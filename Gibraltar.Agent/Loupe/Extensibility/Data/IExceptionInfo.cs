using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000068 RID: 104
	internal interface IExceptionInfo
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000514 RID: 1300
		string TypeName { get; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000515 RID: 1301
		string Message { get; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000516 RID: 1302
		string Source { get; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000517 RID: 1303
		string StackTrace { get; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000518 RID: 1304
		global::Loupe.Extensibility.Data.IExceptionInfo InnerException { get; }
	}
}
