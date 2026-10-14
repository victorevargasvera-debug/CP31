using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Gibraltar
{
	// Token: 0x020000A6 RID: 166
	internal static class CommonCentralLogic
	{
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0000C300 File Offset: 0x0000A500
		public static bool IsMonoRuntime
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.g_MonoRuntime;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0000C308 File Offset: 0x0000A508
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x0000C310 File Offset: 0x0000A510
		public static bool SilentMode
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.s_SilentMode;
			}
			set
			{
				global::Gibraltar.CommonCentralLogic.s_SilentMode = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x0000C318 File Offset: 0x0000A518
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x0000C324 File Offset: 0x0000A524
		public static bool BreakPointEnable
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.s_BreakPointEnable;
			}
			set
			{
				global::Gibraltar.CommonCentralLogic.s_BreakPointEnable = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0000C330 File Offset: 0x0000A530
		public static bool IsSessionEnding
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.g_SessionEnding;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0000C33C File Offset: 0x0000A53C
		public static bool IsSessionEnded
		{
			get
			{
				return global::Gibraltar.CommonCentralLogic.g_SessionEnded;
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0000C348 File Offset: 0x0000A548
		public static void DeclareSessionIsEnding()
		{
			global::Gibraltar.CommonCentralLogic.g_SessionEnding = true;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0000C354 File Offset: 0x0000A554
		public static void DeclareSessionHasEnded()
		{
			global::Gibraltar.CommonCentralLogic.g_SessionEnding = true;
			global::Gibraltar.CommonCentralLogic.g_SessionEnded = true;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000C368 File Offset: 0x0000A568
		[global::System.Diagnostics.Conditional("DEBUG")]
		public static void DebugBreak()
		{
			if (global::Gibraltar.CommonCentralLogic.s_BreakPointEnable && global::System.Diagnostics.Debugger.IsAttached)
			{
				global::System.Diagnostics.Debugger.Break();
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000C388 File Offset: 0x0000A588
		public static string CalculateWebUrl(string pageFileName, string product, string application, global::System.Version version)
		{
			return string.Format("http://www.gibraltarsoftware.com/external/{0}?productName={1}&applicationName={2}&majorVer={3}&minorVer={4}&build={5}&revisionVer={6}", new object[]
			{
				pageFileName,
				product,
				application,
				version.Major,
				version.Minor,
				version.Build,
				version.Revision
			});
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		public static void DisplayWebPage(string pageFileName, string product, string application, global::System.Version version)
		{
			string text = global::Gibraltar.CommonCentralLogic.CalculateWebUrl(pageFileName, product, application, version);
			try
			{
				global::System.Diagnostics.Process.Start(text);
			}
			catch (global::System.Exception)
			{
				global::System.Windows.Forms.MessageBox.Show("Sorry, we couldn't directly open the web page on your system.  If you'd like, open a browser and go to:\r\n" + text, "Unable to open web browser", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000C444 File Offset: 0x0000A644
		private static bool CheckForMono()
		{
			return global::System.Type.GetType("Mono.Runtime") != null;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0000C454 File Offset: 0x0000A654
		public static int FindMessageSource(int skipFrames, bool trustSkipFrames, global::System.Exception exception, out string className, out string methodName, out string fileName, out int lineNumber)
		{
			int result = -1;
			try
			{
				global::System.Diagnostics.StackTrace stackTrace = (exception == null) ? new global::System.Diagnostics.StackTrace(skipFrames + 1, true) : new global::System.Diagnostics.StackTrace(exception, skipFrames, true);
				global::System.Diagnostics.StackFrame stackFrame = null;
				global::System.Diagnostics.StackFrame stackFrame2 = null;
				global::System.Reflection.MethodBase methodBase = null;
				int num = 0;
				do
				{
					try
					{
						global::System.Diagnostics.StackFrame frame = stackTrace.GetFrame(num);
						num++;
						if (frame == null)
						{
							break;
						}
						methodBase = frame.GetMethod();
						if (methodBase == null)
						{
							break;
						}
						string name = methodBase.Module.Name;
						if (name.Equals("System.dll") || name.Equals("mscorlib.dll"))
						{
							if (stackFrame2 == null)
							{
								stackFrame2 = frame;
							}
						}
						else
						{
							stackFrame = frame;
							if (trustSkipFrames || stackFrame2 != null)
							{
								break;
							}
							if (!name.Equals("Gibraltar.Agent.dll") && !name.Equals("Gibraltar.Core.dll"))
							{
								break;
							}
						}
					}
					catch
					{
						break;
					}
					methodBase = null;
				}
				while (num <= 200);
				if (stackFrame == null || methodBase == null)
				{
					stackFrame = stackTrace.GetFrame(0);
					result = 0;
				}
				else
				{
					result = num;
				}
				methodBase = ((stackFrame == null) ? null : stackFrame.GetMethod());
				if (methodBase == null)
				{
					stackFrame = stackFrame2;
					methodBase = ((stackFrame == null) ? null : stackFrame.GetMethod());
				}
				if (methodBase != null)
				{
					className = ((methodBase.DeclaringType == null) ? null : methodBase.DeclaringType.FullName);
					methodName = methodBase.Name;
					try
					{
						fileName = stackFrame.GetFileName();
						if (!string.IsNullOrEmpty(fileName))
						{
							lineNumber = stackFrame.GetFileLineNumber();
						}
						else
						{
							lineNumber = 0;
						}
						goto IL_1B9;
					}
					catch
					{
						fileName = null;
						lineNumber = 0;
						goto IL_1B9;
					}
				}
				methodName = null;
				className = null;
				fileName = null;
				lineNumber = 0;
				IL_1B9:;
			}
			catch
			{
				methodName = null;
				className = null;
				fileName = null;
				lineNumber = 0;
			}
			return result;
		}

		// Token: 0x0400012B RID: 299
		private static bool g_MonoRuntime = global::Gibraltar.CommonCentralLogic.CheckForMono();

		// Token: 0x0400012C RID: 300
		private static bool s_SilentMode = false;

		// Token: 0x0400012D RID: 301
		private static volatile bool s_BreakPointEnable = false;

		// Token: 0x0400012E RID: 302
		private static volatile bool g_SessionEnding;

		// Token: 0x0400012F RID: 303
		private static volatile bool g_SessionEnded;
	}
}
