using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000055 RID: 85
	public static class BatchOpUtility
	{
		// Token: 0x060001FC RID: 508 RVA: 0x000320E8 File Offset: 0x000302E8
		public static global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob CreateFailureJob(global::System.Guid jobContainerGuid, string jobDescription, global::Motorola.Common.CustomException.CommonErrorCode errCode, string[] paramters)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_86;
				case 1:
					batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(paramters);
					num2 = (short)716701696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (paramters != null)
					{
						num2 = (short)1964048385;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				}
				goto IL_1C;
			}
			IL_86:
			num2 = (short)50331649;
			if (num2 != 0)
			{
			}
			num2 = (short)1277860986;
			short num3 = num2;
			num2 = (short)1104845946;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num2 = (short)1102512128;
				if (num2 != 0)
				{
				}
				num2 = (short)1490419712;
				short num4 = num2;
				break;
			}
			}
			IL_121:
			batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
			batchOperationJob.JobContainerUuid = new global::System.Guid?(jobContainerGuid);
			return batchOperationJob;
			IL_1C:
			batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
			batchOperationJob.JobDescription = jobDescription;
			batchOperationJob.ErrorCode = new int?((int)errCode);
			num2 = (short)1088028674;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
