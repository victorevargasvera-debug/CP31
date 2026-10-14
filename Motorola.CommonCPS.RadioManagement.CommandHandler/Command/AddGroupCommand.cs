using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000B7 RID: 183
	internal class AddGroupCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00041FC8 File Offset: 0x000401C8
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1223032833;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num2;
			global::System.Guid? parentGroupUuid;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
					goto IL_D6;
				case 1:
					parentGroupUuid = ((global::Motorola.CommonCPS.RadioManagement.UIModels.Group)paras[0]).ID;
					num = (short)67305472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1005204296;
					short num3 = num;
					num = (short)960443208;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13D;
					default:
						num = (short)1961820160;
						if (num != 0)
						{
						}
						num = (short)1382023171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_13D;
				case 4:
					if (paras.Length != 0)
					{
						num = (short)1428881410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_163;
				}
				goto IL_4C;
				IL_13D:
				if (!(paras[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.Group))
				{
					break;
				}
				num = (short)2078343169;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D6:
			IL_163:
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.AddGroup(parentGroupUuid);
			IL_4C:
			parentGroupUuid = null;
			num = (short)637337600;
			short num4 = num;
			num = (short)432472068;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}
	}
}
