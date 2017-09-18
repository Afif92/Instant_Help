using System;
using System.Linq;
using System.Windows.Forms;
namespace Instant_Help
{
    public partial class Login_Page : Form
    {
        internal static string usName;
        public Login_Page()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rgPage = new Register();
            rgPage.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e) ///Log In Button Clicked
        {
            try
            {
                LinqToSqlInstantHelpDataContext db = new LinqToSqlInstantHelpDataContext();
                string username = txtBoxLgUserName.Text;
                string password = txtBoxLgPassword.Text;

                MessageBox.Show("Enter UserName " + username + "Passoword: " + password);

                UserInfo uInfo = db.UserInfos.SingleOrDefault(x => x.UserName == username);
                MessageBox.Show("Database UserName " + uInfo.UserName + "Passoword: " + uInfo.Password);

                if (uInfo != null)
                {
                    if (uInfo.UserName == username && uInfo.Password == password)
                    {
                        usName = username;
                        Index index = new Index();
                        index.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Enter Your UserName and Password Correctly ?");
                    }

                }
                else
                {
                    MessageBox.Show("Please Register First !");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
;            }
         }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
