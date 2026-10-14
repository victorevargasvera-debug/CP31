using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200005D RID: 93
	internal class ASTROSubmitLicenseAssignmentCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x0002B7FC File Offset: 0x000299FC
		public ASTROSubmitLicenseAssignmentCommand()
		{
			this.a = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0002B820 File Offset: 0x00029A20
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2107498616;
			short num2 = num;
			num = (short)594206840;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1327562752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1857748993;
			if (num != 0)
			{
			}
			num = (short)1728315392;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0400005F RID: 95
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService a;
	}
}
