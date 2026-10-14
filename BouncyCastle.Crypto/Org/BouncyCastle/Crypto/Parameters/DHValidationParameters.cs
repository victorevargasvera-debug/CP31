using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003CE RID: 974
	public class DHValidationParameters
	{
		// Token: 0x06002739 RID: 10041 RVA: 0x000AA844 File Offset: 0x000A8A44
		public DHValidationParameters(byte[] seed, int counter)
		{
			if (seed == null)
			{
				throw new global::System.ArgumentNullException("seed");
			}
			this.seed = (byte[])seed.Clone();
			this.counter = counter;
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x000AA872 File Offset: 0x000A8A72
		public byte[] GetSeed()
		{
			return (byte[])this.seed.Clone();
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x000AA884 File Offset: 0x000A8A84
		public int Counter
		{
			get
			{
				return this.counter;
			}
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000AA88C File Offset: 0x000A8A8C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DHValidationParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DHValidationParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000AA8B2 File Offset: 0x000A8AB2
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DHValidationParameters other)
		{
			return this.counter == other.counter && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.seed, other.seed);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000AA8D8 File Offset: 0x000A8AD8
		public override int GetHashCode()
		{
			return this.counter.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.seed);
		}

		// Token: 0x04000FE9 RID: 4073
		private readonly byte[] seed;

		// Token: 0x04000FEA RID: 4074
		private readonly int counter;
	}
}
