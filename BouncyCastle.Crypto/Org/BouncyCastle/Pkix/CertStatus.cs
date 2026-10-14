using System;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x02000192 RID: 402
	public class CertStatus
	{
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00036FF0 File Offset: 0x000351F0
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x00036FF8 File Offset: 0x000351F8
		public global::Org.BouncyCastle.Utilities.Date.DateTimeObject RevocationDate
		{
			get
			{
				return this.revocationDate;
			}
			set
			{
				this.revocationDate = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00037001 File Offset: 0x00035201
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x00037009 File Offset: 0x00035209
		public int Status
		{
			get
			{
				return this.status;
			}
			set
			{
				this.status = value;
			}
		}

		// Token: 0x0400084C RID: 2124
		public const int Unrevoked = 11;

		// Token: 0x0400084D RID: 2125
		public const int Undetermined = 12;

		// Token: 0x0400084E RID: 2126
		private int status = 11;

		// Token: 0x0400084F RID: 2127
		private global::Org.BouncyCastle.Utilities.Date.DateTimeObject revocationDate;
	}
}
