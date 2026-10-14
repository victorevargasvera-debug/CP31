using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001CD RID: 461
	public class DataTypeMismatchException : global::System.Exception
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x0002B745 File Offset: 0x00029945
		public DataTypeMismatchException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("DataTypeMismatchException"), new object[0]))
		{
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0002B767 File Offset: 0x00029967
		public DataTypeMismatchException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0002B780 File Offset: 0x00029980
		public DataTypeMismatchException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
