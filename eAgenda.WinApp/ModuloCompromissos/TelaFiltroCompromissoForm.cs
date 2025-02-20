namespace eAgenda.WinApp.ModuloCompromissos;
public partial class TelaFiltroCompromissoForm : Form
{
    public tipoFiltroCompromissoEnum filtroSelecionado { get; private set; }
    public DateTime FiltroInicio { get => dtFiltroInicio.Value; }
    public DateTime FiltroTermino { get => dtFiltroTermino.Value; }


    public TelaFiltroCompromissoForm()
    {
        InitializeComponent();

    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        if (rdbTodosOsCompromissos.Checked)
            filtroSelecionado = tipoFiltroCompromissoEnum.Todos;

        else if (rdbCompromissosFuturos.Checked)
            filtroSelecionado = tipoFiltroCompromissoEnum.Fututos;

        else if (rdbCompromissosPassados.Checked)
            filtroSelecionado = tipoFiltroCompromissoEnum.Passados;

        else if (rdbCompromissosPorPeriodo.Checked)
            filtroSelecionado = tipoFiltroCompromissoEnum.Periodo;
    }

    private void rdbCompromissosPorPeriodo_CheckedChanged(object sender, EventArgs e)
    {
        if (rdbCompromissosPorPeriodo.Checked)
        {
            dtFiltroInicio.Enabled = true;
            dtFiltroTermino.Enabled = true;
        }
        else
        {
            dtFiltroInicio.Enabled = false;
            dtFiltroTermino.Enabled = false;
        }
    }

}
