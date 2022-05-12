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

        //Initialise la chaine de connexion global, et un OleDbConnection global aussi
        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\baseLangue.mdb";
        OleDbConnection connec = new OleDbConnection();
        

        private void frmParent_Load(object sender, EventArgs e)
        {
            //vérifie d'abord si l'application peut se connecter à la BDD
            if (testConnexion(chcon, connec))
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

        //Fonction qui test la connexion à la BDD, avec la chaine de connexion donnée, et le OleDbConenction donné
        public bool testConnexion(string Xchcon, OleDbConnection Xconnec)
        {
            try
            {
                Xconnec.ConnectionString = Xchcon;
                Xconnec.Open();
                MessageBox.Show("Connecté à la BDD");
                return true;
            }

            //interception des erreurs possibles
            catch (InvalidOperationException erreur)
            {
                MessageBox.Show("Erreur de connexion à la base\n" + erreur.Message + "\n" + erreur.GetType());
                return false;
            }
            catch (OleDbException erreur)
            {
                MessageBox.Show("Erreur de requete SQL" + erreur.Message + "\n" + erreur.GetType());
                return false;
            }

            //interception des autres eurreurs
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message + "\n\n" + "Nom erreur : '" + erreur.GetType() + "'");
                return false;
            }

            //fermeture du OledBConnection dans tout les cas
            finally
            {
                if (Xconnec.State == ConnectionState.Open)
                {
                    Xconnec.Close();
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

                OleDbCommand cd = new OleDbCommand(requeteCode,connec);
                cd.CommandType = CommandType.Text;

                int numéroPhrase =(int)cd.ExecuteScalar();
                MessageBox.Show(numéroPhrase.ToString());

                if(numéroPhrase!=0)
                {
                    string requeteComplete = "select completeON from Exercices where codePhrase=" + numéroPhrase + ";";
                                     
                    OleDbCommand cdd = new OleDbCommand(requeteComplete, connec);
                    cdd.CommandType = CommandType.Text;

                    bool Complete = (bool)cdd.ExecuteScalar();
                    MessageBox.Show(Complete.ToString());

                    if(!Complete)
                    {
                        string requete
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
