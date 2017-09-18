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
    public partial class EditDatabase : Form
    {
        public EditDatabase()
        {
            InitializeComponent();
        }

        private void btnSearchDataBase_Click(object sender, EventArgs e)
        {

        }

        private void btnEditDatabaseBack_Click(object sender, EventArgs e)
        {
            Index fx = new Index();
            fx.Show();
            this.Hide();
        }
    }
}
