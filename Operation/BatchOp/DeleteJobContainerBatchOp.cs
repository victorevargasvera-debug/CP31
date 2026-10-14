using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000036 RID: 54
	public class DeleteJobContainerBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>
	{
		// Token: 0x06000167 RID: 359 RVA: 0x000260D0 File Offset: 0x000242D0
		public DeleteJobContainerBatchOp(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> jobContainerList)
		{
			base.SelectedItems = jobContainerList;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000260EC File Offset: 0x000242EC
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)903596930;
				short num2 = num;
				num = (short)1530121090;
				switch (num2 == num)
				{
				}
				num = (short)1395589120;
				short num3 = num;
				num = (short)2116288513;
				if (num != 0)
				{
				}
				num = (short)2046558208;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteJobContainer;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00026194 File Offset: 0x00024394
		public override string JobName
		{
			get
			{
				short num = (short)264064828;
				short num2 = num;
				num = (short)91377468;
				switch (num2 == num)
				{
				}
				num = (short)1248460800;
				short num3 = num;
				num = (short)873594881;
				if (num != 0)
				{
				}
				num = (short)161808384;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteJobContainer;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00026240 File Offset: 0x00024440
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)250478592;
			switch (num)
			{
			default:
			{
				num = (short)1839792128;
				short num2 = num;
				num = (short)381353985;
				if (num != 0)
				{
				}
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1130627078;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (base.CancellationPending)
							{
								num = (short)699334661;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_295;
						case 2:
							goto IL_E5;
						case 3:
							try
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer;
								global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet(jobContainer.ID.Value, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.JobContainer);
								validateEntitySet.ValidateEntityList.Add(new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField(jobContainer.ID.Value, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.JobContainer, jobContainer.TimeStamp));
								global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).DeleteJobContainer(base.JobContainerGuid, jobContainer.ID.Value, validateEntitySet, jobContainer.ContainerName);
								goto IL_EA;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer;
								batchOperationJob.JobDescription = jobContainer.ContainerName;
								batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
								batchOperationJob.ErrorMessage = ex.Message;
								if (ex.CommonExceptionData != null)
								{
									batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								}
								batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
								batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
								global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
								radioService.AddBatchOperationJob(batchOperationJob);
								num3++;
								base.ReportProgress(num3);
								break;
							}
							goto IL_295;
							IL_EA:
							num3++;
							base.ReportProgress(num3);
							num = (short)667156481;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1809055751;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer = enumerator.Current;
							num = (short)1849032704;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1105592322;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							IL_96:
							switch (0)
							{
							case 0:
								goto IL_CB;
							}
							continue;
						case 7:
							num = (short)105644040;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_322;
						}
						IL_155:
						num = (short)611581956;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_CB:
						goto IL_155;
						IL_295:
						num = (short)260220405;
						short num5 = num;
						num = (short)1238214133;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_96;
						default:
						{
							num = (short)1234698240;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
							num = (short)877658115;
							num4 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_E5:
					IL_322:;
				}
				finally
				{
					num = (short)1725759488;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_358;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)876216322;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_38F;
						}
						IL_358:
						if (enumerator == null)
						{
							break;
						}
						num = (short)127008769;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_38F:;
				}
				return;
			}
			}
		}
	}
}
