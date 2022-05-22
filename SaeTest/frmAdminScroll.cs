using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SaeTest
{
    public partial class frmAdminScroll : Form
    {
        public frmAdminScroll()
        {
            InitializeComponent();
            instance = this;
            
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperAdmin.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlMid.BackColor = Color.FromArgb(150, 0, 0, 0);
            chargementImage("Blanc");
        }
        public static frmAdminScroll instance;

        string chcon;
        OleDbConnection connec = new OleDbConnection();
        DataSet dsLocal = new DataSet();
        List<int> numLeconActu = new List<int>();

        public void chargementImage(String blanc)
        {
            btnArriere.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\arr"+blanc+"Logo.png"));
            btnArriere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            btnAvant.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\avant" + blanc + "Logo.png"));
            btnAvant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            btnDebut.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipArr" + blanc + "Logo.png"));
            btnDebut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            btnFin.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipAvant" + blanc + "Logo.png"));
            btnFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }


        private void chargementDsLocal()
        {
            try
            {
                connec.Open();

                DataTable schemaTable = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                connec.Close();

                string nomTable;
                string requete;
                foreach (DataRow ligne in schemaTable.Rows)
                {
                    nomTable = ligne[2].ToString();
                    requete = "select * from " + nomTable;

                    OleDbCommand cd = new OleDbCommand(requete, connec);
                    OleDbDataAdapter da = new OleDbDataAdapter(cd);
                    da.Fill(dsLocal, nomTable);
                }
            }
            //intercepetion et affichage de l'erreur si occurence
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message + "\n\n" + "Nom erreur : '" + erreur.GetType() + "'");
            }
            //fermeture du OledBConnection dans tout les cas
            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }
            }

        }

        private void frmAdminScroll_Load(object sender, EventArgs e)
        {
            connec.ConnectionString = frmParent.instance.getLienBase();
            chargementDsLocal();
            cboCours.DataSource = dsLocal.Tables["Cours"];
            cboCours.DisplayMember = "titreCours";
            cboCours.ValueMember = "numCours";
        }

        private void cboCours_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                numLeconActu.Clear();
                cboLecon.Items.Clear();
                DataRow[] ligneActu = dsLocal.Tables["Lecons"].Select("numCours='" + cboCours.SelectedValue.ToString() + "'");
                foreach(DataRow dr in ligneActu)
                {
                    cboLecon.Items.Add(dr["titreLecon"]);
                    numLeconActu.Add((int)dr["numLecon"]);
                }
                if (cboLecon.Items.Count > 0)
                {
                    cboLecon.SelectedIndex = 0;
                }
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message + "\n\n" + "Nom erreur : '" + erreur.GetType() + "'");
            }
        }

        private void cboLecon_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("Titre : " + cboLecon.SelectedItem + "\nNum :" + numLeconActu[cboLecon.SelectedIndex]);
        }
    }
}
