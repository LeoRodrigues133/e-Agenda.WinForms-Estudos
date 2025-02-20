namespace eAgenda.WinApp.ModuloTarefa;
public partial class TabelaTarefaControl : UserControl
{
    public TabelaTarefaControl()
    {
        InitializeComponent();

        ConfigurarColunas();
        ConfigurarListView();
    }

    public void AtualizarRegistros(List<Tarefa> tarefas)
    {
        listTarefas.Items.Clear();
        listTarefas.Groups.Clear();

        var tarefasAgrupadas = tarefas.GroupBy(t => t.Prioridade);

        foreach (var grupo in tarefasAgrupadas)
        {
            ListViewGroup separadorDePrioridade =
                new ListViewGroup($"Prioridade {grupo.Key}", HorizontalAlignment.Left);

            listTarefas.Groups.Add(separadorDePrioridade);

            foreach (Tarefa t in grupo)
            {
                ListViewItem item = new ListViewItem(t.Id.ToString()) { Tag = t };

                item.SubItems.Add(t.Titulo);
                item.SubItems.Add(t.DataDeCriacao.ToShortDateString());
                item.SubItems.Add(t.DataDeConclusao.ToShortDateString());
                item.SubItems.Add(t.Prioridade.ToString());
                item.SubItems.Add(t.PercentualConcluido.ToString() + "%");

                item.Group = separadorDePrioridade;

                listTarefas.Items.Add(item);
            }
        }
    }

    public int ObterIdSelecionado()
    {
        if (listTarefas.SelectedItems.Count == 0)
            return -1;

        var tarefaSelecionada = (Tarefa)listTarefas.SelectedItems[0].Tag;

        return tarefaSelecionada.Id;

    }

    private void ConfigurarListView()
    {
        listTarefas.MultiSelect = false;
        listTarefas.FullRowSelect = true;
        listTarefas.GridLines = true;

        listTarefas.View = View.Details;
    }

    private void ConfigurarColunas()
    {
        var colunas = new ColumnHeader[]
        {
            new ColumnHeader(){ Text = "Id" , Width = 80},
            new ColumnHeader(){ Text = "Título", Width = 200 },
            new ColumnHeader(){ Text = "Data de criação", Width = 150},
            new ColumnHeader(){ Text = "Data de conclusão", Width = 150},
            new ColumnHeader(){ Text = "Prioridade", Width = 150},
            new ColumnHeader(){ Text = "Percentual concluído", Width = 80}
        };

        listTarefas.Columns.AddRange(colunas);
    }
}
