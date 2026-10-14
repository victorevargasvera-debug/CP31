using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls.Converters
{
	// Token: 0x02000133 RID: 307
	public class EmbeddedSetCategoryNameToImportExportButtonVisibility : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600096D RID: 2413 RVA: 0x0009C350 File Offset: 0x0009A550
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)797638657;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1065480827;
					short num3 = num;
					num = (short)1353183867;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_62;
					default:
						goto IL_AA;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_12A;
				case 3:
				{
					num = (short)1984692224;
					short num4 = num;
					num = (short)591003650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_35:
				if (!this.WhiteList.Contains(value.ToString()))
				{
					num = (short)1392377859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_62:
				num = (short)1966080;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AA:
			num = (short)128450561;
			if (num != 0)
			{
			}
			num = (short)512753664;
			if (num != 0)
			{
			}
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_12D;
			IL_12A:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_12D:
			return visibility;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0009C490 File Offset: 0x0009A690
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)876351327;
			short num2 = num;
			num = (short)1544097631;
			switch (num2 == num)
			{
			}
			num = (short)1872953345;
			if (num != 0)
			{
			}
			num = (short)1159397376;
			short num3 = num;
			num = (short)1605632000;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0009C540 File Offset: 0x0009A740
		public EmbeddedSetCategoryNameToImportExportButtonVisibility()
		{
			int a_ = 1;
			this.WhiteList = new string[]
			{
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춘漢톢쪤튦\ud9a8킰쎲어\udeb6ힸ\udcba", a_),
				global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪘ﾜ슠톢첤얦첨\ud9aaﲰ튲어잶킸햺\udabc", a_)
			};
			base..ctor();
		}

		// Token: 0x04000459 RID: 1113
		public string[] WhiteList;
	}
}
