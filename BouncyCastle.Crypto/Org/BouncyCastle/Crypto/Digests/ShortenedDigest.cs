using System;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004E4 RID: 1252
	public class ShortenedDigest : global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06003134 RID: 12596 RVA: 0x000EC36D File Offset: 0x000EA56D
		public ShortenedDigest(global::Org.BouncyCastle.Crypto.IDigest baseDigest, int length)
		{
			if (baseDigest == null)
			{
				throw new global::System.ArgumentNullException("baseDigest");
			}
			if (length > baseDigest.GetDigestSize())
			{
				throw new global::System.ArgumentException("baseDigest output not large enough to support length");
			}
			this.baseDigest = baseDigest;
			this.length = length;
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x000EC3A8 File Offset: 0x000EA5A8
		public string AlgorithmName
		{
			get
			{
				return this.baseDigest.AlgorithmName + "(" + (this.length * 8).ToString() + ")";
			}
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x000EC3DF File Offset: 0x000EA5DF
		public int GetDigestSize()
		{
			return this.length;
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x000EC3E7 File Offset: 0x000EA5E7
		public void Update(byte input)
		{
			this.baseDigest.Update(input);
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x000EC3F5 File Offset: 0x000EA5F5
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
			this.baseDigest.BlockUpdate(input, inOff, length);
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x000EC408 File Offset: 0x000EA608
		public int DoFinal(byte[] output, int outOff)
		{
			byte[] tmp = new byte[this.baseDigest.GetDigestSize()];
			this.baseDigest.DoFinal(tmp, 0);
			global::System.Array.Copy(tmp, 0, output, outOff, this.length);
			return this.length;
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x000EC449 File Offset: 0x000EA649
		public void Reset()
		{
			this.baseDigest.Reset();
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x000EC456 File Offset: 0x000EA656
		public int GetByteLength()
		{
			return this.baseDigest.GetByteLength();
		}

		// Token: 0x04001569 RID: 5481
		private global::Org.BouncyCastle.Crypto.IDigest baseDigest;

		// Token: 0x0400156A RID: 5482
		private int length;
	}
}
