using System;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000025 RID: 37
	internal class GetDatabaseSizeSummaryCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x000193AC File Offset: 0x000175AC
		public override bool CanExecute(params object[] paras)
		{
			short num;
			if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
			{
				num = (short)1244528641;
				if (num != 0)
				{
				}
				num = (short)357083131;
				short num2 = num;
				num = (short)1756801019;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)507576320;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)1010040832;
			short num3 = num;
			return true;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00019460 File Offset: 0x00017660
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2128623589;
			short num2 = num;
			num = (short)117716965;
			switch (num2 == num)
			{
			default:
			{
				num = (short)457113600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)747634688;
			if (num != 0)
			{
			}
			num = (short)1165492225;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetDatabaseSizeSummary();
		}
	}
}
