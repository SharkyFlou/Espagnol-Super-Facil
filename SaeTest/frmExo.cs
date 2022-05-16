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
            
        }
        public frmExo(int xcodeUtile)
        {
            InitializeComponent();
            chcon = frmParent.instance.getLienBase();
            codeUtile = xcodeUtile;

        }
        string chcon;
        OleDbConnection connec = new OleDbConnection();
        DataSet dsLocal = new DataSet();
        private int codeUtile;



        private void frmExo_Load(object sender, EventArgs e)
        {
            connec.ConnectionString = chcon;

            OleDbDataAdapter da = new OleDbDataAdapter();
            chargementDsLocal();

            MessageBox.Show(codeUtile.ToString());
            string numCours = "DEBUT1";
            int numLecon = 4;
            int numExo = 1;
            recupExo(numCours, numLecon, numExo);
        }
        private void Exo1()
        {
            Label traduc = new Label();
            traduc.Text = "Traduction de la phrase:";
            traduc.Width = 200;
            pnlExo1.Controls.Add(traduc);
        }
        private void Exo2()
        {

        }
        private void Exo3()
        {

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
                
                DataRow[] salute = dsLocal.Tables["Exercices"].Select(requeteCode);
                int count = salute.Length;
                int numéroPhrase = (int)salute[0]["codePhrase"];

                MessageBox.Show(numéroPhrase.ToString());

                if (numéroPhrase != 0)
                {
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
                        Exo1();

                    }

                    //Phrases dans le désordre : 2
                    else
                    {
                        string requetePhrase ="codePhrase=" + numéroPhrase;
                        DataRow[] phrases = dsLocal.Tables["Phrases"].Select(requetePhrase);

                        string phrase = phrases[0]["textePhrase"].ToString();
                        MessageBox.Show(phrase);
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

