
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
            this.pnlMid = new System.Windows.Forms.Panel();
            this.btnRajUser = new System.Windows.Forms.Button();
            this.btnVoirExo = new System.Windows.Forms.Button();
            this.lnlTitre = new System.Windows.Forms.Label();
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.pnlMid.SuspendLayout();
            this.pnlHaut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.btnRajUser);
            this.pnlMid.Controls.Add(this.btnVoirExo);
            this.pnlMid.Location = new System.Drawing.Point(250, 95);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(368, 220);
            this.pnlMid.TabIndex = 0;
            // 
            // btnRajUser
            // 
            this.btnRajUser.ForeColor = System.Drawing.Color.Black;
            this.btnRajUser.Location = new System.Drawing.Point(81, 117);
            this.btnRajUser.Name = "btnRajUser";
            this.btnRajUser.Size = new System.Drawing.Size(204, 82);
            this.btnRajUser.TabIndex = 1;
            this.btnRajUser.Text = "Rajouter/modifier les utilisateurs";
            this.btnRajUser.UseVisualStyleBackColor = true;
            this.btnRajUser.Click += new System.EventHandler(this.btnRajUser_Click);
            // 
            // btnVoirExo
            // 
            this.btnVoirExo.ForeColor = System.Drawing.Color.Black;
            this.btnVoirExo.Location = new System.Drawing.Point(87, 23);
            this.btnVoirExo.Name = "btnVoirExo";
            this.btnVoirExo.Size = new System.Drawing.Size(191, 70);
            this.btnVoirExo.TabIndex = 0;
            this.btnVoirExo.Text = "Voir les exercices";
            this.btnVoirExo.UseVisualStyleBackColor = true;
            this.btnVoirExo.Click += new System.EventHandler(this.btnVoirExo_Click);
            // 
            // lnlTitre
            // 
            this.lnlTitre.AutoSize = true;
            this.lnlTitre.BackColor = System.Drawing.Color.Transparent;
            this.lnlTitre.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlTitre.ForeColor = System.Drawing.Color.White;
            this.lnlTitre.Location = new System.Drawing.Point(16, 12);
            this.lnlTitre.Name = "lnlTitre";
            this.lnlTitre.Size = new System.Drawing.Size(361, 32);
            this.lnlTitre.TabIndex = 1;
            this.lnlTitre.Text = "Bienvenu dans l\'interface Admin";
            // 
            // pnlHaut
            // 
            this.pnlHaut.Controls.Add(this.lnlTitre);
            this.pnlHaut.Location = new System.Drawing.Point(241, 20);
            this.pnlHaut.Name = "pnlHaut";
            this.pnlHaut.Size = new System.Drawing.Size(389, 60);
            this.pnlHaut.TabIndex = 2;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.pnlHaut);
            this.Controls.Add(this.pnlMid);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.pnlMid.ResumeLayout(false);
            this.pnlHaut.ResumeLayout(false);
            this.pnlHaut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Button btnRajUser;
        private System.Windows.Forms.Button btnVoirExo;
        private System.Windows.Forms.Label lnlTitre;
        private System.Windows.Forms.Panel pnlHaut;
    }
}