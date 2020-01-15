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
    public partial class InfoFormForFamilyMember : Form
    {
        public familyMember globalMember;
        public Family globalFamily;
        public GraphClient client;
        public string globalInfo;
        public InfoFormForFamilyMember()
        {
            InitializeComponent();
        }

        public InfoFormForFamilyMember(familyMember newMember, Family newFamily, string info)
        {
            InitializeComponent();
            globalMember = newMember;
            globalFamily = newFamily;
            globalInfo = info;
            lblAdd.Text = info;
            switch(info)
            {
                case "REGION": {
                        lblType.Text = "Unesite drzavu: ";
                        lblName.Text = "Unesite grad: ";
                        break; };
                case "HOBI": {
                        lblType.Text = "Unesite hobi: ";
                        lblName.Text = "Unesite detalje hobija: ";
                        break;  };
                case "FIRMA": {
                        lblType.Text = "Unesite naziv firme: ";
                        lblName.Text = "Unesite radno mesto u firmi: ";
                        break;  };
                case "LJUBIMAC": {
                        lblType.Text = "Unesite vrstu ljubimca: ";
                        lblName.Text = "Unesite ime ljubimca: ";
                        break; };
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblAdd.Text == "REGION")
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("infoType", txtType.Text);
                var query = new Neo4jClient.Cypher.CypherQuery("MERGE (n:" + lblAdd.Text + " {infoType:'" + txtType.Text + "'}) return n",
                                                                queryDict, CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query);

                Dictionary<string, object> queryDict3 = new Dictionary<string, object>();
                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: Family),(b: " + lblAdd.Text + ")" +
                                                                "WHERE a.familyName = '" + globalFamily.familyName + "' AND a.usernameOfFamilly='" + globalFamily.usernameOfFamilly + "' AND b.infoType = '" + txtType.Text + "'" +
                                                                "MERGE(a) -[r: " + txtName.Text + "] - > (b)" +
                                                                "RETURN type(r)",
                     queryDict3, CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query2);

                MessageBox.Show("Dodat je " + lblAdd.Text + " po imenu " + txtType.Text + ".");
            }
            else
            {
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("infoType", txtType.Text);
                var query = new Neo4jClient.Cypher.CypherQuery("MERGE (n:" + lblAdd.Text + " {infoType:'" + txtType.Text + "'}) return n",
                                                                queryDict, CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query);

                Dictionary<string, object> queryDict3 = new Dictionary<string, object>();
                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: " + lblAdd.Text + ")" +
                                                                "WHERE a.name = '" + globalMember.name + "' AND a.surname='" + globalMember.surname + "' AND b.infoType = '" + txtType.Text + "'" +
                                                                "CREATE(a) -[r: " + txtName.Text + "] - > (b)" +
                                                                "RETURN type(r)",
                     queryDict3, CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query2);

                MessageBox.Show("Dodat je " + lblAdd.Text + " po imenu " + txtType.Text + ".");
                /*Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
                var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:"+lblAdd.Text+") WHERE ee.infoType = '" + txtType.Text + "' RETURN ee;",
                                                                queryDict1, CypherResultMode.Set);
                Information fName = ((IRawGraphClient)client).ExecuteGetCypherResults<Information>(query1).FirstOrDefault();
                MessageBox.Show("Dodat je " + fName.infoName);*/ //za izvlacenje iz baze
            }
            this.Close();
        }
    }
}
