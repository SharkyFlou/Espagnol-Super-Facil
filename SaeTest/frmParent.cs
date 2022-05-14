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
            instance = this;
        }

        Object temp = null;
        public Object load
        {
            get
            {
                return temp;
            }
            set
            {
                chargeForm(value);
            }
        }


        private void frmParent_Load(object sender, EventArgs e)
        {
            //vérifie d'abord si l'application peut se connecter à la BDD
            if (testConnexion(chcon, connec))
            {
                chargeForm(new frmDema());
            }
        }


        public void chargeForm(object Form)
        {
            MessageBox.Show("mmh debut");
            if (this.pnlForm.Controls.Count > 0)
            {
                this.pnlForm.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlForm.Controls.Add(f);
            this.pnlForm.Tag = f;
            f.Show();
            MessageBox.Show("mmh fin");
        }

        //pour permettre aux autres form d'utiliser les fonctions du frmParent
        public static frmParent instance;


        //pour permettre à l'utilisateur de deplacer la fenetre
        public Point mouseLocation;


        //Initialise la chaine de connexion global, et un OleDbConnection global aussi
        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\baseLangue.mdb";
        OleDbConnection connec = new OleDbConnection();
        




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


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlHaut_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlHaut_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        public String getLienBase()
        {
            return chcon;
        }
    }
}
