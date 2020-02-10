using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        int ID = 0;

        public Dashboard()
        {
            InitializeComponent();
            RefreshBinding();
            RefreshID();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(lastNameText.Text);
            RefreshBinding();
            
        }

        public void RefreshBinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        public void RefreshID()
        {
            PersonID.Text = ID.ToString();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            ID = db.CreatePerson(firstText.Text, lastText.Text, emailText.Text, phoneText.Text);
            RefreshID();
        }
    }
}
