using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContatos;

namespace eAgenda.WinApp.ModuloTarefa;
public class ControladorTarefa : ControladorBase, IControladorAdicionavelSubItens
{
    TabelaTarefaControl TabelaTarefa;

    RepositorioTarefa RepositorioTarefa;

    public override string TipoCadastro => "Tarefas";

    public override string TooltipAdicionar => "Cadastras um nova tarefa";

    public override string TooltipEditar => "Editar uma tarefa";

    public override string TooltipExcluir => "Excluir uma tarefa";

    public string ToolStripAdicionarItem => "Adicionar item à tarefa";

    public string ToolStripAtualizarItem => "Atualizar item da tarefa";

    public ControladorTarefa(RepositorioTarefa repositorioTarefa)
    {
        RepositorioTarefa = repositorioTarefa;
    }

    public override void Adicionar()
    {
        TelaTarefaForm telaTarefa = new TelaTarefaForm();

        DialogResult resultado = telaTarefa.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        Tarefa novaTarefa = telaTarefa.Tarefa;

        RepositorioTarefa.Cadastrar(novaTarefa);

        CarregarTarefas();

        TelaPrincipalForm
            .Instancia
                .AtualizarRodape($"Tarefa \"{novaTarefa.Titulo}\" cadastrado sucesso.");

    }

    public override void Editar()
    {
        TelaTarefaForm telaTarefa = new TelaTarefaForm();

        int idSelecionado = TabelaTarefa.ObterIdSelecionado();

        Tarefa tarefaSelecionada =
            RepositorioTarefa.SelecionarPorId(idSelecionado);

        if (tarefaSelecionada == null)
            return;

        telaTarefa.Tarefa = tarefaSelecionada;

        DialogResult resultado = telaTarefa.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        Tarefa tarefaEditada = telaTarefa.Tarefa;

        RepositorioTarefa.Editar(tarefaSelecionada.Id, tarefaEditada);

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Tarefa \"{tarefaSelecionada.Titulo}\" atualizada com sucesso.");

        CarregarTarefas();

    }

    public override void Excluir()
    {
        int idSelecionado = TabelaTarefa.ObterIdSelecionado();

        Tarefa tarefaSelecionado = RepositorioTarefa.SelecionarPorId(idSelecionado);

        if (tarefaSelecionado == null)
            return;

        DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{tarefaSelecionado.Titulo}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

        if (resposta != DialogResult.Yes)
            return;

        RepositorioTarefa.Excluir(tarefaSelecionado.Id);

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Tarefa excluída com sucesso.");

        CarregarTarefas();
    }

    public override UserControl ObterListagem()
    {
        if (TabelaTarefa == null)
            TabelaTarefa = new TabelaTarefaControl();

        CarregarTarefas();

        return TabelaTarefa;
    }

    private void CarregarTarefas()
    {
        List<Tarefa> tarefas = RepositorioTarefa.SelecionarTodos();

        TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tarefas.Count()} registro(s).");

        TabelaTarefa.AtualizarRegistros(tarefas);
    }

    public void AdicionarItem()
    {

        int idSelecionado = TabelaTarefa.ObterIdSelecionado();

        Tarefa tarefaSelecionada =
            RepositorioTarefa.SelecionarPorId(idSelecionado);

        if (tarefaSelecionada == null)
            return;

        TelaCadastrarSubItens telaTarefa = new TelaCadastrarSubItens(tarefaSelecionada);

        DialogResult resultado = telaTarefa.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        List<ItemTarefa> itens = telaTarefa.ItensSelecionados;

        List<ItemTarefa> novosItens = itens
            .Where(n => tarefaSelecionada.Itens.All(e => e.Titulo != n.Titulo)).ToList();

        RepositorioTarefa.AdicionarItem(tarefaSelecionada, novosItens);

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Tarefa \"{tarefaSelecionada.Titulo}\" atualizada com sucesso.");

        CarregarTarefas();
    }

    public void AtualizarItem()
    {
        int idSelecionado = TabelaTarefa.ObterIdSelecionado();

        Tarefa tarefaSelecionada =
            RepositorioTarefa.SelecionarPorId(idSelecionado);

        if (tarefaSelecionada == null)
            return;

        TelaAtualizarSubItemForm telaTarefa = new TelaAtualizarSubItemForm(tarefaSelecionada);

        DialogResult resultado = telaTarefa.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        List<ItemTarefa> itensPendentes = telaTarefa.ItensPendentes;
        List<ItemTarefa> itensConcluidos = telaTarefa.ItensConcluidos;

        RepositorioTarefa.AtualizarItens(tarefaSelecionada, itensPendentes, itensConcluidos);

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"Tarefa \"{tarefaSelecionada.Titulo}\" atualizada com sucesso.");

        CarregarTarefas();
    }
}
