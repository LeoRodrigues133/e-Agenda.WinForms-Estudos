using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloContatos;
public class ControladorContato : ControladorBase
{
    RepositorioContato RepositorioContato;
    ListagemContatoControl ListagemContatos;

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

        Contato contatoSelecionado = ListagemContatos.ObterContatoSelecionado();

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
        Contato contatoSelecionado = ListagemContatos.ObterContatoSelecionado();

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
        if (ListagemContatos == null)
        {
            ListagemContatos = new ListagemContatoControl();

            if (RepositorioContato.SelecionarTodos().Count() <= 0)
                CadastrarContato();
        }

        CarregarContatos();

        return ListagemContatos;
    }

    private void CarregarContatos()
    {
        List<Contato> contatos = RepositorioContato.SelecionarTodos();

        TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {contatos.Count()} registro(s).");

        ListagemContatos.AtualizarContatos(contatos);
    }

    private void CadastrarContato()
    {

        Contato contato1 = new Contato("Leonardo Rodrigues", "(49)9 9807-6236", "lthkrieger@gmail.com", "Ndd", "Dev Junior");
        Contato contato2 = new Contato("Teste", "4999999999", "teste@gmail.com", "teste", "teste");

        RepositorioContato.Cadastrar(contato1);
        RepositorioContato.Cadastrar(contato2);

    }
}