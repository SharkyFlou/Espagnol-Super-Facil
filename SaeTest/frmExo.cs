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
            
        }
        public frmExo(int xcodeUtile)
        {
            InitializeComponent();
            chcon = frmParent.instance.getLienBase();
            codeUtile = xcodeUtile;
            instance = this;

        }
        string chcon;
        OleDbConnection connec = new OleDbConnection();
        DataSet dsLocal = new DataSet();
        private int codeUtile;

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
           
        }
        private void Exo2()
        {
            if (pnlExo1.Visible == true || pnlExo3.Visible == true)
            {
                pnlExo1.Visible = false;
                pnlExo3.Visible = false;

            }
            pnlExo2.Visible = true;
            

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

                    string phrase = phrases[0]["textePhrase"].ToString();
                    string traducPhrase = phrases[0]["traducPhrase"].ToString();

                    string requeteComplete = "codePhrase="+numéroPhrase;
                    DataRow[] CompleteON = dsLocal.Tables["Exercices"].Select(requeteComplete);

                    

                    bool Complete = (bool)CompleteON[0]["CompleteOn"];
                    MessageBox.Show(Complete.ToString());

                    //Complétez les trous : 1
                    if (!Complete)
                    {
                        string requeteListe = "codePhrase=" +numéroPhrase;

                        string listeMots = CompleteON[0]["listeMots"].ToString();
                        string[] liste = listeMots.Split('/');
                     

                        Exo1(phrase,traducPhrase,liste,enonceExo);

                    }

                    //Phrases dans le désordre : 2
                    else
                    {
                       
                        Exo2();
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
    }
}

