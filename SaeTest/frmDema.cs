using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaeTest
{
    public partial class frmDema : Form
    {
        public frmDema()
        {
            InitializeComponent();
            instance = this;
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperSpainBlur.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlMid.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        //pour permettre aux autres form d'utiliser les fonctions du frmDema
        public static frmDema instance;


        private void btnConnec_Click(object sender, EventArgs e)
        {
            frmParent.instance.chargeForm(new frmConnec());   
        }

        private void btnInscri_Click(object sender, EventArgs e)
        {
            frmParent.instance.chargeForm(new frmInscri());
        }

        private void frmDema_Load(object sender, EventArgs e)
        {
            pbCharly.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\stickmans\stickCharly.png"));
        }

        private void pbCharly_MouseEnter(object sender, EventArgs e)
        {
            pbCharly.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\stickmans\stickCharlyHover.png"));
        }

        private void pbCharly_MouseLeave(object sender, EventArgs e)
        {
            pbCharly.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\stickmans\stickCharly.png"));
        }
    }
}
