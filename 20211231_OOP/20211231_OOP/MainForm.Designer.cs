
namespace _20211231_OOP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_HelloWorld = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnHowOldIAm = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnAbsolute = new System.Windows.Forms.Button();
            this.btnCharacterLeft = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnHamburger = new System.Windows.Forms.Button();
            this.btnCannon = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnPasswordChar = new System.Windows.Forms.Button();
            this.pbLinkedIn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMail = new System.Windows.Forms.PictureBox();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.ttComment = new System.Windows.Forms.ToolTip(this.components);
            this.timerFadeEffect = new System.Windows.Forms.Timer(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panelMove = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkedIn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).BeginInit();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_HelloWorld
            // 
            this.btn_HelloWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HelloWorld.Location = new System.Drawing.Point(32, 12);
            this.btn_HelloWorld.Name = "btn_HelloWorld";
            this.btn_HelloWorld.Size = new System.Drawing.Size(222, 95);
            this.btn_HelloWorld.TabIndex = 0;
            this.btn_HelloWorld.Text = "HELLO WORLD!";
            this.ttComment.SetToolTip(this.btn_HelloWorld, "I\'m a \"Hello World\" text in Message Box");
            this.btn_HelloWorld.UseVisualStyleBackColor = true;
            this.btn_HelloWorld.Click += new System.EventHandler(this.btn_HelloWorld_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.lblHelloWorld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHelloWorld.Location = new System.Drawing.Point(65, 50);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(409, 68);
            this.lblHelloWorld.TabIndex = 5;
            this.lblHelloWorld.Text = "HELLO WORLD";
            // 
            // btnHowOldIAm
            // 
            this.btnHowOldIAm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowOldIAm.Location = new System.Drawing.Point(260, 12);
            this.btnHowOldIAm.Name = "btnHowOldIAm";
            this.btnHowOldIAm.Size = new System.Drawing.Size(222, 95);
            this.btnHowOldIAm.TabIndex = 1;
            this.btnHowOldIAm.Text = "HOW OLD I AM?";
            this.ttComment.SetToolTip(this.btnHowOldIAm, "Don\'t you know your age? \r\nLook at what you\'re worried about. \r\nClick the button!" +
        "");
            this.btnHowOldIAm.UseVisualStyleBackColor = true;
            this.btnHowOldIAm.Click += new System.EventHandler(this.btnHowOldIAm_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Location = new System.Drawing.Point(32, 113);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(222, 95);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.Text = "CALCULATOR";
            this.ttComment.SetToolTip(this.btnCalculator, "Understood. \r\nYou need to calculate.");
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnAbsolute
            // 
            this.btnAbsolute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsolute.Location = new System.Drawing.Point(260, 113);
            this.btnAbsolute.Name = "btnAbsolute";
            this.btnAbsolute.Size = new System.Drawing.Size(222, 95);
            this.btnAbsolute.TabIndex = 3;
            this.btnAbsolute.Text = "Absolute Value";
            this.ttComment.SetToolTip(this.btnAbsolute, "You like math but you don\'t know how to get absolute value? \r\nDude, just click th" +
        "e button");
            this.btnAbsolute.UseVisualStyleBackColor = true;
            this.btnAbsolute.Click += new System.EventHandler(this.btnAbsolute_Click);
            // 
            // btnCharacterLeft
            // 
            this.btnCharacterLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharacterLeft.Location = new System.Drawing.Point(32, 212);
            this.btnCharacterLeft.Name = "btnCharacterLeft";
            this.btnCharacterLeft.Size = new System.Drawing.Size(222, 95);
            this.btnCharacterLeft.TabIndex = 4;
            this.btnCharacterLeft.Text = "How many character left?";
            this.ttComment.SetToolTip(this.btnCharacterLeft, "Can you tell me how many characters I have left? ");
            this.btnCharacterLeft.UseVisualStyleBackColor = true;
            this.btnCharacterLeft.Click += new System.EventHandler(this.btnCharacterLeft_Click);
            // 
            // btnExam
            // 
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Location = new System.Drawing.Point(260, 212);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(222, 95);
            this.btnExam.TabIndex = 5;
            this.btnExam.Text = "Did I get a passing grade in the exam? ";
            this.ttComment.SetToolTip(this.btnExam, "I know my exams but I don\'t know my grade point average.\r\nClickClickClickClickCli" +
        "ckClickClickClickClickClickClickClick");
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnHamburger
            // 
            this.btnHamburger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(27)))), ((int)(((byte)(53)))));
            this.btnHamburger.FlatAppearance.BorderSize = 0;
            this.btnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamburger.Font = new System.Drawing.Font("Microsoft Tai Le", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHamburger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.btnHamburger.Image = ((System.Drawing.Image)(resources.GetObject("btnHamburger.Image")));
            this.btnHamburger.Location = new System.Drawing.Point(32, 414);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(450, 95);
            this.btnHamburger.TabIndex = 7;
            this.btnHamburger.Text = "HAMBURGER";
            this.btnHamburger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHamburger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHamburger.UseVisualStyleBackColor = false;
            this.btnHamburger.Click += new System.EventHandler(this.btnHamburger_Click);
            // 
            // btnCannon
            // 
            this.btnCannon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.btnCannon.FlatAppearance.BorderSize = 0;
            this.btnCannon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCannon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(62)))), ((int)(((byte)(43)))));
            this.btnCannon.Image = ((System.Drawing.Image)(resources.GetObject("btnCannon.Image")));
            this.btnCannon.Location = new System.Drawing.Point(32, 313);
            this.btnCannon.Name = "btnCannon";
            this.btnCannon.Size = new System.Drawing.Size(450, 95);
            this.btnCannon.TabIndex = 6;
            this.btnCannon.Text = "CANNONBALL";
            this.btnCannon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCannon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCannon.UseVisualStyleBackColor = false;
            this.btnCannon.Click += new System.EventHandler(this.btnCannon_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbUsername.Location = new System.Drawing.Point(181, 195);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(248, 35);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Tag = "";
            this.ttComment.SetToolTip(this.tbUsername, "Hey! ");
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPassword.Location = new System.Drawing.Point(181, 281);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(248, 35);
            this.tbPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(181, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(248, 77);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(176, 163);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 29);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btn_HelloWorld);
            this.panelButtons.Controls.Add(this.btnHowOldIAm);
            this.panelButtons.Controls.Add(this.btnAbsolute);
            this.panelButtons.Controls.Add(this.btnExam);
            this.panelButtons.Controls.Add(this.btnHamburger);
            this.panelButtons.Controls.Add(this.btnCalculator);
            this.panelButtons.Controls.Add(this.btnCannon);
            this.panelButtons.Controls.Add(this.btnCharacterLeft);
            this.panelButtons.Location = new System.Drawing.Point(504, 64);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(515, 531);
            this.panelButtons.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.tbUsername);
            this.panelLogin.Controls.Add(this.lblHelloWorld);
            this.panelLogin.Controls.Add(this.pictureBox2);
            this.panelLogin.Controls.Add(this.tbPassword);
            this.panelLogin.Controls.Add(this.btnSignUp);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.lblUsername);
            this.panelLogin.Controls.Add(this.btnPasswordChar);
            this.panelLogin.Location = new System.Drawing.Point(12, 64);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(486, 605);
            this.panelLogin.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Location = new System.Drawing.Point(181, 432);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(248, 77);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnPasswordChar
            // 
            this.btnPasswordChar.FlatAppearance.BorderSize = 0;
            this.btnPasswordChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordChar.Image = ((System.Drawing.Image)(resources.GetObject("btnPasswordChar.Image")));
            this.btnPasswordChar.Location = new System.Drawing.Point(435, 279);
            this.btnPasswordChar.Name = "btnPasswordChar";
            this.btnPasswordChar.Size = new System.Drawing.Size(48, 38);
            this.btnPasswordChar.TabIndex = 4;
            this.btnPasswordChar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPasswordChar.UseVisualStyleBackColor = true;
            this.btnPasswordChar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPasswordChar_MouseDown);
            this.btnPasswordChar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPasswordChar_MouseUp);
            // 
            // pbLinkedIn
            // 
            this.pbLinkedIn.Image = ((System.Drawing.Image)(resources.GetObject("pbLinkedIn.Image")));
            this.pbLinkedIn.Location = new System.Drawing.Point(433, 9);
            this.pbLinkedIn.Name = "pbLinkedIn";
            this.pbLinkedIn.Size = new System.Drawing.Size(48, 48);
            this.pbLinkedIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLinkedIn.TabIndex = 8;
            this.pbLinkedIn.TabStop = false;
            this.ttComment.SetToolTip(this.pbLinkedIn, "LinkedIn");
            this.pbLinkedIn.Click += new System.EventHandler(this.pbLinkedIn_Click);
            this.pbLinkedIn.MouseEnter += new System.EventHandler(this.pbLinkedIn_MouseEnter);
            this.pbLinkedIn.MouseLeave += new System.EventHandler(this.pbLinkedIn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbMail);
            this.panel1.Controls.Add(this.pbLinkedIn);
            this.panel1.Controls.Add(this.btnAdminPanel);
            this.panel1.Location = new System.Drawing.Point(504, 601);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 68);
            this.panel1.TabIndex = 2;
            // 
            // pbMail
            // 
            this.pbMail.Image = ((System.Drawing.Image)(resources.GetObject("pbMail.Image")));
            this.pbMail.Location = new System.Drawing.Point(369, 9);
            this.pbMail.Name = "pbMail";
            this.pbMail.Size = new System.Drawing.Size(48, 48);
            this.pbMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMail.TabIndex = 8;
            this.pbMail.TabStop = false;
            this.ttComment.SetToolTip(this.pbMail, "Mail");
            this.pbMail.Click += new System.EventHandler(this.pbMail_Click);
            this.pbMail.MouseEnter += new System.EventHandler(this.pbMail_MouseEnter);
            this.pbMail.MouseLeave += new System.EventHandler(this.pbMail_MouseLeave);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(171)))), ((int)(((byte)(129)))));
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdminPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminPanel.Image")));
            this.btnAdminPanel.Location = new System.Drawing.Point(32, 0);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(222, 62);
            this.btnAdminPanel.TabIndex = 0;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Visible = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // timerFadeEffect
            // 
            this.timerFadeEffect.Interval = 25;
            this.timerFadeEffect.Tick += new System.EventHandler(this.timerFadeEffect_Tick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(912, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 36);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.Location = new System.Drawing.Point(958, 12);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(40, 36);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // panelMove
            // 
            this.panelMove.Controls.Add(this.btnCloseForm);
            this.panelMove.Controls.Add(this.btnMinimize);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(1029, 58);
            this.panelMove.TabIndex = 3;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1029, 678);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelButtons);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HELLO WORLD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinkedIn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).EndInit();
            this.panelMove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HelloWorld;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btnHowOldIAm;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnAbsolute;
        private System.Windows.Forms.Button btnCharacterLeft;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnHamburger;
        private System.Windows.Forms.Button btnCannon;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbLinkedIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMail;
        private System.Windows.Forms.ToolTip ttComment;
        private System.Windows.Forms.Timer timerFadeEffect;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnPasswordChar;
    }
}

