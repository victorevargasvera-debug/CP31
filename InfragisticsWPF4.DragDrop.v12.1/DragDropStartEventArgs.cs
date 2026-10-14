using System;
using System.Windows;

namespace Infragistics.DragDrop
{
	// Token: 0x0200000E RID: 14
	public class DragDropStartEventArgs : global::Infragistics.DragDrop.DragDropCancelEventArgs
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00005D8B File Offset: 0x00003F8B
		internal DragDropStartEventArgs(global::Infragistics.DragDrop.DragDropEventArgs baseArgs) : base(baseArgs)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00005D94 File Offset: 0x00003F94
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00005D9C File Offset: 0x00003F9C
		public global::System.Windows.UIElement DragSnapshotElement { get; set; }
	}
}
