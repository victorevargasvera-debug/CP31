using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D1 RID: 977
	public class DsaParameterGenerationParameters
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x000AA9AB File Offset: 0x000A8BAB
		public DsaParameterGenerationParameters(int L, int N, int certainty, global::Org.BouncyCastle.Security.SecureRandom random) : this(L, N, certainty, random, -1)
		{
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000AA9B9 File Offset: 0x000A8BB9
		public DsaParameterGenerationParameters(int L, int N, int certainty, global::Org.BouncyCastle.Security.SecureRandom random, int usageIndex)
		{
			this.l = L;
			this.n = N;
			this.certainty = certainty;
			this.random = random;
			this.usageIndex = usageIndex;
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x000AA9E6 File Offset: 0x000A8BE6
		public virtual int L
		{
			get
			{
				return this.l;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x000AA9EE File Offset: 0x000A8BEE
		public virtual int N
		{
			get
			{
				return this.n;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x000AA9F6 File Offset: 0x000A8BF6
		public virtual int UsageIndex
		{
			get
			{
				return this.usageIndex;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x000AA9FE File Offset: 0x000A8BFE
		public virtual int Certainty
		{
			get
			{
				return this.certainty;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x000AAA06 File Offset: 0x000A8C06
		public virtual global::Org.BouncyCastle.Security.SecureRandom Random
		{
			get
			{
				return this.random;
			}
		}

		// Token: 0x04000FED RID: 4077
		public const int DigitalSignatureUsage = 1;

		// Token: 0x04000FEE RID: 4078
		public const int KeyEstablishmentUsage = 2;

		// Token: 0x04000FEF RID: 4079
		private readonly int l;

		// Token: 0x04000FF0 RID: 4080
		private readonly int n;

		// Token: 0x04000FF1 RID: 4081
		private readonly int certainty;

		// Token: 0x04000FF2 RID: 4082
		private readonly global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04000FF3 RID: 4083
		private readonly int usageIndex;
	}
}
