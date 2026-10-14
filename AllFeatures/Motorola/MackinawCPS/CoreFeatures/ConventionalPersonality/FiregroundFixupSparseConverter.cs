using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x0200057F RID: 1407
	public sealed class FiregroundFixupSparseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600C235 RID: 49717 RVA: 0x00B60A60 File Offset: 0x00B5EC60
		public FiregroundFixupSparseConverter(int[] DBvalue, string[] ResIds)
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

		// Token: 0x0600C236 RID: 49718 RVA: 0x00B60AE0 File Offset: 0x00B5ECE0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			int value2;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::System.Array.IndexOf<int>(this.a, value2) != -1)
					{
						num2 = (short)246349827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16C;
				case 1:
					if (culture == null)
					{
						num2 = (short)937885698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_65;
				case 2:
				{
					num2 = (short)1453129729;
					if (num2 != 0)
					{
					}
					num2 = (short)1550799155;
					short num3 = num2;
					num2 = (short)1910657331;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C1;
					default:
						goto IL_151;
					}
					break;
				}
				case 3:
					goto IL_C1;
				}
				goto IL_20;
				IL_C1:
				num2 = (short)847511553;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_65:
			return global::CommonResources.AcgResources.ResourceManager.GetString(this.c[global::System.Array.IndexOf<int>(this.a, value2)], culture);
			IL_151:
			num2 = (short)1654325248;
			if (num2 != 0)
			{
			}
			num2 = (short)1248657408;
			short num4 = num2;
			return this.b[global::System.Array.IndexOf<int>(this.a, value2)];
			IL_16C:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THEVALUEOUTOFLOVRANGE);
			IL_20:
			value2 = (int)value;
			num2 = (short)1593049088;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600C237 RID: 49719 RVA: 0x00B60C64 File Offset: 0x00B5EE64
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int num;
			short num2;
			int num3;
			string text;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_E7;
					case 1:
						num2 = (short)1786445827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						if (num3 != -1)
						{
							goto IL_E7;
						}
						num2 = (short)2067464192;
						short num4 = num2;
						num2 = (short)1251888203;
						short num5 = num2;
						num2 = (short)918375499;
						switch ((num5 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_40;
						default:
							num2 = (short)1894973440;
							if (num2 != 0)
							{
							}
							num2 = (short)512032769;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						num2 = (short)425984001;
						if (num2 != 0)
						{
						}
						if (text.Equals(global::CommonResources.AcgResources.ID_FIREGROUND))
						{
							num2 = (short)168820741;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E7;
					case 4:
						goto IL_11D;
					case 5:
						text = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITY;
						num3 = global::System.Array.IndexOf<string>(this.b, text);
						num2 = (short)1043791872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (num3 != -1)
						{
							num2 = (short)119799812;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1C9;
					}
					goto IL_2C;
					IL_E7:
					num2 = (short)697106438;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_11D:
				return this.a[num3];
				IL_1C9:
				throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THESTRINGOUTOFLOVRANGE);
			}
			IL_2C:
			text = (string)value;
			num3 = global::System.Array.IndexOf<string>(this.b, text);
			IL_40:
			num2 = (short)1908277250;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040060AF RID: 24751
		private int[] a;

		// Token: 0x040060B0 RID: 24752
		private string[] b;

		// Token: 0x040060B1 RID: 24753
		private string[] c;
	}
}
