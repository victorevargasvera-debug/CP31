using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.Operation.RadioConversion;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000010 RID: 16
	public class MigrateTemplateBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00008580 File Offset: 0x00006780
		public MigrateTemplateBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> templateInfoList)
		{
			base.SelectedItems = templateInfoList;
			base.IsVisible = false;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000077 RID: 119 RVA: 0x000085A4 File Offset: 0x000067A4
		// (remove) Token: 0x06000078 RID: 120 RVA: 0x000086D8 File Offset: 0x000068D8
		public event global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs> TemplateImportCompleteEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num;
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs> eventHandler;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						num = (short)1374871031;
						short num2 = num;
						num = (short)787340791;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6D;
						default:
						{
							num = (short)1150746624;
							if (num != 0)
							{
							}
							global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs> eventHandler2;
							switch (num3)
							{
							case 0:
								goto IL_FD;
							case 1:
								if (eventHandler == eventHandler2)
								{
									num = (short)881721344;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_84;
							case 2:
								goto IL_84;
							}
							goto IL_66;
							IL_84:
							eventHandler2 = eventHandler;
							global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
							eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs>>(ref this.a, value2, eventHandler2);
							num = (short)2114387968;
							short num4 = num;
							num = (short)1700462593;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_FD:
					num = (short)1657470977;
					if (num != 0)
					{
					}
					return;
				}
				IL_66:
				eventHandler = this.a;
				IL_6D:
				num = (short)1819869186;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num;
				int num3;
				global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs> eventHandler;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						num = (short)1660262638;
						short num2 = num;
						num = (short)263297262;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_96;
						default:
						{
							num = (short)1185939457;
							if (num != 0)
							{
							}
							num = (short)606535680;
							if (num != 0)
							{
							}
							global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs> eventHandler2;
							switch (num3)
							{
							case 0:
								return;
							case 1:
								if (eventHandler == eventHandler2)
								{
									num = (short)1261502464;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_AF;
							case 2:
								goto IL_AF;
							}
							goto IL_8F;
							IL_AF:
							num = (short)1251278848;
							short num4 = num;
							eventHandler2 = eventHandler;
							global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs> value2 = (global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
							eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs>>(ref this.a, value2, eventHandler2);
							num = (short)1831862273;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					return;
				}
				IL_8F:
				eventHandler = this.a;
				IL_96:
				num = (short)326565890;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00008810 File Offset: 0x00006A10
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1346633729;
				if (num != 0)
				{
				}
				num = (short)184581461;
				short num2 = num;
				num = (short)2057141589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1015873536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847394304;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.TemplateMigration;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000088C0 File Offset: 0x00006AC0
		public override string JobName
		{
			get
			{
				short num = (short)18481153;
				if (num != 0)
				{
				}
				num = (short)2129076229;
				short num2 = num;
				num = (short)1008017413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)765526016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)794951680;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.TemplateMigration;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00008970 File Offset: 0x00006B70
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)2138439680;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1965096960;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo> list;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> enumerator;
				int num5;
				for (;;)
				{
					IL_50:
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs> eventHandler = this.a;
						if (eventHandler == null)
						{
							return;
						}
						eventHandler(this, new global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs
						{
							PerformedList = list
						});
						num = (short)2137194496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)1172111366;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_158;
								case 1:
								{
									if (base.CancellationPending)
									{
										num = (short)1173422087;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
									string filePath = "";
									num = (short)1831993352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_59D;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1572208645;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo templateInfo = enumerator.Current;
									num = (short)1630732289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_583;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_DB;
									}
									continue;
								case 7:
									num = (short)1535049728;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_215;
										}
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationRadioBasicInfo>.Enumerator enumerator2;
										global::Motorola.CommonCPS.Server.EntityModel.Template template;
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate> list2;
										global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
										for (;;)
										{
											IL_1FA:
											switch (num2)
											{
											case 0:
											{
												global::Motorola.CommonCPS.Server.EntityModel.MigrateTemplateParameter parameter;
												if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).MigrateTemplate(parameter) != null)
												{
													num = (short)171311107;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_4C3;
											}
											case 1:
												goto IL_4DC;
											case 2:
											{
												try
												{
													num = (short)829882370;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															if (!enumerator2.MoveNext())
															{
																num = (short)862453763;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationRadioBasicInfo dbmigrationRadioBasicInfo = enumerator2.Current;
															global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceUuid = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(dbmigrationRadioBasicInfo.RadioUuid, true);
															global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService;
															global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate radioInfoForApplyTemplate = templateService.GetRadioInfoForApplyTemplate(radioByDeviceUuid, template);
															list2.Add(radioInfoForApplyTemplate);
															num = (short)1375731716;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 1:
															goto IL_415;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_324;
															}
															continue;
														case 3:
															num = (short)853344257;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														IL_372:
														num = (short)1643041333;
														short num4 = num;
														num = (short)1216205365;
														switch ((num4 == num) ? 1 : 0)
														{
														case 0:
														case 2:
															goto IL_415;
														default:
															num = (short)1160380416;
															if (num != 0)
															{
															}
															num = (short)1421082624;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														IL_324:
														goto IL_372;
													}
													IL_415:
													goto IL_461;
												}
												finally
												{
													((global::System.IDisposable)enumerator2).Dispose();
												}
												goto IL_425;
												IL_461:
												global::Motorola.CommonCPS.Server.EntityModel.MigrateTemplateParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.MigrateTemplateParameter(base.JobContainerGuid, template, radio, list2, template.Name);
												num = (short)1099169792;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												goto IL_425;
											case 4:
												goto IL_4C3;
											}
											goto IL_215;
											IL_425:
											list.AddRange(CS$<>8__locals1.templateInfo.ReferencedRadioList.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationRadioBasicInfo radioInfo)
											{
												short num6 = (short)1176658423;
												short num7 = num6;
												num6 = (short)2010341879;
												switch (num7 == num6)
												{
												}
												num6 = (short)793444352;
												short num8 = num6;
												num6 = (short)355467264;
												if (num6 != 0)
												{
												}
												num6 = (short)877264897;
												if (num6 != 0)
												{
												}
												return new global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo
												{
													RadioUuid = radioInfo.RadioUuid,
													SerialNumber = radioInfo.SerialNumber,
													TemplateName = CS$<>8__locals1.templateInfo.TemplateName,
													TemplateUuid = CS$<>8__locals1.templateInfo.TemplateUuid,
													HasPBA = radioInfo.HasPBA
												};
											}));
											num = (short)773128196;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4C3:
											num = (short)1639645185;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_4DC:
										goto IL_11A;
										IL_215:
										global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).TransferArchiveFileById(CS$<>8__locals1.templateInfo.ArchiveFileUuid);
										string filePath = global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.Instance.DownloadArchiveFile(CS$<>8__locals1.templateInfo.ArchiveFileUuid, null);
										global::System.Collections.Generic.Dictionary<int, int> dictionary;
										radio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.ParseArchive(filePath, true, null, out dictionary);
										template = radio.WorkingCodeplug.Template;
										template.Uuid = CS$<>8__locals1.templateInfo.TemplateUuid;
										template.Name = CS$<>8__locals1.templateInfo.TemplateName;
										template.TemplateBaseName = CS$<>8__locals1.templateInfo.TemplateName;
										template.FileUuid = new global::System.Guid?(CS$<>8__locals1.templateInfo.ArchiveFileUuid);
										list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate>();
										enumerator2 = CS$<>8__locals1.templateInfo.ReferencedRadioList.GetEnumerator();
										num = (short)1039859714;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_1FA;
									}
									catch (global::Motorola.Common.CustomException.CommonException ex)
									{
										global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
										{
											JobDescription = global::System.IO.Path.GetFileNameWithoutExtension(CS$<>8__locals1.templateInfo.TemplateName),
											ErrorCode = new int?((int)ex.ErrorCode),
											ErrorMessage = ex.Message,
											JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
											JobContainerUuid = new global::System.Guid?(base.JobContainerGuid)
										};
										if (ex.CommonExceptionData != null)
										{
											batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
										}
										global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
										radioService.AddBatchOperationJob(batchOperationJob);
										num5++;
										base.ReportProgress(num5);
										break;
									}
									finally
									{
										string filePath;
										global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.Instance.DeleteFile(filePath);
									}
									goto IL_583;
									IL_11A:
									num5++;
									base.ReportProgress(num5);
									num = (short)1158479876;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_15D:
								num = (short)792526851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DB:
								goto IL_15D;
								IL_583:
								num = (short)47710210;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_158:
							return;
							IL_59D:;
						}
						finally
						{
							num = (short)1001455617;
							if (num != 0)
							{
							}
							num = (short)1998651394;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_633;
								case 1:
									enumerator.Dispose();
									num = (short)1357578240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5FC;
									}
									continue;
								}
								IL_5FC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)271974401;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_633:;
						}
						num = (short)1244594177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63;
				}
				return;
				IL_63:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo>();
				num5 = 0;
				enumerator = base.SelectedItems.GetEnumerator();
				num = (short)1942159362;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x04000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs> a;

		// Token: 0x02000011 RID: 17
		public class ApplyTemplatesEventArgs : global::System.EventArgs
		{
			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600007C RID: 124 RVA: 0x00009068 File Offset: 0x00007268
			// (set) Token: 0x0600007D RID: 125 RVA: 0x00009118 File Offset: 0x00007318
			public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo> PerformedList
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)360141792;
					short num2 = num;
					num = (short)1823888352;
					switch (num2 == num)
					{
					}
					num = (short)1497235456;
					short num3 = num;
					num = (short)365101057;
					if (num != 0)
					{
					}
					num = (short)1958019072;
					if (num != 0)
					{
					}
					return this.a;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)921849836;
					short num2 = num;
					num = (short)685002732;
					switch (num2 == num)
					{
					}
					num = (short)1206517760;
					short num3 = num;
					num = (short)1591541760;
					if (num != 0)
					{
					}
					num = (short)1474822145;
					if (num != 0)
					{
					}
					this.a = value;
				}
			}

			// Token: 0x04000024 RID: 36
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo> a;
		}
	}
}
