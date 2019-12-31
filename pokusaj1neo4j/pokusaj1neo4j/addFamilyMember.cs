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
        public addFamilyMember(String relative)
        {
            InitializeComponent();
            labelForNewMember.Text = "Novi clan je " +relative+" clanu +ime+";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            familyMember member = this.createMember();
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

        private void btnDeath(object sender, EventArgs e)
        {
            layoutForDeath.Visible = !layoutForDeath.Visible;
        }
    }
}
