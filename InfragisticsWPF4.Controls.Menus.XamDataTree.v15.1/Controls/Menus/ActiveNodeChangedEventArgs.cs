using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000015 RID: 21
	public class ActiveNodeChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000337E File Offset: 0x0000157E
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00003386 File Offset: 0x00001586
		public global::Infragistics.Controls.Menus.XamDataTreeNode OriginalActiveTreeNode { get; protected internal set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000338F File Offset: 0x0000158F
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00003397 File Offset: 0x00001597
		public global::Infragistics.Controls.Menus.XamDataTreeNode NewActiveTreeNode { get; protected internal set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000033A0 File Offset: 0x000015A0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000033A8 File Offset: 0x000015A8
		[global::System.Obsolete("The Cancel property on ActiveNodeChangedEventArgs will no longer be used.  To cancel the setting of the active node then the argument on the ActiveNodeChanging event should be modified.")]
		public bool Cancel { get; set; }
	}
}
