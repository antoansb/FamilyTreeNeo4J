namespace pokusaj1neo4j
{
    partial class AddRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRelation));
            this.btnBrother = new System.Windows.Forms.Button();
            this.btnFather = new System.Windows.Forms.Button();
            this.btnMother = new System.Windows.Forms.Button();
            this.btnSon = new System.Windows.Forms.Button();
            this.btnDauther = new System.Windows.Forms.Button();
            this.btnSpouse = new System.Windows.Forms.Button();
            this.btnSister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrother
            // 
            this.btnBrother.Location = new System.Drawing.Point(87, 160);
            this.btnBrother.Name = "btnBrother";
            this.btnBrother.Size = new System.Drawing.Size(121, 55);
            this.btnBrother.TabIndex = 0;
            this.btnBrother.Text = "BRAT";
            this.btnBrother.UseVisualStyleBackColor = true;
            this.btnBrother.Click += new System.EventHandler(this.btnBrother_Click);
            // 
            // btnFather
            // 
            this.btnFather.Location = new System.Drawing.Point(87, 273);
            this.btnFather.Name = "btnFather";
            this.btnFather.Size = new System.Drawing.Size(121, 55);
            this.btnFather.TabIndex = 2;
            this.btnFather.Text = "OTAC";
            this.btnFather.UseVisualStyleBackColor = true;
            this.btnFather.Click += new System.EventHandler(this.btnFather_Click);
            // 
            // btnMother
            // 
            this.btnMother.Location = new System.Drawing.Point(278, 273);
            this.btnMother.Name = "btnMother";
            this.btnMother.Size = new System.Drawing.Size(121, 55);
            this.btnMother.TabIndex = 3;
            this.btnMother.Text = "MAJKA";
            this.btnMother.UseVisualStyleBackColor = true;
            this.btnMother.Click += new System.EventHandler(this.btnMother_Click);
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(87, 381);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(121, 55);
            this.btnSon.TabIndex = 4;
            this.btnSon.Text = "SIN";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // btnDauther
            // 
            this.btnDauther.Location = new System.Drawing.Point(278, 381);
            this.btnDauther.Name = "btnDauther";
            this.btnDauther.Size = new System.Drawing.Size(121, 55);
            this.btnDauther.TabIndex = 5;
            this.btnDauther.Text = "CERKA";
            this.btnDauther.UseVisualStyleBackColor = true;
            this.btnDauther.Click += new System.EventHandler(this.btnDauther_Click);
            // 
            // btnSpouse
            // 
            this.btnSpouse.Location = new System.Drawing.Point(87, 53);
            this.btnSpouse.Name = "btnSpouse";
            this.btnSpouse.Size = new System.Drawing.Size(312, 55);
            this.btnSpouse.TabIndex = 6;
            this.btnSpouse.Text = "SUPRUG/A";
            this.btnSpouse.UseVisualStyleBackColor = true;
            this.btnSpouse.Click += new System.EventHandler(this.btnSpouse_Click);
            // 
            // btnSister
            // 
            this.btnSister.Location = new System.Drawing.Point(278, 160);
            this.btnSister.Name = "btnSister";
            this.btnSister.Size = new System.Drawing.Size(121, 55);
            this.btnSister.TabIndex = 7;
            this.btnSister.Text = "SESTRA";
            this.btnSister.UseVisualStyleBackColor = true;
            this.btnSister.Click += new System.EventHandler(this.btnSister_Click);
            // 
            // AddRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 501);
            this.Controls.Add(this.btnSister);
            this.Controls.Add(this.btnSpouse);
            this.Controls.Add(this.btnDauther);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.btnMother);
            this.Controls.Add(this.btnFather);
            this.Controls.Add(this.btnBrother);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj srodstvo";
            this.Load += new System.EventHandler(this.AddRelation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrother;
        private System.Windows.Forms.Button btnFather;
        private System.Windows.Forms.Button btnMother;
        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Button btnDauther;
        private System.Windows.Forms.Button btnSpouse;
        private System.Windows.Forms.Button btnSister;
    }
}