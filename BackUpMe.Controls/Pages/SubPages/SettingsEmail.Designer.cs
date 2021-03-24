
namespace BackUpMe.Controls.Pages.SubPages
{
	partial class SettingsEmail
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnl_background = new System.Windows.Forms.Panel();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtHostName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkEmailSender = new System.Windows.Forms.CheckBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pnl_background.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_background
			// 
			this.pnl_background.AutoScroll = true;
			this.pnl_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
			this.pnl_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_background.Controls.Add(this.checkBox2);
			this.pnl_background.Controls.Add(this.label5);
			this.pnl_background.Controls.Add(this.txtPassword);
			this.pnl_background.Controls.Add(this.label4);
			this.pnl_background.Controls.Add(this.txtUsername);
			this.pnl_background.Controls.Add(this.label3);
			this.pnl_background.Controls.Add(this.txtPort);
			this.pnl_background.Controls.Add(this.label2);
			this.pnl_background.Controls.Add(this.txtHostName);
			this.pnl_background.Controls.Add(this.label1);
			this.pnl_background.Controls.Add(this.chkEmailSender);
			this.pnl_background.Controls.Add(this.panel5);
			this.pnl_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_background.Location = new System.Drawing.Point(0, 0);
			this.pnl_background.Name = "pnl_background";
			this.pnl_background.Size = new System.Drawing.Size(405, 297);
			this.pnl_background.TabIndex = 1;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(72, 207);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(15, 14);
			this.checkBox2.TabIndex = 27;
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label5.Location = new System.Drawing.Point(3, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 15);
			this.label5.TabIndex = 26;
			this.label5.Text = "SSL:";
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Location = new System.Drawing.Point(6, 181);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(394, 22);
			this.txtPassword.TabIndex = 25;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label4.Location = new System.Drawing.Point(3, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 15);
			this.label4.TabIndex = 24;
			this.label4.Text = "Password:";
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUsername.Location = new System.Drawing.Point(6, 138);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(394, 22);
			this.txtUsername.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label3.Location = new System.Drawing.Point(3, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 15);
			this.label3.TabIndex = 22;
			this.label3.Text = "Username:";
			// 
			// txtPort
			// 
			this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPort.Location = new System.Drawing.Point(6, 95);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(394, 22);
			this.txtPort.TabIndex = 21;
			this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
			this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label2.Location = new System.Drawing.Point(3, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 15);
			this.label2.TabIndex = 20;
			this.label2.Text = "Port:";
			// 
			// txtHostName
			// 
			this.txtHostName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHostName.Location = new System.Drawing.Point(6, 52);
			this.txtHostName.Name = "txtHostName";
			this.txtHostName.Size = new System.Drawing.Size(394, 22);
			this.txtHostName.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label1.Location = new System.Drawing.Point(3, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 15);
			this.label1.TabIndex = 18;
			this.label1.Text = "Host (Domain):";
			// 
			// chkEmailSender
			// 
			this.chkEmailSender.AutoSize = true;
			this.chkEmailSender.Location = new System.Drawing.Point(6, 14);
			this.chkEmailSender.Name = "chkEmailSender";
			this.chkEmailSender.Size = new System.Drawing.Size(61, 17);
			this.chkEmailSender.TabIndex = 17;
			this.chkEmailSender.Text = "Enable";
			this.chkEmailSender.UseVisualStyleBackColor = true;
			this.chkEmailSender.CheckedChanged += new System.EventHandler(this.chkEmailSender_CheckedChanged);
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 270);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(403, 25);
			this.panel5.TabIndex = 16;
			// 
			// SettingsEmail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnl_background);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Name = "SettingsEmail";
			this.Size = new System.Drawing.Size(405, 297);
			this.pnl_background.ResumeLayout(false);
			this.pnl_background.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl_background;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtHostName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkEmailSender;
	}
}
