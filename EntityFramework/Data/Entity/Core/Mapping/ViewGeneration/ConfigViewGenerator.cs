using System;
using System.Data.Entity.Core.Common.Utils;
using System.Diagnostics;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x02000567 RID: 1383
	internal sealed class ConfigViewGenerator : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004380 RID: 17280 RVA: 0x000E8CB4 File Offset: 0x000E6EB4
		internal ConfigViewGenerator()
		{
			this.m_watch = new global::System.Diagnostics.Stopwatch();
			this.m_singleWatch = new global::System.Diagnostics.Stopwatch();
			int num = global::System.Enum.GetNames(typeof(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType)).Length;
			this.m_breakdownTimes = new global::System.TimeSpan[num];
			this.m_traceLevel = global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenTraceLevel.None;
			this.m_generateUpdateViews = false;
			this.StartWatch();
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06004381 RID: 17281 RVA: 0x000E8D1D File Offset: 0x000E6F1D
		// (set) Token: 0x06004382 RID: 17282 RVA: 0x000E8D25 File Offset: 0x000E6F25
		internal bool GenerateEsql { get; set; }

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x000E8D2E File Offset: 0x000E6F2E
		internal global::System.TimeSpan[] BreakdownTimes
		{
			get
			{
				return this.m_breakdownTimes;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x000E8D36 File Offset: 0x000E6F36
		// (set) Token: 0x06004385 RID: 17285 RVA: 0x000E8D3E File Offset: 0x000E6F3E
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenTraceLevel TraceLevel
		{
			get
			{
				return this.m_traceLevel;
			}
			set
			{
				this.m_traceLevel = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x000E8D47 File Offset: 0x000E6F47
		// (set) Token: 0x06004387 RID: 17287 RVA: 0x000E8D4F File Offset: 0x000E6F4F
		internal bool IsValidationEnabled
		{
			get
			{
				return this.m_enableValidation;
			}
			set
			{
				this.m_enableValidation = value;
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x000E8D58 File Offset: 0x000E6F58
		// (set) Token: 0x06004389 RID: 17289 RVA: 0x000E8D60 File Offset: 0x000E6F60
		internal bool GenerateUpdateViews
		{
			get
			{
				return this.m_generateUpdateViews;
			}
			set
			{
				this.m_generateUpdateViews = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x000E8D69 File Offset: 0x000E6F69
		// (set) Token: 0x0600438B RID: 17291 RVA: 0x000E8D71 File Offset: 0x000E6F71
		internal bool GenerateViewsForEachType { get; set; }

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x0600438C RID: 17292 RVA: 0x000E8D7A File Offset: 0x000E6F7A
		internal bool IsViewTracing
		{
			get
			{
				return this.IsTraceAllowed(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenTraceLevel.ViewsOnly);
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600438D RID: 17293 RVA: 0x000E8D83 File Offset: 0x000E6F83
		internal bool IsNormalTracing
		{
			get
			{
				return this.IsTraceAllowed(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenTraceLevel.Normal);
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x000E8D8C File Offset: 0x000E6F8C
		internal bool IsVerboseTracing
		{
			get
			{
				return this.IsTraceAllowed(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenTraceLevel.Verbose);
			}
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x000E8D95 File Offset: 0x000E6F95
		private void StartWatch()
		{
			this.m_watch.Start();
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x000E8DA2 File Offset: 0x000E6FA2
		internal void StartSingleWatch(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType perfType)
		{
			this.m_singleWatch.Start();
			this.m_singlePerfOp = perfType;
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x000E8DB8 File Offset: 0x000E6FB8
		internal void StopSingleWatch(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType perfType)
		{
			global::System.TimeSpan elapsed = this.m_singleWatch.Elapsed;
			this.m_singleWatch.Stop();
			this.m_singleWatch.Reset();
			this.BreakdownTimes[(int)perfType] = this.BreakdownTimes[(int)perfType].Add(elapsed);
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x000E8E08 File Offset: 0x000E7008
		internal void SetTimeForFinishedActivity(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType perfType)
		{
			global::System.TimeSpan elapsed = this.m_watch.Elapsed;
			this.BreakdownTimes[(int)perfType] = this.BreakdownTimes[(int)perfType].Add(elapsed);
			this.m_watch.Reset();
			this.m_watch.Start();
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x000E8E57 File Offset: 0x000E7057
		internal bool IsTraceAllowed(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenTraceLevel traceLevel)
		{
			return this.TraceLevel >= traceLevel;
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x000E8E65 File Offset: 0x000E7065
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "Trace Switch: {0}", new object[]
			{
				this.m_traceLevel
			});
		}

		// Token: 0x04001814 RID: 6164
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenTraceLevel m_traceLevel;

		// Token: 0x04001815 RID: 6165
		private readonly global::System.TimeSpan[] m_breakdownTimes;

		// Token: 0x04001816 RID: 6166
		private readonly global::System.Diagnostics.Stopwatch m_watch;

		// Token: 0x04001817 RID: 6167
		private readonly global::System.Diagnostics.Stopwatch m_singleWatch;

		// Token: 0x04001818 RID: 6168
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType m_singlePerfOp;

		// Token: 0x04001819 RID: 6169
		private bool m_enableValidation = true;

		// Token: 0x0400181A RID: 6170
		private bool m_generateUpdateViews = true;
	}
}
