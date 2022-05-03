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
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\charl\OneDrive\Bureau\Charly\Cours\BUT S2\saeTest\SaeTest\SaeTest\baseLangue.mdb";
        OleDbConnection connec = new OleDbConnection();


        private void btnVersEnfant_Click(object sender, EventArgs e)
        {
            frmEnfant feuille = new frmEnfant();
            if (feuille.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Tu as cliqué sur quitter", "mmh");
            }
            else
            {
                MessageBox.Show("Tu as cliqué sur la croix, ou tu as Alt+F4","mmh");
            }
        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            try
            {
                connec.ConnectionString = chcon;
                connec.Open();
                MessageBox.Show("Connecté à la BDD");
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de connexion à la base\n"+ erreur.Message+"\n"+ erreur.GetType());
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL" + erreur.Message + "\n" + erreur.GetType());
            }
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message + "\n\n" + "Nom erreur : '" + erreur.GetType() + "'");
            }
            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }
            }
        }
    }
}
