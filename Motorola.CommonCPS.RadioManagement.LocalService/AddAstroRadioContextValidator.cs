using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000039 RID: 57
	public class AddAstroRadioContextValidator : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x06000215 RID: 533 RVA: 0x000249D0 File Offset: 0x00022BD0
		public void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 2;
			short num = (short)1658912768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_107;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
				string text2;
				global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService astrouivalidationService;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> radioIPErrors;
					global::System.Type type;
					string text;
					switch (num2)
					{
					case 0:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帛爝唟䜡倣䤥䜧帩䐫栭䈯嬱儳堵尷嘹䔻瀽ℿ⽁⅃", a_)))
						{
							num = (short)1686700065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B44;
					case 1:
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>>>.Enumerator enumerator = radioIPErrors.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>>, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.AddAstroRadioContextValidator.<>c.<>9.a)).ToList<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>>>().GetEnumerator();
						num = (short)396296229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("堛䠝爟無氣䜥娧丩嬫伭䈯圱焳堵夷堹倻嬽", a_))
						{
							num = (short)1809842176;
							short num3 = num;
							num = (short)2053832752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_7F8;
					case 4:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帛爝唟䜡倣䤥䜧帩䐫欭帯匱嘳娵崷", a_)))
						{
							num = (short)683343891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B44;
					case 5:
						goto IL_86C;
					case 6:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("丛缝䐟䬡䬣甥尧䬩堫嬭䌯", a_))
						{
							num = (short)1249443862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)498008106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䤛洝䔟倡栣䤥伧䌩䈫笭帯嬱䀳缵簷", a_)))
						{
							num = (short)612630560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_693;
					case 8:
						goto IL_3FF;
					case 9:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("丛缝䐟䬡䬣甥尧䬩堫嬭䌯", a_))
						{
							num = (short)1786904579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1258291213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("娛焝刟䜡䴣䄥䘧挩簫", a_))
						{
							num = (short)1388707889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1185153068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伛笝刟䬡䔣䨥昧弩䄫䰭唯䀱", a_))
						{
							num = (short)379125795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1443495953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_750;
					case 13:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伛欝䈟儡䜣吥䄧䠩䤫尭礯戱", a_)))
						{
							num = (short)847052816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D8;
					case 14:
						goto IL_A42;
					case 15:
						goto IL_597;
					case 16:
						num = (short)859308033;
						if (num != 0)
						{
						}
						num = (short)1628241965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䰛缝匟儡猣䤥娧丩", a_))
						{
							num = (short)1160904732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)371916810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)2047475751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1192755206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (string.IsNullOrEmpty(astroradio.SerialNumber))
						{
							num = (short)2003697695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD8;
					case 21:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䤛洝䔟倡琣漥昧", a_))
						{
							num = (short)943259662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_282;
					case 22:
						goto IL_9EE;
					case 23:
						goto IL_5D8;
					case 24:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("匛樝䄟倡洣戥", a_))
						{
							num = (short)420151308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)497614875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)2071920678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_946;
					case 27:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䤛洝䔟倡樣䜥䔧伩", a_)))
						{
							num = (short)774570013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_453;
					case 28:
						goto IL_B3F;
					case 29:
						num = (short)1082589214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䤛洝䔟倡樣䜥䔧伩栫䜭䌯䈱堳圵䄷渹夻䘽㐿ᅁⵃ㱅ⵇ", a_))
						{
							num = (short)252772357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1315373077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_68E;
					case 32:
						num = (short)1959460911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)2049572868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1231421442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)985464852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1469841417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						try
						{
							num = (short)551419905;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)794942159;
									short num4 = num;
									num = (short)152623823;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1CA;
									default:
										goto IL_259;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_195;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>>>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1547304964;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair = enumerator.Current;
									type.GetProperty(keyValuePair.Key).SetValue(astroradio, "", null);
									num = (short)1454112770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1CA;
								}
								IL_197:
								num = (short)2140995587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_195:
								goto IL_197;
								IL_1CA:
								num = (short)854720512;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_259:
							num = (short)1261895680;
							if (num != 0)
							{
							}
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>>>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_282;
					case 38:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帛爝唟䜡倣䤥䜧帩䐫樭支簱搳匵崷䠹画渽", a_))
						{
							num = (short)48496663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2046164992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("帛爝唟䜡倣䤥䜧帩䐫樭支簱朳䌵娷䤹弻䰽⤿⁁⅃㑅Ňᩉ", a_)))
						{
							num = (short)551485465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D8;
					case 40:
						return;
					case 41:
						type.GetProperty(text).SetValue(astroradio, radioIPErrors[text][0], null);
						num = (short)791805960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䨛䰝椟昡", a_)))
						{
							num = (short)903938082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91B;
					case 43:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䤛洝䔟倡栣䤥伧䌩䈫笭帯嬱䀳缵簷渹夻䘽㐿ᅁⵃ㱅ⵇ", a_)))
						{
							num = (short)2075721764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_693;
					case 44:
						if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("丛缝䐟䬡䬣朥䐧䌩䴫崭", a_))
						{
							num = (short)1787166735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)261881880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䰛笝䔟倡洣瘥", a_)))
						{
							num = (short)970850322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D8;
					case 46:
						if (e == null)
						{
							num = (short)721420328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text2 = "";
						num = (short)105906187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䤛洝䔟倡栣䤥伧䌩䈫笭帯嬱䀳缵簷缹刻弽∿⹁⅃", a_)))
						{
							num = (short)311427123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_693;
					case 48:
						goto IL_91B;
					case 49:
						goto IL_C12;
					case 50:
						if (radioIPErrors[text].Count > 0)
						{
							num = (short)1060175913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FF;
					case 51:
						num = (short)1476460587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_107;
					IL_282:
					num = (short)1971585031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FF:
					num = (short)496369665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D8:
					radioIPErrors = astrouivalidationService.GetRadioIPErrors(astroradio);
					type = astroradio.GetType();
					text = e.PropertyName + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("夛氝刟䴡嘣", a_);
					num = (short)2142502962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_91B:
					astrouivalidationService.ValidateDeviceVRID(astroradio, out text2, true);
					astroradio.VRIDError = text2;
					num = (short)896073754;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_453:
				astrouivalidationService.ValidateUserName(astroradio.UserName, astroradio.UserNameDisplayTextSize, out text2);
				astroradio.UserNameError = text2;
				return;
				IL_597:
				astrouivalidationService.ValidateRadioAlias(astroradio.RadioAlias, out text2);
				astroradio.RadioAliasError = text2;
				return;
				IL_68E:
				astroradio.SerialNumberError = null;
				return;
				IL_693:
				astrouivalidationService.ValidateUserLoginUnitID(astroradio.UserLoginUnitID, astroradio.UserLoginUnitIDTextSize, out text2);
				astroradio.UserLoginUnitIDError = text2;
				return;
				IL_750:
				astrouivalidationService.ValidateOTARID(astroradio, out text2);
				astroradio.OtarIDError = text2;
				return;
				IL_7F8:
				goto IL_693;
				IL_86C:
				goto IL_453;
				IL_946:
				return;
				IL_9EE:
				goto IL_B44;
				IL_A42:
				astrouivalidationService.ValidateUserPIN(astroradio.UserPIN, out text2);
				astroradio.UserPINError = text2;
				return;
				IL_AD8:
				astrouivalidationService.ValidateSerialNumber(astroradio.SerialNumber, out text2);
				astroradio.SerialNumberError = text2;
				return;
				IL_B3F:
				astrouivalidationService.ValidatePassWord(astroradio.PassWord, out text2);
				astroradio.PassWordError = text2;
				return;
				IL_B44:
				astrouivalidationService.ValidateDeviceBluetoothFriendlyName(astroradio.BluetoothFriendlyName, out text2);
				astroradio.BluetoothFriendlyNameError = text2;
				return;
				IL_C12:
				astrouivalidationService.ValidateForeignIP(astroradio.ForeignIP, out text2);
				astroradio.ForeignIPError = text2;
				return;
				IL_107:
				astrouivalidationService = (global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService);
				astroradio = (uiModel as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
				num = (short)1712586798;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
