using System;
using System.Text;
using System.Text.RegularExpressions;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000178 RID: 376
	public static class SerialNumberValidator
	{
		// Token: 0x060012B7 RID: 4791 RVA: 0x001A36AC File Offset: 0x001A18AC
		internal static bool IsCBISerialNumber(string serialNumber)
		{
			return true;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x001A38D8 File Offset: 0x001A1AD8
		internal static bool ValidateSerialNumber(string serialNumber)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					goto IL_198;
				case 2:
					goto IL_1D7;
				case 3:
					goto IL_93;
				case 4:
					num2 = (short)1849032712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude84랆ꒈ늊킌풎ꆐ뺒겔쪖슘ꮚ난ꚞﲠ閤誦邨肬鲰華ﲼ銾鯀黄軆蛈雊郌铎郐ﻒ返𥳐苘鋚鋜苞볠룢헤쫦탨ꫪ샬뗮\udcf0ꣲ보룶ꓸ꛺꛼쿾Ⰰ㨂䐄⨆匈☊嘌䘎帐丒䠔䰖⤘㘚␜帞ఠ礢ࠤ簦栨渪搬怮搰樲栴樶戸଺ြؾ@湂ὄ橆ቈ੊ࡌَṐْ౔੖ј", a_)).IsMatch(serialNumber))
					{
						num2 = (short)79167494;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					result = true;
					num2 = (short)1907818496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					if (!new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude84랆ꒈ늊킌풎ꆐ뺒겔쪖슘ꮚ난ꚞﲠ閤誦邨肬鲰華ﲼ銾鯀黄軆蛈雊郌铎郐ﻒ返𥳐苘鋚鋜苞볠룢헤쫦탨ꫪ샬뗮\udcf0ꣲ듴닶냸듺꣼꛾尀市帄㜆␈㈊䰌∎䬐㸒且嘖尘刚刜䨞砠縢砤簦ᤨتᐬ渮ᰰ椲ᠴ氶砸縺琼瀾ᑀᩂᡄᩆቈ筊恌癎ၐ繒པ穖ɘᩚᡜᙞ⹠㙢㱤㩦㑨", a_)).IsMatch(serialNumber))
					{
						goto IL_69;
					}
					num2 = (short)509078458;
					short num3 = num2;
					num2 = (short)2031020986;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_198;
					default:
						num2 = (short)2085158912;
						if (num2 != 0)
						{
						}
						num2 = (short)906821633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 8:
					if (!char.IsUpper(serialNumber[8]))
					{
						num2 = (short)571670537;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_93;
				case 9:
					num2 = (short)1147600906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (char.IsUpper(serialNumber[9]))
					{
						num2 = (short)1837170691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1011875845;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (serialNumber.Length == 10)
					{
						num2 = (short)1591476228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 12:
					try
					{
						byte[] bytes = global::System.Convert.FromBase64String(serialNumber);
						serialNumber = global::System.Text.Encoding.ASCII.GetString(bytes);
						goto IL_23E;
					}
					catch (global::System.Exception)
					{
						goto IL_23E;
					}
					goto IL_198;
					IL_23E:
					num2 = (short)1105330187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_4D;
				IL_93:
				num2 = (short)1058668551;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_198:
				result = true;
				num2 = (short)1999896577;
				if (num2 != 0)
				{
				}
				num2 = (short)1397161986;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_69:
			num2 = (short)1475739648;
			short num4 = num2;
			return result;
			IL_1D7:
			goto IL_69;
			IL_4D:
			result = false;
			num2 = (short)1673265164;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x001A3BB8 File Offset: 0x001A1DB8
		// Note: this type is marked as 'beforefieldinit'.
		static SerialNumberValidator()
		{
			short num = (short)2038253046;
			short num2 = num;
			num = (short)1991525878;
			switch (num2 == num)
			{
			}
			num = (short)384827392;
			if (num != 0)
			{
			}
			num = (short)1069154305;
			if (num != 0)
			{
			}
			num = (short)920453120;
			short num3 = num;
			global::SpecialFeatures.Comms.SerialNumberValidator.a = new byte[]
			{
				200,
				212,
				221,
				157,
				162,
				204,
				132,
				209,
				157,
				175
			};
		}

		// Token: 0x04000A11 RID: 2577
		private static readonly byte[] a;

		// Token: 0x04000A12 RID: 2578
		internal const short SERIALNUMBERSIZE = 10;
	}
}
