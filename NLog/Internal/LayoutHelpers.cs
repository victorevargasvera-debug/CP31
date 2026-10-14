using System;
using System.Globalization;
using NLog.Common;
using NLog.Layouts;

namespace NLog.Internal
{
	// Token: 0x0200010C RID: 268
	internal static class LayoutHelpers
	{
		// Token: 0x06000CFB RID: 3323 RVA: 0x0001FADC File Offset: 0x0001DCDC
		public static short RenderShort(this global::NLog.Layouts.Layout layout, global::NLog.LogEventInfo logEvent, short defaultValue, string layoutName)
		{
			if (layout == null)
			{
				global::NLog.Common.InternalLogger.Debug(layoutName + " is null so default value of " + defaultValue);
				return defaultValue;
			}
			if (logEvent == null)
			{
				global::NLog.Common.InternalLogger.Debug(layoutName + ": logEvent is null so default value of " + defaultValue);
				return defaultValue;
			}
			string text = layout.Render(logEvent);
			short result;
			if (!short.TryParse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out result))
			{
				global::NLog.Common.InternalLogger.Warn(string.Concat(new object[]
				{
					layoutName,
					": parse of value '",
					text,
					"' failed, return ",
					defaultValue
				}));
				return defaultValue;
			}
			return result;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0001FB6C File Offset: 0x0001DD6C
		public static int RenderInt(this global::NLog.Layouts.Layout layout, global::NLog.LogEventInfo logEvent, int defaultValue, string layoutName)
		{
			if (layout == null)
			{
				global::NLog.Common.InternalLogger.Debug(layoutName + " is null so default value of " + defaultValue);
				return defaultValue;
			}
			if (logEvent == null)
			{
				global::NLog.Common.InternalLogger.Debug(layoutName + ": logEvent is null so default value of " + defaultValue);
				return defaultValue;
			}
			string text = layout.Render(logEvent);
			int result;
			if (!int.TryParse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out result))
			{
				global::NLog.Common.InternalLogger.Warn(string.Concat(new object[]
				{
					layoutName,
					": parse of value '",
					text,
					"' failed, return ",
					defaultValue
				}));
				return defaultValue;
			}
			return result;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0001FBFC File Offset: 0x0001DDFC
		public static bool RenderBool(this global::NLog.Layouts.Layout layout, global::NLog.LogEventInfo logEvent, bool defaultValue, string layoutName)
		{
			if (layout == null)
			{
				global::NLog.Common.InternalLogger.Debug(layoutName + " is null so default value of " + defaultValue.ToString());
				return defaultValue;
			}
			if (logEvent == null)
			{
				global::NLog.Common.InternalLogger.Debug(layoutName + ": logEvent is null so default value of " + defaultValue.ToString());
				return defaultValue;
			}
			string text = layout.Render(logEvent);
			bool result;
			if (!bool.TryParse(text, out result))
			{
				global::NLog.Common.InternalLogger.Warn(string.Concat(new string[]
				{
					layoutName,
					": parse of value '",
					text,
					"' failed, return ",
					defaultValue.ToString()
				}));
				return defaultValue;
			}
			return result;
		}
	}
}
