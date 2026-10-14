using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D5 RID: 981
	public class DsaValidationParameters
	{
		// Token: 0x06002761 RID: 10081 RVA: 0x000AAC88 File Offset: 0x000A8E88
		public DsaValidationParameters(byte[] seed, int counter) : this(seed, counter, -1)
		{
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000AAC93 File Offset: 0x000A8E93
		public DsaValidationParameters(byte[] seed, int counter, int usageIndex)
		{
			if (seed == null)
			{
				throw new global::System.ArgumentNullException("seed");
			}
			this.seed = (byte[])seed.Clone();
			this.counter = counter;
			this.usageIndex = usageIndex;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000AACC8 File Offset: 0x000A8EC8
		public virtual byte[] GetSeed()
		{
			return (byte[])this.seed.Clone();
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000AACDA File Offset: 0x000A8EDA
		public virtual int Counter
		{
			get
			{
				return this.counter;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x000AACE2 File Offset: 0x000A8EE2
		public virtual int UsageIndex
		{
			get
			{
				return this.usageIndex;
			}
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x000AACEC File Offset: 0x000A8EEC
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000AAD12 File Offset: 0x000A8F12
		protected virtual bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters other)
		{
			return this.counter == other.counter && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.seed, other.seed);
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x000AAD38 File Offset: 0x000A8F38
		public override int GetHashCode()
		{
			return this.counter.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.seed);
		}

		// Token: 0x04000FFA RID: 4090
		private readonly byte[] seed;

		// Token: 0x04000FFB RID: 4091
		private readonly int counter;

		// Token: 0x04000FFC RID: 4092
		private readonly int usageIndex;
	}
}
