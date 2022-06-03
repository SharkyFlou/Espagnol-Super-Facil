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
using System.IO;

namespace SaeTest
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
            instance = this;
        }

        //permet aux autres formes de changer d'écran
        Object formActu = null;
        public Font fontDeBase = new Font(new FontFamily("Nirmala UI"), 12F, FontStyle.Regular);


        public Object load
        {
            get
            {
                return formActu;
            }
            set
            {
                formActu = value; chargeForm(value);
            }
        }


        private void frmParent_Load(object sender, EventArgs e)
        {
            //vérifie d'abord si l'application peut se connecter à la BDD
            if (testConnexion(chcon, connec))
            {
                chargeForm(new frmDema());
                chargePhotopb();
            }
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperHexa.png"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
        }


        public void chargeForm(object Form)
        {
            if (this.pnlForm.Controls.Count > 0)
            {
                this.pnlForm.Controls.RemoveAt(0);
            }
            //activation ou desactivation du bouton retour
            if (Form.GetType() == typeof(frmDema)){
                pbRetour.Enabled = false;
            }
            else
            {
               pbRetour.Enabled = true;
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlForm.Controls.Add(f);
            this.pnlForm.Tag = f;
            f.Show();
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
                //MessageBox.Show("Connecté à la BDD");
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
            if(MessageBox.Show("Etes vous sur de vouloir quitter ?\nVos données seront sauvegardées", "Quitter ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pnlHaut_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(Label))
            {
                Label lbl = (Label)sender;
                mouseLocation = new Point(-e.X- lbl.Left, -e.Y-lbl.Top);
            }
            else
            {
                mouseLocation = new Point(-e.X, -e.Y);
            }
            
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

        public String photoExiste(String path)
        {
            String defaultPath = @"..\..\Photos\default.jpg";
            if (File.Exists(path))
            {
                defaultPath = path;
            }
            return defaultPath;
        }

        private void btnMaison_Click(object sender, EventArgs e)
        {
            if (pnlForm.Controls[0].GetType() == typeof(frmExo))
            {
                if (MessageBox.Show("Etes vous sur de vouloir revenir au menu ?\nVos données seront sauvegardées", "Partir ?", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }
            chargeForm(new frmDema());
        }

        private void chargePhotopb()
        {
            pbMaison.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\maisonLogo.png"));
            pbCroix.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\croixLogo.png"));
            pbRetour.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\flecheArriereLogo.png"));
            pbUser.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\userLogo.png"));
        }

        private void pbMaison_MouseEnter(object sender, EventArgs e)
        {
            pbMaison.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\maisonHoverLogo.png"));
        }

        private void pbMaison_MouseLeave(object sender, EventArgs e)
        {
            pbMaison.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\maisonLogo.png"));
        }

        private void pbRetour_MouseEnter(object sender, EventArgs e)
        {
            pbRetour.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\flecheArriereHoverLogo.png"));
        }

        private void pbRetour_MouseLeave(object sender, EventArgs e)
        {
            pbRetour.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\flecheArriereLogo.png"));
        }

        private void pbCroix_MouseEnter(object sender, EventArgs e)
        {
            pbCroix.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\croixHoverLogo.png"));
        }

        private void pbCroix_MouseLeave(object sender, EventArgs e)
        {
            pbCroix.BackgroundImage = Image.FromFile(photoExiste(@"..\..\Photos\croixLogo.png"));
        }

        private void pbRetour_Click(object sender, EventArgs e)
        {
            if (pnlForm.Controls[0].GetType() == typeof(frmConnec) || pnlForm.Controls[0].GetType() == typeof(frmInscri))
            {
                chargeForm(new frmDema());
            }
            else if(pnlForm.Controls[0].GetType() == typeof(frmExo))
            {
                if (MessageBox.Show("Etes vous sur de vouloir revenir en arrière ?\nVos données seront sauvegardées", "Partir ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    chargeForm(new frmConnec());
                }
            }
            else if (pnlForm.Controls[0].GetType() == typeof(frmAdmin))
            {
                chargeForm(new frmConnec());
            }
            else if (pnlForm.Controls[0].GetType() == typeof(frmAdminScroll) || pnlForm.Controls[0].GetType() == typeof(frmAdminCrea))
            {
                chargeForm(new frmAdmin());
            }
        }

        public void ChangeUser(String str)
        {
            String[] recupNomPrenom = str.Split(' ');
            if (recupNomPrenom.Length>= 2){
                lblUser.Text = recupNomPrenom[1].Substring(0, 1) + ". " + recupNomPrenom[0];
            }
            
        }
    }
}
