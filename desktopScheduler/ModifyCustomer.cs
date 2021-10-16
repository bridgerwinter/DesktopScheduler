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
	public partial class ModifyCustomer : Form
	{
		public ModifyCustomer(string custid)
		{
			InitializeComponent();
			string[] person = Database.lookupCustomer(custid);

			customerid.Text = person[0];
			name.Text = person[1];
			addressid.Text = person[2];
			address.Text = person[3];
			zip.Text = person[4];
			phone.Text = person[5];
		}

		private void save_Click(object sender, EventArgs e)
		{
			string[] person = { customerid.Text, name.Text, addressid.Text, address.Text, zip.Text, phone.Text,   };
			Database.updateCustomer(person);
			Close();
		}
		private void cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
