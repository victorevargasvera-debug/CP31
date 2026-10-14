using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001CB RID: 459
	public class ResizingColumnCannotBeRemovedException : global::System.Exception
	{
		// Token: 0x06000C3A RID: 3130 RVA: 0x0002B6BB File Offset: 0x000298BB
		public ResizingColumnCannotBeRemovedException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("ResizingColumnCannotBeRemovedException"), new object[0]))
		{
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0002B6DD File Offset: 0x000298DD
		public ResizingColumnCannotBeRemovedException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0002B6F6 File Offset: 0x000298F6
		public ResizingColumnCannotBeRemovedException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
