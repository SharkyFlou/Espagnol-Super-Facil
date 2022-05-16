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
    public partial class frmAdminScroll : Form
    {
        public frmAdminScroll()
        {
            InitializeComponent();
            instance = this;
            
            this.BackgroundImage = Image.FromFile(frmParent.instance.photoExiste(@"..\..\Photos\fond\wallpaperAdmin.jpg"));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlMid.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        public static frmAdminScroll instance;

    }
}
