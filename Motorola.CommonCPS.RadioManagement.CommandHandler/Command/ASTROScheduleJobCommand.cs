using System;
using System.Collections.Generic;
using System.Globalization;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200004E RID: 78
	internal class ASTROScheduleJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.ScheduleJobCommand
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x000252F4 File Offset: 0x000234F4
		protected override bool ExecuteOperation(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context)
		{
			short num = (short)1217921025;
			if (num != 0)
			{
			}
			num = (short)262466927;
			short num2 = num;
			num = (short)130149743;
			switch (num2 == num)
			{
			}
			num = (short)692781056;
			short num3 = num;
			num = (short)1963196416;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROScheduleJobBatchOp operation = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROScheduleJobBatchOp(context);
			base.RunOperationWrapper(context, operation);
			return true;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000253AC File Offset: 0x000235AC
		protected override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType GetJobType(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext context)
		{
			short num = (short)1856203109;
			short num2 = num;
			num = (short)117139813;
			switch (num2 == num)
			{
			}
			num = (short)718864385;
			if (num != 0)
			{
			}
			num = (short)89456640;
			short num3 = num;
			num = (short)2132934656;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2Enum.ConverterUiJobTypeToServerJobType(context.Type, true);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00025460 File Offset: 0x00023660
		protected override bool GetWarningRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio warningRadio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isFirmwareRecoveryBeforeSynchronizationRead)
		{
			bool flag = base.GetWarningRadio(d, type, warningRadio, transport, isFirmwareRecoveryBeforeSynchronizationRead);
			flag |= this.a(type, d, warningRadio);
			global::System.Collections.Generic.List<string>.Enumerator enumerator = warningRadio.OriginalReasonList.GetEnumerator();
			short num;
			try
			{
				num = (short)466419716;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)193396737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_12F;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1836710132;
							short num3 = num;
							num = (short)686684404;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)50200576;
								if (num != 0)
								{
								}
								num = (short)536084480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						string str = enumerator.Current;
						warningRadio.Reason += str;
						num = (short)1776877570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					}
					IL_92:
					num = (short)1000210435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60:
					goto IL_92;
				}
				IL_12F:;
			}
			finally
			{
				num = (short)1646788609;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)387776512;
			short num4 = num;
			return flag;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0002561C File Offset: 0x0002381C
		private bool a(global::Motorola.CommonCPS.Server.CommonDBConstants.JobType A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_1, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio A_2)
		{
			short num = (short)1343225856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				bool result;
				for (;;)
				{
					IL_27:
					string rfresourceValueByResourceID;
					switch (num2)
					{
					case 0:
						if ((A_1.ChangeIndicator & 2) != 0)
						{
							num = (short)92930064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					case 1:
						return result;
					case 2:
						num = (short)1104740362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						if (apxradio.CurrentCodeplug.FirmwareVersion.Length > 8)
						{
							num = (short)1995374621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62D;
					}
					case 4:
						if (!global::Motorola.Common.Communication.CommonUtil.ModelNumber.IsAmp(A_1.ModelNumber))
						{
							num = (short)2083192860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						if (apxradio.CurrentCodeplug != null)
						{
							goto IL_4A3;
						}
						goto IL_62D;
					}
					case 6:
						num = (short)1018626075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_5E5;
					case 8:
						num = (short)812777477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1020395524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						if (apxradio.CurrentCodeplug.FirmwareVersion != null)
						{
							num = (short)212336655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62D;
					}
					case 11:
					{
						string astroUpgradeKVLWarning;
						A_2.OriginalReasonList.Add(astroUpgradeKVLWarning);
						result = true;
						num = (short)1571815431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)487325713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_2DA;
					case 14:
						if (A_1 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)
						{
							num = (short)2019557395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					case 15:
						num = (short)36241411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)371458062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (A_0 == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteWithSwitchover)
						{
							num = (short)1139277837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 18:
						num = (short)714997761;
						if (num != 0)
						{
						}
						num = (short)1564409882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						int? secureOperation = (A_1 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).SecureOperation;
						int num3 = 1;
						num = (short)6291488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						A_2.OriginalReasonList.Add(rfresourceValueByResourceID);
						result = true;
						num = (short)1284613678;
						short num4 = num;
						num = (short)670017070;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4A3;
						default:
							num = (short)1522794496;
							if (num != 0)
							{
							}
							num = (short)412221441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
					{
						string astroUpgradeKVLWarning = global::Motorola.CommonCPS.ResourceRepository.Resources.AstroUpgradeKVLWarning;
						num = (short)686555167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_62D;
					case 23:
						goto IL_247;
					case 24:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						if (apxradio != null)
						{
							num = (short)701562888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62D;
					}
					case 25:
						if (!A_2.OriginalReasonList.Contains(rfresourceValueByResourceID))
						{
							num = (short)45350932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 26:
						if (A_0 == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteWithSwitchover)
						{
							num = (short)2026110999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					case 27:
						if (A_0 != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover)
						{
							num = (short)1343946764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DA;
					case 28:
					{
						string empty = string.Empty;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(A_1.DeviceUuid, true) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio;
						int num5 = 14;
						int num6 = 0;
						num = (short)1223295000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						int num6 = int.Parse(apxradio.CurrentCodeplug.FirmwareVersion.Substring(1, 2), global::System.Globalization.CultureInfo.InvariantCulture);
						num = (short)1604059136;
						short num7 = num;
						num = (short)477036566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (A_0 != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover)
						{
							num = (short)233177106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_247;
					case 31:
					{
						string astroUpgradeKVLWarning;
						if (!A_2.OriginalReasonList.Contains(astroUpgradeKVLWarning))
						{
							num = (short)530645003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					}
					case 32:
					{
						int? secureOperation;
						int num3;
						if (secureOperation.GetValueOrDefault() == num3 & secureOperation != null)
						{
							num = (short)775487497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					}
					case 33:
						if (!string.IsNullOrEmpty((A_1 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).LPWarningCode))
						{
							num = (short)471990278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 34:
					{
						int num5;
						int num6;
						if (num6 < num5)
						{
							num = (short)1769996309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					}
					}
					goto IL_BA;
					IL_247:
					num = (short)1091239936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DA:
					rfresourceValueByResourceID = global::RFResourceRepository.ASTROResourceHelper.Instance().GetRFResourceValueByResourceID((A_1 as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).LPWarningCode, null);
					num = (short)2052128793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A3:
					num = (short)245563394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E5:
					num = (short)1585381409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62D:
					num = (short)1651441698;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_BA:
				result = false;
				num = (short)162660382;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
