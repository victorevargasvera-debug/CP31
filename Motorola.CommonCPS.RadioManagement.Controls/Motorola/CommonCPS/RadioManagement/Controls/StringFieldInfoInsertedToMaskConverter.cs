using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000D7 RID: 215
	public class StringFieldInfoInsertedToMaskConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x00061B68 File Offset: 0x0005FD68
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
			short num = (short)1744371712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				string text;
				global::System.Text.RegularExpressions.Match match;
				int num3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						return text;
					case 1:
						if (match.Success)
						{
							num = (short)1969750023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 2:
						return text;
					case 3:
						if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1109262336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (int)values[1];
						num = (short)787021830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_A7;
					case 5:
						goto IL_269;
					case 6:
						if (num3 == 0)
						{
							num = (short)1960050690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2071855105;
						if (num != 0)
						{
						}
						text = text.Trim();
						match = global::Motorola.CommonCPS.RadioManagement.Controls.StringFieldInfoInsertedToMaskConverter.a.Match(text);
						num = (short)89980929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)2107899912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!match.Groups[2].Value.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udba5銧톩", a_)))
						{
							num = (short)413335557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 9:
					{
						num = (short)997573966;
						short num4 = num;
						num = (short)1151780174;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A7;
						default:
							goto IL_FF;
						}
						break;
					}
					}
					goto IL_5F;
					IL_A7:
					if (string.IsNullOrEmpty(text))
					{
						num = (short)1791885321;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)624099331;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_FF:
				num = (short)298647552;
				if (num != 0)
				{
				}
				return string.Empty;
				IL_269:
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udda5펧즩쒫쾭슯袱쾳蚵얷肹잻辽붿뿁맃", a_), num3, match.Groups[2].Value);
				IL_5F:
				text = (string)values[0];
				num = (short)955711488;
				short num5 = num;
				num = (short)62783492;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00061E2C File Offset: 0x0006002C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1633926166;
			short num2 = num;
			num = (short)878754838;
			switch (num2 == num)
			{
			}
			num = (short)140247040;
			if (num != 0)
			{
			}
			num = (short)939982849;
			if (num != 0)
			{
			}
			num = (short)1028784128;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00061EF0 File Offset: 0x000600F0
		// Note: this type is marked as 'beforefieldinit'.
		static StringFieldInfoInsertedToMaskConverter()
		{
			int a_ = 18;
			short num = (short)1412038657;
			if (num != 0)
			{
			}
			num = (short)488737576;
			short num2 = num;
			num = (short)2046069544;
			switch (num2 == num)
			{
			}
			num = (short)1223229440;
			if (num != 0)
			{
			}
			num = (short)1662779392;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.StringFieldInfoInsertedToMaskConverter.a = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힫춭\ud8af펱욳貵邷\ud8bb閽뇋", a_));
		}

		// Token: 0x0400029E RID: 670
		private static readonly global::System.Text.RegularExpressions.Regex a;
	}
}
