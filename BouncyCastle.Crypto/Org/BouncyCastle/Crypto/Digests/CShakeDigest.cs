using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004C9 RID: 1225
	public class CShakeDigest : global::Org.BouncyCastle.Crypto.Digests.ShakeDigest
	{
		// Token: 0x06002F91 RID: 12177 RVA: 0x000DDED1 File Offset: 0x000DC0D1
		private static byte[] EncodeString(byte[] str)
		{
			if (global::Org.BouncyCastle.Utilities.Arrays.IsNullOrEmpty(str))
			{
				return global::Org.BouncyCastle.Crypto.Digests.XofUtilities.LeftEncode(0L);
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(global::Org.BouncyCastle.Crypto.Digests.XofUtilities.LeftEncode((long)str.Length * 8L), str);
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x000DDEF8 File Offset: 0x000DC0F8
		public CShakeDigest(int bitLength, byte[] N, byte[] S) : base(bitLength)
		{
			if ((N == null || N.Length == 0) && (S == null || S.Length == 0))
			{
				this.diff = null;
				return;
			}
			this.diff = global::Org.BouncyCastle.Utilities.Arrays.ConcatenateAll(new byte[][]
			{
				global::Org.BouncyCastle.Crypto.Digests.XofUtilities.LeftEncode((long)(this.rate / 8)),
				global::Org.BouncyCastle.Crypto.Digests.CShakeDigest.EncodeString(N),
				global::Org.BouncyCastle.Crypto.Digests.CShakeDigest.EncodeString(S)
			});
			this.DiffPadAndAbsorb();
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x000DDF5C File Offset: 0x000DC15C
		public CShakeDigest(global::Org.BouncyCastle.Crypto.Digests.CShakeDigest source) : base(source)
		{
			this.diff = global::Org.BouncyCastle.Utilities.Arrays.Clone(source.diff);
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x000DDF78 File Offset: 0x000DC178
		private void DiffPadAndAbsorb()
		{
			int blockSize = this.rate / 8;
			base.Absorb(this.diff, 0, this.diff.Length);
			int delta = this.diff.Length % blockSize;
			if (delta != 0)
			{
				int required;
				for (required = blockSize - delta; required > global::Org.BouncyCastle.Crypto.Digests.CShakeDigest.padding.Length; required -= global::Org.BouncyCastle.Crypto.Digests.CShakeDigest.padding.Length)
				{
					base.Absorb(global::Org.BouncyCastle.Crypto.Digests.CShakeDigest.padding, 0, global::Org.BouncyCastle.Crypto.Digests.CShakeDigest.padding.Length);
				}
				base.Absorb(global::Org.BouncyCastle.Crypto.Digests.CShakeDigest.padding, 0, required);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x000DDFEB File Offset: 0x000DC1EB
		public override string AlgorithmName
		{
			get
			{
				return "CSHAKE" + this.fixedOutputLength.ToString();
			}
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x000DE002 File Offset: 0x000DC202
		public override int DoOutput(byte[] output, int outOff, int outLen)
		{
			if (this.diff == null)
			{
				return base.DoOutput(output, outOff, outLen);
			}
			if (!this.squeezing)
			{
				base.AbsorbBits(0, 2);
			}
			base.Squeeze(output, outOff, (long)outLen << 3);
			return outLen;
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x000DE033 File Offset: 0x000DC233
		public override void Reset()
		{
			base.Reset();
			if (this.diff != null)
			{
				this.DiffPadAndAbsorb();
			}
		}

		// Token: 0x04001481 RID: 5249
		private static readonly byte[] padding = new byte[100];

		// Token: 0x04001482 RID: 5250
		private readonly byte[] diff;
	}
}
