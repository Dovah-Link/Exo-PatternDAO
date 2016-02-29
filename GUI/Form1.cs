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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; database=hotel; integrated security=true");
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GB_Details.Enabled = true;
            Client c = new Client();
            c.Nom = "@nom";
            c.Prenom = "Titi";
            c.Ville = "Amiens";

            ClientDAO database = new ClientDAO();

            database.Insert(c);
        }  
    }
}
