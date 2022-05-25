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
    /*Régler la taille des Button Exo2() -> Pas assez large selon les mots 
     * Label générés pas assez large selon les mots
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
    public partial class frmExo : Form
    {
        public frmExo()
        {
            InitializeComponent();
            chcon = frmParent.instance.getLienBase();
            instance = this;
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperExo.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        public frmExo(int xcodeUtile)
        {
            InitializeComponent();
            chcon = frmParent.instance.getLienBase();
            codeUtile = xcodeUtile;
            instance = this;
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperExo.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

        }
        string chcon;
        OleDbConnection connec = new OleDbConnection();
        DataSet dsLocal = new DataSet();
        private int codeUtile;
        private string[] mots;
        private string[] liste;
        private int lefttt;
        private int toppp;
        private int decalage;
        string phrase;
        private bool Reussi;

        public static frmExo instance;


        private void frmExo_Load(object sender, EventArgs e)
        {
            connec.ConnectionString = chcon;

            OleDbDataAdapter da = new OleDbDataAdapter();
            chargementDsLocal();

            string requeteExo = "codeUtil=" + codeUtile;
            DataRow[] Utilisateur = dsLocal.Tables["Utilisateurs"].Select(requeteExo);

            string numCours = Utilisateur[0]["codeCours"].ToString();
            int numLecon = (int)Utilisateur[0]["codeLeçon"];
            int numExo = (int)Utilisateur[0]["codeExo"];

            numCours = "DEBUT1";
            numExo = 4;
            numLecon = 1;

            bpg.chaineConn = frmParent.instance.getLienBase();
            bpg.numCours = numCours;
            bpg.numLecon = numLecon;
            bpg.spawn = true;
            Reussi = false;


            recupExo(numCours, numLecon, numExo);
        }
        
        private void Exo1(string phrase,string traducPhrase,string []listeMots,string enonceExo)
        {
            if(pnlExo2.Visible==true || pnlExo3.Visible==true)
            {
                pnlExo2.Visible=false;
                pnlExo3.Visible=false;

            }
            pnlExo1.Visible = true;
            lblEnonce.Visible = true;
            lblEnonce.Text = enonceExo;
            lblTraductionFrançais.Text = traducPhrase;
            int left = lblTrad.Left;
            int top = lblTrad.Top + 30;
            mots = phrase.Split(' ');
           

            for(int i = 0; i < mots.Length; i++)
            {
                if(listeMots.Contains((i+1).ToString()))
                {
                    TextBox name = new TextBox();
                    name.Name = i+"txtBox";
                    name.Left = left;
                    name.Top = top;
                    pnlExo1.Controls.Add(name);
                    left += name.Width;
                }
                else
                {
                    Label mot = new Label();
                    mot.Text = mots[i];
                    mot.AutoSize = true;
                    mot.ForeColor = Color.Black;
                    mot.Left = left;
                    mot.Top = top;
                    pnlExo1.Controls.Add(mot);
                    left += mot.Width;

                }
                if (left>pnlExo1.Width)
                {
                    left = lblTrad.Left;
                    top = lblTrad.Top + 60;
                }
            }
        }


        private void Exo2(string phrase, string traduc, string enonce)
        {
            if (pnlExo1.Visible == true || pnlExo3.Visible == true)
            {
                pnlExo1.Visible = false;
                pnlExo3.Visible = false;

            }
            pnlExo2.Visible = true;
            lblEnonce2.Text = enonce;
            lblTraduction2.Text = traduc;

            mots = phrase.Split(' ');
            Random random = new Random();
            mots = mots.OrderBy(x => random.Next()).ToArray();

            int left = lblEnonce2.Left;
            int top = lblTraduction2.Top + 80;

            lefttt = lblTraduction2.Left;
            toppp = lblTraduction2.Top + 30;

            for(int i = 0; i < mots.Length; i++)
            {
                Button t = new Button();
                t.Left = left;
                t.Top = top;
                t.ForeColor = Color.Black;
                t.Name = i + "btn";
                t.Text = mots[i];
                t.BackColor = Color.Yellow;
                t.Height = 30;
                t.AutoSize = true;
                t.Tag = i;
                t.Click += Queue;
                pnlExo2.Controls.Add(t);
                left += t.Width + 5;
                if (left>pnlExo2.Width)
                {
                    left = lblEnonce.Left;
                    top = lblTraduction2.Top + 110;
                }
            }
        }



        private void Exo3()
        {
            if (pnlExo2.Visible == true || pnlExo1.Visible == true)
            {
                pnlExo2.Visible = false;
                pnlExo1.Visible = false;

            }
            pnlExo3.Visible = true;
        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {

        }

        private void btnAide_Click(object sender, EventArgs e)
        {

        }



        private void btnValider_Click(object sender, EventArgs e)
        {
            if (pnlExo1.Visible)
            {
                if (Reussi)
                {
                    frmParent.instance.chargeForm(new frmExo(codeUtile));
                }
                int numéro = 0;
                foreach (Object o in pnlExo1.Controls)
                {
                    if (o.GetType() == typeof(TextBox))
                    {
                        TextBox t = (TextBox)o;
                        int num = int.Parse(liste[numéro]);
                        if (t.Text == mots[num - 1])
                        {
                            t.BackColor = Color.Green;
                        }
                        else
                        {
                            t.BackColor = Color.Red;
                        }
                        numéro++;
                    }
                }
                Reussi = true;
                foreach(TextBox t in pnlExo1.Controls.OfType<TextBox>())
                {
                    if(t.BackColor==Color.Red)
                    {
                        Reussi = false;
                    }
                }
                if(Reussi)
                {
                    btnValider.AutoSize = true;
                    btnValider.Text = "Continuer";
                }
            }
            if(pnlExo2.Visible)
            {
                bool vérif = true;
                foreach(Button btn in pnlExo2.Controls.OfType<Button>())
                {
                    if(btn.Enabled)
                    {
                        vérif = false;
                    }
                }
                if (vérif)
                {
                    if(Reussi)
                    {
                        frmParent.instance.chargeForm(new frmExo(codeUtile));
                    }
                    string réponse = "";
                    foreach (Label l in pnlExo2.Controls.OfType<Label>())
                    {
                        if (l.Tag.ToString() != "Test")
                        {
                            réponse += l.Text.ToString()+" "; 
                        }
                    }

                    phrase = phrase.Trim();
                    réponse = réponse.Trim();

                    if (phrase.Equals(réponse)) 
                    {
                        MessageBox.Show("Gagné!");
                        Reussi = true;
                    }
                    else
                    {
                        MessageBox.Show("Perdu...");
                    }
                    if(Reussi)
                    {
                        btnValider.AutoSize = true;
                        btnValider.Text = "Continuer";
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez utiliser tout les mots");
                }
            }
            if(pnlExo3.Visible)
            {

            }
        }


        private void chargementDsLocal()
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
        private void recupExo(string numCours, int numLecon, int numExo)
        {
            try
            {
               
                string requeteCode = "numExo=" + numExo + " and numCours='" + numCours + "'" + " and numLecon=" + numLecon;     
                DataRow[] Exercices = dsLocal.Tables["Exercices"].Select(requeteCode);

                int numéroPhrase = (int)Exercices[0]["codePhrase"];
                string enonceExo = Exercices[0]["enonceExo"].ToString();

                if (numéroPhrase != 0)
                {
                    string requetePhrase = "codePhrase=" + numéroPhrase;
                    DataRow[] phrases = dsLocal.Tables["Phrases"].Select(requetePhrase);


                    phrase = phrases[0]["textePhrase"].ToString();
                    phrase = Normalsation(phrase);
                    string traducPhrase = phrases[0]["traducPhrase"].ToString();

                    string requeteComplete = "codePhrase="+numéroPhrase;
                    DataRow[] CompleteON = dsLocal.Tables["Exercices"].Select(requeteComplete);

                    bool Complete = (bool)CompleteON[0]["CompleteOn"];

                    //Complétez les trous : 1
                    if (!Complete)
                    {
                        string requeteListe = "codePhrase=" +numéroPhrase;

                        string listeMots = CompleteON[0]["listeMots"].ToString();
                        liste= listeMots.Split('/');
                     

                        Exo1(phrase,traducPhrase,liste,enonceExo);

                    }

                    //Phrases dans le désordre : 2
                    else
                    {
                       
                        Exo2(phrase,traducPhrase,enonceExo);
                    }
                }
                //Vocabulaire : 3
                else
                {
                    Exo3();
                }


            }
            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }
            }



        }
        private void Queue(object sender,EventArgs e)
        {
            object tag = ((Button)sender).Tag;
            foreach(Control c in pnlExo2.Controls)
            {
                if (c.Tag == tag)
                {
                    c.Enabled = false;
                    c.BackColor = Color.DarkGray;
                    Label t = new Label();
                    t.Tag = tag;
                    t.Left = lefttt;
                    t.Top = toppp;
                    t.Text = c.Text;
                    t.AutoSize = true;
                    t.Click += Chatte;
                    pnlExo2.Controls.Add(t);
                    lefttt += t.Width;
                }
            }
        }
        private void Chatte(object sender, EventArgs e)
        {
            object tag = ((Label)sender).Tag;
            decalage = ((Label)sender).Width;
            foreach (Control c in pnlExo2.Controls)
            {
                if (c.Tag == tag)
                {
                    pnlExo2.Controls.Remove((Label)sender);
                    c.Enabled = true;
                    c.BackColor = Color.Yellow;
                }
            }
            foreach (Label l in pnlExo2.Controls.OfType<Label>())
            {
                if (l.Left > ((Label)sender).Left)
                {
                    if (l.Tag.ToString() != "Test")
                    {
                        l.Left -= decalage;
                    }
                }
            }
            lefttt -= decalage;

        }
        private String Normalsation(string s )
        {
            s = s.ToLower();
            var sb = new StringBuilder(); foreach (char c in s) { if (!char.IsPunctuation(c)) sb.Append(c); }
            s = sb.ToString();

            return s;
        }
    } 
}

