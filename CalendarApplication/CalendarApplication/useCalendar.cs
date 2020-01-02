using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System.Globalization;
using System.Threading;

namespace CalendarApplication
{
	public partial class useCalendar : DevExpress.XtraEditors.XtraUserControl
	{
		private static useCalendar _instance;

		public static useCalendar Instance
		{
			get
			{
				if (_instance == null)
					_instance = new useCalendar();
				return _instance;
			}
		}
		public useCalendar()
		{
			InitializeComponent();
		}

		private void scheduler_CustomDrawDayHeader(object sender, CustomDrawObjectEventArgs e)
		{
			e.DrawDefault();
			if (schedulerControl1.ActiveViewType == SchedulerViewType.Month)
			{
				DayHeader header = e.ObjectInfo as DayHeader;
				var vcal = new ConvertSolarToLunar();
				int[] arr = vcal.convertSolar2Lunars(header.Interval.Start.Day, header.Interval.Start.Month, header.Interval.Start.Year, 7);
				var tempDay = arr[0] + "/" + arr[1];

				string lunnarDay;
				if (arr[0].ToString() == "1")
				{
					lunnarDay = arr[0] + "/" + arr[1];
				}
				else
				{
					lunnarDay = arr[0].ToString();
				}
				bool holiday = false;

				if (tempDay == "10/3")
				{
					lunnarDay = "Giỗ Tổ Hùng Vương";

					holiday = true;
				}
				else if (tempDay == "5/5")
				{
					lunnarDay = "Tết Đoan Ngọ";

					holiday = true;
				}
				else if (tempDay == "1/1")
				{
					lunnarDay = "Mùng 1 Tết";
					holiday = true;
				}
				else if (tempDay == "2/1")
				{
					lunnarDay = "Mùng 2 Tết";
					holiday = true;
				}
				else if (tempDay == "3/1")
				{
					lunnarDay = "Mùng 3 Tết";
					holiday = true;
				}
				else if (tempDay == "4/1")
				{
					lunnarDay = "Mùng 4 Tết";
					holiday = true;
				}
				else if (header.Interval.Start.Day == 1 && header.Interval.Start.Month == 1)
				{
					lunnarDay = "Tết Dương Lịch";
					holiday = true;
				}
				else if (header.Interval.Start.Day == 30 && header.Interval.Start.Month == 4)
				{
					lunnarDay = "Giải Phóng Miền Nam";
					holiday = true;
				}
				else if (header.Interval.Start.Day == 1 && header.Interval.Start.Month == 5)
				{
					lunnarDay = "Quốc Tế Lao Động";
					holiday = true;
				}
				else if (header.Interval.Start.Day == 2 && header.Interval.Start.Month == 9)
				{
					lunnarDay = "Lễ Quốc Khánh";
					holiday = true;
				}
				//header.Image = Image.FromFile("vietnam.png");
				StringFormat format = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };
				StringFormat format_holiday = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

				StringFormat format2 = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

				//e.DrawDefault();  
				RectangleF r = e.ObjectInfo.Bounds;
				string str = string.Format("{0}", lunnarDay);

				Font font = new Font("Tahoma", 7.0f, FontStyle.Bold);
				Font font_calendar = new Font("Arial", 12.0f);

				//header.Caption = string.Empty;
				e.Graphics.FillRectangle(Brushes.White, header.Bounds);

				Color color = Color.Gray;

				if (header.Interval.Start.DayOfWeek == DayOfWeek.Sunday)
				{
					color = Color.Red;
				}
				else if (header.Interval.Start.DayOfWeek == DayOfWeek.Saturday)
				{
					color = Color.Green;
				}

				if (arr[0].ToString() == "1" || holiday)
				{
					font = new Font("Tahoma", 7.2f, FontStyle.Bold);

					if (holiday)
					{
						e.Graphics.FillRectangle(Brushes.Red, header.Bounds);
						e.Graphics.DrawString(str, font, new SolidBrush(Color.White), r, format_holiday);

					}
					else if (header.Interval.Start.Day == 1)
					{
						e.Graphics.DrawString(str, font, new SolidBrush(color), r, format);
						e.Graphics.DrawString(header.Interval.Start.Day + "", font_calendar, new SolidBrush(color), r, format2);
					}
					else if (header.Interval.Start.Day != 1)
					{
						e.Graphics.DrawString(str, font, new SolidBrush(color), r, format);
						e.Graphics.DrawString(header.Interval.Start.Day + "", font_calendar, new SolidBrush(color), r, format2);
					}


				}
				else if (header.Interval.Start.Day != 1)
				{
					e.Graphics.DrawString(str, font, new SolidBrush(color), r, format);
					e.Graphics.DrawString(header.Interval.Start.Day + "", font_calendar, new SolidBrush(color), r, format2);
				}

				if (header.Interval.Start.Day == 1 && !holiday)
				{
					e.Graphics.DrawString(header.Interval.Start.Day + "/" + header.Interval.Start.Month, font_calendar, new SolidBrush(Color.Red), r, format2);
				}


			}
			e.Handled = true;
		}


		/* Click đưa tới ngày hiện tại*/
		private void btnGoToDay_Click(object sender, EventArgs e)
		{
			schedulerControl1.GoToToday();
		}

		/* Chuyển sang chế độ xem theo ngày*/
		private void btnDay_click(object sender, EventArgs e)
		{
			schedulerControl1.ActiveViewType = SchedulerViewType.Day;
		}
		/* Chuyển sang chế độ xem theo tuần*/
		private void BtnWeek_Click(object sender, EventArgs e)
		{
			schedulerControl1.ActiveViewType = SchedulerViewType.FullWeek;
		}

		private void SchedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
		{
			DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
			CalendarApplication.OutlookAppointmentForm form = new CalendarApplication.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
			try
			{
				e.DialogResult = form.ShowDialog();
				e.Handled = true;
			}
			finally
			{
				form.Dispose();
			}

		}

		private void BtnMonth_Click(object sender, EventArgs e)
		{
			schedulerControl1.ActiveViewType = SchedulerViewType.Month;
		}
	}
}
