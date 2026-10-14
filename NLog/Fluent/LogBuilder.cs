using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NLog.Fluent
{
	// Token: 0x0200014A RID: 330
	public class LogBuilder
	{
		// Token: 0x06000ED0 RID: 3792 RVA: 0x00025C5C File Offset: 0x00023E5C
		[global::System.CLSCompliant(false)]
		public LogBuilder(global::NLog.ILogger logger) : this(logger, global::NLog.LogLevel.Debug)
		{
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00025C6C File Offset: 0x00023E6C
		[global::System.CLSCompliant(false)]
		public LogBuilder(global::NLog.ILogger logger, global::NLog.LogLevel logLevel)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			if (logLevel == null)
			{
				throw new global::System.ArgumentNullException("logLevel");
			}
			this._logger = logger;
			this._logEvent = new global::NLog.LogEventInfo
			{
				LoggerName = logger.Name,
				Level = logLevel
			};
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00025CC6 File Offset: 0x00023EC6
		public global::NLog.LogEventInfo LogEventInfo
		{
			get
			{
				return this._logEvent;
			}
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00025CCE File Offset: 0x00023ECE
		public global::NLog.Fluent.LogBuilder Exception(global::System.Exception exception)
		{
			this._logEvent.Exception = exception;
			return this;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00025CDD File Offset: 0x00023EDD
		public global::NLog.Fluent.LogBuilder Level(global::NLog.LogLevel logLevel)
		{
			if (logLevel == null)
			{
				throw new global::System.ArgumentNullException("logLevel");
			}
			this._logEvent.Level = logLevel;
			return this;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00025D00 File Offset: 0x00023F00
		public global::NLog.Fluent.LogBuilder LoggerName(string loggerName)
		{
			this._logEvent.LoggerName = loggerName;
			return this;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00025D0F File Offset: 0x00023F0F
		public global::NLog.Fluent.LogBuilder Message(string message)
		{
			this._logEvent.Message = message;
			return this;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00025D1E File Offset: 0x00023F1E
		[global::NLog.MessageTemplateFormatMethod("format")]
		public global::NLog.Fluent.LogBuilder Message(string format, object arg0)
		{
			this._logEvent.Message = format;
			this._logEvent.Parameters = new object[]
			{
				arg0
			};
			return this;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00025D42 File Offset: 0x00023F42
		[global::NLog.MessageTemplateFormatMethod("format")]
		public global::NLog.Fluent.LogBuilder Message(string format, object arg0, object arg1)
		{
			this._logEvent.Message = format;
			this._logEvent.Parameters = new object[]
			{
				arg0,
				arg1
			};
			return this;
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00025D6A File Offset: 0x00023F6A
		[global::NLog.MessageTemplateFormatMethod("format")]
		public global::NLog.Fluent.LogBuilder Message(string format, object arg0, object arg1, object arg2)
		{
			this._logEvent.Message = format;
			this._logEvent.Parameters = new object[]
			{
				arg0,
				arg1,
				arg2
			};
			return this;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00025D97 File Offset: 0x00023F97
		[global::NLog.MessageTemplateFormatMethod("format")]
		public global::NLog.Fluent.LogBuilder Message(string format, object arg0, object arg1, object arg2, object arg3)
		{
			this._logEvent.Message = format;
			this._logEvent.Parameters = new object[]
			{
				arg0,
				arg1,
				arg2,
				arg3
			};
			return this;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00025DC9 File Offset: 0x00023FC9
		[global::NLog.MessageTemplateFormatMethod("format")]
		public global::NLog.Fluent.LogBuilder Message(string format, params object[] args)
		{
			this._logEvent.Message = format;
			this._logEvent.Parameters = args;
			return this;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00025DE4 File Offset: 0x00023FE4
		[global::NLog.MessageTemplateFormatMethod("format")]
		public global::NLog.Fluent.LogBuilder Message(global::System.IFormatProvider provider, string format, params object[] args)
		{
			this._logEvent.FormatProvider = provider;
			this._logEvent.Message = format;
			this._logEvent.Parameters = args;
			return this;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00025E0B File Offset: 0x0002400B
		public global::NLog.Fluent.LogBuilder Property(object name, object value)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			this._logEvent.Properties[name] = value;
			return this;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00025E30 File Offset: 0x00024030
		public global::NLog.Fluent.LogBuilder Properties(global::System.Collections.IDictionary properties)
		{
			if (properties == null)
			{
				throw new global::System.ArgumentNullException("properties");
			}
			foreach (object key in properties.Keys)
			{
				this._logEvent.Properties[key] = properties[key];
			}
			return this;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00025EA4 File Offset: 0x000240A4
		public global::NLog.Fluent.LogBuilder TimeStamp(global::System.DateTime timeStamp)
		{
			this._logEvent.TimeStamp = timeStamp;
			return this;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00025EB3 File Offset: 0x000240B3
		public global::NLog.Fluent.LogBuilder StackTrace(global::System.Diagnostics.StackTrace stackTrace, int userStackFrame)
		{
			this._logEvent.SetStackTrace(stackTrace, userStackFrame);
			return this;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00025EC4 File Offset: 0x000240C4
		public void Write([global::System.Runtime.CompilerServices.CallerMemberName] string callerMemberName = null, [global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null, [global::System.Runtime.CompilerServices.CallerLineNumber] int callerLineNumber = 0)
		{
			if (!this._logger.IsEnabled(this._logEvent.Level))
			{
				return;
			}
			if (callerMemberName != null)
			{
				this.Property("CallerMemberName", callerMemberName);
			}
			if (callerFilePath != null)
			{
				this.Property("CallerFilePath", callerFilePath);
			}
			if (callerLineNumber != 0)
			{
				this.Property("CallerLineNumber", callerLineNumber);
			}
			this._logEvent.SetCallerInfo(null, callerMemberName, callerFilePath, callerLineNumber);
			this._logger.Log(this._logEvent);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00025F40 File Offset: 0x00024140
		public void WriteIf(global::System.Func<bool> condition, [global::System.Runtime.CompilerServices.CallerMemberName] string callerMemberName = null, [global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null, [global::System.Runtime.CompilerServices.CallerLineNumber] int callerLineNumber = 0)
		{
			if (condition == null || !condition() || !this._logger.IsEnabled(this._logEvent.Level))
			{
				return;
			}
			if (callerMemberName != null)
			{
				this.Property("CallerMemberName", callerMemberName);
			}
			if (callerFilePath != null)
			{
				this.Property("CallerFilePath", callerFilePath);
			}
			if (callerLineNumber != 0)
			{
				this.Property("CallerLineNumber", callerLineNumber);
			}
			this._logEvent.SetCallerInfo(null, callerMemberName, callerFilePath, callerLineNumber);
			this._logger.Log(this._logEvent);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00025FCC File Offset: 0x000241CC
		public void WriteIf(bool condition, [global::System.Runtime.CompilerServices.CallerMemberName] string callerMemberName = null, [global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null, [global::System.Runtime.CompilerServices.CallerLineNumber] int callerLineNumber = 0)
		{
			if (!condition || !this._logger.IsEnabled(this._logEvent.Level))
			{
				return;
			}
			if (callerMemberName != null)
			{
				this.Property("CallerMemberName", callerMemberName);
			}
			if (callerFilePath != null)
			{
				this.Property("CallerFilePath", callerFilePath);
			}
			if (callerLineNumber != 0)
			{
				this.Property("CallerLineNumber", callerLineNumber);
			}
			this._logEvent.SetCallerInfo(null, callerMemberName, callerFilePath, callerLineNumber);
			this._logger.Log(this._logEvent);
		}

		// Token: 0x04000415 RID: 1045
		private readonly global::NLog.LogEventInfo _logEvent;

		// Token: 0x04000416 RID: 1046
		private readonly global::NLog.ILogger _logger;
	}
}
