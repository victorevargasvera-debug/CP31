using System;
using System.Windows;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000049 RID: 73
	public interface IDropTarget
	{
		// Token: 0x06000114 RID: 276
		void DragOver(global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo dropInfo, global::System.Windows.DragEventArgs e);

		// Token: 0x06000115 RID: 277
		void Drop(global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo dropInfo);
	}
}
