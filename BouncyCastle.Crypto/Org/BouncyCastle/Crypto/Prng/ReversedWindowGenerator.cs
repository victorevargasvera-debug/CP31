using System;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003B8 RID: 952
	public class ReversedWindowGenerator : global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator
	{
		// Token: 0x0600269C RID: 9884 RVA: 0x000A8038 File Offset: 0x000A6238
		public ReversedWindowGenerator(global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator generator, int windowSize)
		{
			if (generator == null)
			{
				throw new global::System.ArgumentNullException("generator");
			}
			if (windowSize < 2)
			{
				throw new global::System.ArgumentException("Window size must be at least 2", "windowSize");
			}
			this.generator = generator;
			this.window = new byte[windowSize];
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000A8078 File Offset: 0x000A6278
		public virtual void AddSeedMaterial(byte[] seed)
		{
			lock (this)
			{
				this.windowCount = 0;
				this.generator.AddSeedMaterial(seed);
			}
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000A80C0 File Offset: 0x000A62C0
		public virtual void AddSeedMaterial(long seed)
		{
			lock (this)
			{
				this.windowCount = 0;
				this.generator.AddSeedMaterial(seed);
			}
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000A8108 File Offset: 0x000A6308
		public virtual void NextBytes(byte[] bytes)
		{
			this.doNextBytes(bytes, 0, bytes.Length);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x000A8115 File Offset: 0x000A6315
		public virtual void NextBytes(byte[] bytes, int start, int len)
		{
			this.doNextBytes(bytes, start, len);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000A8120 File Offset: 0x000A6320
		private void doNextBytes(byte[] bytes, int start, int len)
		{
			lock (this)
			{
				int done = 0;
				while (done < len)
				{
					if (this.windowCount < 1)
					{
						this.generator.NextBytes(this.window, 0, this.window.Length);
						this.windowCount = this.window.Length;
					}
					int num = start + done++;
					byte[] array = this.window;
					int num2 = this.windowCount - 1;
					this.windowCount = num2;
					bytes[num] = array[num2];
				}
			}
		}

		// Token: 0x04000F91 RID: 3985
		private readonly global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator generator;

		// Token: 0x04000F92 RID: 3986
		private byte[] window;

		// Token: 0x04000F93 RID: 3987
		private int windowCount;
	}
}
