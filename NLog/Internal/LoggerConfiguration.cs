using System;

namespace NLog.Internal
{
	// Token: 0x0200010D RID: 269
	internal class LoggerConfiguration
	{
		// Token: 0x06000CFE RID: 3326 RVA: 0x0001FC88 File Offset: 0x0001DE88
		public LoggerConfiguration(global::NLog.Internal.TargetWithFilterChain[] targetsByLevel, bool exceptionLoggingOldStyle = false)
		{
			this._targetsByLevel = targetsByLevel;
			this.ExceptionLoggingOldStyle = exceptionLoggingOldStyle;
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0001FC9E File Offset: 0x0001DE9E
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x0001FCA6 File Offset: 0x0001DEA6
		[global::System.Obsolete("This property marked obsolete before v4.3.11 and it will be removed in NLog 5.")]
		public bool ExceptionLoggingOldStyle { get; private set; }

		// Token: 0x06000D01 RID: 3329 RVA: 0x0001FCAF File Offset: 0x0001DEAF
		public global::NLog.Internal.TargetWithFilterChain GetTargetsForLevel(global::NLog.LogLevel level)
		{
			if (level == global::NLog.LogLevel.Off)
			{
				return null;
			}
			return this._targetsByLevel[level.Ordinal];
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0001FCCD File Offset: 0x0001DECD
		public bool IsEnabled(global::NLog.LogLevel level)
		{
			return !(level == global::NLog.LogLevel.Off) && this._targetsByLevel[level.Ordinal] != null;
		}

		// Token: 0x04000395 RID: 917
		private readonly global::NLog.Internal.TargetWithFilterChain[] _targetsByLevel;
	}
}
