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

        public AddRelation()
        {
            InitializeComponent();
        }

        private void AddRelation_Load(object sender, EventArgs e)
        {

        }

        private void btnSpouse_Click(object sender, EventArgs e)
        {
            String relative = btnSpouse.Text;
            addFamilyMember nova = new addFamilyMember(relative);
            nova.client = client;
            nova.ShowDialog();
        }

        private void btnBrother_Click(object sender, EventArgs e)
        {
            String relative = btnBrother.Text;
            addFamilyMember nova = new addFamilyMember(relative);
            nova.client = client;
            nova.ShowDialog();
        }
    }
}
