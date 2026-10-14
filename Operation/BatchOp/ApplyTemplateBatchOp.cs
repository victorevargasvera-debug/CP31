using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Enums;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000045 RID: 69
	public class ApplyTemplateBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00029C04 File Offset: 0x00027E04
		public ApplyTemplateBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios, global::System.Guid selTemplateID, global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType cmdType)
		{
			this.TargetDevices = radios;
			this.SelectedTemplateID = selTemplateID;
			base.SelectedItems = radios;
			this.CmdType = cmdType;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00029C34 File Offset: 0x00027E34
		public ApplyTemplateBatchOp()
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00029C48 File Offset: 0x00027E48
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00029CF8 File Offset: 0x00027EF8
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> TargetDevices
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1501359735;
				short num2 = num;
				num = (short)1238101623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)452657152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)443154432;
				if (num != 0)
				{
				}
				num = (short)1563033601;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)708353403;
				short num2 = num;
				num = (short)1345625467;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1479671808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1403060225;
				if (num != 0)
				{
				}
				num = (short)2075787264;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00029DA8 File Offset: 0x00027FA8
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00029E54 File Offset: 0x00028054
		public global::System.Guid SelectedTemplateID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)138296;
				short num2 = num;
				num = (short)912071736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1995309056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1470234625;
				if (num != 0)
				{
				}
				num = (short)267386880;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)434170900;
				short num2 = num;
				num = (short)1098181652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)75759616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1877409793;
				if (num != 0)
				{
				}
				num = (short)69533696;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00029F08 File Offset: 0x00028108
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00029FB8 File Offset: 0x000281B8
		public global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType CmdType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1230581126;
				short num2 = num;
				num = (short)1452617094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1276641280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1202847744;
				if (num != 0)
				{
				}
				num = (short)2061369345;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1043940623;
				short num2 = num;
				num = (short)1200571663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1144324096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)19791873;
				if (num != 0)
				{
				}
				num = (short)1393098752;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0002A06C File Offset: 0x0002826C
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)2109180248;
				short num2 = num;
				num = (short)1959758168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)391380992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)996474881;
				if (num != 0)
				{
				}
				num = (short)726532096;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectTemplate;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0002A118 File Offset: 0x00028318
		public override string JobName
		{
			get
			{
				short num = (short)1792212993;
				if (num != 0)
				{
				}
				num = (short)1448542208;
				short num2 = num;
				num = (short)1201413613;
				short num3 = num;
				num = (short)1724063213;
				switch (num3 == num)
				{
				}
				num = (short)201850880;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.ApplyTemplateJobName;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0002A1C8 File Offset: 0x000283C8
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)1166016512;
			switch (num)
			{
			default:
			{
				num = (short)2099904513;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
				global::Motorola.CommonCPS.Server.EntityModel.Template templateRawData = templateService.GetTemplateRawData(this.SelectedTemplateID, true);
				int num2 = 0;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = this.TargetDevices.GetEnumerator();
				try
				{
					num = (short)1305542669;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_322;
								}
								global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
								global::System.Guid templateUuid;
								global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate radioInfoForApplyTemplate;
								global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySetForApplyTemplate;
								for (;;)
								{
									IL_2C7:
									bool flag;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> keyValuePair;
									bool flag2;
									switch (num3)
									{
									case 0:
										if (flag)
										{
											num = (short)1236008968;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_6AA;
									case 1:
										goto IL_6C3;
									case 2:
										goto IL_6AA;
									case 3:
									{
										global::System.Guid? guid = radioByDeviceUuid.WorkingCodeplug.TemplateUuid;
										num = (short)1583087629;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										if (flag)
										{
											num = (short)122028049;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_629;
									case 5:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase item = keyValuePair.Value.ToUiModel(true);
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
										{
											item
										});
										num = (short)701562882;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::System.Guid? guid = radioByDeviceUuid.WorkingCodeplug.TemplateUuid;
										templateUuid = guid.Value;
										num = (short)1886650388;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										if (keyValuePair.Key != null)
										{
											num = (short)225050642;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_44F;
									case 8:
										num = (short)343801866;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplateSummary(templateUuid);
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
										{
											templateSummary.ToUiModel(true)
										});
										num = (short)826081294;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										if (keyValuePair.Value != null)
										{
											num = (short)325648389;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_6AA;
									case 11:
										num = (short)1528299527;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
										goto IL_44F;
									case 13:
									{
										global::System.Guid? guid;
										if (guid != null)
										{
											num = (short)2101739526;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_37E;
									}
									case 14:
										goto IL_629;
									case 15:
										if (templateUuid != global::System.Guid.Empty)
										{
											num = (short)1421213705;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_629;
									case 16:
										if (radioByDeviceUuid.WorkingCodeplug != null)
										{
											num = (short)1223950339;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_37E;
									case 17:
										num = (short)1481310223;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item2 = keyValuePair.Key.ToUiModel(true);
										base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
										{
											item2
										});
										num = (short)278790156;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 19:
										if (flag2)
										{
											num = (short)1134166027;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_44F;
									case 20:
										goto IL_37E;
									}
									goto IL_322;
									IL_37E:
									flag = base.ViewCacheNotifier.CheckViewCacheListsTypeMatch(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase));
									flag2 = base.ViewCacheNotifier.CheckViewCacheListsTypeMatch(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase));
									keyValuePair = templateService.ApplyTemplateToRadio(base.JobContainerGuid, templateRawData.Uuid, radioInfoForApplyTemplate, radioByDeviceUuid.SerialNumber, validateEntitySetForApplyTemplate, flag, flag2);
									num = (short)1392705540;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_44F:
									num = (short)2081095680;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_629:
									num = (short)566099987;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_6AA:
									num = (short)6225921;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_6C3:
								goto IL_294;
								IL_322:
								radioInfoForApplyTemplate = templateService.GetRadioInfoForApplyTemplate(radioByDeviceUuid, templateRawData);
								validateEntitySetForApplyTemplate = templateService.GetValidateEntitySetForApplyTemplate(radioByDeviceUuid, templateRawData);
								templateUuid = global::System.Guid.Empty;
								num = (short)23592976;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_2C7;
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
								batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
								batchOperationJob.JobDescription = radioBase.SerialNumber;
								templateService.AddBatchOperationJob(batchOperationJob);
								goto IL_294;
							}
							goto IL_745;
							IL_294:
							num2++;
							base.ReportProgress(num2);
							num = (short)449118223;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (base.CancellationPending)
							{
								num = (short)1692794896;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)110362628;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							templateService.AddBatchOperationJob(new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
							{
								JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
								ErrorCode = new int?(2119),
								JobDescription = radioBase.SerialNumber,
								Parameters = string.Empty,
								JobContainerUuid = new global::System.Guid?(base.JobContainerGuid)
							});
							num = (short)924188675;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							if (templateRawData == null)
							{
								num = (short)756350985;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_745;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)16777227;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
							goto IL_7F2;
						}
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							string empty;
							templateService.AddBatchOperationJob(new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
							{
								JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
								ErrorCode = new int?(2050),
								ErrorMessage = empty,
								JobDescription = radioBase.SerialNumber,
								Parameters = string.Empty,
								JobContainerUuid = new global::System.Guid?(base.JobContainerGuid)
							});
							num = (short)644218887;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							templateService.AddBatchOperationJob(new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
							{
								JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
								ErrorCode = new int?(2120),
								ErrorMessage = global::System.Enum.GetName(typeof(global::Motorola.Common.CustomException.CommonErrorCode), global::Motorola.Common.CustomException.CommonErrorCode.RMC_TemplateNotExist),
								JobDescription = radioBase.SerialNumber,
								Parameters = string.Empty,
								JobContainerUuid = new global::System.Guid?(base.JobContainerGuid)
							});
							num2++;
							base.ReportProgress(num2);
							num = (short)19398664;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_93A;
						case 11:
							num = (short)1543897098;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							string empty;
							if (!templateService.PrecheckForApplyTemplate(templateRawData, radioByDeviceUuid, this.CmdType, templateRawData.Uuid, radioBase, out empty))
							{
								num = (short)1494548486;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1973420032;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							switch (0)
							{
							case 0:
								goto IL_DC;
							}
							continue;
						case 14:
							goto IL_134;
						case 16:
							num = (short)1913126926;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid;
							if (radioByDeviceUuid == null)
							{
								num = (short)1876426754;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string empty = string.Empty;
							num = (short)322109452;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_157:
						num = (short)2022178821;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DC:
						goto IL_157;
						IL_745:
						num = (short)2012818533;
						short num4 = num;
						num = (short)70069349;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_7F2:
							num = (short)1593704449;
							num3 = (int)((global::System.IntPtr)num);
							break;
						default:
						{
							num = (short)1393491968;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
							global::System.Guid? guid = radioBase.ID;
							global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid = instance.GetRadioByDeviceUuid(guid.Value, false);
							num = (short)1932263441;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_134:
					IL_93A:;
				}
				finally
				{
					num = (short)692387840;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_96E;
							}
							continue;
						case 1:
							goto IL_9A3;
						case 2:
							enumerator.Dispose();
							num = (short)2006908929;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_96E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1874591746;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_9A3:;
				}
				num = (short)1999503360;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x04000082 RID: 130
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> a;

		// Token: 0x04000083 RID: 131
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid b;

		// Token: 0x04000084 RID: 132
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType c;
	}
}
