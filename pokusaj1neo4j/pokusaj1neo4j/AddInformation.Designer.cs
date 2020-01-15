namespace pokusaj1neo4j
{
    partial class AddInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInformation));
            this.btnHobby = new System.Windows.Forms.Button();
            this.bntFirm = new System.Windows.Forms.Button();
            this.btnRegion = new System.Windows.Forms.Button();
            this.btnPet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHobby
            // 
            this.btnHobby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHobby.Location = new System.Drawing.Point(32, 93);
            this.btnHobby.Name = "btnHobby";
            this.btnHobby.Size = new System.Drawing.Size(131, 55);
            this.btnHobby.TabIndex = 0;
            this.btnHobby.Text = "HOBI";
            this.btnHobby.UseVisualStyleBackColor = true;
            this.btnHobby.Click += new System.EventHandler(this.btnHobby_Click);
            // 
            // bntFirm
            // 
            this.bntFirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntFirm.Location = new System.Drawing.Point(32, 322);
            this.bntFirm.Name = "bntFirm";
            this.bntFirm.Size = new System.Drawing.Size(131, 55);
            this.bntFirm.TabIndex = 3;
            this.bntFirm.Text = "FIRMA";
            this.bntFirm.UseVisualStyleBackColor = true;
            this.bntFirm.Click += new System.EventHandler(this.bntFirm_Click);
            // 
            // btnRegion
            // 
            this.btnRegion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegion.Location = new System.Drawing.Point(255, 93);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(131, 55);
            this.btnRegion.TabIndex = 2;
            this.btnRegion.Text = "REGION";
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.btnRegion_Click);
            // 
            // btnPet
            // 
            this.btnPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPet.Location = new System.Drawing.Point(255, 322);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(131, 55);
            this.btnPet.TabIndex = 4;
            this.btnPet.Text = "LJUBIMAC";
            this.btnPet.UseVisualStyleBackColor = true;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "DODAJ:";
            // 
            // AddInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPet);
            this.Controls.Add(this.btnRegion);
            this.Controls.Add(this.bntFirm);
            this.Controls.Add(this.btnHobby);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj informaciju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHobby;
        private System.Windows.Forms.Button bntFirm;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Button btnPet;
        private System.Windows.Forms.Label label1;
    }
}