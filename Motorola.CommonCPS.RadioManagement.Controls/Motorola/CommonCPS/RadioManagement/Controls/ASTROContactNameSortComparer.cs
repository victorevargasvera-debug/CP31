using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200007B RID: 123
	internal class ASTROContactNameSortComparer : global::System.Collections.Generic.IComparer<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x0002ED1C File Offset: 0x0002CF1C
		public int Compare(global::Motorola.CommonCPS.RadioManagement.UIModels.Set x, global::Motorola.CommonCPS.RadioManagement.UIModels.Set y)
		{
			int a_ = 19;
			short num = (short)604897281;
			if (num != 0)
			{
			}
			num = (short)948170029;
			short num2 = num;
			num = (short)1040510253;
			switch (num2 == num)
			{
			default:
			{
				num = (short)515178496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2051604480;
			if (num != 0)
			{
			}
			return string.Compare(x.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺪ캬쎮횲\udbb4視풺펼쮾ꃀꃂ뇄蛆ꗈꋊ곌볎軐鋒", a_)].ToString(), y.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺪ캬쎮횲\udbb4視풺펼쮾ꃀꃂ뇄蛆ꗈꋊ곌볎軐鋒", a_)].ToString(), global::System.StringComparison.CurrentCulture);
		}
	}
}
