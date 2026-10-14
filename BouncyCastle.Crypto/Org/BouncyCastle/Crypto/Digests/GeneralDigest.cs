using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004CB RID: 1227
	public abstract class GeneralDigest : global::Org.BouncyCastle.Crypto.IDigest, global::Org.BouncyCastle.Utilities.IMemoable
	{
		// Token: 0x06002FAE RID: 12206 RVA: 0x000DEEFD File Offset: 0x000DD0FD
		internal GeneralDigest()
		{
			this.xBuf = new byte[4];
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x000DEF11 File Offset: 0x000DD111
		internal GeneralDigest(global::Org.BouncyCastle.Crypto.Digests.GeneralDigest t)
		{
			this.xBuf = new byte[t.xBuf.Length];
			this.CopyIn(t);
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x000DEF33 File Offset: 0x000DD133
		protected void CopyIn(global::Org.BouncyCastle.Crypto.Digests.GeneralDigest t)
		{
			global::System.Array.Copy(t.xBuf, 0, this.xBuf, 0, t.xBuf.Length);
			this.xBufOff = t.xBufOff;
			this.byteCount = t.byteCount;
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x000DEF68 File Offset: 0x000DD168
		public void Update(byte input)
		{
			byte[] array = this.xBuf;
			int num = this.xBufOff;
			this.xBufOff = num + 1;
			array[num] = input;
			if (this.xBufOff == this.xBuf.Length)
			{
				this.ProcessWord(this.xBuf, 0);
				this.xBufOff = 0;
			}
			this.byteCount += 1L;
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x000DEFC4 File Offset: 0x000DD1C4
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
			length = global::System.Math.Max(0, length);
			int i = 0;
			if (this.xBufOff != 0)
			{
				while (i < length)
				{
					byte[] array = this.xBuf;
					int num = this.xBufOff;
					this.xBufOff = num + 1;
					array[num] = input[inOff + i++];
					if (this.xBufOff == 4)
					{
						this.ProcessWord(this.xBuf, 0);
						this.xBufOff = 0;
						break;
					}
				}
			}
			int limit = (length - i & -4) + i;
			while (i < limit)
			{
				this.ProcessWord(input, inOff + i);
				i += 4;
			}
			while (i < length)
			{
				byte[] array2 = this.xBuf;
				int num = this.xBufOff;
				this.xBufOff = num + 1;
				array2[num] = input[inOff + i++];
			}
			this.byteCount += (long)length;
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x000DF080 File Offset: 0x000DD280
		public void Finish()
		{
			long bitLength = this.byteCount << 3;
			this.Update(128);
			while (this.xBufOff != 0)
			{
				this.Update(0);
			}
			this.ProcessLength(bitLength);
			this.ProcessBlock();
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x000DF0BF File Offset: 0x000DD2BF
		public virtual void Reset()
		{
			this.byteCount = 0L;
			this.xBufOff = 0;
			global::System.Array.Clear(this.xBuf, 0, this.xBuf.Length);
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x000DF0E4 File Offset: 0x000DD2E4
		public int GetByteLength()
		{
			return 64;
		}

		// Token: 0x06002FB6 RID: 12214
		internal abstract void ProcessWord(byte[] input, int inOff);

		// Token: 0x06002FB7 RID: 12215
		internal abstract void ProcessLength(long bitLength);

		// Token: 0x06002FB8 RID: 12216
		internal abstract void ProcessBlock();

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002FB9 RID: 12217
		public abstract string AlgorithmName { get; }

		// Token: 0x06002FBA RID: 12218
		public abstract int GetDigestSize();

		// Token: 0x06002FBB RID: 12219
		public abstract int DoFinal(byte[] output, int outOff);

		// Token: 0x06002FBC RID: 12220
		public abstract global::Org.BouncyCastle.Utilities.IMemoable Copy();

		// Token: 0x06002FBD RID: 12221
		public abstract void Reset(global::Org.BouncyCastle.Utilities.IMemoable t);

		// Token: 0x04001495 RID: 5269
		private const int BYTE_LENGTH = 64;

		// Token: 0x04001496 RID: 5270
		private byte[] xBuf;

		// Token: 0x04001497 RID: 5271
		private int xBufOff;

		// Token: 0x04001498 RID: 5272
		private long byteCount;
	}
}
