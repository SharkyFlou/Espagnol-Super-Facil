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
    public partial class frmAdminScroll : Form
    {
        public frmAdminScroll()
        {
            InitializeComponent();
            instance = this;
            
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperAdmin.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlMid.BackColor = Color.FromArgb(150, 0, 0, 0);

            
            chargementImage("Blanc");
        }
        public static frmAdminScroll instance;

        OleDbConnection connec = new OleDbConnection();
        DataSet dsLocal = new DataSet();
        Dictionary<String, List<int>> trvDejaPresent = new Dictionary<String, List<int>>();
        Dictionary<String, int[]> lienVersNodesEnfant = new Dictionary<String, int[]> ();
        Dictionary<String, int> lienVersNodesParent = new Dictionary<String, int>();

        private String numCoursActu = null;
        private int numExoActu = -1;
        private int numLeconActu= -1;

        public void chargementImage(String blanc)
        {
            btnArriere.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\arr"+blanc+"Logo.png"));
            btnArriere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            btnAvant.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\avant" + blanc + "Logo.png"));
            btnAvant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            btnDebut.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipArr" + blanc + "Logo.png"));
            btnDebut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            btnFin.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipAvant" + blanc + "Logo.png"));
            btnFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }


        private void chargementDsLocal()
        {
            try
            {
                connec.Open();

                DataTable schemaTable = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                connec.Close();

                string nomTable;
                string requete;
                foreach (DataRow ligne in schemaTable.Rows)
                {
                    nomTable = ligne[2].ToString();
                    requete = "select * from " + nomTable;

                    OleDbCommand cd = new OleDbCommand(requete, connec);
                    OleDbDataAdapter da = new OleDbDataAdapter(cd);
                    da.Fill(dsLocal, nomTable);
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

        private void frmAdminScroll_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'baseLangueDataSet.Exercices'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.exercicesTableAdapter.Fill(this.baseLangueDataSet.Exercices);
            connec.ConnectionString = frmParent.instance.getLienBase();
            chargementDsLocal();
            chargementTree();
        }

        private void chargementTree()
        {
            DataTable dr = dsLocal.Tables["Exercices"];
            string numCours;
            int numLecon;
            int numExo;
            int repereCours;
            int repereLecon;

            foreach (DataRow d in dr.Rows)
            {
                numCours = d["numCours"].ToString();
                numLecon = (int)d["numLecon"];
                numExo =(int)d["numExo"];
                repereCours = -1;
                repereLecon = -1;
                if (!trvDejaPresent.ContainsKey(numCours))
                {
                    trvDejaPresent.Add(numCours,new List<int>());
                }
                if (!trvDejaPresent[numCours].Contains(numLecon))
                {
                    trvDejaPresent[numCours].Add(numLecon);

                    //repertorie le nv double noeud
                    if (!lienVersNodesParent.ContainsKey(numCours))
                    {
                        lienVersNodesParent.Add(numCours, trwExos.Nodes.Count);
                        String temp = dsLocal.Tables["Cours"].Select("numCours ='" + numCours+"'")[0][1].ToString();
                        trwExos.Nodes.Add(temp);
                        trwExos.Nodes[trwExos.Nodes.Count - 1].Tag=numCours;
                    }

                    if (!lienVersNodesParent.ContainsKey(numCours+ numLecon))
                    {
                        lienVersNodesEnfant.Add(numCours + numLecon, new int[2]);
                        lienVersNodesEnfant[numCours + numLecon][0] = lienVersNodesParent[numCours];
                        lienVersNodesEnfant[numCours + numLecon][1] = trwExos.Nodes[lienVersNodesParent[numCours]].Nodes.Count;

                        String temp = dsLocal.Tables["Lecons"].Select("numLecon ='" + numLecon+"'")[0][2].ToString();
                        trwExos.Nodes[lienVersNodesParent[numCours]].Nodes.Add(temp);
                        trwExos.Nodes[lienVersNodesParent[numCours]].Nodes[lienVersNodesEnfant[numCours + numLecon][1]].Tag = numLecon;
                    }
                }
                repereCours = lienVersNodesParent[numCours];
                repereLecon = lienVersNodesEnfant[numCours + numLecon][1];
                if (trwExos.Nodes[repereCours].Nodes[repereLecon].Nodes.Count < numExo-1)
                {
                    trwExos.Nodes[repereCours].Nodes[repereLecon].Nodes.Add("Exo n°" + numExo.ToString());
                    trwExos.Nodes[repereCours].Nodes[repereLecon].Nodes[trwExos.Nodes[repereCours].Nodes[repereLecon].Nodes.Count - 1].Tag = numExo;
                }
                else
                {
                    trwExos.Nodes[repereCours].Nodes[repereLecon].Nodes.Insert(numExo-1, "Exo n°" + numExo.ToString());
                    trwExos.Nodes[repereCours].Nodes[repereLecon].Nodes[numExo-1].Tag = numExo;
                }
                

                
            }
        }     

        private void trwExos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trwExos.SelectedNode.Level == 2)
            {
                numCoursActu = trwExos.SelectedNode.Parent.Parent.Tag.ToString();
                numLeconActu = (int)trwExos.SelectedNode.Parent.Tag;
                numExoActu = (int)trwExos.SelectedNode.Tag;
                string requete = "numExo=" + numExoActu + " and numCours='" + numCoursActu + "'" + " and numLecon=" + numLeconActu;
                lblTitre.Text = dsLocal.Tables["Exercices"].Select(requete)[0][3].ToString();
                lblTitre.Left = (pnlMid.Width - lblTitre.Width) / 2;
            }
        }

        private void btnDebut_Click(object sender, EventArgs e)
        {
            if (numCoursActu != null)
            {
                trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[0];
                trwExos.Focus();
            }
        }

        private void btnArriere_Click(object sender, EventArgs e)
        {
            if (numCoursActu != null)
            {
                if((int)trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu-1].Tag > 1)
                {
                    trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu-2];
                }
               
                trwExos.Focus();
            }
        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            if (numCoursActu != null)
            {
                if ((int)trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu-1].Tag  < trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes.Count)
                {
                    trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu ];
                }
                trwExos.Focus();
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (numCoursActu != null)
            {
                trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes.Count-1];
                trwExos.Focus();
            }
        }
    }
}