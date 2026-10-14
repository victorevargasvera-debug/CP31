using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;

namespace CommonUtility
{
	// Token: 0x02000028 RID: 40
	public class CFSUtility
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00019158 File Offset: 0x00017358
		public static string GenerateCFS(global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier pac, string pbbProductIdentifier, string pbbModelNumber, global::System.Collections.Generic.List<string> enabledFeatures = null, int disableStatus = 2, int activeStatus = 8)
		{
			short num = (short)1167458304;
			switch (num)
			{
			default:
			{
				num = (short)413397052;
				short num2 = num;
				num = (short)1396502588;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1D8:
					goto IL_1DA;
				case 1:
					goto IL_7E;
				default:
				{
					num = (short)697499648;
					short num3 = num;
					goto IL_7E;
				}
				}
				int num4;
				string text;
				for (;;)
				{
					IL_B3:
					int num5;
					global::System.Array values;
					global::System.Collections.Generic.List<int> radioFeatureList;
					int num6;
					switch (num4)
					{
					case 0:
						goto IL_217;
					case 1:
						if (enabledFeatures != null)
						{
							num = (short)1653866499;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_222;
					case 2:
						goto IL_1D8;
					case 3:
						num = (short)1101004807;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_26E;
					case 5:
						num5 = activeStatus;
						num = (short)1379794953;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_E6;
						}
						continue;
					case 7:
						num = (short)89325569;
						if (num != 0)
						{
						}
						if (enabledFeatures.Contains(values.GetValue(radioFeatureList[num6]).ToString()))
						{
							num = (short)297074693;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_222;
					case 8:
						if (num6 >= radioFeatureList.Count)
						{
							num = (short)2039218176;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = disableStatus;
						num = (short)5308417;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_222;
					case 10:
						goto IL_102;
					}
					IL_E6:
					if (pac != global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier.PBB)
					{
						num = (short)1458634762;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = string.Empty;
					values = global::System.Enum.GetValues(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.PBBFeatureCode));
					radioFeatureList = global::CommonUtility.CFSUtility.GetRadioFeatureList(pbbProductIdentifier, pbbModelNumber);
					num6 = 0;
					num = (short)179765250;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_222:
					text += string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseTags.PBB_LICENSENODESTRINGFORMAT, values.GetValue(radioFeatureList[num6]), global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseTags.LICENSE_STATUS, num5);
					num6++;
					num = (short)559153156;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_102:
				throw new global::System.NotImplementedException();
				IL_217:
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseTags.PBB_LICENSEXMLSTRINGFORMAT, global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseTags.LICENSES, text);
				IL_26E:
				goto IL_1DA;
				IL_7E:
				num = (short)1275068416;
				if (num != 0)
				{
				}
				num = (short)1556873222;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_B3;
				IL_1DA:
				num = (short)1145438216;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_B3;
			}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001942C File Offset: 0x0001762C
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> GetRadioFeatureRequests(global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier pac, string ModelNumber, string serialNumber, global::Motorola.CommonCPS.Server.EntityModel.BLVersion cpVersion)
		{
			short num = (short)1625948160;
			switch (num)
			{
			default:
			{
				num = (short)339804161;
				if (num != 0)
				{
				}
				num = (short)880017410;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>.Enumerator enumerator;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> list;
					switch (num2)
					{
					case 0:
						goto IL_95;
					case 1:
						try
						{
							num = (short)591659012;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)1570111491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)851219708;
									short num3 = num;
									num = (short)364483836;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1502281728;
										if (num != 0)
										{
										}
										if (enumerator.MoveNext())
										{
											global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode featureName = enumerator.Current;
											list.Add(new global::Motorola.CommonCPS.Server.EntityModel.RadioFeature
											{
												FeatureName = (int)featureName,
												CurrentStatus = 2,
												WorkingStatus = 2,
												SerialNumber = serialNumber,
												ModelNumber = ModelNumber,
												LicenseName = featureName.ToString(),
												FeatureType = 0
											});
											num = (short)362807296;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									num = (short)1028521985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1E4;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_D4;
									}
									continue;
								}
								IL_142:
								num = (short)1012531202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D4:
								goto IL_142;
							}
							IL_1E4:
							return list;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1F4;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_77;
						}
						continue;
					}
					IL_77:
					if (pac != global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier.PCR)
					{
						num = (short)458096640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1F4:
					num = (short)436535296;
					short num4 = num;
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>();
					new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>();
					enumerator = cpVersion.GetCapacityMaxFeatures().GetEnumerator();
					num = (short)575078401;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_95:
				throw new global::System.NotImplementedException();
			}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000196B0 File Offset: 0x000178B0
		public static void MergePCR_GenerateDMR3ControllerOptionsCollection(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num = (short)283246592;
			switch (num)
			{
			default:
			{
				num = (short)787021825;
				if (num != 0)
				{
				}
				num = (short)110821376;
				short num2 = num;
				global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection optionsCollection = global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection.DeserializeFromXML(radio.WorkingCodeplug.CFS);
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>.Enumerator enumerator = new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(radio.WorkingCodeplug.CodeplugVersion).GetCapacityMaxFeatures().GetEnumerator())
				{
					num = (short)1137901574;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition optionID = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCR_OptionIDDefinition(a2.a.ToString(), null);
							global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem optionDesItem = new global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem(global::CommonUtility.CFSUtility.TCCFSDictionary[a2.a.ToString()], optionID, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller);
							optionDesItem.OptionStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.CFS_DISABLED;
							optionDesItem.Visible = true;
							optionsCollection.OptionsList.Add(optionDesItem);
							num = (short)1119354883;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)421462018;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_25B;
						case 3:
						{
							num = (short)441391086;
							short num4 = num;
							num = (short)1627920366;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_123;
							default:
								num = (short)91619328;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1818296321;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode a = enumerator.Current;
							num = (short)1228734469;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							if (!optionsCollection.OptionsList.Exists(new global::System.Predicate<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem>(a2.b)))
							{
								goto IL_123;
							}
							break;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_DD;
							}
							continue;
						}
						goto IL_DD;
						IL_123:
						num = (short)1377435648;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_13A:
						num = (short)1954349060;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DD:
						goto IL_13A;
					}
					IL_25B:;
				}
				radio.WorkingCodeplug.CFS = optionsCollection.SerializeToXML();
				return;
			}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00019958 File Offset: 0x00017B58
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> GetRadioFeatureRequests(global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier pac, string pbbProductIdentifier, string pbbModelNumber, string serialNumber)
		{
			short num = (short)1465843712;
			switch (num)
			{
			default:
			{
				num = (short)384696320;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<int>.Enumerator enumerator;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> list;
					global::System.Array values;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					case 1:
					{
						num = (short)1848705024;
						short num3 = num;
						try
						{
							num = (short)1550909440;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_AA;
									}
									continue;
								case 2:
									goto IL_1C1;
								case 3:
								{
									num = (short)1883607067;
									short num4 = num;
									num = (short)832737307;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1C1;
									default:
										num = (short)1201143808;
										if (num != 0)
										{
										}
										num = (short)1565327362;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1250820099;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num5 = enumerator.Current;
									list.Add(new global::Motorola.CommonCPS.Server.EntityModel.RadioFeature
									{
										FeatureName = num5,
										CurrentStatus = 2,
										WorkingStatus = 2,
										LicenseName = values.GetValue(num5).ToString(),
										SerialNumber = serialNumber,
										ProductIdentifier = pbbProductIdentifier,
										FeatureType = 1
									});
									num = (short)400490497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_120:
								num = (short)235929604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AA:
								goto IL_120;
							}
							IL_1C1:
							return list;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1D4;
					}
					case 2:
						goto IL_6B;
					}
					IL_4F:
					if (pac != global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier.PBB)
					{
						num = (short)1865678850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1D4:
					num = (short)213778433;
					if (num != 0)
					{
					}
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>();
					values = global::System.Enum.GetValues(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.PBBFeatureCode));
					enumerator = global::CommonUtility.CFSUtility.GetRadioFeatureList(pbbProductIdentifier, pbbModelNumber).GetEnumerator();
					num = (short)531365889;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_6B:
				throw new global::System.NotImplementedException();
			}
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00019BEC File Offset: 0x00017DEC
		public static global::System.Collections.Generic.List<int> GetRadioFeatureList(string pbbProductIdentifier, string pbbModelNumber)
		{
			int a_ = 10;
			short num = (short)1389297664;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<int> result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)122880001;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_97;
					}
					continue;
				case 1:
					if (global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsCascadeNotInternational(pbbModelNumber))
					{
						num = (short)291241986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)669777932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					result = global::Motorola.CommonCPS.Server.CommonDBConstants.PbbDeviceFeature.CascadeFeatures;
					num = (short)993591305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (pbbModelNumber == global::CommonUtility.VersionUtility.b("漺Լ฾着瑂ф", a_))
					{
						num = (short)1081081872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1730543617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsFeatureLicensingSupportedByModel(pbbModelNumber))
					{
						num = (short)1962278918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C5;
				case 5:
					result = global::Motorola.CommonCPS.Server.CommonDBConstants.PbbDeviceFeature.CascadeInternationalFeatures;
					num = (short)1538588687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1665925128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_2C5;
				case 8:
					if (pbbModelNumber == global::CommonUtility.VersionUtility.b("猺瘼ാ煀畂瑄ن", a_))
					{
						num = (short)1730347021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_213;
				case 9:
					goto IL_2C5;
				case 10:
					IL_B1:
					pbbModelNumber = global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.GetDefaultModelNumber(pbbProductIdentifier);
					num = (short)1330184203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_12E;
				case 12:
					if (global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsCascadeInternational(pbbModelNumber))
					{
						num = (short)223739909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1774059524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					result = global::Motorola.CommonCPS.Server.CommonDBConstants.PbbDeviceFeature.FusionFeatures;
					num = (short)1706164231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_2C5;
				case 15:
					goto IL_2C5;
				case 16:
					result = global::Motorola.CommonCPS.Server.CommonDBConstants.PbbDeviceFeature.FutonFeatures;
					num = (short)1005191182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_97:
				if (pbbModelNumber == null)
				{
					num = (short)1596325898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_12E;
				IL_2C5:
				num = (short)886767616;
				short num3 = num;
				num = (short)234340858;
				short num4 = num;
				num = (short)1212006906;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B1;
				default:
					goto IL_323;
				}
				IL_12E:
				result = new global::System.Collections.Generic.List<int>();
				num = (short)520093699;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_213:
			throw new global::System.Exception(global::CommonUtility.VersionUtility.b("町刼䬾慀ᕂ⑄⭆⁈⽊浌὎⍐㱒ㅔ≖㩘⽚ᑜ㭞Ѡൢᅤ๦ཨɪ࡬ᵮ", a_));
			IL_323:
			num = (short)1110048768;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00019F48 File Offset: 0x00018148
		// Note: this type is marked as 'beforefieldinit'.
		static CFSUtility()
		{
			int a_ = 19;
			short num = (short)1053687808;
			short num2 = num;
			num = (short)1936817858;
			short num3 = num;
			num = (short)800227010;
			switch (num3 == num)
			{
			}
			num = (short)1484718081;
			if (num != 0)
			{
			}
			num = (short)234291200;
			if (num != 0)
			{
			}
			global::CommonUtility.CFSUtility.TCCFSDictionary = new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓Օŗख़͛ᵝ⽟ⱡっ㑥❧♩⁫⭭≯", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙཛݝ㍟㵡❣⥥♧㹩㹫Ⅽ㱯㹱ㅳ⑵", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓Օᅗ๙ᥛ", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙཛ᝝㑟❡", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓Օŗख़͛Ὕ⑟㑡ⵣ㕥❧㡩", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙཛݝ㍟㵡╣≥㹧⍩㽫Ⅽ≯", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓Օŗख़͛Ὕ⑟㑡ⵣ㕥❧㡩㍫⁭㉯㭱", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙཛݝ㍟㵡╣≥㹧⍩㽫Ⅽ≯⵱㩳㑵ㅷ", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓U᝗ፙὛ᭝㽟╡╣㉥ⵧ㵩⵫㝭", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙਜ਼ᅝ⥟ⅡⅣ㥥⽧⭩㡫⭭❯㍱⵳", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓U᝗ፙὛ᭝㽟㙡╣⩥⍧㩩⵫㩭㡯", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙਜ਼ᅝ⥟ⅡⅣ㥥㱧⭩⁫╭⁯㍱⁳㹵", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓ቕᥗ๙ᵛŝ❟⍡っ⍥㽧⭩㕫", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙᡛὝ㑟⍡㭣Ⅵ⥧㹩⥫㥭ㅯ⭱", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓Օୗՙཛݝ㍟㵡❣⡥㱧㡩⁫", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙཛ൝㽟ㅡ㵣㕥㝧⥩≫㩭≯㹱", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓Օୗՙ࡛ᅝ㽟⽡㝣㥥㭧㍩㽫ㅭ㍯㱱⁳⑵㑷", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙཛ൝㽟㙡⭣㥥╧㥩㍫㵭⥯ⅱ⭳㕵㙷⹹⹻㉽", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓ᑕ੗ፙᡛᥝ╟㵡⁣⽥㭧⭩⹫≭㕯㙱", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙṛౝ⥟♡⍣⍥㝧⹩╫㵭ㅯぱ㡳㍵㱷", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓ᑕ੗ፙᡛᥝ╟㵡Ⅳ⡥⥧⡩⁫⭭㑯", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙṛౝ⥟♡⍣⍥㝧⽩≫⽭㉯㹱ㅳ㉵", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓ቕὗᑙᵛ", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙᡛᥝ⹟⍡", a_)
				},
				{
					global::CommonUtility.VersionUtility.b("݃Eᭇᕉࡋ͍ɏ慑୓Օᕗ᭙", a_),
					global::CommonUtility.VersionUtility.b("̓੅݇ࡉോɍཏᙑᥓѕ歗ՙཛ፝⅟", a_)
				}
			};
		}

		// Token: 0x04000075 RID: 117
		public static readonly global::System.Collections.Generic.Dictionary<string, string> TCCFSDictionary;

		// Token: 0x02000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000FC RID: 252 RVA: 0x0001A1D0 File Offset: 0x000183D0
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem A_0)
			{
				short num = (short)339673088;
				short num2 = num;
				num = (short)1637800009;
				short num3 = num;
				num = (short)1327487049;
				switch (num3 == num)
				{
				}
				num = (short)270073857;
				if (num != 0)
				{
				}
				num = (short)1357840384;
				if (num != 0)
				{
				}
				return A_0.OptionID.OptionInt == (int)this.a;
			}

			// Token: 0x04000076 RID: 118
			public global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode a;
		}
	}
}
