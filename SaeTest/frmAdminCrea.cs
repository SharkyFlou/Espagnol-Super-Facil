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
            instance = this;
        }

        public static frmAdminCrea instance;

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

                clefUtil.Clear();
                cboUtil.Items.Clear();
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


                clefCours.Clear();
                cboCours.Items.Clear();
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

        public void retourFrmEnfant(string nom, string prenom, string mail, string coursRetour, int leconRetour, int exoRetour)
        {   
            try
            {
                //cherche le nombre max de num d'util
                connec.ConnectionString = frmParent.instance.getLienBase();
                connec.Open();

                string requete = "SELECT max(codeUtil) " +
                    "FROM Utilisateurs ";
                OleDbCommand cd = new OleDbCommand(requete, connec);
                cd.CommandText = requete;
                int nbrMax = (int)cd.ExecuteScalar();


                connec.Close();
                

                connec.Open();
                requete = "INSERT INTO Utilisateurs " +
                "(codeUtil, nomUtil, pnUtil, mailUtil, codeCours, codeLeçon, codeExo) " +
                "VALUES (" + (nbrMax+1) + ", '" + nom + "' ,'" + prenom + "', '" + mail + "' ,'" + coursRetour + "', " + leconRetour + " ," + exoRetour + ")";
                OleDbCommand comm = new OleDbCommand(requete, connec);
                int res = comm.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("L'utilsateur "+ prenom + " "+ nom + " a bien été créer.\n:)", "Retour création");
                    connec.Close();
                    chargeLogin();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            metUtilADefault();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (cboCours.SelectedIndex == -1)
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
                try
                {
                    connec.Open();
                    string requete = "UPDATE Utilisateurs " +
                        "SET codeCours ='"+clefCours[cboCours.SelectedIndex]+"', codeLeçon = "+ clefLecon[cboLecon.SelectedIndex]+", codeExo = "+clefExo[cboExo.SelectedIndex]+" " +
                         "WHERE codeUtil = " + clefUtil[cboUtil.SelectedIndex];
                    OleDbCommand comm = new OleDbCommand(requete, connec);
                    int res = comm.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("L'utilsateur " + cboUtil.SelectedItem + " a bien été modifié. \n:)","Retour modification");
                        defaultCours = clefCours[cboCours.SelectedIndex];
                        defaultLecon = clefLecon[cboLecon.SelectedIndex];
                        defaultExo = clefExo[cboExo.SelectedIndex];
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmEnfantAdminCrea feuille = new frmEnfantAdminCrea();
            string Nom;
            string Prenom;
            string mail;
            string cours;
            int lecon;
            int exo;
            if(feuille.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btSuppr_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboUtil.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez d'abord choisir un utilisateur.","Erreur");
                    return;
                }
                if (MessageBox.Show("Etes vous sur de vouloir suprimer "+cboUtil.SelectedItem+" ?","Confirmer supression", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    connec.Open();
                    string requete = "DELETE FROM Utilisateurs " +
                        "WHERE codeUtil = " + clefUtil[cboUtil.SelectedIndex];
                    string nomPrenom = cboUtil.SelectedItem.ToString();

                    OleDbCommand comm = new OleDbCommand(requete, connec);
                    int res = comm.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("L'utilsateur " + nomPrenom + " a bien été supprimé. \n:(","Retour supression");
                        connec.Close();
                        chargeLogin();
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
    }
}
