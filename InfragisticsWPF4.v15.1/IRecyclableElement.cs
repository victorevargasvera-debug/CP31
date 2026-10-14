using System;
using System.Windows.Controls;

namespace Infragistics
{
	// Token: 0x02000086 RID: 134
	public interface IRecyclableElement
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600055B RID: 1371
		// (set) Token: 0x0600055C RID: 1372
		bool DelayRecycling { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600055D RID: 1373
		// (set) Token: 0x0600055E RID: 1374
		global::System.Windows.Controls.Panel OwnerPanel { get; set; }
	}
}
