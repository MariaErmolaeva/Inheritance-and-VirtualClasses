namespace InheritanceAndVirtualClasses
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.womenButton = new System.Windows.Forms.RadioButton();
            this.menButton = new System.Windows.Forms.RadioButton();
            this.getName = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getNameStudent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.getTeacher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(12, 12);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(257, 261);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getName);
            this.groupBox1.Controls.Add(this.menButton);
            this.groupBox1.Controls.Add(this.womenButton);
            this.groupBox1.Location = new System.Drawing.Point(289, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name women/men";
            // 
            // womenButton
            // 
            this.womenButton.AutoSize = true;
            this.womenButton.Location = new System.Drawing.Point(26, 19);
            this.womenButton.Name = "womenButton";
            this.womenButton.Size = new System.Drawing.Size(59, 17);
            this.womenButton.TabIndex = 2;
            this.womenButton.TabStop = true;
            this.womenButton.Text = "women";
            this.womenButton.UseVisualStyleBackColor = true;
            // 
            // menButton
            // 
            this.menButton.AutoSize = true;
            this.menButton.Location = new System.Drawing.Point(101, 19);
            this.menButton.Name = "menButton";
            this.menButton.Size = new System.Drawing.Size(45, 17);
            this.menButton.TabIndex = 2;
            this.menButton.TabStop = true;
            this.menButton.Text = "men";
            this.menButton.UseVisualStyleBackColor = true;
            // 
            // getName
            // 
            this.getName.Location = new System.Drawing.Point(31, 42);
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(103, 23);
            this.getName.TabIndex = 2;
            this.getName.Text = "Get name";
            this.getName.UseVisualStyleBackColor = true;
            this.getName.Click += new System.EventHandler(this.getName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getNameStudent);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboCourse);
            this.groupBox2.Location = new System.Drawing.Point(289, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name student";
            // 
            // comboCourse
            // 
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboCourse.Location = new System.Drawing.Point(69, 19);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(77, 21);
            this.comboCourse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course";
            // 
            // getNameStudent
            // 
            this.getNameStudent.Location = new System.Drawing.Point(31, 46);
            this.getNameStudent.Name = "getNameStudent";
            this.getNameStudent.Size = new System.Drawing.Size(105, 23);
            this.getNameStudent.TabIndex = 4;
            this.getNameStudent.Text = "Get name";
            this.getNameStudent.UseVisualStyleBackColor = true;
            this.getNameStudent.Click += new System.EventHandler(this.getNameStudent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.getTeacher);
            this.groupBox3.Controls.Add(this.comboDepartment);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(289, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 88);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name and position teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department";
            // 
            // comboDepartment
            // 
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Items.AddRange(new object[] {
            "biological",
            "physical",
            "geographical",
            "chemical"});
            this.comboDepartment.Location = new System.Drawing.Point(68, 26);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(95, 21);
            this.comboDepartment.TabIndex = 5;
            // 
            // getTeacher
            // 
            this.getTeacher.Location = new System.Drawing.Point(31, 53);
            this.getTeacher.Name = "getTeacher";
            this.getTeacher.Size = new System.Drawing.Size(105, 23);
            this.getTeacher.TabIndex = 5;
            this.getTeacher.Text = "Get teacher";
            this.getTeacher.UseVisualStyleBackColor = true;
            this.getTeacher.Click += new System.EventHandler(this.getTeacher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 286);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getName;
        private System.Windows.Forms.RadioButton menButton;
        private System.Windows.Forms.RadioButton womenButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getNameStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button getTeacher;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.Label label2;
    }
}

