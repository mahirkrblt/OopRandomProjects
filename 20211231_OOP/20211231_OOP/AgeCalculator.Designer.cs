
namespace _20211231_OOP
{
    partial class AgeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeCalculator));
            this.btnAgeCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAgeCalculate = new System.Windows.Forms.DateTimePicker();
            this.btnAgeCalculatorBack = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnAbsolueMinimize = new System.Windows.Forms.Button();
            this.panelMove = new System.Windows.Forms.Panel();
            this.timerFadeEffect = new System.Windows.Forms.Timer(this.components);
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgeCalculate
            // 
            this.btnAgeCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgeCalculate.Location = new System.Drawing.Point(93, 137);
            this.btnAgeCalculate.Name = "btnAgeCalculate";
            this.btnAgeCalculate.Size = new System.Drawing.Size(341, 108);
            this.btnAgeCalculate.TabIndex = 0;
            this.btnAgeCalculate.Text = "Calculate";
            this.btnAgeCalculate.UseVisualStyleBackColor = true;
            this.btnAgeCalculate.Click += new System.EventHandler(this.btnAgeCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOW OLD I AM?";
            // 
            // dtpAgeCalculate
            // 
            this.dtpAgeCalculate.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dtpAgeCalculate.Location = new System.Drawing.Point(18, 84);
            this.dtpAgeCalculate.Name = "dtpAgeCalculate";
            this.dtpAgeCalculate.Size = new System.Drawing.Size(495, 32);
            this.dtpAgeCalculate.TabIndex = 3;
            // 
            // btnAgeCalculatorBack
            // 
            this.btnAgeCalculatorBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgeCalculatorBack.Location = new System.Drawing.Point(198, 269);
            this.btnAgeCalculatorBack.Name = "btnAgeCalculatorBack";
            this.btnAgeCalculatorBack.Size = new System.Drawing.Size(123, 71);
            this.btnAgeCalculatorBack.TabIndex = 4;
            this.btnAgeCalculatorBack.Text = "Back";
            this.btnAgeCalculatorBack.UseVisualStyleBackColor = true;
            this.btnAgeCalculatorBack.Click += new System.EventHandler(this.btnAgeCalculatorBack_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.Location = new System.Drawing.Point(467, 12);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(40, 36);
            this.btnCloseForm.TabIndex = 9;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnAbsolueMinimize
            // 
            this.btnAbsolueMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsolueMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbsolueMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnAbsolueMinimize.Image")));
            this.btnAbsolueMinimize.Location = new System.Drawing.Point(421, 12);
            this.btnAbsolueMinimize.Name = "btnAbsolueMinimize";
            this.btnAbsolueMinimize.Size = new System.Drawing.Size(40, 36);
            this.btnAbsolueMinimize.TabIndex = 10;
            this.btnAbsolueMinimize.UseVisualStyleBackColor = true;
            this.btnAbsolueMinimize.Click += new System.EventHandler(this.btnAbsolueMinimize_Click);
            // 
            // panelMove
            // 
            this.panelMove.Controls.Add(this.btnCloseForm);
            this.panelMove.Controls.Add(this.btnAbsolueMinimize);
            this.panelMove.Controls.Add(this.label1);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(527, 64);
            this.panelMove.TabIndex = 11;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // timerFadeEffect
            // 
            this.timerFadeEffect.Interval = 25;
            this.timerFadeEffect.Tick += new System.EventHandler(this.timerFadeEffect_Tick);
            // 
            // AgeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(527, 356);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.btnAgeCalculatorBack);
            this.Controls.Add(this.dtpAgeCalculate);
            this.Controls.Add(this.btnAgeCalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AgeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgeCalculator";
            this.Load += new System.EventHandler(this.AgeCalculator_Load);
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgeCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAgeCalculate;
        private System.Windows.Forms.Button btnAgeCalculatorBack;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnAbsolueMinimize;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Timer timerFadeEffect;
    }
}