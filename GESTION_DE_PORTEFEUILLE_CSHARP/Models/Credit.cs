using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace GESTION_DE_PORTEFEUILLE_CSHARP.MODEL
{
    class Credit
    {
        private int reference;
        private String reason;
        private int amount;
        private String date;
        private String confirmation;

        public Credit()
        {

        }
        public Credit(int reference)
        {
            this.reference = reference;
        }
        public Credit(int reference, String reason, int amount)
        {
            this.reference = reference;
            this.reason = reason;
            this.amount = amount;
        }
        public Credit(String reason, int amount, String date, String confirmation)
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
                MySqlCommand si_produit = new MySqlCommand("INSERT INTO `credit`( `reason`, `amount`, `date`, `confirmation`) VALUES(@reason,@amount,@date,@confirmation)", conbdd);
                si_produit.Parameters.AddWithValue("@reason", this.reason);
                si_produit.Parameters.AddWithValue("@amount", this.amount);
                si_produit.Parameters.AddWithValue("@date", this.date);
                si_produit.Parameters.AddWithValue("@confirmation", this.confirmation);


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
        public void modifcredit()
        {
            Models.ConnexionM si_conbdd_obj = new Models.ConnexionM();
            MySqlConnection si_conbdd = si_conbdd_obj.si_connectionbdd();

            try
            {
                si_conbdd.Open();
                // MySqlCommand testqte = new MySqlCommand("SELECT COUNT(*) FROM `sortie` WHERE `idprod`=@idprodaty", si_conbdd);
                //MySqlCommand compteligne = new MySqlCommand("SELECT COUNT(*) FROM `entree` WHERe `idprod`=@idproduiay", si_conbdd);
                MySqlCommand modif1 = new MySqlCommand("UPDATE `credit` SET  `reason`=@reason, `amount`=@amount, `confirmation` =@confirmation WHERE `reference`=@reference", si_conbdd);
                // MySqlCommand si_produit = new MySqlCommand("UPDATE `produit` SET `libelleprod`=@libelleprod, `qteprod`=@qteprod WHERE `idprod`=@idprod", si_conbdd);
                // MySqlCommand si_mod = new MySqlCommand("UPDATE `produit` SET `qmvt`=@qteprodaytou - (SELECT `qteprod` FROM `produit` WHERE `idprod`=@idprodaytou) + (SELECT `qmvt` FROM `produit` WHERE `idprod`=@idprodaytou) WHERE `idprod`=@idprodaytou", si_conbdd);

                modif1.Parameters.AddWithValue("@reason", this.reason);
                modif1.Parameters.AddWithValue("@amount", this.amount);
                modif1.Parameters.AddWithValue("@reference", this.reference);
                modif1.Parameters.AddWithValue("@confirmation", this.confirmation);

                /*testqte.Parameters.AddWithValue("@idprodaty", this.idproduit);

                compteligne.Parameters.AddWithValue("@idproduiay", this.idproduit);

                si_mod.Parameters.AddWithValue("@qteprodaytou", this.qtproduit);
                si_mod.Parameters.AddWithValue("@idprodaytou", this.idproduit);

                si_produit.Parameters.AddWithValue("@idprod", this.idproduit);
                si_produit.Parameters.AddWithValue("@libelleprod", this.libelleproduit);
                si_produit.Parameters.AddWithValue("@qteprod", this.qtproduit);

                if (int.Parse(testqte.ExecuteScalar().ToString()) == 0 && int.Parse(compteligne.ExecuteScalar().ToString()) == 0)
                {

                    modif1.ExecuteNonQuery();
                    si_conbdd.Close();
                    //  return foru;

                    //return 1000;

                }
                else
                {
                    si_mod.ExecuteNonQuery();
                    si_produit.ExecuteNonQuery();
                    si_conbdd.Close();
                }


                si_produit.Parameters.AddWithValue("@idprod", this.idproduit);
                si_produit.Parameters.AddWithValue("@libelleprod", this.libelleproduit);
                si_produit.Parameters.AddWithValue("@qteprod", this.qtproduit);
                si_produit.ExecuteNonQuery();
                si_conbdd.Close();*/
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
                MySqlCommand deldebit = new MySqlCommand("DELETE FROM `credit` WHERE `reference`=@reference", si_conbdd);
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
    }
}
