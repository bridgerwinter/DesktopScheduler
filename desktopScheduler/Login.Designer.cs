
namespace desktopScheduler
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.userLabel = new System.Windows.Forms.Label();
			this.passLabel = new System.Windows.Forms.Label();
			this.user = new System.Windows.Forms.TextBox();
			this.pass = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.isValid = new System.Windows.Forms.Label();
			this.isNotValid = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.ForeColor = System.Drawing.Color.Silver;
			this.label2.Name = "label2";
			// 
			// userLabel
			// 
			resources.ApplyResources(this.userLabel, "userLabel");
			this.userLabel.ForeColor = System.Drawing.Color.Silver;
			this.userLabel.Name = "userLabel";
			// 
			// passLabel
			// 
			resources.ApplyResources(this.passLabel, "passLabel");
			this.passLabel.ForeColor = System.Drawing.Color.Silver;
			this.passLabel.Name = "passLabel";
			// 
			// user
			// 
			resources.ApplyResources(this.user, "user");
			this.user.Name = "user";
			// 
			// pass
			// 
			resources.ApplyResources(this.pass, "pass");
			this.pass.Name = "pass";
			// 
			// loginButton
			// 
			resources.ApplyResources(this.loginButton, "loginButton");
			this.loginButton.Name = "loginButton";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// isValid
			// 
			resources.ApplyResources(this.isValid, "isValid");
			this.isValid.Name = "isValid";
			// 
			// isNotValid
			// 
			resources.ApplyResources(this.isNotValid, "isNotValid");
			this.isNotValid.Name = "isNotValid";
			// 
			// Login
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.isNotValid);
			this.Controls.Add(this.isValid);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.pass);
			this.Controls.Add(this.user);
			this.Controls.Add(this.passLabel);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label passLabel;
		private System.Windows.Forms.TextBox user;
		private System.Windows.Forms.TextBox pass;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label isValid;
		private System.Windows.Forms.Label isNotValid;
		private System.Windows.Forms.Label userLabel;
	}
}

