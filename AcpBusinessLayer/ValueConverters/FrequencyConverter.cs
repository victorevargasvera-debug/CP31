using System;
using System.Globalization;
using System.Windows.Data;
using AcpBusinessLayer.UndoRedo;
using AcpCommonResources;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x02000043 RID: 67
	public class FrequencyConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x000669F0 File Offset: 0x00064BF0
		public FrequencyConverter(int step)
		{
			this.b = step;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00066A0C File Offset: 0x00064C0C
		public FrequencyConverter(bool kiloHertz, int step)
		{
			this.a = kiloHertz;
			this.b = step;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00066A30 File Offset: 0x00064C30
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 5;
			short num;
			double num3;
			for (;;)
			{
				num = (short)627834880;
				short num2 = num;
				num3 = (double)((int)value);
				if (!this.a)
				{
					goto IL_D8;
				}
				num = (short)1010996585;
				short num4 = num;
				num = (short)1736414569;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7A;
				}
			}
			IL_7A:
			num = (short)923860993;
			if (num != 0)
			{
			}
			num = (short)51904512;
			if (num != 0)
			{
			}
			return (num3 / 200.0).ToString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뇖", a_));
			IL_D8:
			return (num3 / 200000.0).ToString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뇖", a_));
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00066B38 File Offset: 0x00064D38
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1614348288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				decimal d;
				decimal num3;
				for (;;)
				{
					IL_28:
					decimal d2;
					decimal d3;
					decimal d4;
					switch (num2)
					{
					case 0:
						goto IL_238;
					case 1:
						if (this.a)
						{
							num = (short)118292483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						d = 1000000m;
						num = (short)2114715650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_238;
					case 3:
						num = (short)1746468865;
						if (num != 0)
						{
						}
						d = 1000m;
						num = (short)532807680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num3 = d2 / d3;
						num = (short)1214281745;
						short num4 = num;
						num = (short)178223121;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2AA;
						default:
							num = (short)1824391168;
							if (num != 0)
							{
							}
							num = (short)465174535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (d2 - global::System.Math.Floor(d2 / d4) * d4 == 0.0m)
						{
							num = (short)829685766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FB;
					case 6:
						goto IL_2AA;
					case 7:
						goto IL_139;
					case 8:
						if (d2 - global::System.Math.Floor(d2 / d3) * d3 == 0.0m)
						{
							num = (short)915734528;
							short num5 = num;
							num = (short)533659652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D;
					}
					goto IL_53;
					IL_238:
					d2 = num3 * d;
					d4 = global::System.Convert.ToDecimal(this.b);
					num = (short)38469637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AA:
					d3 = 5m;
					num = (short)1953103880;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_139:
				return (int)num3;
				IL_1FB:
				throw new global::System.ArgumentException(global::AcpCommonResources.AcpResources.UI_Value_Not_On_Step);
				IL_22D:
				throw new global::System.ArgumentException(global::AcpCommonResources.AcpResources.UI_Value_Not_On_Step);
				IL_53:
				num3 = decimal.Parse((string)value);
				d = 0m;
				num = (short)297598977;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x04000149 RID: 329
		private bool a;

		// Token: 0x0400014A RID: 330
		private int b;
	}
}
