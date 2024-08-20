using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_PORTEFEUILLE_CSHARP.Vue
{
    public partial class interface_autorisation : Form
    {
        public interface_autorisation()
        {
            InitializeComponent();
        }
        public interface_autorisation(string email, string types)
        {
            InitializeComponent();
            lblmail.Text = email;
            lbltype.Text = types;
        }

        private void interface_autorisation_Load(object sender, EventArgs e)
        {

        }

        private void btneditpoursuivre_Click(object sender, EventArgs e)
        {
            String email = lblmail.Text;
            String motdepasse = txtmdp.Text;
            Models.UserM user = new Models.UserM();
            DataTable data = user.user_select();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                lblmdpfausse.Visible = false;
                String emailtable = data.Rows[i]["mail"].ToString();
                String mdptable = data.Rows[i]["password"].ToString();
                if (email == emailtable && motdepasse == mdptable)
                {
                    if (lbltype.Text == "reinitialiser")
                    {
                        Models.CreditM suppCred_tout = new Models.CreditM();
                        Models.DebitM suppDeb_tout = new Models.DebitM();
                        Models.CreditM reini_refcred = new Models.CreditM();
                        Models.DebitM reini_refdeb = new Models.DebitM();

                        suppCred_tout.suppCredit_edit();
                        suppDeb_tout.suppDebit_edit();
                        reini_refcred.reinitial_reference();
                        reini_refdeb.reinitial_reference();
                        MessageBox.Show("Reinitialisation réussie", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        Models.UserM mdp = new Models.UserM(email, lbltype.Text);
                        mdp.modifMotdepasse();
                        MessageBox.Show("Modification réussie", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    this.Close();

                }
                lblmdpfausse.Visible = true;

            }
        }

        private void btneditannuler_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
