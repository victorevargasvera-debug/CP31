using System;

namespace Infragistics.Controls
{
	// Token: 0x02000025 RID: 37
	internal interface ICancelableTool
	{
		// Token: 0x060001F1 RID: 497
		void StopTool();

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001F2 RID: 498
		// (set) Token: 0x060001F3 RID: 499
		bool IsCanceled { get; set; }
	}
}
