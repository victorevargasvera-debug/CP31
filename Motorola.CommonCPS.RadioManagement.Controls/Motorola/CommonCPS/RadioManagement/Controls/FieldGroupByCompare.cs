using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000B6 RID: 182
	internal class FieldGroupByCompare : global::System.Collections.Generic.IEqualityComparer<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x0004BB24 File Offset: 0x00049D24
		public bool Equals(global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet x, global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet y)
		{
			short num = (short)620205591;
			short num2 = num;
			num = (short)1290442263;
			switch (num2 == num)
			{
			}
			num = (short)1058603009;
			if (num != 0)
			{
			}
			num = (short)1921974272;
			short num3 = num;
			num = (short)1872625664;
			if (num != 0)
			{
			}
			return x.ParentSet.GetHashCode() == y.ParentSet.GetHashCode();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0004BBE8 File Offset: 0x00049DE8
		public int GetHashCode(global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet obj)
		{
			short num = (short)1395674833;
			short num2 = num;
			num = (short)1272467153;
			switch (num2 == num)
			{
			}
			num = (short)1753219073;
			if (num != 0)
			{
			}
			num = (short)687996928;
			short num3 = num;
			num = (short)1583939584;
			if (num != 0)
			{
			}
			return obj.ParentSet.GetHashCode();
		}
	}
}
