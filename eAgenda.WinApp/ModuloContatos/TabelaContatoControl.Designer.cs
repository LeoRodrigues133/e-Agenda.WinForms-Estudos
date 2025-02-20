namespace eAgenda.WinApp.ModuloContatos;

partial class TabelaContatoControl
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
        id = new DataGridViewTextBoxColumn();
        Nome = new DataGridViewTextBoxColumn();
        telefone = new DataGridViewTextBoxColumn();
        email = new DataGridViewTextBoxColumn();
        empresa = new DataGridViewTextBoxColumn();
        cargo = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
        SuspendLayout();
        // 
        // grid
        // 
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        grid.Columns.AddRange(new DataGridViewColumn[] { id, Nome, telefone, email, empresa, cargo });
        grid.Dock = DockStyle.Fill;
        grid.Location = new Point(0, 0);
        grid.MultiSelect = false;
        grid.Name = "grid";
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.Size = new Size(785, 376);
        grid.TabIndex = 0;
        // 
        // id
        // 
        id.HeaderText = "Id";
        id.Name = "id";
        id.ReadOnly = true;
        // 
        // Nome
        // 
        Nome.HeaderText = "nome";
        Nome.Name = "Nome";
        Nome.ReadOnly = true;
        // 
        // telefone
        // 
        telefone.HeaderText = "Telefone";
        telefone.Name = "telefone";
        telefone.ReadOnly = true;
        // 
        // email
        // 
        email.HeaderText = "Email";
        email.Name = "email";
        email.ReadOnly = true;
        // 
        // empresa
        // 
        empresa.HeaderText = "Empresa";
        empresa.Name = "empresa";
        empresa.ReadOnly = true;
        // 
        // cargo
        // 
        cargo.HeaderText = "Cargo";
        cargo.Name = "cargo";
        cargo.ReadOnly = true;
        // 
        // TabelaContatoControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(grid);
        Name = "TabelaContatoControl";
        Size = new Size(785, 376);
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView grid;
    private DataGridViewTextBoxColumn id;
    private DataGridViewTextBoxColumn Nome;
    private DataGridViewTextBoxColumn telefone;
    private DataGridViewTextBoxColumn email;
    private DataGridViewTextBoxColumn empresa;
    private DataGridViewTextBoxColumn cargo;
}
