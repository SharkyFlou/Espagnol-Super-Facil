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
    public partial class frmAdminCrea : Form
    {
        public frmAdminCrea()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperAdmin.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlGauche.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlDroit.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        OleDbConnection connec = new OleDbConnection();
        List<int> clefUtil = new List<int>();
        List<String> clefCours = new List<string>();
        List<int> clefLecon = new List<int>();
        List<int> clefExo = new List<int>();
        String defaultCours;
        int defaultLecon;
        int defaultExo;

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
                while (reader.Read())
                {
                    cboUtil.Items.Add(reader[0].ToString());
                    clefUtil.Add((int)reader[1]);
                }


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


        private void frmAdminCrea_Load(object sender, EventArgs e)
        {
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
                        cboExo.Items.Add("Exo n°"+ reader[0] + " : "+reader[1].ToString());
                        clefExo.Add((int)reader[0]);
                    }
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

        private void cboUtil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cboUtil.SelectedIndex != -1)
                {
                    connec.Open();
                    string requete = "SELECT codeCours, codeLeçon, codeExo " +
                        "FROM Utilisateurs " +
                        "WHERE codeUtil = " + clefUtil[cboUtil.SelectedIndex] + " " +
                        "ORDER BY codeUtil";

                    OleDbCommand comm = new OleDbCommand(requete, connec);
                    OleDbDataReader reader = comm.ExecuteReader();
                    reader.Read();
                    defaultCours = reader[0].ToString();
                    defaultLecon = (int)reader[1];
                    defaultExo =(int) reader[2];

                    connec.Close();
                    metUtilADefault();
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

        private void metUtilADefault()
        {
            int i;
            for (i =0; i<clefCours.Count; i++)
            {
                if (clefCours[i] == defaultCours)
                {
                    cboCours.SelectedIndex = i;
                }
            }
            cboCours_SelectionChangeCommitted(new object(),new EventArgs());
            for (i = 0; i < clefLecon.Count; i++)
            {
                if (clefLecon[i] == defaultLecon)
                {
                    cboLecon.SelectedIndex = i;
                }
            }
            cboLecon_SelectionChangeCommitted(new object(), new EventArgs());
            for (i = 0; i < clefExo.Count; i++)
            {
                if (clefExo[i] == defaultExo)
                {
                    cboExo.SelectedIndex = i;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            metUtilADefault();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
