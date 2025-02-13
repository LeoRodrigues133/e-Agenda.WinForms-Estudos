namespace eAgenda.WinApp.ModuloContatos;
public partial class ListagemContatoControl : UserControl
{
    public ListagemContatoControl()
    {
        InitializeComponent();

    }

    public void AtualizarContatos(List<Contato> contatos)
    {
        listContato.Items.Clear();

        foreach (Contato contato in contatos)
            listContato.Items.Add(contato);
    }

    public Contato ObterContatoSelecionado()
    {
        if (listContato.SelectedItem == null)
            return null;

        return (Contato)listContato.SelectedItem;
    }
}
