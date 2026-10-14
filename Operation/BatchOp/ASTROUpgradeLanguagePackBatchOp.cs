using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000028 RID: 40
	public class ASTROUpgradeLanguagePackBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>
	{
		// Token: 0x0600012B RID: 299 RVA: 0x000201D0 File Offset: 0x0001E3D0
		public ASTROUpgradeLanguagePackBatchOp(global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> selectedtemplateList)
		{
			base.SelectedItems = selectedtemplateList.ToList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>();
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000201F0 File Offset: 0x0001E3F0
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1280107026;
				short num2 = num;
				num = (short)1949032978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093219840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1714290689;
				if (num != 0)
				{
				}
				num = (short)1591672832;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeLanguagePack;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0002029C File Offset: 0x0001E49C
		public override string JobName
		{
			get
			{
				short num = (short)1030788527;
				short num2 = num;
				num = (short)1371575727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)288489472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)787283969;
				if (num != 0)
				{
				}
				num = (short)1486487552;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.UpgradeLanguagePackJobName;
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0002034C File Offset: 0x0001E54C
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)778567680;
			short num2 = num;
			num = (short)668467200;
			switch (num)
			{
			default:
			{
				int num3 = 0;
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>> enumerator = base.SelectedItems.GetEnumerator();
				try
				{
					num = (short)384958465;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)405965059;
						short num5 = num;
						num = (short)1538361603;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1156775936;
							if (num != 0)
							{
							}
							switch (num4)
							{
							case 0:
								if (base.CancellationPending)
								{
									num = (short)72482818;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_873;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_EB;
								}
								continue;
							case 2:
								num = (short)1269825544;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1489567750;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> keyValuePair = enumerator.Current;
								num = (short)719519744;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_216;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> keyValuePair;
									global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate key;
									for (;;)
									{
										IL_1C3:
										global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack latestASTROLPPackagesByFirmwareVersion;
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary> list;
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> list2;
										global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary;
										global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary;
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator2;
										switch (num4)
										{
										case 0:
											goto IL_83B;
										case 1:
											if (apxtemplate == null)
											{
												num = (short)3014663;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)593821705;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											if (latestASTROLPPackagesByFirmwareVersion == null)
											{
												num = (short)1593442308;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary>();
											list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet>
											{
												global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidateSet(apxtemplate, null)
											};
											num = (short)610336782;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											if (templateSummary != null)
											{
												num = (short)1900150800;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_83B;
										case 4:
											goto IL_3D5;
										case 5:
										{
											if (entitySummary.Uuid == templateSummary.Uuid)
											{
												num = (short)370737162;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplateSummary(entitySummary.Uuid);
											num = (short)701759500;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
											goto IL_7FC;
										case 7:
											goto IL_285;
										case 8:
											try
											{
												num = (short)86704130;
												num4 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
													global::Motorola.Common.CustomException.CommonExceptionData exceptionData;
													switch (num4)
													{
													case 0:
														goto IL_6F6;
													case 1:
														goto IL_695;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_4E2;
														}
														continue;
													case 3:
														goto IL_543;
													case 4:
														num = (short)1558183936;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 5:
														if (!base.ValidationServiceFactory.UIValidateService.CanCreateJob(radioBase.JobStatus))
														{
															num = (short)1809973256;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_695;
													case 6:
														if (radioBase != null)
														{
															num = (short)1220870147;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														break;
													case 8:
														exceptionData = new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_JOB_DEVICE_ALREADY_SCHEDULED_A_JOB, new string[]
														{
															radioBase.SerialNumber
														});
														num = (short)456523777;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 9:
														try
														{
															apxtemplate.ASTROLanguagePack = latestASTROLPPackagesByFirmwareVersion;
															global::Motorola.CommonCPS.RadioManagement.SharedServices.AutomaticUpgradeLPUtility.ValidateLanguagePackForApplyTemplateToRadio(apxtemplate, radioBase.FirmwareVersion);
															goto IL_608;
														}
														catch (global::Motorola.Common.CustomException.CommonException ex)
														{
															exceptionData = new global::Motorola.Common.CustomException.CommonExceptionData(ex.ErrorCode, new string[]
															{
																radioBase.SerialNumber
															});
															goto IL_608;
														}
														catch (global::System.Exception)
														{
															exceptionData = new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, new string[]
															{
																radioBase.SerialNumber
															});
															goto IL_608;
														}
														goto IL_543;
														IL_608:
														num = (short)1484521477;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 10:
														if (!enumerator2.MoveNext())
														{
															num = (short)1560936452;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														radioBase = enumerator2.Current;
														num = (short)2098200582;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_4E2;
													IL_543:
													global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary2 = new global::Motorola.CommonCPS.Server.EntityModel.EntitySummary();
													entitySummary2.Uuid = radioBase.DeviceUuid;
													entitySummary2.Name = radioBase.SerialNumber;
													exceptionData = null;
													num = (short)184221705;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_656:
													num = (short)1602420746;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_4E2:
													goto IL_656;
													IL_695:
													entitySummary2.ExceptionData = exceptionData;
													list.Add(entitySummary2);
													global::Motorola.CommonCPS.Server.EntityModel.Radio a_ = radioBase.ToServerModel();
													list2.Add(this.a(a_));
													num = (short)339083271;
													num4 = (int)((global::System.IntPtr)num);
												}
												IL_6F6:
												goto IL_731;
											}
											finally
											{
												((global::System.IDisposable)enumerator2).Dispose();
											}
											goto IL_706;
										case 9:
										{
											if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(apxtemplate.Timestamp, key.TimeStamp))
											{
												num = (short)1635778566;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											string lpid = ((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).AstroDecodeLanguageIndexToLPID(apxtemplate.LanguageIndex);
											latestASTROLPPackagesByFirmwareVersion = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetLatestASTROLPPackagesByFirmwareVersion(apxtemplate.FirmwareVersion, lpid);
											num = (short)1409155074;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 10:
											base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
											{
												templateSummary.ToUiModel(true)
											});
											num = (short)904593408;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 11:
											goto IL_853;
										case 12:
										{
											global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary2;
											if (templateSummary2 != null)
											{
												num = (short)1887371277;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_2C4;
										}
										case 13:
										{
											global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary2;
											base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
											{
												templateSummary2.ToUiModel(true)
											});
											num = (short)629669905;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 14:
											if (keyValuePair.Value != null)
											{
												num = (short)2002190351;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_731;
										case 15:
											goto IL_706;
										case 16:
											num = (short)344719365;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 17:
											goto IL_2C4;
										case 18:
											goto IL_83B;
										}
										goto IL_216;
										IL_2C4:
										base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
										{
											templateSummary.ToUiModel(true)
										});
										num = (short)1021313042;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_706:
										enumerator2 = keyValuePair.Value.GetEnumerator();
										num = (short)1700134920;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_731:
										entitySummary = new global::Motorola.CommonCPS.Server.EntityModel.EntitySummary();
										entitySummary.Uuid = apxtemplate.Uuid;
										entitySummary.Name = apxtemplate.Name;
										templateSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).UpgradeAPXTemplateLanguagePack(base.JobContainerGuid, entitySummary, latestASTROLPPackagesByFirmwareVersion.Uuid, list, list2);
										num = (short)1853685763;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_83B:
										num = (short)846331915;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_285:
									throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_TemplateNotExist, "", null);
									IL_3D5:
									throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_NO_MATCH_PACKAGE);
									IL_7FC:
									throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date, "", null);
									IL_853:
									goto IL_10D;
									IL_216:
									key = keyValuePair.Key;
									((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).AstroDecodeLanguageIndexToLPID(key.CPLanguageIndex);
									apxtemplate = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplate(key.TemplateID, true) as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
									num = (short)1434058753;
									num4 = (int)((global::System.IntPtr)num);
									goto IL_1C3;
								}
								catch (global::Motorola.Common.CustomException.CommonException exp)
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>> keyValuePair;
									base.CreateFailJob(exp, keyValuePair.Key.Name);
									goto IL_10D;
								}
								goto IL_873;
								IL_10D:
								num3++;
								base.ReportProgress(num3);
								num = (short)1857159173;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)1458765831;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_8AA;
							case 8:
								goto IL_108;
							}
							IL_EB:
							break;
							IL_873:
							num = (short)1083899908;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_179:
						num = (short)1153695747;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						goto IL_179;
					}
					IL_108:
					IL_8AA:;
				}
				finally
				{
					num = (short)1150025729;
					if (num != 0)
					{
					}
					num = (short)573440001;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)691929090;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_908;
							}
							continue;
						case 2:
							goto IL_940;
						}
						IL_908:
						if (enumerator == null)
						{
							break;
						}
						num = (short)897122304;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_940:;
				}
				return;
			}
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00020D18 File Offset: 0x0001EF18
		private global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Guid? guid;
				switch (num)
				{
				case 0:
					goto IL_1DD;
				case 1:
					return validateSet;
				case 2:
				{
					num2 = (short)226735046;
					short num3 = num2;
					num2 = (short)472888262;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return validateSet;
					default:
						num2 = (short)239075328;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateSet.ValidateEntityList, A_0.CurrentCodeplug);
						num2 = (short)1201471494;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (A_0.LastJob != null)
					{
						num2 = (short)1739456517;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1DD;
				case 4:
				{
					num2 = (short)550109184;
					short num4 = num2;
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateSet.ValidateEntityList, A_0.WorkingCodeplug);
					num2 = (short)1035075585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateSet.ValidateEntityList, A_0.LastJob);
					num2 = (short)926089216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1842806785;
					if (num2 != 0)
					{
					}
					goto IL_76;
				case 7:
					if (guid != null)
					{
						num2 = (short)324141058;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_76;
				case 8:
					if (guid != null)
					{
						num2 = (short)1730150404;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return validateSet;
				}
				goto IL_34;
				IL_76:
				guid = A_0.WorkingCodeplugUuid;
				num2 = (short)1575419912;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1DD:
				guid = A_0.CurrentCodeplugUuid;
				num2 = (short)2096824327;
				num = (int)((global::System.IntPtr)num2);
			}
			return validateSet;
			IL_34:
			validateSet = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidateSet(A_0, null);
			num2 = (short)713818115;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
