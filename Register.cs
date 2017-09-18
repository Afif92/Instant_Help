using System;
using System.Linq;
using System.Windows.Forms;
namespace Instant_Help
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxRgConPassword.Text == txtBoxRgPassword.Text && txtBoxRgConPassword.Text != "")
            {
                if (txtBoxRgContact.Text != "" && txtBoxRgEmail.Text != "" && txtBoxRgUserName.Text != "" &&
                          txtBoxRgName.Text != "" && txtBoxRgFamilyContact.Text != "")
                {

                    LinqToSqlInstantHelpDataContext db = new LinqToSqlInstantHelpDataContext();
                    Table info = db.Tables.SingleOrDefault(x => x.UserName == txtBoxRgUserName.Text);
                    if (info == null)
                    {
                        UserInfo uInfo = new UserInfo();
                        uInfo.Name = txtBoxRgName.Text;
                        uInfo.Email = txtBoxRgEmail.Text;
                        uInfo.Password = txtBoxRgPassword.Text;
                        uInfo.Phone = txtBoxRgContact.Text;
                        uInfo.UserName = txtBoxRgUserName.Text;
                        uInfo.Family_Phone = txtBoxRgFamilyContact.Text;
                        db.UserInfos.InsertOnSubmit(uInfo);
                        db.SubmitChanges();
                        Login_Page fx = new Login_Page();
                        fx.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("UserName Already Exist. Try with a Different UserName ?");
                    }

                }
                else
                {
                    MessageBox.Show(" Please Fill Up All The Box Properly ?");
                }
            }
            else
            {
                MessageBox.Show("Both The Passwored Field Have To be Same ! ");
                txtBoxRgPassword.Text = txtBoxRgConPassword.Text = "";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
 
}
