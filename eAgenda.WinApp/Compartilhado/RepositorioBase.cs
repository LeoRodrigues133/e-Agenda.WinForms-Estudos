namespace eAgenda.WinApp.Compartilhado;
public abstract class RepositorioBase<T> where T : EntidadeBase
{
    protected List<T> registros = new List<T>();

    protected int contadorId = 1;

    public void Cadastrar(T novoRegistro)
    {
        novoRegistro.Id = contadorId++;

        registros.Add(novoRegistro);
    }

    public bool Editar(int id, T entidade)
    {
        entidade.Id = id;

        foreach (T registro in registros)
            if (registro == null)
                continue;

            else if (registro.Id == id)
            {
                registro.AtualizarRegistro(entidade);
                return true;
            }

        return false;
    }

    public bool Excluir(int id)
    {
        foreach (T registro in registros)
            if (registro == null)
                continue;

            else if (registro.Id == id)
            {
                registros.Remove(registro);
                return true;
            }

        return false;
    }
    public List<T> SelecionarTodos()
    {
        return registros;
    }

    public T SelecionarPorId(int id)
    {
        foreach (T registro in registros)
            if (registro == null)
                continue;

            else if (registro.Id == id)
                return registro;

        return null;
    }

    public bool Existe(int id)
    {
        foreach (T registro in registros)
            if (registro == null)
                continue;

            else if (registro.Id == id)
                return true;

        return false;
    }
}
