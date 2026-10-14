using System;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000A0 RID: 160
	public interface IStringEdit
	{
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060005D8 RID: 1496
		// (set) Token: 0x060005D9 RID: 1497
		string Text { get; set; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060005DA RID: 1498
		int MaxLength { get; }
	}
}
