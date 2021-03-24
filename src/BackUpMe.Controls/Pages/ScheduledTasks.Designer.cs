
namespace BackUpMe.Controls.Pages
{
	partial class ScheduledTasks
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.list_view_scheduled_tasks = new System.Windows.Forms.ListView();
			this.col_task_name = new System.Windows.Forms.ColumnHeader();
			this.col_source_path = new System.Windows.Forms.ColumnHeader();
			this.col_destination_path = new System.Windows.Forms.ColumnHeader();
			this.col_last_run = new System.Windows.Forms.ColumnHeader();
			this.col_job_status = new System.Windows.Forms.ColumnHeader();
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
			this.panel6.Controls.Add(this.panel1);
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.label2);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(612, 424);
			this.panel6.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.list_view_scheduled_tasks);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(612, 355);
			this.panel1.TabIndex = 6;
			// 
			// list_view_scheduled_tasks
			// 
			this.list_view_scheduled_tasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.list_view_scheduled_tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_task_name,
            this.col_source_path,
            this.col_destination_path,
            this.col_last_run,
            this.col_job_status});
			this.list_view_scheduled_tasks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.list_view_scheduled_tasks.FullRowSelect = true;
			this.list_view_scheduled_tasks.GridLines = true;
			this.list_view_scheduled_tasks.HideSelection = false;
			this.list_view_scheduled_tasks.Location = new System.Drawing.Point(0, 0);
			this.list_view_scheduled_tasks.Name = "list_view_scheduled_tasks";
			this.list_view_scheduled_tasks.Size = new System.Drawing.Size(612, 355);
			this.list_view_scheduled_tasks.TabIndex = 5;
			this.list_view_scheduled_tasks.UseCompatibleStateImageBehavior = false;
			this.list_view_scheduled_tasks.View = System.Windows.Forms.View.Details;
			this.list_view_scheduled_tasks.DoubleClick += new System.EventHandler(this.list_view_scheduled_tasks_DoubleClick);
			this.list_view_scheduled_tasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_view_scheduled_tasks_MouseClick);
			// 
			// col_task_name
			// 
			this.col_task_name.Name = "col_task_name";
			this.col_task_name.Text = "Task Name";
			this.col_task_name.Width = 150;
			// 
			// col_source_path
			// 
			this.col_source_path.Name = "col_source_path";
			this.col_source_path.Text = "Source Path";
			this.col_source_path.Width = 100;
			// 
			// col_destination_path
			// 
			this.col_destination_path.Name = "col_destination_path";
			this.col_destination_path.Text = "Destination Path";
			this.col_destination_path.Width = 100;
			// 
			// col_last_run
			// 
			this.col_last_run.Name = "col_last_run";
			this.col_last_run.Text = "Last Job Runned";
			this.col_last_run.Width = 100;
			// 
			// col_job_status
			// 
			this.col_job_status.Name = "col_job_status";
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
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(13, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Scheduled Tasks";
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
			this.context_ShowDetails.Click += new System.EventHandler(this.context_ShowDetails_Click);
			// 
			// context_DeleteTask
			// 
			this.context_DeleteTask.Name = "context_DeleteTask";
			this.context_DeleteTask.Size = new System.Drawing.Size(141, 22);
			this.context_DeleteTask.Text = "Delete Task";
			this.context_DeleteTask.Click += new System.EventHandler(this.context_DeleteTask_Click);
			// 
			// ScheduledTasks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel6);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Name = "ScheduledTasks";
			this.Size = new System.Drawing.Size(612, 424);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.contextMenu_rows.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.ListView list_view_scheduled_tasks;
		private System.Windows.Forms.ColumnHeader col_task_name;
		private System.Windows.Forms.ColumnHeader col_source_path;
		private System.Windows.Forms.ColumnHeader col_destination_path;
		private System.Windows.Forms.ColumnHeader col_last_run;
		private System.Windows.Forms.ColumnHeader col_job_status;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ContextMenuStrip contextMenu_rows;
		private System.Windows.Forms.ToolStripMenuItem context_ShowDetails;
		private System.Windows.Forms.ToolStripMenuItem context_DeleteTask;
	}
}
