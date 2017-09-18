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
    public partial class FireIndex : Form
    {
        public FireIndex()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFireIndexBack_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();

        }
    }
}
