﻿namespace eAgenda.WinApp.ModuloCompromissos;

partial class ListagemCompromissoControl
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
        listCompromissos = new ListBox();
        SuspendLayout();
        // 
        // listCompromissos
        // 
        listCompromissos.Dock = DockStyle.Fill;
        listCompromissos.FormattingEnabled = true;
        listCompromissos.Location = new Point(0, 0);
        listCompromissos.Name = "listCompromissos";
        listCompromissos.Size = new Size(490, 353);
        listCompromissos.TabIndex = 0;
        // 
        // ListagemCompromissoControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(listCompromissos);
        Name = "ListagemCompromissoControl";
        Size = new Size(490, 353);
        ResumeLayout(false);
    }

    #endregion

    private ListBox listCompromissos;
}
