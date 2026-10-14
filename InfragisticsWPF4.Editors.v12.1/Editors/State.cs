using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000099 RID: 153
	internal enum State
	{
		// Token: 0x040002F8 RID: 760
		Initial,
		// Token: 0x040002F9 RID: 761
		LiteralEscape,
		// Token: 0x040002FA RID: 762
		Date,
		// Token: 0x040002FB RID: 763
		Time,
		// Token: 0x040002FC RID: 764
		Number,
		// Token: 0x040002FD RID: 765
		FractionPart
	}
}
