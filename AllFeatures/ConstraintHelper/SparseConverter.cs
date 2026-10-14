using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace ConstraintHelper
{
	// Token: 0x020005EF RID: 1519
	public class SparseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600D0D4 RID: 53460 RVA: 0x00C389E4 File Offset: 0x00C36BE4
		public SparseConverter(int[] DBvalue, string[] ResIds)
		{
			this.a = DBvalue;
			this.c = ResIds;
			this.b = new string[ResIds.Length];
			for (int i = 0; i < DBvalue.Length; i++)
			{
				this.b[i] = global::CommonResources.AcgResources.ResourceManager.GetString(this.c[i], global::CommonResources.AcgResources.Culture);
				if (this.b[i] == null)
				{
					this.b[i] = this.c[i];
				}
			}
		}

		// Token: 0x0600D0D5 RID: 53461 RVA: 0x00C38A64 File Offset: 0x00C36C64
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int value2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_165;
					case 1:
						if (global::System.Array.IndexOf<int>(this.a, value2) != -1)
						{
							num2 = (short)1684406275;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_16A;
					case 2:
						if (culture == null)
						{
							num2 = (short)807534593;
							if (num2 != 0)
							{
							}
							num2 = (short)481296384;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_64;
					case 3:
					{
						num2 = (short)1367465470;
						short num3 = num2;
						num2 = (short)1095884286;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1700331520;
							if (num2 != 0)
							{
							}
							num2 = (short)677642240;
							short num4 = num2;
							num2 = (short)1514274818;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					break;
				}
				IL_20:
				value2 = (int)value;
				num2 = (short)131137537;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_64:
			return global::CommonResources.AcgResources.ResourceManager.GetString(this.c[global::System.Array.IndexOf<int>(this.a, value2)], culture);
			IL_165:
			return this.b[global::System.Array.IndexOf<int>(this.a, value2)];
			IL_16A:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THEVALUEOUTOFLOVRANGE);
		}

		// Token: 0x0600D0D6 RID: 53462 RVA: 0x00C38BE8 File Offset: 0x00C36DE8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_75;
			}
			short num;
			int num3;
			string text;
			for (;;)
			{
				IL_0A:
				num = (short)2001734813;
				short num2 = num;
				num = (short)1124076701;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2039873536;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_157;
					case 1:
						text = global::CommonResources.AcgResources.ID_SOFTWARE;
						num = (short)2068054019;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (global::System.Array.IndexOf<string>(this.b, text.Trim()) == -1)
						{
							num = (short)557252612;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111;
					case 3:
						goto IL_111;
					case 4:
					{
						num = (short)174391297;
						if (num != 0)
						{
						}
						num = (short)662110208;
						short num4 = num;
						goto IL_179;
					}
					case 5:
						if (text.Trim().Equals(global::CommonResources.AppResources.ID_ADVANCEDDIGITALPRIVACY))
						{
							num = (short)1995440129;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111;
					case 6:
						if (global::System.Array.IndexOf<string>(this.b, text.Trim()) != -1)
						{
							num = (short)282460160;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DD;
					}
					goto IL_75;
					IL_111:
					num = (short)1345126406;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_179:
				num = (short)1678508037;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_157:
			return this.a[global::System.Array.IndexOf<string>(this.b, text.Trim())];
			IL_1DD:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THESTRINGOUTOFLOVRANGE);
			IL_75:
			text = (string)value;
			num = (short)549191682;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040065DD RID: 26077
		private int[] a;

		// Token: 0x040065DE RID: 26078
		private string[] b;

		// Token: 0x040065DF RID: 26079
		private string[] c;
	}
}
