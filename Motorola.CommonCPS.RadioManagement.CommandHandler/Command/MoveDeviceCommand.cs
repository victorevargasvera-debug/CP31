using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000BA RID: 186
	internal class MoveDeviceCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003FB RID: 1019 RVA: 0x000429D8 File Offset: 0x00040BD8
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)92209152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
				for (;;)
				{
					IL_28:
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService radioService;
					switch (num2)
					{
					case 0:
						group = null;
						goto IL_207;
					case 1:
						goto IL_200;
					case 2:
					{
						global::System.Guid? id = group.ID;
						num = (short)301072393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_116;
					case 4:
						goto IL_11B;
					case 5:
					{
						global::System.Guid? id;
						if (id == null)
						{
							num = (short)1159004160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11B;
					}
					case 6:
					{
						num = (short)961165305;
						short num3 = num;
						num = (short)1837971449;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_207;
						default:
							num = (short)1804075008;
							if (num != 0)
							{
							}
							if (group != null)
							{
								num = (short)1402601482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11B;
						}
						break;
					}
					case 7:
						radioBase = radioService.MoveDeviceToGroup(radioBase2.ToServerModel(), group).ToUiModel(true);
						num = (short)469368835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (group != null)
						{
							num = (short)1368522754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D3;
					case 9:
					{
						global::System.Guid? id;
						if (id != null)
						{
							num = (short)654180352;
							short num4 = num;
							num = (short)766705671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D3;
					}
					case 10:
					{
						num = (short)1711800321;
						if (num != 0)
						{
						}
						global::System.Guid? id = group.ID;
						num = (short)1909587973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5B;
					IL_11B:
					radioService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService;
					radioBase = null;
					num = (short)1814298632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D3:
					radioBase = radioService.MoveDeviceToGroup(radioBase2.ToServerModel(), null).ToUiModel(true);
					num = (short)722272257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_207:
					num = (short)142409732;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_116:
				IL_200:
				base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
				{
					radioBase
				});
				radioBase2.CopyFrom(radioBase);
				return null;
				IL_5B:
				radioBase2 = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
				group = (paras[2] as global::Motorola.CommonCPS.RadioManagement.UIModels.Group);
				num = (short)1332805638;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
