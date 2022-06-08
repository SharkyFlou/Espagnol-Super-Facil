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
        DataTable tableMoment = new DataTable();
        BindingSource bd = new BindingSource();


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
            //this.exercicesTableAdapter.Fill(this.baseLangueDataSet.Exercices);
            connec.ConnectionString = frmParent.instance.getLienBase();
            chargementDsLocal();
            chargementTree();


            tableMoment = new DataTable("superTable");
            tableMoment.Columns.Add(new DataColumn("numCours", typeof(string)));
            tableMoment.Columns.Add(new DataColumn("numLecon", typeof(int)));
            tableMoment.Columns.Add(new DataColumn("numExo", typeof(int)));
            tableMoment.Columns.Add(new DataColumn("enonce", typeof(string)));
            tableMoment.Columns.Add(new DataColumn("codePhrase", typeof(int)));
            tableMoment.Columns.Add(new DataColumn("codeVerbe", typeof(int)));

            tableMoment.Columns.Add(new DataColumn("phrase", typeof(string)));
            tableMoment.Columns.Add(new DataColumn("corrige", typeof(string)));
        }

        private void chargementTree()
        {

            //trie le dataset
            dsLocal.Tables["Exercices"].DefaultView.Sort = "numCours, numLecon, numExo";
            DataTable dr = dsLocal.Tables["Exercices"].DefaultView.ToTable();

            //init
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
                        String temp = dsLocal.Tables["Cours"].Select("numCours ='" + numCours + "'")[0][1].ToString();
                        trwExos.Nodes.Add(temp);
                        trwExos.Nodes[trwExos.Nodes.Count - 1].Tag = numCours;
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
                trwExos.Nodes[repereCours].Nodes[repereLecon].Nodes.Add("Exo n°" + numExo.ToString());
                trwExos.Nodes[repereCours].Nodes[repereLecon].Nodes[trwExos.Nodes[repereCours].Nodes[repereLecon].Nodes.Count - 1].Tag = numExo;
            }
        }     

        private void trwExos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trwExos.SelectedNode.Level == 2)
            {
                if((int)trwExos.SelectedNode.Parent.Tag != numLeconActu || numCoursActu != trwExos.SelectedNode.Parent.Parent.Tag.ToString())
                {
                    numCoursActu = trwExos.SelectedNode.Parent.Parent.Tag.ToString();
                    numLeconActu = (int)trwExos.SelectedNode.Parent.Tag;

                    changeTableMoment();
                }
                if (numExoActu != (int)trwExos.SelectedNode.Tag)
                {
                    numExoActu = (int)trwExos.SelectedNode.Tag;
                    bd.Position = numExoActu;
                    
                    lblTitre.Left = (pnlMid.Width - lblTitre.Width) / 2;

                    lblCorr.Font = new Font(new FontFamily("Nirmala UI"), 16F, FontStyle.Regular);
                    lblPhrase.Font = new Font(new FontFamily("Nirmala UI"), 16F, FontStyle.Regular);

                    if ((pnlMid.Width - lblPhrase.Width) < 0) //si ça depasse
                    {
                        lblPhrase.Font = new Font(new FontFamily("Nirmala UI"), 12F, FontStyle.Regular);
                    }
                    lblPhrase.Left = (pnlMid.Width - lblPhrase.Width) / 2;

                    if ((pnlMid.Width - lblCorr.Width) < 0) //si ça depasse
                    {
                        lblCorr.Font = new Font(new FontFamily("Nirmala UI"), 12F, FontStyle.Regular);
                    }
                    lblCorr.Left = (pnlMid.Width - lblCorr.Width) / 2;
                }
            }
        }

        public void changeTableMoment()
        {
            tableMoment.Clear();
            

            //rajout des infos de bases des exos
            int codeVerbe; //car peut être NULL, et je ne peut pas cast les NULL
            foreach (DataRow dr in dsLocal.Tables["Exercices"].Select("numCours = '"+numCoursActu+"' AND numLecon ="+ numLeconActu))
            {
                codeVerbe = 0;
                if (dr["codeVerbe"].ToString().Length>0)
                {
                    codeVerbe = (int)dr["codeVerbe"];
                }
                tableMoment.Rows.Add(dr["numCours"].ToString(), (int)dr["numLecon"], (int)dr["numExo"], dr["enonceExo"].ToString(), (int)dr["codePhrase"], codeVerbe, "","");
            }

            //rajout des corrigés si quand codePhrase != 0 pour exo 1 et 2 et mtn 3
            int i = 0;
            string requete;
            foreach (DataRow dr in tableMoment.Rows)
            {
                if ((int)dr["codePhrase"] != 0) //soit exo 1 ou 2 (phrase a trou + phrase mots mélangés)
                {
                    DataRow[] drr = dsLocal.Tables["Phrases"].Select("codePhrase = " + tableMoment.Rows[i]["codePhrase"]);

                    tableMoment.Rows[i]["phrase"] = drr[0]["textePhrase"].ToString();
                    tableMoment.Rows[i]["corrige"] = drr[0]["traducPhrase"].ToString();
                }
                else if((int)dr["codeVerbe"] == 0) //soit exo 3 (voca)
                {
                    requete = "numExo=" + dr["numExo"] + " and numCours='" + dr["numCours"] + "'" + " and numLecon=" + dr["numLecon"];
                    DataRow[] MotsConcerne = dsLocal.Tables["ConcerneMots"].Select(requete);
                    string fr="";
                    string esp="";
                    foreach(DataRow dr2 in MotsConcerne)
                    {
                        DataRow[] vraimot = dsLocal.Tables["Mots"].Select("numMot = "+dr2["numMot"]);
                        esp = esp + vraimot[0]["traducMot"].ToString()+ "; ";
                        fr = fr + vraimot[0]["libMot"].ToString() + "; ";
                    }
                    esp = esp.Substring(0, esp.Length-2);
                    fr = fr.Substring(0, fr.Length - 2);

                    tableMoment.Rows[i]["corrige"] = esp;
                    tableMoment.Rows[i]["phrase"] = fr;
                }
                i++;


            }

            bd.DataSource = tableMoment;

            Binding bdTitre = new Binding("Text", bd, "enonce", true, DataSourceUpdateMode.OnPropertyChanged);
            lblTitre.DataBindings.Clear();
            lblTitre.DataBindings.Add(bdTitre);

            Binding bdPhrase = new Binding("Text", bd, "phrase", true, DataSourceUpdateMode.OnPropertyChanged);
            lblPhrase.DataBindings.Clear();
            lblPhrase.DataBindings.Add(bdPhrase);

            Binding bdCorr = new Binding("Text", bd, "corrige", true, DataSourceUpdateMode.OnPropertyChanged);
            lblCorr.DataBindings.Clear();
            lblCorr.DataBindings.Add(bdCorr);
        }

        private void btnDebut_Click(object sender, EventArgs e)
        {
            if (numCoursActu != null)
            {
                bd.MoveFirst();
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
                    bd.MovePrevious();
                    trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu-2];
                    trwExos.Focus();
                }          
            }
        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            if (numCoursActu != null)
            {
                if ((int)trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu-1].Tag  < trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes.Count)
                {
                    bd.MoveNext();
                    trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu];
                    trwExos.Focus();
                }
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (numCoursActu != null)
            {
                bd.MoveLast();
                trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes.Count - 1];
                trwExos.Focus();
            }
        }
    }
}