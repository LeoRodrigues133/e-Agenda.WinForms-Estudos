
using eAgenda.WinApp.ModuloContatos;

namespace eAgenda.WinApp.Compartilhado;
public abstract class ControladorBase
{
    public abstract string TipoCadastro { get; }

    public abstract string TooltipAdicionar { get; }
    public abstract string TooltipEditar { get; }
    public abstract string TooltipExcluir { get; }

    public abstract UserControl ObterListagem();

    public abstract void Adicionar() ;
    public abstract void Editar();
    public abstract void Excluir();
}
