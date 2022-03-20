
namespace _20211231_OOP
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPasswordRetry = new System.Windows.Forms.TextBox();
            this.btnSignUpBack = new System.Windows.Forms.Button();
            this.panelMove = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbBirthDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timerFadeEffect = new System.Windows.Forms.Timer(this.components);
            this.btnPasswordChar = new System.Windows.Forms.Button();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Location = new System.Drawing.Point(281, 413);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(312, 73);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbUsername.Location = new System.Drawing.Point(281, 123);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(312, 35);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbPassword.Location = new System.Drawing.Point(281, 171);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(312, 35);
            this.tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password Retry";
            // 
            // tbPasswordRetry
            // 
            this.tbPasswordRetry.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbPasswordRetry.Location = new System.Drawing.Point(281, 220);
            this.tbPasswordRetry.Name = "tbPasswordRetry";
            this.tbPasswordRetry.PasswordChar = '*';
            this.tbPasswordRetry.Size = new System.Drawing.Size(312, 35);
            this.tbPasswordRetry.TabIndex = 1;
            // 
            // btnSignUpBack
            // 
            this.btnSignUpBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpBack.Location = new System.Drawing.Point(393, 509);
            this.btnSignUpBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnSignUpBack.Name = "btnSignUpBack";
            this.btnSignUpBack.Size = new System.Drawing.Size(200, 75);
            this.btnSignUpBack.TabIndex = 0;
            this.btnSignUpBack.Text = "Back";
            this.btnSignUpBack.UseVisualStyleBackColor = true;
            this.btnSignUpBack.Click += new System.EventHandler(this.btnSignUpBack_Click);
            // 
            // panelMove
            // 
            this.panelMove.Controls.Add(this.btnCloseForm);
            this.panelMove.Controls.Add(this.btnMinimize);
            this.panelMove.Controls.Add(this.label6);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(673, 64);
            this.panelMove.TabIndex = 4;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.Location = new System.Drawing.Point(616, 12);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(40, 36);
            this.btnCloseForm.TabIndex = 6;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(570, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 36);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 41);
            this.label6.TabIndex = 2;
            this.label6.Text = "SIGN UP";
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbMail.Location = new System.Drawing.Point(281, 270);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(312, 35);
            this.tbMail.TabIndex = 1;
            // 
            // tbBirthDate
            // 
            this.tbBirthDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbBirthDate.Location = new System.Drawing.Point(281, 321);
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.Size = new System.Drawing.Size(312, 35);
            this.tbBirthDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "BirthDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "(yyyy-mm-dd)";
            // 
            // timerFadeEffect
            // 
            this.timerFadeEffect.Tick += new System.EventHandler(this.timerFadeEffect_Tick);
            // 
            // btnPasswordChar
            // 
            this.btnPasswordChar.FlatAppearance.BorderSize = 0;
            this.btnPasswordChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordChar.Image = ((System.Drawing.Image)(resources.GetObject("btnPasswordChar.Image")));
            this.btnPasswordChar.Location = new System.Drawing.Point(608, 169);
            this.btnPasswordChar.Name = "btnPasswordChar";
            this.btnPasswordChar.Size = new System.Drawing.Size(48, 38);
            this.btnPasswordChar.TabIndex = 10;
            this.btnPasswordChar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPasswordChar.UseVisualStyleBackColor = true;
            this.btnPasswordChar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPasswordChar_MouseDown);
            this.btnPasswordChar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPasswordChar_MouseUp);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(673, 624);
            this.Controls.Add(this.btnPasswordChar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBirthDate);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPasswordRetry);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnSignUpBack);
            this.Controls.Add(this.btnSignUp);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPasswordRetry;
        private System.Windows.Forms.Button btnSignUpBack;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerFadeEffect;
        private System.Windows.Forms.Button btnPasswordChar;
    }
}