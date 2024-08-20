using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace GESTION_DE_PORTEFEUILLE_CSHARP.Vue
{
    public partial class interfaceajoutCredit : Form
    {
        private void interfaceajoutCredit_Load(object sender, EventArgs e)
        {
        }
        public interfaceajoutCredit()
        {
            InitializeComponent();
            dateCredit.Value = DateTime.Now;

        }
        public interfaceajoutCredit(string confirmation)
        {
            InitializeComponent();

            if (confirmation == "oui")
            {
                Creditlbl.Text = "Ajout depense";
            }
            else
            {
                Creditlbl.Text = "Ajout dette";

            }
            dateCredit.Value = DateTime.Now;

        }
        public interfaceajoutCredit(string reference, string reason, string amount, string date, string confirmation)
        {
            InitializeComponent();
            //txtidprodidprod.Enabled = false;
            if (confirmation == "oui")
            {
                Creditlbl.Text = "Modifier depense";
            }
            else
            {
                Creditlbl.Text = "Modifier dette";

            }
            txtreasonCredit.Text = reason;
            txtamountCredit.Text = amount;
            dateCredit.Enabled = false;
            string datyyString = date; // Chaîne représentant la date
            DateTime datyy = DateTime.ParseExact(datyyString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime dateSeule = datyy.Date;
            // Supposons que dateTimePicker1 est votre DateTimePicker où vous voulez affecter la valeur
            dateCredit.Value = dateSeule;
            // txtqteprod.Text = cqteprod;
            // txtqtmvtprod.Text = cqtmv;
            lblreferencecredit.Text = reference;

        }
        private void btnenregistrerajoutCredit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnenregistrerajoutCredit_Click_1(object sender, EventArgs e)
        {
            //int reference = int.Parse(lblreferencecredit.Text);
            Models.DebitM solde = new Models.DebitM();
            int soldes = solde.somme_solde();
            Models.CreditM depenses = new Models.CreditM();
            int depe = depenses.somme_depenses();
            int restesolde = soldes - depe;


            string reasonCredit = txtreasonCredit.Text;
            int amountCredit;
            if (!int.TryParse(txtamountCredit.Text, out amountCredit) || int.Parse(txtamountCredit.Text) <= 0)
            {
                MessageBox.Show("La valeur doit être  valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (restesolde < amountCredit && Creditlbl.Text == "Ajout depense")
            {
                MessageBox.Show("Votre solde n'est pas suffisant!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime datemysql = dateCredit.Value;
            string datecava = datemysql.ToString("yyyy-MM-dd");
            if (Creditlbl.Text == "Modifier depense")
            {
                int reference = int.Parse(lblreferencecredit.Text);
                Models.CreditM solde_depart = new Models.CreditM(reference);
                int soldedepart = solde_depart.integrite_modif_credit();
                
                if ((amountCredit - soldedepart) > restesolde)
                {
                    MessageBox.Show("Votre solde n'est pas suffisant!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Models.CreditM obj = new Models.CreditM(reference, reasonCredit, amountCredit);
                obj.modifcredit();
                MessageBox.Show("Modification réussie", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Creditlbl.Text == "Modifier dette")
            {
                int reference = int.Parse(lblreferencecredit.Text);

                Models.CreditM obj = new Models.CreditM(reference, reasonCredit, amountCredit);
                obj.modifcredit();
                MessageBox.Show("Modification réussie", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Creditlbl.Text == "Ajout depense")
            {
                Models.CreditM obj = new Models.CreditM(reasonCredit, amountCredit, datecava, "oui");
                obj.ajoutCred();

            }
            else if (Creditlbl.Text == "Ajout dette")
            {
                Models.CreditM obj = new Models.CreditM(reasonCredit, amountCredit, datecava, "non");
                obj.ajoutCred();

            }

            this.Close();
        }

        private void btnajoutannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
