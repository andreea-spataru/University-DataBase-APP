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
    public partial class DatabaseMenu : Form
    {
        public DatabaseMenu()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BE3UV51\\SQLEXPRESS;Initial Catalog=Licenta;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        void GetData()
        {
            string querry = "SELECT Nume, Prenume, CNP, Sex, DataNasterii, Oras, Judet, NrTelefon, Medie FROM Studenti";
            con.Open();
            da = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLicence.DataSource = dt;
            con.Close();            

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO Studenti(Nume, Prenume, CNP, Sex, DataNasterii, Oras, Judet, NrTelefon, Medie) VALUES (@nume, @prenume, @cnp, @sex, @datanasterii, @oras, @judet, @nrtelefon, @medie)";
            
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@nume", txtName.Text);
            cmd.Parameters.AddWithValue("@prenume", txtLastName.Text);
            cmd.Parameters.AddWithValue("@cnp", txtCNP.Text);
            cmd.Parameters.AddWithValue("@sex", cmbGender.Text);
            cmd.Parameters.AddWithValue("@datanasterii", dtBirthData.Value);
            cmd.Parameters.AddWithValue("@oras", txtCity.Text);
            cmd.Parameters.AddWithValue("@judet", txtSector.Text);
            cmd.Parameters.AddWithValue("@nrtelefon", txtPhoneNo.Text);
            cmd.Parameters.AddWithValue("@medei", txtMedie.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();

            MessageBox.Show("Student inserted!");
        }

        private void DatabaseMenu_Load(object sender, EventArgs e)
        {
            GetData();            
        }

        private void dgvLicence_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvLicence.CurrentRow.Cells[0].Value.ToString();
            txtLastName.Text = dgvLicence.CurrentRow.Cells[1].Value.ToString();
            txtCNP.Text = dgvLicence.CurrentRow.Cells[2].Value.ToString();
            cmbGender.Text = dgvLicence.CurrentRow.Cells[3].Value.ToString();
            dtBirthData.Text = dgvLicence.CurrentRow.Cells[4].Value.ToString();
            txtCity.Text = dgvLicence.CurrentRow.Cells[5].Value.ToString();
            txtSector.Text = dgvLicence.CurrentRow.Cells[6].Value.ToString();
            txtPhoneNo.Text = dgvLicence.CurrentRow.Cells[7].Value.ToString();
            txtMedie.Text = dgvLicence.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE Studenti SET Nume=@nume, " + "Prenume=@prenume," +
                " CNP=@cnp," + " Sex=@sex," +
                " DataNasterii=@datanasterii," + " Oras=@oras," + 
                " Judet=@judet," + " NrTelefon=@nrtelefon " + " Medie=@medie WHERE CNP=@cnp";

            cmd = new SqlCommand(querry, con);

            cmd.Parameters.AddWithValue("@nume", txtName.Text);
            cmd.Parameters.AddWithValue("@prenume", txtLastName.Text);
            cmd.Parameters.AddWithValue("@cnp", txtCNP.Text);
            cmd.Parameters.AddWithValue("@sex", cmbGender.Text);
            cmd.Parameters.AddWithValue("@datanasterii", dtBirthData.Value);
            cmd.Parameters.AddWithValue("@oras", txtCity.Text);
            cmd.Parameters.AddWithValue("@judet", txtSector.Text);
            cmd.Parameters.AddWithValue("@nrtelefon", txtPhoneNo.Text);
            cmd.Parameters.AddWithValue("@medei", txtMedie.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            GetData();
            MessageBox.Show("Student updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string querry = "DELETE FROM Studenti WHERE CNP=@cnp";

            cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@cnp", txtCNP.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            GetData();
            MessageBox.Show("Student deleted!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
                GetData();
            else
            {
                string querry = "SELECT Nume, Prenume, CNP, Sex, DataNasterii, Oras, Judet, NrTelefon, Medie FROM Studenti WHERE Nume='" + txtName.Text + "'";
                con.Open();
                da = new SqlDataAdapter(querry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLicence.DataSource = dt;
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm back = new MenuForm();
            back.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TemeLicenta form4= new TemeLicenta();
            form4.Show();
            this.Hide();
        }

       
    }
}
