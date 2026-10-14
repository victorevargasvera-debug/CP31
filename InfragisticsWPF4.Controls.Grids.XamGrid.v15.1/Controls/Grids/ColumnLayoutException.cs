using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001CE RID: 462
	public class ColumnLayoutException : global::System.Exception
	{
		// Token: 0x06000C43 RID: 3139 RVA: 0x0002B78A File Offset: 0x0002998A
		public ColumnLayoutException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("ColumnLayoutException"), new object[0]))
		{
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0002B7AC File Offset: 0x000299AC
		public ColumnLayoutException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0002B7C5 File Offset: 0x000299C5
		public ColumnLayoutException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
