using System;

namespace AcpCommonLib
{
	// Token: 0x0200002A RID: 42
	public interface IAcpPointerField
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001C9 RID: 457
		// (set) Token: 0x060001CA RID: 458
		global::AcpCommonLib.IAcpField PointedField { get; set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001CB RID: 459
		// (set) Token: 0x060001CC RID: 460
		string HexUIValue { get; set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001CD RID: 461
		bool ShowHexValue { get; }
	}
}
