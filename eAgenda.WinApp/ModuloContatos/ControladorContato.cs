using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloContatos;
public class ControladorContato : ControladorBase
{
    RepositorioContato RepositorioContato;
    TabelaContatoControl TabelaContatos;

    public ControladorContato(RepositorioContato repositorioContato)
    {
        RepositorioContato = repositorioContato;
    }

    public override string TipoCadastro => "Contatos";
    public override string TooltipAdicionar => "Cadastrar um novo contato";
    public override string TooltipEditar => "Editar um contato";
    public override string TooltipExcluir => "Deletar um contato";

    public override void Adicionar()
    {

        TelaContatoForm telaContato = new TelaContatoForm();

        DialogResult resultado = telaContato.ShowDialog();

        if (resultado != DialogResult.OK)
        {
            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"Nenhuma informação foi salva.");
            return;
        }

        Contato novoContato = telaContato.Contato;

        RepositorioContato.Cadastrar(novoContato);

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Contato \"{novoContato.Nome}\" cadastrado com sucesso.");

        CarregarContatos();

    }

    public override void Editar()
    {
        TelaContatoForm telaContato = new TelaContatoForm();

        int idSelecionado = TabelaContatos.ObterContatoSelecionado();

        Contato contatoSelecionado = RepositorioContato.SelecionarPorId(idSelecionado);

        if (contatoSelecionado == null)
            return;

        telaContato.Contato = contatoSelecionado;

        DialogResult resultado = telaContato.ShowDialog();

        Contato contatoAtualizado = telaContato.Contato;

        if (resultado != DialogResult.OK)
        {
            TelaPrincipalForm
               .Instancia
                 .AtualizarRodape($"Nenhuma informação foi salva.");
            return;
        }

        RepositorioContato.Editar(contatoSelecionado.Id, contatoAtualizado);

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Contato  \"{contatoAtualizado.Nome}\" atualizado com sucesso.");

        CarregarContatos();
    }

    public override void Excluir()
    {
        int idSelecionado = TabelaContatos.ObterContatoSelecionado();

        Contato contatoSelecionado = RepositorioContato.SelecionarPorId(idSelecionado);

        if (contatoSelecionado == null)
            return;

        DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{contatoSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

        if (resposta != DialogResult.Yes)
            return;

        RepositorioContato.Excluir(contatoSelecionado.Id);

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Contato Excluído com sucesso.");

        CarregarContatos();

    }

    public override UserControl ObterListagem()
    {
        if (TabelaContatos == null)
            TabelaContatos = new TabelaContatoControl();

        CarregarContatos();

        return TabelaContatos;
    }

    private void CarregarContatos()
    {
        List<Contato> contatos = RepositorioContato.SelecionarTodos();

        TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {contatos.Count()} registro(s).");

        TabelaContatos.AtualizarContatos(contatos);
    }


}