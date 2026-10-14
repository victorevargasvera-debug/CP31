using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;

namespace AcpUI.Common
{
	// Token: 0x0200007A RID: 122
	public class MultiValueToColorConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x00078288 File Offset: 0x00076488
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::System.Windows.Media.Brush brush;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1EF;
				case 1:
					if (values[0] is bool)
					{
						num2 = (short)362807302;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return brush;
				case 2:
					if (brush == null)
					{
						num2 = (short)2058616832;
						short num3 = num2;
						num2 = (short)2080440324;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return brush;
				case 3:
					if ((bool)values[0])
					{
						num2 = (short)365559813;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return brush;
				case 4:
					brush = global::System.Windows.Media.Brushes.Red;
					goto IL_1D4;
				case 5:
					brush = global::AcpUI.AcpColorKeyBrush.GetBrushFromColorKey(typeof(global::AcpUI.AcpExpander), global::AcpUI.AcpColorKeys.AcpExpanderInValidForeground);
					num2 = (short)987758594;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)2027880451;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return brush;
				case 8:
					num2 = (short)612499457;
					if (num2 != 0)
					{
					}
					brush = global::System.Windows.Media.Brushes.Black;
					num2 = (short)1595342848;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					if (brush != null)
					{
						goto IL_1EF;
					}
					num2 = (short)101911773;
					short num4 = num2;
					num2 = (short)1304235229;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D4;
					default:
						num2 = (short)1372323840;
						if (num2 != 0)
						{
						}
						num2 = (short)1946091528;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_38;
				IL_1D4:
				num2 = (short)1943404551;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1EF:
				num2 = (short)1840185345;
				num = (int)((global::System.IntPtr)num2);
			}
			return brush;
			IL_38:
			brush = global::AcpUI.AcpColorKeyBrush.GetBrushFromColorKey(typeof(global::System.Windows.Documents.Hyperlink), global::AcpUI.AcpColorKeys.HyperlinkForFeatureGroupForeground);
			num2 = (short)1386348553;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000784C4 File Offset: 0x000766C4
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			short num = (short)1925579359;
			short num2 = num;
			num = (short)593691231;
			switch (num2 == num)
			{
			default:
			{
				num = (short)860356608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)817692673;
			if (num != 0)
			{
			}
			num = (short)1515913216;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException(global::AcpUI.Common.Utility.c("\uda96ﲘ얠莢쮤좦\udda8讪쒬슮솰\udfb2킴\udab6\udcb8햺즼\udabeꗀ", a_));
		}
	}
}
