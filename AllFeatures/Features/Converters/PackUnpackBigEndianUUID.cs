using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;

namespace Features.Converters
{
	// Token: 0x02000031 RID: 49
	public sealed class PackUnpackBigEndianUUID : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00006A44 File Offset: 0x00004C44
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 12;
			short num = (short)1505427458;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Guid guid;
			for (;;)
			{
				string input;
				switch (num2)
				{
				case 0:
					goto IL_A2;
				case 1:
				{
					num = (short)231090381;
					short num3 = num;
					num = (short)1448945869;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A2;
					default:
					{
						num = (short)859701248;
						if (num != 0)
						{
						}
						num = (short)569704448;
						short num4 = num;
						num = (short)198574080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 3:
					input = null;
					goto IL_B5;
				}
				IL_3E:
				string text = (string)value;
				if (text == null)
				{
					num = (short)1037041665;
					if (num != 0)
					{
					}
					num = (short)1092616195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				input = text.Replace(global::AllFeatures.CodeplugGuid.b("", a_), "");
				IL_B5:
				if (!global::System.Guid.TryParseExact(input, global::AllFeatures.CodeplugGuid.b("菌", a_), out guid))
				{
					goto IL_17C;
				}
				num = (short)980353025;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A2:
			return guid.ToString().ToUpper();
			IL_17C:
			return "";
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			string text;
			string result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2092980509;
					short num3 = num2;
					num2 = (short)1059871005;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					case 1:
						goto IL_169;
					default:
					{
						num2 = (short)211681280;
						short num4 = num2;
						goto IL_169;
					}
					}
					IL_6C:
					result = text.Replace(global::AllFeatures.CodeplugGuid.b("", a_), "");
					num2 = (short)1048641538;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_169:
					num2 = (short)1628176384;
					if (num2 != 0)
					{
					}
					goto IL_6C;
				}
				case 1:
					if (text.Length == 36)
					{
						num2 = (short)1198522368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_9E;
				case 3:
					if (text != null)
					{
						num2 = (short)47054852;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)1997668353;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2D;
			}
			IL_9E:
			num2 = (short)1292500993;
			if (num2 != 0)
			{
			}
			return result;
			IL_2D:
			text = (string)value;
			result = "";
			num2 = (short)952172547;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
