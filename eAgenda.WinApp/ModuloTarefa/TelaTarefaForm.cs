namespace eAgenda.WinApp.ModuloTarefa;
public partial class TelaTarefaForm : Form
{
    Tarefa tarefa { get; set; }
    public Tarefa Tarefa
    {
        set
        {
            txtId.Text = value.Id.ToString();
            txtTitulo.Text = value.Titulo;

            cmbPrioridade.SelectedItem = value.Prioridade;
        }
        get => tarefa;
    }

    public TelaTarefaForm()
    {
        InitializeComponent();

        CarregarPrioridades();
    }

    private void CarregarPrioridades()
    {
        cmbPrioridade.DataSource = Enum.GetValues(typeof(prioridadeEnum));

        /*
         Array prioridades = Enum.GetValues(typeof(prioridadeEnum));

        foreach(var p in prioridades)
            cmbPrioridade.Items.Add(p);
         */
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        string titulo = txtTitulo.Text;
        prioridadeEnum prioridade = (prioridadeEnum)cmbPrioridade.SelectedItem;

        tarefa = new Tarefa(titulo, prioridade);
    }
}
