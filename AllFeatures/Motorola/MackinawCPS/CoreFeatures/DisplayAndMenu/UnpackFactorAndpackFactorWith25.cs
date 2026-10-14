using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000279 RID: 633
	public sealed class UnpackFactorAndpackFactorWith25 : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060070DA RID: 28890 RVA: 0x00646248 File Offset: 0x00644448
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1029792308;
			short num2 = num;
			num = (short)545874484;
			switch (num2 == num)
			{
			}
			num = (short)1444872193;
			if (num != 0)
			{
			}
			num = (short)242679808;
			short num3 = num;
			num = (short)213647360;
			if (num != 0)
			{
			}
			return (global::System.Convert.ToInt32(value) * 25).ToString();
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x00646304 File Offset: 0x00644504
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			string s;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)582221497;
					short num3 = num2;
					num2 = (short)668466873;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)764215296;
						if (num2 != 0)
						{
						}
						if (global::System.Convert.ToInt32(value) % 250 != 0)
						{
							num2 = (short)456982528;
							short num4 = num2;
							num2 = (short)1258553345;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13B;
					}
					break;
				}
				case 1:
					goto IL_EF;
				case 2:
					try
					{
						int.Parse(s);
						goto IL_3C;
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.ArgumentException(ex.ToString());
					}
					goto IL_108;
					IL_3C:
					num2 = (short)119013376;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_EF:
			IL_108:
			num2 = (short)2093875201;
			if (num2 != 0)
			{
			}
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_UIVALUEOUTSTEPSIZE);
			IL_13B:
			return global::System.Convert.ToInt32(value) / 25;
			IL_1C:
			s = global::System.Convert.ToString(value);
			num2 = (short)751304706;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
