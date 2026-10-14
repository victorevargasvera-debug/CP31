using System;
using Motorola.CommonCPS.RadioManagement.BatchOp;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000075 RID: 117
	internal class ClearBatchOpCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000325 RID: 805 RVA: 0x0003085C File Offset: 0x0002EA5C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1769144320;
			short num2 = num;
			num = (short)437552435;
			short num3 = num;
			num = (short)139232563;
			switch (num3 == num)
			{
			}
			num = (short)1543438337;
			if (num != 0)
			{
			}
			num = (short)748879872;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.Instance.ClearOldBatchOp();
			return true;
		}
	}
}
