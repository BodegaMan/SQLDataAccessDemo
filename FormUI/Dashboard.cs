using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using FormUI.Extensions;

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

        private void bCreate_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            ID = db.CreatePerson(firstText.Text, lastText.Text, emailText.Text, phoneText.Text);
        }

        private void bCreateCSV_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            Person peoples = new Person();

            people = db.GetAllPeople();

            //var records = new List<Person>
            //{
            //    new Person { Id = 1, Name = "one" },
            //    new Person { Id = 2, Name = "two" },

            //    new Person = new Person

            //};


            string dDay = DateTime.Today.Day.ToString();
            string dMonth = DateTime.Today.Month.ToString();
            string dYear = DateTime.Today.Year.ToString();

            string dHour = DateTime.Now.Hour.ToString();
            string dMinute = DateTime.Now.Minute.ToString();
            string dSeconds = DateTime.Now.Second.ToString();

            //if (dMonth.Length == 1) { dMonth = "0" + dMonth; }
            //if (dDay.Length == 1) { dDay = "0" + dDay; }

            string dDate = dMonth.PadMe(2) + dDay.PadMe(2) + dYear + dHour + dMinute + dSeconds + ".csv"; 

            string fileName = @"C:\\Architecture\\" + dDate;

            using (var writer = new StreamWriter(fileName))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(people);
            }
        }
    }
}
