using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Crud1
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        string strSql = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server=localhost\SQLEXPRESS02;Database=Cliente;Trusted_Connection=True;TrustServerCertificate=true");

                strSql = "INSERT INTO CAD_CLIENTE (ID, NOME, NUMERO) VALUES (@Id,@NOME, @NUMERO)";

                command = new SqlCommand(strSql, connection);

                command.Parameters.AddWithValue("@ID", txtId.Text);
                command.Parameters.AddWithValue("@NOME", txtName.Text);
                command.Parameters.AddWithValue("@NUMERO", txtNum.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }


        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server=localhost\SQLEXPRESS02;Database=Cliente;Trusted_Connection=True;TrustServerCertificate=true");

                strSql = "SELECT * FROM CAD_CLIENTE ";

                DataSet dataSet = new DataSet();
                adapter = new SqlDataAdapter(strSql, connection);
                connection.Open();

                adapter.Fill(dataSet);

                dgvDados.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server=localhost\SQLEXPRESS02;Database=Cliente;Trusted_Connection=True;TrustServerCertificate=true");

                strSql = "SELECT * FROM CAD_CLIENTE WHERE ID = @ID";

                command = new SqlCommand(strSql, connection);

                command.Parameters.AddWithValue("@ID", txtId.Text);



                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtName.Text = (string)reader["nome"];
                    txtNum.Text = Convert.ToString(reader["numero"]); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }
    }
}