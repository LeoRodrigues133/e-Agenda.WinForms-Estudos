
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCompromissos;
public partial class TabelaCompromissoControl : UserControl
{
    public TabelaCompromissoControl()
    {
        InitializeComponent();

        grid.Columns.AddRange(GerarColunas());

        grid.ConfigurarGrid();
        grid.ConfigurarGridZebrado();
    }

    public void AtualizarCompromissos(List<Compromisso> compromissos)
    {
        grid.Rows.Clear();

        foreach(Compromisso c in compromissos)
            grid.Rows.Add(c.Id, c.Assunto.ToCapitalize(), c.Data, c.HoraInicio, c.HoraTermino, c.ContatoMarcado, c.TipoCompromisso, c.Local);
    }

    public int ObterCompromisso()
    {
        return grid.ObterIdDoGrid();
    }

    private DataGridViewColumn[] GerarColunas() => new DataGridViewColumn[]
        {
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName= "Assunto", HeaderText = "Assunto" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
            new DataGridViewTextBoxColumn { DataPropertyName = "HoraInicio", HeaderText= "Hora de Início" },
            new DataGridViewTextBoxColumn { DataPropertyName = "HoraTermino", HeaderText= "Hora de Término" },
            new DataGridViewTextBoxColumn { DataPropertyName = "ContatoMarcado", HeaderText = "Contato" },
            new DataGridViewTextBoxColumn { DataPropertyName = "TipoCompromisso", HeaderText = "Tipo de Compromisso" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Local", HeaderText = "Local" }
        };

}
