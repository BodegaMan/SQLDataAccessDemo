using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {

        public List<Person> GetPeople(string lastName)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //return connection.Query<Person>($"SELECT * FROM PEOPLE WHERE LASTNAME = '{lastName}'").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
            
        }

        public List<Person> GetAllPeople()
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //return connection.Query<Person>($"SELECT * FROM PEOPLE WHERE LASTNAME = '{lastName}'").ToList();
                var output = connection.Query<Person>("dbo.People_GetAll").ToList();
                return output;
            }

        }


        public int CreatePerson(string firstName, string lastName, string email, string phone)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    EmailAddress = email,
                    PhoneNumber = phone
                });

                int ID = connection.Execute("dbo.PeopleInsert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people); 
                
                return ID;
            }
        }

    }
}
