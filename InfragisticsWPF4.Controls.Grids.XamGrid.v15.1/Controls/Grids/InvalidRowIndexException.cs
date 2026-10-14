using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001D1 RID: 465
	public class InvalidRowIndexException : global::System.Exception
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x0002B859 File Offset: 0x00029A59
		public InvalidRowIndexException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("InvalidRowIndexException"), new object[0]))
		{
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0002B87B File Offset: 0x00029A7B
		public InvalidRowIndexException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0002B894 File Offset: 0x00029A94
		public InvalidRowIndexException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
