using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E8 RID: 1000
	public sealed class FpeParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x060027E4 RID: 10212 RVA: 0x000ABD74 File Offset: 0x000A9F74
		public FpeParameters(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, int radix, byte[] tweak) : this(key, radix, tweak, false)
		{
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x000ABD80 File Offset: 0x000A9F80
		public FpeParameters(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, int radix, byte[] tweak, bool useInverse)
		{
			this.key = key;
			this.radix = radix;
			this.tweak = global::Org.BouncyCastle.Utilities.Arrays.Clone(tweak);
			this.useInverse = useInverse;
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x000ABDAA File Offset: 0x000A9FAA
		public global::Org.BouncyCastle.Crypto.Parameters.KeyParameter Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x000ABDB2 File Offset: 0x000A9FB2
		public int Radix
		{
			get
			{
				return this.radix;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x000ABDBA File Offset: 0x000A9FBA
		public bool UseInverseFunction
		{
			get
			{
				return this.useInverse;
			}
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000ABDC2 File Offset: 0x000A9FC2
		public byte[] GetTweak()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.tweak);
		}

		// Token: 0x04001022 RID: 4130
		private readonly global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key;

		// Token: 0x04001023 RID: 4131
		private readonly int radix;

		// Token: 0x04001024 RID: 4132
		private readonly byte[] tweak;

		// Token: 0x04001025 RID: 4133
		private readonly bool useInverse;
	}
}
