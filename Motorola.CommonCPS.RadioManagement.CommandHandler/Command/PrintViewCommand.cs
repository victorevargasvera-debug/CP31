using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000C5 RID: 197
	internal class PrintViewCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x00045AF8 File Offset: 0x00043CF8
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 0;
			short num = (short)147980288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)784400385;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
				for (;;)
				{
					IL_58:
					switch (num2)
					{
					case 0:
						num = (short)9699332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_166;
					case 2:
					{
						if (list == null)
						{
							goto IL_1A3;
						}
						num = (short)224002265;
						short num3 = num;
						num = (short)1364590809;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14E;
						default:
						{
							num = (short)151912448;
							short num4 = num;
							num = (short)1114046464;
							if (num != 0)
							{
							}
							num = (short)1012531200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						list = (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext as global::System.ComponentModel.ICollectionView).SourceCollection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
						goto IL_14E;
					case 4:
						if (list.Count == 0)
						{
							num = (short)1353580547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					}
					goto IL_73;
					IL_14E:
					num = (short)2085158913;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_166:
				IL_1A3:
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>>();
				dictionary.Add(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꓰ뫲뛴鿶飸闺髼髾䠀洂愄渆樈樊礌怎挐", a_), new global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>(new global::Motorola.CommonCPS.RadioManagement.Converters.ChangeIndivatorConverter(), typeof(string)));
				global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
				list2.Add(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꓰ胲郴藶꧸닺돼", a_));
				global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext printViewContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext();
				printViewContext.SelectedDataItems = list;
				printViewContext.FieldNeedSpecialConverter = dictionary;
				printViewContext.FieldNeedCollapsed = list2;
				base.Interaction.NotifyPrintView(printViewContext);
				return null;
				IL_73:
				list = null;
				list = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
				num = (short)2044329986;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}
	}
}
