using System;

namespace Motorola.Common.LogUtility
{
	// Token: 0x0200000E RID: 14
	public interface ILog
	{
		// Token: 0x06000075 RID: 117
		void Debug(string message);

		// Token: 0x06000076 RID: 118
		void Debug(string format, params object[] message);

		// Token: 0x06000077 RID: 119
		void DebugEx(string logFileSuffix, string format, params object[] message);

		// Token: 0x06000078 RID: 120
		void Error(string message);

		// Token: 0x06000079 RID: 121
		void Error(string format, params object[] message);

		// Token: 0x0600007A RID: 122
		void ErrorEx(string logFileSuffix, string format, params object[] message);

		// Token: 0x0600007B RID: 123
		void Error(global::System.Exception e, string message = null);

		// Token: 0x0600007C RID: 124
		void Error(global::System.Exception e, string format, params object[] message);

		// Token: 0x0600007D RID: 125
		void ErrorEx(global::System.Exception e, string logFileSuffix, string format, params object[] message);

		// Token: 0x0600007E RID: 126
		void UserOperation(string message);

		// Token: 0x0600007F RID: 127
		void UserOperation(string format, params object[] message);

		// Token: 0x06000080 RID: 128
		void UserOperationEx(string logFileSuffix, string format, params object[] message);

		// Token: 0x06000081 RID: 129
		void SetTimeStampLabel(string labelName);

		// Token: 0x06000082 RID: 130
		bool CanLogPerformance();

		// Token: 0x06000083 RID: 131
		void Performance(string stampName, string message);

		// Token: 0x06000084 RID: 132
		void Performance(string stampName, string format, params object[] message);

		// Token: 0x06000085 RID: 133
		void PerformanceEx(string logFileSuffix, string stampName, string format, params object[] message);

		// Token: 0x06000086 RID: 134
		void EventInfo(string message);

		// Token: 0x06000087 RID: 135
		void EventWarning(string message);

		// Token: 0x06000088 RID: 136
		void EventError(string message);

		// Token: 0x06000089 RID: 137
		void WriteEventEntry(string content, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);

		// Token: 0x0600008A RID: 138
		void WriteEventEntry(global::System.Exception e, global::Motorola.Common.LogUtility.LoggingLevel level = global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);

		// Token: 0x0600008B RID: 139
		void AddAppender(global::Motorola.Common.LogUtility.IAppender appender);
	}
}
