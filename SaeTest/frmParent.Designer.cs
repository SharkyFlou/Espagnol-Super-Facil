﻿
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
            this.btnVersEnfant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.Location = new System.Drawing.Point(391, 64);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(35, 17);
            this.lblYes.TabIndex = 0;
            this.lblYes.Text = "Yes !";
            // 
            // btnVersEnfant
            // 
            this.btnVersEnfant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVersEnfant.Location = new System.Drawing.Point(260, 147);
            this.btnVersEnfant.Name = "btnVersEnfant";
            this.btnVersEnfant.Size = new System.Drawing.Size(321, 150);
            this.btnVersEnfant.TabIndex = 1;
            this.btnVersEnfant.Text = "Appel enfant";
            this.btnVersEnfant.UseVisualStyleBackColor = true;
            this.btnVersEnfant.Click += new System.EventHandler(this.btnVersEnfant_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 427);
            this.Controls.Add(this.btnVersEnfant);
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
        private System.Windows.Forms.Button btnVersEnfant;
    }
}

