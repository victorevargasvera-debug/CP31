using System;
using System.Text;
using System.Text.RegularExpressions;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000F2 RID: 242
	public static class SerialNumberValidator
	{
		// Token: 0x06000DEC RID: 3564 RVA: 0x0013422C File Offset: 0x0013242C
		internal static bool ValidateSerialNumber(string serialNumber)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_72;
			}
			short num;
			int num3;
			bool result;
			string text;
			for (;;)
			{
				IL_13:
				num = (short)827850752;
				short num2 = num;
				switch (num3)
				{
				case 0:
					num = (short)223543299;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					result = true;
					num = (short)1047920645;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (text.Length == 10)
					{
						num = (short)1549991940;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
				{
					num = (short)919238875;
					short num4 = num;
					num = (short)1175222491;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)50659328;
						if (num != 0)
						{
						}
						if (char.IsUpper(text[9]))
						{
							num = (short)2028535819;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)713359370;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)394133513;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return result;
				case 6:
					result = true;
					num = (short)1026818049;
					if (num != 0)
					{
					}
					num = (short)217186312;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud882떄ꪆ낈횊회뾎벐ꪒ좔첖ꦘ뚚꒜슞猪鎢袤麦蚪芮ﲲ諸邼飂賄裆铈雊雌軎ﳐ角賖郘铚胜苞뫠폢죤\udee6꣨웪러싮꫰닲냴뻶뛸껺ꓼꋾ尀堂㔄⨆〈䨊‌唎㰐䠒吔刖倘吚䠜䘞簠縢縤ᜦШሪ氬Ȯ欰Ḳ渴瘶簸爺爼樾ᡀṂᡄ᱆祈晊瑌๎籐॒硔ౖᡘṚᑜၞ㑠㩢㡤㩦", a_)).IsMatch(text))
					{
						num = (short)1209466886;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 8:
					return result;
				case 9:
					if (!char.IsUpper(text[8]))
					{
						num = (short)1428553728;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10C;
				case 10:
					if (new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud882떄ꪆ낈횊회뾎벐ꪒ좔첖ꦘ뚚꒜슞猪鎢袤麦蚪芮ﲲ諸邼飂賄裆铈雊雌軎ﳐ角賖郘铚胜苞뫠폢죤\udee6꣨웪러싮꫰뫲뫴꫶ꓸꃺ췼틾㠀䈂⠄崆␈倊䐌䀎䰐丒且✖㐘√尜㈞笠ย縤昦氨截戬種栰渲栴氶सᘺм績汀᥂桄᱆ࡈ๊ьNѐ੒ࡔ੖", a_)).IsMatch(text))
					{
						num = (short)898629633;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 11:
					goto IL_10C;
				}
				goto IL_72;
				IL_10C:
				num = (short)1352400903;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_72:
			result = false;
			text = global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.convertSerialNumberToAscii(serialNumber);
			num = (short)1514143746;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x001344CC File Offset: 0x001326CC
		internal static bool IsCBISerialNumber(string serialNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				byte[] array;
				switch (num)
				{
				case 0:
					return result;
				case 1:
					goto IL_81;
				case 2:
					num2 = (short)473694209;
					if (num2 != 0)
					{
					}
					goto IL_81;
				case 3:
					goto IL_5F;
				case 4:
				{
					result = false;
					num2 = (short)1744240640;
					short num3 = num2;
					num2 = (short)1257915068;
					short num4 = num2;
					num2 = (short)477053628;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5F;
					default:
						num2 = (short)1193017344;
						if (num2 != 0)
						{
						}
						num2 = (short)308150272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					return result;
				case 6:
					result = false;
					num2 = (short)218234885;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return result;
				case 8:
				{
					int num5 = 0;
					num2 = (short)475922434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					if (array.Length == global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.a.Length)
					{
						num2 = (short)1489502216;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = false;
					num2 = (short)184221703;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)2001272843;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					return result;
				case 12:
				{
					int num5;
					if (num5 >= global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.a.Length)
					{
						num2 = (short)1615134730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)918487053;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
				{
					int num5;
					if (global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.a[num5] != array[num5])
					{
						num2 = (short)1906180102;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num5++;
					num2 = (short)672202753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_48;
				IL_5F:
				if (global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.ValidateSerialNumber(serialNumber))
				{
					num2 = (short)1348730884;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				array = global::System.Convert.FromBase64String(serialNumber);
				num2 = (short)302186505;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_81:
				num2 = (short)1319174156;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_48:
			result = true;
			num2 = (short)855506947;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0013477C File Offset: 0x0013297C
		internal static string convertSerialNumberToAscii(string serialNo)
		{
			short num;
			string result;
			try
			{
				num = (short)1582579922;
				short num2 = num;
				num = (short)202719442;
				switch (num2 == num)
				{
				}
				num = (short)142147584;
				if (num != 0)
				{
				}
				num = (short)1086193665;
				if (num != 0)
				{
				}
				byte[] bytes = global::System.Convert.FromBase64String(serialNo);
				result = global::System.Text.Encoding.ASCII.GetString(bytes);
			}
			catch (global::System.Exception)
			{
				result = string.Empty;
			}
			num = (short)1229848576;
			short num3 = num;
			return result;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00134854 File Offset: 0x00132A54
		// Note: this type is marked as 'beforefieldinit'.
		static SerialNumberValidator()
		{
			short num = (short)1771188548;
			short num2 = num;
			num = (short)1632317764;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1072365568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)844103681;
			if (num != 0)
			{
			}
			num = (short)895483904;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FlashRadio.SerialNumberValidator.a = new byte[]
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

		// Token: 0x04000736 RID: 1846
		public const short SERIALNUMBERSIZE = 10;

		// Token: 0x04000737 RID: 1847
		private static readonly byte[] a;
	}
}
