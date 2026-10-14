using System;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000041 RID: 65
	public class ASTROSelectWarningRadiostoScheduleJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.SelectWarningRadiostoScheduleJobCommand
	{
		// Token: 0x06000269 RID: 617 RVA: 0x00020C70 File Offset: 0x0001EE70
		protected override void ExecBatchOP(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context)
		{
			short num = (short)545325056;
			short num2 = num;
			num = (short)1380326762;
			short num3 = num;
			num = (short)515382634;
			switch (num3 == num)
			{
			}
			num = (short)753664000;
			if (num != 0)
			{
			}
			num = (short)1379008513;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROScheduleJobBatchOp operation = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROScheduleJobBatchOp(context);
			base.RunOperationWrapper(context, operation);
		}
	}
}
