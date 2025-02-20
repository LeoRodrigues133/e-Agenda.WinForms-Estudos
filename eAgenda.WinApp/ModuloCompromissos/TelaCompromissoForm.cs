using eAgenda.WinApp.ModuloContatos;

namespace eAgenda.WinApp.ModuloCompromissos;
public partial class TelaCompromissoForm : Form
{
    Compromisso compromisso { get; set; }

    public Compromisso Compromisso
    {
        set
        {
            txtRemoto.Text = value.Local;
            txtAssunto.Text = value.Assunto;
            txtId.Text = value.Id.ToString();
            txtPresencial.Text = value.Local;
            dtData.Text = value.Data.ToString();
            chkboxContato.Checked = value.MarcarContato;
            dtHoraInicio.Text = value.HoraInicio.ToString();
            cmbBoxContato.SelectedItem = value.MarcarContato;
            dtHoraTermino.Text = value.HoraTermino.ToString();
            rdbPresencial.Checked = value.TipoCompromisso == tipoCompromissoEnum.Remoto;

        }
        get => compromisso;
    }

    public TelaCompromissoForm()
    {
        InitializeComponent();
        txtPresencial.Enabled = false;
    }

    public void CarregarContatos(List<Contato> contatos)
    {
        cmbBoxContato.Items.Clear();

        foreach (Contato contato in contatos)
            cmbBoxContato.Items.Add(contato);
    }

    private void chkboxContato_CheckedChanged(object sender, EventArgs e)
    {
        if (chkboxContato.Checked)
            cmbBoxContato.Enabled = true;
        else
        {
            cmbBoxContato.Enabled = false;
            cmbBoxContato.SelectedItem = null;
        }
    }

    private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
    {

        if (rdbPresencial.Checked)
        {
            txtRemoto.Enabled = false;
            txtPresencial.Enabled = true;
            txtRemoto.Text = string.Empty;
        }
        else
        {
            txtRemoto.Enabled = true;
            txtPresencial.Enabled = false;
            txtPresencial.Text = string.Empty;
        }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        string assunto = !string.IsNullOrEmpty(txtAssunto.Text) ? txtAssunto.Text : "(Sem assunto)";
        DateTime data = dtData.Value;
        TimeSpan inicio = dtHoraInicio.Value.TimeOfDay;
        TimeSpan termino = dtHoraTermino.Value.TimeOfDay;
        bool marcarContato = chkboxContato.Checked;
        tipoCompromissoEnum tipoCompromisso = rdbPresencial.Checked ? tipoCompromissoEnum.Presencial : tipoCompromissoEnum.Remoto;
        Contato? contato = (Contato)cmbBoxContato.SelectedItem!;

        string local =
            !string.IsNullOrEmpty(txtRemoto.Text) ? txtRemoto.Text
            : (!string.IsNullOrEmpty(txtPresencial.Text.Trim()) ? txtPresencial.Text
             : "(Sem local definido)");

        compromisso = new Compromisso(assunto, data, inicio, termino, marcarContato, contato, tipoCompromisso, local);

        List<string> erros = compromisso.Validar();

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

            DialogResult = DialogResult.None;
        }

    }

}
