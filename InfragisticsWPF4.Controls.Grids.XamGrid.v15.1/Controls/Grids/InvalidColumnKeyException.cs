using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001C4 RID: 452
	public class InvalidColumnKeyException : global::System.Exception
	{
		// Token: 0x06000C24 RID: 3108 RVA: 0x0002B4BF File Offset: 0x000296BF
		public InvalidColumnKeyException()
		{
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0002B4C8 File Offset: 0x000296C8
		public InvalidColumnKeyException(string keys) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("InvalidColumnKeyException"), new object[]
		{
			"\"" + keys + "\""
		}))
		{
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0002B50A File Offset: 0x0002970A
		public InvalidColumnKeyException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
