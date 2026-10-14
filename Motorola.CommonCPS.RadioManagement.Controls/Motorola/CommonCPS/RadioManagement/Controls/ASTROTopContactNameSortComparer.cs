using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200007C RID: 124
	internal class ASTROTopContactNameSortComparer : global::System.Collections.Generic.IComparer<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x0002EE24 File Offset: 0x0002D024
		public int Compare(global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet x, global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet y)
		{
			int a_ = 19;
			short num = (short)618827066;
			short num2 = num;
			num = (short)1091996986;
			switch (num2 == num)
			{
			}
			num = (short)2108293120;
			short num3 = num;
			num = (short)1869217793;
			if (num != 0)
			{
			}
			num = (short)779747328;
			if (num != 0)
			{
			}
			return string.Compare(x.ParentSet.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺪ캬쎮횲\udbb4視풺펼쮾ꃀꃂ뇄蛆ꗈꋊ곌볎軐鋒", a_)].ToString(), y.ParentSet.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺪ캬쎮횲\udbb4視풺펼쮾ꃀꃂ뇄蛆ꗈꋊ곌볎軐鋒", a_)].ToString(), global::System.StringComparison.CurrentCulture);
		}
	}
}
