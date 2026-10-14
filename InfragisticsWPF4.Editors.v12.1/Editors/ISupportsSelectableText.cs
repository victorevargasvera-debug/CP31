using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000020 RID: 32
	public interface ISupportsSelectableText
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001CF RID: 463
		// (set) Token: 0x060001D0 RID: 464
		int SelectionStart { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001D1 RID: 465
		// (set) Token: 0x060001D2 RID: 466
		int SelectionLength { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001D3 RID: 467
		// (set) Token: 0x060001D4 RID: 468
		string SelectedText { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001D5 RID: 469
		int TextLength { get; }

		// Token: 0x060001D6 RID: 470
		void SelectAll();
	}
}
