using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000014 RID: 20
	public class NodeLayoutAssignedEventArgs : global::System.EventArgs
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00003332 File Offset: 0x00001532
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000333A File Offset: 0x0000153A
		public global::Infragistics.Controls.Menus.NodeLayout NodeLayout { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00003343 File Offset: 0x00001543
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000334B File Offset: 0x0000154B
		public int Level { get; protected internal set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00003354 File Offset: 0x00001554
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000335C File Offset: 0x0000155C
		public string Key { get; protected internal set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00003365 File Offset: 0x00001565
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000336D File Offset: 0x0000156D
		public global::System.Type DataType { get; protected internal set; }
	}
}
