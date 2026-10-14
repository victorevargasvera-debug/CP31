using System;

namespace Infragistics
{
	// Token: 0x020000BD RID: 189
	public static class StringFormatUtil
	{
		// Token: 0x0600081E RID: 2078 RVA: 0x00026218 File Offset: 0x00024418
		public static string Format(this string format, object obj, global::Infragistics.StringFormatter.ValueDelegate propertyValue)
		{
			global::Infragistics.StringFormatter stringFormatter = (format != null) ? new global::Infragistics.StringFormatter
			{
				FormatString = format
			} : null;
			if (stringFormatter == null)
			{
				return null;
			}
			return stringFormatter.Format(obj, propertyValue);
		}
	}
}
