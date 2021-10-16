
namespace desktopScheduler
{
	partial class Dashboard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.addAppointment = new System.Windows.Forms.Button();
			this.updateAppointment = new System.Windows.Forms.Button();
			this.deleteAppointment = new System.Windows.Forms.Button();
			this.upcomingAppts = new System.Windows.Forms.Label();
			this.delCustomer = new System.Windows.Forms.Button();
			this.updateCustomer = new System.Windows.Forms.Button();
			this.addCustomer = new System.Windows.Forms.Button();
			this.dashboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dashboardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.u057MVDataSet1 = new desktopScheduler.U057MVDataSet1();
			this.dashboardTableAdapter1 = new desktopScheduler.U057MVDataSet1TableAdapters.dashboardTableAdapter();
			this.refresh = new System.Windows.Forms.Button();
			this.appointmentsforcurweekBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.curWeek = new System.Windows.Forms.RadioButton();
			this.curMonth = new System.Windows.Forms.RadioButton();
			this.appointmentsforcurmonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.appointmentsforcurmonthBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.u057MVDataSet3_cur_month = new desktopScheduler.U057MVDataSet3_cur_month();
			this.appointments_for_cur_monthTableAdapter1 = new desktopScheduler.U057MVDataSet3_cur_monthTableAdapters.appointments_for_cur_monthTableAdapter();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contactDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.appointmentsforcurweekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.u057MVDataSet3 = new desktopScheduler.U057MVDataSet3();
			this.appointments_for_cur_weekTableAdapter1 = new desktopScheduler.U057MVDataSet3TableAdapters.appointments_for_cur_weekTableAdapter();
			this.refreshAppointments = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.appointmentpermonthbtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.u057MVDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsforcurweekBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsforcurmonthBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsforcurmonthBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.u057MVDataSet3_cur_month)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsforcurweekBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.u057MVDataSet3)).BeginInit();
			this.SuspendLayout();
			// 
			// addAppointment
			// 
			this.addAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addAppointment.ForeColor = System.Drawing.Color.Black;
			this.addAppointment.Location = new System.Drawing.Point(67, 511);
			this.addAppointment.Name = "addAppointment";
			this.addAppointment.Size = new System.Drawing.Size(113, 50);
			this.addAppointment.TabIndex = 0;
			this.addAppointment.Text = "Add Appointment";
			this.addAppointment.UseVisualStyleBackColor = true;
			this.addAppointment.Click += new System.EventHandler(this.addAppointment_Click);
			// 
			// updateAppointment
			// 
			this.updateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateAppointment.ForeColor = System.Drawing.Color.Black;
			this.updateAppointment.Location = new System.Drawing.Point(67, 598);
			this.updateAppointment.Name = "updateAppointment";
			this.updateAppointment.Size = new System.Drawing.Size(113, 50);
			this.updateAppointment.TabIndex = 1;
			this.updateAppointment.Text = "Update Appointment";
			this.updateAppointment.UseVisualStyleBackColor = true;
			this.updateAppointment.Click += new System.EventHandler(this.updateAppointment_Click);
			// 
			// deleteAppointment
			// 
			this.deleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteAppointment.ForeColor = System.Drawing.Color.Black;
			this.deleteAppointment.Location = new System.Drawing.Point(67, 683);
			this.deleteAppointment.Name = "deleteAppointment";
			this.deleteAppointment.Size = new System.Drawing.Size(113, 50);
			this.deleteAppointment.TabIndex = 2;
			this.deleteAppointment.Text = "Delete Appointment";
			this.deleteAppointment.UseVisualStyleBackColor = true;
			this.deleteAppointment.Click += new System.EventHandler(this.deleteAppointment_Click);
			// 
			// upcomingAppts
			// 
			this.upcomingAppts.AutoSize = true;
			this.upcomingAppts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.upcomingAppts.Location = new System.Drawing.Point(207, 453);
			this.upcomingAppts.Name = "upcomingAppts";
			this.upcomingAppts.Size = new System.Drawing.Size(456, 46);
			this.upcomingAppts.TabIndex = 3;
			this.upcomingAppts.Text = "Upcoming Appointments";
			this.upcomingAppts.Click += new System.EventHandler(this.upcomingAppts_Click);
			// 
			// delCustomer
			// 
			this.delCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delCustomer.ForeColor = System.Drawing.Color.Black;
			this.delCustomer.Location = new System.Drawing.Point(67, 255);
			this.delCustomer.Name = "delCustomer";
			this.delCustomer.Size = new System.Drawing.Size(113, 50);
			this.delCustomer.TabIndex = 7;
			this.delCustomer.Text = "Delete Customer";
			this.delCustomer.UseVisualStyleBackColor = true;
			this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
			// 
			// updateCustomer
			// 
			this.updateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateCustomer.ForeColor = System.Drawing.Color.Black;
			this.updateCustomer.Location = new System.Drawing.Point(67, 170);
			this.updateCustomer.Name = "updateCustomer";
			this.updateCustomer.Size = new System.Drawing.Size(113, 50);
			this.updateCustomer.TabIndex = 6;
			this.updateCustomer.Text = "Update Customer";
			this.updateCustomer.UseVisualStyleBackColor = true;
			this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
			// 
			// addCustomer
			// 
			this.addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addCustomer.ForeColor = System.Drawing.Color.Black;
			this.addCustomer.Location = new System.Drawing.Point(67, 83);
			this.addCustomer.Name = "addCustomer";
			this.addCustomer.Size = new System.Drawing.Size(113, 50);
			this.addCustomer.TabIndex = 5;
			this.addCustomer.Text = "Add Customer";
			this.addCustomer.UseVisualStyleBackColor = true;
			//this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
			// 
			// dashboardBindingSource
			// 
			this.dashboardBindingSource.DataMember = "dashboard";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressIDDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.dashboardBindingSource1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.Location = new System.Drawing.Point(186, 83);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(763, 222);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn.Width = 125;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 125;
			// 
			// addressIDDataGridViewTextBoxColumn
			// 
			this.addressIDDataGridViewTextBoxColumn.DataPropertyName = "Address ID";
			this.addressIDDataGridViewTextBoxColumn.HeaderText = "Address ID";
			this.addressIDDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.addressIDDataGridViewTextBoxColumn.Name = "addressIDDataGridViewTextBoxColumn";
			this.addressIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.addressIDDataGridViewTextBoxColumn.Width = 125;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			this.addressDataGridViewTextBoxColumn.Width = 125;
			// 
			// postalCodeDataGridViewTextBoxColumn
			// 
			this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "Postal Code";
			this.postalCodeDataGridViewTextBoxColumn.HeaderText = "Postal Code";
			this.postalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
			this.postalCodeDataGridViewTextBoxColumn.ReadOnly = true;
			this.postalCodeDataGridViewTextBoxColumn.Width = 125;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
			this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneDataGridViewTextBoxColumn.Width = 125;
			// 
			// dashboardBindingSource1
			// 
			this.dashboardBindingSource1.DataMember = "dashboard";
			this.dashboardBindingSource1.DataSource = this.u057MVDataSet1;
			// 
			// u057MVDataSet1
			// 
			this.u057MVDataSet1.DataSetName = "U057MVDataSet1";
			this.u057MVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dashboardTableAdapter1
			// 
			this.dashboardTableAdapter1.ClearBeforeFill = true;
			// 
			// refresh
			// 
			this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refresh.ForeColor = System.Drawing.Color.Black;
			this.refresh.Location = new System.Drawing.Point(843, 40);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(106, 31);
			this.refresh.TabIndex = 11;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = true;
			//this.refresh.Click += new System.EventHandler(this.refresh_Click);
			// 
			// appointmentsforcurweekBindingSource
			// 
			this.appointmentsforcurweekBindingSource.DataMember = "appointments_for_cur_week";
			// 
			// curWeek
			// 
			this.curWeek.AutoSize = true;
			this.curWeek.Checked = true;
			this.curWeek.Location = new System.Drawing.Point(661, 461);
			this.curWeek.Name = "curWeek";
			this.curWeek.Size = new System.Drawing.Size(202, 35);
			this.curWeek.TabIndex = 13;
			this.curWeek.TabStop = true;
			this.curWeek.Text = "Current Week";
			this.curWeek.UseVisualStyleBackColor = true;
			this.curWeek.CheckedChanged += new System.EventHandler(this.curWeek_CheckedChanged);
			// 
			// curMonth
			// 
			this.curMonth.AutoSize = true;
			this.curMonth.Location = new System.Drawing.Point(661, 426);
			this.curMonth.Name = "curMonth";
			this.curMonth.Size = new System.Drawing.Size(208, 35);
			this.curMonth.TabIndex = 14;
			this.curMonth.TabStop = true;
			this.curMonth.Text = "Current Month";
			this.curMonth.UseVisualStyleBackColor = true;
			this.curMonth.CheckedChanged += new System.EventHandler(this.curMonth_CheckedChanged);
			// 
			// appointmentsforcurmonthBindingSource
			// 
			this.appointmentsforcurmonthBindingSource.DataMember = "appointments_for_cur_month";
			// 
			// dataGridView3
			// 
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn});
			this.dataGridView3.DataSource = this.appointmentsforcurmonthBindingSource1;
			this.dataGridView3.Location = new System.Drawing.Point(214, 511);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.RowHeadersWidth = 51;
			this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView3.Size = new System.Drawing.Size(1087, 233);
			this.dataGridView3.TabIndex = 15;
			// 
			// iDDataGridViewTextBoxColumn1
			// 
			this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
			this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn1.Width = 125;
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn1.Width = 125;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "title";
			this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.ReadOnly = true;
			this.titleDataGridViewTextBoxColumn.Width = 125;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
			this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			this.descriptionDataGridViewTextBoxColumn.Width = 125;
			// 
			// locationDataGridViewTextBoxColumn
			// 
			this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
			this.locationDataGridViewTextBoxColumn.HeaderText = "location";
			this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
			this.locationDataGridViewTextBoxColumn.ReadOnly = true;
			this.locationDataGridViewTextBoxColumn.Width = 125;
			// 
			// contactDataGridViewTextBoxColumn
			// 
			this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
			this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
			this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
			this.contactDataGridViewTextBoxColumn.ReadOnly = true;
			this.contactDataGridViewTextBoxColumn.Width = 125;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "type";
			this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeDataGridViewTextBoxColumn.Width = 125;
			// 
			// startDataGridViewTextBoxColumn
			// 
			this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
			this.startDataGridViewTextBoxColumn.HeaderText = "start";
			this.startDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
			this.startDataGridViewTextBoxColumn.ReadOnly = true;
			this.startDataGridViewTextBoxColumn.Width = 125;
			// 
			// appointmentsforcurmonthBindingSource1
			// 
			this.appointmentsforcurmonthBindingSource1.DataMember = "appointments_for_cur_month";
			this.appointmentsforcurmonthBindingSource1.DataSource = this.u057MVDataSet3_cur_month;
			// 
			// u057MVDataSet3_cur_month
			// 
			this.u057MVDataSet3_cur_month.DataSetName = "U057MVDataSet3_cur_month";
			this.u057MVDataSet3_cur_month.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// appointments_for_cur_monthTableAdapter1
			// 
			this.appointments_for_cur_monthTableAdapter1.ClearBeforeFill = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.titleDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.locationDataGridViewTextBoxColumn1,
            this.contactDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.startDataGridViewTextBoxColumn1});
			this.dataGridView2.DataSource = this.appointmentsforcurweekBindingSource1;
			this.dataGridView2.Location = new System.Drawing.Point(214, 511);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(1087, 233);
			this.dataGridView2.TabIndex = 16;
			// 
			// iDDataGridViewTextBoxColumn2
			// 
			this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
			this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn2.Width = 125;
			// 
			// nameDataGridViewTextBoxColumn2
			// 
			this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
			this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn2.Width = 125;
			// 
			// titleDataGridViewTextBoxColumn1
			// 
			this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
			this.titleDataGridViewTextBoxColumn1.HeaderText = "title";
			this.titleDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
			this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
			this.titleDataGridViewTextBoxColumn1.Width = 125;
			// 
			// descriptionDataGridViewTextBoxColumn1
			// 
			this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
			this.descriptionDataGridViewTextBoxColumn1.HeaderText = "description";
			this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
			this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
			this.descriptionDataGridViewTextBoxColumn1.Width = 125;
			// 
			// locationDataGridViewTextBoxColumn1
			// 
			this.locationDataGridViewTextBoxColumn1.DataPropertyName = "location";
			this.locationDataGridViewTextBoxColumn1.HeaderText = "location";
			this.locationDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.locationDataGridViewTextBoxColumn1.Name = "locationDataGridViewTextBoxColumn1";
			this.locationDataGridViewTextBoxColumn1.ReadOnly = true;
			this.locationDataGridViewTextBoxColumn1.Width = 125;
			// 
			// contactDataGridViewTextBoxColumn1
			// 
			this.contactDataGridViewTextBoxColumn1.DataPropertyName = "contact";
			this.contactDataGridViewTextBoxColumn1.HeaderText = "contact";
			this.contactDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.contactDataGridViewTextBoxColumn1.Name = "contactDataGridViewTextBoxColumn1";
			this.contactDataGridViewTextBoxColumn1.ReadOnly = true;
			this.contactDataGridViewTextBoxColumn1.Width = 125;
			// 
			// typeDataGridViewTextBoxColumn1
			// 
			this.typeDataGridViewTextBoxColumn1.DataPropertyName = "type";
			this.typeDataGridViewTextBoxColumn1.HeaderText = "type";
			this.typeDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
			this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
			this.typeDataGridViewTextBoxColumn1.Width = 125;
			// 
			// startDataGridViewTextBoxColumn1
			// 
			this.startDataGridViewTextBoxColumn1.DataPropertyName = "start";
			this.startDataGridViewTextBoxColumn1.HeaderText = "start";
			this.startDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.startDataGridViewTextBoxColumn1.Name = "startDataGridViewTextBoxColumn1";
			this.startDataGridViewTextBoxColumn1.ReadOnly = true;
			this.startDataGridViewTextBoxColumn1.Width = 125;
			// 
			// appointmentsforcurweekBindingSource1
			// 
			this.appointmentsforcurweekBindingSource1.DataMember = "appointments_for_cur_week";
			this.appointmentsforcurweekBindingSource1.DataSource = this.u057MVDataSet3;
			// 
			// u057MVDataSet3
			// 
			this.u057MVDataSet3.DataSetName = "U057MVDataSet3";
			this.u057MVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// appointments_for_cur_weekTableAdapter1
			// 
			this.appointments_for_cur_weekTableAdapter1.ClearBeforeFill = true;
			// 
			// refreshAppointments
			// 
			this.refreshAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshAppointments.ForeColor = System.Drawing.Color.Black;
			this.refreshAppointments.Location = new System.Drawing.Point(869, 467);
			this.refreshAppointments.Name = "refreshAppointments";
			this.refreshAppointments.Size = new System.Drawing.Size(106, 31);
			this.refreshAppointments.TabIndex = 17;
			this.refreshAppointments.Text = "Refresh";
			this.refreshAppointments.UseVisualStyleBackColor = true;
			this.refreshAppointments.Click += new System.EventHandler(this.refreshAppointments_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1143, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 31);
			this.label2.TabIndex = 18;
			this.label2.Text = "Reports";
			// 
			// appointmentpermonthbtn
			// 
			this.appointmentpermonthbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentpermonthbtn.ForeColor = System.Drawing.Color.Black;
			this.appointmentpermonthbtn.Location = new System.Drawing.Point(1124, 107);
			this.appointmentpermonthbtn.Name = "appointmentpermonthbtn";
			this.appointmentpermonthbtn.Size = new System.Drawing.Size(128, 53);
			this.appointmentpermonthbtn.TabIndex = 19;
			this.appointmentpermonthbtn.Text = "View Reports";
			this.appointmentpermonthbtn.UseVisualStyleBackColor = true;
			this.appointmentpermonthbtn.Click += new System.EventHandler(this.appointmentpermonthbtn_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1402, 872);
			this.Controls.Add(this.appointmentpermonthbtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.refreshAppointments);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.curMonth);
			this.Controls.Add(this.curWeek);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.delCustomer);
			this.Controls.Add(this.updateCustomer);
			this.Controls.Add(this.addCustomer);
			this.Controls.Add(this.upcomingAppts);
			this.Controls.Add(this.deleteAppointment);
			this.Controls.Add(this.updateAppointment);
			this.Controls.Add(this.addAppointment);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.DarkGray;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.u057MVDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsforcurweekBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsforcurmonthBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsforcurmonthBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.u057MVDataSet3_cur_month)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsforcurweekBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.u057MVDataSet3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addAppointment;
		private System.Windows.Forms.Button updateAppointment;
		private System.Windows.Forms.Button deleteAppointment;
		private System.Windows.Forms.Label upcomingAppts;
		private System.Windows.Forms.Button delCustomer;
		private System.Windows.Forms.Button updateCustomer;
		private System.Windows.Forms.Button addCustomer;
		private System.Windows.Forms.BindingSource dashboardBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private U057MVDataSet1 u057MVDataSet1;
		private System.Windows.Forms.BindingSource dashboardBindingSource1;
		private U057MVDataSet1TableAdapters.dashboardTableAdapter dashboardTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.BindingSource appointmentsforcurweekBindingSource;
		private System.Windows.Forms.RadioButton curWeek;
		private System.Windows.Forms.RadioButton curMonth;
		private System.Windows.Forms.BindingSource appointmentsforcurmonthBindingSource;
		private System.Windows.Forms.DataGridView dataGridView3;
		private U057MVDataSet3_cur_month u057MVDataSet3_cur_month;
		private System.Windows.Forms.BindingSource appointmentsforcurmonthBindingSource1;
		private U057MVDataSet3_cur_monthTableAdapters.appointments_for_cur_monthTableAdapter appointments_for_cur_monthTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private U057MVDataSet3 u057MVDataSet3;
		private System.Windows.Forms.BindingSource appointmentsforcurweekBindingSource1;
		private U057MVDataSet3TableAdapters.appointments_for_cur_weekTableAdapter appointments_for_cur_weekTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn1;
		private System.Windows.Forms.Button refreshAppointments;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button appointmentpermonthbtn;
	}
}