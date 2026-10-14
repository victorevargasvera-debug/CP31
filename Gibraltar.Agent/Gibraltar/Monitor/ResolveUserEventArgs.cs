using System;
using System.Security.Principal;

namespace Gibraltar.Monitor
{
	// Token: 0x02000181 RID: 385
	internal sealed class ResolveUserEventArgs : global::System.EventArgs
	{
		// Token: 0x06001017 RID: 4119 RVA: 0x0002C418 File Offset: 0x0002A618
		internal ResolveUserEventArgs(string userName, global::System.Security.Principal.IPrincipal principal, global::System.DateTimeOffset timestamp, long sequence)
		{
			this.m_Timestamp = timestamp;
			this.m_Sequence = sequence;
			this.UserName = userName;
			this.Principal = principal;
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0002C440 File Offset: 0x0002A640
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x0002C448 File Offset: 0x0002A648
		public string UserName { get; set; }

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0002C454 File Offset: 0x0002A654
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x0002C45C File Offset: 0x0002A65C
		public global::System.Security.Principal.IPrincipal Principal { get; set; }

		// Token: 0x0600101C RID: 4124 RVA: 0x0002C468 File Offset: 0x0002A668
		public global::Gibraltar.Monitor.ApplicationUser GetUser()
		{
			if (this.m_User == null)
			{
				this.m_User = new global::Gibraltar.Monitor.ApplicationUser(this.UserName, this.m_Timestamp, this.m_Sequence);
			}
			return this.m_User;
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x0002C4A0 File Offset: 0x0002A6A0
		internal global::Gibraltar.Monitor.ApplicationUser User
		{
			get
			{
				return this.m_User;
			}
		}

		// Token: 0x04000562 RID: 1378
		private readonly global::System.DateTimeOffset m_Timestamp;

		// Token: 0x04000563 RID: 1379
		private readonly long m_Sequence;

		// Token: 0x04000564 RID: 1380
		private global::Gibraltar.Monitor.ApplicationUser m_User;
	}
}
