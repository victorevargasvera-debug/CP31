using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200001C RID: 28
	public class ClipboardOperationCancelEventArgs : global::System.ComponentModel.CancelEventArgs
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00006B98 File Offset: 0x00004D98
		public ClipboardOperationCancelEventArgs(global::Infragistics.Controls.Editors.ClipboardOperation clipboardOperation, global::System.Windows.IDataObject dataObject, global::System.Exception exception = null)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(dataObject, "dataObject");
			global::Infragistics.CoreUtilities.ValidateEnum("clipboardOperation", typeof(global::Infragistics.Controls.Editors.ClipboardOperation), clipboardOperation);
			this.ClipboardOperation = clipboardOperation;
			this.DataObject = dataObject;
			this.Exception = exception;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00006BE5 File Offset: 0x00004DE5
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00006BED File Offset: 0x00004DED
		public global::Infragistics.Controls.Editors.ClipboardOperation ClipboardOperation { get; private set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00006BF6 File Offset: 0x00004DF6
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00006BFE File Offset: 0x00004DFE
		public global::System.Windows.IDataObject DataObject { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006C07 File Offset: 0x00004E07
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00006C0F File Offset: 0x00004E0F
		public global::System.Exception Exception { get; protected set; }
	}
}
