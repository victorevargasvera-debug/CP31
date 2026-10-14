using System;
using System.Globalization;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001CF RID: 463
	public class ChildColumnIsSelectedAccessDeniedException : global::System.Exception
	{
		// Token: 0x06000C46 RID: 3142 RVA: 0x0002B7CF File Offset: 0x000299CF
		public ChildColumnIsSelectedAccessDeniedException() : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("ChildColumnIsSelectedAccessDeniedException"), new object[0]))
		{
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0002B7F1 File Offset: 0x000299F1
		public ChildColumnIsSelectedAccessDeniedException(string message) : base(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, message, new object[0]))
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0002B80A File Offset: 0x00029A0A
		public ChildColumnIsSelectedAccessDeniedException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
