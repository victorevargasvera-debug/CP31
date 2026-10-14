using System;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x0200000E RID: 14
	public interface ICellRangeFiller
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71
		string Name { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72
		global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation Operation { get; }

		// Token: 0x06000049 RID: 73
		bool CanExecute(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillParameter paremeter);

		// Token: 0x0600004A RID: 74
		void Execute(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillParameter paremeter);
	}
}
