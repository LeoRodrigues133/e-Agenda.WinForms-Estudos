﻿namespace eAgenda.WinApp.ModuloTarefa;

partial class TabelaTarefaControl
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
        listTarefas = new ListView();
        SuspendLayout();
        // 
        // listTarefas
        // 
        listTarefas.Dock = DockStyle.Fill;
        listTarefas.Location = new Point(0, 0);
        listTarefas.Name = "listTarefas";
        listTarefas.Size = new Size(782, 370);
        listTarefas.TabIndex = 0;
        listTarefas.UseCompatibleStateImageBehavior = false;
        // 
        // TabelaTarefaControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(listTarefas);
        Name = "TabelaTarefaControl";
        Size = new Size(782, 370);
        ResumeLayout(false);
    }

    #endregion

    private ListView listTarefas;
}
