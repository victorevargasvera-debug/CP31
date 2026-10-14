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
	// Token: 0x02000023 RID: 35
	internal class EditAstroDataProfileCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060001EE RID: 494 RVA: 0x0001894C File Offset: 0x00016B4C
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 5;
			short num = (short)378339328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				bool flag;
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
				global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
				global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile2;
				string text;
				object newValue;
				string empty;
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary apxdataProfileSummary;
				for (;;)
				{
					IL_30:
					bool flag2;
					switch (num2)
					{
					case 0:
						flag = (bool)paras[4];
						num = (short)1136721933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> list;
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary rawData = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AstroDataProfileService.EditDataProfileFields(radio, astroDataProfile.ID, list);
						astroDataProfile.EditingField = string.Empty;
						astroDataProfile2 = rawData.ToUiModel(true);
						global::System.Guid? id = astroDataProfile.ID;
						global::System.Guid? id2 = astroDataProfile2.ID;
						num = (short)1244004358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						flag2 = true;
						goto IL_812;
					case 3:
						if (paras.Length >= 5)
						{
							num = (short)1069350912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D4;
					case 4:
					{
						if (string.IsNullOrEmpty(text))
						{
							num = (short)2044198933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> list = null;
						radio = null;
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService iastrouivalidationService = base.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService;
						num = (short)1105657874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1856176139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Guid? id;
						global::System.Guid? id2;
						if (id != null != (id2 != null))
						{
							num = (short)1747845130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2145058839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Guid? id;
						global::System.Guid? id2;
						flag2 = (id.GetValueOrDefault() != id2.GetValueOrDefault());
						goto IL_812;
					}
					case 8:
						num = (short)1953038345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> list;
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService iastrouivalidationService;
						if (iastrouivalidationService.ValidateWhenEditRadioDataProfileColumn(astroDataProfile, text, newValue, !flag, out list, out radio, out empty))
						{
							num = (short)1969815566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257;
					}
					case 10:
						num = (short)1565261826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						flag2 = false;
						goto IL_812;
					case 12:
						if (astroDataProfile != null)
						{
							num = (short)1740046353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41D;
					case 13:
						goto IL_7D4;
					case 14:
						goto IL_423;
					case 15:
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)407175188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return astroDataProfile;
					case 16:
						goto IL_252;
					case 17:
						num = (short)1262485508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService iastrouivalidationService;
						if (iastrouivalidationService != null)
						{
							num = (short)1069678600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257;
					}
					case 19:
					{
						if (flag)
						{
							num = (short)1343815681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxdataProfileSummary = astroDataProfile.ToEntity();
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> list;
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> enumerator = list.GetEnumerator();
						num = (short)317390864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						num = (short)41555743;
						short num3 = num;
						num = (short)988092191;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_423;
						default:
							goto IL_353;
						}
						break;
					}
					case 21:
						goto IL_1D3;
					case 22:
						goto IL_82F;
					case 23:
					{
						global::System.Guid? id;
						if (id == null)
						{
							num = (short)778305541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2032402439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_97;
					IL_257:
					num = (short)399114255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_423:
					num = (short)419495955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7D4:
					num = (short)1220870156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_812:
					if (!flag2)
					{
						break;
					}
					num = (short)2064908310;
					num2 = (int)((global::System.IntPtr)num);
				}
				astroDataProfile.CopyFrom(astroDataProfile2);
				base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
				{
					astroDataProfile2
				});
				return astroDataProfile;
				IL_1D3:
				num = (short)1425539073;
				if (num != 0)
				{
				}
				num = (short)309592064;
				short num4 = num;
				goto IL_41D;
				IL_252:
				try
				{
					num = (short)1521483776;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text2;
						global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object> keyValuePair;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_4DF;
							}
							continue;
						case 1:
							goto IL_55C;
						case 2:
							text2 = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("럵釷裹뗻都瓿朁瘃怅椇椉椋䜍䀏", a_);
							num = (short)229900299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (text2 == global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.AstroBluetoothDunSubscriberIp.ToString())
							{
								num = (short)345047047;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_55C;
						case 4:
							goto IL_55C;
						case 5:
							goto IL_70A;
						case 6:
							text2 = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("듵铷迹駻諽濿洁瀃清䰇弉䈋帍甏眑易引䠗", a_);
							num = (short)1060831233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							text2 = global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("듵铷迹駻諽濿洁瀃清䰇弉䈋崍攏瀑朓甕樗猙縛笝刟次琣", a_);
							num = (short)1148059652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (text2 == global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.AstroBluetoothDunPeerIp.ToString())
							{
								num = (short)919601158;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1856176131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (text2 == global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType.AirInterfaceAddress.ToString())
							{
								num = (short)1757806594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1784021000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_55C;
						case 12:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)87556109;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							keyValuePair = enumerator.Current;
							text2 = keyValuePair.Key.ToString();
							num = (short)2099707913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							num = (short)1753284613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DF;
						IL_55C:
						apxdataProfileSummary.GetType().GetProperty(text2).SetValue(apxdataProfileSummary, keyValuePair.Value);
						num = (short)1935867914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_685:
						num = (short)2055864332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4DF:
						goto IL_685;
					}
					IL_70A:
					goto IL_309;
				}
				finally
				{
					num = (short)1979187200;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> enumerator;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_742;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)705167362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_77A;
						}
						IL_742:
						if (enumerator == null)
						{
							break;
						}
						num = (short)735117313;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_77A:;
				}
				goto IL_77D;
				IL_309:
				global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile source = apxdataProfileSummary.ToUiModel(true);
				astroDataProfile.CopyFrom(source);
				return astroDataProfile;
				IL_353:
				num = (short)1593049088;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Special_Display_Msg, empty);
				IL_41D:
				throw new global::System.ArgumentNullException();
				IL_77D:
				base.ASTROLocalService.RefreshDataProfileForRadio((global::Motorola.CommonCPS.Server.EntityModel.APXRadio)radio);
				return astroDataProfile2;
				IL_82F:
				goto IL_77D;
				IL_97:
				empty = string.Empty;
				astroDataProfile = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile);
				text = (paras[1] as string);
				newValue = paras[2];
				flag = true;
				num = (short)240254979;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
