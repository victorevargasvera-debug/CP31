using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001BF RID: 447
	public class ClipboardPasteErrorEventArgs : global::System.EventArgs
	{
		// Token: 0x06000C0F RID: 3087 RVA: 0x0002B3EC File Offset: 0x000295EC
		public ClipboardPasteErrorEventArgs()
		{
			this.IsRecoverable = true;
			this.AttemptRecover = true;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0002B402 File Offset: 0x00029602
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x0002B40A File Offset: 0x0002960A
		public global::Infragistics.Controls.Grids.ClipboardPasteErrorType ErrorType { get; set; }

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0002B413 File Offset: 0x00029613
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x0002B41B File Offset: 0x0002961B
		public bool IsRecoverable { get; internal set; }

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0002B424 File Offset: 0x00029624
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0002B42C File Offset: 0x0002962C
		public bool AttemptRecover { get; set; }
	}
}
