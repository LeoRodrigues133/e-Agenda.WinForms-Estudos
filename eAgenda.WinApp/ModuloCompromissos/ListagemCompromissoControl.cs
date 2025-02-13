namespace eAgenda.WinApp.ModuloCompromissos;
public partial class ListagemCompromissoControl : UserControl
{
    public ListagemCompromissoControl()
    {
        InitializeComponent();
    }

    public void AtualizarCompromissos(List<Compromisso> compromissos)
    {
        listCompromissos.Items.Clear();

        foreach(Compromisso compromisso in compromissos)
            listCompromissos.Items.Add(compromisso);
    }

    public Compromisso ObterCompromisso()
    {
        if (listCompromissos.SelectedItem == null)
            return null;

        return (Compromisso)listCompromissos.SelectedItem;

    }
}
