using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromissos;
using eAgenda.WinApp.ModuloContatos;

namespace eAgenda.WinApp;

public partial class TelaPrincipalForm : Form
{
    ControladorBase controlador;
    RepositorioContato repositorioContato;
    RepositorioCompromisso repositorioCompromisso;

    public static TelaPrincipalForm Instancia { get; private set; }

    public TelaPrincipalForm()
    {
        InitializeComponent();

        lblTipoCadastro.Text = string.Empty;

        repositorioContato = new RepositorioContato();
        repositorioCompromisso = new RepositorioCompromisso();
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

        lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

        ConfigurarToolTip(controlador);
        ConfigurarListagem(controlador);

    }
    private void compromissosMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

        lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

        ConfigurarToolTip(controlador);
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

    private void ConfigurarListagem(ControladorBase controladorSelecionado)
    {
        UserControl listagemContatos = controladorSelecionado.ObterListagem();

        listagemContatos.Dock = DockStyle.Fill;

        pnlRegistros.Controls.Clear();
        pnlRegistros.Controls.Add(listagemContatos);
    }

    private void ConfigurarToolTip(ControladorBase controladorSelecionado)
    {
        if (controladorSelecionado != null)
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            if (controlador is IControladorFiltravel)
            {
                btnFiltrar.Visible = true;
                btnFiltrar.Enabled = true;
            }
            else
            {
                btnFiltrar.Visible = false;
                btnFiltrar.Enabled = false;
            }

            btnAdicionar.ToolTipText = controladorSelecionado.TooltipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.TooltipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.TooltipExcluir;
        }

    }

    private void IniciarRegistros()
    {
        List<Contato> Contatos = new List<Contato>(){
         new Contato(
             "Leonardo Rodrigues",
             "(49)9 9807-6236",
             "lthkrieger@gmail.com",
             "Ndd",
             "Dev Junior"

             ),

        new Contato(
            "Teste",
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
        "Reunião de Planejamento",
        new DateTime(2025, 2, 14),
        new TimeSpan(10, 0, 0),
        new TimeSpan(11, 30, 0),
        false,null,"Discord"

    ),

    new Compromisso(
        "Almoço com Cliente",
        new DateTime(2025, 2, 15),
        new TimeSpan(12, 30, 0),
        new TimeSpan(14, 0, 0),
        true,repositorioContato.SelecionarPorId(2),
        "Hamgourmet Hamburgueria"
    ),

    new Compromisso(
        "Apresentação de Projeto",
        new DateTime(2025, 2, 16),
        new TimeSpan(15, 0, 0),
        new TimeSpan(16, 30, 0),
        true,
        repositorioContato.SelecionarPorId(1),
        "Auditório da Empresa"
    )
    };
        repositorioCompromisso.CadastrarMultiplosRegistros(Compromissos);
    }

}
