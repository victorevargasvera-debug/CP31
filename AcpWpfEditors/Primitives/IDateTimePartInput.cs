using System;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x0200005A RID: 90
	public interface IDateTimePartInput
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060005C5 RID: 1477
		// (set) Token: 0x060005C6 RID: 1478
		int? Value { get; set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060005C7 RID: 1479
		// (set) Token: 0x060005C8 RID: 1480
		int MinValue { get; set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005C9 RID: 1481
		// (set) Token: 0x060005CA RID: 1482
		int MaxValue { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005CB RID: 1483
		global::DevComponents.WpfEditors.Primitives.eDateTimePart Part { get; }

		// Token: 0x060005CC RID: 1484
		void UndoInput();
	}
}
