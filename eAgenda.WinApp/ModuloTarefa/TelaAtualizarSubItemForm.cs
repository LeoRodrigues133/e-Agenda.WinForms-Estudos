namespace eAgenda.WinApp.ModuloTarefa;
public partial class TelaAtualizarSubItemForm : Form
{
    Tarefa tarefa { get; set; }

    public List<ItemTarefa> ItensPendentes
    {
        get
        {
            return chklistItensTarefa.Items
                .Cast<ItemTarefa>()
                .Except(ItensConcluidos)
                .ToList();
        }
    }

    public List<ItemTarefa> ItensConcluidos
    {
        get
        {
            return chklistItensTarefa.CheckedItems
                .Cast<ItemTarefa>().ToList();
        }
    }

    public TelaAtualizarSubItemForm(Tarefa tarefaSelecionada)
    {
        InitializeComponent();

        lblTituloTarefa.Text = tarefaSelecionada.Titulo;

        CarregarItensSelecionados(tarefaSelecionada);
    }

    private void CarregarItensSelecionados(Tarefa tarefaSelecionada)
    {
        int i = 0;

        foreach (ItemTarefa item in tarefaSelecionada.Itens)
        {
            chklistItensTarefa.Items.Add(item);

            if (item.Concluido)
                chklistItensTarefa.SetItemChecked(i, true);

            i++;
        }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        
    }
}
