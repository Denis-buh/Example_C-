﻿



partial class MainForm{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing){
        if (disposing && (components != null)){
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent(){
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settings_graphics = new System.Windows.Forms.ToolStripMenuItem();
            this.build_graphics = new System.Windows.Forms.ToolStripMenuItem();
            this.clean = new System.Windows.Forms.ToolStripMenuItem();
            this.inform_graphics = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings_graphics,
            this.build_graphics,
            this.clean,
            this.inform_graphics,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settings_graphics
            // 
            this.settings_graphics.Name = "settings_graphics";
            this.settings_graphics.Size = new System.Drawing.Size(139, 20);
            this.settings_graphics.Text = "Параметры графиков";
            this.settings_graphics.Click += new System.EventHandler(this.settings_graphics_Click);
            // 
            // build_graphics
            // 
            this.build_graphics.Name = "build_graphics";
            this.build_graphics.Size = new System.Drawing.Size(128, 20);
            this.build_graphics.Text = "Построить графики";
            this.build_graphics.Click += new System.EventHandler(this.build_graphics_Click);
            // 
            // clean
            // 
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(121, 20);
            this.clean.Text = "Очистить графики";
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // inform_graphics
            // 
            this.inform_graphics.Name = "inform_graphics";
            this.inform_graphics.Size = new System.Drawing.Size(158, 20);
            this.inform_graphics.Text = "Информация о графиках";
            this.inform_graphics.Click += new System.EventHandler(this.inform_graphics_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(132, 20);
            this.Exit.Text = "Завершение работы";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 896);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 935);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem settings_graphics;
    private System.Windows.Forms.ToolStripMenuItem build_graphics;
    private System.Windows.Forms.ToolStripMenuItem clean;
    private System.Windows.Forms.ToolStripMenuItem inform_graphics;
    private System.Windows.Forms.ToolStripMenuItem Exit;
}
