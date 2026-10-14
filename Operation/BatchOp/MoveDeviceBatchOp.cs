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
	// Token: 0x02000041 RID: 65
	public class MoveDeviceBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000184 RID: 388 RVA: 0x000283E0 File Offset: 0x000265E0
		public MoveDeviceBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> devices, global::Motorola.CommonCPS.RadioManagement.UIModels.Group targetGroup)
		{
			base.SelectedItems = devices;
			this.a = targetGroup;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00028404 File Offset: 0x00026604
		public override bool IsSafe
		{
			get
			{
				short num = (short)1220272812;
				short num2 = num;
				num = (short)1435755180;
				switch (num2 == num)
				{
				}
				num = (short)46923777;
				if (num != 0)
				{
				}
				num = (short)1155072000;
				short num3 = num;
				num = (short)1857421312;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000284B4 File Offset: 0x000266B4
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)246964758;
				short num2 = num;
				num = (short)1853055510;
				switch (num2 == num)
				{
				}
				num = (short)2115960832;
				if (num != 0)
				{
				}
				num = (short)986841088;
				short num3 = num;
				num = (short)551682049;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.MoveDevices;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0002855C File Offset: 0x0002675C
		public override string JobName
		{
			get
			{
				short num = (short)1174805754;
				short num2 = num;
				num = (short)1069817082;
				switch (num2 == num)
				{
				}
				num = (short)875429888;
				if (num != 0)
				{
				}
				num = (short)1902182400;
				short num3 = num;
				num = (short)496500737;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.MoveDevicesJobName;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00028608 File Offset: 0x00026808
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)524288;
			switch (num)
			{
			default:
			{
				int num2 = 0;
				bool flag = false;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1770455047;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_45D;
						case 1:
							goto IL_443;
						case 2:
							goto IL_A1;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1195311108;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							num = (short)1308164107;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)794886153;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)581566466;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_87;
							}
							continue;
						case 8:
						{
							if (flag)
							{
								num = (short)1954283521;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
							global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = null;
							num = (short)205651978;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_47A;
						case 10:
							try
							{
								num = (short)1675558917;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
									global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
									switch (num3)
									{
									case 0:
										goto IL_2D4;
									case 1:
										radioSummary = radioService.MoveDeviceToGroupBatch(base.JobContainerGuid, radioBase.ToServerModel(), this.a);
										num = (short)1740963840;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::System.Guid? id = this.a.ID;
										num = (short)1036845059;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::System.Guid? id;
										if (id != null)
										{
											num = (short)467599361;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_224;
									}
									case 4:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = radioSummary.ToUiModel(true);
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
										{
											item
										});
										num = (short)987430918;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_205;
										}
										continue;
									case 6:
										goto IL_348;
									case 7:
										goto IL_361;
									case 8:
										if (radioSummary != null)
										{
											num = (short)1499463684;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_348;
									case 9:
										goto IL_2D4;
									}
									IL_205:
									if (this.a != null)
									{
										num = (short)473038850;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_224:
									radioSummary = radioService.MoveDeviceToGroupBatch(base.JobContainerGuid, radioBase.ToServerModel(), null);
									num = (short)1672478729;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_2D4:
									num = (short)842530824;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_348:
									num = (short)381157383;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_361:
								goto IL_A6;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
								batchOperationJob.JobDescription = radioBase.SerialNumber;
								batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
								batchOperationJob.ErrorMessage = ex.Message;
								if (ex.CommonExceptionData == null)
								{
									goto IL_3C2;
								}
								IL_3A8:
								batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								IL_3C2:
								num = (short)146941330;
								short num4 = num;
								num = (short)1227957650;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_3A8;
								default:
								{
									num = (short)1343815680;
									if (num != 0)
									{
									}
									batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
									batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
									global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
									radioService.AddBatchOperationJob(batchOperationJob);
									num2++;
									base.ReportProgress(num2);
									goto IL_111;
								}
								}
							}
							goto IL_443;
							IL_A6:
							num2++;
							base.ReportProgress(num2);
							num = (short)1613955078;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (base.CancellationPending)
							{
								num = (short)959315973;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2080636936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_111:
						num = (short)1030094851;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_87:
						goto IL_111;
						IL_443:
						num = (short)298385408;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_A1:
					IL_45D:
					IL_47A:;
				}
				finally
				{
					num = (short)237764610;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_4E5;
						case 1:
							enumerator.Dispose();
							num = (short)1489895424;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_4AF;
							}
							continue;
						}
						IL_4AF:
						if (enumerator == null)
						{
							break;
						}
						num = (short)808124417;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_4E5:;
				}
				num = (short)1987444737;
				if (num != 0)
				{
				}
				num = (short)38010880;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x0400007C RID: 124
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group a;
	}
}
