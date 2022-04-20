using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15UserRegisterAndLoginDemo
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLoginFrm frm = new UserLoginFrm();
            frm.Show();

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            UserLoginFrm frm = new UserLoginFrm();

                frm.Show();
        }
    }
}
