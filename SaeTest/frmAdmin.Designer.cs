
namespace SaeTest
{
    partial class frmAdmin
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
            this.pnlMid = new System.Windows.Forms.Panel();
            this.btnVoirExo = new System.Windows.Forms.Button();
            this.btnRajUser = new System.Windows.Forms.Button();
            this.pnlMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.btnRajUser);
            this.pnlMid.Controls.Add(this.btnVoirExo);
            this.pnlMid.Location = new System.Drawing.Point(174, 70);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(489, 220);
            this.pnlMid.TabIndex = 0;
            // 
            // btnVoirExo
            // 
            this.btnVoirExo.ForeColor = System.Drawing.Color.Black;
            this.btnVoirExo.Location = new System.Drawing.Point(150, 29);
            this.btnVoirExo.Name = "btnVoirExo";
            this.btnVoirExo.Size = new System.Drawing.Size(191, 70);
            this.btnVoirExo.TabIndex = 0;
            this.btnVoirExo.Text = "Voir les exos";
            this.btnVoirExo.UseVisualStyleBackColor = true;
            this.btnVoirExo.Click += new System.EventHandler(this.btnVoirExo_Click);
            // 
            // btnRajUser
            // 
            this.btnRajUser.ForeColor = System.Drawing.Color.Black;
            this.btnRajUser.Location = new System.Drawing.Point(150, 118);
            this.btnRajUser.Name = "btnRajUser";
            this.btnRajUser.Size = new System.Drawing.Size(191, 82);
            this.btnRajUser.TabIndex = 1;
            this.btnRajUser.Text = "Rajouter des utilisateurs";
            this.btnRajUser.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.pnlMid);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.pnlMid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Button btnRajUser;
        private System.Windows.Forms.Button btnVoirExo;
    }
}