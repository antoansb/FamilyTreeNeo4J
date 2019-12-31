namespace pokusaj1neo4j
{
    partial class addFamilyMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.txtEAddress = new System.Windows.Forms.TextBox();
            this.txtBiography = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelForNewMember = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioDead = new System.Windows.Forms.RadioButton();
            this.radioLive = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.layoutForDeath = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeForDeath = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            this.layoutForDeath.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rodjenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesto rodjenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-adresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Biografija:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(28, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(247, 81);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(147, 22);
            this.txtSurname.TabIndex = 7;
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(26, 261);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(147, 22);
            this.txtPlaceOfBirth.TabIndex = 9;
            // 
            // txtEAddress
            // 
            this.txtEAddress.Location = new System.Drawing.Point(244, 261);
            this.txtEAddress.Name = "txtEAddress";
            this.txtEAddress.Size = new System.Drawing.Size(147, 22);
            this.txtEAddress.TabIndex = 10;
            // 
            // txtBiography
            // 
            this.txtBiography.Location = new System.Drawing.Point(25, 366);
            this.txtBiography.Margin = new System.Windows.Forms.Padding(4);
            this.txtBiography.Multiline = true;
            this.txtBiography.Name = "txtBiography";
            this.txtBiography.Size = new System.Drawing.Size(366, 121);
            this.txtBiography.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(25, 185);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 504);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 41);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelForNewMember
            // 
            this.labelForNewMember.AutoSize = true;
            this.labelForNewMember.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelForNewMember.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForNewMember.Location = new System.Drawing.Point(25, 23);
            this.labelForNewMember.Name = "labelForNewMember";
            this.labelForNewMember.Size = new System.Drawing.Size(150, 22);
            this.labelForNewMember.TabIndex = 15;
            this.labelForNewMember.Text = "Clan porodice je";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(28, 121);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(70, 21);
            this.radioMale.TabIndex = 16;
            this.radioMale.TabStop = true;
            this.radioMale.Tag = "";
            this.radioMale.Text = "Musko";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(134, 121);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(76, 21);
            this.radioFemale.TabIndex = 17;
            this.radioFemale.Tag = "";
            this.radioFemale.Text = "Zensko";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioDead
            // 
            this.radioDead.AutoSize = true;
            this.radioDead.Location = new System.Drawing.Point(57, 3);
            this.radioDead.Name = "radioDead";
            this.radioDead.Size = new System.Drawing.Size(89, 21);
            this.radioDead.TabIndex = 19;
            this.radioDead.Tag = "";
            this.radioDead.Text = "Preminuo";
            this.radioDead.UseVisualStyleBackColor = true;
            this.radioDead.CheckedChanged += new System.EventHandler(this.btnDeath);
            // 
            // radioLive
            // 
            this.radioLive.AutoSize = true;
            this.radioLive.Checked = true;
            this.radioLive.Location = new System.Drawing.Point(3, 3);
            this.radioLive.Name = "radioLive";
            this.radioLive.Size = new System.Drawing.Size(48, 21);
            this.radioLive.TabIndex = 18;
            this.radioLive.TabStop = true;
            this.radioLive.Tag = "";
            this.radioLive.Text = "Ziv";
            this.radioLive.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioLive);
            this.flowLayoutPanel1.Controls.Add(this.radioDead);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 302);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(168, 40);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 41);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // layoutForDeath
            // 
            this.layoutForDeath.Controls.Add(this.label8);
            this.layoutForDeath.Controls.Add(this.dateTimeForDeath);
            this.layoutForDeath.Location = new System.Drawing.Point(222, 302);
            this.layoutForDeath.Name = "layoutForDeath";
            this.layoutForDeath.Size = new System.Drawing.Size(209, 43);
            this.layoutForDeath.TabIndex = 22;
            this.layoutForDeath.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Godina smrti:";
            // 
            // dateTimeForDeath
            // 
            this.dateTimeForDeath.Location = new System.Drawing.Point(4, 21);
            this.dateTimeForDeath.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeForDeath.Name = "dateTimeForDeath";
            this.dateTimeForDeath.Size = new System.Drawing.Size(204, 22);
            this.dateTimeForDeath.TabIndex = 13;
            // 
            // addFamilyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 564);
            this.Controls.Add(this.layoutForDeath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.labelForNewMember);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtBiography);
            this.Controls.Add(this.txtEAddress);
            this.Controls.Add(this.txtPlaceOfBirth);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addFamilyMember";
            this.Text = "addFamilyMember";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.layoutForDeath.ResumeLayout(false);
            this.layoutForDeath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPlaceOfBirth;
        private System.Windows.Forms.TextBox txtEAddress;
        private System.Windows.Forms.TextBox txtBiography;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelForNewMember;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioDead;
        private System.Windows.Forms.RadioButton radioLive;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel layoutForDeath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeForDeath;
    }
}