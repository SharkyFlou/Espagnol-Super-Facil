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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            instance = this;
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperAdmin.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            frmParent.instance.changeTitre("Interface Admin");
            pnlUtil.Visible = false;
            pnlUtil.Enabled = false;


            //pour pnl Exo / Scroll
            pnlExo.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperAdmin.jpg"));
            pnlExo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlMid.BackColor = Color.FromArgb(150, 0, 0, 0);

            chargementImage();

            //pour pnl Util / Crea
            pnlUtil.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperAdmin.jpg"));
            pnlUtil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlGauche.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlDroit.BackColor = Color.FromArgb(150, 0, 0, 0);

            pnlExo.BringToFront();
            pnlUtil.BringToFront();
        }

        public static frmAdmin instance;


        //pour le pnl Exo / scroll
        OleDbConnection connec = new OleDbConnection();
        DataSet dsLocal = new DataSet();
        Dictionary<String, List<int>> trvDejaPresent = new Dictionary<String, List<int>>();
        Dictionary<String, int[]> lienVersNodesEnfant = new Dictionary<String, int[]>();
        Dictionary<String, int> lienVersNodesParent = new Dictionary<String, int>();
        DataTable tableMoment = new DataTable();
        BindingSource bd = new BindingSource();

        //pouyr pnl Exo / Scroll
        private String numCoursActu = null;
        private int numExoActu = -1;
        private int numLeconActu = -1;

        private void btnExos_Click(object sender, EventArgs e)
        {
            pnlExo.Visible = true;
            pnlExo.Enabled = true;
            pnlUtil.Visible = false;
            pnlUtil.Enabled = false;
        }

        private void btnUtil_Click(object sender, EventArgs e)
        {
            pnlUtil.Visible = true;
            pnlUtil.Enabled = true;
            pnlExo.Visible = false;
            pnlExo.Enabled = false;
        }




        public void chargementImage()
        {
            pbArriere.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\arrBlancLogo.png"));
            pbArriere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            pbAvant.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\avantBlancLogo.png"));
            pbAvant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            pbDebut.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipArrBlancLogo.png"));
            pbDebut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            pbFin.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipAvantBlancLogo.png"));
            pbFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            pbSuppr.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\corbeilleLogo.png"));
            pbReset.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\resetLogo.png"));
            pbValider.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\validerLogo.png"));
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
                numExo = (int)d["numExo"];
                repereCours = -1;
                repereLecon = -1;
                if (!trvDejaPresent.ContainsKey(numCours))
                {
                    trvDejaPresent.Add(numCours, new List<int>());
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

                    if (!lienVersNodesParent.ContainsKey(numCours + numLecon))
                    {
                        lienVersNodesEnfant.Add(numCours + numLecon, new int[2]);
                        lienVersNodesEnfant[numCours + numLecon][0] = lienVersNodesParent[numCours];
                        lienVersNodesEnfant[numCours + numLecon][1] = trwExos.Nodes[lienVersNodesParent[numCours]].Nodes.Count;

                        String temp = dsLocal.Tables["Lecons"].Select("numLecon ='" + numLecon + "'")[0][2].ToString();
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
                if ((int)trwExos.SelectedNode.Parent.Tag != numLeconActu || numCoursActu != trwExos.SelectedNode.Parent.Parent.Tag.ToString())
                {
                    numCoursActu = trwExos.SelectedNode.Parent.Parent.Tag.ToString();
                    numLeconActu = (int)trwExos.SelectedNode.Parent.Tag;

                    changeTableMoment();
                }
                if (numExoActu-1 != (int)trwExos.SelectedNode.Tag)
                {
                    numExoActu = (int)trwExos.SelectedNode.Tag-1;
                    bd.Position = numExoActu;


                }
            }
        }

        public void changeTableMoment()
        {
            tableMoment.Clear();


            //rajout des infos de bases des exos
            int codeVerbe; //car peut être NULL, et je ne peut pas cast les NULL
            foreach (DataRow dr in dsLocal.Tables["Exercices"].Select("numCours = '" + numCoursActu + "' AND numLecon =" + numLeconActu))
            {
                codeVerbe = 0;
                if (dr["codeVerbe"].ToString().Length > 0)
                {
                    codeVerbe = (int)dr["codeVerbe"];
                }
                tableMoment.Rows.Add(dr["numCours"].ToString(), (int)dr["numLecon"], (int)dr["numExo"], dr["enonceExo"].ToString(), (int)dr["codePhrase"], codeVerbe, "", "");
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
                else if ((int)dr["codeVerbe"] == 0) //soit exo 3 (voca)
                {
                    requete = "numExo=" + dr["numExo"] + " and numCours='" + dr["numCours"] + "'" + " and numLecon=" + dr["numLecon"];
                    DataRow[] MotsConcerne = dsLocal.Tables["ConcerneMots"].Select(requete);
                    string fr = "";
                    string esp = "";
                    foreach (DataRow dr2 in MotsConcerne)
                    {
                        DataRow[] vraimot = dsLocal.Tables["Mots"].Select("numMot = " + dr2["numMot"]);
                        esp = esp + vraimot[0]["traducMot"].ToString() + "; ";
                        fr = fr + vraimot[0]["libMot"].ToString() + "; ";
                    }
                    esp = esp.Substring(0, esp.Length - 2);
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
                if ((int)trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu].Tag > 1)
                {
                    bd.MovePrevious();
                    trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu - 1];
                }
                trwExos.Focus();
            }
        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            if (numCoursActu != null)
            {
                if ((int)trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu].Tag < trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes.Count)
                {
                    bd.MoveNext();
                    trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[numExoActu+1];
                }
                trwExos.Focus();
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (numCoursActu != null)
            {
                bd.MoveLast();
                trwExos.SelectedNode = trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes[trwExos.Nodes[lienVersNodesParent[numCoursActu]].Nodes[lienVersNodesEnfant[numCoursActu + numLeconActu][1]].Nodes.Count - 1];
            }
            trwExos.Focus();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //pour form Exo / Scroll
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

            //pour pnl Util / Crea
            chargeLogin();
        }

        //pour pnl Crea / Util
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
                "VALUES (" + (nbrMax + 1) + ", '" + nom + "' ,'" + prenom + "', '" + mail + "' ,'" + coursRetour + "', " + leconRetour + " ," + exoRetour + ")";
                OleDbCommand comm = new OleDbCommand(requete, connec);
                int res = comm.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("L'utilsateur " + prenom + " " + nom + " a bien été créer.\n:)", "Retour création");
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
                    defaultExo = (int)reader[2];

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
            for (i = 0; i < clefCours.Count; i++)
            {
                if (clefCours[i] == defaultCours)
                {
                    cboCours.SelectedIndex = i;
                }
            }
            cboCours_SelectionChangeCommitted(new object(), new EventArgs());
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
                        "SET codeCours ='" + clefCours[cboCours.SelectedIndex] + "', codeLeçon = " + clefLecon[cboLecon.SelectedIndex] + ", codeExo = " + clefExo[cboExo.SelectedIndex] + " " +
                         "WHERE codeUtil = " + clefUtil[cboUtil.SelectedIndex];
                    OleDbCommand comm = new OleDbCommand(requete, connec);
                    int res = comm.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("L'utilsateur " + cboUtil.SelectedItem + " a bien été modifié. \n:)", "Retour modification");
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
            if (feuille.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btSuppr_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboUtil.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez d'abord choisir un utilisateur.", "Erreur");
                    return;
                }
                if (MessageBox.Show("Etes vous sur de vouloir suprimer " + cboUtil.SelectedItem + " ?", "Confirmer supression", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    connec.Open();
                    string requete = "DELETE FROM Utilisateurs " +
                        "WHERE codeUtil = " + clefUtil[cboUtil.SelectedIndex];
                    string nomPrenom = cboUtil.SelectedItem.ToString();

                    OleDbCommand comm = new OleDbCommand(requete, connec);
                    int res = comm.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("L'utilsateur " + nomPrenom + " a bien été supprimé. \n:(", "Retour supression");
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
             
        private void pbDebut_MouseEnter(object sender, EventArgs e)
        {
            pbDebut.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipArrBlancHoverLogo.png"));
        }

        private void pbDebut_MouseLeave(object sender, EventArgs e)
        {
            pbDebut.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipArrBlancLogo.png"));
        }

        private void pbArriere_MouseEnter(object sender, EventArgs e)
        {
            pbArriere.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\arrBlancHoverLogo.png"));
        }

        private void pbArriere_MouseLeave(object sender, EventArgs e)
        {
            pbArriere.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\arrBlancLogo.png"));
        }

        private void pbAvant_MouseEnter(object sender, EventArgs e)
        {
            pbAvant.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\avantBlancHoverLogo.png"));
        }

        private void pbAvant_MouseLeave(object sender, EventArgs e)
        {
            pbAvant.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\avantBlancLogo.png"));
        }

        private void pbFin_MouseEnter(object sender, EventArgs e)
        {
            pbFin.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipAvantBlancHoverLogo.png"));
        }

        private void pbFin_MouseLeave(object sender, EventArgs e)
        {
            pbFin.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\skipAvantBlancLogo.png"));
        }

        private void pbSuppr_MouseEnter(object sender, EventArgs e)
        {
            pbSuppr.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\corbeilleHoverLogo.png"));
        }

        private void pbSuppr_MouseLeave(object sender, EventArgs e)
        {
            pbSuppr.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\corbeilleLogo.png"));
        }

        private void pbReset_MouseEnter(object sender, EventArgs e)
        {
            pbReset.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\resetHoverLogo.png"));
        }

        private void pbReset_MouseLeave(object sender, EventArgs e)
        {
            pbReset.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\resetLogo.png"));
        }


        private void pbValider_MouseEnter(object sender, EventArgs e)
        {
            pbValider.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\validerHoverLogo.png"));
        }

        private void pbValider_MouseLeave(object sender, EventArgs e)
        {
            pbValider.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\validerLogo.png"));
        }

    }
}
