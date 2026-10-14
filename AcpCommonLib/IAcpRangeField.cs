using System;

namespace AcpCommonLib
{
	// Token: 0x02000029 RID: 41
	public interface IAcpRangeField
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001BD RID: 445
		// (set) Token: 0x060001BE RID: 446
		string HexUIValue { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001BF RID: 447
		bool ShowHexValue { get; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001C0 RID: 448
		bool ShowLeadingZeros { get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001C1 RID: 449
		// (set) Token: 0x060001C2 RID: 450
		int Min { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001C3 RID: 451
		// (set) Token: 0x060001C4 RID: 452
		int Max { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001C5 RID: 453
		// (set) Token: 0x060001C6 RID: 454
		int StepSize { get; set; }

		// Token: 0x060001C7 RID: 455
		void StepUp();

		// Token: 0x060001C8 RID: 456
		void StepDown();
	}
}
