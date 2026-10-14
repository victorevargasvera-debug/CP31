using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003B4 RID: 948
	public class DigestRandomGenerator : global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator
	{
		// Token: 0x0600268B RID: 9867 RVA: 0x000A7D88 File Offset: 0x000A5F88
		public DigestRandomGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.digest = digest;
			this.seed = new byte[digest.GetDigestSize()];
			this.seedCounter = 1L;
			this.state = new byte[digest.GetDigestSize()];
			this.stateCounter = 1L;
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000A7DD4 File Offset: 0x000A5FD4
		public void AddSeedMaterial(byte[] inSeed)
		{
			lock (this)
			{
				if (!global::Org.BouncyCastle.Utilities.Arrays.IsNullOrEmpty(inSeed))
				{
					this.DigestUpdate(inSeed);
				}
				this.DigestUpdate(this.seed);
				this.DigestDoFinal(this.seed);
			}
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000A7E30 File Offset: 0x000A6030
		public void AddSeedMaterial(long rSeed)
		{
			lock (this)
			{
				this.DigestAddCounter(rSeed);
				this.DigestUpdate(this.seed);
				this.DigestDoFinal(this.seed);
			}
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000A7E84 File Offset: 0x000A6084
		public void NextBytes(byte[] bytes)
		{
			this.NextBytes(bytes, 0, bytes.Length);
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000A7E94 File Offset: 0x000A6094
		public void NextBytes(byte[] bytes, int start, int len)
		{
			lock (this)
			{
				int stateOff = 0;
				this.GenerateState();
				int end = start + len;
				for (int i = start; i < end; i++)
				{
					if (stateOff == this.state.Length)
					{
						this.GenerateState();
						stateOff = 0;
					}
					bytes[i] = this.state[stateOff++];
				}
			}
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000A7F08 File Offset: 0x000A6108
		private void CycleSeed()
		{
			this.DigestUpdate(this.seed);
			long num = this.seedCounter;
			this.seedCounter = num + 1L;
			this.DigestAddCounter(num);
			this.DigestDoFinal(this.seed);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x000A7F48 File Offset: 0x000A6148
		private void GenerateState()
		{
			long num = this.stateCounter;
			this.stateCounter = num + 1L;
			this.DigestAddCounter(num);
			this.DigestUpdate(this.state);
			this.DigestUpdate(this.seed);
			this.DigestDoFinal(this.state);
			if (this.stateCounter % 10L == 0L)
			{
				this.CycleSeed();
			}
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000A7FA4 File Offset: 0x000A61A4
		private void DigestAddCounter(long seedVal)
		{
			byte[] bytes = new byte[8];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE((ulong)seedVal, bytes);
			this.digest.BlockUpdate(bytes, 0, bytes.Length);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000A7FCF File Offset: 0x000A61CF
		private void DigestUpdate(byte[] inSeed)
		{
			this.digest.BlockUpdate(inSeed, 0, inSeed.Length);
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000A7FE1 File Offset: 0x000A61E1
		private void DigestDoFinal(byte[] result)
		{
			this.digest.DoFinal(result, 0);
		}

		// Token: 0x04000F8B RID: 3979
		private const long CYCLE_COUNT = 10L;

		// Token: 0x04000F8C RID: 3980
		private long stateCounter;

		// Token: 0x04000F8D RID: 3981
		private long seedCounter;

		// Token: 0x04000F8E RID: 3982
		private global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04000F8F RID: 3983
		private byte[] state;

		// Token: 0x04000F90 RID: 3984
		private byte[] seed;
	}
}
