using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001C5 RID: 453
	public class EmptyColumnKeyException : global::System.Exception
	{
		// Token: 0x06000C27 RID: 3111 RVA: 0x0002B514 File Offset: 0x00029714
		public EmptyColumnKeyException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("EmptyColumnKeyException"), new object[0]))
		{
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0002B536 File Offset: 0x00029736
		public EmptyColumnKeyException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0002B54F File Offset: 0x0002974F
		public EmptyColumnKeyException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
