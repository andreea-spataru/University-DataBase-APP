using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Interogari : Form
    {
        string connectString = @"Data Source=DESKTOP-BE3UV51\SQLEXPRESS;Initial Catalog=Licenta;Integrated Security=True";
        public Interogari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select ST.Nume, ST.Prenume, ST.Medie\r\nfrom Studenti ST INNER JOIN Departamente D ON ST.DepartamentID=D.DepartamentID\r\nWHERE D.NumeDepartament = 'CTI'", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                //display data
                dgv1.DataSource = dtb1;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat = new SqlDataAdapter("SELECT I.Nume, I.Prenume, SUM(NrOre) AS NrOreTeme\r\nFROM Indrumatori I INNER JOIN TemeIndrumator TI ON I.IndrumatorID = TI.IndrumatorID\r\nGROUP BY I.IndrumatorID, I.Nume, I.Prenume\r\nHAVING SUM(NrOre) > 5\r\nORDER BY SUM(NrOre) ASC", sqlCon);
                DataTable dtb2 = new DataTable();
                sqlDat.Fill(dtb2);

                //display data
                dgv1.DataSource = dtb2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat2 = new SqlDataAdapter("SELECT TL.NumeTema FROM TemeLicenta TL\r\nINNER JOIN Studenti ST ON ST.TemeLicentaID = TL.TemaLicentaID\r\nGROUP BY TL.NumeTema\r\nHAVING SUM(TL.NrOreDeLucru) > 6", sqlCon);
                DataTable dtb3 = new DataTable();
                sqlDat2.Fill(dtb3);

                //display data
                dgv1.DataSource = dtb3;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat3 = new SqlDataAdapter("SELECT TOP 3 ST.Nume, ST.Prenume, ST.Medie\r\nFROM Studenti ST INNER JOIN Departamente D ON ST.DepartamentID = D.DepartamentID\r\nWHERE D.NumeDepartament = 'CTI'\r\nORDER BY ST.Medie DESC", sqlCon);
                DataTable dtb4 = new DataTable();
                sqlDat3.Fill(dtb4);

                //display data
                dgv1.DataSource = dtb4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat4 = new SqlDataAdapter("SELECT D.NumeDepartament, COUNT(ST.StudentID) as NrStudenti\r\nFROM Departamente D LEFT JOIN Studenti ST ON D.DepartamentID = ST.DepartamentID\r\nGROUP BY D.NumeDepartament\r\n", sqlCon);
                DataTable dtb5 = new DataTable();
                sqlDat4.Fill(dtb5);

                //display data
                dgv1.DataSource = dtb5;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat5 = new SqlDataAdapter("SELECT D.NumeDepartament, COUNT(*) as NrStudenti, CAST(AVG(ST.Medie) as decimal(10,2)) as Medie\r\nFROM Departamente D LEFT JOIN Studenti ST ON ST.DepartamentID = D.DepartamentID\r\nGROUP BY D.NumeDepartament", sqlCon);
                DataTable dtb6 = new DataTable();
                sqlDat5.Fill(dtb6);

                //display data
                dgv1.DataSource = dtb6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat6 = new SqlDataAdapter("SELECT * FROM Departamente D\r\nWHERE D.DepartamentID != ALL(SELECT ST.DepartamentID FROM Studenti ST);", sqlCon);
                DataTable dtb7 = new DataTable();
                sqlDat6.Fill(dtb7);

                //display data
                dgv1.DataSource = dtb7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat7 = new SqlDataAdapter("SELECT ST.Prenume, ST.Nume, ST.CNP\r\nFROM Studenti ST\r\nWHERE ST.DepartamentID IN (SELECT DepartamentID FROM Departamente D\r\nWHERE EXISTS (SELECT StudentID FROM Studenti SST\r\nWHERE SST.DepartamentID = D.DepartamentID AND SST.Medie < 7))", sqlCon);
                DataTable dtb8 = new DataTable();
                sqlDat7.Fill(dtb8);

                //display data
                dgv1.DataSource = dtb8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat8 = new SqlDataAdapter("SELECT I.Nume, I.Prenume, TI.MedieOre\r\nFROM Indrumatori I JOIN\r\n(SELECT IndrumatorID, AVG(NrOre) as MedieOre\r\nFROM TemeIndrumator \r\nGROUP BY IndrumatorID) TI\r\nON I.IndrumatorID = TI.IndrumatorID", sqlCon);
                DataTable dtb9 = new DataTable();
                sqlDat8.Fill(dtb9);

                //display data
                dgv1.DataSource = dtb9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDat9 = new SqlDataAdapter("SELECT I.Nume, I.Prenume\r\nFROM Indrumatori I\r\nWHERE I.IndrumatorID NOT IN (SELECT DISTINCT II.IndrumatorID\r\nFROM Indrumatori II, TemeIndrumator TI\r\nWHERE II.IndrumatorID = TI.IndrumatorID)", sqlCon);
                DataTable dtb8 = new DataTable();
                sqlDat9.Fill(dtb8);

                //display data
                dgv1.DataSource = dtb8;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for visting our page! Have a nice day!");
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            TemeLicenta back = new TemeLicenta();
            back.Show();
        }
    }
}
