using System;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x020000BB RID: 187
	public class InvalidEventNameException : global::System.Exception
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x00018A7C File Offset: 0x00016C7C
		public InvalidEventNameException()
		{
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00018A84 File Offset: 0x00016C84
		public InvalidEventNameException(string eventName, global::System.Type elementType) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::SR.GetString("InvalidEventName"), new object[]
		{
			"\"" + eventName + "\"",
			elementType.ToString()
		}))
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00018ACF File Offset: 0x00016CCF
		public InvalidEventNameException(string message) : base(message)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00018AD8 File Offset: 0x00016CD8
		public InvalidEventNameException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
