using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000311 RID: 785
	internal class CombinedHash : global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash, global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x0600212B RID: 8491 RVA: 0x00092F95 File Offset: 0x00091195
		internal CombinedHash()
		{
			this.mMd5 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(1);
			this.mSha1 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(2);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00092FB5 File Offset: 0x000911B5
		internal CombinedHash(global::Org.BouncyCastle.Crypto.Tls.CombinedHash t)
		{
			this.mContext = t.mContext;
			this.mMd5 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(1, t.mMd5);
			this.mSha1 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(2, t.mSha1);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00092FED File Offset: 0x000911ED
		public virtual void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			this.mContext = context;
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00092FF6 File Offset: 0x000911F6
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash NotifyPrfDetermined()
		{
			return this;
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00092FF9 File Offset: 0x000911F9
		public virtual void TrackHashAlgorithm(byte hashAlgorithm)
		{
			throw new global::System.InvalidOperationException("CombinedHash only supports calculating the legacy PRF for handshake hash");
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00093005 File Offset: 0x00091205
		public virtual void SealHashAlgorithms()
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00093007 File Offset: 0x00091207
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash StopTracking()
		{
			return new global::Org.BouncyCastle.Crypto.Tls.CombinedHash(this);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0009300F File Offset: 0x0009120F
		public virtual global::Org.BouncyCastle.Crypto.IDigest ForkPrfHash()
		{
			return new global::Org.BouncyCastle.Crypto.Tls.CombinedHash(this);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00093017 File Offset: 0x00091217
		public virtual byte[] GetFinalHash(byte hashAlgorithm)
		{
			throw new global::System.InvalidOperationException("CombinedHash doesn't support multiple hashes");
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x00093023 File Offset: 0x00091223
		public virtual string AlgorithmName
		{
			get
			{
				return this.mMd5.AlgorithmName + " and " + this.mSha1.AlgorithmName;
			}
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00093045 File Offset: 0x00091245
		public virtual int GetByteLength()
		{
			return global::System.Math.Max(this.mMd5.GetByteLength(), this.mSha1.GetByteLength());
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00093062 File Offset: 0x00091262
		public virtual int GetDigestSize()
		{
			return this.mMd5.GetDigestSize() + this.mSha1.GetDigestSize();
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0009307B File Offset: 0x0009127B
		public virtual void Update(byte input)
		{
			this.mMd5.Update(input);
			this.mSha1.Update(input);
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00093095 File Offset: 0x00091295
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
			this.mMd5.BlockUpdate(input, inOff, len);
			this.mSha1.BlockUpdate(input, inOff, len);
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x000930B4 File Offset: 0x000912B4
		public virtual int DoFinal(byte[] output, int outOff)
		{
			if (this.mContext != null && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.mContext))
			{
				this.Ssl3Complete(this.mMd5, global::Org.BouncyCastle.Crypto.Tls.Ssl3Mac.IPAD, global::Org.BouncyCastle.Crypto.Tls.Ssl3Mac.OPAD, 48);
				this.Ssl3Complete(this.mSha1, global::Org.BouncyCastle.Crypto.Tls.Ssl3Mac.IPAD, global::Org.BouncyCastle.Crypto.Tls.Ssl3Mac.OPAD, 40);
			}
			int i = this.mMd5.DoFinal(output, outOff);
			int i2 = this.mSha1.DoFinal(output, outOff + i);
			return i + i2;
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00093127 File Offset: 0x00091327
		public virtual void Reset()
		{
			this.mMd5.Reset();
			this.mSha1.Reset();
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00093140 File Offset: 0x00091340
		protected virtual void Ssl3Complete(global::Org.BouncyCastle.Crypto.IDigest d, byte[] ipad, byte[] opad, int padLength)
		{
			byte[] master_secret = this.mContext.SecurityParameters.masterSecret;
			d.BlockUpdate(master_secret, 0, master_secret.Length);
			d.BlockUpdate(ipad, 0, padLength);
			byte[] tmp = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(d);
			d.BlockUpdate(master_secret, 0, master_secret.Length);
			d.BlockUpdate(opad, 0, padLength);
			d.BlockUpdate(tmp, 0, tmp.Length);
		}

		// Token: 0x04000CBF RID: 3263
		protected global::Org.BouncyCastle.Crypto.Tls.TlsContext mContext;

		// Token: 0x04000CC0 RID: 3264
		protected global::Org.BouncyCastle.Crypto.IDigest mMd5;

		// Token: 0x04000CC1 RID: 3265
		protected global::Org.BouncyCastle.Crypto.IDigest mSha1;
	}
}
