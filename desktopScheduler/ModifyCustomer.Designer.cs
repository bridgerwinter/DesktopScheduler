
namespace desktopScheduler
{
	partial class ModifyCustomer
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.addressLabel = new System.Windows.Forms.Label();
			this.zipCodeLabel = new System.Windows.Forms.Label();
			this.Label = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.address = new System.Windows.Forms.TextBox();
			this.zip = new System.Windows.Forms.TextBox();
			this.phone = new System.Windows.Forms.TextBox();
			this.cancel = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.customerid = new System.Windows.Forms.TextBox();
			this.customeridLabel = new System.Windows.Forms.Label();
			this.addressidLabel = new System.Windows.Forms.Label();
			this.addressid = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.BackColor = System.Drawing.Color.White;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLabel.Location = new System.Drawing.Point(99, 82);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(68, 25);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name";
			// 
			// addressLabel
			// 
			this.addressLabel.AutoSize = true;
			this.addressLabel.BackColor = System.Drawing.Color.White;
			this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressLabel.Location = new System.Drawing.Point(76, 134);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(91, 25);
			this.addressLabel.TabIndex = 1;
			this.addressLabel.Text = "Address";
			// 
			// zipCodeLabel
			// 
			this.zipCodeLabel.AutoSize = true;
			this.zipCodeLabel.BackColor = System.Drawing.Color.White;
			this.zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zipCodeLabel.Location = new System.Drawing.Point(68, 192);
			this.zipCodeLabel.Name = "zipCodeLabel";
			this.zipCodeLabel.Size = new System.Drawing.Size(99, 25);
			this.zipCodeLabel.TabIndex = 2;
			this.zipCodeLabel.Text = "Zip Code";
			// 
			// Label
			// 
			this.Label.AutoSize = true;
			this.Label.BackColor = System.Drawing.Color.White;
			this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label.Location = new System.Drawing.Point(12, 243);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(155, 25);
			this.Label.TabIndex = 3;
			this.Label.Text = "Phone Number";
			// 
			// name
			// 
			this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name.Location = new System.Drawing.Point(183, 76);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(208, 31);
			this.name.TabIndex = 4;
			// 
			// address
			// 
			this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.address.Location = new System.Drawing.Point(183, 131);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(208, 31);
			this.address.TabIndex = 5;
			// 
			// zip
			// 
			this.zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zip.Location = new System.Drawing.Point(183, 186);
			this.zip.Name = "zip";
			this.zip.Size = new System.Drawing.Size(208, 31);
			this.zip.TabIndex = 6;
			// 
			// phone
			// 
			this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phone.Location = new System.Drawing.Point(183, 240);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(208, 31);
			this.phone.TabIndex = 7;
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(216, 344);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(109, 31);
			this.cancel.TabIndex = 9;
			this.cancel.Text = "Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(51, 344);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(109, 31);
			this.save.TabIndex = 10;
			this.save.Text = "Save";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// customerid
			// 
			this.customerid.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.customerid.Location = new System.Drawing.Point(83, 300);
			this.customerid.Name = "customerid";
			this.customerid.ReadOnly = true;
			this.customerid.Size = new System.Drawing.Size(51, 20);
			this.customerid.TabIndex = 11;
			// 
			// customeridLabel
			// 
			this.customeridLabel.AutoSize = true;
			this.customeridLabel.ForeColor = System.Drawing.Color.White;
			this.customeridLabel.Location = new System.Drawing.Point(12, 303);
			this.customeridLabel.Name = "customeridLabel";
			this.customeridLabel.Size = new System.Drawing.Size(65, 13);
			this.customeridLabel.TabIndex = 12;
			this.customeridLabel.Text = "Customer ID";
			// 
			// addressidLabel
			// 
			this.addressidLabel.AutoSize = true;
			this.addressidLabel.ForeColor = System.Drawing.Color.White;
			this.addressidLabel.Location = new System.Drawing.Point(157, 303);
			this.addressidLabel.Name = "addressidLabel";
			this.addressidLabel.Size = new System.Drawing.Size(59, 13);
			this.addressidLabel.TabIndex = 13;
			this.addressidLabel.Text = "Address ID";
			// 
			// addressid
			// 
			this.addressid.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.addressid.Location = new System.Drawing.Point(222, 300);
			this.addressid.Name = "addressid";
			this.addressid.ReadOnly = true;
			this.addressid.Size = new System.Drawing.Size(57, 20);
			this.addressid.TabIndex = 14;
			// 
			// ModifyCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(403, 422);
			this.Controls.Add(this.addressid);
			this.Controls.Add(this.addressidLabel);
			this.Controls.Add(this.customeridLabel);
			this.Controls.Add(this.customerid);
			this.Controls.Add(this.save);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.phone);
			this.Controls.Add(this.zip);
			this.Controls.Add(this.address);
			this.Controls.Add(this.name);
			this.Controls.Add(this.Label);
			this.Controls.Add(this.zipCodeLabel);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.nameLabel);
			this.Name = "ModifyCustomer";
			this.Text = "ModifyCustomer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label addressLabel;
		private System.Windows.Forms.Label zipCodeLabel;
		private System.Windows.Forms.Label Label;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox address;
		private System.Windows.Forms.TextBox zip;
		private System.Windows.Forms.TextBox phone;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.TextBox customerid;
		private System.Windows.Forms.Label customeridLabel;
		private System.Windows.Forms.Label addressidLabel;
		private System.Windows.Forms.TextBox addressid;
	}
}