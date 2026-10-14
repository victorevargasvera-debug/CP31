using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004D7 RID: 1239
	public class ParallelHash : global::Org.BouncyCastle.Crypto.IXof, global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06003067 RID: 12391 RVA: 0x000E397E File Offset: 0x000E1B7E
		public ParallelHash(int bitLength, byte[] S, int B) : this(bitLength, S, B, bitLength * 2)
		{
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x000E398C File Offset: 0x000E1B8C
		public ParallelHash(int bitLength, byte[] S, int B, int outputSize)
		{
			this.cshake = new global::Org.BouncyCastle.Crypto.Digests.CShakeDigest(bitLength, global::Org.BouncyCastle.Crypto.Digests.ParallelHash.N_PARALLEL_HASH, S);
			this.compressor = new global::Org.BouncyCastle.Crypto.Digests.CShakeDigest(bitLength, new byte[0], new byte[0]);
			this.bitLength = bitLength;
			this.B = B;
			this.outputLength = (outputSize + 7) / 8;
			this.buffer = new byte[B];
			this.compressorBuffer = new byte[bitLength * 2 / 8];
			this.Reset();
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x000E3A08 File Offset: 0x000E1C08
		public ParallelHash(global::Org.BouncyCastle.Crypto.Digests.ParallelHash source)
		{
			this.cshake = new global::Org.BouncyCastle.Crypto.Digests.CShakeDigest(source.cshake);
			this.compressor = new global::Org.BouncyCastle.Crypto.Digests.CShakeDigest(source.compressor);
			this.bitLength = source.bitLength;
			this.B = source.B;
			this.outputLength = source.outputLength;
			this.buffer = global::Org.BouncyCastle.Utilities.Arrays.Clone(source.buffer);
			this.compressorBuffer = global::Org.BouncyCastle.Utilities.Arrays.Clone(source.compressorBuffer);
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x000E3A83 File Offset: 0x000E1C83
		public virtual string AlgorithmName
		{
			get
			{
				return "ParallelHash" + this.cshake.AlgorithmName.Substring(6);
			}
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x000E3AA0 File Offset: 0x000E1CA0
		public virtual int GetByteLength()
		{
			return this.cshake.GetByteLength();
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x000E3AAD File Offset: 0x000E1CAD
		public virtual int GetDigestSize()
		{
			return this.outputLength;
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x000E3AB8 File Offset: 0x000E1CB8
		public virtual void Update(byte b)
		{
			byte[] array = this.buffer;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = b;
			if (this.bufOff == this.buffer.Length)
			{
				this.compress();
			}
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x000E3AF4 File Offset: 0x000E1CF4
		public virtual void BlockUpdate(byte[] inBuf, int inOff, int len)
		{
			len = global::System.Math.Max(0, len);
			int i = 0;
			if (this.bufOff != 0)
			{
				while (i < len && this.bufOff != this.buffer.Length)
				{
					byte[] array = this.buffer;
					int num = this.bufOff;
					this.bufOff = num + 1;
					array[num] = inBuf[inOff + i++];
				}
				if (this.bufOff == this.buffer.Length)
				{
					this.compress();
				}
			}
			if (i < len)
			{
				while (len - i > this.B)
				{
					this.compress(inBuf, inOff + i, this.B);
					i += this.B;
				}
			}
			while (i < len)
			{
				this.Update(inBuf[inOff + i++]);
			}
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x000E3BA0 File Offset: 0x000E1DA0
		private void compress()
		{
			this.compress(this.buffer, 0, this.bufOff);
			this.bufOff = 0;
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x000E3BBC File Offset: 0x000E1DBC
		private void compress(byte[] buf, int offSet, int len)
		{
			this.compressor.BlockUpdate(buf, offSet, len);
			this.compressor.DoFinal(this.compressorBuffer, 0, this.compressorBuffer.Length);
			this.cshake.BlockUpdate(this.compressorBuffer, 0, this.compressorBuffer.Length);
			this.nCount++;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x000E3C1C File Offset: 0x000E1E1C
		private void wrapUp(int outputSize)
		{
			if (this.bufOff != 0)
			{
				this.compress();
			}
			byte[] nOut = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.RightEncode((long)this.nCount);
			byte[] encOut = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.RightEncode((long)(outputSize * 8));
			this.cshake.BlockUpdate(nOut, 0, nOut.Length);
			this.cshake.BlockUpdate(encOut, 0, encOut.Length);
			this.firstOutput = false;
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x000E3C75 File Offset: 0x000E1E75
		public virtual int DoFinal(byte[] outBuf, int outOff)
		{
			if (this.firstOutput)
			{
				this.wrapUp(this.outputLength);
			}
			int result = this.cshake.DoFinal(outBuf, outOff, this.GetDigestSize());
			this.Reset();
			return result;
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x000E3CA4 File Offset: 0x000E1EA4
		public virtual int DoFinal(byte[] outBuf, int outOff, int outLen)
		{
			if (this.firstOutput)
			{
				this.wrapUp(this.outputLength);
			}
			int result = this.cshake.DoFinal(outBuf, outOff, outLen);
			this.Reset();
			return result;
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x000E3CCE File Offset: 0x000E1ECE
		public virtual int DoOutput(byte[] outBuf, int outOff, int outLen)
		{
			if (this.firstOutput)
			{
				this.wrapUp(0);
			}
			return this.cshake.DoOutput(outBuf, outOff, outLen);
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x000E3CF0 File Offset: 0x000E1EF0
		public virtual void Reset()
		{
			this.cshake.Reset();
			global::Org.BouncyCastle.Utilities.Arrays.Clear(this.buffer);
			byte[] hdr = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.LeftEncode((long)this.B);
			this.cshake.BlockUpdate(hdr, 0, hdr.Length);
			this.nCount = 0;
			this.bufOff = 0;
			this.firstOutput = true;
		}

		// Token: 0x04001507 RID: 5383
		private static readonly byte[] N_PARALLEL_HASH = global::Org.BouncyCastle.Utilities.Strings.ToByteArray("ParallelHash");

		// Token: 0x04001508 RID: 5384
		private readonly global::Org.BouncyCastle.Crypto.Digests.CShakeDigest cshake;

		// Token: 0x04001509 RID: 5385
		private readonly global::Org.BouncyCastle.Crypto.Digests.CShakeDigest compressor;

		// Token: 0x0400150A RID: 5386
		private readonly int bitLength;

		// Token: 0x0400150B RID: 5387
		private readonly int outputLength;

		// Token: 0x0400150C RID: 5388
		private readonly int B;

		// Token: 0x0400150D RID: 5389
		private readonly byte[] buffer;

		// Token: 0x0400150E RID: 5390
		private readonly byte[] compressorBuffer;

		// Token: 0x0400150F RID: 5391
		private bool firstOutput;

		// Token: 0x04001510 RID: 5392
		private int nCount;

		// Token: 0x04001511 RID: 5393
		private int bufOff;
	}
}
