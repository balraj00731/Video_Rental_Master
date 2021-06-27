using System.Data;
using System.Data.SqlClient;

namespace Video_Rental_Master
{
    public class BussinessLogic
    {
            public int CustomerId { get; set; }
            public int OptionId { get; set; }
            public string CustomerName { get; set; }
            public string Mobile { get; set; }
            public string City { get; set; }
            public string Country { get; set; }


            public int MovieId { get; set; }
            public string MovieName { get; set; }
            public string Year { get; set; }
            public string Plot { get; set; }
            public string Copies { get; set; }
            public string Genre { get; set; }
            public string Price { get; set; }


            public int BookingId { get; set; }
            public string BookMovie { get; set; }
            public string ReturnMovie { get; set; }


            public SqlConnection conn;

            public string connStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=Video_Rental_Master_Database;Integrated Security=True";
            public SqlCommand cmd;
            public SqlDataReader reader;
            public void DbInteractions(string query)
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            public DataTable Changes(string qry)
            {
                DataTable tbl = new DataTable();

                conn = new SqlConnection(connStr);

                conn.Open();

                cmd = new SqlCommand(qry, conn);

                reader = cmd.ExecuteReader();

                tbl.Load(reader);

                conn.Close();

                return tbl;
            }
    }
}
