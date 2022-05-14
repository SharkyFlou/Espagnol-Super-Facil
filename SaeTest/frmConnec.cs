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
    public partial class frmConnec : Form
    {

        public frmConnec()
        {
            InitializeComponent();
            chcon = frmParent.instance.getLienBase();
            instance = this;
        }

        //pour permettre aux autres form d'utiliser les fonctions du frmDema
        public static frmConnec instance;


        //Initialise la chaine de connexion global, et un OleDbConnection global aussi
        string chcon;
        OleDbConnection connec = new OleDbConnection();

        public void frmConnec_Load(object sender, EventArgs e)
        {
            //vérifie d'abord si l'application peut se connecter à la BDD
            if (frmParent.instance.testConnexion(chcon, connec))
            {
                chargeLogin();
            }
        }

        private void chargeLogin()
        {
            try
            {
                //connection à la BDD
                connec.ConnectionString = chcon;
                connec.Open();

                string requete = "SELECT (pnUtil +' '+ nomUtil) " +
                                                            "FROM Utilisateurs " +
                                                            "ORDER BY codeUtil";
                OleDbCommand comm = new OleDbCommand(requete, connec);
                OleDbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cboLogin.Items.Add(reader[0].ToString());
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


        private void btnValide_Click(object sender, EventArgs e)
        {
            try
            {
                string login = cboLogin.Text;
                connec.ConnectionString = chcon;
                // connec.Open();
                OleDbCommand cd = new OleDbCommand("SELECT ");
                string numCours = "DEBUT1";
                int numLecon = 4;
                int numExo = 1;
                recupExo(numCours, numLecon, numExo);

            }
            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }
            }
        }
        private void recupExo(string numCours, int numLecon, int numExo)
        {
            try
            {
                connec.ConnectionString = chcon;
                connec.Open();
                string requeteCode = "select codePhrase" +
                                    " from Exercices " +
                                     "where numExo=" + numExo +
                                     " and numCours='" + numCours + "'" +
                                     " and numLecon=" + numLecon + ";";

                OleDbCommand cd = new OleDbCommand(requeteCode, connec);
                cd.CommandType = CommandType.Text;

                int numéroPhrase = (int)cd.ExecuteScalar();
                MessageBox.Show(numéroPhrase.ToString());

                if (numéroPhrase != 0)
                {
                    string requeteComplete = "select completeON from Exercices where codePhrase=" + numéroPhrase + ";";

                    OleDbCommand cdd = new OleDbCommand(requeteComplete, connec);
                    cdd.CommandType = CommandType.Text;

                    bool Complete = (bool)cdd.ExecuteScalar();
                    MessageBox.Show(Complete.ToString());

                    if (!Complete)
                    {
                        //string requete
                    }
                    else
                    {
                        string requetePhrase = "select textePhrase " +
                                               "from Phrases " +
                                               "where codePhrase=" + numéroPhrase + ";";

                        OleDbCommand cddd = new OleDbCommand(requetePhrase, connec);
                        cddd.CommandType = CommandType.Text;

                        string phrase = cddd.ExecuteScalar().ToString();
                        MessageBox.Show(phrase);
                    }
                }


            }
            finally
            {

            }

        }

    }
}
