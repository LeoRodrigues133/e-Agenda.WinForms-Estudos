namespace eAgenda.WinApp.Compartilhado;
public interface IControladorAdicionavelSubItens
{
    string ToolStripAdicionarItem { get; }
    string ToolStripAtualizarItem { get; }

    void AdicionarItem();
    void AtualizarItem();
}
