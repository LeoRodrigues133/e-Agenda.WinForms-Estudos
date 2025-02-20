using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa;

public class ItemTarefa
{

    public int Id { get; set; }
    public string Titulo { get; set; }
    public bool Concluido { get; set; }
    public Tarefa tarefa { get; set; }

    public ItemTarefa(string titulo)
    {
        Titulo = titulo;
    }

    public void Concluir()
    {
        Concluido = true;
    }

    public void MarcarPendente()
    {
        Concluido = false;
    }

    public override string ToString()
    {

        return Titulo;

    }
}