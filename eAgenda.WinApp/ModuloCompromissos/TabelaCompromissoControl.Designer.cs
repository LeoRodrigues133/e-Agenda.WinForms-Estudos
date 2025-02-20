namespace eAgenda.WinApp.ModuloCompromissos;

partial class TabelaCompromissoControl
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
        grid = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
        SuspendLayout();
        // 
        // grid
        // 
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        grid.Dock = DockStyle.Fill;
        grid.Location = new Point(0, 0);
        grid.MultiSelect = false;
        grid.Name = "grid";
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.Size = new Size(893, 393);
        grid.TabIndex = 0;
        // 
        // TabelaCompromissoControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(grid);
        Name = "TabelaCompromissoControl";
        Size = new Size(893, 393);
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView grid;
}
