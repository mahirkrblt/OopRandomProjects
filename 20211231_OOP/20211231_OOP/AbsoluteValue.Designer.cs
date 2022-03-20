
namespace _20211231_OOP
{
    partial class AbsoluteValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsoluteValue));
            this.btnAbsoluteCalculate = new System.Windows.Forms.Button();
            this.tbAbsoluteValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAbsolute = new System.Windows.Forms.Label();
            this.btnAbsoluteClose = new System.Windows.Forms.Button();
            this.btnAbsolueMinimize = new System.Windows.Forms.Button();
            this.panelMove = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.timerFadeEffect = new System.Windows.Forms.Timer(this.components);
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbsoluteCalculate
            // 
            this.btnAbsoluteCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsoluteCalculate.Location = new System.Drawing.Point(14, 201);
            this.btnAbsoluteCalculate.Margin = new System.Windows.Forms.Padding(6);
            this.btnAbsoluteCalculate.Name = "btnAbsoluteCalculate";
            this.btnAbsoluteCalculate.Size = new System.Drawing.Size(289, 76);
            this.btnAbsoluteCalculate.TabIndex = 0;
            this.btnAbsoluteCalculate.Text = "Absolute Calculate";
            this.btnAbsoluteCalculate.UseVisualStyleBackColor = true;
            this.btnAbsoluteCalculate.Click += new System.EventHandler(this.btnAbsoluteCalculate_Click);
            // 
            // tbAbsoluteValue
            // 
            this.tbAbsoluteValue.Location = new System.Drawing.Point(15, 154);
            this.tbAbsoluteValue.Margin = new System.Windows.Forms.Padding(6);
            this.tbAbsoluteValue.Name = "tbAbsoluteValue";
            this.tbAbsoluteValue.Size = new System.Drawing.Size(390, 35);
            this.tbAbsoluteValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "ABSOLUTE VALUE";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(319, 201);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 76);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num";
            // 
            // lblAbsolute
            // 
            this.lblAbsolute.AutoSize = true;
            this.lblAbsolute.Location = new System.Drawing.Point(190, 119);
            this.lblAbsolute.Name = "lblAbsolute";
            this.lblAbsolute.Size = new System.Drawing.Size(27, 29);
            this.lblAbsolute.TabIndex = 5;
            this.lblAbsolute.Text = ":)";
            // 
            // btnAbsoluteClose
            // 
            this.btnAbsoluteClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsoluteClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbsoluteClose.Image = ((System.Drawing.Image)(resources.GetObject("btnAbsoluteClose.Image")));
            this.btnAbsoluteClose.Location = new System.Drawing.Point(365, 12);
            this.btnAbsoluteClose.Name = "btnAbsoluteClose";
            this.btnAbsoluteClose.Size = new System.Drawing.Size(40, 36);
            this.btnAbsoluteClose.TabIndex = 7;
            this.btnAbsoluteClose.UseVisualStyleBackColor = true;
            this.btnAbsoluteClose.Click += new System.EventHandler(this.btnAbsoluteClose_Click);
            // 
            // btnAbsolueMinimize
            // 
            this.btnAbsolueMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsolueMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbsolueMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnAbsolueMinimize.Image")));
            this.btnAbsolueMinimize.Location = new System.Drawing.Point(319, 12);
            this.btnAbsolueMinimize.Name = "btnAbsolueMinimize";
            this.btnAbsolueMinimize.Size = new System.Drawing.Size(40, 36);
            this.btnAbsolueMinimize.TabIndex = 8;
            this.btnAbsolueMinimize.UseVisualStyleBackColor = true;
            this.btnAbsolueMinimize.Click += new System.EventHandler(this.btnAbsolueMinimize_Click);
            // 
            // panelMove
            // 
            this.panelMove.Controls.Add(this.btnCloseForm);
            this.panelMove.Controls.Add(this.btnAbsoluteClose);
            this.panelMove.Controls.Add(this.btnMinimize);
            this.panelMove.Controls.Add(this.btnAbsolueMinimize);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(417, 54);
            this.panelMove.TabIndex = 9;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.Location = new System.Drawing.Point(946, 12);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(40, 36);
            this.btnCloseForm.TabIndex = 6;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(900, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 36);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // timerFadeEffect
            // 
            this.timerFadeEffect.Interval = 25;
            this.timerFadeEffect.Tick += new System.EventHandler(this.timerFadeEffect_Tick);
            // 
            // AbsoluteValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(417, 294);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.lblAbsolute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAbsoluteValue);
            this.Controls.Add(this.btnAbsoluteCalculate);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AbsoluteValue";
            this.Text = "AbsoluteValue";
            this.Load += new System.EventHandler(this.AbsoluteValue_Load);
            this.panelMove.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbsoluteCalculate;
        private System.Windows.Forms.TextBox tbAbsoluteValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAbsolute;
        private System.Windows.Forms.Button btnAbsoluteClose;
        private System.Windows.Forms.Button btnAbsolueMinimize;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timerFadeEffect;
    }
}