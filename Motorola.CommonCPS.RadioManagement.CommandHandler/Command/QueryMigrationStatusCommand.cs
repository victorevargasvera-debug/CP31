using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200003A RID: 58
	internal class QueryMigrationStatusCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600024C RID: 588 RVA: 0x0001E884 File Offset: 0x0001CA84
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1735451870;
			short num2 = num;
			num = (short)1553982686;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1726349312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1575157761;
			if (num != 0)
			{
			}
			num = (short)1195704320;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001E92C File Offset: 0x0001CB2C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1459800067;
			short num2 = num;
			num = (short)1193068547;
			switch (num2 == num)
			{
			default:
			{
				num = (short)418512896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)143261696;
			if (num != 0)
			{
			}
			num = (short)36438017;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DbMigrationService.GetDBMigrationRecord();
		}
	}
}
