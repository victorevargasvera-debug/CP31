using System;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000046 RID: 70
	public interface IDragSource
	{
		// Token: 0x060000FA RID: 250
		void StartDrag(global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo dragInfo);

		// Token: 0x060000FB RID: 251
		bool CanStartDrag(global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo dragInfo);

		// Token: 0x060000FC RID: 252
		void Dropped(global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo dropInfo);

		// Token: 0x060000FD RID: 253
		void DragCancelled();

		// Token: 0x060000FE RID: 254
		bool TryCatchOccurredException(global::System.Exception exception);
	}
}
