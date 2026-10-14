using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.Acp.PackUnpack.Ish.Layouts;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.ToneSignalingList;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x02000068 RID: 104
	public static class FeatureSetConstraints
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x00094C3C File Offset: 0x00092E3C
		public static string getUsedFcodeValue()
		{
			short num = (short)316276736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				byte[] array;
				byte[] array2;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_27:
					global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
					switch (num2)
					{
					case 0:
						goto IL_654;
					case 1:
						num = (short)175833091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_114;
							}
							int num7;
							for (;;)
							{
								IL_DD:
								int num6;
								switch (num2)
								{
								case 0:
									goto IL_149;
								case 1:
									try
									{
										num = (short)1300299783;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
											{
												global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1958674435;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
												global::AcpCommonLib.IAcpField dbField = option.DbField;
												num = (short)375062532;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												num = (short)546373637;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												num = (short)1267531786;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::SpecialFeatures.Flashport.FlashRadio.Option option;
												int value;
												if (option.Mask.Apply(value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack) == option.BitsValue)
												{
													num = (short)1576861704;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
											{
												global::SpecialFeatures.Flashport.FlashRadio.Option option;
												if (option.IsOptionUsed())
												{
													num = (short)322240518;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
											{
												global::SpecialFeatures.Flashport.FlashRadio.Option option;
												int num3 = option.Mask.Apply(option.BitsValue, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Pack);
												int num4;
												num4 |= num3;
												num = (short)1620246528;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
												switch (0)
												{
												case 0:
													goto IL_308;
												}
												continue;
											case 8:
												num = (short)1453195273;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
											{
												global::SpecialFeatures.Flashport.FlashRadio.Option option;
												if (option.IsOptionUsed != null)
												{
													num = (short)1343553538;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 10:
												goto IL_478;
											}
											IL_3A2:
											num = (short)1454309377;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_308:
											goto IL_3A2;
										}
										IL_478:
										goto IL_246;
									}
									finally
									{
										num = (short)2052980737;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
											switch (num2)
											{
											case 0:
											{
												num = (short)1933280789;
												short num5 = num;
												num = (short)1461749269;
												switch ((num5 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_4B7;
												default:
													num = (short)837091328;
													if (num != 0)
													{
													}
													enumerator.Dispose();
													num = (short)773193730;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
												switch (0)
												{
												case 0:
													goto IL_4B0;
												}
												continue;
											case 2:
												goto IL_53A;
											}
											goto IL_4B0;
											IL_4B7:
											num = (short)257753088;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4B0:
											if (enumerator != null)
											{
												goto IL_4B7;
											}
											break;
										}
										IL_53A:;
									}
									goto IL_53D;
								case 2:
								{
									global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
									if (optionsByPosition != null)
									{
										num = (short)1473511427;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_246;
								}
								case 3:
								{
									global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = optionsByPosition.GetEnumerator();
									num = (short)1068302337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_187;
								case 5:
								{
									if (num6 >= 8)
									{
										num = (short)629735430;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int position = num7 * 8 + num6 + 1;
									global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition = flashcodeTable.FLASHcode.GetOptionsByPosition(position);
									num = (short)1647312898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									int num4;
									array[num7] = (byte)num4;
									num7++;
									num = (short)943063044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_53D;
								case 8:
									goto IL_187;
								case 9:
									goto IL_556;
								case 10:
								{
									if (num7 >= 24)
									{
										num = (short)1782972423;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num4 = 0;
									int value = (int)array2[num7];
									num6 = 0;
									num = (short)1519321099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_149;
								}
								goto IL_114;
								IL_149:
								num = (short)1156448261;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_187:
								num = (short)1960443914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_246:
								num6++;
								num = (short)448462848;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_53D:
								num = (short)1264517129;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_556:
							goto IL_65C;
							IL_114:
							flashcodeTable.InitTable(true, radioInformation.General.RadInfoGeneralModelNumber_A8539.Value, false);
							num7 = 0;
							num = (short)1947140104;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_DD;
						}
						finally
						{
							num = (short)1233518593;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)flashcodeTable).Dispose();
									num = (short)255459330;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_58D;
									}
									continue;
								case 2:
									goto IL_5C4;
								}
								IL_58D:
								if (flashcodeTable == null)
								{
									break;
								}
								num = (short)660799488;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5C4:;
						}
						goto IL_5C7;
					case 3:
						num = (short)1763966977;
						if (num != 0)
						{
						}
						if (array2.Length != 24)
						{
							num = (short)2013396992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C7;
					case 4:
						if (array2 != null)
						{
							num = (short)424804352;
							short num8 = num;
							num = (short)610926593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_656;
					}
					goto IL_42;
					IL_5C7:
					array = new byte[24];
					flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
					num = (short)1989541890;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_654:
				IL_656:
				return "";
				IL_65C:
				return global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(array, array.Length);
				IL_42:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				string radInfoFLASHportFLASHcode_A8132Value = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
				array2 = new byte[0];
				global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(radInfoFLASHportFLASHcode_A8132Value, ref array2);
				num = (short)808386564;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000952E4 File Offset: 0x000934E4
		internal static bool IsOtapUsedInCpg()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			bool flag;
			short num2;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num2 = (short)1839005697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FC;
				case 1:
					goto IL_3D9;
				case 2:
					try
					{
						num2 = (short)526254083;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)2063204358;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_28E;
							case 2:
								if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current).Features.TrkSysLabtoolEnable_A8669Value)
								{
									num2 = (short)221006066;
									short num3 = num2;
									num2 = (short)1614891250;
									switch ((num3 == num2) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_28E;
									default:
										num2 = (short)1450246145;
										if (num2 != 0)
										{
										}
										num2 = (short)927465472;
										if (num2 != 0)
										{
										}
										num2 = (short)1766785028;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
								}
								break;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_23D;
								}
								continue;
							case 4:
								flag = true;
								num2 = (short)150208513;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								if (!enumerator.MoveNext())
								{
									num2 = (short)883359744;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)1834352642;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
								goto IL_36A;
							}
							IL_23F:
							num2 = (short)256442373;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_23D:
							goto IL_23F;
						}
						IL_28E:
						IL_36A:
						goto IL_1B0;
					}
					finally
					{
						num2 = (short)114556929;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)955711490;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3A1;
								}
								continue;
							case 2:
								goto IL_3D6;
							}
							IL_3A1:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1660616704;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_3D6:;
					}
					goto IL_3D9;
				case 3:
					try
					{
						num2 = (short)885129219;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)496828422;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_DE;
							case 2:
								if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current).Features.CnvSysDVRSPOP25Enable_A40126Value)
								{
									num2 = (short)1365245956;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_93;
								}
								continue;
							case 4:
								flag = true;
								num2 = (short)1561591809;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								if (!enumerator.MoveNext())
								{
									num2 = (short)433979392;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)41156610;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
								goto IL_142;
							}
							IL_95:
							num2 = (short)1041760261;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_93:
							goto IL_95;
						}
						IL_DE:
						IL_142:
						goto IL_3FC;
					}
					finally
					{
						num2 = (short)88408065;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1939406850;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_178;
								}
								continue;
							case 2:
								goto IL_1AD;
							}
							IL_178:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)437911552;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1AD:;
					}
					goto IL_1B0;
				}
				goto IL_20;
				IL_1B0:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset;
				num2 = (short)1291845632;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3D9:
				enumerator = conventionalSystemRecset.GetEnumerator();
				num2 = (short)22151171;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_3FC:
			num2 = (short)35061760;
			short num4 = num2;
			return flag;
			IL_20:
			flag = false;
			enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
			num2 = (short)160432130;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0009574C File Offset: 0x0009394C
		internal static bool IsDigitalIMBEUsedInCpg()
		{
			short num = (short)1599406080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				bool flag;
				for (;;)
				{
					IL_27:
					bool flag2;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (!radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185Value)
						{
							num = (short)779681794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1674838023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset).GetEnumerator();
						num = (short)169279491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)32112648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)2073231369;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.Value == 2)
									{
										num = (short)1605369858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_467;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (trunkingPersonality.Talkgroup.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset).GetEnumerator();
									num = (short)975437835;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_286;
								case 4:
									num = (short)1323499530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									flag = true;
									num = (short)193134595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1898119172;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current;
									num = (short)377487368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									if (flag)
									{
										num = (short)600637452;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.Value == 7)
									{
										num = (short)1141702661;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1401683968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_158;
									}
									continue;
								case 10:
									goto IL_4C1;
								case 11:
									try
									{
										num = (short)2125463555;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)275578881;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1955004418;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												goto IL_324;
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner)enumerator2.Current).TalkgroupInnerSection.TrkPerTalkgroupTxVoiceSignalType_A9575Value == 1)
												{
													num = (short)152151026;
													short num3 = num;
													num = (short)1670423538;
													switch ((num3 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_324;
													default:
														num = (short)1300168704;
														if (num != 0)
														{
														}
														num = (short)1807941636;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
												}
												break;
											}
											case 3:
												switch (0)
												{
												case 0:
													goto IL_2CE;
												}
												continue;
											case 4:
												flag = true;
												num = (short)1511063557;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												goto IL_2E8;
											case 6:
												goto IL_3DC;
											}
											IL_2ED:
											num = (short)1528889344;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2CE:
											goto IL_2ED;
											IL_324:
											num = (short)354418694;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2E8:
										IL_3DC:
										goto IL_46C;
									}
									finally
									{
										num = (short)222429185;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1496711170;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_414;
												}
												continue;
											case 2:
												goto IL_44B;
											}
											IL_414:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)136249344;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_44B:;
									}
									goto IL_44E;
									IL_46C:
									num = (short)990314503;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_44E;
								}
								IL_15D:
								num = (short)1610153990;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_158:
								goto IL_15D;
								IL_44E:
								num = (short)10420225;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_286:
							IL_467:
							IL_4C1:
							return flag;
						}
						finally
						{
							num = (short)403111937;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)992280578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4F8;
									}
									continue;
								case 2:
									goto IL_52E;
								}
								IL_4F8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1364066304;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_52E:;
						}
						goto Block_2;
					case 4:
						if (!flag)
						{
							num = (short)195821574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 5:
					{
						num = (short)885522432;
						short num4 = num;
						goto IL_531;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)1988034560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						flag2 = true;
						goto IL_6A7;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						flag2 = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184Value;
						goto IL_6A7;
					}
					}
					goto IL_52;
					IL_6A7:
					if (flag2)
					{
						num = (short)1582432257;
						if (num != 0)
						{
						}
						num = (short)1038483457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					Block_2:
					try
					{
						IL_531:
						num = (short)571539459;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								flag = true;
								num = (short)581304324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)1714290690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)23003141;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1405681670;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_575;
								}
								continue;
							case 4:
								goto IL_619;
							case 5:
								if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current).RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
								{
									num = (short)1257963520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 6:
								goto IL_636;
							}
							IL_5C2:
							num = (short)445775873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_575:
							goto IL_5C2;
						}
						IL_619:
						IL_636:
						goto IL_748;
					}
					finally
					{
						num = (short)66125825;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)651558914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_66D;
								}
								continue;
							case 2:
								goto IL_6A4;
							}
							IL_66D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)907476992;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_6A4:;
					}
					goto IL_6A7;
					IL_748:
					num = (short)541655044;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_52:
				flag = false;
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
				num = (short)1949499397;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00095F54 File Offset: 0x00094154
		internal static bool IsOtarMkeyUsedInCpg()
		{
			short num = (short)1582170113;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					goto IL_13C;
				case 1:
					num = (short)1920794624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1276257008;
					short num3 = num;
					num = (short)1043342064;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13C;
					default:
						goto IL_1A0;
					}
					break;
				}
				case 3:
				{
					num = (short)568983552;
					short num4 = num;
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 1)
					{
						num = (short)637468673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 4:
					if (secureWide.General.SecWideGeneralOTAREnable_A7966Value)
					{
						num = (short)1352204293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					num = (short)1065222147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4F;
				IL_13C:
				if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 3)
				{
					break;
				}
				num = (short)1531314178;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_1A0:
			num = (short)75759616;
			if (num != 0)
			{
			}
			return secureWide.General.SecureWideAESAlgorithmEnable_43201.Value;
			IL_4F:
			secureWide = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
			num = (short)294846468;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0009611C File Offset: 0x0009431C
		internal static bool IsSmartConnectUsedInCpg()
		{
			short num = (short)1108082689;
			if (num != 0)
			{
			}
			num = (short)740098048;
			short num2 = num;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset).GetEnumerator();
			try
			{
				num = (short)1961164805;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (!enumerator.MoveNext())
						{
							num = (short)1567293442;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1085341702;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_193;
					case 2:
						num = (short)42008579;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1B0;
					case 4:
						result = true;
						num = (short)1188364289;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_7F;
					case 6:
					{
						num = (short)6259074;
						short num4 = num;
						num = (short)74023298;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7F;
						default:
							num = (short)440270848;
							if (num != 0)
							{
							}
							if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current).Features.TrkPerFeatureBackupPTTOperation_A43628Value != 0)
							{
								num = (short)1036582916;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						break;
					}
					}
					goto IL_AB;
					IL_7F:
					switch (0)
					{
					case 0:
						IL_AB:
						goto IL_13E;
					}
					continue;
					IL_13E:
					num = (short)369033216;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_193:
				IL_1B0:;
			}
			finally
			{
				num = (short)2096103426;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1751187457;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_216;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1E3;
						}
						continue;
					}
					IL_1E3:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1059848192;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_216:;
			}
			return result;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00096360 File Offset: 0x00094560
		internal static bool IsMultikeyUsedInCpg()
		{
			short num = (short)1417935418;
			short num2 = num;
			num = (short)1135606330;
			switch (num2 == num)
			{
			}
			num = (short)390791168;
			short num3 = num;
			num = (short)410583040;
			if (num != 0)
			{
			}
			num = (short)956497921;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide).General.SecWideGeneralSecureOperation_A9067.Value != 0;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00096434 File Offset: 0x00094634
		internal static bool IsFedFPPUsedInCpg()
		{
			short num = (short)1909934580;
			short num2 = num;
			num = (short)1822771700;
			switch (num2 == num)
			{
			}
			num = (short)13565952;
			short num3 = num;
			num = (short)275841025;
			if (num != 0)
			{
			}
			num = (short)293273600;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Features.ZnChanCfgFPPProtectionFPPEnable_A8142Value;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000964FC File Offset: 0x000946FC
		internal static bool IsSmartzoneUsedInCpg()
		{
			short num = (short)1132804152;
			short num2 = num;
			num = (short)1260861496;
			switch (num2 == num)
			{
			}
			num = (short)564920320;
			short num3 = num;
			num = (short)246480897;
			if (num != 0)
			{
			}
			num = (short)1317601280;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000965A8 File Offset: 0x000947A8
		internal static bool IsSmartnetUsedInCpg()
		{
			short num = (short)754629781;
			short num2 = num;
			num = (short)781368469;
			switch (num2 == num)
			{
			}
			num = (short)1514209280;
			short num3 = num;
			num = (short)95617025;
			if (num != 0)
			{
			}
			num = (short)756088832;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00096650 File Offset: 0x00094850
		internal static bool IsGPSActivationUsedInCpg()
		{
			short num = (short)488159450;
			short num2 = num;
			num = (short)2011674842;
			switch (num2 == num)
			{
			}
			num = (short)879558656;
			short num3 = num;
			num = (short)1217331201;
			if (num != 0)
			{
			}
			num = (short)2122186752;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Location.RadWideLocationLocationEnable_A8448Value;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00096718 File Offset: 0x00094918
		internal static bool IsGeofenceActivationUsedInCpg()
		{
			short num = (short)1238237184;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
				bool flag = false;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
				try
				{
					num = (short)984154120;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1430503913;
							short num3 = num;
							num = (short)469287401;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_9E;
							default:
								num = (short)1871904768;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 1:
							goto IL_9E;
						case 2:
							goto IL_217;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
							{
								num = (short)211025921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_196;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (trunkingSystem.ASTRO26.TrkSysASTRO25GeoFenceMode_42322.Value == 0)
							{
								num = (short)841613321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = true;
							num = (short)469499909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_191;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)892469255;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
							num = (short)217907203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)494534658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_9C;
							}
							continue;
						case 9:
							goto IL_196;
						}
						goto IL_9C;
						IL_9E:
						num = (short)926613508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_E4:
						num = (short)2034565126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9C:
						goto IL_E4;
						IL_196:
						flag = false;
						num = (short)862388224;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_191:
					IL_217:;
				}
				finally
				{
					num = (short)1301020674;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)358612993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_280;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_24B;
							}
							continue;
						}
						IL_24B:
						if (enumerator == null)
						{
							break;
						}
						num = (short)143458304;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_280:;
				}
				num = (short)1159135232;
				short num4 = num;
				num = (short)205914113;
				if (num != 0)
				{
				}
				return radioWide.Location.RadWideLocationLocationEnable_A8448Value && flag;
			}
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00096A24 File Offset: 0x00094C24
		internal static bool IsDataUsedInCpg()
		{
			short num = (short)849608704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					IL_28:
					bool flag2;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)1804468226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)517996549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (!radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185Value)
						{
							num = (short)1869611009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)967704584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						try
						{
							num = (short)1502806023;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_23C;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
									{
										num = (short)1811087364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									flag = true;
									num = (short)2077949952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)244318216;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
									num = (short)198180865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1586692102;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_259;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.Value != 0)
									{
										num = (short)663748610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_148;
									}
									continue;
								case 8:
									num = (short)1690894341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_14A:
								num = (short)1829502979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_148:
								goto IL_14A;
							}
							IL_23C:
							IL_259:
							return flag;
						}
						finally
						{
							num = (short)888406018;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2AE;
								case 1:
								{
									num = (short)1566173081;
									short num3 = num;
									num = (short)1691871129;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2AE;
									default:
										goto IL_301;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_290;
									}
									continue;
								}
								IL_290:
								if (enumerator != null)
								{
									num = (short)1846149120;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_319;
								IL_2AE:
								enumerator.Dispose();
								num = (short)580190209;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_301:
							num = (short)59768832;
							if (num != 0)
							{
							}
							IL_319:;
						}
						goto Block_2;
					case 4:
						if (!flag)
						{
							num = (short)2095054848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						flag2 = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184Value;
						goto IL_4EF;
					}
					case 6:
						num = (short)1653604353;
						if (num != 0)
						{
						}
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
						num = (short)1452146691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_31A;
					case 8:
						flag2 = true;
						goto IL_4EF;
					}
					goto IL_53;
					IL_4EF:
					if (flag2)
					{
						num = (short)680984582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					Block_2:
					try
					{
						IL_31A:
						num = (short)64225287;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_460;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1391067140;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current;
								conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.CalculateApplicability();
								num = (short)1870790659;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								flag = true;
								num = (short)1050476544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
								if (conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266_Applicable)
								{
									num = (short)334626824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								num = (short)849805317;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_47E;
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
								if (conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.Value != 0)
								{
									num = (short)1672347650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								switch (0)
								{
								case 0:
									goto IL_366;
								}
								continue;
							case 8:
								num = (short)692060166;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_408:
							num = (short)1675362305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_366:
							goto IL_408;
						}
						IL_460:
						IL_47E:
						goto IL_593;
					}
					finally
					{
						num = (short)1034485762;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1592524801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_4EC;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_4B6;
								}
								continue;
							}
							IL_4B6:
							if (enumerator == null)
							{
								break;
							}
							num = (short)608894976;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4EC:;
					}
					goto IL_4EF;
					IL_593:
					num = (short)401014788;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_53:
				flag = false;
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).GetEnumerator();
				num = (short)946733056;
				short num4 = num;
				num = (short)913702919;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00097060 File Offset: 0x00095260
		internal static bool IsSiteSelAlertInCpg()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					goto IL_278;
				case 1:
				{
					num2 = (short)1947074560;
					short num3 = num2;
					try
					{
						num2 = (short)1041825799;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)217207169;
								short num4 = num2;
								num2 = (short)2118340993;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num2 = (short)471007232;
									if (num2 != 0)
									{
									}
									result = true;
									num2 = (short)101056513;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 1:
								goto IL_15B;
							case 2:
								num2 = (short)2048851972;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)1900740616;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
								num2 = (short)1746927622;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								if (trunkingSystem.Features.SiteSelectableAlertList_A42060.ReferencedNode != null)
								{
									num2 = (short)1753219072;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 5:
								goto IL_20B;
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
								{
									num2 = (short)1495465986;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 7:
								switch (0)
								{
								case 0:
									goto IL_BA;
								}
								continue;
							case 8:
								num2 = (short)149291013;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_BC:
							num2 = (short)137297923;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_BA:
							goto IL_BC;
						}
						IL_15B:
						IL_20B:
						return result;
					}
					finally
					{
						num2 = (short)278134786;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)488046593;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_275;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_241;
								}
								continue;
							}
							IL_241:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1742405632;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_275:;
					}
					goto IL_278;
				}
				case 2:
					if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolH38G51Smartzone_A8185Value)
					{
						num2 = (short)1648164864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_1C;
				IL_278:
				num2 = (short)1059127297;
				if (num2 != 0)
				{
				}
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
				num2 = (short)74514433;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			result = false;
			num2 = (short)1103101954;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00097388 File Offset: 0x00095588
		internal static bool IsLTEUsedInCpg()
		{
			short num = (short)1454702593;
			if (num != 0)
			{
			}
			num = (short)1251344384;
			short num2 = num;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
			try
			{
				num = (short)337903621;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (!enumerator.MoveNext())
						{
							num = (short)1364787202;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)401866758;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_198;
					case 2:
						num = (short)1786970115;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1B5;
					case 4:
						result = true;
						num = (short)1486684161;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_7D;
					case 6:
					{
						num = (short)319991939;
						short num4 = num;
						num = (short)761180291;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							num = (short)1618673664;
							if (num != 0)
							{
							}
							if (((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current).LTE.DataProfBroadbandSource_A42858.Value == 1)
							{
								num = (short)251002884;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						break;
					}
					}
					goto IL_A9;
					IL_7D:
					switch (0)
					{
					case 0:
						IL_A9:
						goto IL_143;
					}
					continue;
					IL_143:
					num = (short)855834624;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_198:
				IL_1B5:;
			}
			finally
			{
				num = (short)857997314;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)499908609;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_21D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1E9;
						}
						continue;
					}
					IL_1E9:
					if (enumerator == null)
					{
						break;
					}
					num = (short)894500864;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_21D:;
			}
			return result;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000975D4 File Offset: 0x000957D4
		internal static bool IsEnVPNGatewayUsedInCpg()
		{
			bool flag = false;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
			short num;
			try
			{
				num = (short)2097414150;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (enumerator.MoveNext())
						{
							num = (short)1833041922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)162511376;
						short num3 = num;
						num = (short)498514448;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13F;
						default:
							num = (short)1403650048;
							if (num != 0)
							{
							}
							num = (short)1631322116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_178;
					case 2:
						if (((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current).NetworkLayerSecurity.DataProfVPNSecClrStrp_A42120.Value == 1)
						{
							num = (short)1792999429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 3:
						goto IL_15B;
					case 4:
						goto IL_13F;
					case 5:
						flag = true;
						num = (short)792199171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					}
					IL_BE:
					num = (short)1036451840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_71:
					goto IL_BE;
					IL_13F:
					num = (short)1134231553;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_15B:
				IL_178:;
			}
			finally
			{
				num = (short)328990722;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)200671233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1DF;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1AC;
						}
						continue;
					}
					IL_1AC:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1208483840;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DF:;
			}
			num = (short)1017643008;
			short num4 = num;
			num = (short)1670119425;
			if (num != 0)
			{
			}
			return secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1 && flag;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00097844 File Offset: 0x00095A44
		internal static bool IsOmnilinkUsedInCpg()
		{
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
			short num;
			try
			{
				num = (short)1195245572;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_159;
					case 1:
						goto IL_13F;
					case 2:
						goto IL_6B;
					case 3:
						goto IL_20C;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					case 5:
					{
						num = (short)296742034;
						short num3 = num;
						num = (short)1781001362;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6B;
						default:
							num = (short)1490812928;
							if (num != 0)
							{
							}
							num = (short)40828936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1558642697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
						num = (short)320012295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value != 7)
						{
							num = (short)631111682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value == 6)
						{
							num = (short)538705921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						num = (short)393871363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value != 5)
						{
							num = (short)532086789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					}
					}
					goto IL_69;
					IL_6B:
					num = (short)2053505034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1:
					num = (short)542900230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69:
					goto IL_B1;
					IL_13F:
					result = true;
					num = (short)977731584;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_159:
				IL_20C:;
			}
			finally
			{
				num = (short)1266221058;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)396623873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_29E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_243;
						}
						continue;
					}
					IL_243:
					if (enumerator == null)
					{
						break;
					}
					num = (short)719192065;
					if (num != 0)
					{
					}
					num = (short)693698560;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_29E:;
			}
			num = (short)1700462592;
			short num4 = num;
			return result;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00097B38 File Offset: 0x00095D38
		internal static bool IsVotingScanUsedInCpg()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			bool flag;
			short num2;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return flag;
				case 1:
					if (flag)
					{
						num2 = (short)241106944;
						short num3 = num2;
						num2 = (short)724893696;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
					num2 = (short)269942786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_1E6;
				case 3:
					try
					{
						num2 = (short)640679942;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								flag = true;
								num2 = (short)1396113410;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_17A;
							case 2:
								goto IL_D9;
							case 3:
								num2 = (short)439615489;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num2 = (short)467206147;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)1873477637;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								if (((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator.Current).General.ScanLstGeneralScanType_A9058.Value == 4)
								{
									num2 = (short)331874304;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_C0;
								}
								continue;
							}
							IL_12A:
							num2 = (short)1386610692;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_C0:
							goto IL_12A;
						}
						IL_D9:
						IL_17A:
						goto IL_39B;
					}
					finally
					{
						num2 = (short)2133458946;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1329135617;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_1E3;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1AF;
								}
								continue;
							}
							IL_1AF:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1455161344;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1E3:;
					}
					goto Block_2;
				}
				goto IL_20;
				IL_39B:
				num2 = (short)1883701249;
				num = (int)((global::System.IntPtr)num2);
				continue;
				Block_2:
				try
				{
					IL_1E6:
					num2 = (short)1468530694;
					num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current).Features.CnvPerFeaturesMixedVoteScanEnable_A38723.Value)
							{
								num2 = (short)646578180;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						case 1:
							goto IL_2DC;
						case 2:
							if (!enumerator.MoveNext())
							{
								num2 = (short)1343946757;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1905655808;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							goto IL_2BE;
						case 4:
							flag = true;
							num2 = (short)913768451;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 5:
							num2 = (short)991232001;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_226;
							}
							continue;
						}
						IL_228:
						num2 = (short)2103508994;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_226:
						goto IL_228;
					}
					IL_2BE:
					IL_2DC:
					goto IL_3FE;
				}
				finally
				{
					num2 = (short)525402114;
					num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							for (;;)
							{
								num2 = (short)1656689613;
								short num4 = num2;
								num2 = (short)805508045;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_363;
								}
							}
							IL_363:
							num2 = (short)34865152;
							if (num2 != 0)
							{
							}
							enumerator.Dispose();
							num2 = (short)1980825601;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_398;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_312;
							}
							continue;
						}
						IL_312:
						if (enumerator == null)
						{
							break;
						}
						num2 = (short)82575360;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_398:;
				}
				goto IL_39B;
			}
			return flag;
			IL_3FE:
			num2 = (short)1708064769;
			if (num2 != 0)
			{
			}
			return flag;
			IL_20:
			flag = false;
			enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset).GetEnumerator();
			num2 = (short)488701955;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00097FA0 File Offset: 0x000961A0
		internal static bool IsNonFedFPPUsedInCpg()
		{
			short num = (short)1029717286;
			short num2 = num;
			num = (short)2078555430;
			switch (num2 == num)
			{
			}
			num = (short)1113063424;
			if (num != 0)
			{
			}
			num = (short)1306198017;
			if (num != 0)
			{
			}
			num = (short)1749417984;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Features.ZnChanCfgFPPProtectionFPPEnable_A8142Value;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00098068 File Offset: 0x00096268
		internal static bool Is9600UsedInCpg()
		{
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
			short num;
			try
			{
				num = (short)1429667846;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (enumerator.MoveNext())
						{
							num = (short)1017511938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1576293388;
						short num3 = num;
						num = (short)707810316;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12A;
						default:
							num = (short)432930816;
							if (num != 0)
							{
							}
							num = (short)1122828292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_162;
					case 2:
						if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current).General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)33554437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 3:
						goto IL_146;
					case 4:
						goto IL_12A;
					case 5:
						result = true;
						num = (short)1407516675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_A7:
					num = (short)2095972352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A:
					goto IL_A7;
					IL_12A:
					num = (short)2099249153;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_146:
				IL_162:;
			}
			finally
			{
				num = (short)236388354;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1420165121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1F4;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_197;
						}
						continue;
					}
					IL_197:
					num = (short)600178689;
					if (num != 0)
					{
					}
					if (enumerator == null)
					{
						break;
					}
					num = (short)2049703936;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F4:;
			}
			num = (short)1144389632;
			short num4 = num;
			return result;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000982B4 File Offset: 0x000964B4
		internal static bool IsTDMAUsedInCpg()
		{
			short num = (short)1186398208;
			switch (num)
			{
			default:
			{
				num = (short)1832124417;
				if (num != 0)
				{
				}
				bool result = false;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
				try
				{
					num = (short)1472724998;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_32E;
						case 1:
							goto IL_347;
						case 2:
							try
							{
								num = (short)561840136;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)821493762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1421934592;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection = ((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInner)enumerator2.Current).ASTRO25ChannelIDInnerSection;
										astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelType_A1390.CalculateApplicability();
										num = (short)1975189508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_2BD;
									case 3:
										goto IL_1CD;
									case 4:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
										if (astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelType_A1390_Applicable)
										{
											num = (short)1850277895;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										result = true;
										num = (short)1521876995;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
										if (astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelType_A1390Value == 1)
										{
											num = (short)1257701381;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
										num = (short)155516934;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										switch (0)
										{
										case 0:
											goto IL_1B4;
										}
										continue;
									}
									IL_229:
									num = (short)305397761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1B4:
									goto IL_229;
								}
								IL_1CD:
								IL_2BD:
								break;
							}
							finally
							{
								num = (short)888406018;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1431896065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_32B;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2F4;
										}
										continue;
									}
									IL_2F4:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)2141913088;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_32B:;
							}
							goto IL_32E;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (trunkingSystem.ASTRO25ChannelID.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset).GetEnumerator();
							num = (short)1449263106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
							{
								num = (short)165871619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1605894144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
							num = (short)1817772036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						}
						IL_D7:
						num = (short)287244293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						goto IL_D7;
						IL_32E:
						num = (short)374603777;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_347:;
				}
				finally
				{
					num = (short)672464898;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							for (;;)
							{
								num = (short)1844660656;
								short num3 = num;
								num = (short)169167280;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_3D1;
								}
							}
							IL_3D1:
							num = (short)719781888;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)585302017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_405;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_37E;
							}
							continue;
						}
						IL_37E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1283063808;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_405:;
				}
				num = (short)1456340992;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00098728 File Offset: 0x00096928
		internal static bool IsFrontDisplayFullKeypadUsedInCpg()
		{
			short num = (short)1415406065;
			short num2 = num;
			num = (short)2079482353;
			switch (num2 == num)
			{
			}
			num = (short)1550319616;
			if (num != 0)
			{
			}
			num = (short)576585729;
			if (num != 0)
			{
			}
			num = (short)1284767744;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolFrontDisplayFullKeypad_A23985Value;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000987F0 File Offset: 0x000969F0
		internal static bool Is6000XEUsedInCpg()
		{
			short num = (short)1255705635;
			short num2 = num;
			num = (short)120884259;
			switch (num2 == num)
			{
			}
			num = (short)257818625;
			if (num != 0)
			{
			}
			num = (short)1373896704;
			if (num != 0)
			{
			}
			num = (short)1483341824;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQA02006APX6000XE_A38951Value;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000988B8 File Offset: 0x00096AB8
		internal static bool IsMotorcycleRadioUsedInCpg()
		{
			short num = (short)118143128;
			short num2 = num;
			num = (short)950384792;
			switch (num2 == num)
			{
			}
			num = (short)1282211840;
			if (num != 0)
			{
			}
			num = (short)1453129729;
			if (num != 0)
			{
			}
			num = (short)632684544;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolG138MotorcycleRadio_A24684Value;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00098980 File Offset: 0x00096B80
		internal static bool IsAuthenticationUsedInCpg()
		{
			short num = (short)1596183545;
			short num2 = num;
			num = (short)1467929593;
			switch (num2 == num)
			{
			}
			num = (short)1664155649;
			if (num != 0)
			{
			}
			num = (short)1252261888;
			if (num != 0)
			{
			}
			num = (short)1725235200;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolAuthentication_A37609Value;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00098A4C File Offset: 0x00096C4C
		internal static bool IsDigitalToneSignalingOperationUsedInCpg()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)696516613;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_2CE;
				case 2:
				{
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset).GetEnumerator();
					num2 = (short)1277558784;
					short num3 = num2;
					num2 = (short)1483210753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (!flag)
					{
						num2 = (short)42926080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 4:
					try
					{
						num2 = (short)1771962373;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)1624659759;
								short num4 = num2;
								num2 = (short)247945007;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1F0;
								default:
									goto IL_19C;
								}
								break;
							}
							case 1:
								goto IL_260;
							case 2:
								if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current).Signaling.CnvPerFeaturesAstroAlertingToneTable.ReferencedNode is global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList)
								{
									goto IL_1F0;
								}
								break;
							case 3:
								if (!enumerator.MoveNext())
								{
									num2 = (short)177405956;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)12255234;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								num2 = (short)2061959169;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_14C;
								}
								continue;
							case 6:
								flag = true;
								num2 = (short)430702592;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_14C;
							IL_1F0:
							num2 = (short)1020002310;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_20E:
							num2 = (short)70713347;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_14C:
							goto IL_20E;
						}
						IL_19C:
						num2 = (short)101842944;
						if (num2 != 0)
						{
						}
						IL_260:
						goto IL_4AF;
					}
					finally
					{
						num2 = (short)1141964801;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_2CB;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_296;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num2 = (short)1383268352;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_296:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)123207682;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2CB:;
					}
					goto Block_3;
				case 5:
					if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolH38G51Smartzone_A8185Value)
					{
						num2 = (short)745078786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				}
				goto IL_28;
				IL_4AF:
				num2 = (short)1335033859;
				num = (int)((global::System.IntPtr)num2);
				continue;
				Block_3:
				try
				{
					IL_2CE:
					num2 = (short)1733492743;
					num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_443;
						case 1:
							num2 = (short)1844707328;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
							if (trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.Value == 7)
							{
								num2 = (short)198836227;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 3:
							num2 = (short)1753284612;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
							if (trunkingPersonality.CallPage.TrkPerFeaturesAstroAlertingToneTable.ReferencedNode is global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList)
							{
								num2 = (short)1930690568;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 5:
							goto IL_426;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num2 = (short)295501825;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current;
							num2 = (short)1946615810;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 7:
							num2 = (short)348651521;
							if (num2 != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_33D;
							}
							continue;
						case 8:
							flag = true;
							num2 = (short)438370309;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						IL_33F:
						num2 = (short)357761030;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_33D:
						goto IL_33F;
					}
					IL_426:
					IL_443:
					break;
				}
				finally
				{
					num2 = (short)1254424577;
					num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_4AC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_479;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num2 = (short)1184301056;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						IL_479:
						if (enumerator == null)
						{
							break;
						}
						num2 = (short)412876802;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_4AC:;
				}
				goto IL_4AF;
			}
			return flag;
			IL_28:
			flag = false;
			enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
			num2 = (short)1429143556;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00098F78 File Offset: 0x00097178
		internal static bool IsPreAMPInCpg()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E4;
				case 1:
					if (radioWide.Features.RadWideFeaturePreAmpUHF_A42962.Value)
					{
						num2 = (short)1781895810;
						short num3 = num2;
						num2 = (short)950243970;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_14E;
						}
					}
					num2 = (short)2072117248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
					{
						num2 = (short)1583874049;
						if (num2 != 0)
						{
						}
						num2 = (short)2084306947;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)854523905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_90;
				}
				goto IL_20;
			}
			IL_90:
			num2 = (short)48300032;
			short num4 = num2;
			return radioWide.Features.RadWideAdvancedPreAmp_A8733Value;
			IL_E4:
			return radioWide.Features.RadWideFeaturePreAmpVHF_A42960.Value;
			IL_14E:
			num2 = (short)1278869504;
			if (num2 != 0)
			{
			}
			return true;
			IL_20:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)791412738;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000990EC File Offset: 0x000972EC
		internal static bool BandsIgnoredOnClone()
		{
			short num = (short)248840193;
			if (num != 0)
			{
			}
			num = (short)1598619648;
			short num2 = num;
			num = (short)1390652127;
			short num3 = num;
			num = (short)954772191;
			switch (num3 == num)
			{
			}
			num = (short)1366163456;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00099194 File Offset: 0x00097394
		internal static bool IsASKEnableUsedInCpg()
		{
			short num = (short)2070139582;
			short num2 = num;
			num = (short)210358974;
			switch (num2 == num)
			{
			default:
			{
				num = (short)773455872;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)830341120;
			if (num != 0)
			{
			}
			num = (short)1970929665;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0009923C File Offset: 0x0009743C
		internal static bool IsLegacySWEnableUsedInCpg()
		{
			short num = (short)1990842843;
			short num2 = num;
			num = (short)1532746203;
			switch (num2 == num)
			{
			default:
			{
				num = (short)717160448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1958281216;
			if (num != 0)
			{
			}
			num = (short)893976577;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000992E8 File Offset: 0x000974E8
		internal static bool IsEnhLevel2UsedInCpg()
		{
			short num = (short)1441494019;
			short num2 = num;
			num = (short)240284675;
			switch (num2 == num)
			{
			default:
			{
				num = (short)940834816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)446038017;
			if (num != 0)
			{
			}
			num = (short)1116667904;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQA01771GA01771EnhancementLev2_37660Value;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000993B4 File Offset: 0x000975B4
		internal static bool IsEnhLevel1UsedInCpg()
		{
			short num = (short)2112670982;
			short num2 = num;
			num = (short)850644230;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1961426944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1603862529;
			if (num != 0)
			{
			}
			num = (short)894959616;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQA01770GA01770EnhancementLev1_38632Value;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0009947C File Offset: 0x0009767C
		internal static bool IsADPSwUsedInCpg()
		{
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
			{
				short num = (short)1177616385;
				if (num != 0)
				{
				}
				num = (short)1275002880;
				short num2 = num;
			}
			else
			{
				short num = (short)1602983616;
				short num3 = num;
				num = (short)917149376;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1138163712;
					if (num != 0)
					{
					}
					return false;
				}
			}
			return secureWide.General.SecureWideADPAlgorithmEnable_43200.Value;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00099564 File Offset: 0x00097764
		internal static bool IsAESUsedInCpg()
		{
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			short num;
			if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 3)
			{
				num = (short)991120629;
				short num2 = num;
				num = (short)106056949;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1141112832;
					if (num != 0)
					{
					}
					num = (short)452460545;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)875102208;
			short num3 = num;
			return secureWide.General.SecureWideAESAlgorithmEnable_43201.Value;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0009964C File Offset: 0x0009784C
		internal static bool IsCnvTactRekeyUsedInCpg()
		{
			short num = (short)123273217;
			if (num != 0)
			{
			}
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
			try
			{
				num = (short)894894087;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_190;
					case 1:
						num = (short)629014530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.Features.CnvPerFeaturesTacticalRekeyEnable_A19309Value)
						{
							num = (short)1907621891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						result = true;
						num = (short)761528325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)920125448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
						conventionalPersonality.Features.CnvPerFeaturesTacticalRekeyEnable_A19309.CalculateApplicability();
						num = (short)322371590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_173;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.Features.CnvPerFeaturesTacticalRekeyEnable_A19309_Applicable)
						{
							num = (short)521928705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 8:
						num = (short)2029977600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E0:
					num = (short)888799236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_89:
					goto IL_E0;
				}
				IL_173:
				IL_190:;
			}
			finally
			{
				num = (short)818544641;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_24B;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1C6;
						}
						continue;
					case 2:
					{
						num = (short)133732537;
						short num3 = num;
						num = (short)15177913;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)931921920;
							if (num != 0)
							{
							}
							break;
						}
						enumerator.Dispose();
						num = (short)1391656960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_1C6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1110114306;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_24B:;
			}
			num = (short)1313931264;
			short num4 = num;
			return result;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000998EC File Offset: 0x00097AEC
		internal static bool IsOneTouchUsedInCpg()
		{
			short num = (short)1225064448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_222;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				bool flag;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
					int num4;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag2;
					bool flag3;
					global::AcpCommonLib.IAcpRecordset feature;
					switch (num2)
					{
					case 0:
						num = (short)345768027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH6))
						{
							num = (short)1502478421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 2:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH15))
						{
							num = (short)36962351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 3:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH12))
						{
							num = (short)1983250535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 4:
						num = (short)1607860342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185Value)
						{
							num = (short)1513619545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)137232478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH8))
						{
							num = (short)1459552308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 7:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH2))
						{
							num = (short)572653663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 8:
						enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset)[0][10235].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset).GetEnumerator();
						num = (short)2030632987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)598409273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_SIG2))
						{
							num = (short)695926821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 11:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH7))
						{
							num = (short)390856734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 12:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH16))
						{
							num = (short)1270612041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 13:
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
						num = (short)591331452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH3))
						{
							num = (short)327417925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 15:
						if (!flag)
						{
							num = (short)987234308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 16:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH13))
						{
							num = (short)874053674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 17:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH9))
						{
							num = (short)2141978659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 18:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH7))
						{
							num = (short)1183449208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 19:
						num = (short)523108423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)516489261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH8))
						{
							num = (short)1408761922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 22:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH10))
						{
							num = (short)2137784363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 23:
						enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset).GetEnumerator();
						num = (short)2083979322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						num = (short)115802112;
						short num5 = num;
						if (flag2)
						{
							num = (short)1308229645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1012;
					}
					case 25:
						num = (short)94175270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH1))
						{
							num = (short)1549336585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 27:
						try
						{
							num = (short)1485635625;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)2031649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2B78;
								case 2:
									num = (short)737214518;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1503395884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value == 287)
									{
										num = (short)732037168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1139081287;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1257963581;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 276)
									{
										num = (short)1331232804;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 278)
									{
										num = (short)1571881023;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 8:
									num = (short)1864630311;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)2067529742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 284)
									{
										num = (short)130154498;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 98)
									{
										num = (short)5963842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 12:
									num = (short)1658978351;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									num = (short)199098414;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 280)
									{
										num = (short)1077280828;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 15:
									num = (short)497942538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									num = (short)61800468;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									num = (short)1003946002;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 101)
									{
										num = (short)1203896357;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 19:
									num = (short)746586118;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 283)
									{
										num = (short)482869263;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 278)
									{
										num = (short)400687109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 22:
									num = (short)1840709666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 280)
									{
										num = (short)1257308172;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 24:
									num = (short)1689387015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1966211098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner)enumerator.Current;
									num = (short)1000472641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
									num = (short)1083703349;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									num = (short)941948932;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 101)
									{
										num = (short)1800339475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 29:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 276)
									{
										num = (short)2135228471;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 30:
									num = (short)910360597;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 277)
									{
										num = (short)379650078;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 32:
									goto IL_2BE1;
								case 33:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value == 287)
									{
										num = (short)940769344;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 34:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 284)
									{
										num = (short)1480392717;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 35:
									num = (short)1760952389;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									num = (short)687145010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
									num = (short)2124742685;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 286)
									{
										num = (short)1483079707;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 39:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 100)
									{
										num = (short)2093023249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 40:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 283)
									{
										num = (short)97648662;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 41:
									switch (0)
									{
									case 0:
										goto IL_26BA;
									}
									continue;
								case 42:
									num = (short)934936604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									num = (short)2111438886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 282)
									{
										num = (short)2122383376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 45:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 99)
									{
										num = (short)641138696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 46:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 285)
									{
										num = (short)1770061867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 47:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 281)
									{
										num = (short)2000420867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 48:
									goto IL_2B5C;
								case 49:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 100)
									{
										num = (short)1099890730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 50:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 277)
									{
										num = (short)1298006040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 51:
									num = (short)1358364721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 52:
									num = (short)200802366;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
									goto IL_31AC;
								case 54:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 285)
									{
										num = (short)1924005923;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 55:
									num = (short)1052114975;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 56:
									num = (short)1661337640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 57:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 99)
									{
										num = (short)171704371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 58:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 279)
									{
										num = (short)1742274569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 59:
									num = (short)1700724793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 60:
									num = (short)568459331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 61:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 279)
									{
										num = (short)29884484;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 62:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 282)
									{
										num = (short)263454776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 63:
									num = (short)1135673402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 64:
									goto IL_2BC7;
								case 65:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 98)
									{
										num = (short)245563451;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 66:
									num = (short)1508311085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 67:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value != 281)
									{
										num = (short)812777524;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B5C;
								}
								case 68:
									num = (short)258080791;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 69:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner o3HHCHButtonInner;
									if (o3HHCHButtonInner.O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value != 286)
									{
										num = (short)1729298432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BC7;
								}
								case 70:
									num = (short)406716427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 71:
									if (flag2)
									{
										num = (short)398458950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_2A7D:
								num = (short)1863647257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_26BA:
								goto IL_2A7D;
								IL_2B5C:
								flag = true;
								num = (short)1173880833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2BC7:
								flag = true;
								num = (short)1598816288;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B78:
							IL_2BE1:
							IL_31AC:
							goto IL_48A7;
						}
						finally
						{
							num = (short)1074331648;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_31E3;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1536753666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_321A;
								}
								IL_31E3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1292763137;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_321A:;
						}
						goto IL_321D;
					case 28:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_SIG1))
						{
							num = (short)1167523921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 29:
					{
						int num3 = 0;
						num = (short)1355743342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						num = (short)849149958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SIG4DISP)
						{
							num = (short)1944256566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)87752820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)262668319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1304559724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset)[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset).GetEnumerator();
						num = (short)828571762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)1320812566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1482555457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)1954545744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH5))
						{
							num = (short)1113128993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 39:
						try
						{
							num = (short)2075131907;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)450101254;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current).OneTouch.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerRecset).GetEnumerator();
									num = (short)1573322753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									try
									{
										num = (short)1570832390;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_4C63;
											case 1:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)404291587;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1862991874;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInner)enumerator2.Current).OneTouchInnerSection.CnvPerOneTouchFeature_A19662.Value != 38)
												{
													num = (short)1268187140;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
												num = (short)1868038144;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												flag = true;
												num = (short)1490354181;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												goto IL_4BB9;
											case 6:
												switch (0)
												{
												case 0:
													goto IL_4B9E;
												}
												continue;
											}
											IL_4C0D:
											num = (short)658505729;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4B9E:
											goto IL_4C0D;
										}
										IL_4BB9:
										IL_4C63:
										goto IL_4AE8;
									}
									finally
									{
										num = (short)660602882;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1688207361;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_4CD2;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_4C9A;
												}
												continue;
											}
											IL_4C9A:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)117506048;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_4CD2:;
									}
									break;
									IL_4AE8:
									num = (short)25493509;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4D4A;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_4AE3;
									}
									continue;
								case 4:
									goto IL_4D2C;
								case 5:
									if (flag)
									{
										num = (short)273219591;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									num = (short)985792514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)451805188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4CD5:
								num = (short)1333002240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4AE3:
								goto IL_4CD5;
							}
							IL_4D2C:
							IL_4D4A:
							goto IL_574B;
						}
						finally
						{
							num = (short)1337393154;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)944635905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4DB8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4D81;
									}
									continue;
								}
								IL_4D81:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2104688640;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4DB8:;
						}
						goto IL_4DBB;
					case 40:
						flag3 = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184Value;
						goto IL_231B;
					case 41:
						num = (short)247464058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_4658;
					case 43:
						num = (short)292421680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH4))
						{
							num = (short)1427308563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 45:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH14))
						{
							num = (short)1975320646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 46:
						num = (short)701497356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)2125332544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH11))
						{
							num = (short)1859518547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 49:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH13))
						{
							num = (short)937099284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 50:
						num = (short)1603010675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						num = (short)307822636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						num = (short)1671888913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (!flag)
						{
							num = (short)1799684130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 54:
						goto IL_48E5;
					case 55:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH4))
						{
							num = (short)876085273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 56:
						num = (short)905379841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH2))
						{
							num = (short)993656895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 58:
						try
						{
							num = (short)1418199070;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (flag2)
									{
										num = (short)1482031163;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 99)
									{
										num = (short)1372913713;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 2:
									num = (short)514850887;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 98)
									{
										num = (short)1056440338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 284)
									{
										num = (short)612106246;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 283)
									{
										num = (short)770375711;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 6:
									num = (short)219807788;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 101)
									{
										num = (short)714539044;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 285)
									{
										num = (short)1753284666;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2114977794;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner = (global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner)enumerator.Current;
									num = (short)831782915;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 280)
									{
										num = (short)529072139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 11:
									num = (short)572194881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 100)
									{
										num = (short)1429733444;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 13:
									num = (short)2048000033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_1970;
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 286)
									{
										num = (short)1000210494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 281)
									{
										num = (short)859701295;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 17:
									num = (short)875364357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									num = (short)1789657089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									num = (short)1617100823;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									num = (short)1374486562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 278)
									{
										num = (short)1110704152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 22:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 279)
									{
										num = (short)435355699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 287)
									{
										num = (short)613154844;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1265369088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
									num = (short)87293974;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									num = (short)416415760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									num = (short)1328349223;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									num = (short)706019363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									goto IL_1956;
								case 29:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 287)
									{
										num = (short)2128609335;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 30:
									switch (0)
									{
									case 0:
										goto IL_143A;
									}
									continue;
								case 31:
									num = (short)526647300;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									goto IL_167B;
								case 33:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 284)
									{
										num = (short)270270533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 34:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 277)
									{
										num = (short)1346240578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 35:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 280)
									{
										num = (short)1972371481;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 36:
									num = (short)1190723625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 282)
									{
										num = (short)1944322065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 38:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 98)
									{
										num = (short)1652097050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 39:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 99)
									{
										num = (short)1547632694;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 40:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 277)
									{
										num = (short)71041067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 41:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 276)
									{
										num = (short)2042626111;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 42:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 282)
									{
										num = (short)482803758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 43:
									num = (short)1859715139;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 285)
									{
										num = (short)338690118;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 45:
									num = (short)1599930432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									num = (short)1334050873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
									num = (short)1477050410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 279)
									{
										num = (short)1717305371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 49:
									num = (short)369623052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 286)
									{
										num = (short)39059475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 51:
									num = (short)343539722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 52:
									num = (short)1388511280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 100)
									{
										num = (short)1885077549;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 54:
									num = (short)376373301;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 55:
									goto IL_1660;
								case 56:
									num = (short)172490789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 57:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 283)
									{
										num = (short)1988034573;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 58:
									num = (short)1162412082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 59:
									num = (short)1179648038;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 60:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 276)
									{
										num = (short)432144404;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 61:
									num = (short)1364656188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 62:
									num = (short)444465181;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 63:
									num = (short)2023751720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 64:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 101)
									{
										num = (short)34537533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 65:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 281)
									{
										num = (short)483000376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1660;
								}
								case 66:
									num = (short)1339686933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 67:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner portableButtonInner;
									if (portableButtonInner.PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 278)
									{
										num = (short)549257268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1956;
								}
								case 68:
									num = (short)156958727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 69:
									num = (short)1948581896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 70:
									num = (short)1503789071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 71:
									goto IL_1F2A;
								}
								goto IL_143A;
								IL_1660:
								flag = true;
								num = (short)550436896;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1956:
								flag = true;
								num = (short)1627521038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E81:
								num = (short)1604124681;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_143A:
								goto IL_1E81;
							}
							IL_167B:
							IL_1970:
							IL_1F2A:
							goto IL_12B5;
						}
						finally
						{
							num = (short)259588098;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)4063233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1F97;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1F61;
									}
									continue;
								}
								IL_1F61:
								if (enumerator == null)
								{
									break;
								}
								num = (short)16121856;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1F97:;
						}
						goto IL_1F9A;
						IL_12B5:
						num = (short)1685258308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						if (feature.Count != 0)
						{
							num = (short)785317948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24D9;
					case 60:
						goto IL_1F9A;
					case 61:
						if (!flag)
						{
							num = (short)379715689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1012;
					case 62:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH11))
						{
							num = (short)216006735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 63:
						num = (short)447086664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH16))
						{
							num = (short)16449638;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 65:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH10))
						{
							num = (short)1361051761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 66:
						num = (short)1455292502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH1))
						{
							num = (short)450822248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 68:
						if (!flag)
						{
							num = (short)1032650858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 69:
						goto IL_4DBB;
					case 70:
						num = (short)767492196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH5))
						{
							num = (short)1614872632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 72:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH3))
						{
							num = (short)2059075635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 73:
						num = (short)83034205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)1566638098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						if (flag2)
						{
							num = (short)926941213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24D9;
					case 76:
						if (!flag)
						{
							num = (short)2098724872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48A7;
					case 77:
						num = (short)989659138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (!flag)
						{
							num = (short)1807417463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B1;
					case 79:
						num = (short)225968131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_SIG3))
						{
							num = (short)819134552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 81:
						num = (short)573308938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						goto IL_4A2D;
					case 83:
						num = (short)1563361387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						goto IL_24D9;
					case 85:
						num = (short)1747189771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH9))
						{
							num = (short)2022047780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 87:
						goto IL_4E1C;
					case 88:
						num = (short)743833697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						num = (short)1197211688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						goto IL_4A2D;
					case 91:
						num = (short)965869569;
						if (num != 0)
						{
						}
						if (flag)
						{
							num = (short)702546004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1167261722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						try
						{
							num = (short)1793720329;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1701904402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 280)
									{
										num = (short)489488434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 2:
									num = (short)625213452;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1363476506;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)23396399;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value == 287)
									{
										num = (short)918683709;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 283)
									{
										num = (short)1294139447;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 7:
									num = (short)1852899360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 285)
									{
										num = (short)273678360;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_36A1;
									}
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 283)
									{
										num = (short)1499136037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 101)
									{
										num = (short)1208025151;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 282)
									{
										num = (short)651034666;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 13:
									if (flag2)
									{
										num = (short)266076209;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 281)
									{
										num = (short)2090795037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 15:
									goto IL_4195;
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 101)
									{
										num = (short)994115629;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 284)
									{
										num = (short)1197736004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 277)
									{
										num = (short)1980563508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 19:
									goto IL_3BE7;
								case 20:
									num = (short)755040289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num = (short)620363835;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									num = (short)1297154063;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 278)
									{
										num = (short)269746230;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 24:
									num = (short)1123418165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 99)
									{
										num = (short)1165754371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 26:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 100)
									{
										num = (short)734003260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 27:
									num = (short)942014469;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 282)
									{
										num = (short)1915158590;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 29:
									num = (short)869400604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 276)
									{
										num = (short)1812004908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 31:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 278)
									{
										num = (short)1700790276;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 32:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 280)
									{
										num = (short)1752563732;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 33:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 281)
									{
										num = (short)981729282;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 34:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 98)
									{
										num = (short)556859430;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 35:
									goto IL_3B7A;
								case 36:
									num = (short)125173808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
									num = (short)824115217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
									num = (short)2119368744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)674955286;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner = (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)enumerator.Current;
									num = (short)1573257272;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 40:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 99)
									{
										num = (short)667484196;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 41:
									num = (short)1012400139;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									num = (short)1276313610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									num = (short)823132185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
									num = (short)621805633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									num = (short)1971912734;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 286)
									{
										num = (short)377028629;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 47:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 279)
									{
										num = (short)1092485178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 48:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 100)
									{
										num = (short)376504361;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 49:
									num = (short)1677852706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
									num = (short)1813970958;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 51:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 285)
									{
										num = (short)618332227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 52:
									num = (short)1131413535;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 286)
									{
										num = (short)2010382363;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 54:
									num = (short)638124089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 55:
									num = (short)1313734725;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 56:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 98)
									{
										num = (short)1125187627;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 57:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 279)
									{
										num = (short)1955528711;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 58:
									num = (short)98369537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 59:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value == 287)
									{
										num = (short)393740354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)439025677;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 60:
									num = (short)605290512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 61:
									goto IL_3BCD;
								case 62:
									num = (short)450363398;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 63:
									num = (short)323747911;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 64:
									num = (short)1541996552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 65:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 277)
									{
										num = (short)459800646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B60;
								}
								case 66:
									goto IL_3B60;
								case 67:
									num = (short)604438574;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 68:
									num = (short)629342259;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 69:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 284)
									{
										num = (short)685703232;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								case 70:
									num = (short)926613527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 71:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner kmbuttonInner;
									if (kmbuttonInner.KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 276)
									{
										num = (short)1978597376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BCD;
								}
								}
								IL_36A6:
								num = (short)285278247;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_36A1:
								goto IL_36A6;
								IL_3B60:
								flag = true;
								num = (short)1441005603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3BCD:
								flag = true;
								num = (short)355270675;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3B7A:
							IL_3BE7:
							IL_4195:
							goto IL_10B1;
						}
						finally
						{
							num = (short)713818113;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1579417602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_41CD;
									}
									continue;
								case 2:
									goto IL_4203;
								}
								IL_41CD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)185335808;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4203:;
						}
						goto IL_4206;
					case 93:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SIG1))
						{
							num = (short)574357554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 94:
						flag3 = true;
						goto IL_231B;
					case 95:
						num = (short)1855586318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						goto IL_24D9;
					case 97:
					{
						int num3;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_SIG4DISP)
						{
							num = (short)1181548667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)674234477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 98:
					{
						int num3;
						if (num3 < menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1541931008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24D9;
					}
					case 99:
						if (num4 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1698627666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1833631811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH15))
						{
							num = (short)1824849966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 101:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH14))
						{
							num = (short)1037172813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 102:
						num = (short)313589788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						num = (short)1123614769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						num = (short)422379527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						num = (short)1306525720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						goto IL_4206;
					case 107:
					{
						int num3;
						if (!(menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TCH12))
						{
							num = (short)1602945136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF3;
					}
					case 108:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_TCH6))
						{
							num = (short)1050214474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 109:
						goto IL_3441;
					case 110:
						goto IL_3441;
					case 111:
						try
						{
							num = (short)1474232334;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1702952976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 276)
									{
										num = (short)315359283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 98)
									{
										num = (short)471859219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 3:
									num = (short)526385172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 284)
									{
										num = (short)231604259;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 283)
									{
										num = (short)1695809547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 280)
									{
										num = (short)1061683259;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 278)
									{
										num = (short)101449772;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 282)
									{
										num = (short)1367080978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 286)
									{
										num = (short)1337720898;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 283)
									{
										num = (short)1138294853;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 11:
									num = (short)975372318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 279)
									{
										num = (short)1628897333;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 281)
									{
										num = (short)1121255476;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 14:
									switch (0)
									{
									case 0:
										goto IL_48B;
									}
									continue;
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 285)
									{
										num = (short)2022703135;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 100)
									{
										num = (short)614203440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 17:
									num = (short)1146224703;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									num = (short)1486422021;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									num = (short)2146566171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 101)
									{
										num = (short)1162018881;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 101)
									{
										num = (short)1508376636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 22:
									num = (short)482410545;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									if (flag2)
									{
										num = (short)745603119;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 24:
									num = (short)1351090247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 98)
									{
										num = (short)1338572824;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 26:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 276)
									{
										num = (short)1105788964;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 27:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 99)
									{
										num = (short)1965096998;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 28:
									goto IL_99E;
								case 29:
									goto IL_F83;
								case 30:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 284)
									{
										num = (short)480444477;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 31:
									num = (short)2127626307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									num = (short)924844078;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									goto IL_BB0;
								case 34:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 285)
									{
										num = (short)1404633130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 35:
									num = (short)1029701647;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									num = (short)1496383527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value == 287)
									{
										num = (short)149225515;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1296236567;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 38:
									num = (short)1348337704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 277)
									{
										num = (short)1926365229;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 40:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 100)
									{
										num = (short)1050017795;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 41:
									goto IL_B94;
								case 42:
									num = (short)327286793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									goto IL_983;
								case 44:
									num = (short)891224076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									num = (short)1845690438;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 279)
									{
										num = (short)33292310;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 47:
									num = (short)2061238297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
									num = (short)22216725;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 49:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 280)
									{
										num = (short)1396768785;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 50:
									num = (short)1370685496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 51:
									num = (short)806551620;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 52:
									num = (short)628359232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
									num = (short)2079391750;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 54:
									num = (short)1004797981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 55:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)36765750;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner = (global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner)enumerator.Current;
									num = (short)1692401666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 56:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value == 287)
									{
										num = (short)1806958633;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 57:
									num = (short)1976958983;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 58:
									num = (short)1680867338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 59:
									num = (short)931856397;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 60:
									num = (short)516751361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 61:
									num = (short)333971490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 62:
									num = (short)297926664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 63:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 281)
									{
										num = (short)1929379902;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 64:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 282)
									{
										num = (short)1044709434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 65:
									num = (short)1364262938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 66:
									num = (short)1646395429;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 67:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 286)
									{
										num = (short)1199046706;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 68:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 277)
									{
										num = (short)856555577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								case 69:
									num = (short)1203830788;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 70:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 278)
									{
										num = (short)1716060192;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_983;
								}
								case 71:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 99)
									{
										num = (short)331415552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B94;
								}
								}
								goto IL_48B;
								IL_983:
								flag = true;
								num = (short)590544924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B94:
								flag = true;
								num = (short)1660420129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D9B:
								num = (short)204275767;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_48B:
								goto IL_D9B;
							}
							IL_99E:
							IL_BB0:
							IL_F83:
							return flag;
						}
						finally
						{
							num = (short)321323009;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_FF0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_FBB;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1859321856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FBB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1565917186;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FF0:;
						}
						goto IL_FF3;
					case 112:
						num = (short)1603600400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
						num = (short)767492158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						try
						{
							num = (short)209518619;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_55C0;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 98)
									{
										num = (short)636682252;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 279)
									{
										num = (short)1514733588;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 3:
									goto IL_55A6;
								case 4:
									num = (short)1104281619;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 283)
									{
										num = (short)432734231;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 6:
									num = (short)231997465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 100)
									{
										num = (short)1243742224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 8:
									num = (short)1147535367;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)322306084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 286)
									{
										num = (short)147259414;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 11:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1224212504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner)enumerator.Current;
									num = (short)372244481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num = (short)1433337890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									num = (short)854523909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)1369505818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									num = (short)166002690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									num = (short)689373202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									num = (short)1001455626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 101)
									{
										num = (short)1399783430;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 19:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 281)
									{
										num = (short)582221838;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 20:
									num = (short)109903904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value == 287)
									{
										num = (short)589365251;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 22:
									num = (short)1268645909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									num = (short)1030422561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									num = (short)1760428062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 276)
									{
										num = (short)1338507273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 26:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 282)
									{
										num = (short)1969029133;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 27:
									switch (0)
									{
									case 0:
										goto IL_5100;
									}
									continue;
								case 28:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 285)
									{
										num = (short)935591953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 29:
									num = (short)968949788;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									goto IL_568C;
								case 31:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 278)
									{
										num = (short)1525284879;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 32:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 280)
									{
										num = (short)746389508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 33:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 284)
									{
										num = (short)2050424861;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 34:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 99)
									{
										num = (short)615514120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								case 35:
									num = (short)438370335;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
									if (o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value != 277)
									{
										num = (short)1524957219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55A6;
								}
								}
								IL_51F7:
								num = (short)194707467;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5100:
								goto IL_51F7;
								IL_55A6:
								flag = true;
								num = (short)139657216;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_55C0:
							IL_568C:
							return flag;
						}
						finally
						{
							num = (short)878706688;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_56C4;
									}
									continue;
								case 1:
									enumerator.Dispose();
									goto IL_572F;
								case 2:
									goto IL_5748;
								}
								IL_56C4:
								num = (short)303304114;
								short num6 = num;
								num = (short)412028338;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_572F:
									num = (short)1402601474;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)1763639296;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_574A;
									}
									num = (short)1578565633;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_5748:
							IL_574A:;
						}
						goto IL_574B;
					case 115:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SIG2))
						{
							num = (short)2076508201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 116:
						goto IL_4E1C;
					case 117:
						num = (short)235929659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)405798935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_321D;
					case 119:
						enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset)[0][10231].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset).GetEnumerator();
						num = (short)862847068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						num = (short)58064917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						if (feature != null)
						{
							num = (short)67698805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24D9;
					case 122:
						if (!(menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SIG3))
						{
							num = (short)1022165024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E5;
					case 123:
						goto IL_FF3;
					case 124:
						try
						{
							num = (short)882311174;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4517;
								case 1:
									goto IL_44FE;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)495190019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current).OneTouch.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset).GetEnumerator();
									num = (short)1828782085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)711065607;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (flag)
									{
										num = (short)1078919169;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									try
									{
										num = (short)1967587331;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_448C;
											case 1:
												flag = true;
												num = (short)526123010;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_4419;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_43CA;
												}
												continue;
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)555352070;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1800142853;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner)enumerator2.Current).OneTouchInnerSection.TrkSysOneTouchFeature_A8614.Value != 38)
												{
													num = (short)189661185;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
												num = (short)1297154048;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_43CC:
											num = (short)1278935044;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_43CA:
											goto IL_43CC;
										}
										IL_4419:
										IL_448C:
										goto IL_4557;
									}
									finally
									{
										num = (short)1100546050;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												goto IL_44FB;
											case 1:
												enumerator2.Dispose();
												num = (short)216334336;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_44C4;
												}
												continue;
											}
											IL_44C4:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)159055873;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_44FB:;
									}
									goto IL_44FE;
									IL_4557:
									num = (short)756482052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_4382;
									}
									continue;
								case 7:
									goto IL_45E8;
								}
								goto IL_4382;
								IL_44FE:
								num = (short)272433152;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_451C:
								num = (short)1659043842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4382:
								goto IL_451C;
							}
							IL_4517:
							IL_45E8:
							goto IL_1012;
						}
						finally
						{
							num = (short)1856897026;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4655;
								case 1:
									enumerator.Dispose();
									num = (short)1689255936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_461F;
									}
									continue;
								}
								IL_461F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)646578177;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4655:;
						}
						goto IL_4658;
					}
					goto IL_222;
					IL_FF3:
					flag = true;
					num = (short)747176032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1012:
					num = (short)2145320975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10B1:
					num = (short)1309343820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F9A:
					menuItems = (feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems);
					num4 = 0;
					num = (short)1874395223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_231B:
					flag2 = flag3;
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
					num = (short)741998631;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24D9:
					num = (short)1345650766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_321D:
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
					num = (short)868221049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3441:
					num = (short)1424687202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4206:
					enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset).GetEnumerator();
					num = (short)610271343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4658:
					num = (short)1908342885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48A7:
					num = (short)1304297525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48E5:
					flag = true;
					num = (short)1733492826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A2D:
					num = (short)60424267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DBB:
					num = (short)257687607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E1C:
					num = (short)395247715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_574B:
					num = (short)224526397;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_222:
				flag = false;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)755761157;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0009F288 File Offset: 0x0009D488
		internal static bool IsBluetoothUsedInCpg()
		{
			short num = (short)1465918696;
			short num2 = num;
			num = (short)1672946920;
			switch (num2 == num)
			{
			default:
			{
				num = (short)969998336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)785317889;
			if (num != 0)
			{
			}
			num = (short)176291840;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10630] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth).RadWideBluetoothBluetoothEnable_A37028Value;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0009F358 File Offset: 0x0009D558
		internal static bool IsTrunkedRadioTraceRemoteMonitorUsedInCpg()
		{
			short num = (short)1735281015;
			short num2 = num;
			num = (short)683559287;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)352583680;
				if (num != 0)
				{
				}
				result = false;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
				try
				{
					num = (short)1266089985;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							result = true;
							num = (short)46530566;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A4;
							}
							continue;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)262799365;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1754857476;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_154;
						case 4:
							if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current).Features.TrkSysFeaturesEnable_A7968Value)
							{
								num = (short)1905655808;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							num = (short)1530200067;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_137;
						}
						IL_E7:
						num = (short)1403518978;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A4:
						goto IL_E7;
					}
					IL_137:
					IL_154:;
				}
				finally
				{
					num = (short)1171193856;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_186;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)228720642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1BB;
						}
						IL_186:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1327038465;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1BB:;
				}
				break;
			}
			}
			num = (short)1666514945;
			if (num != 0)
			{
			}
			num = (short)499974144;
			short num4 = num;
			return result;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0009F584 File Offset: 0x0009D784
		internal static bool IsEnhancedZoneBankUsedInCpg()
		{
			short num = (short)1878970379;
			short num2 = num;
			num = (short)451465227;
			switch (num2 == num)
			{
			default:
			{
				num = (short)59113472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)666697728;
			if (num != 0)
			{
			}
			num = (short)808648705;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10075] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedZoneBankOperation_A37543Value == 1;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0009F654 File Offset: 0x0009D854
		internal static bool IsExtremeNoiseReductionUsedInCpg()
		{
			short num = (short)2036556355;
			short num2 = num;
			num = (short)1895785027;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)559546368;
				short num3 = num;
				num = (short)1615265793;
				if (num != 0)
				{
				}
				num = (short)1684930560;
				if (num != 0)
				{
				}
				num = (short)1128923136;
				switch (num)
				{
				}
				break;
			}
			}
			bool result = false;
			bool flag = global::ConstraintHelper.UtilityMack.IsPortable();
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset).GetEnumerator();
			try
			{
				num = (short)1911291910;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_18D;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
						if (radioProfiles.AudioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292.HiddenStatic)
						{
							num = (short)952500233;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18D;
					}
					case 2:
						if (flag)
						{
							num = (short)1283653642;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 3:
						num = (short)1219100684;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)958857223;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles = (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)enumerator.Current;
						num = (short)1731264526;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)443547649;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_143;
						}
						continue;
					case 7:
						num = (short)1147600911;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
						if (radioProfiles.LabtoolRAD_PROF_CDA.RadProfAudioSettingsInternalMicSourceMode_A22193Value != 7)
						{
							num = (short)1455882243;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18D;
					}
					case 9:
						goto IL_2BB;
					case 10:
						num = (short)1756889096;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1653866498;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
						if (radioProfiles.LabtoolRAD_PROF_CDA.RadProfAudioSettingsInternalMicSourceMode_A22193Value == 8)
						{
							num = (short)1866268672;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						goto IL_1A7;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
						if (radioProfiles.AudioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292Value == 3)
						{
							num = (short)1010434053;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BB;
					}
					case 15:
						goto IL_35D;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
						if (radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291Value != 3)
						{
							num = (short)1576534027;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18D;
					}
					}
					goto IL_143;
					IL_18D:
					result = true;
					num = (short)196018189;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_243:
					num = (short)199819268;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_143:
					goto IL_243;
					IL_2BB:
					num = (short)719519760;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1A7:
				IL_35D:;
			}
			finally
			{
				num = (short)1813446656;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_391;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)157745154;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3C8;
					}
					IL_391:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1933115393;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_3C8:;
			}
			return result;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0009FA4C File Offset: 0x0009DC4C
		internal static bool IsFCCNarrowBandMandateUsedInCpg()
		{
			short num = (short)191820961;
			short num2 = num;
			num = (short)1735062689;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1770389504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)894959616;
			if (num != 0)
			{
			}
			num = (short)1087897601;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQ507G507FCCMANDATE_A38198Value;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0009FB14 File Offset: 0x0009DD14
		internal static bool IsDVRSUsedInCpg()
		{
			short num = (short)1797279518;
			short num2 = num;
			num = (short)1102860062;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1741815809;
				if (num != 0)
				{
				}
				num = (short)82313216;
				if (num != 0)
				{
				}
				result = false;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).GetEnumerator();
				try
				{
					num = (short)48758785;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							result = true;
							num = (short)2112618502;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D0;
							}
							continue;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)887881733;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)431816708;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_187;
						case 4:
							if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current).General.CnvSysGeneralSystemType_A13262.Value == 2)
							{
								num = (short)646184960;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							num = (short)576258051;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_169;
						}
						IL_11A:
						num = (short)1221656578;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D0:
						goto IL_11A;
					}
					IL_169:
					IL_187:;
				}
				finally
				{
					num = (short)1823604736;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1B9;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)916520962;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1EF;
						}
						IL_1B9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)158990337;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1EF:;
				}
				break;
			}
			}
			num = (short)92995584;
			short num4 = num;
			return result;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0009FD4C File Offset: 0x0009DF4C
		internal static bool IsDVRSMSUUsedInCpg()
		{
			short num = (short)777584641;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			int num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
				{
					num = (short)351226032;
					short num3 = num;
					num = (short)1337936048;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num = (short)40632320;
						if (num != 0)
						{
						}
						result = dvrswide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
						num = (short)1427177472;
						short num4 = num;
						num = (short)1118830593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return result;
				case 2:
					if (dvrswide != null)
					{
						num = (short)242024448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_43;
			}
			return result;
			IL_43:
			result = false;
			dvrswide = (global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide);
			num = (short)83230722;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0009FE84 File Offset: 0x0009E084
		internal static bool IsDualRadioUsedInCpg()
		{
			bool result;
			for (;;)
			{
				IL_00:
				short num = (short)549715969;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				int num2;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_33:
					switch (num2)
					{
					case 0:
						result = true;
						num = (short)2136604673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return result;
					case 2:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
						{
							num = (short)1964345053;
							short num3 = num;
							num = (short)972588765;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)1437728768;
								short num4 = num;
								break;
							}
							}
							num = (short)1218510848;
							if (num != 0)
							{
							}
							num = (short)1614938112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						num = (short)1602224130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (radioWide != null)
						{
							num = (short)1033764867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				IL_4D:
				result = false;
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)781123588;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			return result;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000A0004 File Offset: 0x0009E204
		internal static bool IsV24SoftwareEnabledInCpg()
		{
			short num = (short)91815937;
			if (num != 0)
			{
			}
			num = (short)1850736640;
			short num2 = num;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset).GetEnumerator();
			try
			{
				num = (short)130540021;
				short num3 = num;
				num = (short)506126837;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_126:
					num = (short)264372229;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)429654016;
					if (num != 0)
					{
					}
					num = (short)480378886;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						if (((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current).RSI.ZoneChannelAssignmentRSIMode_A41831.Value != 0)
						{
							goto IL_126;
						}
						break;
					case 1:
						goto IL_1AC;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)2047803395;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1340997632;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)991559681;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_18E;
					case 5:
						result = true;
						num = (short)623116292;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_F4;
						}
						continue;
					}
					IL_13D:
					num = (short)1807810562;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_F4:
					goto IL_13D;
				}
				IL_18E:
				IL_1AC:;
			}
			finally
			{
				num = (short)1938096130;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						enumerator.Dispose();
						num = (short)768802817;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_215;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1DF;
						}
						continue;
					}
					IL_1DF:
					if (enumerator == null)
					{
						break;
					}
					num = (short)377618432;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_215:;
			}
			return result;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000A0248 File Offset: 0x0009E448
		internal static bool IsEnhancedDataEnabledInCpg()
		{
			short num = (short)1285105605;
			short num2 = num;
			num = (short)1370302405;
			switch (num2 == num)
			{
			}
			num = (short)1456013312;
			if (num != 0)
			{
			}
			num = (short)257163265;
			if (num != 0)
			{
			}
			num = (short)1381105664;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.EnhancedDataOperation_42024Value;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000A0314 File Offset: 0x0009E514
		internal static bool IsExtendedDispatchEnabledInCpg()
		{
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).GetEnumerator();
			short num;
			try
			{
				num = (short)1811988996;
				short num2 = num;
				num = (short)376160772;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D2:
					num = (short)2114715653;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)386203648;
					if (num != 0)
					{
					}
					num = (short)1672216582;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current).Features.CnvSysFeaturesExtendedDispatchEn_A37220Value)
						{
							goto IL_D2;
						}
						break;
					case 1:
						goto IL_155;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1706491907;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1441792000;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1463418881;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_137;
					case 5:
						result = true;
						num = (short)1292304388;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					IL_E8:
					num = (short)630784002;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					goto IL_E8;
				}
				IL_137:
				IL_155:;
			}
			finally
			{
				num = (short)1303838722;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1309933569;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1BB;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_188;
						}
						continue;
					}
					IL_188:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1255079936;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1BB:;
			}
			num = (short)215154688;
			short num4 = num;
			num = (short)132907009;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x000A054C File Offset: 0x0009E74C
		internal static bool IsManDownUsedInCpg()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)196498447;
					short num3 = num2;
					num2 = (short)223171599;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)16580608;
						if (num2 != 0)
						{
						}
						result = (emergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0);
						num2 = (short)1663762433;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_DC;
				case 2:
					if (emergencyWide != null)
					{
						num2 = (short)460521472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_1C;
			}
			IL_DC:
			num2 = (short)1279524864;
			short num4 = num2;
			num2 = (short)2009137153;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			result = false;
			emergencyWide = (global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide);
			num2 = (short)1575223298;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000A068C File Offset: 0x0009E88C
		internal static bool IsTrkSingleSystemTriggerUsedInCpg()
		{
			short num = (short)1157267855;
			short num2 = num;
			num = (short)1942716815;
			switch (num2 == num)
			{
			}
			num = (short)259915777;
			if (num != 0)
			{
			}
			num = (short)215351296;
			if (num != 0)
			{
			}
			num = (short)547618816;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQA02811TrkSingleSysTrigger_A41198Value;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000A0754 File Offset: 0x0009E954
		internal static bool IsAPXLiUsedInCpg()
		{
			short num = (short)945091868;
			short num2 = num;
			num = (short)1257501980;
			switch (num2 == num)
			{
			}
			num = (short)1902575617;
			if (num != 0)
			{
			}
			num = (short)1311703040;
			if (num != 0)
			{
			}
			num = (short)1262223360;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQA02751APXLiRadioTrigger_A41197Value;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000A081C File Offset: 0x0009EA1C
		internal static bool IsFiregroundAccountabilitySoftwareInCpg()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)439540901;
						short num3 = num2;
						num2 = (short)1588518053;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_11F:
							num2 = (short)1933443077;
							num = (int)((global::System.IntPtr)num2);
							break;
						default:
							num2 = (short)167444480;
							if (num2 != 0)
							{
							}
							num2 = (short)761921542;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						bool result;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									goto IL_11F;
								}
								num2 = (short)732889091;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_1B5;
							case 2:
								goto IL_14B;
							case 3:
								if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current).Features.TrkSysFeaturesPASelection_A42882.ReferencedNode != null)
								{
									num2 = (short)1999896580;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 4:
								result = true;
								num2 = (short)1818820610;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								num2 = (short)615383041;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_101;
								}
								continue;
							}
							IL_103:
							num2 = (short)1796866048;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_101:
							goto IL_103;
						}
						IL_14B:
						return result;
						IL_1B5:
						return false;
					}
					finally
					{
						num2 = (short)2035613698;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1141571585;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_21F;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1EA;
								}
								continue;
							}
							IL_1EA:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1171259392;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_21F:;
					}
					goto Block_2;
				case 1:
					try
					{
						num2 = (short)1842741254;
						num = (int)((global::System.IntPtr)num2);
						bool result;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num2 = (short)688717829;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)1912733699;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_506;
							case 2:
								goto IL_498;
							case 3:
								if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current).Features.CnvSysFeaturesPASelection_A42880.ReferencedNode != null)
								{
									num2 = (short)1255473156;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 4:
								result = true;
								num2 = (short)1230045186;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								num2 = (short)1424293889;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_44A;
								}
								continue;
							}
							IL_44C:
							num2 = (short)1517748224;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_44A:
							goto IL_44C;
						}
						IL_498:
						return result;
						IL_506:
						goto IL_3D4;
					}
					finally
					{
						num2 = (short)429391874;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)2049638401;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_571;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_53C;
								}
								continue;
							}
							IL_53C:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1022623744;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_571:;
					}
					goto IL_574;
				case 2:
				{
					num2 = (short)739966976;
					short num4 = num2;
					goto IL_222;
				}
				}
				goto IL_1C;
				IL_3D4:
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
				num2 = (short)2022506496;
				num = (int)((global::System.IntPtr)num2);
				continue;
				Block_2:
				try
				{
					IL_222:
					num2 = (short)1866989576;
					num = (int)((global::System.IntPtr)num2);
					bool result;
					for (;;)
					{
						switch (num)
						{
						case 0:
							num2 = (short)1529282567;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_368;
						case 2:
							goto IL_30F;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if (conventionalPersonality.Features.ConPerFeatureIncidentSignalingType_A41507Value != 2)
							{
								num2 = (short)481951744;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_2F5;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num2 = (short)1016004614;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
							num2 = (short)253427715;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 5:
							goto IL_2F5;
						case 6:
							num2 = (short)1818624001;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if (conventionalPersonality.Features.ConPerFeatureIncidentSignalingType_A41507Value == 3)
							{
								num2 = (short)1678442501;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 8:
							switch (0)
							{
							case 0:
								goto IL_26A;
							}
							continue;
						}
						goto IL_26A;
						IL_2F5:
						result = true;
						num2 = (short)1562574850;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_314:
						num2 = (short)955711492;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_26A:
						goto IL_314;
					}
					IL_30F:
					return result;
					IL_368:
					goto IL_574;
				}
				finally
				{
					num2 = (short)134217730;
					num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							enumerator.Dispose();
							num2 = (short)1180827649;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_3D1;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_39D;
							}
							continue;
						}
						IL_39D:
						if (enumerator == null)
						{
							break;
						}
						num2 = (short)102957056;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_3D1:;
				}
				goto IL_3D4;
				IL_574:
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).GetEnumerator();
				num2 = (short)1862729729;
				if (num2 != 0)
				{
				}
				num2 = (short)238944257;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_1C:
			enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
			num2 = (short)959447042;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000A0E44 File Offset: 0x0009F044
		internal static bool IsP25CommonAirInterfaceOptionUsedInCpg()
		{
			short num = (short)157417473;
			if (num != 0)
			{
			}
			num = (short)1111490560;
			short num2 = num;
			num = (short)113078937;
			short num3 = num;
			num = (short)744452761;
			switch (num3 == num)
			{
			}
			num = (short)256966656;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolP25CommonAirInterface_A42122Value;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000A0F10 File Offset: 0x0009F110
		internal static bool IsFDNYEmergencyRxTxToneSetInCpg()
		{
			short num = (short)1959597624;
			short num2 = num;
			num = (short)30217784;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1964310528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1637285889;
			if (num != 0)
			{
			}
			num = (short)1997406208;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolG857FDNYEmRxTxToneSet_A41509Value;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000A0FD8 File Offset: 0x0009F1D8
		internal static bool IsEncryptedTacticalInhibitUsedInCpg()
		{
			short num = (short)1329237965;
			short num2 = num;
			num = (short)1793429453;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1147076608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1042743297;
			if (num != 0)
			{
			}
			num = (short)583204864;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405Value;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000A10A4 File Offset: 0x0009F2A4
		internal static bool IsCollaborativePhase1UsedInCpg()
		{
			short num = (short)1446496932;
			short num2 = num;
			num = (short)1207749284;
			switch (num2 == num)
			{
			default:
			{
				num = (short)749862912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)824508416;
			if (num != 0)
			{
			}
			num = (short)1283194881;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x000A1150 File Offset: 0x0009F350
		internal static bool IsRSIDataUsedInCpg()
		{
			short num = (short)129232122;
			short num2 = num;
			num = (short)67824890;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2052587520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1085669377;
			if (num != 0)
			{
			}
			num = (short)962134016;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000A11FC File Offset: 0x0009F3FC
		internal static bool IsWifiCapabilityUsedInCpg()
		{
			short num = (short)1239022065;
			short num2 = num;
			num = (short)1247541745;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2127626240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1612185601;
			if (num != 0)
			{
			}
			num = (short)1440481280;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).WIFI.DataWideWIFIEnable_42506Value;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000A12C4 File Offset: 0x0009F4C4
		internal static bool IsDINCPlusUsedInCpg()
		{
			short num = (short)617283584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2096365571;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_19C;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (radioProfiles.AudioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292.Value != 4)
									{
										num = (short)338558986;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_181;
								}
								case 2:
									goto IL_2DB;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_12F;
									}
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291.Value == 4)
									{
										num = (short)1382285321;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)134610945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)195559436;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles = (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)enumerator.Current;
									num = (short)1172176907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)530120712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (!radioProfiles.AudioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.Value)
									{
										num = (short)1147600901;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_181;
								}
								case 9:
									goto IL_181;
								case 10:
									num = (short)380305412;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (!radioProfiles.AudioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.Value)
									{
										num = (short)1379991559;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_181;
								}
								case 12:
									num = (short)938606594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_12F;
								IL_181:
								result = true;
								num = (short)944701440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A1:
								num = (short)2046099462;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12F:
								goto IL_1A1;
							}
							IL_19C:
							return result;
							IL_2DB:
							return false;
						}
						finally
						{
							num = (short)120782849;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_34A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_313;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)445841408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_313:
								if (enumerator != null)
								{
									num = (short)1236467714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_34A:
								num = (short)1745064026;
								short num3 = num;
								num = (short)1526829146;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_313;
								default:
									goto IL_381;
								}
							}
							IL_381:
							num = (short)247988224;
							if (num != 0)
							{
							}
						}
						goto IL_398;
					case 1:
						if (radioProfilesRecset != null)
						{
							num = (short)178192385;
							if (num != 0)
							{
							}
							num = (short)1584332802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						goto IL_398;
					}
					goto IL_3A;
					IL_398:
					enumerator = radioProfilesRecset.GetEnumerator();
					num = (short)1456734208;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3A:
				radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
				num = (short)3080192;
				short num4 = num;
				num = (short)1503526913;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000A16AC File Offset: 0x0009F8AC
		internal static bool IsGroupServicesUsedInCpg()
		{
			short num = (short)527695872;
			short num2 = num;
			num = (short)1079508992;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
				for (;;)
				{
					IL_50:
					switch (num3)
					{
					case 0:
						try
						{
							num = (short)743768069;
							num3 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num3)
								{
								case 0:
									num = (short)1295843332;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_463;
								case 2:
									goto IL_4C9;
								case 3:
									goto IL_448;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem.Features.TrkSysFeaturesGroupTMSEable_42804.Value != 0)
									{
										num = (short)1136001027;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_3BF;
									}
									continue;
								case 6:
									num = (short)1350893570;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem.Features.TrkPerFeaturesOTARadioAliasType_42854.Value == 0)
									{
										num = (short)103874560;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_448;
								}
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1383268358;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
									num = (short)59310087;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_40E:
								num = (short)1802436616;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_3BF:
								goto IL_40E;
								IL_448:
								result = true;
								num = (short)565641217;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_463:
							return result;
							IL_4C9:
							return false;
						}
						finally
						{
							num = (short)777453569;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num3)
								{
								case 0:
									goto IL_535;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_500;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1743519744;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_500:
								if (enumerator == null)
								{
									break;
								}
								num = (short)830734338;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_535:;
						}
						goto Block_5;
					case 1:
						goto IL_538;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1985216513;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1246101506;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F2;
					case 4:
						try
						{
							num = (short)427753477;
							num3 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current).Features.CnvSysFeaturesGroupTMSEable_42809.Value != 0)
									{
										num = (short)2141519874;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)30015491;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1090060288;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									result = true;
									goto IL_1C1;
								case 3:
								{
									num = (short)291885048;
									short num4 = num;
									num = (short)1302056952;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1C1;
									default:
										num = (short)1506279424;
										if (num != 0)
										{
										}
										num = (short)618659844;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_281;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_173;
									}
									continue;
								case 6:
									goto IL_1D9;
								}
								goto IL_173;
								IL_1C1:
								num = (short)625737734;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DE:
								num = (short)2109210625;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_173:
								goto IL_1DE;
							}
							IL_1D9:
							return result;
							IL_281:
							goto IL_6AB;
						}
						finally
						{
							num = (short)1209532417;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num3)
								{
								case 0:
									goto IL_2EF;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2B9;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1695744000;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2B9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)550961154;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_2EF:;
						}
						goto IL_2F2;
					case 5:
						if (conventionalSystemRecset != null)
						{
							num = (short)17301511;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AB;
					case 6:
					{
						num = (short)1400700929;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSystemRecset.GetEnumerator();
						num = (short)1973420032;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalSystemRecset.GetEnumerator();
						num = (short)185532420;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (trunkingSystemRecset != null)
						{
							num = (short)347668486;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_7B;
					IL_2F2:
					num = (short)108789768;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_538:
						num = (short)805240837;
						num3 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_596;
							case 1:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current).Features.CnvPerFeaturesOTARadioAliasType_42784.Value != 0)
								{
									num = (short)1686700035;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)118751238;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)996409345;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								result = true;
								num = (short)1812725760;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_63A;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_57B;
								}
								continue;
							case 6:
								num = (short)1631911940;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_59B:
							num = (short)1902641154;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_57B:
							goto IL_59B;
						}
						IL_596:
						return result;
						IL_63A:
						goto IL_2F2;
					}
					finally
					{
						num = (short)1212416001;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num3)
							{
							case 0:
								goto IL_6A8;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_671;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)1059192832;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_671:
							if (enumerator == null)
							{
								break;
							}
							num = (short)736559106;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_6A8:;
					}
					IL_6AB:
					num = (short)1559756803;
					num3 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_7B:
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
				trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
				num = (short)1792868357;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000A1DF0 File Offset: 0x0009FFF0
		internal static bool IsDataModemUsedInCP(int DataModemType)
		{
			short num = (short)1066467328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset dataModemTableInnerRecset;
					object obj;
					switch (num2)
					{
					case 0:
						goto IL_CF;
					case 1:
					{
						num = (short)87818240;
						short num3 = num;
						enumerator = dataModemTableInnerRecset.GetEnumerator();
						num = (short)419299328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						obj = null;
						goto IL_37E;
					case 3:
						if (dataWide.ExternalDataModem.ModemConnectionType_43350 == 1)
						{
							num = (short)640221188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32D;
					case 4:
						num = (short)177864710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = dataWide.ExternalDataModem;
						if (externalDataModem == null)
						{
							num = (short)1986461698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj = externalDataModem.EmbeddedRecset;
						goto IL_37E;
					}
					case 6:
						if (dataModemTableInnerRecset != null)
						{
							num = (short)646447105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_4A;
					IL_37E:
					dataModemTableInnerRecset = (obj as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset);
					num = (short)1367408643;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CF:
				num = (short)1579876353;
				if (num != 0)
				{
				}
				try
				{
					num = (short)319356933;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)578420738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1362362372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_26E;
						case 3:
							result = true;
							num = (short)947257352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
							if (dataModemTableInner.DataModemTableInnerSection.DataWideExternalDataModemType_43362.Value == DataModemType)
							{
								num = (short)644939779;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_16F;
							}
							continue;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
							if (dataModemTableInner != null)
							{
								num = (short)314572801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1011613696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner;
							num = (short)837877766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_1C1;
						}
						IL_171:
						num = (short)97189895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_16F:
						goto IL_171;
					}
					IL_1C1:
					return result;
					IL_26E:
					return false;
				}
				finally
				{
					num = (short)807993345;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2E0;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2A5;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)389349376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2A5:
						if (enumerator != null)
						{
							num = (short)759037954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2E0:
						num = (short)362204097;
						short num4 = num;
						num = (short)796117953;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2A5;
						default:
							goto IL_315;
						}
					}
					IL_315:
					num = (short)728825856;
					if (num != 0)
					{
					}
				}
				IL_32D:
				return dataWide.ExternalDataModem.DataWideExternalDataModemType_42843.Value == DataModemType;
				IL_4A:
				dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
				num = (short)1765998597;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000A21EC File Offset: 0x000A03EC
		internal static bool IsMissionCriticalGeofenceUsedInCpg()
		{
			short num = (short)1444741120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				bool result;
				for (;;)
				{
					IL_27:
					num = (short)2099052545;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset missionCriticalGeofenceRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (missionCriticalGeofenceRecset != null)
						{
							num = (short)387842049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						goto IL_331;
					case 2:
						return result;
					case 3:
						if ((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Location.RadWideLocationSystemManagedGeofence_43042.Value)
						{
							num = (short)1109458949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						missionCriticalGeofenceRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4174) as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset);
						num = (short)1550057472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)1685520386;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_123;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									if (missionCriticalGeofence != null)
									{
										num = (short)444858373;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_121;
									}
									continue;
								case 3:
									goto IL_271;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									if (missionCriticalGeofence.General.McGeofenceExitAction_42888.Value > 0)
									{
										num = (short)1133903872;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)419364870;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									if (missionCriticalGeofence.General.McGeofenceEntryAction_42887.Value <= 0)
									{
										num = (short)2035286025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_123;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2111832074;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence = (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence)enumerator.Current;
									num = (short)500367361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_13A;
								case 9:
									num = (short)731119620;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)1447362563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_121;
								IL_123:
								result = true;
								num = (short)1771241480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13F:
								num = (short)2107703303;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_121:
								goto IL_13F;
							}
							IL_13A:
							IL_271:
							return result;
						}
						finally
						{
							for (;;)
							{
								IL_276:
								num = (short)653131778;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_32E;
									case 1:
										enumerator.Dispose();
										num = (short)108658688;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2A8;
										}
										continue;
									}
									IL_2A8:
									num = (short)1373499135;
									short num3 = num;
									num = (short)1369632511;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_276;
									default:
										num = (short)848494592;
										if (num != 0)
										{
										}
										if (enumerator == null)
										{
											goto IL_330;
										}
										num = (short)459472897;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
							}
							IL_32E:
							IL_330:;
						}
						goto IL_331;
					case 5:
						result = true;
						num = (short)1407975426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E;
					IL_331:
					num = (short)739115008;
					short num4 = num;
					enumerator = missionCriticalGeofenceRecset.GetEnumerator();
					num = (short)1228144644;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6E:
				result = false;
				num = (short)105250819;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x000A25FC File Offset: 0x000A07FC
		internal static bool IsNightVisionGoggleUsedInCpg()
		{
			short num = (short)53673984;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
			for (;;)
			{
				IL_33:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num3)
				{
				case 0:
					try
					{
						num = (short)1191182340;
						num3 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_193;
							case 1:
								num = (short)774832131;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								result = true;
								num = (short)1108082688;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_1B0;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_F3;
								}
								continue;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)484311041;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1811087366;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (((global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)enumerator.Current).General.RadProfNVGEnable_A41615.Value)
								{
									num = (short)208470018;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_13E:
							num = (short)454688773;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_F3:
							goto IL_13E;
						}
						IL_193:
						return result;
						IL_1B0:
						return false;
					}
					finally
					{
						for (;;)
						{
							IL_1B5:
							num = (short)264503298;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_267;
								case 1:
									enumerator.Dispose();
									num = (short)826671104;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1E6;
									}
									continue;
								}
								IL_1E6:
								num = (short)97603418;
								short num4 = num;
								num = (short)1813401434;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1B5;
								default:
									num = (short)205651968;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_269;
									}
									num = (short)423690241;
									num3 = (int)((global::System.IntPtr)num);
									break;
								}
							}
						}
						IL_267:
						IL_269:;
					}
					goto IL_26A;
				case 1:
					goto IL_26A;
				case 2:
					if (radioProfilesRecset != null)
					{
						num = (short)1454964737;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				goto IL_45;
				IL_26A:
				enumerator = radioProfilesRecset.GetEnumerator();
				num = (short)541786112;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_45:
			radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
			num = (short)836370433;
			if (num != 0)
			{
			}
			num = (short)1437270018;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000A28B8 File Offset: 0x000A0AB8
		internal static bool IsMultiSystemOTARUsedInCpg()
		{
			short num = (short)1150418944;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
			for (;;)
			{
				IL_33:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num3)
				{
				case 0:
					try
					{
						num = (short)1364721668;
						num3 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_161;
							case 1:
								num = (short)427360259;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								result = true;
								num = (short)1321730048;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_17D;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_C9;
								}
								continue;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)804126721;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)2036793350;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current).General.SecKmfProfGenIndependentKeyList_43597.Value)
								{
									num = (short)2023424002;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_112:
							num = (short)528809989;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_C9:
							goto IL_112;
						}
						IL_161:
						return result;
						IL_17D:
						return false;
					}
					finally
					{
						for (;;)
						{
							IL_182:
							num = (short)1434255362;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_236;
								case 1:
									enumerator.Dispose();
									num = (short)1312358400;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1B3;
									}
									continue;
								}
								IL_1B3:
								num = (short)1224439605;
								short num4 = num;
								num = (short)890009397;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_182;
								default:
									num = (short)71237632;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_238;
									}
									num = (short)1786970113;
									num3 = (int)((global::System.IntPtr)num);
									break;
								}
							}
						}
						IL_236:
						IL_238:;
					}
					goto IL_239;
				case 1:
					goto IL_239;
				case 2:
					if (secureKMFProfileRecset != null)
					{
						num = (short)2035613697;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				goto IL_45;
				IL_239:
				num = (short)97845249;
				if (num != 0)
				{
				}
				enumerator = secureKMFProfileRecset.GetEnumerator();
				num = (short)1276903424;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_45:
			secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
			num = (short)538509314;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000A2B5C File Offset: 0x000A0D5C
		internal static bool IsDesSwCryptoUsedInCpg()
		{
			short num;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				num = (short)685441025;
				if (num != 0)
				{
				}
				secureWide = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 3)
				{
					return false;
				}
				num = (short)2039111260;
				short num2 = num;
				num = (short)1354260060;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8B;
				}
			}
			IL_8B:
			num = (short)380698624;
			if (num != 0)
			{
			}
			num = (short)1155399680;
			short num3 = num;
			return secureWide.General.SecureWideDESAlgorithmEnable_43744.Value;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000A2C44 File Offset: 0x000A0E44
		internal static bool IsDVRSConScanUsedInCpg()
		{
			short num = (short)790233089;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
			bool result;
			try
			{
				num = (short)1494679554;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)2075918337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if ((conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262Value == 2)
						{
							num = (short)440795141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_BB;
						}
						continue;
					case 3:
						goto IL_210;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498 != 0)
						{
							num = (short)129630208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						result = true;
						num = (short)257097737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)957218820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1649606659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1613627399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
						num = (short)345899018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_155;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.Features.CnvPerLabtoolScanListSelection_A9054Value != 0)
						{
							num = (short)614400006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_BD:
					num = (short)1298989064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB:
					goto IL_BD;
				}
				IL_155:
				return result;
				IL_210:
				goto IL_3E;
			}
			finally
			{
				for (;;)
				{
					IL_215:
					num = (short)82706434;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2C7;
						case 1:
							enumerator.Dispose();
							num = (short)858259456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_245;
							}
							continue;
						}
						IL_245:
						num = (short)290998417;
						short num3 = num;
						num = (short)1682393233;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_215;
						default:
							num = (short)1711865856;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_2C9;
							}
							num = (short)377487361;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				IL_2C7:
				IL_2C9:;
			}
			return result;
			IL_3E:
			num = (short)1633550336;
			short num4 = num;
			return false;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000A2F38 File Offset: 0x000A1138
		internal static bool IsRegRegionEnabledETSIOption_43771()
		{
			short num = (short)1827269587;
			short num2 = num;
			num = (short)2020666323;
			switch (num2 == num)
			{
			}
			num = (short)979369985;
			if (num != 0)
			{
			}
			num = (short)2071330816;
			if (num != 0)
			{
			}
			num = (short)1280376832;
			short num3 = num;
			return true;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000A2FE0 File Offset: 0x000A11E0
		internal static bool IsGermanFedGovEnabledOptionUsedInCpg()
		{
			short num = (short)1332161320;
			short num2 = num;
			num = (short)695675688;
			switch (num2 == num)
			{
			}
			num = (short)1043660800;
			if (num != 0)
			{
			}
			num = (short)188284929;
			if (num != 0)
			{
			}
			num = (short)714014720;
			short num3 = num;
			return true;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000A3088 File Offset: 0x000A1288
		internal static bool IsViQi_VoiceControl()
		{
			short num = (short)178323457;
			if (num != 0)
			{
			}
			num = (short)1935055523;
			short num2 = num;
			num = (short)563387043;
			switch (num2 == num)
			{
			}
			num = (short)1792737280;
			if (num != 0)
			{
			}
			num = (short)1953693696;
			short num3 = num;
			return true;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000A3134 File Offset: 0x000A1334
		internal static bool isAtakHOption()
		{
			short num = (short)589543624;
			short num2 = num;
			num = (short)407156936;
			switch (num2 == num)
			{
			}
			num = (short)1429340161;
			if (num != 0)
			{
			}
			num = (short)1411579904;
			if (num != 0)
			{
			}
			num = (short)614727680;
			short num3 = num;
			return true;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000A31E0 File Offset: 0x000A13E0
		internal static bool isVoiceControlBasic()
		{
			short num = (short)1612948176;
			short num2 = num;
			num = (short)253338320;
			switch (num2 == num)
			{
			}
			num = (short)1035993088;
			if (num != 0)
			{
			}
			num = (short)23527425;
			if (num != 0)
			{
			}
			num = (short)1005191168;
			short num3 = num;
			return true;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000A3290 File Offset: 0x000A1490
		internal static bool isAdaptiveSpeakerVolumeHOption()
		{
			short num = (short)1836029224;
			short num2 = num;
			num = (short)823366952;
			switch (num2 == num)
			{
			}
			num = (short)712441857;
			if (num != 0)
			{
			}
			num = (short)789643264;
			if (num != 0)
			{
			}
			num = (short)1929314304;
			short num3 = num;
			return true;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000A3338 File Offset: 0x000A1538
		internal static bool isLTEHwEnablement()
		{
			short num = (short)2044633882;
			short num2 = num;
			num = (short)1918280474;
			switch (num2 == num)
			{
			}
			num = (short)751632384;
			if (num != 0)
			{
			}
			num = (short)920977409;
			if (num != 0)
			{
			}
			num = (short)1495597056;
			short num3 = num;
			return true;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000A33E0 File Offset: 0x000A15E0
		internal static bool isTacticalServicesHOption()
		{
			short num = (short)1317815233;
			short num2 = num;
			num = (short)1533100993;
			switch (num2 == num)
			{
			}
			num = (short)368640000;
			if (num != 0)
			{
			}
			num = (short)1345978369;
			if (num != 0)
			{
			}
			num = (short)276103168;
			short num3 = num;
			return true;
		}
	}
}
