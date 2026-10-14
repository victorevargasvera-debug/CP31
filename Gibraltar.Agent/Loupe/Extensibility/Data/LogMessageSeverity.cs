using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200007C RID: 124
	[global::System.Flags]
	internal enum LogMessageSeverity
	{
		// Token: 0x040000F7 RID: 247
		Unknown = 0,
		// Token: 0x040000F8 RID: 248
		Critical = 1,
		// Token: 0x040000F9 RID: 249
		Error = 2,
		// Token: 0x040000FA RID: 250
		Warning = 4,
		// Token: 0x040000FB RID: 251
		Information = 8,
		// Token: 0x040000FC RID: 252
		Verbose = 16
	}
}
