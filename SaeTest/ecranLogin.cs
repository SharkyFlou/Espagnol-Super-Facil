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
    public partial class ecranLogin : UserControl
    {
        public ecranLogin()
        {
            InitializeComponent();
        }

        //Initialise la chaine de connexion global, et un OleDbConnection global aussi
        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\baseLangue.mdb";
        OleDbConnection connec = new OleDbConnection();


        private void ecranLogin_Load(object sender, EventArgs e)
        {
            //vérifie d'abord si l'interface peut se connecter à la BDD
            if(testConnexion(chcon, connec)) 
            {
                try
                {
                    //connection à la BDD
                    connec.ConnectionString = chcon;
                    connec.Open();

                    string requete = "SELECT pnUtil || nomUtil " +
                                                                "FROM Utilisateurs" +
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
    }
}
