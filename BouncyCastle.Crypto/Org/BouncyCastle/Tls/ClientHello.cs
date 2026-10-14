using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000A5 RID: 165
	public sealed class ClientHello
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x0001AEB8 File Offset: 0x000190B8
		public ClientHello(global::Org.BouncyCastle.Tls.ProtocolVersion version, byte[] random, byte[] sessionID, byte[] cookie, int[] cipherSuites, global::System.Collections.IDictionary extensions, int bindersSize)
		{
			this.m_version = version;
			this.m_random = random;
			this.m_sessionID = sessionID;
			this.m_cookie = cookie;
			this.m_cipherSuites = cipherSuites;
			this.m_extensions = extensions;
			this.m_bindersSize = bindersSize;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0001AEF5 File Offset: 0x000190F5
		public int BindersSize
		{
			get
			{
				return this.m_bindersSize;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0001AEFD File Offset: 0x000190FD
		public int[] CipherSuites
		{
			get
			{
				return this.m_cipherSuites;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0001AF05 File Offset: 0x00019105
		public byte[] Cookie
		{
			get
			{
				return this.m_cookie;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0001AF0D File Offset: 0x0001910D
		public global::System.Collections.IDictionary Extensions
		{
			get
			{
				return this.m_extensions;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0001AF15 File Offset: 0x00019115
		public byte[] Random
		{
			get
			{
				return this.m_random;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0001AF1D File Offset: 0x0001911D
		public byte[] SessionID
		{
			get
			{
				return this.m_sessionID;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0001AF25 File Offset: 0x00019125
		public global::Org.BouncyCastle.Tls.ProtocolVersion Version
		{
			get
			{
				return this.m_version;
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001AF30 File Offset: 0x00019130
		public void Encode(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream output)
		{
			if (this.m_bindersSize < 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(this.m_version, output);
			output.Write(this.m_random, 0, this.m_random.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_sessionID, output);
			if (this.m_cookie != null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_cookie, output);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16ArrayWithUint16Length(this.m_cipherSuites, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(new short[1], output);
			global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensions(output, this.m_extensions, this.m_bindersSize);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001AFBC File Offset: 0x000191BC
		public static global::Org.BouncyCastle.Tls.ClientHello Parse(global::System.IO.MemoryStream messageInput, global::System.IO.Stream dtlsOutput)
		{
			global::Org.BouncyCastle.Tls.ClientHello result;
			try
			{
				result = global::Org.BouncyCastle.Tls.ClientHello.ImplParse(messageInput, dtlsOutput);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert tlsFatalAlert)
			{
				throw tlsFatalAlert;
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50, e);
			}
			return result;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001AFFC File Offset: 0x000191FC
		private static global::Org.BouncyCastle.Tls.ClientHello ImplParse(global::System.IO.MemoryStream messageInput, global::System.IO.Stream dtlsOutput)
		{
			global::System.IO.Stream input = messageInput;
			if (dtlsOutput != null)
			{
				input = new global::Org.BouncyCastle.Utilities.IO.TeeInputStream(input, dtlsOutput);
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion clientVersion = global::Org.BouncyCastle.Tls.TlsUtilities.ReadVersion(input);
			byte[] random = global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(32, input);
			byte[] sessionID = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input, 0, 32);
			byte[] cookie = null;
			if (dtlsOutput != null)
			{
				int maxCookieLength = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12.IsEqualOrEarlierVersionOf(clientVersion) ? 255 : 32;
				cookie = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(messageInput, 0, maxCookieLength);
			}
			int cipher_suites_length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			if (cipher_suites_length < 2 || (cipher_suites_length & 1) != 0 || (int)(messageInput.Length - messageInput.Position) < cipher_suites_length)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			int[] cipherSuites = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16Array(cipher_suites_length / 2, input);
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8ArrayWithUint8Length(input, 1), 0))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
			global::System.Collections.IDictionary extensions = null;
			if (messageInput.Position < messageInput.Length)
			{
				byte[] extBytes = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
				global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(messageInput);
				extensions = global::Org.BouncyCastle.Tls.TlsProtocol.ReadExtensionsDataClientHello(extBytes);
			}
			return new global::Org.BouncyCastle.Tls.ClientHello(clientVersion, random, sessionID, cookie, cipherSuites, extensions, -1);
		}

		// Token: 0x040004B1 RID: 1201
		private readonly global::Org.BouncyCastle.Tls.ProtocolVersion m_version;

		// Token: 0x040004B2 RID: 1202
		private readonly byte[] m_random;

		// Token: 0x040004B3 RID: 1203
		private readonly byte[] m_sessionID;

		// Token: 0x040004B4 RID: 1204
		private readonly byte[] m_cookie;

		// Token: 0x040004B5 RID: 1205
		private readonly int[] m_cipherSuites;

		// Token: 0x040004B6 RID: 1206
		private readonly global::System.Collections.IDictionary m_extensions;

		// Token: 0x040004B7 RID: 1207
		private readonly int m_bindersSize;
	}
}
