using System;

namespace Infragistics.DragDrop
{
	// Token: 0x0200000D RID: 13
	public class DragDropCancelEventArgs : global::Infragistics.DragDrop.DragDropEventArgs
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00005E88 File Offset: 0x00004088
		internal DragDropCancelEventArgs(global::Infragistics.DragDrop.DragDropEventArgs baseArgs)
		{
			base.CopyCursorTemplate = baseArgs.CopyCursorTemplate;
			base.Data = baseArgs.Data;
			base.DragTemplate = baseArgs.DragTemplate;
			base.DragSource = baseArgs.DragSource;
			base.OriginalDragSource = baseArgs.OriginalDragSource;
			base.MoveCursorTemplate = baseArgs.MoveCursorTemplate;
			base.DropNotAllowedCursorTemplate = baseArgs.DropNotAllowedCursorTemplate;
			base.OriginalDragSource = baseArgs.OriginalDragSource;
			base.OperationType = baseArgs.OperationType;
			this.Cancel = false;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00005F0E File Offset: 0x0000410E
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00005F16 File Offset: 0x00004116
		public bool Cancel { get; set; }
	}
}
