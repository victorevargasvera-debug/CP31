using System;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x020000D8 RID: 216
	public class InvalidEventNameException : global::System.Exception
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x0001C224 File Offset: 0x0001A424
		public InvalidEventNameException()
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0001C22C File Offset: 0x0001A42C
		public InvalidEventNameException(string eventName, global::System.Type elementType) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::SR.GetString("InvalidEventName"), new object[]
		{
			"\"" + eventName + "\"",
			elementType.ToString()
		}))
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0001C277 File Offset: 0x0001A477
		public InvalidEventNameException(string message) : base(message)
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0001C280 File Offset: 0x0001A480
		public InvalidEventNameException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
