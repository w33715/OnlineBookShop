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
using Excel= Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;
using System.Reflection;
using GISKommunikation.Repository;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Markup;
using DataTable = System.Data.DataTable;
using System.Windows.Forms;
using UserControl = System.Windows.Controls.UserControl;

namespace GISKommunikation.Views
{
    /// <summary>
    /// Interaktionslogik für PersonalUserControl.xaml
    /// </summary>
    public partial class PersonalUserControl : UserControl
    {
        //public string sqlDataString = "SELECT * FROM vwKommPers";
        public string sqlDataString = "SELECT * FROM Customers";
        public PersonalUserControl()
        {

            InitializeComponent();



            CreateData(sqlDataString);
            ShowByAll();
            //ShowByServiceL();


        }
        public IList<PersonalModel> persons = new List<PersonalModel>();
        public IList<PersonalModel> filteredList = new List<PersonalModel>();
        private DataGrid Getdata()
        {
            return dataGridPersonal;
        }



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
                                   Name = dr["CompanyName"].ToString(),
                                   //Name = dr["Nachname"].ToString(),
                                   Vorname = dr["ContactName"].ToString(),
                                   //Vorname = dr["Vorname"].ToString(),
                                   Kdnr = dr["ContactTitle"].ToString(),
                                   //Kdnr = dr["Stamm_ort"].ToString(),
                                   Telefon = dr["City"].ToString(),
                                   //Telefon = dr["Telefon"].ToString(),
                                   //Handy = dr["Handy"].ToString(),
                                   //  PersNr = Convert.ToInt32(dr["PersNr"]),
                               }).ToList();

                }
                return persons;
            }
        }


        public DataGrid ShowByAll()
        {

           
           
                dataGridPersonal.ItemsSource = persons;
            
           




            return dataGridPersonal;

        }

        public void ShowByServiceL()

        {
            MainWindow mainWindow = new MainWindow();
            if (mainWindow.chBoxServiceL.IsChecked == true)
            {
                //sqlDataString = " SELECT * FROM vwKommPers WHERE Vorname=" + "'Cerkin'";
                sqlDataString = " SELECT * FROM Employees WHERE FirstName=" + "'Nancy'";
                CreateData(sqlDataString);
                ShowByAll();


            }
            else
            {

                sqlDataString = "SELECT * FROM Employees";
                CreateData(sqlDataString);
                ShowByAll();
            }



            //var filteredList = from p in persons
            //                   where p.Vorname == "Cerkin"
            //                   select new { p.Vorname, p.Name, p.Telefon, p.Handy };



        }
        //public DataGrid ShowByTeamL()
        //{

        //}
        //public DataGrid ShowClientNumber()
        //{

        //}
        //public DataGrid ShowByAge()
        //{

        //}
        //public DataGrid ShowByRegion()
        //{

        //}



        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            //string pattern = @"^[a-zA-Z]";
            //if (Regex.IsMatch(txtSearch.Text, pattern))
            //{
            //    sqlDataString = "SELECT * FROM vwKommPers WHERE" +

            //                        " (Nachname LIKE '" + '%' + txtSearch.Text.Substring(0, txtSearch.Text.Length) + '%' + "'" + ")" +
            //                        //" OR (Kdnr LIKE '" + '%' + txtSearch.Text.Substring(0, txtSearch.Text.Length) + '%' + "'" + " AND PersNr IS NULL)" +
            //                        " OR (Vorname LIKE '" + '%' + txtSearch.Text.Substring(0, txtSearch.Text.Length) + '%' + "'" + ")";
            //    //" OR (Aufgen_von LIKE '" + '%' + txtSearch.Text.Substring(0, txtSearch.Text.Length) + '%' + "'" + " AND PersNr IS NULL)";
            //    CreateData(sqlDataString);
            //    ShowByAll();

            //}
            string pattern = @"^[a-zA-Z]";
            if (Regex.IsMatch(txtSearch.Text, pattern))
            {
                sqlDataString = "SELECT * FROM Employees WHERE" +

                                    " (LastName LIKE '" + '%' + txtSearch.Text.Substring(0, txtSearch.Text.Length) + '%' + "'" + ")" +
                                    //" OR (Kdnr LIKE '" + '%' + txtSearch.Text.Substring(0, txtSearch.Text.Length) + '%' + "'" + " AND PersNr IS NULL)" +
                                    " OR (FirstName LIKE '" + '%' + txtSearch.Text.Substring(0, txtSearch.Text.Length) + '%' + "'" + ")";
                //" OR (Aufgen_von LIKE '" + '%' + txtSearch.Text.Substring(0, txtSearch.Text.Length) + '%' + "'" + " AND PersNr IS NULL)";
                CreateData(sqlDataString);
                ShowByAll();

            }

        }
        public void copyAllToClipboard()
        {
            dataGridPersonal.SelectAllCells();
            dataGridPersonal.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, this.dataGridPersonal);
            this.dataGridPersonal.UnselectAllCells();

        }

        private void btnToExcel_Click(object sender, RoutedEventArgs e)
        {
            //this.dataGridPersonal.SelectAllCells();
            //this.dataGridPersonal.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            //ApplicationCommands.Copy.Execute(null, this.dataGridPersonal);
            //this.dataGridPersonal.UnselectAllCells();
            //String result = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            //try
            //{
            //    StreamWriter sw = new StreamWriter("wpfdata.csv");
            //    sw.WriteLine(result);
            //    sw.Close();
            //    Process.Start("wpfdata.csv");
            //}
            //catch (Exception ex)
            //{ }



            //dataGridPersonal.SelectAllCells();
            //dataGridPersonal.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            // ApplicationCommands.Copy.Execute(null, dataGridPersonal);
            // String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            // String result = (string)Clipboard.GetData(DataFormats.Text);
            // dataGridPersonal.UnselectAllCells();
            // System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Programmierung\Projekte_C#\test.xlsx");
            // file.WriteLine(result.Replace(',', ' '));
            // file.Close();

            // MessageBox.Show(" Exporting DataGrid data to Excel file created");

            //dataGridPersonal.SelectAllCells();
            //dataGridPersonal.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            //ApplicationCommands.Copy.Execute(null, dataGridPersonal);
            //String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            //String result = (string)Clipboard.GetData(DataFormats.Text);
            //dataGridPersonal.UnselectAllCells();
            //StreamWriter file = new StreamWriter(@"D:\Programmierung\Projekte_C#\test.xls", true, Encoding.GetEncoding(1251));
            //file.WriteLine(result.Replace(',', ' '));
            //file.Close();
            //MessageBox.Show("Exporting DataGrid data to Excel file created");

           

           
        }
    }










        //public string ShowData()

        //{
        //   MainWindow mainWindow = new MainWindow();


        //        mainWindow.txbTimerLabel.Text = dataGridPersonal.Items.Count.ToString();

        //    //personalUserControl.ShowEmployees();
        //    mainWindow.Parent= mainWindow;
        //    return mainWindow.txbTimerLabel.Text;


        //    //personalUserControl.CreateData();
        //    //personalUserControl.dataGridPersonal.ItemsSource = personalUserControl.persons;




        //}
    }


