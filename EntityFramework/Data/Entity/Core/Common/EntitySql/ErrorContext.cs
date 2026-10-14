using System;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200064D RID: 1613
	internal class ErrorContext
	{
		// Token: 0x04001C2D RID: 7213
		internal int InputPosition = -1;

		// Token: 0x04001C2E RID: 7214
		internal string ErrorContextInfo;

		// Token: 0x04001C2F RID: 7215
		internal bool UseContextInfoAsResourceIdentifier = true;

		// Token: 0x04001C30 RID: 7216
		internal string CommandText;
	}
}
