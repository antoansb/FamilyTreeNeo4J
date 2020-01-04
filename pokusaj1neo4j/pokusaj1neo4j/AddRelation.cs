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
    public partial class AddRelation : Form
    {
        public GraphClient client;
        public familyMember globalMember;
        public Family globalFamily;

        public AddRelation(familyMember global, Family familyGlobal)
        {
            InitializeComponent();
            this.globalMember = global;
            this.globalFamily = familyGlobal;
        }

        private void AddRelation_Load(object sender, EventArgs e)
        {

        }

        private void btnSpouse_Click(object sender, EventArgs e)
        {
            String relative = "SUPRUZNIK";
            addFamilyMember nova = new addFamilyMember(relative, globalMember, globalFamily);
            nova.client = client;
            nova.ShowDialog();
        }

        private void btnBrother_Click(object sender, EventArgs e)
        {
            String relative = btnBrother.Text;
            addFamilyMember nova = new addFamilyMember(relative, globalMember, globalFamily);
            nova.client = client;
            nova.ShowDialog();
        }

        private void btnSister_Click(object sender, EventArgs e)
        {
            String relative = btnSister.Text;
            addFamilyMember nova = new addFamilyMember(relative, globalMember, globalFamily);
            nova.client = client;
            nova.ShowDialog();
        }

        private void btnFather_Click(object sender, EventArgs e)
        {
            String relative = btnFather.Text;
            addFamilyMember nova = new addFamilyMember(relative, globalMember, globalFamily);
            nova.client = client;
            nova.ShowDialog();
        }

        private void btnMother_Click(object sender, EventArgs e)
        {
            String relative = btnMother.Text;
            addFamilyMember nova = new addFamilyMember(relative, globalMember, globalFamily);
            nova.client = client;
            nova.ShowDialog();
        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            String relative = btnSon.Text;
            addFamilyMember nova = new addFamilyMember(relative, globalMember, globalFamily);
            nova.client = client;
            nova.ShowDialog();
        }

        private void btnDauther_Click(object sender, EventArgs e)
        {
            String relative = btnDauther.Text;
            addFamilyMember nova = new addFamilyMember(relative, globalMember, globalFamily);
            nova.client = client;
            nova.ShowDialog();
        }
    }
}
