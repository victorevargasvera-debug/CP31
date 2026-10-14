using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E7 RID: 231
	public sealed class ServerHello
	{
		// Token: 0x06000874 RID: 2164 RVA: 0x00022996 File Offset: 0x00020B96
		public ServerHello(byte[] sessionID, int cipherSuite, global::System.Collections.IDictionary extensions) : this(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12, global::Org.BouncyCastle.Utilities.Arrays.Clone(global::Org.BouncyCastle.Tls.ServerHello.HelloRetryRequestMagic), sessionID, cipherSuite, extensions)
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000229B0 File Offset: 0x00020BB0
		public ServerHello(global::Org.BouncyCastle.Tls.ProtocolVersion version, byte[] random, byte[] sessionID, int cipherSuite, global::System.Collections.IDictionary extensions)
		{
			this.m_version = version;
			this.m_random = random;
			this.m_sessionID = sessionID;
			this.m_cipherSuite = cipherSuite;
			this.m_extensions = extensions;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x000229DD File Offset: 0x00020BDD
		public int CipherSuite
		{
			get
			{
				return this.m_cipherSuite;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000229E5 File Offset: 0x00020BE5
		public global::System.Collections.IDictionary Extensions
		{
			get
			{
				return this.m_extensions;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000229ED File Offset: 0x00020BED
		public byte[] Random
		{
			get
			{
				return this.m_random;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x000229F5 File Offset: 0x00020BF5
		public byte[] SessionID
		{
			get
			{
				return this.m_sessionID;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x000229FD File Offset: 0x00020BFD
		public global::Org.BouncyCastle.Tls.ProtocolVersion Version
		{
			get
			{
				return this.m_version;
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00022A05 File Offset: 0x00020C05
		public bool IsHelloRetryRequest()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.AreEqual(global::Org.BouncyCastle.Tls.ServerHello.HelloRetryRequestMagic, this.m_random);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00022A18 File Offset: 0x00020C18
		public void Encode(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(this.m_version, output);
			output.Write(this.m_random, 0, this.m_random.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_sessionID, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(this.m_cipherSuite, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(0, output);
			global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensions(output, this.m_extensions);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00022A74 File Offset: 0x00020C74
		public static global::Org.BouncyCastle.Tls.ServerHello Parse(global::System.IO.MemoryStream input)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion version = global::Org.BouncyCastle.Tls.TlsUtilities.ReadVersion(input);
			byte[] random = global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(32, input);
			byte[] sessionID = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input, 0, 32);
			int cipherSuite = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			short compressionMethod = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			if (compressionMethod != 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Tls.TlsProtocol.ReadExtensions(input);
			return new global::Org.BouncyCastle.Tls.ServerHello(version, random, sessionID, cipherSuite, extensions);
		}

		// Token: 0x04000672 RID: 1650
		private static readonly byte[] HelloRetryRequestMagic = new byte[]
		{
			207,
			33,
			173,
			116,
			229,
			154,
			97,
			17,
			190,
			29,
			140,
			2,
			30,
			101,
			184,
			145,
			194,
			162,
			17,
			22,
			122,
			187,
			140,
			94,
			7,
			158,
			9,
			226,
			200,
			168,
			51,
			156
		};

		// Token: 0x04000673 RID: 1651
		private readonly global::Org.BouncyCastle.Tls.ProtocolVersion m_version;

		// Token: 0x04000674 RID: 1652
		private readonly byte[] m_random;

		// Token: 0x04000675 RID: 1653
		private readonly byte[] m_sessionID;

		// Token: 0x04000676 RID: 1654
		private readonly int m_cipherSuite;

		// Token: 0x04000677 RID: 1655
		private readonly global::System.Collections.IDictionary m_extensions;
	}
}
