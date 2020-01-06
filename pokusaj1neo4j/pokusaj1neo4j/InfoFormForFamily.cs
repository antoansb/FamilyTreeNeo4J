using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pokusaj1neo4j.DomainModel;
using Neo4jClient;
using Neo4jClient.Cypher;
namespace pokusaj1neo4j
{
    public partial class InfoFormForFamily : Form
    {
        public GraphClient client;
        public familyMember globalMember;
        public Family globalFamily;
        public List<familyMember> familyMembers;

        public InfoFormForFamily(familyMember glMember, Family glFamily, List<familyMember> AllMembers)
        {
            InitializeComponent();
            globalMember = glMember;
            globalFamily = glFamily;
            familyMembers = AllMembers;
            lbl.Text = "Svi clanovi porodice "+globalFamily.familyName+".";
            int i = 42;
            foreach (familyMember f in familyMembers)
            {
                Label lblDynamic = new Label();
                this.Controls.Add(lblDynamic);
                lblDynamic.BackColor = Color.DarkOrange;
                lblDynamic.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblDynamic.Location = new System.Drawing.Point(6,i);
                lblDynamic.Name = "lblDynamic";
                lblDynamic.Size = new System.Drawing.Size(507, 25);
                lblDynamic.TabIndex = 0;
                lblDynamic.Text = "Ime i prezime: " + f.name + " " + f.surname + " , pol: ";
                if (f.gender == "Male")
                {
                    lblDynamic.Text += "Musko, ";
                }
                else lblDynamic.Text += "Zensko, ";
                lblDynamic.Text += "E - adresa: " + f.eAddress + ".";
                if (f.live!="Alive")
                {
                    lblDynamic.BackColor = System.Drawing.SystemColors.Desktop;
                    lblDynamic.ForeColor = Color.DarkOrange;
                }
                i += 42;
            }
        }
    }
}
