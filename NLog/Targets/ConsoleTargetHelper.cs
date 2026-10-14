using System;
using System.IO;
using System.Text;
using NLog.Common;
using NLog.Internal;

namespace NLog.Targets
{
	// Token: 0x0200002D RID: 45
	internal static class ConsoleTargetHelper
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x0000A098 File Offset: 0x00008298
		public static bool IsConsoleAvailable(out string reason)
		{
			reason = string.Empty;
			try
			{
				if (!global::System.Environment.UserInteractive)
				{
					if (global::NLog.Internal.PlatformDetector.IsMono && global::System.Console.In is global::System.IO.StreamReader)
					{
						return true;
					}
					reason = "Environment.UserInteractive = False";
					return false;
				}
				else if (global::System.Console.OpenStandardInput(1) == global::System.IO.Stream.Null)
				{
					reason = "Console.OpenStandardInput = Null";
					return false;
				}
			}
			catch (global::System.Exception ex)
			{
				reason = string.Format("Unexpected exception: {0}:{1}", ex.GetType().Name, ex.Message);
				global::NLog.Common.InternalLogger.Warn(ex, "Failed to detect whether console is available.");
				return false;
			}
			return true;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000A130 File Offset: 0x00008330
		public static global::System.Text.Encoding GetConsoleOutputEncoding(global::System.Text.Encoding currentEncoding, bool isInitialized, bool pauseLogging)
		{
			if (currentEncoding != null)
			{
				return currentEncoding;
			}
			string text;
			if ((isInitialized && !pauseLogging) || global::NLog.Targets.ConsoleTargetHelper.IsConsoleAvailable(out text))
			{
				return global::System.Console.OutputEncoding;
			}
			return global::System.Text.Encoding.Default;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000A15C File Offset: 0x0000835C
		public static bool SetConsoleOutputEncoding(global::System.Text.Encoding newEncoding, bool isInitialized, bool pauseLogging)
		{
			if (!isInitialized)
			{
				return true;
			}
			if (!pauseLogging)
			{
				global::System.Console.OutputEncoding = newEncoding;
				return true;
			}
			return false;
		}
	}
}
