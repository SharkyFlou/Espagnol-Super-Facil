
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
            this.pnlMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInscri
            // 
            this.btnInscri.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscri.Location = new System.Drawing.Point(94, 15);
            this.btnInscri.Name = "btnInscri";
            this.btnInscri.Size = new System.Drawing.Size(225, 82);
            this.btnInscri.TabIndex = 0;
            this.btnInscri.Text = "Inscription";
            this.btnInscri.UseVisualStyleBackColor = true;
            // 
            // btnConnec
            // 
            this.btnConnec.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnec.Location = new System.Drawing.Point(94, 103);
            this.btnConnec.Name = "btnConnec";
            this.btnConnec.Size = new System.Drawing.Size(225, 82);
            this.btnConnec.TabIndex = 1;
            this.btnConnec.Text = "Connexion";
            this.btnConnec.UseVisualStyleBackColor = true;
            this.btnConnec.Click += new System.EventHandler(this.btnConnec_Click);
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.btnConnec);
            this.pnlMid.Controls.Add(this.btnInscri);
            this.pnlMid.Location = new System.Drawing.Point(213, 62);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(399, 200);
            this.pnlMid.TabIndex = 2;
            // 
            // frmDema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInscri;
        private System.Windows.Forms.Button btnConnec;
        private System.Windows.Forms.Panel pnlMid;
    }
}