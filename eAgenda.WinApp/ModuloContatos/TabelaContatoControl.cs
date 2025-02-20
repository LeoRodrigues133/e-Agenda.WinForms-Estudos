using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloContatos;
public partial class TabelaContatoControl : UserControl
{
    public TabelaContatoControl()
    {
        InitializeComponent();

        grid.Columns.AddRange(GerarColunas());

        grid.ConfigurarGrid();
        grid.ConfigurarGridZebrado();

    }

    public void AtualizarContatos(List<Contato> contatos)
    {
        grid.Rows.Clear();

        foreach (Contato c in contatos)
            grid.Rows.Add(c.Id, c.Nome.ToCapitalize(), c.Telefone, c.Email, c.Empresa, c.Cargo);

    }

    public int ObterContatoSelecionado()
    {
        return grid.ObterIdDoGrid();
    }

    private DataGridViewColumn[] GerarColunas() => new DataGridViewColumn[]
    {
        new DataGridViewTextBoxColumn{ DataPropertyName = "Id", HeaderText ="Id"},
        new DataGridViewTextBoxColumn{ DataPropertyName = "Nome", HeaderText ="Nome"},
        new DataGridViewTextBoxColumn{ DataPropertyName = "Telefone", HeaderText ="Telefone"},
        new DataGridViewTextBoxColumn{ DataPropertyName = "Email", HeaderText ="Email"},
        new DataGridViewTextBoxColumn{ DataPropertyName = "Empresa", HeaderText ="Empresa"},
        new DataGridViewTextBoxColumn{ DataPropertyName = "Cargo", HeaderText ="Cargo"}
    };

}
