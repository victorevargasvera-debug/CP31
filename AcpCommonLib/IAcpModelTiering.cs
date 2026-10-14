using System;
using System.Collections.Generic;

namespace AcpCommonLib
{
	// Token: 0x0200002C RID: 44
	public interface IAcpModelTiering
	{
		// Token: 0x060001D0 RID: 464
		bool GetFieldFromTieringFile(string strFieldToRetrieve);

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001D1 RID: 465
		string FieldName { get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001D2 RID: 466
		string IsVisible { get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001D3 RID: 467
		string DefaultValue { get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001D4 RID: 468
		string MaxValue { get; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001D5 RID: 469
		string MinValue { get; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001D6 RID: 470
		string StepSize { get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001D7 RID: 471
		global::System.Collections.Generic.List<string> ListOfValues { get; }
	}
}
