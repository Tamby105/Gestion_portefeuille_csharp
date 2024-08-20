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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar = true;

        }

        private void btninvisiblepassword_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
            btninvisiblepassword.Visible = false;
            btnvisiblepassword.Visible = true;

        }

        private void btnvisiblepassword_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
            btninvisiblepassword.Visible = true;
            btnvisiblepassword.Visible = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connexion();
        }
        private void connexion()
        {
            String email = txtemail.Text;
            String motdepasse = txtpassword.Text;
            Models.UserM user = new Models.UserM();
            DataTable data = user.user_select();
            lblemail.Visible = false;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                lblemail.Visible = false;
                String username = data.Rows[i]["username"].ToString();
                String emailtable = data.Rows[i]["mail"].ToString();
                String mdptable = data.Rows[i]["password"].ToString();
                if (email == emailtable && motdepasse == mdptable)
                {
                    // vue.frm_produit yoo = new vue.frm_produit();
                    Form1 yoo = new Form1(username, email);
                    yoo.Show();
                   /// MessageBox.Show("Bienvenue " + username + " !", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                txtemail.Text = "";
                txtpassword.Text = "";

                lblemail.Visible = true;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                connexion();


            
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //connexion();
            }
        }
    }
}
