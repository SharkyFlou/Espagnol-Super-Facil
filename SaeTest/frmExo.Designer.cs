
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
            this.lblTraductionFrançais = new System.Windows.Forms.Label();
            this.lblTrad = new System.Windows.Forms.Label();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlExo2 = new System.Windows.Forms.Panel();
            this.pnlExo3 = new System.Windows.Forms.Panel();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.pnlExo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(617, 308);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 33);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(448, 308);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 33);
            this.btnAide.TabIndex = 1;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // pnlExo1
            // 
            this.pnlExo1.BackColor = System.Drawing.Color.White;
            this.pnlExo1.Controls.Add(this.lblEnonce);
            this.pnlExo1.Controls.Add(this.lblTraductionFrançais);
            this.pnlExo1.Controls.Add(this.lblTrad);
            this.pnlExo1.Location = new System.Drawing.Point(73, 100);
            this.pnlExo1.Name = "pnlExo1";
            this.pnlExo1.Size = new System.Drawing.Size(651, 194);
            this.pnlExo1.TabIndex = 2;
            this.pnlExo1.Visible = false;
            // 
            // lblTraductionFrançais
            // 
            this.lblTraductionFrançais.AutoSize = true;
            this.lblTraductionFrançais.ForeColor = System.Drawing.Color.Black;
            this.lblTraductionFrançais.Location = new System.Drawing.Point(206, 79);
            this.lblTraductionFrançais.Name = "lblTraductionFrançais";
            this.lblTraductionFrançais.Size = new System.Drawing.Size(43, 21);
            this.lblTraductionFrançais.TabIndex = 1;
            this.lblTraductionFrançais.Text = "salut";
            // 
            // lblTrad
            // 
            this.lblTrad.AutoSize = true;
            this.lblTrad.ForeColor = System.Drawing.Color.Black;
            this.lblTrad.Location = new System.Drawing.Point(22, 79);
            this.lblTrad.Name = "lblTrad";
            this.lblTrad.Size = new System.Drawing.Size(178, 21);
            this.lblTrad.TabIndex = 0;
            this.lblTrad.Text = "Traduction de la phrase :";
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(279, 308);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(128, 33);
            this.btnRecommencer.TabIndex = 3;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
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
            this.pnlExo2.Location = new System.Drawing.Point(448, 29);
            this.pnlExo2.Name = "pnlExo2";
            this.pnlExo2.Size = new System.Drawing.Size(651, 194);
            this.pnlExo2.TabIndex = 5;
            this.pnlExo2.Visible = false;
            // 
            // pnlExo3
            // 
            this.pnlExo3.BackColor = System.Drawing.Color.Black;
            this.pnlExo3.Location = new System.Drawing.Point(73, 325);
            this.pnlExo3.Name = "pnlExo3";
            this.pnlExo3.Size = new System.Drawing.Size(651, 194);
            this.pnlExo3.TabIndex = 5;
            this.pnlExo3.Visible = false;
            // 
            // lblEnonce
            // 
            this.lblEnonce.AutoSize = true;
            this.lblEnonce.ForeColor = System.Drawing.Color.Black;
            this.lblEnonce.Location = new System.Drawing.Point(131, 30);
            this.lblEnonce.Name = "lblEnonce";
            this.lblEnonce.Size = new System.Drawing.Size(44, 21);
            this.lblEnonce.TabIndex = 2;
            this.lblEnonce.Text = "Texte";
            // 
            // frmExo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.pnlExo2);
            this.Controls.Add(this.pnlExo3);
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
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}