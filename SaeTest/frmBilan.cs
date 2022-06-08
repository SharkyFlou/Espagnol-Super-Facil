using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
using System.Data.OleDb;



namespace SaeTest
{
    public partial class frmBilan : Form
    {
        
        public frmBilan()
        {
            InitializeComponent();
        }
        public frmBilan(DataTable xtableUtilisateur,int xcodeUtile)
        {
            InitializeComponent();
            chcon = frmParent.instance.getLienBase();
            codeUtile = xcodeUtile;
            tableUtil = xtableUtilisateur;
            instance = this;
            this.BackgroundImage = System.Drawing.Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperExo.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        Document document = new Document();
        Page page = new Page();
        int numLecon;
        string chcon;
        private int codeUtile;
        OleDbConnection connec = new OleDbConnection();
        DataSet dsLocal = new DataSet();
        DataTable tableUtil = new DataTable();
        public static frmBilan instance;


        private void frmBilan_Load(object sender, EventArgs e)
        {
            pnlJuste.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            pnlFaux.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);

            connec.ConnectionString = chcon;
            chargementDsLocal();
            RemplissagePanel();
        }

        private void btnTélécharger_Click(object sender, EventArgs e)
        {
            RemplissagePage();
            document.Pages.Add(page);
            document.Draw("C:\\Users\\tneu\\Leçon" + numLecon + ".pdf");
            frmParent.instance.chargeForm(new frmExo(codeUtile));

        }
        private void RemplissagePanel()
        {
            int topJuste = 10;
            int topFaux = 10;
            foreach(DataRow d in tableUtil.Rows)
            {
                string réponseVrai = d["phraseVrai"].ToString();
                if(réponseVrai=="")
                {
                    string réponseFause = d["phraseFausse"].ToString();
                    int numExo = (int)d["numExo"];
                    string réponseCorrecte = d["corrige"].ToString();

                    System.Windows.Forms.Label l = new System.Windows.Forms.Label();
                    l.Text = "Exercice " + numExo + ": Vous aviez mis : " + réponseFause;
                    l.ForeColor = System.Drawing.Color.Orange;
                    l.Top = topFaux;
                    l.AutoSize = true;
                    l.BackColor = System.Drawing.Color.Transparent;
                    l.MaximumSize = new Size(pnlFaux.Width-5, 0);

                    pnlFaux.Controls.Add(l);
                    topFaux += l.Height + 5;
                    MessageBox.Show(l.Text);
                    System.Windows.Forms.Label labelCorrection = new System.Windows.Forms.Label();
                    labelCorrection.Text = "La réponse correcte était :" + réponseCorrecte;
                    labelCorrection.ForeColor = System.Drawing.Color.Orange;
                    labelCorrection.BackColor = System.Drawing.Color.Transparent;
                    labelCorrection.AutoSize = true;
                    labelCorrection.MaximumSize = new Size(pnlFaux.Width-5, 0);
                    labelCorrection.Top = topFaux;

                    pnlFaux.Controls.Add(labelCorrection);
                    topFaux += labelCorrection.Height + 15;
                }
                else
                {
                    int numExo = (int)d["numExo"];

                    System.Windows.Forms.Label l = new System.Windows.Forms.Label();
                    l.Text = "Exercice " + numExo + ": Vous aviez eu Juste!";
                    l.ForeColor = System.Drawing.Color.LightGreen;
                    l.Top = topJuste;
                    l.AutoSize = true;
                    l.BackColor = System.Drawing.Color.Transparent;

                    pnlJuste.Controls.Add(l);
                    topJuste += l.Height + 5;
                }
            }
        }
        private void RemplissagePage()
        {
            int top = 10;
            foreach (System.Windows.Forms.Label l in pnlJuste.Controls.OfType<System.Windows.Forms.Label>())
            {
                ceTe.DynamicPDF.PageElements.Label label = new ceTe.DynamicPDF.PageElements.Label(l.Text, 0, top, l.Width, l.Height);
                page.Elements.Add(label);
                top += l.Height + 5;
            }

            foreach (System.Windows.Forms.Label l in pnlFaux.Controls.OfType<System.Windows.Forms.Label>())
            {
                ceTe.DynamicPDF.PageElements.Label label = new ceTe.DynamicPDF.PageElements.Label(l.Text, 0, top, l.Width, l.Height);
                page.Elements.Add(label);
                top += l.Height + 5;
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

        private void pnlFaux_MouseDown(object sender, MouseEventArgs e)
        {
            if(!pnlFaux.Focused)
            {
                pnlFaux.Focus();
            }
        }
    }
}
