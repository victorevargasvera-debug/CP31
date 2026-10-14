using System;
using System.Data.Common;

namespace System.Data.Entity.Migrations.Utilities
{
	// Token: 0x020000A4 RID: 164
	internal class EmptyContext : global::System.Data.Entity.DbContext
	{
		// Token: 0x06000EC0 RID: 3776 RVA: 0x0001E45C File Offset: 0x0001C65C
		public EmptyContext(global::System.Data.Common.DbConnection existingConnection) : base(existingConnection, false)
		{
			this.InternalContext.InitializerDisabled = true;
		}
	}
}
