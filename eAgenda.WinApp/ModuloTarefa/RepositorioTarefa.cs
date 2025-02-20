using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa;
public class RepositorioTarefa : RepositorioBase<Tarefa>
{
    public void AdicionarItem(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
    {
        foreach (ItemTarefa item in itens)
            tarefaSelecionada.Itens.Add(item);
    }

    public void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensPendentes, List<ItemTarefa> itensConcluidos)
    {
        foreach (ItemTarefa i in itensPendentes)
            tarefaSelecionada.MarcarPendente(i);

        foreach (ItemTarefa i in itensConcluidos)
            tarefaSelecionada.ConcluirItem(i);
    }
}
