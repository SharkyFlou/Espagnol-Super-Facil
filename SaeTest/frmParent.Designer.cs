
namespace SaeTest
{
    partial class frmParent
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblYes = new System.Windows.Forms.Label();
            this.btnValide = new System.Windows.Forms.Button();
            this.cboLogin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.Location = new System.Drawing.Point(294, 9);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(247, 38);
            this.lblYes.TabIndex = 0;
            this.lblYes.Text = "Español súper fácil";
            // 
            // btnValide
            // 
            this.btnValide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValide.Location = new System.Drawing.Point(484, 116);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(134, 33);
            this.btnValide.TabIndex = 2;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // cboLogin
            // 
            this.cboLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLogin.FormattingEnabled = true;
            this.cboLogin.Location = new System.Drawing.Point(269, 116);
            this.cboLogin.Name = "cboLogin";
            this.cboLogin.Size = new System.Drawing.Size(195, 36);
            this.cboLogin.TabIndex = 3;
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 427);
            this.Controls.Add(this.cboLogin);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.lblYes);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmParent";
            this.Text = "Tanguy renome ça";
            this.Load += new System.EventHandler(this.frmParent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.ComboBox cboLogin;
    }
}

