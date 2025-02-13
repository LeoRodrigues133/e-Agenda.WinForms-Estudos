namespace eAgenda.WinApp.ModuloContatos;

partial class ListagemContatoControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        listContato = new ListBox();
        SuspendLayout();
        // 
        // listContato
        // 
        listContato.Dock = DockStyle.Fill;
        listContato.FormattingEnabled = true;
        listContato.Location = new Point(0, 0);
        listContato.Name = "listContato";
        listContato.Size = new Size(839, 474);
        listContato.TabIndex = 0;
        // 
        // ListagemContatoControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(listContato);
        Name = "ListagemContatoControl";
        Size = new Size(839, 474);
        ResumeLayout(false);
    }

    #endregion

    private ListBox listContato;
}
