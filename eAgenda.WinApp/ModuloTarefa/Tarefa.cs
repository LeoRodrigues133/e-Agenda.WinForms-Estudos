using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa;
public class Tarefa : EntidadeBase
{
    public string Titulo { get; set; }
    public prioridadeEnum Prioridade { get; set; }
    public DateTime DataDeCriacao { get; set; }
    public DateTime DataDeConclusao { get; set; }
    public List<ItemTarefa> Itens { get; set; }
    public decimal PercentualConcluido
    {
        get
        {
            if (Itens.Count == 0)
                return 0;

            int Concluidos = Itens.Count(i => i.Concluido);

            decimal percentualBase = (Concluidos / (decimal)Itens.Count) * 100;

            return Math.Round(percentualBase, 2);
        }
    }

    public Tarefa(string titulo, prioridadeEnum prioridade)
    {
        Titulo = titulo;
        Prioridade = prioridade;
        DataDeCriacao = DateTime.Now;
        DataDeConclusao = DateTime.MinValue;

        Itens = new List<ItemTarefa>();
    }
     
    public bool AdicionarItem(ItemTarefa item)
    {
        if(Itens.Exists(i => i.Titulo == item.Titulo))
            return false;

        item.tarefa = this;
        Itens.Add(item);

        DataDeConclusao = DateTime.MinValue;

        return true;
    }
    public void ConcluirItem(ItemTarefa item)
    {
        ItemTarefa itemTarefa = Itens.Find(i => i.Titulo == item.Titulo);

        if (itemTarefa == null)
            return;

        itemTarefa.Concluir();

        if (Itens.All(i => i.Concluido))
            DataDeConclusao = DateTime.Now;
    }

    public void MarcarPendente(ItemTarefa item)
    {
        ItemTarefa itemTarefa = Itens.Find(i => i.Titulo == item.Titulo);

        if (itemTarefa == null)
            return;

        itemTarefa.MarcarPendente();
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        Tarefa Atualizado = (Tarefa)novoRegistro;

        Titulo = Atualizado.Titulo;
        Prioridade = Atualizado.Prioridade;

    }

    public override List<string> Validar()
    {
        List<string> erros = new List<string>();

        if (string.IsNullOrEmpty(Titulo.Trim()))
            erros.Add($"O campo \"titulo\" é obrigatório.");

        return erros;
    }
}
