using System;

namespace Infragistics
{
	// Token: 0x020000C4 RID: 196
	public interface ISelectableObject
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600073A RID: 1850
		// (set) Token: 0x0600073B RID: 1851
		bool IsSelected { get; set; }

		// Token: 0x0600073C RID: 1852
		void SetSelected(bool isSelected);
	}
}
