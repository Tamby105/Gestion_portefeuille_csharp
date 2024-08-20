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
    public partial class interfaceajoutDebit : Form
    {
        private void interfaceajoutDebit_Load(object sender, EventArgs e)
        {
        }
        public interfaceajoutDebit()
        {
            InitializeComponent();
            dateDebit.Value = DateTime.Now;
            debitlbl.Text = "Ajout soldes";

        }
        public interfaceajoutDebit(string reference, string reason, string amount, string date)
        {
            InitializeComponent();
            //txtidprodidprod.Enabled = false;
            txtamountdebi.Text = amount;
            txtreasonDebit.Text = reason;
            txtamountDebit.Text = amount;
            dateDebit.Enabled = false;
            string datyyString = date; // Chaîne représentant la date
            DateTime datyy = DateTime.ParseExact(datyyString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime dateSeule = datyy.Date;
            // Supposons que dateTimePicker1 est votre DateTimePicker où vous voulez affecter la valeur
            dateDebit.Value = dateSeule;
            // txtqteprod.Text = cqteprod;
            // txtqtmvtprod.Text = cqtmv;
            debitlbl.Text = "Modifier soldes";
            lblreferencedebit.Text = reference;

        }

        private void btnajoutanuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnenregistrerajoutDebit_Click_1(object sender, EventArgs e)
        {
            Models.DebitM solde = new Models.DebitM();
            int soldes = solde.somme_solde();
            Models.CreditM depenses = new Models.CreditM();
            int depe = depenses.somme_depenses();
            string reasonDebit = txtreasonDebit.Text;
            int amountDebit;
            if (!int.TryParse(txtamountDebit.Text, out amountDebit) || int.Parse(txtamountDebit.Text) <= 0)
            {
                MessageBox.Show("La valeur doit être valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DateTime datemysql = dateDebit.Value;
            string datecava = datemysql.ToString("yyyy-MM-dd");
            if (debitlbl.Text == "Modifier soldes")
            {
                int reference = int.Parse(lblreferencedebit.Text);
                int difference = amountDebit - int.Parse(txtamountdebi.Text);
                if ((soldes + difference) < depe)
                {
                    MessageBox.Show("La votre solde sera inferieur aux depenses!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Models.DebitM obj = new Models.DebitM(reference, reasonDebit, amountDebit);
                obj.modifdebit();
                MessageBox.Show("Modification réussie", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Models.DebitM obj = new Models.DebitM(reasonDebit, amountDebit, datecava);
                obj.ajoutDebit();
            }

            this.Close();

        }

        private void btnajoutanuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
