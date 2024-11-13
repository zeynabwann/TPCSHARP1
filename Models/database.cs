using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Name.Models;
using System.Data.SqlClient;
namespace Name.pagemodel
{
    public class ClientModel :  PageModel{
       public  List<Client> clients = new List<Client>();
        public void OnGet()
        {
            try
            {
                String connection="";
                using (SqlConnection connection = new SqlConnection(connection)){
                    connection.open();
                    String sql = "SELECT * FROM  client";
                    using (SqlCommand = new SqlCommand(sql, connection)){
                        using(SqlDataReader reader =Command.ExecuteReader()){
                            while (Reader.Read())
                            {
                                Client client new Client();
                                client.Id ="" + reader.GetInt32(0);
                                client.Surnom ="" + reader.GetInt32(0);  
                                                                client.Id ="" + reader.GetInt32(0);
                                client.Telephone ="" + reader.GetInt32(0);
                                client.Addresse ="" + reader.GetInt32(0);
                                clients.Add(client);


                            }


                        }
                    }
                }
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Exception");
            }

        }
    }
    public class Client{
        public String id;
        public String surnom;
        public String telephone;
         public String addresse;



    }

}