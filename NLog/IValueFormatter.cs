using System;
using System.Text;
using NLog.MessageTemplates;

namespace NLog
{
	// Token: 0x0200000A RID: 10
	public interface IValueFormatter
	{
		// Token: 0x06000181 RID: 385
		bool FormatValue(object value, string format, global::NLog.MessageTemplates.CaptureType captureType, global::System.IFormatProvider formatProvider, global::System.Text.StringBuilder builder);
	}
}
