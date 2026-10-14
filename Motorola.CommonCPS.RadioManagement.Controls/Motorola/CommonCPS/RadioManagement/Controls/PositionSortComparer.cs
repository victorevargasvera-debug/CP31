using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000F7 RID: 247
	internal class PositionSortComparer : global::System.Collections.Generic.IComparer<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x0006F0C4 File Offset: 0x0006D2C4
		public int Compare(global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet x, global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet y)
		{
			short num = (short)213125787;
			short num2 = num;
			num = (short)1769736859;
			switch (num2 == num)
			{
			}
			num = (short)1137770497;
			if (num != 0)
			{
			}
			num = (short)1035075584;
			short num3 = num;
			num = (short)1387790336;
			if (num != 0)
			{
			}
			return x.ParentSet.Position.CompareTo(y.ParentSet.Position);
		}
	}
}
