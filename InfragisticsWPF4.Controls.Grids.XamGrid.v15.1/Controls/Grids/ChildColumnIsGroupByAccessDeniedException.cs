using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001D0 RID: 464
	public class ChildColumnIsGroupByAccessDeniedException : global::System.Exception
	{
		// Token: 0x06000C49 RID: 3145 RVA: 0x0002B814 File Offset: 0x00029A14
		public ChildColumnIsGroupByAccessDeniedException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("ChildColumnIsGroupByAccessDeniedException"), new object[0]))
		{
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0002B836 File Offset: 0x00029A36
		public ChildColumnIsGroupByAccessDeniedException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0002B84F File Offset: 0x00029A4F
		public ChildColumnIsGroupByAccessDeniedException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
