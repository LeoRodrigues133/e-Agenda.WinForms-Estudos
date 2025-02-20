namespace eAgenda.WinApp.ModuloTarefa;
public partial class TelaCadastrarSubItens : Form
{
    Tarefa tarefa { get; set; }

    public Tarefa Tarefa
    {
        set
        {
            tarefa = value;

        }
        get => tarefa;
    }

    public List<ItemTarefa> ItensSelecionados
    {
        get => listItensTarefa.Items.Cast<ItemTarefa>().ToList();
    }

    public TelaCadastrarSubItens(Tarefa tarefaSelecionada)
    {
        InitializeComponent();

        lblTituloTarefa.Text = tarefaSelecionada.Titulo;

        foreach(ItemTarefa item in tarefaSelecionada.Itens)
            listItensTarefa.Items.Add(item);

    }

    private void btnAdicionarItem_Click(object sender, EventArgs e)
    {

        if (ItensSelecionados.Any(x => x.Titulo == txtTituloItemTarefa.Text) || txtTituloItemTarefa.Text.Length == 0)
            return;

        ItemTarefa itemTarefa = new ItemTarefa(txtTituloItemTarefa.Text);

        listItensTarefa.Items.Add(itemTarefa);

        txtTituloItemTarefa.Text = string.Empty;
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        return;
    }
}
