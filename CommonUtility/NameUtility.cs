using System;
using System.Globalization;

namespace CommonUtility
{
	// Token: 0x02000038 RID: 56
	public static class NameUtility
	{
		// Token: 0x06000129 RID: 297 RVA: 0x0001EEFC File Offset: 0x0001D0FC
		public static string GetDefaultSaveAsName(string name, bool needHundredsecond = true, bool needMillisecond = false)
		{
			int a_ = 14;
			short num = (short)1071906816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C7;
				}
				string text2;
				string result;
				for (;;)
				{
					IL_30:
					int num3;
					string text;
					string str;
					int num4;
					switch (num2)
					{
					case 0:
						text = name.Substring(0, num3);
						num = (short)124846102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_352;
					case 2:
						if (text.Length > num3)
						{
							num = (short)790888455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_109;
					case 3:
						if (string.IsNullOrEmpty(name))
						{
							num = (short)2048655384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						str = global::System.DateTime.Now.ToString(text2, global::System.Globalization.CultureInfo.InvariantCulture);
						num4 = name.LastIndexOf(global::CommonUtility.VersionUtility.b("怾", a_), global::System.StringComparison.CurrentCulture);
						num = (short)319881237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)315097117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_199;
					case 6:
						goto IL_199;
					case 7:
						text = text.Substring(0, num3);
						num = (short)862846996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (name.Length > num3)
						{
							num = (short)113967118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_352;
					case 9:
						goto IL_587;
					case 10:
						if (needHundredsecond)
						{
							num = (short)1615986701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text2 = global::CommonUtility.VersionUtility.b("䘾㡀โࡄ⍆ⵈᑊՌݎ㱐㹒♔⑖", a_);
						num = (short)1908932614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_199;
					case 12:
						num = (short)2044526626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						text2 = global::CommonUtility.VersionUtility.b("䘾㡀โࡄ⍆ⵈᑊՌݎ㱐㹒♔⑖㽘㵚", a_);
						num = (short)1797652491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						text = name.Substring(0, num3);
						num = (short)121372673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_13A;
					case 16:
						return result;
					case 17:
						num = (short)1137901569;
						if (num != 0)
						{
						}
						if (num4 < name.Length)
						{
							num = (short)466092059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D3;
					case 18:
						if (needMillisecond)
						{
							num = (short)1803288608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1395589130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_4F5;
					case 20:
						goto IL_109;
					case 21:
					{
						if (num4 <= 0)
						{
							goto IL_5D3;
						}
						num = (short)1595514477;
						short num5 = num;
						num = (short)866426477;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4F5;
						default:
							num = (short)1295712256;
							if (num != 0)
							{
							}
							num = (short)2137325587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 22:
						goto IL_1F4;
					case 23:
						if (name.Length > num3)
						{
							num = (short)2061041664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F4;
					case 24:
						goto IL_1EF;
					case 25:
						num = (short)1226309667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (num4 > 0)
						{
							num = (short)483590148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311;
					case 27:
						num4 = name.LastIndexOf(global::CommonUtility.VersionUtility.b("怾", a_), num4 - 1, num4, global::System.StringComparison.CurrentCulture);
						num = (short)461635612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						num = (short)562757632;
						short num6 = num;
						goto IL_5D3;
					}
					case 29:
						if (num4 < name.Length)
						{
							num = (short)1425342494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311;
					case 30:
					{
						string s = name.Substring(num4 + 1);
						num = (short)1092747295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						string s;
						global::System.DateTime dateTime;
						if (!global::System.DateTime.TryParseExact(s, global::CommonUtility.VersionUtility.b("䘾㡀โࡄ⍆ⵈᑊՌݎ㱐㹒♔⑖㽘㵚㭜㥞ݠբ", a_), global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.None, out dateTime))
						{
							num = (short)1710424076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					}
					case 32:
						text2 = global::CommonUtility.VersionUtility.b("䘾㡀โࡄ⍆ⵈᑊՌݎ㱐㹒♔⑖㽘㵚㭜㥞ݠբ", a_);
						num = (short)917962757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						return result;
					case 34:
					{
						string s;
						global::System.DateTime dateTime;
						if (!global::System.DateTime.TryParseExact(s, global::CommonUtility.VersionUtility.b("䘾㡀โࡄ⍆ⵈᑊՌݎ㱐㹒♔⑖", a_), global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.None, out dateTime))
						{
							num = (short)1411514393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					}
					case 35:
					{
						string s;
						global::System.DateTime dateTime;
						if (global::System.DateTime.TryParseExact(s, global::CommonUtility.VersionUtility.b("䘾㡀โࡄ⍆ⵈᑊՌݎ㱐㹒♔⑖㽘㵚", a_), global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.None, out dateTime))
						{
							num = (short)1509097481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = name;
						num = (short)2130575383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_C7;
					IL_109:
					result = text + global::CommonUtility.VersionUtility.b("怾", a_) + str;
					num = (short)347996175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_199:
					num3 = 50 - text2.Length - 1;
					text = string.Empty;
					name = name.Trim();
					num = (short)365363203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F4:
					result = text + global::CommonUtility.VersionUtility.b("怾", a_) + str;
					num = (short)129237025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_311:
					text = name;
					num = (short)1757544456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_352:
					result = text + global::CommonUtility.VersionUtility.b("怾", a_) + str;
					num = (short)297009168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F5:
					num = (short)1765212177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_587:
					text = name.Substring(0, num4);
					num = (short)1431633922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D3:
					num = (short)1991049242;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13A:
				return result;
				IL_1EF:
				throw new global::System.ArgumentNullException();
				IL_C7:
				text2 = string.Empty;
				num = (short)1502937106;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
