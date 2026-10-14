using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x02000422 RID: 1058
	public sealed class SirenTypeSparseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06009111 RID: 37137 RVA: 0x0088E0CC File Offset: 0x0088C2CC
		public SirenTypeSparseConverter(int[] DBvalue, string[] ResIds)
		{
			this.a = DBvalue;
			this.b = new string[ResIds.Length];
			this.c = ResIds;
			for (int i = 0; i < DBvalue.Length; i++)
			{
				this.b[i] = global::CommonResources.AcgResources.ResourceManager.GetString(this.c[i], global::CommonResources.AcgResources.Culture);
				if (this.b[i] == null)
				{
					this.b[i] = this.c[i];
				}
			}
		}

		// Token: 0x06009112 RID: 37138 RVA: 0x0088E14C File Offset: 0x0088C34C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			int value2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1355481088;
					short num3 = num2;
					num2 = (short)949944322;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (global::System.Array.IndexOf<int>(this.a, value2) != -1)
					{
						num2 = (short)1209991168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16D;
				case 2:
				{
					if (culture != null)
					{
						goto IL_64;
					}
					num2 = (short)770155953;
					short num4 = num2;
					num2 = (short)1006937521;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)892469249;
						if (num2 != 0)
						{
						}
						num2 = (short)2029780992;
						if (num2 != 0)
						{
						}
						num2 = (short)834928643;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_168;
				}
				goto IL_20;
			}
			IL_64:
			return global::CommonResources.AcgResources.ResourceManager.GetString(this.c[global::System.Array.IndexOf<int>(this.a, value2)], culture);
			IL_168:
			return this.b[global::System.Array.IndexOf<int>(this.a, value2)];
			IL_16D:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THEVALUEOUTOFLOVRANGE);
			IL_20:
			value2 = (int)value;
			num2 = (short)1107951617;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009113 RID: 37139 RVA: 0x0088E2D0 File Offset: 0x0088C4D0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			string text;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (text.Equals(global::CommonResources.AcgResources.ID_OFF))
					{
						num2 = (short)460521473;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_99;
				case 1:
				{
					num2 = (short)1707999232;
					short num3 = num2;
					text = global::CommonResources.AcgResources.ID_SIRENOFF;
					num4 = global::System.Array.IndexOf<string>(this.b, text);
					num2 = (short)1741815811;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (num4 == -1)
					{
						num2 = (short)1979908102;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_99;
				case 3:
					goto IL_99;
				case 4:
				{
					if (num4 != -1)
					{
						num2 = (short)1295384581;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2075550653;
					short num5 = num2;
					num2 = (short)2099667901;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
						goto IL_1B0;
					}
					break;
				}
				case 5:
					goto IL_CF;
				case 6:
					goto IL_101;
				}
				goto IL_2C;
				IL_99:
				num2 = (short)1418133508;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_101:
				num2 = (short)1878786048;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_CF:
			return this.a[num4];
			IL_1B0:
			num2 = (short)1388642304;
			if (num2 != 0)
			{
			}
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THESTRINGOUTOFLOVRANGE);
			IL_2C:
			num2 = (short)1402339329;
			if (num2 != 0)
			{
			}
			text = (string)value;
			num4 = global::System.Array.IndexOf<string>(this.b, text);
			num2 = (short)361168898;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004844 RID: 18500
		private int[] a;

		// Token: 0x04004845 RID: 18501
		private string[] b;

		// Token: 0x04004846 RID: 18502
		private string[] c;
	}
}
