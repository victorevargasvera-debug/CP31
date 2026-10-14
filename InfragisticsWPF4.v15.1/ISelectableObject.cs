using System;

namespace Infragistics
{
	// Token: 0x020000E1 RID: 225
	public interface ISelectableObject
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000838 RID: 2104
		// (set) Token: 0x06000839 RID: 2105
		bool IsSelected { get; set; }

		// Token: 0x0600083A RID: 2106
		void SetSelected(bool isSelected);
	}
}
