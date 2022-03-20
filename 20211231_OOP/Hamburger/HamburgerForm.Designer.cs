
namespace Hamburger
{
    partial class HamburgerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HamburgerForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.panelMfc = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureHamburger = new System.Windows.Forms.PictureBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnEatIn = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMove = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timerFadeEffect = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.home1 = new Hamburger.Home();
            this.panelLeft.SuspendLayout();
            this.panelMfc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHamburger)).BeginInit();
            this.panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelLeft.Controls.Add(this.btnMainMenu);
            this.panelLeft.Controls.Add(this.panelMfc);
            this.panelLeft.Controls.Add(this.btnPayment);
            this.panelLeft.Controls.Add(this.btnOrders);
            this.panelLeft.Controls.Add(this.btnEatIn);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(203, 786);
            this.panelLeft.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.Image")));
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Location = new System.Drawing.Point(12, 551);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(191, 52);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // panelMfc
            // 
            this.panelMfc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.panelMfc.Controls.Add(this.label2);
            this.panelMfc.Controls.Add(this.label1);
            this.panelMfc.Controls.Add(this.pictureHamburger);
            this.panelMfc.Location = new System.Drawing.Point(36, 0);
            this.panelMfc.Name = "panelMfc";
            this.panelMfc.Size = new System.Drawing.Size(126, 156);
            this.panelMfc.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(20, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hamburgers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "MFC";
            // 
            // pictureHamburger
            // 
            this.pictureHamburger.Image = ((System.Drawing.Image)(resources.GetObject("pictureHamburger.Image")));
            this.pictureHamburger.Location = new System.Drawing.Point(23, 12);
            this.pictureHamburger.Name = "pictureHamburger";
            this.pictureHamburger.Size = new System.Drawing.Size(80, 80);
            this.pictureHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHamburger.TabIndex = 1;
            this.pictureHamburger.TabStop = false;
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(13, 430);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(191, 52);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(13, 353);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(191, 52);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnEatIn
            // 
            this.btnEatIn.FlatAppearance.BorderSize = 0;
            this.btnEatIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEatIn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEatIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEatIn.Image = ((System.Drawing.Image)(resources.GetObject("btnEatIn.Image")));
            this.btnEatIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEatIn.Location = new System.Drawing.Point(13, 276);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(191, 52);
            this.btnEatIn.TabIndex = 1;
            this.btnEatIn.Text = "Eat-In";
            this.btnEatIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEatIn.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 199);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(191, 52);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 52);
            this.panel2.TabIndex = 0;
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.panelMove.Controls.Add(this.button1);
            this.panelMove.Controls.Add(this.btnMinimize);
            this.panelMove.Controls.Add(this.btnClose);
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(1035, 56);
            this.panelMove.TabIndex = 0;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(219, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(942, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(983, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerFadeEffect
            // 
            this.timerFadeEffect.Tick += new System.EventHandler(this.timerFadeEffect_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.progressBar1.Location = new System.Drawing.Point(209, 528);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(799, 40);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 25;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(211)))), ((int)(((byte)(95)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(540, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 96);
            this.button2.TabIndex = 3;
            this.button2.Text = "Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 477);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // home1
            // 
            this.home1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home1.Location = new System.Drawing.Point(202, 65);
            this.home1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(816, 523);
            this.home1.TabIndex = 1;
            // 
            // HamburgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 651);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelMove);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HamburgerForm";
            this.Text = "HamburgerForm";
            this.panelLeft.ResumeLayout(false);
            this.panelMfc.ResumeLayout(false);
            this.panelMfc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHamburger)).EndInit();
            this.panelMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnEatIn;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelMfc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureHamburger;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timerFadeEffect;
        private System.Windows.Forms.Button button1;
        private Home home1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}