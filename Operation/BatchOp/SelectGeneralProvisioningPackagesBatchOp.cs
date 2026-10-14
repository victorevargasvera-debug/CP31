using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000042 RID: 66
	public class SelectGeneralProvisioningPackagesBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000189 RID: 393 RVA: 0x00028B84 File Offset: 0x00026D84
		public SelectGeneralProvisioningPackagesBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> devices, global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage package)
		{
			base.SelectedItems = devices;
			this.a = package;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00028BA8 File Offset: 0x00026DA8
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1593216456;
				short num2 = num;
				num = (short)521244104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1862008832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844431361;
				if (num != 0)
				{
				}
				num = (short)289538048;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectGeneralPackage;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00028C54 File Offset: 0x00026E54
		public override string JobName
		{
			get
			{
				short num = (short)670954039;
				short num2 = num;
				num = (short)1556869687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)266862592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975241217;
				if (num != 0)
				{
				}
				num = (short)1907228672;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.SelectProvisioningPackageJobName;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00028D00 File Offset: 0x00026F00
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)9961472;
			switch (num)
			{
			default:
			{
				num = (short)362479617;
				if (num != 0)
				{
				}
				num = (short)2078605312;
				short num2 = num;
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)481951752;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)1619591173;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_1B7;
								}
								global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
								for (;;)
								{
									IL_1A0:
									switch (num4)
									{
									case 0:
										goto IL_2AE;
									case 1:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = radioSummary.ToUiModel(true);
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
										{
											item
										});
										num = (short)818282496;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_2C7;
									case 3:
										if (radioSummary != null)
										{
											num = (short)867696641;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2AE;
									}
									goto IL_1B7;
									IL_2AE:
									num = (short)93913090;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_2C7:
								goto IL_E8;
								IL_1B7:
								global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
								validateEntitySet.RelatedObject = radioBase.ID;
								validateEntitySet.ValidateEntityList.Add(new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField(radioBase.ID.Value, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio, radioBase.RadioTimestamp));
								global::System.Collections.Generic.List<global::System.Guid> packageUuids = new global::System.Collections.Generic.List<global::System.Guid>
								{
									this.a.Uuid
								};
								radioSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ApplyGeneralPackagesToRadio(base.JobContainerGuid, radioBase.ID.Value, packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.GeneralPackage, this.a.Name, validateEntitySet);
								num = (short)1776615427;
								num4 = (int)((global::System.IntPtr)num);
								goto IL_1A0;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
								batchOperationJob.ErrorMessage = ex.Message;
								if (ex.CommonExceptionData != null)
								{
									batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								}
								batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
								batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
								global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(batchOperationJob);
								goto IL_E8;
							}
							goto IL_34C;
							IL_E8:
							base.ReportProgress(++num3);
							num = (short)670367747;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)58458119;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (base.CancellationPending)
							{
								num = (short)1428029440;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_34C;
						case 5:
							goto IL_E3;
						case 6:
						{
							IL_16E:
							if (!enumerator.MoveNext())
							{
								num = (short)385875970;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							num = (short)10813444;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_3CD;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_C7;
							}
							continue;
						}
						goto IL_C7;
						IL_34C:
						num = (short)573131707;
						short num5 = num;
						num = (short)439438267;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16E;
						default:
							num = (short)495583232;
							if (num != 0)
							{
							}
							num = (short)1816788993;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_156:
						num = (short)1985675270;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_C7:
						goto IL_156;
					}
					IL_E3:
					IL_3CD:;
				}
				finally
				{
					num = (short)618790914;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)79167489;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_43A;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_402;
							}
							continue;
						}
						IL_402:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1811742720;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_43A:;
				}
				return;
			}
			}
		}

		// Token: 0x0400007D RID: 125
		private global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage a;
	}
}
