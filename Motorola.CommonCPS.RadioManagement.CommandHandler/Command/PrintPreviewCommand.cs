using System;
using System.Collections.Generic;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000C4 RID: 196
	internal class PrintPreviewCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000418 RID: 1048 RVA: 0x0004597C File Offset: 0x00043B7C
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 13;
			short num = (short)2065610918;
			short num2 = num;
			num = (short)197114022;
			switch (num2 == num)
			{
			default:
			{
				num = (short)411959296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)57999361;
			if (num != 0)
			{
			}
			num = (short)848035840;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>>();
			dictionary.Add(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꯽䧿䄁氃朅昇洉椋䜍縏瘑紓甕礗渙猛氝", a_), new global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>(new global::Motorola.CommonCPS.RadioManagement.Converters.ChangeIndivatorConverter(), typeof(string)));
			dictionary.Add(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("곽懿昁洃椅䄇渉", a_), new global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>(new global::Motorola.CommonCPS.RadioManagement.Converters.PrintPreviewIDToNAConverter(), typeof(string)));
			dictionary.Add(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뷽䇿䬁", a_), new global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>(new global::Motorola.CommonCPS.RadioManagement.Converters.PrintPreviewIDToNAConverter(), typeof(string)));
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꯽珿朁瘃嘅䄇䐉", a_));
			global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext printViewContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext();
			printViewContext.FieldNeedSpecialConverter = dictionary;
			printViewContext.FieldNeedCollapsed = list;
			base.Interaction.NotifyPrintViewPreview(printViewContext);
			return null;
		}
	}
}
