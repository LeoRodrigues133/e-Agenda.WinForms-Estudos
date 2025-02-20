namespace eAgenda.WinApp.ModuloCompromissos;

partial class TelaCompromissoForm
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
        btnSalvar = new Button();
        btnCancelar = new Button();
        label1 = new Label();
        txtId = new TextBox();
        label2 = new Label();
        txtAssunto = new TextBox();
        label4 = new Label();
        dtData = new DateTimePicker();
        label3 = new Label();
        dtHoraInicio = new DateTimePicker();
        label5 = new Label();
        dtHoraTermino = new DateTimePicker();
        chkboxContato = new CheckBox();
        cmbBoxContato = new ComboBox();
        groupBox1 = new GroupBox();
        txtPresencial = new TextBox();
        rdbPresencial = new RadioButton();
        txtRemoto = new TextBox();
        rdbRemoto = new RadioButton();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // btnSalvar
        // 
        btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSalvar.DialogResult = DialogResult.OK;
        btnSalvar.Location = new Point(246, 526);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(100, 40);
        btnSalvar.TabIndex = 13;
        btnSalvar.Text = "&Salvar";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(352, 526);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(100, 40);
        btnCancelar.TabIndex = 14;
        btnCancelar.Text = "&Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(228, 70);
        label1.Name = "label1";
        label1.Size = new Size(25, 20);
        label1.TabIndex = 0;
        label1.Text = "Id:";
        // 
        // txtId
        // 
        txtId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtId.Enabled = false;
        txtId.Location = new Point(259, 67);
        txtId.Name = "txtId";
        txtId.Size = new Size(136, 27);
        txtId.TabIndex = 1;
        txtId.Text = "0";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(67, 100);
        label2.Name = "label2";
        label2.Size = new Size(64, 20);
        label2.TabIndex = 2;
        label2.Text = "Assunto:";
        // 
        // txtAssunto
        // 
        txtAssunto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtAssunto.Location = new Point(67, 123);
        txtAssunto.Name = "txtAssunto";
        txtAssunto.Size = new Size(328, 27);
        txtAssunto.TabIndex = 3;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(67, 153);
        label4.Name = "label4";
        label4.Size = new Size(44, 20);
        label4.TabIndex = 4;
        label4.Text = "Data:";
        // 
        // dtData
        // 
        dtData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        dtData.Format = DateTimePickerFormat.Short;
        dtData.Location = new Point(67, 176);
        dtData.Name = "dtData";
        dtData.Size = new Size(165, 27);
        dtData.TabIndex = 5;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(67, 206);
        label3.Name = "label3";
        label3.Size = new Size(48, 20);
        label3.TabIndex = 6;
        label3.Text = "Início:";
        // 
        // dtHoraInicio
        // 
        dtHoraInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        dtHoraInicio.CustomFormat = "HH:mm";
        dtHoraInicio.Format = DateTimePickerFormat.Custom;
        dtHoraInicio.Location = new Point(67, 229);
        dtHoraInicio.Name = "dtHoraInicio";
        dtHoraInicio.Size = new Size(142, 27);
        dtHoraInicio.TabIndex = 7;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label5.AutoSize = true;
        label5.Location = new Point(253, 206);
        label5.Name = "label5";
        label5.Size = new Size(66, 20);
        label5.TabIndex = 8;
        label5.Text = "Término:";
        // 
        // dtHoraTermino
        // 
        dtHoraTermino.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        dtHoraTermino.CustomFormat = "HH:mm";
        dtHoraTermino.Format = DateTimePickerFormat.Custom;
        dtHoraTermino.Location = new Point(253, 229);
        dtHoraTermino.Name = "dtHoraTermino";
        dtHoraTermino.Size = new Size(142, 27);
        dtHoraTermino.TabIndex = 9;
        // 
        // chkboxContato
        // 
        chkboxContato.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        chkboxContato.AutoSize = true;
        chkboxContato.Location = new Point(67, 289);
        chkboxContato.Name = "chkboxContato";
        chkboxContato.Size = new Size(215, 24);
        chkboxContato.TabIndex = 10;
        chkboxContato.Text = "Deseja vincular um contato?";
        chkboxContato.UseVisualStyleBackColor = true;
        chkboxContato.CheckedChanged += chkboxContato_CheckedChanged;
        // 
        // cmbBoxContato
        // 
        cmbBoxContato.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBoxContato.FormattingEnabled = true;
        cmbBoxContato.Location = new Point(118, 319);
        cmbBoxContato.Name = "cmbBoxContato";
        cmbBoxContato.Size = new Size(231, 28);
        cmbBoxContato.TabIndex = 11;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtPresencial);
        groupBox1.Controls.Add(rdbPresencial);
        groupBox1.Controls.Add(txtRemoto);
        groupBox1.Controls.Add(rdbRemoto);
        groupBox1.Location = new Point(69, 386);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(328, 132);
        groupBox1.TabIndex = 12;
        groupBox1.TabStop = false;
        groupBox1.Text = "Localização";
        // 
        // txtPresencial
        // 
        txtPresencial.Location = new Point(109, 78);
        txtPresencial.Name = "txtPresencial";
        txtPresencial.Size = new Size(213, 27);
        txtPresencial.TabIndex = 3;
        // 
        // rdbPresencial
        // 
        rdbPresencial.AutoSize = true;
        rdbPresencial.Location = new Point(7, 79);
        rdbPresencial.Name = "rdbPresencial";
        rdbPresencial.Size = new Size(96, 24);
        rdbPresencial.TabIndex = 2;
        rdbPresencial.Text = "Presencial:";
        rdbPresencial.UseVisualStyleBackColor = true;
        rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
        // 
        // txtRemoto
        // 
        txtRemoto.Location = new Point(109, 45);
        txtRemoto.Name = "txtRemoto";
        txtRemoto.Size = new Size(213, 27);
        txtRemoto.TabIndex = 1;
        // 
        // rdbRemoto
        // 
        rdbRemoto.AutoSize = true;
        rdbRemoto.Checked = true;
        rdbRemoto.Location = new Point(7, 46);
        rdbRemoto.Name = "rdbRemoto";
        rdbRemoto.Size = new Size(83, 24);
        rdbRemoto.TabIndex = 0;
        rdbRemoto.TabStop = true;
        rdbRemoto.Text = "Remoto:";
        rdbRemoto.UseVisualStyleBackColor = true;
        // 
        // TelaCompromissoForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(464, 585);
        Controls.Add(groupBox1);
        Controls.Add(cmbBoxContato);
        Controls.Add(chkboxContato);
        Controls.Add(dtHoraTermino);
        Controls.Add(dtHoraInicio);
        Controls.Add(label5);
        Controls.Add(dtData);
        Controls.Add(label3);
        Controls.Add(txtAssunto);
        Controls.Add(label4);
        Controls.Add(label2);
        Controls.Add(txtId);
        Controls.Add(label1);
        Controls.Add(btnSalvar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TelaCompromissoForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastro de Compromisso";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnSalvar;
    private Button btnCancelar;
    private Label label1;
    private TextBox txtId;
    private Label label2;
    private TextBox txtAssunto;
    private Label label4;
    private DateTimePicker dtData;
    private Label label3;
    private DateTimePicker dtHoraInicio;
    private Label label5;
    private DateTimePicker dtHoraTermino;
    private CheckBox chkboxContato;
    private ComboBox cmbBoxContato;
    private GroupBox groupBox1;
    private TextBox txtPresencial;
    private RadioButton rdbPresencial;
    private TextBox txtRemoto;
    private RadioButton rdbRemoto;
}