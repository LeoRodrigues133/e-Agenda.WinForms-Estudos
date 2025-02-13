namespace eAgenda.WinApp.ModuloContatos;

partial class TelaContatoForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        txtNome = new TextBox();
        label2 = new Label();
        label3 = new Label();
        txtEmail = new TextBox();
        label4 = new Label();
        txtEmpresa = new TextBox();
        btnCancelar = new Button();
        btnSalvar = new Button();
        label5 = new Label();
        txtCargo = new TextBox();
        label6 = new Label();
        txtId = new TextBox();
        txtTelefone = new MaskedTextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(41, 91);
        label1.Name = "label1";
        label1.Size = new Size(53, 20);
        label1.TabIndex = 2;
        label1.Text = "&Nome:";
        // 
        // txtNome
        // 
        txtNome.Location = new Point(43, 114);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(382, 27);
        txtNome.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(41, 144);
        label2.Name = "label2";
        label2.Size = new Size(69, 20);
        label2.TabIndex = 4;
        label2.Text = "&Telefone:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(41, 197);
        label3.Name = "label3";
        label3.Size = new Size(49, 20);
        label3.TabIndex = 6;
        label3.Text = "&Email:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(43, 220);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(382, 27);
        txtEmail.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(41, 250);
        label4.Name = "label4";
        label4.Size = new Size(69, 20);
        label4.TabIndex = 8;
        label4.Text = "Em&presa:";
        // 
        // txtEmpresa
        // 
        txtEmpresa.Location = new Point(43, 273);
        txtEmpresa.Name = "txtEmpresa";
        txtEmpresa.Size = new Size(188, 27);
        txtEmpresa.TabIndex = 9;
        // 
        // btnCancelar
        // 
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(236, 388);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(100, 40);
        btnCancelar.TabIndex = 13;
        btnCancelar.Text = "&Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // btnSalvar
        // 
        btnSalvar.DialogResult = DialogResult.OK;
        btnSalvar.Location = new Point(130, 388);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(100, 40);
        btnSalvar.TabIndex = 12;
        btnSalvar.Text = "&Salvar";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(237, 250);
        label5.Name = "label5";
        label5.Size = new Size(52, 20);
        label5.TabIndex = 10;
        label5.Text = "Carg&o:";
        // 
        // txtCargo
        // 
        txtCargo.Location = new Point(239, 273);
        txtCargo.Name = "txtCargo";
        txtCargo.Size = new Size(186, 27);
        txtCargo.TabIndex = 11;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(258, 64);
        label6.Name = "label6";
        label6.Size = new Size(25, 20);
        label6.TabIndex = 0;
        label6.Text = "Id:";
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(289, 61);
        txtId.Name = "txtId";
        txtId.Size = new Size(136, 27);
        txtId.TabIndex = 1;
        txtId.Text = "0";
        // 
        // txtTelefone
        // 
        txtTelefone.Location = new Point(41, 167);
        txtTelefone.Mask = "(00) 0 0000-0000";
        txtTelefone.Name = "txtTelefone";
        txtTelefone.Size = new Size(162, 27);
        txtTelefone.TabIndex = 5;
        // 
        // TelaContatoForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(466, 461);
        Controls.Add(txtTelefone);
        Controls.Add(btnSalvar);
        Controls.Add(btnCancelar);
        Controls.Add(txtCargo);
        Controls.Add(label5);
        Controls.Add(txtEmpresa);
        Controls.Add(label4);
        Controls.Add(txtEmail);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(txtId);
        Controls.Add(label6);
        Controls.Add(txtNome);
        Controls.Add(label1);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TelaContatoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastro de contato";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtNome;
    private Label label2;
    private Label label3;
    private TextBox txtEmail;
    private Label label4;
    private TextBox txtEmpresa;
    private Button btnCancelar;
    private Button btnSalvar;
    private Label label5;
    private TextBox txtCargo;
    private Label label6;
    private TextBox txtId;
    private MaskedTextBox txtTelefone;
}