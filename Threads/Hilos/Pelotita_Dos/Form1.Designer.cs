﻿namespace Pelotita_Dos
{
    partial class Form1
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
            this.pctbxPelotita2 = new System.Windows.Forms.PictureBox();
            this.btnCrear2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxPelotita2)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbxPelotita2
            // 
            this.pctbxPelotita2.Location = new System.Drawing.Point(-1, 1);
            this.pctbxPelotita2.Name = "pctbxPelotita2";
            this.pctbxPelotita2.Size = new System.Drawing.Size(284, 224);
            this.pctbxPelotita2.TabIndex = 0;
            this.pctbxPelotita2.TabStop = false;
            this.pctbxPelotita2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCrear2
            // 
            this.btnCrear2.Location = new System.Drawing.Point(77, 231);
            this.btnCrear2.Name = "btnCrear2";
            this.btnCrear2.Size = new System.Drawing.Size(138, 23);
            this.btnCrear2.TabIndex = 1;
            this.btnCrear2.Text = "Crear Pelotita";
            this.btnCrear2.UseVisualStyleBackColor = true;
            this.btnCrear2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCrear2);
            this.Controls.Add(this.pctbxPelotita2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctbxPelotita2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbxPelotita2;
        private System.Windows.Forms.Button btnCrear2;
    }
}

