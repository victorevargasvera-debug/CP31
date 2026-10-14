using System;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200003D RID: 61
	public class ImportRadioContextValidator : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x06000226 RID: 550 RVA: 0x00027EE8 File Offset: 0x000260E8
		public void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext importRadiosContext;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (!importRadiosContext.IsAlwaysOverrideEditable)
					{
						num2 = (short)1421803525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_97;
				case 2:
					IL_2C4:
					if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("堚漜稞䀠圢䀤搦䘨䔪䬬䘮嘰䘲䜴嘶䴸刺刼儾㉀", a_))
					{
						num2 = (short)881065992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("堚漜稞䀠圢䀤甦䠨伪䐬䀮䈰", a_)))
					{
						num2 = (short)1663762447;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_33C;
				case 4:
					goto IL_97;
				case 5:
					importRadiosContext.IsNeverOverrideEditable = true;
					importRadiosContext.IsOverrideWhenFlashcodeNotChangedEditable = true;
					importRadiosContext.IsAlwaysOverrideEditable = true;
					importRadiosContext.OverrideOption = new global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption?(global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption.Overwrite_Always);
					num2 = (short)2010644484;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return;
				case 7:
					goto IL_1C7;
				case 8:
					goto IL_33C;
				case 9:
					num2 = (short)566296592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_97;
				case 11:
					if (e == null)
					{
						num2 = (short)110690304;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)803733507;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (importRadiosContext.CreateRadios)
					{
						num2 = (short)1501954062;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					importRadiosContext.IsNeverOverrideEditable = false;
					importRadiosContext.IsOverrideWhenFlashcodeNotChangedEditable = false;
					importRadiosContext.IsAlwaysOverrideEditable = false;
					importRadiosContext.OverrideOption = null;
					num2 = (short)446889994;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (importRadiosContext.CreateRadios)
					{
						num2 = (short)1008467977;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C9;
				case 14:
					num2 = (short)506003457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					num2 = (short)2080309248;
					short num3 = num2;
					num2 = (short)219807746;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 16:
					num2 = (short)752025601;
					if (num2 != 0)
					{
					}
					if (importRadiosContext.CreateConfigurations)
					{
						num2 = (short)714342407;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C9;
				}
				goto IL_5D;
				IL_97:
				num2 = (short)902430733;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C9:
				num2 = (short)1876429464;
				short num4 = num2;
				num2 = (short)1314196120;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2C4;
				default:
					num2 = (short)2949120;
					if (num2 != 0)
					{
					}
					importRadiosContext.IsApplyConfigurationsToRadiosEditable = false;
					importRadiosContext.ApplyConfigurationsToRadios = false;
					num2 = (short)140574726;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_33C:
				num2 = (short)36372492;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C7:
			importRadiosContext.IsApplyConfigurationsToRadiosEditable = true;
			return;
			IL_5D:
			importRadiosContext = (global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext)uiModel;
			num2 = (short)835256331;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
