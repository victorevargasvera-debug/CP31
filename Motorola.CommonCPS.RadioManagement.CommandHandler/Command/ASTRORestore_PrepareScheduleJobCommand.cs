using System;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200004C RID: 76
	public class ASTRORestore_PrepareScheduleJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.Restore_PrepareScheduleJobCommand
	{
		// Token: 0x06000298 RID: 664 RVA: 0x0002481C File Offset: 0x00022A1C
		public override void InitializeContext(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleRestoreJobContext context)
		{
			short num = (short)628431279;
			short num2 = num;
			num = (short)1633556911;
			switch (num2 == num)
			{
			}
			num = (short)275578881;
			if (num != 0)
			{
			}
			num = (short)1426915328;
			short num3 = num;
			num = (short)2001010688;
			if (num != 0)
			{
			}
			base.InitializeContext(context);
			global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService = base.LocalService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService;
			context.IsWriteProtectedEnable = true;
			context.IsConnectionMethodOTAEditable = iastrolocalService.CheckAstroPop25Enabled();
			context.IsConnectionMethodWiredEditable = true;
			context.IsConnectionMethodAnyEditable = (context.IsConnectionMethodOTAEditable && context.IsConnectionMethodWiredEditable);
			context.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROScheduleJobContextValidator();
		}

		// Token: 0x0400004D RID: 77
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioDetailService a = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioDetailService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioDetailService;
	}
}
