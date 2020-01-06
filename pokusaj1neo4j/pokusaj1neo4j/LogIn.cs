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
    public partial class LogIn : Form
    {
        public GraphClient client;
        public Family globalFamily;
        public LogIn()
        {
            InitializeComponent();
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "blizanci");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Family fname = this.createFamilyName();
            
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("familyName", fname.familyName);
            queryDict.Add("usernameOfFamilly", fname.usernameOfFamilly);
            queryDict.Add("password", fname.password);
            queryDict.Add("numberOfMembers", fname.numberOfMembers);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Family {familyName:'" + fname.familyName
                                                            + "',usernameOfFamilly:'" + fname.usernameOfFamilly + "', password:'" + fname.password
                                                            + "',numberOfMembers:'" + fname.numberOfMembers
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);


            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            var query1 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:Family) WHERE ee.usernameOfFamilly = '" + txtNewUsername.Text + "' RETURN ee.familyName;",
                                                            queryDict1, CypherResultMode.Set);
            String fName = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query1).FirstOrDefault();
            if (fName == null)
            {
                ((IRawGraphClient)client).ExecuteCypher(query);
                Form1 newForm = new Form1(fname);
                newForm.client = client;
                newForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Neko je vec registrovan kao " + txtNewUsername.Text + ", molim vas unesite drugi username");
                txtNewUsername.Text = "";
                txtNewPassword.Text = "";
                fName = null;
            }


            
        }
        public Family createFamilyName()
        {
            Family newFamily = new Family();
            newFamily.familyName = txtFamilyName.Text;
            newFamily.usernameOfFamilly = txtNewUsername.Text;
            newFamily.password = txtNewPassword.Text;           
            newFamily.numberOfMembers = 0;
            Console.WriteLine(newFamily);
            return newFamily;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:Family) WHERE ee.usernameOfFamilly = '" + txtUsername.Text + "' RETURN ee",
                                                            queryDict, CypherResultMode.Set);

            Family fm = ((IRawGraphClient)client).ExecuteGetCypherResults<Family>(query).FirstOrDefault();
            
            if (fm!=null)
            {
                if(fm.password==txtPassword.Text)
                {
                    Form1 newForm = new Form1(fm);
                    newForm.client = client;
                    newForm.ShowDialog();
                }
                else MessageBox.Show("pogresili ste password");
            }
            else MessageBox.Show("Nije tacan username");
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(10, 10, 10);
        }
    }
}
