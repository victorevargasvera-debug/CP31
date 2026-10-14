using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000B5 RID: 181
	internal class PeudoCallIdSortComparer : global::System.Collections.Generic.IComparer<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>
	{
		// Token: 0x06000498 RID: 1176 RVA: 0x0004BA10 File Offset: 0x00049C10
		public int Compare(global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet x, global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet y)
		{
			int a_ = 17;
			short num = (short)906176595;
			short num2 = num;
			num = (short)1606625363;
			switch (num2 == num)
			{
			}
			num = (short)1984102401;
			if (num != 0)
			{
			}
			num = (short)1974206464;
			short num3 = num;
			num = (short)1557725184;
			if (num != 0)
			{
			}
			return string.Compare(x.ChildSet.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("令캪\ud8ac쮮\udeb0풴\udbb6햸\ud9bc", a_)].ToString(), y.ChildSet.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("令캪\ud8ac쮮\udeb0풴\udbb6햸\ud9bc", a_)].ToString(), global::System.StringComparison.CurrentCulture);
		}
	}
}
