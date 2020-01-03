namespace pokusaj1neo4j
{
    partial class Form1
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.lblFamily = new System.Windows.Forms.Label();
            this.btnRelate = new System.Windows.Forms.Button();
            this.lblOtherName = new System.Windows.Forms.Label();
            this.lblotherSurname = new System.Windows.Forms.Label();
            this.txtOtherPersonName = new System.Windows.Forms.TextBox();
            this.txtOtherPersonSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Location = new System.Drawing.Point(44, 308);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(139, 69);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "DODAJ RODBINU";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(383, 142);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(383, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesite prezime osobe kojoj dodajete rodjaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unesite ime osobe kojoj dodajete rodjaka:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(536, 194);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 69);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "POTRAZI";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(536, 49);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(139, 69);
            this.btnNewMember.TabIndex = 8;
            this.btnNewMember.Text = "NOVI CLAN";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamily.Location = new System.Drawing.Point(41, 32);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(111, 24);
            this.lblFamily.TabIndex = 10;
            this.lblFamily.Text = "Dobrodosli";
            // 
            // btnRelate
            // 
            this.btnRelate.Enabled = false;
            this.btnRelate.Location = new System.Drawing.Point(308, 308);
            this.btnRelate.Name = "btnRelate";
            this.btnRelate.Size = new System.Drawing.Size(139, 69);
            this.btnRelate.TabIndex = 9;
            this.btnRelate.Text = "POVEZI POSTOJECEG CLANA";
            this.btnRelate.UseVisualStyleBackColor = true;
            this.btnRelate.Click += new System.EventHandler(this.btnRelate_Click);
            // 
            // lblOtherName
            // 
            this.lblOtherName.AutoSize = true;
            this.lblOtherName.Location = new System.Drawing.Point(41, 194);
            this.lblOtherName.Name = "lblOtherName";
            this.lblOtherName.Size = new System.Drawing.Size(308, 17);
            this.lblOtherName.TabIndex = 12;
            this.lblOtherName.Text = "Unesite ime osobe sa kojom zelite da povezete:";
            this.lblOtherName.Visible = false;
            // 
            // lblotherSurname
            // 
            this.lblotherSurname.AutoSize = true;
            this.lblotherSurname.Location = new System.Drawing.Point(41, 249);
            this.lblotherSurname.Name = "lblotherSurname";
            this.lblotherSurname.Size = new System.Drawing.Size(336, 17);
            this.lblotherSurname.TabIndex = 11;
            this.lblotherSurname.Text = "Unesite prezime osobe sa kojom zelite da povezete:";
            this.lblotherSurname.Visible = false;
            // 
            // txtOtherPersonName
            // 
            this.txtOtherPersonName.Location = new System.Drawing.Point(383, 194);
            this.txtOtherPersonName.Name = "txtOtherPersonName";
            this.txtOtherPersonName.Size = new System.Drawing.Size(100, 22);
            this.txtOtherPersonName.TabIndex = 3;
            this.txtOtherPersonName.Tag = "";
            this.txtOtherPersonName.Visible = false;
            // 
            // txtOtherPersonSurname
            // 
            this.txtOtherPersonSurname.Location = new System.Drawing.Point(383, 249);
            this.txtOtherPersonSurname.Name = "txtOtherPersonSurname";
            this.txtOtherPersonSurname.Size = new System.Drawing.Size(100, 22);
            this.txtOtherPersonSurname.TabIndex = 4;
            this.txtOtherPersonSurname.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 408);
            this.Controls.Add(this.lblOtherName);
            this.Controls.Add(this.lblotherSurname);
            this.Controls.Add(this.txtOtherPersonName);
            this.Controls.Add(this.txtOtherPersonSurname);
            this.Controls.Add(this.btnRelate);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Button btnRelate;
        private System.Windows.Forms.Label lblOtherName;
        private System.Windows.Forms.Label lblotherSurname;
        private System.Windows.Forms.TextBox txtOtherPersonName;
        private System.Windows.Forms.TextBox txtOtherPersonSurname;
    }
}

