using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Features.Converters
{
	// Token: 0x02000036 RID: 54
	public sealed class ZoneBankSparseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000075B4 File Offset: 0x000057B4
		public ZoneBankSparseConverter(int[] dbValue, string[] resIds)
		{
			this.a = dbValue;
			this.b = new string[resIds.Length];
			this.c = resIds;
			for (int i = 0; i < dbValue.Length; i++)
			{
				this.b[i] = global::CommonResources.AcgResources.ResourceManager.GetString(this.c[i], global::CommonResources.AcgResources.Culture);
				if (this.b[i] == null)
				{
					this.b[i] = this.c[i];
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00007634 File Offset: 0x00005834
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int value2;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (global::System.Array.IndexOf<int>(this.a, value2) != -1)
						{
							num2 = (short)305528832;
							short num3 = num2;
							num2 = (short)1019215873;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_14E;
					case 1:
						num2 = (short)927989763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_149;
					case 3:
						if (culture == null)
						{
							num2 = (short)134545410;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_93;
					}
					goto IL_20;
				}
				IL_149:
				num2 = (short)2051130732;
				short num4 = num2;
				num2 = (short)1156629868;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_E8;
				}
				IL_20:
				value2 = (int)value;
				num2 = (short)1735524352;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_93:
			return global::CommonResources.AcgResources.ResourceManager.GetString(this.c[global::System.Array.IndexOf<int>(this.a, value2)], culture);
			IL_E8:
			num2 = (short)1110245376;
			if (num2 != 0)
			{
			}
			return this.b[global::System.Array.IndexOf<int>(this.a, value2)];
			IL_14E:
			num2 = (short)1300430849;
			if (num2 != 0)
			{
			}
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THEVALUEOUTOFLOVRANGE);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000077C0 File Offset: 0x000059C0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_228;
				case 1:
					if (num2 == -1)
					{
						num3 = (short)29360132;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_22A;
				case 2:
					goto IL_1F5;
				case 3:
				{
					string text;
					if (text.Equals(global::CommonResources.AcgResources.ID_ZONEBANK))
					{
						num3 = (short)862978056;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_22A;
				}
				case 4:
					num3 = (short)1247543299;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
				{
					string text;
					if (text.Equals(global::CommonResources.AcgResources.ID_KEYPADLOCK))
					{
						num3 = (short)277676039;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1F5;
				}
				case 6:
					goto IL_22A;
				case 7:
				{
					string text = global::CommonResources.AcgResources.ID_KEYPADCONTROLSLOCK;
					num2 = global::System.Array.IndexOf<string>(this.b, text);
					num3 = (short)1995177984;
					short num4 = num3;
					num3 = (short)243728386;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 8:
				{
					string text = global::CommonResources.AcgResources.ID_ZONEBANKUP;
					num2 = global::System.Array.IndexOf<string>(this.b, text);
					num3 = (short)39387142;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 9:
					if (num2 == -1)
					{
						num3 = (short)366936074;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1F5;
				case 10:
					goto IL_289;
				case 11:
					if (num2 != -1)
					{
						num3 = (short)765460480;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_28E;
				}
				goto IL_40;
				IL_1F5:
				num3 = (short)1741553675;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_22A:
				num3 = (short)324403201;
				if (num3 != 0)
				{
				}
				num3 = (short)408813577;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_228:
			return this.a[num2];
			IL_28E:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THESTRINGOUTOFLOVRANGE);
			IL_40:
			num3 = (short)1137423770;
			short num5 = num3;
			num3 = (short)42907034;
			switch ((num5 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_289:
				num3 = (short)175767557;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			default:
			{
				num3 = (short)275382272;
				if (num3 != 0)
				{
				}
				string text = (string)value;
				num2 = global::System.Array.IndexOf<string>(this.b, text);
				num3 = (short)547422209;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04000073 RID: 115
		private readonly int[] a;

		// Token: 0x04000074 RID: 116
		private readonly string[] b;

		// Token: 0x04000075 RID: 117
		private readonly string[] c;
	}
}
