using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x0200001B RID: 27
	internal class TlsServer : global::Org.BouncyCastle.Crypto.Tls.DefaultTlsServer
	{
		// Token: 0x06000088 RID: 136 RVA: 0x000079FC File Offset: 0x00005BFC
		public TlsServer(global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, int[] cipherSuites, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion minVersion, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion maxVersion, global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory) : base(cipherFactory)
		{
			this.a = certificate;
			this.b = privateKey;
			this.c = cipherSuites;
			this.f = minVersion;
			this.e = maxVersion;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007A38 File Offset: 0x00005C38
		public TlsServer(global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, int[] cipherSuites, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version, global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory) : this(certificate, privateKey, cipherSuites, version, version, cipherFactory)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007A54 File Offset: 0x00005C54
		public override void NotifyClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
		{
			short num = (short)113532910;
			short num2 = num;
			num = (short)603217902;
			switch (num2 == num)
			{
			}
			num = (short)1333395456;
			short num3 = num;
			num = (short)542572545;
			if (num != 0)
			{
			}
			num = (short)438370304;
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

		// Token: 0x0600008B RID: 139 RVA: 0x00007B14 File Offset: 0x00005D14
		public override void NotifySecureRenegotiation(bool secureRenegotiation)
		{
			short num = (short)1907928750;
			short num2 = num;
			num = (short)1474277038;
			switch (num2 == num)
			{
			}
			num = (short)2129068032;
			short num3 = num;
			num = (short)549781505;
			if (num != 0)
			{
			}
			num = (short)2035941376;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007BC0 File Offset: 0x00005DC0
		public override global::Org.BouncyCastle.Crypto.Tls.CertificateRequest GetCertificateRequest()
		{
			if (!this.RequestClientCertificate)
			{
				short num = (short)10652014;
				short num2 = num;
				num = (short)276990318;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)597622784;
					if (num != 0)
					{
					}
					num = (short)1407582208;
					short num3 = num;
					break;
				}
				}
				num = (short)2040856577;
				if (num != 0)
				{
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00007CAC File Offset: 0x00005EAC
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00007D60 File Offset: 0x00005F60
		public global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> NotifyClientVersionAction
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private get
			{
				short num = (short)1633550337;
				if (num != 0)
				{
				}
				num = (short)639252556;
				short num2 = num;
				num = (short)144324684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)288948224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)362807296;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)54788097;
				if (num != 0)
				{
				}
				num = (short)473828139;
				short num2 = num;
				num = (short)1645480747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1666580480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1623457792;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00007E10 File Offset: 0x00006010
		protected override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion MaximumVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1771030296;
				short num2 = num;
				num = (short)1780860696;
				switch (num2 == num)
				{
				}
				num = (short)1592000512;
				short num3 = num;
				num = (short)1435828225;
				if (num != 0)
				{
				}
				num = (short)855179264;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00007EC0 File Offset: 0x000060C0
		protected override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion MinimumVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1093051366;
				short num2 = num;
				num = (short)908108774;
				switch (num2 == num)
				{
				}
				num = (short)1167917056;
				short num3 = num;
				num = (short)358285313;
				if (num != 0)
				{
				}
				num = (short)118423552;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00007F70 File Offset: 0x00006170
		private bool RequestClientCertificate
		{
			get
			{
				short num = (short)1501874493;
				short num2 = num;
				num = (short)712624445;
				switch (num2 == num)
				{
				}
				num = (short)299892736;
				short num3 = num;
				num = (short)1062600705;
				if (num != 0)
				{
				}
				num = (short)1258291200;
				if (num != 0)
				{
				}
				return this.NotifyClientVersionAction != null;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00008024 File Offset: 0x00006224
		protected override global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials GetRsaEncryptionCredentials()
		{
			short num = (short)553178699;
			short num2 = num;
			num = (short)1797183051;
			switch (num2 == num)
			{
			}
			num = (short)549322752;
			short num3 = num;
			num = (short)835649537;
			if (num != 0)
			{
			}
			num = (short)1515782144;
			if (num != 0)
			{
			}
			return new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsEncryptionCredentials(this.mContext, this.a, this.b);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000080E4 File Offset: 0x000062E4
		protected override int[] GetCipherSuites()
		{
			short num = (short)547523911;
			short num2 = num;
			num = (short)199134535;
			switch (num2 == num)
			{
			}
			num = (short)1340211200;
			short num3 = num;
			num = (short)1310720001;
			if (num != 0)
			{
			}
			num = (short)543490048;
			if (num != 0)
			{
			}
			return this.c;
		}

		// Token: 0x0400003D RID: 61
		private readonly global::Org.BouncyCastle.Crypto.Tls.Certificate a;

		// Token: 0x0400003E RID: 62
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter b;

		// Token: 0x0400003F RID: 63
		private readonly int[] c;

		// Token: 0x04000040 RID: 64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> d;

		// Token: 0x04000041 RID: 65
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion e;

		// Token: 0x04000042 RID: 66
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion f;
	}
}
