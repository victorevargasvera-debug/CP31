using System;
using System.Collections.Generic;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002BC RID: 700
	public interface Parent : global::NPOI.POIFS.Properties.Child
	{
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600134C RID: 4940
		global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.Properties.Property> Children { get; }

		// Token: 0x0600134D RID: 4941
		void AddChild(global::NPOI.POIFS.Properties.Property property);

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600134E RID: 4942
		// (set) Token: 0x0600134F RID: 4943
		global::NPOI.POIFS.Properties.Child PreviousChild { get; set; }

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001350 RID: 4944
		// (set) Token: 0x06001351 RID: 4945
		global::NPOI.POIFS.Properties.Child NextChild { get; set; }
	}
}
