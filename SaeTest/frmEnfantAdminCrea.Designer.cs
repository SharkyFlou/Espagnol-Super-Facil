
namespace SaeTest
{
    partial class frmEnfantAdminCrea
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAide = new System.Windows.Forms.Button();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblLecon = new System.Windows.Forms.Label();
            this.cboCours = new System.Windows.Forms.ComboBox();
            this.cboExo = new System.Windows.Forms.ComboBox();
            this.cboLecon = new System.Windows.Forms.ComboBox();
            this.lblExo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(3, 93);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(267, 29);
            this.txtNom.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(224, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(176, 30);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Nouvel utilisateur";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(3, 9);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(145, 62);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(447, 9);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(145, 62);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider et créer";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(508, 9);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 40);
            this.btnAide.TabIndex = 6;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(3, 171);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(267, 29);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(3, 242);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(267, 29);
            this.txtMail.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Location = new System.Drawing.Point(0, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 74);
            this.panel1.TabIndex = 9;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(3, 69);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 21);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.ForeColor = System.Drawing.Color.White;
            this.lblPrenom.Location = new System.Drawing.Point(3, 147);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(65, 21);
            this.lblPrenom.TabIndex = 11;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(3, 218);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(40, 21);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail";
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.ForeColor = System.Drawing.Color.White;
            this.lblCours.Location = new System.Drawing.Point(13, 69);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(51, 21);
            this.lblCours.TabIndex = 13;
            this.lblCours.Text = "Cours";
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.ForeColor = System.Drawing.Color.White;
            this.lblLecon.Location = new System.Drawing.Point(13, 135);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(51, 21);
            this.lblLecon.TabIndex = 14;
            this.lblLecon.Text = "Leçon";
            // 
            // cboCours
            // 
            this.cboCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCours.FormattingEnabled = true;
            this.cboCours.Location = new System.Drawing.Point(17, 93);
            this.cboCours.Name = "cboCours";
            this.cboCours.Size = new System.Drawing.Size(227, 29);
            this.cboCours.TabIndex = 3;
            this.cboCours.SelectionChangeCommitted += new System.EventHandler(this.cboCours_SelectionChangeCommitted);
            // 
            // cboExo
            // 
            this.cboExo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExo.FormattingEnabled = true;
            this.cboExo.Location = new System.Drawing.Point(17, 242);
            this.cboExo.Name = "cboExo";
            this.cboExo.Size = new System.Drawing.Size(227, 29);
            this.cboExo.TabIndex = 5;
            // 
            // cboLecon
            // 
            this.cboLecon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLecon.FormattingEnabled = true;
            this.cboLecon.Location = new System.Drawing.Point(17, 171);
            this.cboLecon.Name = "cboLecon";
            this.cboLecon.Size = new System.Drawing.Size(227, 29);
            this.cboLecon.TabIndex = 4;
            this.cboLecon.SelectionChangeCommitted += new System.EventHandler(this.cboLecon_SelectionChangeCommitted);
            // 
            // lblExo
            // 
            this.lblExo.AutoSize = true;
            this.lblExo.ForeColor = System.Drawing.Color.White;
            this.lblExo.Location = new System.Drawing.Point(13, 218);
            this.lblExo.Name = "lblExo";
            this.lblExo.Size = new System.Drawing.Size(65, 21);
            this.lblExo.TabIndex = 18;
            this.lblExo.Text = "Exercice";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Controls.Add(this.lblMail);
            this.panel2.Controls.Add(this.lblPrenom);
            this.panel2.Controls.Add(this.lblNom);
            this.panel2.Controls.Add(this.txtMail);
            this.panel2.Controls.Add(this.txtPrenom);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 284);
            this.panel2.TabIndex = 19;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(58, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(130, 25);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "Infos générals";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblExo);
            this.panel3.Controls.Add(this.cboLecon);
            this.panel3.Controls.Add(this.cboExo);
            this.panel3.Controls.Add(this.cboCours);
            this.panel3.Controls.Add(this.lblLecon);
            this.panel3.Controls.Add(this.lblCours);
            this.panel3.Location = new System.Drawing.Point(318, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 284);
            this.panel3.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choix premier exercice";
            // 
            // frmEnfantAdminCrea
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(595, 431);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.lblTitre);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEnfantAdminCrea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creation d\'utilisateur";
            this.Load += new System.EventHandler(this.frmEnfantAdminCrea_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.ComboBox cboCours;
        private System.Windows.Forms.ComboBox cboExo;
        private System.Windows.Forms.ComboBox cboLecon;
        private System.Windows.Forms.Label lblExo;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}