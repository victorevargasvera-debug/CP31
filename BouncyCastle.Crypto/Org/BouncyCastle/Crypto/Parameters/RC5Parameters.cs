using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000404 RID: 1028
	public class RC5Parameters : global::Org.BouncyCastle.Crypto.Parameters.KeyParameter
	{
		// Token: 0x0600286B RID: 10347 RVA: 0x000ACA9A File Offset: 0x000AAC9A
		public RC5Parameters(byte[] key, int rounds) : base(key)
		{
			if (key.Length > 255)
			{
				throw new global::System.ArgumentException("RC5 key length can be no greater than 255");
			}
			this.rounds = rounds;
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x000ACABF File Offset: 0x000AACBF
		public int Rounds
		{
			get
			{
				return this.rounds;
			}
		}

		// Token: 0x04001067 RID: 4199
		private readonly int rounds;
	}
}
