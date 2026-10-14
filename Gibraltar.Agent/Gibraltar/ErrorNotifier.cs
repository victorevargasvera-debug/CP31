using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Gibraltar
{
	// Token: 0x020000A9 RID: 169
	internal static class ErrorNotifier
	{
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000701 RID: 1793 RVA: 0x0000C75C File Offset: 0x0000A95C
		// (remove) Token: 0x06000702 RID: 1794 RVA: 0x0000C794 File Offset: 0x0000A994
		public static event global::System.EventHandler<global::Gibraltar.ErrorNotificationEventArgs> Error;

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0000C7CC File Offset: 0x0000A9CC
		public static global::System.Exception LastException
		{
			get
			{
				return global::Gibraltar.ErrorNotifier.s_LastException;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		public static int ErrorCount
		{
			get
			{
				return global::Gibraltar.ErrorNotifier.s_ErrorCount;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		public static int MaxErrorCount
		{
			get
			{
				return global::Gibraltar.ErrorNotifier.s_MaxErrorCount;
			}
			set
			{
				global::Gibraltar.ErrorNotifier.s_MaxErrorCount = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		public static global::Gibraltar.ExceptionPolicy Policy
		{
			get
			{
				return global::Gibraltar.ErrorNotifier.s_Policy;
			}
			set
			{
				global::Gibraltar.ErrorNotifier.s_Policy = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x0000C7FC File Offset: 0x0000A9FC
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x0000C804 File Offset: 0x0000AA04
		public static bool DisableLogging
		{
			get
			{
				return global::Gibraltar.ErrorNotifier.s_DisableLogging;
			}
			set
			{
				global::Gibraltar.ErrorNotifier.s_DisableLogging = value;
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0000C80C File Offset: 0x0000AA0C
		public static void Notify(object sender, global::System.Exception exception)
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0000C810 File Offset: 0x0000AA10
		private static void LogApplicationError(global::System.Exception exception, bool disableLogging)
		{
			object obj = global::Gibraltar.ErrorNotifier.s_SyncObject;
			lock (obj)
			{
				if (global::Gibraltar.ErrorNotifier.s_ReportingError)
				{
					global::Gibraltar.ErrorNotifier.s_DisableLogging = true;
				}
				else
				{
					try
					{
						global::Gibraltar.ErrorNotifier.s_ReportingError = true;
						global::Gibraltar.ErrorNotifier.WriteTraceMessage(exception.Message, exception);
						if (disableLogging)
						{
							global::Gibraltar.ErrorNotifier.WriteTraceMessage("Disabling logging after " + global::Gibraltar.ErrorNotifier.s_MaxErrorCount + " errors.", null);
							global::Gibraltar.ErrorNotifier.s_DisableLogging = true;
						}
					}
					finally
					{
						global::Gibraltar.ErrorNotifier.s_ReportingError = false;
					}
				}
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		private static void WriteTraceMessage(string message, global::System.Exception exception)
		{
			message = "LOUPE ERROR:" + message;
			try
			{
				string machineName = global::System.Environment.MachineName;
				new global::System.Diagnostics.EventLog("Application", machineName)
				{
					Source = "Gibraltar"
				}.WriteEntry(message, global::System.Diagnostics.EventLogEntryType.Error);
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
			try
			{
				global::System.Console.Error.WriteLine(message);
			}
			catch (global::System.Exception obj2)
			{
				global::System.GC.KeepAlive(obj2);
			}
			try
			{
				global::System.Diagnostics.Trace.TraceError(message, new object[]
				{
					exception
				});
			}
			catch (global::System.Exception obj3)
			{
				global::System.GC.KeepAlive(obj3);
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0000C95C File Offset: 0x0000AB5C
		public static string SafeFormat(global::System.IFormatProvider formatProvider, string format, params object[] args)
		{
			if (args == null || args.Length == 0)
			{
				return format ?? string.Empty;
			}
			global::System.Exception ex = null;
			string text;
			if (format == null || format.Length > 0)
			{
				try
				{
					text = string.Format(formatProvider, format, args);
					goto IL_48;
				}
				catch (global::System.Exception ex)
				{
					text = null;
					goto IL_48;
				}
			}
			text = null;
			IL_48:
			if (text == null)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(format ?? string.Empty);
				global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
				string text2 = global::Gibraltar.ErrorNotifier.ReverseEscapes(format);
				if (string.IsNullOrEmpty(format))
				{
					stringBuilder.Append("\r\n");
				}
				else
				{
					char c = format[format.Length - 1];
					if (c != '\n' && c != '\r')
					{
						stringBuilder.Append("\r\n");
					}
				}
				if (ex != null)
				{
					stringBuilder2.AppendFormat("\r\n\r\n\r\nError expanding message format with {0} args supplied:\r\nException = ", args.Length);
					stringBuilder2.Append(global::Gibraltar.ErrorNotifier.SafeToString(formatProvider, ex, false));
					stringBuilder2.AppendFormat(formatProvider, "\r\nFormat string = {0}", new object[]
					{
						text2
					});
				}
				for (int i = 0; i < args.Length; i++)
				{
					object obj = args[i];
					stringBuilder.AppendFormat(formatProvider, "\r\nValue #{0}: {1}", new object[]
					{
						i,
						global::Gibraltar.ErrorNotifier.SafeToString(formatProvider, obj, false)
					});
					if (ex != null)
					{
						if (obj == null)
						{
							stringBuilder2.AppendFormat(formatProvider, "\r\nargs[{0}] {1}", new object[]
							{
								i,
								global::Gibraltar.ErrorNotifier.SafeToString(formatProvider, obj, true)
							});
						}
						else
						{
							string fullName = obj.GetType().FullName;
							stringBuilder2.AppendFormat(formatProvider, "\r\nargs[{0}] ({1}) = {2}", new object[]
							{
								i,
								fullName,
								global::Gibraltar.ErrorNotifier.SafeToString(formatProvider, obj, true)
							});
						}
					}
				}
				stringBuilder.Append(stringBuilder2);
				text = stringBuilder.ToString();
			}
			return text;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0000CB44 File Offset: 0x0000AD44
		private static global::System.Collections.Generic.Dictionary<char, string> InitEscapeMap()
		{
			int num = global::Gibraltar.ErrorNotifier.ResolvedEscapes.Length;
			global::System.Collections.Generic.Dictionary<char, string> dictionary = new global::System.Collections.Generic.Dictionary<char, string>(num);
			for (int i = 0; i < num; i++)
			{
				dictionary[global::Gibraltar.ErrorNotifier.ResolvedEscapes[i]] = global::Gibraltar.ErrorNotifier.LiteralEscapes[i];
			}
			return dictionary;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		private static string ReverseEscapes(string format)
		{
			if (format == null)
			{
				return "(null)";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("\"");
			int num;
			for (int i = 0; i < format.Length; i = num + 1)
			{
				string value = null;
				num = format.IndexOfAny(global::Gibraltar.ErrorNotifier.ResolvedEscapes, i);
				if (num < 0)
				{
					num = format.Length;
				}
				else
				{
					char c = format[num];
					if (!global::Gibraltar.ErrorNotifier.EscapeMap.TryGetValue(c, out value))
					{
						value = new string(c, 1);
					}
				}
				int num2 = num - i;
				if (num2 >= 0)
				{
					stringBuilder.Append(format, i, num2);
				}
				if (!string.IsNullOrEmpty(value))
				{
					stringBuilder.Append(value);
				}
			}
			stringBuilder.Append("\"");
			return stringBuilder.ToString();
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		private static string SafeToString(global::System.IFormatProvider formatProvider, object forDisplay, bool reverseEscapes)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Exception ex = forDisplay as global::System.Exception;
			global::System.Exception ex2 = null;
			try
			{
				if (reverseEscapes && (forDisplay == null || forDisplay.GetType() == typeof(string)))
				{
					stringBuilder.Append(global::Gibraltar.ErrorNotifier.ReverseEscapes((string)forDisplay));
				}
				else if (ex == null)
				{
					stringBuilder.AppendFormat(formatProvider, "{0}", new object[]
					{
						forDisplay
					});
				}
				else
				{
					stringBuilder.AppendFormat(formatProvider, "{0}\r\nException Message ", new object[]
					{
						ex.GetType().FullName
					});
					stringBuilder.AppendFormat(formatProvider, "= {0}", new object[]
					{
						ex.Message
					});
				}
			}
			catch (global::System.Exception ex2)
			{
			}
			if (ex2 != null)
			{
				try
				{
					stringBuilder.AppendFormat(formatProvider, "<<<{0} error converting to string>>> : ", new object[]
					{
						ex2.GetType().FullName
					});
					stringBuilder.Append(ex2.Message);
				}
				catch
				{
					stringBuilder.Append("<<<Error accessing exception message>>>");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000133 RID: 307
		private static bool s_ReportingError;

		// Token: 0x04000134 RID: 308
		private static global::System.Exception s_LastException;

		// Token: 0x04000135 RID: 309
		private static int s_ErrorCount;

		// Token: 0x04000136 RID: 310
		private static int s_MaxErrorCount = 100;

		// Token: 0x04000137 RID: 311
		private static global::Gibraltar.ExceptionPolicy s_Policy = global::Gibraltar.ExceptionPolicy.RaiseNoExceptions;

		// Token: 0x04000138 RID: 312
		private static bool s_DisableLogging = true;

		// Token: 0x04000139 RID: 313
		private static readonly object s_SyncObject = new object();

		// Token: 0x0400013A RID: 314
		public const string GibraltarErrorPrefix = "LOUPE ERROR:";

		// Token: 0x0400013B RID: 315
		private static readonly char[] ResolvedEscapes = new char[]
		{
			'\r',
			'\n',
			'\t',
			'"',
			'\\'
		};

		// Token: 0x0400013C RID: 316
		private static readonly string[] LiteralEscapes = new string[]
		{
			"\\r",
			"\\n",
			"\\t",
			"\\\"",
			"\\\\"
		};

		// Token: 0x0400013D RID: 317
		private static readonly global::System.Collections.Generic.Dictionary<char, string> EscapeMap = global::Gibraltar.ErrorNotifier.InitEscapeMap();
	}
}
