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

namespace LoginForm
{
    public partial class MenuForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-BE3UV51\SQLEXPRESS;Initial Catalog=Licenta;Integrated Security=True";
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Nume, Prenume, CNP, Sex, DataNasterii, Oras, Judet, NrTelefon, Medie FROM Studenti", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                //display data
                dgv1.DataSource = dtb1;           
  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat = new SqlDataAdapter("SELECT NumeDepartament, CodDepartament FROM Departamente", sqlCon);
                DataTable dtb2 = new DataTable();
                sqlDat.Fill(dtb2);

                //display data
                dgv1.DataSource = dtb2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat2 = new SqlDataAdapter("SELECT Nume, Prenume, Specializare, Limba FROM Indrumatori", sqlCon);
                DataTable dtb3 = new DataTable();
                sqlDat2.Fill(dtb3);

                //display data
                dgv1.DataSource = dtb3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat3 = new SqlDataAdapter("SELECT NumeSpecializare, Limba FROM Specializari", sqlCon);
                DataTable dtb4 = new DataTable();
                sqlDat3.Fill(dtb4);

                //display data
                dgv1.DataSource = dtb4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat4 = new SqlDataAdapter("SELECT NumeTema, CodTema, TermenLimita, NrOreDeLucru, Limba, NumeIndrumator, PrenumeIndrumator FROM TemeLicenta", sqlCon);
                DataTable dtb5 = new DataTable();
                sqlDat4.Fill(dtb5);

                //display data
                dgv1.DataSource = dtb5;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DatabaseMenu form3 = new DatabaseMenu();
            form3.Show();
            this.Hide();
        }

       
    }
}
