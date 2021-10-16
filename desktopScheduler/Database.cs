using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktopScheduler
{
	public class Database
	{
		static MySqlConnection con;
		public static void connectAndOpenDB()
		{
			con = new MySqlConnection("server = wgudb.ucertify.com; user id = username;password=password; persistsecurityinfo = True; database = databasename");
			con.Open();
		}
		public static void closeConnection()
		{
			con.Close();
		}
		public Database()
		{

		}
		public static List<string> getUpcomingAppointments()
		{
			//string[] appointments = { };
			List<string> appointments = new List<string>();
			connectAndOpenDB();
			string query = "SELECT start,type,customer.customerName from appointment join customer on customer.customerid = appointment.customerid WHERE start >= DATE_ADD(curdate(), interval 15 minute)";
			MySqlCommand cmd = new MySqlCommand(query, con);
			MySqlDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				while (dr.Read())
				{
					string start = dr.GetString(0);
					string type = dr.GetString(1);
					string name = dr.GetString(2);
					appointments.Add(type);
					appointments.Add(start);
					appointments.Add(name);
				}
			}

			dr.Close();
			closeConnection();

			return appointments;
		}
		public bool checkCredentials(string username, string password)
		{
			bool validCreds = false;
			//-------
			con = new MySqlConnection("server = wgudb.ucertify.com; user id = U057MV;password=53688432820; persistsecurityinfo = True; database = U057MV");
			string query = ("SELECT userid, username, password FROM user WHERE username = '" + username + "'");
			MySqlCommand cmd = new MySqlCommand(query, con);
			con.Open();
			MySqlDataReader dr = cmd.ExecuteReader();

			if (dr.HasRows)
			{
				while (dr.Read())
				{
					int userId = dr.GetInt32(0);
					string dbUsername = dr.GetString(1);
					string dbPassword = dr.GetString(2);
					//Console.WriteLine("{0},{1},{2}", userId.ToString(), dbUsername, dbPassword);
					if (dbUsername == username && dbPassword == password)
					{
						validCreds = true;
						return validCreds;
					}
					else
					{
						//next row?
					}
				}
			}
			else
			{
				validCreds = false;
			}
			dr.Close();
			con.Close();
			return validCreds;
		}
		public static void delCustomer(string customerid)
		{
			connectAndOpenDB();
			string query = "DELETE FROM customer WHERE customerid = @customerid";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@customerid", Convert.ToInt32(customerid));
			cmd.ExecuteReader();
			closeConnection();
		}
		public static bool determineDateTimeExceptions(string start, string end)
		{
			//check if appointment overlaps with other dates
			string query_overlap = "SELECT * FROM appointment WHERE @date BETWEEN start and end;";
			//string query_buisness_hours = "SELECT start, end FROM appointment WHERE hour(start) BETWEEN  '08:00:00' and '17:00:00' and hour(end) BETWEEN '08:00:00' and '17:00:00'";
			connectAndOpenDB();
			MySqlCommand cmd = new MySqlCommand(query_overlap, con);
			cmd.Parameters.AddWithValue("@date", start);
			MySqlDataReader dr = cmd.ExecuteReader();
			if(dr.HasRows)
			{
				dr.Close();
				closeConnection();
				return false;
			}
			else
			{
				closeConnection();
				return true;
			}
			//true equals good to go no issues
			//false equals overlapping occured
			

		}
		public static void addCustomer(string[] person)
		{
			connectAndOpenDB();
			string query2 = "INSERT INTO address(address, postalcode, phone,address2,cityId,createDate,createdBy,lastUpdate,lastUpdateBy) VALUES (@address, @postalcode, @phone,@address2,@cityId,@createDate,@createdBy,@lastUpdate,@lastUpdateBy)";
			MySqlCommand cmd2 = new MySqlCommand(query2, con);
			cmd2.Parameters.AddWithValue("@address", person[3]);
			cmd2.Parameters.AddWithValue("@postalcode", person[4]);
			cmd2.Parameters.AddWithValue("@phone", person[5]);
			//cmd2.Parameters.AddWithValue("@addressid", Convert.ToInt32(person[2]));
			cmd2.Parameters.AddWithValue("@address2", "testtesttest");
			cmd2.Parameters.AddWithValue("@cityId", 1);
			cmd2.Parameters.AddWithValue("@createDate", DateTime.Now);
			cmd2.Parameters.AddWithValue("@createdBy", "test");
			cmd2.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
			cmd2.Parameters.AddWithValue("@lastUpdateBy", "test");
			cmd2.ExecuteNonQuery(); 
			closeConnection();
			//--------------------------
			int addressid = lookupAddressid(person[1]);
			connectAndOpenDB();
			string query = "INSERT INTO customer(customerName,addressid, active,createDate,createdBy, lastUpdate,lastUpdateBy) VALUES (@customername,@active,@addressid, @createDate,@createdBy,@lastUpdate,@lastUpdateBy)";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@customerName", person[1]);
			cmd.Parameters.AddWithValue("@addressid", addressid);
			cmd.Parameters.AddWithValue("@active", 1);
			//cmd.Parameters.AddWithValue("@addressid", addressid);
			cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
			cmd.Parameters.AddWithValue("@createdBy", "test");
			cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
			cmd.Parameters.AddWithValue("@lastUpdateBy", "test");

			cmd.ExecuteNonQuery();
			closeConnection();
			//-----------------------------------------


		}
		public static string[] lookupCustomer(string customerid)
		{
			connectAndOpenDB();
			string query = "select customerId, customername, address.addressId, address, postalcode, phone  FROM address join customer on customer.addressId = address.addressId WHERE customerId = @customerid";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@customerid", customerid);
			MySqlDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				while (dr.Read())
				{
					customerid = dr.GetString(0);
					string customername = dr.GetString(1);
					string addressid = dr.GetString(2);
					string address = dr.GetString(3);
					string postalcode = dr.GetString(4);
					string phone = dr.GetString(5);
					string[] person = { customerid, customername, addressid, address, postalcode, phone };
					dr.Close();
					closeConnection();
					return person;
				}
			}
			dr.Close();
			closeConnection();
			return null;

		}
		public static string lookupCustomerID(string customername)
		{
			//using linq to lookup customerid, nevermind I can't without a third party extension.
			connectAndOpenDB();
			string query = "SELECT customerid FROM customer WHERE customername = @customername";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@customername", customername);
			MySqlDataReader dr = cmd.ExecuteReader();
			if(dr.HasRows)
			{
				while(dr.Read())
				{
					string customerid = dr.GetString(0);
					return customerid;
				}
			}
			return "0";
		}
		public static void updateCustomer(string[] person)
		{
			connectAndOpenDB();
			string query = "UPDATE customer SET customername = @customername WHERE addressid = @addressid";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@customername", person[1]);
			cmd.Parameters.AddWithValue("@addressid", Convert.ToInt32(person[2]));
			cmd.ExecuteReader();
			closeConnection();
			//--------------------------------------
			connectAndOpenDB();
			string query2 = "UPDATE address SET address = @address, postalcode = @postalcode, phone = @phone WHERE addressid = @addressid";
			MySqlCommand cmd2 = new MySqlCommand(query2, con);
			cmd2.Parameters.AddWithValue("@address", person[3]);
			cmd2.Parameters.AddWithValue("@postalcode", person[4]);
			cmd2.Parameters.AddWithValue("@phone", person[5]);
			cmd2.Parameters.AddWithValue("@addressid", Convert.ToInt32(person[2]));
			cmd2.ExecuteReader();
			closeConnection();
			


			//UPDATE address SET address = @address, postalcode = @postalcode, phone = @phone WHERE addressid = @addressid;
		}
		//----------------- Appointments
		public static string[] lookupAppointment(string id)
		{
			connectAndOpenDB();
			string query = "select * FROM all_Appointments WHERE appointmentID = @appointmentID";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@appointmentID", id);
			MySqlDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				while (dr.Read())
				{
					string appointmentID = dr.GetString(0);
					string name = dr.GetString(1);
					string customerID = dr.GetString(2);
					string title = dr.GetString(3);
					string description = dr.GetString(4);
					string location = dr.GetString(5);
					string contact = dr.GetString(6);
					string type = dr.GetString(7);
					string start = dr.GetString(8);
					string end = dr.GetString(9);
					string[] appointment = { appointmentID, name, customerID, title, description, location, contact, type, start, end};
					dr.Close();
					closeConnection();
					return appointment;
				}
			}
			dr.Close();
			closeConnection();
			return null;
		}
		public static void delAppointment(string id)
		{
			connectAndOpenDB();
			string query = "DELETE FROM appointment WHERE appointmentId = @appointmentid";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@appointmentid", Convert.ToInt32(id));
			cmd.ExecuteReader();
			closeConnection();
		}
		public static void updateAppointment(string[] appointment)
		{
			connectAndOpenDB();
			string query = "UPDATE appointment SET title = @title, description = @description, location = @location, contact = @contact, type = @type, start = @start, end = @end WHERE appointmentId = @appointmentid";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@title", appointment[3]);
			cmd.Parameters.AddWithValue("@description", appointment[4]);
			cmd.Parameters.AddWithValue("@location", appointment[5]);
			cmd.Parameters.AddWithValue("@contact", appointment[6]);
			cmd.Parameters.AddWithValue("@type", appointment[7]);
			cmd.Parameters.AddWithValue("@start", appointment[8]);
			cmd.Parameters.AddWithValue("@end", appointment[9]);
			cmd.Parameters.AddWithValue("@appointmentid", appointment[0]);
			cmd.ExecuteReader();
			closeConnection();
			
			connectAndOpenDB();
			string query2 = "UPDATE customer SET customername = @customername WHERE customerid = @customerid";
			MySqlCommand cmd2 = new MySqlCommand(query2, con);
			cmd2.Parameters.AddWithValue("@customername", appointment[1]);
			cmd2.Parameters.AddWithValue("@customerid", appointment[2]);
			cmd2.ExecuteReader();
			closeConnection();

		}
		public static void addAppointment(string[] appointment)
		{
			//add appointment
			connectAndOpenDB();
			string query = "INSERT into appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)" +
				" VALUES(@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";
			MySqlCommand cmd = new MySqlCommand(query, con);
			string customerid = lookupCustomerID(appointment[1]);
			//cmd.Parameters.AddWithValue("@appointmentId", appointment[0]);
			cmd.Parameters.AddWithValue("@customerId", Convert.ToInt32(customerid));
			cmd.Parameters.AddWithValue("@userId", "1");
			cmd.Parameters.AddWithValue("@title", appointment[3]);
			cmd.Parameters.AddWithValue("@description", appointment[4]);
			cmd.Parameters.AddWithValue("@location", appointment[5]);
			cmd.Parameters.AddWithValue("@contact", appointment[6]);
			cmd.Parameters.AddWithValue("@type", appointment[7]);
			cmd.Parameters.AddWithValue("@url", "not needed");
			cmd.Parameters.AddWithValue("@start", appointment[8]);
			cmd.Parameters.AddWithValue("@end", appointment[9]);
			cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
			cmd.Parameters.AddWithValue("@createdBy", "test");
			cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now);
			cmd.Parameters.AddWithValue("@lastUpdateBy", "test");
			cmd.ExecuteNonQuery();
			closeConnection();
			//add customer
			//connectAndOpenDB();
			//closeConnection();
		}
		public static int lookupAddressid(string customername)
		{
			connectAndOpenDB();
			string query = "SELECT addressid FROM address WHERE customername = @customername";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@customername", customername);
			try
			{
				MySqlDataReader dr = cmd.ExecuteReader();
				if (dr.HasRows)
				{
					while (dr.Read())
					{
						int addressid = dr.GetInt32(0);
						dr.Close();
						closeConnection();
						return addressid;

					}
				}
				dr.Close();
				closeConnection();
				return 0;
			}
			catch (Exception)
			{
				return 0;
				throw;
			}
			
		}
	}

}
