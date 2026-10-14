using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x0200055B RID: 1371
	public sealed class UnpackAndpackPretimeAndPreambles : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600B767 RID: 46951 RVA: 0x00AA7DF8 File Offset: 0x00AA5FF8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)970522625;
			if (num != 0)
			{
			}
			num = (short)2098184538;
			short num2 = num;
			num = (short)1814151514;
			switch (num2 == num)
			{
			}
			num = (short)380436480;
			if (num != 0)
			{
			}
			num = (short)1247477760;
			short num3 = num;
			return ((global::System.Convert.ToInt32(value) - 1) * 25).ToString();
		}

		// Token: 0x0600B768 RID: 46952 RVA: 0x00AA7EB8 File Offset: 0x00AA60B8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1346800074;
			short num2 = num;
			num = (short)457804234;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_10E;
			case 1:
				break;
			default:
			{
				num = (short)1282473984;
				short num3 = num;
				break;
			}
			}
			num = (short)1125384192;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			int num4;
			string s;
			for (;;)
			{
				IL_7E:
				switch (num4)
				{
				case 0:
					goto IL_10E;
				case 1:
					num = (short)1026621441;
					if (num != 0)
					{
					}
					try
					{
						int.Parse(s);
						goto IL_D6;
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.ArgumentException(ex.ToString());
					}
					goto IL_124;
					IL_D6:
					num = (short)1737752578;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (global::System.Convert.ToInt32(value) % 25 != 0)
					{
						num = (short)1641283584;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12F;
				}
				goto IL_90;
			}
			IL_12F:
			return global::System.Convert.ToInt32(value) / 25 + 1;
			IL_90:
			s = global::System.Convert.ToString(value);
			num = (short)1909325825;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7E;
			IL_10E:
			IL_124:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_UIVALUEOUTSTEPSIZE);
		}
	}
}
