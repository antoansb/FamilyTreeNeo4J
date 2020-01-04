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
    public partial class Form1 : Form
    {
        public GraphClient client;
        public familyMember globalMember;
        public Family globalFamily;

        public Form1(Family fname)
        {
            InitializeComponent();
            lblFamily.Text = "Porodica " + fname.familyName + ", dobrodosli!";
            globalFamily = fname;
#region comm
            /* client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "blizanci");
             try
             {
                 client.Connect();
             }
             catch (Exception exc)
             {
                 MessageBox.Show(exc.Message);
             }*/

            /* Dictionary<string, object> queryDict = new Dictionary<string, object>();
             /*queryDict.Add("name", "22");
             queryDict.Add("birthday", "312313");
             queryDict.Add("birthplace", "Nis");
             queryDict.Add("biography", actor.biography);
             var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Actor {id:'22', name:'marko', birthday:'312313', birthplace:'Nis', biography:'dasdsa'}) return n",
                                                             queryDict, CypherResultMode.Set);
             ((IRawGraphClient)client).ExecuteCypher(query);


             //pravi relaciju izmedju dva nova cvora
             var query1 = new Neo4jClient.Cypher.CypherQuery("CREATE (js: familyMember { name: 'Mikica', surname: 'Dimic', birthday: '10', city: 'Nis', yearOfDeath: '2000' }),(ir: familyMember { name: 'Janko', surname: 'Dimic', birthday: '10', city: 'Nis', yearOfDeath: '2000' }),(js)-[:parentOf]->(ir)",
                 queryDict, CypherResultMode.Set);
             ((IRawGraphClient)client).ExecuteCypher(query1);


             //pravi relaciju izmedju dva cvora vec napravljena
             var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
 "WHERE a.name = 'Mikica' AND b.name = 'Pera'"+
 "CREATE(a) < -[r: brothers] - (b)"+
 "RETURN type(r)",
                 queryDict, CypherResultMode.Set);
             ((IRawGraphClient)client).ExecuteCypher(query2);*/
#endregion
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            AddRelation relation = new AddRelation(globalMember, globalFamily);
            relation.client = client;
            relation.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (n: familyMember)-[:FAMILIJA]-(f:Family) where n.name = '" + txtName.Text + "' AND n.surname = '" + txtSurname.Text + "' AND f.familyName='"+globalFamily.familyName+"' return n",
                 queryDict, CypherResultMode.Set);
            List<familyMember> novi = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query1).ToList();
            foreach( familyMember f in novi )
            {
                globalMember = f;
                MessageBox.Show(globalMember.name);
                
            }
            if (globalMember == null)
            {
                MessageBox.Show("Osoba nije pronadjena!");
            }
            else
            {
                #region visible
                btnDodaj.Enabled = true;
                lblOtherName.Visible = true;
                lblotherSurname.Visible = true;
                txtOtherPersonName.Visible = true;
                txtOtherPersonSurname.Visible = true;
                btnRelate.Enabled = true;
                btnDelete.Enabled = true;
                btnShowList.Enabled = true;
                btnShowFamily.Enabled = true;
                #endregion
            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            addFamilyMember newMember = new addFamilyMember(null, null, globalFamily);
            newMember.client = client;
            newMember.ShowDialog();
            if (newMember.globalRelative == null)
            {
                txtName.Text = newMember.NameForNewMember;
                txtSurname.Text = newMember.SurnameForNewMember;
            }
        }

        private void btnRelate_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query3 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where n.name = '" + txtOtherPersonName.Text + "' AND n.surname = '" + txtOtherPersonSurname.Text + "' return n",
                 queryDict, CypherResultMode.Set);

            familyMember novi = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query3).FirstOrDefault();

            var query4 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                            "WHERE a.name = '"+ this.globalMember.name +"' AND a.surname='"+this.globalMember.surname+"' AND b.name = '"+novi.name+"' AND b.surname='"+novi.surname+"' " +
                                                            "CREATE(a) < -[r: SUPRUZNIK] - (b)" +
                                                            "RETURN type(r)",
                 queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query4);
            lblOtherName.Visible = false;
            lblotherSurname.Visible = false;
            txtOtherPersonName.Visible = false;
            txtOtherPersonSurname.Visible = false;
            btnRelate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query5 = new Neo4jClient.Cypher.CypherQuery("MATCH (n { name: '"+txtName.Text+"', surname: '"+ txtSurname.Text + "' }) DETACH DELETE n",
                 queryDict, CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query5);
            MessageBox.Show("Obrisana je osoba " + txtName.Text+ " " +txtSurname.Text+" !");
            txtName.Text = "";
            txtSurname.Text = "";
            #region visible
            btnDodaj.Enabled = false;
            lblOtherName.Visible = false;
            lblotherSurname.Visible = false;
            txtOtherPersonName.Visible = false;
            txtOtherPersonSurname.Visible = false;
            btnRelate.Enabled = false;
            btnDelete.Enabled = false;
            btnShowList.Enabled = false;
            btnShowFamily.Enabled = false;
            #endregion
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            addFamilyMember newMember = new addFamilyMember("FILL", globalMember, globalFamily);
            newMember.client = client;
            newMember.ShowDialog();
            this.globalMember = null;
            txtName.Text = "";
            txtSurname.Text = "";
        }

        private void btnShowFamily_Click(object sender, EventArgs e)
        {
            InfoForm information = new InfoForm(globalMember, globalFamily);
            information.client = client;
            information.ShowDialog();
        }
    }
}
