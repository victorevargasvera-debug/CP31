using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000400 RID: 1024
	public class ParametersWithRandom : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x0600285A RID: 10330 RVA: 0x000AC96B File Offset: 0x000AAB6B
		public ParametersWithRandom(global::Org.BouncyCastle.Crypto.ICipherParameters parameters, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			if (random == null)
			{
				throw new global::System.ArgumentNullException("random");
			}
			this.parameters = parameters;
			this.random = random;
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x000AC99D File Offset: 0x000AAB9D
		public ParametersWithRandom(global::Org.BouncyCastle.Crypto.ICipherParameters parameters) : this(parameters, new global::Org.BouncyCastle.Security.SecureRandom())
		{
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x000AC9AB File Offset: 0x000AABAB
		[global::System.Obsolete("Use Random property instead")]
		public global::Org.BouncyCastle.Security.SecureRandom GetRandom()
		{
			return this.Random;
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x000AC9B3 File Offset: 0x000AABB3
		public global::Org.BouncyCastle.Security.SecureRandom Random
		{
			get
			{
				return this.random;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000AC9BB File Offset: 0x000AABBB
		public global::Org.BouncyCastle.Crypto.ICipherParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x04001060 RID: 4192
		private readonly global::Org.BouncyCastle.Crypto.ICipherParameters parameters;

		// Token: 0x04001061 RID: 4193
		private readonly global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
