
namespace SaeTest
{
    partial class frmAdminCrea
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
            this.cboUtil = new System.Windows.Forms.ComboBox();
            this.cboLecon = new System.Windows.Forms.ComboBox();
            this.cboCours = new System.Windows.Forms.ComboBox();
            this.cboExo = new System.Windows.Forms.ComboBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblExo = new System.Windows.Forms.Label();
            this.lblLecon = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.pnlGauche = new System.Windows.Forms.Panel();
            this.pnlDroit = new System.Windows.Forms.Panel();
            this.btSuppr = new System.Windows.Forms.Button();
            this.pnlGauche.SuspendLayout();
            this.pnlDroit.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboUtil
            // 
            this.cboUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUtil.ForeColor = System.Drawing.Color.Black;
            this.cboUtil.FormattingEnabled = true;
            this.cboUtil.Location = new System.Drawing.Point(3, 49);
            this.cboUtil.Name = "cboUtil";
            this.cboUtil.Size = new System.Drawing.Size(364, 29);
            this.cboUtil.TabIndex = 0;
            this.cboUtil.SelectionChangeCommitted += new System.EventHandler(this.cboUtil_SelectionChangeCommitted);
            // 
            // cboLecon
            // 
            this.cboLecon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLecon.ForeColor = System.Drawing.Color.Black;
            this.cboLecon.FormattingEnabled = true;
            this.cboLecon.Location = new System.Drawing.Point(3, 180);
            this.cboLecon.Name = "cboLecon";
            this.cboLecon.Size = new System.Drawing.Size(364, 29);
            this.cboLecon.TabIndex = 2;
            this.cboLecon.SelectionChangeCommitted += new System.EventHandler(this.cboLecon_SelectionChangeCommitted);
            // 
            // cboCours
            // 
            this.cboCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCours.ForeColor = System.Drawing.Color.Black;
            this.cboCours.FormattingEnabled = true;
            this.cboCours.Location = new System.Drawing.Point(3, 115);
            this.cboCours.Name = "cboCours";
            this.cboCours.Size = new System.Drawing.Size(364, 29);
            this.cboCours.TabIndex = 3;
            this.cboCours.SelectionChangeCommitted += new System.EventHandler(this.cboCours_SelectionChangeCommitted);
            // 
            // cboExo
            // 
            this.cboExo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExo.ForeColor = System.Drawing.Color.Black;
            this.cboExo.FormattingEnabled = true;
            this.cboExo.Location = new System.Drawing.Point(3, 254);
            this.cboExo.Name = "cboExo";
            this.cboExo.Size = new System.Drawing.Size(360, 29);
            this.cboExo.TabIndex = 4;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(3, 16);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(279, 30);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Modifier un utilisateur inscrit";
            // 
            // lblExo
            // 
            this.lblExo.AutoSize = true;
            this.lblExo.BackColor = System.Drawing.Color.Transparent;
            this.lblExo.ForeColor = System.Drawing.Color.White;
            this.lblExo.Location = new System.Drawing.Point(3, 230);
            this.lblExo.Name = "lblExo";
            this.lblExo.Size = new System.Drawing.Size(72, 21);
            this.lblExo.TabIndex = 7;
            this.lblExo.Text = "Exercices";
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblLecon.ForeColor = System.Drawing.Color.White;
            this.lblLecon.Location = new System.Drawing.Point(3, 156);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(51, 21);
            this.lblLecon.TabIndex = 8;
            this.lblLecon.Text = "Leçon";
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.ForeColor = System.Drawing.Color.White;
            this.lblCours.Location = new System.Drawing.Point(4, 91);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(51, 21);
            this.lblCours.TabIndex = 9;
            this.lblCours.Text = "Cours";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(141, 296);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 50);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.Black;
            this.btnValider.Location = new System.Drawing.Point(243, 296);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(124, 50);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Modifier";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(45, 31);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(285, 119);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter un nouvel utilisateur";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // pnlGauche
            // 
            this.pnlGauche.Controls.Add(this.btnAjouter);
            this.pnlGauche.Location = new System.Drawing.Point(36, 13);
            this.pnlGauche.Name = "pnlGauche";
            this.pnlGauche.Size = new System.Drawing.Size(370, 350);
            this.pnlGauche.TabIndex = 12;
            // 
            // pnlDroit
            // 
            this.pnlDroit.Controls.Add(this.btSuppr);
            this.pnlDroit.Controls.Add(this.lblTitre);
            this.pnlDroit.Controls.Add(this.cboUtil);
            this.pnlDroit.Controls.Add(this.btnValider);
            this.pnlDroit.Controls.Add(this.cboCours);
            this.pnlDroit.Controls.Add(this.btnReset);
            this.pnlDroit.Controls.Add(this.lblCours);
            this.pnlDroit.Controls.Add(this.lblExo);
            this.pnlDroit.Controls.Add(this.lblLecon);
            this.pnlDroit.Controls.Add(this.cboExo);
            this.pnlDroit.Controls.Add(this.cboLecon);
            this.pnlDroit.Location = new System.Drawing.Point(412, 12);
            this.pnlDroit.Name = "pnlDroit";
            this.pnlDroit.Size = new System.Drawing.Size(370, 350);
            this.pnlDroit.TabIndex = 13;
            // 
            // btSuppr
            // 
            this.btSuppr.BackColor = System.Drawing.Color.Red;
            this.btSuppr.FlatAppearance.BorderSize = 0;
            this.btSuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuppr.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuppr.ForeColor = System.Drawing.Color.Black;
            this.btSuppr.Location = new System.Drawing.Point(3, 297);
            this.btSuppr.Name = "btSuppr";
            this.btSuppr.Size = new System.Drawing.Size(127, 50);
            this.btSuppr.TabIndex = 12;
            this.btSuppr.Text = "Supprimer l\'utilisateur";
            this.btSuppr.UseVisualStyleBackColor = false;
            this.btSuppr.Click += new System.EventHandler(this.btSuppr_Click);
            // 
            // frmAdminCrea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.pnlDroit);
            this.Controls.Add(this.pnlGauche);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminCrea";
            this.Text = "frmAdminCrea";
            this.Load += new System.EventHandler(this.frmAdminCrea_Load);
            this.pnlGauche.ResumeLayout(false);
            this.pnlDroit.ResumeLayout(false);
            this.pnlDroit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUtil;
        private System.Windows.Forms.ComboBox cboLecon;
        private System.Windows.Forms.ComboBox cboCours;
        private System.Windows.Forms.ComboBox cboExo;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblExo;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel pnlGauche;
        private System.Windows.Forms.Panel pnlDroit;
        private System.Windows.Forms.Button btSuppr;
    }
}