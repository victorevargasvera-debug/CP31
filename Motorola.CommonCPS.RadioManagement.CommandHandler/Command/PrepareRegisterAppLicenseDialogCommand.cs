using System;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200007F RID: 127
	internal class PrepareRegisterAppLicenseDialogCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600033D RID: 829 RVA: 0x000328CC File Offset: 0x00030ACC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1705145396;
			short num2 = num;
			num = (short)877425716;
			switch (num2 == num)
			{
			}
			num = (short)864157696;
			short num3 = num;
			num = (short)298254337;
			if (num != 0)
			{
			}
			num = (short)423755776;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext registerApplicationLicenseContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext();
			base.Interaction.ShowRegisterApplicationLicenseDialog(registerApplicationLicenseContext);
			return null;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00032988 File Offset: 0x00030B88
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1082752502;
			short num2 = num;
			num = (short)24935926;
			switch (num2 == num)
			{
			}
			num = (short)1641873408;
			short num3 = num;
			num = (short)663748609;
			if (num != 0)
			{
			}
			num = (short)90963968;
			if (num != 0)
			{
			}
			return true;
		}
	}
}
