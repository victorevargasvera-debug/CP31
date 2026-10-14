using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004E5 RID: 1253
	public class SkeinDigest : global::Org.BouncyCastle.Crypto.IDigest, global::Org.BouncyCastle.Utilities.IMemoable
	{
		// Token: 0x0600313C RID: 12604 RVA: 0x000EC463 File Offset: 0x000EA663
		public SkeinDigest(int stateSizeBits, int digestSizeBits)
		{
			this.engine = new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine(stateSizeBits, digestSizeBits);
			this.Init(null);
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x000EC47F File Offset: 0x000EA67F
		public SkeinDigest(global::Org.BouncyCastle.Crypto.Digests.SkeinDigest digest)
		{
			this.engine = new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine(digest.engine);
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x000EC498 File Offset: 0x000EA698
		public void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.SkeinDigest d = (global::Org.BouncyCastle.Crypto.Digests.SkeinDigest)other;
			this.engine.Reset(d.engine);
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x000EC4BD File Offset: 0x000EA6BD
		public global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.SkeinDigest(this);
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x000EC4C8 File Offset: 0x000EA6C8
		public string AlgorithmName
		{
			get
			{
				return "Skein-" + (this.engine.BlockSize * 8).ToString() + "-" + (this.engine.OutputSize * 8).ToString();
			}
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x000EC50E File Offset: 0x000EA70E
		public int GetDigestSize()
		{
			return this.engine.OutputSize;
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x000EC51B File Offset: 0x000EA71B
		public int GetByteLength()
		{
			return this.engine.BlockSize;
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x000EC528 File Offset: 0x000EA728
		public void Init(global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters parameters)
		{
			this.engine.Init(parameters);
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x000EC536 File Offset: 0x000EA736
		public void Reset()
		{
			this.engine.Reset();
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x000EC543 File Offset: 0x000EA743
		public void Update(byte inByte)
		{
			this.engine.Update(inByte);
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x000EC551 File Offset: 0x000EA751
		public void BlockUpdate(byte[] inBytes, int inOff, int len)
		{
			this.engine.Update(inBytes, inOff, len);
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x000EC561 File Offset: 0x000EA761
		public int DoFinal(byte[] outBytes, int outOff)
		{
			return this.engine.DoFinal(outBytes, outOff);
		}

		// Token: 0x0400156B RID: 5483
		public const int SKEIN_256 = 256;

		// Token: 0x0400156C RID: 5484
		public const int SKEIN_512 = 512;

		// Token: 0x0400156D RID: 5485
		public const int SKEIN_1024 = 1024;

		// Token: 0x0400156E RID: 5486
		private readonly global::Org.BouncyCastle.Crypto.Digests.SkeinEngine engine;
	}
}
