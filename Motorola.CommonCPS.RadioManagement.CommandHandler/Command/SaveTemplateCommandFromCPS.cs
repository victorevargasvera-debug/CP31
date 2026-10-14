using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtility;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.CommonBase.Enums;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000D3 RID: 211
	internal class SaveTemplateCommandFromCPS : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x00048FE0 File Offset: 0x000471E0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2115698688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::Motorola.CommonCPS.Server.EntityModel.Template template;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService;
				byte[] array;
				global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
				global::Motorola.CommonCPS.Server.EntityModel.Template template2;
				for (;;)
				{
					IL_28:
					int referencedRadiosCount;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext saveTemplateAsContext;
					switch (num2)
					{
					case 0:
						goto IL_CB;
					case 1:
						goto IL_4D3;
					case 2:
						goto IL_2F9;
					case 3:
						goto IL_28F;
					case 4:
						num = (short)732233735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (referencedRadiosCount == 0)
						{
							num = (short)1973813262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D0;
					case 6:
						if (saveTemplateAsContext.IsCancel)
						{
							num = (short)1992097800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						template.Name = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetActualValue(saveTemplateAsContext.DefaultTemplateName);
						templateSummary = templateService.SaveTemplate(template, array);
						base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
						{
							templateSummary.ToUiModel(true)
						});
						num = (short)49348626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (referencedRadiosCount == 0)
						{
							num = (short)252706819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_395;
					case 8:
						return template;
					case 9:
						if (list.Count == 0)
						{
							num = (short)1920466960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F4;
					case 10:
						if (radio == null)
						{
							num = (short)607125508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_395;
					case 11:
						num = (short)1977221121;
						if (num != 0)
						{
						}
						if (radio != null)
						{
							num = (short)113377297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						template = template2;
						num = (short)1361182722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_2F9;
					case 13:
					{
						if (array == null)
						{
							num = (short)1367408640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2063550442;
						short num3 = num;
						num = (short)1055803370;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_360;
						default:
						{
							num = (short)1777598464;
							short num4 = num;
							num = (short)525008896;
							if (num != 0)
							{
							}
							template = null;
							num = (short)422379531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 14:
						goto IL_360;
					case 15:
						if (templateService.GetTemplateRawData(template.Uuid, true) == null)
						{
							num = (short)2073821185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D0;
					case 16:
						return templateSummary;
					case 17:
						template = radio.WorkingCodeplug.Template;
						num = (short)1028521996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						list = saveTemplateAsContext.ShowingRadioOptions.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption ro)
						{
							short num5 = (short)942306042;
							short num6 = num5;
							num5 = (short)1268478714;
							switch (num6 == num5)
							{
							}
							num5 = (short)2117468160;
							if (num5 != 0)
							{
							}
							num5 = (short)1294336000;
							short num7 = num5;
							num5 = (short)1439236097;
							if (num5 != 0)
							{
							}
							return ro.Option;
						}).Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption ro)
						{
							short num5 = (short)218937058;
							short num6 = num5;
							num5 = (short)1099675362;
							switch (num6 == num5)
							{
							}
							num5 = (short)104726529;
							if (num5 != 0)
							{
							}
							num5 = (short)2114650112;
							short num7 = num5;
							num5 = (short)2144403456;
							if (num5 != 0)
							{
							}
							return ro.InnerRadio;
						}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						num = (short)717750281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
					IL_D0:
					num = (short)762249226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F9:
					templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
					referencedRadiosCount = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetReferencedRadiosCount(new global::System.Collections.Generic.List<global::System.Guid>
					{
						template.Uuid
					}, false, false);
					num = (short)877789189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_360:
					num = (short)568983567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_395:
					global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext saveTemplateAsContext2 = new global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext();
					saveTemplateAsContext2.IsCancel = true;
					saveTemplateAsContext2.DefaultTemplateName = global::CommonUtility.NameUtility.GetDefaultSaveAsName(template.Name, true, false);
					saveTemplateAsContext2.RadioOptions = base.LocalService.GetReferencedRadioList(template.Uuid, false);
					saveTemplateAsContext = base.Interaction.ShowSaveTemplateAsDialog(saveTemplateAsContext2);
					num = (short)425328646;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CB:
				return false;
				IL_28F:
				global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary2 = templateService.SaveTemplate(template, array);
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>();
				dictionary.Add(template.Uuid, templateSummary2.ToUiModel(true));
				base.ViewCacheNotifier.NotifyViewCacheReplaceItems<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>(dictionary);
				return templateSummary2;
				IL_4D3:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Template_Deleted_Error);
				IL_4F4:
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ApplyTemplateBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ApplyTemplateBatchOp(list, templateSummary.Uuid, global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType.SaveTemplateOnCPS);
				base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
				return templateSummary;
				IL_7B:
				array = (paras[0] as byte[]);
				radio = (paras[1] as global::Motorola.CommonCPS.Server.EntityModel.Radio);
				template2 = (paras[2] as global::Motorola.CommonCPS.Server.EntityModel.Template);
				num = (short)474480653;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
