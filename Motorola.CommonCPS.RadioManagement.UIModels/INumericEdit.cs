using System;
using System.Collections.Generic;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200009F RID: 159
	public interface INumericEdit
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060005CF RID: 1487
		decimal Max { get; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060005D0 RID: 1488
		decimal Min { get; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060005D1 RID: 1489
		decimal[][] RangeSection { get; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060005D2 RID: 1490
		decimal Step { get; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060005D3 RID: 1491
		// (set) Token: 0x060005D4 RID: 1492
		decimal Value { get; set; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060005D5 RID: 1493
		global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<decimal, string>> CustomValueChoiceMap { get; }

		// Token: 0x060005D6 RID: 1494
		void Increase();

		// Token: 0x060005D7 RID: 1495
		void Decrease();
	}
}
