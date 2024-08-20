
namespace GESTION_DE_PORTEFEUILLE_CSHARP.Vue
{
    partial class interfaceajoutCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfaceajoutCredit));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblreferencecredit = new System.Windows.Forms.Label();
            this.dateCredit = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Creditlbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnajoutannuler = new Guna.UI2.WinForms.Guna2Button();
            this.btnenregistrerajoutCredit = new Guna.UI2.WinForms.Guna2Button();
            this.txtreasonCredit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtamountCredit = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lblreferencecredit
            // 
            this.lblreferencecredit.AutoSize = true;
            this.lblreferencecredit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreferencecredit.Location = new System.Drawing.Point(445, 33);
            this.lblreferencecredit.Name = "lblreferencecredit";
            this.lblreferencecredit.Size = new System.Drawing.Size(0, 19);
            this.lblreferencecredit.TabIndex = 28;
            this.lblreferencecredit.Visible = false;
            // 
            // dateCredit
            // 
            this.dateCredit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dateCredit.BorderThickness = 2;
            this.dateCredit.CausesValidation = false;
            this.dateCredit.Checked = true;
            this.dateCredit.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateCredit.Enabled = false;
            this.dateCredit.FillColor = System.Drawing.Color.Transparent;
            this.dateCredit.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCredit.ForeColor = System.Drawing.Color.Gray;
            this.dateCredit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCredit.Location = new System.Drawing.Point(71, 372);
            this.dateCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCredit.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateCredit.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateCredit.Name = "dateCredit";
            this.dateCredit.Size = new System.Drawing.Size(285, 50);
            this.dateCredit.TabIndex = 27;
            this.dateCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateCredit.Value = new System.DateTime(2024, 4, 13, 1, 39, 26, 399);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(67, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(67, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Montant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(67, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Motif";
            // 
            // Creditlbl
            // 
            this.Creditlbl.BackColor = System.Drawing.Color.Transparent;
            this.Creditlbl.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creditlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Creditlbl.Location = new System.Drawing.Point(71, 71);
            this.Creditlbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Creditlbl.Name = "Creditlbl";
            this.Creditlbl.Size = new System.Drawing.Size(292, 52);
            this.Creditlbl.TabIndex = 22;
            this.Creditlbl.Text = "Ajouter Depense";
            // 
            // btnajoutannuler
            // 
            this.btnajoutannuler.BorderColor = System.Drawing.Color.Gray;
            this.btnajoutannuler.BorderRadius = 4;
            this.btnajoutannuler.BorderThickness = 1;
            this.btnajoutannuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnajoutannuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnajoutannuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnajoutannuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnajoutannuler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.btnajoutannuler.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajoutannuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnajoutannuler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnajoutannuler.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnajoutannuler.Location = new System.Drawing.Point(268, 474);
            this.btnajoutannuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnajoutannuler.Name = "btnajoutannuler";
            this.btnajoutannuler.Size = new System.Drawing.Size(164, 46);
            this.btnajoutannuler.TabIndex = 21;
            this.btnajoutannuler.Text = "Annuler";
            this.btnajoutannuler.Click += new System.EventHandler(this.btnajoutannuler_Click);
            // 
            // btnenregistrerajoutCredit
            // 
            this.btnenregistrerajoutCredit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnenregistrerajoutCredit.BorderRadius = 4;
            this.btnenregistrerajoutCredit.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnenregistrerajoutCredit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnenregistrerajoutCredit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnenregistrerajoutCredit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnenregistrerajoutCredit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnenregistrerajoutCredit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnenregistrerajoutCredit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrerajoutCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.btnenregistrerajoutCredit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnenregistrerajoutCredit.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnenregistrerajoutCredit.Location = new System.Drawing.Point(71, 474);
            this.btnenregistrerajoutCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnenregistrerajoutCredit.Name = "btnenregistrerajoutCredit";
            this.btnenregistrerajoutCredit.Size = new System.Drawing.Size(164, 46);
            this.btnenregistrerajoutCredit.TabIndex = 20;
            this.btnenregistrerajoutCredit.Text = "Enregistrer";
            this.btnenregistrerajoutCredit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnenregistrerajoutCredit.Click += new System.EventHandler(this.btnenregistrerajoutCredit_Click_1);
            // 
            // txtreasonCredit
            // 
            this.txtreasonCredit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txtreasonCredit.BorderThickness = 2;
            this.txtreasonCredit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtreasonCredit.DefaultText = "";
            this.txtreasonCredit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtreasonCredit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtreasonCredit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtreasonCredit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtreasonCredit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.txtreasonCredit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtreasonCredit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreasonCredit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtreasonCredit.Location = new System.Drawing.Point(71, 208);
            this.txtreasonCredit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtreasonCredit.Name = "txtreasonCredit";
            this.txtreasonCredit.PasswordChar = '\0';
            this.txtreasonCredit.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtreasonCredit.PlaceholderText = "";
            this.txtreasonCredit.SelectedText = "";
            this.txtreasonCredit.Size = new System.Drawing.Size(357, 50);
            this.txtreasonCredit.TabIndex = 1;
            // 
            // txtamountCredit
            // 
            this.txtamountCredit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txtamountCredit.BorderThickness = 2;
            this.txtamountCredit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtamountCredit.DefaultText = "";
            this.txtamountCredit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtamountCredit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtamountCredit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtamountCredit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtamountCredit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.txtamountCredit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtamountCredit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamountCredit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtamountCredit.Location = new System.Drawing.Point(71, 289);
            this.txtamountCredit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtamountCredit.Name = "txtamountCredit";
            this.txtamountCredit.PasswordChar = '\0';
            this.txtamountCredit.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtamountCredit.PlaceholderText = "";
            this.txtamountCredit.SelectedText = "";
            this.txtamountCredit.Size = new System.Drawing.Size(357, 50);
            this.txtamountCredit.TabIndex = 2;
            // 
            // interfaceajoutCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(491, 551);
            this.Controls.Add(this.txtamountCredit);
            this.Controls.Add(this.lblreferencecredit);
            this.Controls.Add(this.dateCredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Creditlbl);
            this.Controls.Add(this.btnajoutannuler);
            this.Controls.Add(this.btnenregistrerajoutCredit);
            this.Controls.Add(this.txtreasonCredit);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(491, 551);
            this.MinimumSize = new System.Drawing.Size(491, 551);
            this.Name = "interfaceajoutCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "interfaceajoutCredit";
            this.Load += new System.EventHandler(this.interfaceajoutCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblreferencecredit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateCredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Creditlbl;
        private Guna.UI2.WinForms.Guna2Button btnajoutannuler;
        private Guna.UI2.WinForms.Guna2Button btnenregistrerajoutCredit;
        private Guna.UI2.WinForms.Guna2TextBox txtreasonCredit;
        private Guna.UI2.WinForms.Guna2TextBox txtamountCredit;
    }
}