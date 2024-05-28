using GISKommunikation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using GISKommunikation.Views;

namespace GISKommunikation.Repository
{
    
    public class PersonalRepository : RepositoryBase, IPersonalRepository
    {
        public IList<PersonalModel> persons = new List<PersonalModel>();
        public IList<PersonalModel> filteredList = new List<PersonalModel>();

        public string sqlDataString = "SELECT * FROM Employees";


        public IEnumerable<PersonalModel> CreateData(string sqlDataString)
        {
            //string connectionString = @"Data Source=GIS-KS-SQL\GIS;Initial Catalog=GIS2000;  UID=GIS2000;Password=GIS2000";
            string connectionString = @"Data Source=IGOR-LAPTOP;Database=Northwind;Trusted_Connection=True;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlDataString, sqlConnection);
                sqlConnection.Open();

                using (SqlDataAdapter reader = new SqlDataAdapter(command))


                {
                    if (persons == null) persons = new List<PersonalModel>();

                    DataTable dataTable = new DataTable();
                    if (dataTable == null)

                        dataTable = new DataTable();
                    else
                    {
                        dataTable.Clear();  // keine Doppelfüllung
                    }
                    reader.Fill(dataTable);
                    sqlConnection.Close();

                    persons = (from DataRow dr in dataTable.Rows
                               select new PersonalModel()
                               {
                                   Name = dr["Lastname"].ToString(),
                                   //Name = dr["Nachname"].ToString(),
                                   Vorname = dr["FirstName"].ToString(),
                                   //Vorname = dr["Vorname"].ToString(),
                                   Kdnr = dr["Title"].ToString(),
                                   //Kdnr = dr["Stamm_ort"].ToString(),
                                   Telefon = dr["HomePhone"].ToString(),
                                   //Telefon = dr["Telefon"].ToString(),
                                   //Handy = dr["Handy"].ToString(),
                                   //  PersNr = Convert.ToInt32(dr["PersNr"]),
                               }).ToList();

                }
                return persons;
            }
        }

        public IEnumerable<PersonalModel> GetByAll()
        {
            CreateData(sqlDataString);
            return persons;
        }
    }
    
}
