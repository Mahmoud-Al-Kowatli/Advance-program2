namespace myHomeWorkForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_username = new TextBox();
            txt_firstname = new TextBox();
            txt_lastname = new TextBox();
            txt_email = new TextBox();
            txt_phone = new TextBox();
            txt_registeryear = new TextBox();
            txt_department = new TextBox();
            button2 = new Button();
            findStudent = new TextBox();
            btn_findById = new Button();
            txt_show_department = new TextBox();
            txt_show_registeryear = new TextBox();
            txt_show_phone = new TextBox();
            txt_show_email = new TextBox();
            txt_show_lastname = new TextBox();
            txt_show_firstname = new TextBox();
            txt_show_username = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btn_update = new Button();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(210, 121);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 0;
            button1.Text = "Show All Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(588, 94);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 163);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 197);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 223);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 163);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 197);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 6;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(257, 223);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 7;
            label6.Text = "Register Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(482, 163);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 8;
            label7.Text = "Department";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(108, 160);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(100, 23);
            txt_username.TabIndex = 9;
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(108, 189);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(100, 23);
            txt_firstname.TabIndex = 10;
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(108, 220);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(100, 23);
            txt_lastname.TabIndex = 11;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(337, 155);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 12;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(337, 186);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(100, 23);
            txt_phone.TabIndex = 13;
            // 
            // txt_registeryear
            // 
            txt_registeryear.Location = new Point(337, 215);
            txt_registeryear.Name = "txt_registeryear";
            txt_registeryear.Size = new Size(100, 23);
            txt_registeryear.TabIndex = 14;
            // 
            // txt_department
            // 
            txt_department.Location = new Point(482, 186);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(100, 23);
            txt_department.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(210, 259);
            button2.Name = "button2";
            button2.Size = new Size(161, 23);
            button2.TabIndex = 16;
            button2.Text = "Add New Student";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // findStudent
            // 
            findStudent.Location = new Point(25, 307);
            findStudent.Name = "findStudent";
            findStudent.Size = new Size(183, 23);
            findStudent.TabIndex = 17;
            // 
            // btn_findById
            // 
            btn_findById.Location = new Point(226, 306);
            btn_findById.Name = "btn_findById";
            btn_findById.Size = new Size(161, 23);
            btn_findById.TabIndex = 18;
            btn_findById.Text = "find student by id";
            btn_findById.UseVisualStyleBackColor = true;
            btn_findById.Click += btn_findById_Click;
            // 
            // txt_show_department
            // 
            txt_show_department.Location = new Point(482, 373);
            txt_show_department.Name = "txt_show_department";
            txt_show_department.Size = new Size(100, 23);
            txt_show_department.TabIndex = 32;
            // 
            // txt_show_registeryear
            // 
            txt_show_registeryear.Location = new Point(337, 402);
            txt_show_registeryear.Name = "txt_show_registeryear";
            txt_show_registeryear.Size = new Size(100, 23);
            txt_show_registeryear.TabIndex = 31;
            // 
            // txt_show_phone
            // 
            txt_show_phone.Location = new Point(337, 373);
            txt_show_phone.Name = "txt_show_phone";
            txt_show_phone.Size = new Size(100, 23);
            txt_show_phone.TabIndex = 30;
            // 
            // txt_show_email
            // 
            txt_show_email.Location = new Point(337, 342);
            txt_show_email.Name = "txt_show_email";
            txt_show_email.Size = new Size(100, 23);
            txt_show_email.TabIndex = 29;
            // 
            // txt_show_lastname
            // 
            txt_show_lastname.Location = new Point(108, 407);
            txt_show_lastname.Name = "txt_show_lastname";
            txt_show_lastname.Size = new Size(100, 23);
            txt_show_lastname.TabIndex = 28;
            // 
            // txt_show_firstname
            // 
            txt_show_firstname.Location = new Point(108, 376);
            txt_show_firstname.Name = "txt_show_firstname";
            txt_show_firstname.Size = new Size(100, 23);
            txt_show_firstname.TabIndex = 27;
            // 
            // txt_show_username
            // 
            txt_show_username.Location = new Point(108, 347);
            txt_show_username.Name = "txt_show_username";
            txt_show_username.Size = new Size(100, 23);
            txt_show_username.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(482, 350);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 25;
            label8.Text = "Department";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(257, 410);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 24;
            label9.Text = "Register Year";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(257, 384);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 23;
            label10.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(257, 350);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 22;
            label11.Text = "Email";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 410);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 21;
            label12.Text = "Last Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 384);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 20;
            label13.Text = "First Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 350);
            label14.Name = "label14";
            label14.Size = new Size(65, 15);
            label14.TabIndex = 19;
            label14.Text = "User Name";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(226, 441);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(161, 23);
            btn_update.TabIndex = 33;
            btn_update.Text = "Save the Change";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(410, 306);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(161, 23);
            btn_delete.TabIndex = 34;
            btn_delete.Text = "Delete Student By Id";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 493);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(txt_show_department);
            Controls.Add(txt_show_registeryear);
            Controls.Add(txt_show_phone);
            Controls.Add(txt_show_email);
            Controls.Add(txt_show_lastname);
            Controls.Add(txt_show_firstname);
            Controls.Add(txt_show_username);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(btn_findById);
            Controls.Add(findStudent);
            Controls.Add(button2);
            Controls.Add(txt_department);
            Controls.Add(txt_registeryear);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(txt_lastname);
            Controls.Add(txt_firstname);
            Controls.Add(txt_username);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_username;
        private TextBox txt_firstname;
        private TextBox txt_lastname;
        private TextBox txt_email;
        private TextBox txt_phone;
        private TextBox txt_registeryear;
        private TextBox txt_department;
        private Button button2;
        private TextBox findStudent;
        private Button btn_findById;
        private TextBox txt_show_department;
        private TextBox txt_show_registeryear;
        private TextBox txt_show_phone;
        private TextBox txt_show_email;
        private TextBox txt_show_lastname;
        private TextBox txt_show_firstname;
        private TextBox txt_show_username;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btn_update;
        private Button btn_delete;
    }
}