﻿using eAgenda.WinApp.ModuloContatos;

namespace eAgenda.WinApp.Compartilhado;
public abstract class RepositorioBase<T> where T : EntidadeBase
{
    protected List<T> registros = new List<T>();

    protected int contadorId = 1;

    public void CadastrarMultiplosRegistros(List<T> registros)
    {
        foreach(T entidade in registros) 
            Cadastrar(entidade);
    }

    public void Cadastrar(T novoRegistro)
    {
        novoRegistro.Id = contadorId++;

        registros.Add(novoRegistro);
    }

    public bool Editar(int id, T entidade)
    {
        T registro = SelecionarPorId(id);

        if (registro == null)
            return false;

        registro.AtualizarRegistro(entidade);

        return true;
    }

    public bool Excluir(int id)
    {
        return registros.Remove(SelecionarPorId(id));
    }

    public List<T> SelecionarTodos()
    {
        return registros;
    }

    public T SelecionarPorId(int id)
    {
        return registros.Find(x => x.Id == id)!;
    }

    public bool Existe(int id)
    {
        return registros.Any(x => x.Id == id);
    }
}
