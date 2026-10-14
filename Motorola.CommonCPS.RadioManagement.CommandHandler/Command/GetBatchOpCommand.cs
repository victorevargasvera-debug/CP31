using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000073 RID: 115
	internal class GetBatchOpCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000320 RID: 800 RVA: 0x000304AC File Offset: 0x0002E6AC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2133896202;
			short num2 = num;
			num = (short)1057008650;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1726218240;
				if (num != 0)
				{
				}
				num = (short)408289281;
				if (num != 0)
				{
				}
				num = (short)1680277504;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer = (global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)paras[0];
				global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.Instance.Find(jobContainer.ID.Value);
				if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetJbcSummary(batchOp.JobContainerGuid) != null)
				{
					return batchOp.JobContainerGuid;
				}
				break;
			}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobJobContainerDeleted);
		}
	}
}
