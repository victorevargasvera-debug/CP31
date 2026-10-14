using System;

namespace Gibraltar.Agent.Data
{
	// Token: 0x0200003D RID: 61
	public interface ILogMessage : global::System.IComparable<global::Gibraltar.Agent.Data.ILogMessage>, global::System.IEquatable<global::Gibraltar.Agent.Data.ILogMessage>
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000363 RID: 867
		global::System.Guid Id { get; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000364 RID: 868
		long Sequence { get; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000365 RID: 869
		global::System.DateTimeOffset Timestamp { get; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000366 RID: 870
		global::Gibraltar.Agent.LogMessageSeverity Severity { get; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000367 RID: 871
		string LogSystem { get; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000368 RID: 872
		string CategoryName { get; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000369 RID: 873
		string UserName { get; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600036A RID: 874
		string Caption { get; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600036B RID: 875
		string Description { get; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600036C RID: 876
		string Details { get; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600036D RID: 877
		string MethodName { get; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600036E RID: 878
		string ClassName { get; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600036F RID: 879
		string FileName { get; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000370 RID: 880
		int LineNumber { get; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000371 RID: 881
		bool HasException { get; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000372 RID: 882
		global::Gibraltar.Agent.Data.IExceptionInfo Exception { get; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000373 RID: 883
		int ThreadId { get; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000374 RID: 884
		string ThreadName { get; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000375 RID: 885
		int DomainId { get; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000376 RID: 886
		string DomainName { get; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000377 RID: 887
		bool IsBackground { get; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000378 RID: 888
		bool IsThreadPoolThread { get; }
	}
}
