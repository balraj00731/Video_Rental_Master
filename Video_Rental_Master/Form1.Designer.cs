
namespace Video_Rental_Master
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cust_city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.custo_country = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.custo_mobile = new System.Windows.Forms.TextBox();
            this.add_customer = new System.Windows.Forms.Button();
            this.update_customer = new System.Windows.Forms.Button();
            this.delete_customer = new System.Windows.Forms.Button();
            this.deleteVideo = new System.Windows.Forms.Button();
            this.video_update = new System.Windows.Forms.Button();
            this.add_video = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.copies = new System.Windows.Forms.TextBox();
            this.year_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.genre_video = new System.Windows.Forms.TextBox();
            this.plot_video = new System.Windows.Forms.TextBox();
            this.vd_add = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rental_customerId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rental_movieId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rental_startDate = new System.Windows.Forms.DateTimePicker();
            this.rental_endDate = new System.Windows.Forms.DateTimePicker();
            this.delete_rentalMovie = new System.Windows.Forms.Button();
            this.return_movie = new System.Windows.Forms.Button();
            this.issue_movie = new System.Windows.Forms.Button();
            this.popular_videos = new System.Windows.Forms.Button();
            this.popular_customer = new System.Windows.Forms.Button();
            this.clickCustomers = new System.Windows.Forms.Button();
            this.clickVideos = new System.Windows.Forms.Button();
            this.clickRentals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Customer ";
            // 
            // customer_name
            // 
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.Location = new System.Drawing.Point(143, 56);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(135, 24);
            this.customer_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "City";
            // 
            // cust_city
            // 
            this.cust_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_city.Location = new System.Drawing.Point(143, 100);
            this.cust_city.Name = "cust_city";
            this.cust_city.Size = new System.Drawing.Size(135, 24);
            this.cust_city.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Country";
            // 
            // custo_country
            // 
            this.custo_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custo_country.Location = new System.Drawing.Point(382, 100);
            this.custo_country.Name = "custo_country";
            this.custo_country.Size = new System.Drawing.Size(135, 24);
            this.custo_country.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mobile ";
            // 
            // custo_mobile
            // 
            this.custo_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custo_mobile.Location = new System.Drawing.Point(382, 56);
            this.custo_mobile.Name = "custo_mobile";
            this.custo_mobile.Size = new System.Drawing.Size(135, 24);
            this.custo_mobile.TabIndex = 6;
            // 
            // add_customer
            // 
            this.add_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_customer.Location = new System.Drawing.Point(543, 11);
            this.add_customer.Name = "add_customer";
            this.add_customer.Size = new System.Drawing.Size(150, 39);
            this.add_customer.TabIndex = 10;
            this.add_customer.Text = "Add Customer";
            this.add_customer.UseVisualStyleBackColor = false;
            this.add_customer.Click += new System.EventHandler(this.add_customer_Click);
            // 
            // update_customer
            // 
            this.update_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.update_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_customer.Location = new System.Drawing.Point(526, 56);
            this.update_customer.Name = "update_customer";
            this.update_customer.Size = new System.Drawing.Size(181, 49);
            this.update_customer.TabIndex = 11;
            this.update_customer.Text = "Update Customer";
            this.update_customer.UseVisualStyleBackColor = false;
            this.update_customer.Click += new System.EventHandler(this.update_customer_Click);
            // 
            // delete_customer
            // 
            this.delete_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_customer.Location = new System.Drawing.Point(526, 111);
            this.delete_customer.Name = "delete_customer";
            this.delete_customer.Size = new System.Drawing.Size(181, 49);
            this.delete_customer.TabIndex = 12;
            this.delete_customer.Text = "Delete Customer";
            this.delete_customer.UseVisualStyleBackColor = false;
            this.delete_customer.Click += new System.EventHandler(this.delete_customer_Click);
            // 
            // deleteVideo
            // 
            this.deleteVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteVideo.Location = new System.Drawing.Point(553, 597);
            this.deleteVideo.Name = "deleteVideo";
            this.deleteVideo.Size = new System.Drawing.Size(181, 49);
            this.deleteVideo.TabIndex = 24;
            this.deleteVideo.Text = "Delete";
            this.deleteVideo.UseVisualStyleBackColor = false;
            this.deleteVideo.Click += new System.EventHandler(this.deleteVideo_Click);
            // 
            // video_update
            // 
            this.video_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.video_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.video_update.Location = new System.Drawing.Point(553, 542);
            this.video_update.Name = "video_update";
            this.video_update.Size = new System.Drawing.Size(181, 49);
            this.video_update.TabIndex = 23;
            this.video_update.Text = "Update Video";
            this.video_update.UseVisualStyleBackColor = false;
            this.video_update.Click += new System.EventHandler(this.video_update_Click);
            // 
            // add_video
            // 
            this.add_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_video.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_video.Location = new System.Drawing.Point(570, 487);
            this.add_video.Name = "add_video";
            this.add_video.Size = new System.Drawing.Size(150, 49);
            this.add_video.TabIndex = 22;
            this.add_video.Text = "Add Video";
            this.add_video.UseVisualStyleBackColor = false;
            this.add_video.Click += new System.EventHandler(this.add_video_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 31);
            this.label10.TabIndex = 13;
            this.label10.Text = "Enter Details for Video ";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(395, 603);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(135, 26);
            this.price.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(304, 605);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 21);
            this.label14.TabIndex = 54;
            this.label14.Text = "Price";
            // 
            // copies
            // 
            this.copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copies.Location = new System.Drawing.Point(395, 565);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(135, 26);
            this.copies.TabIndex = 53;
            // 
            // year_textbox
            // 
            this.year_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_textbox.Location = new System.Drawing.Point(395, 532);
            this.year_textbox.Name = "year_textbox";
            this.year_textbox.Size = new System.Drawing.Size(135, 26);
            this.year_textbox.TabIndex = 52;
            this.year_textbox.TextChanged += new System.EventHandler(this.year_textbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "Plot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 49;
            this.label7.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "Copies";
            // 
            // genre_video
            // 
            this.genre_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_video.Location = new System.Drawing.Point(110, 598);
            this.genre_video.Name = "genre_video";
            this.genre_video.Size = new System.Drawing.Size(135, 26);
            this.genre_video.TabIndex = 47;
            // 
            // plot_video
            // 
            this.plot_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot_video.Location = new System.Drawing.Point(110, 563);
            this.plot_video.Name = "plot_video";
            this.plot_video.Size = new System.Drawing.Size(135, 26);
            this.plot_video.TabIndex = 46;
            // 
            // vd_add
            // 
            this.vd_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vd_add.Location = new System.Drawing.Point(110, 524);
            this.vd_add.Name = "vd_add";
            this.vd_add.Size = new System.Drawing.Size(135, 26);
            this.vd_add.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 21);
            this.label11.TabIndex = 44;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(857, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 31);
            this.label12.TabIndex = 56;
            this.label12.Text = "Rental Data ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(809, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 61;
            this.label13.Text = "Customer Id";
            // 
            // rental_customerId
            // 
            this.rental_customerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_customerId.Location = new System.Drawing.Point(961, 100);
            this.rental_customerId.Name = "rental_customerId";
            this.rental_customerId.Size = new System.Drawing.Size(135, 24);
            this.rental_customerId.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(809, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 19);
            this.label15.TabIndex = 59;
            this.label15.Text = "Movie Id";
            // 
            // rental_movieId
            // 
            this.rental_movieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_movieId.Location = new System.Drawing.Point(961, 58);
            this.rental_movieId.Name = "rental_movieId";
            this.rental_movieId.Size = new System.Drawing.Size(135, 24);
            this.rental_movieId.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(813, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 19);
            this.label16.TabIndex = 63;
            this.label16.Text = "Return Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(809, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 19);
            this.label17.TabIndex = 62;
            this.label17.Text = "Issue Date ";
            // 
            // rental_startDate
            // 
            this.rental_startDate.Location = new System.Drawing.Point(935, 141);
            this.rental_startDate.Name = "rental_startDate";
            this.rental_startDate.Size = new System.Drawing.Size(200, 20);
            this.rental_startDate.TabIndex = 64;
            // 
            // rental_endDate
            // 
            this.rental_endDate.Location = new System.Drawing.Point(935, 183);
            this.rental_endDate.Name = "rental_endDate";
            this.rental_endDate.Size = new System.Drawing.Size(200, 20);
            this.rental_endDate.TabIndex = 65;
            // 
            // delete_rentalMovie
            // 
            this.delete_rentalMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_rentalMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_rentalMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_rentalMovie.Location = new System.Drawing.Point(813, 284);
            this.delete_rentalMovie.Name = "delete_rentalMovie";
            this.delete_rentalMovie.Size = new System.Drawing.Size(236, 49);
            this.delete_rentalMovie.TabIndex = 68;
            this.delete_rentalMovie.Text = "Delete From Database";
            this.delete_rentalMovie.UseVisualStyleBackColor = false;
            this.delete_rentalMovie.Click += new System.EventHandler(this.delete_rentalMovie_Click);
            // 
            // return_movie
            // 
            this.return_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.return_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_movie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.return_movie.Location = new System.Drawing.Point(954, 229);
            this.return_movie.Name = "return_movie";
            this.return_movie.Size = new System.Drawing.Size(181, 49);
            this.return_movie.TabIndex = 67;
            this.return_movie.Text = "Return Movie";
            this.return_movie.UseVisualStyleBackColor = false;
            this.return_movie.Click += new System.EventHandler(this.return_movie_Click);
            // 
            // issue_movie
            // 
            this.issue_movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.issue_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_movie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.issue_movie.Location = new System.Drawing.Point(699, 229);
            this.issue_movie.Name = "issue_movie";
            this.issue_movie.Size = new System.Drawing.Size(207, 49);
            this.issue_movie.TabIndex = 66;
            this.issue_movie.Text = "Issue New Movie";
            this.issue_movie.UseVisualStyleBackColor = false;
            this.issue_movie.Click += new System.EventHandler(this.issue_movie_Click);
            // 
            // popular_videos
            // 
            this.popular_videos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_videos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popular_videos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.popular_videos.Location = new System.Drawing.Point(813, 380);
            this.popular_videos.Name = "popular_videos";
            this.popular_videos.Size = new System.Drawing.Size(236, 49);
            this.popular_videos.TabIndex = 69;
            this.popular_videos.Text = "Popular Videos";
            this.popular_videos.UseVisualStyleBackColor = false;
            this.popular_videos.Click += new System.EventHandler(this.popular_videos_Click);
            // 
            // popular_customer
            // 
            this.popular_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.popular_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popular_customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.popular_customer.Location = new System.Drawing.Point(813, 445);
            this.popular_customer.Name = "popular_customer";
            this.popular_customer.Size = new System.Drawing.Size(236, 49);
            this.popular_customer.TabIndex = 70;
            this.popular_customer.Text = "Popular Customer";
            this.popular_customer.UseVisualStyleBackColor = false;
            this.popular_customer.Click += new System.EventHandler(this.popular_customer_Click);
            // 
            // clickCustomers
            // 
            this.clickCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clickCustomers.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickCustomers.ForeColor = System.Drawing.Color.White;
            this.clickCustomers.Location = new System.Drawing.Point(143, 424);
            this.clickCustomers.Name = "clickCustomers";
            this.clickCustomers.Size = new System.Drawing.Size(115, 48);
            this.clickCustomers.TabIndex = 71;
            this.clickCustomers.Text = "Customers";
            this.clickCustomers.UseVisualStyleBackColor = false;
            this.clickCustomers.UseWaitCursor = true;
            this.clickCustomers.Click += new System.EventHandler(this.clickCustomers_Click);
            // 
            // clickVideos
            // 
            this.clickVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clickVideos.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickVideos.ForeColor = System.Drawing.Color.White;
            this.clickVideos.Location = new System.Drawing.Point(281, 424);
            this.clickVideos.Name = "clickVideos";
            this.clickVideos.Size = new System.Drawing.Size(111, 48);
            this.clickVideos.TabIndex = 72;
            this.clickVideos.Text = "Movies";
            this.clickVideos.UseVisualStyleBackColor = false;
            this.clickVideos.Click += new System.EventHandler(this.clickVideos_Click);
            // 
            // clickRentals
            // 
            this.clickRentals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clickRentals.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickRentals.ForeColor = System.Drawing.Color.White;
            this.clickRentals.Location = new System.Drawing.Point(425, 424);
            this.clickRentals.Name = "clickRentals";
            this.clickRentals.Size = new System.Drawing.Size(92, 48);
            this.clickRentals.TabIndex = 73;
            this.clickRentals.Text = "Rentals";
            this.clickRentals.UseVisualStyleBackColor = false;
            this.clickRentals.Click += new System.EventHandler(this.clickRentals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1157, 665);
            this.Controls.Add(this.clickRentals);
            this.Controls.Add(this.clickVideos);
            this.Controls.Add(this.clickCustomers);
            this.Controls.Add(this.popular_customer);
            this.Controls.Add(this.popular_videos);
            this.Controls.Add(this.delete_rentalMovie);
            this.Controls.Add(this.return_movie);
            this.Controls.Add(this.issue_movie);
            this.Controls.Add(this.rental_endDate);
            this.Controls.Add(this.rental_startDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rental_customerId);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rental_movieId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.year_textbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genre_video);
            this.Controls.Add(this.plot_video);
            this.Controls.Add(this.vd_add);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.deleteVideo);
            this.Controls.Add(this.video_update);
            this.Controls.Add(this.add_video);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.delete_customer);
            this.Controls.Add(this.update_customer);
            this.Controls.Add(this.add_customer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.custo_country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.custo_mobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cust_city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cust_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custo_country;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custo_mobile;
        private System.Windows.Forms.Button add_customer;
        private System.Windows.Forms.Button update_customer;
        private System.Windows.Forms.Button delete_customer;
        private System.Windows.Forms.Button deleteVideo;
        private System.Windows.Forms.Button video_update;
        private System.Windows.Forms.Button add_video;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.TextBox year_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox genre_video;
        private System.Windows.Forms.TextBox plot_video;
        private System.Windows.Forms.TextBox vd_add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox rental_customerId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rental_movieId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker rental_startDate;
        private System.Windows.Forms.DateTimePicker rental_endDate;
        private System.Windows.Forms.Button delete_rentalMovie;
        private System.Windows.Forms.Button return_movie;
        private System.Windows.Forms.Button issue_movie;
        private System.Windows.Forms.Button popular_videos;
        private System.Windows.Forms.Button popular_customer;
        private System.Windows.Forms.Button clickCustomers;
        private System.Windows.Forms.Button clickVideos;
        private System.Windows.Forms.Button clickRentals;
    }
}

