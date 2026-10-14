using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000028 RID: 40
	public class UserOperationToUiTextConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00007B0C File Offset: 0x00005D0C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1366097921;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1643315201;
					if (num != 0)
					{
					}
					num = (short)1688338435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
					goto IL_53;
				case 3:
					goto IL_ED;
				case 4:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType userOperationType;
					switch (userOperationType)
					{
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Open:
						goto IL_1A9;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Save:
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.LicenseRecDev:
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.LicenseRecApp:
						goto IL_1C7;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Read:
						goto IL_1C1;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Write:
						goto IL_1A3;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Clone:
						goto IL_D0;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Register:
						goto IL_80;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Update:
						goto IL_1B5;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Recover:
						goto IL_197;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Activate:
						goto IL_1AF;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.Import:
						goto IL_F2;
					case global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.ChangeLogSetting:
						goto IL_19D;
					default:
						num = (short)843382784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_38:
				if (value == null)
				{
					num = (short)388562946;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType userOperationType = (global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType)value;
					num = (short)903938052;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_53:
			num = (short)631242752;
			short num3 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Action_Select;
			IL_80:
			num = (short)998382938;
			short num4 = num;
			num = (short)118693210;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_197:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.Windows_RecoverButton;
			default:
				num = (short)1627979776;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Register_Device_Licenses_Title;
			}
			IL_D0:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Button_Label_Clone;
			IL_ED:
			goto IL_1C7;
			IL_F2:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Import_Voice_Announcement;
			IL_19D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_LogSetting;
			IL_1A3:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Button_Label_Write;
			IL_1A9:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Button_Label_Open;
			IL_1AF:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Action_Activate;
			IL_1B5:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Button_Label_Update;
			IL_1C1:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Button_Label_Read;
			IL_1C7:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Action_Select;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1594949633;
			if (num != 0)
			{
			}
			num = (short)704570840;
			short num2 = num;
			num = (short)689759704;
			switch (num2 == num)
			{
			}
			num = (short)1846149120;
			if (num != 0)
			{
			}
			num = (short)1389887488;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
