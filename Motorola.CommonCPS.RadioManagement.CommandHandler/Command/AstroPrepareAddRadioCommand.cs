using System;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000046 RID: 70
	public class AstroPrepareAddRadioCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000279 RID: 633 RVA: 0x00021EAC File Offset: 0x000200AC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)98500609;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1010506212;
				short num3 = num;
				num = (short)745150948;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1629356032;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1056374784;
						short num4 = num;
						num = (short)33095682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_15;
					case 2:
						num = (short)2071592961;
						if (num != 0)
						{
						}
						if (paras.Length != 0)
						{
							num = (short)1566048259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187;
					case 3:
						goto IL_182;
					}
					goto IL_81;
				}
				IL_15:
				switch (0)
				{
				case 0:
					IL_81:
					if (paras == null)
					{
						goto IL_187;
					}
					num = (short)242286592;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_182:
			global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext addRadioContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext
			{
				Radio = this.CreateRadio()
			};
			global::Motorola.CommonCPS.RadioManagement.UIModels.Group curentGroup = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.Group;
			addRadioContext.Radio.ProductFamily = new global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily?(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily);
			addRadioContext.Radio.CurentGroup = curentGroup;
			addRadioContext.Radio.Validator = this.CreateContextValidator();
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowAddRadioDialog(addRadioContext);
			return true;
			IL_187:
			return false;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00022048 File Offset: 0x00020248
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1534459905;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)617611265;
				if (num != 0)
				{
				}
				num = (short)934588367;
				short num3 = num;
				num = (short)1680322511;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2049703936;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)2052194306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_15;
					case 2:
						if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsMaintenanceMode)
						{
							num = (short)533004291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						goto IL_132;
					}
					goto IL_A7;
				}
				IL_15:
				switch (0)
				{
				case 0:
					IL_A7:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
					{
						return true;
					}
					num = (short)1675689984;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_132:
			num = (short)1516699648;
			short num4 = num;
			return false;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0002218C File Offset: 0x0002038C
		protected virtual global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio CreateRadio()
		{
			short num = (short)1214578688;
			short num2 = num;
			num = (short)1057596447;
			short num3 = num;
			num = (short)259695647;
			switch (num3 == num)
			{
			}
			num = (short)799473664;
			if (num != 0)
			{
			}
			num = (short)1111883777;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00022238 File Offset: 0x00020438
		protected virtual global::Motorola.CommonCPS.RadioManagement.LocalService.AddAstroRadioContextValidator CreateContextValidator()
		{
			short num = (short)1908015104;
			short num2 = num;
			num = (short)1757874617;
			short num3 = num;
			num = (short)1570310585;
			switch (num3 == num)
			{
			}
			num = (short)1247870977;
			if (num != 0)
			{
			}
			num = (short)198967296;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.AddAstroRadioContextValidator();
		}
	}
}
