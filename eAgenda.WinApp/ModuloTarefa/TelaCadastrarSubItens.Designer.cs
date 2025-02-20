namespace eAgenda.WinApp.ModuloTarefa;

partial class TelaCadastrarSubItens
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
        btnCancelar = new Button();
        btnSalvar = new Button();
        label1 = new Label();
        txtTituloItemTarefa = new TextBox();
        btnAdicionarItem = new Button();
        label2 = new Label();
        lblTituloTarefa = new Label();
        listItensTarefa = new ListBox();
        SuspendLayout();
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(272, 339);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(100, 40);
        btnCancelar.TabIndex = 18;
        btnCancelar.Text = "&Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // btnSalvar
        // 
        btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSalvar.DialogResult = DialogResult.OK;
        btnSalvar.Location = new Point(166, 339);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(100, 40);
        btnSalvar.TabIndex = 17;
        btnSalvar.Text = "&Salvar";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 60);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 19;
        label1.Text = "Título:";
        // 
        // txtTituloItemTarefa
        // 
        txtTituloItemTarefa.Location = new Point(28, 83);
        txtTituloItemTarefa.Name = "txtTituloItemTarefa";
        txtTituloItemTarefa.Size = new Size(219, 27);
        txtTituloItemTarefa.TabIndex = 20;
        // 
        // btnAdicionarItem
        // 
        btnAdicionarItem.Location = new Point(262, 83);
        btnAdicionarItem.Name = "btnAdicionarItem";
        btnAdicionarItem.Size = new Size(95, 27);
        btnAdicionarItem.TabIndex = 21;
        btnAdicionarItem.Text = "Adicionar";
        btnAdicionarItem.UseVisualStyleBackColor = true;
        btnAdicionarItem.Click += btnAdicionarItem_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(28, 24);
        label2.Name = "label2";
        label2.Size = new Size(52, 20);
        label2.TabIndex = 22;
        label2.Text = "Tarefa:";
        // 
        // lblTituloTarefa
        // 
        lblTituloTarefa.AutoSize = true;
        lblTituloTarefa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
        lblTituloTarefa.Location = new Point(84, 24);
        lblTituloTarefa.Name = "lblTituloTarefa";
        lblTituloTarefa.Size = new Size(131, 20);
        lblTituloTarefa.TabIndex = 23;
        lblTituloTarefa.Text = "[Título da Tarefa]";
        // 
        // listItensTarefa
        // 
        listItensTarefa.FormattingEnabled = true;
        listItensTarefa.Location = new Point(28, 135);
        listItensTarefa.Name = "listItensTarefa";
        listItensTarefa.Size = new Size(329, 184);
        listItensTarefa.TabIndex = 24;
        // 
        // TelaCadastrarSubItens
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 391);
        Controls.Add(listItensTarefa);
        Controls.Add(lblTituloTarefa);
        Controls.Add(label2);
        Controls.Add(btnAdicionarItem);
        Controls.Add(txtTituloItemTarefa);
        Controls.Add(label1);
        Controls.Add(btnCancelar);
        Controls.Add(btnSalvar);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TelaCadastrarSubItens";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "TelaSubItemForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnCancelar;
    private Button btnSalvar;
    private Label label1;
    private TextBox txtTituloItemTarefa;
    private Button btnAdicionarItem;
    private Label label2;
    private Label lblTituloTarefa;
    private ListBox listItensTarefa;
}