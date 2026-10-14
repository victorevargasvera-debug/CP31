using System;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005CE RID: 1486
	[global::System.Flags]
	internal enum PropagatorFlags : byte
	{
		// Token: 0x04001987 RID: 6535
		NoFlags = 0,
		// Token: 0x04001988 RID: 6536
		Preserve = 1,
		// Token: 0x04001989 RID: 6537
		ConcurrencyValue = 2,
		// Token: 0x0400198A RID: 6538
		Unknown = 8,
		// Token: 0x0400198B RID: 6539
		Key = 16,
		// Token: 0x0400198C RID: 6540
		ForeignKey = 32
	}
}
