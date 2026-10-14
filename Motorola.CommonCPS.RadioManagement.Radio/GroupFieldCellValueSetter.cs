using System;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000007 RID: 7
	public class GroupFieldCellValueSetter<TDevice> : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandCellValueSetter where TDevice : global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000044E8 File Offset: 0x000026E8
		public GroupFieldCellValueSetter(global::System.Windows.Input.ICommand editModeStartedCommand, global::System.Windows.Input.ICommand editModeEndedCommand, global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver editabilityResolver, global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel deviceViewModel)
		{
			int a_ = 14;
			base..ctor(editModeStartedCommand, editModeEndedCommand, editabilityResolver);
			if (deviceViewModel == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꛁꇃ냅ꇇ꧉꧋飍맏럑ꏓ鯕럗뻙맛닝", a_));
			}
			this.a = deviceViewModel;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000452C File Offset: 0x0000272C
		public override void SetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh)
		{
			int a_ = 14;
			short num = (short)1743781888;
			switch (num)
			{
			default:
			{
				num = (short)1282539528;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
				for (;;)
				{
					object obj;
					switch (num2)
					{
					case 0:
						obj = null;
						goto IL_2BB;
					case 1:
					{
						global::Infragistics.Windows.DataPresenter.DataRecord record = cell.Record;
						if (record == null)
						{
							num = (short)285999113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj = record.DataItem;
						goto IL_2BB;
					}
					case 2:
					{
						if (text == null)
						{
							num = (short)10551299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						cell.IsActive = true;
						object commandParameter = this.GetCommandParameter(cell, value, supressNotification, commit, refresh);
						base.EditModeStartedCommand.Execute(commandParameter);
						num = (short)993132554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_244;
					case 4:
						return;
					case 5:
					{
						object[] parameter = new object[]
						{
							radioBase,
							null,
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroupByPath(text)
						};
						this.a.CommandProxy.MoveDeviceCommand.Execute(parameter);
						num = (short)907280388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_31F;
					case 7:
					{
						num = (short)1160630144;
						short num3 = num;
						num = (short)1074581376;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_307;
						default:
							num = (short)2105278464;
							if (num != 0)
							{
							}
							num = (short)450494464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 9:
						obj = null;
						goto IL_2BB;
					case 10:
						if (commit)
						{
							num = (short)655425541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 11:
					{
						if (radioBase == null)
						{
							goto IL_307;
						}
						num = (short)1042939904;
						short num4 = num;
						base.CheckSettability(cell, value);
						text = (value as string);
						num = (short)1321730050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_7C:
					if (cell == null)
					{
						num = (short)288227335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)583204865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BB:
					radioBase = (obj as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
					num = (short)509411329;
					if (num != 0)
					{
					}
					num = (short)2041577483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_307:
					num = (short)363134982;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_244:
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("铁ꗃ꫅뷇꿉ꏍꗏꇑꃓ뫗뿙ﳛ뿝샟釡郣铥臧蓩诫", a_), global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("듁ꗃ꫅뷇꿉", a_));
				IL_31F:
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("蛁ꗃ닅꧇菉룋ꯍ뷏맓ꏕꯗ껙ﳛ볝藟싡藣웥뫧诩裫蟭鿯냱闳藵鷷", a_), global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꇁꇃ꫅꓇", a_));
				IL_324:
				radioBase.CurentGroup = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroupByPath(text);
				radioBase.GroupName = text;
				cell.Record.RefreshCellValue(cell.Field);
				return;
			}
			}
		}

		// Token: 0x0400001E RID: 30
		private readonly global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel a;
	}
}
