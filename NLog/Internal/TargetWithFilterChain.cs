using System;
using System.Collections.Generic;
using NLog.Config;
using NLog.Filters;
using NLog.Targets;

namespace NLog.Internal
{
	// Token: 0x0200012B RID: 299
	[global::NLog.Config.NLogConfigurationItem]
	internal class TargetWithFilterChain
	{
		// Token: 0x06000DC7 RID: 3527 RVA: 0x00022F5D File Offset: 0x0002115D
		public TargetWithFilterChain(global::NLog.Targets.Target target, global::System.Collections.Generic.IList<global::NLog.Filters.Filter> filterChain)
		{
			this.Target = target;
			this.FilterChain = filterChain;
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00022F73 File Offset: 0x00021173
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x00022F7B File Offset: 0x0002117B
		public global::NLog.Targets.Target Target { get; private set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00022F84 File Offset: 0x00021184
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00022F8C File Offset: 0x0002118C
		public global::System.Collections.Generic.IList<global::NLog.Filters.Filter> FilterChain { get; private set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00022F95 File Offset: 0x00021195
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00022F9D File Offset: 0x0002119D
		public global::NLog.Internal.TargetWithFilterChain NextInChain { get; set; }

		// Token: 0x06000DCE RID: 3534 RVA: 0x00022FA8 File Offset: 0x000211A8
		public global::NLog.Config.StackTraceUsage GetStackTraceUsage()
		{
			global::NLog.Config.StackTraceUsage? stackTraceUsage = this._stackTraceUsage;
			if (stackTraceUsage == null)
			{
				return global::NLog.Config.StackTraceUsage.None;
			}
			return stackTraceUsage.GetValueOrDefault();
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00022FD0 File Offset: 0x000211D0
		internal global::NLog.Config.StackTraceUsage PrecalculateStackTraceUsage()
		{
			global::NLog.Config.StackTraceUsage stackTraceUsage = global::NLog.Config.StackTraceUsage.None;
			if (this.Target != null)
			{
				stackTraceUsage = this.Target.StackTraceUsage;
			}
			if (this.NextInChain != null && stackTraceUsage != global::NLog.Config.StackTraceUsage.WithSource)
			{
				global::NLog.Config.StackTraceUsage stackTraceUsage2 = this.NextInChain.PrecalculateStackTraceUsage();
				if (stackTraceUsage2 > stackTraceUsage)
				{
					stackTraceUsage = stackTraceUsage2;
				}
			}
			this._stackTraceUsage = new global::NLog.Config.StackTraceUsage?(stackTraceUsage);
			return stackTraceUsage;
		}

		// Token: 0x040003C8 RID: 968
		private global::NLog.Config.StackTraceUsage? _stackTraceUsage;
	}
}
