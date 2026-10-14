using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;

namespace Microsoft.IdentityModel.Logging
{
	// Token: 0x02000003 RID: 3
	public class LogHelper
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002590 File Offset: 0x00000790
		public static global::System.ArgumentNullException LogArgumentNullException(string argument)
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentException<global::System.ArgumentNullException>(global::System.Diagnostics.Tracing.EventLevel.Error, argument, "IDX10000: The parameter '{0}' cannot be a 'null' or an empty object.", new object[]
			{
				argument
			});
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025A8 File Offset: 0x000007A8
		public static T LogException<T>(string message) where T : global::System.Exception
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogException<T>(global::System.Diagnostics.Tracing.EventLevel.Error, null, message, null);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025B3 File Offset: 0x000007B3
		public static T LogArgumentException<T>(string argumentName, string message) where T : global::System.ArgumentException
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentException<T>(global::System.Diagnostics.Tracing.EventLevel.Error, argumentName, null, message, null);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000025BF File Offset: 0x000007BF
		public static T LogException<T>(string format, params object[] args) where T : global::System.Exception
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogException<T>(global::System.Diagnostics.Tracing.EventLevel.Error, null, format, args);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000025CA File Offset: 0x000007CA
		public static T LogArgumentException<T>(string argumentName, string format, params object[] args) where T : global::System.ArgumentException
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentException<T>(global::System.Diagnostics.Tracing.EventLevel.Error, argumentName, null, format, args);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000025D6 File Offset: 0x000007D6
		public static T LogException<T>(global::System.Exception innerException, string message) where T : global::System.Exception
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogException<T>(global::System.Diagnostics.Tracing.EventLevel.Error, innerException, message, null);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000025E1 File Offset: 0x000007E1
		public static T LogArgumentException<T>(string argumentName, global::System.Exception innerException, string message) where T : global::System.ArgumentException
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentException<T>(global::System.Diagnostics.Tracing.EventLevel.Error, argumentName, innerException, message, null);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000025ED File Offset: 0x000007ED
		public static T LogException<T>(global::System.Exception innerException, string format, params object[] args) where T : global::System.Exception
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogException<T>(global::System.Diagnostics.Tracing.EventLevel.Error, innerException, format, args);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000025F8 File Offset: 0x000007F8
		public static T LogArgumentException<T>(string argumentName, global::System.Exception innerException, string format, params object[] args) where T : global::System.ArgumentException
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentException<T>(global::System.Diagnostics.Tracing.EventLevel.Error, argumentName, innerException, format, args);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002604 File Offset: 0x00000804
		public static T LogException<T>(global::System.Diagnostics.Tracing.EventLevel eventLevel, string message) where T : global::System.Exception
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogException<T>(eventLevel, null, message, null);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000260F File Offset: 0x0000080F
		public static T LogArgumentException<T>(global::System.Diagnostics.Tracing.EventLevel eventLevel, string argumentName, string message) where T : global::System.ArgumentException
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentException<T>(eventLevel, argumentName, null, message, null);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000261B File Offset: 0x0000081B
		public static T LogException<T>(global::System.Diagnostics.Tracing.EventLevel eventLevel, string format, params object[] args) where T : global::System.Exception
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogException<T>(eventLevel, null, format, args);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002626 File Offset: 0x00000826
		public static T LogArgumentException<T>(global::System.Diagnostics.Tracing.EventLevel eventLevel, string argumentName, string format, params object[] args) where T : global::System.ArgumentException
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentException<T>(eventLevel, argumentName, null, format, args);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002632 File Offset: 0x00000832
		public static T LogException<T>(global::System.Diagnostics.Tracing.EventLevel eventLevel, global::System.Exception innerException, string message) where T : global::System.Exception
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogException<T>(eventLevel, innerException, message, null);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000263D File Offset: 0x0000083D
		public static T LogArgumentException<T>(global::System.Diagnostics.Tracing.EventLevel eventLevel, string argumentName, global::System.Exception innerException, string message) where T : global::System.ArgumentException
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentException<T>(eventLevel, argumentName, innerException, message, null);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002649 File Offset: 0x00000849
		public static T LogException<T>(global::System.Diagnostics.Tracing.EventLevel eventLevel, global::System.Exception innerException, string format, params object[] args) where T : global::System.Exception
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionImpl<T>(eventLevel, null, innerException, format, args);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002655 File Offset: 0x00000855
		public static T LogArgumentException<T>(global::System.Diagnostics.Tracing.EventLevel eventLevel, string argumentName, global::System.Exception innerException, string format, params object[] args) where T : global::System.ArgumentException
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionImpl<T>(eventLevel, argumentName, innerException, format, args);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002662 File Offset: 0x00000862
		public static global::System.Exception LogExceptionMessage(global::System.Exception exception)
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(global::System.Diagnostics.Tracing.EventLevel.Error, exception);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000266B File Offset: 0x0000086B
		public static global::System.Exception LogExceptionMessage(global::System.Diagnostics.Tracing.EventLevel eventLevel, global::System.Exception exception)
		{
			if (global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.IsEnabled() && global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.LogLevel >= eventLevel)
			{
				global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.Write(eventLevel, exception.InnerException, exception.Message);
			}
			return exception;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000269E File Offset: 0x0000089E
		public static void LogInformation(string message, params object[] args)
		{
			if (global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.IsEnabled())
			{
				global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.WriteInformation(message, args);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000026B8 File Offset: 0x000008B8
		public static void LogVerbose(string message, params object[] args)
		{
			if (global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.IsEnabled())
			{
				global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.WriteVerbose(message, args);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000026D2 File Offset: 0x000008D2
		public static void LogWarning(string message, params object[] args)
		{
			if (global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.IsEnabled())
			{
				global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.WriteWarning(message, args);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000026EC File Offset: 0x000008EC
		private static T LogExceptionImpl<T>(global::System.Diagnostics.Tracing.EventLevel eventLevel, string argumentName, global::System.Exception innerException, string format, params object[] args) where T : global::System.Exception
		{
			string text;
			if (args != null)
			{
				text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args);
			}
			else
			{
				text = format;
			}
			if (global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.IsEnabled() && global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.LogLevel >= eventLevel)
			{
				global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.Logger.Write(eventLevel, innerException, text);
			}
			if (innerException != null)
			{
				if (string.IsNullOrEmpty(argumentName))
				{
					return (T)((object)global::System.Activator.CreateInstance(typeof(T), new object[]
					{
						text,
						innerException
					}));
				}
				return (T)((object)global::System.Activator.CreateInstance(typeof(T), new object[]
				{
					argumentName,
					text,
					innerException
				}));
			}
			else
			{
				if (string.IsNullOrEmpty(argumentName))
				{
					return (T)((object)global::System.Activator.CreateInstance(typeof(T), new object[]
					{
						text
					}));
				}
				return (T)((object)global::System.Activator.CreateInstance(typeof(T), new object[]
				{
					argumentName,
					text
				}));
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000027D8 File Offset: 0x000009D8
		public static string FormatInvariant(string format, params object[] args)
		{
			if (!global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII)
			{
				global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
				object[] args2 = args.Select(new global::System.Func<object, string>(global::Microsoft.IdentityModel.Logging.LogHelper.RemovePII)).ToArray<string>();
				return string.Format(invariantCulture, format, args2);
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002820 File Offset: 0x00000A20
		private static string RemovePII(object arg)
		{
			if (!(arg is global::System.Exception))
			{
				return global::Microsoft.IdentityModel.Logging.IdentityModelEventSource.HiddenPIIString;
			}
			global::System.Exception ex = arg as global::System.Exception;
			if (global::Microsoft.IdentityModel.Logging.LogHelper.IsCustomException(ex))
			{
				return ex.ToString();
			}
			return ex.GetType().ToString();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000285C File Offset: 0x00000A5C
		internal static bool IsCustomException(global::System.Exception ex)
		{
			return global::Microsoft.IdentityModel.Logging.LogHelper.CustomExceptionTypePrefixes.Exists((string e) => ex.GetType().FullName.Contains(e));
		}

		// Token: 0x0400000A RID: 10
		private static readonly global::System.Collections.Generic.List<string> CustomExceptionTypePrefixes = new global::System.Collections.Generic.List<string>
		{
			"Microsoft.IdentityModel.Protocols",
			"Microsoft.IdentityModel.Tokens.SecurityToken",
			"Microsoft.IdentityModel.Tokens.Saml",
			"Microsoft.IdentityModel.Xml"
		};
	}
}
