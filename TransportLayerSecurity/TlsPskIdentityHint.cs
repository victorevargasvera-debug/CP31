using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TLS.TlsPskForAstro;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000018 RID: 24
	internal class TlsPskIdentityHint
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00005DA8 File Offset: 0x00003FA8
		public TlsPskIdentityHint(byte[] pskIdentityHint)
		{
			this.IdentityHint = pskIdentityHint;
			this.a(global::System.Text.Encoding.UTF8.GetString(pskIdentityHint));
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00005DD4 File Offset: 0x00003FD4
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00005E84 File Offset: 0x00004084
		public string DeviceId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1001671903;
				short num2 = num;
				num = (short)1994476767;
				switch (num2 == num)
				{
				}
				num = (short)1833435136;
				short num3 = num;
				num = (short)565051393;
				if (num != 0)
				{
				}
				num = (short)1537277952;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1034621521;
				short num2 = num;
				num = (short)2023887441;
				switch (num2 == num)
				{
				}
				num = (short)1283194880;
				short num3 = num;
				num = (short)12058625;
				if (num != 0)
				{
				}
				num = (short)77856768;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00005F34 File Offset: 0x00004134
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00005FE8 File Offset: 0x000041E8
		public string KeyId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1332651319;
				short num2 = num;
				num = (short)1989715255;
				switch (num2 == num)
				{
				}
				num = (short)1859715072;
				short num3 = num;
				num = (short)1887109121;
				if (num != 0)
				{
				}
				num = (short)604045312;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)576596676;
				short num2 = num;
				num = (short)1087318724;
				switch (num2 == num)
				{
				}
				num = (short)158269440;
				short num3 = num;
				num = (short)1248591872;
				if (num != 0)
				{
				}
				num = (short)1517813761;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00006098 File Offset: 0x00004298
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00006148 File Offset: 0x00004348
		public byte[] IdentityHint
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1975734721;
				short num2 = num;
				num = (short)1801474497;
				switch (num2 == num)
				{
				}
				num = (short)929693696;
				short num3 = num;
				num = (short)2051735552;
				if (num != 0)
				{
				}
				num = (short)1210056705;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)512415511;
				short num2 = num;
				num = (short)651548439;
				switch (num2 == num)
				{
				}
				num = (short)2040725504;
				short num3 = num;
				num = (short)586350593;
				if (num != 0)
				{
				}
				num = (short)798556160;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000061F8 File Offset: 0x000043F8
		private void a(string pskIdentityHint)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			int num2;
			short num3;
			global::System.Text.RegularExpressions.Match match;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (num2 > 16776415)
					{
						num3 = (short)1434714113;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)598802435;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					goto IL_2AB;
				case 2:
				{
					num3 = (short)1986718508;
					short num4 = num3;
					num3 = (short)1420094252;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C8;
					default:
						num3 = (short)472055808;
						if (num3 != 0)
						{
						}
						if (this.DeviceId.Equals(string.Empty))
						{
							num3 = (short)468910084;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						this.KeyId = match.Groups[global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("娰嘲䰴縶崸", a_)].Value;
						num2 = global::System.Convert.ToInt32(this.DeviceId);
						num3 = (short)280690697;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 3:
					if (this.KeyId.Length > 16)
					{
						goto IL_C8;
					}
					return;
				case 4:
					goto IL_22E;
				case 5:
				{
					num3 = (short)926810112;
					short num5 = num3;
					num3 = (short)2015100929;
					if (num3 != 0)
					{
					}
					num3 = (short)11010048;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 6:
					goto IL_E0;
				case 7:
					if (match.Success)
					{
						num3 = (short)294846472;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_13F;
				case 8:
					this.DeviceId = match.Groups[global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("唰嘲䌴帶娸帺琼嬾", a_)].Value.TrimStart(new char[]
					{
						'0'
					});
					num3 = (short)1498808322;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					if (num2 >= 1)
					{
						num3 = (short)2031288325;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_E5;
				}
				goto IL_41;
				IL_C8:
				num3 = (short)1548746758;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_E0:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("戰嘲嘴䈶䬸刺䤼䘾筀捂⹄≆え歊⑌⭎煐㽒ご㥖㹘⽚㕜罞ࡠၢ䕤፦٨Ѫ䵬ͮṰᵲቴ坶ɸ䭺|", a_), new object[]
			{
				this.KeyId.Length
			});
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Handshake_Failed);
			IL_E5:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("戰嘲嘴䈶䬸刺䤼䘾筀捂⅄≆㽈≊⹌⩎煐㩒ㅔ睖じ⡚絜ぞᑠᝢ䕤ࡦཨ䭪Ὤ๮ὰᑲၴ坶ɸ䭺|", a_), new object[]
			{
				num2
			});
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Handshake_Failed);
			IL_13F:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("戰嘲嘴䈶䬸刺䤼䘾筀捂ⵄ⹆❈㽊浌⥎㹐⅒㡔㙖ⵘ筚㑜ⱞ䅠੢୤ᅦࡨݪѬ୮兰ࡲ䕴੶", a_), new object[]
			{
				pskIdentityHint
			});
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Handshake_Failed);
			IL_22E:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("戰嘲嘴䈶䬸刺䤼䘾筀捂⅄≆㽈≊⹌⩎煐㩒ㅔ睖じ⡚絜ぞᑠᝢ䕤ࡦཨ䭪Ὤ๮ὰᑲၴ坶䥸", a_), global::System.Array.Empty<object>());
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Handshake_Failed);
			IL_2AB:
			goto IL_E5;
			IL_41:
			match = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("漰ᬲ਴ଶ崸帺䬼嘾≀♂ౄ⍆睈ᕊᙌ罎籐橒ࡔⱖ桘睚敜≞䡠塢䵤塦啨j࡬᙮㡰ᝲ䭴奶剸剺", a_), global::System.Text.RegularExpressions.RegexOptions.CultureInvariant).Match(pskIdentityHint);
			num3 = (short)2060713991;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x0400002E RID: 46
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x0400002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x04000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] c;
	}
}
