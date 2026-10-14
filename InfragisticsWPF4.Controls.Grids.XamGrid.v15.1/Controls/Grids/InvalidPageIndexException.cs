using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001C9 RID: 457
	public class InvalidPageIndexException : global::System.Exception
	{
		// Token: 0x06000C34 RID: 3124 RVA: 0x0002B64B File Offset: 0x0002984B
		public InvalidPageIndexException()
		{
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0002B653 File Offset: 0x00029853
		public InvalidPageIndexException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0002B66C File Offset: 0x0002986C
		public InvalidPageIndexException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
