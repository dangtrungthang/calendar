using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System.Globalization;
using System.Threading;


namespace CalendarApplication
{
	public partial class MainCalendar : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		
		public MainCalendar()
		{
			
			// Khởi tạo tiếng anh khi load lên
			CultureInfo culture = CultureInfo.CreateSpecificCulture("vi");
			Thread.CurrentThread.CurrentUICulture = culture;
			Thread.CurrentThread.CurrentCulture = culture;		
			

			// Các hàm khởi tạo các control kéo thả nằm trong đây
			InitializeComponent();

			/* Lần đầu khởi tạo form chính sẽ load calendar lên*/
			if (!container.Controls.Contains(useCalendar.Instance))
			{
				container.Controls.Add(useCalendar.Instance);
				useCalendar.Instance.Dock = DockStyle.Fill;
				useCalendar.Instance.BringToFront();
			}
			useCalendar.Instance.BringToFront();
			
		}

		/* Click vào calendar sẽ load useCalendar lên*/
		private void GroupCalendar_Click(object sender, EventArgs e)
		{
			if (!container.Controls.Contains(useCalendar.Instance))
			{
				container.Controls.Add(useCalendar.Instance);
				useCalendar.Instance.Dock = DockStyle.Fill;
				useCalendar.Instance.BringToFront();
				
			}
			useCalendar.Instance.BringToFront();
			

		}

		/*Click Setting sẽ load useSetting lên*/
		private void GroupSetting_Click(object sender, EventArgs e)
		{
			if (!container.Controls.Contains(useSetting.Instance))
			{
				container.Controls.Add(useSetting.Instance);
				useSetting.Instance.Dock = DockStyle.Fill;
				useSetting.Instance.BringToFront();
			}
			useSetting.Instance.BringToFront();
		}

		
	}
}

