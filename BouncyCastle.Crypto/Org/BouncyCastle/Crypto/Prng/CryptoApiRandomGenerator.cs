using System;
using System.Security.Cryptography;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003B3 RID: 947
	public class CryptoApiRandomGenerator : global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator
	{
		// Token: 0x06002685 RID: 9861 RVA: 0x000A7CF8 File Offset: 0x000A5EF8
		public CryptoApiRandomGenerator() : this(global::System.Security.Cryptography.RandomNumberGenerator.Create())
		{
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x000A7D05 File Offset: 0x000A5F05
		public CryptoApiRandomGenerator(global::System.Security.Cryptography.RandomNumberGenerator rng)
		{
			this.rndProv = rng;
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000A7D14 File Offset: 0x000A5F14
		public virtual void AddSeedMaterial(byte[] seed)
		{
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000A7D16 File Offset: 0x000A5F16
		public virtual void AddSeedMaterial(long seed)
		{
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000A7D18 File Offset: 0x000A5F18
		public virtual void NextBytes(byte[] bytes)
		{
			this.rndProv.GetBytes(bytes);
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000A7D28 File Offset: 0x000A5F28
		public virtual void NextBytes(byte[] bytes, int start, int len)
		{
			if (start < 0)
			{
				throw new global::System.ArgumentException("Start offset cannot be negative", "start");
			}
			if (bytes.Length < start + len)
			{
				throw new global::System.ArgumentException("Byte array too small for requested offset and length");
			}
			if (bytes.Length == len && start == 0)
			{
				this.NextBytes(bytes);
				return;
			}
			byte[] tmpBuf = new byte[len];
			this.NextBytes(tmpBuf);
			global::System.Array.Copy(tmpBuf, 0, bytes, start, len);
		}

		// Token: 0x04000F8A RID: 3978
		private readonly global::System.Security.Cryptography.RandomNumberGenerator rndProv;
	}
}
