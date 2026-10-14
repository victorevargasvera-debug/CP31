using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000D8 RID: 216
	public class ShowTemplateLanguageDetailInfomationCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x0004A318 File Offset: 0x00048518
		public override bool CanExecute(params object[] paras)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase;
			short num;
			for (;;)
			{
				templateBase = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase);
				if (templateBase != null)
				{
					num = (short)2016437415;
					short num2 = num;
					num = (short)1809409191;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_70;
					}
					break;
				}
				return false;
			}
			num = (short)1747582976;
			short num3 = num;
			IL_70:
			num = (short)1173291009;
			if (num != 0)
			{
			}
			num = (short)1598095360;
			if (num != 0)
			{
			}
			return templateBase.ID != null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0004A3E4 File Offset: 0x000485E4
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1373286613;
			short num2 = num;
			num = (short)1839182037;
			switch (num2 == num)
			{
			}
			num = (short)1124401152;
			short num3 = num;
			num = (short)95027201;
			if (num != 0)
			{
			}
			num = (short)4259840;
			if (num != 0)
			{
			}
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> languagePacksDetailInfo = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>();
			global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext showTemplateLanguagePacksContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext();
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase;
			languagePacksDetailInfo = base.LocalService.GetTemplateLanguagesDetailInfo(templateBase.ID.Value);
			showTemplateLanguagePacksContext.LanguagePacksDetailInfo = languagePacksDetailInfo;
			base.Interaction.ShowTemplateLanguagePacksDialog(showTemplateLanguagePacksContext);
			return null;
		}
	}
}
