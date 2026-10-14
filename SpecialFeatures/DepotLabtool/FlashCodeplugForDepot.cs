using System;
using System.Collections.Generic;
using AcpCommonLib;
using Motorola.Acp.PackUnpack.Ish.Layouts;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.Model_Configuration;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x0200013F RID: 319
	public class FlashCodeplugForDepot
	{
		// Token: 0x0600108B RID: 4235 RVA: 0x00171578 File Offset: 0x0016F778
		public bool UpgradeCodeplugForDepot(string modelNumber, string flashcode, string serialNumber, bool IsModelNumberUpgrade)
		{
			int a_ = 10;
			short num = (short)1739522048;
			switch (num)
			{
			default:
			{
				num = (short)103546890;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)100663296;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_BE4;
					case 1:
					{
						byte[] array;
						if (array.Length != 24)
						{
							num = (short)762380297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
						num = (short)219611143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_BD;
					case 3:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)807337989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2;
					}
					case 4:
						goto IL_168;
					case 5:
						num = (short)784334849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
						if (!modelTiering.FindModel(modelNumber))
						{
							num = (short)1367015424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = false;
						string str = "";
						byte[] array = new byte[0];
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(flashcode, ref array);
						num = (short)2051407875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_B25;
					case 8:
					{
						if (!global::SpecialFeatures.Flashport.FlashRadio.FlashcodeValidator.Validate(flashcode))
						{
							num = (short)1944518660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(modelNumber, global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.DEPOT, global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.NONE, false);
						num = (short)1161756678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_B96;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					IL_A1:
					if (IsModelNumberUpgrade)
					{
						num = (short)1917976578;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1110048776;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_BD:
				goto IL_AF1;
				IL_C2:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(flashcode + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("권뎒練릘삠쾢첤쎦覨춪솬캮슰\udbb2횴\ud8b6\uddb8\udeba鎼", a_));
				IL_168:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(flashcode + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("권뎒練릘삠쾢첤쎦覨춪솬캮슰\udbb2횴\ud8b6\uddb8\udeba鎼", a_));
				IL_AF1:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삌璉랖ﶞ쒠톢薤튦\ud9a8첪\udfac캮햰횲운鞶\ud8b8즺\ud8bc龾꿀곂뇄뫈뻊뷌뿎뻐ꇒꇔ닖뷘ﯚ드뇞쇠韢跤軦髨쯪鿬諮鷰雲铴蓶鳸헺", a_));
				IL_B25:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_1F2;
					}
					global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
					string str;
					int num4;
					global::System.Collections.Generic.IDictionary<global::SpecialFeatures.Flashport.FlashRadio.Option, int> dictionary;
					for (;;)
					{
						IL_177:
						int num5;
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::SpecialFeatures.Flashport.FlashRadio.Option, int>> enumerator2;
						switch (num2)
						{
						case 0:
							num = (short)703070226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							bool flag;
							if (flag)
							{
								num = (short)1564213254;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array;
							int value = (int)array[num4];
							num5 = 0;
							num = (short)1565589518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_757;
						case 3:
							if (num4 < 24)
							{
								num = (short)331415573;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3F4;
						case 4:
							goto IL_3B8;
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
							radioInformation.General.RadInfoGeneralModelNumber_A8539.SetValue(modelNumber);
							radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132.SetValue(flashcode);
							radioInformation.General.RadInfoGeneralSerialNumber_A9122.SetValue(serialNumber);
							bool flag2 = false;
							bool flag3 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c몎ꊐ", a_), flashcode, ref flag2);
							num = (short)948961288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_3F4;
						case 7:
							num = (short)1228144663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							bool flag2;
							bool flag3;
							if (flag2 && flag3)
							{
								num = (short)644546571;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_719;
						}
						case 9:
							goto IL_A7F;
						case 10:
						{
							global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
							if (optionsByPosition != null)
							{
								num = (short)1764163611;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_287;
						}
						case 11:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
							radioInformation.Labtool.RadInfoLabtoolFPPNonFEDVersion_A8143.SetValue(true);
							num = (short)958660630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							try
							{
								num = (short)1219821579;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										int num6;
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										if (num6 == option.BitsValue)
										{
											num = (short)773980162;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5FD;
									}
									case 1:
										goto IL_656;
									case 2:
									{
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										str = option.ToString();
										bool flag = true;
										num = (short)1338245126;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)267845636;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
										global::AcpCommonLib.IAcpField dbField = option.DbField;
										int fieldValue = flashcodeTable.GetFieldValue(dbField);
										int value;
										int num6 = option.Mask.Apply(value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack);
										num = (short)613679109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										num = (short)1916600321;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										if (!modelTiering.IsOptionAvailableForModel(modelNumber, option.Name))
										{
											num = (short)607059977;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5FD;
									}
									case 6:
										goto IL_5F8;
									case 7:
									{
										int num6;
										global::SpecialFeatures.Flashport.FlashRadio.Option option;
										dictionary.Add(option, num6);
										num = (short)391577608;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										num = (short)861470720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										int num6;
										int fieldValue;
										if (fieldValue != num6)
										{
											num = (short)117047303;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 11:
										switch (0)
										{
										case 0:
											goto IL_4C2;
										}
										continue;
									}
									IL_4C4:
									num = (short)1548943363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_4C2:
									goto IL_4C4;
									IL_5FD:
									num = (short)1080885258;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_5F8:
								IL_656:
								goto IL_287;
							}
							finally
							{
								num = (short)1377959937;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_6F3;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_68D;
										}
										continue;
									case 2:
										goto IL_716;
									}
									IL_68D:
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
									if (enumerator == null)
									{
										break;
									}
									num = (short)185107466;
									short num7 = num;
									num = (short)127894538;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1524760576;
										if (num != 0)
										{
										}
										num = (short)232128512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_6F3:
									enumerator.Dispose();
									num = (short)1346699266;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_716:;
							}
							goto IL_719;
						case 13:
							goto IL_2A7;
						case 14:
							goto IL_2A7;
						case 15:
						{
							try
							{
								num = (short)1287454721;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										switch (0)
										{
										case 0:
											goto IL_8E1;
										}
										continue;
									case 2:
										num = (short)1538850820;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)1236664322;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<global::SpecialFeatures.Flashport.FlashRadio.Option, int> keyValuePair = enumerator2.Current;
										flashcodeTable.SetFieldValue(keyValuePair.Key.DbField, keyValuePair.Value);
										num = (short)522715136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_96E;
									}
									IL_8E3:
									num = (short)1348403203;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_8E1:
									goto IL_8E3;
								}
								IL_96E:
								goto IL_7F0;
							}
							finally
							{
								num = (short)1700790273;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)2067922946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_9A6;
										}
										continue;
									case 2:
										goto IL_9DF;
									}
									IL_9A6:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)927268864;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_9DF:;
							}
							goto IL_9E2;
							IL_7F0:
							dictionary.Clear();
							dictionary = null;
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
							num = (short)36044825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							goto IL_A66;
						case 17:
							if (num5 < 8)
							{
								num = (short)1978859527;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_757;
						case 18:
						{
							bool flag3;
							if (!flag3)
							{
								num = (short)1668284436;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A66;
						}
						case 19:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)2111111168;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A66;
						}
						case 20:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
							radioInformation.Labtool.RadInfoLabtoolFPPNonFEDVersion_A8143.SetValue(false);
							num = (short)176357392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
							num = (short)1360527361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							goto IL_A61;
						case 23:
						{
							bool flag;
							if (flag)
							{
								num = (short)242155522;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int position = num4 * 8 + num5 + 1;
							global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition = flashcodeTable.FLASHcode.GetOptionsByPosition(position);
							num = (short)576782346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
							goto IL_42B;
						case 25:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
							if (radioInformation != null)
							{
								num = (short)585433093;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A66;
						}
						case 26:
						{
							bool flag;
							if (flag)
							{
								num = (short)1254227992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9E2;
						}
						case 27:
						{
							global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
							global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = optionsByPosition.GetEnumerator();
							num = (short)96993292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
							goto IL_3B8;
						}
						goto IL_1F2;
						IL_287:
						num5++;
						num = (short)1957953549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A7:
						num = (short)1615331345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B8:
						num = (short)1854734339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3F4:
						num = (short)436666394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_719:
						num = (short)850395155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_757:
						num = (short)872677377;
						if (num != 0)
						{
						}
						num4++;
						num = (short)918093828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9E2:
						enumerator2 = dictionary.GetEnumerator();
						num = (short)1588330511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A66:
						num = (short)529399817;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_42B:
					throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슌ﾎ朗杖練릘", a_) + str + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("권뎒ﮔ뮚ﲜ뾞힠슢즤캦춨讪슬\udfae얰\udab2\udab4\ud9b6馸\uddba튼춾껂꫄ꏆ곈ꟊ", a_) + modelNumber);
					IL_A61:
					IL_A7F:
					return true;
					IL_1F2:
					flashcodeTable.InitTable(true, modelNumber, false);
					dictionary = new global::System.Collections.Generic.Dictionary<global::SpecialFeatures.Flashport.FlashRadio.Option, int>();
					num4 = 0;
					num = (short)559022108;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_177;
				}
				finally
				{
					num = (short)127074305;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)flashcodeTable).Dispose();
							num = (short)700841986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_AB6;
							}
							continue;
						case 2:
							goto IL_AEE;
						}
						IL_AB6:
						if (flashcodeTable == null)
						{
							break;
						}
						num = (short)230490112;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_AEE:;
				}
				goto IL_AF1;
				IL_B96:
				goto IL_C2;
				IL_BE4:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(modelNumber + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("권뎒ﮔ뮚ﮜ풠춢솤螦삨얪趬\udeb0ힲ킴\udbb6馸풼\udabe돀ꫂꯄꃆ꿊곌믎냐뇒듔ꓖ볘", a_));
			}
			}
		}
	}
}
