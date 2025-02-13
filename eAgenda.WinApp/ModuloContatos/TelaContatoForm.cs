namespace eAgenda.WinApp.ModuloContatos;
public partial class TelaContatoForm : Form
{

    Contato contato { get; set; }

    public Contato Contato
    {
        set
        {
            txtId.Text = value.Id.ToString();
            txtNome.Text = value.Nome;
            txtTelefone.Text = value.Telefone;
            txtEmail.Text = value.Email;
            txtEmpresa.Text = value.Empresa;
            txtCargo.Text = value.Cargo;
        }

        get => contato;
    }

    public TelaContatoForm()
    {
        InitializeComponent();

    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        string nome = txtNome.Text;
        string telefone = txtTelefone.Text;
        string email = txtEmail.Text;
        string empresa = txtEmpresa.Text;
        string cargo = txtCargo.Text;

        contato = new Contato(nome, telefone, email, empresa, cargo);

        List<string> erros = contato.Validar();

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

            DialogResult = DialogResult.None;
        }
    }
}
