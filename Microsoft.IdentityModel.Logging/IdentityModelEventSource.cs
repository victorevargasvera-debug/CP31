using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection;

namespace Microsoft.IdentityModel.Logging
{
	// Token: 0x02000002 RID: 2
	[global::System.Diagnostics.Tracing.EventSource(Name = "Microsoft.IdentityModel.EventSource")]
	public class IdentityModelEventSource : global::System.Diagnostics.Tracing.EventSource
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		static IdentityModelEventSource()
		{
			global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger = new global::Microsoft.IdentityModel.Logging.IdentityModelEventSource();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020A5 File Offset: 0x000002A5
		private IdentityModelEventSource()
		{
			this.LogLevel = global::System.Diagnostics.Tracing.EventLevel.Warning;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020B4 File Offset: 0x000002B4
		public static global::Microsoft.IdentityModel.Logging.IdentityModelEventSource Logger { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020BB File Offset: 0x000002BB
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020C2 File Offset: 0x000002C2
		public static bool ShowPII { get; set; } = false;

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020CA File Offset: 0x000002CA
		public static string HiddenPIIString { get; } = "[PII is hidden]";

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020D1 File Offset: 0x000002D1
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000020D8 File Offset: 0x000002D8
		public static bool HeaderWritten { get; set; } = false;

		// Token: 0x06000009 RID: 9 RVA: 0x000020E0 File Offset: 0x000002E0
		[global::System.Diagnostics.Tracing.Event(6, Level = global::System.Diagnostics.Tracing.EventLevel.LogAlways)]
		public void WriteAlways(string message)
		{
			if (base.IsEnabled())
			{
				message = this.PrepareMessage(global::System.Diagnostics.Tracing.EventLevel.LogAlways, message, new object[0]);
				base.WriteEvent(6, message);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002102 File Offset: 0x00000302
		[global::System.Diagnostics.Tracing.NonEvent]
		public void WriteAlways(string message, params object[] args)
		{
			if (base.IsEnabled())
			{
				if (args != null)
				{
					this.WriteAlways(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant(message, args));
					return;
				}
				this.WriteAlways(message);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002124 File Offset: 0x00000324
		[global::System.Diagnostics.Tracing.Event(1, Level = global::System.Diagnostics.Tracing.EventLevel.Verbose)]
		public void WriteVerbose(string message)
		{
			if (base.IsEnabled() && this.LogLevel >= global::System.Diagnostics.Tracing.EventLevel.Verbose)
			{
				message = this.PrepareMessage(global::System.Diagnostics.Tracing.EventLevel.Verbose, message, new object[0]);
				base.WriteEvent(1, message);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000214F File Offset: 0x0000034F
		[global::System.Diagnostics.Tracing.NonEvent]
		public void WriteVerbose(string message, params object[] args)
		{
			if (base.IsEnabled() && this.LogLevel >= global::System.Diagnostics.Tracing.EventLevel.Verbose)
			{
				if (args != null)
				{
					this.WriteVerbose(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant(message, args));
					return;
				}
				this.WriteVerbose(message);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000217A File Offset: 0x0000037A
		[global::System.Diagnostics.Tracing.Event(2, Level = global::System.Diagnostics.Tracing.EventLevel.Informational)]
		public void WriteInformation(string message)
		{
			if (base.IsEnabled() && this.LogLevel >= global::System.Diagnostics.Tracing.EventLevel.Informational)
			{
				message = this.PrepareMessage(global::System.Diagnostics.Tracing.EventLevel.Informational, message, new object[0]);
				base.WriteEvent(2, message);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021A5 File Offset: 0x000003A5
		[global::System.Diagnostics.Tracing.NonEvent]
		public void WriteInformation(string message, params object[] args)
		{
			if (base.IsEnabled() && this.LogLevel >= global::System.Diagnostics.Tracing.EventLevel.Informational)
			{
				if (args != null)
				{
					this.WriteInformation(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant(message, args));
					return;
				}
				this.WriteInformation(message);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021D0 File Offset: 0x000003D0
		[global::System.Diagnostics.Tracing.Event(3, Level = global::System.Diagnostics.Tracing.EventLevel.Warning)]
		public void WriteWarning(string message)
		{
			if (base.IsEnabled() && this.LogLevel >= global::System.Diagnostics.Tracing.EventLevel.Warning)
			{
				message = this.PrepareMessage(global::System.Diagnostics.Tracing.EventLevel.Warning, message, new object[0]);
				base.WriteEvent(3, message);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021FB File Offset: 0x000003FB
		[global::System.Diagnostics.Tracing.NonEvent]
		public void WriteWarning(string message, params object[] args)
		{
			if (args != null)
			{
				this.WriteWarning(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant(message, args));
				return;
			}
			this.WriteWarning(message);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002215 File Offset: 0x00000415
		[global::System.Diagnostics.Tracing.Event(4, Level = global::System.Diagnostics.Tracing.EventLevel.Error)]
		public void WriteError(string message)
		{
			if (base.IsEnabled() && this.LogLevel >= global::System.Diagnostics.Tracing.EventLevel.Error)
			{
				message = this.PrepareMessage(global::System.Diagnostics.Tracing.EventLevel.Error, message, new object[0]);
				base.WriteEvent(4, message);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002240 File Offset: 0x00000440
		[global::System.Diagnostics.Tracing.NonEvent]
		public void WriteError(string message, params object[] args)
		{
			if (base.IsEnabled() && this.LogLevel >= global::System.Diagnostics.Tracing.EventLevel.Error)
			{
				if (args != null)
				{
					this.WriteError(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant(message, args));
					return;
				}
				this.WriteError(message);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000226B File Offset: 0x0000046B
		[global::System.Diagnostics.Tracing.Event(5, Level = global::System.Diagnostics.Tracing.EventLevel.Critical)]
		public void WriteCritical(string message)
		{
			if (base.IsEnabled() && this.LogLevel >= global::System.Diagnostics.Tracing.EventLevel.Critical)
			{
				message = this.PrepareMessage(global::System.Diagnostics.Tracing.EventLevel.Critical, message, new object[0]);
				base.WriteEvent(5, message);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002296 File Offset: 0x00000496
		[global::System.Diagnostics.Tracing.NonEvent]
		public void WriteCritical(string message, params object[] args)
		{
			if (base.IsEnabled() && this.LogLevel >= global::System.Diagnostics.Tracing.EventLevel.Critical)
			{
				if (args != null)
				{
					this.WriteCritical(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant(message, args));
					return;
				}
				this.WriteCritical(message);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022C1 File Offset: 0x000004C1
		[global::System.Diagnostics.Tracing.NonEvent]
		public void Write(global::System.Diagnostics.Tracing.EventLevel level, global::System.Exception innerException, string message)
		{
			this.Write(level, innerException, message, null);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000022D0 File Offset: 0x000004D0
		[global::System.Diagnostics.Tracing.NonEvent]
		public void Write(global::System.Diagnostics.Tracing.EventLevel level, global::System.Exception innerException, string message, params object[] args)
		{
			if (innerException != null)
			{
				if (!global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII && !global::Microsoft.IdentityModel.Logging.LogHelper.IsCustomException(innerException))
				{
					message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Message: {0}, InnerException: {1}", new object[]
					{
						message,
						innerException.GetType()
					});
				}
				else
				{
					message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Message: {0}, InnerException: {1}", new object[]
					{
						message,
						innerException.Message
					});
				}
			}
			if (!global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.HeaderWritten)
			{
				this.WriteAlways(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Microsoft.IdentityModel.Logging.IdentityModelEventSource._versionLogMessage, new object[]
				{
					typeof(global::Microsoft.IdentityModel.Logging.IdentityModelEventSource).GetTypeInfo().Assembly.GetName().Version.ToString()
				}));
				this.WriteAlways(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Microsoft.IdentityModel.Logging.IdentityModelEventSource._dateLogMessage, new object[]
				{
					global::System.DateTime.UtcNow
				}));
				if (global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII)
				{
					this.WriteAlways(global::Microsoft.IdentityModel.Logging.IdentityModelEventSource._piiOnLogMessage);
				}
				else
				{
					this.WriteAlways(global::Microsoft.IdentityModel.Logging.IdentityModelEventSource._piiOffLogMessage);
				}
				global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.HeaderWritten = true;
			}
			switch (level)
			{
			case global::System.Diagnostics.Tracing.EventLevel.LogAlways:
				this.WriteAlways(message, args);
				return;
			case global::System.Diagnostics.Tracing.EventLevel.Critical:
				this.WriteCritical(message, args);
				return;
			case global::System.Diagnostics.Tracing.EventLevel.Error:
				this.WriteError(message, args);
				return;
			case global::System.Diagnostics.Tracing.EventLevel.Warning:
				this.WriteWarning(message, args);
				return;
			case global::System.Diagnostics.Tracing.EventLevel.Informational:
				this.WriteInformation(message, args);
				return;
			case global::System.Diagnostics.Tracing.EventLevel.Verbose:
				this.WriteVerbose(message, args);
				return;
			default:
				this.WriteError(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("MIML10002: Unknown log level: {0}.", new object[]
				{
					level
				}));
				this.WriteError(message, args);
				return;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002455 File Offset: 0x00000655
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000245D File Offset: 0x0000065D
		public global::System.Diagnostics.Tracing.EventLevel LogLevel { get; set; }

		// Token: 0x06000019 RID: 25 RVA: 0x00002468 File Offset: 0x00000668
		private string PrepareMessage(global::System.Diagnostics.Tracing.EventLevel level, string message, params object[] args)
		{
			if (message == null)
			{
				return string.Empty;
			}
			try
			{
				if (args != null && args.Length != 0)
				{
					return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "[{0}]{1} {2}", new object[]
					{
						level.ToString(),
						global::System.DateTime.UtcNow.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
						global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant(message, args)
					});
				}
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "[{0}]{1} {2}", new object[]
				{
					level.ToString(),
					global::System.DateTime.UtcNow.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
					message
				});
			}
			catch
			{
			}
			string result;
			try
			{
				result = global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("[{0}]{1} {2}", new object[]
				{
					level.ToString(),
					global::System.DateTime.UtcNow.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
					message
				});
			}
			catch (global::System.Exception)
			{
				result = level + global::System.DateTime.UtcNow.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + message;
			}
			return result;
		}

		// Token: 0x04000005 RID: 5
		private static string _versionLogMessage = "Library version: {0}.";

		// Token: 0x04000006 RID: 6
		private static string _dateLogMessage = "Date: {0}.";

		// Token: 0x04000007 RID: 7
		private static string _piiOffLogMessage = "PII (personally identifiable information) logging is currently turned off. Set IdentityModelEventSource.ShowPII to 'true' to view the full details of exceptions.";

		// Token: 0x04000008 RID: 8
		private static string _piiOnLogMessage = "PII (personally identifiable information) logging is currently turned on. Set IdentityModelEventSource.ShowPII to 'false' to hide PII from log messages.";
	}
}
