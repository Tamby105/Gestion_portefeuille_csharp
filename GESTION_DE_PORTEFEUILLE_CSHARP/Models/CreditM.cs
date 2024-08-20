using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace GESTION_DE_PORTEFEUILLE_CSHARP.Models
{
    class CreditM
    {
        private int reference;
        private String reason;
        private int amount;
        private String date;
        private String confirmation;

        public CreditM()
        {

        }
        public CreditM(int reference)
        {
            this.reference = reference;
        }
        public CreditM(String reason, string confirmation)
        {
            this.reason = reason;
            this.confirmation = confirmation;

        }
        public CreditM(String reason)
        {
            this.reason = reason;
        }
        
        public CreditM(int reference, String reason, int amount)
        {
            this.reference = reference;
            this.reason = reason;
            this.amount = amount;
        }
        public CreditM(String reason, int amount, String date)
        {
            this.reason = reason;
            this.amount = amount;
            this.date = date;

        }
        public CreditM(String reason, int amount, String date, String confirmation)
        {
            this.reason = reason;
            this.amount = amount;
            this.date = date;
            this.confirmation = confirmation;

        }
        public void ajoutCred()
        {
            Models.ConnexionM conbdd_obj = new Models.ConnexionM();
            //sorte de chemin ou se trouve les fichiers model c-a-d dans le dossier model.le fichier voulu
            MySqlConnection conbdd = conbdd_obj.si_connectionbdd();
            //model.=dossier
            //try catch gestion d'exeption
            try
            {
                conbdd.Open();
                // MySqlCommand libelle = new MySqlCommand("SELECT COUNT(*) FROM `produit` WHERE `libelleprod`=@libelleproday", conbdd);
                MySqlCommand si_produit = new MySqlCommand("INSERT INTO `credit`(`reason`, `amount`, `date`, `confirmation`) VALUES(@reason, @amount, @date, @confirmation)", conbdd);
                si_produit.Parameters.AddWithValue("@reason", this.reason);
                si_produit.Parameters.AddWithValue("@amount", this.amount);
                si_produit.Parameters.AddWithValue("@date", this.date);
                si_produit.Parameters.AddWithValue("@confirmation", this.confirmation);

                si_produit.ExecuteNonQuery();
                conbdd.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
            }
        }
        public void modifcredit()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                MySqlCommand modif1 = new MySqlCommand("UPDATE `credit` SET  `reason`=@reason, `amount`=@amount  WHERE `reference`=@reference", si_conbdd);

                modif1.Parameters.AddWithValue("@reason", this.reason);
                modif1.Parameters.AddWithValue("@amount", this.amount);
                modif1.Parameters.AddWithValue("@reference", this.reference);


                modif1.ExecuteNonQuery();
                si_conbdd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");

            }
        }
        public void payment_dette()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                MySqlCommand modif1 = new MySqlCommand("UPDATE `credit` SET  `confirmation`= 'oui' WHERE `reference`=@reference", si_conbdd);

                
                modif1.Parameters.AddWithValue("@reference", this.reference);


                modif1.ExecuteNonQuery();
                si_conbdd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");

            }
        }
        public void suppCredit()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                MySqlCommand delCredit = new MySqlCommand("DELETE FROM `credit` WHERE `reference`=@reference", si_conbdd);
                delCredit.Parameters.AddWithValue("@reference", this.reference);


                delCredit.ExecuteNonQuery();

                si_conbdd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
            }

        }
        public void suppCredit_edit()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                MySqlCommand delCredit = new MySqlCommand("DELETE  FROM `credit` ", si_conbdd);


                delCredit.ExecuteNonQuery();

                si_conbdd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
            }

        }
        public DataTable Credit_select()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            DataTable si_datatable = new DataTable();

            try
            {
                si_conbdd.Open();
                MySqlCommand si_produit = new MySqlCommand("SELECT * FROM `credit` WHERE `confirmation` = @confirmation ORDER BY `reference` DESC", si_conbdd);
                si_produit.Parameters.AddWithValue("@confirmation", this.reason);

                MySqlDataAdapter si_adapter = new MySqlDataAdapter(si_produit);
                si_adapter.Fill(si_datatable);

                si_conbdd.Close();
                return si_datatable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
                return si_datatable;
            }
        }
        public void reinitial_reference()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                MySqlCommand compteligne = new MySqlCommand("ALTER TABLE `credit` AUTO_INCREMENT = 1 ", si_conbdd);
                

                    compteligne.ExecuteNonQuery();
                    si_conbdd.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");

            }

        }

        public DataTable Credit_recherche()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            DataTable si_datatable = new DataTable();

            try
            {
                si_conbdd.Open();
                MySqlCommand si_produit = new MySqlCommand("SELECT * FROM `credit` WHERE `reason` LIKE '%" + this.reason + "%' AND `confirmation` = '"+this.confirmation+" '", si_conbdd);
                //si_produit.Parameters.AddWithValue("@idproduit", this.idproduit);
                //si_produit.Parameters.AddWithValue("@libelleproduit", this.idproduit);

                MySqlDataAdapter si_adapter = new MySqlDataAdapter(si_produit);
                si_adapter.Fill(si_datatable);

                si_conbdd.Close();
                return si_datatable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
                return si_datatable;
            }
        }
        public int somme_depenses()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();
            try
            {
                si_conbdd.Open();
                MySqlCommand solde = new MySqlCommand("SELECT SUM(`amount`) FROM `credit` WHERE `confirmation` = 'oui' ", si_conbdd);
                object result = solde.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    int Somme = Convert.ToInt32(result);
                    return Somme;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                // Vous devriez envisager de renvoyer une valeur par défaut ou de gérer l'exception d'une autre manière selon vos besoins
                return 0; // Ou une autre valeur par défaut, selon votre logique de gestion d'erreur
            }
        }
        public int somme_dette()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();
            try
            {
                si_conbdd.Open();
                MySqlCommand solde = new MySqlCommand("SELECT SUM(`amount`) FROM `credit` WHERE `confirmation` = 'non' ", si_conbdd);
                object result = solde.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    int Somme = Convert.ToInt32(result);
                    return Somme;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                // Vous devriez envisager de renvoyer une valeur par défaut ou de gérer l'exception d'une autre manière selon vos besoins
                return 0; // Ou une autre valeur par défaut, selon votre logique de gestion d'erreur
            }
        }
        public int integrite_modif_credit()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();
            try
            {
                si_conbdd.Open();
                MySqlCommand soldemodif = new MySqlCommand("SELECT `amount` FROM `credit` WHERE `reference` = @reference ", si_conbdd);
                soldemodif.Parameters.AddWithValue("@reference", this.reference);

                object result = soldemodif.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    int Somme = Convert.ToInt32(result);
                    return Somme;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                // Vous devriez envisager de renvoyer une valeur par défaut ou de gérer l'exception d'une autre manière selon vos besoins
                return 0; // Ou une autre valeur par défaut, selon votre logique de gestion d'erreur
            }
        }
        /////////////////////////////////////////DETTES/////////////////
        public DataTable Dette_select()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            DataTable si_datatable = new DataTable();

            try
            {
                si_conbdd.Open();
                MySqlCommand si_produit = new MySqlCommand("SELECT * FROM `credit` WHERE `confirmation` = 'non'", si_conbdd);

                MySqlDataAdapter si_adapter = new MySqlDataAdapter(si_produit);
                si_adapter.Fill(si_datatable);

                si_conbdd.Close();
                return si_datatable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
                return si_datatable;
            }
        }
    }
}
