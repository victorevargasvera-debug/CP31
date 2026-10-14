using System;
using System.Collections.Generic;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000060 RID: 96
	internal class EditAstroSystemCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002EB RID: 747 RVA: 0x0002BC30 File Offset: 0x00029E30
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2003173376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				string empty;
				global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem astroSystem;
				string text;
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
				bool flag;
				global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary apxradioSystemSummary;
				global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem astroSystem2;
				object newValue;
				for (;;)
				{
					IL_27:
					bool flag2;
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)706805772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return astroSystem;
					case 1:
					{
						if (string.IsNullOrEmpty(text))
						{
							num = (short)457179146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> list = null;
						radio = null;
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService iastrouivalidationService = base.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService;
						num = (short)1004470275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)17302559;
						short num3 = num;
						num = (short)281740319;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_60F;
						default:
						{
							num = (short)2066939904;
							short num4 = num;
							num = (short)1184169984;
							if (num != 0)
							{
							}
							if (flag)
							{
								num = (short)1576271876;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							apxradioSystemSummary = astroSystem.ToEntity();
							global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> list;
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> enumerator = list.GetEnumerator();
							num = (short)1760100365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService iastrouivalidationService;
						if (iastrouivalidationService != null)
						{
							num = (short)279314447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FB;
					}
					case 4:
					{
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> list;
						astroSystem2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AstroSystemService.EditSystemFields(radio, astroSystem.ID, list).ToUiModel(true);
						global::System.Guid? id = astroSystem.ID;
						global::System.Guid? id2 = astroSystem2.ID;
						num = (short)1788936199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Guid? id;
						global::System.Guid? id2;
						flag2 = (id.GetValueOrDefault() != id2.GetValueOrDefault());
						goto IL_655;
					}
					case 6:
						num = (short)8060929;
						if (num != 0)
						{
						}
						num = (short)1742143489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Guid? id;
						global::System.Guid? id2;
						if (id != null != (id2 != null))
						{
							num = (short)1486749713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)922877970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (paras.Length >= 5)
						{
							num = (short)1274085397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F1;
					case 9:
					{
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> list;
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService iastrouivalidationService;
						if (iastrouivalidationService.ValidateWhenEditRadioSystemColumn(astroSystem, text, newValue, !flag, out list, out radio, out empty))
						{
							num = (short)1522532374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FB;
					}
					case 10:
						goto IL_1C7;
					case 11:
						goto IL_5F1;
					case 12:
						goto IL_237;
					case 13:
						goto IL_1F6;
					case 14:
						num = (short)830865428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1445724169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						flag2 = true;
						goto IL_655;
					case 17:
						num = (short)1063714832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::System.Guid? id;
						if (id == null)
						{
							num = (short)155254798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1184759813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_673;
					case 20:
						flag2 = false;
						goto IL_655;
					case 21:
						flag = (bool)paras[4];
						num = (short)1325269003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)423493634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (astroSystem != null)
						{
							goto IL_60F;
						}
						goto IL_36D;
					}
					goto IL_8E;
					IL_1FB:
					num = (short)1390018560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F1:
					num = (short)1996423191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60F:
					num = (short)1609170950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_655:
					if (!flag2)
					{
						break;
					}
					num = (short)1084096531;
					num2 = (int)((global::System.IntPtr)num);
				}
				astroSystem.CopyFrom(astroSystem2);
				base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
				{
					astroSystem2
				});
				return astroSystem;
				IL_1C7:
				goto IL_36D;
				IL_1F6:
				try
				{
					num = (short)430178306;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							num = (short)1467678724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_47D;
							}
							continue;
						case 3:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)2036400129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object> keyValuePair = enumerator.Current;
							apxradioSystemSummary.GetType().GetProperty(keyValuePair.Key.ToString()).SetValue(apxradioSystemSummary, keyValuePair.Value);
							num = (short)1254031360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_524;
						}
						IL_4CF:
						num = (short)629080067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_47D:
						goto IL_4CF;
					}
					IL_524:
					goto IL_2AC;
				}
				finally
				{
					num = (short)1030488064;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> enumerator;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_55C;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1404567554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_594;
						}
						IL_55C:
						if (enumerator == null)
						{
							break;
						}
						num = (short)899350529;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_594:;
				}
				goto IL_597;
				IL_2AC:
				global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem source = apxradioSystemSummary.ToUiModel(true);
				astroSystem.CopyFrom(source);
				return astroSystem;
				IL_237:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Special_Display_Msg, empty);
				IL_36D:
				throw new global::System.ArgumentNullException();
				IL_597:
				base.ASTROLocalService.RefreshRadioSystemViewForRadio((global::Motorola.CommonCPS.Server.EntityModel.APXRadio)radio);
				return astroSystem2;
				IL_673:
				goto IL_597;
				IL_8E:
				empty = string.Empty;
				astroSystem = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem);
				text = (paras[1] as string);
				newValue = paras[2];
				flag = true;
				num = (short)2111504392;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
