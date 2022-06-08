
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
            this.components = new System.ComponentModel.Container();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbCroix = new System.Windows.Forms.PictureBox();
            this.pbRetour = new System.Windows.Forms.PictureBox();
            this.pbMaison = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCroix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaison)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(291, 4);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(237, 37);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Español súper fácil";
            this.tTip.SetToolTip(this.lblTitre, "La mejor aplicación");
            this.lblTitre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseDown);
            this.lblTitre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseMove);
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
            // pnlHaut
            // 
            this.pnlHaut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlHaut.Controls.Add(this.lblUser);
            this.pnlHaut.Controls.Add(this.pbUser);
            this.pnlHaut.Controls.Add(this.pbCroix);
            this.pnlHaut.Controls.Add(this.pbRetour);
            this.pnlHaut.Controls.Add(this.pbMaison);
            this.pnlHaut.Controls.Add(this.panel1);
            this.pnlHaut.Controls.Add(this.lblTitre);
            this.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHaut.ForeColor = System.Drawing.Color.White;
            this.pnlHaut.Location = new System.Drawing.Point(0, 0);
            this.pnlHaut.Name = "pnlHaut";
            this.pnlHaut.Size = new System.Drawing.Size(831, 55);
            this.pnlHaut.TabIndex = 6;
            this.pnlHaut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseDown);
            this.pnlHaut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseMove);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(706, 4);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 20);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Anonyme";
            this.tTip.SetToolTip(this.lblUser, "Votre nom");
            this.lblUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseDown);
            this.lblUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseMove);
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbUser.Location = new System.Drawing.Point(679, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(21, 18);
            this.pbUser.TabIndex = 11;
            this.pbUser.TabStop = false;
            this.tTip.SetToolTip(this.pbUser, "Votre nom");
            this.pbUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseDown);
            this.pbUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHaut_MouseMove);
            // 
            // pbCroix
            // 
            this.pbCroix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCroix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCroix.Location = new System.Drawing.Point(783, 4);
            this.pbCroix.Name = "pbCroix";
            this.pbCroix.Size = new System.Drawing.Size(44, 42);
            this.pbCroix.TabIndex = 10;
            this.pbCroix.TabStop = false;
            this.tTip.SetToolTip(this.pbCroix, "Quitter l\'application :\'(");
            this.pbCroix.Click += new System.EventHandler(this.btnQuitter_Click);
            this.pbCroix.MouseEnter += new System.EventHandler(this.pbCroix_MouseEnter);
            this.pbCroix.MouseLeave += new System.EventHandler(this.pbCroix_MouseLeave);
            // 
            // pbRetour
            // 
            this.pbRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRetour.Location = new System.Drawing.Point(62, 8);
            this.pbRetour.Name = "pbRetour";
            this.pbRetour.Size = new System.Drawing.Size(47, 33);
            this.pbRetour.TabIndex = 9;
            this.pbRetour.TabStop = false;
            this.tTip.SetToolTip(this.pbRetour, "Retour en arrière");
            this.pbRetour.Click += new System.EventHandler(this.pbRetour_Click);
            this.pbRetour.MouseEnter += new System.EventHandler(this.pbRetour_MouseEnter);
            this.pbRetour.MouseLeave += new System.EventHandler(this.pbRetour_MouseLeave);
            // 
            // pbMaison
            // 
            this.pbMaison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMaison.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaison.Location = new System.Drawing.Point(12, 4);
            this.pbMaison.Name = "pbMaison";
            this.pbMaison.Size = new System.Drawing.Size(44, 42);
            this.pbMaison.TabIndex = 8;
            this.pbMaison.TabStop = false;
            this.tTip.SetToolTip(this.pbMaison, "Aller à l\'acceuil");
            this.pbMaison.Click += new System.EventHandler(this.btnMaison_Click);
            this.pbMaison.MouseEnter += new System.EventHandler(this.pbMaison_MouseEnter);
            this.pbMaison.MouseLeave += new System.EventHandler(this.pbMaison_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 10);
            this.panel1.TabIndex = 7;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCroix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCroix;
        private System.Windows.Forms.PictureBox pbRetour;
        private System.Windows.Forms.PictureBox pbMaison;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.ToolTip tTip;
    }
}

