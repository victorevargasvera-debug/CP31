using System;
using System.Windows.Controls;

namespace Infragistics
{
	// Token: 0x0200006F RID: 111
	public interface IRecyclableElement
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600049A RID: 1178
		// (set) Token: 0x0600049B RID: 1179
		bool DelayRecycling { get; set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600049C RID: 1180
		// (set) Token: 0x0600049D RID: 1181
		global::System.Windows.Controls.Panel OwnerPanel { get; set; }
	}
}
