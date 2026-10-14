using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200004D RID: 77
	public class Restore_PrepareScheduleJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00024940 File Offset: 0x00022B40
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000249F0 File Offset: 0x00022BF0
		private protected global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase Device
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected get
			{
				short num = (short)182946014;
				short num2 = num;
				num = (short)1856800990;
				switch (num2 == num)
				{
				}
				num = (short)690814976;
				short num3 = num;
				num = (short)1839267841;
				if (num != 0)
				{
				}
				num = (short)943915008;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1066025319;
				short num2 = num;
				num = (short)937705831;
				switch (num2 == num)
				{
				}
				num = (short)2139750400;
				short num3 = num;
				num = (short)1731788800;
				if (num != 0)
				{
				}
				num = (short)1539112961;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00024AA4 File Offset: 0x00022CA4
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1403256835;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E5;
				case 1:
					this.Device = ((global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails)paras[0]).Radio.ToUiModel(true);
					num = (short)1033371648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_E7;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					num = (short)30408705;
					if (num != 0)
					{
					}
					if (this.Device == null)
					{
						num = (short)326762496;
						short num3 = num;
						num = (short)1192230913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_39:
				if ((paras[1] as global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>).Count != 1)
				{
					return false;
				}
				num = (short)1469976314;
				short num4 = num;
				num = (short)479465210;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)434307072;
					if (num != 0)
					{
					}
					num = (short)1956708354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E7:
				num = (short)817627140;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_E5:
			return true;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00024C28 File Offset: 0x00022E28
		public virtual void InitializeContext(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleRestoreJobContext context)
		{
			short num = (short)2128674816;
			switch (num)
			{
			default:
			{
				num = (short)1143734273;
				if (num != 0)
				{
				}
				context.ConnectionMethod = global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.Wired;
				global::System.TimeZoneInfo local = global::System.TimeZoneInfo.Local;
				global::System.Collections.Generic.List<global::System.TimeZoneInfo> list = new global::System.Collections.Generic.List<global::System.TimeZoneInfo>();
				global::System.Collections.Generic.IEnumerator<global::System.TimeZoneInfo> enumerator = global::System.TimeZoneInfo.GetSystemTimeZones().GetEnumerator();
				try
				{
					num = (short)921960451;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)392953862;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.TimeZoneInfo timeZoneInfo = enumerator.Current;
							num = (short)1953562629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_156;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_A8;
							}
							continue;
						case 4:
						{
							global::System.TimeZoneInfo timeZoneInfo;
							list.Add(timeZoneInfo);
							num = (short)757071873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.TimeZoneInfo timeZoneInfo;
							if (timeZoneInfo != local)
							{
								num = (short)905052164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)2121728002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E1:
						num = (short)570753024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A8:
						goto IL_E1;
					}
					IL_156:;
				}
				finally
				{
					for (;;)
					{
						num = (short)979238913;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1C3;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_18D;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)1699807232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_18D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)274661378;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1C5:
						num = (short)171186584;
						short num3 = num;
						num = (short)838736280;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_1F9;
						}
						IL_1C3:
						goto IL_1C5;
					}
					IL_1F9:
					num = (short)57999360;
					if (num != 0)
					{
					}
				}
				num = (short)1687748608;
				short num4 = num;
				context.TimeZoneInfos = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.TimeZoneInfo>(list);
				context.SelectedTimeZoneInfo = global::System.TimeZoneInfo.Local;
				context.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				context.Radios.Add(this.Device);
				context.IsTypeReadEditable = false;
				context.Type = global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Write;
				context.IsTypeWriteEditable = true;
				context.IsTypeReadGenerateConfigurationOrTemplateEditable = true;
				context.IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable = false;
				context.TypeReadGenerateConfigurationOrTemplate = false;
				context.TypeReadGenerateConfigurationOrTemplateApplyToRadio = false;
				return;
			}
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00024EE4 File Offset: 0x000230E4
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 12;
			short num;
			object result;
			try
			{
				num = (short)37879808;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> list;
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetails;
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							goto IL_203;
						case 1:
						{
							string content;
							if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioDetailService.ValidateRestore_PreSchedule(list, this.Device, radioDetails, out content))
							{
								num = (short)921829384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							base.Interaction.ShowNotificationDialog(content, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
							result = false;
							num = (short)2129526791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob historyJob;
							this.SheduleRestoreJob(historyJob);
							num = (short)1190920198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (base.Interaction.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Restore_Warning, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Confirm))
							{
								num = (short)626524162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EB;
						case 4:
							goto IL_1EB;
						case 5:
						{
							if (radioDetails.RadioUIChangeIndicator > 0L)
							{
								num = (short)700514313;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob historyJob;
							this.SheduleRestoreJob(historyJob);
							num = (short)821231620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_1EB;
						case 7:
							goto IL_15B;
						case 8:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob historyJob = list[0];
							num = (short)758382597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num = (short)213385219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_60;
						IL_1EB:
						num = (short)1823342592;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_15B:
					goto IL_2D7;
					IL_203:
					break;
					IL_60:
					list = (paras[1] as global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>);
					radioDetails = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails);
					this.Device = ((global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails)paras[0]).Radio.ToUiModel(true);
					num = (short)2094465025;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RestoreDevice_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\uddfc", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
			}
			num = (short)1988506902;
			short num3 = num;
			num = (short)24458518;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_2D7:
				num = (short)125960192;
				short num4 = num;
				return result;
			}
			default:
				num = (short)2072772609;
				if (num != 0)
				{
				}
				num = (short)254607360;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00025210 File Offset: 0x00023410
		protected virtual void SheduleRestoreJob(global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob historyJob)
		{
			short num = (short)1700200448;
			short num2 = num;
			num = (short)849994458;
			short num3 = num;
			num = (short)387900122;
			switch (num3 == num)
			{
			}
			num = (short)1835073537;
			if (num != 0)
			{
			}
			num = (short)1356136448;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleRestoreJobContext scheduleRestoreJobContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleRestoreJobContext();
			scheduleRestoreJobContext.RestoreJob = historyJob.RawData;
			this.InitializeContext(scheduleRestoreJobContext);
			base.Interaction.ShowScheduleJobDialog(scheduleRestoreJobContext);
		}

		// Token: 0x0400004E RID: 78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a;
	}
}
