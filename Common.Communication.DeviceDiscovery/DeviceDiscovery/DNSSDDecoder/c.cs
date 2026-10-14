using System;
using Motorola.Common.Communication.DeviceDiscovery;

namespace DeviceDiscovery.DNSSDDecoder
{
	// Token: 0x02000005 RID: 5
	internal class c
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002348 File Offset: 0x00000548
		internal static global::DeviceDiscovery.DNSSDDecoder.b a(string domainName)
		{
			int a_ = 1;
			short num;
			int num2;
			global::DeviceDiscovery.DNSSDDecoder.b result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					num = (short)816775169;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (domainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ŀቁ᱃晅", a_)))
						{
							num = (short)2115043330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)485818377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return result;
					case 2:
						result = new global::DeviceDiscovery.DNSSDDecoder.a();
						num = (short)1802174474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
						if (!domainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("☿㝁ぃ⥅♇", a_)))
						{
							num = (short)608174088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					case 5:
					{
						result = new global::DeviceDiscovery.DNSSDDecoder.e();
						num = (short)1153481728;
						short num3 = num;
						num = (short)491174912;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6E;
						default:
							num = (short)307953664;
							if (num != 0)
							{
							}
							num = (short)225640449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						if (domainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ؿ㝁㝃⽅❇⑉", a_)))
						{
							num = (short)1482686471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1938554880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_22E;
					case 8:
					{
						num = (short)331087872;
						short num4 = num;
						num = (short)517079046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (domainName.Contains(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ിു၃ॅ᱇ᡉ๋ōཏ", a_)))
						{
							num = (short)1182466053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						return result;
					}
					goto IL_6C;
					IL_22E:
					result = new global::DeviceDiscovery.DNSSDDecoder.d();
					num = (short)1739653123;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
			}
			IL_6C:
			result = null;
			IL_6E:
			num = (short)2051014660;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x04000006 RID: 6
		private const string a = "MOTOTRBO_";

		// Token: 0x04000007 RID: 7
		private const string b = "APX ";

		// Token: 0x04000008 RID: 8
		private const string c = "futon";

		// Token: 0x04000009 RID: 9
		private const string d = "Fusion";
	}
}
