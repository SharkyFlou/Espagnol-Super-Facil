﻿
namespace SaeTest
{
    partial class frmAdmin
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
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.pnlHautGauche = new System.Windows.Forms.Panel();
            this.btnExos = new System.Windows.Forms.Button();
            this.btnUtil = new System.Windows.Forms.Button();
            this.pnlExo = new System.Windows.Forms.Panel();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pbFin = new System.Windows.Forms.PictureBox();
            this.pbAvant = new System.Windows.Forms.PictureBox();
            this.pbDebut = new System.Windows.Forms.PictureBox();
            this.pbArriere = new System.Windows.Forms.PictureBox();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.lblCorr = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.trwExos = new System.Windows.Forms.TreeView();
            this.pnlUtil = new System.Windows.Forms.Panel();
            this.pnlDroit = new System.Windows.Forms.Panel();
            this.pbValider = new System.Windows.Forms.PictureBox();
            this.pbReset = new System.Windows.Forms.PictureBox();
            this.pbSuppr = new System.Windows.Forms.PictureBox();
            this.lblAjouterUtil = new System.Windows.Forms.Label();
            this.cboUtil = new System.Windows.Forms.ComboBox();
            this.cboCours = new System.Windows.Forms.ComboBox();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblExo = new System.Windows.Forms.Label();
            this.lblLecon = new System.Windows.Forms.Label();
            this.cboExo = new System.Windows.Forms.ComboBox();
            this.cboLecon = new System.Windows.Forms.ComboBox();
            this.pnlGauche = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHaut.SuspendLayout();
            this.pnlHautGauche.SuspendLayout();
            this.pnlExo.SuspendLayout();
            this.pnlMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArriere)).BeginInit();
            this.pnlUtil.SuspendLayout();
            this.pnlDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuppr)).BeginInit();
            this.pnlGauche.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHaut
            // 
            this.pnlHaut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlHaut.Controls.Add(this.pnlHautGauche);
            this.pnlHaut.Location = new System.Drawing.Point(0, 0);
            this.pnlHaut.Name = "pnlHaut";
            this.pnlHaut.Size = new System.Drawing.Size(831, 52);
            this.pnlHaut.TabIndex = 4;
            // 
            // pnlHautGauche
            // 
            this.pnlHautGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlHautGauche.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHautGauche.Controls.Add(this.btnExos);
            this.pnlHautGauche.Controls.Add(this.btnUtil);
            this.pnlHautGauche.Location = new System.Drawing.Point(0, 3);
            this.pnlHautGauche.Name = "pnlHautGauche";
            this.pnlHautGauche.Size = new System.Drawing.Size(439, 52);
            this.pnlHautGauche.TabIndex = 5;
            // 
            // btnExos
            // 
            this.btnExos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExos.FlatAppearance.BorderSize = 0;
            this.btnExos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExos.ForeColor = System.Drawing.Color.White;
            this.btnExos.Location = new System.Drawing.Point(0, -1);
            this.btnExos.Name = "btnExos";
            this.btnExos.Size = new System.Drawing.Size(150, 48);
            this.btnExos.TabIndex = 0;
            this.btnExos.Text = "Voir les exos";
            this.tTip.SetToolTip(this.btnExos, "Aller sur la page d\'affichage des exercices");
            this.btnExos.UseVisualStyleBackColor = false;
            this.btnExos.Click += new System.EventHandler(this.btnExos_Click);
            // 
            // btnUtil
            // 
            this.btnUtil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUtil.FlatAppearance.BorderSize = 0;
            this.btnUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtil.ForeColor = System.Drawing.Color.White;
            this.btnUtil.Location = new System.Drawing.Point(154, -1);
            this.btnUtil.Name = "btnUtil";
            this.btnUtil.Size = new System.Drawing.Size(281, 48);
            this.btnUtil.TabIndex = 1;
            this.btnUtil.Text = "Ajouter/modifier des utilisateurs";
            this.tTip.SetToolTip(this.btnUtil, "Aller sur la page pour ajouter/modifer des utilisateurs");
            this.btnUtil.UseVisualStyleBackColor = false;
            this.btnUtil.Click += new System.EventHandler(this.btnUtil_Click);
            // 
            // pnlExo
            // 
            this.pnlExo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlExo.Controls.Add(this.pnlMid);
            this.pnlExo.Controls.Add(this.trwExos);
            this.pnlExo.Location = new System.Drawing.Point(0, 52);
            this.pnlExo.Name = "pnlExo";
            this.pnlExo.Size = new System.Drawing.Size(831, 323);
            this.pnlExo.TabIndex = 5;
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.pbFin);
            this.pnlMid.Controls.Add(this.pbAvant);
            this.pnlMid.Controls.Add(this.pbDebut);
            this.pnlMid.Controls.Add(this.pbArriere);
            this.pnlMid.Controls.Add(this.lblPhrase);
            this.pnlMid.Controls.Add(this.lblCorr);
            this.pnlMid.Controls.Add(this.lblTitre);
            this.pnlMid.Location = new System.Drawing.Point(280, 3);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(536, 314);
            this.pnlMid.TabIndex = 2;
            // 
            // pbFin
            // 
            this.pbFin.BackColor = System.Drawing.Color.Transparent;
            this.pbFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFin.Location = new System.Drawing.Point(463, 277);
            this.pbFin.Name = "pbFin";
            this.pbFin.Size = new System.Drawing.Size(70, 37);
            this.pbFin.TabIndex = 14;
            this.pbFin.TabStop = false;
            this.pbFin.Click += new System.EventHandler(this.btnFin_Click);
            this.pbFin.MouseEnter += new System.EventHandler(this.pbFin_MouseEnter);
            this.pbFin.MouseLeave += new System.EventHandler(this.pbFin_MouseLeave);
            // 
            // pbAvant
            // 
            this.pbAvant.BackColor = System.Drawing.Color.Transparent;
            this.pbAvant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAvant.Location = new System.Drawing.Point(404, 277);
            this.pbAvant.Name = "pbAvant";
            this.pbAvant.Size = new System.Drawing.Size(53, 38);
            this.pbAvant.TabIndex = 13;
            this.pbAvant.TabStop = false;
            this.pbAvant.Click += new System.EventHandler(this.btnAvant_Click);
            this.pbAvant.MouseEnter += new System.EventHandler(this.pbAvant_MouseEnter);
            this.pbAvant.MouseLeave += new System.EventHandler(this.pbAvant_MouseLeave);
            // 
            // pbDebut
            // 
            this.pbDebut.BackColor = System.Drawing.Color.Transparent;
            this.pbDebut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDebut.Location = new System.Drawing.Point(2, 277);
            this.pbDebut.Name = "pbDebut";
            this.pbDebut.Size = new System.Drawing.Size(70, 37);
            this.pbDebut.TabIndex = 12;
            this.pbDebut.TabStop = false;
            this.pbDebut.Click += new System.EventHandler(this.btnDebut_Click);
            this.pbDebut.MouseEnter += new System.EventHandler(this.pbDebut_MouseEnter);
            this.pbDebut.MouseLeave += new System.EventHandler(this.pbDebut_MouseLeave);
            // 
            // pbArriere
            // 
            this.pbArriere.BackColor = System.Drawing.Color.Transparent;
            this.pbArriere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbArriere.Location = new System.Drawing.Point(78, 277);
            this.pbArriere.Name = "pbArriere";
            this.pbArriere.Size = new System.Drawing.Size(53, 38);
            this.pbArriere.TabIndex = 11;
            this.pbArriere.TabStop = false;
            this.pbArriere.Click += new System.EventHandler(this.btnArriere_Click);
            this.pbArriere.MouseEnter += new System.EventHandler(this.pbArriere_MouseEnter);
            this.pbArriere.MouseLeave += new System.EventHandler(this.pbArriere_MouseLeave);
            // 
            // lblPhrase
            // 
            this.lblPhrase.BackColor = System.Drawing.Color.Transparent;
            this.lblPhrase.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPhrase.Location = new System.Drawing.Point(3, 76);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(529, 84);
            this.lblPhrase.TabIndex = 10;
            this.lblPhrase.Text = "Phrase";
            this.lblPhrase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCorr
            // 
            this.lblCorr.BackColor = System.Drawing.Color.Transparent;
            this.lblCorr.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCorr.Location = new System.Drawing.Point(3, 160);
            this.lblCorr.Name = "lblCorr";
            this.lblCorr.Size = new System.Drawing.Size(529, 78);
            this.lblCorr.TabIndex = 9;
            this.lblCorr.Text = "Corrige";
            this.lblCorr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitre.Location = new System.Drawing.Point(2, 8);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(530, 40);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Titre";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tTip.SetToolTip(this.lblTitre, "Titre de l\'exercice");
            // 
            // trwExos
            // 
            this.trwExos.BackColor = System.Drawing.Color.DimGray;
            this.trwExos.Location = new System.Drawing.Point(3, 3);
            this.trwExos.Name = "trwExos";
            this.trwExos.Size = new System.Drawing.Size(265, 314);
            this.trwExos.TabIndex = 3;
            this.trwExos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trwExos_AfterSelect);
            // 
            // pnlUtil
            // 
            this.pnlUtil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUtil.Controls.Add(this.pnlDroit);
            this.pnlUtil.Controls.Add(this.pnlGauche);
            this.pnlUtil.Location = new System.Drawing.Point(0, 52);
            this.pnlUtil.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUtil.Name = "pnlUtil";
            this.pnlUtil.Size = new System.Drawing.Size(831, 323);
            this.pnlUtil.TabIndex = 6;
            // 
            // pnlDroit
            // 
            this.pnlDroit.Controls.Add(this.pbValider);
            this.pnlDroit.Controls.Add(this.pbReset);
            this.pnlDroit.Controls.Add(this.pbSuppr);
            this.pnlDroit.Controls.Add(this.lblAjouterUtil);
            this.pnlDroit.Controls.Add(this.cboUtil);
            this.pnlDroit.Controls.Add(this.cboCours);
            this.pnlDroit.Controls.Add(this.lblCours);
            this.pnlDroit.Controls.Add(this.lblExo);
            this.pnlDroit.Controls.Add(this.lblLecon);
            this.pnlDroit.Controls.Add(this.cboExo);
            this.pnlDroit.Controls.Add(this.cboLecon);
            this.pnlDroit.Location = new System.Drawing.Point(449, 6);
            this.pnlDroit.Name = "pnlDroit";
            this.pnlDroit.Size = new System.Drawing.Size(370, 310);
            this.pnlDroit.TabIndex = 15;
            // 
            // pbValider
            // 
            this.pbValider.BackColor = System.Drawing.Color.Transparent;
            this.pbValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbValider.Location = new System.Drawing.Point(307, 248);
            this.pbValider.Name = "pbValider";
            this.pbValider.Size = new System.Drawing.Size(61, 65);
            this.pbValider.TabIndex = 14;
            this.pbValider.TabStop = false;
            this.tTip.SetToolTip(this.pbValider, "Appliquer les modfications \r\nà l\'utilisateur sélectionné");
            this.pbValider.Click += new System.EventHandler(this.btnModifier_Click);
            this.pbValider.MouseEnter += new System.EventHandler(this.pbValider_MouseEnter);
            this.pbValider.MouseLeave += new System.EventHandler(this.pbValider_MouseLeave);
            // 
            // pbReset
            // 
            this.pbReset.BackColor = System.Drawing.Color.Transparent;
            this.pbReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReset.Location = new System.Drawing.Point(240, 248);
            this.pbReset.Name = "pbReset";
            this.pbReset.Size = new System.Drawing.Size(61, 67);
            this.pbReset.TabIndex = 13;
            this.pbReset.TabStop = false;
            this.tTip.SetToolTip(this.pbReset, "Remettre à default l\'avancement \r\nde l\'utilisateur sélectionné");
            this.pbReset.Click += new System.EventHandler(this.btnReset_Click);
            this.pbReset.MouseEnter += new System.EventHandler(this.pbReset_MouseEnter);
            this.pbReset.MouseLeave += new System.EventHandler(this.pbReset_MouseLeave);
            // 
            // pbSuppr
            // 
            this.pbSuppr.BackColor = System.Drawing.Color.Transparent;
            this.pbSuppr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSuppr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSuppr.Location = new System.Drawing.Point(3, 248);
            this.pbSuppr.Name = "pbSuppr";
            this.pbSuppr.Size = new System.Drawing.Size(61, 67);
            this.pbSuppr.TabIndex = 12;
            this.pbSuppr.TabStop = false;
            this.tTip.SetToolTip(this.pbSuppr, "Supprimer l\'utilisateur sélectionné");
            this.pbSuppr.Click += new System.EventHandler(this.btSuppr_Click);
            this.pbSuppr.MouseEnter += new System.EventHandler(this.pbSuppr_MouseEnter);
            this.pbSuppr.MouseLeave += new System.EventHandler(this.pbSuppr_MouseLeave);
            // 
            // lblAjouterUtil
            // 
            this.lblAjouterUtil.BackColor = System.Drawing.Color.Transparent;
            this.lblAjouterUtil.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAjouterUtil.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjouterUtil.ForeColor = System.Drawing.Color.White;
            this.lblAjouterUtil.Location = new System.Drawing.Point(0, 0);
            this.lblAjouterUtil.Name = "lblAjouterUtil";
            this.lblAjouterUtil.Size = new System.Drawing.Size(370, 29);
            this.lblAjouterUtil.TabIndex = 5;
            this.lblAjouterUtil.Text = "Modifier un utilisateur inscrit";
            this.lblAjouterUtil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboUtil
            // 
            this.cboUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUtil.ForeColor = System.Drawing.Color.Black;
            this.cboUtil.FormattingEnabled = true;
            this.cboUtil.Location = new System.Drawing.Point(3, 32);
            this.cboUtil.Name = "cboUtil";
            this.cboUtil.Size = new System.Drawing.Size(364, 29);
            this.cboUtil.TabIndex = 0;
            this.cboUtil.SelectionChangeCommitted += new System.EventHandler(this.cboUtil_SelectionChangeCommitted);
            // 
            // cboCours
            // 
            this.cboCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCours.ForeColor = System.Drawing.Color.Black;
            this.cboCours.FormattingEnabled = true;
            this.cboCours.Location = new System.Drawing.Point(3, 92);
            this.cboCours.Name = "cboCours";
            this.cboCours.Size = new System.Drawing.Size(364, 29);
            this.cboCours.TabIndex = 3;
            this.cboCours.SelectionChangeCommitted += new System.EventHandler(this.cboCours_SelectionChangeCommitted);
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.ForeColor = System.Drawing.Color.White;
            this.lblCours.Location = new System.Drawing.Point(3, 68);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(51, 21);
            this.lblCours.TabIndex = 9;
            this.lblCours.Text = "Cours";
            // 
            // lblExo
            // 
            this.lblExo.AutoSize = true;
            this.lblExo.BackColor = System.Drawing.Color.Transparent;
            this.lblExo.ForeColor = System.Drawing.Color.White;
            this.lblExo.Location = new System.Drawing.Point(3, 188);
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
            this.lblLecon.Location = new System.Drawing.Point(3, 128);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(51, 21);
            this.lblLecon.TabIndex = 8;
            this.lblLecon.Text = "Leçon";
            // 
            // cboExo
            // 
            this.cboExo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExo.ForeColor = System.Drawing.Color.Black;
            this.cboExo.FormattingEnabled = true;
            this.cboExo.Location = new System.Drawing.Point(3, 212);
            this.cboExo.Name = "cboExo";
            this.cboExo.Size = new System.Drawing.Size(364, 29);
            this.cboExo.TabIndex = 4;
            // 
            // cboLecon
            // 
            this.cboLecon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLecon.ForeColor = System.Drawing.Color.Black;
            this.cboLecon.FormattingEnabled = true;
            this.cboLecon.Location = new System.Drawing.Point(3, 152);
            this.cboLecon.Name = "cboLecon";
            this.cboLecon.Size = new System.Drawing.Size(364, 29);
            this.cboLecon.TabIndex = 2;
            this.cboLecon.SelectionChangeCommitted += new System.EventHandler(this.cboLecon_SelectionChangeCommitted);
            // 
            // pnlGauche
            // 
            this.pnlGauche.Controls.Add(this.btnAjouter);
            this.pnlGauche.Location = new System.Drawing.Point(12, 7);
            this.pnlGauche.Name = "pnlGauche";
            this.pnlGauche.Size = new System.Drawing.Size(370, 309);
            this.pnlGauche.TabIndex = 14;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(16, 16);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(336, 143);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter un nouvel utilisateur";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.pnlHaut);
            this.Controls.Add(this.pnlExo);
            this.Controls.Add(this.pnlUtil);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlHaut.ResumeLayout(false);
            this.pnlHautGauche.ResumeLayout(false);
            this.pnlExo.ResumeLayout(false);
            this.pnlMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArriere)).EndInit();
            this.pnlUtil.ResumeLayout(false);
            this.pnlDroit.ResumeLayout(false);
            this.pnlDroit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuppr)).EndInit();
            this.pnlGauche.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.Button btnUtil;
        private System.Windows.Forms.Button btnExos;
        private System.Windows.Forms.Panel pnlExo;
        private System.Windows.Forms.Panel pnlUtil;
        private System.Windows.Forms.TreeView trwExos;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Label lblCorr;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlDroit;
        private System.Windows.Forms.Label lblAjouterUtil;
        private System.Windows.Forms.ComboBox cboUtil;
        private System.Windows.Forms.ComboBox cboCours;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblExo;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.ComboBox cboExo;
        private System.Windows.Forms.ComboBox cboLecon;
        private System.Windows.Forms.Panel pnlGauche;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel pnlHautGauche;
        private System.Windows.Forms.PictureBox pbFin;
        private System.Windows.Forms.PictureBox pbAvant;
        private System.Windows.Forms.PictureBox pbDebut;
        private System.Windows.Forms.PictureBox pbArriere;
        private System.Windows.Forms.PictureBox pbSuppr;
        private System.Windows.Forms.PictureBox pbValider;
        private System.Windows.Forms.PictureBox pbReset;
        private System.Windows.Forms.ToolTip tTip;
    }
}