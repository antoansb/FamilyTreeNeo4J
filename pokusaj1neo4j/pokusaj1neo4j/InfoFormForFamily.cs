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
    public partial class InfoFormForFamily : Form
    {
        public GraphClient client;
        public familyMember globalMember;
        public Family globalFamily;
        public List<familyMember> familyMembers;

        public InfoFormForFamily(familyMember glMember, Family glFamily, List<familyMember> AllMembers)
        {
            InitializeComponent();
            globalMember = glMember;
            globalFamily = glFamily;
            familyMembers = AllMembers;
            lbl.Text = "Svi clanovi porodice "+globalFamily.familyName+".";
            popuniInicijalno();
            foreach(familyMember f in familyMembers)
            {
                String pol;
                if (f.gender == "Male")
                    pol = "Musko";
                else pol = "Zensko";
                add(f.name, f.surname, f.eAddress, pol, f.birthPlace, f.biography);
            }
        }

        public void popuniInicijalno()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Ime", 100);
            listView1.Columns.Add("Prezime", 100);
            listView1.Columns.Add("E-adresa", 100);
            listView1.Columns.Add("pol", 95);
            listView1.Columns.Add("Mesto rodjenja", 110);
            listView1.Columns.Add("Biografija", 100);
        }

        public void add(string name, string surname, string eaddress, string gender, string placeOfBirth, string bio)
        {
            String[] row = { name, surname, eaddress, gender, placeOfBirth, bio };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

    }
}
