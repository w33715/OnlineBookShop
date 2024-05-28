using GISKommunikation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GISKommunikation.Repository
{
    public class PersonalRepository:IPersonalRepository
    {

        public IList<PersonalModel> persons = new List<PersonalModel>();
        private string connectionString;

        //private void CreateData()
        //{

        //    string sqlOldDataString = "SELECT * FROM Aushilfen";

        //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(sqlOldDataString, sqlConnection);
        //        sqlConnection.Open();

        //        using (SqlDataAdapter reader = new SqlDataAdapter(command))


        //        {
        //            if (persons == null) persons = new List<PersonalModel>();

        //            DataTable dataTable = new DataTable();
        //            if (dataTable == null)

        //                dataTable = new DataTable();
        //            else
        //            {
        //                dataTable.Clear();  // keine Doppelfüllung
        //            }
        //            reader.Fill(dataTable);
        //            sqlConnection.Close();

        //            persons = (from DataRow dr in dataTable.Rows
        //                       select new PersonalModel()
        //                       {

        //                           Kdnr = dr["Stamm_ort"].ToString(),
        //                           Name = dr["Nachname"].ToString(),
        //                           Vorname = dr["Vorname"].ToString(),
        //                           //  PersNr = Convert.ToInt32(dr["PersNr"]),
        //                       }).ToList();
        //        }


        //    }
        //}
        public IEnumerable<PersonalModel> GetByAll()
        {
            using (var connection =new  SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Aushilfen]";
                // DataSet dataSet = new DataSet();
                IEnumerable<UserModel> persons = new List<UserModel>();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.Fill((DataSet)persons, "CustomersTable");
                return (IEnumerable<PersonalModel>)persons;








            }
        }

    }
}
