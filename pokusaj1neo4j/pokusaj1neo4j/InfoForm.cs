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
    public partial class InfoForm : Form
    {
        public GraphClient client;
        public familyMember globalMember;
        public Family globalFamily;
        public InfoForm(familyMember glMember, Family glFamily)
        {
            globalMember = glMember;
            globalFamily = glFamily;
            InitializeComponent();
            Label lblDynamic = new Label();
            this.Controls.Add(lblDynamic);
            lblDynamic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lblDynamic.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDynamic.Location = new System.Drawing.Point(6, 42);
            lblDynamic.Name = "lblDynamic";
            lblDynamic.Size = new System.Drawing.Size(407, 25);
            lblDynamic.TabIndex = 0;
            lblDynamic.Text = "label1";
            this.dja();
        }
        public void dja()
        {
            MessageBox.Show("trazi se " + globalMember.name);
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            //queryDict.Add("name", globalMember.name);
            //queryDict.Add("surname", globalMember.surname);
            //queryDict.Add("birthday", globalMember.birthday);
            //queryDict.Add("birthplace", globalMember.birthPlace);
            //queryDict.Add("yearOfDeath", globalMember.yearOfDeath);
            //queryDict.Add("eAddress", globalMember.eAddress);
            //queryDict.Add("gender", globalMember.gender);
            //queryDict.Add("live", globalMember.live);
            //queryDict.Add("biography", globalMember.biography);
            var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:familyMember)-[r]-(aa:familyMember) WHERE ee.name = '" + globalMember.name + "' RETURN aa",
                    queryDict, CypherResultMode.Set);
            List<familyMember> brothers = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query3).ToList();
            foreach (familyMember f in brothers)
            {
                MessageBox.Show("clan je " + f.name);
            }
        }
    }
}
