using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A0 RID: 160
	internal enum State
	{
		// Token: 0x0400032E RID: 814
		Initial,
		// Token: 0x0400032F RID: 815
		LiteralEscape,
		// Token: 0x04000330 RID: 816
		Date,
		// Token: 0x04000331 RID: 817
		Time,
		// Token: 0x04000332 RID: 818
		Number,
		// Token: 0x04000333 RID: 819
		FractionPart
	}
}
