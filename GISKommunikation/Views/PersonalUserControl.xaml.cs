using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GISKommunikation.Models;
using GISKommunikation.ViewModels;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace GISKommunikation.Views
{
    /// <summary>
    /// Interaktionslogik für PersonalUserControl.xaml
    /// </summary>
    public partial class PersonalUserControl : UserControl
    {
        public PersonalUserControl()
        {
            InitializeComponent();
            CreateData();
        }
        public IList<PersonalModel> persons = new List<PersonalModel>();
        private string connectionString;

        private void CreateData()
        {
            connectionString = @"Data Source=GIS-KS-SQL\GIS;Initial Catalog=GIS2000;  UID=GIS2000;Password=GIS2000";
            string sqlOldDataString = "SELECT * FROM Aushilfen";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlOldDataString, sqlConnection);
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

                                   Kdnr = dr["Stamm_ort"].ToString(),
                                   Name = dr["Nachname"].ToString(),
                                   Vorname = dr["Vorname"].ToString(),
                                   //  PersNr = Convert.ToInt32(dr["PersNr"]),
                               }).ToList();
                }

                dataGridPersonal.ItemsSource= persons;
                txbTimerLabel.Text=persons.Count.ToString();
            }
        }

    }
}
