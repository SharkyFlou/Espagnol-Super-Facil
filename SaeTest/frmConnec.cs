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
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperSpainBlur.jpg"));
            this.pnlMid.BackColor = Color.FromArgb(150, 0, 0, 0);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
                                                            "ORDER BY codeUtil ASC";
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
            int codeUtile = cboLogin.SelectedIndex + 1;
            if(codeUtile==5 || codeUtile == 6)
            {
                frmParent.instance.chargeForm(new frmAdmin());
            }
            else if (codeUtile >= 0)
            {
                frmParent.instance.chargeForm(new frmExo(codeUtile));
            }
        }
        private void cboLogin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eLog.lien = frmParent.instance.getLienBase();
            eLog.codeUtil = cboLogin.SelectedIndex+1;
            eLog.refresh = true;
        }
    }
}
