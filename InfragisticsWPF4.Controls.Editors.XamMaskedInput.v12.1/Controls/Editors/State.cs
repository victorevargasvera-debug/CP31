using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002D RID: 45
	internal enum State
	{
		// Token: 0x040000A2 RID: 162
		Initial,
		// Token: 0x040000A3 RID: 163
		LiteralEscape,
		// Token: 0x040000A4 RID: 164
		Date,
		// Token: 0x040000A5 RID: 165
		Time,
		// Token: 0x040000A6 RID: 166
		Number,
		// Token: 0x040000A7 RID: 167
		FractionPart
	}
}
