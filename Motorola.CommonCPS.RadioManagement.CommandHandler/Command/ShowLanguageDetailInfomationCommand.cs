using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000B0 RID: 176
	public class ShowLanguageDetailInfomationCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003DB RID: 987 RVA: 0x00040014 File Offset: 0x0003E214
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)321650688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
				global::System.Guid? id;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_177;
					case 1:
						goto IL_C5;
					case 2:
						if (radioBase != null)
						{
							num = (short)2036596737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						num = (short)1304297473;
						if (num != 0)
						{
						}
						if (id != null)
						{
							num = (short)965541888;
							short num3 = num;
							num = (short)864550912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_3F;
				}
				IL_C5:
				id = radioBase.ID;
				goto IL_ED;
				IL_177:
				bool? isOutOfSync = radioBase.IsOutOfSync;
				bool flag = true;
				return !(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null);
				IL_3F:
				radioBase = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
				num = (short)920058699;
				short num4 = num;
				num = (short)1106705227;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_ED:
					num = (short)579993603;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				default:
					num = (short)99811328;
					if (num != 0)
					{
					}
					num = (short)1303117826;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				break;
			}
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000401A0 File Offset: 0x0003E3A0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1089238403;
			short num2 = num;
			num = (short)1134065027;
			switch (num2 == num)
			{
			}
			num = (short)1298202624;
			short num3 = num;
			num = (short)1734082560;
			if (num != 0)
			{
			}
			num = (short)2048524289;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> radioLanguagesDetailInfo = base.LocalService.GetRadioLanguagesDetailInfo(radioBase.ID.Value);
			global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext showLanguagePacksContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext();
			showLanguagePacksContext.LanguagePacksDetailInfo = radioLanguagesDetailInfo;
			showLanguagePacksContext.Radio = radioBase;
			base.Interaction.ShowLanguagePacksDialog(showLanguagePacksContext);
			return null;
		}
	}
}
