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
    public partial class frmInscri : Form
    {
        public frmInscri()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperSpainBlur.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMid.BackColor = Color.FromArgb(150, 0, 0, 0);
        }
        OleDbConnection connec = new OleDbConnection();

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNom.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez rentrer un nom.");
                }
                else if (txtPrenom.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez rentrer un prenom.");
                }
                else if (txtMail.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez rentrer un mail.");
                }
                else
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

                    //Creation de l'utilisateur
                    requete = "INSERT INTO Utilisateurs " +
                    "(codeUtil, nomUtil, pnUtil, mailUtil, codeCours, codeLeçon, codeExo) " +
                    "VALUES (" + (nbrMax + 1) + ", '" + txtNom.Text + "' ,'" + txtPrenom.Text + "', '" + txtMail.Text + "' ,'DEBUT1', 1, 1)";
                    cd.CommandText = requete;
                    int res = cd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Bienvenido " + txtPrenom.Text + " " + txtNom.Text + " !\n:)", "Retour création");
                        frmParent.instance.chargeForm(new frmExo(nbrMax + 1));
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
