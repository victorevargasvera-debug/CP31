using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x0200001A RID: 26
	internal class TlsRsaPskServer : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsServer
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00006E1C File Offset: 0x0000501C
		public TlsRsaPskServer(global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, int[] cipherSuites, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion minVersion, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion maxVersion, global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory) : base(cipherFactory)
		{
			this.PskIdentityManager = pskIdentityManager;
			this.a = certificate;
			this.b = privateKey;
			this.c = cipherSuites;
			this.f = minVersion;
			this.e = maxVersion;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006E5E File Offset: 0x0000505E
		public TlsRsaPskServer(global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, int[] cipherSuites, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version, global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory) : this(pskIdentityManager, certificate, privateKey, cipherSuites, version, version, cipherFactory)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006E74 File Offset: 0x00005074
		public override void NotifyClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
		{
			short num = (short)1009577355;
			short num2 = num;
			num = (short)1864756619;
			switch (num2 == num)
			{
			}
			num = (short)1372323840;
			short num3 = num;
			num = (short)561971200;
			if (num != 0)
			{
			}
			num = (short)1132527617;
			if (num != 0)
			{
			}
			global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> action = this.NotifyClientVersionAction;
			if (action == null)
			{
				return;
			}
			action(clientCertificate.ToX509Certificate());
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00006F38 File Offset: 0x00005138
		public override void NotifySecureRenegotiation(bool secureRenegotiation)
		{
			short num = (short)1501842675;
			short num2 = num;
			num = (short)1654541555;
			switch (num2 == num)
			{
			}
			num = (short)833552384;
			short num3 = num;
			num = (short)999948288;
			if (num != 0)
			{
			}
			num = (short)721223681;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00006FE0 File Offset: 0x000051E0
		public override global::Org.BouncyCastle.Crypto.Tls.CertificateRequest GetCertificateRequest()
		{
			if (!this.RequestClientCertificate)
			{
				short num = (short)1373185156;
				short num2 = num;
				num = (short)2050892932;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)796852225;
					if (num != 0)
					{
					}
					num = (short)147587072;
					short num3 = num;
					num = (short)652935168;
					if (num != 0)
					{
					}
					break;
				}
				}
				return null;
			}
			byte[] certificateTypes = new byte[]
			{
				1
			};
			global::System.Collections.IList defaultSupportedSignatureAlgorithms = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetDefaultSupportedSignatureAlgorithms();
			global::System.Collections.IList certificateAuthorities = new global::System.Collections.ArrayList
			{
				this.a.GetCertificateAt(0).Subject
			};
			return new global::Org.BouncyCastle.Crypto.Tls.CertificateRequest(certificateTypes, defaultSupportedSignatureAlgorithms, certificateAuthorities);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000070D0 File Offset: 0x000052D0
		public override global::Org.BouncyCastle.Crypto.Tls.TlsCredentials GetCredentials()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			int keyExchangeAlgorithm;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
				{
					num2 = (short)1064234858;
					short num3 = num2;
					num2 = (short)272691050;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
					{
						num2 = (short)1206779904;
						short num4 = num2;
						num2 = (short)995360768;
						if (num2 != 0)
						{
						}
						num2 = (short)55967746;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (keyExchangeAlgorithm != 13)
					{
						num2 = (short)1702297604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12C;
				case 3:
					if (keyExchangeAlgorithm != 1)
					{
						num2 = (short)1826291713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_60;
				case 4:
					num2 = (short)887554048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_60:
			return this.a();
			IL_7C:
			num2 = (short)624558081;
			if (num2 != 0)
			{
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			IL_12C:
			return null;
			IL_24:
			keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			num2 = (short)216006659;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000723C File Offset: 0x0000543C
		public override global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			int keyExchangeAlgorithm;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)145620993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (keyExchangeAlgorithm == 13)
					{
						num2 = (short)884932611;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 2:
				{
					num2 = (short)1519058945;
					if (num2 != 0)
					{
					}
					num2 = (short)201064448;
					short num3 = num2;
					if (keyExchangeAlgorithm != 1)
					{
						num2 = (short)1843200000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AE;
				}
				case 3:
					goto IL_13D;
				}
				goto IL_20;
			}
			IL_AE:
			num2 = (short)1294921823;
			short num4 = num2;
			num2 = (short)306245727;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_100:
				return this.a(keyExchangeAlgorithm);
			default:
				num2 = (short)826081280;
				if (num2 != 0)
				{
				}
				return this.d();
			}
			IL_13D:
			goto IL_100;
			IL_13F:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			IL_20:
			keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			num2 = (short)1346764802;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007390 File Offset: 0x00005590
		private global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange a(int keyExchange)
		{
			short num = (short)147980289;
			if (num != 0)
			{
			}
			num = (short)728482082;
			short num2 = num;
			num = (short)677036322;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1681326080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1925447680;
			if (num != 0)
			{
			}
			return new global::Org.BouncyCastle.Crypto.Tls.TlsPskKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, null, this.PskIdentityManager, null, this.mNamedCurves, this.mClientECPointFormats, this.mServerECPointFormats);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007460 File Offset: 0x00005660
		private global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange d()
		{
			short num = (short)27467321;
			short num2 = num;
			num = (short)530718265;
			switch (num2 == num)
			{
			}
			num = (short)2141257728;
			short num3 = num;
			num = (short)1441792001;
			if (num != 0)
			{
			}
			num = (short)367591424;
			if (num != 0)
			{
			}
			return new global::Org.BouncyCastle.Crypto.Tls.TlsRsaKeyExchange(this.mSupportedSignatureAlgorithms);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00007518 File Offset: 0x00005718
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000075C8 File Offset: 0x000057C8
		public global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> NotifyClientVersionAction
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private get
			{
				short num = (short)213623975;
				short num2 = num;
				num = (short)1288217767;
				switch (num2 == num)
				{
				}
				num = (short)59637760;
				short num3 = num;
				num = (short)1461714944;
				if (num != 0)
				{
				}
				num = (short)42139649;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1251906392;
				short num2 = num;
				num = (short)1514902360;
				switch (num2 == num)
				{
				}
				num = (short)1149108224;
				short num3 = num;
				num = (short)210436097;
				if (num != 0)
				{
				}
				num = (short)2140667904;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000767C File Offset: 0x0000587C
		protected override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion MaximumVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1131706494;
				short num2 = num;
				num = (short)778729598;
				switch (num2 == num)
				{
				}
				num = (short)283508736;
				short num3 = num;
				num = (short)1485373441;
				if (num != 0)
				{
				}
				num = (short)125763584;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00007728 File Offset: 0x00005928
		protected override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion MinimumVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)384269500;
				short num2 = num;
				num = (short)147946684;
				switch (num2 == num)
				{
				}
				num = (short)1834156032;
				short num3 = num;
				num = (short)474546176;
				if (num != 0)
				{
				}
				num = (short)2012020737;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000077D8 File Offset: 0x000059D8
		private bool RequestClientCertificate
		{
			get
			{
				short num = (short)1923599690;
				short num2 = num;
				num = (short)1218760010;
				switch (num2 == num)
				{
				}
				num = (short)1798438912;
				short num3 = num;
				num = (short)576651264;
				if (num != 0)
				{
				}
				num = (short)995491841;
				if (num != 0)
				{
				}
				return this.NotifyClientVersionAction != null;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000788C File Offset: 0x00005A8C
		private global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials a()
		{
			short num = (short)1692794881;
			if (num != 0)
			{
			}
			num = (short)1770094178;
			short num2 = num;
			num = (short)524123746;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1225064448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1185611776;
			if (num != 0)
			{
			}
			return new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsEncryptionCredentials(this.mContext, this.a, this.b);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000794C File Offset: 0x00005B4C
		protected override int[] GetCipherSuites()
		{
			short num = (short)1074200577;
			if (num != 0)
			{
			}
			num = (short)1440911630;
			short num2 = num;
			num = (short)893096206;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2055208960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1840709632;
			if (num != 0)
			{
			}
			return this.c;
		}

		// Token: 0x04000036 RID: 54
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager PskIdentityManager;

		// Token: 0x04000037 RID: 55
		private readonly global::Org.BouncyCastle.Crypto.Tls.Certificate a;

		// Token: 0x04000038 RID: 56
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter b;

		// Token: 0x04000039 RID: 57
		private readonly int[] c;

		// Token: 0x0400003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> d;

		// Token: 0x0400003B RID: 59
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion e;

		// Token: 0x0400003C RID: 60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion f;
	}
}
