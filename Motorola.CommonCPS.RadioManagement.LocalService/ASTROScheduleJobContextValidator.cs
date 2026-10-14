using System;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200003B RID: 59
	public class ASTROScheduleJobContextValidator : global::Motorola.CommonCPS.RadioManagement.LocalService.ScheduleJobContextValidator
	{
		// Token: 0x0600021A RID: 538 RVA: 0x000257C0 File Offset: 0x000239C0
		public override void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext scheduleJobContext;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("猦倨嬪䠬", a_))
					{
						num2 = (short)1085276163;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)338231298;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_CC;
				case 2:
				{
					if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("猦倨嬪䠬紮吰刲儴瀶尸唺堼䴾⁀㝂⁄ц♈╊⭌♎㙐♒❔㙖ⵘ㉚㉜ㅞ⹠ᅢㅤɦѨ᭪Ŭ๮հᙲ", a_)))
					{
						return;
					}
					num2 = (short)2141519872;
					short num3 = num2;
					num2 = (short)159959365;
					short num4 = num2;
					num2 = (short)725600581;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AA;
					default:
						num2 = (short)350289921;
						if (num2 != 0)
						{
						}
						num2 = (short)95223808;
						if (num2 != 0)
						{
						}
						num2 = (short)1536425997;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)347209742;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (scheduleJobContext.TypeReadGenerateConfigurationOrTemplate)
					{
						num2 = (short)858914822;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					scheduleJobContext.IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable = false;
					scheduleJobContext.TypeReadGenerateConfigurationOrTemplateApplyToRadio = false;
					num2 = (short)1801912328;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_1F4;
				case 6:
					num2 = (short)811728903;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_AA;
				case 8:
					goto IL_2BB;
				case 9:
					if (e == null)
					{
						num2 = (short)323092491;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					base.Validate(uiModel, e);
					num2 = (short)135266304;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (scheduleJobContext.Type == global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Write)
					{
						num2 = (short)1163591692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					return;
				case 12:
					goto IL_2FB;
				case 13:
					num2 = (short)699006980;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (scheduleJobContext.Type == global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Read)
					{
						num2 = (short)1897988101;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)143261706;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_55;
				IL_AA:
				if (!(scheduleJobContext is global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleRestoreJobContext))
				{
					goto IL_1F9;
				}
				num2 = (short)1297022977;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_CC:
			scheduleJobContext.IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable = false;
			scheduleJobContext.TypeReadGenerateConfigurationOrTemplateApplyToRadio = true;
			return;
			IL_1F4:
			scheduleJobContext.IsTypeReadGenerateConfigurationOrTemplateEditable = true;
			scheduleJobContext.TypeReadGenerateConfigurationOrTemplate = false;
			scheduleJobContext.IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable = false;
			scheduleJobContext.TypeReadGenerateConfigurationOrTemplateApplyToRadio = false;
			scheduleJobContext.IsWriteProtected = false;
			scheduleJobContext.IsWriteProtectedEnable = false;
			scheduleJobContext.UIUserDefersAllowed = scheduleJobContext.DefaultUIUserDefersAllowed;
			scheduleJobContext.EnableImmediateDeployment = false;
			return;
			IL_1F9:
			scheduleJobContext.IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable = true;
			return;
			IL_2BB:
			return;
			IL_2FB:
			scheduleJobContext.IsTypeReadGenerateConfigurationOrTemplateEditable = false;
			scheduleJobContext.IsTypeReadGenerateConfigurationOrTemplateApplyToRadioEditable = false;
			scheduleJobContext.TypeReadGenerateConfigurationOrTemplate = false;
			scheduleJobContext.TypeReadGenerateConfigurationOrTemplateApplyToRadio = false;
			scheduleJobContext.IsWriteProtected = false;
			scheduleJobContext.IsWriteProtectedEnable = true;
			return;
			IL_55:
			scheduleJobContext = (global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduleJobContext)uiModel;
			num2 = (short)498532361;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
