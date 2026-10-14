using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200004C RID: 76
	public class DeletePackageBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase>
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0002C000 File Offset: 0x0002A200
		public DeletePackageBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase> rds)
		{
			base.SelectedItems = rds;
			if (base.SelectedItems.Count > 0)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase = base.SelectedItems[0];
				if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware)
				{
					this.a = global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware;
					return;
				}
				if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack)
				{
					this.a = global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.LanguagePack;
					return;
				}
				if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement)
				{
					this.a = global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.VoiceAnnouncement;
					return;
				}
				if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates)
				{
					this.a = global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.CACertificates;
					return;
				}
				if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles)
				{
					this.a = global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.DVRSFiles;
					return;
				}
				if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech)
				{
					this.a = global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.TextToSpeech;
					return;
				}
				if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage)
				{
					this.a = global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.GeneralPackage;
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0002C0BC File Offset: 0x0002A2BC
		public override bool IsSafe
		{
			get
			{
				short num = (short)477711678;
				short num2 = num;
				num = (short)734809406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)742391808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)230096896;
				if (num != 0)
				{
				}
				num = (short)381943809;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0002C164 File Offset: 0x0002A364
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1899825357;
				short num2 = num;
				num = (short)443680973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1254096896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533266433;
				if (num != 0)
				{
				}
				num = (short)762118144;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeletePackage;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0002C20C File Offset: 0x0002A40C
		public override string JobName
		{
			get
			{
				short num = (short)41680896;
				short num2 = num;
				num = (short)1591168350;
				short num3 = num;
				num = (short)209669470;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_10F:
					num = (short)813236226;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)682295296;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_90;
					}
					break;
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType;
				for (;;)
				{
					IL_7E:
					switch (num4)
					{
					case 0:
						switch (packageType)
						{
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware:
							goto IL_11D;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Codeplug:
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.FirmwareCodeplugPairGroup:
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.ApplicationShortcut:
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.ApplicationWidget:
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.FirmwareCodeplugPairGroupDontParseFirmware:
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Cps20TextToSpeech:
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.TtsVoiceAnnouncement:
							goto IL_18E;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.VoiceAnnouncement:
							goto IL_188;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.TextToSpeech:
							goto IL_15A;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.LanguagePack:
							goto IL_154;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.GeneralPackage:
							goto IL_111;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Application:
							goto IL_142;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.HomeSetPackage:
							goto IL_123;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Certificate:
							goto IL_148;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.CACertificates:
							goto IL_14E;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.DVRSFiles:
							goto IL_117;
						default:
							num = (short)772276225;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 1:
						goto IL_10F;
					case 2:
						goto IL_140;
					}
					goto IL_90;
				}
				IL_111:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_ProvisioningPackage;
				IL_117:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_DVRSFiles;
				IL_11D:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_FirmwarePackage;
				IL_123:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_HomeSetPackage;
				IL_140:
				goto IL_18E;
				IL_142:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_ApplicationPackage;
				IL_148:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_CertificatePackage;
				IL_14E:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_CACertificates;
				IL_154:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_LanguagePackage;
				IL_15A:
				num = (short)220659713;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_TextToSpeech;
				IL_188:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Delete_VoiceAnnouncement;
				IL_18E:
				return string.Empty;
				IL_90:
				packageType = this.a;
				num = (short)50659328;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7E;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0002C3AC File Offset: 0x0002A5AC
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)778436608;
			short num2 = num;
			num = (short)1887174656;
			switch (num)
			{
			default:
			{
				num = (short)848822273;
				if (num != 0)
				{
				}
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase> enumerator = base.SelectedItems.GetEnumerator();
				goto IL_80;
				try
				{
					for (;;)
					{
						IL_80:
						num = (short)300679173;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1874198535;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase = enumerator.Current;
								global::Motorola.CommonCPS.Server.EntityModel.Package package = packageBase.ToServerModel();
								num = (short)87425026;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_E6;
							case 2:
								if (base.CancellationPending)
								{
									num = (short)622788614;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_732;
							case 4:
								try
								{
									num = (short)1954480130;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase;
										switch (num4)
										{
										case 0:
											if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack)
											{
												num = (short)1638137881;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)772734993;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											packageBase.Name = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GenerateTTSGUIName(packageBase.Name);
											num = (short)1209794566;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_27E;
											}
											continue;
										case 3:
											if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage)
											{
												num = (short)1484455957;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_687;
										case 4:
											goto IL_687;
										case 5:
											goto IL_687;
										case 6:
											goto IL_5B2;
										case 7:
											if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech)
											{
												num = (short)360513556;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)507510787;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
											num = (short)1405157388;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 9:
											goto IL_687;
										case 10:
											goto IL_687;
										case 11:
											goto IL_687;
										case 12:
											if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware)
											{
												num = (short)283181072;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1372979200;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 13:
										{
											global::Motorola.CommonCPS.Server.EntityModel.Package package;
											base.ViewCacheNotifier.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement>(new global::System.Collections.Generic.List<global::System.Guid>
											{
												package.Uuid
											});
											num = (short)1468203012;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 14:
										{
											global::Motorola.CommonCPS.Server.EntityModel.Package package;
											base.ViewCacheNotifier.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates>(new global::System.Collections.Generic.List<global::System.Guid>
											{
												package.Uuid
											});
											num = (short)2027618319;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 15:
											goto IL_687;
										case 16:
										{
											global::Motorola.CommonCPS.Server.EntityModel.Package package;
											base.ViewCacheNotifier.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(new global::System.Collections.Generic.List<global::System.Guid>
											{
												package.Uuid
											});
											num = (short)119930885;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 17:
											if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement)
											{
												num = (short)1455489037;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)657391634;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 18:
											if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates)
											{
												num = (short)1380319246;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)952369176;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 19:
										{
											global::Motorola.CommonCPS.Server.EntityModel.Package package;
											base.ViewCacheNotifier.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles>(new global::System.Collections.Generic.List<global::System.Guid>
											{
												package.Uuid
											});
											num = (short)452460553;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 20:
										{
											global::Motorola.CommonCPS.Server.EntityModel.Package package;
											base.ViewCacheNotifier.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech>(new global::System.Collections.Generic.List<global::System.Guid>
											{
												package.Uuid
											});
											num = (short)1790115863;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 21:
										{
											global::Motorola.CommonCPS.Server.EntityModel.Package package;
											base.ViewCacheNotifier.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>(new global::System.Collections.Generic.List<global::System.Guid>
											{
												package.Uuid
											});
											num = (short)395968522;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 22:
										{
											global::Motorola.CommonCPS.Server.EntityModel.Package package;
											if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.DeletePackages(new global::System.Guid?(base.JobContainerGuid), package, packageBase.Name))
											{
												num = (short)15269896;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_687;
										}
										case 23:
											goto IL_687;
										case 24:
											if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles)
											{
												num = (short)1101332499;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1322778631;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 25:
										{
											global::Motorola.CommonCPS.Server.EntityModel.Package package;
											base.ViewCacheNotifier.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>(new global::System.Collections.Generic.List<global::System.Guid>
											{
												package.Uuid
											});
											num = (short)311558155;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 26:
											goto IL_6A0;
										}
										IL_27E:
										if (packageBase is global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech)
										{
											num = (short)1662386177;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_5B2:
										num = (short)1812725782;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_687:
										num = (short)492765210;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_6A0:
									goto IL_137;
								}
								catch (global::Motorola.Common.CustomException.CommonException ex)
								{
									global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob();
									global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase;
									batchOperationJob.JobDescription = packageBase.Name;
									batchOperationJob.ErrorCode = new int?((int)ex.ErrorCode);
									batchOperationJob.ErrorMessage = ex.Message;
									if (ex.CommonExceptionData != null)
									{
										batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
									}
									batchOperationJob.JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
									batchOperationJob.JobContainerUuid = new global::System.Guid?(base.JobContainerGuid);
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.AddBatchOperationJob(batchOperationJob);
									goto IL_137;
								}
								goto IL_732;
								IL_137:
								num3++;
								base.ReportProgress(num3);
								num = (short)1365377027;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_CB;
								}
								continue;
							case 6:
								num = (short)1461321729;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								num = (short)940441608;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_769;
							}
							IL_1AA:
							num = (short)1143078912;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_CB:
							goto IL_1AA;
							IL_732:
							num = (short)970784772;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_E6:
						num = (short)1164059866;
						short num5 = num;
						num = (short)1511531738;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_11B;
						}
					}
					IL_11B:
					num = (short)1197211648;
					if (num != 0)
					{
					}
					IL_769:;
				}
				finally
				{
					num = (short)2130837504;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_79E;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1242038274;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_7D3;
						}
						IL_79E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)596901889;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_7D3:;
				}
				return;
			}
			}
		}

		// Token: 0x0400008F RID: 143
		private global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType a;
	}
}
