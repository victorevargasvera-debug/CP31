using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using SSLMangrComp.ConnectionLayer;

namespace SSLMangrComp
{
	// Token: 0x02000021 RID: 33
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class SecureClientConfiguration
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000D470 File Offset: 0x0000B670
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000D520 File Offset: 0x0000B720
		[global::System.Runtime.Serialization.DataMember]
		public string CACertificate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1475071856;
				short num2 = num;
				num = (short)1188220784;
				switch (num2 == num)
				{
				}
				num = (short)616103937;
				if (num != 0)
				{
				}
				num = (short)1761673216;
				short num3 = num;
				num = (short)159776768;
				if (num != 0)
				{
				}
				return this.<CACertificate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)172397261;
				short num2 = num;
				num = (short)2142081741;
				switch (num2 == num)
				{
				}
				num = (short)81788929;
				if (num != 0)
				{
				}
				num = (short)464977920;
				short num3 = num;
				num = (short)228589568;
				if (num != 0)
				{
				}
				this.<CACertificate>k__BackingField = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000D680 File Offset: 0x0000B880
		[global::System.Runtime.Serialization.DataMember]
		public string ClientCertificate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)55138387;
				short num2 = num;
				num = (short)1275615315;
				switch (num2 == num)
				{
				}
				num = (short)1566048257;
				if (num != 0)
				{
				}
				num = (short)1125318656;
				short num3 = num;
				num = (short)1516765184;
				if (num != 0)
				{
				}
				return this.<ClientCertificate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2096076338;
				short num2 = num;
				num = (short)1914541618;
				switch (num2 == num)
				{
				}
				num = (short)227082241;
				if (num != 0)
				{
				}
				num = (short)174260224;
				short num3 = num;
				num = (short)1337524224;
				if (num != 0)
				{
				}
				this.<ClientCertificate>k__BackingField = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000D730 File Offset: 0x0000B930
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		[global::System.Runtime.Serialization.DataMember]
		public string ClientKeyPassphrase
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2074763761;
				short num2 = num;
				num = (short)2087936497;
				switch (num2 == num)
				{
				}
				num = (short)1531052032;
				if (num != 0)
				{
				}
				num = (short)1933574144;
				short num3 = num;
				num = (short)1127743489;
				if (num != 0)
				{
				}
				return this.<ClientKeyPassphrase>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1016077497;
				short num2 = num;
				num = (short)1083317433;
				switch (num2 == num)
				{
				}
				num = (short)414908416;
				if (num != 0)
				{
				}
				num = (short)262012928;
				short num3 = num;
				num = (short)1555038209;
				if (num != 0)
				{
				}
				this.<ClientKeyPassphrase>k__BackingField = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000D890 File Offset: 0x0000BA90
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000D940 File Offset: 0x0000BB40
		[global::System.Runtime.Serialization.DataMember]
		public string CipherSuites
		{
			get
			{
				short num = (short)2096817719;
				short num2 = num;
				num = (short)2050745911;
				switch (num2 == num)
				{
				}
				num = (short)749338625;
				if (num != 0)
				{
				}
				num = (short)474873856;
				short num3 = num;
				num = (short)2020081664;
				if (num != 0)
				{
				}
				return this.cipherSuite;
			}
			set
			{
				short num = (short)649346491;
				short num2 = num;
				num = (short)752696763;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)679936000;
					if (num != 0)
					{
					}
					num = (short)1994522624;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)914292737;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A5;
							}
							continue;
						case 1:
							goto IL_DF;
						case 2:
							this.cipherSuite = value;
							num = (short)561446913;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A5:
						if (value.Length <= 3)
						{
							return;
						}
						num = (short)493486082;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_DF:
					num = (short)1844445184;
					short num4 = num;
					break;
				}
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000DA58 File Offset: 0x0000BC58
		public SecureClientConfiguration()
		{
			int a_ = 2;
			this.cipherSuite = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("申猵欷9༻稽Կᅁ繃杅ే᥉Ὃ瑍͏ᩑᕓ汕祗㭙ቛଢ଼ⱟ⹡幣䝥൧⑩㥫≭㱯䡱啳㉵㵷⥹䙻彽쵿욁놃벅ꦇ쎉좋쮍톏ꢑ떓쒕\udb97ꢙꚛ뾝那鲥囹ﲭﲱ", a_);
			base..ctor();
		}

		// Token: 0x04000075 RID: 117
		private string cipherSuite;
	}
}
