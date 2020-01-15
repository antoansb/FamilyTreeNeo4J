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
        public String NameForNewMember;
        public String SurnameForNewMember;
        public Boolean changeInformation = false;

        public addFamilyMember(String relative, familyMember global, Family familyGlobal)
        {
            InitializeComponent();
            this.globalMember = global;
            this.globalFamily = familyGlobal;
            this.globalRelative = relative;
            if (relative != null)
            {
                if (relative == "FILL")
                {
                    this.fillTheLabels();
                    changeInformation = true;
                    labelForNewMember.Visible = true;
                    labelForNewMember.Text = "Promenite informacije clanu " + globalMember.name;
                }
                else
                {
                    labelForNewMember.Visible = true;
                    labelForNewMember.Text = "Novi clan je " + relative + " clanu " + globalMember.name;
                }
            }
            else labelForNewMember.Visible = false;
        }

        public void fillTheLabels()
        {
            txtName.Text = globalMember.name;
            txtSurname.Text = globalMember.surname;
            txtEAddress.Text = globalMember.eAddress;
            txtBiography.Text = globalMember.biography;
            txtPlaceOfBirth.Text = globalMember.birthPlace;
            //timeParses
            if (globalMember.gender == "Male")
                radioMale.Checked = true;
            else radioFemale.Checked = true;
            if (globalMember.live == "Alive")
                radioLive.Checked = true;
            else { radioDead.Checked = true;
                dateTimeForDeath.Visible = true;
            }
            btnAdd.Text = "Promeni";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.changeInformation == false)
            {
                familyMember member = this.createMember();
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("name", member.name);
                queryDict.Add("surname", member.surname);
                queryDict.Add("birthday", member.birthday);
                queryDict.Add("birthPlace", member.birthPlace);
                queryDict.Add("yearOfDeath", member.yearOfDeath);
                queryDict.Add("eAddress", member.eAddress);
                queryDict.Add("gender", member.gender);
                queryDict.Add("live", member.live);
                queryDict.Add("biography", member.biography);

                var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:familyMember {id:'" + member.id + "', name:'" + member.name
                                                                + "',surname:'" + member.surname + "', birthday:'" + member.birthday + "', birthPlace:'" + member.birthPlace
                                                                + "',yearOfDeath:'" + member.yearOfDeath + "',eAddress:'" + member.eAddress
                                                                + "',gender:'" + member.gender + "', live:'" + member.live + "', biography:'" + member.biography
                                                                + "'}) return n",
                                                                queryDict, CypherResultMode.Set);

                List<familyMember> fMembers = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query).ToList();
                Dictionary<string, object> queryDict3 = new Dictionary<string, object>();
                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: Family)" +
                                                                "WHERE a.name = '" + member.name + "' AND a.surname='"+member.surname+"' AND b.familyName = '" + globalFamily.familyName + "'" +
                                                                "CREATE(a) < -[r: FAMILIJA] - (b)" +
                                                                "RETURN type(r)",
                     queryDict3, CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query2);


                foreach (familyMember a in fMembers)
                {
                    MessageBox.Show("Dodat je novi clan "+a.name+" "+a.surname+".");
                }

                if (this.globalRelative != null)
                {

                    #region BratISestra
                    if (globalRelative == "BRAT" || globalRelative == "SESTRA")
                    {
                        var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:familyMember)-[:BRAT|SESTRA]-(aa:familyMember) WHERE ee.name = '" + globalMember.name + "' RETURN aa",
                    queryDict, CypherResultMode.Set);
                        List<familyMember> brothers = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query3).ToList();

                        foreach (familyMember newBrother in brothers)
                        {
                            String cousin;
                            if (newBrother.gender == "Male")
                                cousin = "BRAT";
                            else cousin = "SESTRA";
                            var query4 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                    "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + newBrother.name + "' AND b.surname= '" + newBrother.surname + "'  " +
                                                                    "CREATE(a) - [r: " + cousin + "] - > (b)" +
                                                                    "RETURN type(r)",
                            queryDict, CypherResultMode.Set);
                            ((IRawGraphClient)client).ExecuteCypher(query4);
                        }
                        var query5 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:familyMember)<-[:OTAC|MAJKA]-(aa:familyMember) WHERE ee.name = '" + globalMember.name + "' RETURN aa",
                    queryDict, CypherResultMode.Set);
                        List<familyMember> motherAndFather = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query5).ToList();

                        foreach (familyMember parent in motherAndFather)
                        {
                            String parentsGender, genderOfGlobalRelative;
                            if (parent.gender == "Male")
                            { parentsGender = "OTAC"; }
                            else { parentsGender = "MAJKA"; }
                            if (globalRelative == "BRAT")
                                genderOfGlobalRelative = "SIN";
                            else genderOfGlobalRelative = "CERKA";
                            var query6 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                    "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + parent.name + "' AND b.surname= '" + parent.surname + "'  " +
                                                                    "CREATE(a) < - [r: " + parentsGender + "] - (b),(a) - [rr: " + genderOfGlobalRelative + "] - > (b)" +
                                                                    "RETURN type(r)",
                            queryDict, CypherResultMode.Set);
                            ((IRawGraphClient)client).ExecuteCypher(query6);
                        }
                    }
                    #endregion

                    #region Roditelji
                    if (globalRelative == "OTAC" || globalRelative == "MAJKA")
                    {
                        var query7 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:familyMember)-[:BRAT|SESTRA]-(aa:familyMember) WHERE ee.name = '" + globalMember.name + "' RETURN aa",
                    queryDict, CypherResultMode.Set);
                        List<familyMember> brothersAndSisters = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query7).ToList();
                        foreach (familyMember newBrother in brothersAndSisters)
                        {
                            String genderOfChild;
                            if (newBrother.gender == "Male")
                                genderOfChild = "SIN";
                            else genderOfChild = "CERKA";
                            var query8 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                    "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + newBrother.name + "' AND b.surname= '" + newBrother.surname + "'  " +
                                                                    "CREATE(a) - [r: " + globalRelative + "] - > (b), (a) < - [rr: " + genderOfChild + "] - (b) " +
                                                                    "RETURN type(r)",
                            queryDict, CypherResultMode.Set);
                            ((IRawGraphClient)client).ExecuteCypher(query8);
                        }
                        String genderOfMemberChild;
                        if (member.gender == "Male")
                            genderOfMemberChild = "SIN";
                        else genderOfMemberChild = "CERKA";
                        var query9 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                    "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + globalMember.name + "' AND b.surname= '" + globalMember.surname + "'  " +
                                                                    "CREATE(a) < - [r: " + genderOfMemberChild + "] - (b) " +
                                                                    "RETURN type(r)",
                            queryDict, CypherResultMode.Set);
                        ((IRawGraphClient)client).ExecuteCypher(query9);

                    }
                    #endregion

                    #region SiniCerka
                    if (globalRelative == "SIN" || globalRelative == "CERKA")
                    {
                        String genderForRelate, parent, parent2;
                        if (globalRelative == "SIN")
                            genderForRelate = "BRAT";
                        else genderForRelate = "SESTRA";
                        if (globalMember.gender == "Male")
                        { parent = "OTAC"; parent2 = "MAJKA"; }
                        else { parent = "MAJKA"; parent2 = "OTAC"; }
                        var query10 = new Neo4jClient.Cypher.CypherQuery("MATCH (ee:familyMember)<-[:SIN|CERKA]-(aa:familyMember) WHERE ee.name = '" + globalMember.name + "' RETURN aa",
                    queryDict, CypherResultMode.Set);
                        List<familyMember> sonsAndDaughters = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query10).ToList();

                        foreach (familyMember newBrother in sonsAndDaughters)
                        {
                            var query11 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                    "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + newBrother.name + "' AND b.surname= '" + newBrother.surname + "'  " +
                                                                    "CREATE(a) - [r: " + genderForRelate + "] - > (b)" +
                                                                    "RETURN type(r)",
                            queryDict, CypherResultMode.Set);
                            ((IRawGraphClient)client).ExecuteCypher(query11);
                        }
                        var query12 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                    "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + globalMember.name + "' AND b.surname= '" + globalMember.surname + "'  " +
                                                                    "CREATE(a) < - [r: " + parent + "] - (b)" +
                                                                    "RETURN type(r)",
                            queryDict, CypherResultMode.Set);
                        ((IRawGraphClient)client).ExecuteCypher(query12);

                        var query13 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember)-[:SUPRUZNIK]-(b: familyMember) WHERE a.name = '" + globalMember.name + "' AND a.surname = '" + globalMember.surname + "' RETURN b",
                                queryDict, CypherResultMode.Set);
                        familyMember supruznik = ((IRawGraphClient)client).ExecuteGetCypherResults<familyMember>(query13).FirstOrDefault();
                        if (supruznik != null)
                        {
                            var query14 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                           "WHERE a.name = '" + member.name + "' AND a.surname = '" + member.surname + "' AND b.name = '" + supruznik.name + "' AND b.surname= '" + supruznik.surname + "'  " +
                                                                           "CREATE(a) < - [rrr: " + parent2 + "] - (b),(a) - [rr: " + globalRelative + "] - > (b)" +
                                                                           "RETURN type(rrr)",
                                   queryDict, CypherResultMode.Set);
                            ((IRawGraphClient)client).ExecuteCypher(query14);
                        }
                    }
                    #endregion


                    var query15 = new Neo4jClient.Cypher.CypherQuery("MATCH(a: familyMember),(b: familyMember)" +
                                                                    "WHERE a.name = '" + this.globalMember.name + "' AND a.surname = '" + this.globalMember.surname + "' AND b.name = '" + member.name + "' AND b.surname= '" + member.surname + "'  " +
                                                                    "CREATE(a) < - [r: " + this.globalRelative + "] - (b)" +
                                                                    "RETURN type(r)",
                     queryDict, CypherResultMode.Set);
                    ((IRawGraphClient)client).ExecuteCypher(query15);
                }
                if (this.globalRelative == null)
                {
                    this.NameForNewMember = member.name;
                    this.SurnameForNewMember = member.surname;
                }
            }
            else
            {
                familyMember memberForChange = this.createMember();
                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                var query16 = new Neo4jClient.Cypher.CypherQuery("MATCH (n { name: '"+globalMember.name+"', surname: '"+globalMember.surname+ "' }) SET n = {id:'" + memberForChange.id + "', name:'" + memberForChange.name
                                                                + "',surname:'" + memberForChange.surname + "', birthday:'" + memberForChange.birthday + "', birthPlace:'" + memberForChange.birthPlace
                                                                + "',yearOfDeath:'" + memberForChange.yearOfDeath + "',eAddress:'" + memberForChange.eAddress
                                                                + "',gender:'" + memberForChange.gender + "', live:'" + memberForChange.live + "', biography:'" + memberForChange.biography
                                                                + "'} RETURN n",
                                                                queryDict, CypherResultMode.Set);

                ((IRawGraphClient)client).ExecuteCypher(query16);
                MessageBox.Show("Promenjen je "+memberForChange.name+" "+memberForChange.surname);
                btnAdd.Text = "Dodaj";
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
