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
    public partial class AddInformation : Form
    {
        public familyMember globalMember;
        public Family globalFamily;
        public GraphClient client;
        public AddInformation()
        {
            InitializeComponent();
        }
        public AddInformation(familyMember newMember, Family newFamily)
        {
            InitializeComponent();
            globalMember = newMember;
            globalFamily = newFamily;
        }

        private void btnHobby_Click(object sender, EventArgs e)
        {
            InfoFormForFamilyMember novo = new InfoFormForFamilyMember(globalMember, globalFamily, btnHobby.Text);
            novo.client = client;
            novo.ShowDialog();
        }

        private void btnRegion_Click(object sender, EventArgs e)
        {
            InfoFormForFamilyMember novo = new InfoFormForFamilyMember(globalMember, globalFamily, btnRegion.Text);
            novo.client = client;
            novo.ShowDialog();
        }

        private void bntFirm_Click(object sender, EventArgs e)
        {
            InfoFormForFamilyMember novo = new InfoFormForFamilyMember(globalMember, globalFamily, bntFirm.Text);
            novo.client = client;
            novo.ShowDialog();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            InfoFormForFamilyMember novo = new InfoFormForFamilyMember(globalMember, globalFamily, btnPet.Text);
            novo.client = client;
            novo.ShowDialog();
        }
    }
}
