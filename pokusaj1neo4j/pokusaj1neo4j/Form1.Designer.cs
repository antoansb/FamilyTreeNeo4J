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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnShowFamily = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Location = new System.Drawing.Point(50, 353);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(171, 82);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "DODAJ RODBINU";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(458, 134);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(171, 30);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(458, 79);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 30);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesite prezime osobe kojoj dodajete rodjaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unesite ime osobe kojoj dodajete rodjaka:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnSearch.Location = new System.Drawing.Point(660, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 82);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "POTRAZI";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnNewMember.Location = new System.Drawing.Point(660, 27);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(171, 82);
            this.btnNewMember.TabIndex = 8;
            this.btnNewMember.Text = "NOVI CLAN";
            this.btnNewMember.UseVisualStyleBackColor = false;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamily.Location = new System.Drawing.Point(46, 32);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(111, 24);
            this.lblFamily.TabIndex = 10;
            this.lblFamily.Text = "Dobrodosli";
            // 
            // btnRelate
            // 
            this.btnRelate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnRelate.Enabled = false;
            this.btnRelate.Location = new System.Drawing.Point(254, 353);
            this.btnRelate.Name = "btnRelate";
            this.btnRelate.Size = new System.Drawing.Size(171, 82);
            this.btnRelate.TabIndex = 9;
            this.btnRelate.Text = "POVEZI POSTOJECEG CLANA";
            this.btnRelate.UseVisualStyleBackColor = false;
            this.btnRelate.Click += new System.EventHandler(this.btnRelate_Click);
            // 
            // lblOtherName
            // 
            this.lblOtherName.AutoSize = true;
            this.lblOtherName.BackColor = System.Drawing.Color.Transparent;
            this.lblOtherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherName.Location = new System.Drawing.Point(22, 221);
            this.lblOtherName.Name = "lblOtherName";
            this.lblOtherName.Size = new System.Drawing.Size(370, 18);
            this.lblOtherName.TabIndex = 12;
            this.lblOtherName.Text = "Unesite ime osobe sa kojom zelite da povezete:";
            this.lblOtherName.Visible = false;
            // 
            // lblotherSurname
            // 
            this.lblotherSurname.AutoSize = true;
            this.lblotherSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblotherSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblotherSurname.Location = new System.Drawing.Point(22, 276);
            this.lblotherSurname.Name = "lblotherSurname";
            this.lblotherSurname.Size = new System.Drawing.Size(403, 18);
            this.lblotherSurname.TabIndex = 11;
            this.lblotherSurname.Text = "Unesite prezime osobe sa kojom zelite da povezete:";
            this.lblotherSurname.Visible = false;
            // 
            // txtOtherPersonName
            // 
            this.txtOtherPersonName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherPersonName.Location = new System.Drawing.Point(458, 209);
            this.txtOtherPersonName.Multiline = true;
            this.txtOtherPersonName.Name = "txtOtherPersonName";
            this.txtOtherPersonName.Size = new System.Drawing.Size(171, 30);
            this.txtOtherPersonName.TabIndex = 3;
            this.txtOtherPersonName.Tag = "";
            this.txtOtherPersonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOtherPersonName.Visible = false;
            // 
            // txtOtherPersonSurname
            // 
            this.txtOtherPersonSurname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherPersonSurname.Location = new System.Drawing.Point(458, 264);
            this.txtOtherPersonSurname.Multiline = true;
            this.txtOtherPersonSurname.Name = "txtOtherPersonSurname";
            this.txtOtherPersonSurname.Size = new System.Drawing.Size(171, 30);
            this.txtOtherPersonSurname.TabIndex = 4;
            this.txtOtherPersonSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOtherPersonSurname.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(660, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 82);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "OBRISI CLANA PORODICE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnShowList.Enabled = false;
            this.btnShowList.Location = new System.Drawing.Point(458, 353);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(171, 82);
            this.btnShowList.TabIndex = 14;
            this.btnShowList.Text = "VIDI INFORMACIJE";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnShowFamily
            // 
            this.btnShowFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnShowFamily.Enabled = false;
            this.btnShowFamily.Location = new System.Drawing.Point(660, 353);
            this.btnShowFamily.Name = "btnShowFamily";
            this.btnShowFamily.Size = new System.Drawing.Size(171, 82);
            this.btnShowFamily.TabIndex = 15;
            this.btnShowFamily.Text = "VIDI PORODICU";
            this.btnShowFamily.UseVisualStyleBackColor = false;
            this.btnShowFamily.Click += new System.EventHandler(this.btnShowFamily_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 468);
            this.Controls.Add(this.btnShowFamily);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnDelete);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porodicno stablo";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnShowFamily;
    }
}

