using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000038 RID: 56
	internal class IsCheckedToIconConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000BBD8 File Offset: 0x00009DD8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			short num = (short)1262814078;
			short num2 = num;
			num = (short)1441923966;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A9;
			case 1:
				break;
			default:
			{
				num = (short)1918566400;
				short num3 = num;
				break;
			}
			}
			num = (short)801308673;
			if (num != 0)
			{
			}
			num = (short)1513750528;
			if (num != 0)
			{
			}
			if (!(bool)value)
			{
				return global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("뚘횚캠톢쪤쮦좨薪삮\udcb0\udeb2\udab4\ud9b6視醾鏀ꋂꇄ껆ꛈ蛊곌ꇎ냐듒냔뫖볘뗚꧜ꋠ賢诤鏦鯨蓪臬鳮쫰郲髴髶觸铺鏼髾漀眂⨄丆樈搊挌簎㸐嘒洔朖砘甚礜䀞ጠᜢ紤ᔦᴨԪ崬䄮嘰", a_);
			}
			IL_A9:
			return global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("뚘횚캠톢쪤쮦좨薪삮\udcb0\udeb2\udab4\ud9b6視醾鏀ꋂꇄ껆ꛈ蛊곌ꇎ냐듒냔뫖볘뗚꧜ꋠ賢诤鏦鯨蓪臬鳮쫰郲髴髶觸铺鏼髾漀眂⨄丆樈搊挌簎㸐倒稔笖甘稚洜氞䐠簢ᜤጦ焨ᤪ᤬Į䄰崲刴", a_);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000BCB0 File Offset: 0x00009EB0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)278455158;
			short num2 = num;
			num = (short)634250102;
			switch (num2 == num)
			{
			}
			num = (short)83034112;
			short num3 = num;
			num = (short)81264640;
			if (num != 0)
			{
			}
			num = (short)1321926657;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
