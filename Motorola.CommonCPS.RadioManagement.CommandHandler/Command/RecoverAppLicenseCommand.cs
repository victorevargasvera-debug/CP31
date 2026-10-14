using System;
using Motorola.CommonCPS.RadioManagement.BatchOp;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000084 RID: 132
	internal class RecoverAppLicenseCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600034E RID: 846 RVA: 0x000342E0 File Offset: 0x000324E0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1078968167;
			short num2 = num;
			num = (short)123387751;
			switch (num2 == num)
			{
			}
			num = (short)2084569088;
			if (num != 0)
			{
			}
			num = (short)1257373696;
			short num3 = num;
			num = (short)406388737;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.RecoverAppLicenseBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.RecoverAppLicenseBatchOp();
			base.ExecuteBatchOp<string>(op);
			return null;
		}
	}
}
