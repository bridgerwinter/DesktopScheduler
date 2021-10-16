using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopScheduler
{
	public partial class addAppointment : Form
	{
		public addAppointment()
		{
			InitializeComponent();
		}

		private void save_Click(object sender, EventArgs e)
		{
			string end = endDate.Value.ToString("yyyy-MM-dd") + " " + endTime.Value.ToString("HH-mm-ss");
			string start = startDate.Value.ToString("yyyy-MM-dd") + " " + startTime.Value.ToString("HH-mm-ss");

			DateTime formStart = DateTime.ParseExact(start, "yyyy-MM-dd HH-mm-ss", null);
			DateTime formEnd = DateTime.ParseExact(end, "yyyy-MM-dd HH-mm-ss", null);
			DateTime busStart = DateTime.Parse("08:00");
			DateTime busEnd = DateTime.Parse("17:00");

			bool isValid = Database.determineDateTimeExceptions(start, end);
			if (isValid)
			{

			}
			else
			{
				MessageBox.Show("Your start or end times overlap with another appointment please modify them.");
			}

			if (formStart >= busStart && formEnd <= busEnd)
			{
				//values are appropriate
			}
			else
			{
				MessageBox.Show("Your start or end dates are outside of buisness hours");
			}
			customeridtext.Text = Database.lookupCustomerID(customernametext.Text);
			//need to generate new ids for users
			if (customeridtext.Text == "0")
			{
				DialogResult dialogResult = MessageBox.Show("There isn't a customer with that name would you like to quick add? (A customer account will be made with the information available)", "Would you like to quick add?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					string[] person = { "0", customernametext.Text, "quick add", "quickadd", "quickadd", "quickadd", "quickadd" };
					string[] appointment = { "0", customernametext.Text, customeridtext.Text, titletext.Text, descriptiontext.Text, locationtext.Text, contacttext.Text, typetext.Text, start, end };
					Database.addCustomer(person);
					Database.addAppointment(appointment);
					Close();
				}
				else if (dialogResult == DialogResult.No)
				{
					//do nothing
				}	
			}
			else
			{
				string[] appointment = { "0", customernametext.Text, customeridtext.Text, titletext.Text, descriptiontext.Text, locationtext.Text, contacttext.Text, typetext.Text, start, end };
				Database.addAppointment(appointment);
				Close();
			}
	
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void addAppointment_Load(object sender, EventArgs e)
		{

		}
	}
}
