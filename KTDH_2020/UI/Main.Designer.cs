
namespace KTDH_2020
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.pnl_Mode = new System.Windows.Forms.Panel();
            this.pnl_Change = new System.Windows.Forms.Panel();
            this.btn_Toolbar = new System.Windows.Forms.Button();
            this.pnl_WorkStation = new System.Windows.Forms.Panel();
            this.picb_2DArea = new System.Windows.Forms.PictureBox();
            this.picb_3DArea = new System.Windows.Forms.PictureBox();
            this.pnl_Tb_3D = new System.Windows.Forms.Panel();
            this.grb_3Dobject = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Tb_2D = new System.Windows.Forms.Panel();
            this.grb_2DShapes = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.grb_2DLine = new System.Windows.Forms.GroupBox();
            this.pnl_ToolBox = new System.Windows.Forms.Panel();
            this.pnl_Mode.SuspendLayout();
            this.pnl_Change.SuspendLayout();
            this.pnl_WorkStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_2DArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_3DArea)).BeginInit();
            this.pnl_Tb_3D.SuspendLayout();
            this.grb_3Dobject.SuspendLayout();
            this.pnl_Tb_2D.SuspendLayout();
            this.grb_2DShapes.SuspendLayout();
            this.pnl_ToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Mode
            // 
            this.pnl_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_Mode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_Mode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Mode.Controls.Add(this.pnl_Change);
            this.pnl_Mode.Location = new System.Drawing.Point(2, 2);
            this.pnl_Mode.Name = "pnl_Mode";
            this.pnl_Mode.Size = new System.Drawing.Size(260, 256);
            this.pnl_Mode.TabIndex = 0;
            this.pnl_Mode.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Mode_Paint);
            // 
            // pnl_Change
            // 
            this.pnl_Change.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_Change.Controls.Add(this.btn_Toolbar);
            this.pnl_Change.Location = new System.Drawing.Point(36, 6);
            this.pnl_Change.Name = "pnl_Change";
            this.pnl_Change.Size = new System.Drawing.Size(177, 70);
            this.pnl_Change.TabIndex = 2;
            // 
            // btn_Toolbar
            // 
            this.btn_Toolbar.BackColor = System.Drawing.Color.White;
            this.btn_Toolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Toolbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Toolbar.FlatAppearance.BorderSize = 0;
            this.btn_Toolbar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Toolbar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Toolbar.ForeColor = System.Drawing.Color.Black;
            this.btn_Toolbar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Toolbar.Location = new System.Drawing.Point(12, 3);
            this.btn_Toolbar.Name = "btn_Toolbar";
            this.btn_Toolbar.Size = new System.Drawing.Size(154, 60);
            this.btn_Toolbar.TabIndex = 0;
            this.btn_Toolbar.Tag = "";
            this.btn_Toolbar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Toolbar.UseVisualStyleBackColor = false;
            this.btn_Toolbar.Click += new System.EventHandler(this.Btn_Toolbar_Click);
            // 
            // pnl_WorkStation
            // 
            this.pnl_WorkStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_WorkStation.AutoScroll = true;
            this.pnl_WorkStation.AutoSize = true;
            this.pnl_WorkStation.BackColor = System.Drawing.Color.White;
            this.pnl_WorkStation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_WorkStation.Controls.Add(this.picb_2DArea);
            this.pnl_WorkStation.Controls.Add(this.picb_3DArea);
            this.pnl_WorkStation.Location = new System.Drawing.Point(259, 2);
            this.pnl_WorkStation.Name = "pnl_WorkStation";
            this.pnl_WorkStation.Size = new System.Drawing.Size(1097, 691);
            this.pnl_WorkStation.TabIndex = 3;
            // 
            // picb_2DArea
            // 
            this.picb_2DArea.BackColor = System.Drawing.Color.Honeydew;
            this.picb_2DArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picb_2DArea.Location = new System.Drawing.Point(3, 0);
            this.picb_2DArea.Name = "picb_2DArea";
            this.picb_2DArea.Size = new System.Drawing.Size(580, 513);
            this.picb_2DArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picb_2DArea.TabIndex = 1;
            this.picb_2DArea.TabStop = false;
            this.picb_2DArea.SizeChanged += new System.EventHandler(this.picb_2DArea_SizeChanged);
            this.picb_2DArea.Click += new System.EventHandler(this.Picb_2DArea_Click);
            this.picb_2DArea.Paint += new System.Windows.Forms.PaintEventHandler(this.picb_2DArea_Paint);
            // 
            // picb_3DArea
            // 
            this.picb_3DArea.BackColor = System.Drawing.Color.LightCyan;
            this.picb_3DArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picb_3DArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picb_3DArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picb_3DArea.Location = new System.Drawing.Point(0, 0);
            this.picb_3DArea.Name = "picb_3DArea";
            this.picb_3DArea.Size = new System.Drawing.Size(1093, 687);
            this.picb_3DArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_3DArea.TabIndex = 1;
            this.picb_3DArea.TabStop = false;
            this.picb_3DArea.SizeChanged += new System.EventHandler(this.Picb_3DArea_SizeChanged);
            this.picb_3DArea.Paint += new System.Windows.Forms.PaintEventHandler(this.Picb_3DArea_Paint);
            // 
            // pnl_Tb_3D
            // 
            this.pnl_Tb_3D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Tb_3D.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_Tb_3D.Controls.Add(this.grb_3Dobject);
            this.pnl_Tb_3D.Location = new System.Drawing.Point(-1, 0);
            this.pnl_Tb_3D.Name = "pnl_Tb_3D";
            this.pnl_Tb_3D.Size = new System.Drawing.Size(260, 603);
            this.pnl_Tb_3D.TabIndex = 1;
            // 
            // grb_3Dobject
            // 
            this.grb_3Dobject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_3Dobject.BackColor = System.Drawing.Color.AliceBlue;
            this.grb_3Dobject.Controls.Add(this.button2);
            this.grb_3Dobject.Controls.Add(this.button22);
            this.grb_3Dobject.Controls.Add(this.button24);
            this.grb_3Dobject.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_3Dobject.ForeColor = System.Drawing.Color.DarkCyan;
            this.grb_3Dobject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grb_3Dobject.Location = new System.Drawing.Point(10, 3);
            this.grb_3Dobject.Name = "grb_3Dobject";
            this.grb_3Dobject.Size = new System.Drawing.Size(238, 588);
            this.grb_3Dobject.TabIndex = 1;
            this.grb_3Dobject.TabStop = false;
            this.grb_3Dobject.Enter += new System.EventHandler(this.grb_3Dobject_Enter);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::KTDH_2020.Image_Res.delete;
            this.button2.Location = new System.Drawing.Point(81, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Tag = "Xóa Hình";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Image = global::KTDH_2020.Properties.Resources.shapesphere_120489;
            this.button22.Location = new System.Drawing.Point(47, 60);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(152, 150);
            this.button22.TabIndex = 10;
            this.button22.Tag = "Hinh Cau";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.Button_Click);
            this.button22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN3D_MouseDown);
            this.button22.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button22.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Image = global::KTDH_2020.Image_Res.cude;
            this.button24.Location = new System.Drawing.Point(47, 231);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(152, 150);
            this.button24.TabIndex = 8;
            this.button24.Tag = "Hinh Lap Phuong";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.Button_Click);
            this.button24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN3D_MouseDown);
            this.button24.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button24.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_Tb_2D
            // 
            this.pnl_Tb_2D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Tb_2D.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_Tb_2D.Controls.Add(this.grb_2DShapes);
            this.pnl_Tb_2D.Controls.Add(this.grb_2DLine);
            this.pnl_Tb_2D.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tb_2D.Name = "pnl_Tb_2D";
            this.pnl_Tb_2D.Size = new System.Drawing.Size(260, 603);
            this.pnl_Tb_2D.TabIndex = 0;
            // 
            // grb_2DShapes
            // 
            this.grb_2DShapes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_2DShapes.BackColor = System.Drawing.Color.AliceBlue;
            this.grb_2DShapes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grb_2DShapes.Controls.Add(this.button1);
            this.grb_2DShapes.Controls.Add(this.button9);
            this.grb_2DShapes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_2DShapes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grb_2DShapes.Location = new System.Drawing.Point(10, 3);
            this.grb_2DShapes.Name = "grb_2DShapes";
            this.grb_2DShapes.Size = new System.Drawing.Size(238, 588);
            this.grb_2DShapes.TabIndex = 1;
            this.grb_2DShapes.TabStop = false;
            this.grb_2DShapes.Enter += new System.EventHandler(this.grb_2DShapes_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 209);
            this.button1.TabIndex = 15;
            this.button1.Tag = "SpaceX";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::KTDH_2020.Image_Res._1455554775_line_85_icon_icons_com_53362;
            this.button9.Location = new System.Drawing.Point(11, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(213, 283);
            this.button9.TabIndex = 15;
            this.button9.Tag = "SpaceX";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.button9.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // grb_2DLine
            // 
            this.grb_2DLine.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grb_2DLine.Location = new System.Drawing.Point(29, 71);
            this.grb_2DLine.Name = "grb_2DLine";
            this.grb_2DLine.Size = new System.Drawing.Size(192, 58);
            this.grb_2DLine.TabIndex = 0;
            this.grb_2DLine.TabStop = false;
            this.grb_2DLine.Text = "Line";
            // 
            // pnl_ToolBox
            // 
            this.pnl_ToolBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_ToolBox.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ToolBox.Controls.Add(this.pnl_Tb_2D);
            this.pnl_ToolBox.Controls.Add(this.pnl_Tb_3D);
            this.pnl_ToolBox.Location = new System.Drawing.Point(3, 86);
            this.pnl_ToolBox.Name = "pnl_ToolBox";
            this.pnl_ToolBox.Size = new System.Drawing.Size(259, 603);
            this.pnl_ToolBox.TabIndex = 1;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 690);
            this.Controls.Add(this.pnl_WorkStation);
            this.Controls.Add(this.pnl_ToolBox);
            this.Controls.Add(this.pnl_Mode);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "Vẽ hình cơ bản - Nhóm 12 - D17CQCN03";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.pnl_Mode.ResumeLayout(false);
            this.pnl_Change.ResumeLayout(false);
            this.pnl_WorkStation.ResumeLayout(false);
            this.pnl_WorkStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_2DArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_3DArea)).EndInit();
            this.pnl_Tb_3D.ResumeLayout(false);
            this.grb_3Dobject.ResumeLayout(false);
            this.grb_3Dobject.PerformLayout();
            this.pnl_Tb_2D.ResumeLayout(false);
            this.grb_2DShapes.ResumeLayout(false);
            this.pnl_ToolBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Panel pnl_Mode;
        private System.Windows.Forms.Panel pnl_WorkStation;
        private System.Windows.Forms.PictureBox picb_2DArea;
        private System.Windows.Forms.PictureBox picb_3DArea;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_Tb_2D;
        private System.Windows.Forms.GroupBox grb_2DShapes;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel pnl_Tb_3D;
        private System.Windows.Forms.GroupBox grb_3Dobject;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Panel pnl_ToolBox;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnl_Change;
        private System.Windows.Forms.Button btn_Toolbar;
        private System.Windows.Forms.GroupBox grb_2DLine;
        private System.Windows.Forms.Button button1;
    }
}

