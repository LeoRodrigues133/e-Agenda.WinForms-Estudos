using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContatos;

namespace eAgenda.WinApp.ModuloCompromissos;
public class ControladorCompromisso : ControladorBase, IControladorFiltravel
{
    RepositorioCompromisso RepositorioCompromisso { get; set; }
    RepositorioContato RepositorioContato { get; set; }
    ListagemCompromissoControl ListagemCompromisso { get; set; }
    public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
    {
        RepositorioCompromisso = repositorioCompromisso;
        RepositorioContato = repositorioContato;
    }

    public override string TipoCadastro => "Compromissos";

    public override string TooltipAdicionar => "Cadastrar um novo compromisso";

    public override string TooltipEditar => "Editar um compromisso";

    public override string TooltipExcluir => "Excluir um compromisso";

    public string ToolTipFiltrar => "Filtrar compromissos";

    public override void Adicionar()
    {
        TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

        List<Contato> contatosCadastrados = RepositorioContato.SelecionarTodos();

        telaCompromisso.CarregarContatos(contatosCadastrados);

        DialogResult Resultado = telaCompromisso.ShowDialog();

        if (Resultado != DialogResult.OK)
        {
            TelaPrincipalForm
                .Instancia
                    .AtualizarRodape($"Nenhuma informação foi salva.");
            return;
        }

        Compromisso novoCompromisso = telaCompromisso.Compromisso;

        RepositorioCompromisso.Cadastrar(novoCompromisso);

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Compromisso \"{novoCompromisso.Assunto}\" cadastrado com sucesso.");

        CarregarCompromissos();

    }

    public override void Editar()
    {
        TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

        Compromisso compromissoSelecionado = ListagemCompromisso.ObterCompromisso();

        if (compromissoSelecionado == null)
            return;

        telaCompromisso.Compromisso = compromissoSelecionado;

        Compromisso compromissoAtualizado = telaCompromisso.Compromisso;

        DialogResult Resultado = telaCompromisso.ShowDialog();

        if (Resultado != DialogResult.OK)
        {
            TelaPrincipalForm
              .Instancia
                .AtualizarRodape($"Nenhuma informação foi salva.");
            return;
        }

        RepositorioCompromisso.Editar(compromissoSelecionado.Id, compromissoAtualizado);

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Compromisso \"{compromissoSelecionado.Assunto}\" foi atualizado com sucesso.");

        CarregarCompromissos();
    }

    public override void Excluir()
    {
        Compromisso compromissoSelecionado = ListagemCompromisso.ObterCompromisso();

        if (compromissoSelecionado == null)
            return;

        DialogResult resposta =
            MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{compromissoSelecionado.Assunto}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Compromisso excluído com sucesso");

        CarregarCompromissos();

    }

    public void Filtrar()
    {
        TelaFiltroCompromissoForm telaFiltroCompromisso = new TelaFiltroCompromissoForm();

        DialogResult resultado = telaFiltroCompromisso.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        tipoFiltroCompromissoEnum filtroSelecionado = telaFiltroCompromisso.filtroSelecionado;


        List<Compromisso> compromissosSelecionados = new List<Compromisso>();

        switch (filtroSelecionado)
        {

            case tipoFiltroCompromissoEnum.Passados:
                {
                    compromissosSelecionados = RepositorioCompromisso.SelecionarCompromissosPassados();

                    ListagemCompromisso.AtualizarCompromissos(compromissosSelecionados);
                    break;
                }

            case tipoFiltroCompromissoEnum.Fututos:
                {
                    compromissosSelecionados = RepositorioCompromisso.SelecionarCompromissosFuturos();

                    ListagemCompromisso.AtualizarCompromissos(compromissosSelecionados);

                    break;
                }

            case tipoFiltroCompromissoEnum.Periodo:
                {
                    compromissosSelecionados = RepositorioCompromisso.SelecionarCompromissosPorPeriodo(telaFiltroCompromisso.FiltroInicio, telaFiltroCompromisso.FiltroTermino);

                    ListagemCompromisso.AtualizarCompromissos(compromissosSelecionados);

                    break;
                }

            default:
                {
                    CarregarCompromissos();

                    break;
                }
        }
    }

    private void CarregarCompromissos()
    {
        List<Compromisso> compromissos = RepositorioCompromisso.SelecionarTodos();

        TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count()} registro(s).");

        ListagemCompromisso.AtualizarCompromissos(compromissos);
    }

    public override UserControl ObterListagem()
    {
        if (ListagemCompromisso == null)
            ListagemCompromisso = new ListagemCompromissoControl();

        CarregarCompromissos();

        return ListagemCompromisso;
    }

}
