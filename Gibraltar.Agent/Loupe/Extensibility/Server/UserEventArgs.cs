using System;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Server
{
	// Token: 0x0200005A RID: 90
	internal class UserEventArgs : global::System.EventArgs
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x0000C084 File Offset: 0x0000A284
		public UserEventArgs(global::Loupe.Extensibility.Data.IUserProfile user)
		{
			this.User = user;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0000C094 File Offset: 0x0000A294
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0000C09C File Offset: 0x0000A29C
		public global::Loupe.Extensibility.Data.IUserProfile User { get; set; }
	}
}
