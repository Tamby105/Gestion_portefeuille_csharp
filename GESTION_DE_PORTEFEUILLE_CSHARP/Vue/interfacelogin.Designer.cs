
namespace GESTION_DE_PORTEFEUILLE_CSHARP
{
    partial class interfacelogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btninvisiblepassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnvisiblepassword = new Guna.UI2.WinForms.Guna2Button();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtpassword);
            this.guna2Panel1.Controls.Add(this.btninvisiblepassword);
            this.guna2Panel1.Controls.Add(this.btnvisiblepassword);
            this.guna2Panel1.Controls.Add(this.txtemail);
            this.guna2Panel1.Controls.Add(this.btnlogin);
            this.guna2Panel1.Controls.Add(this.lblemail);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.MaximumSize = new System.Drawing.Size(491, 552);
            this.guna2Panel1.MinimumSize = new System.Drawing.Size(491, 552);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(491, 552);
            this.guna2Panel1.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderRadius = 10;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Location = new System.Drawing.Point(104, 419);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(285, 50);
            this.txtpassword.TabIndex = 21;
            // 
            // btninvisiblepassword
            // 
            this.btninvisiblepassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btninvisiblepassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btninvisiblepassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btninvisiblepassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btninvisiblepassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btninvisiblepassword.ForeColor = System.Drawing.Color.White;
            this.btninvisiblepassword.Location = new System.Drawing.Point(48, 159);
            this.btninvisiblepassword.Name = "btninvisiblepassword";
            this.btninvisiblepassword.Size = new System.Drawing.Size(180, 45);
            this.btninvisiblepassword.TabIndex = 19;
            this.btninvisiblepassword.Text = "1";
            this.btninvisiblepassword.Click += new System.EventHandler(this.btninvisiblepassword_Click);
            // 
            // btnvisiblepassword
            // 
            this.btnvisiblepassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnvisiblepassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnvisiblepassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnvisiblepassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnvisiblepassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnvisiblepassword.ForeColor = System.Drawing.Color.White;
            this.btnvisiblepassword.Location = new System.Drawing.Point(263, 159);
            this.btnvisiblepassword.Name = "btnvisiblepassword";
            this.btnvisiblepassword.Size = new System.Drawing.Size(180, 45);
            this.btnvisiblepassword.TabIndex = 18;
            this.btnvisiblepassword.Text = "2";
            this.btnvisiblepassword.Click += new System.EventHandler(this.btnvisiblepassword_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderRadius = 10;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(104, 339);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "E-mail Address";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(285, 50);
            this.txtemail.TabIndex = 16;
            // 
            // btnlogin
            // 
            this.btnlogin.BorderRadius = 12;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.FillColor = System.Drawing.Color.Gray;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlogin.ImageSize = new System.Drawing.Size(35, 35);
            this.btnlogin.Location = new System.Drawing.Point(150, 489);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(180, 45);
            this.btnlogin.TabIndex = 14;
            this.btnlogin.Text = "Se connecter";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Red;
            this.lblemail.Location = new System.Drawing.Point(100, 294);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(291, 21);
            this.lblemail.TabIndex = 13;
            this.lblemail.Text = "E-mail ou mot de passe incorrect!!";
            this.lblemail.Visible = false;
            // 
            // interfacelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 552);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 552);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(491, 552);
            this.Name = "interfacelogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.Label lblemail;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2Button btnvisiblepassword;
        private Guna.UI2.WinForms.Guna2Button btninvisiblepassword;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
    }
}