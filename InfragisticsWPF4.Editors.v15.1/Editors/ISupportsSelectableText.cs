using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000021 RID: 33
	public interface ISupportsSelectableText
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001DA RID: 474
		// (set) Token: 0x060001DB RID: 475
		int SelectionStart { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001DC RID: 476
		// (set) Token: 0x060001DD RID: 477
		int SelectionLength { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001DE RID: 478
		// (set) Token: 0x060001DF RID: 479
		string SelectedText { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001E0 RID: 480
		int TextLength { get; }

		// Token: 0x060001E1 RID: 481
		void SelectAll();
	}
}
