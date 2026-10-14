using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000457 RID: 1111
	public class SipHash : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002B13 RID: 11027 RVA: 0x000B8F26 File Offset: 0x000B7126
		public SipHash() : this(2, 4)
		{
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000B8F30 File Offset: 0x000B7130
		public SipHash(int c, int d)
		{
			this.c = c;
			this.d = d;
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x000B8F48 File Offset: 0x000B7148
		public virtual string AlgorithmName
		{
			get
			{
				return "SipHash-" + this.c.ToString() + "-" + this.d.ToString();
			}
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000B8F80 File Offset: 0x000B7180
		public virtual int GetMacSize()
		{
			return 8;
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000B8F84 File Offset: 0x000B7184
		public virtual void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParameter = parameters as global::Org.BouncyCastle.Crypto.Parameters.KeyParameter;
			if (keyParameter == null)
			{
				throw new global::System.ArgumentException("must be an instance of KeyParameter", "parameters");
			}
			byte[] key = keyParameter.GetKey();
			if (key.Length != 16)
			{
				throw new global::System.ArgumentException("must be a 128-bit key", "parameters");
			}
			this.k0 = (long)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(key, 0);
			this.k1 = (long)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(key, 8);
			this.Reset();
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000B8FE8 File Offset: 0x000B71E8
		public virtual void Update(byte input)
		{
			this.m = (long)((ulong)this.m >> 8 | (ulong)input << 56);
			int num = this.wordPos + 1;
			this.wordPos = num;
			if (num == 8)
			{
				this.ProcessMessageWord();
				this.wordPos = 0;
			}
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x000B902C File Offset: 0x000B722C
		public virtual void BlockUpdate(byte[] input, int offset, int length)
		{
			int i = 0;
			int fullWords = length & -8;
			if (this.wordPos == 0)
			{
				while (i < fullWords)
				{
					this.m = (long)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(input, offset + i);
					this.ProcessMessageWord();
					i += 8;
				}
				while (i < length)
				{
					this.m = (long)((ulong)this.m >> 8 | (ulong)input[offset + i] << 56);
					i++;
				}
				this.wordPos = length - fullWords;
				return;
			}
			int bits = this.wordPos << 3;
			while (i < fullWords)
			{
				ulong j = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(input, offset + i);
				this.m = (long)(j << bits | (ulong)this.m >> -bits);
				this.ProcessMessageWord();
				this.m = (long)j;
				i += 8;
			}
			while (i < length)
			{
				this.m = (long)((ulong)this.m >> 8 | (ulong)input[offset + i] << 56);
				int num = this.wordPos + 1;
				this.wordPos = num;
				if (num == 8)
				{
					this.ProcessMessageWord();
					this.wordPos = 0;
				}
				i++;
			}
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x000B911C File Offset: 0x000B731C
		public virtual long DoFinal()
		{
			this.m = (long)((ulong)this.m >> (7 - this.wordPos << 3));
			this.m = (long)((ulong)this.m >> 8);
			this.m |= (long)((this.wordCount << 3) + this.wordPos) << 56;
			this.ProcessMessageWord();
			this.v2 ^= 255L;
			this.ApplySipRounds(this.d);
			long result = this.v0 ^ this.v1 ^ this.v2 ^ this.v3;
			this.Reset();
			return result;
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000B91B7 File Offset: 0x000B73B7
		public virtual int DoFinal(byte[] output, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE((ulong)this.DoFinal(), output, outOff);
			return 8;
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x000B91C8 File Offset: 0x000B73C8
		public virtual void Reset()
		{
			this.v0 = (this.k0 ^ 8317987319222330741L);
			this.v1 = (this.k1 ^ 7237128888997146477L);
			this.v2 = (this.k0 ^ 7816392313619706465L);
			this.v3 = (this.k1 ^ 8387220255154660723L);
			this.m = 0L;
			this.wordPos = 0;
			this.wordCount = 0;
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000B9244 File Offset: 0x000B7444
		protected virtual void ProcessMessageWord()
		{
			this.wordCount++;
			this.v3 ^= this.m;
			this.ApplySipRounds(this.c);
			this.v0 ^= this.m;
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000B9294 File Offset: 0x000B7494
		protected virtual void ApplySipRounds(int n)
		{
			long r0 = this.v0;
			long r = this.v1;
			long r2 = this.v2;
			long r3 = this.v3;
			for (int r4 = 0; r4 < n; r4++)
			{
				r0 += r;
				r2 += r3;
				r = global::Org.BouncyCastle.Crypto.Macs.SipHash.RotateLeft(r, 13);
				r3 = global::Org.BouncyCastle.Crypto.Macs.SipHash.RotateLeft(r3, 16);
				r ^= r0;
				r3 ^= r2;
				r0 = global::Org.BouncyCastle.Crypto.Macs.SipHash.RotateLeft(r0, 32);
				r2 += r;
				r0 += r3;
				r = global::Org.BouncyCastle.Crypto.Macs.SipHash.RotateLeft(r, 17);
				r3 = global::Org.BouncyCastle.Crypto.Macs.SipHash.RotateLeft(r3, 21);
				r ^= r2;
				r3 ^= r0;
				r2 = global::Org.BouncyCastle.Crypto.Macs.SipHash.RotateLeft(r2, 32);
			}
			this.v0 = r0;
			this.v1 = r;
			this.v2 = r2;
			this.v3 = r3;
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000B9340 File Offset: 0x000B7540
		protected static long RotateLeft(long x, int n)
		{
			return x << n | (long)((ulong)x >> -n);
		}

		// Token: 0x040011D3 RID: 4563
		protected readonly int c;

		// Token: 0x040011D4 RID: 4564
		protected readonly int d;

		// Token: 0x040011D5 RID: 4565
		protected long k0;

		// Token: 0x040011D6 RID: 4566
		protected long k1;

		// Token: 0x040011D7 RID: 4567
		protected long v0;

		// Token: 0x040011D8 RID: 4568
		protected long v1;

		// Token: 0x040011D9 RID: 4569
		protected long v2;

		// Token: 0x040011DA RID: 4570
		protected long v3;

		// Token: 0x040011DB RID: 4571
		protected long m;

		// Token: 0x040011DC RID: 4572
		protected int wordPos;

		// Token: 0x040011DD RID: 4573
		protected int wordCount;
	}
}
