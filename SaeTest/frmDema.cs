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
        }

        //pour permettre aux autres form d'utiliser les fonctions du frmDema
        public static frmDema instance;


        private void btnConnec_Click(object sender, EventArgs e)
        {
            frmParent.instance.chargeForm(new frmConnec());   
        }


    }
}
