﻿namespace TelasSharpWare.Botoes
{
    partial class BotaoCartao
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
            this.SuspendLayout();
            // 
            // BotaoCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TelasSharpWare.Properties.Resources.BotaoCartao1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Name = "BotaoCartao";
            this.Size = new System.Drawing.Size(120, 120);
            this.MouseEnter += new System.EventHandler(this.BotaoCartao_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.BotaoCartao_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
