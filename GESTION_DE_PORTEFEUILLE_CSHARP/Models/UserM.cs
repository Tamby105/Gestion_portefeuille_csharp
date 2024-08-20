using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace GESTION_DE_PORTEFEUILLE_CSHARP.Models
{
    class UserM
    {
        //donnee membre
        private String email;
        private String username;
        private String motdepasse;
        private int type;
        public UserM()
        {

        }
        public UserM(String username, String motdepasse)
        {
            this.motdepasse = motdepasse;
            this.username = username;
        }
        public DataTable user_select()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            DataTable si_datatable = new DataTable();

            try
            {
                si_conbdd.Open();
                //mysqlcommand class qui demande deux argument 1:requete,2:variable bdd comme type qsqlquery dans qt
                MySqlCommand si_produit = new MySqlCommand("SELECT * FROM `login`", si_conbdd);

                MySqlDataAdapter si_adapter = new MySqlDataAdapter(si_produit);
                si_adapter.Fill(si_datatable);

                si_conbdd.Close();
                return si_datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connexion impossible a la base de donnees ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return si_datatable;
            }
        }
        public void modifMotdepasse()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                MySqlCommand modif1 = new MySqlCommand("UPDATE `login` SET  `password`=@password  WHERE `mail`=@mail", si_conbdd);

                modif1.Parameters.AddWithValue("@password", this.motdepasse);
                modif1.Parameters.AddWithValue("@mail", this.username);


                modif1.ExecuteNonQuery();
                si_conbdd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");

            }
        }
    }
}
