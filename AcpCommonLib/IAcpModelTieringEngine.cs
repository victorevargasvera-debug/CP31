using System;
using System.Collections.Generic;

namespace AcpCommonLib
{
	// Token: 0x0200002D RID: 45
	public interface IAcpModelTieringEngine
	{
		// Token: 0x060001D8 RID: 472
		void GetTieringData(string recordsetOrFieldName);

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001D9 RID: 473
		global::System.Collections.Generic.List<string> TieredRecordsets { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001DA RID: 474
		global::System.Collections.Generic.List<string> TieredFields { get; }
	}
}
