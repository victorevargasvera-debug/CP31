using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using AcpUtility;
using ASK.Interface;
using Motorola.CommonCPS.ResourceRepository;
using RMIBtnWrapperLib;
using RMKeyValidatorLib;

namespace ASK.Core
{
	// Token: 0x0200001F RID: 31
	public class KeyRecordSet
	{
		// Token: 0x06000151 RID: 337 RVA: 0x00025D0C File Offset: 0x00023F0C
		public KeyRecordSet()
		{
			this.d = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyRecord>();
			this.e = new global::System.Collections.ObjectModel.ObservableCollection<global::RMKeyValidatorLib.AcpiButton>();
			if (global::ASK.Core.KeyRecordSet.a == null)
			{
				global::ASK.Core.KeyRecordSet.a = new global::System.Collections.ArrayList();
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00025D4C File Offset: 0x00023F4C
		internal bool a(global::ASK.Core.AccessLevelDataRecordSet A_0)
		{
			short num = (short)985399296;
			short num2 = num;
			num = (short)1536312104;
			short num3 = num;
			num = (short)1948468008;
			switch (num3 == num)
			{
			}
			num = (short)960888833;
			if (num != 0)
			{
			}
			num = (short)1960509440;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00025DF8 File Offset: 0x00023FF8
		public bool ReadAlliBtnKeys(global::RMIBtnWrapperLib.IIBtnWrapper spIBtn, global::RMKeyValidatorLib.HardwareKeyType keyTypeToLoad, bool bReadMasterKeys, bool bValidatePassword, global::ASK.Core.AccessLevelDataRecordSet pRsAccess, ref bool bOpen, ref bool bISR, ref global::System.Collections.ObjectModel.Collection<global::ASK.Core.StatusMsg> status, bool bASKCalling = false)
		{
			int a_ = 7;
			short num = (short)699738589;
			short num2 = num;
			num = (short)1100491229;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1428226048;
				short num3 = num;
				num = (short)762707968;
				if (num != 0)
				{
				}
				num = (short)1635057664;
				num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			switch (0)
			{
			case 0:
				goto IL_C6;
			}
			bool flag;
			global::RMIBtnWrapperLib.MultiBtnWrapper multiBtnWrapper;
			global::ASK.Core.HardwareKey hardwareKey;
			bool bAddAccessLevel;
			bool result;
			short num8;
			short num9;
			for (;;)
			{
				IL_A3:
				switch (num4)
				{
				case 0:
					goto IL_FD;
				case 1:
					goto IL_FD;
				case 2:
					num = (short)1318584323;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (flag)
					{
						num = (short)2029912070;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)443482116;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_216;
						}
						short num7;
						for (;;)
						{
							IL_1BF:
							short num5;
							switch (num4)
							{
							case 0:
								if (multiBtnWrapper.PortType == 6)
								{
									num = (short)1416757260;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_E2A;
							case 1:
								goto IL_F1B;
							case 2:
								if (num5 <= 15)
								{
									num = (short)1831796740;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F01;
							case 3:
								num = (short)17498127;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)580255749;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								if (flag)
								{
									num = (short)1345847309;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								multiBtnWrapper.PortNumber = num5;
								bool flag2 = multiBtnWrapper.FindFirstBtn(255);
								num = (short)1196163090;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								bool flag2 = multiBtnWrapper.FindNextBtn();
								num = (short)971374606;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_266;
							case 8:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_43A;
									}
									global::RMKeyValidatorLib.AcpiButton acpiButton;
									for (;;)
									{
										IL_38B:
										global::ASK.Core.IKeyRecord keyRecord;
										switch (num4)
										{
										case 0:
											goto IL_98C;
										case 1:
											if (status != null)
											{
												num = (short)698351650;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_D83;
										case 2:
										{
											string empty;
											hardwareKey.WriteMASKToIBtn(multiBtnWrapper, empty, hardwareKey.ExpirationType, hardwareKey.DaysToExpiration, 0, ref bOpen);
											num = (short)1186005010;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											goto IL_D83;
										case 4:
										{
											global::ASK.Core.StatusMsg statusMsg;
											if (statusMsg != null)
											{
												num = (short)1367080980;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_D83;
										}
										case 5:
											try
											{
												num = (short)1257242629;
												num4 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num4)
													{
													case 0:
													{
														global::ASK.Core.HardwareKey hardwareKey2;
														if (hardwareKey2.SerialNumber == ((global::ASK.Core.HardwareKey)keyRecord).SerialNumber)
														{
															num = (short)1829634049;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														break;
													}
													case 1:
													{
														global::ASK.Core.HardwareKey hardwareKey2;
														global::ASK.Core.HardwareKey item = hardwareKey2;
														bool flag3 = true;
														num = (short)1793785859;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 2:
													{
														global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyRecord> enumerator;
														if (!enumerator.MoveNext())
														{
															num = (short)859308036;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::ASK.Core.HardwareKey hardwareKey2 = (global::ASK.Core.HardwareKey)enumerator.Current;
														num = (short)1327693824;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 4:
														num = (short)1635844102;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 5:
														switch (0)
														{
														case 0:
															goto IL_72F;
														}
														continue;
													case 6:
														goto IL_7FE;
													}
													IL_7A8:
													num = (short)1109590018;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_72F:
													goto IL_7A8;
												}
												IL_7FE:
												goto IL_D46;
											}
											finally
											{
												num = (short)1165295618;
												num4 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyRecord> enumerator;
													switch (num4)
													{
													case 0:
														goto IL_86F;
													case 1:
														enumerator.Dispose();
														num = (short)1872363520;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_836;
														}
														continue;
													}
													IL_836:
													if (enumerator == null)
													{
														break;
													}
													num = (short)121765889;
													num4 = (int)((global::System.IntPtr)num);
												}
												IL_86F:;
											}
											goto IL_872;
											IL_D46:
											num = (short)1401749533;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
										{
											hardwareKey.EraseData(ref multiBtnWrapper);
											string message = global::Motorola.CommonCPS.ResourceRepository.Resources.HighWaterMark_Security_Violation.AcpStringFormat(new object[]
											{
												hardwareKey.SerialNumber
											});
											status.Add(new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, message, 3758129166U));
											num = (short)751828992;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 7:
											goto IL_98C;
										case 8:
											if (!this.a(multiBtnWrapper, out acpiButton))
											{
												num = (short)843710483;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)440860699;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 9:
										{
											string empty;
											if (hardwareKey.GetPswdFromIBtn(multiBtnWrapper, ref empty) == 0U)
											{
												num = (short)1195900930;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											bool flag2 = false;
											num = (short)1510998023;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 10:
										{
											bool flag2;
											if (flag2)
											{
												num = (short)152371239;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_646;
										}
										case 11:
											goto IL_646;
										case 12:
											if (hardwareKey.HighWaterMarkSupported(ref hardwareKey, ref multiBtnWrapper))
											{
												num = (short)1932132393;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_98C;
										case 13:
											goto IL_D83;
										case 14:
											if ((keyTypeToLoad & global::RMKeyValidatorLib.HardwareKeyType.ADVANCED_SYSTEM_KEY) != global::RMKeyValidatorLib.HardwareKeyType.UNKOWN)
											{
												num = (short)197656599;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)172228609;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 15:
										{
											global::ASK.Core.HardwareKey item;
											this.d.Remove(item);
											num = (short)739311653;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 16:
											goto IL_872;
										case 17:
											goto IL_D83;
										case 18:
											goto IL_98C;
										case 19:
											num = (short)642777102;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 20:
										{
											global::ASK.Core.StatusMsg statusMsg;
											status.Add(statusMsg);
											num = (short)1354694669;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 21:
										{
											bool flag4;
											if (flag4)
											{
												num = (short)813826084;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_872;
										}
										case 22:
											status.Add(new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, global::Motorola.CommonCPS.ResourceRepository.Resources.iButton_Invalid, 3758129160U));
											num = (short)1028849681;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 23:
										{
											global::ASK.Core.StatusMsg statusMsg = null;
											keyRecord = new global::ASK.Core.HardwareKey();
											bool flag2 = ((global::ASK.Core.HardwareKey)keyRecord).ReadiBtnKey(multiBtnWrapper, bReadMasterKeys, bValidatePassword, pRsAccess, ref bOpen, ref bISR, out statusMsg, bASKCalling, bAddAccessLevel);
											num = (short)567803932;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 24:
											try
											{
												num = (short)32833536;
												num4 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num4)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_A62;
														}
														continue;
													case 1:
														goto IL_B25;
													case 2:
														goto IL_B0C;
													case 3:
													{
														global::System.Collections.Generic.IEnumerator<global::RMKeyValidatorLib.AcpiButton> enumerator2;
														if (!enumerator2.MoveNext())
														{
															num = (short)977797125;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::RMKeyValidatorLib.AcpiButton acpiButton2 = enumerator2.Current;
														num = (short)2067070980;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 4:
													{
														global::RMKeyValidatorLib.AcpiButton acpiButton2;
														if (acpiButton2.SerialNumber == acpiButton.SerialNumber)
														{
															num = (short)969474054;
															num4 = (int)((global::System.IntPtr)num);
															continue;
														}
														break;
													}
													case 5:
														goto IL_B0C;
													case 6:
													{
														global::RMKeyValidatorLib.AcpiButton acpiButton2;
														global::RMKeyValidatorLib.AcpiButton item2 = acpiButton2;
														bool flag4 = true;
														num = (short)251330562;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													}
													}
													IL_AAF:
													num = (short)495517699;
													num4 = (int)((global::System.IntPtr)num);
													continue;
													IL_A62:
													goto IL_AAF;
													IL_B0C:
													num = (short)12058625;
													num4 = (int)((global::System.IntPtr)num);
												}
												IL_B25:
												goto IL_551;
											}
											finally
											{
												num = (short)1903951874;
												num4 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													global::System.Collections.Generic.IEnumerator<global::RMKeyValidatorLib.AcpiButton> enumerator2;
													switch (num4)
													{
													case 0:
														goto IL_B95;
													case 1:
														enumerator2.Dispose();
														num = (short)1967259648;
														num4 = (int)((global::System.IntPtr)num);
														continue;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_B5D;
														}
														continue;
													}
													IL_B5D:
													if (enumerator2 == null)
													{
														break;
													}
													num = (short)1632436225;
													num4 = (int)((global::System.IntPtr)num);
												}
												IL_B95:;
											}
											goto IL_B98;
											IL_551:
											num = (short)1004929045;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 25:
										{
											string empty = string.Empty;
											num = (short)1059127305;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 26:
											goto IL_D83;
										case 27:
											if ((keyTypeToLoad & acpiButton.KeyType) != global::RMKeyValidatorLib.HardwareKeyType.UNKOWN)
											{
												num = (short)2061697062;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)41091107;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 28:
										{
											bool flag2;
											if (flag2)
											{
												num = (short)201719838;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_98C;
										}
										case 29:
										{
											bool flag3;
											if (flag3)
											{
												num = (short)2101870607;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_6C1;
										}
										case 30:
											goto IL_B98;
										case 31:
										{
											if (hardwareKey.Version == 5)
											{
												num = (short)73400345;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::ASK.Core.StatusMsg statusMsg;
											bool flag2 = hardwareKey.WriteiBtnKey(multiBtnWrapper, ref bOpen, false, 1, global::ASK.Interface.OpenMode.IBTN_OPEN_WRITE, pRsAccess, out statusMsg);
											num = (short)1999568936;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 32:
										{
											bool flag2;
											if (!flag2)
											{
												num = (short)419299334;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)736165919;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 33:
											goto IL_D9B;
										case 34:
											status.Add(new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, global::Motorola.CommonCPS.ResourceRepository.Resources.iButton_Invalid, 3758129160U));
											num = (short)491585539;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 35:
											if (status != null)
											{
												num = (short)1531183126;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_D83;
										case 36:
										{
											global::RMKeyValidatorLib.AcpiButton item2;
											this.e.Remove(item2);
											num = (short)165281808;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 37:
											goto IL_6C1;
										case 38:
										{
											global::RMKeyValidatorLib.AcpiButton item2 = null;
											bool flag4 = false;
											global::System.Collections.Generic.IEnumerator<global::RMKeyValidatorLib.AcpiButton> enumerator2 = this.e.GetEnumerator();
											num = (short)1556348952;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 39:
										{
											bool flag3 = false;
											global::ASK.Core.HardwareKey item = null;
											global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyRecord> enumerator = this.d.GetEnumerator();
											num = (short)627834885;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 40:
											goto IL_98C;
										case 41:
										{
											bool flag2 = hardwareKey.HighWaterMarkValidation(hardwareKey.LastDateProgrammed);
											num = (short)989790240;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										goto IL_43A;
										IL_646:
										num = (short)175964164;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_6C1:
										this.d.Add(keyRecord);
										result = true;
										num = (short)1949433867;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_872:
										this.e.Add(acpiButton);
										result = true;
										num = (short)723910682;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_98C:
										num = (short)1686765578;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_B98:
										hardwareKey = (global::ASK.Core.HardwareKey)keyRecord;
										num = (short)134873100;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_D83:
										num = (short)346619937;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_D9B:
									goto IL_EC7;
									IL_43A:
									acpiButton = null;
									num = (short)2146304008;
									num4 = (int)((global::System.IntPtr)num);
									goto IL_38B;
								}
								catch (global::System.Exception ex)
								{
									if (ex.Data != null)
									{
										uint num6 = (uint)ex.Data[global::ASK.Core.StatusMsg.b("ق㝄㕆♈㥊์⁎㕐㙒", a_)];
										if (num6 != 2684387329U)
										{
											if (num6 != 2684387332U)
											{
												goto IL_DE9;
											}
										}
										flag = true;
									}
									IL_DE9:
									goto IL_EC7;
								}
								goto IL_DEE;
								IL_EC7:
								num = (short)1910177801;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								if (!flag)
								{
									num = (short)694288390;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_E8C;
							case 10:
								goto IL_E0C;
							case 11:
								goto IL_E2A;
							case 12:
								goto IL_DEE;
							case 13:
								goto IL_F01;
							case 14:
								goto IL_E8C;
							case 15:
								if (flag)
								{
									num = (short)588972051;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_E0C;
							case 16:
							{
								bool flag2;
								if (flag2)
								{
									num = (short)716767235;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_31F;
							}
							case 17:
								goto IL_266;
							case 18:
							{
								bool flag2;
								if (flag2)
								{
									num = (short)402063370;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_31F;
							}
							case 19:
								goto IL_31F;
							}
							goto IL_216;
							IL_266:
							num = (short)1333133314;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_31F:
							num5 += 1;
							num = (short)709623815;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_DEE:
							num7 = 2;
							num = (short)643039243;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_E0C:
							num = (short)1042939912;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_E2A:
							num5 = num7;
							num = (short)1797849105;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_E8C:
							num = (short)615317520;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_F01:
							num = (short)1182466049;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_F1B:
						goto IL_F85;
						IL_216:
						multiBtnWrapper.PortType = num8;
						multiBtnWrapper.CreateButton();
						num7 = 1;
						num = (short)197328896;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_1BF;
					}
					catch (global::System.AccessViolationException ex2)
					{
						string message2 = global::ASK.Core.StatusMsg.b("ᅂ⁄♆ⵈ歊⑌ൎ⑐❒⅔㡖㝘筚㡜ⵞ፠ౢᝤ嵦䥨", a_) + ex2.Message;
						new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, message2, 1610645507U);
						throw ex2;
					}
					catch (global::System.Exception ex3)
					{
						string message3 = global::ASK.Core.StatusMsg.b("ᅂ⁄♆ⵈ歊⑌ൎ⑐❒⅔㡖㝘筚㡜ⵞ፠ౢᝤ嵦䥨", a_) + ex3.Message;
						new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Error, message3, 1610645507U);
					}
					finally
					{
						multiBtnWrapper.CloseButton();
						bOpen = false;
					}
					IL_F85:
					num8 += 4;
					num = (short)1159921664;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (num8 <= num9)
					{
						num = (short)1993146370;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 6:
					goto IL_189;
				}
				goto IL_C6;
				IL_FD:
				num = (short)1354301445;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_189:
			num = (short)1749942273;
			if (num != 0)
			{
			}
			return result;
			IL_C6:
			result = false;
			bAddAccessLevel = true;
			short num10 = 2;
			num9 = 2;
			num9 = 6;
			multiBtnWrapper = (global::RMIBtnWrapperLib.MultiBtnWrapper)spIBtn;
			hardwareKey = new global::ASK.Core.HardwareKey();
			flag = false;
			num8 = num10;
			num = (short)90832897;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A3;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00026E44 File Offset: 0x00025044
		internal bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, bool A_1, int A_2, ref bool A_3, global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyDataRecord> A_4, global::ASK.Core.AccessLevelDataRecordSet A_5, out global::ASK.Core.StatusMsg A_6)
		{
			int a_ = 8;
			short num = (short)70582272;
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
				bool result;
				bool flag2;
				global::RMIBtnWrapperLib.MultiBtnWrapper multiBtnWrapper;
				short num7;
				short num8;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_8E;
					case 1:
						goto IL_8E;
					case 2:
						return result;
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_1CD;
							}
							short num6;
							for (;;)
							{
								IL_176:
								short num3;
								switch (num2)
								{
								case 0:
								{
									bool flag;
									if (flag)
									{
										num = (short)1795031047;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D1;
								}
								case 1:
									goto IL_640;
								case 2:
									goto IL_56F;
								case 3:
									num = (short)934674436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (flag2)
									{
										num = (short)1879900161;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									multiBtnWrapper.PortNumber = num3;
									bool flag = multiBtnWrapper.FindFirstBtn(255);
									num = (short)1680080896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_532;
								case 6:
									try
									{
										global::ASK.Core.IKeyRecord keyRecord = new global::ASK.Core.HardwareKey();
										global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator = A_4.GetEnumerator();
										try
										{
											num = (short)16515076;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													num = (short)711458819;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
												{
													if (!enumerator.MoveNext())
													{
														num = (short)394264576;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::ASK.Core.KeyDataRecord item = (global::ASK.Core.KeyDataRecord)enumerator.Current;
													keyRecord.KeyDataList.Add(item);
													num = (short)352976897;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													goto IL_406;
												case 4:
													switch (0)
													{
													case 0:
														goto IL_37D;
													}
													continue;
												}
												IL_3B4:
												num = (short)2071134210;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_37D:
												goto IL_3B4;
											}
											IL_406:;
										}
										finally
										{
											for (;;)
											{
												IL_40B:
												num = (short)392691714;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														enumerator.Dispose();
														num = (short)825425921;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 1:
														goto IL_4C5;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_43D;
														}
														continue;
													}
													IL_43D:
													num = (short)1803533440;
													short num4 = num;
													num = (short)1545059456;
													switch ((num4 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_40B;
													default:
														num = (short)1598947328;
														if (num != 0)
														{
														}
														if (enumerator == null)
														{
															goto IL_4C7;
														}
														num = (short)203161600;
														num2 = (int)((global::System.IntPtr)num);
														break;
													}
												}
											}
											IL_4C5:
											IL_4C7:;
										}
										bool flag = ((global::ASK.Core.HardwareKey)keyRecord).WriteiBtnKey(multiBtnWrapper, ref A_3, A_1, A_2, global::ASK.Interface.OpenMode.IBTN_OPEN_WRITE, A_5, out A_6);
										goto IL_607;
									}
									catch (global::System.Exception ex)
									{
										if (ex.Data != null)
										{
											uint num5 = (uint)ex.Data[global::ASK.Core.StatusMsg.b("Ń㑅㩇╉㹋്㽏㙑ㅓ", a_)];
											if (num5 != 2684387329U)
											{
												if (num5 != 2684387332U)
												{
													goto IL_52D;
												}
											}
											flag2 = true;
										}
										IL_52D:
										goto IL_607;
									}
									goto IL_532;
									IL_607:
									num = (short)925302793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_550;
								case 8:
									if (multiBtnWrapper.PortType == 6)
									{
										num = (short)1187905541;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_56F;
								case 9:
									if (!flag2)
									{
										num = (short)2555916;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5CC;
								case 10:
									goto IL_2D1;
								case 11:
								{
									bool flag;
									if (flag)
									{
										num = (short)294256656;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D1;
								}
								case 12:
								{
									bool flag = multiBtnWrapper.FindNextBtn();
									num = (short)281083922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									goto IL_21D;
								case 14:
									goto IL_21D;
								case 15:
									goto IL_659;
								case 16:
									num = (short)149422097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (flag2)
									{
										num = (short)1943404554;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_550;
								case 18:
									goto IL_5CC;
								case 19:
									if (num3 <= 15)
									{
										num = (short)469893123;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_640;
								}
								goto IL_1CD;
								IL_21D:
								num = (short)226951187;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D1:
								num3 += 1;
								num = (short)1389559821;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_532:
								num6 = 2;
								num = (short)8847362;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_550:
								num = (short)1461190662;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_56F:
								num3 = num6;
								num = (short)138936334;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5CC:
								num = (short)1639317515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_640:
								num = (short)1619787791;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_659:
							goto IL_689;
							IL_1CD:
							multiBtnWrapper.PortType = num7;
							multiBtnWrapper.CreateButton();
							num6 = 1;
							num = (short)339345416;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_176;
						}
						catch (global::System.Exception ex2)
						{
							global::System.Diagnostics.Trace.WriteLine(global::ASK.Core.StatusMsg.b("ᙃ⍅⥇⹉汋❍቏❑⁓≕㝗㑙籛㭝቟ၡୣᑥ剧䩩", a_) + ex2.Message);
						}
						finally
						{
							multiBtnWrapper.CloseButton();
							A_3 = false;
						}
						IL_689:
						num7 += 4;
						num = (short)1911488513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (num7 <= num8)
						{
							num = (short)2055536646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
					{
						if (flag2)
						{
							num = (short)997654530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)27459584;
						short num9 = num;
						num = (short)63045635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)326828033;
						if (num != 0)
						{
						}
						num = (short)764411909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_53;
					IL_8E:
					num = (short)1142489092;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_53:
				A_6 = new global::ASK.Core.StatusMsg(global::ASK.Core.AskStatusType.Info, "", 0U);
				result = false;
				short num10 = 2;
				num8 = 2;
				num8 = 6;
				multiBtnWrapper = (global::RMIBtnWrapperLib.MultiBtnWrapper)A_0;
				flag2 = true;
				num7 = num10;
				num = (short)665976832;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00027564 File Offset: 0x00025764
		internal static void e(string A_0)
		{
			short num = (short)1136371829;
			short num2 = num;
			num = (short)1208461429;
			switch (num2 == num)
			{
			}
			num = (short)831127553;
			if (num != 0)
			{
			}
			num = (short)1764950016;
			short num3 = num;
			num = (short)1368391680;
			if (num != 0)
			{
			}
			global::ASK.Core.KeyRecordSet.a.Add(A_0);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00027618 File Offset: 0x00025818
		internal static global::System.Collections.ArrayList ExpiredSerialNumList
		{
			get
			{
				short num = (short)750267110;
				short num2 = num;
				num = (short)1381903078;
				switch (num2 == num)
				{
				}
				num = (short)1300758529;
				if (num != 0)
				{
				}
				num = (short)1829306368;
				short num3 = num;
				num = (short)477298688;
				if (num != 0)
				{
				}
				return global::ASK.Core.KeyRecordSet.a;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000276C4 File Offset: 0x000258C4
		internal static void d(string A_0)
		{
			short num = (short)64880641;
			if (num != 0)
			{
			}
			num = (short)1948976472;
			short num2 = num;
			num = (short)1575224664;
			switch (num2 == num)
			{
			}
			num = (short)2041249792;
			short num3 = num;
			num = (short)1886453760;
			if (num != 0)
			{
			}
			global::ASK.Core.KeyRecordSet.c.Add(A_0, A_0);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0002777C File Offset: 0x0002597C
		internal static bool c(string A_0)
		{
			short num = (short)43290614;
			short num2 = num;
			num = (short)2014810102;
			switch (num2 == num)
			{
			}
			num = (short)1796734977;
			if (num != 0)
			{
			}
			num = (short)1713831936;
			short num3 = num;
			num = (short)1415380992;
			if (num != 0)
			{
			}
			return global::ASK.Core.KeyRecordSet.c.ContainsKey(A_0);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00027830 File Offset: 0x00025A30
		internal static void b(string A_0)
		{
			short num = (short)830829383;
			short num2 = num;
			num = (short)559248199;
			switch (num2 == num)
			{
			}
			num = (short)898760705;
			if (num != 0)
			{
			}
			num = (short)1510801408;
			short num3 = num;
			num = (short)937951232;
			if (num != 0)
			{
			}
			global::ASK.Core.KeyRecordSet.b.Add(A_0, global::System.DateTime.Now);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000278E8 File Offset: 0x00025AE8
		internal static global::System.Collections.Generic.Dictionary<string, global::System.DateTime> LockedOutKeyList
		{
			get
			{
				short num = (short)588977837;
				short num2 = num;
				num = (short)547231405;
				switch (num2 == num)
				{
				}
				num = (short)1276837889;
				if (num != 0)
				{
				}
				num = (short)254017536;
				short num3 = num;
				num = (short)845742080;
				if (num != 0)
				{
				}
				return global::ASK.Core.KeyRecordSet.b;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00027998 File Offset: 0x00025B98
		internal static bool a(string A_0)
		{
			int num;
			short num2;
			bool result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::System.TimeSpan timeSpan;
						if (timeSpan.TotalSeconds < 600.0)
						{
							num2 = (short)1734606849;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)746323968;
						short num3 = num2;
						global::ASK.Core.KeyRecordSet.b.Remove(A_0);
						result = false;
						num2 = (short)1097269250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						result = true;
						num2 = (short)1858666499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_B4;
					case 3:
						return result;
					case 4:
					{
						global::System.TimeSpan timeSpan = global::System.DateTime.Now.Subtract(global::ASK.Core.KeyRecordSet.b[A_0]);
						num2 = (short)455999488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						if (global::ASK.Core.KeyRecordSet.b.ContainsKey(A_0))
						{
							num2 = (short)1183121412;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_28;
				}
				IL_B4:
				num2 = (short)1825787788;
				short num4 = num2;
				num2 = (short)1714179980;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2A;
				default:
					num2 = (short)1277362177;
					if (num2 != 0)
					{
					}
					num2 = (short)1068695552;
					if (num2 != 0)
					{
					}
					break;
				}
				return result;
			}
			}
			IL_28:
			result = false;
			IL_2A:
			num2 = (short)945946629;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00027B4C File Offset: 0x00025D4C
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyRecord> KeyList
		{
			get
			{
				short num = (short)1760211335;
				short num2 = num;
				num = (short)560443783;
				switch (num2 == num)
				{
				}
				num = (short)72679425;
				if (num != 0)
				{
				}
				num = (short)905117696;
				short num3 = num;
				num = (short)426770432;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00027BFC File Offset: 0x00025DFC
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyDataRecord> KeyDataList
		{
			get
			{
				short num = (short)304349184;
				switch (num)
				{
				default:
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyDataRecord> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyDataRecord>();
					global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyRecord> enumerator = this.d.GetEnumerator();
					try
					{
						num = (short)1380712452;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_23B;
							case 1:
								try
								{
									num = (short)177340420;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 1:
										{
											global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)571801602;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::ASK.Core.IKeyDataRecord item = enumerator2.Current;
											observableCollection.Add(item);
											num = (short)1975451648;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 2:
											num = (short)630718467;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											goto IL_17E;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_109;
											}
											continue;
										}
										IL_10B:
										num = (short)1929445377;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_109:
										goto IL_10B;
									}
									IL_17E:
									break;
								}
								finally
								{
									for (;;)
									{
										IL_183:
										num = (short)1799356418;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)220790785;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_238;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_1B5;
												}
												continue;
											}
											IL_1B5:
											num = (short)961541298;
											short num3 = num;
											num = (short)851309746;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_183;
											default:
												num = (short)96927744;
												if (num != 0)
												{
												}
												if (enumerator2 == null)
												{
													goto IL_23A;
												}
												num = (short)119472128;
												num2 = (int)((global::System.IntPtr)num);
												break;
											}
										}
									}
									IL_238:
									IL_23A:;
								}
								goto IL_23B;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1833500672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.IEnumerator<global::ASK.Core.IKeyDataRecord> enumerator2 = enumerator.Current.KeyDataList.GetEnumerator();
								num = (short)628424705;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_253;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_6B;
								}
								continue;
							}
							IL_97:
							num = (short)255459330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6B:
							goto IL_97;
							IL_23B:
							num = (short)1816592387;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_253:;
					}
					finally
					{
						num = (short)772800514;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)2091974657;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_2C0;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_288;
								}
								continue;
							}
							IL_288:
							if (enumerator == null)
							{
								break;
							}
							num = (short)48168960;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2C0:;
					}
					num = (short)957415424;
					short num4 = num;
					num = (short)936116225;
					if (num != 0)
					{
					}
					return observableCollection;
				}
				}
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00027F54 File Offset: 0x00026154
		private bool a(global::RMIBtnWrapperLib.IIBtnWrapper A_0, out global::RMKeyValidatorLib.AcpiButton A_1)
		{
			short num = (short)1969487872;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_68;
			}
			int num3;
			bool flag;
			global::RMKeyValidatorLib.AcpiButton acpiButton;
			bool flag2;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					flag = true;
					num = (short)780337159;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					A_1 = acpiButton;
					num = (short)2092105737;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					flag = true;
					num = (short)1620901898;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (acpiButton.IsFTR(A_0))
					{
						num = (short)57016331;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)774701062;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (flag)
					{
						num = (short)7077889;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return flag;
				case 5:
					if (acpiButton.IsLabTool(A_0, out flag2))
					{
						num = (short)1362690050;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FC;
				case 6:
					if (acpiButton.IsDepot(A_0, out flag2))
					{
						num = (short)1893859328;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)973078533;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1FC;
				case 8:
				{
					num = (short)780914169;
					short num4 = num;
					num = (short)786550265;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return flag;
					default:
						num = (short)2086207488;
						if (num != 0)
						{
						}
						goto IL_1FC;
					}
					break;
				}
				case 9:
					return flag;
				case 10:
					goto IL_1FC;
				case 11:
					flag = true;
					num = (short)2045181960;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_68;
				IL_1FC:
				num = (short)1779433476;
				num3 = (int)((global::System.IntPtr)num);
			}
			return flag;
			IL_68:
			num = (short)1396965377;
			if (num != 0)
			{
			}
			flag = false;
			flag2 = false;
			A_1 = null;
			acpiButton = new global::RMKeyValidatorLib.AcpiButton();
			num = (short)1582039043;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000281B0 File Offset: 0x000263B0
		internal global::System.Collections.ObjectModel.ObservableCollection<global::RMKeyValidatorLib.AcpiButton> SpecialKeyList
		{
			get
			{
				short num = (short)1329265603;
				short num2 = num;
				num = (short)1798962115;
				switch (num2 == num)
				{
				}
				num = (short)1418002433;
				if (num != 0)
				{
				}
				num = (short)1537867776;
				short num3 = num;
				num = (short)649854976;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00028260 File Offset: 0x00026460
		// Note: this type is marked as 'beforefieldinit'.
		static KeyRecordSet()
		{
			short num = (short)233555166;
			short num2 = num;
			num = (short)1409074398;
			switch (num2 == num)
			{
			}
			num = (short)1594294273;
			if (num != 0)
			{
			}
			num = (short)1392050176;
			short num3 = num;
			num = (short)1018560512;
			if (num != 0)
			{
			}
			global::ASK.Core.KeyRecordSet.a = null;
			global::ASK.Core.KeyRecordSet.b = new global::System.Collections.Generic.Dictionary<string, global::System.DateTime>();
			global::ASK.Core.KeyRecordSet.c = new global::System.Collections.Generic.Dictionary<string, string>();
		}

		// Token: 0x040000AF RID: 175
		private static global::System.Collections.ArrayList a;

		// Token: 0x040000B0 RID: 176
		private static global::System.Collections.Generic.Dictionary<string, global::System.DateTime> b;

		// Token: 0x040000B1 RID: 177
		private static global::System.Collections.Generic.Dictionary<string, string> c;

		// Token: 0x040000B2 RID: 178
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyRecord> d;

		// Token: 0x040000B3 RID: 179
		private global::System.Collections.ObjectModel.ObservableCollection<global::RMKeyValidatorLib.AcpiButton> e;
	}
}
