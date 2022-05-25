
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.pnlGauche = new System.Windows.Forms.Panel();
            this.pnlDroit = new System.Windows.Forms.Panel();
            this.pnlGauche.SuspendLayout();
            this.pnlDroit.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboUtil
            // 
            this.cboUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUtil.ForeColor = System.Drawing.Color.Black;
            this.cboUtil.FormattingEnabled = true;
            this.cboUtil.Location = new System.Drawing.Point(7, 49);
            this.cboUtil.Name = "cboUtil";
            this.cboUtil.Size = new System.Drawing.Size(339, 29);
            this.cboUtil.TabIndex = 0;
            this.cboUtil.SelectionChangeCommitted += new System.EventHandler(this.cboUtil_SelectionChangeCommitted);
            // 
            // cboLecon
            // 
            this.cboLecon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLecon.ForeColor = System.Drawing.Color.Black;
            this.cboLecon.FormattingEnabled = true;
            this.cboLecon.Location = new System.Drawing.Point(7, 180);
            this.cboLecon.Name = "cboLecon";
            this.cboLecon.Size = new System.Drawing.Size(339, 29);
            this.cboLecon.TabIndex = 2;
            this.cboLecon.SelectionChangeCommitted += new System.EventHandler(this.cboLecon_SelectionChangeCommitted);
            // 
            // cboCours
            // 
            this.cboCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCours.ForeColor = System.Drawing.Color.Black;
            this.cboCours.FormattingEnabled = true;
            this.cboCours.Location = new System.Drawing.Point(7, 115);
            this.cboCours.Name = "cboCours";
            this.cboCours.Size = new System.Drawing.Size(339, 29);
            this.cboCours.TabIndex = 3;
            this.cboCours.SelectionChangeCommitted += new System.EventHandler(this.cboCours_SelectionChangeCommitted);
            // 
            // cboExo
            // 
            this.cboExo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExo.ForeColor = System.Drawing.Color.Black;
            this.cboExo.FormattingEnabled = true;
            this.cboExo.Location = new System.Drawing.Point(7, 254);
            this.cboExo.Name = "cboExo";
            this.cboExo.Size = new System.Drawing.Size(339, 29);
            this.cboExo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modifier un utilisateur inscrit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Exercices";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Leçon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cours";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(7, 297);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 50);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.Black;
            this.btnValider.Location = new System.Drawing.Point(222, 297);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(124, 50);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.button2_Click);
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
            this.pnlDroit.Controls.Add(this.label1);
            this.pnlDroit.Controls.Add(this.cboUtil);
            this.pnlDroit.Controls.Add(this.btnValider);
            this.pnlDroit.Controls.Add(this.cboCours);
            this.pnlDroit.Controls.Add(this.btnReset);
            this.pnlDroit.Controls.Add(this.label5);
            this.pnlDroit.Controls.Add(this.label3);
            this.pnlDroit.Controls.Add(this.label4);
            this.pnlDroit.Controls.Add(this.cboExo);
            this.pnlDroit.Controls.Add(this.cboLecon);
            this.pnlDroit.Location = new System.Drawing.Point(412, 12);
            this.pnlDroit.Name = "pnlDroit";
            this.pnlDroit.Size = new System.Drawing.Size(370, 350);
            this.pnlDroit.TabIndex = 13;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel pnlGauche;
        private System.Windows.Forms.Panel pnlDroit;
    }
}