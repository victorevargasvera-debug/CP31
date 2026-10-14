using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x02000299 RID: 665
	public sealed class ControlLockSparseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060074DC RID: 29916 RVA: 0x00693CF4 File Offset: 0x00691EF4
		public ControlLockSparseConverter(int[] DBvalue, string[] ResIds)
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

		// Token: 0x060074DD RID: 29917 RVA: 0x00693D74 File Offset: 0x00691F74
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
						num2 = (short)598278145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_167;
				case 1:
				{
					num2 = (short)1112953830;
					short num3 = num2;
					num2 = (short)975524838;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_167;
					default:
					{
						num2 = (short)443547649;
						if (num2 != 0)
						{
						}
						num2 = (short)1315569664;
						short num4 = num2;
						num2 = (short)494665728;
						if (num2 != 0)
						{
						}
						num2 = (short)1728315395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_165;
				case 3:
					if (culture == null)
					{
						num2 = (short)1064960002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FD;
				}
				goto IL_20;
			}
			IL_FD:
			return global::CommonResources.AcgResources.ResourceManager.GetString(this.c[global::System.Array.IndexOf<int>(this.a, value2)], culture);
			IL_165:
			return this.b[global::System.Array.IndexOf<int>(this.a, value2)];
			IL_167:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THEVALUEOUTOFLOVRANGE);
			IL_20:
			value2 = (int)value;
			num2 = (short)1365639168;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x00693EF4 File Offset: 0x006920F4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			int num2;
			short num3;
			string text;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (num2 != -1)
					{
						num3 = (short)1396047876;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1C2;
				case 1:
					goto IL_1B2;
				case 2:
					if (num2 == -1)
					{
						num3 = (short)1719960780;
						short num4 = num3;
						num3 = (short)574981324;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B2;
						case 1:
							break;
						default:
						{
							num3 = (short)1075314688;
							short num5 = num3;
							break;
						}
						}
						num3 = (short)629735425;
						if (num3 != 0)
						{
						}
						num3 = (short)1141899264;
						if (num3 != 0)
						{
						}
						num3 = (short)146669571;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_111;
				case 3:
					num3 = (short)829554694;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					goto IL_146;
				case 5:
					goto IL_111;
				case 6:
					if (text.Equals(global::CommonResources.AcgResources.ID_KEYPADLOCK))
					{
						num3 = (short)1250230273;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_111;
				}
				goto IL_2C;
				IL_111:
				num3 = (short)69926912;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1B2:
				text = global::CommonResources.AcgResources.ID_KEYPADCONTROLSLOCK;
				num2 = global::System.Array.IndexOf<string>(this.b, text);
				num3 = (short)1229258757;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_146:
			return this.a[num2];
			IL_1C2:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_THESTRINGOUTOFLOVRANGE);
			IL_2C:
			text = (string)value;
			num2 = global::System.Array.IndexOf<string>(this.b, text);
			num3 = (short)1052966914;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x04002D1D RID: 11549
		private int[] a;

		// Token: 0x04002D1E RID: 11550
		private string[] b;

		// Token: 0x04002D1F RID: 11551
		private string[] c;
	}
}
