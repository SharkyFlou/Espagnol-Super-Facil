
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAide = new System.Windows.Forms.Button();
            this.pnlExo = new System.Windows.Forms.Panel();
            this.btnRecommencer = new System.Windows.Forms.Button();
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
            // pnlExo
            // 
            this.pnlExo.Location = new System.Drawing.Point(73, 76);
            this.pnlExo.Name = "pnlExo";
            this.pnlExo.Size = new System.Drawing.Size(601, 194);
            this.pnlExo.TabIndex = 2;
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
            // frmExo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.pnlExo);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.btnValider);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExo";
            this.Opacity = 0.2D;
            this.Text = "frmExo";
            this.Load += new System.EventHandler(this.frmExo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Panel pnlExo;
        private System.Windows.Forms.Button btnRecommencer;
    }
}