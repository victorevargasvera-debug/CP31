using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000B4 RID: 180
	internal class CallTypeSortComparer : global::System.Collections.Generic.IComparer<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>
	{
		// Token: 0x06000496 RID: 1174 RVA: 0x0004B8FC File Offset: 0x00049AFC
		public int Compare(global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet x, global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet y)
		{
			int a_ = 17;
			short num = (short)284588133;
			short num2 = num;
			num = (short)1361803365;
			switch (num2 == num)
			{
			}
			num = (short)351404032;
			if (num != 0)
			{
			}
			num = (short)977797120;
			short num3 = num;
			num = (short)112459777;
			if (num != 0)
			{
			}
			return string.Compare(x.ChildSet.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪪솬쎮쪲어튶", a_)].ToString(), y.ChildSet.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪪솬쎮쪲어튶", a_)].ToString(), global::System.StringComparison.CurrentCulture);
		}
	}
}
