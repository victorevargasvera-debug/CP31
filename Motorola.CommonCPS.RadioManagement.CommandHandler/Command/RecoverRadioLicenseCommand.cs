using System;
using Motorola.CommonCPS.RadioManagement.BatchOp;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000085 RID: 133
	internal class RecoverRadioLicenseCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000350 RID: 848 RVA: 0x000343AC File Offset: 0x000325AC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1726537053;
			short num2 = num;
			num = (short)60743005;
			switch (num2 == num)
			{
			}
			num = (short)1087832065;
			if (num != 0)
			{
			}
			num = (short)1519648768;
			short num3 = num;
			num = (short)874905600;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.RecoverAllRadioFeaturesBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.RecoverAllRadioFeaturesBatchOp();
			base.ExecuteBatchOp<string>(op);
			return null;
		}
	}
}
