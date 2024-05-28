using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace kopie_FiktPersNr
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public class Persons
        //{
        //    public int FP_FktPersNr_ID { get; set; }
        //    public int fPersNr { get; set; }
        //    public string Aufgen_von { get; set; }
        //    public DateTime Aufgen_am { get; set; }
        //    public string Kdnr { get; set; }
        //    public string Name { get; set; }
        //    public string Vorname { get; set; }
        //    public DateTime Geburtstag { get; set; }
        //    public int PersNr { get; set; }
        //    public string Infotext { get; set; }
        //    public string PersNr_Upd_von { get; set; }
        //    public DateTime PersNr_Upd_am { get; set; }
        //    public string Mod_von { get; set; }
        //    public string Mod_am { get; set; }
        //}
        //public static List<Persons> personenList=new List<Persons>();
        //string queryString = "SELECT * FROM FP_FiktPersNr";
        
        
        public string queryString = "SELECT * FROM Persons";
        public DataGrid readPerson(string queryString)
        {
            //string connectionString = @"Data Source=GIS-KS-SQL/GIS; Initial Catalog=GIS2000;"+
            //                          "User ID=GIS2000;Password=GIS=2000";
            string connectionString = @"Data Source=IGOR-LAPTOP;Database=Unternehmen;Trusted_Connection=True;";
            using (SqlConnection sqlConnection=new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();
                DataSet dataSet= new DataSet();
                using (SqlDataAdapter reader= new SqlDataAdapter(queryString,sqlConnection))
                {
                    reader.Fill(dataSet, "personenTable");
                   dgPersons.ItemsSource = dataSet.Tables[0].DefaultView;
                }
                
                sqlConnection.Close(); 
                return dgPersons;
                
            }
        }      
       
        public MainWindow()
        {
            InitializeComponent();
            readPerson(queryString);    
        }
    }
}
