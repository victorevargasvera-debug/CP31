using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000DE RID: 222
	public sealed class ProtocolVersion
	{
		// Token: 0x060007EA RID: 2026 RVA: 0x00021624 File Offset: 0x0001F824
		public static bool Contains(global::Org.BouncyCastle.Tls.ProtocolVersion[] versions, global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			if (versions != null && version != null)
			{
				for (int i = 0; i < versions.Length; i++)
				{
					if (version.Equals(versions[i]))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00021654 File Offset: 0x0001F854
		public static global::Org.BouncyCastle.Tls.ProtocolVersion GetEarliestDtls(global::Org.BouncyCastle.Tls.ProtocolVersion[] versions)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion earliest = null;
			if (versions != null)
			{
				foreach (global::Org.BouncyCastle.Tls.ProtocolVersion next in versions)
				{
					if (next != null && next.IsDtls && (earliest == null || next.MinorVersion > earliest.MinorVersion))
					{
						earliest = next;
					}
				}
			}
			return earliest;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00021698 File Offset: 0x0001F898
		public static global::Org.BouncyCastle.Tls.ProtocolVersion GetEarliestTls(global::Org.BouncyCastle.Tls.ProtocolVersion[] versions)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion earliest = null;
			if (versions != null)
			{
				foreach (global::Org.BouncyCastle.Tls.ProtocolVersion next in versions)
				{
					if (next != null && next.IsTls && (earliest == null || next.MinorVersion < earliest.MinorVersion))
					{
						earliest = next;
					}
				}
			}
			return earliest;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x000216DC File Offset: 0x0001F8DC
		public static global::Org.BouncyCastle.Tls.ProtocolVersion GetLatestDtls(global::Org.BouncyCastle.Tls.ProtocolVersion[] versions)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion latest = null;
			if (versions != null)
			{
				foreach (global::Org.BouncyCastle.Tls.ProtocolVersion next in versions)
				{
					if (next != null && next.IsDtls && (latest == null || next.MinorVersion < latest.MinorVersion))
					{
						latest = next;
					}
				}
			}
			return latest;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00021720 File Offset: 0x0001F920
		public static global::Org.BouncyCastle.Tls.ProtocolVersion GetLatestTls(global::Org.BouncyCastle.Tls.ProtocolVersion[] versions)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion latest = null;
			if (versions != null)
			{
				foreach (global::Org.BouncyCastle.Tls.ProtocolVersion next in versions)
				{
					if (next != null && next.IsTls && (latest == null || next.MinorVersion > latest.MinorVersion))
					{
						latest = next;
					}
				}
			}
			return latest;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00021763 File Offset: 0x0001F963
		internal static bool IsSupportedDtlsVersionClient(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return version != null && version.IsEqualOrLaterVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.CLIENT_EARLIEST_SUPPORTED_DTLS) && version.IsEqualOrEarlierVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.CLIENT_LATEST_SUPPORTED_DTLS);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00021782 File Offset: 0x0001F982
		internal static bool IsSupportedDtlsVersionServer(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return version != null && version.IsEqualOrLaterVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.SERVER_EARLIEST_SUPPORTED_DTLS) && version.IsEqualOrEarlierVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.SERVER_LATEST_SUPPORTED_DTLS);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000217A4 File Offset: 0x0001F9A4
		internal static bool IsSupportedTlsVersionClient(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			if (version == null)
			{
				return false;
			}
			int fullVersion = version.FullVersion;
			return fullVersion >= global::Org.BouncyCastle.Tls.ProtocolVersion.CLIENT_EARLIEST_SUPPORTED_TLS.FullVersion && fullVersion <= global::Org.BouncyCastle.Tls.ProtocolVersion.CLIENT_LATEST_SUPPORTED_TLS.FullVersion;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000217DC File Offset: 0x0001F9DC
		internal static bool IsSupportedTlsVersionServer(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			if (version == null)
			{
				return false;
			}
			int fullVersion = version.FullVersion;
			return fullVersion >= global::Org.BouncyCastle.Tls.ProtocolVersion.SERVER_EARLIEST_SUPPORTED_TLS.FullVersion && fullVersion <= global::Org.BouncyCastle.Tls.ProtocolVersion.SERVER_LATEST_SUPPORTED_TLS.FullVersion;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00021814 File Offset: 0x0001FA14
		private ProtocolVersion(int v, string name)
		{
			this.version = (v & 65535);
			this.name = name;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00021830 File Offset: 0x0001FA30
		public global::Org.BouncyCastle.Tls.ProtocolVersion[] DownTo(global::Org.BouncyCastle.Tls.ProtocolVersion min)
		{
			if (!this.IsEqualOrLaterVersionOf(min))
			{
				throw new global::System.ArgumentException("must be an equal or earlier version of this one", "min");
			}
			global::System.Collections.IList result = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			result.Add(this);
			global::Org.BouncyCastle.Tls.ProtocolVersion current = this;
			while (!current.Equals(min))
			{
				current = current.GetPreviousVersion();
				result.Add(current);
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion[] versions = new global::Org.BouncyCastle.Tls.ProtocolVersion[result.Count];
			for (int i = 0; i < result.Count; i++)
			{
				versions[i] = (global::Org.BouncyCastle.Tls.ProtocolVersion)result[i];
			}
			return versions;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000218AD File Offset: 0x0001FAAD
		public int FullVersion
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x000218B5 File Offset: 0x0001FAB5
		public int MajorVersion
		{
			get
			{
				return this.version >> 8;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x000218BF File Offset: 0x0001FABF
		public int MinorVersion
		{
			get
			{
				return this.version & 255;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000218CD File Offset: 0x0001FACD
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x000218D5 File Offset: 0x0001FAD5
		public bool IsDtls
		{
			get
			{
				return this.MajorVersion == 254;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000218E4 File Offset: 0x0001FAE4
		public bool IsSsl
		{
			get
			{
				return this == global::Org.BouncyCastle.Tls.ProtocolVersion.SSLv3;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x000218EE File Offset: 0x0001FAEE
		public bool IsTls
		{
			get
			{
				return this.MajorVersion == 3;
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000218FC File Offset: 0x0001FAFC
		public global::Org.BouncyCastle.Tls.ProtocolVersion GetEquivalentTlsVersion()
		{
			int majorVersion = this.MajorVersion;
			if (majorVersion == 3)
			{
				return this;
			}
			if (majorVersion != 254)
			{
				return null;
			}
			int minorVersion = this.MinorVersion;
			if (minorVersion == 253)
			{
				return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12;
			}
			if (minorVersion == 255)
			{
				return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv11;
			}
			return null;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00021948 File Offset: 0x0001FB48
		public global::Org.BouncyCastle.Tls.ProtocolVersion GetNextVersion()
		{
			int major = this.MajorVersion;
			int minor = this.MinorVersion;
			if (major != 3)
			{
				if (major != 254)
				{
					return null;
				}
				if (minor == 0)
				{
					return null;
				}
				if (minor != 255)
				{
					return global::Org.BouncyCastle.Tls.ProtocolVersion.Get(major, minor - 1);
				}
				return global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12;
			}
			else
			{
				if (minor == 255)
				{
					return null;
				}
				return global::Org.BouncyCastle.Tls.ProtocolVersion.Get(major, minor + 1);
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000219A8 File Offset: 0x0001FBA8
		public global::Org.BouncyCastle.Tls.ProtocolVersion GetPreviousVersion()
		{
			int major = this.MajorVersion;
			int minor = this.MinorVersion;
			if (major != 3)
			{
				if (major != 254)
				{
					return null;
				}
				if (minor == 253)
				{
					return global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10;
				}
				if (minor == 255)
				{
					return null;
				}
				return global::Org.BouncyCastle.Tls.ProtocolVersion.Get(major, minor + 1);
			}
			else
			{
				if (minor == 0)
				{
					return null;
				}
				return global::Org.BouncyCastle.Tls.ProtocolVersion.Get(major, minor - 1);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00021A04 File Offset: 0x0001FC04
		public bool IsEarlierVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			if (version == null || this.MajorVersion != version.MajorVersion)
			{
				return false;
			}
			int diffMinorVersion = this.MinorVersion - version.MinorVersion;
			if (!this.IsDtls)
			{
				return diffMinorVersion < 0;
			}
			return diffMinorVersion > 0;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00021A44 File Offset: 0x0001FC44
		public bool IsEqualOrEarlierVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			if (version == null || this.MajorVersion != version.MajorVersion)
			{
				return false;
			}
			int diffMinorVersion = this.MinorVersion - version.MinorVersion;
			if (!this.IsDtls)
			{
				return diffMinorVersion <= 0;
			}
			return diffMinorVersion >= 0;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00021A8C File Offset: 0x0001FC8C
		public bool IsEqualOrLaterVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			if (version == null || this.MajorVersion != version.MajorVersion)
			{
				return false;
			}
			int diffMinorVersion = this.MinorVersion - version.MinorVersion;
			if (!this.IsDtls)
			{
				return diffMinorVersion >= 0;
			}
			return diffMinorVersion <= 0;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00021AD4 File Offset: 0x0001FCD4
		public bool IsLaterVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			if (version == null || this.MajorVersion != version.MajorVersion)
			{
				return false;
			}
			int diffMinorVersion = this.MinorVersion - version.MinorVersion;
			if (!this.IsDtls)
			{
				return diffMinorVersion > 0;
			}
			return diffMinorVersion < 0;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00021B13 File Offset: 0x0001FD13
		public override bool Equals(object other)
		{
			return this == other || (other is global::Org.BouncyCastle.Tls.ProtocolVersion && this.Equals((global::Org.BouncyCastle.Tls.ProtocolVersion)other));
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00021B31 File Offset: 0x0001FD31
		public bool Equals(global::Org.BouncyCastle.Tls.ProtocolVersion other)
		{
			return other != null && this.version == other.version;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00021B46 File Offset: 0x0001FD46
		public override int GetHashCode()
		{
			return this.version;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00021B50 File Offset: 0x0001FD50
		public static global::Org.BouncyCastle.Tls.ProtocolVersion Get(int major, int minor)
		{
			if (major != 3)
			{
				if (major != 254)
				{
					return global::Org.BouncyCastle.Tls.ProtocolVersion.GetUnknownVersion(major, minor, "UNKNOWN");
				}
				switch (minor)
				{
				case 253:
					return global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12;
				case 254:
					throw new global::System.ArgumentException("{0xFE, 0xFE} is a reserved protocol version");
				case 255:
					return global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10;
				default:
					return global::Org.BouncyCastle.Tls.ProtocolVersion.GetUnknownVersion(major, minor, "DTLS");
				}
			}
			else
			{
				switch (minor)
				{
				case 0:
					return global::Org.BouncyCastle.Tls.ProtocolVersion.SSLv3;
				case 1:
					return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10;
				case 2:
					return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv11;
				case 3:
					return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12;
				case 4:
					return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13;
				default:
					return global::Org.BouncyCastle.Tls.ProtocolVersion.GetUnknownVersion(major, minor, "TLS");
				}
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00021BFF File Offset: 0x0001FDFF
		public global::Org.BouncyCastle.Tls.ProtocolVersion[] Only()
		{
			return new global::Org.BouncyCastle.Tls.ProtocolVersion[]
			{
				this
			};
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00021C0B File Offset: 0x0001FE0B
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00021C13 File Offset: 0x0001FE13
		private static void CheckUint8(int versionOctet)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint8(versionOctet))
			{
				throw new global::System.ArgumentException("not a valid octet", "versionOctet");
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00021C30 File Offset: 0x0001FE30
		private static global::Org.BouncyCastle.Tls.ProtocolVersion GetUnknownVersion(int major, int minor, string prefix)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion.CheckUint8(major);
			global::Org.BouncyCastle.Tls.ProtocolVersion.CheckUint8(minor);
			int v = major << 8 | minor;
			string hex = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(global::System.Convert.ToString(65536 | v, 16).Substring(1));
			return new global::Org.BouncyCastle.Tls.ProtocolVersion(v, prefix + " 0x" + hex);
		}

		// Token: 0x04000616 RID: 1558
		public static readonly global::Org.BouncyCastle.Tls.ProtocolVersion SSLv3 = new global::Org.BouncyCastle.Tls.ProtocolVersion(768, "SSL 3.0");

		// Token: 0x04000617 RID: 1559
		public static readonly global::Org.BouncyCastle.Tls.ProtocolVersion TLSv10 = new global::Org.BouncyCastle.Tls.ProtocolVersion(769, "TLS 1.0");

		// Token: 0x04000618 RID: 1560
		public static readonly global::Org.BouncyCastle.Tls.ProtocolVersion TLSv11 = new global::Org.BouncyCastle.Tls.ProtocolVersion(770, "TLS 1.1");

		// Token: 0x04000619 RID: 1561
		public static readonly global::Org.BouncyCastle.Tls.ProtocolVersion TLSv12 = new global::Org.BouncyCastle.Tls.ProtocolVersion(771, "TLS 1.2");

		// Token: 0x0400061A RID: 1562
		public static readonly global::Org.BouncyCastle.Tls.ProtocolVersion TLSv13 = new global::Org.BouncyCastle.Tls.ProtocolVersion(772, "TLS 1.3");

		// Token: 0x0400061B RID: 1563
		public static readonly global::Org.BouncyCastle.Tls.ProtocolVersion DTLSv10 = new global::Org.BouncyCastle.Tls.ProtocolVersion(65279, "DTLS 1.0");

		// Token: 0x0400061C RID: 1564
		public static readonly global::Org.BouncyCastle.Tls.ProtocolVersion DTLSv12 = new global::Org.BouncyCastle.Tls.ProtocolVersion(65277, "DTLS 1.2");

		// Token: 0x0400061D RID: 1565
		internal static readonly global::Org.BouncyCastle.Tls.ProtocolVersion CLIENT_EARLIEST_SUPPORTED_DTLS = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10;

		// Token: 0x0400061E RID: 1566
		internal static readonly global::Org.BouncyCastle.Tls.ProtocolVersion CLIENT_EARLIEST_SUPPORTED_TLS = global::Org.BouncyCastle.Tls.ProtocolVersion.SSLv3;

		// Token: 0x0400061F RID: 1567
		internal static readonly global::Org.BouncyCastle.Tls.ProtocolVersion CLIENT_LATEST_SUPPORTED_DTLS = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12;

		// Token: 0x04000620 RID: 1568
		internal static readonly global::Org.BouncyCastle.Tls.ProtocolVersion CLIENT_LATEST_SUPPORTED_TLS = global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13;

		// Token: 0x04000621 RID: 1569
		internal static readonly global::Org.BouncyCastle.Tls.ProtocolVersion SERVER_EARLIEST_SUPPORTED_DTLS = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10;

		// Token: 0x04000622 RID: 1570
		internal static readonly global::Org.BouncyCastle.Tls.ProtocolVersion SERVER_EARLIEST_SUPPORTED_TLS = global::Org.BouncyCastle.Tls.ProtocolVersion.SSLv3;

		// Token: 0x04000623 RID: 1571
		internal static readonly global::Org.BouncyCastle.Tls.ProtocolVersion SERVER_LATEST_SUPPORTED_DTLS = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12;

		// Token: 0x04000624 RID: 1572
		internal static readonly global::Org.BouncyCastle.Tls.ProtocolVersion SERVER_LATEST_SUPPORTED_TLS = global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13;

		// Token: 0x04000625 RID: 1573
		private readonly int version;

		// Token: 0x04000626 RID: 1574
		private readonly string name;
	}
}
