
namespace BackUpMe.Controls.Pages
{
	partial class Settings
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
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnl_subpage = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnEmailSettings = new System.Windows.Forms.Button();
			this.btnGeneralSettings = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel6.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
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
			this.panel1.Controls.Add(this.pnl_subpage);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 51);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(612, 373);
			this.panel1.TabIndex = 6;
			// 
			// pnl_subpage
			// 
			this.pnl_subpage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_subpage.Location = new System.Drawing.Point(0, 37);
			this.pnl_subpage.Name = "pnl_subpage";
			this.pnl_subpage.Size = new System.Drawing.Size(612, 336);
			this.pnl_subpage.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnEmailSettings);
			this.panel2.Controls.Add(this.btnGeneralSettings);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(612, 37);
			this.panel2.TabIndex = 0;
			// 
			// btnEmailSettings
			// 
			this.btnEmailSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
			this.btnEmailSettings.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnEmailSettings.FlatAppearance.BorderSize = 0;
			this.btnEmailSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmailSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnEmailSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnEmailSettings.Location = new System.Drawing.Point(102, 0);
			this.btnEmailSettings.Name = "btnEmailSettings";
			this.btnEmailSettings.Size = new System.Drawing.Size(102, 37);
			this.btnEmailSettings.TabIndex = 1;
			this.btnEmailSettings.Tag = "EmailSettings";
			this.btnEmailSettings.Text = "Email Settings";
			this.btnEmailSettings.UseVisualStyleBackColor = false;
			this.btnEmailSettings.Click += new System.EventHandler(this.btnTabButton_Click);
			// 
			// btnGeneralSettings
			// 
			this.btnGeneralSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(38)))), ((int)(((byte)(66)))));
			this.btnGeneralSettings.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnGeneralSettings.FlatAppearance.BorderSize = 0;
			this.btnGeneralSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGeneralSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btnGeneralSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnGeneralSettings.Location = new System.Drawing.Point(0, 0);
			this.btnGeneralSettings.Name = "btnGeneralSettings";
			this.btnGeneralSettings.Size = new System.Drawing.Size(102, 37);
			this.btnGeneralSettings.TabIndex = 0;
			this.btnGeneralSettings.Tag = "GeneralSettings";
			this.btnGeneralSettings.Text = "General Settings";
			this.btnGeneralSettings.UseVisualStyleBackColor = false;
			this.btnGeneralSettings.Click += new System.EventHandler(this.btnTabButton_Click);
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
			this.label2.Size = new System.Drawing.Size(81, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Settings";
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(66)))), ((int)(((byte)(118)))));
			this.Controls.Add(this.panel6);
			this.Name = "Settings";
			this.Size = new System.Drawing.Size(612, 424);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnEmailSettings;
		private System.Windows.Forms.Button btnGeneralSettings;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnl_subpage;
	}
}
