using System;
using System.Collections;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUtility;
using CommonResources;
using ConstraintHelper;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.Model_Configuration;
using SpecialFeatures.Ucl.Contact;
using SpecialFeatures.VoiceAnnouncements.List;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x0200017F RID: 383
	public static class AllowCloning
	{
		// Token: 0x060012CF RID: 4815 RVA: 0x001A4CA8 File Offset: 0x001A2EA8
		public static bool AllowClone(global::SpecialFeatures.Clone_Configuration.Common.CodeplugData srcData, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData targetData, bool isPortable, ref string stsErrorMsg)
		{
			short num = (short)1405091840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				bool flag;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)706150417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_450;
					case 2:
						return flag;
					case 3:
						goto IL_49C;
					case 4:
					{
						num = (short)2103246848;
						short num3 = num;
						int num4;
						if (num4 >= 24)
						{
							num = (short)831520768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2103181327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						byte[] array = new byte[25];
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(srcData.usedFlashcode, ref array);
						byte[] array2 = new byte[25];
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(targetData.purchasedFlashcode, ref array2);
						flag = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.AllowCloneSpecialCases(srcData, targetData, ref array, isPortable, ref stsErrorMsg);
						num = (short)935460884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)511311886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						int num4 = 0;
						num = (short)1694826514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1632829459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (srcData.usedFlashcode != targetData.purchasedFlashcode)
						{
							num = (short)848035845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_548;
					case 10:
					{
						byte[] array;
						global::System.Collections.BitArray bitArray = new global::System.Collections.BitArray(array);
						byte[] array2;
						global::System.Collections.BitArray value = new global::System.Collections.BitArray(array2);
						global::System.Collections.BitArray bitArray2 = bitArray.Or(value).Xor(value);
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = null;
						num = (short)233832460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (srcData.purchasedFlashcode != targetData.purchasedFlashcode)
						{
							num = (short)2059010061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_548;
					case 12:
						try
						{
							num = (short)1968373764;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
								global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable2;
								global::System.Collections.IEnumerator enumerator;
								int num5;
								int num6;
								string str;
								switch (num2)
								{
								case 0:
									flashcodeTable2 = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
									goto IL_36F;
								case 1:
									num = (short)928186370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									flashcodeTable2 = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(isPortable, false);
									goto IL_36F;
								case 3:
									try
									{
										num = (short)2093613065;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												if ((bool)enumerator.Current)
												{
													num = (short)608567301;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_258;
											case 1:
												if (num5 == 8)
												{
													num = (short)274661384;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 2:
												goto IL_258;
											case 4:
												goto IL_2F3;
											case 5:
												str = flashcodeTable.GetOptionsInOffset(num6, num5);
												stsErrorMsg += str;
												num = (short)648609794;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												num = (short)1446576132;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												if (!enumerator.MoveNext())
												{
													num = (short)1850736646;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1791426560;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												num5 = 0;
												num6++;
												num = (short)2127167491;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												switch (0)
												{
												case 0:
													goto IL_1BB;
												}
												continue;
											}
											goto IL_1BB;
											IL_258:
											num5++;
											num = (short)1006305281;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_299:
											num = (short)1699348487;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1BB:
											goto IL_299;
										}
										IL_2F3:
										goto IL_CD;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_315;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_302:
											switch (num2)
											{
											case 0:
												if (disposable != null)
												{
													num = (short)775684098;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_36E;
											case 1:
												goto IL_36C;
											case 2:
												disposable.Dispose();
												num = (short)1892220929;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_315;
										}
										IL_36C:
										IL_36E:
										goto EndFinally_18;
										IL_315:
										disposable = (enumerator as global::System.IDisposable);
										num = (short)158859264;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_302;
										EndFinally_18:;
									}
									goto IL_36F;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_129;
									}
									continue;
								}
								IL_129:
								if (srcData._data != null)
								{
									num = (short)1476198401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1996292096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_36F:
								flashcodeTable = flashcodeTable2;
								str = string.Empty;
								flashcodeTable.InitTable(srcData._data == null, srcData.modelNumber, false);
								num5 = 0;
								num6 = 1;
								stsErrorMsg = global::CommonResources.AppResources.Failure_due_to_mismatch_of_Codeplug_Used_FLASHcode_and_Radio_FLASHcode;
								global::System.Collections.BitArray bitArray2;
								enumerator = bitArray2.GetEnumerator();
								num = (short)2103050243;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						finally
						{
							num = (short)207683584;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_413;
									}
									continue;
								case 1:
									goto IL_44D;
								case 2:
									flashcodeTable.Dispose();
									flashcodeTable = null;
									num = (short)1602158593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_413:
								if (flashcodeTable == null)
								{
									break;
								}
								num = (short)173408258;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_44D:;
						}
						goto IL_450;
						IL_CD:
						flag = false;
						num = (short)92078096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)625213449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeValidator.Validate(targetData.purchasedFlashcode))
						{
							num = (short)369098753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 15:
					{
						int num4;
						byte[] array;
						byte[] array2;
						if ((array[num4] | array2[num4]) != array2[num4])
						{
							goto IL_5DB;
						}
						num4++;
						num = (short)335609859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						return flag;
					case 17:
						return flag;
					case 18:
						goto IL_49C;
					case 19:
						num = (short)90898433;
						if (num != 0)
						{
						}
						if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeValidator.Validate(srcData.usedFlashcode))
						{
							num = (short)453050374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 20:
						if (flag)
						{
							num = (short)393936903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 21:
						if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeValidator.Validate(srcData.purchasedFlashcode))
						{
							num = (short)672071688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					goto IL_87;
					IL_450:
					num = (short)2057437195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49C:
					num = (short)520093700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_548:
					num = (short)1283850712;
					short num7 = num;
					num = (short)87425496;
					switch ((num7 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_5DB:
						num = (short)2093350922;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)179896320;
						if (num != 0)
						{
						}
						flag = true;
						num = (short)825360386;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return flag;
				IL_87:
				flag = false;
				num = (short)292093973;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x001A54A8 File Offset: 0x001A36A8
		public static bool ModelNumberCheck(string sourceModel, string targetModel, bool isPortable, ref string stsErrorMsg)
		{
			int num;
			string text;
			string text2;
			short num2;
			bool flag;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_1E8;
					case 1:
						goto IL_312;
					case 2:
						if (string.Compare(text, 0, text2, 0, 3) != 0)
						{
							num2 = (short)477167621;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1310195715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (!global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelHighPower(text))
						{
							num2 = (short)743571462;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_312;
					case 4:
						goto IL_258;
					case 5:
						flag = false;
						num2 = (short)964427776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						num2 = (short)1406795786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						num2 = (short)1859387406;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						goto IL_1E8;
					case 9:
						stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_due_to_the_incompatibility_between_source_and_models;
						num2 = (short)2001534993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
					{
						num2 = (short)873332736;
						short num3 = num2;
						if (!global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelHighPower(text2))
						{
							num2 = (short)841285633;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_258;
					}
					case 11:
						if (text != text2)
						{
							num2 = (short)1068892167;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1E8;
					case 12:
						if (!flag)
						{
							num2 = (short)124387337;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return flag;
					case 13:
						if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelHighPower(text))
						{
							num2 = (short)1097924624;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1E8;
					case 14:
						if (isPortable)
						{
							num2 = (short)170524691;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1331822594;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 15:
						if (!global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelHighPower(text2))
						{
							num2 = (short)2087321604;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1E8;
					case 16:
						num2 = (short)1785462785;
						if (num2 != 0)
						{
						}
						num2 = (short)1615659023;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 17:
						return flag;
					case 18:
						goto IL_1E8;
					case 19:
					{
						flag = false;
						num2 = (short)1454790138;
						short num4 = num2;
						num2 = (short)1056265722;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_70;
						default:
							num2 = (short)1238106112;
							if (num2 != 0)
							{
							}
							num2 = (short)1448542216;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_60;
					IL_1E8:
					num2 = (short)1807024140;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_258:
					flag = false;
					num2 = (short)958398482;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_312:
					num2 = (short)1096744973;
					num = (int)((global::System.IntPtr)num2);
				}
				return flag;
			}
			IL_60:
			flag = true;
			text = sourceModel.Trim();
			text2 = targetModel.Trim();
			IL_70:
			num2 = (short)278462475;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x001A5828 File Offset: 0x001A3A28
		public static bool IsModelDualBand(string modelNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					if (modelNumber.Trim()[3] != 'T')
					{
						return result;
					}
					num2 = (short)1573774130;
					short num3 = num2;
					num2 = (short)1813177138;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
					{
						num2 = (short)1716256769;
						if (num2 != 0)
						{
						}
						num2 = (short)610009088;
						if (num2 != 0)
						{
						}
						num2 = (short)54853632;
						short num4 = num2;
						num2 = (short)401670146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					result = true;
					goto IL_FD;
				}
				goto IL_1C;
				IL_FD:
				num2 = (short)164954112;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			result = false;
			num2 = (short)72155137;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x001A5950 File Offset: 0x001A3B50
		public static bool IsModelSingleBand(string modelNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_EB;
				case 1:
				{
					if (modelNumber.Trim()[3] == 'T')
					{
						return result;
					}
					num2 = (short)866370356;
					short num3 = num2;
					num2 = (short)359646004;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D3;
					default:
						num2 = (short)1839333376;
						if (num2 != 0)
						{
						}
						num2 = (short)1327759362;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
				{
					num2 = (short)2131951616;
					short num4 = num2;
					result = true;
					goto IL_D3;
				}
				}
				goto IL_1C;
				IL_D3:
				num2 = (short)84803584;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EB:
			num2 = (short)269811713;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			result = false;
			num2 = (short)691863553;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x001A5A74 File Offset: 0x001A3C74
		public static bool IsModelHighPower(string modelNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			string text;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)856162304;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)877039493;
					short num4 = num;
					num = (short)1639288709;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						goto IL_107;
					}
					break;
				}
				case 1:
					goto IL_B8;
				case 2:
					if (text[4] == 'T')
					{
						goto IL_141;
					}
					return result;
				case 3:
					if (text[4] != 'X')
					{
						num = (short)1615003652;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
				case 4:
					num = (short)609681409;
					if (num != 0)
					{
					}
					num = (short)1747058690;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_B8:
				result = true;
				num = (short)194445312;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_141:
				num = (short)117309441;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_107:
			num = (short)1279328256;
			if (num != 0)
			{
			}
			return result;
			IL_4D:
			result = false;
			text = modelNumber.Trim();
			num = (short)1518993411;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x001A5BE0 File Offset: 0x001A3DE0
		public static bool AllowCloneSpecialCases(global::SpecialFeatures.Clone_Configuration.Common.CodeplugData srcData, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData targetData, ref byte[] srcUsedBytes, bool isPortable, ref string stsErrorMsg)
		{
			int a_ = 9;
			short num = (short)331546624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_168;
				}
				int num3;
				bool flag;
				bool flag2;
				int num4;
				int num5;
				int num6;
				bool flag3;
				int num7;
				int num8;
				int num9;
				int num10;
				int num11;
				int num12;
				int num13;
				string name;
				string text;
				string text2;
				string text3;
				string text4;
				int num14;
				bool flag4;
				int num15;
				int num16;
				int num17;
				int num19;
				bool flag5;
				int num20;
				bool flag6;
				bool flag7;
				int num21;
				bool flag8;
				int num22;
				bool flag9;
				string text6;
				string text7;
				string text8;
				bool flag11;
				string text11;
				bool flag12;
				int num23;
				for (;;)
				{
					IL_31:
					global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
					switch (num2)
					{
					case 0:
						if (num3 != -1)
						{
							num = (short)1791033360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FAA;
					case 1:
						if (flag)
						{
							num = (short)1278148673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 2:
						if (num4 != -1)
						{
							num = (short)1411055679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A6;
					case 3:
						srcUsedBytes[num5] &= (byte)(~(byte)num6);
						num = (short)1809383453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_9A7;
					case 5:
						if (flag3)
						{
							num = (short)1187250185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BB;
					case 6:
						srcUsedBytes[num7] &= (byte)(~(byte)num8);
						num = (short)540672022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1802764334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						srcUsedBytes[num9] &= (byte)(~(byte)num10);
						num = (short)2041970699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1063452691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)487587890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_900;
					case 12:
						num = (short)733872128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_795;
					case 14:
						srcUsedBytes[num11] &= (byte)(~(byte)num12);
						num = (short)2020212769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (num12 != -1)
						{
							num = (short)1763901492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 16:
						srcUsedBytes[num3] &= (byte)(~(byte)num13);
						num = (short)71696420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						name = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋뮍ꆏ", a_);
						text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋뮍ꂏ", a_);
						text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋쾍ꂏꎑꎓꆕꢗ", a_);
						text3 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋쾍ꂏꎑꎓꆕꦗ", a_);
						text4 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋뮍ꂏꖑ", a_);
						num = (short)356122628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (num9 != -1)
						{
							num = (short)170852360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_900;
					case 19:
						if (num8 != -1)
						{
							num = (short)1109917768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BB;
					case 20:
						num = (short)209846347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (num14 != -1)
						{
							num = (short)1563689014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F7;
					case 22:
						goto IL_2BB;
					case 23:
						if (flag4)
						{
							num = (short)1029636141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_795;
					case 24:
						if (num15 != -1)
						{
							num = (short)815267893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_795;
					case 25:
						goto IL_2F7;
					case 26:
						if (num16 != -1)
						{
							num = (short)706412613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_795;
					case 27:
						if (num17 != -1)
						{
							num = (short)127860800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F7;
					case 28:
						if (num10 != -1)
						{
							num = (short)643498043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_900;
					case 29:
						goto IL_2E4C;
					case 30:
						num = (short)142278698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						num = (short)890250291;
						short num18 = num;
						num = (short)98706483;
						switch ((num18 == num) ? 1 : 0)
						{
						case 0:
						case 2:
						{
							bool result;
							return result;
						}
						default:
							num = (short)174915584;
							if (num != 0)
							{
							}
							num = (short)889389084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 32:
						if (num19 != -1)
						{
							num = (short)1162346503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A07;
					case 33:
						return flag2;
					case 34:
						if (targetData.modelNumber.StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒋랍ꞏ", a_)) && flag5)
						{
							num = (short)1502085181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A07;
					case 35:
						num = (short)2133393410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_2FAA;
					case 37:
						if (num20 != -1)
						{
							num = (short)629407817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F6E;
					case 38:
						if (flag6)
						{
							num = (short)1829306428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4C;
					case 39:
						goto IL_A07;
					case 40:
						if (flag7)
						{
							num = (short)298778654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FAA;
					case 41:
						num = (short)1151664165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (num13 != -1)
						{
							num = (short)1366687756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FAA;
					case 43:
						num = (short)290390087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						srcUsedBytes[num21] &= (byte)(~(byte)num19);
						num = (short)628752423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)2019360792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (num21 != -1)
						{
							num = (short)1367081004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A07;
					case 47:
						if (num11 != -1)
						{
							num = (short)760283150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 48:
						if (num7 != -1)
						{
							num = (short)369033222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BB;
					case 49:
						if (flag8)
						{
							num = (short)79298603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A6;
					case 50:
						if (num22 != -1)
						{
							num = (short)654114857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F6E;
					case 51:
						if (flag2)
						{
							num = (short)409534531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 52:
						num = (short)324796463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						num = (short)1787035674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						num = (short)138936347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						num = (short)1650065429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_2F6E;
					case 57:
						goto IL_3A6;
					case 58:
						num = (short)422510593;
						if (num != 0)
						{
						}
						if (flag9)
						{
							num = (short)213712951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F7;
					case 59:
						num = (short)2134114322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						num = (short)1841889350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)1177813024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						try
						{
							num = (short)1561264310;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								bool flag10;
								string optName;
								global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable2;
								bool a_2;
								switch (num2)
								{
								case 0:
								{
									string text5;
									if (flashcodeTable.IsOptionEnabledInFlashcode(text5, srcData.usedFlashcode, ref flag10))
									{
										num = (short)748093444;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E8D;
								}
								case 1:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text6, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1363214364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1914;
								case 2:
									goto IL_2237;
								case 3:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text4, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)676200594;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_22C7;
								case 4:
									num = (short)493289490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text7, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1359806641;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CE3;
								case 6:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꂑ꒓ꚕ꺗", a_), targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)721158309;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18D7;
								case 7:
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_from_a_NVG_radio;
									result = false;
									num = (short)2084307143;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꂑ꒓ꚕ꺗", a_), targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)575340699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CC9;
								case 9:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text8, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1666383966;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DBE;
								case 10:
									goto IL_248B;
								case 11:
									flag2 = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.AllowEnhLevel2Clone(flashcodeTable, srcData, targetData);
									num = (short)2091909315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (isPortable)
									{
										num = (short)1804206097;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_28AD;
								case 13:
									num = (short)1582694435;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋뾍ꎏꪑ", a_), srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1407516823;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_278A;
								case 15:
									goto IL_18D7;
								case 16:
									flag2 = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.AllowEnhLevel1Clone(flashcodeTable, srcData, targetData);
									num = (short)306053168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									num = (short)1018429634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									string name2;
									if (flashcodeTable.IsOptionEnabledInFlashcode(name2, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)1306525852;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E8D;
								}
								case 19:
									num = (short)1829437538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text7, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)818741280;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CE3;
								case 21:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b붍ꚏꎑ", a_), srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)241696877;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1160;
								case 22:
									if (!isPortable)
									{
										num = (short)859045918;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27A7;
								case 23:
									goto IL_27A7;
								case 24:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꂑ꒓ꚕ꺗", a_), srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)348127358;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18D7;
								case 25:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text6, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)239337655;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1914;
								case 26:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text4, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1220345946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_22C7;
								case 27:
									num = (short)1414135956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									num = (short)766705689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꊑꆓꆕ꾗", a_), targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)227672152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B82;
								case 30:
									num = (short)1818165339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(name, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)1584726100;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2009;
								case 32:
									num = (short)1596915888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text2, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1562050661;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_19E3;
								case 34:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)2087649336;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D3E;
								case 35:
									if (isPortable)
									{
										num = (short)262733917;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag2 = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.AllowFrequencyCloneMobile(flashcodeTable, srcData, targetData);
									num = (short)28311689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									num22 = flashcodeTable.FLASHcode.GetOptionMask(text4);
									num20 = flashcodeTable.FLASHcode.GetOptionBytePosition(text4) - 1;
									flag11 = true;
									num = (short)366215346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
									if (optionByName != null)
									{
										num = (short)1248329847;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_because_the_number_of_records_feature_in_target.AcpStringFormat(new object[]
									{
										text2
									});
									num = (short)1020985441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 38:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName2;
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_because_the_number_of_records_feature_in_target.AcpStringFormat(new object[]
									{
										optionByName2.ToString()
									});
									num = (short)372637760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 39:
									if (!flag2)
									{
										num = (short)315686969;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F24;
								case 40:
								{
									string text5 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8b랍ꚏꮑ", a_);
									string name2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋벍ꦏꪑ", a_);
									string text9 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋쾍ꂏꎑꎓꂕ꾗", a_);
									num = (short)234422415;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 41:
									if (flag2)
									{
										num = (short)1581645843;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18D7;
								case 42:
								{
									string text10;
									if (flashcodeTable.IsOptionEnabledInFlashcode(text10, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)497156139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2701;
								}
								case 43:
								{
									string text10;
									num19 = flashcodeTable.FLASHcode.GetOptionMask(text10);
									num21 = flashcodeTable.FLASHcode.GetOptionBytePosition(text10) - 1;
									flag5 = true;
									num = (short)44302441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 44:
									num = (short)2090401919;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.a(srcData.modelNumber))
									{
										num = (short)2077753523;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DBE;
								case 46:
									num = (short)2053832771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
									if (!flag2)
									{
										num = (short)354156697;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_248B;
								case 48:
								{
									if (flag2)
									{
										num = (short)1665204274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName3 = flashcodeTable.FLASHcode.GetOptionByName(text2);
									num = (short)873857101;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 49:
									num = (short)1314979944;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
									num13 = flashcodeTable.FLASHcode.GetOptionMask(text2);
									num3 = flashcodeTable.FLASHcode.GetOptionBytePosition(text2) - 1;
									flag7 = true;
									num = (short)978256014;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 51:
									flag2 = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.b(flashcodeTable, srcData, targetData);
									num = (short)1442316335;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 52:
									num = (short)371982410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
									goto IL_1160;
								case 54:
									num = (short)1973223536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 55:
									flag2 = false;
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_from_a_trunking;
									num = (short)279904446;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 56:
									flag2 = false;
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_from_a_Trunking_SmartZone;
									num = (short)104792216;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 57:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName = flashcodeTable.FLASHcode.GetOptionByName(text2);
									num = (short)784465957;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 58:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text11, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1683685545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1AFC;
								case 59:
									num10 = flashcodeTable.FLASHcode.GetOptionMask(text);
									num9 = flashcodeTable.FLASHcode.GetOptionBytePosition(text) - 1;
									flag12 = true;
									num = (short)710213804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 60:
									goto IL_1422;
								case 61:
									if (flag2)
									{
										num = (short)630063117;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11F7;
								case 62:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)812974160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2009;
								case 63:
								{
									string text5 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒋뚍ꚏꮑ", a_);
									string name2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b몍ꦏꪑ", a_);
									string text9 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꎑꎓꂕ꾗", a_);
									string text10 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꎑꎓꂕꂗ", a_);
									num = (short)868941955;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 64:
									goto IL_1F24;
								case 65:
									if (flashcodeTable.IsOptionEnabledInFlashcode(name, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)964296763;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F62;
								case 66:
									goto IL_2885;
								case 67:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text4, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)468516900;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29FD;
								case 68:
									num = (short)661192725;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 69:
									flag = true;
									optName = text8;
									num = (short)445644916;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 70:
									num = (short)809173158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 71:
									goto IL_1F24;
								case 72:
									goto IL_2DD7;
								case 73:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text7, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1867972657;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_274E;
								case 74:
									flashcodeTable2 = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(isPortable, false);
									goto IL_17F0;
								case 75:
									if (flag2)
									{
										num = (short)2023358648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_22C7;
								case 76:
									optName = text11;
									num = (short)1410138172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 77:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName3;
									if (optionByName3 != null)
									{
										num = (short)1741488260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_because_the_number_of_records_feature.AcpStringFormat(new object[]
									{
										text2
									});
									num = (short)383451261;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 78:
								{
									bool flag13;
									if (!flag13)
									{
										num = (short)1834156048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_19E3;
								}
								case 79:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꊑꆓꆕ꾗", a_), srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1759772795;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B82;
								case 80:
									goto IL_1389;
								case 81:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text4, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1422655534;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29FD;
								case 82:
									num = (short)1753612350;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 83:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName4;
									if (optionByName4 != null)
									{
										num = (short)2125332597;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_because_the_number_of_records_feature.AcpStringFormat(new object[]
									{
										text3
									});
									num = (short)1997799532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 84:
									num = (short)821428339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 85:
									if (flag2)
									{
										num = (short)2084044941;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D3E;
								case 86:
								{
									string text5;
									if (flashcodeTable.IsOptionEnabledInFlashcode(text5, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)729743527;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1E8D;
								}
								case 87:
									num = (short)57475117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 88:
									goto IL_2CF0;
								case 89:
									flag2 = false;
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_from_non_APX_Lite_model_to_APX_Lite_model;
									num = (short)1302593635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 90:
									num = (short)1777598467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 91:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋뾍ꎏꪑ", a_), srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1532493868;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_ECF;
								case 92:
									num8 = flashcodeTable.FLASHcode.GetOptionMask(text3);
									num7 = flashcodeTable.FLASHcode.GetOptionBytePosition(text3) - 1;
									flag3 = true;
									num = (short)1347813478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 93:
									flag2 = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.AllowFrequencyClonePortable(flashcodeTable, srcData, targetData);
									num = (short)1596457123;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 94:
									goto IL_1AFC;
								case 95:
									goto IL_1961;
								case 96:
								{
									string text9;
									num15 = flashcodeTable.FLASHcode.GetOptionMask(text9);
									num16 = flashcodeTable.FLASHcode.GetOptionBytePosition(text9) - 1;
									flag4 = true;
									num = (short)1915158530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 97:
									goto IL_1F24;
								case 98:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꂑ꒓ꚕ꺗", a_), srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)860422284;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2920;
								case 99:
									goto IL_21FA;
								case 100:
									if (flag2)
									{
										num = (short)498925595;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2009;
								case 101:
									num = (short)227475534;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 102:
									goto IL_1F24;
								case 103:
									goto IL_1E8D;
								case 104:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text7, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)27000965;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_274E;
								case 105:
									goto IL_2701;
								case 106:
									if (flag2)
									{
										num = (short)740360373;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21FA;
								case 107:
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_to_a_12_5;
									num = (short)1548157039;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 108:
									goto IL_1F24;
								case 109:
									num = (short)1048641674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 110:
									goto IL_1F24;
								case 111:
									goto IL_22C7;
								case 112:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text6, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)1535836249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21FA;
								case 113:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text8, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)106233925;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DBE;
								case 114:
									num = (short)1170276386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 115:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)1380188215;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2009;
								case 116:
									if (isPortable)
									{
										num = (short)171573324;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1422;
								case 117:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName4;
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_because_the_number_of_records_feature.AcpStringFormat(new object[]
									{
										optionByName4.ToString()
									});
									num = (short)1627127997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 118:
									if (flashcodeTable.IsOptionEnabledInFlashcode(name, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1283194994;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D3E;
								case 119:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_because_the_number_of_records_feature_in_target.AcpStringFormat(new object[]
									{
										optionByName.ToString()
									});
									num = (short)246153326;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 120:
								{
									bool flag13;
									bool flag14;
									if (!flag14 && flag13)
									{
										num = (short)1981612161;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1434517625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 121:
								{
									bool flag15;
									bool flag16;
									if (!flag15 && flag16)
									{
										num = (short)1804206091;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F24;
								}
								case 122:
									num = (short)780927041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 123:
									num = (short)366673949;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 124:
									flashcodeTable2 = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
									goto IL_17F0;
								case 125:
									goto IL_1F24;
								case 126:
									num = (short)1951924230;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 127:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋뾍ꎏꪑ", a_), targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)104661160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2885;
								case 128:
									num = (short)926875808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 129:
									flag2 = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.AllowEnhLevel1Clone(flashcodeTable, srcData, targetData);
									num = (short)177995815;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 130:
									if (flag2)
									{
										num = (short)54526022;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_28AD;
								case 131:
									if (!isPortable)
									{
										num = (short)1844248616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2AA0;
								case 132:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName3;
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_because_the_number_of_records_feature.AcpStringFormat(new object[]
									{
										optionByName3.ToString()
									});
									num = (short)1651048519;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 133:
									num6 = flashcodeTable.FLASHcode.GetOptionMask(text7);
									num5 = flashcodeTable.FLASHcode.GetOptionBytePosition(text7) - 1;
									flag6 = true;
									num = (short)688980143;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 134:
									if (flag2)
									{
										num = (short)916127880;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F24;
								case 135:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋뾍ꎏꪑ", a_), targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)1285161026;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_278A;
								case 136:
								{
									bool flag16 = flashcodeTable.IsOptionEnabledInFlashcode(text3, targetData.purchasedFlashcode, ref flag10);
									bool flag13 = flashcodeTable.IsOptionEnabledInFlashcode(text2, targetData.purchasedFlashcode, ref flag10);
									bool flag14 = flashcodeTable.IsOptionEnabledInFlashcode(text2, srcData.purchasedFlashcode, ref flag10);
									bool flag15 = flashcodeTable.IsOptionEnabledInFlashcode(text3, srcData.purchasedFlashcode, ref flag10);
									num = (short)1218642078;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 137:
									goto IL_1749;
								case 138:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋붍ꚏꎑ", a_), srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)909180981;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CE3;
								case 139:
									goto IL_2DBE;
								case 140:
									num = (short)95617032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 141:
									num = (short)682819702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 142:
									goto IL_1F24;
								case 143:
									goto IL_2AA0;
								case 144:
									if (!flag2)
									{
										num = (short)1115357329;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11F7;
								case 145:
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_due_to_the_incompatibility;
									num = (short)1229717677;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 146:
									flag2 = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.a(flashcodeTable, targetData.purchasedFlashcode, a_2, isPortable);
									num = (short)1892286626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 147:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName2;
									if (optionByName2 != null)
									{
										num = (short)2146566182;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_because_the_number_of_records_feature_in_target.AcpStringFormat(new object[]
									{
										text3
									});
									num = (short)55967894;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 148:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(name, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)358678610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1389;
								case 149:
									goto IL_1914;
								case 150:
									goto IL_1F24;
								case 151:
									num = (short)1848377479;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 152:
									goto IL_2D3E;
								case 153:
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_due_to_G857_incompatibility;
									num = (short)360906762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 154:
									goto IL_1CE3;
								case 155:
									goto IL_2920;
								case 156:
								{
									string text5;
									num14 = flashcodeTable.FLASHcode.GetOptionMask(text5);
									num17 = flashcodeTable.FLASHcode.GetOptionBytePosition(text5) - 1;
									flag9 = true;
									num = (short)1787822183;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 157:
									num = (short)738721956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 158:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text3, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)131334272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_133D;
								case 159:
									if (flag2)
									{
										num = (short)987299891;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_248B;
								case 160:
								{
									bool flag16;
									if (!flag16)
									{
										num = (short)1403584704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_133D;
								}
								case 161:
									if (flag2)
									{
										num = (short)306708548;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CE3;
								case 162:
									if (!flag2)
									{
										num = (short)1185611883;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_22C7;
								case 163:
									goto IL_1749;
								case 164:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꊑꆓꆕ꾗", a_), targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)407306410;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CF0;
								case 165:
									goto IL_2CC9;
								case 166:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏ꒑궓꺕궗", a_), srcData.purchasedFlashcode, ref flag10) != flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏ꒑궓꺕궗", a_), targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)527302663;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_28AD;
								case 167:
									num = (short)1927413760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 168:
									goto IL_ECF;
								case 169:
									num = (short)1652621321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 170:
									goto IL_1DF2;
								case 171:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text6, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)244973622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21FA;
								case 172:
									goto IL_1F62;
								case 173:
									goto IL_11F7;
								case 174:
									if (flashcodeTable.IsOptionEnabledInFlashcode(text, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)1634533498;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F62;
								case 175:
									goto IL_274E;
								case 176:
									if (!global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.a(srcData))
									{
										num = (short)341311681;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CE3;
								case 177:
									num = (short)1707999252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 178:
									goto IL_29FD;
								case 179:
									num = (short)249102394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 180:
									goto IL_1961;
								case 181:
									num = (short)1900478635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 182:
									switch (0)
									{
									case 0:
										goto IL_E70;
									}
									continue;
								case 183:
									num23 = flashcodeTable.FLASHcode.GetOptionMask(text6);
									num4 = flashcodeTable.FLASHcode.GetOptionBytePosition(text6) - 1;
									flag8 = true;
									num = (short)2130641045;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 184:
									num = (short)991887386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 185:
								{
									if (flag2)
									{
										num = (short)1199636572;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName4 = flashcodeTable.FLASHcode.GetOptionByName(text3);
									num = (short)591134803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 186:
									num = (short)12451953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 187:
									if (flag2)
									{
										num = (short)364249175;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DBE;
								case 188:
								{
									global::SpecialFeatures.Flashport.FlashRadio.Option optionByName2 = flashcodeTable.FLASHcode.GetOptionByName(text3);
									num = (short)918618259;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 189:
									goto IL_1F24;
								case 190:
									goto IL_2009;
								case 191:
									goto IL_27A7;
								case 192:
									flag2 = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.AllowEnhLevel2Clone(flashcodeTable, srcData, targetData);
									num = (short)1830879417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 193:
									flag2 = false;
									stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_source_has_36009600_trunking_target_single_trunking;
									num = (short)1217200282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 194:
									if (flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꊑꆓꆕ꾗", a_), srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)2013003933;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DF2;
								case 195:
									if (!flag2)
									{
										num = (short)44171452;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F24;
								case 196:
									if (flag2)
									{
										num = (short)578420799;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_274E;
								case 197:
								{
									string text9;
									if (flashcodeTable.IsOptionEnabledInFlashcode(text9, srcData.purchasedFlashcode, ref flag10))
									{
										num = (short)273285216;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2237;
								}
								case 198:
									if (!flashcodeTable.IsOptionEnabledInFlashcode(text11, targetData.purchasedFlashcode, ref flag10))
									{
										num = (short)1760166074;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DBE;
								case 199:
									goto IL_115B;
								}
								IL_E70:
								if (srcData._data != null)
								{
									num = (short)259719220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)346357884;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ECF:
								num = (short)449904654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1160:
								num = (short)1894121477;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11F7:
								num = (short)1286471755;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_133D:
								num = (short)356909089;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1389:
								num = (short)872742943;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1422:
								num12 = flashcodeTable.FLASHcode.GetOptionMask(optName);
								num11 = flashcodeTable.FLASHcode.GetOptionBytePosition(optName) - 1;
								num = (short)1952972939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1749:
								num = (short)1774059664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17F0:
								flashcodeTable = flashcodeTable2;
								flashcodeTable.InitTable(srcData._data == null, srcData.modelNumber, false);
								flag10 = false;
								a_2 = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.b(srcData);
								num = (short)423952396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18D7:
								num = (short)814678146;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1914:
								num = (short)1352728649;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1961:
								num = (short)207749161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19E3:
								num = (short)1705377912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1AFC:
								num = (short)1996882118;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CE3:
								num = (short)866517179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DF2:
								num = (short)1582497871;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E8D:
								num = (short)219414702;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F24:
								num = (short)1149304938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F62:
								num = (short)1728774341;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2009:
								num = (short)1602814037;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21FA:
								num = (short)1073152161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2237:
								num = (short)1483210794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_22C7:
								num = (short)143786143;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_248B:
								num = (short)639697092;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2701:
								num = (short)64880721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_274E:
								num = (short)51576966;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_278A:
								flag2 = true;
								num = (short)495845399;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27A7:
								num = (short)611254372;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2885:
								flag2 = false;
								stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_from_a_Motorcycle_radio;
								num = (short)1335165119;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_28AD:
								num = (short)1529282582;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2920:
								num = (short)121569304;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_29FD:
								num = (short)1503461377;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2AA0:
								num = (short)606863446;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B82:
								flag2 = true;
								num = (short)1285750879;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2CC9:
								flag2 = false;
								stsErrorMsg = global::CommonResources.AppResources.Unable_To_Clone_From_APX6000_To_APX6000XE_And_Viceversa;
								num = (short)1238433807;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2CF0:
								flag2 = false;
								stsErrorMsg = global::CommonResources.AppResources.Unable_to_clone_from_a_model_3_5;
								num = (short)98697396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D3E:
								num = (short)1451098173;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2DBE:
								num = (short)543883336;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_115B:
							return result;
							IL_2DD7:
							goto IL_AEF;
						}
						finally
						{
							num = (short)1239023618;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flashcodeTable.Dispose();
									flashcodeTable = null;
									num = (short)1108410369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2E49;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2E0F;
									}
									continue;
								}
								IL_2E0F:
								if (flashcodeTable == null)
								{
									break;
								}
								num = (short)2124611584;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E49:;
						}
						goto IL_2E4C;
						IL_AEF:
						num = (short)1634205747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						srcUsedBytes[num4] &= (byte)(~(byte)num23);
						num = (short)487850041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						srcUsedBytes[num17] &= (byte)(~(byte)num14);
						num = (short)902365209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						num = (short)1381629967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (flag11)
						{
							num = (short)492044298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F6E;
					case 67:
						num = (short)865075258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
					{
						num = (short)930873344;
						short num24 = num;
						if (flag12)
						{
							num = (short)514850847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_900;
					}
					case 69:
						srcUsedBytes[num16] &= (byte)(~(byte)num15);
						num = (short)162070541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (num6 != -1)
						{
							num = (short)1648951316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4C;
					case 71:
						if (num23 != -1)
						{
							num = (short)1942749219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A6;
					case 72:
						num = (short)2121859120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						srcUsedBytes[num20] &= (byte)(~(byte)num22);
						num = (short)791740472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (!isPortable)
						{
							num = (short)1513947153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A7;
					case 75:
						if (num5 != -1)
						{
							num = (short)1591607299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4C;
					}
					goto IL_168;
					IL_2BB:
					num = (short)1827340328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F7:
					num = (short)1128857668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A6:
					num = (short)544538662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_795:
					num = (short)1885143074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_900:
					num = (short)847380503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A7:
					flashcodeTable = null;
					num = (short)1626275902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A07:
					num = (short)798162949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E4C:
					num = (short)228524033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F6E:
					num = (short)1964769329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FAA:
					num = (short)1451032642;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag2;
				IL_168:
				flag2 = false;
				flag9 = false;
				num14 = -1;
				num17 = -1;
				flag12 = false;
				num10 = -1;
				num9 = -1;
				flag4 = false;
				flag5 = false;
				num15 = -1;
				num19 = -1;
				num16 = -1;
				num21 = -1;
				flag7 = false;
				flag3 = false;
				num13 = -1;
				num8 = -1;
				num3 = -1;
				num7 = -1;
				num22 = -1;
				num20 = -1;
				flag11 = false;
				flag8 = false;
				num23 = -1;
				num4 = -1;
				flag6 = false;
				num6 = -1;
				num5 = -1;
				flag = false;
				num11 = -1;
				num12 = -1;
				name = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒋붍ꢏ", a_);
				text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒋붍ꞏ", a_);
				text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꎑꎓꆕꢗ", a_);
				text3 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꎑꎓꆕꦗ", a_);
				text4 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b뮍ꂏꖑ", a_);
				text6 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꂑꎓꎕꦗ", a_);
				text7 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꂑ겓ꞕꦗ", a_);
				text8 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋뾍ꦏꆑ", a_);
				text11 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b뢍ꚏꖑ", a_);
				num = (short)181076042;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x001A8C30 File Offset: 0x001A6E30
		private static bool a(string A_0)
		{
			int a_ = 4;
			short num = (short)1375150025;
			short num2 = num;
			num = (short)1590239177;
			switch (num2 == num)
			{
			default:
			{
				num = (short)793116672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1423245312;
			if (num != 0)
			{
			}
			num = (short)2037579777;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈몊\ud98c좎햐ꪒ얔삖겘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈몊\ud98c좎햐ꪒ얔삖꾘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈몊\ud98c좎햐ꪒ얔삖꺘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈몊\ud98c좎햐ꪒ얔삖ꆘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈몊\ud98c좎햐ꪒ얔삖ꂘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈몊\ud98c좎햐ꪒ얔삖궘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈벊\ud98c좎햐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆불늊\ud98c좎햐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆번뺊\ud98c좎얐ꪒ얔삖ꆘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆번뺊\ud98c좎얐ꪒ잔삖ꆘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆불뺊\ud98c좎얐ꪒ얔삖ꆘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈뮊욌\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈뮊욌\udb8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈뮊\ud88c\udd8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈뮊\ud98c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈뮊\ud98c힎슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈뮊\udc8c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈뮊\udc8c\udb8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈뮊\ude8c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮆몈뮊\ud88c\udd8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮆몈뮊욌\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮆몈뮊\udc8c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮆몈뮊\ude8c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮆몈뮊\ud98c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮆몈뮊\uda8c\udd8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈벊\ud98c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈벊\ud98c힎슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮆몈벊\ud98c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펆릈뺊\ud98c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ud88c첎햐ꪒ얔삖겘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\udc8c쮎햐ꪒ얔삖겘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ude8c쮎햐ꪒ얔삖겘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊욌좎햐ꪒ얔삖겘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ud88c첎힐ꪒ얔삖꾘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\udc8c쮎힐ꪒ얔삖꾘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ude8c쮎힐ꪒ얔삖꾘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊욌좎힐ꪒ얔삖꾘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ud88c첎\ud990ꪒ얔삖꺘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\udc8c쮎\ud990ꪒ얔삖꺘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ude8c쮎\ud990ꪒ얔삖꺘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊욌좎\ud990ꪒ얔삖꺘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ud88c첎햐ꪒ얔삖겘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\udc8c쮎햐ꪒ얔삖겘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ude8c쮎햐ꪒ얔삖겘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊욌좎햐ꪒ얔삖겘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ud88c첎힐ꪒ얔삖꾘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\udc8c쮎힐ꪒ얔삖꾘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ude8c쮎힐ꪒ얔삖꾘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊욌좎힐ꪒ얔삖꾘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ud88c첎\ud990ꪒ얔삖꺘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\udc8c쮎\ud990ꪒ얔삖꺘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊\ude8c쮎\ud990ꪒ얔삖꺘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊욌좎\ud990ꪒ얔삖꺘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊\udc8c쮎햐ꪒ얔삖겘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊욌좎햐ꪒ얔삖겘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊\ud88c첎햐ꪒ얔삖겘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊\udc8c쮎\ud990ꪒ얔삖꺘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊욌좎\ud990ꪒ얔삖꺘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊\ud88c첎\ud990ꪒ얔삖꺘\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊\udc8c쮎햐ꪒ얔삖겘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊욌좎햐ꪒ얔삖겘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊\ud88c첎햐ꪒ얔삖겘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊\udc8c쮎\ud990ꪒ얔삖꺘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊욌좎\ud990ꪒ얔삖꺘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊\ud88c첎\ud990ꪒ얔삖꺘\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊욌\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊욌\udb8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊\ud88c\udd8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊\udc8c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊\udc8c\udb8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊\ude8c\udc8e슐ꪒ얔삖ꢘ\uda9a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊\ud88c\udd8e슐ꪒ얔삖ꢘ\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊욌\udc8e슐ꪒ얔삖ꢘ\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊\udc8c\udc8e슐ꪒ얔삖ꢘ\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊\ude8c\udc8e슐ꪒ얔삖ꢘ\ud99a펜", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊\udb8c\udd8e슐ꪒ얔삖ꢘ\ud89a펜", a_)
			}.Contains(A_0);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x001A92E0 File Offset: 0x001A74E0
		private static bool b(global::SpecialFeatures.Clone_Configuration.Common.CodeplugData A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_CE;
				case 1:
					goto IL_10A;
				case 2:
					result = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493Value;
					goto IL_F3;
				case 3:
				{
					if (A_0._data == null)
					{
						num2 = (short)120258562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)284647482;
					short num3 = num2;
					num2 = (short)1803378746;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
						num2 = (short)2071920640;
						if (num2 != 0)
						{
						}
						result = A_0._data.AllowInvalidFrequency.Value;
						num2 = (short)1987051520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
				IL_F3:
				num2 = (short)428605441;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_CE:
			return result;
			IL_10A:
			num2 = (short)1081737217;
			if (num2 != 0)
			{
			}
			num2 = (short)1642004480;
			short num4 = num2;
			return result;
			IL_20:
			result = false;
			num2 = (short)841678851;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x001A944C File Offset: 0x001A764C
		private static bool a(global::SpecialFeatures.Clone_Configuration.Common.CodeplugData A_0)
		{
			short num = (short)851968000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				bool result;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
					switch (num2)
					{
					case 0:
					{
						if (A_0._data == null)
						{
							num = (short)1069481990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3 = -1;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator = A_0._data.APXRadioSystems.GetEnumerator();
						num = (short)2017787906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int num4 = ((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)trunkingSystemRecset[0]).General.TrkSysGeneralSystemType_A9252.Value;
						num = (short)2141519877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)1167458307;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_37A;
								case 2:
								{
									int num3;
									if (num3 == -1)
									{
										num = (short)713162763;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1060765704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1E6;
									}
									continue;
								case 4:
									num = (short)1331363841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
									global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
									if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
									{
										num = (short)218431494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)370933762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									result = false;
									num = (short)201064458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									int num3;
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
									if (global::System.Convert.ToInt32(apxradioSystem.SystemSubType) != num3)
									{
										num = (short)947453959;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1701511172;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = enumerator.Current;
									global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = apxradioSystem.SystemType;
									global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING;
									num = (short)791740421;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_278;
								case 11:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
									int num3 = global::System.Convert.ToInt32(apxradioSystem.SystemSubType);
									num = (short)449642496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_21D:
								num = (short)2081030153;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E6:
								goto IL_21D;
							}
							IL_278:
							IL_37A:
							return result;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_4;
					case 3:
						if (trunkingSystemRecset.Count > 0)
						{
							num = (short)969277441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_550;
					case 4:
						goto IL_38D;
					case 5:
						goto IL_550;
					case 6:
					{
						int num4 = -1;
						trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
						num = (short)1837170688;
						short num5 = num;
						num = (short)922943489;
						if (num != 0)
						{
						}
						num = (short)1426653187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4B;
					IL_550:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = trunkingSystemRecset.GetEnumerator();
					num = (short)85262340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_38D:
						num = (short)273285120;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3D0;
								}
								continue;
							case 1:
								num = (short)1622867972;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								result = false;
								num = (short)1442381829;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (!enumerator2.MoveNext())
								{
									num = (short)162136065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)973275142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_493;
							case 5:
								goto IL_437;
							case 6:
							{
								int num4;
								if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator2.Current).General.TrkSysGeneralSystemType_A9252.Value != num4)
								{
									num = (short)1563623426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_43C:
							num = (short)1326579715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3D0:
							goto IL_43C;
						}
						IL_437:
						IL_493:
						break;
					}
					finally
					{
						num = (short)1619329026;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_54D;
							case 1:
								enumerator2.Dispose();
								num = (short)310444032;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								num = (short)1621647755;
								short num6 = num;
								num = (short)1790599563;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1079705600;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_516;
									}
									continue;
								}
								break;
							}
							}
							IL_516:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)530251777;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_54D:;
					}
					goto IL_550;
				}
				return result;
				IL_4B:
				result = true;
				num = (short)2089877504;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x001A9A04 File Offset: 0x001A7C04
		private static bool b(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable A_0, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData A_1, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData A_2)
		{
			int a_ = 19;
			string purchasedFlashcode = A_1.purchasedFlashcode;
			string purchasedFlashcode2 = A_2.purchasedFlashcode;
			bool flag = false;
			short num;
			if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톕ꂗ꾙ꮛ", a_), purchasedFlashcode, ref flag))
			{
				num = (short)690382803;
				short num2 = num;
				num = (short)855795667;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1725235201;
					if (num != 0)
					{
					}
					num = (short)522977280;
					if (num != 0)
					{
					}
					return true;
				}
			}
			num = (short)1391722496;
			short num3 = num;
			return !A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톕ꂗ꾙ꮛ", a_), purchasedFlashcode2, ref flag);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x001A9B00 File Offset: 0x001A7D00
		private static bool a(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable A_0, string A_1, bool A_2, bool A_3)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_ED;
			}
			int num;
			bool flag;
			short num2;
			bool flag2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꖐꆒ", a_), A_1, ref flag))
					{
						num2 = (short)558956580;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_614;
				case 1:
					num2 = (short)657457154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횆좈뮊붌몎Ꚑꎒ", a_), A_1, ref flag))
					{
						num2 = (short)1976369190;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8FA;
				case 3:
					num2 = (short)728039452;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꆐꪒ", a_), A_1, ref flag))
					{
						num2 = (short)198377517;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8DA;
				case 5:
					goto IL_757;
				case 6:
					num2 = (short)1043136542;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1820590099;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_8DA;
				case 9:
					num2 = (short)1898708996;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횆좈뮊붌몎ꚐꞒ", a_), A_1, ref flag))
					{
						num2 = (short)892796935;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_44D;
				case 11:
					goto IL_44D;
				case 12:
					num2 = (short)1087569955;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꆐꖒ", a_), A_1, ref flag))
					{
						num2 = (short)1647837235;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_614;
				case 14:
					num2 = (short)1999634456;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)7733258;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)1885470733;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					return flag2;
				case 18:
					if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꖐꖒ", a_), A_1, ref flag))
					{
						num2 = (short)1846935560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_757;
				case 19:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횆좈뮊붌몎ꚐꚒ", a_), A_1, ref flag))
					{
						num2 = (short)194314246;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_44D;
				case 20:
					num2 = (short)54460441;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (flag2)
					{
						num2 = (short)39976972;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_757;
				case 22:
					goto IL_792;
				case 23:
					goto IL_632;
				case 24:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꖐꊒ", a_), A_1, ref flag))
					{
						num2 = (short)1735720991;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_614;
				case 25:
					if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횆좈뮊붌몎Ꚑꆒ", a_), A_1, ref flag))
					{
						num2 = (short)2121203739;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_632;
				case 26:
					if (flag2)
					{
						num2 = (short)1355218947;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag2;
				case 27:
					goto IL_8FA;
				case 28:
					if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횆좈뮊붌몎Ꚑꪒ", a_), A_1, ref flag))
					{
						num2 = (short)455802895;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag2;
				case 29:
					num2 = (short)1931477040;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횆좈뮊붌몎Ꚑꖒ", a_), A_1, ref flag))
					{
						num2 = (short)1144651787;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag2;
				case 31:
					num2 = (short)849477632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					num2 = (short)1015218219;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
				{
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꖐꚒ", a_), A_1, ref flag))
					{
						goto IL_792;
					}
					num2 = (short)1245606638;
					short num3 = num2;
					num2 = (short)1217098478;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6ED;
					default:
						num2 = (short)2048393216;
						if (num2 != 0)
						{
						}
						num2 = (short)128516148;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 34:
					if (A_2)
					{
						num2 = (short)136183854;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8A1;
				case 35:
					if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌몎Ꚑꪒ", a_), A_1, ref flag))
					{
						num2 = (short)727056424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_757;
				case 36:
					num2 = (short)19071009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꖐꂒ", a_), A_1, ref flag))
					{
						num2 = (short)246349856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8DA;
				case 38:
					num2 = (short)2064646188;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					if (flag2)
					{
						num2 = (short)1803485213;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_757;
				case 40:
					num2 = (short)910098473;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꆐꮒ", a_), A_1, ref flag))
					{
						goto IL_6ED;
					}
					goto IL_8DA;
				case 42:
					num2 = (short)699662354;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꖐꞒ", a_), A_1, ref flag))
					{
						num2 = (short)1422589994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8DA;
				case 44:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횆좈뮊붌몎Ꚑꊒ", a_), A_1, ref flag))
					{
						num2 = (short)1424556052;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8FA;
				case 45:
					num2 = (short)2024276005;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
				{
					flag2 = false;
					num2 = (short)97845248;
					short num4 = num2;
					num2 = (short)1754136623;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 47:
					goto IL_8A1;
				case 48:
					if (!A_3)
					{
						num2 = (short)992346128;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_757;
				case 49:
					if (flag2 && A_3)
					{
						num2 = (short)481820673;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag2;
				case 50:
					if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆좈뮊붌벎ꆐ꒒", a_), A_1, ref flag))
					{
						num2 = (short)1319895041;
						if (num2 != 0)
						{
						}
						num2 = (short)2070347790;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_614;
				case 51:
					num2 = (short)2024472626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 52:
					goto IL_614;
				}
				goto IL_ED;
				IL_44D:
				flag2 = false;
				num2 = (short)492371985;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_614:
				flag2 = false;
				num2 = (short)338952214;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_632:
				num2 = (short)422903834;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6ED:
				num2 = (short)1633878025;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_757:
				num2 = (short)1940389937;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_792:
				num2 = (short)1913651221;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_8A1:
				num2 = (short)1290338343;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_8DA:
				flag2 = false;
				num2 = (short)2028208133;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_8FA:
				flag2 = false;
				num2 = (short)1684733975;
				num = (int)((global::System.IntPtr)num2);
			}
			return flag2;
			IL_ED:
			flag = false;
			flag2 = true;
			num2 = (short)1119158306;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x001AA428 File Offset: 0x001A8628
		private static void b(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable A_0, string A_1, string A_2, ref bool A_3)
		{
			int a_ = 10;
			short num = (short)1090191360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_88;
				}
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						num = (short)1984299009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)248485467;
						short num3 = num;
						num = (short)223843931;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_347;
						default:
							num = (short)1573650432;
							if (num != 0)
							{
							}
							if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c캎ꆐꎒꂔꆖꂘ", a_), A_2, ref flag))
							{
								num = (short)206569486;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F7;
						}
						break;
					}
					case 2:
						goto IL_264;
					case 3:
						if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c캎ꆐꎒꂔꂖꢘ", a_), A_1, ref flag))
						{
							num = (short)376700940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_264;
					case 4:
						flag2 = false;
						num = (short)1017315330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c캎ꆐꎒꂔꂖꮘ", a_), A_2, ref flag))
						{
							num = (short)1922236435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 6:
						goto IL_2F7;
					case 7:
						flag3 = false;
						num = (short)58720266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c캎ꆐꎒꂔꂖꦘ", a_), A_1, ref flag))
						{
							num = (short)394067981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_102;
					case 9:
						goto IL_2D2;
					case 10:
						goto IL_102;
					case 11:
						num = (short)1338769409;
						if (num != 0)
						{
						}
						if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c캎ꆐꎒꂔꂖꦘ", a_), A_2, ref flag))
						{
							num = (short)1116471296;
							short num4 = num;
							num = (short)1421737991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_102;
					case 12:
						goto IL_347;
					case 13:
						num = (short)1346699275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						flag4 = false;
						num = (short)606470150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c캎ꆐꎒꂔꂖꮘ", a_), A_1, ref flag))
						{
							num = (short)45613074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 16:
						if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c캎ꆐꎒꂔꂖꢘ", a_), A_2, ref flag))
						{
							num = (short)1186725892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_264;
					case 17:
						if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8c캎ꆐꎒꂔꆖꂘ", a_), A_1, ref flag))
						{
							num = (short)2079326208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F7;
					case 18:
						num = (short)1363148805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						flag5 = false;
						num = (short)1163329545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88;
					IL_102:
					num = (short)420413443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_264:
					num = (short)1434845199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F7:
					num = (short)929038344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_347:
					num = (short)2073165840;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2D2:
				IL_43A:
				A_3 = (flag4 && flag3 && flag2 && flag5);
				return;
				IL_88:
				flag = false;
				flag4 = true;
				flag3 = true;
				flag2 = true;
				flag5 = true;
				num = (short)1989345297;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x001AA87C File Offset: 0x001A8A7C
		private static void a(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable A_0, string A_1, string A_2, ref bool A_3)
		{
			int a_ = 2;
			short num = (short)1692139520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						num = (short)1283981313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)2089907775;
						short num3 = num;
						num = (short)303527487;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_372;
						default:
							num = (short)1412104192;
							if (num != 0)
							{
							}
							if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슄욆릈뮊뾌뮎ꖐ", a_), A_2, ref flag))
							{
								num = (short)645726209;
								if (num != 0)
								{
								}
								num = (short)414318606;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_322;
						}
						break;
					}
					case 2:
						goto IL_291;
					case 3:
						if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슄욆릈뮊뺌뮎ꂐ", a_), A_1, ref flag))
						{
							num = (short)139591692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_291;
					case 4:
						flag2 = false;
						num = (short)2129657858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슄욆릈뮊뺌뮎꒐", a_), A_2, ref flag))
						{
							num = (short)754319379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43F;
					case 6:
						goto IL_322;
					case 7:
						flag3 = false;
						num = (short)551026698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슄욆릈뮊뺌뾎Ꞑ", a_), A_1, ref flag))
						{
							num = (short)234160141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101;
					case 9:
						goto IL_2FE;
					case 10:
						goto IL_101;
					case 11:
						if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슄욆릈뮊뺌뾎Ꞑ", a_), A_2, ref flag))
						{
							num = (short)1685979136;
							short num4 = num;
							num = (short)590020615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101;
					case 12:
						goto IL_372;
					case 13:
						num = (short)1614938123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						flag4 = false;
						num = (short)1763115014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슄욆릈뮊뺌뮎꒐", a_), A_1, ref flag))
						{
							num = (short)1456734226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43F;
					case 16:
						if (!A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슄욆릈뮊뺌뮎ꂐ", a_), A_2, ref flag))
						{
							num = (short)1942028292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_291;
					case 17:
						if (A_0.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슄욆릈뮊뾌뮎ꖐ", a_), A_1, ref flag))
						{
							num = (short)981139456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_322;
					case 18:
						num = (short)577372165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						flag5 = false;
						num = (short)1687420937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_87;
					IL_101:
					num = (short)6291459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_291:
					num = (short)1784807439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_322:
					num = (short)1862139912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_372:
					num = (short)398327824;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2FE:
				IL_43F:
				A_3 = (flag4 && flag3 && flag2 && flag5);
				return;
				IL_87:
				flag = false;
				flag4 = true;
				flag3 = true;
				flag2 = true;
				flag5 = true;
				num = (short)134086673;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x001AACD4 File Offset: 0x001A8ED4
		internal static bool AllowFrequencyClonePortable(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable FcodeTable, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData srcData, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData targetData)
		{
			int a_ = 13;
			short num = (short)1166737408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_359;
				}
				bool flag;
				bool result;
				for (;;)
				{
					IL_32:
					string purchasedFlashcode;
					switch (num2)
					{
					case 0:
						goto IL_17CE;
					case 1:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1092944064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E91;
					case 2:
						goto IL_167D;
					case 3:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1451294867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5E;
					}
					case 4:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1189544013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 5:
						num = (short)548208760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1A52;
					case 7:
						num = (short)1346109484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)815857697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1895497820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)175505511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)142671925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1458962474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E72;
					case 12:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1928331368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D4;
					}
					case 13:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)666304642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167D;
					case 14:
						num = (short)1965424785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)142606508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1366229097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 17:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1658650648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1439;
					}
					case 18:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)225706177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1342;
					case 19:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1106772087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B97;
					case 20:
						goto IL_7B2;
					case 21:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1039794326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 22:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)82837643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FB1;
					case 23:
						num = (short)988348514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)1106509894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)556073049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AEF;
					case 26:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)42401938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2155;
					case 27:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)861470763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1530;
					case 28:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1635713175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167D;
					}
					case 29:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)901251129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5BC;
					}
					case 30:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1446838357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1439;
					case 31:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1246036056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F5;
					}
					case 32:
						goto IL_1CCF;
					case 33:
					{
						num = (short)983040000;
						short num3 = num;
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)278069263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E1F;
					}
					case 34:
						num = (short)935591962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)845742127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D7;
					case 36:
						num = (short)670040122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						result = true;
						num = (short)1596326000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)912392200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E1F;
					}
					case 39:
						num = (short)1592393783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)139395181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AEF;
					}
					case 41:
					{
						string text;
						string b;
						if (text == b)
						{
							num = (short)1508048906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C67;
					}
					case 42:
						num = (short)322371666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num = (short)132644955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)185794566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 45:
						num = (short)1601306768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1870921824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F5;
					case 47:
						num = (short)583336072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_1BEA;
					case 49:
						num = (short)453115972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)517800031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_660;
					case 51:
						goto IL_6F5;
					case 52:
						num = (short)1163460710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
					{
						string text;
						if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelSingleBand(text))
						{
							num = (short)138084389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C67;
					}
					case 54:
						return result;
					case 55:
					{
						string text;
						if (!global::ConstraintHelper.UtilityMack.IsFreonCodeplug(text))
						{
							num = (short)1247477881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string purchasedFlashcode2;
						global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.b(FcodeTable, purchasedFlashcode2, purchasedFlashcode, ref result);
						num = (short)1272643684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						goto IL_1439;
					case 57:
						num = (short)465109059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)278855795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 59:
						num = (short)68419709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						num = (short)550437062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)980549663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_FB1;
					case 63:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)479330353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B2;
					case 64:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1356529720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 65:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1253834887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D4;
					}
					case 66:
						return result;
					case 67:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1250427056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1246;
					case 68:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1586298900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E72;
					case 69:
						num = (short)389611570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)239992839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A52;
					case 71:
						num = (short)1205927965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						num = (short)1076232323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						num = (short)1940521094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)908394622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1308033167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5BC;
					case 76:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)341311604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 77:
						num = (short)393216001;
						if (num != 0)
						{
						}
						goto IL_1AEF;
					case 78:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)457375867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E7;
					case 79:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1104150564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CA8;
					case 80:
						num = (short)1345585346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						goto IL_1E72;
					case 82:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)48693345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5E;
					case 83:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)2102394952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1394;
					}
					case 84:
						num = (short)1656422416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
					{
						num = (short)1980301410;
						short num4 = num;
						num = (short)615514210;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15F1;
						default:
							num = (short)1175388160;
							if (num != 0)
							{
							}
							num = (short)1130627136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 86:
					{
						string text;
						string b;
						if (text == b)
						{
							num = (short)2116091949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 87:
						return result;
					case 88:
						num = (short)1037500443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						num = (short)1594359812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1491402836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B43;
					case 91:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)940703851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 92:
						num = (short)949616808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						goto IL_2155;
					case 94:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1029242960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CCF;
					case 95:
						num = (short)324927646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						num = (short)1733165164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						num = (short)1798045860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)682557567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 99:
						num = (short)12648643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						return result;
					case 101:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1709113524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 102:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1417216191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D4;
					case 103:
						return result;
					case 104:
						num = (short)126091329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						goto IL_1B43;
					case 106:
						num = (short)1605501102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						goto IL_1530;
					case 108:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1475018803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 109:
						num = (short)1202061406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)879230999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E2;
					case 111:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1323106318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_660;
					}
					case 112:
						return result;
					case 113:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1047986362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1439;
					}
					case 114:
						goto IL_5BC;
					case 115:
						goto IL_CA8;
					case 116:
						goto IL_1E1F;
					case 117:
						num = (short)1259995325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1842020535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F2;
					case 119:
						num = (short)1585316006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)661848098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E2;
					}
					case 121:
						num = (short)1575551175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						num = (short)303038527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						num = (short)876675209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)329842810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E72;
					case 125:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)146079904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BEA;
					case 126:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)629538816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 127:
						goto IL_22E2;
					case 128:
						return result;
					case 129:
						goto IL_1342;
					case 130:
						num = (short)526057631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 131:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1080164537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1394;
					}
					case 132:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)260112580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1342;
					}
					case 133:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)547815517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 134:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꖛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)501415975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)448004105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 135:
						num = (short)875954177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1843593398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 137:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1093533858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E72;
					case 138:
						goto IL_1246;
					case 139:
						num = (short)11927739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
					{
						string text = srcData.modelNumber.Trim();
						string b = targetData.modelNumber.Trim();
						string purchasedFlashcode2 = srcData.purchasedFlashcode;
						purchasedFlashcode = targetData.purchasedFlashcode;
						num = (short)1288568873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 141:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)988414004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D4;
					case 142:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1657471124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E1F;
					case 143:
						num = (short)321913005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
					{
						string text;
						if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelDualBand(text))
						{
							num = (short)842137673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 145:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)985923653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E72;
					case 146:
						num = (short)483786885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 147:
						num = (short)381091851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						num = (short)996737100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 149:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1485635713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 150:
						goto IL_11F2;
					case 151:
						num = (short)1165426767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 152:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1833566363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AEF;
					}
					case 153:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)2044133514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 154:
						num = (short)1416298524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 155:
						num = (short)1871511592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 156:
						goto IL_1394;
					case 157:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)353370218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1394;
					case 158:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)329056337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_660;
					case 159:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)801832962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 160:
						num = (short)179765432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 161:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1328283709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F5;
					}
					case 162:
						goto IL_13E7;
					case 163:
						num = (short)619315222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 164:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)89129130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E72;
					case 165:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1633616053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B2;
					}
					case 166:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1490682027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 167:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1145634876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F2;
					}
					case 168:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)550699013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E2;
					}
					case 169:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)299565210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167D;
					}
					case 170:
						goto IL_F5E;
					case 171:
						goto IL_1B97;
					case 172:
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙겛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1002307658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17CE;
					case 173:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1099759730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 174:
						goto IL_15F1;
					case 175:
						num = (short)648413262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 176:
						num = (short)1930428569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꦛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1891041470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1342;
					}
					case 178:
						return result;
					case 179:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꺛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1866465351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5BC;
					}
					case 180:
						goto IL_1E91;
					case 181:
						num = (short)195100796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 182:
						goto IL_8D7;
					case 183:
						num = (short)691077141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)63766576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 185:
						num = (short)294715411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 186:
						num = (short)1529544721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 187:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1460666430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 188:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙궛", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)853147765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D7;
					}
					case 189:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꪛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1896808611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D7;
					}
					case 190:
						num = (short)1982726234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 191:
						goto IL_21FC;
					case 192:
						num = (short)1165361253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 193:
						num = (short)2109800597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 194:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙꾛", a_), purchasedFlashcode, ref flag))
						{
							num = (short)645201952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21FC;
					case 195:
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)34603183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E72;
					case 196:
						num = (short)280625329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 197:
						if (!global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.b(srcData))
						{
							num = (short)737149068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)144375936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 198:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)330563643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F2;
					}
					case 199:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗겙ꖛ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)652542051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E7;
					}
					}
					goto IL_359;
					IL_5BC:
					num = (short)129171468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_660:
					result = false;
					num = (short)1496252470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D4:
					result = false;
					num = (short)1110310999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F5:
					num = (short)587137193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7B2:
					num = (short)1895825519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D7:
					num = (short)1034551463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C67:
					num = (short)405405782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CA8:
					num = (short)745996301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F5E:
					num = (short)420479141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FB1:
					num = (short)1197932579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11F2:
					num = (short)1626734771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1246:
					num = (short)1779368011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1342:
					num = (short)452133025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1394:
					num = (short)342687782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13E7:
					num = (short)81526787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1439:
					num = (short)2107506876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1530:
					num = (short)1299578926;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15F1:
					if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솏펑꒓ꚕ궗궙ꢛ", a_), purchasedFlashcode, ref flag))
					{
						num = (short)955646108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21FC;
					IL_167D:
					num = (short)1836515411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17CE:
					num = (short)247922830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A52:
					num = (short)1785724958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AEF:
					num = (short)635699313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B43:
					num = (short)1330446354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B97:
					num = (short)1485111453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BEA:
					num = (short)2000027766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CCF:
					num = (short)664862745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E1F:
					num = (short)1338245272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E72:
					result = true;
					num = (short)915996850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E91:
					num = (short)832045197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2155:
					num = (short)1976828014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21FC:
					result = true;
					num = (short)2141257794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22E2:
					num = (short)1864827012;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_359:
				flag = false;
				result = false;
				num = (short)2108162245;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x001AD0CC File Offset: 0x001AB2CC
		internal static bool AllowFrequencyCloneMobile(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable FcodeTable, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData srcData, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData targetData)
		{
			int a_ = 11;
			short num = (short)1242234880;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F8;
				}
				bool flag;
				bool result;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						num = (short)1861747119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)435355902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CF2;
					}
					case 2:
						num = (short)516620515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)772538468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 4:
					{
						string purchasedFlashcode;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1833042104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CD3;
					}
					case 5:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)749470051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_970;
					}
					case 6:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1890451490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45D0;
					}
					case 7:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1461059810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 8:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1110311326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 9:
						num = (short)1739718713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1834221688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1092354214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18CE;
					}
					case 12:
						num = (short)1787756931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)371196272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D97;
					}
					case 14:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)900333975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4622;
					}
					case 15:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)260046896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 16:
						num = (short)1879507341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						return result;
					case 18:
					{
						string text;
						if (!global::ConstraintHelper.UtilityMack.IsFreonCodeplug(text))
						{
							num = (short)1358561356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string purchasedFlashcode;
						string purchasedFlashcode2;
						global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.a(FcodeTable, purchasedFlashcode, purchasedFlashcode2, ref result);
						num = (short)1278869668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1180369063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C1;
					}
					case 20:
						num = (short)1243414554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						string text;
						if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelDualBand(text))
						{
							num = (short)425132069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31AD;
					}
					case 22:
						goto IL_C93;
					case 23:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1270415430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F3;
					}
					case 24:
						num = (short)796655763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						string text2;
						if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelDualBand(text2))
						{
							num = (short)1613103483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49C7;
					}
					case 26:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1855258745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 27:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)315359604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 28:
						num = (short)2092499218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_1EE4;
					case 30:
						num = (short)1277428077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1963524173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1962344563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_348E;
					}
					case 33:
					{
						string text2;
						if (text2[3] == 'K')
						{
							num = (short)413859899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3167;
					}
					case 34:
						num = (short)1695940615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)1948188964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)643498271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 37:
						num = (short)659554610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)1840447864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1861026087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F86;
					}
					case 40:
						goto IL_1D45;
					case 41:
						num = (short)1230045505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)284950671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_2014;
					case 44:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)15925670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F38;
					}
					case 45:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)684065073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D45;
					}
					case 46:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)921960848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CF2;
					}
					case 47:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)167117149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4197;
					}
					case 48:
						goto IL_3944;
					case 49:
						num = (short)671809731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						num = (short)810483765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1163067571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 52:
						num = (short)609222805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1778385218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 54:
						goto IL_ED0;
					case 55:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)509477208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42E1;
					}
					case 56:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1492582409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D97;
					}
					case 57:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1501102153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 58:
						num = (short)1891041316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						num = (short)240451652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1278476461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_307C;
					}
					case 61:
						goto IL_47E1;
					case 62:
						num = (short)1943142486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						goto IL_A17;
					case 64:
						num = (short)291045431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							goto IL_39B8;
						}
						num = (short)1347376400;
						short num3 = num;
						num = (short)1656771856;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3276;
						default:
							num = (short)1743192064;
							if (num != 0)
							{
							}
							num = (short)1610612839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 66:
						goto IL_1921;
					case 67:
						goto IL_D89;
					case 68:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1050935566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3167;
					}
					case 69:
						num = (short)1749942606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						num = (short)436470077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						return result;
					case 72:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)247333283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 73:
						goto IL_1D97;
					case 74:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)734724201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 75:
						num = (short)1318387786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						num = (short)1234763858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1012334659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 78:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)506003810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CD3;
					}
					case 79:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1995112684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3944;
					}
					case 80:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)327352708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35CE;
					}
					case 81:
					{
						string text;
						if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelDualBand(text))
						{
							num = (short)867696883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 82:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)330956875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33CA;
					}
					case 83:
						num = (short)1860567054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						string text = srcData.modelNumber.Trim();
						string text2 = targetData.modelNumber.Trim();
						string purchasedFlashcode = srcData.purchasedFlashcode;
						string purchasedFlashcode2 = targetData.purchasedFlashcode;
						num = (short)1750073434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)2078670879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D89;
					}
					case 86:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1313669549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38F1;
					}
					case 87:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1875050733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_457D;
					}
					case 88:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1906966592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42E1;
					}
					case 89:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1364721904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)1196163243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 90:
					{
						string text;
						string text2;
						if (text == text2)
						{
							num = (short)801570993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B5A;
					}
					case 91:
						num = (short)352387231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)2081554456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4974;
					}
					case 93:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1284571511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33CA;
					}
					case 94:
						return result;
					case 95:
						goto IL_38F1;
					case 96:
						num = (short)892666220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						num = (short)1153171665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)41746775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2161;
					}
					case 99:
						num = (short)1591279694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						goto IL_18CE;
					case 101:
					{
						string text2;
						if (text2[3] == 'U')
						{
							num = (short)1201406166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3386;
					}
					case 102:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1396638005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3944;
					}
					case 103:
						num = (short)788791552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						goto IL_9C4;
					case 105:
						num = (short)27197533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						num = (short)117899365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						num = (short)1453654171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1793130888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F22;
					}
					case 109:
						goto IL_2658;
					case 110:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1054736386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2F;
					}
					case 111:
						num = (short)2146369692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						num = (short)1140261133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)129958166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 114:
						num = (short)2053046676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						num = (short)1872101489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1507131422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_970;
					}
					case 117:
						num = (short)1160380671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						num = (short)1170735136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1288437949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3614;
					}
					case 120:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)491520125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EE4;
					}
					case 121:
						goto IL_3240;
					case 122:
						goto IL_48CE;
					case 123:
						return result;
					case 124:
						num = (short)1451688292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						num = (short)543817793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						goto IL_4AAD;
					case 127:
						num = (short)1746206965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
						num = (short)453771610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 129:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)2075853096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B9B;
					}
					case 130:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode2, ref flag))
						{
							goto IL_3276;
						}
						goto IL_9C4;
					}
					case 131:
						goto IL_35CE;
					case 132:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1970733380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 133:
						num = (short)1318650268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						num = (short)1175584998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						num = (short)2037121434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
						num = (short)1119093163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 137:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1220280429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 138:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)616759691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 139:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1197539491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2658;
					}
					case 140:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)264831366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B9B;
					}
					case 141:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)153551150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 142:
						num = (short)1893663008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1704198364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 144:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)215875619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1333;
					}
					case 145:
						goto IL_45D0;
					case 146:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1691222375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_385B;
					}
					case 147:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1662845289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 148:
					{
						string text2;
						if (text2[3] == 'Q')
						{
							num = (short)971178402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5D;
					}
					case 149:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1589903751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 150:
					{
						string text2;
						if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelSingleBand(text2))
						{
							num = (short)1476591722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 151:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1894121688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 152:
						num = (short)155582574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 153:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1101332843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C93;
					}
					case 154:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)2036662632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C4;
					}
					case 155:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)862585044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 156:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)487456976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CF3;
					}
					case 157:
					{
						string text;
						if (text[3] == 'U')
						{
							num = (short)1309999457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4F;
					}
					case 158:
					{
						string text;
						if (text[3] == 'K')
						{
							num = (short)1924530304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_385B;
					}
					case 159:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)417988840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4922;
					}
					case 160:
						goto IL_4622;
					case 161:
					{
						string text;
						if (text[3] == 'Q')
						{
							num = (short)441516032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35CE;
					}
					case 162:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1260192152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F86;
					}
					case 163:
						num = (short)673513609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 164:
						return result;
					case 165:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1302069590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_348E;
					}
					case 166:
						num = (short)235667867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 167:
						num = (short)447545593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 168:
						num = (short)1233060139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 169:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1158938742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 170:
						num = (short)1681391884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						return result;
					case 172:
						return result;
					case 173:
						num = (short)574357633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 174:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)974717326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3944;
					}
					case 175:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)118423635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4622;
					}
					case 176:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)388038694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C0F;
					}
					case 177:
						num = (short)1525678407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 178:
						goto IL_255F;
					case 179:
						goto IL_4BA7;
					case 180:
						num = (short)464912405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 181:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)310247663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 182:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)2145714508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 183:
						num = (short)1850802443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
						goto IL_3B9B;
					case 185:
						num = (short)95617170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 186:
						num = (short)868680042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 187:
					{
						num = (short)1047330816;
						short num4 = num;
						num = (short)1365245960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 188:
						return result;
					case 189:
						num = (short)511508837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 190:
						goto IL_1F38;
					case 191:
						goto IL_3998;
					case 192:
						num = (short)807272676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 193:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)327418167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18CE;
					}
					case 194:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)457375880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4974;
					}
					case 195:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1664286954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1333;
					}
					case 196:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1117389006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18CE;
					}
					case 197:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1898971459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_970;
					}
					case 198:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1623720027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4922;
					}
					case 199:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)835780776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 200:
					{
						string text;
						if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelSingleBand(text))
						{
							num = (short)1342439634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49C7;
					}
					case 201:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)523895131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B9B;
					}
					case 202:
						num = (short)1088225325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 203:
						return result;
					case 204:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)692256809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38F1;
					}
					case 205:
						goto IL_3167;
					case 206:
						num = (short)1022951435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 207:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)453050703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 208:
						num = (short)1445134543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 209:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1433469088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 210:
						num = (short)80609305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 211:
					{
						string text2;
						if (text2[3] == 'Q')
						{
							num = (short)1996947746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47E1;
					}
					case 212:
						goto IL_1DE9;
					case 213:
						if (!global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.b(srcData))
						{
							num = (short)2144272468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)132907102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 214:
						num = (short)150339900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 215:
						goto IL_2329;
					case 216:
						goto IL_1536;
					case 217:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1066336446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 218:
						num = (short)483262646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 219:
						num = (short)261095564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 220:
						goto IL_16DB;
					case 221:
						num = (short)1182597522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 222:
						num = (short)1447297327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 223:
						num = (short)1479016720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 224:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)2070610112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48CE;
					}
					case 225:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1320747030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 226:
						num = (short)1584857414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 227:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1540489458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2F;
					}
					case 228:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)284885409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_370E;
					}
					case 229:
						goto IL_C4F;
					case 230:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1564213311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 231:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1197604893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 232:
						num = (short)1693778073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 233:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)37617714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3E;
					}
					case 234:
						num = (short)138084623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 235:
						num = (short)617546025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 236:
						num = (short)512688143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 237:
						num = (short)1646789029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 238:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1026490503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C0F;
					}
					case 239:
						goto IL_4922;
					case 240:
						num = (short)697565435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 241:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)912654379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 242:
						goto IL_46C6;
					case 243:
						num = (short)1548157078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 244:
					{
						string text;
						if (text[3] == 'K')
						{
							num = (short)1277428012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2329;
					}
					case 245:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)602275974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A17;
					}
					case 246:
					{
						string text;
						if (text[3] == 'Q')
						{
							num = (short)2050621725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A17;
					}
					case 247:
						num = (short)1273758090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 248:
						return result;
					case 249:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)223019328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C1;
					}
					case 250:
						num = (short)2017657212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 251:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)2059731281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48CE;
					}
					case 252:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)966852810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D45;
					}
					case 253:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)479002871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47E1;
					}
					case 254:
						num = (short)1262027090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 255:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1913586016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 256:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1762525445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 257:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1498087653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 258:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)335872170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4197;
					}
					case 259:
						num = (short)128385355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 260:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)400032048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 261:
						goto IL_39B8;
					case 262:
						num = (short)46727319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 263:
						num = (short)204603762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 264:
						goto IL_341C;
					case 265:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)821886992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 266:
						num = (short)1852834208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 267:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1514405954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 268:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1110835459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4197;
					}
					case 269:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)867958901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2701;
					}
					case 270:
						num = (short)357564764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 271:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)2001142024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1333;
					}
					case 272:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1968177526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 273:
					{
						string text;
						string text2;
						if (text == text2)
						{
							num = (short)237043892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31AD;
					}
					case 274:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1207435409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 275:
						num = (short)737739053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 276:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1155858750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 277:
						goto IL_73E;
					case 278:
						goto IL_348E;
					case 279:
						num = (short)362545232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 280:
						num = (short)538247593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 281:
						num = (short)750387298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 282:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1857683842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 283:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)260440191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 284:
						num = (short)1088618556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 285:
						num = (short)1963720987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 286:
						return result;
					case 287:
						goto IL_3DEC;
					case 288:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)34865274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 289:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)793968855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 290:
						num = (short)1233584381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 291:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)724762859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C4;
					}
					case 292:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1697972273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 293:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)60883347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 294:
						return result;
					case 295:
						num = (short)475136108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 296:
						goto IL_307C;
					case 297:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1059913748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3240;
					}
					case 298:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1796210911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42E1;
					}
					case 299:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)416285055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4F;
					}
					case 300:
						num = (short)1259340117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 301:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1004208140;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AAD;
					}
					case 302:
						goto IL_4197;
					case 303:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1261109288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 304:
						goto IL_970;
					case 305:
						num = (short)415170926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 306:
					{
						string purchasedFlashcode;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1474822495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)563216473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 307:
						goto IL_1AAE;
					case 308:
						goto IL_28F3;
					case 309:
						num = (short)1912275340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 310:
						num = (short)1164378158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 311:
						num = (short)1080295427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 312:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1050476766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D45;
					}
					case 313:
						num = (short)1166278707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 314:
						num = (short)1208418535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 315:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)633667653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D97;
					}
					case 316:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1354498432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3386;
					}
					case 317:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1316618548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 318:
						goto IL_370E;
					case 319:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)960037214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BA7;
					}
					case 320:
						num = (short)471924821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 321:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)449052767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 322:
						goto IL_1E3E;
					case 323:
						num = (short)2114060548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 324:
						goto IL_2161;
					case 325:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)501612606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38F1;
					}
					case 326:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)544473116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45D0;
					}
					case 327:
					{
						string text;
						if (global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.IsModelSingleBand(text))
						{
							num = (short)1928003929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B5A;
					}
					case 328:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1145962627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 329:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)450494474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EE4;
					}
					case 330:
					{
						string text2;
						if (text2[3] == 'K')
						{
							num = (short)1387594012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_307C;
					}
					case 331:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)313393335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1921;
					}
					case 332:
						goto IL_3614;
					case 333:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)618266842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3614;
					}
					case 334:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)804913259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DE9;
					}
					case 335:
						goto IL_2CF3;
					case 336:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1534001285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_255F;
					}
					case 337:
						num = (short)508297440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 338:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)97648950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_341C;
					}
					case 339:
					{
						num = (short)1495465985;
						if (num != 0)
						{
						}
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1607008443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C1;
					}
					case 340:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1495335175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73E;
					}
					case 341:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1907097821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 342:
						num = (short)1022558377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 343:
						num = (short)668663940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 344:
						num = (short)1664483561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 345:
						result = true;
						num = (short)1627717880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 346:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1614086329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 347:
						goto IL_3386;
					case 348:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1725694157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B9B;
					}
					case 349:
						num = (short)990642317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 350:
						num = (short)1691943177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 351:
						num = (short)1601962002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 352:
						goto IL_2701;
					case 353:
						num = (short)862519495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 354:
						num = (short)2034958340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 355:
						num = (short)1495531636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 356:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)807665718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 357:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1117257824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3614;
					}
					case 358:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1657864303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73E;
					}
					case 359:
						num = (short)769851419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 360:
						num = (short)824705315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 361:
						goto IL_4974;
					case 362:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)2054422640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F38;
					}
					case 363:
						num = (short)1371603169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 364:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)321978492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED0;
					}
					case 365:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1663893784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AAE;
					}
					case 366:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1331888170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16DB;
					}
					case 367:
						num = (short)675021089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 368:
						num = (short)1452933435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 369:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)527171993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_457D;
					}
					case 370:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)675676437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 371:
						num = (short)1609367982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 372:
						goto IL_385B;
					case 373:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)344916187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5D;
					}
					case 374:
						goto IL_42E1;
					case 375:
						num = (short)29229128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 376:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1227620543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C0F;
					}
					case 377:
					{
						string text;
						if (text[3] == 'S')
						{
							num = (short)1595867386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2F;
					}
					case 378:
						num = (short)1323827558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 379:
						num = (short)1583677597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 380:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1080688792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					case 381:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1874002017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4622;
					}
					case 382:
						num = (short)1470628081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 383:
						num = (short)713883905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 384:
						num = (short)1593442505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 385:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1654260090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73E;
					}
					case 386:
						goto IL_F22;
					case 387:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)730529918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 388:
						num = (short)1848770888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 389:
						num = (short)1317273639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 390:
						goto IL_A5D;
					case 391:
						goto IL_4145;
					case 392:
						num = (short)1717371162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 393:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)686031237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F86;
					}
					case 394:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꎕ꾗ꎙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)191561789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B9B;
					}
					case 395:
						goto IL_2F86;
					case 396:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1252393012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4145;
					}
					case 397:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1312293177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BA7;
					}
					case 398:
						num = (short)990249062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 399:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)161939770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EE4;
					}
					case 400:
						num = (short)1144652069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 401:
						goto IL_457D;
					case 402:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1141309807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2329;
					}
					case 403:
						goto IL_1CF2;
					case 404:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)232259688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 405:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)212336826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F38;
					}
					case 406:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1585316211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_255F;
					}
					case 407:
						num = (short)2124742679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 408:
						num = (short)1782972554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 409:
						num = (short)110952876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 410:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)686293258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C0F;
					}
					case 411:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1542520890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DEC;
					}
					case 412:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1710489778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 413:
						num = (short)1479016587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 414:
						goto IL_30C1;
					case 415:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ궙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)565707172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4922;
					}
					case 416:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꾙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)433324294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1536;
					}
					case 417:
						num = (short)1424032020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 418:
						num = (short)1643839861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 419:
						goto IL_33CA;
					case 420:
						num = (short)1956642997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 421:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗꺙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1206518161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 422:
						num = (short)812253401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 423:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꢙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1426915470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48CE;
					}
					case 424:
					{
						string purchasedFlashcode2;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗ겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)1907687806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2014;
					}
					case 425:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗겙", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)906232115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3998;
					}
					case 426:
					{
						string text2;
						if (text2[3] == 'S')
						{
							num = (short)1994522723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CD3;
					}
					case 427:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꦙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)146931993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4974;
					}
					case 428:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓꒕ꪗ꾙", a_), purchasedFlashcode, ref flag))
						{
							num = (short)1772224787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_457D;
					}
					case 429:
						num = (short)1820262824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 430:
					{
						string purchasedFlashcode;
						if (FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕꢗꊙ", a_), purchasedFlashcode, ref flag))
						{
							num = (short)444989853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_255F;
					}
					case 431:
					{
						string purchasedFlashcode2;
						if (!FcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즍톏ꊑ꒓ꖕ겗ꮙ", a_), purchasedFlashcode2, ref flag))
						{
							num = (short)452657431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46C6;
					}
					}
					goto IL_6F8;
					IL_73E:
					num = (short)95289749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_970:
					num = (short)1713111446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9C4:
					num = (short)1205535113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A17:
					num = (short)772538745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A5D:
					num = (short)1934426538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C2F:
					result = false;
					num = (short)957087761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C4F:
					num = (short)1176699124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C93:
					num = (short)251920799;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D89:
					num = (short)618529107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED0:
					num = (short)1022296397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F22:
					num = (short)520487074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1333:
					result = false;
					num = (short)430506278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1536:
					num = (short)88539312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16DB:
					num = (short)757268792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18CE:
					num = (short)837353670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1921:
					num = (short)2049769519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AAE:
					num = (short)742916293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CF2:
					num = (short)1175322768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D45:
					num = (short)1357250756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D97:
					num = (short)1345388929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DE9:
					num = (short)384696376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E3E:
					num = (short)1721958698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EE4:
					num = (short)1187905711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F38:
					num = (short)115671278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2014:
					num = (short)144244940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2161:
					num = (short)152961116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2329:
					num = (short)982909086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_255F:
					num = (short)1116536920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2658:
					num = (short)1163198800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2701:
					num = (short)2031091756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28F3:
					num = (short)1576534397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CF3:
					num = (short)1441202516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F86:
					num = (short)794230903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_307C:
					num = (short)616890579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30C1:
					num = (short)439746812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3167:
					num = (short)598868298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31AD:
					num = (short)2068512968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3240:
					num = (short)278790274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3276:
					num = (short)1728905330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3386:
					num = (short)342032417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33CA:
					num = (short)1516568582;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_341C:
					result = true;
					num = (short)1148452935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_348E:
					num = (short)992346431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35CE:
					num = (short)138805494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3614:
					num = (short)652214291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_370E:
					num = (short)255066535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_385B:
					num = (short)1600651425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38F1:
					num = (short)243204101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3944:
					num = (short)2011955394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3998:
					result = true;
					num = (short)584515772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39B8:
					num = (short)789381519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B5A:
					num = (short)827523345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B9B:
					result = true;
					num = (short)2085028043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C0F:
					result = false;
					num = (short)162726060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CD3:
					result = false;
					num = (short)960364830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DEC:
					num = (short)1715142849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4145:
					num = (short)493092943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4197:
					num = (short)863240366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42E1:
					num = (short)186581005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_457D:
					num = (short)1166344346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45D0:
					num = (short)783810725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4622:
					num = (short)159318341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46C6:
					result = true;
					num = (short)1097400443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47E1:
					num = (short)962134164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48CE:
					num = (short)1594098033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4922:
					num = (short)316080386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4974:
					num = (short)1462305097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49C7:
					num = (short)801898577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AAD:
					num = (short)383254615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BA7:
					num = (short)1163198465;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6F8:
				flag = false;
				result = false;
				num = (short)1475281109;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x001B1CD8 File Offset: 0x001AFED8
		internal static bool AllowEnhLevel1Clone(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable FcodeTable, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData srcData, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData targetData)
		{
			short num = (short)1192296448;
			short num2 = num;
			num = (short)519726226;
			short num3 = num;
			num = (short)2069259410;
			switch (num3 == num)
			{
			}
			num = (short)67829761;
			if (num != 0)
			{
			}
			num = (short)1193803776;
			if (num != 0)
			{
			}
			return global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.a(FcodeTable, srcData, targetData);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x001B1D8C File Offset: 0x001AFF8C
		internal static bool AllowEnhLevel2Clone(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable FcodeTable, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData srcData, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData targetData)
		{
			int a_ = 6;
			short num = (short)1723277621;
			short num2 = num;
			num = (short)504504629;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9A;
			case 1:
				break;
			default:
			{
				num = (short)367394816;
				short num3 = num;
				break;
			}
			}
			num = (short)1834680320;
			if (num != 0)
			{
			}
			num = (short)2091843584;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_9A:
				num = (short)1921253377;
				if (num != 0)
				{
				}
				bool flag = true;
				try
				{
					global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(targetData.modelNumber, targetData.purchasedFlashcode);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_1A2;
						}
						string strFullyQualifiedRecordsetName;
						int nMaxRecs;
						for (;;)
						{
							IL_E3:
							switch (num4)
							{
							case 0:
								if (srcData.recSetCounts != null)
								{
									num = (short)2031632;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_692;
							case 1:
								num = (short)598474770;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
								if (!zoneChannelAssignmentRecset.HiddenStatic)
								{
									num = (short)828571670;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_692;
							}
							case 3:
								flag = false;
								num = (short)634912795;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)1427046417;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset = global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset;
								num = (short)1978007593;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
								if (radioProfilesRecset.Count > nMaxRecs)
								{
									num = (short)1374421023;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51F;
							}
							case 7:
								flag = false;
								num = (short)584122406;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_51F;
							case 9:
								flag = false;
								num = (short)168034315;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								if (srcData._data == null)
								{
									num = (short)1405681696;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1340407832;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_692;
							case 12:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
								if (!radioProfilesRecset.HiddenStatic)
								{
									num = (short)1685258261;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51F;
							}
							case 13:
								if (nMaxRecs != -1)
								{
									num = (short)1618346014;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51F;
							case 14:
								if (nMaxRecs != -1)
								{
									num = (short)1673986084;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_692;
							case 15:
								flag = global::SpecialFeatures.Clone_Configuration.Common.AllowCloning.a(FcodeTable, srcData, targetData);
								num = (short)770244634;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
								num = (short)933101601;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								if (nMaxRecs != -1)
								{
									num = (short)1085407260;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51F;
							case 18:
								if (nMaxRecs != -1)
								{
									num = (short)1162608682;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_692;
							case 19:
								if (srcData.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 2;
									short num5;
									for (;;)
									{
										num5 = (short)1136590848;
										short num6 = num5;
										num5 = (short)2100756481;
										if (num5 != 0)
										{
										}
										if (!(x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힄\udf8eﲒﺖﺚ춞쒠삢횤슦\udda8", a_2)))
										{
											return false;
										}
										num5 = (short)1096765262;
										short num7 = num5;
										num5 = (short)1630818126;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_AD;
										}
									}
									IL_AD:
									num5 = (short)1896022016;
									if (num5 != 0)
									{
									}
									return x._count > nMaxRecs;
								}) != null)
								{
									num = (short)1232601095;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51F;
							case 20:
								if (srcData.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 12;
									short num5 = (short)2083717120;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햎ﺐﶒ풖漢쒠쾢풦\udaa8슪쪬솮\udcb0횲\udbb4쎶\udeba\udebc첾꓀럂", a_2))
									{
										num5 = (short)1480312842;
										short num7 = num5;
										num5 = (short)1710016522;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)83689472;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									num5 = (short)250740737;
									if (num5 != 0)
									{
									}
									return false;
								}) != null)
								{
									num = (short)1312227331;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_692;
							case 21:
								num = (short)1752563725;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 22:
								num = (short)870514702;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 23:
								if (srcData._data == null)
								{
									num = (short)1278083077;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1476657152;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 24:
								if (srcData.recSetCounts != null)
								{
									num = (short)1990983709;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51F;
							case 25:
								if (srcData.recSetCounts.Count > 0)
								{
									num = (short)1785593860;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51F;
							case 26:
								goto IL_7E1;
							case 27:
								goto IL_692;
							case 28:
								num = (short)303169555;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 29:
								num = (short)979566617;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 30:
								num = (short)431357958;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 31:
								flag = false;
								num = (short)727777288;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 32:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset;
								num = (short)4915234;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 33:
								if (srcData.recSetCounts.Count > 0)
								{
									num = (short)691535873;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_692;
							case 34:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
								if (radioProfilesRecset != null)
								{
									num = (short)1126957096;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51F;
							}
							case 35:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒈歷ﲒ璉래횚ﲜﲞ쪠쪢쮤욦\udea8ﶬﲮ龰\udab4얶\udcb8ﶺ\ud8bc\udebe뗀뛂럄ꋆ뫈韌ꃎ뿐뛒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致\ud9f6ꏸ铺鏼髾䈀欂搄椆月渊愌与成怒簔瀖眘瘚砜焞唠焢䀤䐦娨个夬", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)1581842455;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 36:
								num = (short)179634220;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 37:
								if (flag)
								{
									num = (short)1150156835;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_692;
							case 38:
								goto IL_51F;
							case 39:
								goto IL_7FB;
							case 40:
								num = (short)734724108;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 41:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
								if (zoneChannelAssignmentRecset != null)
								{
									num = (short)360841261;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_692;
							}
							case 42:
								num = (short)1590951956;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 43:
								if (flag)
								{
									num = (short)73400335;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7E1;
							case 44:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
								if (zoneChannelAssignmentRecset.Count > nMaxRecs)
								{
									num = (short)1022230537;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_692;
							}
							case 45:
								num = (short)1726218242;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A2;
							IL_51F:
							num = (short)417202213;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_692:
							num = (short)1625882667;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_7E1:
							num = (short)1286733863;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_7FB:
						goto IL_867;
						IL_1A2:
						strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒈歷ﲒ璉래횚ﲜﲞ쪠쪢쮤욦\udea8ﶬﲮ龰\udab4얶\udcb8ﶺ\ud8bc\udebe뗀뛂럄ꋆ뫈鿌껎뗐뫒뫔蟖ꯘ듚믜뛞跠蛢雤짦믨諪觬蛮黰ꏲ蟴飶鿸鋺釼髾爀儂怄搆稈渊礌", a_);
						nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
						num = (short)1821966346;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_E3;
					}
					finally
					{
						num = (short)1475084288;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_82F;
								}
								continue;
							case 1:
								((global::System.IDisposable)modelTiering).Dispose();
								num = (short)1606483970;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_864;
							}
							IL_82F:
							if (modelTiering == null)
							{
								break;
							}
							num = (short)1859321857;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_864:;
					}
					IL_867:;
				}
				catch (global::System.Exception)
				{
					flag = false;
				}
				return flag;
			}
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x001B263C File Offset: 0x001B083C
		private static bool a(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable A_0, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData A_1, global::SpecialFeatures.Clone_Configuration.Common.CodeplugData A_2)
		{
			int a_ = 11;
			short num = (short)1589837824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool flag = true;
				try
				{
					global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(A_2.modelNumber, A_2.purchasedFlashcode);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_40C;
						}
						string strFullyQualifiedRecordsetName;
						int nMaxRecs;
						for (;;)
						{
							IL_49:
							switch (num2)
							{
							case 0:
								num = (short)137232503;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								num = (short)359202835;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (nMaxRecs != -1)
								{
									num = (short)1070661864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A4;
							case 3:
								goto IL_17E0;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset = global::AcpCommonLib.FeatureManager.GetFeature(2062) as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset;
								num = (short)1485963481;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								if (A_1._data == null)
								{
									num = (short)632160305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1900150932;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (flag)
								{
									num = (short)16580809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17E0;
							case 7:
							{
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ낝쎡잣춥솧쒩춫\ud9ad颵﮷햹캻\udbbd蚿ꟁꗃ닅뷇룉꧋뷍ﻏ裑믓룕뷗駙듛뿝軟賡臣諥ꧧ駩鿫蟭韯鳱駳鏵雷軹틻뷽棿持樃栅洇昉䴋納挏笑猓砕甗缙爛樝氟䬡圣別愧䐩䈫䬭䈯怱儳唵䬷弹䠻", a_);
								int nMaxPoolRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxPoolRecords);
								num = (short)525074448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)321191989;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_913;
							case 9:
								if (flag)
								{
									num = (short)1782644863;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC4;
							case 10:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
								if (encryptionKeyListInnerRecset != null)
								{
									num = (short)1389559851;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17E0;
							}
							case 11:
								num = (short)1029374038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								num = (short)182386790;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								goto IL_12AA;
							case 14:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
								if (channelAssignmentListInnerRecset.MaxPool - channelAssignmentListInnerRecset.CounterToMaxPool > CS$<>8__locals2.nMaxPoolRecs)
								{
									num = (short)1649606893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_275F;
							}
							case 15:
							{
								global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
								if (uclContactRecset.Count > nMaxRecs)
								{
									num = (short)809500877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C03;
							}
							case 16:
								if (A_1._data == null)
								{
									num = (short)1368916044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)2105933966;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								num = (short)1130627162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
								flag = false;
								num = (short)396099620;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 19:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
								if (encryptionKeyListInnerRecset.Count > nMaxRecs)
								{
									num = (short)816251084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17E0;
							}
							case 20:
								if (nMaxRecs != -1)
								{
									num = (short)1311834158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C03;
							case 21:
								if (A_1._data == null)
								{
									num = (short)532086788;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1647575185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 22:
								if (A_1.recSetCounts != null)
								{
									num = (short)1910571038;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC4;
							case 23:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)688980121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A4;
							case 24:
								num = (short)1021378663;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 25:
								goto IL_913;
							case 26:
								if (flag)
								{
									num = (short)1762787505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_913;
							case 27:
								num = (short)1598881980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 28:
								if (A_1._data == null)
								{
									num = (short)229572740;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1752563753;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 29:
								goto IL_275F;
							case 30:
								num = (short)1713111250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 31:
								num = (short)1862795408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 32:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
								if (conventionalSystemRecset != null)
								{
									num = (short)220004574;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_913;
							}
							case 33:
								goto IL_CBE;
							case 34:
								num = (short)2119172275;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 35:
								if (flag)
								{
									num = (short)1172570306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A66;
							case 36:
								goto IL_17A4;
							case 37:
								goto IL_17A4;
							case 38:
								num = (short)853409931;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 39:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 0;
									short num5 = (short)1818296320;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud982좊ﾐﶒﮖ\ud898욠춢좤슦잨\udfaaﾬ쪮튰삲킴쎶", a_2))
									{
										num5 = (short)960419318;
										short num7 = num5;
										num5 = (short)415421942;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)1024458753;
											if (num5 != 0)
											{
											}
											num5 = (short)1293680640;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)200343722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_897;
							case 40:
								goto IL_1A66;
							case 41:
								if (A_1.recSetCounts != null)
								{
									num = (short)1302266052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A4;
							case 42:
								num = (short)1690566820;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 43:
								num = (short)556204142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 44:
								if (A_1.recSetCounts != null)
								{
									num = (short)997261485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB;
							case 45:
								if (nMaxRecs != -1)
								{
									num = (short)1309802527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC4;
							case 46:
								num = (short)82968591;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 47:
							{
								global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
								if (!uclContactRecset.HiddenStatic)
								{
									num = (short)1699807337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C03;
							}
							case 48:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
								if (!astrotalkgroupListRecset.HiddenStatic)
								{
									num = (short)2099380224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A66;
							}
							case 49:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset = global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset;
								num = (short)1161429044;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 50:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
								if (trunkingSystemRecset.Count > nMaxRecs)
								{
									num = (short)1569915116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CBE;
							}
							case 51:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8dﾕ聯\uda9bﮝ솟횡톣풥춧\ud9a9芫ﮭ펯\udeb1骳ힷ풹좻\udfbdꎿ뛁鏅ꯇꛉ迋ꇍ뻏ꛑ뗓뗕곗裙맛뷝鏟蟡郣", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)42008752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 52:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
								if (zoneChannelAssignmentRecset != null)
								{
									num = (short)1471217688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_897;
							}
							case 53:
								num = (short)2063335662;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 54:
								num = (short)2145255632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 55:
								num = (short)1935081607;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 56:
								if (flag)
								{
									num = (short)928120839;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_275F;
							case 57:
								goto IL_5BB;
							case 58:
								num = (short)886571241;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 59:
								if (A_1._data == null)
								{
									num = (short)455934061;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1637679251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 60:
								if (nMaxRecs != -1)
								{
									num = (short)1095893072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_913;
							case 61:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureKMFProfileRecset.GetEnumerator();
								num = (short)473432195;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 62:
								num = (short)164167746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 63:
								flag = false;
								num = (short)471466167;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 64:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ낝쎡잣춥솧쒩춫\ud9ad颵﮷햹캻\udbbd蚿ꟁꗃ닅뷇룉꧋뷍ﻏ蛑ꛓꏕ뛗뇙뗛냝蟟닡臣铥鯧藩苫迭鳯鯱胳迵훷껹軻诽滿椁洃栅漇娉椋簍挏紑稓眕琗猙栛朝爟䜡䜣唥䴧帩", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)2045444124;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 65:
								num = (short)1217396817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 66:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 10;
									short num5 = (short)2120155136;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ횔ﾖ爵춠횤풦삨첪쎬슮풰\uddb2솴\udcb8\ud8ba캼\udabe뗀", a_2))
									{
										num5 = (short)419419638;
										short num7 = num5;
										num5 = (short)1566823926;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)1505427456;
											if (num5 != 0)
											{
											}
											num5 = (short)1727987713;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)196715;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC4;
							case 67:
								if (A_1.recSetCounts != null)
								{
									num = (short)1627127921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E44;
							case 68:
								if (A_1.recSetCounts != null)
								{
									num = (short)1926168665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CBE;
							case 69:
								num = (short)1219756253;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 70:
								num = (short)1768489039;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 71:
								num = (short)1717436507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 72:
								num = (short)1761935408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 73:
								num = (short)744489179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 74:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)2125463651;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CBE;
							case 75:
								if (flag)
								{
									num = (short)1788543099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB;
							case 76:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset = global::AcpCommonLib.FeatureManager.GetFeature(2051)[0][10114].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset;
								num = (short)1498939592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 77:
								num = (short)1244922031;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 78:
								num = (short)781713541;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 79:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 0;
									short num5 = (short)4784128;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삂킐ﺖﺘ爵쾠힢캦\udaa8\udfaa솮\udfb0횲잴\udcb8\ud8ba캼\udabe뗀", a_2))
									{
										num5 = (short)804511789;
										short num7 = num5;
										num5 = (short)782098477;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)37421057;
											if (num5 != 0)
											{
											}
											num5 = (short)306053120;
											if (num5 != 0)
											{
											}
											return x._maxPool - x._counterToMaxPool > CS$<>8__locals2.nMaxPoolRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)915996773;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_275F;
							case 80:
								num = (short)2086404210;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 81:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 7;
									short num5 = (short)1826881536;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude89ﺋﮍﺏ撚ﶓﾗ즙풟잡즣춧즩\udfab쮭쒯", a_2))
									{
										num5 = (short)305954862;
										short num7 = num5;
										num5 = (short)550535214;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)909443072;
											if (num5 != 0)
											{
											}
											num5 = (short)1271332865;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)903413901;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CBE;
							case 82:
								if (flag)
								{
									num = (short)1583022131;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C03;
							case 83:
								flag = false;
								num = (short)229834789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 84:
								num = (short)1043792065;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 85:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
								if (!conventionalSystemRecset.HiddenStatic)
								{
									num = (short)774504674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_913;
							}
							case 86:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 10;
									short num5 = (short)737673216;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﾐ練삠쾢\udea6\udaa8\udfaa좬슮횲횴쒶\udcb8쾺", a_2))
									{
										num5 = (short)1099169793;
										if (num5 != 0)
										{
										}
										num5 = (short)386468123;
										short num7 = num5;
										num5 = (short)74647835;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)1639710720;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)150667444;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_913;
							case 87:
								flag = false;
								num = (short)2010644709;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 88:
							{
								global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
								if (!voiceAnnouncementListRecSet.HiddenStatic)
								{
									num = (short)1543962679;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB;
							}
							case 89:
								num = (short)2026045514;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 90:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 19;
									short num5 = (short)169738240;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펕蓮킟횡춣즥욧즫힭ﲯ\udbb1잳습풹튻\udbbd늿郁ꇃꗅ믇꿉룋", a_2))
									{
										num5 = (short)1970952423;
										short num7 = num5;
										num5 = (short)158882023;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)1031471105;
											if (num5 != 0)
											{
											}
											num5 = (short)931332096;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)527761592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17E0;
							case 91:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
								if (!secureKMFProfileRecset.HiddenStatic)
								{
									num = (short)1084752024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E44;
							}
							case 92:
								if (nMaxRecs != -1)
								{
									num = (short)1275330716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C03;
							case 93:
								num = (short)2138832904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 94:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)827785337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C03;
							case 95:
								goto IL_2778;
							case 96:
								num = (short)1422983384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 97:
								num = (short)498204870;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 98:
								if (nMaxRecs != -1)
								{
									num = (short)1718026369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CBE;
							case 99:
								num = (short)1659306175;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 100:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset2;
								if (!zoneChannelAssignmentRecset2.HiddenStatic)
								{
									num = (short)587399399;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC4;
							}
							case 101:
								flag = false;
								num = (short)114950343;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 102:
								if (CS$<>8__locals2.nMaxPoolRecs != -1)
								{
									num = (short)412221510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_275F;
							case 103:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
								if (!zoneChannelAssignmentRecset.HiddenStatic)
								{
									num = (short)596574305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_897;
							}
							case 104:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)557645866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E44;
							case 105:
								num = (short)971046932;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 106:
								flag = false;
								num = (short)489947176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 107:
								flag = false;
								num = (short)609878138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 108:
								flag = false;
								num = (short)1223164089;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 109:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset;
								num = (short)1328414752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 110:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
								if (!encryptionKeyListInnerRecset.HiddenStatic)
								{
									num = (short)2053505078;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17E0;
							}
							case 111:
								num = (short)1437860068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 112:
								num = (short)1645412534;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 113:
								num = (short)1575551080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 114:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
								if (conventionalSystemRecset.Count > nMaxRecs)
								{
									num = (short)1841823852;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_913;
							}
							case 115:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
								if (secureKMFProfileRecset != null)
								{
									num = (short)429391943;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E44;
							}
							case 116:
								goto IL_17E0;
							case 117:
								num = (short)531628210;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 118:
								flag = false;
								num = (short)383385737;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 119:
								if (nMaxRecs != -1)
								{
									num = (short)1574043706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A66;
							case 120:
								if (flag)
								{
									num = (short)1661075520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A4;
							case 121:
								num = (short)919076956;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 122:
								goto IL_BC4;
							case 123:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8dﾕ聯\uda9bﮝ솟횡톣풥춧\ud9a9芫\udfaf\udbb1ힳ펵醴풹튻톽떿곁ꟃꏅꗇ꿉ꋋ뫍ꏏﳑ飓뿕ꯗ껙裝迟诡蟣菥ꧧ蓩苫臭藯鳱音鏵闷鿹鋻諽䳿欁眃爅娇漉漋崍甏昑", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)279904463;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 124:
								if (A_1._data == null)
								{
									num = (short)1413349506;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)788135958;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 125:
								if (A_1._data == null)
								{
									num = (short)76546243;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)2052128904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 126:
								flag = false;
								num = (short)1305673893;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 127:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ낝쎡잣춥솧쒩춫\ud9ad颵﮷햹캻\udbbd蚿ꟁꗃ닅뷇룉꧋뷍ﻏ裑믓룕뷗駙듛뿝軟賡臣諥ꧧ駩鿫蟭韯鳱駳鏵雷軹틻ꓽ濿氁愃䔅怇欉戋怍甏縑唓攕欗猙笛瀝䴟䜡䨣別稧伩伫崭唯䘱", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)115671164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 128:
								goto IL_1C03;
							case 129:
								num = (short)536936498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 130:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset2 = global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset;
								num = (short)1751515286;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 131:
								try
								{
									num = (short)863502339;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_121E;
										case 1:
											goto IL_1236;
										case 2:
										{
											flag = false;
											num = (short)1244539262;
											short num3 = num;
											num = (short)2115053950;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_11BB;
											default:
												num = (short)1427832832;
												if (num != 0)
												{
												}
												num = (short)81920005;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 3:
											switch (0)
											{
											case 0:
												goto IL_1118;
											}
											continue;
										case 4:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)1770979328;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)928645126;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
											goto IL_11BB;
										case 6:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											if ((((global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current).SecureHardwareEncryptionKeyReferencesList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset).Count > nMaxRecs)
											{
												num = (short)149553154;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_111A:
										num = (short)543948804;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_1118:
										goto IL_111A;
										IL_121E:
										num = (short)106889217;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_11BB:
										goto IL_121E;
									}
									IL_1236:
									goto IL_1E44;
								}
								finally
								{
									num = (short)2066677760;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_126D;
											}
											continue;
										case 1:
											goto IL_12A7;
										case 2:
											enumerator.Dispose();
											num = (short)939524097;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_126D:
										if (enumerator == null)
										{
											break;
										}
										num = (short)1565786114;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_12A7:;
								}
								goto IL_12AA;
							case 132:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset = global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset;
								num = (short)1933574311;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 133:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 10;
									short num5 = (short)474152960;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udc8e얐솒\uda94쎖펠첢키힦슪\udeac\udbae횲횴쒶\udcb8쾺", a_2))
									{
										num5 = (short)241587197;
										short num7 = num5;
										num5 = (short)317936637;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)1172635649;
											if (num5 != 0)
											{
											}
											num5 = (short)817823744;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)1746993215;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A66;
							case 134:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 12;
									short num5 = (short)436994048;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8eﾒ횔ﲜﲞ햠삤쒦\udaa8캪\ud9ac", a_2))
									{
										num5 = (short)1294270465;
										if (num5 != 0)
										{
										}
										num5 = (short)592247382;
										short num7 = num5;
										num5 = (short)634780246;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)632684544;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)1056178388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C03;
							case 135:
								if (nMaxRecs != -1)
								{
									num = (short)1105985648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB;
							case 136:
								if (A_1.recSetCounts != null)
								{
									num = (short)516096034;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17E0;
							case 137:
								goto IL_5BB;
							case 138:
								goto IL_1C03;
							case 139:
								if (nMaxRecs != -1)
								{
									num = (short)2002518190;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_897;
							case 140:
							{
								global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
								if (voiceAnnouncementListRecSet != null)
								{
									num = (short)867500222;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB;
							}
							case 141:
								flag = false;
								num = (short)1812005023;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 142:
								if (A_1.recSetCounts != null)
								{
									num = (short)2012282957;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_275F;
							case 143:
								num = (short)541786339;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 144:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset2;
								if (zoneChannelAssignmentRecset2.Count > nMaxRecs)
								{
									num = (short)1941766231;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC4;
							}
							case 145:
								if (A_1.recSetCounts != null)
								{
									num = (short)390660213;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A66;
							case 146:
								num = (short)586416315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 147:
								if (A_1.recSetCounts != null)
								{
									num = (short)1021575261;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_913;
							case 148:
								if (A_1.recSetCounts != null)
								{
									num = (short)1714356320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_897;
							case 149:
								if (A_1._data == null)
								{
									num = (short)272957598;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)857997379;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 150:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset2;
								if (zoneChannelAssignmentRecset2 != null)
								{
									num = (short)771489958;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC4;
							}
							case 151:
								num = (short)272433387;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 152:
								num = (short)702873789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 153:
								num = (short)1098448898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 154:
								num = (short)922484907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 155:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ낝쎡잣춥솧쒩춫\ud9ad颵﮷햹캻\udbbd蚿ꟁꗃ닅뷇룉꧋뷍ﻏ裑믓룕뷗駙듛뿝軟賡臣諥ꧧ駩鿫蟭韯鳱駳鏵雷軹틻ꓽ濿氁愃䔅怇欉戋怍甏縑唓攕欗猙笛瀝䴟䜡䨣別稧伩伫崭唯䘱", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)2082471941;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 156:
								num = (short)1543438470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 157:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 0;
									short num5 = (short)893648896;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힂쎒ﺞ춠쪢톤\udea6ﮨ캪캬\udcae풰잲", a_2))
									{
										num5 = (short)202645221;
										short num7 = num5;
										num5 = (short)1696866021;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)188088320;
											if (num5 != 0)
											{
											}
											num5 = (short)2119303169;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)2134835218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A4;
							case 158:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset = global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset;
								num = (short)606077043;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 159:
								goto IL_CBE;
							case 160:
								flag = false;
								num = (short)1789722805;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 161:
								if (A_1._data == null)
								{
									num = (short)594018501;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1705640004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 162:
								if (flag)
								{
									num = (short)990052520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E44;
							case 163:
								num = (short)432210018;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 164:
								if (nMaxRecs != -1)
								{
									num = (short)1793654976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E44;
							case 165:
								goto IL_1E44;
							case 166:
								num = (short)1424883812;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 167:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
								if (trunkingPersonalityRecset != null)
								{
									num = (short)1080230112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A4;
							}
							case 168:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ낝쎡잣춥솧쒩춫\ud9ad颵﮷햹캻\udbbd蚿ꟁꗃ닅뷇룉꧋뷍ﻏ臑뇓뗕귗꣙맛闝귟ꓡ듣铥蟧賩藫苭闯\udcf1ꟳ鏵鯷迹軻鯽䣿持瘃戅缇欉縋欍唏簑眓搕愗標栛眝伟䰡漣䌥儧砩䤫䠭唯䀱儳堵嬷弹伻爽⤿ㅁぃཅ♇⑉⥋㱍ɏ㝑㝓╕㵗⹙", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)1656619157;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 169:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 2;
									short num5 = (short)215941120;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄ﺊﾌ\ud990漢爵춢욤햦킨\udbaa\ud9ac욮\udeb0\uddb2ﺴ튶삸\ud8bc\ud9be꓀뇂ꃄ꧆꫈껊뻌菎룐ꃒꇔ黖럘뗚룜귞돠蛢蛤铦賨鿪", a_2))
									{
										num5 = (short)1237472542;
										short num7 = num5;
										num5 = (short)1513903390;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)1462304769;
											if (num5 != 0)
											{
											}
											num5 = (short)1443627008;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)194445438;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E44;
							case 170:
								flag = false;
								num = (short)299237594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 171:
								if (nMaxRecs != -1)
								{
									num = (short)1872035918;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A66;
							case 172:
							{
								global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
								if (uclContactRecset != null)
								{
									num = (short)2118713567;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C03;
							}
							case 173:
								num = (short)149356757;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 174:
								num = (short)1437532199;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 175:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)1804533772;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_275F;
							case 176:
								if (A_1._data == null)
								{
									num = (short)1433927895;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)102170844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 177:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ낝쎡잣춥솧쒩춫\ud9ad颵﮷햹캻\udbbd蚿ꟁꗃ닅뷇룉꧋뷍ﻏ金믓룕껗뿙닛ꫝ觟跡諣蟥蓧맩闫鷭蓯韱駳\ud8f5믷闹鋻製旿氁瀃漅朇搉洋戍䌏欑朓戕紗眙丛笝䌟儡䄣別", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)887881787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 178:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)983498906;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A66;
							case 179:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)1609629839;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17E0;
							case 180:
								flag = false;
								num = (short)1700462617;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 181:
								goto IL_897;
							case 182:
							{
								global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
								if (voiceAnnouncementListRecSet.Count > nMaxRecs)
								{
									num = (short)833683574;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB;
							}
							case 183:
								goto IL_1A66;
							case 184:
								flag = false;
								num = (short)545390595;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 185:
								goto IL_913;
							case 186:
								if (flag)
								{
									num = (short)1235550363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_897;
							case 187:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
								if (!channelAssignmentListInnerRecset.HiddenStatic)
								{
									num = (short)1514471493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_275F;
							}
							case 188:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
								if (!trunkingSystemRecset.HiddenStatic)
								{
									num = (short)933167267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CBE;
							}
							case 189:
								if (nMaxRecs != -1)
								{
									num = (short)101449789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E44;
							case 190:
								num = (short)1677721688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 191:
								if (nMaxRecs != -1)
								{
									num = (short)2057044033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CBE;
							case 192:
								num = (short)1341128873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 193:
								if (nMaxRecs != -1)
								{
									num = (short)1506410558;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC4;
							case 194:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ낝쎡잣춥솧쒩춫\ud9ad颵﮷햹캻\udbbd蚿ꟁꗃ닅뷇룉꧋뷍ﻏ鏑蟓苕諗闙裛뿝賟觡菣铥蟧鿩鳫ꋭ駯臱胳\ud8f5맷꧹ꣻ곽俿嘁攃樅指洉縋愍攏我堓缕欗渙丛笝䌟儡䄣別", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)2110783509;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 195:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset)[0][10040].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset;
								num = (short)2045181962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 196:
								num = (short)1375272983;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 197:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset;
								num = (short)7798986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 198:
								if (nMaxRecs != -1)
								{
									num = (short)1193934959;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_897;
							case 199:
								goto IL_275F;
							case 200:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
								if (channelAssignmentListInnerRecset != null)
								{
									num = (short)1822687378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_275F;
							}
							case 201:
								strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ낝쎡잣춥솧쒩춫\ud9ad颵﮷햹캻\udbbd蚿ꟁꗃ닅뷇룉꧋뷍ﻏ臑뇓뗕귗꣙맛觝觟蛡臣죥귧蓩迫鳭觯英胳鿵韷铹럻鯽秿丁洃甅簇䌉戋怍甏怑䘓猕笗椙礛樝", a_);
								nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
								num = (short)1115881597;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 202:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
								if (trunkingSystemRecset != null)
								{
									num = (short)79364123;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CBE;
							}
							case 203:
							{
								global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet = global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet;
								num = (short)1112801420;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 204:
								flag = false;
								num = (short)637075572;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 205:
								flag = false;
								num = (short)593756298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 206:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
								if (!trunkingPersonalityRecset.HiddenStatic)
								{
									num = (short)1986068631;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A4;
							}
							case 207:
								if (A_1._data == null)
								{
									num = (short)133693643;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1770324012;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 208:
								if (nMaxRecs != -1)
								{
									num = (short)613416961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17E0;
							case 209:
								num = (short)1993212134;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 210:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)1124139092;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BC4;
							case 211:
								num = (short)1869938782;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 212:
								flag = false;
								num = (short)693698688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 213:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)1484128465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB;
							case 214:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
								if (trunkingPersonalityRecset.Count > nMaxRecs)
								{
									num = (short)1243349075;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A4;
							}
							case 215:
							{
								global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset = global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset;
								num = (short)501809324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 216:
								if (A_1.recSetCounts.Count > 0)
								{
									num = (short)422379558;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_897;
							case 217:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
								if (astrotalkgroupListRecset != null)
								{
									num = (short)2119434312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A66;
							}
							case 218:
								goto IL_897;
							case 219:
								if (A_1.recSetCounts.Find(delegate(global::SpecialFeatures.Clone_Configuration.Common.AstroRecSetCountsItem x)
								{
									int a_2 = 14;
									short num5 = (short)1963524096;
									short num6 = num5;
									if (x._recSetName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("자ﲒﲔﲘ\uda9a캠횢쮤쒦첨욪좬솮얰ﾲ\udcb4쒶춸\ud8bc\udcbe鋀ꛂ뇄", a_2))
									{
										num5 = (short)691097055;
										short num7 = num5;
										num5 = (short)722947551;
										switch ((num7 == num5) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num5 = (short)1582104576;
											if (num5 != 0)
											{
											}
											num5 = (short)1502085121;
											if (num5 != 0)
											{
											}
											return x._count > nMaxRecs;
										}
									}
									return false;
								}) != null)
								{
									num = (short)74645517;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB;
							case 220:
								if (A_1.recSetCounts != null)
								{
									num = (short)1172766931;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1C03;
							case 221:
								if (CS$<>8__locals2.nMaxPoolRecs != -1)
								{
									num = (short)1599275242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_275F;
							case 222:
								num = (short)1210122325;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 223:
								num = (short)124518447;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 224:
								num = (short)2088632526;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 225:
								num = (short)722796758;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 226:
								num = (short)1590886460;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 227:
								if (nMaxRecs != -1)
								{
									num = (short)1038417937;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17E0;
							case 228:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
								if (zoneChannelAssignmentRecset.Count > nMaxRecs)
								{
									num = (short)2114453664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_897;
							}
							case 229:
								goto IL_BC4;
							case 230:
								if (nMaxRecs != -1)
								{
									num = (short)1704853577;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB;
							case 231:
								num = (short)1452081197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 232:
								num = (short)1602879645;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 233:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
								if (astrotalkgroupListRecset.Count > nMaxRecs)
								{
									num = (short)1666973802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1A66;
							}
							case 234:
								num = (short)1804861454;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 235:
								if (nMaxRecs != -1)
								{
									num = (short)19988705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17A4;
							case 236:
								flag = false;
								num = (short)1076035617;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 237:
								flag = false;
								num = (short)550502429;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 238:
								if (nMaxRecs != -1)
								{
									num = (short)1428422667;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_913;
							}
							goto IL_40C;
							IL_5BB:
							num = (short)1294729222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_897:
							num = (short)767426569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_913:
							num = (short)721223800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BC4:
							num = (short)963444792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_CBE:
							num = (short)456392739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_12AA:
							flag = false;
							num = (short)849543225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_17A4:
							num = (short)911147083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_17E0:
							num = (short)1823801506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1A66:
							num = (short)1680605210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1C03:
							num = (short)1507066042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1E44:
							num = (short)1478950994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_275F:
							num = (short)581042271;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2778:
						goto IL_27E5;
						IL_40C:
						strFullyQualifiedRecordsetName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍ﾏﮓﶛ낝쎡잣춥솧쒩춫\ud9ad颵﮷햹캻\udbbd蚿ꟁꗃ닅뷇룉꧋뷍ﻏ蛑ꛓꏕ뛗뇙뗛냝蟟뇡鷣闥鳧迩臫샭ꓯ胱至飵鏷鏹鋻駽叿笁眃爅洇有帋欍猏愑焓戕", a_);
						nMaxRecs = modelTiering.GetRecordsetDataFromEngine(strFullyQualifiedRecordsetName, global::SpecialFeatures.Model_Configuration.ModelTiering.RecsetAttributeTypes.MaxRecords);
						num = (short)1293680801;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_49;
					}
					finally
					{
						num = (short)1282539520;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_27AC;
								}
								continue;
							case 1:
								goto IL_27E2;
							case 2:
								((global::System.IDisposable)modelTiering).Dispose();
								num = (short)1830223873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_27AC:
							if (modelTiering == null)
							{
								break;
							}
							num = (short)1573912578;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_27E2:;
					}
					IL_27E5:;
				}
				catch (global::System.Exception)
				{
					flag = false;
				}
				num = (short)490471424;
				short num4 = num;
				num = (short)782172161;
				if (num != 0)
				{
				}
				return flag;
			}
			}
		}
	}
}
