using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;
using FiktPersNr;
using FiktPersNr.ViewModels;

namespace FiktPersNr.View
{
    /// <summary>
    /// Interaktionslogik für PersonAddView.xaml
    /// </summary>
    public partial class PersonAddView : Window
    {
         private static string connectionString = ConfigurationManager.ConnectionStrings["GIS2000"].ConnectionString;
        MainWindow window= new MainWindow();

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        public PersonAddView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //string queryString = "SELECT * FROM FP_FiktPersNr";
            //window.Refresh(queryString);
            
            
        }
        public void AddEmployees()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))

            if (txtEmployeeNumber.Text.Equals(""))
            {
                MessageBox.Show("Bitte eine Kundennummer eingeben.");

            }
            else
            { 
                try
                {
                   sqlConnection.Open();

                        {
                           //string sqlKey = "SET FOREIGN_KEY_CHECKS=0"; 
                           // // Prüfung auf Fremdschlüssel abschalten

                           //    SqlCommand command = new SqlCommand(sqlKey, sqlConnection);
                           // //    //sqlConnection.Open();
                           //   command.ExecuteNonQuery();

                            //        //Primary Key FP_FktPersNr_ID auf *Auto_Increment * ändern
                            // sqlKey = "ALTER TABLE FP_FiktPersNr MODIFY COLUMN FP_FiktPersNr_ID INT NOT NULL AUTO_INCREMENT";    //!!!!!
                            //SqlCommand command1 = new SqlCommand(sqlKey, sqlConnection);

                            //command1.ExecuteNonQuery();
                            string sqlInsert = "INSERT INTO FP_FiktPersNr (fPersNr, Kdnr, Name, Vorname) VALUES (" + txtEmployeeNumber.Text+",'"+txtKunde.Text+"', '"+
                                txtSurName.Text +"','"+ txtFirstName.Text+"')";
                          
                            // Hier könnten wir auch command1 verwenden, anstatt sqlKey und sqlInsert eine indifferente Variablename nehmen
                            SqlCommand command2 = new SqlCommand(sqlInsert, sqlConnection);
                       
                       // command2.Parameters.AddWithValue("@fPersNr", Int32.Parse(txtEmployeeNumber.Text));
                        //command2.Parameters.AddWithValue("@FP_FiktPersNr", txtAufgen_von.Text);
                      //  command2.Parameters.AddWithValue("@Kdnr", txtKunde.Text);
                        //command2.Parameters.AddWithValue("@FP_FiktPersNr", txtSurName.Text);
                        //command2.Parameters.AddWithValue("@FP_FiktPersNr", txtFirstName.Text);
                            //  command2.Parameters.AddWithValue("@FP_FiktPersNr", txtBirthday.Text);
                            command2.ExecuteNonQuery();
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType()+Environment.NewLine+ex.Message, "Datenbankfehler");
                    
                }
                finally 
                {
                        //// Die Ausnahmenprüfung wieder einsetzen
                        //string sqlKey = "SET FOREIGN_KEY_CHECKS=1";
                        //_ = new SqlCommand(sqlKey, sqlConnection);
                        //// sqlConnection.Open();
                        //command.ExecuteNonQuery();
                        ////// Die verbindung schließen
                        sqlConnection.Close();
                        //MessageBox.Show("Daten wurden gespeichert");
                        
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            //txtBirthday.Text.Equals("");
            //txtEmployeeNumber.Text.Equals("");
            //txtSurName.Text.Equals("");
            //txtFirstName.Text.Equals("");
            //txtAufgen_von.Text.Equals("");
            //txtKunde.Text.Equals("");

            PersonsFomClear personsFomClear = new PersonsFomClear();
           
            personsFomClear.Reset_Entry_Fields();

        }
       

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            AddEmployees();
            
        }

        
    }
}
