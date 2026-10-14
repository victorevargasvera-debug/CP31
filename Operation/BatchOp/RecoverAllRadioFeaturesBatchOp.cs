using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using EntityModel.GenericModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200002C RID: 44
	public class RecoverAllRadioFeaturesBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00022374 File Offset: 0x00020574
		public RecoverAllRadioFeaturesBatchOp()
		{
			global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode;
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
			{
				workMode = global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template;
				goto IL_13D;
			}
			IL_137:
			workMode = global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration;
			IL_13D:
			this.b = workMode;
			base..ctor();
			int num = 0;
			int num2 = 0;
			try
			{
				num = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetRadioCount(null, this.b, false);
				for (int i = 0; i < num; i += this.a)
				{
					for (;;)
					{
						using (global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioSummaries(i, this.a, null, this.b).GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = enumerator.Current;
								int? productFamily = radioSummary.ProductFamily;
								int num3 = 512;
								if (!(productFamily.GetValueOrDefault() == num3 & productFamily != null))
								{
									productFamily = radioSummary.ProductFamily;
									num3 = 1024;
									if (!(productFamily.GetValueOrDefault() == num3 & productFamily != null))
									{
										productFamily = radioSummary.ProductFamily;
										num3 = 2048;
										if (!(productFamily.GetValueOrDefault() == num3 & productFamily != null))
										{
											continue;
										}
									}
								}
								num2++;
							}
							break;
						}
					}
				}
				goto IL_151;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				num = 1;
				num2 = 0;
				goto IL_151;
			}
			goto IL_137;
			IL_151:
			this.TotalRadioCount = num;
			base.SelectedItems = new string[num - num2].ToList<string>();
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00022520 File Offset: 0x00020720
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000225D0 File Offset: 0x000207D0
		public int TotalRadioCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)141455489;
				short num2 = num;
				num = (short)2022535297;
				switch (num2 == num)
				{
				}
				num = (short)828440577;
				if (num != 0)
				{
				}
				num = (short)631635968;
				short num3 = num;
				num = (short)1880752128;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)908941765;
				short num2 = num;
				num = (short)1701403077;
				switch (num2 == num)
				{
				}
				num = (short)2137980929;
				if (num != 0)
				{
				}
				num = (short)2126381056;
				short num3 = num;
				num = (short)203948032;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00022684 File Offset: 0x00020884
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1196890126;
				short num2 = num;
				num = (short)1591875598;
				switch (num2 == num)
				{
				}
				num = (short)1652752384;
				if (num != 0)
				{
				}
				num = (short)913833984;
				short num3 = num;
				num = (short)807272449;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RecoverRadioLicense;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00022734 File Offset: 0x00020934
		public override string JobName
		{
			get
			{
				short num = (short)1545344245;
				short num2 = num;
				num = (short)899683573;
				switch (num2 == num)
				{
				}
				num = (short)1570701313;
				if (num != 0)
				{
				}
				num = (short)1280180224;
				short num3 = num;
				num = (short)127860736;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_RecoverRadioLicense;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000227E4 File Offset: 0x000209E4
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)1904869376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num3;
				int num5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_12D;
					case 1:
						goto IL_F0;
					case 2:
					{
						if (num3 >= this.TotalRadioCount)
						{
							num = (short)191102976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioSummaries(num3, this.a, null, this.b).GetEnumerator();
						num = (short)446562308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_F0;
					case 4:
						try
						{
							num = (short)1402273805;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6F2;
								case 1:
									goto IL_236;
								case 2:
									num = (short)298254348;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
									int? productFamily = radioSummary.ProductFamily;
									int num4 = 1024;
									num = (short)923271182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									int? productFamily;
									int num4;
									if (!(productFamily.GetValueOrDefault() == num4 & productFamily != null))
									{
										num = (short)649723906;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_70B;
								case 6:
								{
									if (base.CancellationPending)
									{
										num = (short)1088356363;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
									int? productFamily = radioSummary.ProductFamily;
									int num4 = 512;
									num = (short)1291517959;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									int? productFamily;
									int num4;
									if (!(productFamily.GetValueOrDefault() == num4 & productFamily != null))
									{
										num = (short)1420361731;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1979580416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = enumerator.Current;
									num = (short)71303174;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
									int? productFamily = radioSummary.ProductFamily;
									int num4 = 2048;
									num = (short)594542596;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)368771073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_3EC;
										}
										global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
										global::EntityModel.GenericModel.CFSUpdateResult cfsupdateResult;
										string empty;
										for (;;)
										{
											IL_3D1:
											global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob;
											switch (num2)
											{
											case 0:
												goto IL_508;
											case 1:
												base.ViewCacheNotifier.CFSNotifyViewCacheLicenseChanged(cfsupdateResult, false);
												num = (short)499515394;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_43F;
											case 3:
												if (cfsupdateResult != null)
												{
													num = (short)2068774913;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_43F;
											case 4:
												batchOperationJob.WarningMessage = ((!string.IsNullOrEmpty(empty)) ? empty : string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Recover_DoRecover_Success, radioSummary.SerialNumber));
												global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.AddBatchOperationJob(batchOperationJob);
												num = (short)165675008;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_3EC;
											IL_43F:
											batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
											batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
											batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED;
											batchOperationJob.JobDescription = radioSummary.SerialNumber;
											num = (short)611188740;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_508:
										goto IL_23B;
										IL_3EC:
										empty = string.Empty;
										cfsupdateResult = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService.RecoverRadioLicense(radioSummary.SerialNumber, out empty);
										num = (short)2132934659;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_3D1;
									}
									catch (global::Motorola.Common.CustomException.CommonException ex)
									{
										global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob2 = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
										batchOperationJob2.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
										global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
										batchOperationJob2.JobDescription = radioSummary.SerialNumber;
										if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.SERVER_RADIOLICENSE_UPDATE_TO_DATE)
										{
											batchOperationJob2.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED;
											batchOperationJob2.JobDescription = radioSummary.SerialNumber;
											batchOperationJob2.WarningMessage = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.SERVER_RADIOLICENSE_UPDATE_TO_DATE, radioSummary.SerialNumber);
										}
										else if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Licenses_Recover_Com_BackOfficeServer_NullError)
										{
											batchOperationJob2.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED;
											batchOperationJob2.JobDescription = radioSummary.SerialNumber;
											batchOperationJob2.WarningMessage = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Recover_Com_BackOfficeServer_NullError, radioSummary.SerialNumber);
										}
										else if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Licenses_Recover_LicenseFeatureCompatibility_PACType)
										{
											batchOperationJob2.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED;
											batchOperationJob2.JobDescription = radioSummary.SerialNumber;
											batchOperationJob2.WarningMessage = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Recover_LicenseFeatureCompatibility_PACType, radioSummary.SerialNumber);
										}
										else
										{
											batchOperationJob2.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
											batchOperationJob2.ErrorCode = new int?((int)ex.ErrorCode);
											batchOperationJob2.ErrorMessage = ex.Message;
											if (ex.CommonExceptionData != null)
											{
												batchOperationJob2.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
											}
											batchOperationJob2.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
										}
										global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.AddBatchOperationJob(batchOperationJob2);
										goto IL_23B;
									}
									catch (global::System.Exception ex2)
									{
										global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob3 = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
										batchOperationJob3.ErrorCode = new int?(1);
										batchOperationJob3.ErrorMessage = ex2.Message;
										batchOperationJob3.Parameters = string.Empty;
										batchOperationJob3.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
										global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
										batchOperationJob3.JobDescription = radioSummary.SerialNumber;
										batchOperationJob3.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
										global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService.AddBatchOperationJob(batchOperationJob3);
										goto IL_23B;
									}
									goto IL_6F2;
									IL_23B:
									num5++;
									base.ReportProgress(num5);
									num = (short)163315720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									switch (0)
									{
									case 0:
										goto IL_1BE;
									}
									continue;
								case 14:
								{
									int? productFamily;
									int num4;
									if (!(productFamily.GetValueOrDefault() == num4 & productFamily != null))
									{
										num = (short)326434826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1C3:
								num = (short)2061434889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BE:
								goto IL_1C3;
								IL_6F2:
								num = (short)289144837;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_236:
							return;
							IL_70B:
							goto IL_89;
						}
						finally
						{
							num = (short)1008074753;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_77C;
								case 1:
									IL_725:
									switch (0)
									{
									case 0:
										goto IL_742;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)663748608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_742:
								if (enumerator != null)
								{
									num = (short)1922695170;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_77C:
								num = (short)301827770;
								short num6 = num;
								num = (short)280528570;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_725;
								default:
									goto IL_7B3;
								}
							}
							IL_7B3:
							num = (short)674037760;
							if (num != 0)
							{
							}
						}
						return;
						IL_89:
						num3 += this.a;
						num = (short)2063007745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42;
					IL_F0:
					num = (short)667680770;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12D:
				num = (short)1617035264;
				short num7 = num;
				return;
				IL_42:
				num = (short)1964900353;
				if (num != 0)
				{
				}
				num5 = 0;
				num3 = 0;
				num = (short)15532035;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0400005D RID: 93
		private int a = 100;

		// Token: 0x0400005E RID: 94
		private readonly global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode b;

		// Token: 0x0400005F RID: 95
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int c;
	}
}
