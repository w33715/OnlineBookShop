using System.Data.SqlClient;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyStore.Pages.Clients
{
    public class DeleteModel : PageModel
    {
        public ClientInfo clientInfo = new ClientInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
            try
            {
                string id = Request.Query["id"];
                string connectionString = "Data Source=IGOR-LAPTOP\\W33715;Initial Catalog=mystore;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlString = "DELETE FROM clients WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sqlString, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                // errorMessage = ex.Message;
                // return;
            }
            Response.Redirect("/Clients/Index");
        }
    }
}
