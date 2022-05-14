
namespace SaeTest
{
    partial class frmConnec
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
            this.cboLogin = new System.Windows.Forms.ComboBox();
            this.btnValide = new System.Windows.Forms.Button();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pnlMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboLogin
            // 
            this.cboLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLogin.FormattingEnabled = true;
            this.cboLogin.Location = new System.Drawing.Point(46, 98);
            this.cboLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLogin.Name = "cboLogin";
            this.cboLogin.Size = new System.Drawing.Size(237, 32);
            this.cboLogin.TabIndex = 4;
            // 
            // btnValide
            // 
            this.btnValide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValide.Location = new System.Drawing.Point(331, 96);
            this.btnValide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(163, 35);
            this.btnValide.TabIndex = 5;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.btnValide);
            this.pnlMid.Controls.Add(this.cboLogin);
            this.pnlMid.Location = new System.Drawing.Point(146, 62);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(566, 259);
            this.pnlMid.TabIndex = 6;
            // 
            // frmConnec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.pnlMid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConnec";
            this.Opacity = 0.2D;
            this.Text = "frmConnec";
            this.Load += new System.EventHandler(this.frmConnec_Load);
            this.pnlMid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLogin;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Panel pnlMid;
    }
}