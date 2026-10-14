using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200000E RID: 14
	public class MigrateRadioDataBacthOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo>
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000063 RID: 99 RVA: 0x0000752C File Offset: 0x0000572C
		// (remove) Token: 0x06000064 RID: 100 RVA: 0x00007664 File Offset: 0x00005864
		public event global::System.EventHandler ApplyTemplateCompleteEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				int num2;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)1079902209;
					if (num != 0)
					{
					}
					global::System.EventHandler eventHandler2;
					switch (num2)
					{
					case 0:
					{
						if (eventHandler != eventHandler2)
						{
							goto IL_61;
						}
						num = (short)1827361960;
						short num3 = num;
						num = (short)831673512;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_61;
						default:
							num = (short)1845821440;
							if (num != 0)
							{
							}
							num = (short)755761154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_61;
					case 2:
						goto IL_FC;
					}
					goto IL_43;
					IL_61:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
					num = (short)181469184;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FC:
				num = (short)118358016;
				short num4 = num;
				return;
				IL_43:
				eventHandler = this.a;
				num = (short)1449525249;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)575143937;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num2;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_33:
					global::System.EventHandler eventHandler2;
					switch (num2)
					{
					case 0:
					{
						if (eventHandler != eventHandler2)
						{
							goto IL_63;
						}
						num = (short)1194071929;
						short num3 = num;
						num = (short)1239816057;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_63;
						default:
							num = (short)903086080;
							if (num != 0)
							{
							}
							num = (short)2117795842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_63;
					case 2:
						goto IL_FB;
					}
					goto IL_45;
					IL_63:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
					num = (short)2047934464;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FB:
				num = (short)606863360;
				short num4 = num;
				return;
				IL_45:
				eventHandler = this.a;
				num = (short)996737025;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007798 File Offset: 0x00005998
		public MigrateRadioDataBacthOp(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo> templateInfoList)
		{
			base.SelectedItems = templateInfoList;
			base.IsVisible = false;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000077BC File Offset: 0x000059BC
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1104204056;
				short num2 = num;
				num = (short)583913752;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1269039104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)399376384;
				if (num != 0)
				{
				}
				num = (short)712900609;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyTemplateToRadio;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00007868 File Offset: 0x00005A68
		public override string JobName
		{
			get
			{
				short num = (short)1731200460;
				short num2 = num;
				num = (short)567477708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124466688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)419430400;
				if (num != 0)
				{
				}
				num = (short)2093285377;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.ApplyTemplateToRadio;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007914 File Offset: 0x00005B14
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			int a_ = 11;
			short num = (short)931463168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo> enumerator;
				int num4;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						global::System.EventHandler eventHandler = this.a;
						if (eventHandler == null)
						{
							return;
						}
						eventHandler(this, global::System.EventArgs.Empty);
						num = (short)448004098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						try
						{
							num = (short)1929052166;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_11B;
								case 1:
								{
									if (base.CancellationPending)
									{
										num = (short)530513927;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
									num = (short)732823560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_2D0;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)207355909;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1672161119;
									short num3 = num;
									num = (short)61089631;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2D0;
									default:
									{
										num = (short)1948909568;
										if (num != 0)
										{
										}
										global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo dbmigrationApplyTemplateBaseInfo = enumerator.Current;
										num = (short)1542324225;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 5:
									goto IL_2B8;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_B5;
									}
									continue;
								case 7:
									num = (short)398589952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									try
									{
										global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo dbmigrationApplyTemplateBaseInfo;
										global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).MigrateTemplateDataToRadio(base.JobContainerGuid, dbmigrationApplyTemplateBaseInfo.RadioUuid, dbmigrationApplyTemplateBaseInfo.TemplateUuid, dbmigrationApplyTemplateBaseInfo.SerialNumber, dbmigrationApplyTemplateBaseInfo.HasPBA);
										goto IL_DF;
									}
									catch (global::Motorola.Common.CustomException.CommonException ex)
									{
										global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo dbmigrationApplyTemplateBaseInfo;
										global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob batchOperationJob = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
										{
											ErrorCode = new int?((int)ex.ErrorCode),
											ErrorMessage = ex.Message,
											JobContainerUuid = new global::System.Guid?(base.JobContainerGuid),
											JobDescription = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("量ꋑꓓ뫕ꇗ龎裛믝跟鋡裣蟥鳧迩쳫짭误싱觳퇵\ud8f7軹鏻\udefd狿持怃漅朇⨉⬋甍ℏ漑㌓", a_), dbmigrationApplyTemplateBaseInfo.TemplateName, dbmigrationApplyTemplateBaseInfo.SerialNumber)
										};
										if (ex.CommonExceptionData != null)
										{
											batchOperationJob.Parameters = global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(ex.CommonExceptionData.Paramters);
										}
										global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService;
										templateService.AddBatchOperationJob(batchOperationJob);
										goto IL_DF;
									}
									goto IL_2B8;
									IL_DF:
									num4++;
									base.ReportProgress(num4);
									num = (short)97976324;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_120:
								num = (short)129695747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B5:
								goto IL_120;
								IL_2B8:
								num = (short)230162434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11B:
							goto IL_3B4;
							IL_2D0:;
						}
						finally
						{
							num = (short)1997144066;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_33B;
								case 1:
									enumerator.Dispose();
									num = (short)878051328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_306;
									}
									continue;
								}
								IL_306:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1242169345;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_33B:;
						}
						num = (short)1388445696;
						short num5 = num;
						num = (short)1514209280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_3B2;
					}
					goto IL_44;
				}
				return;
				IL_3B2:
				IL_3B4:
				num = (short)1855586305;
				if (num != 0)
				{
				}
				return;
				IL_44:
				num4 = 0;
				enumerator = base.SelectedItems.GetEnumerator();
				num = (short)774832129;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler a;
	}
}
