using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;
using NLog.Common;
using NLog.Internal;
using NLog.Layouts;
using NLog.MessageTemplates;
using NLog.Time;

namespace NLog
{
	// Token: 0x0200000B RID: 11
	public class LogEventInfo
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000023A4 File Offset: 0x000005A4
		// (set) Token: 0x06000183 RID: 387 RVA: 0x000023AB File Offset: 0x000005AB
		internal static global::NLog.LogMessageFormatter DefaultMessageFormatter { get; private set; } = global::NLog.Internal.LogMessageTemplateFormatter.DefaultAuto.MessageFormatter;

		// Token: 0x06000184 RID: 388 RVA: 0x000023B3 File Offset: 0x000005B3
		public LogEventInfo()
		{
			this.TimeStamp = global::NLog.Time.TimeSource.Current.Time;
			this.SequenceID = global::System.Threading.Interlocked.Increment(ref global::NLog.LogEventInfo.globalSequenceId);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000023E6 File Offset: 0x000005E6
		public LogEventInfo(global::NLog.LogLevel level, string loggerName, [global::System.ComponentModel.Localizable(false)] string message) : this(level, loggerName, null, message, null, null)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000023F4 File Offset: 0x000005F4
		public LogEventInfo(global::NLog.LogLevel level, string loggerName, [global::System.ComponentModel.Localizable(false)] string message, global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> messageTemplateParameters) : this(level, loggerName, null, message, null, null)
		{
			if (messageTemplateParameters != null && messageTemplateParameters.Count > 0)
			{
				this._properties = new global::NLog.Internal.PropertiesDictionary(messageTemplateParameters);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000241D File Offset: 0x0000061D
		public LogEventInfo(global::NLog.LogLevel level, string loggerName, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, object[] parameters) : this(level, loggerName, formatProvider, message, parameters, null)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002430 File Offset: 0x00000630
		public LogEventInfo(global::NLog.LogLevel level, string loggerName, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, object[] parameters, global::System.Exception exception) : this()
		{
			this.Level = level;
			this.LoggerName = loggerName;
			this.Message = message;
			this.Parameters = parameters;
			this.FormatProvider = formatProvider;
			this.Exception = exception;
			if (global::NLog.LogEventInfo.NeedToPreformatMessage(parameters))
			{
				this.CalcFormattedMessage();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000247F File Offset: 0x0000067F
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002487 File Offset: 0x00000687
		public int SequenceID { get; private set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002498 File Offset: 0x00000698
		public global::System.DateTime TimeStamp { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000024A1 File Offset: 0x000006A1
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000024A9 File Offset: 0x000006A9
		public global::NLog.LogLevel Level { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000024B2 File Offset: 0x000006B2
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000024BA File Offset: 0x000006BA
		internal global::NLog.Internal.CallSiteInformation CallSiteInformation { get; private set; }

		// Token: 0x06000191 RID: 401 RVA: 0x000024C4 File Offset: 0x000006C4
		internal global::NLog.Internal.CallSiteInformation GetCallSiteInformationInternal()
		{
			global::NLog.Internal.CallSiteInformation result;
			if ((result = this.CallSiteInformation) == null)
			{
				result = (this.CallSiteInformation = new global::NLog.Internal.CallSiteInformation());
			}
			return result;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000024E9 File Offset: 0x000006E9
		public bool HasStackTrace
		{
			get
			{
				global::NLog.Internal.CallSiteInformation callSiteInformation = this.CallSiteInformation;
				return ((callSiteInformation != null) ? callSiteInformation.StackTrace : null) != null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002500 File Offset: 0x00000700
		public global::System.Diagnostics.StackFrame UserStackFrame
		{
			get
			{
				global::NLog.Internal.CallSiteInformation callSiteInformation = this.CallSiteInformation;
				if (callSiteInformation == null)
				{
					return null;
				}
				return callSiteInformation.UserStackFrame;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002514 File Offset: 0x00000714
		public int UserStackFrameNumber
		{
			get
			{
				global::NLog.Internal.CallSiteInformation callSiteInformation = this.CallSiteInformation;
				int? num = (callSiteInformation != null) ? callSiteInformation.UserStackFrameNumberLegacy : null;
				if (num != null)
				{
					return num.GetValueOrDefault();
				}
				global::NLog.Internal.CallSiteInformation callSiteInformation2 = this.CallSiteInformation;
				if (callSiteInformation2 == null)
				{
					return 0;
				}
				return callSiteInformation2.UserStackFrameNumber;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000255E File Offset: 0x0000075E
		public global::System.Diagnostics.StackTrace StackTrace
		{
			get
			{
				global::NLog.Internal.CallSiteInformation callSiteInformation = this.CallSiteInformation;
				if (callSiteInformation == null)
				{
					return null;
				}
				return callSiteInformation.StackTrace;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00002571 File Offset: 0x00000771
		public string CallerClassName
		{
			get
			{
				global::NLog.Internal.CallSiteInformation callSiteInformation = this.CallSiteInformation;
				if (callSiteInformation == null)
				{
					return null;
				}
				return callSiteInformation.GetCallerClassName(null, true, true, true);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002588 File Offset: 0x00000788
		public string CallerMemberName
		{
			get
			{
				global::NLog.Internal.CallSiteInformation callSiteInformation = this.CallSiteInformation;
				if (callSiteInformation == null)
				{
					return null;
				}
				return callSiteInformation.GetCallerMemberName(null, false, true, true);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000259F File Offset: 0x0000079F
		public string CallerFilePath
		{
			get
			{
				global::NLog.Internal.CallSiteInformation callSiteInformation = this.CallSiteInformation;
				if (callSiteInformation == null)
				{
					return null;
				}
				return callSiteInformation.GetCallerFilePath(0);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000025B3 File Offset: 0x000007B3
		public int CallerLineNumber
		{
			get
			{
				global::NLog.Internal.CallSiteInformation callSiteInformation = this.CallSiteInformation;
				if (callSiteInformation == null)
				{
					return 0;
				}
				return callSiteInformation.GetCallerLineNumber(0);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600019A RID: 410 RVA: 0x000025C7 File Offset: 0x000007C7
		// (set) Token: 0x0600019B RID: 411 RVA: 0x000025CF File Offset: 0x000007CF
		public global::System.Exception Exception { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600019D RID: 413 RVA: 0x000025E0 File Offset: 0x000007E0
		public string LoggerName { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000025EC File Offset: 0x000007EC
		[global::System.Obsolete("This property should not be used. Marked obsolete on NLog 2.0")]
		public string LoggerShortName
		{
			get
			{
				int num = this.LoggerName.LastIndexOf('.');
				if (num >= 0)
				{
					return this.LoggerName.Substring(num + 1);
				}
				return this.LoggerName;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002620 File Offset: 0x00000820
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002628 File Offset: 0x00000828
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				bool rebuildMessageTemplateParameters = this.ResetMessageTemplateParameters();
				this._message = value;
				this.ResetFormattedMessage(rebuildMessageTemplateParameters);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000264A File Offset: 0x0000084A
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002654 File Offset: 0x00000854
		public object[] Parameters
		{
			get
			{
				return this._parameters;
			}
			set
			{
				bool rebuildMessageTemplateParameters = this.ResetMessageTemplateParameters();
				this._parameters = value;
				this.ResetFormattedMessage(rebuildMessageTemplateParameters);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002676 File Offset: 0x00000876
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000267E File Offset: 0x0000087E
		public global::System.IFormatProvider FormatProvider
		{
			get
			{
				return this._formatProvider;
			}
			set
			{
				if (this._formatProvider != value)
				{
					this._formatProvider = value;
					this.ResetFormattedMessage(false);
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002697 File Offset: 0x00000897
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000269F File Offset: 0x0000089F
		public global::NLog.LogMessageFormatter MessageFormatter
		{
			get
			{
				return this._messageFormatter;
			}
			set
			{
				this._messageFormatter = (value ?? global::NLog.LogEventInfo.StringFormatMessageFormatter);
				this.ResetFormattedMessage(false);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000026B8 File Offset: 0x000008B8
		public string FormattedMessage
		{
			get
			{
				if (this._formattedMessage == null)
				{
					this.CalcFormattedMessage();
				}
				return this._formattedMessage;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000026CE File Offset: 0x000008CE
		public bool HasProperties
		{
			get
			{
				if (this._properties != null)
				{
					return this._properties.Count > 0;
				}
				global::NLog.Internal.PropertiesDictionary propertiesDictionary = this.CreateOrUpdatePropertiesInternal(false, null);
				return propertiesDictionary != null && propertiesDictionary.Count > 0;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000026FD File Offset: 0x000008FD
		public global::System.Collections.Generic.IDictionary<object, object> Properties
		{
			get
			{
				return this.CreateOrUpdatePropertiesInternal(true, null);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002708 File Offset: 0x00000908
		internal global::NLog.Internal.PropertiesDictionary CreateOrUpdatePropertiesInternal(bool forceCreate = true, global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> templateParameters = null)
		{
			global::NLog.Internal.PropertiesDictionary propertiesDictionary = this._properties;
			if (propertiesDictionary == null)
			{
				if (forceCreate || (templateParameters != null && templateParameters.Count > 0) || (templateParameters == null && this.HasMessageTemplateParameters))
				{
					propertiesDictionary = new global::NLog.Internal.PropertiesDictionary(templateParameters);
					global::System.Threading.Interlocked.CompareExchange<global::NLog.Internal.PropertiesDictionary>(ref this._properties, propertiesDictionary, null);
					if (templateParameters == null && (!forceCreate || this.HasMessageTemplateParameters))
					{
						this.CalcFormattedMessage();
					}
				}
			}
			else if (templateParameters != null)
			{
				propertiesDictionary.MessageProperties = templateParameters;
			}
			return this._properties;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00002774 File Offset: 0x00000974
		internal bool HasMessageTemplateParameters
		{
			get
			{
				if (this._formattedMessage == null)
				{
					global::NLog.LogMessageFormatter messageFormatter = this._messageFormatter;
					global::NLog.Internal.ILogMessageFormatter logMessageFormatter = ((messageFormatter != null) ? messageFormatter.Target : null) as global::NLog.Internal.ILogMessageFormatter;
					return logMessageFormatter != null && logMessageFormatter.HasProperties(this);
				}
				return false;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000027A4 File Offset: 0x000009A4
		public global::NLog.MessageTemplates.MessageTemplateParameters MessageTemplateParameters
		{
			get
			{
				if (this._properties != null && this._properties.MessageProperties.Count > 0)
				{
					return new global::NLog.MessageTemplates.MessageTemplateParameters(this._properties.MessageProperties, this._message, this._parameters);
				}
				return new global::NLog.MessageTemplates.MessageTemplateParameters(this._message, this._parameters);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000027FA File Offset: 0x000009FA
		[global::System.Obsolete("Use LogEventInfo.Properties instead.  Marked obsolete on NLog 2.0", true)]
		public global::System.Collections.IDictionary Context
		{
			get
			{
				return this.CreateOrUpdatePropertiesInternal(true, null).EventContext;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002809 File Offset: 0x00000A09
		public static global::NLog.LogEventInfo CreateNullEvent()
		{
			return new global::NLog.LogEventInfo(global::NLog.LogLevel.Off, string.Empty, string.Empty);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000281F File Offset: 0x00000A1F
		public static global::NLog.LogEventInfo Create(global::NLog.LogLevel logLevel, string loggerName, [global::System.ComponentModel.Localizable(false)] string message)
		{
			return new global::NLog.LogEventInfo(logLevel, loggerName, null, message, null);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000282B File Offset: 0x00000A2B
		public static global::NLog.LogEventInfo Create(global::NLog.LogLevel logLevel, string loggerName, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, object[] parameters)
		{
			return new global::NLog.LogEventInfo(logLevel, loggerName, formatProvider, message, parameters);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002838 File Offset: 0x00000A38
		public static global::NLog.LogEventInfo Create(global::NLog.LogLevel logLevel, string loggerName, global::System.IFormatProvider formatProvider, object message)
		{
			global::System.Exception ex = message as global::System.Exception;
			global::NLog.LogEventInfo logEventInfo;
			if (ex == null && (logEventInfo = (message as global::NLog.LogEventInfo)) != null)
			{
				logEventInfo.LoggerName = loggerName;
				logEventInfo.Level = logLevel;
				logEventInfo.FormatProvider = (formatProvider ?? logEventInfo.FormatProvider);
				return logEventInfo;
			}
			return new global::NLog.LogEventInfo(logLevel, loggerName, formatProvider, "{0}", new object[]
			{
				message
			}, ex);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002892 File Offset: 0x00000A92
		[global::System.Obsolete("use Create(LogLevel logLevel, string loggerName, Exception exception, IFormatProvider formatProvider, string message) instead. Marked obsolete before v4.3.11")]
		public static global::NLog.LogEventInfo Create(global::NLog.LogLevel logLevel, string loggerName, [global::System.ComponentModel.Localizable(false)] string message, global::System.Exception exception)
		{
			return new global::NLog.LogEventInfo(logLevel, loggerName, null, message, null, exception);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000289F File Offset: 0x00000A9F
		public static global::NLog.LogEventInfo Create(global::NLog.LogLevel logLevel, string loggerName, global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message)
		{
			return global::NLog.LogEventInfo.Create(logLevel, loggerName, exception, formatProvider, message, null);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000028AD File Offset: 0x00000AAD
		public static global::NLog.LogEventInfo Create(global::NLog.LogLevel logLevel, string loggerName, global::System.Exception exception, global::System.IFormatProvider formatProvider, [global::System.ComponentModel.Localizable(false)] string message, object[] parameters)
		{
			return new global::NLog.LogEventInfo(logLevel, loggerName, formatProvider, message, parameters, exception);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000028BC File Offset: 0x00000ABC
		public global::NLog.Common.AsyncLogEventInfo WithContinuation(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			return new global::NLog.Common.AsyncLogEventInfo(this, asyncContinuation);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000028C5 File Offset: 0x00000AC5
		public override string ToString()
		{
			return string.Format("Log Event: Logger='{0}' Level={1} Message='{2}' SequenceID={3}", new object[]
			{
				this.LoggerName,
				this.Level,
				this.FormattedMessage,
				this.SequenceID
			});
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002900 File Offset: 0x00000B00
		public void SetStackTrace(global::System.Diagnostics.StackTrace stackTrace, int userStackFrame)
		{
			this.GetCallSiteInformationInternal().SetStackTrace(stackTrace, userStackFrame, null);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002923 File Offset: 0x00000B23
		public void SetCallerInfo(string callerClassName, string callerMemberName, string callerFilePath, int callerLineNumber)
		{
			this.GetCallSiteInformationInternal().SetCallerInfo(callerClassName, callerMemberName, callerFilePath, callerLineNumber);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002938 File Offset: 0x00000B38
		internal void AddCachedLayoutValue(global::NLog.Layouts.Layout layout, object value)
		{
			if (this._layoutCache == null)
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Collections.Generic.IDictionary<global::NLog.Layouts.Layout, object>>(ref this._layoutCache, new global::System.Collections.Generic.Dictionary<global::NLog.Layouts.Layout, object>(), null);
			}
			global::System.Collections.Generic.IDictionary<global::NLog.Layouts.Layout, object> layoutCache = this._layoutCache;
			lock (layoutCache)
			{
				this._layoutCache[layout] = value;
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000299C File Offset: 0x00000B9C
		internal bool TryGetCachedLayoutValue(global::NLog.Layouts.Layout layout, out object value)
		{
			if (this._layoutCache == null)
			{
				value = null;
				return false;
			}
			global::System.Collections.Generic.IDictionary<global::NLog.Layouts.Layout, object> layoutCache = this._layoutCache;
			bool result;
			lock (layoutCache)
			{
				if (this._layoutCache.Count == 0)
				{
					value = null;
					result = false;
				}
				else
				{
					result = this._layoutCache.TryGetValue(layout, out value);
				}
			}
			return result;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002A08 File Offset: 0x00000C08
		private static bool NeedToPreformatMessage(object[] parameters)
		{
			if (parameters == null || parameters.Length == 0)
			{
				return false;
			}
			if (parameters.Length > 5)
			{
				return true;
			}
			for (int i = 0; i < parameters.Length; i++)
			{
				if (!global::NLog.LogEventInfo.IsSafeToDeferFormatting(parameters[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002A41 File Offset: 0x00000C41
		private static bool IsSafeToDeferFormatting(object value)
		{
			return global::System.Convert.GetTypeCode(value) != global::System.TypeCode.Object;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002A50 File Offset: 0x00000C50
		internal bool IsLogEventMutableSafe()
		{
			if (this.Exception != null || this._formattedMessage != null)
			{
				return false;
			}
			global::NLog.Internal.PropertiesDictionary propertiesDictionary = this.CreateOrUpdatePropertiesInternal(false, null);
			if (propertiesDictionary == null || propertiesDictionary.Count == 0)
			{
				return true;
			}
			if (propertiesDictionary.Count > 5)
			{
				return false;
			}
			int count = propertiesDictionary.Count;
			object[] parameters = this._parameters;
			return (count == ((parameters != null) ? new int?(parameters.Length) : null) && propertiesDictionary.Count == propertiesDictionary.MessageProperties.Count) || global::NLog.LogEventInfo.HasImmutableProperties(propertiesDictionary);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002AE4 File Offset: 0x00000CE4
		private static bool HasImmutableProperties(global::NLog.Internal.PropertiesDictionary properties)
		{
			if (properties.Count != properties.MessageProperties.Count)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<object, object> keyValuePair in properties)
				{
					if (!global::NLog.LogEventInfo.IsSafeToDeferFormatting(keyValuePair.Value))
					{
						return false;
					}
				}
				return true;
			}
			for (int i = 0; i < properties.MessageProperties.Count; i++)
			{
				if (!global::NLog.LogEventInfo.IsSafeToDeferFormatting(properties.MessageProperties[i].Value))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002B84 File Offset: 0x00000D84
		internal bool CanLogEventDeferMessageFormat()
		{
			if (this._formattedMessage != null)
			{
				return false;
			}
			if (this._parameters == null || this._parameters.Length == 0)
			{
				return false;
			}
			string message = this._message;
			return message != null && message.Length < 256 && this.MessageFormatter == global::NLog.Internal.LogMessageTemplateFormatter.DefaultAuto.MessageFormatter;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002BDE File Offset: 0x00000DDE
		private static string GetStringFormatMessageFormatter(global::NLog.LogEventInfo logEvent)
		{
			if (logEvent.Parameters == null || logEvent.Parameters.Length == 0)
			{
				return logEvent.Message;
			}
			return string.Format(logEvent.FormatProvider ?? global::System.Globalization.CultureInfo.CurrentCulture, logEvent.Message, logEvent.Parameters);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002C18 File Offset: 0x00000E18
		private void CalcFormattedMessage()
		{
			try
			{
				this._formattedMessage = this._messageFormatter(this);
			}
			catch (global::System.Exception ex)
			{
				this._formattedMessage = this.Message;
				global::NLog.Common.InternalLogger.Warn(ex, "Error when formatting a message.");
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002C6C File Offset: 0x00000E6C
		internal void AppendFormattedMessage(global::NLog.Internal.ILogMessageFormatter messageFormatter, global::System.Text.StringBuilder builder)
		{
			if (this._formattedMessage != null)
			{
				builder.Append(this._formattedMessage);
				return;
			}
			int length = builder.Length;
			try
			{
				messageFormatter.AppendFormattedMessage(this, builder);
			}
			catch (global::System.Exception ex)
			{
				builder.Length = length;
				builder.Append(this._message ?? string.Empty);
				global::NLog.Common.InternalLogger.Warn(ex, "Error when formatting a message.");
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002CE4 File Offset: 0x00000EE4
		private void ResetFormattedMessage(bool rebuildMessageTemplateParameters)
		{
			this._formattedMessage = null;
			if (rebuildMessageTemplateParameters && this.HasMessageTemplateParameters)
			{
				this.CalcFormattedMessage();
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002CFE File Offset: 0x00000EFE
		private bool ResetMessageTemplateParameters()
		{
			if (this._properties != null && this.HasMessageTemplateParameters)
			{
				this._properties.MessageProperties = null;
				return true;
			}
			return false;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002D20 File Offset: 0x00000F20
		internal static void SetDefaultMessageFormatter(bool? mode)
		{
			if (mode == true)
			{
				global::NLog.Common.InternalLogger.Info("Message Template Format always enabled");
				global::NLog.LogEventInfo.DefaultMessageFormatter = global::NLog.Internal.LogMessageTemplateFormatter.Default.MessageFormatter;
				return;
			}
			if (mode == false)
			{
				global::NLog.Common.InternalLogger.Info("Message Template String Format always enabled");
				global::NLog.LogEventInfo.DefaultMessageFormatter = global::NLog.LogEventInfo.StringFormatMessageFormatter;
				return;
			}
			global::NLog.Common.InternalLogger.Info("Message Template Auto Format enabled");
			global::NLog.LogEventInfo.DefaultMessageFormatter = global::NLog.Internal.LogMessageTemplateFormatter.DefaultAuto.MessageFormatter;
		}

		// Token: 0x04000002 RID: 2
		public static readonly global::System.DateTime ZeroDate = global::System.DateTime.UtcNow;

		// Token: 0x04000003 RID: 3
		internal static readonly global::NLog.LogMessageFormatter StringFormatMessageFormatter = new global::NLog.LogMessageFormatter(global::NLog.LogEventInfo.GetStringFormatMessageFormatter);

		// Token: 0x04000005 RID: 5
		private static int globalSequenceId;

		// Token: 0x04000006 RID: 6
		private string _formattedMessage;

		// Token: 0x04000007 RID: 7
		private string _message;

		// Token: 0x04000008 RID: 8
		private object[] _parameters;

		// Token: 0x04000009 RID: 9
		private global::System.IFormatProvider _formatProvider;

		// Token: 0x0400000A RID: 10
		private global::NLog.LogMessageFormatter _messageFormatter = global::NLog.LogEventInfo.DefaultMessageFormatter;

		// Token: 0x0400000B RID: 11
		private global::System.Collections.Generic.IDictionary<global::NLog.Layouts.Layout, object> _layoutCache;

		// Token: 0x0400000C RID: 12
		private global::NLog.Internal.PropertiesDictionary _properties;
	}
}
