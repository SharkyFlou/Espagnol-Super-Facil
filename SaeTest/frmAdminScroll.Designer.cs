
namespace SaeTest
{
    partial class frmAdminScroll
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
            this.pnlMid = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnArriere = new System.Windows.Forms.Button();
            this.btnDebut = new System.Windows.Forms.Button();
            this.btnAvant = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.lblLecon = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.cboLecon = new System.Windows.Forms.ComboBox();
            this.cboCours = new System.Windows.Forms.ComboBox();
            this.barProgression1 = new barProgression.barProgression();
            this.pnlMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.lblTitre);
            this.pnlMid.Controls.Add(this.btnArriere);
            this.pnlMid.Controls.Add(this.btnDebut);
            this.pnlMid.Controls.Add(this.btnAvant);
            this.pnlMid.Controls.Add(this.btnFin);
            this.pnlMid.Controls.Add(this.lblLecon);
            this.pnlMid.Controls.Add(this.lblCours);
            this.pnlMid.Controls.Add(this.cboLecon);
            this.pnlMid.Controls.Add(this.cboCours);
            this.pnlMid.Location = new System.Drawing.Point(12, 12);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(807, 307);
            this.pnlMid.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitre.Location = new System.Drawing.Point(344, 85);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(54, 30);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Titre";
            // 
            // btnArriere
            // 
            this.btnArriere.BackColor = System.Drawing.Color.Transparent;
            this.btnArriere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArriere.ForeColor = System.Drawing.Color.Transparent;
            this.btnArriere.Location = new System.Drawing.Point(69, 274);
            this.btnArriere.Name = "btnArriere";
            this.btnArriere.Size = new System.Drawing.Size(40, 30);
            this.btnArriere.TabIndex = 7;
            this.btnArriere.UseVisualStyleBackColor = false;
            // 
            // btnDebut
            // 
            this.btnDebut.BackColor = System.Drawing.Color.Transparent;
            this.btnDebut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDebut.ForeColor = System.Drawing.Color.Transparent;
            this.btnDebut.Location = new System.Drawing.Point(3, 274);
            this.btnDebut.Name = "btnDebut";
            this.btnDebut.Size = new System.Drawing.Size(60, 30);
            this.btnDebut.TabIndex = 6;
            this.btnDebut.UseVisualStyleBackColor = false;
            // 
            // btnAvant
            // 
            this.btnAvant.BackColor = System.Drawing.Color.Transparent;
            this.btnAvant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvant.ForeColor = System.Drawing.Color.Transparent;
            this.btnAvant.Location = new System.Drawing.Point(698, 274);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(40, 30);
            this.btnAvant.TabIndex = 5;
            this.btnAvant.UseVisualStyleBackColor = false;
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.Color.Transparent;
            this.btnFin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFin.ForeColor = System.Drawing.Color.Transparent;
            this.btnFin.Location = new System.Drawing.Point(744, 274);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(60, 30);
            this.btnFin.TabIndex = 4;
            this.btnFin.UseVisualStyleBackColor = false;
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblLecon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLecon.Location = new System.Drawing.Point(451, 34);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(58, 21);
            this.lblLecon.TabIndex = 3;
            this.lblLecon.Text = "Leçon :";
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCours.Location = new System.Drawing.Point(16, 34);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(58, 21);
            this.lblCours.TabIndex = 2;
            this.lblCours.Text = "Cours :";
            // 
            // cboLecon
            // 
            this.cboLecon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLecon.FormattingEnabled = true;
            this.cboLecon.Location = new System.Drawing.Point(509, 31);
            this.cboLecon.Name = "cboLecon";
            this.cboLecon.Size = new System.Drawing.Size(295, 29);
            this.cboLecon.TabIndex = 1;
            this.cboLecon.SelectionChangeCommitted += new System.EventHandler(this.cboLecon_SelectionChangeCommitted);
            // 
            // cboCours
            // 
            this.cboCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCours.FormattingEnabled = true;
            this.cboCours.Location = new System.Drawing.Point(84, 31);
            this.cboCours.Name = "cboCours";
            this.cboCours.Size = new System.Drawing.Size(257, 29);
            this.cboCours.TabIndex = 0;
            this.cboCours.SelectionChangeCommitted += new System.EventHandler(this.cboCours_SelectionChangeCommitted);
            // 
            // barProgression1
            // 
            this.barProgression1.BackColor = System.Drawing.Color.Transparent;
            this.barProgression1.chaineConn = null;
            this.barProgression1.fail = false;
            this.barProgression1.Location = new System.Drawing.Point(96, 325);
            this.barProgression1.MaximumSize = new System.Drawing.Size(2000, 65);
            this.barProgression1.MinimumSize = new System.Drawing.Size(200, 30);
            this.barProgression1.Name = "barProgression1";
            this.barProgression1.next = false;
            this.barProgression1.numCours = "DEBUT1";
            this.barProgression1.numLecon = 1;
            this.barProgression1.refresh = false;
            this.barProgression1.Size = new System.Drawing.Size(658, 38);
            this.barProgression1.spawn = false;
            this.barProgression1.TabIndex = 1;
            // 
            // frmAdminScroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.barProgression1);
            this.Controls.Add(this.pnlMid);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminScroll";
            this.Text = "frmAdminScroll";
            this.Load += new System.EventHandler(this.frmAdminScroll_Load);
            this.pnlMid.ResumeLayout(false);
            this.pnlMid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMid;
        private barProgression.barProgression barProgression1;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.ComboBox cboLecon;
        private System.Windows.Forms.ComboBox cboCours;
        private System.Windows.Forms.Button btnArriere;
        private System.Windows.Forms.Button btnDebut;
        private System.Windows.Forms.Button btnAvant;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label lblTitre;
    }
}