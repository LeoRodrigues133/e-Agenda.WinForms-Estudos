namespace eAgenda.WinApp.Compartilhado;
public static class DataGridViewExtensions
{
    public static void ConfigurarGrid(this DataGridView grid)
    {
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;

        grid.BorderStyle = BorderStyle.None;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        grid.ReadOnly = true;
        grid.MultiSelect = false;
        grid.RowHeadersVisible = false;

        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoGenerateColumns = false;

        grid.AllowUserToOrderColumns = false;
        grid.AllowUserToResizeRows = false;
    }

    public static int ObterIdDoGrid(this DataGridView grid)
    {
        if (grid.SelectedRows.Count == 0)
            return - 1;

        object valorSelecionado = grid
                                    .SelectedRows[0]
                                        .Cells[0]
                                            .Value;
        if (valorSelecionado == null)
            return -1;

        return (int)valorSelecionado;
    }
}
