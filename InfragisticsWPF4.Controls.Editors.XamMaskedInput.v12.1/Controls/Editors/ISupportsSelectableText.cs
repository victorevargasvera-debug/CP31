using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000030 RID: 48
	public interface ISupportsSelectableText
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000153 RID: 339
		// (set) Token: 0x06000154 RID: 340
		int SelectionStart { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000155 RID: 341
		// (set) Token: 0x06000156 RID: 342
		int SelectionLength { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000157 RID: 343
		// (set) Token: 0x06000158 RID: 344
		string SelectedText { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000159 RID: 345
		int TextLength { get; }

		// Token: 0x0600015A RID: 346
		void SelectAll();
	}
}
