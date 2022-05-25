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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            instance = this;
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperAdmin.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlMid.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlHaut.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        public static frmAdmin instance;

        private void btnVoirExo_Click(object sender, EventArgs e)
        {
            frmParent.instance.chargeForm(new frmAdminScroll());
        }

        private void btnRajUser_Click(object sender, EventArgs e)
        {
            frmParent.instance.chargeForm(new frmAdminCrea());
        }
    }
}
