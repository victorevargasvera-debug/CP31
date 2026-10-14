using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000340 RID: 832
	public sealed class ProtocolVersion
	{
		// Token: 0x06002249 RID: 8777 RVA: 0x00097A1E File Offset: 0x00095C1E
		private ProtocolVersion(int v, string name)
		{
			this.version = (v & 65535);
			this.name = name;
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00097A3A File Offset: 0x00095C3A
		public int FullVersion
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x00097A42 File Offset: 0x00095C42
		public int MajorVersion
		{
			get
			{
				return this.version >> 8;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00097A4C File Offset: 0x00095C4C
		public int MinorVersion
		{
			get
			{
				return this.version & 255;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x00097A5A File Offset: 0x00095C5A
		public bool IsDtls
		{
			get
			{
				return this.MajorVersion == 254;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x00097A69 File Offset: 0x00095C69
		public bool IsSsl
		{
			get
			{
				return this == global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.SSLv3;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x00097A73 File Offset: 0x00095C73
		public bool IsTls
		{
			get
			{
				return this.MajorVersion == 3;
			}
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00097A7E File Offset: 0x00095C7E
		public global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion GetEquivalentTLSVersion()
		{
			if (!this.IsDtls)
			{
				return this;
			}
			if (this == global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv10)
			{
				return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv11;
			}
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12;
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x00097AA0 File Offset: 0x00095CA0
		public bool IsEqualOrEarlierVersionOf(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
		{
			if (this.MajorVersion != version.MajorVersion)
			{
				return false;
			}
			int diffMinorVersion = version.MinorVersion - this.MinorVersion;
			if (!this.IsDtls)
			{
				return diffMinorVersion >= 0;
			}
			return diffMinorVersion <= 0;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00097AE4 File Offset: 0x00095CE4
		public bool IsLaterVersionOf(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
		{
			if (this.MajorVersion != version.MajorVersion)
			{
				return false;
			}
			int diffMinorVersion = version.MinorVersion - this.MinorVersion;
			if (!this.IsDtls)
			{
				return diffMinorVersion < 0;
			}
			return diffMinorVersion > 0;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00097B20 File Offset: 0x00095D20
		public override bool Equals(object other)
		{
			return this == other || (other is global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion && this.Equals((global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion)other));
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00097B3E File Offset: 0x00095D3E
		public bool Equals(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion other)
		{
			return other != null && this.version == other.version;
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00097B53 File Offset: 0x00095D53
		public override int GetHashCode()
		{
			return this.version;
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00097B5C File Offset: 0x00095D5C
		public static global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion Get(int major, int minor)
		{
			if (major != 3)
			{
				if (major != 254)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				switch (minor)
				{
				case 253:
					return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv12;
				case 254:
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				case 255:
					return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv10;
				default:
					return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.GetUnknownVersion(major, minor, "DTLS");
				}
			}
			else
			{
				switch (minor)
				{
				case 0:
					return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.SSLv3;
				case 1:
					return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv10;
				case 2:
					return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv11;
				case 3:
					return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12;
				default:
					return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.GetUnknownVersion(major, minor, "TLS");
				}
			}
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00097BF6 File Offset: 0x00095DF6
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00097C00 File Offset: 0x00095E00
		private static global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion GetUnknownVersion(int major, int minor, string prefix)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(major);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(minor);
			int v = major << 8 | minor;
			string hex = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(global::System.Convert.ToString(65536 | v, 16).Substring(1));
			return new global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion(v, prefix + " 0x" + hex);
		}

		// Token: 0x04000DCB RID: 3531
		public static readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion SSLv3 = new global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion(768, "SSL 3.0");

		// Token: 0x04000DCC RID: 3532
		public static readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion TLSv10 = new global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion(769, "TLS 1.0");

		// Token: 0x04000DCD RID: 3533
		public static readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion TLSv11 = new global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion(770, "TLS 1.1");

		// Token: 0x04000DCE RID: 3534
		public static readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion TLSv12 = new global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion(771, "TLS 1.2");

		// Token: 0x04000DCF RID: 3535
		public static readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion DTLSv10 = new global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion(65279, "DTLS 1.0");

		// Token: 0x04000DD0 RID: 3536
		public static readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion DTLSv12 = new global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion(65277, "DTLS 1.2");

		// Token: 0x04000DD1 RID: 3537
		private readonly int version;

		// Token: 0x04000DD2 RID: 3538
		private readonly string name;
	}
}
