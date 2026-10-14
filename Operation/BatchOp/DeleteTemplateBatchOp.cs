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
	// Token: 0x02000053 RID: 83
	public class DeleteTemplateBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00030E04 File Offset: 0x0002F004
		public DeleteTemplateBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> selTemplates)
		{
			base.SelectedItems = selTemplates;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00030E20 File Offset: 0x0002F020
		public DeleteTemplateBatchOp()
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00030E34 File Offset: 0x0002F034
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)741419431;
				short num2 = num;
				num = (short)570173863;
				switch (num2 == num)
				{
				}
				num = (short)1926758401;
				if (num != 0)
				{
				}
				num = (short)674299904;
				if (num != 0)
				{
				}
				num = (short)614072320;
				short num3 = num;
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteTemplate;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00030EE4 File Offset: 0x0002F0E4
		public override string JobName
		{
			get
			{
				short num = (short)16739982;
				short num2 = num;
				num = (short)1318940302;
				switch (num2 == num)
				{
				}
				num = (short)482017281;
				if (num != 0)
				{
				}
				num = (short)1266417664;
				if (num != 0)
				{
				}
				num = (short)206307328;
				short num3 = num;
				return global::Motorola.CommonCPS.ResourceRepository.Resources.Delete_Template;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00030F94 File Offset: 0x0002F194
		public override bool IsSafe
		{
			get
			{
				short num = (short)1169224785;
				short num2 = num;
				num = (short)639431761;
				switch (num2 == num)
				{
				}
				num = (short)2077884417;
				if (num != 0)
				{
				}
				num = (short)1004470272;
				if (num != 0)
				{
				}
				num = (short)444137472;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0003103C File Offset: 0x0002F23C
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)204996608;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
				int num2 = 0;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)1447624708;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							num = (short)1489436680;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2B8;
						case 3:
							try
							{
								num = (short)1737097219;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase;
									switch (num3)
									{
									case 0:
										goto IL_1F7;
									case 1:
										base.ViewCacheNotifier.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Collections.Generic.List<global::System.Guid>
										{
											templateBase.TemplateID
										});
										num = (short)1658191874;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_1DF;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_186;
										}
										continue;
									}
									IL_186:
									if (templateService.DeleteTemplate(base.JobContainerGuid, templateBase))
									{
										num = (short)659619841;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1DF:
									num = (short)488636416;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1F7:
								goto IL_A3;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
								batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
								batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
								batchOperationJob.ErrorMessage = ex.Message;
								global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase;
								batchOperationJob.JobDescription = templateBase.Name;
								if (ex.CommonExceptionData != null)
								{
									batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
								}
								batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
								templateService.AddBatchOperationJob(batchOperationJob);
								goto IL_A3;
							}
							goto IL_280;
							IL_A3:
							num2++;
							base.ReportProgress(num2);
							num = (short)463405056;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_83;
							}
							continue;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1225261063;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase = enumerator.Current;
							num = (short)1978138630;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (base.CancellationPending)
							{
								num = (short)730267649;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_280;
						case 7:
							num = (short)715980802;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_9E;
						}
						IL_10D:
						num = (short)1586626565;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_83:
						goto IL_10D;
						IL_280:
						num = (short)1707540483;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_9E:
					IL_2B8:;
				}
				finally
				{
					num = (short)924319746;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_327;
						case 1:
							enumerator.Dispose();
							num = (short)994050048;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2F0;
							}
							continue;
						}
						IL_2F0:
						if (enumerator != null)
						{
							num = (short)1958477825;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_327:
						num = (short)1681275846;
						short num4 = num;
						num = (short)845495238;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2F0;
						default:
							goto IL_35B;
						}
					}
					IL_35B:
					num = (short)1624899584;
					if (num != 0)
					{
					}
				}
				num = (short)1637416961;
				if (num != 0)
				{
				}
				num = (short)1717764096;
				short num5 = num;
				return;
			}
			}
		}
	}
}
