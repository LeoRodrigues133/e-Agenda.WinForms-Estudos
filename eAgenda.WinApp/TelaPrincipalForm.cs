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
        if(controlador is IControladorFiltravel controladorFiltravel)
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

}
