using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000131 RID: 305
	public sealed class UrlAndHash
	{
		// Token: 0x06000CC4 RID: 3268 RVA: 0x00031ACC File Offset: 0x0002FCCC
		public UrlAndHash(string url, byte[] sha1Hash)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(url) || url.Length >= 65536)
			{
				throw new global::System.ArgumentException("must have length from 1 to (2^16 - 1)", "url");
			}
			if (sha1Hash != null && sha1Hash.Length != 20)
			{
				throw new global::System.ArgumentException("must have length == 20, if present", "sha1Hash");
			}
			this.m_url = url;
			this.m_sha1Hash = sha1Hash;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00031B2C File Offset: 0x0002FD2C
		public string Url
		{
			get
			{
				return this.m_url;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00031B34 File Offset: 0x0002FD34
		public byte[] Sha1Hash
		{
			get
			{
				return this.m_sha1Hash;
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00031B3C File Offset: 0x0002FD3C
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(global::Org.BouncyCastle.Utilities.Strings.ToByteArray(this.m_url), output);
			if (this.m_sha1Hash == null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(0, output);
				return;
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(1, output);
			output.Write(this.m_sha1Hash, 0, this.m_sha1Hash.Length);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00031B7C File Offset: 0x0002FD7C
		public static global::Org.BouncyCastle.Tls.UrlAndHash Parse(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream input)
		{
			string url = global::Org.BouncyCastle.Utilities.Strings.FromByteArray(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1));
			byte[] sha1Hash = null;
			short padding = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			if (padding != 0)
			{
				if (padding != 1)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				sha1Hash = global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(20, input);
			}
			else if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(context))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return new global::Org.BouncyCastle.Tls.UrlAndHash(url, sha1Hash);
		}

		// Token: 0x04000761 RID: 1889
		private readonly string m_url;

		// Token: 0x04000762 RID: 1890
		private readonly byte[] m_sha1Hash;
	}
}
