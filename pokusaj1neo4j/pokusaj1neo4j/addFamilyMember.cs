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
    public partial class addFamilyMember : Form
    {
        public GraphClient client;
        public familyMember globalMember;
        public String globalRelative;
        public Family globalFamily;

        public addFamilyMember(String relative, familyMember global, Family familyGlobal)
        {
            InitializeComponent();
            this.globalMember = global;
            this.globalFamily = familyGlobal;
            this.globalRelative = relative;
            if (relative != null)
            {
                labelForNewMember.Visible = true;
                labelForNewMember.Text = "Novi clan je " + relative + " clanu " + globalMember.name;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            familyMember member = this.createMember();
            /*String maxId = getMaxId();
            
            
                int sk = Int32.Parse(maxId);
                //int mId = Int32.Parse(maxId);
                member.id = (sk++).ToString();*/
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("name", member.name);
            queryDict.Add("surname", member.surname);
            queryDict.Add("birthday", member.birthday);
            queryDict.Add("birthplace", member.birthPlace);
            queryDict.Add("yearOfDeath", member.yearOfDeath);
            queryDict.Add("eAddress", member.eAddress);
            queryDict.Add("gender", member.gender);
            queryDict.Add("live", member.live);
            queryDict.Add("biography", member.biography);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:familyMember {id:'" + member.id + "', name:'" + member.name
                                                            + "',surname:'"+ member.surname +"', birthday:'" + member.birthday + "', birthplace:'" + member.birthPlace
                                                            + "',yearOfDeath:'" + member.yearOfDeath + "',eAddress:'" + member.eAddress
                                                            + "',gender:'" + member.gender + "', live:'" + member.live + "', biography:'" + member.biography
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            List<familyMember> fMembers = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query).ToList();

            //ovde se dodaje clan porodice cvoru Family
            Dictionary<string, object> queryDict3 = new Dictionary<string, object>();
            var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: Family)" +
                                                            "WHERE a.name = '"+member.name+"' AND b.familyName = '"+ globalFamily.familyName +"'" +
                                                            "CREATE(a) < -[r: FAMILIJA] - (b)" +
                                                            "RETURN type(r)",
                 queryDict3, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query3);


            foreach (familyMember a in fMembers)
            {
                MessageBox.Show(a.name);
            }

            if (this.globalRelative != null)
            { //ovde se menja sad poslednje

                //NE DIRAJ-dodaju se braca i sestre,ali ne dobijaju iste roditelje
                #region BratISestra
                if (globalRelative == "BRAT" || globalRelative == "SESTRA")
                {
                    //Za Bracu i Sestre
                    var query4 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:familyMember)-[:BRAT|SESTRA]-(aa:familyMember) WHERE ee.name = '" + globalMember.name + "' RETURN aa",
                queryDict, CypherResultMode.Set);
                    List<familyMember> brothers = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query4).ToList();

                    foreach (familyMember newBrother in brothers)
                    {
                        var query5 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + newBrother.name + "' AND b.surname= '" + newBrother.surname + "'  " +
                                                                "CREATE(a) - [r: " + globalRelative + "] - > (b)" +
                                                                "RETURN type(r)",
                        queryDict, CypherResultMode.Set);
                        ((IRawGraphClient)client).ExecuteCypher(query5);
                    }
                }
                #endregion

                #region Roditelji
                if (globalRelative == "OTAC" || globalRelative == "MAJKA")
                {
                    var query5 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:familyMember)-[:BRAT|SESTRA]-(aa:familyMember) WHERE ee.name = '" + globalMember.name + "' RETURN aa",
                queryDict, CypherResultMode.Set);
                    List<familyMember> brothersAndSisters = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query5).ToList();
                    foreach (familyMember newBrother in brothersAndSisters)
                    {
                        String genderOfChild;
                        if (newBrother.gender == "Male")
                            genderOfChild = "SIN";
                        else genderOfChild = "CERKA";
                        var query6 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + newBrother.name + "' AND b.surname= '" + newBrother.surname + "'  " +
                                                                "CREATE(a) - [r: " + globalRelative + "] - > (b), (a) < - [rr: "+ genderOfChild +"] - (b) " +
                                                                "RETURN type(r)",
                        queryDict, CypherResultMode.Set);
                        ((IRawGraphClient)client).ExecuteCypher(query6);
                    }
                    String genderOfMemberChild;
                    if (member.gender == "Male")
                        genderOfMemberChild = "SIN";
                    else genderOfMemberChild = "CERKA";
                    var query19 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + globalMember.name + "' AND b.surname= '" + globalMember.surname + "'  " +
                                                                "CREATE(a) < - [r: " + genderOfMemberChild + "] - (b) " +
                                                                "RETURN type(r)",
                        queryDict, CypherResultMode.Set);
                    ((IRawGraphClient)client).ExecuteCypher(query19);

                }
                #endregion               

                #region SiniCerka
                if (globalRelative == "SIN" || globalRelative == "CERKA")
                {
                    String genderForRelate, parent;
                    if (globalRelative == "SIN")
                        genderForRelate = "BRAT";
                    else genderForRelate = "SESTRA";
                    if (globalMember.gender == "Male")
                        parent = "OTAC";
                    else parent = "MAJKA";
                    var query7 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:familyMember)-[:SIN|CERKA]-(aa:familyMember) WHERE ee.name = '" + globalMember.name + "' RETURN aa",
                queryDict, CypherResultMode.Set);
                    List<familyMember> sonsAndDaughters = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query7).ToList();

                    foreach (familyMember newBrother in sonsAndDaughters)
                    {
                        var query8 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + newBrother.name + "' AND b.surname= '" + newBrother.surname + "'  " +
                                                                "CREATE(a) - [r: " + genderForRelate + "] - > (b)" +
                                                                "RETURN type(r)",
                        queryDict, CypherResultMode.Set);
                        ((IRawGraphClient)client).ExecuteCypher(query8);
                    }
                    var query22 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + globalMember.name + "' AND b.surname= '" + globalMember.surname + "'  " +
                                                                "CREATE(a) < - [r: " + parent + "] - (b)" +
                                                                "RETURN type(r)",
                        queryDict, CypherResultMode.Set);
                    ((IRawGraphClient)client).ExecuteCypher(query22);

                }
                #endregion


                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                "WHERE a.name = '" + this.globalMember.name + "' AND a.surname = '" + this.globalMember.surname + "' AND b.name = '" + member.name + "' AND b.surname= '" + member.surname + "'  " +
                                                                "CREATE(a) < - [r: " + this.globalRelative + "] - (b)" +
                                                                "RETURN type(r)",
                 queryDict, CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query2);



            }

            

            //NodeReference<familyMember> newActor = client.Create(member);

            this.Close();


        }

        private familyMember createMember()
        {
            familyMember newMember = new familyMember();

            TimeSpan unixtime =
                dateTimePicker.Value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            newMember.birthday = unixtime.TotalMilliseconds.ToString();
            newMember.name = txtName.Text;
            newMember.surname = txtSurname.Text;
            if (radioMale.Checked == true)
                newMember.gender = "Male";
            else newMember.gender = "Female";

            if (radioLive.Checked == true)
                newMember.live = "Alive";
            else
            {
                newMember.live = "Passed away";
                TimeSpan unixtimeForDeath =
                dateTimeForDeath.Value.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

                newMember.yearOfDeath = unixtimeForDeath.TotalMilliseconds.ToString();
            }

            newMember.eAddress = txtEAddress.Text;
            newMember.birthPlace = txtPlaceOfBirth.Text;
            newMember.biography = txtBiography.Text;

            
            return newMember;
        }

        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:familyMember) where exists(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();
            
            return maxId;
        }

        private void btnDeath(object sender, EventArgs e)
        {
            layoutForDeath.Visible = !layoutForDeath.Visible;
        }
    }
}
