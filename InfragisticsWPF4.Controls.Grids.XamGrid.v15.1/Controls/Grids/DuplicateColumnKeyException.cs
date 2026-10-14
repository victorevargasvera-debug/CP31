using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001C6 RID: 454
	public class DuplicateColumnKeyException : global::System.Exception
	{
		// Token: 0x06000C2A RID: 3114 RVA: 0x0002B559 File Offset: 0x00029759
		public DuplicateColumnKeyException()
		{
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0002B564 File Offset: 0x00029764
		public DuplicateColumnKeyException(string key) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("DuplicateColumnKeyException"), new object[]
		{
			key
		}))
		{
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0002B597 File Offset: 0x00029797
		public DuplicateColumnKeyException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
