using System;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004D5 RID: 1237
	public class NonMemoableDigest : global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06003057 RID: 12375 RVA: 0x000E386D File Offset: 0x000E1A6D
		public NonMemoableDigest(global::Org.BouncyCastle.Crypto.IDigest baseDigest)
		{
			if (baseDigest == null)
			{
				throw new global::System.ArgumentNullException("baseDigest");
			}
			this.mBaseDigest = baseDigest;
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x000E388A File Offset: 0x000E1A8A
		public virtual string AlgorithmName
		{
			get
			{
				return this.mBaseDigest.AlgorithmName;
			}
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x000E3897 File Offset: 0x000E1A97
		public virtual int GetDigestSize()
		{
			return this.mBaseDigest.GetDigestSize();
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x000E38A4 File Offset: 0x000E1AA4
		public virtual void Update(byte input)
		{
			this.mBaseDigest.Update(input);
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x000E38B2 File Offset: 0x000E1AB2
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
			this.mBaseDigest.BlockUpdate(input, inOff, len);
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x000E38C2 File Offset: 0x000E1AC2
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return this.mBaseDigest.DoFinal(output, outOff);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x000E38D1 File Offset: 0x000E1AD1
		public virtual void Reset()
		{
			this.mBaseDigest.Reset();
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x000E38DE File Offset: 0x000E1ADE
		public virtual int GetByteLength()
		{
			return this.mBaseDigest.GetByteLength();
		}

		// Token: 0x04001505 RID: 5381
		protected readonly global::Org.BouncyCastle.Crypto.IDigest mBaseDigest;
	}
}
