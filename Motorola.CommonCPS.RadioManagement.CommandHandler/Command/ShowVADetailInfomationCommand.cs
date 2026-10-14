using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000AF RID: 175
	public class ShowVADetailInfomationCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x0003FD80 File Offset: 0x0003DF80
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1271136256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
				global::System.Guid? id;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_17A;
					case 1:
						goto IL_F0;
					case 2:
						if (radioBase != null)
						{
							num = (short)1535574017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						if (id != null)
						{
							num = (short)464519168;
							short num3 = num;
							num = (short)1503920128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_3E;
				}
				IL_F0:
				id = radioBase.ID;
				goto IL_118;
				IL_17A:
				bool? isOutOfSync = radioBase.IsOutOfSync;
				bool flag = true;
				return !(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null);
				IL_3E:
				num = (short)1877278721;
				if (num != 0)
				{
				}
				radioBase = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
				num = (short)179789509;
				short num4 = num;
				num = (short)1294425797;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_118:
					num = (short)41156611;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				default:
					num = (short)1050148864;
					if (num != 0)
					{
					}
					num = (short)821493762;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0003FF10 File Offset: 0x0003E110
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1139081217;
			if (num != 0)
			{
			}
			num = (short)1147325349;
			short num2 = num;
			num = (short)1062849445;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1394343936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)808321024;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> radioVADetailInfo = base.LocalService.GetRadioVADetailInfo(radioBase.ID.Value);
			global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext showVAPacksContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext();
			showVAPacksContext.VAPacksDetailInfo = radioVADetailInfo;
			showVAPacksContext.Radio = radioBase;
			base.Interaction.ShowVAPacksDialog(showVAPacksContext);
			return null;
		}
	}
}
