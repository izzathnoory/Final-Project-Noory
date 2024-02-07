namespace Final_Project_Noory
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.LinkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deltebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TextBoxCondactDetails = new System.Windows.Forms.TextBox();
            this.TextBoxNIC = new System.Windows.Forms.TextBox();
            this.TextBoxParentsname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxHomePhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxMobilePhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.textboxlastname = new System.Windows.Forms.TextBox();
            this.textboxfirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.REgistrationCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exitlinklb = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skills International";
            // 
            // LinkLabelLogout
            // 
            this.LinkLabelLogout.AutoSize = true;
            this.LinkLabelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelLogout.Location = new System.Drawing.Point(2, 22);
            this.LinkLabelLogout.Name = "LinkLabelLogout";
            this.LinkLabelLogout.Size = new System.Drawing.Size(66, 20);
            this.LinkLabelLogout.TabIndex = 1;
            this.LinkLabelLogout.TabStop = true;
            this.LinkLabelLogout.Text = "Logout";
            this.LinkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutlinklb_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deltebtn);
            this.groupBox1.Controls.Add(this.clearbtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.registerbtn);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.REgistrationCombobox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 783);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // deltebtn
            // 
            this.deltebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltebtn.Location = new System.Drawing.Point(571, 742);
            this.deltebtn.Name = "deltebtn";
            this.deltebtn.Size = new System.Drawing.Size(75, 35);
            this.deltebtn.TabIndex = 8;
            this.deltebtn.Text = "Delete";
            this.deltebtn.UseVisualStyleBackColor = true;
            this.deltebtn.Click += new System.EventHandler(this.deltebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(490, 742);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 35);
            this.clearbtn.TabIndex = 7;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(124, 742);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(81, 35);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(34, 742);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(84, 35);
            this.registerbtn.TabIndex = 5;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TextBoxCondactDetails);
            this.groupBox4.Controls.Add(this.TextBoxNIC);
            this.groupBox4.Controls.Add(this.TextBoxParentsname);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(22, 542);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 194);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parent Details";
            // 
            // TextBoxCondactDetails
            // 
            this.TextBoxCondactDetails.Location = new System.Drawing.Point(154, 140);
            this.TextBoxCondactDetails.Name = "TextBoxCondactDetails";
            this.TextBoxCondactDetails.Size = new System.Drawing.Size(157, 26);
            this.TextBoxCondactDetails.TabIndex = 5;
            // 
            // TextBoxNIC
            // 
            this.TextBoxNIC.Location = new System.Drawing.Point(153, 93);
            this.TextBoxNIC.Name = "TextBoxNIC";
            this.TextBoxNIC.Size = new System.Drawing.Size(158, 26);
            this.TextBoxNIC.TabIndex = 4;
            // 
            // TextBoxParentsname
            // 
            this.TextBoxParentsname.Location = new System.Drawing.Point(153, 42);
            this.TextBoxParentsname.Name = "TextBoxParentsname";
            this.TextBoxParentsname.Size = new System.Drawing.Size(453, 26);
            this.TextBoxParentsname.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Contact Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "NIC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Parent Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBoxHomePhone);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TextBoxEmail);
            this.groupBox3.Controls.Add(this.TextBoxAddress);
            this.groupBox3.Controls.Add(this.TextBoxMobilePhone);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(22, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 213);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // TextBoxHomePhone
            // 
            this.TextBoxHomePhone.Location = new System.Drawing.Point(438, 157);
            this.TextBoxHomePhone.Name = "TextBoxHomePhone";
            this.TextBoxHomePhone.Size = new System.Drawing.Size(168, 26);
            this.TextBoxHomePhone.TabIndex = 7;
            this.TextBoxHomePhone.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Home phone";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(153, 114);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(453, 26);
            this.TextBoxEmail.TabIndex = 5;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(153, 44);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(453, 47);
            this.TextBoxAddress.TabIndex = 4;
            // 
            // TextBoxMobilePhone
            // 
            this.TextBoxMobilePhone.Location = new System.Drawing.Point(153, 160);
            this.TextBoxMobilePhone.Name = "TextBoxMobilePhone";
            this.TextBoxMobilePhone.Size = new System.Drawing.Size(158, 26);
            this.TextBoxMobilePhone.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mobile phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbfemale);
            this.groupBox2.Controls.Add(this.rbmale);
            this.groupBox2.Controls.Add(this.DateOfBirth);
            this.groupBox2.Controls.Add(this.textboxlastname);
            this.groupBox2.Controls.Add(this.textboxfirstname);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(289, 174);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(81, 21);
            this.rbfemale.TabIndex = 8;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.Location = new System.Drawing.Point(177, 174);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(63, 21);
            this.rbmale.TabIndex = 7;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirth.Location = new System.Drawing.Point(180, 136);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(176, 26);
            this.DateOfBirth.TabIndex = 6;
            // 
            // textboxlastname
            // 
            this.textboxlastname.Location = new System.Drawing.Point(153, 81);
            this.textboxlastname.Name = "textboxlastname";
            this.textboxlastname.Size = new System.Drawing.Size(453, 26);
            this.textboxlastname.TabIndex = 5;
            // 
            // textboxfirstname
            // 
            this.textboxfirstname.Location = new System.Drawing.Point(153, 36);
            this.textboxfirstname.Name = "textboxfirstname";
            this.textboxfirstname.Size = new System.Drawing.Size(453, 26);
            this.textboxfirstname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // REgistrationCombobox
            // 
            this.REgistrationCombobox.FormattingEnabled = true;
            this.REgistrationCombobox.Location = new System.Drawing.Point(175, 47);
            this.REgistrationCombobox.Name = "REgistrationCombobox";
            this.REgistrationCombobox.Size = new System.Drawing.Size(193, 28);
            this.REgistrationCombobox.TabIndex = 1;
            this.REgistrationCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reg No";
            // 
            // exitlinklb
            // 
            this.exitlinklb.AutoSize = true;
            this.exitlinklb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitlinklb.Location = new System.Drawing.Point(642, 893);
            this.exitlinklb.Name = "exitlinklb";
            this.exitlinklb.Size = new System.Drawing.Size(34, 17);
            this.exitlinklb.TabIndex = 3;
            this.exitlinklb.TabStop = true;
            this.exitlinklb.Text = "Exit";
            this.exitlinklb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitlinklb_LinkClicked);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 943);
            this.Controls.Add(this.exitlinklb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LinkLabelLogout);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration_Form";
            this.Text = "Student Registration-Skills International";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkLabelLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.TextBox textboxlastname;
        private System.Windows.Forms.TextBox textboxfirstname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox REgistrationCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxHomePhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxMobilePhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button deltebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.TextBox TextBoxCondactDetails;
        private System.Windows.Forms.TextBox TextBoxNIC;
        private System.Windows.Forms.TextBox TextBoxParentsname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel exitlinklb;
    }
}