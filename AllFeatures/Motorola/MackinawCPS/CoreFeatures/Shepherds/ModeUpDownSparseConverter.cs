using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001D0 RID: 464
	public sealed class ModeUpDownSparseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060053A1 RID: 21409 RVA: 0x004BD650 File Offset: 0x004BB850
		public ModeUpDownSparseConverter(int[] DBvalue, string[] ResIds)
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

		// Token: 0x060053A2 RID: 21410 RVA: 0x004BD6D0 File Offset: 0x004BB8D0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int num;
			short num2;
			int value2;
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
					{
						num2 = (short)1110245377;
						if (num2 != 0)
						{
						}
						if (global::System.Array.IndexOf<int>(this.a, value2) == -1)
						{
							goto IL_16D;
						}
						num2 = (short)1333725835;
						short num3 = num2;
						num2 = (short)1730415243;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
						{
							num2 = (short)799539200;
							short num4 = num2;
							num2 = (short)1334706176;
							if (num2 != 0)
							{
							}
							num2 = (short)1819017217;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						num2 = (short)894173187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_16B;
					case 3:
						if (culture == null)
						{
							num2 = (short)1197998082;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_103;
					}
					goto IL_20;
				}
				IL_103:
				return global::CommonResources.AcgResources.ResourceManager.GetString(this.c[global::System.Array.IndexOf<int>(this.a, value2)], culture);
				IL_16B:
				return this.b[global::System.Array.IndexOf<int>(this.a, value2)];
				IL_16D:
				throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THEVALUEOUTOFLOVRANGE);
			}
			IL_20:
			value2 = (int)value;
			IL_27:
			num2 = (short)6029312;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x004BD854 File Offset: 0x004BBA54
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)415236096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				string text;
				for (;;)
				{
					IL_27:
					string id_MODEDOWN;
					switch (num2)
					{
					case 0:
					{
						int value2;
						text = global::CommonResources.AcgResources.ResourceManager.GetString(this.c[global::System.Array.IndexOf<int>(this.a, value2)], culture);
						num = (short)1906573318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_131;
					case 2:
					{
						string id_MODEUP = global::CommonResources.AcgResources.ID_MODEUP;
						id_MODEDOWN = global::CommonResources.AcgResources.ID_MODEDOWN;
						int value2 = 64;
						int value3 = 65;
						if (id_MODEUP.Equals(text))
						{
							num = (short)1870987264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1719402500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						if (global::System.Array.IndexOf<string>(this.b, text.Trim()) == -1)
						{
							goto IL_263;
						}
						num = (short)1297449202;
						short num3 = num;
						num = (short)1044873458;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_211;
						default:
							num = (short)1650393088;
							if (num != 0)
							{
							}
							num = (short)610992129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_211;
					case 5:
					{
						num = (short)1146290177;
						if (num != 0)
						{
						}
						int value3;
						text = global::CommonResources.AcgResources.ResourceManager.GetString(this.c[global::System.Array.IndexOf<int>(this.a, value3)], culture);
						num = (short)899284999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_A0;
					case 7:
					{
						num = (short)389218304;
						short num4 = num;
						goto IL_A0;
					}
					}
					goto IL_4E;
					IL_A0:
					num = (short)430571523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_211:
					if (!id_MODEDOWN.Equals(text))
					{
						goto IL_A0;
					}
					num = (short)1669332997;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_131:
				return this.a[global::System.Array.IndexOf<string>(this.b, text.Trim())];
				IL_263:
				throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THESTRINGOUTOFLOVRANGE);
				IL_4E:
				text = (string)value;
				num = (short)294191106;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x04001FB7 RID: 8119
		private int[] a;

		// Token: 0x04001FB8 RID: 8120
		private string[] b;

		// Token: 0x04001FB9 RID: 8121
		private string[] c;
	}
}
