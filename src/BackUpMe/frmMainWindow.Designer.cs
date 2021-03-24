
namespace BackUpMe
{
	partial class frmMainWindow
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
			this.mainWindowToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnl_sidebar = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_about = new System.Windows.Forms.LinkLabel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnActivityLogs = new System.Windows.Forms.Button();
			this.btnScheduleTasks = new System.Windows.Forms.Button();
			this.btnCreateTask = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pnl_mainpage = new System.Windows.Forms.Panel();
			this.pnl_header = new System.Windows.Forms.Panel();
			this.btnMinimizeApplication = new System.Windows.Forms.Button();
			this.BtnCloseApplication = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnl_sidebar.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.pnl_header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnl_sidebar
			// 
			this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
			this.pnl_sidebar.Controls.Add(this.panel3);
			this.pnl_sidebar.Controls.Add(this.panel2);
			this.pnl_sidebar.Controls.Add(this.pictureBox1);
			this.pnl_sidebar.Controls.Add(this.label1);
			this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
			this.pnl_sidebar.Name = "pnl_sidebar";
			this.pnl_sidebar.Size = new System.Drawing.Size(200, 471);
			this.pnl_sidebar.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
			this.panel3.Location = new System.Drawing.Point(0, 110);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 1);
			this.panel3.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lbl_about);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.btnSettings);
			this.panel2.Controls.Add(this.btnActivityLogs);
			this.panel2.Controls.Add(this.btnScheduleTasks);
			this.panel2.Controls.Add(this.btnCreateTask);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 124);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.panel2.Size = new System.Drawing.Size(200, 347);
			this.panel2.TabIndex = 2;
			// 
			// lbl_about
			// 
			this.lbl_about.AutoSize = true;
			this.lbl_about.LinkColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl_about.Location = new System.Drawing.Point(11, 326);
			this.lbl_about.Name = "lbl_about";
			this.lbl_about.Size = new System.Drawing.Size(116, 13);
			this.lbl_about.TabIndex = 4;
			this.lbl_about.TabStop = true;
			this.lbl_about.Text = "Created by HaruTzuki";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.panel4.Location = new System.Drawing.Point(-5, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 212);
			this.panel4.TabIndex = 3;
			// 
			// btnSettings
			// 
			this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnSettings.Location = new System.Drawing.Point(15, 159);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(185, 53);
			this.btnSettings.TabIndex = 3;
			this.btnSettings.Tag = "Settings";
			this.btnSettings.Text = "Settings";
			this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.btnMenuClick_Click);
			// 
			// btnActivityLogs
			// 
			this.btnActivityLogs.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnActivityLogs.FlatAppearance.BorderSize = 0;
			this.btnActivityLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActivityLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnActivityLogs.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnActivityLogs.Location = new System.Drawing.Point(15, 106);
			this.btnActivityLogs.Name = "btnActivityLogs";
			this.btnActivityLogs.Size = new System.Drawing.Size(185, 53);
			this.btnActivityLogs.TabIndex = 2;
			this.btnActivityLogs.Tag = "ActivityLogs";
			this.btnActivityLogs.Text = "Activity Logs";
			this.btnActivityLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActivityLogs.UseVisualStyleBackColor = true;
			this.btnActivityLogs.Click += new System.EventHandler(this.btnMenuClick_Click);
			// 
			// btnScheduleTasks
			// 
			this.btnScheduleTasks.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnScheduleTasks.FlatAppearance.BorderSize = 0;
			this.btnScheduleTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnScheduleTasks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnScheduleTasks.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnScheduleTasks.Location = new System.Drawing.Point(15, 53);
			this.btnScheduleTasks.Name = "btnScheduleTasks";
			this.btnScheduleTasks.Size = new System.Drawing.Size(185, 53);
			this.btnScheduleTasks.TabIndex = 1;
			this.btnScheduleTasks.Tag = "ScheduledTasks";
			this.btnScheduleTasks.Text = "Scheduled Tasks";
			this.btnScheduleTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnScheduleTasks.UseVisualStyleBackColor = true;
			this.btnScheduleTasks.Click += new System.EventHandler(this.btnMenuClick_Click);
			// 
			// btnCreateTask
			// 
			this.btnCreateTask.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCreateTask.FlatAppearance.BorderSize = 0;
			this.btnCreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateTask.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnCreateTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCreateTask.Location = new System.Drawing.Point(15, 0);
			this.btnCreateTask.Name = "btnCreateTask";
			this.btnCreateTask.Size = new System.Drawing.Size(185, 53);
			this.btnCreateTask.TabIndex = 0;
			this.btnCreateTask.Tag = "CreateTask";
			this.btnCreateTask.Text = "Create Task";
			this.btnCreateTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCreateTask.UseVisualStyleBackColor = true;
			this.btnCreateTask.Click += new System.EventHandler(this.btnMenuClick_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(23, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "BackUp Me";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.pnl_mainpage);
			this.panel5.Controls.Add(this.pnl_header);
			this.panel5.Controls.Add(this.pnl_sidebar);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(792, 473);
			this.panel5.TabIndex = 3;
			// 
			// pnl_mainpage
			// 
			this.pnl_mainpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.pnl_mainpage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_mainpage.Location = new System.Drawing.Point(200, 36);
			this.pnl_mainpage.Name = "pnl_mainpage";
			this.pnl_mainpage.Size = new System.Drawing.Size(590, 435);
			this.pnl_mainpage.TabIndex = 3;
			// 
			// pnl_header
			// 
			this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.pnl_header.Controls.Add(this.btnMinimizeApplication);
			this.pnl_header.Controls.Add(this.BtnCloseApplication);
			this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_header.Location = new System.Drawing.Point(200, 0);
			this.pnl_header.Name = "pnl_header";
			this.pnl_header.Size = new System.Drawing.Size(590, 36);
			this.pnl_header.TabIndex = 2;
			this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
			// 
			// btnMinimizeApplication
			// 
			this.btnMinimizeApplication.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMinimizeApplication.FlatAppearance.BorderSize = 0;
			this.btnMinimizeApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimizeApplication.Image = global::BackUpMe.Properties.Resources.minimize_16_16;
			this.btnMinimizeApplication.Location = new System.Drawing.Point(518, 0);
			this.btnMinimizeApplication.Name = "btnMinimizeApplication";
			this.btnMinimizeApplication.Size = new System.Drawing.Size(36, 36);
			this.btnMinimizeApplication.TabIndex = 1;
			this.btnMinimizeApplication.UseVisualStyleBackColor = true;
			// 
			// BtnCloseApplication
			// 
			this.BtnCloseApplication.Dock = System.Windows.Forms.DockStyle.Right;
			this.BtnCloseApplication.FlatAppearance.BorderSize = 0;
			this.BtnCloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCloseApplication.Image = global::BackUpMe.Properties.Resources.close_16_16;
			this.BtnCloseApplication.Location = new System.Drawing.Point(554, 0);
			this.BtnCloseApplication.Name = "BtnCloseApplication";
			this.BtnCloseApplication.Size = new System.Drawing.Size(36, 36);
			this.BtnCloseApplication.TabIndex = 0;
			this.BtnCloseApplication.UseVisualStyleBackColor = true;
			this.BtnCloseApplication.Click += new System.EventHandler(this.BtnCloseApplication_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(70, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// frmMainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.ClientSize = new System.Drawing.Size(792, 473);
			this.Controls.Add(this.panel5);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BackUpMe";
			this.pnl_sidebar.ResumeLayout(false);
			this.pnl_sidebar.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.pnl_header.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolTip mainWindowToolTip;
		private System.Windows.Forms.Panel pnl_sidebar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnActivityLogs;
		private System.Windows.Forms.Button btnScheduleTasks;
		private System.Windows.Forms.Button btnCreateTask;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.LinkLabel lbl_about;
		private System.Windows.Forms.Panel pnl_header;
		private System.Windows.Forms.Panel pnl_mainpage;
		private System.Windows.Forms.Button BtnCloseApplication;
		private System.Windows.Forms.Button btnMinimizeApplication;
	}
}

