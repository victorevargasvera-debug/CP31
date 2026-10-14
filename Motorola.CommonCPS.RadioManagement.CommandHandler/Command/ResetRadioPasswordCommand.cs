using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200002F RID: 47
	public class ResetRadioPasswordCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600021E RID: 542 RVA: 0x0001BDB4 File Offset: 0x00019FB4
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 10;
			short num = (short)654245888;
			switch (num)
			{
			default:
			{
				num = (short)1584332800;
				short num2 = num;
				num = (short)1647247363;
				int num3 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext resetRadioPasswordContext;
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						global::System.Guid? id;
						if (id == null)
						{
							num = (short)1391919106;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_199;
					}
					case 1:
					{
						num = (short)643384228;
						short num4 = num;
						num = (short)343622564;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_65;
						default:
							goto IL_139;
						}
						break;
					}
					case 2:
						goto IL_101;
					case 3:
						goto IL_65;
					}
					goto IL_86;
					IL_65:
					switch (0)
					{
					case 0:
						IL_86:
						if (!global::Motorola.CommonCPS.RadioManagement.Command.ResetRadioPasswordCommand.a(paras, out resetRadioPasswordContext))
						{
							num = (short)1057226753;
							num3 = (int)((global::System.IntPtr)num);
						}
						else
						{
							global::System.Guid? id = resetRadioPasswordContext.Radio.ID;
							num = (short)626655232;
							num3 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
				IL_101:
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꯺迼郾眀樂愄戆洈⬊缌渎甐稒稔㜖焘稚礜㼞䐠丢唤匦倨ପ搬欮", a_));
				IL_139:
				num = (short)1871839233;
				if (num != 0)
				{
				}
				num = (short)467402752;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꯺迼郾眀樂愄戆洈⬊紌渎挐爒昔㜖紘爚礜㼞传䰢儤ܦ䨨䐪䌬嬮倰娲嬴᜶䴸区堼Ἶፀ♂㙄≆㵈᥊ⱌ⭎㡐㱒Ք㙖⩘⡚⩜ぞ፠ݢ♤ࡦݨὪ࡬ᝮհ", a_), global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("诺鳼跾怀瀂", a_));
				IL_199:
				byte[] passwordResetFileContent = global::System.IO.File.ReadAllBytes(resetRadioPasswordContext.PasswordResetFilePath);
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROScheduleJobBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROScheduleJobBatchOp(this.CreateScheduleJobContext(resetRadioPasswordContext.Radio, passwordResetFileContent));
				base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
				return null;
			}
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001BF84 File Offset: 0x0001A184
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)349306884;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext resetRadioPasswordContext;
				switch (num2)
				{
				case 0:
					if (!global::System.IO.File.Exists(resetRadioPasswordContext.PasswordResetFilePath))
					{
						num = (short)483786753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2092564483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					goto IL_E6;
				case 4:
				{
					num = (short)1022844315;
					short num3 = num;
					num = (short)897605019;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E6;
					default:
						num = (short)121896960;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					}
					break;
				}
				case 5:
					goto IL_A9;
				}
				IL_88:
				if (!global::Motorola.CommonCPS.RadioManagement.Command.ResetRadioPasswordCommand.a(paras, out resetRadioPasswordContext))
				{
					num = (short)63111173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)275578880;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E6:
				num = (short)100335616;
				short num4 = num;
				if (global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.CheckFileContentsValid(global::System.IO.File.ReadAllBytes(resetRadioPasswordContext.PasswordResetFilePath), resetRadioPasswordContext.Radio.SerialNumber) == global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus.ValidFile)
				{
					return true;
				}
				num = (short)597229570;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A9:
			num = (short)382861313;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0001C124 File Offset: 0x0001A324
		private static bool a(object[] A_0, out global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext A_1)
		{
			short num = (short)1763840556;
			short num2 = num;
			num = (short)1461981740;
			switch (num2 == num)
			{
			}
			num = (short)2000486400;
			if (num != 0)
			{
			}
			num = (short)1609498624;
			short num3 = num;
			num = (short)809697281;
			if (num != 0)
			{
			}
			A_1 = (((A_0 != null) ? A_0.FirstOrDefault<object>() : null) as global::Motorola.CommonCPS.RadioManagement.UIModels.ResetRadioPasswordContext);
			return A_1 != null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		protected virtual global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext CreateScheduleJobContext(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, byte[] passwordResetFileContent)
		{
			int a_ = 5;
			short num = (short)1299120129;
			if (num != 0)
			{
			}
			num = (short)1312283381;
			short num2 = num;
			num = (short)1305664245;
			switch (num2 == num)
			{
			}
			num = (short)1623719936;
			short num3 = num;
			num = (short)634847232;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext scheduleJobContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext();
			scheduleJobContext.Type = global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.PasswordReset;
			scheduleJobContext.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
			{
				radio
			};
			scheduleJobContext.ResetPasswordFileContent = passwordResetFileContent;
			scheduleJobContext.ConnectionMethod = global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.Wired;
			scheduleJobContext.Name = string.Format(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("践죷蟹\udcfb藽ㇿ㠁紃缅焇猉ℋ䌍崏㼑瀓爕㠗则君␝䴟伡夣ล紧縩漫ܭ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.PasswordReset, global::System.DateTime.Now.ToUniversalTime());
			global::System.Collections.Generic.List<global::System.TimeZoneInfo> list = global::System.TimeZoneInfo.GetSystemTimeZones().Where(delegate(global::System.TimeZoneInfo timeZone)
			{
				short num4 = (short)922788491;
				short num5 = num4;
				num4 = (short)1162322571;
				switch (num5 == num4)
				{
				}
				num4 = (short)1457848321;
				if (num4 != 0)
				{
				}
				num4 = (short)1198522368;
				short num6 = num4;
				num4 = (short)1469054976;
				if (num4 != 0)
				{
				}
				return !timeZone.Equals(global::System.TimeZoneInfo.Local);
			}).ToList<global::System.TimeZoneInfo>();
			scheduleJobContext.TimeZoneInfos = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.TimeZoneInfo>(list);
			global::System.TimeZoneInfo.ClearCachedData();
			scheduleJobContext.SelectedTimeZoneInfo = global::System.TimeZoneInfo.Local;
			return scheduleJobContext;
		}
	}
}
