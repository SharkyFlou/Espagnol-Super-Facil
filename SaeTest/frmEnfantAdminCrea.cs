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
    public partial class frmEnfantAdminCrea : Form
    {
        public frmEnfantAdminCrea()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection();
        List<String> clefCours = new List<string>();
        List<int> clefLecon = new List<int>();
        List<int> clefExo = new List<int>();

        private void chargeLogin()
        {
            try
            {
                //connection à la BDD
                connec.ConnectionString = frmParent.instance.getLienBase();
                connec.Open();

                string requete = "SELECT (pnUtil +' '+ nomUtil), codeUtil " +
                                                            "FROM Utilisateurs " +
                                                            "ORDER BY codeUtil ASC";
                OleDbCommand comm = new OleDbCommand(requete, connec);
                OleDbDataReader reader = comm.ExecuteReader();

                requete = "SELECT numCours, titreCours FROM Cours ORDER BY numCours ASC";
                connec.Close();
                connec.Open();

                comm.CommandType = CommandType.Text;
                comm.CommandText = requete;



                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cboCours.Items.Add(reader[1].ToString());
                    clefCours.Add(reader[0].ToString());
                }
                connec.Close();
                metUtilADefault();


            }
            //intercepetion et affichage de l'erreur si occurence
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message + "\n\n" + "Nom erreur : '" + erreur.GetType() + "'","ERREUR");
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

        private void frmEnfantAdminCrea_Load(object sender, EventArgs e)
        {
            txtNom.Focus();
            chargeLogin();
        }

        private void cboCours_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                connec.Open();
                clefLecon.Clear();
                cboLecon.Items.Clear();
                string requete = "SELECT numLecon, titreLecon " +
                    "FROM Lecons " +
                    "WHERE numCours = '" + clefCours[cboCours.SelectedIndex] + "' " +
                    "ORDER BY numLecon ASC";
                OleDbCommand comm = new OleDbCommand(requete, connec);
                OleDbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cboLecon.Items.Add(reader[1].ToString());
                    clefLecon.Add((int)reader[0]);
                }

            }
            //intercepetion et affichage de l'erreur si occurence
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message + "\n\n" + "Nom erreur : '" + erreur.GetType() + "'", "ERREUR");
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

        private void metUtilADefault()
        {
            if (cboCours.Items.Count > 0)
            {
                cboCours.SelectedIndex = 0;
                cboCours_SelectionChangeCommitted(new object(), new EventArgs());
            }
            
            if (cboLecon.Items.Count > 0)
            {
                cboLecon.SelectedIndex = 0;
                cboLecon_SelectionChangeCommitted(new object(), new EventArgs());
            }
            
            if (cboExo.Items.Count > 0)
            {
                cboExo.SelectedIndex = 0;
            }

        }

        private void cboLecon_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cboLecon.SelectedIndex != -1 && cboCours.SelectedIndex != -1)
                {
                    connec.Open();
                    clefExo.Clear();
                    cboExo.Items.Clear();
                    string requete = "SELECT numExo, enonceExo " +
                        "FROM Exercices " +
                        "WHERE numCours = '" + clefCours[cboCours.SelectedIndex] + "' " +
                        "AND numLecon = " + clefLecon[cboLecon.SelectedIndex] + " " +
                        "ORDER BY numExo";
                    OleDbCommand comm = new OleDbCommand(requete, connec);
                    OleDbDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        cboExo.Items.Add("Exo n°" + reader[0] + " : " + reader[1].ToString());
                        clefExo.Add((int)reader[0]);
                    }
                }

            }
            //intercepetion et affichage de l'erreur si occurence
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message + "\n\n" + "Nom erreur : '" + erreur.GetType() + "'", "ERREUR");
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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            string message = "Pour créer un utilisateur, veuillez d'abord rentrer a gauche ses informations général, puis à droite l'exercice où il débutera.";
            MessageBox.Show(message, "Aide");
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == String.Empty)
            {
                MessageBox.Show("Veuillez rentrer un nom.");
            }
            else if(txtPrenom.Text == String.Empty)
            {
                MessageBox.Show("Veuillez rentrer un prenom.");
            }
            else if (txtMail.Text == String.Empty)
            {
                MessageBox.Show("Veuillez rentrer un mail.");
            }
            else if (cboCours.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un cours.");
            }
            else if (cboLecon.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir une leçon.");
            }
            else if (cboExo.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un exercice.");
            }
            else
            {
                frmAdminCrea.instance.retourFrmEnfant(txtNom.Text.Trim(), txtPrenom.Text.Trim(), txtMail.Text.Trim(), clefCours[cboCours.SelectedIndex], clefLecon[cboLecon.SelectedIndex], clefExo[cboExo.SelectedIndex]);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
