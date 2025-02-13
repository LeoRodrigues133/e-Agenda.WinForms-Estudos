using eAgenda.WinApp.Compartilhado;
using static eAgenda.WinApp.ModuloCompromissos.ControladorCompromisso;

namespace eAgenda.WinApp.ModuloCompromissos;
public class RepositorioCompromisso : RepositorioBase<Compromisso>
{
    public List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
    {
        return registros.FindAll(c => c.Data >= dataInicio && c.Data <= dataTermino); 
    }

    public List<Compromisso> SelecionarCompromissosFuturos()
    {
        return registros.FindAll(c => c.Data >= DateTime.Now || (c.Data == DateTime.Now && c.HoraInicio < DateTime.Now.TimeOfDay));
    }

    public List<Compromisso> SelecionarCompromissosPassados()
    {
        return registros.FindAll(c => c.Data < DateTime.Now || (c.Data == DateTime.Now && c.HoraTermino < DateTime.Now.TimeOfDay));
    }
}
