using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instant_Help
{
    public partial class Police : Form
    {
        public Police()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) //btn Send Voice Mail
        {
            Send_Voice_Mail ob = new Send_Voice_Mail();
            ob.Show();
            this.Hide();
        }

        private void btnMailNow_Click(object sender, EventArgs e)
        {
            Send_Mail ob = new Send_Mail();
            ob.Show();
            this.Hide();
        }

        private void btnNearbyPoliceCenter_Click(object sender, EventArgs e)
        {

        }

        private void btnPoliceCenterBack_Click(object sender, EventArgs e)
        {
            Index fx = new Index();
            fx.Show();
            this.Hide();
        }
    }
}
