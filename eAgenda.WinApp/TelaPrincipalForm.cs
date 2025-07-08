using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromissos;
using eAgenda.WinApp.ModuloContatos;
using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp;

public partial class TelaPrincipalForm : Form
{
    ControladorBase controlador;
    RepositorioContato repositorioContato;
    RepositorioCompromisso repositorioCompromisso;
    RepositorioTarefa repositorioTarefa;

    public static TelaPrincipalForm Instancia { get; private set; }

    public TelaPrincipalForm()
    {
        InitializeComponent();

        lblTipoCadastro.Text = string.Empty;

        repositorioContato = new RepositorioContato();
        repositorioCompromisso = new RepositorioCompromisso();
        repositorioTarefa = new RepositorioTarefa();

        Instancia = this;
        IniciarRegistros();

    }

    public void AtualizarRodape(string texto)
    {
        toolStripLabelPrincipal.Text = texto;
    }

    private void contatosMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorContato(repositorioContato);

        ConfigurarTelaPrincipal();

    }
    private void compromissosMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

        ConfigurarTelaPrincipal();
    }
    private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorTarefa(repositorioTarefa);

        ConfigurarTelaPrincipal();
    }

    private void ConfigurarTelaPrincipal()
    {
        lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

        ConfigurarToolBox(controlador);
        ConfigurarListagem(controlador);
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        controlador.Adicionar();

    }
    private void btnEditar_Click(object sender, EventArgs e)
    {
        controlador.Editar();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        controlador.Excluir();
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
        if (controlador is IControladorFiltravel controladorFiltravel)
            controladorFiltravel.Filtrar();
    }
    private void btnAdicionarItem_Click(object sender, EventArgs e)
    {
        if (controlador is IControladorAdicionavelSubItens controladorAdicionavel)
            controladorAdicionavel.AdicionarItem();
    }

    private void btnAtualizarTask_Click(object sender, EventArgs e)
    {
        if (controlador is IControladorAdicionavelSubItens controladorAtualizavel)
            controladorAtualizavel.AtualizarItem();
    }

    private void ConfigurarListagem(ControladorBase controladorSelecionado)
    {
        //UserControl listagemControls = controladorSelecionado.ObterListagem(); // Utilizando LisyBox
        UserControl TabelaControl = controladorSelecionado.ObterListagem();

        //listagemControl.Dock = DockStyle.Fill; // Utilizando ListBox
        TabelaControl.Dock = DockStyle.Fill;

        pnlRegistros.Controls.Clear();
        //pnlRegistros.Controls.Add(listagemControl); // Utilizando ListBox
        pnlRegistros.Controls.Add(TabelaControl);
    }

    private void ConfigurarToolTip(ControladorBase controladorSelecionado)
    {

        btnAdicionar.ToolTipText = controladorSelecionado.TooltipAdicionar;
        btnEditar.ToolTipText = controladorSelecionado.TooltipEditar;
        btnExcluir.ToolTipText = controladorSelecionado.TooltipExcluir;
    }

    private void ConfigurarToolBox(ControladorBase controladorSelecionado)
    {
        btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
        btnEditar.Enabled = controladorSelecionado is ControladorBase;
        btnExcluir.Enabled = controladorSelecionado is ControladorBase;

        btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;

        btnAdicionarItem.Enabled = controladorSelecionado is IControladorAdicionavelSubItens;
        btnAtualizarTask.Enabled = controladorSelecionado is IControladorAdicionavelSubItens;

        ConfigurarToolTip(controladorSelecionado);
    }

    private void IniciarRegistros()
    {
        List<Contato> Contatos = new List<Contato>(){
        new Contato(
            "teste",
            "(49)9 9999-9999",
            "teste@gmail.com",
            "teste",
            "teste"

            )
        };

        repositorioContato.CadastrarMultiplosRegistros(Contatos);

        List<Compromisso> Compromissos = new List<Compromisso>()
{
    new Compromisso(
        "REUNIÃO DE PRANEJAMENTO",
        new DateTime(2025, 2, 14),
        new TimeSpan(10, 0, 0),
        new TimeSpan(11, 30, 0),
        false,
        null,
        tipoCompromissoEnum.Remoto,
        "Discord"

    ),

    };
        repositorioCompromisso.CadastrarMultiplosRegistros(Compromissos);

        List<Tarefa> tarefas = new List<Tarefa>()
    {
        new Tarefa(
            "Tarefa Teste",
            prioridadeEnum.Normal
            )
    };
        repositorioTarefa.CadastrarMultiplosRegistros(tarefas);
    }


}
