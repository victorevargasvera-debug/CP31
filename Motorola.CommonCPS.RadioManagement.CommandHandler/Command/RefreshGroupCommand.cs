using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000035 RID: 53
	internal class RefreshGroupCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000235 RID: 565 RVA: 0x0001D4E0 File Offset: 0x0001B6E0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1852170308;
			short num2 = num;
			num = (short)1009639492;
			switch (num2 == num)
			{
			}
			num = (short)71106560;
			if (num != 0)
			{
			}
			num = (short)1909325824;
			short num3 = num;
			num = (short)1574764545;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.GetGroupsTree();
		}
	}
}
