using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F8 RID: 1016
	public class MgfParameters : global::Org.BouncyCastle.Crypto.IDerivationParameters
	{
		// Token: 0x06002839 RID: 10297 RVA: 0x000AC67E File Offset: 0x000AA87E
		public MgfParameters(byte[] seed) : this(seed, 0, seed.Length)
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000AC68B File Offset: 0x000AA88B
		public MgfParameters(byte[] seed, int off, int len)
		{
			this.seed = new byte[len];
			global::System.Array.Copy(seed, off, this.seed, 0, len);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x000AC6AE File Offset: 0x000AA8AE
		public byte[] GetSeed()
		{
			return (byte[])this.seed.Clone();
		}

		// Token: 0x0400104F RID: 4175
		private readonly byte[] seed;
	}
}
