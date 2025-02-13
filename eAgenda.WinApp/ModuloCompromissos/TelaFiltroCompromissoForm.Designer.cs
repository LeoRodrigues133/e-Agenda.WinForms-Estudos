namespace eAgenda.WinApp.ModuloCompromissos;

partial class TelaFiltroCompromissoForm
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
        groupBox1 = new GroupBox();
        lblFiltroTermino = new Label();
        lblFiltroInicio = new Label();
        dtFiltroTermino = new DateTimePicker();
        dtFiltroInicio = new DateTimePicker();
        rdbCompromissosPorPeriodo = new RadioButton();
        rdbTodosOsCompromissos = new RadioButton();
        rdbCompromissosPassados = new RadioButton();
        rdbCompromissosFuturos = new RadioButton();
        btnSalvar = new Button();
        btnCancelar = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lblFiltroTermino);
        groupBox1.Controls.Add(lblFiltroInicio);
        groupBox1.Controls.Add(dtFiltroTermino);
        groupBox1.Controls.Add(dtFiltroInicio);
        groupBox1.Controls.Add(rdbCompromissosPorPeriodo);
        groupBox1.Controls.Add(rdbTodosOsCompromissos);
        groupBox1.Controls.Add(rdbCompromissosPassados);
        groupBox1.Controls.Add(rdbCompromissosFuturos);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(360, 198);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Selecione um filtro";
        // 
        // lblFiltroTermino
        // 
        lblFiltroTermino.AutoSize = true;
        lblFiltroTermino.Location = new Point(184, 159);
        lblFiltroTermino.Name = "lblFiltroTermino";
        lblFiltroTermino.Size = new Size(66, 20);
        lblFiltroTermino.TabIndex = 3;
        lblFiltroTermino.Text = "Término:";
        // 
        // lblFiltroInicio
        // 
        lblFiltroInicio.AutoSize = true;
        lblFiltroInicio.Location = new Point(13, 159);
        lblFiltroInicio.Name = "lblFiltroInicio";
        lblFiltroInicio.Size = new Size(48, 20);
        lblFiltroInicio.TabIndex = 3;
        lblFiltroInicio.Text = "Início:";
        // 
        // dtFiltroTermino
        // 
        dtFiltroTermino.Enabled = false;
        dtFiltroTermino.Format = DateTimePickerFormat.Short;
        dtFiltroTermino.Location = new Point(256, 154);
        dtFiltroTermino.Name = "dtFiltroTermino";
        dtFiltroTermino.Size = new Size(98, 27);
        dtFiltroTermino.TabIndex = 2;
        // 
        // dtFiltroInicio
        // 
        dtFiltroInicio.Enabled = false;
        dtFiltroInicio.Format = DateTimePickerFormat.Short;
        dtFiltroInicio.Location = new Point(67, 154);
        dtFiltroInicio.Name = "dtFiltroInicio";
        dtFiltroInicio.Size = new Size(98, 27);
        dtFiltroInicio.TabIndex = 2;
        // 
        // rdbCompromissosPorPeriodo
        // 
        rdbCompromissosPorPeriodo.AutoSize = true;
        rdbCompromissosPorPeriodo.Location = new Point(38, 124);
        rdbCompromissosPorPeriodo.Name = "rdbCompromissosPorPeriodo";
        rdbCompromissosPorPeriodo.Size = new Size(212, 24);
        rdbCompromissosPorPeriodo.TabIndex = 1;
        rdbCompromissosPorPeriodo.TabStop = true;
        rdbCompromissosPorPeriodo.Text = "Compromissos por período.";
        rdbCompromissosPorPeriodo.UseVisualStyleBackColor = true;
        rdbCompromissosPorPeriodo.CheckedChanged += rdbCompromissosPorPeriodo_CheckedChanged;
        // 
        // rdbTodosOsCompromissos
        // 
        rdbTodosOsCompromissos.AutoSize = true;
        rdbTodosOsCompromissos.Location = new Point(38, 23);
        rdbTodosOsCompromissos.Name = "rdbTodosOsCompromissos";
        rdbTodosOsCompromissos.Size = new Size(189, 24);
        rdbTodosOsCompromissos.TabIndex = 0;
        rdbTodosOsCompromissos.TabStop = true;
        rdbTodosOsCompromissos.Text = "Todos os compromissos.";
        rdbTodosOsCompromissos.UseVisualStyleBackColor = true;
        // 
        // rdbCompromissosPassados
        // 
        rdbCompromissosPassados.AutoSize = true;
        rdbCompromissosPassados.Location = new Point(38, 53);
        rdbCompromissosPassados.Name = "rdbCompromissosPassados";
        rdbCompromissosPassados.Size = new Size(193, 24);
        rdbCompromissosPassados.TabIndex = 0;
        rdbCompromissosPassados.TabStop = true;
        rdbCompromissosPassados.Text = "Compromissos passados.";
        rdbCompromissosPassados.UseVisualStyleBackColor = true;
        // 
        // rdbCompromissosFuturos
        // 
        rdbCompromissosFuturos.AutoSize = true;
        rdbCompromissosFuturos.Location = new Point(38, 83);
        rdbCompromissosFuturos.Name = "rdbCompromissosFuturos";
        rdbCompromissosFuturos.Size = new Size(178, 24);
        rdbCompromissosFuturos.TabIndex = 0;
        rdbCompromissosFuturos.TabStop = true;
        rdbCompromissosFuturos.Text = "Compromissos futuros.";
        rdbCompromissosFuturos.UseVisualStyleBackColor = true;
        // 
        // btnSalvar
        // 
        btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSalvar.DialogResult = DialogResult.OK;
        btnSalvar.Location = new Point(89, 216);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(100, 40);
        btnSalvar.TabIndex = 15;
        btnSalvar.Text = "&Salvar";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(195, 216);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(100, 40);
        btnCancelar.TabIndex = 16;
        btnCancelar.Text = "&Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // TelaFiltroCompromissoForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 268);
        Controls.Add(btnCancelar);
        Controls.Add(btnSalvar);
        Controls.Add(groupBox1);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TelaFiltroCompromissoForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Filtro de compromissos";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Button btnSalvar;
    private Button btnCancelar;
    private RadioButton rdbTodosOsCompromissos;
    private RadioButton rdbCompromissosPassados;
    private RadioButton rdbCompromissosFuturos;
    private Label lblFiltroTermino;
    private Label lblFiltroInicio;
    private DateTimePicker dtFiltroTermino;
    private DateTimePicker dtFiltroInicio;
    private RadioButton rdbCompromissosPorPeriodo;
}