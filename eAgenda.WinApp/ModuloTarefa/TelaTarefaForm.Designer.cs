namespace eAgenda.WinApp.ModuloTarefa;

partial class TelaTarefaForm
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
        cmbPrioridade = new ComboBox();
        btnSalvar = new Button();
        btnCancelar = new Button();
        label2 = new Label();
        txtId = new TextBox();
        label6 = new Label();
        txtTitulo = new TextBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // cmbPrioridade
        // 
        cmbPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPrioridade.FormattingEnabled = true;
        cmbPrioridade.Location = new Point(41, 149);
        cmbPrioridade.Name = "cmbPrioridade";
        cmbPrioridade.Size = new Size(160, 28);
        cmbPrioridade.TabIndex = 0;
        // 
        // btnSalvar
        // 
        btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSalvar.DialogResult = DialogResult.OK;
        btnSalvar.Location = new Point(246, 209);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(100, 40);
        btnSalvar.TabIndex = 14;
        btnSalvar.Text = "&Salvar";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(352, 209);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(100, 40);
        btnCancelar.TabIndex = 15;
        btnCancelar.Text = "&Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(41, 126);
        label2.Name = "label2";
        label2.Size = new Size(81, 20);
        label2.TabIndex = 20;
        label2.Text = "&Prioridade:";
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(289, 43);
        txtId.Name = "txtId";
        txtId.Size = new Size(136, 27);
        txtId.TabIndex = 17;
        txtId.Text = "0";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(258, 46);
        label6.Name = "label6";
        label6.Size = new Size(25, 20);
        label6.TabIndex = 16;
        label6.Text = "Id:";
        // 
        // txtTitulo
        // 
        txtTitulo.Location = new Point(43, 96);
        txtTitulo.Name = "txtTitulo";
        txtTitulo.Size = new Size(382, 27);
        txtTitulo.TabIndex = 19;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(41, 73);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 18;
        label1.Text = "&Titulo:";
        // 
        // TelaTarefaForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(464, 261);
        Controls.Add(label2);
        Controls.Add(txtId);
        Controls.Add(label6);
        Controls.Add(txtTitulo);
        Controls.Add(label1);
        Controls.Add(btnSalvar);
        Controls.Add(btnCancelar);
        Controls.Add(cmbPrioridade);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TelaTarefaForm";
        Text = "TelaTarefaForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox cmbPrioridade;
    private Button btnSalvar;
    private Button btnCancelar;
    private Label label2;
    private TextBox txtId;
    private Label label6;
    private TextBox txtTitulo;
    private Label label1;
}