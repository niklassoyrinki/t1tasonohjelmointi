﻿
namespace Harjoitus14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TallennaBT = new System.Windows.Forms.Button();
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TallennaBT
            // 
            this.TallennaBT.Location = new System.Drawing.Point(33, 321);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(499, 91);
            this.TallennaBT.TabIndex = 0;
            this.TallennaBT.Text = "Tallenna päiväkirjaan";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // SyottoTB
            // 
            this.SyottoTB.Location = new System.Drawing.Point(33, 12);
            this.SyottoTB.Multiline = true;
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(499, 290);
            this.SyottoTB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.SyottoTB);
            this.Controls.Add(this.TallennaBT);
            this.Name = "Form1";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.TextBox SyottoTB;
    }
}

