
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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaison = new System.Windows.Forms.Button();
            this.pnlHaut.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.Location = new System.Drawing.Point(291, 4);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(237, 37);
            this.lblYes.TabIndex = 0;
            this.lblYes.Text = "Español súper fácil";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlForm.Location = new System.Drawing.Point(0, 52);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(831, 375);
            this.pnlForm.TabIndex = 4;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitter.Location = new System.Drawing.Point(787, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(41, 38);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pnlHaut
            // 
            this.pnlHaut.BackColor = System.Drawing.Color.Transparent;
            this.pnlHaut.Controls.Add(this.btnMaison);
            this.pnlHaut.Controls.Add(this.panel1);
            this.pnlHaut.Controls.Add(this.btnQuitter);
            this.pnlHaut.Controls.Add(this.lblYes);
            this.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHaut.Location = new System.Drawing.Point(0, 0);
            this.pnlHaut.Name = "pnlHaut";
            this.pnlHaut.Size = new System.Drawing.Size(831, 55);
            this.pnlHaut.TabIndex = 6;
            this.pnlHaut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseDown);
            this.pnlHaut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 10);
            this.panel1.TabIndex = 7;
            // 
            // btnMaison
            // 
            this.btnMaison.BackColor = System.Drawing.Color.Transparent;
            this.btnMaison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaison.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaison.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaison.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaison.Location = new System.Drawing.Point(3, 3);
            this.btnMaison.Name = "btnMaison";
            this.btnMaison.Size = new System.Drawing.Size(40, 40);
            this.btnMaison.TabIndex = 8;
            this.btnMaison.UseVisualStyleBackColor = false;
            this.btnMaison.Click += new System.EventHandler(this.btnMaison_Click);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 427);
            this.Controls.Add(this.pnlHaut);
            this.Controls.Add(this.pnlForm);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanguy renome ça";
            this.Load += new System.EventHandler(this.frmParent_Load);
            this.pnlHaut.ResumeLayout(false);
            this.pnlHaut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMaison;
    }
}

