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

        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\baseLangue.mdb";
        OleDbConnection connec = new OleDbConnection();
        

        private void frmParent_Load(object sender, EventArgs e)
        {
            testConnexion();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnValide_Click(sender, e);
            }
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txtLogin.Text;
                connec.ConnectionString = chcon;
                connec.Open();
                OleDbCommand cd = new OleDbCommand("SELECT ");

            }
            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }
            }
        }

        private void testConnexion()
        {
            try
            {
                connec.ConnectionString = chcon;
                connec.Open();
                MessageBox.Show("Connecté à la BDD");
            }
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de connexion à la base\n" + erreur.Message + "\n" + erreur.GetType());
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



        private void recupExo(int numCours, int numLecon, int numExo)
        {
            try
            {
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = "select textePhrase " +
                                                    "from Phrases " +
                                                    "where codePhrase=" +
                                                                    "(select codePhrase " +
                                                                    "from Exercices e " +
                                                                    "where numExo=" + numExo + "" +
                                                                    "and numLecon=" + numLecon + "" +
                                                                    "and numCours=" + numCours+")";
                OleDbCommand cd = new OleDbCommand(requete,connec);
                cd.CommandType = CommandType.Text;
                string phrase = cd.ExecuteScalar().ToString();
                MessageBox.Show(phrase);
            
            }
            finally
            {
                
            }

        }
    }
}
