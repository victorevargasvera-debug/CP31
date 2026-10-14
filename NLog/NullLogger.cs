using System;
using NLog.Internal;

namespace NLog
{
	// Token: 0x0200001E RID: 30
	public sealed class NullLogger : global::NLog.Logger
	{
		// Token: 0x06000480 RID: 1152 RVA: 0x00008FC8 File Offset: 0x000071C8
		private NullLogger()
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00008FD0 File Offset: 0x000071D0
		public NullLogger(global::NLog.LogFactory factory)
		{
			if (factory == null)
			{
				throw new global::System.ArgumentNullException("factory");
			}
			global::NLog.Internal.TargetWithFilterChain[] targetsByLevel = new global::NLog.Internal.TargetWithFilterChain[global::NLog.LogLevel.MaxLevel.Ordinal + 1];
			base.Initialize(string.Empty, new global::NLog.Internal.LoggerConfiguration(targetsByLevel, false), factory);
		}
	}
}
