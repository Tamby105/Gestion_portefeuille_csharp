using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_PORTEFEUILLE_CSHARP
{
    public partial class interfacelogin : Form
    {
        public interfacelogin()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar = true;

        }

        private void btnvisiblepassword_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;

        }

        private void btninvisiblepassword_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;

        }
    }
}
