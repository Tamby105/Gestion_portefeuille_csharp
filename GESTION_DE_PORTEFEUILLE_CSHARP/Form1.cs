using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GESTION_DE_PORTEFEUILLE_CSHARP
{
    public partial class Form1 : Form
    {
       /* [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int RightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );*/
        public Form1()
        {
            InitializeComponent();
           // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            depensecircle.Value = 0;
            restecircle.Value = 0;
        }
        public Form1(string username, string mail)
        {
            InitializeComponent();
            txtom.Text = username;
            txtmail.Text = mail;
            depensecircle.Value = 0;
            restecircle.Value = 0;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debitloc();
            Creditloc();
            guna2Button2.FillColor = Color.FromArgb(5, 38, 89);
            reste_solde();
            depense_dash();
            dette_dash();


            //circles_DEPENSE();
        }


        bool hamburger;
        private void btndebit_Click(object sender, EventArgs e)
        {
            Debitloc();
            
            tabControl1.SelectedTab = tabControl1.TabPages["interfacedebit"];
            btndebit.FillColor = Color.FromArgb(5,38,89);
            btncredit.FillColor = Color.FromArgb(0, 15, 34);
            guna2Button2.FillColor = Color.FromArgb(0, 15, 34);
            btedit.FillColor = Color.FromArgb(0, 15, 34);

        }

        private void btncredit_Click(object sender, EventArgs e)
        {
            Creditloc();
            radioDepense.Checked = true;
            tabControl1.SelectedTab = tabControl1.TabPages["interfacecredit"];
            btncredit.FillColor = Color.FromArgb(5, 38, 89);
            btndebit.FillColor = Color.FromArgb(0, 15, 34);
            guna2Button2.FillColor = Color.FromArgb(0, 15, 34);
            btedit.FillColor = Color.FromArgb(0, 15, 34);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["interfacedashboard"];
            
            btndebit.FillColor = Color.FromArgb(0, 15, 34);
            btncredit.FillColor = Color.FromArgb(0, 15, 34);
            guna2Button2.FillColor = Color.FromArgb(5, 38, 89);
            btedit.FillColor = Color.FromArgb(0, 15, 34);
            reste_solde();
            depense_dash();
            dette_dash();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["interfaceEdit"];
            btndebit.FillColor = Color.FromArgb(0, 15, 34);
            btncredit.FillColor = Color.FromArgb(0, 15, 34);
            guna2Button2.FillColor = Color.FromArgb(0, 15, 34);
            btedit.FillColor = Color.FromArgb(5, 38, 89);
        }

        private void interfacedashboard_Click(object sender, EventArgs e)
        {

        }

        private void menuhamburgertimer_Tick(object sender, EventArgs e)
        {
            if (hamburger) 
            {
                menu.Width -= 10;
                if (menu.Width == menu.MinimumSize.Width) 
                {
                    hamburger = false;
                    menuhamburgertimer.Stop();
                }
            }
            else 
            {
                menu.Width += 10;
                if (menu.Width == menu.MaximumSize.Width) 
                {
                    hamburger = true;
                    menuhamburgertimer.Stop();
                }
            }
        }

        private void hamb_Click(object sender, EventArgs e)
        {
            //menuhamburgertimer.Start();
        }
        /// <summary>
        /// //////////////////////////////DEBIT////////////////////////////////////
        /// </summary>
        private void Debitloc()
        {

            Models.DebitM deb = new Models.DebitM();
            DataTable Debdatta = new DataTable();
            Debdatta = deb.Debit_select();
            tbldebit.DataSource = Debdatta;
            tbldebit.Columns[0].HeaderText = "Reference";
            tbldebit.Columns[1].HeaderText = "Motif";
            tbldebit.Columns[2].HeaderText = "Montant";
            tbldebit.Columns[3].HeaderText = "Date";

        }
        private void btnajoutdebit_Click(object sender, EventArgs e)
        {
            Vue.interfaceajoutDebit yoo = new Vue.interfaceajoutDebit();
            yoo.ShowDialog();
            Debitloc();
        }

        private void btnmodifierdebit_Click(object sender, EventArgs e)
        {
            if (tbldebit.SelectedRows.Count > 0)
            {
                if (tbldebit.CurrentRow.Index >= 0)
                {
                    //tbldebit.Columns[0].HeaderText = "Reference";
                    string reference = tbldebit.Rows[tbldebit.CurrentRow.Index].Cells[0].Value.ToString();
                    string reason = tbldebit.Rows[tbldebit.CurrentRow.Index].Cells[1].Value.ToString();
                    string amount = tbldebit.Rows[tbldebit.CurrentRow.Index].Cells[2].Value.ToString();
                    string date = tbldebit.Rows[tbldebit.CurrentRow.Index].Cells[3].Value.ToString();
                    Vue.interfaceajoutDebit modifprod = new Vue.interfaceajoutDebit(reference, reason, amount,date);
                    modifprod.ShowDialog();
                    Debitloc();
                }
            }

            else
            {
                MessageBox.Show("Pas d'elements selectionnes ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsuppdebit_Click(object sender, EventArgs e)
        {
            int selectedRowCount = tbldebit.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                var result = MessageBox.Show("Voulez-vous vraiment supprimer cet élement?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        string references = Convert.ToString(tbldebit.Rows[tbldebit.SelectedRows[i].Index].Cells[0].Value);
                        int reference = int.Parse(references);
                        string amountdebits = Convert.ToString(tbldebit.Rows[tbldebit.SelectedRows[i].Index].Cells[2].Value);
                        int amountdebit = int.Parse(amountdebits);
                        Models.DebitM solde = new Models.DebitM();
                        int soldes = solde.somme_solde();
                        Models.CreditM depenses = new Models.CreditM();
                        int depe = depenses.somme_depenses();
                       // int restesolde = soldes - depe;
                       if((soldes - amountdebit)< depe)
                        {
                            MessageBox.Show("La votre solde sera inferieur aux depenses!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Models.DebitM suprod = new Models.DebitM(reference);
                        suprod.suppDebit();
                    }
                    Debitloc();
                }
            }
            else
            {
                MessageBox.Show("Pas d'élements selectionnés ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void textrechDebit_TextChanged(object sender, EventArgs e)
        {
            string debit = textrechDebit.Text;
            afficherecerce_debit(debit);
        }
        private void afficherecerce_debit(string debit)
        {
            Models.DebitM deb = new Models.DebitM(debit);
            DataTable Debdatta = new DataTable();
            Debdatta = deb.Debit_recherche();
            tbldebit.DataSource = Debdatta;
            tbldebit.Columns[0].HeaderText = "Reference";
            tbldebit.Columns[1].HeaderText = "Motif";
            tbldebit.Columns[2].HeaderText = "Montant";
            tbldebit.Columns[3].HeaderText = "Date";
        }
        /// <summary>
        /// //////////////////////////////CREDIT////////////////////////////////////
        /// </summary>
        private void Creditloc()
        {
            string confirmation = "oui";
            if (radioDepense.Checked == true)
            {
                confirmation = "oui";
            }
            else if (radioDette.Checked == true)
            {
                confirmation = "non";

            }
            Models.CreditM cred = new Models.CreditM(confirmation);
            DataTable Creddatta = new DataTable();
            Creddatta = cred.Credit_select();
            if (Creddatta.Columns.Count >= 5)
            {
                Creddatta.Columns.RemoveAt(4);
            }
            tblcredit.DataSource = Creddatta;
            tblcredit.Columns[0].HeaderText = "Reference";
            tblcredit.Columns[1].HeaderText = "Motif";
            tblcredit.Columns[2].HeaderText = "Montant";
            tblcredit.Columns[3].HeaderText = "Date";
           
        }
        private void btnajoutcredit_Click_1(object sender, EventArgs e)
        {
            string confirmation = "oui";
            if (radioDepense.Checked == true)
            {
                confirmation = "oui";
            }
            else if (radioDette.Checked == true)
            {
                confirmation = "non";

            }
            Vue.interfaceajoutCredit yoo = new Vue.interfaceajoutCredit(confirmation);
            yoo.ShowDialog();
            Creditloc();
        }


        private void btnmodifiercredit_Click_1(object sender, EventArgs e)
        {
            string confirmation = "oui";
            if (radioDepense.Checked == true)
            {
                confirmation = "oui";
            }
            else if (radioDette.Checked == true)
            {
                confirmation = "non";

            }
            if (tblcredit.SelectedRows.Count > 0)
            {
                if (tblcredit.CurrentRow.Index >= 0)
                {
                    string reference = tblcredit.Rows[tblcredit.CurrentRow.Index].Cells[0].Value.ToString();
                    string reason = tblcredit.Rows[tblcredit.CurrentRow.Index].Cells[1].Value.ToString();
                    string amount = tblcredit.Rows[tblcredit.CurrentRow.Index].Cells[2].Value.ToString();
                    string date = tblcredit.Rows[tblcredit.CurrentRow.Index].Cells[3].Value.ToString();
                    Vue.interfaceajoutCredit modifcredit = new Vue.interfaceajoutCredit(reference, reason, amount, date, confirmation);
                    modifcredit.ShowDialog();
                    Creditloc();
                }
            }

            else
            {
                MessageBox.Show("Pas d'elements selectionnes ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsuppcredit_Click(object sender, EventArgs e)
        {
            if (tblcredit.SelectedRows.Count > 0)
            {
                if (tblcredit.CurrentRow.Index >= 0)
                {
                    string reference = tblcredit.Rows[tblcredit.CurrentRow.Index].Cells[0].Value.ToString();
                    string amount_dette = tblcredit.Rows[tblcredit.CurrentRow.Index].Cells[2].Value.ToString();

                    Models.CreditM obj = new Models.CreditM((int.Parse(reference)));
                    Models.DebitM solde = new Models.DebitM();
                    int soldes = solde.somme_solde();
                    Models.CreditM depenses = new Models.CreditM();
                    int depe = depenses.somme_depenses();
                    int restesolde = soldes - depe;
                    if (restesolde < (int.Parse(amount_dette))) 
                    {
                        MessageBox.Show("Votre solde n'est pas suffisant!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    obj.payment_dette();
                    MessageBox.Show("Payement effectuee", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    Creditloc();
                }
            }

            else
            {
                MessageBox.Show("Pas d'elements selectionnes ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textrechCredit_TextChanged_1(object sender, EventArgs e)
        {
            string motif_credit = textrechCredit.Text;
            afficherecerce_credit(motif_credit);
        }
        private void afficherecerce_credit(string motif_credit)
        {
            string confirmation = "oui";
            if (radioDepense.Checked == true)
            {
                confirmation = "oui";
            }
            else if (radioDette.Checked == true)
            {
                confirmation = "non";

            }
            Models.CreditM cred = new Models.CreditM(motif_credit, confirmation);
            DataTable Creddatta = new DataTable();
            Creddatta = cred.Credit_recherche();
            if (Creddatta.Columns.Count >= 5)
            {
                Creddatta.Columns.RemoveAt(4);
            }
            tblcredit.DataSource = Creddatta;
            tblcredit.Columns[0].HeaderText = "Reference";
            tblcredit.Columns[1].HeaderText = "Motif ";
            tblcredit.Columns[2].HeaderText = "Montant";
            tblcredit.Columns[3].HeaderText = "Date";
        }




        //////////////////////////////////////////////////////////TAPITRA////////////////////
        /// <summary>
        /// 
        /// </summary>
        /////////                                                               ///////CIRCLE//////
        ///
        /// 
        /// 
        /// 
        /// 
        /////////////////////             ////////////circle solde/////////////////////////
        private void reste_solde()
        {
            Models.DebitM solde = new Models.DebitM();
            int soldes = solde.somme_solde();
            Models.CreditM depenses = new Models.CreditM();
            int depe = depenses.somme_depenses();
            int restesolde = soldes - depe;
            label9.Text = restesolde.ToString() + " Ar";

            /*for (int i = 0; i<= (int)reste_Circle(); i++) 
            {
                restecircle.Value = i;
                restecircle.Text = i.ToString();

            }*/
            restecircle.Value = (int)reste_Circle();
            restecircle.Text = reste_Circle().ToString();


        }
        private decimal reste_Circle()
        {
            Models.DebitM solde = new Models.DebitM();
            int soldes = solde.somme_solde();
            Models.CreditM depenses = new Models.CreditM();
            int depe = depenses.somme_depenses();
            int restesolde = soldes - depe;
            label11.Text = soldes.ToString() + " Ar";
            label9.Text = restesolde.ToString() + " Ar";
            if (soldes != 0)
            {
                decimal pourcentage_reste_solde = (decimal)restesolde * 100 / soldes;

                return Math.Round(pourcentage_reste_solde, 0);

            }
            else
            {
                return 0;
            }


        }
      /*  private void circles_RESTE()
        {
            if (reste_Circle() != 0)
            {
                restecircle.Value += 1;
                restecircle.Text = restecircle.Value.ToString();
                if (restecircle.Value == (int)reste_Circle())
                {
                    timer2.Enabled = false;
                }

            }
            else
            {
                restecircle.Text = "0";

            }
        }*/
        /// <summary>
        /// /////////////               ////////circle depenses///////////////////////
        /// </summary>
        /// <returns></returns>
        /// 
        private void depense_dash()
        {
            
            Models.CreditM depenses = new Models.CreditM();
            int depe = depenses.somme_depenses();
            label10.Text = depe.ToString() + " Ar";

            
            depensecircle.Value = (int)depense_Circle();
            depensecircle.Text = depense_Circle().ToString();

        }
        private void dette_dash()
        {

            Models.CreditM depenses = new Models.CreditM();
            int depe = depenses.somme_dette();
            label15.Text = depe.ToString() + " Ar";


            
        }
        private decimal depense_Circle() 
        {
            Models.DebitM solde = new Models.DebitM();
            int soldes = solde.somme_solde();
            Models.CreditM depenses = new Models.CreditM();
            int depe = depenses.somme_depenses();
            label10.Text = depe.ToString() + " Ar";

            if (soldes != 0) 
            {
                decimal pourcentage_depense = (decimal)depe * 100 / soldes;
                return Math.Round(pourcentage_depense, 0);
            }
            else 
            {

                return 0;
            }
            

        }

        
       /* private void circles_DEPENSE()
        {
            if (depense_Circle() != 0)
            {
                depensecircle.Value += 1;
                depensecircle.Text = depensecircle.Value.ToString();
                if (depensecircle.Value == (int)depense_Circle())
                {
                    timer1.Enabled = false;
                }
            }
            else 
            {
                depensecircle.Text = "0";

            }

        }*/
        
        ////////////////////////TIMER//////////////

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            //circles_DEPENSE();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            circles_RESTE();

        }*/

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmail_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // circles_DEPENSE();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // circles_RESTE();
        }

        private void radioDepense_CheckedChanged(object sender, EventArgs e)
        {
            Creditloc();
            btnsuppcredit.Visible = false;
            label5.Text = "Depenses";

        }

        private void radioDette_CheckedChanged(object sender, EventArgs e)
        {
            Creditloc();
            btnsuppcredit.Visible = true;
            label5.Text = "Dettes";

        }

        private void btnreinitialiser_Click(object sender, EventArgs e)
        {
            Vue.interface_autorisation yoo = new Vue.interface_autorisation(txtmail.Text, "reinitialiser");
            yoo.ShowDialog();
        }

        private void btnannulerreini_Click(object sender, EventArgs e)
        {

        }

        private void btneditmotdepasse_Click(object sender, EventArgs e)
        {
            if (txtmotdepassenouveau.Text != txtmotdepasseconfirmation.Text)
            {
                MessageBox.Show("Les mots de passes ne sont pas identiques!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtmotdepassenouveau.Text =="" && txtmotdepasseconfirmation.Text == "")
            {
                MessageBox.Show("Les champs sont vides!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Vue.interface_autorisation yoo = new Vue.interface_autorisation(txtmail.Text, txtmotdepassenouveau.Text);
                yoo.ShowDialog();
                txtmotdepasseconfirmation.Text = "";
                txtmotdepassenouveau.Text = "";

            }

        }

        private void btnannulermodif_Click(object sender, EventArgs e)
        {
            txtmotdepasseconfirmation.Text = "";
            txtmotdepassenouveau.Text = "";
        }
    }
}
