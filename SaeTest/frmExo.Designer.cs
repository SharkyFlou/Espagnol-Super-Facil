
using System.Drawing;

namespace SaeTest
{
    partial class frmExo
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAide = new System.Windows.Forms.Button();
            this.pnlExo1 = new System.Windows.Forms.Panel();
            this.pnlPhrase = new System.Windows.Forms.Panel();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.lblTraductionFrançais = new System.Windows.Forms.Label();
            this.lblTrad = new System.Windows.Forms.Label();
            this.explicationExercice1 = new System.Windows.Forms.Label();
            this.lblEnonce3 = new System.Windows.Forms.Label();
            this.explicationExercice2 = new System.Windows.Forms.Label();
            this.explicationExercice4 = new System.Windows.Forms.Label();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlExo2 = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlMots = new System.Windows.Forms.Panel();
            this.lblTraduction2 = new System.Windows.Forms.Label();
            this.lblEnonce2 = new System.Windows.Forms.Label();
            this.pnlExo3 = new System.Windows.Forms.Panel();
            this.bpg = new barProgression.barProgression();
            this.pnlExo4 = new System.Windows.Forms.Panel();
            this.lblEnonce4 = new System.Windows.Forms.Label();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlExo1.SuspendLayout();
            this.pnlExo2.SuspendLayout();
            this.pnlExo3.SuspendLayout();
            this.pnlExo4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Chartreuse;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.ForeColor = System.Drawing.Color.Black;
            this.btnValider.Location = new System.Drawing.Point(710, 308);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 33);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.tTip.SetToolTip(this.btnValider, "Valider la proposition");
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAide
            // 
            this.btnAide.BackColor = System.Drawing.Color.DarkGray;
            this.btnAide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAide.FlatAppearance.BorderSize = 0;
            this.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAide.ForeColor = System.Drawing.Color.Black;
            this.btnAide.Location = new System.Drawing.Point(180, 308);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 33);
            this.btnAide.TabIndex = 1;
            this.btnAide.Text = "Indice";
            this.tTip.SetToolTip(this.btnAide, "Donner un indice");
            this.btnAide.UseVisualStyleBackColor = false;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // pnlExo1
            // 
            this.pnlExo1.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlExo1.Controls.Add(this.pnlPhrase);
            this.pnlExo1.Controls.Add(this.lblEnonce);
            this.pnlExo1.Controls.Add(this.lblTraductionFrançais);
            this.pnlExo1.Controls.Add(this.lblTrad);
            this.pnlExo1.Controls.Add(this.explicationExercice1);
            this.pnlExo1.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlExo1.Location = new System.Drawing.Point(46, 19);
            this.pnlExo1.Name = "pnlExo1";
            this.pnlExo1.Size = new System.Drawing.Size(739, 268);
            this.pnlExo1.TabIndex = 2;
            this.pnlExo1.Visible = false;
            // 
            // pnlPhrase
            // 
            this.pnlPhrase.BackColor = System.Drawing.Color.Transparent;
            this.pnlPhrase.Location = new System.Drawing.Point(3, 142);
            this.pnlPhrase.Name = "pnlPhrase";
            this.pnlPhrase.Size = new System.Drawing.Size(670, 102);
            this.pnlPhrase.TabIndex = 3;
            // 
            // lblEnonce
            // 
            this.lblEnonce.BackColor = System.Drawing.Color.Transparent;
            this.lblEnonce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnonce.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonce.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnonce.Location = new System.Drawing.Point(0, 0);
            this.lblEnonce.Name = "lblEnonce";
            this.lblEnonce.Size = new System.Drawing.Size(739, 268);
            this.lblEnonce.TabIndex = 2;
            this.lblEnonce.Text = "Texte";
            this.lblEnonce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTraductionFrançais
            // 
            this.lblTraductionFrançais.AutoSize = true;
            this.lblTraductionFrançais.BackColor = System.Drawing.Color.Transparent;
            this.lblTraductionFrançais.ForeColor = System.Drawing.Color.White;
            this.lblTraductionFrançais.Location = new System.Drawing.Point(227, 104);
            this.lblTraductionFrançais.Name = "lblTraductionFrançais";
            this.lblTraductionFrançais.Size = new System.Drawing.Size(0, 21);
            this.lblTraductionFrançais.TabIndex = 1;
            // 
            // lblTrad
            // 
            this.lblTrad.AutoSize = true;
            this.lblTrad.BackColor = System.Drawing.Color.Transparent;
            this.lblTrad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTrad.Location = new System.Drawing.Point(45, 104);
            this.lblTrad.Name = "lblTrad";
            this.lblTrad.Size = new System.Drawing.Size(182, 21);
            this.lblTrad.TabIndex = 0;
            this.lblTrad.Text = "Traduction de la phrase : ";
            // 
            // explicationExercice1
            // 
            this.explicationExercice1.AutoSize = true;
            this.explicationExercice1.BackColor = System.Drawing.Color.Transparent;
            this.explicationExercice1.ForeColor = System.Drawing.Color.White;
            this.explicationExercice1.Location = new System.Drawing.Point(45, 54);
            this.explicationExercice1.Name = "explicationExercice1";
            this.explicationExercice1.Size = new System.Drawing.Size(579, 21);
            this.explicationExercice1.TabIndex = 4;
            this.explicationExercice1.Text = "Complétez les TextBox avec les mots correspondants à une traduction de la phrase." +
    "";
            // 
            // lblEnonce3
            // 
            this.lblEnonce3.BackColor = System.Drawing.Color.Transparent;
            this.lblEnonce3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnonce3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonce3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnonce3.Location = new System.Drawing.Point(0, 0);
            this.lblEnonce3.Name = "lblEnonce3";
            this.lblEnonce3.Size = new System.Drawing.Size(739, 268);
            this.lblEnonce3.TabIndex = 15;
            this.lblEnonce3.Text = "Texte";
            this.lblEnonce3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // explicationExercice2
            // 
            this.explicationExercice2.AutoSize = true;
            this.explicationExercice2.BackColor = System.Drawing.Color.Transparent;
            this.explicationExercice2.ForeColor = System.Drawing.Color.White;
            this.explicationExercice2.Location = new System.Drawing.Point(45, 54);
            this.explicationExercice2.Name = "explicationExercice2";
            this.explicationExercice2.Size = new System.Drawing.Size(692, 21);
            this.explicationExercice2.TabIndex = 4;
            this.explicationExercice2.Text = "Appuyez sur tout les boutons pour former une phrase, réappuyer sur les Labels pou" +
    "r retirer le mot.";
            // 
            // explicationExercice4
            // 
            this.explicationExercice4.AutoSize = true;
            this.explicationExercice4.BackColor = System.Drawing.Color.Transparent;
            this.explicationExercice4.ForeColor = System.Drawing.Color.White;
            this.explicationExercice4.Location = new System.Drawing.Point(45, 54);
            this.explicationExercice4.Name = "explicationExercice4";
            this.explicationExercice4.Size = new System.Drawing.Size(579, 21);
            this.explicationExercice4.TabIndex = 4;
            this.explicationExercice4.Text = "Complétez les TextBox avec les mots correspondants à une traduction de la phrase." +
    "";
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRecommencer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecommencer.FlatAppearance.BorderSize = 0;
            this.btnRecommencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecommencer.ForeColor = System.Drawing.Color.Black;
            this.btnRecommencer.Location = new System.Drawing.Point(46, 308);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(128, 33);
            this.btnRecommencer.TabIndex = 3;
            this.btnRecommencer.Text = "Recommencer";
            this.tTip.SetToolTip(this.btnRecommencer, "Recommencer l\'exercice actuell");
            this.btnRecommencer.UseVisualStyleBackColor = false;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlExo2
            // 
            this.pnlExo2.BackColor = System.Drawing.Color.Silver;
            this.pnlExo2.Controls.Add(this.pnlButton);
            this.pnlExo2.Controls.Add(this.pnlMots);
            this.pnlExo2.Controls.Add(this.lblTraduction2);
            this.pnlExo2.Controls.Add(this.lblEnonce2);
            this.pnlExo2.Controls.Add(this.explicationExercice2);
            this.pnlExo2.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlExo2.Location = new System.Drawing.Point(46, 19);
            this.pnlExo2.Name = "pnlExo2";
            this.pnlExo2.Size = new System.Drawing.Size(739, 268);
            this.pnlExo2.TabIndex = 5;
            this.pnlExo2.Visible = false;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Location = new System.Drawing.Point(5, 190);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(669, 75);
            this.pnlButton.TabIndex = 3;
            // 
            // pnlMots
            // 
            this.pnlMots.BackColor = System.Drawing.Color.Transparent;
            this.pnlMots.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlMots.Location = new System.Drawing.Point(4, 127);
            this.pnlMots.Name = "pnlMots";
            this.pnlMots.Size = new System.Drawing.Size(670, 85);
            this.pnlMots.TabIndex = 2;
            // 
            // lblTraduction2
            // 
            this.lblTraduction2.AutoSize = true;
            this.lblTraduction2.BackColor = System.Drawing.Color.Transparent;
            this.lblTraduction2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTraduction2.Location = new System.Drawing.Point(45, 104);
            this.lblTraduction2.Name = "lblTraduction2";
            this.lblTraduction2.Size = new System.Drawing.Size(0, 21);
            this.lblTraduction2.TabIndex = 1;
            this.lblTraduction2.Tag = "Test";
            // 
            // lblEnonce2
            // 
            this.lblEnonce2.BackColor = System.Drawing.Color.Transparent;
            this.lblEnonce2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnonce2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonce2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnonce2.Location = new System.Drawing.Point(0, 0);
            this.lblEnonce2.Name = "lblEnonce2";
            this.lblEnonce2.Size = new System.Drawing.Size(739, 268);
            this.lblEnonce2.TabIndex = 0;
            this.lblEnonce2.Tag = "Test";
            this.lblEnonce2.Text = "Texte";
            this.lblEnonce2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlExo3
            // 
            this.pnlExo3.BackColor = System.Drawing.Color.Silver;
            this.pnlExo3.Controls.Add(this.lblEnonce3);
            this.pnlExo3.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlExo3.Location = new System.Drawing.Point(46, 19);
            this.pnlExo3.Name = "pnlExo3";
            this.pnlExo3.Size = new System.Drawing.Size(739, 268);
            this.pnlExo3.TabIndex = 5;
            this.pnlExo3.Visible = false;
            // 
            // bpg
            // 
            this.bpg.BackColor = System.Drawing.Color.Transparent;
            this.bpg.chaineConn = null;
            this.bpg.fail = false;
            this.bpg.Location = new System.Drawing.Point(46, 347);
            this.bpg.MaximumSize = new System.Drawing.Size(2000, 65);
            this.bpg.MinimumSize = new System.Drawing.Size(200, 30);
            this.bpg.Name = "bpg";
            this.bpg.nbrVertDebut = 0;
            this.bpg.next = false;
            this.bpg.numCours = "DEBUT1";
            this.bpg.numLecon = 1;
            this.bpg.refresh = false;
            this.bpg.Size = new System.Drawing.Size(677, 30);
            this.bpg.spawn = false;
            this.bpg.TabIndex = 6;
            // 
            // pnlExo4
            // 
            this.pnlExo4.Controls.Add(this.lblEnonce4);
            this.pnlExo4.Controls.Add(this.explicationExercice4);
            this.pnlExo4.Location = new System.Drawing.Point(46, 19);
            this.pnlExo4.Name = "pnlExo4";
            this.pnlExo4.Size = new System.Drawing.Size(739, 268);
            this.pnlExo4.TabIndex = 7;
            // 
            // lblEnonce4
            // 
            this.lblEnonce4.BackColor = System.Drawing.Color.Transparent;
            this.lblEnonce4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnonce4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonce4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnonce4.Location = new System.Drawing.Point(0, 0);
            this.lblEnonce4.Name = "lblEnonce4";
            this.lblEnonce4.Size = new System.Drawing.Size(739, 268);
            this.lblEnonce4.TabIndex = 0;
            this.lblEnonce4.Text = "label1";
            this.lblEnonce4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmExo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.pnlExo4);
            this.Controls.Add(this.bpg);
            this.Controls.Add(this.pnlExo3);
            this.Controls.Add(this.pnlExo2);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.pnlExo1);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.btnValider);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExo";
            this.Opacity = 0.2D;
            this.Text = "frmExo";
            this.Load += new System.EventHandler(this.frmExo_Load);
            this.pnlExo1.ResumeLayout(false);
            this.pnlExo1.PerformLayout();
            this.pnlExo2.ResumeLayout(false);
            this.pnlExo2.PerformLayout();
            this.pnlExo3.ResumeLayout(false);
            this.pnlExo4.ResumeLayout(false);
            this.pnlExo4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEnonce3;
        private System.Windows.Forms.Label explicationExercice2;
        private System.Windows.Forms.Label explicationExercice4;
        private System.Windows.Forms.Label explicationExercice1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Panel pnlExo1;
        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlExo2;
        private System.Windows.Forms.Panel pnlExo3;
        private System.Windows.Forms.Label lblTraductionFrançais;
        private System.Windows.Forms.Label lblTrad;
        private System.Windows.Forms.Label lblEnonce;
        private System.Windows.Forms.Label lblEnonce2;
        private System.Windows.Forms.Label lblTraduction2;
        private barProgression.barProgression bpg;
        private System.Windows.Forms.Panel pnlMots;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlPhrase;
        private System.Windows.Forms.Panel pnlExo4;
        private System.Windows.Forms.Label lblEnonce4;
        private System.Windows.Forms.ToolTip tTip;
    }
}