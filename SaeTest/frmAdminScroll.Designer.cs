
namespace SaeTest
{
    partial class frmAdminScroll
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
            this.pnlMid = new System.Windows.Forms.Panel();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.exercicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseLangueDataSet = new SaeTest.baseLangueDataSet();
            this.lblCorr = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnArriere = new System.Windows.Forms.Button();
            this.btnDebut = new System.Windows.Forms.Button();
            this.btnAvant = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.trwExos = new System.Windows.Forms.TreeView();
            this.exercicesTableAdapter = new SaeTest.baseLangueDataSetTableAdapters.ExercicesTableAdapter();
            this.pnlMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLangueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.lblPhrase);
            this.pnlMid.Controls.Add(this.lblCorr);
            this.pnlMid.Controls.Add(this.lblTitre);
            this.pnlMid.Controls.Add(this.btnArriere);
            this.pnlMid.Controls.Add(this.btnDebut);
            this.pnlMid.Controls.Add(this.btnAvant);
            this.pnlMid.Controls.Add(this.btnFin);
            this.pnlMid.Location = new System.Drawing.Point(283, 12);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(536, 351);
            this.pnlMid.TabIndex = 0;
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.BackColor = System.Drawing.Color.Transparent;
            this.lblPhrase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exercicesBindingSource, "enonceExo", true));
            this.lblPhrase.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPhrase.Location = new System.Drawing.Point(206, 108);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(75, 30);
            this.lblPhrase.TabIndex = 10;
            this.lblPhrase.Text = "Phrase";
            // 
            // exercicesBindingSource
            // 
            this.exercicesBindingSource.DataMember = "Exercices";
            this.exercicesBindingSource.DataSource = this.baseLangueDataSet;
            // 
            // baseLangueDataSet
            // 
            this.baseLangueDataSet.DataSetName = "baseLangueDataSet";
            this.baseLangueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCorr
            // 
            this.lblCorr.AutoSize = true;
            this.lblCorr.BackColor = System.Drawing.Color.Transparent;
            this.lblCorr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exercicesBindingSource, "enonceExo", true));
            this.lblCorr.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCorr.Location = new System.Drawing.Point(206, 182);
            this.lblCorr.Name = "lblCorr";
            this.lblCorr.Size = new System.Drawing.Size(80, 30);
            this.lblCorr.TabIndex = 9;
            this.lblCorr.Text = "Corrige";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exercicesBindingSource, "enonceExo", true));
            this.lblTitre.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitre.Location = new System.Drawing.Point(205, 33);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(63, 32);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Titre";
            // 
            // btnArriere
            // 
            this.btnArriere.BackColor = System.Drawing.Color.Transparent;
            this.btnArriere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArriere.ForeColor = System.Drawing.Color.Transparent;
            this.btnArriere.Location = new System.Drawing.Point(69, 318);
            this.btnArriere.Name = "btnArriere";
            this.btnArriere.Size = new System.Drawing.Size(40, 30);
            this.btnArriere.TabIndex = 7;
            this.btnArriere.UseVisualStyleBackColor = false;
            this.btnArriere.Click += new System.EventHandler(this.btnArriere_Click);
            // 
            // btnDebut
            // 
            this.btnDebut.BackColor = System.Drawing.Color.Transparent;
            this.btnDebut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDebut.ForeColor = System.Drawing.Color.Transparent;
            this.btnDebut.Location = new System.Drawing.Point(3, 318);
            this.btnDebut.Name = "btnDebut";
            this.btnDebut.Size = new System.Drawing.Size(60, 30);
            this.btnDebut.TabIndex = 6;
            this.btnDebut.UseVisualStyleBackColor = false;
            this.btnDebut.Click += new System.EventHandler(this.btnDebut_Click);
            // 
            // btnAvant
            // 
            this.btnAvant.BackColor = System.Drawing.Color.Transparent;
            this.btnAvant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvant.ForeColor = System.Drawing.Color.Transparent;
            this.btnAvant.Location = new System.Drawing.Point(427, 318);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(40, 30);
            this.btnAvant.TabIndex = 5;
            this.btnAvant.UseVisualStyleBackColor = false;
            this.btnAvant.Click += new System.EventHandler(this.btnAvant_Click);
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.Color.Transparent;
            this.btnFin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFin.ForeColor = System.Drawing.Color.Transparent;
            this.btnFin.Location = new System.Drawing.Point(473, 318);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(60, 30);
            this.btnFin.TabIndex = 4;
            this.btnFin.UseVisualStyleBackColor = false;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // trwExos
            // 
            this.trwExos.BackColor = System.Drawing.Color.DimGray;
            this.trwExos.Location = new System.Drawing.Point(12, 12);
            this.trwExos.Name = "trwExos";
            this.trwExos.Size = new System.Drawing.Size(265, 351);
            this.trwExos.TabIndex = 1;
            this.trwExos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trwExos_AfterSelect);
            // 
            // exercicesTableAdapter
            // 
            this.exercicesTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdminScroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.trwExos);
            this.Controls.Add(this.pnlMid);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminScroll";
            this.Text = "frmAdminScroll";
            this.Load += new System.EventHandler(this.frmAdminScroll_Load);
            this.pnlMid.ResumeLayout(false);
            this.pnlMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLangueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Button btnArriere;
        private System.Windows.Forms.Button btnDebut;
        private System.Windows.Forms.Button btnAvant;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TreeView trwExos;
        private baseLangueDataSet baseLangueDataSet;
        private System.Windows.Forms.BindingSource exercicesBindingSource;
        private baseLangueDataSetTableAdapters.ExercicesTableAdapter exercicesTableAdapter;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Label lblCorr;
    }
}