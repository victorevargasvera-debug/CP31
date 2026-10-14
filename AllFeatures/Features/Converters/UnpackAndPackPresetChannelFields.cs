using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;
using CommonResources;

namespace Features.Converters
{
	// Token: 0x02000033 RID: 51
	public sealed class UnpackAndPackPresetChannelFields : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00006F04 File Offset: 0x00005104
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			for (;;)
			{
				IL_00:
				short num = (short)393019392;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					case 1:
						num = (short)442761217;
						if (num != 0)
						{
						}
						num = (short)451018755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_12B;
					case 3:
					{
						num = (short)1933967360;
						short num3 = num;
						if ((int)value != -1)
						{
							goto IL_130;
						}
						num = (short)1446242249;
						short num4 = num;
						num = (short)874768329;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1624702976;
							if (num != 0)
							{
							}
							num = (short)260964354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_35:
					if ((int)value == 0)
					{
						goto IL_7A;
					}
					num = (short)1754005505;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7A:
			return global::Features.Converters.UnpackAndPackPresetChannelFields.a;
			IL_12B:
			goto IL_7A;
			IL_130:
			return value.ToString();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00007048 File Offset: 0x00005248
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)860880896;
			short num2 = num;
			num = (short)534571901;
			short num3 = num;
			num = (short)2080369533;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1634795520;
				if (num != 0)
				{
				}
				string s = global::System.Convert.ToString(value);
				if (!(s == global::Features.Converters.UnpackAndPackPresetChannelFields.a))
				{
					num = (short)1021575169;
					if (num != 0)
					{
					}
					return int.Parse(s);
				}
				break;
			}
			}
			return 0;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00007130 File Offset: 0x00005330
		// Note: this type is marked as 'beforefieldinit'.
		static UnpackAndPackPresetChannelFields()
		{
			int a_ = 18;
			short num = (short)371654656;
			short num2 = num;
			num = (short)560637526;
			short num3 = num;
			num = (short)2014226006;
			switch (num3 == num)
			{
			}
			num = (short)801177601;
			if (num != 0)
			{
			}
			num = (short)2139947008;
			if (num != 0)
			{
			}
			global::Features.Converters.UnpackAndPackPresetChannelFields.a = global::AllFeatures.CodeplugGuid.b("", a_) + global::CommonResources.AcgResources.ID_SELECTEDCHAN + global::AllFeatures.CodeplugGuid.b("", a_);
		}

		// Token: 0x04000072 RID: 114
		private static readonly string a;
	}
}
