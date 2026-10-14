using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000024 RID: 36
	public class ASTROSelectCodeplugVersionBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000111 RID: 273 RVA: 0x0001D118 File Offset: 0x0001B318
		public ASTROSelectCodeplugVersionBatchOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedAllRadios, string codeplugVersion)
		{
			base.SelectedItems = selectedAllRadios;
			this.a = codeplugVersion;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0001D13C File Offset: 0x0001B33C
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1345068195;
				short num2 = num;
				num = (short)602021027;
				switch (num2 == num)
				{
				}
				num = (short)1479671808;
				if (num != 0)
				{
				}
				num = (short)1942028289;
				if (num != 0)
				{
				}
				num = (short)1836253184;
				short num3 = num;
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeCodeplugVersion;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
		public override string JobName
		{
			get
			{
				short num = (short)500629505;
				if (num != 0)
				{
				}
				num = (short)544866099;
				short num2 = num;
				num = (short)115605299;
				switch (num2 == num)
				{
				}
				num = (short)1640235008;
				if (num != 0)
				{
				}
				num = (short)1984888832;
				short num3 = num;
				return global::Motorola.CommonCPS.ResourceRepository.Resources.General_UpgradeCodeplugVersion;
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0001D298 File Offset: 0x0001B498
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			short num = (short)1167917056;
			switch (num)
			{
			default:
			{
				num = (short)956039169;
				if (num != 0)
				{
				}
				num = (short)819855361;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService iastroradioService;
					int num3;
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)283705347;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_31B;
								case 2:
									goto IL_302;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_105;
									}
									continue;
								case 4:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_1AA;
										}
										global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
										for (;;)
										{
											IL_193:
											switch (num2)
											{
											case 0:
												goto IL_2A8;
											case 1:
												if (radioSummary != null)
												{
													num = (short)1269039106;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_28F;
											case 2:
											{
												global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = radioSummary.ToUiModel(true);
												base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
												{
													item
												});
												num = (short)1730871299;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												goto IL_28F;
											}
											goto IL_1AA;
											IL_28F:
											num = (short)1925054464;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2A8:
										goto IL_128;
										IL_1AA:
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										global::Motorola.CommonCPS.Server.EntityModel.Radio radio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadio(radioBase.DeviceUuid, true);
										global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).LoadConfiguration(radio.WorkingCodeplug.ConfigurationUuid.ToString());
										radio.WorkingCodeplug.Configuration = configuration;
										radioSummary = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).UpgradeRadioCodeplugVersion(base.JobContainerGuid, radio, this.a);
										num = (short)739442689;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_193;
									}
									catch (global::Motorola.Common.CustomException.CommonException ex)
									{
										string[] paramters = null;
										if (ex.CommonExceptionData != null)
										{
											paramters = ex.CommonExceptionData.Paramters;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpUtility.CreateFailureJob(base.JobContainerGuid, radioBase.SerialNumber, ex.ErrorCode, paramters);
										iastroradioService.AddBatchOperationJob(job);
										num3++;
										base.ReportProgress(num3);
										break;
									}
									goto IL_302;
									IL_128:
									num3++;
									base.ReportProgress(num3);
									num = (short)181272576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1460731906;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
									num = (short)1482686468;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_14B:
								num = (short)1688535045;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_105:
								goto IL_14B;
								IL_302:
								num = (short)458162177;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_31B:
							return;
						}
						finally
						{
							num = (short)1856241665;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3D9;
								case 1:
									goto IL_335;
								case 2:
								{
									num = (short)751414915;
									short num4 = num;
									num = (short)594325123;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_335;
									default:
										num = (short)1700659200;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)172294144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_352;
								IL_335:
								switch (0)
								{
								case 0:
									IL_352:
									if (enumerator == null)
									{
										goto IL_3DB;
									}
									num = (short)1162739714;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_3D9:
							IL_3DB:;
						}
						goto IL_3DC;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_76;
						}
						continue;
					case 2:
						return;
					}
					IL_76:
					num = (short)816775168;
					short num5 = num;
					if (base.CancellationPending)
					{
						num = (short)764477442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3DC:
					iastroradioService = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService);
					num3 = 0;
					enumerator = base.SelectedItems.GetEnumerator();
					num = (short)328269824;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x04000050 RID: 80
		private string a;
	}
}
