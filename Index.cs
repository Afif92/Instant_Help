using Newtonsoft.Json.Linq;
using System;
using System.Device.Location;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Instant_Help
{
    public partial class Index : Form
    {
        internal static string Locationname="";

        public Index()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)   //   Police Center
        {
            Police plc = new Police();
            plc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //Medical Center
        {
            Medical mdcl = new Medical();
            mdcl.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)   //Fire Station
        {
            FireIndex fire = new FireIndex();
            fire.Show();
            this.Hide();
        }

        private void btnEditDatabase_Click(object sender, EventArgs e)
        {
            EditDatabase db = new EditDatabase();
            db.Show();
            this.Hide();
        }

        private void Index_Load(object sende, EventArgs ee)
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(); var json = ""; string rsl = "", lat = "", longi = "";

            watcher.PositionChanged += (sender, e) =>
            {
                var coordinate = e.Position.Location;
                watcher.Stop();
                lat = coordinate.Latitude.ToString();
                longi = coordinate.Longitude.ToString();
                rsl = "https://maps.googleapis.com/maps/api/geocode/json?latlng=" + lat + "," + longi + "&key=AIzaSyCWBX-YLcoiQEbmu4eadNNnGH0ToJxBvVs";
                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(rsl);
                }
                JObject o = JObject.Parse(json);
                Locationname = (string)o.SelectToken("results[0].address_components[2].long_name");
                MessageBox.Show("Your current Location: " + Locationname);
            };
            watcher.Start();
            LinqToSqlInstantHelpDataContext db = new LinqToSqlInstantHelpDataContext();
            UserInfo user = db.UserInfos.SingleOrDefault(x => x.UserName == Login_Page.usName);
            if(user.UserType == "Admin")
            {
                btnEditDatabase.Visible = true;
            }
        }

        private void btnIndexBack_Click(object sender, EventArgs e)
        {
            Login_Page fx = new Login_Page();
            fx.Show();
            this.Hide();
        }
    }
}
