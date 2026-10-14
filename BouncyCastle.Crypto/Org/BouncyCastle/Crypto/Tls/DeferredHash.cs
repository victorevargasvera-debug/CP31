using System;
using System.Collections;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200031E RID: 798
	internal class DeferredHash : global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash, global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x00093E8B File Offset: 0x0009208B
		internal DeferredHash()
		{
			this.mBuf = new global::Org.BouncyCastle.Crypto.Tls.DigestInputBuffer();
			this.mHashes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			this.mPrfHashAlgorithm = -1;
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00093EB0 File Offset: 0x000920B0
		private DeferredHash(byte prfHashAlgorithm, global::Org.BouncyCastle.Crypto.IDigest prfHash)
		{
			this.mBuf = null;
			this.mHashes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			this.mPrfHashAlgorithm = (int)prfHashAlgorithm;
			this.mHashes[prfHashAlgorithm] = prfHash;
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00093EE3 File Offset: 0x000920E3
		public virtual void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			this.mContext = context;
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00093EEC File Offset: 0x000920EC
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash NotifyPrfDetermined()
		{
			int prfAlgorithm = this.mContext.SecurityParameters.PrfAlgorithm;
			if (prfAlgorithm == 0)
			{
				global::Org.BouncyCastle.Crypto.Tls.CombinedHash legacyHash = new global::Org.BouncyCastle.Crypto.Tls.CombinedHash();
				legacyHash.Init(this.mContext);
				this.mBuf.UpdateDigest(legacyHash);
				return legacyHash.NotifyPrfDetermined();
			}
			this.mPrfHashAlgorithm = (int)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetHashAlgorithmForPrfAlgorithm(prfAlgorithm);
			this.CheckTrackingHash((byte)this.mPrfHashAlgorithm);
			return this;
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00093F4C File Offset: 0x0009214C
		public virtual void TrackHashAlgorithm(byte hashAlgorithm)
		{
			if (this.mBuf == null)
			{
				throw new global::System.InvalidOperationException("Too late to track more hash algorithms");
			}
			this.CheckTrackingHash(hashAlgorithm);
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00093F68 File Offset: 0x00092168
		public virtual void SealHashAlgorithms()
		{
			this.CheckStopBuffering();
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00093F70 File Offset: 0x00092170
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash StopTracking()
		{
			byte prfHashAlgorithm = (byte)this.mPrfHashAlgorithm;
			global::Org.BouncyCastle.Crypto.IDigest prfHash = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(prfHashAlgorithm, (global::Org.BouncyCastle.Crypto.IDigest)this.mHashes[prfHashAlgorithm]);
			if (this.mBuf != null)
			{
				this.mBuf.UpdateDigest(prfHash);
			}
			global::Org.BouncyCastle.Crypto.Tls.DeferredHash deferredHash = new global::Org.BouncyCastle.Crypto.Tls.DeferredHash(prfHashAlgorithm, prfHash);
			deferredHash.Init(this.mContext);
			return deferredHash;
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00093FCC File Offset: 0x000921CC
		public virtual global::Org.BouncyCastle.Crypto.IDigest ForkPrfHash()
		{
			this.CheckStopBuffering();
			byte prfHashAlgorithm = (byte)this.mPrfHashAlgorithm;
			if (this.mBuf != null)
			{
				global::Org.BouncyCastle.Crypto.IDigest prfHash = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(prfHashAlgorithm);
				this.mBuf.UpdateDigest(prfHash);
				return prfHash;
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(prfHashAlgorithm, (global::Org.BouncyCastle.Crypto.IDigest)this.mHashes[prfHashAlgorithm]);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00094020 File Offset: 0x00092220
		public virtual byte[] GetFinalHash(byte hashAlgorithm)
		{
			global::Org.BouncyCastle.Crypto.IDigest d = (global::Org.BouncyCastle.Crypto.IDigest)this.mHashes[hashAlgorithm];
			if (d == null)
			{
				throw new global::System.InvalidOperationException("HashAlgorithm." + global::Org.BouncyCastle.Crypto.Tls.HashAlgorithm.GetText(hashAlgorithm) + " is not being tracked");
			}
			d = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(hashAlgorithm, d);
			if (this.mBuf != null)
			{
				this.mBuf.UpdateDigest(d);
			}
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(d);
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x00094084 File Offset: 0x00092284
		public virtual string AlgorithmName
		{
			get
			{
				throw new global::System.InvalidOperationException("Use Fork() to get a definite IDigest");
			}
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00094090 File Offset: 0x00092290
		public virtual int GetByteLength()
		{
			throw new global::System.InvalidOperationException("Use Fork() to get a definite IDigest");
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x0009409C File Offset: 0x0009229C
		public virtual int GetDigestSize()
		{
			throw new global::System.InvalidOperationException("Use Fork() to get a definite IDigest");
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x000940A8 File Offset: 0x000922A8
		public virtual void Update(byte input)
		{
			if (this.mBuf != null)
			{
				this.mBuf.WriteByte(input);
				return;
			}
			foreach (object obj in this.mHashes.Values)
			{
				((global::Org.BouncyCastle.Crypto.IDigest)obj).Update(input);
			}
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0009411C File Offset: 0x0009231C
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
			if (this.mBuf != null)
			{
				this.mBuf.Write(input, inOff, len);
				return;
			}
			foreach (object obj in this.mHashes.Values)
			{
				((global::Org.BouncyCastle.Crypto.IDigest)obj).BlockUpdate(input, inOff, len);
			}
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00094194 File Offset: 0x00092394
		public virtual int DoFinal(byte[] output, int outOff)
		{
			throw new global::System.InvalidOperationException("Use Fork() to get a definite IDigest");
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000941A0 File Offset: 0x000923A0
		public virtual void Reset()
		{
			if (this.mBuf != null)
			{
				this.mBuf.SetLength(0L);
				return;
			}
			foreach (object obj in this.mHashes.Values)
			{
				((global::Org.BouncyCastle.Crypto.IDigest)obj).Reset();
			}
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00094214 File Offset: 0x00092414
		protected virtual void CheckStopBuffering()
		{
			if (this.mBuf != null && this.mHashes.Count <= 4)
			{
				foreach (object obj in this.mHashes.Values)
				{
					global::Org.BouncyCastle.Crypto.IDigest hash = (global::Org.BouncyCastle.Crypto.IDigest)obj;
					this.mBuf.UpdateDigest(hash);
				}
				this.mBuf = null;
			}
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00094294 File Offset: 0x00092494
		protected virtual void CheckTrackingHash(byte hashAlgorithm)
		{
			if (!this.mHashes.Contains(hashAlgorithm))
			{
				global::Org.BouncyCastle.Crypto.IDigest hash = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm);
				this.mHashes[hashAlgorithm] = hash;
			}
		}

		// Token: 0x04000CDE RID: 3294
		protected const int BUFFERING_HASH_LIMIT = 4;

		// Token: 0x04000CDF RID: 3295
		protected global::Org.BouncyCastle.Crypto.Tls.TlsContext mContext;

		// Token: 0x04000CE0 RID: 3296
		private global::Org.BouncyCastle.Crypto.Tls.DigestInputBuffer mBuf;

		// Token: 0x04000CE1 RID: 3297
		private global::System.Collections.IDictionary mHashes;

		// Token: 0x04000CE2 RID: 3298
		private int mPrfHashAlgorithm;
	}
}
