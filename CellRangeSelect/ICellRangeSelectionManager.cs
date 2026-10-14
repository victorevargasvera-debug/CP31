using System;

namespace Motorola.CommonCPS.UI.CellRangeSelect
{
	// Token: 0x0200000D RID: 13
	public interface ICellRangeSelectionManager : global::System.IDisposable
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000083 RID: 131
		global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionCompletedHandler DragSelectionEnded { get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000084 RID: 132
		global::Motorola.CommonCPS.UI.CellRangeSelect.DragSelectionStartedHandler DragSelectionStarted { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000085 RID: 133
		global::Motorola.CommonCPS.UI.CellRangeSelect.CellRangeSelectionAdorner SelectionAdorner { get; }

		// Token: 0x06000086 RID: 134
		global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange GetSelectionRange();
	}
}
