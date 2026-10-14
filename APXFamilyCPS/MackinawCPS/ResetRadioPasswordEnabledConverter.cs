using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.Server.EntityModel;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x02000016 RID: 22
	public class ResetRadioPasswordEnabledConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000050 RID: 80 RVA: 0x0000B814 File Offset: 0x00009A14
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			short num = (short)838270977;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B1;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
					goto IL_55;
				case 3:
					if (!(value is global::Motorola.CommonCPS.Server.EntityModel.APXRadio))
					{
						num = (short)1486422016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				}
				IL_3E:
				if (value == null)
				{
					num = (short)1907294210;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)768868355;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_55:
			num = (short)2111631179;
			short num3 = num;
			num = (short)572518219;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B1:
				throw new global::System.ArgumentException(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냣軥跧쫩鳫鳭鿯蓱鷳鋵鷷黹\udcfb製懿渁焃挅⠇礉搋愍攏縑瀓㘕稗缙㰛焝䘟ȡ倣弥堧伩ఫ漭怯樱昳圵尷匹医ḽ栿ف⅃ぅⅇ⥉⥋ࡍ≏㵑㥓Օ㵗⡙⩛㭝቟䭡䩣", a_), global::PreEmptive.SoS.Runtime.FixedLengthStream.b("鋣蟥蓧鿩觫", a_));
			default:
				num = (short)2132148225;
				if (num != 0)
				{
				}
				num = (short)756744192;
				if (num != 0)
				{
				}
				return true;
			}
			IL_12D:
			num = (short)454557696;
			short num4 = num;
			return false;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000B980 File Offset: 0x00009B80
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1316320086;
			short num2 = num;
			num = (short)792818518;
			switch (num2 == num)
			{
			}
			num = (short)1889992705;
			if (num != 0)
			{
			}
			num = (short)1587544064;
			if (num != 0)
			{
			}
			num = (short)314638336;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0400002A RID: 42
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
