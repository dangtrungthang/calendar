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
using System.Globalization;
using System.Threading;


namespace CalendarApplication
{
	enum languageSelect {
		languageVN, // 0 là VN
		languageEN,// 1 là EN
	};

	public partial class useSetting : DevExpress.XtraEditors.XtraUserControl
	{
		private static useSetting _instance;
		int _statusLanguage = 1; // mặc định ban đầu là tiếng anh

		//tạo singleton pattern
		public static useSetting Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new useSetting();
				}
				return _instance;
			}
		}
		public useSetting()
		{
			InitializeComponent();
		}

		private void onItemSelectLanguague_Select(object sender, EventArgs e)
		{
			CultureInfo culture;
			switch (dropDownLanguage.selectedIndex)
			{
				case 0:
					_statusLanguage = 0;
					break;
				case 1:
					_statusLanguage = 1;
					break;

			}
		}

		public int getStatusLanguage()
		{
			return _statusLanguage;
		}
	}
}
