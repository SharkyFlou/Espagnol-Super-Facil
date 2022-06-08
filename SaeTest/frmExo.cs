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
        DataTable tableUtilisateur = new DataTable();


        private int codeUtile;

        private string[] mots;
        private string[] liste;
        private List<string> TerminaisonsExo4=new List<string>();

        private int decalageGauche;
        private int decalageHauteur;
        private int decalage;

        string phrase;
        private bool Reussi;
        private bool Present = false;

        public static frmExo instance;

        private int numLecon;
        private int numExo;
        private string numCours;
        private string réponse;
        private string réponseJuste;

        private string reponseExo1;
        
        //tTip.SetToolTip(bpg,Cours : cours , Lecon : lecon)

        //Charge le formulaire et s'occupe de préparer les bases 
        private void frmExo_Load(object sender, EventArgs e)
        {
            connec.ConnectionString = chcon;

            OleDbDataAdapter da = new OleDbDataAdapter();
            chargementDsLocal();

            string requeteExo = "codeUtil=" + codeUtile;
            DataRow[] Utilisateur = dsLocal.Tables["Utilisateurs"].Select(requeteExo);

            numCours = Utilisateur[0]["codeCours"].ToString();
            numLecon = (int)Utilisateur[0]["codeLeçon"];
            numExo = (int)Utilisateur[0]["codeExo"];

            CreationTable();

            bpg.chaineConn = frmParent.instance.getLienBase();
            bpg.numCours = numCours;
            bpg.numLecon = numLecon;
            bpg.spawn = true;
            Reussi = false;

            pnlExo1.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlExo2.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlExo3.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlExo4.BackColor = Color.FromArgb(150, 0, 0, 0);
           // frmParent.instance.chargeForm(new frmBilan(tableUtilisateur,codeUtile));


            recupExo(numCours, numLecon, numExo);
        }
        
        //Exercice Type 1 : Phrase à trous 
        private void Exo1(string phrase,string traducPhrase,string []listeMots,string enonceExo)
        {
            if(pnlExo2.Visible==true || pnlExo3.Visible==true || pnlExo4.Visible == true)
            {
                pnlExo2.Visible=false;
                pnlExo3.Visible=false;
                pnlExo4.Visible = false;

            }
            pnlPhrase.Controls.Clear();
            pnlExo1.Visible = true;
            lblEnonce.Visible = true;
            lblEnonce.Text = enonceExo;
            lblTraductionFrançais.Text = traducPhrase;
            lblTraductionFrançais.BringToFront();
            lblTrad.BringToFront();
            explicationExercice1.BringToFront();
            
            int left = lblTrad.Left;
            int top = lblEnonce.Top;
            mots = phrase.Split(' ');
            reponseExo1 = "";

            for(int i = 0; i < mots.Length; i++)
            {
                if (listeMots.Contains((i+1).ToString()))
                {
                    TextBox name = new TextBox();
                    name.Name = i+"txtBox";
                    name.Left = left;
                    name.Top = top;
                    pnlPhrase.Controls.Add(name);
                    left += name.Width;

                    reponseExo1 += mots[i]+", ";
                }
                else
                {
                    Label mot = new Label();
                    mot.Text = mots[i];
                    mot.AutoSize = true;
                    mot.ForeColor = Color.White;
                    mot.Left = left;
                    mot.Top = top;
                    pnlPhrase.Controls.Add(mot);
                    left += mot.Width;
                    if (left> pnlPhrase.Width)
                    {
                        left = lblEnonce.Left;
                        top = lblEnonce.Top + 30;
                        mot.Left = left;
                        mot.Top = top;
                        left += mot.Width;
                    }


                }
              
            }
        }

        //Exercice Type 2 : Remettre les mots dans l'ordre
        private void Exo2(string phrase, string traduc, string enonce)
        {
            Reussi = false;
            btnValider.Text = "Continuer";
            if (pnlExo1.Visible == true || pnlExo3.Visible == true || pnlExo4.Visible == true)
            {
                pnlExo1.Visible = false;
                pnlExo3.Visible = false;
                pnlExo4.Visible = false;


            }
            int count = pnlExo2.Controls.Count;

            pnlMots.Controls.Clear();
            pnlButton.Controls.Clear();

            pnlExo2.Visible = true;
            lblEnonce2.Text = enonce;
            lblTraduction2.Text = traduc;
            explicationExercice2.BringToFront();

            mots = phrase.Split(' ');
            Random random = new Random();
            mots = mots.OrderBy(x => random.Next()).ToArray();

            int left = lblTraduction2.Left;
            int top = lblEnonce2.Top;

            decalageGauche = lblTraduction2.Left;
            decalageHauteur = lblTraduction2.Top ;

            for(int i = 0; i < mots.Length; i++)
            {
                Button t = new Button();
                t.Left = left;
                t.Top =top;
                t.ForeColor = Color.Black;
                t.Name = i + "btn";
                t.Text = mots[i];
                t.BackColor = Color.Yellow;
                t.Height = 30;
                t.AutoSize = true;
                t.Tag = i;
                t.Click += Queue;
                pnlButton.Controls.Add(t);
                left += t.Width + 5;
                if (left>pnlButton.Width)
                {
                    left = lblTraduction2.Left;
                    top +=30;
                    t.Left = left;
                    t.Top = top;
                    left += t.Width+5;
                }
            }
        }


        //Exercice Type 3 : Affichage du vocabulaire
        private void Exo3(string ennonceExo, List<string> motsEspagnols, List<string> motsFrançais, List<string> cheminMots )
        {

            Reussi = false;

            if (pnlExo2.Visible == true || pnlExo1.Visible == true|| pnlExo4.Visible==true)
            {
                pnlExo2.Visible = false;
                pnlExo1.Visible = false;
                pnlExo4.Visible = false;

            }
            pnlExo3.Controls.Clear();
            pnlExo3.Controls.Add(lblEnonce3);
            pnlExo3.Visible = true;
            lblEnonce3.Text = ennonceExo;

            int espaceEntre = 8 + ((4 - motsEspagnols.Count) * 175 / (motsEspagnols.Count + 1));
            int ImageLeft = espaceEntre;

            for (int i = 0; i < motsEspagnols.Count; i++)
            {
                petiteImage.petiteImage u = new petiteImage.petiteImage();
                u.backImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\" + cheminMots[i]));
                u.LabelEspagnol = motsEspagnols[i];
                u.LabelTraduction = motsFrançais[i];
                u.Left = ImageLeft;
                u.Top = 70;
                u.transparence = 150;
                pnlExo3.Controls.Add(u);
                ImageLeft += espaceEntre + u.Width;
                u.BringToFront();
            }
        }
        private void Exo4(string enonce,  string traducVerbe,string verbe,int codeTemps,int groupeTemps)
        {
            TerminaisonsExo4.Clear();
            Reussi = false;
            if(pnlExo1.Visible==true||pnlExo2.Visible==true||pnlExo3.Visible==true)
            {
                pnlExo1.Visible = false;
                pnlExo2.Visible = false;
                pnlExo3.Visible = false;
            }
            pnlExo4.Controls.Clear();
            pnlExo4.Controls.Add(lblEnonce4);
            lblEnonce4.Text = enonce+" : "+verbe + ", traduction : "+traducVerbe;

            int left = lblEnonce4.Left;
            int top = lblEnonce4.Top + 30;
            pnlExo4.Visible = true;
            traducVerbe = traducVerbe.Substring(0,traducVerbe.Length-2);
            
            for(int i=1;i<7;i++)
            {
                string requetePersonne = "codePersonne=" + i;
                DataRow[] resultPersonne = dsLocal.Tables["Personne"].Select(requetePersonne);
                string traducPersonne = resultPersonne[0]["traducPersonne"].ToString();

                string requeteTerminaison = "numPersonne=" + i + " and numTemps=" + codeTemps + " and Groupe=" + groupeTemps;
                DataRow[] resultTerminaison = dsLocal.Tables["Terminaisons"].Select(requeteTerminaison);
                string Terminaison = resultTerminaison[0]["term"].ToString();
                TerminaisonsExo4.Add(Terminaison);
                Label nom = new Label();
                nom.Text = traducPersonne + " "+ traducVerbe;
                nom.Left = left;
                nom.Top = top;
                nom.AutoSize = true;
                nom.BackColor = Color.Transparent;
                pnlExo4.Controls.Add(nom);
                TextBox t = new TextBox();
                t.Left = left + nom.Width;
                t.Top = top;
                t.Height = nom.Height;
                t.Width = 30;
                t.Tag = i;
                pnlExo4.Controls.Add(t);
                top += nom.Height+12;
            }
        }

        //Reccomence l'exercice actuel à 0 si on est sur de vouloir recommencer
        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("êtes vous sur de vouloir recommencer?", "Recommencage", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                recupExo(numCours, numLecon, numExo);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        //Donnes les réponses attendus en fonction du type d'exercice 
        private void btnAide_Click(object sender,EventArgs e)
        {
            if(pnlExo1.Visible)
            {
                MessageBox.Show("Les mots recherchés, dans l'ordre, sont : \n"+reponseExo1);
                reponseExo1 = "";
                recupExo(numCours, numLecon, numExo);
                bpg.fail = true;
                if (!Present)
                {
                    tableUtilisateur.Rows.Add(numExo, "Aide demandée","", réponseJuste);
                    Present = true;
                }
            }
            if(pnlExo2.Visible)
            {
                MessageBox.Show("La phrase dans l'ordre est :\n"+phrase);
                recupExo(numCours, numLecon, numExo);
                bpg.fail = true;
                if (!Present)
                {
                    tableUtilisateur.Rows.Add(numExo, "Aide demandée", "", phrase);
                    Present = true;
                }
                //phrase = "";
            }
            if (pnlExo3.Visible)
            {
                MessageBox.Show("Cet exercice est conçu pour apprendre du vocabulaire");
            }
            if(pnlExo4.Visible)
            {
                string réponse = "";
                foreach(string s in TerminaisonsExo4)
                {
                    réponse += s + ",";
                }
                MessageBox.Show("Les terminaisons dans l'ordre sont : "+réponse);
                réponse = "";
                recupExo(numCours, numLecon, numExo);
                bpg.fail = true;
            }
            
        }


        //Compare et corrige l'exerice en fonction du type d'exercice
        private void btnValider_Click(object sender,EventArgs e)
        {
            if (pnlExo1.Visible)
            {
                réponse = "";
                if (Reussi)
                {
                    bpg.next = true;
                    UpdateExo();
                    ChangerExo();
                    btnValider.Text = "Valider";
                    return;
                }
                int numéro = 0;
                foreach (Object o in pnlPhrase.Controls)
                {
                    if (o.GetType() == typeof(TextBox))
                    {
                        TextBox t = (TextBox)o;
                        int num = int.Parse(liste[numéro]);
                        if (normalise(t.Text).Trim() == normalise(mots[num - 1]).Trim())
                        {
                            t.Text = mots[num - 1];
                            t.BackColor = Color.Green;
                            réponse += t.Text+ ", ";
                            réponseJuste += t.Text + ", ";

                        }
                        else
                        {
                            t.BackColor = Color.Red;
                            réponse += t.Text + ", ";
                            réponseJuste += mots[num - 1] + ", ";
                        }
                        numéro++;
                    }
                }
                Reussi = true;

                foreach(TextBox t in pnlPhrase.Controls.OfType<TextBox>())
                {
                    if(t.BackColor==Color.Red)
                    {
                        Reussi = false;
                        bpg.fail = true;

                        if (!Present)
                        {
                            tableUtilisateur.Rows.Add(numExo, "", réponse, réponseJuste);
                            Present = true;
                        }
                    }
                }
                if(Reussi)
                {
                    btnValider.AutoSize = true;
                    btnValider.Text = "Continuer";
                    if(!Present)
                    {
                        tableUtilisateur.Rows.Add(numExo, réponse, "", réponseJuste);
                        Present = true;
                    }
                }
                réponseJuste = "";
                réponse = "";
            }


            if(pnlExo2.Visible)
            {
                réponse = "";

                bool vérif = true;
                foreach(Button btn in pnlButton.Controls.OfType<Button>())
                {
                    if(btn.Enabled)
                    {
                        vérif = false;
                    }
                }
                if (vérif)
                {
                    if (!Reussi)
                    {
                        foreach (Label l in pnlMots.Controls.OfType<Label>())
                        {
                            if (l.Tag.ToString() != "Test")
                            {
                                réponse += l.Text.ToString() + " ";
                            }
                        }

                        phrase = phrase.Trim();
                        réponse = réponse.Trim();

                        if (phrase.Equals(réponse))
                        {
                            MessageBox.Show("Gagné!");
                            Reussi = true;
                            if (!Present)
                            {
                                tableUtilisateur.Rows.Add(numExo, réponse, "", phrase);
                                Present = true;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Perdu...");
                            bpg.fail = true;
                            if(!Present)
                            {
                                tableUtilisateur.Rows.Add(numExo,"", réponse, phrase);
                                Present = true;
                            }
                        }
                        if (Reussi)
                        {
                            btnValider.AutoSize = true;
                            btnValider.Text = "Continuer";
                        }
                    }
                    else
                    {
                        bpg.next = true;
                        UpdateExo();
                        ChangerExo();
                        btnValider.Text = "Valider";
                        return;
                    }
                    réponse = "";

                }
                else
                {
                    MessageBox.Show("Veuillez utiliser tout les mots");
                }
            }



            if(pnlExo3.Visible)
            {
                    bpg.next = true;
                    UpdateExo();
                    ChangerExo();
                    btnValider.Text = "Valider";
                    return;
            }
            bool valide = true; 


            if(pnlExo4.Visible)
            {
                if(Reussi)
                {
                    bpg.next = true;
                    UpdateExo();
                    ChangerExo();
                    btnValider.Text = "Valider";
                    return;
                }
                foreach (TextBox t in pnlExo4.Controls.OfType<TextBox>())
                {
                    int numérotxtBox = (int)t.Tag-1;
                    if(TerminaisonsExo4.ElementAt(numérotxtBox)!=t.Text)
                    {
                        valide = false;
                        t.BackColor = Color.Red;
                    }
                    else
                    {
                        t.BackColor = Color.Green;
                    }
                }    
                if(valide)
                {
                    Reussi = true;
                    MessageBox.Show("Gagné!");        
                    btnValider.AutoSize = true;
                    btnValider.Text = "Continuer";
                    
                }
                else
                {
                    MessageBox.Show("perdu...");
                    bpg.fail = true;
                }
            }
        }
        
        //S'occupe du chargement de toutes les tables de la base de donnée dans un DataSet Local
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

        //Récupère le type d'exercice et appele le void corresepondant au type d'exercice récuperer
        private void recupExo(string numCours, int numLecon, int numExo)
        {
            try
            {
               
                string requeteCode = "numExo=" + numExo + " and numCours='" + numCours + "'" + " and numLecon=" + numLecon;
                DataRow[] Exercices = dsLocal.Tables["Exercices"].Select(requeteCode);
                //string numérophrase = Exercices[0]["codePhrase"].ToString();
                int numéroPhrase = (int)Exercices[0]["codePhrase"];

                string enonceExo = Exercices[0]["enonceExo"].ToString();

                if (numéroPhrase!=0)
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
                    int codeVerbe=0;
                    int codetemps=0;
                    
                    string verbeToString = Exercices[0]["codeVerbe"].ToString();

                    if(verbeToString!=string.Empty)
                    {
                        codeVerbe = int.Parse(verbeToString);
                        codetemps = (int)Exercices[0]["codetemps"];
                        
                    }
                    string requeteVerbe = "numMot=" + codeVerbe;
                    DataRow[] verber = dsLocal.Tables["Mots"].Select(requeteVerbe);

                    string verbe = verber[0]["traducMot"].ToString();
                    if (codeVerbe!=0)
                    {
                        string traducVerbe = verber[0]["libMot"].ToString();
                        int groupeTemps = 0;

                        if (traducVerbe.Substring(traducVerbe.Length-2)=="ar")
                        {
                            groupeTemps = 1;
                        }
                        if (traducVerbe.Substring(traducVerbe.Length-2)=="er")
                        {
                            groupeTemps = 2;

                        }
                        if (traducVerbe.Substring(traducVerbe.Length-2) =="ir")
                        {
                            groupeTemps = 3;

                        }


                        Exo4(enonceExo,traducVerbe,verbe, codetemps, groupeTemps) ;
                    }
                    else
                    {
                        DataRow[] MotsConcerne = dsLocal.Tables["ConcerneMots"].Select(requeteCode);
                        List<int> listeMotsConcerne = new List<int>();

                        List<string> motsFrançais = new List<string>();
                        List<string> motsEspagnols = new List<string>();
                        List<string> cheminMots = new List<string>();

                        for (int i = 0; i < MotsConcerne.Length; i++)
                        {
                            int numMot = (int)MotsConcerne[i]["numMot"];
                            string requeteMots = "numMot="+numMot;
                            DataRow[] mot = dsLocal.Tables["Mots"].Select(requeteMots);
                            motsEspagnols.Add(mot[0]["libMot"].ToString());
                            motsFrançais.Add(mot[0]["traducMot"].ToString());
                            cheminMots.Add(mot[0]["cheminPhoto"].ToString());
                        }

                        for (int i=0;i<MotsConcerne.Length;i++)
                        {
                            listeMotsConcerne.Add((int)MotsConcerne[i]["numMot"]);
                        }
                        
                        Exo3(enonceExo,motsEspagnols,motsFrançais,cheminMots);
                    }
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


        //Charge les Labels de l'exercice 2 dans un pnlMots et Disable le button correspondant au mot placé
        private void Queue(object sender,EventArgs e)
        {
            object tag = ((Button)sender).Tag;
            foreach(Control c in pnlButton.Controls)
            {
                if (c.Tag == tag)
                {
                    c.Enabled = false;
                    c.BackColor = Color.DarkGray;
                    Label t = new Label();
                    t.Tag = tag;
                    t.BackColor = Color.Transparent;
                    t.Left = decalageGauche;
                    t.Top = 5;
                    t.Text = c.Text;
                    t.AutoSize = true;
                    t.Click += Chatte;
                    t.MouseEnter += MouseEntre;
                    t.MouseLeave += MouseSort;
                    pnlMots.Controls.Add(t);
                    decalageGauche += t.Width;
                }
            }
        }

        //Supprime le label que l'on a cliqué, décale les labels sur la gauche et enable le button correspondant au label 
        private void Chatte(object sender, EventArgs e)
        {

            object tag = ((Label)sender).Tag;
            Label lbl = ((Label)sender);
            lbl.Font = new Font(new FontFamily("Nirmala UI"), 12F, FontStyle.Regular);
            decalage = lbl.Width;
            foreach (Control c in pnlButton.Controls)
            {
                if (c.Tag == tag)
                {
                    pnlMots.Controls.Remove((Label)sender);
                    c.Enabled = true;
                    c.BackColor = Color.Yellow;
                }
            }
            foreach (Label l in pnlMots.Controls.OfType<Label>())
            {
                if (l.Left > ((Label)sender).Left)
                {
                    if (l.Tag.ToString() != "Test")
                    {
                        l.Left -= decalage;
                    }
                }
            }
            decalageGauche -= decalage;

        }

        //Normalise les phrases (enlève la ponctuation et met tout en minuscule)
        private String Normalsation(string s )
        {
            s = s.ToLower();
            var sb = new StringBuilder(); 
            foreach (char c in s) 
            { 
                if (!char.IsPunctuation(c))
                    sb.Append(c); 
            }
            s = sb.ToString();

            return s;
        }

        //Update le numéro d'Exercice quand un utilisateur a réussi l'exercice,
        //si le numéro d'exercice est supérieur au nombre d'exercice dans le Cours, passe au cours suivant 
        private void UpdateExo()
        {
            string requeteNombre = "numCours='" + numCours +"'"+" and numLecon=" + numLecon;

            DataRow[] nbdexo = dsLocal.Tables["Exercices"].Select(requeteNombre);
            int count = nbdexo.Length;

            string requeteExo = "codeUtil=" + codeUtile;
            DataRow[] Utilisateur = dsLocal.Tables["Utilisateurs"].Select(requeteExo);
            int numExo = (int)Utilisateur[0]["codeExo"];
            Utilisateur[0]["codeExo"] = numExo + 1;
            numExo = (int)Utilisateur[0]["codeExo"];
            Present = false;
            if(numExo>count)
            {
                UpdateLecon();
            }


        }
        private void ChangerExo()
        {
            string requeteExo = "codeUtil=" + codeUtile;
            DataRow[] Utilisateur = dsLocal.Tables["Utilisateurs"].Select(requeteExo);

            numCours = Utilisateur[0]["codeCours"].ToString();
            numLecon = (int)Utilisateur[0]["codeLeçon"];
            numExo = (int)Utilisateur[0]["codeExo"];
            Reussi = false;
            //bpg.numCours = numCours;
            //bpg.numLecon = numLecon;
            recupExo(numCours, numLecon, numExo);

        }
        private void UpdateLecon()
        {
            //string requeteNombre="numCours'"+numCours+"'"+"and "

            string requeteLecon = "codeUtil=" + codeUtile;
            DataRow[] Utilisateur = dsLocal.Tables["Utilisateurs"].Select(requeteLecon);
            int numLecon = (int)Utilisateur[0]["codeLeçon"];
            Utilisateur[0]["codeLeçon"] = numLecon + 1;
            Utilisateur[0]["codeExo"] = 1;

            frmParent.instance.chargeForm(new frmBilan(tableUtilisateur,codeUtile));


            ChangerExo();
        }
        private void MouseEntre(object sender, EventArgs e)
        {
            Label lbl = ((Label)sender);
            lbl.ForeColor = Color.Red;
            lbl.Font = new Font(new FontFamily("Nirmala UI"), 12F, FontStyle.Bold);
            lbl.BringToFront();
            lbl.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void MouseSort(object sender, EventArgs e)
        {
            Label lbl = ((Label)sender);
            lbl.ForeColor = Color.White;
            lbl.Font = new Font(new FontFamily("Nirmala UI"),12F, FontStyle.Regular) ;
            lbl.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void CreationTable()
        {
            tableUtilisateur = new DataTable("superTable");

            if (tableUtilisateur.Rows.Count>0)
            {
                tableUtilisateur.Reset();
            }
            tableUtilisateur.Columns.Add(new DataColumn("numExo", typeof(int)));
            tableUtilisateur.Columns.Add(new DataColumn("phraseVrai", typeof(string)));
            tableUtilisateur.Columns.Add(new DataColumn("phraseFausse", typeof(string)));
            tableUtilisateur.Columns.Add(new DataColumn("corrige", typeof(string)));
        }
        public static string normalise(string Xmot)
        {
            string mot2 = "";
            char lettre;
            char lettreActu;

            for (int i = 0; i < Xmot.Length; i++)
            {
                lettreActu = Xmot[i];
                if ((int)Xmot[i] >= 65 && (int)Xmot[i] <= 90)
                {
                    lettre = (char)((int)Xmot[i] + 32); //mise en minuscule du characteres
                    lettreActu = lettre; //ajout de la lettre en mini
                }
                else if (((int)Xmot[i] >= 145 && (int)Xmot[i] <= 148) || ((int)Xmot[i] == 8217))
                { //transforme les "‘", les "’", les "“" et les "”" en "'" et le charactere chelou de 8217
                    lettreActu = (char)(39);
                }
                else if ((int)Xmot[i] >= 97 && (int)Xmot[i] <= 122)
                { //minuscules
                    lettreActu = Xmot[i];
                }
                else if ((int)Xmot[i] == 39 || (int)Xmot[i] == 45 || (int)Xmot[i] == 156)
                { //garde les "-" et les "'" et les "œ"
                    lettreActu = Xmot[i];
                }
                else if ((int)Xmot[i] >= 192 && (int)Xmot[i] <= 221 && (int)Xmot[i] != 215)
                {
                    lettre = (char)((int)Xmot[i] + 32); //mise en minuscule du characteres speciaux sauf le "×"
                    lettreActu = lettre;
                }


                if ((int)lettreActu >= 224 && (int)lettreActu <= 229) //pour les a
                {
                    lettreActu = 'a';
                }
                else if ((int)lettreActu >= 232 && (int)lettreActu <= 235) //pour les e
                {
                    lettreActu = 'e';
                }
                else if ((int)lettreActu >= 236 && (int)lettreActu <= 239) //pour les i
                {
                    lettreActu = 'i';
                }
                else if ((int)lettreActu == 241) //pour le ñ
                {
                    lettreActu = 'n';
                }
                else if ((int)lettreActu >= 242 && (int)lettreActu <= 246 || (int)lettreActu == 246) //pour les o
                {
                    lettreActu = 'o';
                }
                else if ((int)lettreActu >= 249 && (int)lettreActu <= 252) //pour les u
                {
                    lettreActu = 'u';
                }
                else if ((int)lettreActu == 253 || (int)lettreActu == 255) //pour les y
                {
                    lettreActu = 'y';
                }
                else if ((int)lettreActu == 140)
                { //transforme "Œ" en "œ"
                    lettreActu = (char)(156);
                }
                mot2 += lettreActu;
            }
            return mot2;
        }
    } 
}

