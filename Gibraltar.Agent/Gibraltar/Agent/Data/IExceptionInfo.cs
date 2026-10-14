using System;

namespace Gibraltar.Agent.Data
{
	// Token: 0x0200003C RID: 60
	public interface IExceptionInfo
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600035E RID: 862
		string TypeName { get; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600035F RID: 863
		string Message { get; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000360 RID: 864
		string Source { get; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000361 RID: 865
		string StackTrace { get; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000362 RID: 866
		global::Gibraltar.Agent.Data.IExceptionInfo InnerException { get; }
	}
}
