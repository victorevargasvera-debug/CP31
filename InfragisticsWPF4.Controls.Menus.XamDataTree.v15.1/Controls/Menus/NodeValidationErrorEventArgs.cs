using System;
using System.Windows.Controls;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000019 RID: 25
	public class NodeValidationErrorEventArgs : global::Infragistics.Controls.Menus.NodeEventArgs
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003415 File Offset: 0x00001615
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000341D File Offset: 0x0000161D
		public global::System.Windows.Controls.ValidationErrorEventArgs ValidationErrorEventArgs { get; protected internal set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003426 File Offset: 0x00001626
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000342E File Offset: 0x0000162E
		public bool Handled { get; set; }
	}
}
