using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003FF RID: 1023
	internal enum VarType
	{
		// Token: 0x0400100D RID: 4109
		Parameter,
		// Token: 0x0400100E RID: 4110
		Column,
		// Token: 0x0400100F RID: 4111
		Computed,
		// Token: 0x04001010 RID: 4112
		SetOp,
		// Token: 0x04001011 RID: 4113
		NotValid
	}
}
