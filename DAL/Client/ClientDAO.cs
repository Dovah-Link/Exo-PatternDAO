using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ClientDAO
    {
        public void Insert(Client cli)
        {
            SqlConnection con = new SqlConnection("server=(local); database=hotel; integrated security=true");
            con.Open();

            SqlCommand requete = new SqlCommand("insert into client (cli_nom, cli_prenom, cli_ville) values (@p1, @p2, @p3)", con);
            requete.Parameters.AddWithValue("@p1", cli.Nom);
            requete.Parameters.AddWithValue("@p2", cli.Prenom);
            requete.Parameters.AddWithValue("@p3", cli.Ville);

            requete.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(Client cli)
        {
            SqlConnection con = new SqlConnection("server=(local); database=hotel; integrated security=true");
            con.Open();

            SqlCommand requete = new SqlCommand("DELETE FROM CLIENT WHERE @p1=cli_id", con);
            requete.Parameters.RemoveAt("@p1");

            requete.ExecuteNonQuery();
            con.Close();
        }

        public List<Client> List()
        {
            List<Client> liste = new List<Client>();

            SqlConnection con = new SqlConnection("server=(local); database=hotel; integrated security=true");
            con.Open();

            SqlCommand requete = new SqlCommand("select * from client", con);

            SqlDataReader resultat = requete.ExecuteReader();

            while (resultat.Read())
            {
                Client cli = new Client();
                cli.Id = Convert.ToInt32(resultat["cli_id"]);
                cli.Nom = Convert.ToString(resultat["cli_nom"]);
                cli.Prenom = Convert.ToString(resultat["cli_prenom"]);
                cli.Ville = Convert.ToString(resultat["cli_ville"]);

                liste.Add(cli);
            }

            return liste;
        }
    }
}
