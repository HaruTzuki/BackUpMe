
namespace BackUpMe.Controls.Pages
{
	partial class ActivityLogs
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.rbtn_specific_date = new System.Windows.Forms.RadioButton();
			this.rbtn_all_records = new System.Windows.Forms.RadioButton();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.list_view_scheduled_tasks = new System.Windows.Forms.ListView();
			this.col_task_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_started_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_finished_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_job_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel8 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.contextMenu_rows = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.context_ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
			this.context_DeleteTask = new System.Windows.Forms.ToolStripMenuItem();
			this.panel6.SuspendLayout();
			this.panel1.SuspendLayout();
			this.contextMenu_rows.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.panel6.Controls.Add(this.button2);
			this.panel6.Controls.Add(this.button1);
			this.panel6.Controls.Add(this.rbtn_specific_date);
			this.panel6.Controls.Add(this.rbtn_all_records);
			this.panel6.Controls.Add(this.dateTimePicker2);
			this.panel6.Controls.Add(this.dateTimePicker1);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.panel1);
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.label2);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(612, 424);
			this.panel6.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(66)))), ((int)(((byte)(118)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Location = new System.Drawing.Point(442, 74);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 21);
			this.button2.TabIndex = 14;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(66)))), ((int)(((byte)(118)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(336, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 22);
			this.button1.TabIndex = 13;
			this.button1.Text = "Export Excel";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// rbtn_specific_date
			// 
			this.rbtn_specific_date.AutoSize = true;
			this.rbtn_specific_date.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.rbtn_specific_date.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.rbtn_specific_date.Location = new System.Drawing.Point(106, 51);
			this.rbtn_specific_date.Name = "rbtn_specific_date";
			this.rbtn_specific_date.Size = new System.Drawing.Size(91, 17);
			this.rbtn_specific_date.TabIndex = 12;
			this.rbtn_specific_date.Tag = "SpecificDate";
			this.rbtn_specific_date.Text = "Specific Date";
			this.rbtn_specific_date.UseVisualStyleBackColor = true;
			this.rbtn_specific_date.CheckedChanged += new System.EventHandler(this.rbtn_SearchType_CheckedChanged);
			// 
			// rbtn_all_records
			// 
			this.rbtn_all_records.AutoSize = true;
			this.rbtn_all_records.Checked = true;
			this.rbtn_all_records.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.rbtn_all_records.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.rbtn_all_records.Location = new System.Drawing.Point(18, 51);
			this.rbtn_all_records.Name = "rbtn_all_records";
			this.rbtn_all_records.Size = new System.Drawing.Size(82, 17);
			this.rbtn_all_records.TabIndex = 11;
			this.rbtn_all_records.TabStop = true;
			this.rbtn_all_records.Tag = "AllRecords";
			this.rbtn_all_records.Text = "All Records";
			this.rbtn_all_records.UseVisualStyleBackColor = true;
			this.rbtn_all_records.CheckedChanged += new System.EventHandler(this.rbtn_SearchType_CheckedChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
			this.dateTimePicker2.Enabled = false;
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new System.Drawing.Point(240, 74);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(90, 22);
			this.dateTimePicker2.TabIndex = 10;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(87, 74);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(90, 22);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(183, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "To Date:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(15, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "From Date:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.list_view_scheduled_tasks);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 105);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(612, 319);
			this.panel1.TabIndex = 6;
			// 
			// list_view_scheduled_tasks
			// 
			this.list_view_scheduled_tasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.list_view_scheduled_tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_task_name,
            this.col_started_date,
            this.col_finished_date,
            this.col_job_status});
			this.list_view_scheduled_tasks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.list_view_scheduled_tasks.FullRowSelect = true;
			this.list_view_scheduled_tasks.GridLines = true;
			this.list_view_scheduled_tasks.HideSelection = false;
			this.list_view_scheduled_tasks.Location = new System.Drawing.Point(0, 0);
			this.list_view_scheduled_tasks.Name = "list_view_scheduled_tasks";
			this.list_view_scheduled_tasks.Size = new System.Drawing.Size(612, 319);
			this.list_view_scheduled_tasks.TabIndex = 5;
			this.list_view_scheduled_tasks.UseCompatibleStateImageBehavior = false;
			this.list_view_scheduled_tasks.View = System.Windows.Forms.View.Details;
			// 
			// col_task_name
			// 
			this.col_task_name.Text = "Task Name";
			this.col_task_name.Width = 150;
			// 
			// col_started_date
			// 
			this.col_started_date.Text = "Started Date";
			this.col_started_date.Width = 100;
			// 
			// col_finished_date
			// 
			this.col_finished_date.Text = "Finished Date";
			this.col_finished_date.Width = 100;
			// 
			// col_job_status
			// 
			this.col_job_status.Text = "Status";
			this.col_job_status.Width = 100;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel8.Location = new System.Drawing.Point(18, 43);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(298, 2);
			this.panel8.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(13, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Activity Logs";
			// 
			// contextMenu_rows
			// 
			this.contextMenu_rows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_ShowDetails,
            this.context_DeleteTask});
			this.contextMenu_rows.Name = "contextMenu_rows";
			this.contextMenu_rows.Size = new System.Drawing.Size(142, 48);
			// 
			// context_ShowDetails
			// 
			this.context_ShowDetails.Name = "context_ShowDetails";
			this.context_ShowDetails.Size = new System.Drawing.Size(141, 22);
			this.context_ShowDetails.Text = "Show Details";
			// 
			// context_DeleteTask
			// 
			this.context_DeleteTask.Name = "context_DeleteTask";
			this.context_DeleteTask.Size = new System.Drawing.Size(141, 22);
			this.context_DeleteTask.Text = "Delete Task";
			// 
			// ActivityLogs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel6);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.Name = "ActivityLogs";
			this.Size = new System.Drawing.Size(612, 424);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.contextMenu_rows.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView list_view_scheduled_tasks;
		private System.Windows.Forms.ColumnHeader col_task_name;
		private System.Windows.Forms.ColumnHeader col_started_date;
		private System.Windows.Forms.ColumnHeader col_finished_date;
		private System.Windows.Forms.ColumnHeader col_job_status;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenuStrip contextMenu_rows;
		private System.Windows.Forms.ToolStripMenuItem context_ShowDetails;
		private System.Windows.Forms.ToolStripMenuItem context_DeleteTask;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton rbtn_specific_date;
		private System.Windows.Forms.RadioButton rbtn_all_records;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
	}
}
