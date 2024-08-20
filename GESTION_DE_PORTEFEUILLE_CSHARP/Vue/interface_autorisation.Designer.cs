
namespace GESTION_DE_PORTEFEUILLE_CSHARP.Vue
{
    partial class interface_autorisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interface_autorisation));
            this.lbltype = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.lblmdpfausse = new System.Windows.Forms.Label();
            this.btneditannuler = new Guna.UI2.WinForms.Guna2Button();
            this.btneditpoursuivre = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtmdp = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(399, 135);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(46, 17);
            this.lbltype.TabIndex = 35;
            this.lbltype.Text = "label3";
            this.lbltype.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(43, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "E-mail:";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.lblmail.Location = new System.Drawing.Point(131, 60);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(48, 25);
            this.lblmail.TabIndex = 33;
            this.lblmail.Text = "mail";
            // 
            // lblmdpfausse
            // 
            this.lblmdpfausse.AutoSize = true;
            this.lblmdpfausse.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmdpfausse.ForeColor = System.Drawing.Color.Red;
            this.lblmdpfausse.Location = new System.Drawing.Point(95, 98);
            this.lblmdpfausse.Name = "lblmdpfausse";
            this.lblmdpfausse.Size = new System.Drawing.Size(268, 23);
            this.lblmdpfausse.TabIndex = 32;
            this.lblmdpfausse.Text = "Votre mot de passe est incorrect";
            this.lblmdpfausse.Visible = false;
            // 
            // btneditannuler
            // 
            this.btneditannuler.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btneditannuler.BorderRadius = 4;
            this.btneditannuler.BorderThickness = 1;
            this.btneditannuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneditannuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneditannuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneditannuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneditannuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.btneditannuler.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditannuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btneditannuler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btneditannuler.ImageOffset = new System.Drawing.Point(5, 0);
            this.btneditannuler.Location = new System.Drawing.Point(273, 194);
            this.btneditannuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneditannuler.Name = "btneditannuler";
            this.btneditannuler.Size = new System.Drawing.Size(164, 46);
            this.btneditannuler.TabIndex = 30;
            this.btneditannuler.Text = "Annuler";
            this.btneditannuler.Click += new System.EventHandler(this.btneditannuler_Click);
            // 
            // btneditpoursuivre
            // 
            this.btneditpoursuivre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btneditpoursuivre.BorderRadius = 4;
            this.btneditpoursuivre.BorderThickness = 1;
            this.btneditpoursuivre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneditpoursuivre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneditpoursuivre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneditpoursuivre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneditpoursuivre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btneditpoursuivre.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditpoursuivre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.btneditpoursuivre.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btneditpoursuivre.Location = new System.Drawing.Point(51, 194);
            this.btneditpoursuivre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneditpoursuivre.Name = "btneditpoursuivre";
            this.btneditpoursuivre.Size = new System.Drawing.Size(164, 46);
            this.btneditpoursuivre.TabIndex = 29;
            this.btneditpoursuivre.Text = "Poursuivre";
            this.btneditpoursuivre.Click += new System.EventHandler(this.btneditpoursuivre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "*Veuillez d\'abord entrer votre mot de passe";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txtmdp
            // 
            this.txtmdp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txtmdp.BorderRadius = 1;
            this.txtmdp.BorderThickness = 2;
            this.txtmdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmdp.DefaultText = "";
            this.txtmdp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmdp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmdp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmdp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmdp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.txtmdp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmdp.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.txtmdp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmdp.Location = new System.Drawing.Point(89, 126);
            this.txtmdp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.PasswordChar = '\0';
            this.txtmdp.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtmdp.PlaceholderText = "Mot de passe";
            this.txtmdp.SelectedText = "";
            this.txtmdp.Size = new System.Drawing.Size(332, 55);
            this.txtmdp.TabIndex = 1;
            // 
            // interface_autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(512, 278);
            this.ControlBox = false;
            this.Controls.Add(this.txtmdp);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.lblmdpfausse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneditannuler);
            this.Controls.Add(this.btneditpoursuivre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(512, 278);
            this.MinimumSize = new System.Drawing.Size(512, 278);
            this.Name = "interface_autorisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "interface_autorisation";
            this.Load += new System.EventHandler(this.interface_autorisation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblmdpfausse;
        private Guna.UI2.WinForms.Guna2Button btneditannuler;
        private Guna.UI2.WinForms.Guna2Button btneditpoursuivre;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtmdp;
    }
}