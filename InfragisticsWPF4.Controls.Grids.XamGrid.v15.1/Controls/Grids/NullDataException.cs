using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001CC RID: 460
	public class NullDataException : global::System.Exception
	{
		// Token: 0x06000C3D RID: 3133 RVA: 0x0002B700 File Offset: 0x00029900
		public NullDataException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("NullDataException"), new object[0]))
		{
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0002B722 File Offset: 0x00029922
		public NullDataException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0002B73B File Offset: 0x0002993B
		public NullDataException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
