using DAL;
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


namespace GUI
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=hotel; integrated security=true");

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfficheDGV();
        }
        string i = "";
        private void button1_Click(object sender, EventArgs e)
        {
            tbclear();

            i = "ajout";
            GB_Details.Enabled = true;
            Width = 787;

        }

        private void B_modif_Click(object sender, EventArgs e)
        {
            TB_nom.Text = DGV.CurrentRow.Cells[1].Value.ToString();
            TB_prenom.Text = DGV.CurrentRow.Cells[2].Value.ToString();
            TB_ville.Text = DGV.CurrentRow.Cells[3].Value.ToString();
            i = "modif";
            GB_Details.Enabled = true;
            Width = 787;

        }
        private void B_supr_Click(object sender, EventArgs e)
        {
            try
            {
                TB_nom.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                TB_prenom.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                TB_ville.Text = DGV.CurrentRow.Cells[3].Value.ToString();
                GB_Details.Enabled = true;
                Width = 787;
                i = "supr";
            }
            catch
            {
                MessageBox.Show("Aucune valeur selectionner", "Erreur");
            }
        }
        private void b_ok_Click(object sender, EventArgs e)
        {
            if(i=="ajout")
            {
                Client c = new Client();
                c.Nom = TB_nom.Text;
                c.Prenom = TB_prenom.Text;
                c.Ville = TB_ville.Text;

                ClientDAO database = new ClientDAO();

                database.Insert(c);
                tbclear();
            }
            else if(i=="supr")
            {
                Client c = new Client();
                c.Nom = TB_nom.Text;
                c.Prenom = TB_prenom.Text;
                c.Ville = TB_ville.Text;
                c.Id = (int)DGV.CurrentRow.Cells["Id"].Value;

                ClientDAO data = new ClientDAO();

                data.Delete(c);
            }
            else
            {
                Client c = new Client();
                c.Nom = TB_nom.Text;
                c.Prenom = TB_prenom.Text;
                c.Ville = TB_ville.Text;
                c.Id = (int)DGV.CurrentRow.Cells["Id"].Value;

                ClientDAO data = new ClientDAO();

                data.Update(c);
                tbclear();
            }
            Width = 454;
            AfficheDGV();
        }
        private void AfficheDGV()
        {
            con.Open();

            SqlCommand requete = new SqlCommand("select * from dbo.client", con);

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                ClientDAO database = new ClientDAO();
                DGV.DataSource = database;
                DGV.DataSource = database.List();
                DGV.RowHeadersVisible = false;
                DGV.Columns[0].Visible = false;
                DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            con.Close();

        }
        private void tbclear()
        {
            TB_nom.Text = "";
            TB_prenom.Text = "";
            TB_ville.Text = "";
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            
            Width = 484;
        }

    }
}
