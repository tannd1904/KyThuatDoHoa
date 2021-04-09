namespace KTDH_2020.UI.UserCtr
{
    partial class ChooseMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseMode));
            this.btn_3D = new System.Windows.Forms.Button();
            this.btn_2D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_3D
            // 
            this.btn_3D.AutoEllipsis = true;
            this.btn_3D.BackColor = System.Drawing.Color.White;
            this.btn_3D.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_3D, "btn_3D");
            this.btn_3D.ForeColor = System.Drawing.Color.Black;
            this.btn_3D.Name = "btn_3D";
            this.btn_3D.UseVisualStyleBackColor = false;
            this.btn_3D.Click += new System.EventHandler(this.btn_3D_Click);
            // 
            // btn_2D
            // 
            this.btn_2D.BackColor = System.Drawing.Color.White;
            this.btn_2D.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_2D, "btn_2D");
            this.btn_2D.ForeColor = System.Drawing.Color.Black;
            this.btn_2D.Name = "btn_2D";
            this.btn_2D.TabStop = false;
            this.btn_2D.UseVisualStyleBackColor = false;
            this.btn_2D.Click += new System.EventHandler(this.btn_2D_Click);
            // 
            // ChooseMode
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.btn_3D);
            this.Controls.Add(this.btn_2D);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ChooseMode";
            this.Load += new System.EventHandler(this.ChooseMode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_3D;
        private System.Windows.Forms.Button btn_2D;
    }
}
