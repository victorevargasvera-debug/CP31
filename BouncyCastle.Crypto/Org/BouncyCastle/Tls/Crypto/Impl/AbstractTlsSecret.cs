using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x0200015A RID: 346
	public abstract class AbstractTlsSecret : global::Org.BouncyCastle.Tls.Crypto.TlsSecret
	{
		// Token: 0x06000D86 RID: 3462 RVA: 0x0003260A File Offset: 0x0003080A
		protected static byte[] CopyData(global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsSecret other)
		{
			return other.CopyData();
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00032612 File Offset: 0x00030812
		protected AbstractTlsSecret(byte[] data)
		{
			this.m_data = data;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00032621 File Offset: 0x00030821
		protected virtual void CheckAlive()
		{
			if (this.m_data == null)
			{
				throw new global::System.InvalidOperationException("Secret has already been extracted or destroyed");
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000D89 RID: 3465
		protected abstract global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsCrypto Crypto { get; }

		// Token: 0x06000D8A RID: 3466 RVA: 0x00032638 File Offset: 0x00030838
		public virtual byte[] CalculateHmac(int cryptoHashAlgorithm, byte[] buf, int off, int len)
		{
			byte[] result;
			lock (this)
			{
				this.CheckAlive();
				global::Org.BouncyCastle.Tls.Crypto.TlsHmac tlsHmac = this.Crypto.CreateHmacForHash(cryptoHashAlgorithm);
				tlsHmac.SetKey(this.m_data, 0, this.m_data.Length);
				tlsHmac.Update(buf, off, len);
				result = tlsHmac.CalculateMac();
			}
			return result;
		}

		// Token: 0x06000D8B RID: 3467
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSecret DeriveUsingPrf(int prfAlgorithm, string label, byte[] seed, int length);

		// Token: 0x06000D8C RID: 3468 RVA: 0x000326A8 File Offset: 0x000308A8
		public virtual void Destroy()
		{
			lock (this)
			{
				if (this.m_data != null)
				{
					global::System.Array.Clear(this.m_data, 0, this.m_data.Length);
					this.m_data = null;
				}
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00032700 File Offset: 0x00030900
		public virtual byte[] Encrypt(global::Org.BouncyCastle.Tls.Crypto.TlsEncryptor encryptor)
		{
			byte[] result;
			lock (this)
			{
				this.CheckAlive();
				result = encryptor.Encrypt(this.m_data, 0, this.m_data.Length);
			}
			return result;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00032754 File Offset: 0x00030954
		public virtual byte[] Extract()
		{
			byte[] result;
			lock (this)
			{
				this.CheckAlive();
				byte[] data = this.m_data;
				this.m_data = null;
				result = data;
			}
			return result;
		}

		// Token: 0x06000D8F RID: 3471
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfExpand(int cryptoHashAlgorithm, byte[] info, int length);

		// Token: 0x06000D90 RID: 3472
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfExtract(int cryptoHashAlgorithm, global::Org.BouncyCastle.Tls.Crypto.TlsSecret ikm);

		// Token: 0x06000D91 RID: 3473 RVA: 0x000327A0 File Offset: 0x000309A0
		public virtual bool IsAlive()
		{
			bool result;
			lock (this)
			{
				result = (this.m_data != null);
			}
			return result;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000327E0 File Offset: 0x000309E0
		internal virtual byte[] CopyData()
		{
			byte[] result;
			lock (this)
			{
				result = global::Org.BouncyCastle.Utilities.Arrays.Clone(this.m_data);
			}
			return result;
		}

		// Token: 0x040007D6 RID: 2006
		protected byte[] m_data;
	}
}
