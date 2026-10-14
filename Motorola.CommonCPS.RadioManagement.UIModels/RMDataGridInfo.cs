using System;
using System.Collections.Generic;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000010 RID: 16
	public class RMDataGridInfo
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000096B8 File Offset: 0x000078B8
		public RMDataGridInfo()
		{
			this.Columns = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo>();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000096D8 File Offset: 0x000078D8
		public void AddColumnInfo(global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo info)
		{
			short num = (short)1290177853;
			short num2 = num;
			num = (short)1814203709;
			switch (num2 == num)
			{
			}
			num = (short)1057292288;
			short num3 = num;
			num = (short)1964048385;
			if (num != 0)
			{
			}
			num = (short)1666318336;
			if (num != 0)
			{
			}
			this.Columns.Add(info);
		}

		// Token: 0x04000023 RID: 35
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo> Columns;
	}
}
