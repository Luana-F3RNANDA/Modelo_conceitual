﻿
namespace Apresentacao
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroFornecedorToolStripMenuItem,
            this.gerarRelatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroFornecedorToolStripMenuItem
            // 
            this.cadastroFornecedorToolStripMenuItem.Name = "cadastroFornecedorToolStripMenuItem";
            this.cadastroFornecedorToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.cadastroFornecedorToolStripMenuItem.Text = "Cadastro Fornecedor";
            this.cadastroFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroFornecedorToolStripMenuItem_Click);
            // 
            // gerarRelatorioToolStripMenuItem
            // 
            this.gerarRelatorioToolStripMenuItem.Name = "gerarRelatorioToolStripMenuItem";
            this.gerarRelatorioToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.gerarRelatorioToolStripMenuItem.Text = "Gerar relatorio";
            this.gerarRelatorioToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatorioToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatorioToolStripMenuItem;
    }
}