
namespace SaeTest
{
    partial class frmDema
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
            this.btnInscri = new System.Windows.Forms.Button();
            this.btnConnec = new System.Windows.Forms.Button();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInscri
            // 
            this.btnInscri.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscri.Location = new System.Drawing.Point(84, 211);
            this.btnInscri.Name = "btnInscri";
            this.btnInscri.Size = new System.Drawing.Size(225, 82);
            this.btnInscri.TabIndex = 0;
            this.btnInscri.Text = "Registro";
            this.btnInscri.UseVisualStyleBackColor = true;
            this.btnInscri.Click += new System.EventHandler(this.btnInscri_Click);
            // 
            // btnConnec
            // 
            this.btnConnec.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnec.Location = new System.Drawing.Point(84, 123);
            this.btnConnec.Name = "btnConnec";
            this.btnConnec.Size = new System.Drawing.Size(225, 82);
            this.btnConnec.TabIndex = 1;
            this.btnConnec.Text = "Conexión";
            this.btnConnec.UseVisualStyleBackColor = true;
            this.btnConnec.Click += new System.EventHandler(this.btnConnec_Click);
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.lblTitre);
            this.pnlMid.Controls.Add(this.btnConnec);
            this.pnlMid.Controls.Add(this.btnInscri);
            this.pnlMid.Location = new System.Drawing.Point(213, 24);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(399, 305);
            this.pnlMid.TabIndex = 2;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(97, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(203, 50);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Bienvenido";
            // 
            // frmDema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.pnlMid);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDema";
            this.Opacity = 0.5D;
            this.Text = "frmDema";
            this.pnlMid.ResumeLayout(false);
            this.pnlMid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInscri;
        private System.Windows.Forms.Button btnConnec;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Label lblTitre;
    }
}