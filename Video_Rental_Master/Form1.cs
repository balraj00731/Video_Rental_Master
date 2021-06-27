using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            BussinessLogic bussinessLogic = new BussinessLogic();
            string cost;

        // it will show video on grid that are stored in database

        private void clickVideos_Click(object sender, EventArgs e)
        {
        bussinessLogic.OptionId = 3;
                DataTable dataTable = new DataTable();
                dataTable = bussinessLogic.Changes("select * from MovieTable");
                dataGridView1.DataSource = dataTable;
            }

        // record will be displayed to grid of customers that are stored in database

        private void clickCustomers_Click(object sender, EventArgs e)
        {
                bussinessLogic.OptionId = 1;

                DataTable dataTable = new DataTable();
                dataTable = bussinessLogic.Changes("select * from CustomerTable");
                dataGridView1.DataSource = dataTable;
            }


        // record stored in rental coulom of movies will be displayed in grid

        private void clickRentals_Click(object sender, EventArgs e)
        {
                bussinessLogic.OptionId = 2;

                DataTable dataTable = new DataTable();
                dataTable = bussinessLogic.Changes("select * from BookingTable");
                dataGridView1.DataSource = dataTable;
            }

        // popular vidoes will be displayed over here

        private void popular_videos_Click(object sender, EventArgs e)
        {

                DataTable dataTable = new DataTable();
                dataTable = bussinessLogic.Changes("select * from MovieTable");

                int a = 0;
                string Title = "";
                int b = 0;
                while (a < dataTable.Rows.Count)
                {
                    DataTable Rental = new DataTable();

                    Rental = bussinessLogic.Changes("select * from BookingTable where MovieId=" + Convert.ToInt32(dataTable.Rows[a]["MovieId"]) + "");


                    if (Rental.Rows.Count > b)
                    {

                        Title = dataTable.Rows[a]["title"].ToString();
                        b = Rental.Rows.Count;

                    }
                    a++;
                }
                MessageBox.Show(Title + "best Movie");
            }

        // following logic is to store record in database

            private void add_customer_Click(object sender, EventArgs e)
            {
                try
                {
                    if (customer_name.Text != "" && custo_mobile.Text != "" && cust_city.Text != "")
                    {
                        bussinessLogic.CustomerName = customer_name.Text;
                        bussinessLogic.Mobile = custo_mobile.Text;
                        bussinessLogic.City = cust_city.Text;
                        bussinessLogic.Country = custo_country.Text;

                        string qry = "insert into CustomerTable(CustomerName,Mobile,City,Country)values('" + bussinessLogic.CustomerName + "','" + bussinessLogic.Mobile + "','" + bussinessLogic.City + "','" + bussinessLogic.Country + "')";
                        bussinessLogic.DbInteractions(qry);
                        cust_city.Text = "";
                        custo_mobile.Text = "";
                        customer_name.Text = "";
                         custo_country.Text = "";

                        MessageBox.Show("Customer is Saved Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please check and fill all the inputs");
                }
            }

        // this will update record in customer cloumn

            private void update_customer_Click(object sender, EventArgs e)
        {
                try
                {
                    if (rental_customerId.Text != "" && customer_name.Text != "" && custo_mobile.Text != "" && cust_city.Text != "" && custo_country.Text != "")
                    {
                        bussinessLogic.CustomerId = Convert.ToInt32(rental_customerId.Text);
                        bussinessLogic.CustomerName = customer_name.Text;
                        bussinessLogic.Mobile = custo_mobile.Text;
                        bussinessLogic.City = cust_city.Text;
                        bussinessLogic.Country = custo_country.Text;

                        string qry = "update CustomerTable set CustomerName='" + bussinessLogic.CustomerName + "',Mobile='" + bussinessLogic.Mobile + "',City='" + bussinessLogic.City + "',Country='" + bussinessLogic.Country + "' where CustomerId=" + bussinessLogic.CustomerId + "";
                        bussinessLogic.DbInteractions(qry);
                        cust_city.Text = "";
                        custo_mobile.Text = "";
                        customer_name.Text = "";
                        rental_customerId.Text = "";
                        custo_country.Text = "";
                        MessageBox.Show("Customer Updated Successfully");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check and fill all the inputs");
                }
            }

        // to delete record from database

            private void delete_customer_Click(object sender, EventArgs e)
        {
                try
                {
                    if (rental_customerId.Text != "")
                    {
                        bussinessLogic.CustomerId = Convert.ToInt32(rental_customerId.Text);
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Are you sure you want to Delete Customer", "Confirmation Box ", buttons);
                        if (result == DialogResult.Yes)
                        {
                            string qry = "delete from CustomerTable where CustomerId=" + bussinessLogic.CustomerId + "";
                            bussinessLogic.DbInteractions(qry);
                            cust_city.Text = "";
                            custo_mobile.Text = "";
                            customer_name.Text = "";
                            custo_country.Text = "";
                            MessageBox.Show("Customer is Deleted Successfully");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please ensure Customer is valid");
                }
            }

        // add video record to database

            private void add_video_Click_1(object sender, EventArgs e)
        {
                try
                {
                    if (vd_add.Text != "" && price.Text != "" && year_textbox.Text != "" && copies.Text != "" && cost != "" && plot_video.Text != "" && genre_video.Text != "")
                    { 
                        bussinessLogic.MovieName = vd_add.Text;
                        bussinessLogic.Year = year_textbox.Text;
                        bussinessLogic.Copies = copies.Text;
                        bussinessLogic.Price = price.Text;
                        bussinessLogic.Plot = plot_video.Text;
                        bussinessLogic.Genre = genre_video.Text;

                        string qry = "Insert into MovieTable values('" + bussinessLogic.MovieName + "'," + bussinessLogic.Year + ",'" + bussinessLogic.Plot + "'," + bussinessLogic.Copies + ",'" + bussinessLogic.Genre + "'," + bussinessLogic.Price + ")";
                        bussinessLogic.DbInteractions(qry);
                        rental_movieId.Text = "";
                        vd_add.Text = "";
                        price.Text = "";
                        year_textbox.Text = "";
                        copies.Text = "";
                        plot_video.Text = "";
                        genre_video.Text = "";
                        MessageBox.Show("Video is Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Please check and fill all the inputs");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please check and fill all the inputs");
                }
            }

        // to del video from record

            private void deleteVideo_Click(object sender, EventArgs e)
        {
                try
                {
                    if (rental_movieId.Text != "")
                    {

                        bussinessLogic.MovieId = Convert.ToInt32(rental_movieId.Text);

                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Are you sure to delete Movie", "Confirmation Box ", buttons);
                        if (result == DialogResult.Yes)
                        {
                            string qry = "Delete from MovieTable where MovieId=" + bussinessLogic.MovieId + "";
                            bussinessLogic.DbInteractions(qry);
                            rental_movieId.Text = "";
                            vd_add.Text = "";
                            price.Text = "";
                            year_textbox.Text = "";
                            copies.Text = "";
                            plot_video.Text = "";
                            genre_video.Text = "";
                            MessageBox.Show("Video is Deleted Successfully");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid record");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid record");
                }

            }

        // to update record to database

            private void video_update_Click(object sender, EventArgs e)
        {
                try
                {
                    if (rental_movieId.Text != "" && vd_add.Text != "" && price.Text != "" && year_textbox.Text != "" && copies.Text != "" && cost != "" && plot_video.Text != "" && genre_video.Text != "")
                    {

                        bussinessLogic.MovieId = Convert.ToInt32(rental_movieId.Text);
                        bussinessLogic.MovieName = vd_add.Text;
                        bussinessLogic.Year = year_textbox.Text;
                        bussinessLogic.Copies = copies.Text;
                        bussinessLogic.Price = price.Text;
                        bussinessLogic.Plot = plot_video.Text;
                        bussinessLogic.Genre = genre_video.Text;


                        string qry = "Update MovieTable set MovieName='" + bussinessLogic.MovieName + "',Year=" + bussinessLogic.Year + ",Price=" + bussinessLogic.Price + ",Copies=" + bussinessLogic.Copies + ",Plot='" + bussinessLogic.Plot + "',Genre='" + bussinessLogic.Genre + "' where MovieId=" + bussinessLogic.MovieId + "";
                        bussinessLogic.DbInteractions(qry);
                        rental_movieId.Text = "";
                        vd_add.Text = "";
                        price.Text = "";
                        year_textbox.Text = "";
                        copies.Text = "";
                        plot_video.Text = "";
                        genre_video.Text = "";
                        MessageBox.Show("Record is update succesfuly");
                    }
                    else
                    {
                        MessageBox.Show("Please check and fill all the inputs");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please check and fill all the inputs");
                }


            }

        // issue movie 

            private void issue_movie_Click(object sender, EventArgs e)
            {
                try
                {
                    if (rental_customerId.Text != "" && rental_movieId.Text != "")
                    {
                        bussinessLogic.CustomerId = Convert.ToInt32(rental_customerId.Text);
                        bussinessLogic.MovieId = Convert.ToInt32(rental_movieId.Text);
                        bussinessLogic.BookMovie = rental_startDate.Text;
                        bussinessLogic.ReturnMovie = rental_endDate.Text;

                        string qry = "Insert into BookingTable(CustomerId,MovieId,BookMovie,ReturnMovie)values(" + bussinessLogic.CustomerId + "," + bussinessLogic.MovieId + ",'" + bussinessLogic.BookMovie + "','" + bussinessLogic.ReturnMovie + "')";
                        bussinessLogic.DbInteractions(qry);

                        rental_movieId.Text = "";
                        customer_name.Text = "";
                        cust_city.Text = "";
                        custo_mobile.Text = "";
                        rental_customerId.Text = "";
                        MessageBox.Show("Movie is Booked ");
                    }
                    else
                    {
                        MessageBox.Show("Please check and fill all the inputs");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please check and fill all the inputs");
                }
            }

        // delete rental movie

            private void delete_rentalMovie_Click(object sender, EventArgs e)
            {
                try
                {
                    if (bussinessLogic.BookingId > 0)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Are you sure to delete the Booked Movie ", "Confirmation Box ", buttons);
                        if (result == DialogResult.Yes)
                        {
                            string qry = "Delete from BookingTable where BookingId=" + bussinessLogic.BookingId + "";
                            bussinessLogic.DbInteractions(qry);

                            rental_movieId.Text = "";
                            customer_name.Text = "";
                            cust_city.Text = "";
                            custo_mobile.Text = "";
                            rental_customerId.Text = "";
                            MessageBox.Show("Booked Video is Deleted  Successfully");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Record");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Record");
                }


            }

            private void return_movie_Click(object sender, EventArgs e)
        {
                try
                {
                    if (bussinessLogic.BookingId > 0 && rental_customerId.Text != "" && rental_movieId.Text != "")
                    {
                        bussinessLogic.CustomerId = Convert.ToInt32(rental_customerId.Text);
                        bussinessLogic.MovieId = Convert.ToInt32(rental_movieId.Text);
                        bussinessLogic.BookMovie = rental_startDate.Text;
                        bussinessLogic.ReturnMovie = rental_endDate.Text;

                        string qry = "update  BookingTable set CustomerId=" + bussinessLogic.CustomerId + ",MovieId=" + bussinessLogic.MovieId + ",BookMovie='" + bussinessLogic.BookMovie + "',ReturnMovie='" + bussinessLogic.ReturnMovie + "' where BookingId=" + bussinessLogic.BookingId + "";
                        bussinessLogic.DbInteractions(qry);

                        DateTime nw = DateTime.Now;

                        DateTime old = Convert.ToDateTime(rental_startDate.Text);

                        string diff = (nw - old).TotalDays.ToString();

                        Double DaysInterval = Math.Round(Convert.ToDouble(diff));

                        DataTable dataTable = new DataTable();
                        dataTable = bussinessLogic.Changes("Select * from MovieTable where MovieId=" + Convert.ToInt32(rental_movieId.Text) + "");
                        int cost = Convert.ToInt32(dataTable.Rows[0]["Price"].ToString());

                        rental_movieId.Text = "";
                        customer_name.Text = "";
                        cust_city.Text = "";
                        custo_mobile.Text = "";
                        rental_customerId.Text = "";
                        MessageBox.Show("Movie is Returned Your Bill is $" + (DaysInterval * cost));
                    }
                    else
                    {
                        MessageBox.Show("Please check and fill all the inputs");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please check and fill all the inputs");
                }
            }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                switch (bussinessLogic.OptionId)
                {
                    case 1:

                        rental_customerId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        customer_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        custo_mobile.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        cust_city.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        custo_country.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        break;

                    case 2:
                        bussinessLogic.BookingId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        rental_customerId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        rental_movieId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        rental_startDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        break;

                    case 3:
                        rental_movieId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        vd_add.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        year_textbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    plot_video.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    copies.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        genre_video.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    price.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    break;
                }
                bussinessLogic.OptionId = 0;
            }

        private void popular_customer_Click(object sender, EventArgs e)
        {
        DataTable dataTablelVideos = new DataTable();

                dataTablelVideos = bussinessLogic.Changes("select * from CustomerTable");

                int a = 0;
                int b = 0;
                string Title = "";

                while (a < dataTablelVideos.Rows.Count)
                {
                    DataTable dataTablelRental = new DataTable();

                    dataTablelRental = bussinessLogic.Changes("select * from BookingTable where CustomerId=" + Convert.ToInt32(dataTablelVideos.Rows[a]["CustomerId"]) + "");


                    if (dataTablelRental.Rows.Count > b)
                    {

                        Title = dataTablelVideos.Rows[a]["MovieName"].ToString();
                        b = dataTablelRental.Rows.Count;
                    }
                    a++;
                }
                MessageBox.Show(Title + "best Customer");
            }

            private void year_textbox_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    int year = Convert.ToInt32(year_textbox.Text.ToString());
                    DateTime dateTime = DateTime.Now;

                    int currentYear = dateTime.Year;

                    if ((currentYear - year) > 5)
                    {
                        price.Text = "2";
                    }
                    else
                    {
                    price.Text = "5";
                    }
                }
                catch (Exception)
                {
                }
            }        
    }
}
