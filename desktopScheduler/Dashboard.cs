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
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();

		}
		private void Dashboard_Load(object sender, EventArgs e)
		{
			//using lambda expressions to generate event handlers makes it easier to modify and remove event handlers without going to extra pages to delete the _click assignments.
			addCustomer.Click += new EventHandler(delegate (Object o, EventArgs a)
		   {
			   AddCustomer addCustomer = new AddCustomer();
			   addCustomer.Show();
		   });
			//using lambda expressions to generate event handlers makes it easier to modify and remove event handlers without going to extra pages to delete the _click assignments.
			//This makes it easier to modify the code in the future if you decide you do not need the handler and want to do something different with your forms. 

			refresh.Click += new EventHandler(delegate (Object o, EventArgs a)
			{
				this.dashboardTableAdapter1.Fill(this.u057MVDataSet1.dashboard);
				dataGridView1.Rows[0].Selected = false;
			});
			this.appointments_for_cur_weekTableAdapter1.Fill(this.u057MVDataSet3.appointments_for_cur_week);
			this.appointments_for_cur_monthTableAdapter1.Fill(this.u057MVDataSet3_cur_month.appointments_for_cur_month);
			this.dashboardTableAdapter1.Fill(this.u057MVDataSet1.dashboard);
			dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

			dataGridView1.Rows[0].Selected = false;
			dataGridView2.Rows[0].Selected = false;
			dataGridView3.Rows[0].Selected = false;
			dataGridView3.Hide();
			dataGridView2.Show();

			List<string> appointments = Database.getUpcomingAppointments();
			if (appointments == null)
			{
				//nothing
			}
			else
			{
				int totalapp = 0;
				List<string> messagebox = new List<string>();
				DateTime datetime = DateTime.Now;

				for (int k = 1; k < appointments.Count; k+= 3)
				{
					if (datetime.AddMinutes(30) >= DateTime.Parse(appointments[k]) && datetime <= DateTime.Parse(appointments[k]))
					{
						totalapp = totalapp + 1;
						string query = appointments[k-1] + " appointment at " + appointments[k] + " with " + appointments[k+1];
						messagebox.Add(query);
					}
				}

				/*
				for (int i = 0; i < totalapp; i++)
				{
					query +=  appointments[i] + " appointment at " + appointments[i + 1] + " with " + appointments[i + 2];
					messagebox.Add(query);
				}
				*/
				string maxApp = "You have " + totalapp + " total appointments. ";

				string toDisplay = string.Join(Environment.NewLine, messagebox);
				if (toDisplay != @"")
				{
					MessageBox.Show(toDisplay);
				}
				else
				{
					//do nothing
				}
			}
		}


		private void upcomingAppts_Click(object sender, EventArgs e)
		{
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void updateCustomer_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection d = dataGridView1.SelectedRows;
			if (d.Count == 0)
			{
				MessageBox.Show("Please select a row");
			}
			else
			{
				var data = dataGridView1.SelectedRows;
				int indexOfRow = dataGridView1.SelectedRows[0].Index;
				DataGridViewRow selectedRow = dataGridView1.Rows[indexOfRow];
				string customerid = dataGridView1.Rows[indexOfRow].Cells[0].Value.ToString();
				
				ModifyCustomer modifyCustomer = new ModifyCustomer(customerid);
				modifyCustomer.Show();
			}

		}

		private void delCustomer_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection d = dataGridView1.SelectedRows;
			if (d.Count == 0)
			{
				MessageBox.Show("Please select a row");
			}
			else
			{
				var data = dataGridView1.SelectedRows;
				int indexOfRow = dataGridView1.SelectedRows[0].Index;
				DataGridViewRow selectedRow = dataGridView1.Rows[indexOfRow];
				string customerid = dataGridView1.Rows[indexOfRow].Cells[0].Value.ToString();
				Database.delCustomer(customerid);
				this.dashboardTableAdapter1.Fill(this.u057MVDataSet1.dashboard);
				dataGridView1.Rows[0].Selected = false;


			}
		}
		/*private void addCustomer_Click(object sender, EventArgs e)
		{
			AddCustomer addCustomer = new AddCustomer();
			addCustomer.Show();
		}
		private void refresh_Click(object sender, EventArgs e)
		{
			this.dashboardTableAdapter1.Fill(this.u057MVDataSet1.dashboard);
			dataGridView1.Rows[0].Selected = false;


		}
		*/
		private void curMonth_CheckedChanged(object sender, EventArgs e)
		{
			this.appointments_for_cur_weekTableAdapter1.Fill(this.u057MVDataSet3.appointments_for_cur_week);
			this.appointments_for_cur_monthTableAdapter1.Fill(this.u057MVDataSet3_cur_month.appointments_for_cur_month);
			dataGridView2.Hide();
			dataGridView3.Show();
		}
		private void curWeek_CheckedChanged(object sender, EventArgs e)
		{
			this.appointments_for_cur_weekTableAdapter1.Fill(this.u057MVDataSet3.appointments_for_cur_week);
			this.appointments_for_cur_monthTableAdapter1.Fill(this.u057MVDataSet3_cur_month.appointments_for_cur_month);
			dataGridView3.Hide();
			dataGridView2.Show();

		}
		private void addAppointment_Click(object sender, EventArgs e)
		{
			addAppointment addappointment = new addAppointment();
			addappointment.Show();
		}
		private void updateAppointment_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection d = dataGridView2.SelectedRows;
			DataGridViewSelectedRowCollection f = dataGridView3.SelectedRows;
			//if datagrid1 is visible do x otherwise do y
			if (dataGridView2.Visible == true)
			{
				if (d.Count == 0)
				{
					MessageBox.Show("Please select a row");
				}
				else
				{
					var data = dataGridView2.SelectedRows;
					int indexOfRow = dataGridView2.SelectedRows[0].Index;
					DataGridViewRow selectedRow = dataGridView2.Rows[indexOfRow];
					string appointmentid = dataGridView2.Rows[indexOfRow].Cells[0].Value.ToString();

					string[] appointment = Database.lookupAppointment(appointmentid);
					updateAppointment updateappointment = new updateAppointment(appointment);
					updateappointment.Show();

				}
			}
			else if (dataGridView3.Visible == true)
			{
				if (f.Count == 0)
				{
					MessageBox.Show("Please select a row");
				}
				else
				{
					var data = dataGridView3.SelectedRows;
					int indexOfRow = dataGridView3.SelectedRows[0].Index;
					DataGridViewRow selectedRow = dataGridView3.Rows[indexOfRow];
					string appointmentid = dataGridView3.Rows[indexOfRow].Cells[0].Value.ToString();

					string[] appointment = Database.lookupAppointment(appointmentid);
					updateAppointment updateappointment = new updateAppointment(appointment);
					updateappointment.Show();

				}
			}
		}

		private void deleteAppointment_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection d = dataGridView2.SelectedRows;
			DataGridViewSelectedRowCollection f = dataGridView3.SelectedRows;
			//if datagrid1 is visible do x otherwise do y
			if (dataGridView2.Visible == true)
			{
				if (d.Count == 0)
				{
					MessageBox.Show("Please select a row");
				}
				else
				{
					var data = dataGridView2.SelectedRows;
					int indexOfRow = dataGridView2.SelectedRows[0].Index;
					DataGridViewRow selectedRow = dataGridView2.Rows[indexOfRow];
					string appointmentid = dataGridView2.Rows[indexOfRow].Cells[0].Value.ToString();
					Database.delAppointment(appointmentid);
					this.appointments_for_cur_weekTableAdapter1.Fill(this.u057MVDataSet3.appointments_for_cur_week);
					dataGridView2.Rows[0].Selected = false;

				}
			}
			else if (dataGridView3.Visible == true)
			{
				if (f.Count == 0)
				{
					MessageBox.Show("Please select a row");
				}
				else
				{
					var data = dataGridView3.SelectedRows;
					int indexOfRow = dataGridView3.SelectedRows[0].Index;
					DataGridViewRow selectedRow = dataGridView3.Rows[indexOfRow];
					string appointmentid = dataGridView3.Rows[indexOfRow].Cells[0].Value.ToString();
					Database.delAppointment(appointmentid);
					this.appointments_for_cur_monthTableAdapter1.Fill(this.u057MVDataSet3_cur_month.appointments_for_cur_month);
					dataGridView3.Rows[0].Selected = false;

				}
			}
		}

		private void refreshAppointments_Click(object sender, EventArgs e)
		{
			this.appointments_for_cur_weekTableAdapter1.Fill(this.u057MVDataSet3.appointments_for_cur_week);
			this.appointments_for_cur_monthTableAdapter1.Fill(this.u057MVDataSet3_cur_month.appointments_for_cur_month);
			dataGridView3.Rows[0].Selected = false;
			dataGridView2.Rows[0].Selected = false;
		}

		private void appointmentpermonthbtn_Click(object sender, EventArgs e)
		{
			Reports reports = new Reports();
			reports.Show();
		}

		private void schedperuserbtn_Click(object sender, EventArgs e)
		{

		}
	}
}
