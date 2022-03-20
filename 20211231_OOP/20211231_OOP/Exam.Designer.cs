
namespace _20211231_OOP
{
    partial class Exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            this.panelMove = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblHowMany = new System.Windows.Forms.Label();
            this.tbLessonName1 = new System.Windows.Forms.TextBox();
            this.tbLessonName2 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbLessons = new System.Windows.Forms.ListBox();
            this.lbGradePoint = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLessonName3 = new System.Windows.Forms.TextBox();
            this.tbLessonName4 = new System.Windows.Forms.TextBox();
            this.tbLessonName5 = new System.Windows.Forms.TextBox();
            this.tbLessonName6 = new System.Windows.Forms.TextBox();
            this.tbLessonName7 = new System.Windows.Forms.TextBox();
            this.tbLessonName8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.timerFadeEffect = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbLessonCount = new System.Windows.Forms.ComboBox();
            this.cbLetter8 = new System.Windows.Forms.ComboBox();
            this.cbLetter4 = new System.Windows.Forms.ComboBox();
            this.cbLetter6 = new System.Windows.Forms.ComboBox();
            this.cbLetter2 = new System.Windows.Forms.ComboBox();
            this.cbLetter7 = new System.Windows.Forms.ComboBox();
            this.cbLetter3 = new System.Windows.Forms.ComboBox();
            this.cbLetter5 = new System.Windows.Forms.ComboBox();
            this.cbLetter1 = new System.Windows.Forms.ComboBox();
            this.cbUnit8 = new System.Windows.Forms.ComboBox();
            this.cbUnit4 = new System.Windows.Forms.ComboBox();
            this.cbUnit7 = new System.Windows.Forms.ComboBox();
            this.cbUnit3 = new System.Windows.Forms.ComboBox();
            this.cbUnit6 = new System.Windows.Forms.ComboBox();
            this.cbUnit2 = new System.Windows.Forms.ComboBox();
            this.cbUnit5 = new System.Windows.Forms.ComboBox();
            this.cbUnit1 = new System.Windows.Forms.ComboBox();
            this.panelMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMove
            // 
            this.panelMove.Controls.Add(this.btnCloseForm);
            this.panelMove.Controls.Add(this.btnMinimize);
            this.panelMove.Controls.Add(this.lblHowMany);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(1078, 64);
            this.panelMove.TabIndex = 29;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.Location = new System.Drawing.Point(1011, 12);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(40, 36);
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(965, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 36);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblHowMany
            // 
            this.lblHowMany.AutoSize = true;
            this.lblHowMany.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowMany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHowMany.Location = new System.Drawing.Point(10, 17);
            this.lblHowMany.Name = "lblHowMany";
            this.lblHowMany.Size = new System.Drawing.Size(482, 31);
            this.lblHowMany.TabIndex = 0;
            this.lblHowMany.Text = "Do you calculate my grade point for me?";
            this.toolTip1.SetToolTip(this.lblHowMany, "Okey. I do");
            // 
            // tbLessonName1
            // 
            this.tbLessonName1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbLessonName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLessonName1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLessonName1.Location = new System.Drawing.Point(20, 227);
            this.tbLessonName1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbLessonName1.Name = "tbLessonName1";
            this.tbLessonName1.Size = new System.Drawing.Size(222, 28);
            this.tbLessonName1.TabIndex = 1;
            // 
            // tbLessonName2
            // 
            this.tbLessonName2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbLessonName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLessonName2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLessonName2.Location = new System.Drawing.Point(20, 273);
            this.tbLessonName2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbLessonName2.Name = "tbLessonName2";
            this.tbLessonName2.Size = new System.Drawing.Size(222, 28);
            this.tbLessonName2.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(944, 552);
            this.btnBack.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 42);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbLessons
            // 
            this.lbLessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.lbLessons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLessons.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbLessons.FormattingEnabled = true;
            this.lbLessons.HorizontalScrollbar = true;
            this.lbLessons.ItemHeight = 27;
            this.lbLessons.Location = new System.Drawing.Point(575, 223);
            this.lbLessons.Name = "lbLessons";
            this.lbLessons.Size = new System.Drawing.Size(487, 324);
            this.lbLessons.TabIndex = 27;
            // 
            // lbGradePoint
            // 
            this.lbGradePoint.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbGradePoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbGradePoint.FormattingEnabled = true;
            this.lbGradePoint.ItemHeight = 27;
            this.lbGradePoint.Location = new System.Drawing.Point(832, 106);
            this.lbGradePoint.Name = "lbGradePoint";
            this.lbGradePoint.Size = new System.Drawing.Size(230, 81);
            this.lbGradePoint.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "Lesson Count (Max 8)";
            // 
            // tbLessonName3
            // 
            this.tbLessonName3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbLessonName3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLessonName3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLessonName3.Location = new System.Drawing.Point(20, 319);
            this.tbLessonName3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbLessonName3.Name = "tbLessonName3";
            this.tbLessonName3.Size = new System.Drawing.Size(222, 28);
            this.tbLessonName3.TabIndex = 3;
            // 
            // tbLessonName4
            // 
            this.tbLessonName4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbLessonName4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLessonName4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLessonName4.Location = new System.Drawing.Point(20, 365);
            this.tbLessonName4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbLessonName4.Name = "tbLessonName4";
            this.tbLessonName4.Size = new System.Drawing.Size(222, 28);
            this.tbLessonName4.TabIndex = 4;
            // 
            // tbLessonName5
            // 
            this.tbLessonName5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbLessonName5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLessonName5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLessonName5.Location = new System.Drawing.Point(20, 411);
            this.tbLessonName5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbLessonName5.Name = "tbLessonName5";
            this.tbLessonName5.Size = new System.Drawing.Size(222, 28);
            this.tbLessonName5.TabIndex = 5;
            // 
            // tbLessonName6
            // 
            this.tbLessonName6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbLessonName6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLessonName6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLessonName6.Location = new System.Drawing.Point(20, 457);
            this.tbLessonName6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbLessonName6.Name = "tbLessonName6";
            this.tbLessonName6.Size = new System.Drawing.Size(222, 28);
            this.tbLessonName6.TabIndex = 6;
            // 
            // tbLessonName7
            // 
            this.tbLessonName7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbLessonName7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLessonName7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLessonName7.Location = new System.Drawing.Point(20, 503);
            this.tbLessonName7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbLessonName7.Name = "tbLessonName7";
            this.tbLessonName7.Size = new System.Drawing.Size(222, 28);
            this.tbLessonName7.TabIndex = 7;
            // 
            // tbLessonName8
            // 
            this.tbLessonName8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbLessonName8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLessonName8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLessonName8.Location = new System.Drawing.Point(20, 552);
            this.tbLessonName8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbLessonName8.Name = "tbLessonName8";
            this.tbLessonName8.Size = new System.Drawing.Size(222, 28);
            this.tbLessonName8.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Lesson Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Course Units";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Letter Grade";
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(575, 106);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(251, 81);
            this.btnCalculate.TabIndex = 25;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // timerFadeEffect
            // 
            this.timerFadeEffect.Interval = 25;
            this.timerFadeEffect.Tick += new System.EventHandler(this.timerFadeEffect_Tick);
            // 
            // cbLessonCount
            // 
            this.cbLessonCount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLessonCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLessonCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLessonCount.FormattingEnabled = true;
            this.cbLessonCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbLessonCount.Location = new System.Drawing.Point(20, 130);
            this.cbLessonCount.Name = "cbLessonCount";
            this.cbLessonCount.Size = new System.Drawing.Size(222, 35);
            this.cbLessonCount.TabIndex = 0;
            this.cbLessonCount.SelectedIndexChanged += new System.EventHandler(this.cbLessonCount_SelectedIndexChanged);
            // 
            // cbLetter8
            // 
            this.cbLetter8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLetter8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLetter8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLetter8.FormattingEnabled = true;
            this.cbLetter8.Items.AddRange(new object[] {
            "AA",
            "AB",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cbLetter8.Location = new System.Drawing.Point(404, 548);
            this.cbLetter8.Name = "cbLetter8";
            this.cbLetter8.Size = new System.Drawing.Size(121, 29);
            this.cbLetter8.TabIndex = 24;
            // 
            // cbLetter4
            // 
            this.cbLetter4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLetter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLetter4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLetter4.FormattingEnabled = true;
            this.cbLetter4.Items.AddRange(new object[] {
            "AA",
            "AB",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cbLetter4.Location = new System.Drawing.Point(404, 364);
            this.cbLetter4.Name = "cbLetter4";
            this.cbLetter4.Size = new System.Drawing.Size(121, 29);
            this.cbLetter4.TabIndex = 20;
            // 
            // cbLetter6
            // 
            this.cbLetter6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLetter6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLetter6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLetter6.FormattingEnabled = true;
            this.cbLetter6.Items.AddRange(new object[] {
            "AA",
            "AB",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cbLetter6.Location = new System.Drawing.Point(404, 456);
            this.cbLetter6.Name = "cbLetter6";
            this.cbLetter6.Size = new System.Drawing.Size(121, 29);
            this.cbLetter6.TabIndex = 22;
            // 
            // cbLetter2
            // 
            this.cbLetter2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLetter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLetter2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLetter2.FormattingEnabled = true;
            this.cbLetter2.Items.AddRange(new object[] {
            "AA",
            "AB",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cbLetter2.Location = new System.Drawing.Point(404, 272);
            this.cbLetter2.Name = "cbLetter2";
            this.cbLetter2.Size = new System.Drawing.Size(121, 29);
            this.cbLetter2.TabIndex = 18;
            // 
            // cbLetter7
            // 
            this.cbLetter7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLetter7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLetter7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLetter7.FormattingEnabled = true;
            this.cbLetter7.Items.AddRange(new object[] {
            "AA",
            "AB",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cbLetter7.Location = new System.Drawing.Point(404, 502);
            this.cbLetter7.Name = "cbLetter7";
            this.cbLetter7.Size = new System.Drawing.Size(121, 29);
            this.cbLetter7.TabIndex = 23;
            // 
            // cbLetter3
            // 
            this.cbLetter3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLetter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLetter3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLetter3.FormattingEnabled = true;
            this.cbLetter3.Items.AddRange(new object[] {
            "AA",
            "AB",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cbLetter3.Location = new System.Drawing.Point(404, 318);
            this.cbLetter3.Name = "cbLetter3";
            this.cbLetter3.Size = new System.Drawing.Size(121, 29);
            this.cbLetter3.TabIndex = 19;
            // 
            // cbLetter5
            // 
            this.cbLetter5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLetter5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLetter5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLetter5.FormattingEnabled = true;
            this.cbLetter5.Items.AddRange(new object[] {
            "AA",
            "AB",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cbLetter5.Location = new System.Drawing.Point(404, 410);
            this.cbLetter5.Name = "cbLetter5";
            this.cbLetter5.Size = new System.Drawing.Size(121, 29);
            this.cbLetter5.TabIndex = 21;
            // 
            // cbLetter1
            // 
            this.cbLetter1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLetter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLetter1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLetter1.FormattingEnabled = true;
            this.cbLetter1.Items.AddRange(new object[] {
            "AA",
            "AB",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cbLetter1.Location = new System.Drawing.Point(404, 226);
            this.cbLetter1.Name = "cbLetter1";
            this.cbLetter1.Size = new System.Drawing.Size(121, 29);
            this.cbLetter1.TabIndex = 17;
            // 
            // cbUnit8
            // 
            this.cbUnit8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUnit8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit8.FormattingEnabled = true;
            this.cbUnit8.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.cbUnit8.Location = new System.Drawing.Point(260, 548);
            this.cbUnit8.Name = "cbUnit8";
            this.cbUnit8.Size = new System.Drawing.Size(121, 29);
            this.cbUnit8.TabIndex = 16;
            // 
            // cbUnit4
            // 
            this.cbUnit4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUnit4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit4.FormattingEnabled = true;
            this.cbUnit4.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.cbUnit4.Location = new System.Drawing.Point(260, 364);
            this.cbUnit4.Name = "cbUnit4";
            this.cbUnit4.Size = new System.Drawing.Size(121, 29);
            this.cbUnit4.TabIndex = 12;
            // 
            // cbUnit7
            // 
            this.cbUnit7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUnit7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit7.FormattingEnabled = true;
            this.cbUnit7.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.cbUnit7.Location = new System.Drawing.Point(260, 502);
            this.cbUnit7.Name = "cbUnit7";
            this.cbUnit7.Size = new System.Drawing.Size(121, 29);
            this.cbUnit7.TabIndex = 15;
            // 
            // cbUnit3
            // 
            this.cbUnit3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUnit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit3.FormattingEnabled = true;
            this.cbUnit3.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.cbUnit3.Location = new System.Drawing.Point(260, 318);
            this.cbUnit3.Name = "cbUnit3";
            this.cbUnit3.Size = new System.Drawing.Size(121, 29);
            this.cbUnit3.TabIndex = 11;
            // 
            // cbUnit6
            // 
            this.cbUnit6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUnit6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit6.FormattingEnabled = true;
            this.cbUnit6.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.cbUnit6.Location = new System.Drawing.Point(260, 456);
            this.cbUnit6.Name = "cbUnit6";
            this.cbUnit6.Size = new System.Drawing.Size(121, 29);
            this.cbUnit6.TabIndex = 14;
            // 
            // cbUnit2
            // 
            this.cbUnit2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUnit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit2.FormattingEnabled = true;
            this.cbUnit2.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.cbUnit2.Location = new System.Drawing.Point(260, 272);
            this.cbUnit2.Name = "cbUnit2";
            this.cbUnit2.Size = new System.Drawing.Size(121, 29);
            this.cbUnit2.TabIndex = 10;
            // 
            // cbUnit5
            // 
            this.cbUnit5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUnit5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit5.FormattingEnabled = true;
            this.cbUnit5.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.cbUnit5.Location = new System.Drawing.Point(260, 410);
            this.cbUnit5.Name = "cbUnit5";
            this.cbUnit5.Size = new System.Drawing.Size(121, 29);
            this.cbUnit5.TabIndex = 13;
            // 
            // cbUnit1
            // 
            this.cbUnit1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUnit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnit1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit1.FormattingEnabled = true;
            this.cbUnit1.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16",
            "16.5",
            "17",
            "17.5",
            "18",
            "18.5",
            "19",
            "19.5",
            "20",
            "20.5",
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.cbUnit1.Location = new System.Drawing.Point(260, 226);
            this.cbUnit1.Name = "cbUnit1";
            this.cbUnit1.Size = new System.Drawing.Size(121, 29);
            this.cbUnit1.TabIndex = 9;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1078, 610);
            this.Controls.Add(this.cbLetter8);
            this.Controls.Add(this.cbLetter4);
            this.Controls.Add(this.cbLessonCount);
            this.Controls.Add(this.cbLetter6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbLetter2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLetter7);
            this.Controls.Add(this.lbGradePoint);
            this.Controls.Add(this.cbLetter3);
            this.Controls.Add(this.lbLessons);
            this.Controls.Add(this.cbLetter5);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.cbLetter1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbUnit8);
            this.Controls.Add(this.cbUnit4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUnit7);
            this.Controls.Add(this.tbLessonName8);
            this.Controls.Add(this.cbUnit3);
            this.Controls.Add(this.tbLessonName6);
            this.Controls.Add(this.cbUnit6);
            this.Controls.Add(this.tbLessonName4);
            this.Controls.Add(this.cbUnit2);
            this.Controls.Add(this.tbLessonName2);
            this.Controls.Add(this.cbUnit5);
            this.Controls.Add(this.tbLessonName7);
            this.Controls.Add(this.cbUnit1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLessonName5);
            this.Controls.Add(this.tbLessonName1);
            this.Controls.Add(this.tbLessonName3);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            this.panelMove.ResumeLayout(false);
            this.panelMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblHowMany;
        private System.Windows.Forms.TextBox tbLessonName1;
        private System.Windows.Forms.TextBox tbLessonName2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbLessons;
        private System.Windows.Forms.ListBox lbGradePoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLessonName3;
        private System.Windows.Forms.TextBox tbLessonName4;
        private System.Windows.Forms.TextBox tbLessonName5;
        private System.Windows.Forms.TextBox tbLessonName6;
        private System.Windows.Forms.TextBox tbLessonName7;
        private System.Windows.Forms.TextBox tbLessonName8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Timer timerFadeEffect;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbLessonCount;
        private System.Windows.Forms.ComboBox cbLetter8;
        private System.Windows.Forms.ComboBox cbLetter4;
        private System.Windows.Forms.ComboBox cbLetter6;
        private System.Windows.Forms.ComboBox cbLetter2;
        private System.Windows.Forms.ComboBox cbLetter7;
        private System.Windows.Forms.ComboBox cbLetter3;
        private System.Windows.Forms.ComboBox cbLetter5;
        private System.Windows.Forms.ComboBox cbLetter1;
        private System.Windows.Forms.ComboBox cbUnit8;
        private System.Windows.Forms.ComboBox cbUnit4;
        private System.Windows.Forms.ComboBox cbUnit7;
        private System.Windows.Forms.ComboBox cbUnit3;
        private System.Windows.Forms.ComboBox cbUnit6;
        private System.Windows.Forms.ComboBox cbUnit2;
        private System.Windows.Forms.ComboBox cbUnit5;
        private System.Windows.Forms.ComboBox cbUnit1;
    }
}