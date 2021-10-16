using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace desktopScheduler
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            string culture = CultureInfo.CurrentCulture.ToString();
            label1.Text = culture;
            //using french resource pages
			if (culture == "fr-FR")
			{
                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("fr-FR");
                System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            }
            isNotValid.Hide();
            isValid.Hide();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

		private void loginButton_Click(object sender, EventArgs e)
		{
            isValid.Hide();
            isNotValid.Hide();
            Database database = new Database();
            string username = user.Text;
            string password = pass.Text;
            bool validCreds = database.checkCredentials(username, password);
            if (validCreds)
			{
                isValid.BackColor = Color.Green;
                isValid.Show();
                string line = "Login instantiated by: " + username + " at " + DateTime.Now.ToString();
                //string path = "C:\\desktopschedulerlog.txt";
                string path = Path.GetTempPath();

                if (!File.Exists(path + "\\desktopschedulerlog.txt"))
				{
                    using (StreamWriter sq = File.CreateText(path + "\\desktopschedulerlog.txt"))
					{
                        sq.WriteLine(line);
					}
				}
				else
				{
                    using (StreamWriter sq = File.AppendText(path + "\\desktopschedulerlog.txt"))
                    {
                        sq.WriteLine(line);
			        }   
				}
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                Close();
            }
			else
			{
                isNotValid.BackColor = Color.Red;
                isNotValid.Show();
			}
            Close();
        }
	}
}
