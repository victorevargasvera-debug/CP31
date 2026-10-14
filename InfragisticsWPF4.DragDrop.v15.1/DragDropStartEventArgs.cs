using System;
using System.Windows;

namespace Infragistics.DragDrop
{
	// Token: 0x0200000E RID: 14
	public class DragDropStartEventArgs : global::Infragistics.DragDrop.DragDropCancelEventArgs
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x00005F1F File Offset: 0x0000411F
		internal DragDropStartEventArgs(global::Infragistics.DragDrop.DragDropEventArgs baseArgs) : base(baseArgs)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005F28 File Offset: 0x00004128
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00005F30 File Offset: 0x00004130
		public global::System.Windows.UIElement DragSnapshotElement { get; set; }
	}
}
