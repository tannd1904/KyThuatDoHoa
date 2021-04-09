﻿namespace KTDH_2020.UI
{
    partial class frm_ChangeMode
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
            this.btn_3D = new System.Windows.Forms.Button();
            this.btn_2D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_3D
            // 
            this.btn_3D.BackColor = System.Drawing.Color.White;
            this.btn_3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3D.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3D.ForeColor = System.Drawing.Color.Black;
            this.btn_3D.Image = global::KTDH_2020.Image_Res._3D_Model_25px;
            this.btn_3D.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_3D.Location = new System.Drawing.Point(109, 12);
            this.btn_3D.Name = "btn_3D";
            this.btn_3D.Size = new System.Drawing.Size(65, 41);
            this.btn_3D.TabIndex = 1;
            this.btn_3D.Text = "3D";
            this.btn_3D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_3D.UseVisualStyleBackColor = false;
            this.btn_3D.Click += new System.EventHandler(this.btn_3D_Click);
            // 
            // btn_2D
            // 
            this.btn_2D.BackColor = System.Drawing.Color.White;
            this.btn_2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2D.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2D.ForeColor = System.Drawing.Color.Black;
            this.btn_2D.Image = global::KTDH_2020.Image_Res._2D_Model_25px;
            this.btn_2D.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_2D.Location = new System.Drawing.Point(11, 12);
            this.btn_2D.Name = "btn_2D";
            this.btn_2D.Size = new System.Drawing.Size(69, 41);
            this.btn_2D.TabIndex = 0;
            this.btn_2D.TabStop = false;
            this.btn_2D.Text = "2D ";
            this.btn_2D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_2D.UseVisualStyleBackColor = false;
            this.btn_2D.Click += new System.EventHandler(this.btn_2D_Click);
            // 
            // frm_ChangeMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(186, 66);
            this.Controls.Add(this.btn_3D);
            this.Controls.Add(this.btn_2D);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 2);
            this.Name = "frm_ChangeMode";
            this.Text = "frm_ChangeMode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_2D;
        private System.Windows.Forms.Button btn_3D;
    }
}