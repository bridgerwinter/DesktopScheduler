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
	public partial class Reports : Form
	{
		public Reports()
		{
			InitializeComponent();
			rpttotalappointments.Show();
			rptusersched.Hide();
			rpttype.Hide();
		}

		private void Reports_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'rpt_user_schedule._rpt_user_schedule' table. You can move, or remove it, as needed.
			this.rpt_user_scheduleTableAdapter.Fill(this.rpt_user_schedule._rpt_user_schedule);
			// TODO: This line of code loads data into the 'rpt_total_type._rpt_total_type' table. You can move, or remove it, as needed.
			this.rpt_total_typeTableAdapter.Fill(this.rpt_total_type._rpt_total_type);
			// TODO: This line of code loads data into the 'rpt_total_appointments_per_user._rpt_total_appointments_per_user' table. You can move, or remove it, as needed.
			this.rpt_total_appointments_per_userTableAdapter.Fill(this.rpt_total_appointments_per_user._rpt_total_appointments_per_user);

		}

		private void totalappointmentsperuser_CheckedChanged(object sender, EventArgs e)
		{
			
			rptusersched.Hide();
			rpttype.Hide();
			rpttotalappointments.Show();
			this.rpt_total_appointments_per_userTableAdapter.Fill(this.rpt_total_appointments_per_user._rpt_total_appointments_per_user);

		}

		private void totalpertype_CheckedChanged(object sender, EventArgs e)
		{
			rpttotalappointments.Hide();
			rptusersched.Hide();
			rpttype.Show();
			this.rpt_total_typeTableAdapter.Fill(this.rpt_total_type._rpt_total_type);

		}

		private void schedule_per_user_CheckedChanged(object sender, EventArgs e)
		{
			rpttotalappointments.Hide();
			rpttype.Hide();
			rptusersched.Show();
			this.rpt_user_scheduleTableAdapter.Fill(this.rpt_user_schedule._rpt_user_schedule);

		}
	}
}
