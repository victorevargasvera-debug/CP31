using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000394 RID: 916
	public class UrlAndHash
	{
		// Token: 0x06002589 RID: 9609 RVA: 0x000A3154 File Offset: 0x000A1354
		public UrlAndHash(string url, byte[] sha1Hash)
		{
			if (url == null || url.Length < 1 || url.Length >= 65536)
			{
				throw new global::System.ArgumentException("must have length from 1 to (2^16 - 1)", "url");
			}
			if (sha1Hash != null && sha1Hash.Length != 20)
			{
				throw new global::System.ArgumentException("must have length == 20, if present", "sha1Hash");
			}
			this.mUrl = url;
			this.mSha1Hash = sha1Hash;
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x000A31B8 File Offset: 0x000A13B8
		public virtual string Url
		{
			get
			{
				return this.mUrl;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x000A31C0 File Offset: 0x000A13C0
		public virtual byte[] Sha1Hash
		{
			get
			{
				return this.mSha1Hash;
			}
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x000A31C8 File Offset: 0x000A13C8
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(global::Org.BouncyCastle.Utilities.Strings.ToByteArray(this.mUrl), output);
			if (this.mSha1Hash == null)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(0, output);
				return;
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(1, output);
			output.Write(this.mSha1Hash, 0, this.mSha1Hash.Length);
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x000A3208 File Offset: 0x000A1408
		public static global::Org.BouncyCastle.Crypto.Tls.UrlAndHash Parse(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::System.IO.Stream input)
		{
			byte[] array = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input);
			if (array.Length < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			string url = global::Org.BouncyCastle.Utilities.Strings.FromByteArray(array);
			byte[] sha1Hash = null;
			byte padding = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			if (padding != 0)
			{
				if (padding != 1)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				sha1Hash = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(20, input);
			}
			else if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			return new global::Org.BouncyCastle.Crypto.Tls.UrlAndHash(url, sha1Hash);
		}

		// Token: 0x04000EE4 RID: 3812
		protected readonly string mUrl;

		// Token: 0x04000EE5 RID: 3813
		protected readonly byte[] mSha1Hash;
	}
}
