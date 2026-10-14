using System;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x02000085 RID: 133
	[global::System.Serializable]
	public class TspValidationException : global::Org.BouncyCastle.Tsp.TspException
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x00018388 File Offset: 0x00016588
		public TspValidationException(string message) : base(message)
		{
			this.failureCode = -1;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00018398 File Offset: 0x00016598
		public TspValidationException(string message, int failureCode) : base(message)
		{
			this.failureCode = failureCode;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x000183A8 File Offset: 0x000165A8
		public int FailureCode
		{
			get
			{
				return this.failureCode;
			}
		}

		// Token: 0x040002E0 RID: 736
		private int failureCode;
	}
}
