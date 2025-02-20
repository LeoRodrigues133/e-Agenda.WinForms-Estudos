namespace eAgenda.WinApp.ModuloTarefa;

partial class TelaAtualizarSubItemForm
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
        lblTituloTarefa = new Label();
        label2 = new Label();
        btnCancelar = new Button();
        btnSalvar = new Button();
        chklistItensTarefa = new CheckedListBox();
        SuspendLayout();
        // 
        // lblTituloTarefa
        // 
        lblTituloTarefa.AutoSize = true;
        lblTituloTarefa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
        lblTituloTarefa.Location = new Point(84, 18);
        lblTituloTarefa.Name = "lblTituloTarefa";
        lblTituloTarefa.Size = new Size(131, 20);
        lblTituloTarefa.TabIndex = 31;
        lblTituloTarefa.Text = "[Título da Tarefa]";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(28, 18);
        label2.Name = "label2";
        label2.Size = new Size(52, 20);
        label2.TabIndex = 30;
        label2.Text = "Tarefa:";
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Location = new Point(272, 289);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(100, 40);
        btnCancelar.TabIndex = 26;
        btnCancelar.Text = "&Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // btnSalvar
        // 
        btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSalvar.DialogResult = DialogResult.OK;
        btnSalvar.Location = new Point(166, 289);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(100, 40);
        btnSalvar.TabIndex = 25;
        btnSalvar.Text = "&Salvar";
        btnSalvar.UseVisualStyleBackColor = true;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // chklistItensTarefa
        // 
        chklistItensTarefa.FormattingEnabled = true;
        chklistItensTarefa.Location = new Point(28, 51);
        chklistItensTarefa.Name = "chklistItensTarefa";
        chklistItensTarefa.Size = new Size(324, 224);
        chklistItensTarefa.TabIndex = 32;
        // 
        // TelaAtualizarSubItemForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 341);
        Controls.Add(chklistItensTarefa);
        Controls.Add(lblTituloTarefa);
        Controls.Add(label2);
        Controls.Add(btnCancelar);
        Controls.Add(btnSalvar);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "TelaAtualizarSubItemForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "TelaAtualizarSubItemForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label lblTituloTarefa;
    private Label label2;
    private Button btnCancelar;
    private Button btnSalvar;
    private CheckedListBox chklistItensTarefa;
}