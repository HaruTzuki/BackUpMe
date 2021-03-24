
namespace BackUpMe.Controls.Pages
{
	partial class MainPage
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
			this.components = new System.ComponentModel.Container();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtTaskName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel11 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAddTask = new System.Windows.Forms.Button();
			this.pnl_backuptime = new System.Windows.Forms.Panel();
			this.dtTimeExecution = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.pnl_backupday = new System.Windows.Forms.Panel();
			this.dtp_daymonth = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.rbtn_every_day = new System.Windows.Forms.RadioButton();
			this.btnBrowseDestinationPath = new System.Windows.Forms.Button();
			this.txt_destination_path = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBrowseSourcePath = new System.Windows.Forms.Button();
			this.txt_source_path = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.createTaskErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel6.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnl_backuptime.SuspendLayout();
			this.pnl_backupday.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.createTaskErrorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.panel6.Controls.Add(this.txtTaskName);
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.panel11);
			this.panel6.Controls.Add(this.radioButton2);
			this.panel6.Controls.Add(this.radioButton1);
			this.panel6.Controls.Add(this.rbtn_every_day);
			this.panel6.Controls.Add(this.btnBrowseDestinationPath);
			this.panel6.Controls.Add(this.txt_destination_path);
			this.panel6.Controls.Add(this.label4);
			this.panel6.Controls.Add(this.btnBrowseSourcePath);
			this.panel6.Controls.Add(this.txt_source_path);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.label2);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(816, 652);
			this.panel6.TabIndex = 4;
			// 
			// txtTaskName
			// 
			this.txtTaskName.Location = new System.Drawing.Point(17, 113);
			this.txtTaskName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTaskName.Name = "txtTaskName";
			this.txtTaskName.Size = new System.Drawing.Size(629, 27);
			this.txtTaskName.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(17, 88);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "Task Name";
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.panel1);
			this.panel11.Controls.Add(this.pnl_backuptime);
			this.panel11.Controls.Add(this.pnl_backupday);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel11.Location = new System.Drawing.Point(0, 342);
			this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(816, 310);
			this.panel11.TabIndex = 20;
			this.panel11.Tag = "EveryDay";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAddTask);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 54);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(816, 111);
			this.panel1.TabIndex = 21;
			// 
			// btnAddTask
			// 
			this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
			this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(66)))), ((int)(((byte)(118)))));
			this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddTask.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAddTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAddTask.Location = new System.Drawing.Point(687, 9);
			this.btnAddTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddTask.Name = "btnAddTask";
			this.btnAddTask.Size = new System.Drawing.Size(125, 85);
			this.btnAddTask.TabIndex = 20;
			this.btnAddTask.Text = "Add Task";
			this.btnAddTask.UseVisualStyleBackColor = false;
			this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
			// 
			// pnl_backuptime
			// 
			this.pnl_backuptime.Controls.Add(this.dtTimeExecution);
			this.pnl_backuptime.Controls.Add(this.label6);
			this.pnl_backuptime.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_backuptime.Location = new System.Drawing.Point(0, 0);
			this.pnl_backuptime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnl_backuptime.Name = "pnl_backuptime";
			this.pnl_backuptime.Size = new System.Drawing.Size(816, 54);
			this.pnl_backuptime.TabIndex = 18;
			// 
			// dtTimeExecution
			// 
			this.dtTimeExecution.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtTimeExecution.Location = new System.Drawing.Point(135, 9);
			this.dtTimeExecution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dtTimeExecution.Name = "dtTimeExecution";
			this.dtTimeExecution.Size = new System.Drawing.Size(244, 27);
			this.dtTimeExecution.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(20, 9);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 17;
			this.label6.Text = "Backup Time:";
			// 
			// pnl_backupday
			// 
			this.pnl_backupday.Controls.Add(this.dtp_daymonth);
			this.pnl_backupday.Controls.Add(this.label5);
			this.pnl_backupday.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_backupday.Location = new System.Drawing.Point(0, 0);
			this.pnl_backupday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pnl_backupday.Name = "pnl_backupday";
			this.pnl_backupday.Size = new System.Drawing.Size(816, 0);
			this.pnl_backupday.TabIndex = 19;
			// 
			// dtp_daymonth
			// 
			this.dtp_daymonth.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtp_daymonth.Location = new System.Drawing.Point(135, 9);
			this.dtp_daymonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dtp_daymonth.Name = "dtp_daymonth";
			this.dtp_daymonth.Size = new System.Drawing.Size(244, 27);
			this.dtp_daymonth.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(20, 9);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Schedule:";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.radioButton2.Location = new System.Drawing.Point(250, 308);
			this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(119, 24);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.Tag = "EveryMonth";
			this.radioButton2.Text = "Every Month";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.rbtn_backUpType_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.radioButton1.Location = new System.Drawing.Point(128, 308);
			this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(111, 24);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.Tag = "EveryWeek";
			this.radioButton1.Text = "Every Week";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.rbtn_backUpType_CheckedChanged);
			// 
			// rbtn_every_day
			// 
			this.rbtn_every_day.AutoSize = true;
			this.rbtn_every_day.Checked = true;
			this.rbtn_every_day.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.rbtn_every_day.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.rbtn_every_day.Location = new System.Drawing.Point(17, 308);
			this.rbtn_every_day.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbtn_every_day.Name = "rbtn_every_day";
			this.rbtn_every_day.Size = new System.Drawing.Size(100, 24);
			this.rbtn_every_day.TabIndex = 11;
			this.rbtn_every_day.TabStop = true;
			this.rbtn_every_day.Tag = "EveryDay";
			this.rbtn_every_day.Text = "Every Day";
			this.rbtn_every_day.UseVisualStyleBackColor = true;
			this.rbtn_every_day.CheckedChanged += new System.EventHandler(this.rbtn_backUpType_CheckedChanged);
			// 
			// btnBrowseDestinationPath
			// 
			this.btnBrowseDestinationPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
			this.btnBrowseDestinationPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(66)))), ((int)(((byte)(118)))));
			this.btnBrowseDestinationPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowseDestinationPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBrowseDestinationPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnBrowseDestinationPath.Location = new System.Drawing.Point(656, 262);
			this.btnBrowseDestinationPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBrowseDestinationPath.Name = "btnBrowseDestinationPath";
			this.btnBrowseDestinationPath.Size = new System.Drawing.Size(101, 42);
			this.btnBrowseDestinationPath.TabIndex = 10;
			this.btnBrowseDestinationPath.Text = "Browse...";
			this.btnBrowseDestinationPath.UseVisualStyleBackColor = false;
			this.btnBrowseDestinationPath.Click += new System.EventHandler(this.btnBrowseDestinationPath_Click);
			// 
			// txt_destination_path
			// 
			this.txt_destination_path.Location = new System.Drawing.Point(17, 268);
			this.txt_destination_path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_destination_path.Name = "txt_destination_path";
			this.txt_destination_path.Size = new System.Drawing.Size(629, 27);
			this.txt_destination_path.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(13, 241);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Destination Path:";
			// 
			// btnBrowseSourcePath
			// 
			this.btnBrowseSourcePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
			this.btnBrowseSourcePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(66)))), ((int)(((byte)(118)))));
			this.btnBrowseSourcePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowseSourcePath.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBrowseSourcePath.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnBrowseSourcePath.Location = new System.Drawing.Point(656, 182);
			this.btnBrowseSourcePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBrowseSourcePath.Name = "btnBrowseSourcePath";
			this.btnBrowseSourcePath.Size = new System.Drawing.Size(101, 42);
			this.btnBrowseSourcePath.TabIndex = 7;
			this.btnBrowseSourcePath.Text = "Browse...";
			this.btnBrowseSourcePath.UseVisualStyleBackColor = false;
			this.btnBrowseSourcePath.Click += new System.EventHandler(this.btnBrowseSourcePath_Click);
			// 
			// txt_source_path
			// 
			this.txt_source_path.Location = new System.Drawing.Point(17, 188);
			this.txt_source_path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_source_path.Name = "txt_source_path";
			this.txt_source_path.Size = new System.Drawing.Size(629, 27);
			this.txt_source_path.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(17, 163);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Source Path:";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel8.Location = new System.Drawing.Point(24, 66);
			this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(397, 3);
			this.panel8.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(17, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Create Job";
			// 
			// createTaskErrorProvider
			// 
			this.createTaskErrorProvider.ContainerControl = this;
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel6);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainPage";
			this.Size = new System.Drawing.Size(816, 652);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel11.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.pnl_backuptime.ResumeLayout(false);
			this.pnl_backuptime.PerformLayout();
			this.pnl_backupday.ResumeLayout(false);
			this.pnl_backupday.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.createTaskErrorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAddTask;
		private System.Windows.Forms.Panel pnl_backuptime;
		private System.Windows.Forms.DateTimePicker dtTimeExecution;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel pnl_backupday;
		private System.Windows.Forms.DateTimePicker dtp_daymonth;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton rbtn_every_day;
		private System.Windows.Forms.Button btnBrowseDestinationPath;
		private System.Windows.Forms.TextBox txt_destination_path;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBrowseSourcePath;
		private System.Windows.Forms.TextBox txt_source_path;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTaskName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider createTaskErrorProvider;
	}
}
