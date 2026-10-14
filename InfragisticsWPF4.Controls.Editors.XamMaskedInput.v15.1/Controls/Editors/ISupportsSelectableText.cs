using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002F RID: 47
	public interface ISupportsSelectableText
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000152 RID: 338
		// (set) Token: 0x06000153 RID: 339
		int SelectionStart { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000154 RID: 340
		// (set) Token: 0x06000155 RID: 341
		int SelectionLength { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000156 RID: 342
		// (set) Token: 0x06000157 RID: 343
		string SelectedText { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000158 RID: 344
		int TextLength { get; }

		// Token: 0x06000159 RID: 345
		void SelectAll();
	}
}
