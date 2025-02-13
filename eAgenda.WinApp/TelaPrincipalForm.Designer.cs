namespace eAgenda.WinApp;

partial class TelaPrincipalForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new MenuStrip();
        cadastrosToolStripMenuItem = new ToolStripMenuItem();
        contatosMenuItem = new ToolStripMenuItem();
        compromissosMenuItem = new ToolStripMenuItem();
        toolStripStatus = new StatusStrip();
        toolStripLabelPrincipal = new ToolStripStatusLabel();
        toolStrip1 = new ToolStrip();
        btnAdicionar = new ToolStripButton();
        btnEditar = new ToolStripButton();
        btnExcluir = new ToolStripButton();
        btnFiltrar = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        lblTipoCadastro = new ToolStripLabel();
        pnlRegistros = new Panel();
        menuStrip1.SuspendLayout();
        toolStripStatus.SuspendLayout();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(834, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // cadastrosToolStripMenuItem
        // 
        cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem });
        cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
        cadastrosToolStripMenuItem.Size = new Size(86, 24);
        cadastrosToolStripMenuItem.Text = "Cadastros";
        // 
        // contatosMenuItem
        // 
        contatosMenuItem.Name = "contatosMenuItem";
        contatosMenuItem.Size = new Size(176, 24);
        contatosMenuItem.Text = "Contatos";
        contatosMenuItem.Click += contatosMenuItem_Click;
        // 
        // compromissosMenuItem
        // 
        compromissosMenuItem.Name = "compromissosMenuItem";
        compromissosMenuItem.Size = new Size(176, 24);
        compromissosMenuItem.Text = "Compromissos";
        compromissosMenuItem.Click += compromissosMenuItem_Click;
        // 
        // toolStripStatus
        // 
        toolStripStatus.Items.AddRange(new ToolStripItem[] { toolStripLabelPrincipal });
        toolStripStatus.Location = new Point(0, 436);
        toolStripStatus.Name = "toolStripStatus";
        toolStripStatus.Size = new Size(834, 25);
        toolStripStatus.TabIndex = 1;
        toolStripStatus.Text = "statusStrip1";
        // 
        // toolStripLabelPrincipal
        // 
        toolStripLabelPrincipal.Name = "toolStripLabelPrincipal";
        toolStripLabelPrincipal.Size = new Size(179, 20);
        toolStripLabelPrincipal.Text = "Visualizando 0 registro(s).";
        // 
        // toolStrip1
        // 
        toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, btnFiltrar, toolStripSeparator1, lblTipoCadastro });
        toolStrip1.Location = new Point(0, 28);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(834, 41);
        toolStrip1.TabIndex = 2;
        toolStrip1.Text = "toolStrip1";
        // 
        // btnAdicionar
        // 
        btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnAdicionar.Enabled = false;
        btnAdicionar.Image = Properties.Resources.btnAdicionar;
        btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
        btnAdicionar.ImageTransparentColor = Color.Magenta;
        btnAdicionar.Name = "btnAdicionar";
        btnAdicionar.Padding = new Padding(5);
        btnAdicionar.Size = new Size(38, 38);
        btnAdicionar.Text = "toolStripButton3";
        btnAdicionar.Click += btnAdicionar_Click;
        // 
        // btnEditar
        // 
        btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnEditar.Enabled = false;
        btnEditar.Image = Properties.Resources.btnEditar;
        btnEditar.ImageScaling = ToolStripItemImageScaling.None;
        btnEditar.ImageTransparentColor = Color.Magenta;
        btnEditar.Name = "btnEditar";
        btnEditar.Padding = new Padding(5);
        btnEditar.Size = new Size(38, 38);
        btnEditar.Text = "toolStripButton2";
        btnEditar.Click += btnEditar_Click;
        // 
        // btnExcluir
        // 
        btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnExcluir.Enabled = false;
        btnExcluir.Image = Properties.Resources.btnDelete;
        btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
        btnExcluir.ImageTransparentColor = Color.Magenta;
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Padding = new Padding(5);
        btnExcluir.Size = new Size(38, 38);
        btnExcluir.Text = "toolStripButton1";
        btnExcluir.Click += btnExcluir_Click;
        // 
        // btnFiltrar
        // 
        btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnFiltrar.Enabled = false;
        btnFiltrar.Image = Properties.Resources.btnFiltrar;
        btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
        btnFiltrar.ImageTransparentColor = Color.Magenta;
        btnFiltrar.Margin = new Padding(0);
        btnFiltrar.Name = "btnFiltrar";
        btnFiltrar.Padding = new Padding(5);
        btnFiltrar.Size = new Size(38, 41);
        btnFiltrar.Text = "toolStripButton1";
        btnFiltrar.Visible = false;
        btnFiltrar.Click += btnFiltrar_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 41);
        // 
        // lblTipoCadastro
        // 
        lblTipoCadastro.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
        lblTipoCadastro.Name = "lblTipoCadastro";
        lblTipoCadastro.Size = new Size(124, 38);
        lblTipoCadastro.Text = "Tipo de Cadastro";
        // 
        // pnlRegistros
        // 
        pnlRegistros.Dock = DockStyle.Fill;
        pnlRegistros.Location = new Point(0, 69);
        pnlRegistros.Name = "pnlRegistros";
        pnlRegistros.Size = new Size(834, 367);
        pnlRegistros.TabIndex = 3;
        // 
        // TelaPrincipalForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(834, 461);
        Controls.Add(pnlRegistros);
        Controls.Add(toolStrip1);
        Controls.Add(toolStripStatus);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MainMenuStrip = menuStrip1;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TelaPrincipalForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "eAgenda";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        toolStripStatus.ResumeLayout(false);
        toolStripStatus.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem cadastrosToolStripMenuItem;
    private ToolStripMenuItem contatosMenuItem;
    private ToolStripMenuItem compromissosMenuItem;
    private StatusStrip toolStripStatus;
    private ToolStripStatusLabel toolStripLabelPrincipal;
    private ToolStrip toolStrip1;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripLabel lblTipoCadastro;
    private Panel pnlRegistros;
    private ToolStripButton btnAdicionar;
    private ToolStripButton btnEditar;
    private ToolStripButton btnExcluir;
    private ToolStripButton btnFiltrar;
}
