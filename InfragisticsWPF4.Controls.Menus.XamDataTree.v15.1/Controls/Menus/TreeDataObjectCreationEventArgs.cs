using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200001A RID: 26
	public class TreeDataObjectCreationEventArgs : global::Infragistics.Controls.Menus.NodeLayoutEventArgs
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000343F File Offset: 0x0000163F
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00003447 File Offset: 0x00001647
		public object NewObject { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003450 File Offset: 0x00001650
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00003458 File Offset: 0x00001658
		public global::System.Type ObjectType { get; protected internal set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003461 File Offset: 0x00001661
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00003469 File Offset: 0x00001669
		public global::Infragistics.Controls.Menus.XamDataTreeNode ParentNode { get; protected internal set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00003472 File Offset: 0x00001672
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000347A File Offset: 0x0000167A
		public global::System.Type CollectionType { get; protected internal set; }
	}
}
