using System;

namespace System.Data.Entity.Core.Common.EntitySql.AST
{
	// Token: 0x0200068D RID: 1677
	internal enum LiteralKind
	{
		// Token: 0x04001D04 RID: 7428
		Number,
		// Token: 0x04001D05 RID: 7429
		String,
		// Token: 0x04001D06 RID: 7430
		UnicodeString,
		// Token: 0x04001D07 RID: 7431
		Boolean,
		// Token: 0x04001D08 RID: 7432
		Binary,
		// Token: 0x04001D09 RID: 7433
		DateTime,
		// Token: 0x04001D0A RID: 7434
		Time,
		// Token: 0x04001D0B RID: 7435
		DateTimeOffset,
		// Token: 0x04001D0C RID: 7436
		Guid,
		// Token: 0x04001D0D RID: 7437
		Null
	}
}
