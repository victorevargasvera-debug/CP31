using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000548 RID: 1352
	public sealed class UnpackFactorAndpackStep100FactorWith25 : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600B530 RID: 46384 RVA: 0x00A7F348 File Offset: 0x00A7D548
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)949223424;
			short num2 = num;
			num = (short)1620175851;
			short num3 = num;
			num = (short)279702507;
			switch (num3 == num)
			{
			}
			num = (short)1576075265;
			if (num != 0)
			{
			}
			num = (short)612237312;
			if (num != 0)
			{
			}
			return ((int)value * 25).ToString();
		}

		// Token: 0x0600B531 RID: 46385 RVA: 0x00A7F404 File Offset: 0x00A7D604
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num3;
			string s;
			for (;;)
			{
				IL_0A:
				num = (short)274122213;
				short num2 = num;
				num = (short)1499317733;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_129;
				default:
					num = (short)25493504;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						try
						{
							int.Parse(s);
							goto IL_87;
						}
						catch (global::System.Exception ex)
						{
							throw new global::System.ArgumentException(ex.ToString());
						}
						goto IL_129;
						IL_87:
						num = (short)1049231362;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_110;
					case 2:
					{
						num = (short)142737409;
						if (num != 0)
						{
						}
						num = (short)331939840;
						short num4 = num;
						if (global::System.Convert.ToInt32(value) % 100 != 0)
						{
							num = (short)1823211521;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134;
					}
					}
					goto IL_67;
				}
			}
			IL_110:
			IL_129:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_UIVALUEOUTSTEPSIZE);
			IL_134:
			return global::System.Convert.ToInt32(value) / 25;
			IL_67:
			s = global::System.Convert.ToString(value);
			num = (short)2055405568;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
