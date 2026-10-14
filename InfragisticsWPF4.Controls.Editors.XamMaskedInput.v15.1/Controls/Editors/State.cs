using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002C RID: 44
	internal enum State
	{
		// Token: 0x040000A4 RID: 164
		Initial,
		// Token: 0x040000A5 RID: 165
		LiteralEscape,
		// Token: 0x040000A6 RID: 166
		Date,
		// Token: 0x040000A7 RID: 167
		Time,
		// Token: 0x040000A8 RID: 168
		Number,
		// Token: 0x040000A9 RID: 169
		FractionPart
	}
}
