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
        Page pageJuste = new Page();
        Page pageFausse = new Page();

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
            document.Pages.Add(pageJuste);
            document.Pages.Add(pageFausse);
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

            Table2 tableJuste = new Table2(0, 0, 400, 700);
            Table2 tableFausse = new Table2(0, 0, 450, 700);

            Column2 column1 = tableJuste.Columns.Add(200);
            Column2 column2 = tableJuste.Columns.Add(200);

            Row2 rowHeader1 = tableJuste.Rows.Add(40, ceTe.DynamicPDF.Font.CourierBold, 16, Grayscale.Black, Grayscale.Gray);
            rowHeader1.CellDefault.Align = TextAlign.Center;
            rowHeader1.CellDefault.VAlign = VAlign.Center;
            rowHeader1.Cells.Add("Numéro d'exercice");
            rowHeader1.Cells.Add("Exercices justes");

            Column2 column3 = tableFausse.Columns.Add(150);
            Column2 column4 = tableFausse.Columns.Add(150);
            Column2 column5 = tableFausse.Columns.Add(150);

            Row2 rowHeader2 = tableFausse.Rows.Add(40, ceTe.DynamicPDF.Font.CourierBold, 16, Grayscale.Black, Grayscale.Gray);
            rowHeader2.CellDefault.Align = TextAlign.Center;
            rowHeader2.CellDefault.VAlign = VAlign.Center;
            rowHeader2.Cells.Add("Numéro d'exercice");
            rowHeader2.Cells.Add("Exercices Faux");
            rowHeader2.Cells.Add("Exercices Faux");

            tableJuste.Border.Top.Color = RgbColor.Green;
            tableJuste.Border.Bottom.Color = RgbColor.Green;
            tableJuste.Border.Top.Width = 2;
            tableJuste.Border.Bottom.Width = 2;

            tableFausse.Border.Top.Color = RgbColor.Red;
            tableFausse.Border.Bottom.Color = RgbColor.Red;
            tableFausse.Border.Top.Width = 2;
            tableFausse.Border.Bottom.Width = 2;

            foreach (DataRow d in tableUtil.Rows)
            {
                string réponseVrai = d["phraseVrai"].ToString();

                if (réponseVrai== "")
                {
                    string réponseFause = d["phraseFausse"].ToString();
                    int numExo = (int)d["numExo"];
                    string réponseCorrecte = d["corrige"].ToString();

                    Row2 row = tableFausse.Rows.Add(40, ceTe.DynamicPDF.Font.CourierBold, 12, Grayscale.Black, Grayscale.Gray);
                    row.Cells.Add(numExo.ToString());
                    row.Cells.Add(réponseFause);
                    row.Cells.Add(réponseCorrecte);
                }
                else
                {
                    int numExo = (int)d["numExo"];
                    Row2 row = tableJuste.Rows.Add(40, ceTe.DynamicPDF.Font.CourierBold, 12, Grayscale.Black, Grayscale.Gray);
                    row.Cells.Add(numExo.ToString());
                    row.Cells.Add(réponseVrai);
                }
            }
            /*
            foreach (System.Windows.Forms.Label l in pnlJuste.Controls.OfType<System.Windows.Forms.Label>())
            {
                Cells
            }

            foreach (System.Windows.Forms.Label l in pnlFaux.Controls.OfType<System.Windows.Forms.Label>())
            {
                ceTe.DynamicPDF.PageElements.Label label = new ceTe.DynamicPDF.PageElements.Label(l.Text, 0, top, l.Width, l.Height);

            }*/
            pageJuste.Elements.Add(tableJuste);
            pageFausse.Elements.Add(tableFausse);


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
