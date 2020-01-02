namespace CalendarApplication
{
	partial class useCalendar
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
			DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
			this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
			this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btnWeek = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnDay = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bntToDay = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnMonth = new Bunifu.Framework.UI.BunifuFlatButton();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
			this.SuspendLayout();
			// 
			// schedulerControl1
			// 
			this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
			this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
			this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
			this.schedulerControl1.Name = "schedulerControl1";
			this.schedulerControl1.Size = new System.Drawing.Size(787, 560);
			this.schedulerControl1.Start = new System.DateTime(2019, 12, 29, 0, 0, 0, 0);
			this.schedulerControl1.TabIndex = 0;
			this.schedulerControl1.Text = "schedulerControl1";
			this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
			this.schedulerControl1.Views.FullWeekView.Enabled = true;
			this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
			this.schedulerControl1.Views.WeekView.Enabled = false;
			this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
			this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.SchedulerControl1_EditAppointmentFormShowing);
			this.schedulerControl1.CustomDrawDayHeader += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.scheduler_CustomDrawDayHeader);
			// 
			// schedulerDataStorage1
			// 
			// 
			// 
			// 
			this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(474, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(2, 30);
			this.label1.TabIndex = 6;
			// 
			// btnWeek
			// 
			this.btnWeek.Activecolor = System.Drawing.Color.Transparent;
			this.btnWeek.BackColor = System.Drawing.Color.White;
			this.btnWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnWeek.BorderRadius = 0;
			this.btnWeek.ButtonText = "Week";
			this.btnWeek.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnWeek.DisabledColor = System.Drawing.Color.Transparent;
			this.btnWeek.Iconcolor = System.Drawing.Color.Transparent;
			this.btnWeek.Iconimage = global::CalendarApplication.Properties.Resources.imageedit_2_4228020788;
			this.btnWeek.Iconimage_right = null;
			this.btnWeek.Iconimage_right_Selected = null;
			this.btnWeek.Iconimage_Selected = null;
			this.btnWeek.IconMarginLeft = 0;
			this.btnWeek.IconMarginRight = 0;
			this.btnWeek.IconRightVisible = true;
			this.btnWeek.IconRightZoom = 0D;
			this.btnWeek.IconVisible = true;
			this.btnWeek.IconZoom = 50D;
			this.btnWeek.IsTab = false;
			this.btnWeek.Location = new System.Drawing.Point(594, 3);
			this.btnWeek.Name = "btnWeek";
			this.btnWeek.Normalcolor = System.Drawing.Color.White;
			this.btnWeek.OnHovercolor = System.Drawing.Color.Gainsboro;
			this.btnWeek.OnHoverTextColor = System.Drawing.Color.Black;
			this.btnWeek.selected = false;
			this.btnWeek.Size = new System.Drawing.Size(87, 37);
			this.btnWeek.TabIndex = 8;
			this.btnWeek.Text = "Week";
			this.btnWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnWeek.Textcolor = System.Drawing.Color.Black;
			this.btnWeek.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWeek.Click += new System.EventHandler(this.BtnWeek_Click);
			// 
			// btnDay
			// 
			this.btnDay.Activecolor = System.Drawing.Color.Transparent;
			this.btnDay.BackColor = System.Drawing.Color.White;
			this.btnDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDay.BorderRadius = 0;
			this.btnDay.ButtonText = "Day";
			this.btnDay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDay.DisabledColor = System.Drawing.Color.Transparent;
			this.btnDay.Iconcolor = System.Drawing.Color.Transparent;
			this.btnDay.Iconimage = global::CalendarApplication.Properties.Resources.imageedit_2_4228020788;
			this.btnDay.Iconimage_right = null;
			this.btnDay.Iconimage_right_Selected = null;
			this.btnDay.Iconimage_Selected = null;
			this.btnDay.IconMarginLeft = 0;
			this.btnDay.IconMarginRight = 0;
			this.btnDay.IconRightVisible = true;
			this.btnDay.IconRightZoom = 0D;
			this.btnDay.IconVisible = true;
			this.btnDay.IconZoom = 50D;
			this.btnDay.IsTab = false;
			this.btnDay.Location = new System.Drawing.Point(501, 3);
			this.btnDay.Name = "btnDay";
			this.btnDay.Normalcolor = System.Drawing.Color.White;
			this.btnDay.OnHovercolor = System.Drawing.Color.Gainsboro;
			this.btnDay.OnHoverTextColor = System.Drawing.Color.Black;
			this.btnDay.selected = false;
			this.btnDay.Size = new System.Drawing.Size(87, 37);
			this.btnDay.TabIndex = 7;
			this.btnDay.Text = "Day";
			this.btnDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnDay.Textcolor = System.Drawing.Color.Black;
			this.btnDay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDay.Click += new System.EventHandler(this.btnDay_click);
			// 
			// bntToDay
			// 
			this.bntToDay.Activecolor = System.Drawing.Color.Transparent;
			this.bntToDay.BackColor = System.Drawing.Color.White;
			this.bntToDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bntToDay.BorderRadius = 0;
			this.bntToDay.ButtonText = "ToDay";
			this.bntToDay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bntToDay.DisabledColor = System.Drawing.Color.Transparent;
			this.bntToDay.Iconcolor = System.Drawing.Color.Transparent;
			this.bntToDay.Iconimage = global::CalendarApplication.Properties.Resources.imageedit_2_4228020788;
			this.bntToDay.Iconimage_right = null;
			this.bntToDay.Iconimage_right_Selected = null;
			this.bntToDay.Iconimage_Selected = null;
			this.bntToDay.IconMarginLeft = 0;
			this.bntToDay.IconMarginRight = 0;
			this.bntToDay.IconRightVisible = true;
			this.bntToDay.IconRightZoom = 0D;
			this.bntToDay.IconVisible = true;
			this.bntToDay.IconZoom = 50D;
			this.bntToDay.IsTab = false;
			this.bntToDay.Location = new System.Drawing.Point(389, 3);
			this.bntToDay.Name = "bntToDay";
			this.bntToDay.Normalcolor = System.Drawing.Color.White;
			this.bntToDay.OnHovercolor = System.Drawing.Color.Gainsboro;
			this.bntToDay.OnHoverTextColor = System.Drawing.Color.Black;
			this.bntToDay.selected = false;
			this.bntToDay.Size = new System.Drawing.Size(87, 37);
			this.bntToDay.TabIndex = 5;
			this.bntToDay.Text = "ToDay";
			this.bntToDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bntToDay.Textcolor = System.Drawing.Color.Black;
			this.bntToDay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntToDay.Click += new System.EventHandler(this.btnGoToDay_Click);
			// 
			// btnMonth
			// 
			this.btnMonth.Activecolor = System.Drawing.Color.Transparent;
			this.btnMonth.BackColor = System.Drawing.Color.White;
			this.btnMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMonth.BorderRadius = 0;
			this.btnMonth.ButtonText = "Month";
			this.btnMonth.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMonth.DisabledColor = System.Drawing.Color.Transparent;
			this.btnMonth.Iconcolor = System.Drawing.Color.Transparent;
			this.btnMonth.Iconimage = global::CalendarApplication.Properties.Resources.imageedit_2_4228020788;
			this.btnMonth.Iconimage_right = null;
			this.btnMonth.Iconimage_right_Selected = null;
			this.btnMonth.Iconimage_Selected = null;
			this.btnMonth.IconMarginLeft = 0;
			this.btnMonth.IconMarginRight = 0;
			this.btnMonth.IconRightVisible = true;
			this.btnMonth.IconRightZoom = 0D;
			this.btnMonth.IconVisible = true;
			this.btnMonth.IconZoom = 50D;
			this.btnMonth.IsTab = false;
			this.btnMonth.Location = new System.Drawing.Point(678, 3);
			this.btnMonth.Name = "btnMonth";
			this.btnMonth.Normalcolor = System.Drawing.Color.White;
			this.btnMonth.OnHovercolor = System.Drawing.Color.Gainsboro;
			this.btnMonth.OnHoverTextColor = System.Drawing.Color.Black;
			this.btnMonth.selected = false;
			this.btnMonth.Size = new System.Drawing.Size(87, 37);
			this.btnMonth.TabIndex = 9;
			this.btnMonth.Text = "Month";
			this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnMonth.Textcolor = System.Drawing.Color.Black;
			this.btnMonth.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMonth.Click += new System.EventHandler(this.BtnMonth_Click);
			// 
			// useCalendar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnMonth);
			this.Controls.Add(this.btnWeek);
			this.Controls.Add(this.btnDay);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bntToDay);
			this.Controls.Add(this.schedulerControl1);
			this.Name = "useCalendar";
			this.Size = new System.Drawing.Size(787, 560);
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
		private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
		private Bunifu.Framework.UI.BunifuFlatButton btnWeek;
		private Bunifu.Framework.UI.BunifuFlatButton btnDay;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuFlatButton bntToDay;
		private Bunifu.Framework.UI.BunifuFlatButton btnMonth;
	}
}
