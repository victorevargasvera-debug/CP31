using System;
using Infragistics.DragDrop;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200001C RID: 28
	public class TreeDropEventArgs : global::Infragistics.HandleableEventArgs
	{
		// Token: 0x06000093 RID: 147 RVA: 0x000034B5 File Offset: 0x000016B5
		internal TreeDropEventArgs(global::Infragistics.DragDrop.DragDropEventArgs baseArgs)
		{
			this.DragDropEventArgs = baseArgs;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000034C4 File Offset: 0x000016C4
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000034CC File Offset: 0x000016CC
		public global::Infragistics.DragDrop.DragDropEventArgs DragDropEventArgs { get; protected internal set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000034D5 File Offset: 0x000016D5
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000034DD File Offset: 0x000016DD
		public global::Infragistics.Controls.Menus.TreeDropDestination DropDestination { get; protected internal set; }
	}
}
