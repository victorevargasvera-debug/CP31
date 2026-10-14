using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B4 RID: 180
	internal sealed class DeferredHash : global::Org.BouncyCastle.Tls.TlsHandshakeHash, global::Org.BouncyCastle.Tls.Crypto.TlsHash
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x0001B895 File Offset: 0x00019A95
		internal DeferredHash(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			this.m_context = context;
			this.m_buf = new global::Org.BouncyCastle.Tls.DigestInputBuffer();
			this.m_hashes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			this.m_forceBuffering = false;
			this.m_sealed = false;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001B8C8 File Offset: 0x00019AC8
		private DeferredHash(global::Org.BouncyCastle.Tls.TlsContext context, global::System.Collections.IDictionary hashes)
		{
			this.m_context = context;
			this.m_buf = null;
			this.m_hashes = hashes;
			this.m_forceBuffering = false;
			this.m_sealed = true;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0001B8F3 File Offset: 0x00019AF3
		public void CopyBufferTo(global::System.IO.Stream output)
		{
			if (this.m_buf == null)
			{
				throw new global::System.InvalidOperationException("Not buffering");
			}
			this.m_buf.CopyTo(output);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001B914 File Offset: 0x00019B14
		public void ForceBuffering()
		{
			if (this.m_sealed)
			{
				throw new global::System.InvalidOperationException("Too late to force buffering");
			}
			this.m_forceBuffering = true;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001B930 File Offset: 0x00019B30
		public void NotifyPrfDetermined()
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_context.SecurityParameters;
			int prfAlgorithm = securityParameters.PrfAlgorithm;
			if (prfAlgorithm <= 1)
			{
				this.CheckTrackingHash(1);
				this.CheckTrackingHash(2);
				return;
			}
			this.CheckTrackingHash(securityParameters.PrfCryptoHashAlgorithm);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001B96F File Offset: 0x00019B6F
		public void TrackHashAlgorithm(int cryptoHashAlgorithm)
		{
			if (this.m_sealed)
			{
				throw new global::System.InvalidOperationException("Too late to track more hash algorithms");
			}
			this.CheckTrackingHash(cryptoHashAlgorithm);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001B98B File Offset: 0x00019B8B
		public void SealHashAlgorithms()
		{
			if (this.m_sealed)
			{
				throw new global::System.InvalidOperationException("Already sealed");
			}
			this.m_sealed = true;
			this.CheckStopBuffering();
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0001B9B0 File Offset: 0x00019BB0
		public global::Org.BouncyCastle.Tls.TlsHandshakeHash StopTracking()
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_context.SecurityParameters;
			global::System.Collections.IDictionary newHashes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			int prfAlgorithm = securityParameters.PrfAlgorithm;
			if (prfAlgorithm <= 1)
			{
				this.CloneHash(newHashes, 1);
				this.CloneHash(newHashes, 2);
			}
			else
			{
				this.CloneHash(newHashes, securityParameters.PrfCryptoHashAlgorithm);
			}
			return new global::Org.BouncyCastle.Tls.DeferredHash(this.m_context, newHashes);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001BA08 File Offset: 0x00019C08
		public global::Org.BouncyCastle.Tls.Crypto.TlsHash ForkPrfHash()
		{
			this.CheckStopBuffering();
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_context.SecurityParameters;
			int prfAlgorithm = securityParameters.PrfAlgorithm;
			global::Org.BouncyCastle.Tls.Crypto.TlsHash prfHash;
			if (prfAlgorithm <= 1)
			{
				prfHash = new global::Org.BouncyCastle.Tls.CombinedHash(this.m_context, this.CloneHash(1), this.CloneHash(2));
			}
			else
			{
				prfHash = this.CloneHash(securityParameters.PrfCryptoHashAlgorithm);
			}
			if (this.m_buf != null)
			{
				this.m_buf.UpdateDigest(prfHash);
			}
			return prfHash;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0001BA70 File Offset: 0x00019C70
		public byte[] GetFinalHash(int cryptoHashAlgorithm)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsHash d = (global::Org.BouncyCastle.Tls.Crypto.TlsHash)this.m_hashes[cryptoHashAlgorithm];
			if (d == null)
			{
				throw new global::System.InvalidOperationException("CryptoHashAlgorithm." + cryptoHashAlgorithm.ToString() + " is not being tracked");
			}
			this.CheckStopBuffering();
			d = d.CloneHash();
			if (this.m_buf != null)
			{
				this.m_buf.UpdateDigest(d);
			}
			return d.CalculateHash();
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0001BADC File Offset: 0x00019CDC
		public void Update(byte[] input, int inOff, int len)
		{
			if (this.m_buf != null)
			{
				this.m_buf.Write(input, inOff, len);
				return;
			}
			foreach (object obj in this.m_hashes.Values)
			{
				((global::Org.BouncyCastle.Tls.Crypto.TlsHash)obj).Update(input, inOff, len);
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0001BB54 File Offset: 0x00019D54
		public byte[] CalculateHash()
		{
			throw new global::System.InvalidOperationException("Use 'ForkPrfHash' to get a definite hash");
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0001BB60 File Offset: 0x00019D60
		public global::Org.BouncyCastle.Tls.Crypto.TlsHash CloneHash()
		{
			throw new global::System.InvalidOperationException("attempt to clone a DeferredHash");
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001BB6C File Offset: 0x00019D6C
		public void Reset()
		{
			if (this.m_buf != null)
			{
				this.m_buf.SetLength(0L);
				return;
			}
			foreach (object obj in this.m_hashes.Values)
			{
				((global::Org.BouncyCastle.Tls.Crypto.TlsHash)obj).Reset();
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001BBE0 File Offset: 0x00019DE0
		private void CheckStopBuffering()
		{
			if (!this.m_forceBuffering && this.m_sealed && this.m_buf != null && this.m_hashes.Count <= 4)
			{
				foreach (object obj in this.m_hashes.Values)
				{
					global::Org.BouncyCastle.Tls.Crypto.TlsHash hash = (global::Org.BouncyCastle.Tls.Crypto.TlsHash)obj;
					this.m_buf.UpdateDigest(hash);
				}
				this.m_buf = null;
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001BC70 File Offset: 0x00019E70
		private void CheckTrackingHash(int cryptoHashAlgorithm)
		{
			if (!this.m_hashes.Contains(cryptoHashAlgorithm))
			{
				global::Org.BouncyCastle.Tls.Crypto.TlsHash hash = this.m_context.Crypto.CreateHash(cryptoHashAlgorithm);
				this.m_hashes[cryptoHashAlgorithm] = hash;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001BCB4 File Offset: 0x00019EB4
		private global::Org.BouncyCastle.Tls.Crypto.TlsHash CloneHash(int cryptoHashAlgorithm)
		{
			return ((global::Org.BouncyCastle.Tls.Crypto.TlsHash)this.m_hashes[cryptoHashAlgorithm]).CloneHash();
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001BCD4 File Offset: 0x00019ED4
		private void CloneHash(global::System.Collections.IDictionary newHashes, int cryptoHashAlgorithm)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsHash hash = this.CloneHash(cryptoHashAlgorithm);
			if (this.m_buf != null)
			{
				this.m_buf.UpdateDigest(hash);
			}
			newHashes[cryptoHashAlgorithm] = hash;
		}

		// Token: 0x040004D4 RID: 1236
		private const int BufferingHashLimit = 4;

		// Token: 0x040004D5 RID: 1237
		private readonly global::Org.BouncyCastle.Tls.TlsContext m_context;

		// Token: 0x040004D6 RID: 1238
		private global::Org.BouncyCastle.Tls.DigestInputBuffer m_buf;

		// Token: 0x040004D7 RID: 1239
		private readonly global::System.Collections.IDictionary m_hashes;

		// Token: 0x040004D8 RID: 1240
		private bool m_forceBuffering;

		// Token: 0x040004D9 RID: 1241
		private bool m_sealed;
	}
}
