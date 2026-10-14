using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000019 RID: 25
	internal class TlsRsaPskClient : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsClient
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00006570 File Offset: 0x00004770
		public TlsRsaPskClient(global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity pskIdentity, global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, int[] cipherSuites, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
		{
			this.PskIdentity = pskIdentity;
			this.a = new global::Motorola.Common.Communication.TLS.TlsClientAuthentication(certificate, privateKey, 1);
			this.b = cipherSuites;
			this.c = version;
			this.d = version;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000065B0 File Offset: 0x000047B0
		public override void Init(global::Org.BouncyCastle.Crypto.Tls.TlsClientContext context)
		{
			short num = (short)697145499;
			short num2 = num;
			num = (short)818256027;
			switch (num2 == num)
			{
			}
			num = (short)1135869952;
			short num3 = num;
			num = (short)2073165825;
			if (num != 0)
			{
			}
			num = (short)19726336;
			if (num != 0)
			{
			}
			base.Init(context);
			this.a.Initialize(this.mContext);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00006674 File Offset: 0x00004874
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
					num2 = (short)862912513;
					if (num2 != 0)
					{
					}
					num2 = (short)2117926913;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (keyExchangeAlgorithm == 13)
					{
						num2 = (short)1785790467;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13E;
				case 2:
					if (keyExchangeAlgorithm != 1)
					{
						num2 = (short)1434648576;
						short num3 = num2;
						num2 = (short)1413349376;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AD;
				case 3:
					goto IL_13C;
				}
				goto IL_20;
			}
			IL_AD:
			num2 = (short)459573356;
			short num4 = num2;
			num2 = (short)847284332;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FF:
				return this.a(keyExchangeAlgorithm);
			default:
				num2 = (short)577175552;
				if (num2 != 0)
				{
				}
				return this.a();
			}
			IL_13C:
			goto IL_FF;
			IL_13E:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			IL_20:
			keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			num2 = (short)850657282;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000067C8 File Offset: 0x000049C8
		private global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange a(int keyExchange)
		{
			short num = (short)1715911589;
			short num2 = num;
			num = (short)1892531109;
			switch (num2 == num)
			{
			}
			num = (short)1058799616;
			short num3 = num;
			num = (short)1473708032;
			if (num != 0)
			{
			}
			num = (short)584581121;
			if (num != 0)
			{
			}
			return new global::Org.BouncyCastle.Crypto.Tls.TlsPskKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.PskIdentity, null, null, this.mNamedCurves, this.mClientECPointFormats, this.mServerECPointFormats);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00006894 File Offset: 0x00004A94
		private global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange a()
		{
			short num = (short)1694831038;
			short num2 = num;
			num = (short)1671696830;
			switch (num2 == num)
			{
			}
			num = (short)958136320;
			short num3 = num;
			num = (short)2818049;
			if (num != 0)
			{
			}
			num = (short)1615331328;
			if (num != 0)
			{
			}
			return new global::Org.BouncyCastle.Crypto.Tls.TlsRsaKeyExchange(this.mSupportedSignatureAlgorithms);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006948 File Offset: 0x00004B48
		public override void NotifySecureRenegotiation(bool secureRenegotiation)
		{
			short num = (short)416037892;
			short num2 = num;
			num = (short)1281375236;
			switch (num2 == num)
			{
			}
			num = (short)574291968;
			short num3 = num;
			num = (short)1868038145;
			if (num != 0)
			{
			}
			num = (short)1189543936;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000069F0 File Offset: 0x00004BF0
		public override global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication GetAuthentication()
		{
			short num = (short)295748591;
			short num2 = num;
			num = (short)561038319;
			switch (num2 == num)
			{
			}
			num = (short)351338496;
			short num3 = num;
			num = (short)1491992577;
			if (num != 0)
			{
			}
			num = (short)938868736;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00006AA0 File Offset: 0x00004CA0
		public override int[] GetCipherSuites()
		{
			short num = (short)1833913915;
			short num2 = num;
			num = (short)1673481787;
			switch (num2 == num)
			{
			}
			num = (short)1310457856;
			short num3 = num;
			num = (short)1798111232;
			if (num != 0)
			{
			}
			num = (short)1740177409;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00006B54 File Offset: 0x00004D54
		public override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1419014135;
				short num2 = num;
				num = (short)462122999;
				switch (num2 == num)
				{
				}
				num = (short)1498808320;
				short num3 = num;
				num = (short)133169152;
				if (num != 0)
				{
				}
				num = (short)1287520257;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00006C00 File Offset: 0x00004E00
		public override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion MinimumVersion
		{
			get
			{
				short num = (short)1051624031;
				short num2 = num;
				num = (short)1111130719;
				switch (num2 == num)
				{
				}
				num = (short)201785344;
				short num3 = num;
				num = (short)1001848833;
				if (num != 0)
				{
				}
				num = (short)1868496896;
				if (num != 0)
				{
				}
				return this.ClientVersion;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00006CB0 File Offset: 0x00004EB0
		public override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientHelloRecordLayerVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)216875549;
				short num2 = num;
				num = (short)837173789;
				switch (num2 == num)
				{
				}
				num = (short)1133969408;
				short num3 = num;
				num = (short)1080295425;
				if (num != 0)
				{
				}
				num = (short)785186816;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00006D60 File Offset: 0x00004F60
		public override global::System.Collections.IDictionary GetClientExtensions()
		{
			short num = (short)146997249;
			if (num != 0)
			{
			}
			num = (short)777255355;
			short num2 = num;
			num = (short)1925052859;
			switch (num2 == num)
			{
			default:
			{
				num = (short)156303360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1993211904;
			if (num != 0)
			{
			}
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(base.GetClientExtensions());
			global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddEncryptThenMacExtension(dictionary);
			return dictionary;
		}

		// Token: 0x04000031 RID: 49
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity PskIdentity;

		// Token: 0x04000032 RID: 50
		private readonly global::Motorola.Common.Communication.TLS.TlsClientAuthentication a;

		// Token: 0x04000033 RID: 51
		private readonly int[] b;

		// Token: 0x04000034 RID: 52
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion c;

		// Token: 0x04000035 RID: 53
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion d;
	}
}
