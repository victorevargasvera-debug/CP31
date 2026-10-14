using System;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000022 RID: 34
	internal class AboutCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060001EC RID: 492 RVA: 0x0001887C File Offset: 0x00016A7C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)30820999;
			short num2 = num;
			num = (short)447236743;
			switch (num2 == num)
			{
			default:
			{
				num = (short)607584256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)93257729;
			if (num != 0)
			{
			}
			num = (short)2048262144;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowAboutDialog();
			return true;
		}
	}
}
