namespace CalendarApplication
{
	partial class useSetting
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.groupBoxSettingCalendar = new System.Windows.Forms.GroupBox();
			this.dropDownLanguage = new Bunifu.Framework.UI.BunifuDropdown();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.groupBoxSettingCalendar.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.groupBoxSettingCalendar);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(800, 543);
			this.panelControl1.TabIndex = 0;
			// 
			// groupBoxSettingCalendar
			// 
			this.groupBoxSettingCalendar.Controls.Add(this.dropDownLanguage);
			this.groupBoxSettingCalendar.Location = new System.Drawing.Point(67, 43);
			this.groupBoxSettingCalendar.Name = "groupBoxSettingCalendar";
			this.groupBoxSettingCalendar.Size = new System.Drawing.Size(701, 141);
			this.groupBoxSettingCalendar.TabIndex = 1;
			this.groupBoxSettingCalendar.TabStop = false;
			this.groupBoxSettingCalendar.Text = "Calendar";
			// 
			// dropDownLanguage
			// 
			this.dropDownLanguage.BackColor = System.Drawing.Color.Transparent;
			this.dropDownLanguage.BorderRadius = 3;
			this.dropDownLanguage.ForeColor = System.Drawing.Color.White;
			this.dropDownLanguage.Items = new string[] {
        "Vietnamese",
        "English"};
			this.dropDownLanguage.Location = new System.Drawing.Point(531, 20);
			this.dropDownLanguage.Name = "dropDownLanguage";
			this.dropDownLanguage.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.dropDownLanguage.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.dropDownLanguage.selectedIndex = -1;
			this.dropDownLanguage.Size = new System.Drawing.Size(154, 22);
			this.dropDownLanguage.TabIndex = 1;
			this.dropDownLanguage.onItemSelected += new System.EventHandler(this.onItemSelectLanguague_Select);
			// 
			// useSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelControl1);
			this.Name = "useSetting";
			this.Size = new System.Drawing.Size(800, 543);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.groupBoxSettingCalendar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.GroupBox groupBoxSettingCalendar;
		private Bunifu.Framework.UI.BunifuDropdown dropDownLanguage;
	}
}
