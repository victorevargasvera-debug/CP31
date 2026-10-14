using System;
using System.Windows;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200001D RID: 29
	public class ClipboardOperationEventArgs : global::System.EventArgs
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00006C18 File Offset: 0x00004E18
		public ClipboardOperationEventArgs(global::Infragistics.Controls.Editors.ClipboardOperation clipboardOperation, global::System.Windows.IDataObject dataObject, global::Infragistics.Controls.Editors.ClipboardOperationStatus status = global::Infragistics.Controls.Editors.ClipboardOperationStatus.Successful, global::System.Exception exception = null)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(dataObject, "dataObject");
			global::Infragistics.CoreUtilities.ValidateEnum("clipboardOperation", typeof(global::Infragistics.Controls.Editors.ClipboardOperation), clipboardOperation);
			global::Infragistics.CoreUtilities.ValidateEnum("status", typeof(global::Infragistics.Controls.Editors.ClipboardOperationStatus), status);
			this.ClipboardOperation = clipboardOperation;
			this.DataObject = dataObject;
			this.Exception = exception;
			this.Status = status;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006C87 File Offset: 0x00004E87
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00006C8F File Offset: 0x00004E8F
		public global::Infragistics.Controls.Editors.ClipboardOperation ClipboardOperation { get; private set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00006C98 File Offset: 0x00004E98
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00006CA0 File Offset: 0x00004EA0
		public global::System.Windows.IDataObject DataObject { get; private set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006CA9 File Offset: 0x00004EA9
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00006CB1 File Offset: 0x00004EB1
		public global::System.Exception Exception { get; protected set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00006CBA File Offset: 0x00004EBA
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00006CC2 File Offset: 0x00004EC2
		public global::Infragistics.Controls.Editors.ClipboardOperationStatus Status { get; private set; }
	}
}
