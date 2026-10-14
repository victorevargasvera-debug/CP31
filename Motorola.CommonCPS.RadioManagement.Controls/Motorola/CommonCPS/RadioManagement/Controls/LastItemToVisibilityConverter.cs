using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000DC RID: 220
	internal class LastItemToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00062C34 File Offset: 0x00060E34
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1043005442;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					goto IL_196;
				case 1:
					goto IL_B7;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
					num = (short)1283260420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.a.Count == 0)
					{
						num = (short)658702336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63;
				case 5:
					if (flag)
					{
						num = (short)452460545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20E;
				case 6:
					if (this.a != null)
					{
						num = (short)411893760;
						short num3 = num;
						num = (short)106823683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BC;
				case 7:
					this.a = (value as global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, string>>);
					num = (short)662962182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				if (this.a == null)
				{
					num = (short)594673671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_63:
				this.b++;
				flag = (this.b == this.a.Count);
				num = (short)835190789;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B7:
			goto IL_141;
			IL_BC:
			this.a = null;
			this.b = 0;
			return global::System.Windows.Visibility.Hidden;
			IL_141:
			this.a = null;
			this.b = 0;
			return global::System.Windows.Visibility.Hidden;
			IL_196:
			num = (short)923787942;
			short num4 = num;
			num = (short)718660262;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_141;
			default:
				num = (short)757596160;
				if (num != 0)
				{
				}
				num = (short)484376577;
				if (num != 0)
				{
				}
				goto IL_BC;
			}
			IL_20E:
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00062E58 File Offset: 0x00061058
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)204538922;
			short num2 = num;
			num = (short)1040843818;
			switch (num2 == num)
			{
			}
			num = (short)1294794753;
			if (num != 0)
			{
			}
			num = (short)1720844288;
			if (num != 0)
			{
			}
			num = (short)1664090112;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040002A4 RID: 676
		private global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, string>> a;

		// Token: 0x040002A5 RID: 677
		private int b;
	}
}
