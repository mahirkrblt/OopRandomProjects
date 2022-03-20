
namespace _20211231_OOP
{
    partial class CannonBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CannonBall));
            this.panelMove = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.progressAmmo = new System.Windows.Forms.ProgressBar();
            this.btnReload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFire = new System.Windows.Forms.Button();
            this.pbCannonGuy = new System.Windows.Forms.PictureBox();
            this.pbExplosion = new System.Windows.Forms.PictureBox();
            this.pbFire2 = new System.Windows.Forms.PictureBox();
            this.pbFire1 = new System.Windows.Forms.PictureBox();
            this.pbFire3 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerFadeEffect = new System.Windows.Forms.Timer(this.components);
            this.panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCannonGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMove
            // 
            this.panelMove.Controls.Add(this.pictureBox1);
            this.panelMove.Controls.Add(this.pbExit);
            this.panelMove.Controls.Add(this.pbMinimize);
            this.panelMove.Controls.Add(this.label1);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(984, 98);
            this.panelMove.TabIndex = 0;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(871, 5);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(90, 90);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 3;
            this.pbExit.TabStop = false;
            this.toolTip.SetToolTip(this.pbExit, "Exit");
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(781, 5);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(90, 90);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 3;
            this.pbMinimize.TabStop = false;
            this.toolTip.SetToolTip(this.pbMinimize, "Minimize");
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(62)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "CannonBall";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(171)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.pbMainMenu);
            this.panel1.Controls.Add(this.lblAmmo);
            this.panel1.Controls.Add(this.progressAmmo);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnFire);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 141);
            this.panel1.TabIndex = 1;
            // 
            // pbMainMenu
            // 
            this.pbMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMainMenu.Image")));
            this.pbMainMenu.Location = new System.Drawing.Point(861, 26);
            this.pbMainMenu.Name = "pbMainMenu";
            this.pbMainMenu.Size = new System.Drawing.Size(100, 100);
            this.pbMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainMenu.TabIndex = 5;
            this.pbMainMenu.TabStop = false;
            this.toolTip.SetToolTip(this.pbMainMenu, "Main Menu");
            this.pbMainMenu.Click += new System.EventHandler(this.pbMainMenu_Click);
            this.pbMainMenu.MouseEnter += new System.EventHandler(this.pbMainMenu_MouseEnter);
            this.pbMainMenu.MouseLeave += new System.EventHandler(this.pbMainMenu_MouseLeave);
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(742, 36);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(24, 27);
            this.lblAmmo.TabIndex = 2;
            this.lblAmmo.Text = "0";
            // 
            // progressAmmo
            // 
            this.progressAmmo.Location = new System.Drawing.Point(592, 66);
            this.progressAmmo.Maximum = 50;
            this.progressAmmo.Name = "progressAmmo";
            this.progressAmmo.Size = new System.Drawing.Size(223, 49);
            this.progressAmmo.TabIndex = 3;
            this.toolTip.SetToolTip(this.progressAmmo, "Ammo");
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(285, 37);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(236, 78);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "AMMO:";
            // 
            // btnFire
            // 
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFire.Location = new System.Drawing.Point(23, 37);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(236, 78);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            this.btnFire.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFire_MouseDown);
            this.btnFire.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFire_MouseUp);
            // 
            // pbCannonGuy
            // 
            this.pbCannonGuy.Image = ((System.Drawing.Image)(resources.GetObject("pbCannonGuy.Image")));
            this.pbCannonGuy.Location = new System.Drawing.Point(31, 159);
            this.pbCannonGuy.Name = "pbCannonGuy";
            this.pbCannonGuy.Size = new System.Drawing.Size(180, 180);
            this.pbCannonGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCannonGuy.TabIndex = 2;
            this.pbCannonGuy.TabStop = false;
            // 
            // pbExplosion
            // 
            this.pbExplosion.Image = ((System.Drawing.Image)(resources.GetObject("pbExplosion.Image")));
            this.pbExplosion.Location = new System.Drawing.Point(209, 218);
            this.pbExplosion.Name = "pbExplosion";
            this.pbExplosion.Size = new System.Drawing.Size(50, 50);
            this.pbExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExplosion.TabIndex = 2;
            this.pbExplosion.TabStop = false;
            this.pbExplosion.Visible = false;
            // 
            // pbFire2
            // 
            this.pbFire2.Image = ((System.Drawing.Image)(resources.GetObject("pbFire2.Image")));
            this.pbFire2.Location = new System.Drawing.Point(607, 161);
            this.pbFire2.Name = "pbFire2";
            this.pbFire2.Size = new System.Drawing.Size(180, 180);
            this.pbFire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFire2.TabIndex = 2;
            this.pbFire2.TabStop = false;
            this.pbFire2.Visible = false;
            // 
            // pbFire1
            // 
            this.pbFire1.Image = ((System.Drawing.Image)(resources.GetObject("pbFire1.Image")));
            this.pbFire1.Location = new System.Drawing.Point(790, 161);
            this.pbFire1.Name = "pbFire1";
            this.pbFire1.Size = new System.Drawing.Size(180, 180);
            this.pbFire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFire1.TabIndex = 2;
            this.pbFire1.TabStop = false;
            this.pbFire1.Visible = false;
            // 
            // pbFire3
            // 
            this.pbFire3.Image = ((System.Drawing.Image)(resources.GetObject("pbFire3.Image")));
            this.pbFire3.Location = new System.Drawing.Point(421, 161);
            this.pbFire3.Name = "pbFire3";
            this.pbFire3.Size = new System.Drawing.Size(180, 180);
            this.pbFire3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFire3.TabIndex = 2;
            this.pbFire3.TabStop = false;
            this.pbFire3.Visible = false;
            // 
            // timerFadeEffect
            // 
            this.timerFadeEffect.Tick += new System.EventHandler(this.timerFadeEffect_Tick);
            // 
            // CannonBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(984, 482);
            this.Controls.Add(this.pbFire1);
            this.Controls.Add(this.pbFire3);
            this.Controls.Add(this.pbFire2);
            this.Controls.Add(this.pbExplosion);
            this.Controls.Add(this.pbCannonGuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMove);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "CannonBall";
            this.Text = "CannonBall";
            this.Load += new System.EventHandler(this.CannonBall_Load);
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCannonGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressAmmo;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbCannonGuy;
        private System.Windows.Forms.PictureBox pbExplosion;
        private System.Windows.Forms.PictureBox pbFire2;
        private System.Windows.Forms.PictureBox pbFire1;
        private System.Windows.Forms.PictureBox pbFire3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMainMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timerFadeEffect;
    }
}