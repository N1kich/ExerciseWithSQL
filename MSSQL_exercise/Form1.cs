using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient; 


namespace MSSQL_exercise
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = null;
        private SqlConnection northwindConnection = null;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NikichDB"].ConnectionString);
            connection.Open();

            northwindConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["northwind"].ConnectionString);
            northwindConnection.Open();
            if (connection.State == ConnectionState.Open && northwindConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено!");
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand command = new SqlCommand(
              $"INSERT INTO [Employee] (Name, Surname, Birthday, PlaceOfBirthday, Phone, Email)" +
              $"VALUES (@Name, @Surname, @Birthday, @PlaceOfBirthday, @Phone, @Email)", connection);

                DateTime data = DateTime.Parse(BdayBox.Text);
                command.Parameters.AddWithValue("Name", NameBox.Text);
                command.Parameters.AddWithValue("Surname", SurnameBox.Text);
                command.Parameters.AddWithValue("Birthday", $"{data.Month}/{data.Day}/{data.Year}"); ;
                command.Parameters.AddWithValue("PlaceOfBirthday", BornPlaceBox.Text);
                command.Parameters.AddWithValue("Phone", PhoneBox.Text);
                command.Parameters.AddWithValue("Email", EmailBox.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString());
            }
            catch (System.FormatException ex) 
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (requestBox.Text == "")
                {
                    MessageBox.Show("ERROR\n Please entry a request to get data!\n", "WARNING!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dataAdapter = new SqlDataAdapter(requestBox.Text, northwindConnection);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dataView.DataSource = dataSet.Tables[0];
                }
            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Your request is incorrect\n Rewrite your request and try again\n",
                    "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
