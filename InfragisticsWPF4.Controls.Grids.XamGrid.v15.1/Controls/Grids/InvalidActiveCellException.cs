using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001CA RID: 458
	public class InvalidActiveCellException : global::System.Exception
	{
		// Token: 0x06000C37 RID: 3127 RVA: 0x0002B676 File Offset: 0x00029876
		public InvalidActiveCellException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("InvalidActiveCellException"), new object[0]))
		{
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0002B698 File Offset: 0x00029898
		public InvalidActiveCellException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0002B6B1 File Offset: 0x000298B1
		public InvalidActiveCellException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
