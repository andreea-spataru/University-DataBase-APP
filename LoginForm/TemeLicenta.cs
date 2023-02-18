using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LoginForm
{
    public partial class TemeLicenta : Form
    {
        public TemeLicenta()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BE3UV51\\SQLEXPRESS;Initial Catalog=Licenta;Integrated Security=True");
        SqlCommand cmd1;
        SqlDataAdapter da1;

        void GetData()
        {
            string querry1 = "SELECT NumeTema, CodTema, TermenLimita, NrOreDeLucru, Limba, NumeIndrumator, PrenumeIndrumator FROM TemeLicenta";
            conn.Open();
            da1 = new SqlDataAdapter(querry1, conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvLicence1.DataSource = dt1;
            conn.Close();
        }
        private void btnInsert1_Click(object sender, EventArgs e)
        {
            string querry1 = "INSERT INTO TemeLicenta(NumeTema, CodTema, TermenLimita, NrOreDeLucru, Limba, NumeIndrumator, PrenumeIndrumator) VALUES (@numetema, @codtema, @termenlimita, @nroredelucru, @limba, @numeindrumator, @prenumeindrumator)";

            SqlCommand cmd1 = new SqlCommand(querry1, conn);
            cmd1.Parameters.AddWithValue("@numetema", txtNameHom.Text);
            cmd1.Parameters.AddWithValue("@codtema", txtCode.Text);
            cmd1.Parameters.AddWithValue("@termenlimita", dtLimit.Value);
            cmd1.Parameters.AddWithValue("@nroredelucru", txtHours.Text);
            cmd1.Parameters.AddWithValue("@limba", txtLang.Text);
            cmd1.Parameters.AddWithValue("@numeindrumator", txtNameIn.Text);
            cmd1.Parameters.AddWithValue("@prenumeindrumator", txtLastIn.Text);

            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
            GetData();

            MessageBox.Show("Tema Licenta inserted!");
        }

        //back button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DatabaseMenu back= new DatabaseMenu();
            back.Show();
        }

        private void TemeLicenta_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dgvLicence1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNameHom.Text = dgvLicence1.CurrentRow.Cells[0].Value.ToString();
            txtCode.Text = dgvLicence1.CurrentRow.Cells[1].Value.ToString();
            dtLimit.Text = dgvLicence1.CurrentRow.Cells[2].Value.ToString();
            txtHours.Text = dgvLicence1.CurrentRow.Cells[3].Value.ToString();
            txtLang.Text = dgvLicence1.CurrentRow.Cells[4].Value.ToString();
            txtNameIn.Text = dgvLicence1.CurrentRow.Cells[5].Value.ToString();
            txtLastIn.Text = dgvLicence1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            string querry1 = "DELETE FROM TemeLicenta WHERE NumeTema=@numetema";

            cmd1 = new SqlCommand(querry1, conn);
            cmd1.Parameters.AddWithValue("@numetema", txtNameHom.Text);

            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();

            GetData();
            MessageBox.Show("`Tema Licenta deleted!");
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            string querry1 = "UPDATE TemeLicenta SET NumeTema=@numetema, " + "CodTema=@codtema," +
                " TermenLimita=@termenlimita," + " NrOreDeLucru=@nroredelucru," +
                 " Limba=@limba, " + "NumeIndrumator=@numeindrumator, " + "PrenumeIndrumator=@prenumeindrumator  WHERE NumeTema=@numetema";

            cmd1 = new SqlCommand(querry1, conn);

            cmd1.Parameters.AddWithValue("@numetema", txtNameHom.Text);
            cmd1.Parameters.AddWithValue("@codtema", txtCode.Text);
            cmd1.Parameters.AddWithValue("@termenlimita", dtLimit.Value);
            cmd1.Parameters.AddWithValue("@nroredelucru", txtHours.Text);
            cmd1.Parameters.AddWithValue("@limba", txtLang.Text);
            cmd1.Parameters.AddWithValue("@numeindrumator", txtNameIn.Text);
            cmd1.Parameters.AddWithValue("@prenumeindrumator", txtLastIn.Text);

            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();

            GetData();
            MessageBox.Show("Tema Licenta updated!");
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (txtNameHom.Text == "")
                GetData();
            else
            {
                string querry1 = "SELECT NumeTema, CodTema, TermenLimita, NrOreDeLucru, Limba, NumeIndrumator, PrenumeIndrumator FROM TemeLicenta WHERE NumeTema='" + txtNameHom.Text + "'";
                conn.Open();
                da1 = new SqlDataAdapter(querry1, conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dgvLicence1.DataSource = dt1;
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interogari form5 = new Interogari();
            form5.Show();
            this.Hide();
        }
    }
}
