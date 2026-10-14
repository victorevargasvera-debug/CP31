using System;
using System.Collections;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000629 RID: 1577
	public interface IOMathContainer
	{
		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x0600449D RID: 17565
		global::System.Collections.ArrayList Items { get; }

		// Token: 0x0600449E RID: 17566
		global::NPOI.OpenXmlFormats.Shared.CT_R AddNewR();

		// Token: 0x0600449F RID: 17567
		global::NPOI.OpenXmlFormats.Shared.CT_Acc AddNewAcc();

		// Token: 0x060044A0 RID: 17568
		global::NPOI.OpenXmlFormats.Shared.CT_Nary AddNewNary();

		// Token: 0x060044A1 RID: 17569
		global::NPOI.OpenXmlFormats.Shared.CT_SSub AddNewSSub();

		// Token: 0x060044A2 RID: 17570
		global::NPOI.OpenXmlFormats.Shared.CT_SSup AddNewSSup();

		// Token: 0x060044A3 RID: 17571
		global::NPOI.OpenXmlFormats.Shared.CT_F AddNewF();

		// Token: 0x060044A4 RID: 17572
		global::NPOI.OpenXmlFormats.Shared.CT_Rad AddNewRad();
	}
}
