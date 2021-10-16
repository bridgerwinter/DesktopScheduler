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

namespace desktopScheduler
{
	public partial class updateAppointment : Form
	{
		public updateAppointment(string[] appointment)
		{
			InitializeComponent();
			appointmentidtext.Text = appointment[0];
			customernametext.Text = appointment[1];
			customeridtext.Text = appointment[2];
			titletext.Text = appointment[3];
			descriptiontext.Text = appointment[4];
			locationtext.Text = appointment[5];
			contacttext.Text = appointment[6];
			typetext.Text = appointment[7];

			var startdatetime = DateTime.Parse(appointment[8]);
			string shorttime = startdatetime.ToShortTimeString();
			string shortdate = startdatetime.ToShortDateString();
			startDate.Value = DateTime.Parse(shortdate);
			startTime.Value = DateTime.Parse(shorttime);

			var enddatetime = DateTime.Parse(appointment[9]);
			string endshortdate = enddatetime.ToShortDateString();
			string endshorttime = enddatetime.ToShortTimeString();
			endDate.Value = DateTime.Parse(endshortdate);
			endTime.Value = DateTime.Parse(endshorttime);
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void updateAppointment_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void save_Click(object sender, EventArgs e)
		{
			//check for bugs
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



			string[] appointment = { appointmentidtext.Text, customernametext.Text, customeridtext.Text, titletext.Text, descriptiontext.Text, locationtext.Text, contacttext.Text, typetext.Text, start, end};
			string id = Database.lookupCustomerID(customernametext.Text);
			if (id == "0")
			{
				DialogResult dialogResult = MessageBox.Show("There isn't a customer with that name would you like to quick add? (A customer account will be made with the information available)", "Would you like to quick add?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					string[] person = { "0", customernametext.Text, "quick add", "quickadd", "quickadd", "quickadd", "quickadd" };
					string[] appointment2 = { "0", customernametext.Text, customeridtext.Text, titletext.Text, descriptiontext.Text, locationtext.Text, contacttext.Text, typetext.Text, start, end };
					Database.addCustomer(person);
					Database.updateAppointment(appointment2);
					Close();
				}
				else if (dialogResult == DialogResult.No)
				{
					//do nothing
				}
			}
			else
			{
				//string[] appointment = { "0", customernametext.Text, customeridtext.Text, titletext.Text, descriptiontext.Text, locationtext.Text, contacttext.Text, typetext.Text, start, end };
				Database.updateAppointment(appointment);
				Close();
			}
		}

		private void startTime_ValueChanged(object sender, EventArgs e)
		{
		}

		private void endTime_ValueChanged(object sender, EventArgs e)
		{
		}
	}
}
