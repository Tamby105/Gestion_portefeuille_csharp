using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace GESTION_DE_PORTEFEUILLE_CSHARP.Models
{
    class DebitM
    {
        private int reference;
        private String reason;
        private int amount;
        private String date;

        public DebitM()
        {

        }
        public DebitM(int reference)
        {
            this.reference = reference;
        }
        public DebitM(String reason)
        {
            this.reason = reason;
        }
        public DebitM(int reference, String reason, int amount)
        {
            this.reference = reference;
            this.reason = reason;
            this.amount = amount;
        }
        public DebitM(String reason, int amount, String date)
        {
            this.reason = reason;
            this.amount = amount;
            this.date = date;

        }
        public void ajoutDebit()
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
                MySqlCommand si_produit = new MySqlCommand("INSERT INTO `debit`( `reason`, `amount`, `date`) VALUES(@reason,@amount,@date)", conbdd);
                si_produit.Parameters.AddWithValue("@reason", this.reason);
                si_produit.Parameters.AddWithValue("@amount", this.amount);
                si_produit.Parameters.AddWithValue("@date", this.date);


                /* if (int.Parse(libelle.ExecuteScalar().ToString()) == 0)
                 {

                     si_produit.ExecuteNonQuery();
                     conbdd.Close();
                    // return true;
                     //  return foru;

                     //return 1000;

                 }
                 else
                 {

                     conbdd.Close();
                    // return false;
                 }*/
                si_produit.ExecuteNonQuery();
                conbdd.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
                //return false;
            }
        }
        public void modifdebit()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                // MySqlCommand testqte = new MySqlCommand("SELECT COUNT(*) FROM `sortie` WHERE `idprod`=@idprodaty", si_conbdd);
                //MySqlCommand compteligne = new MySqlCommand("SELECT COUNT(*) FROM `entree` WHERe `idprod`=@idproduiay", si_conbdd);
                MySqlCommand modif1 = new MySqlCommand("UPDATE `debit` SET  `reason`=@reason, `amount`=@amount WHERE `reference`=@reference", si_conbdd);
                // MySqlCommand si_produit = new MySqlCommand("UPDATE `produit` SET `libelleprod`=@libelleprod, `qteprod`=@qteprod WHERE `idprod`=@idprod", si_conbdd);
                // MySqlCommand si_mod = new MySqlCommand("UPDATE `produit` SET `qmvt`=@qteprodaytou - (SELECT `qteprod` FROM `produit` WHERE `idprod`=@idprodaytou) + (SELECT `qmvt` FROM `produit` WHERE `idprod`=@idprodaytou) WHERE `idprod`=@idprodaytou", si_conbdd);

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
        public void suppDebit()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                MySqlCommand deldebit = new MySqlCommand("DELETE FROM `debit` WHERE `reference`=@reference", si_conbdd);
                deldebit.Parameters.AddWithValue("@reference", this.reference);
                /* MySqlCommand sisortie = new MySqlCommand("DELETE FROM `sortie` WHERE `idprod`=@idprod", si_conbdd);
                 sisortie.Parameters.AddWithValue("@idprod", this.idproduit);
                 MySqlCommand si_produit = new MySqlCommand("DELETE FROM `produit` WHERE `idprod`=@idprod", si_conbdd);
                 si_produit.Parameters.AddWithValue("@idprod", this.idproduit);*/

                deldebit.ExecuteNonQuery();
                //sisortie.ExecuteNonQuery();
                //si_produit.ExecuteNonQuery();
                si_conbdd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
            }
        }

        public DataTable Debit_select()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            DataTable si_datatable = new DataTable();

            try
            {
                si_conbdd.Open();
                MySqlCommand si_produit = new MySqlCommand("SELECT * FROM `debit` ORDER BY `reference` DESC", si_conbdd);

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
                MySqlCommand compteligne = new MySqlCommand("ALTER TABLE `debit` AUTO_INCREMENT = 1 ", si_conbdd);
                
                    compteligne.ExecuteNonQuery();
                    si_conbdd.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");

            }

        }
        public DataTable Debit_recherche()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            DataTable si_datatable = new DataTable();

            try
            {
                si_conbdd.Open();
                MySqlCommand si_produit = new MySqlCommand("SELECT * FROM `debit` WHERE `reason` LIKE '%" + this.reason + "%'", si_conbdd);
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
        public int somme_solde()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();
            try
            {
                si_conbdd.Open();
                MySqlCommand solde = new MySqlCommand("SELECT SUM(`amount`) FROM `debit`", si_conbdd);
                int Somme = int.Parse(solde.ExecuteScalar().ToString());


                return Somme;
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
            }
            int i = 0;
            return i;
        }
        public void suppDebit_edit()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                MySqlCommand delCredit = new MySqlCommand("DELETE  FROM `debit` ", si_conbdd);


                delCredit.ExecuteNonQuery();

                si_conbdd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("KO");
            }

        }

    }
}
