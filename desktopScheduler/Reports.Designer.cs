
namespace desktopScheduler
{
	partial class Reports
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
			this.rpttotalappointments = new System.Windows.Forms.DataGridView();
			this.rpt_total_appointments_per_user = new desktopScheduler.rpt_total_appointments_per_user();
			this.rpttotalappointmentsperuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rpt_total_appointments_per_userTableAdapter = new desktopScheduler.rpt_total_appointments_per_userTableAdapters.rpt_total_appointments_per_userTableAdapter();
			this.totalappointmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rpttype = new System.Windows.Forms.DataGridView();
			this.rpt_total_type = new desktopScheduler.rpt_total_type();
			this.rpttotaltypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rpt_total_typeTableAdapter = new desktopScheduler.rpt_total_typeTableAdapters.rpt_total_typeTableAdapter();
			this.totaltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rptusersched = new System.Windows.Forms.DataGridView();
			this.rpt_user_schedule = new desktopScheduler.rpt_user_schedule();
			this.rptuserscheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rpt_user_scheduleTableAdapter = new desktopScheduler.rpt_user_scheduleTableAdapters.rpt_user_scheduleTableAdapter();
			this.customernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalappointmentsperuser = new System.Windows.Forms.RadioButton();
			this.totalpertype = new System.Windows.Forms.RadioButton();
			this.schedule_per_user = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.rpttotalappointments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpt_total_appointments_per_user)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpttotalappointmentsperuserBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpttype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpt_total_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpttotaltypeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rptusersched)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rpt_user_schedule)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rptuserscheduleBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// rpttotalappointments
			// 
			this.rpttotalappointments.AutoGenerateColumns = false;
			this.rpttotalappointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rpttotalappointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalappointmentsDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn});
			this.rpttotalappointments.DataSource = this.rpttotalappointmentsperuserBindingSource;
			this.rpttotalappointments.Location = new System.Drawing.Point(12, 175);
			this.rpttotalappointments.Name = "rpttotalappointments";
			this.rpttotalappointments.Size = new System.Drawing.Size(424, 494);
			this.rpttotalappointments.TabIndex = 0;
			// 
			// rpt_total_appointments_per_user
			// 
			this.rpt_total_appointments_per_user.DataSetName = "rpt_total_appointments_per_user";
			this.rpt_total_appointments_per_user.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// rpttotalappointmentsperuserBindingSource
			// 
			this.rpttotalappointmentsperuserBindingSource.DataMember = "rpt_total_appointments_per_user";
			this.rpttotalappointmentsperuserBindingSource.DataSource = this.rpt_total_appointments_per_user;
			// 
			// rpt_total_appointments_per_userTableAdapter
			// 
			this.rpt_total_appointments_per_userTableAdapter.ClearBeforeFill = true;
			// 
			// totalappointmentsDataGridViewTextBoxColumn
			// 
			this.totalappointmentsDataGridViewTextBoxColumn.DataPropertyName = "total_appointments";
			this.totalappointmentsDataGridViewTextBoxColumn.HeaderText = "total_appointments";
			this.totalappointmentsDataGridViewTextBoxColumn.Name = "totalappointmentsDataGridViewTextBoxColumn";
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			// 
			// rpttype
			// 
			this.rpttype.AutoGenerateColumns = false;
			this.rpttype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rpttype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totaltypeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
			this.rpttype.DataSource = this.rpttotaltypeBindingSource;
			this.rpttype.Location = new System.Drawing.Point(12, 175);
			this.rpttype.Name = "rpttype";
			this.rpttype.Size = new System.Drawing.Size(424, 494);
			this.rpttype.TabIndex = 1;
			// 
			// rpt_total_type
			// 
			this.rpt_total_type.DataSetName = "rpt_total_type";
			this.rpt_total_type.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// rpttotaltypeBindingSource
			// 
			this.rpttotaltypeBindingSource.DataMember = "rpt_total_type";
			this.rpttotaltypeBindingSource.DataSource = this.rpt_total_type;
			// 
			// rpt_total_typeTableAdapter
			// 
			this.rpt_total_typeTableAdapter.ClearBeforeFill = true;
			// 
			// totaltypeDataGridViewTextBoxColumn
			// 
			this.totaltypeDataGridViewTextBoxColumn.DataPropertyName = "total_type";
			this.totaltypeDataGridViewTextBoxColumn.HeaderText = "total_type";
			this.totaltypeDataGridViewTextBoxColumn.Name = "totaltypeDataGridViewTextBoxColumn";
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			// 
			// rptusersched
			// 
			this.rptusersched.AutoGenerateColumns = false;
			this.rptusersched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rptusersched.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customernameDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn});
			this.rptusersched.DataSource = this.rptuserscheduleBindingSource;
			this.rptusersched.Location = new System.Drawing.Point(12, 175);
			this.rptusersched.Name = "rptusersched";
			this.rptusersched.Size = new System.Drawing.Size(424, 494);
			this.rptusersched.TabIndex = 2;
			// 
			// rpt_user_schedule
			// 
			this.rpt_user_schedule.DataSetName = "rpt_user_schedule";
			this.rpt_user_schedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// rptuserscheduleBindingSource
			// 
			this.rptuserscheduleBindingSource.DataMember = "rpt_user_schedule";
			this.rptuserscheduleBindingSource.DataSource = this.rpt_user_schedule;
			// 
			// rpt_user_scheduleTableAdapter
			// 
			this.rpt_user_scheduleTableAdapter.ClearBeforeFill = true;
			// 
			// customernameDataGridViewTextBoxColumn1
			// 
			this.customernameDataGridViewTextBoxColumn1.DataPropertyName = "customername";
			this.customernameDataGridViewTextBoxColumn1.HeaderText = "customername";
			this.customernameDataGridViewTextBoxColumn1.Name = "customernameDataGridViewTextBoxColumn1";
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			// 
			// startDataGridViewTextBoxColumn
			// 
			this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
			this.startDataGridViewTextBoxColumn.HeaderText = "start";
			this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
			// 
			// totalappointmentsperuser
			// 
			this.totalappointmentsperuser.AutoSize = true;
			this.totalappointmentsperuser.Checked = true;
			this.totalappointmentsperuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalappointmentsperuser.Location = new System.Drawing.Point(98, 32);
			this.totalappointmentsperuser.Name = "totalappointmentsperuser";
			this.totalappointmentsperuser.Size = new System.Drawing.Size(305, 29);
			this.totalappointmentsperuser.TabIndex = 3;
			this.totalappointmentsperuser.TabStop = true;
			this.totalappointmentsperuser.Text = "Total Appointments Per User";
			this.totalappointmentsperuser.UseVisualStyleBackColor = true;
			this.totalappointmentsperuser.CheckedChanged += new System.EventHandler(this.totalappointmentsperuser_CheckedChanged);
			// 
			// totalpertype
			// 
			this.totalpertype.AutoSize = true;
			this.totalpertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalpertype.Location = new System.Drawing.Point(98, 67);
			this.totalpertype.Name = "totalpertype";
			this.totalpertype.Size = new System.Drawing.Size(169, 29);
			this.totalpertype.TabIndex = 4;
			this.totalpertype.Text = "Total per Type";
			this.totalpertype.UseVisualStyleBackColor = true;
			this.totalpertype.CheckedChanged += new System.EventHandler(this.totalpertype_CheckedChanged);
			// 
			// schedule_per_user
			// 
			this.schedule_per_user.AutoSize = true;
			this.schedule_per_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.schedule_per_user.Location = new System.Drawing.Point(98, 102);
			this.schedule_per_user.Name = "schedule_per_user";
			this.schedule_per_user.Size = new System.Drawing.Size(208, 29);
			this.schedule_per_user.TabIndex = 5;
			this.schedule_per_user.Text = "Schedule per User";
			this.schedule_per_user.UseVisualStyleBackColor = true;
			this.schedule_per_user.CheckedChanged += new System.EventHandler(this.schedule_per_user_CheckedChanged);
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 695);
			this.Controls.Add(this.schedule_per_user);
			this.Controls.Add(this.totalpertype);
			this.Controls.Add(this.totalappointmentsperuser);
			this.Controls.Add(this.rptusersched);
			this.Controls.Add(this.rpttype);
			this.Controls.Add(this.rpttotalappointments);
			this.Name = "Reports";
			this.Text = "Reports";
			this.Load += new System.EventHandler(this.Reports_Load);
			((System.ComponentModel.ISupportInitialize)(this.rpttotalappointments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpt_total_appointments_per_user)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpttotalappointmentsperuserBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpttype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpt_total_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpttotaltypeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rptusersched)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rpt_user_schedule)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rptuserscheduleBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView rpttotalappointments;
		private rpt_total_appointments_per_user rpt_total_appointments_per_user;
		private System.Windows.Forms.BindingSource rpttotalappointmentsperuserBindingSource;
		private rpt_total_appointments_per_userTableAdapters.rpt_total_appointments_per_userTableAdapter rpt_total_appointments_per_userTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalappointmentsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView rpttype;
		private rpt_total_type rpt_total_type;
		private System.Windows.Forms.BindingSource rpttotaltypeBindingSource;
		private rpt_total_typeTableAdapters.rpt_total_typeTableAdapter rpt_total_typeTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn totaltypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView rptusersched;
		private rpt_user_schedule rpt_user_schedule;
		private System.Windows.Forms.BindingSource rptuserscheduleBindingSource;
		private rpt_user_scheduleTableAdapters.rpt_user_scheduleTableAdapter rpt_user_scheduleTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
		private System.Windows.Forms.RadioButton totalappointmentsperuser;
		private System.Windows.Forms.RadioButton totalpertype;
		private System.Windows.Forms.RadioButton schedule_per_user;
	}
}