using System;
using System.Collections;
using System.Collections.Generic;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000389 RID: 905
	public interface HSSFShapeContainer : global::System.Collections.Generic.IEnumerable<global::NPOI.HSSF.UserModel.HSSFShape>, global::System.Collections.IEnumerable
	{
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001D73 RID: 7539
		global::System.Collections.Generic.IList<global::NPOI.HSSF.UserModel.HSSFShape> Children { get; }

		// Token: 0x06001D74 RID: 7540
		void AddShape(global::NPOI.HSSF.UserModel.HSSFShape shape);

		// Token: 0x06001D75 RID: 7541
		void SetCoordinates(int x1, int y1, int x2, int y2);

		// Token: 0x06001D76 RID: 7542
		void Clear();

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001D77 RID: 7543
		int X1 { get; }

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001D78 RID: 7544
		int Y1 { get; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001D79 RID: 7545
		int X2 { get; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001D7A RID: 7546
		int Y2 { get; }

		// Token: 0x06001D7B RID: 7547
		bool RemoveShape(global::NPOI.HSSF.UserModel.HSSFShape shape);
	}
}
