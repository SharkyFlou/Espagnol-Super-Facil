
namespace SaeTest
{
    partial class frmBilan
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
            this.btnTélécharger = new System.Windows.Forms.Button();
            this.pnlFaux = new System.Windows.Forms.Panel();
            this.pnlJuste = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTélécharger
            // 
            this.btnTélécharger.Location = new System.Drawing.Point(658, 340);
            this.btnTélécharger.Name = "btnTélécharger";
            this.btnTélécharger.Size = new System.Drawing.Size(102, 30);
            this.btnTélécharger.TabIndex = 2;
            this.btnTélécharger.Text = "Télécharger";
            this.btnTélécharger.UseVisualStyleBackColor = true;
            this.btnTélécharger.Click += new System.EventHandler(this.btnTélécharger_Click);
            // 
            // pnlFaux
            // 
            this.pnlFaux.AutoScroll = true;
            this.pnlFaux.Location = new System.Drawing.Point(400, 12);
            this.pnlFaux.Name = "pnlFaux";
            this.pnlFaux.Size = new System.Drawing.Size(360, 320);
            this.pnlFaux.TabIndex = 1;
            this.pnlFaux.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFaux_MouseDown);
            // 
            // pnlJuste
            // 
            this.pnlJuste.AutoScroll = true;
            this.pnlJuste.Location = new System.Drawing.Point(12, 12);
            this.pnlJuste.Name = "pnlJuste";
            this.pnlJuste.Size = new System.Drawing.Size(360, 320);
            this.pnlJuste.TabIndex = 0;
            // 
            // frmBilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.pnlFaux);
            this.Controls.Add(this.pnlJuste);
            this.Controls.Add(this.btnTélécharger);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBilan";
            this.Text = "frmBilan";
            this.Load += new System.EventHandler(this.frmBilan_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTélécharger;
        private System.Windows.Forms.Panel pnlFaux;
        private System.Windows.Forms.Panel pnlJuste;
    }
}