using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using AcpCommonResources;
using AcpKeyValidatorLib;
using AcpUtility;
using IBtnWrapperLib;

namespace AcpASKLib
{
	// Token: 0x0200002D RID: 45
	public class KeyRecordSet
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00024944 File Offset: 0x00022B44
		public KeyRecordSet()
		{
			this.d = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyRecord>();
			this.e = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpKeyValidatorLib.AcpiButton>();
			if (global::AcpASKLib.KeyRecordSet.a == null)
			{
				global::AcpASKLib.KeyRecordSet.a = new global::System.Collections.ArrayList();
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00024984 File Offset: 0x00022B84
		internal bool a(global::AcpASKLib.AccessLevelDataRecordSet A_0)
		{
			short num = (short)1447755777;
			if (num != 0)
			{
			}
			num = (short)1465683035;
			short num2 = num;
			num = (short)1796508763;
			switch (num2 == num)
			{
			}
			num = (short)1877999616;
			short num3 = num;
			num = (short)1586167808;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00024A2C File Offset: 0x00022C2C
		internal bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, global::AcpKeyValidatorLib.HardwareKeyType A_1, bool A_2, bool A_3, global::AcpASKLib.AccessLevelDataRecordSet A_4, ref bool A_5, ref bool A_6, ref global::System.Collections.ObjectModel.Collection<global::AcpASKLib.StatusMsg> A_7)
		{
			int a_ = 2;
			short num = (short)1400111104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				global::IBtnWrapperLib.MultiBtnWrapper multiBtnWrapper;
				global::AcpASKLib.HardwareKey hardwareKey;
				bool bASKCalling;
				bool bAddAccessLevel;
				bool result;
				bool flag4;
				short num7;
				short num9;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_8F;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_1D0;
							}
							short num6;
							for (;;)
							{
								IL_179:
								short num5;
								switch (num2)
								{
								case 0:
									goto IL_F13;
								case 1:
									goto IL_223;
								case 2:
									goto IL_E9C;
								case 3:
									goto IL_F2B;
								case 4:
									goto IL_223;
								case 5:
									goto IL_E3D;
								case 6:
								{
									bool flag;
									if (flag)
									{
										num = (short)1807810567;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DC;
								}
								case 7:
									num = (short)1189806092;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_E1E;
								case 9:
									if (multiBtnWrapper.PortType == 6)
									{
										num = (short)610467853;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E3D;
								case 10:
									num = (short)1010106382;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_3F8;
										}
										global::AcpKeyValidatorLib.AcpiButton acpiButton;
										for (;;)
										{
											IL_349:
											global::AcpASKLib.IKeyRecord keyRecord;
											switch (num2)
											{
											case 0:
												goto IL_D96;
											case 1:
												goto IL_BAB;
											case 2:
												if ((A_1 & acpiButton.KeyType) != global::AcpKeyValidatorLib.HardwareKeyType.UNKOWN)
												{
													num = (short)1899167773;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1569390612;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												goto IL_944;
											case 4:
												goto IL_602;
											case 5:
											{
												global::AcpASKLib.StatusMsg statusMsg;
												if (statusMsg != null)
												{
													num = (short)1365770252;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_D96;
											}
											case 6:
											{
												bool flag = hardwareKey.HighWaterMarkValidation(hardwareKey.LastDateProgrammed);
												num = (short)1676607511;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
												goto IL_944;
											case 8:
											{
												if (hardwareKey.Version == 5)
												{
													num = (short)1023082522;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpASKLib.StatusMsg statusMsg;
												bool flag = hardwareKey.WriteiBtnKey(multiBtnWrapper, ref A_5, false, 1, global::AcpASKLib.OpenMode.IBTN_OPEN_WRITE, A_4, out statusMsg);
												num = (short)314376199;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
											{
												global::AcpASKLib.HardwareKey item;
												this.d.Remove(item);
												num = (short)149487627;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 10:
												goto IL_944;
											case 11:
												goto IL_67C;
											case 12:
											{
												global::AcpASKLib.StatusMsg statusMsg;
												A_7.Add(statusMsg);
												num = (short)1639055397;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 13:
												num = (short)708509718;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 14:
												goto IL_D96;
											case 15:
											{
												global::AcpKeyValidatorLib.AcpiButton item2;
												this.e.Remove(item2);
												num = (short)150208545;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 16:
											{
												bool flag2;
												if (flag2)
												{
													num = (short)1991507983;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_827;
											}
											case 17:
											{
												bool flag;
												if (flag)
												{
													num = (short)1222574105;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_602;
											}
											case 18:
												if (hardwareKey.HighWaterMarkSupported(ref hardwareKey, ref multiBtnWrapper))
												{
													num = (short)950337542;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_944;
											case 19:
												try
												{
													num = (short)1236336645;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
															goto IL_B38;
														case 1:
														{
															global::AcpKeyValidatorLib.AcpiButton acpiButton2;
															if (acpiButton2.SerialNumber == acpiButton.SerialNumber)
															{
																num = (short)293666820;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 2:
															goto IL_B1E;
														case 3:
															goto IL_B1E;
														case 4:
														{
															global::AcpKeyValidatorLib.AcpiButton acpiButton2;
															global::AcpKeyValidatorLib.AcpiButton item2 = acpiButton2;
															bool flag2 = true;
															num = (short)411566082;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 5:
															switch (0)
															{
															case 0:
																goto IL_A1D;
															}
															continue;
														case 6:
														{
															global::System.Collections.Generic.IEnumerator<global::AcpKeyValidatorLib.AcpiButton> enumerator;
															if (!enumerator.MoveNext())
															{
																num = (short)1722023939;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::AcpKeyValidatorLib.AcpiButton acpiButton2 = enumerator.Current;
															num = (short)1707174723;
															short num3 = num;
															num = (short)1604676419;
															switch ((num3 == num) ? 1 : 0)
															{
															case 0:
															case 2:
																goto IL_B38;
															default:
																num = (short)1662976000;
																if (num != 0)
																{
																}
																num = (short)1500905473;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														}
														IL_ABF:
														num = (short)602734598;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_A1D:
														goto IL_ABF;
														IL_B1E:
														num = (short)1550450688;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_B38:
													goto IL_50B;
												}
												finally
												{
													num = (short)1371275265;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::AcpKeyValidatorLib.AcpiButton> enumerator;
														switch (num2)
														{
														case 0:
															goto IL_BA8;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_B6F;
															}
															continue;
														case 2:
															enumerator.Dispose();
															num = (short)739246080;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														IL_B6F:
														if (enumerator == null)
														{
															break;
														}
														num = (short)1746468866;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_BA8:;
												}
												goto IL_BAB;
												IL_50B:
												num = (short)1131675664;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 20:
												if (A_7 != null)
												{
													num = (short)1623195676;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_D96;
											case 21:
												goto IL_DAE;
											case 22:
												if ((A_1 & global::AcpKeyValidatorLib.HardwareKeyType.ADVANCED_SYSTEM_KEY) != global::AcpKeyValidatorLib.HardwareKeyType.UNKOWN)
												{
													num = (short)430964763;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1867120674;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 23:
											{
												bool flag;
												if (!flag)
												{
													num = (short)5111844;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)939655176;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 24:
											{
												string empty;
												hardwareKey.WriteMASKToIBtn(multiBtnWrapper, empty, hardwareKey.ExpirationType, hardwareKey.DaysToExpiration, 0, ref A_5);
												num = (short)2136211495;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 25:
											{
												bool flag3 = false;
												global::AcpASKLib.HardwareKey item = null;
												global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyRecord> enumerator2 = this.d.GetEnumerator();
												num = (short)1622409251;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 26:
											{
												string empty = string.Empty;
												num = (short)1101660200;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 27:
											{
												global::AcpASKLib.StatusMsg statusMsg = null;
												keyRecord = new global::AcpASKLib.HardwareKey();
												bool flag = ((global::AcpASKLib.HardwareKey)keyRecord).ReadiBtnKey(multiBtnWrapper, A_2, A_3, A_4, ref A_5, ref A_6, out statusMsg, bASKCalling, bAddAccessLevel);
												num = (short)2144534558;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 28:
												A_7.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, global::AcpCommonResources.AcpResources.iButton_Invalid, 3758129160U));
												num = (short)1332871168;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 29:
											{
												global::AcpKeyValidatorLib.AcpiButton item2 = null;
												bool flag2 = false;
												global::System.Collections.Generic.IEnumerator<global::AcpKeyValidatorLib.AcpiButton> enumerator = this.e.GetEnumerator();
												num = (short)882507795;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 30:
											{
												bool flag;
												if (flag)
												{
													num = (short)859897857;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_944;
											}
											case 31:
												if (!this.a(multiBtnWrapper, out acpiButton))
												{
													num = (short)1764950029;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1893990402;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 32:
												goto IL_D96;
											case 33:
												goto IL_827;
											case 34:
												if (A_7 != null)
												{
													num = (short)490537001;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_D96;
											case 35:
												try
												{
													num = (short)968556549;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
															goto IL_7B5;
														case 2:
															num = (short)1659371520;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 3:
														{
															global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyRecord> enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = (short)1985085442;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::AcpASKLib.HardwareKey hardwareKey2 = (global::AcpASKLib.HardwareKey)enumerator2.Current;
															num = (short)1121517572;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 4:
														{
															global::AcpASKLib.HardwareKey hardwareKey2;
															if (hardwareKey2.SerialNumber == ((global::AcpASKLib.HardwareKey)keyRecord).SerialNumber)
															{
																num = (short)1437401094;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 5:
															switch (0)
															{
															case 0:
																goto IL_6EA;
															}
															continue;
														case 6:
														{
															global::AcpASKLib.HardwareKey hardwareKey2;
															global::AcpASKLib.HardwareKey item = hardwareKey2;
															bool flag3 = true;
															num = (short)521076737;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														}
														IL_762:
														num = (short)1253244931;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_6EA:
														goto IL_762;
													}
													IL_7B5:
													goto IL_D5A;
												}
												finally
												{
													num = (short)945684481;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyRecord> enumerator2;
														switch (num2)
														{
														case 0:
															goto IL_824;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_7EC;
															}
															continue;
														case 2:
															enumerator2.Dispose();
															num = (short)1205469184;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														IL_7EC:
														if (enumerator2 == null)
														{
															break;
														}
														num = (short)1356398594;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_824:;
												}
												goto IL_827;
												IL_D5A:
												num = (short)1302396966;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 36:
											{
												hardwareKey.EraseData(ref multiBtnWrapper);
												string message = global::AcpCommonResources.AcpResources.HighWaterMark_Security_Violation.AcpStringFormat(new object[]
												{
													hardwareKey.SerialNumber
												});
												A_7.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, message, 3758129166U));
												num = (short)434307082;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 37:
												goto IL_D96;
											case 38:
											{
												bool flag3;
												if (flag3)
												{
													num = (short)1862664201;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_67C;
											}
											case 39:
												goto IL_944;
											case 40:
											{
												string empty;
												if (hardwareKey.GetPswdFromIBtn(multiBtnWrapper, ref empty) == 0U)
												{
													num = (short)825294872;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												bool flag = false;
												num = (short)1133772803;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 41:
												A_7.Add(new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, global::AcpCommonResources.AcpResources.iButton_Invalid, 3758129160U));
												num = (short)328532000;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_3F8;
											IL_602:
											num = (short)358744069;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_67C:
											this.d.Add(keyRecord);
											result = true;
											num = (short)1054736388;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_827:
											this.e.Add(acpiButton);
											result = true;
											num = (short)1135345678;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_944:
											num = (short)1965424657;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_BAB:
											hardwareKey = (global::AcpASKLib.HardwareKey)keyRecord;
											num = (short)1201799186;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_D96:
											num = (short)832897045;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_DAE:
										goto IL_ED7;
										IL_3F8:
										acpiButton = null;
										num = (short)491651103;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_349;
									}
									catch (global::System.Exception ex)
									{
										if (ex.Data != null)
										{
											uint num4 = (uint)ex.Data[global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᩞ፠ᅢ੤ᕦ⩨Ѫ६੮", a_)];
											if (num4 != 2684387329U)
											{
												if (num4 != 2684387332U)
												{
													goto IL_DFC;
												}
											}
											flag4 = true;
										}
										IL_DFC:
										goto IL_ED7;
									}
									goto IL_E01;
									IL_ED7:
									num = (short)1111359504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (flag4)
									{
										num = (short)2023686159;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E1E;
								case 13:
									goto IL_E01;
								case 14:
								{
									if (flag4)
									{
										num = (short)1234305024;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									multiBtnWrapper.PortNumber = num5;
									bool flag = multiBtnWrapper.FindFirstBtn(255);
									num = (short)1645477906;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									goto IL_2DC;
								case 16:
									if (!flag4)
									{
										num = (short)1886584849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E9C;
								case 17:
								{
									bool flag = multiBtnWrapper.FindNextBtn();
									num = (short)926220290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
								{
									bool flag;
									if (flag)
									{
										num = (short)1595277320;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2DC;
								}
								case 19:
									if (num5 <= 15)
									{
										num = (short)1312358410;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F13;
								}
								goto IL_1D0;
								IL_223:
								num = (short)1362558995;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2DC:
								num5 += 1;
								num = (short)1170735105;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E01:
								num6 = 2;
								num = (short)770441221;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E1E:
								num = (short)426246155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E3D:
								num5 = num6;
								num = (short)1318256644;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E9C:
								num = (short)589365254;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F13:
								num = (short)1825046531;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F2B:
							goto IL_F96;
							IL_1D0:
							multiBtnWrapper.PortType = num7;
							multiBtnWrapper.CreateButton();
							num6 = 1;
							num = (short)1021313033;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_179;
						}
						catch (global::System.AccessViolationException ex2)
						{
							string message2 = global::AcpASKLib.SystemKeyLoadedEventArgs.b("൞ѠɢŤ䝦h⥪ᡬ᭮հᱲ᭴坶ᱸॺོၾ릂ꖄ", a_) + ex2.Message;
							new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, message2, 1610645507U);
							throw ex2;
						}
						catch (global::System.Exception ex3)
						{
							string message3 = global::AcpASKLib.SystemKeyLoadedEventArgs.b("൞ѠɢŤ䝦h⥪ᡬ᭮հᱲ᭴坶ᱸॺོၾ릂ꖄ", a_) + ex3.Message;
							new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Error, message3, 1610645507U);
						}
						finally
						{
							multiBtnWrapper.CloseButton();
							A_5 = false;
						}
						IL_F96:
						num7 += 4;
						num = (short)651493376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1760100355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (flag4)
						{
							num = (short)289210372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2013003776;
						short num8 = num;
						num = (short)1485832193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return result;
					case 5:
						num = (short)96010241;
						if (num != 0)
						{
						}
						if (num7 <= num9)
						{
							num = (short)1619066882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
						goto IL_8F;
					}
					goto IL_54;
					IL_8F:
					num = (short)353763333;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_54:
				result = false;
				bAddAccessLevel = true;
				bASKCalling = false;
				short num10 = 2;
				num9 = 2;
				num9 = 6;
				multiBtnWrapper = (global::IBtnWrapperLib.MultiBtnWrapper)A_0;
				hardwareKey = new global::AcpASKLib.HardwareKey();
				flag4 = false;
				num7 = num10;
				num = (short)1556283398;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00025A8C File Offset: 0x00023C8C
		internal bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, bool A_1, int A_2, ref bool A_3, global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyDataRecord> A_4, global::AcpASKLib.AccessLevelDataRecordSet A_5, out global::AcpASKLib.StatusMsg A_6)
		{
			int a_ = 8;
			short num = (short)98304000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result;
				for (;;)
				{
					IL_26:
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					short num5;
					short num6;
					global::IBtnWrapperLib.MultiBtnWrapper multiBtnWrapper;
					bool flag2;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							goto IL_8E;
						case 1:
						{
							num = (short)1083684733;
							short num3 = num;
							num = (short)606648189;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_26;
							default:
							{
								num = (short)376766465;
								if (num != 0)
								{
								}
								num = (short)839909376;
								short num4 = num;
								num = (short)847511552;
								if (num != 0)
								{
								}
								if (num5 <= num6)
								{
									num = (short)540082182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return result;
							}
							}
							break;
						}
						case 2:
							return result;
						case 3:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_21C;
								}
								short num9;
								for (;;)
								{
									IL_1C5:
									short num7;
									switch (num2)
									{
									case 0:
										goto IL_54B;
									case 1:
										goto IL_52E;
									case 2:
										goto IL_5C9;
									case 3:
										goto IL_656;
									case 4:
										num = (short)167313420;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										if (num7 <= 15)
										{
											num = (short)398196740;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_63E;
									case 6:
									{
										bool flag = multiBtnWrapper.FindNextBtn();
										num = (short)287965186;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										if (multiBtnWrapper.PortType == 6)
										{
											num = (short)841809921;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_56B;
									case 8:
										try
										{
											global::AcpASKLib.IKeyRecord keyRecord = new global::AcpASKLib.HardwareKey();
											global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator = A_4.GetEnumerator();
											try
											{
												num = (short)1295450112;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_3CF;
														}
														continue;
													case 1:
														num = (short)1094057987;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 2:
													{
														if (!enumerator.MoveNext())
														{
															num = (short)554500097;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::AcpASKLib.KeyDataRecord item = (global::AcpASKLib.KeyDataRecord)enumerator.Current;
														keyRecord.KeyDataList.Add(item);
														num = (short)1182007300;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 3:
														goto IL_456;
													}
													IL_404:
													num = (short)2044461058;
													num2 = (int)((global::System.IntPtr)num);
													continue;
													IL_3CF:
													goto IL_404;
												}
												IL_456:;
											}
											finally
											{
												num = (short)1151139842;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														enumerator.Dispose();
														num = (short)1822031873;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 1:
														goto IL_4C1;
													case 2:
														switch (0)
														{
														case 0:
															goto IL_48A;
														}
														continue;
													}
													IL_48A:
													if (enumerator == null)
													{
														break;
													}
													num = (short)700645376;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_4C1:;
											}
											bool flag = ((global::AcpASKLib.HardwareKey)keyRecord).WriteiBtnKey(multiBtnWrapper, ref A_3, A_1, A_2, global::AcpASKLib.OpenMode.IBTN_OPEN_WRITE, A_5, out A_6);
											goto IL_602;
										}
										catch (global::System.Exception ex)
										{
											if (ex.Data != null)
											{
												uint num8 = (uint)ex.Data[global::AcpASKLib.SystemKeyLoadedEventArgs.b("⁤ᕦ᭨ѪὬⱮṰᝲၴ", a_)];
												if (num8 != 2684387329U)
												{
													if (num8 != 2684387332U)
													{
														goto IL_529;
													}
												}
												flag2 = true;
											}
											IL_529:
											goto IL_602;
										}
										goto IL_52E;
										IL_602:
										num = (short)289538065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										num = (short)907477005;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										goto IL_26C;
									case 11:
										goto IL_63E;
									case 12:
									{
										if (flag2)
										{
											num = (short)515309579;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										multiBtnWrapper.PortNumber = num7;
										bool flag = multiBtnWrapper.FindFirstBtn(255);
										num = (short)623443987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 13:
										if (flag2)
										{
											num = (short)224657423;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_54B;
									case 14:
										goto IL_56B;
									case 15:
										goto IL_321;
									case 16:
									{
										bool flag;
										if (flag)
										{
											num = (short)1331822601;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_321;
									}
									case 17:
										if (!flag2)
										{
											num = (short)1030291462;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5C9;
									case 18:
										goto IL_26C;
									case 19:
									{
										bool flag;
										if (flag)
										{
											num = (short)967770112;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_321;
									}
									}
									goto IL_21C;
									IL_26C:
									num = (short)2128084997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_321:
									num7 += 1;
									num = (short)229244946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_52E:
									num9 = 2;
									num = (short)1000144910;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_54B:
									num = (short)706347016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_56B:
									num7 = num9;
									num = (short)1325465610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_5C9:
									num = (short)992673808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_63E:
									num = (short)2017198083;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_656:
								goto IL_686;
								IL_21C:
								multiBtnWrapper.PortType = num5;
								multiBtnWrapper.CreateButton();
								num9 = 1;
								num = (short)1778974727;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1C5;
							}
							catch (global::System.Exception ex2)
							{
								global::System.Diagnostics.Trace.WriteLine(global::AcpASKLib.SystemKeyLoadedEventArgs.b("㝤ɦࡨཪ䵬ٮ㍰ٲŴͶᙸᕺ嵼᩾뎈ꮊ", a_) + ex2.Message);
							}
							finally
							{
								multiBtnWrapper.CloseButton();
								A_3 = false;
							}
							IL_686:
							num5 += 4;
							num = (short)181469189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (flag2)
							{
								num = (short)1939275778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1686175747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_8E;
						case 6:
							num = (short)1338703876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_8E:
						num = (short)268107777;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_53:
					A_6 = new global::AcpASKLib.StatusMsg(global::AcpASKLib.AskStatusType.Info, "", 0U);
					result = false;
					short num10 = 2;
					num6 = 2;
					num6 = 6;
					multiBtnWrapper = (global::IBtnWrapperLib.MultiBtnWrapper)A_0;
					flag2 = true;
					num5 = num10;
					num = (short)1814364160;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				return result;
			}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000261A8 File Offset: 0x000243A8
		internal static void e(string A_0)
		{
			short num = (short)325648384;
			short num2 = num;
			num = (short)1985290581;
			short num3 = num;
			num = (short)92873045;
			switch (num3 == num)
			{
			}
			num = (short)2080636929;
			if (num != 0)
			{
			}
			num = (short)930021376;
			if (num != 0)
			{
			}
			global::AcpASKLib.KeyRecordSet.a.Add(A_0);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0002625C File Offset: 0x0002445C
		internal static global::System.Collections.ArrayList ExpiredSerialNumList
		{
			get
			{
				short num = (short)1461911552;
				short num2 = num;
				num = (short)1154038167;
				short num3 = num;
				num = (short)394803607;
				switch (num3 == num)
				{
				}
				num = (short)1936326656;
				if (num != 0)
				{
				}
				num = (short)141885441;
				if (num != 0)
				{
				}
				return global::AcpASKLib.KeyRecordSet.a;
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0002630C File Offset: 0x0002450C
		internal static void d(string A_0)
		{
			short num = (short)2071592960;
			short num2 = num;
			num = (short)1160093691;
			short num3 = num;
			num = (short)1003069435;
			switch (num3 == num)
			{
			}
			num = (short)222822401;
			if (num != 0)
			{
			}
			num = (short)966066176;
			if (num != 0)
			{
			}
			global::AcpASKLib.KeyRecordSet.c.Add(A_0, A_0);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000263C4 File Offset: 0x000245C4
		internal static bool c(string A_0)
		{
			short num = (short)1743978496;
			short num2 = num;
			num = (short)1053668830;
			short num3 = num;
			num = (short)1690875358;
			switch (num3 == num)
			{
			}
			num = (short)33357825;
			if (num != 0)
			{
			}
			num = (short)267190272;
			if (num != 0)
			{
			}
			return global::AcpASKLib.KeyRecordSet.c.ContainsKey(A_0);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00026478 File Offset: 0x00024678
		internal static void b(string A_0)
		{
			short num = (short)1969553408;
			short num2 = num;
			num = (short)847057865;
			short num3 = num;
			num = (short)1970672585;
			switch (num3 == num)
			{
			}
			num = (short)635502592;
			if (num != 0)
			{
			}
			num = (short)1284964353;
			if (num != 0)
			{
			}
			global::AcpASKLib.KeyRecordSet.b.Add(A_0, global::System.DateTime.Now);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00026534 File Offset: 0x00024734
		internal static global::System.Collections.Generic.Dictionary<string, global::System.DateTime> LockedOutKeyList
		{
			get
			{
				short num = (short)69074944;
				short num2 = num;
				num = (short)1009141167;
				short num3 = num;
				num = (short)1714308527;
				switch (num3 == num)
				{
				}
				num = (short)192937985;
				if (num != 0)
				{
				}
				num = (short)1920270336;
				if (num != 0)
				{
				}
				return global::AcpASKLib.KeyRecordSet.b;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000265E4 File Offset: 0x000247E4
		internal static bool a(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			short num;
			int num3;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)2112815104;
				short num2 = num;
				switch (num3)
				{
				case 0:
					IL_69:
					if (global::AcpASKLib.KeyRecordSet.b.ContainsKey(A_0))
					{
						num = (short)1024196613;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_166;
				case 1:
					result = true;
					num = (short)1955463171;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)80609281;
					if (num != 0)
					{
					}
					global::System.TimeSpan timeSpan;
					if (timeSpan.TotalSeconds < 600.0)
					{
						num = (short)1896939521;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpASKLib.KeyRecordSet.b.Remove(A_0);
					result = false;
					num = (short)537329668;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_166;
				case 4:
					goto IL_166;
				case 5:
				{
					global::System.TimeSpan timeSpan = global::System.DateTime.Now.Subtract(global::AcpASKLib.KeyRecordSet.b[A_0]);
					num = (short)320077826;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_51;
				IL_166:
				num = (short)1575487858;
				short num4 = num;
				num = (short)358287730;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_69;
				default:
					goto IL_19A;
				}
			}
			IL_19A:
			num = (short)1895432192;
			if (num != 0)
			{
			}
			return result;
			IL_51:
			result = false;
			num = (short)1570963456;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000267A4 File Offset: 0x000249A4
		internal global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyRecord> KeyList
		{
			get
			{
				short num = (short)1315241984;
				short num2 = num;
				num = (short)52204195;
				short num3 = num;
				num = (short)1707446947;
				switch (num3 == num)
				{
				}
				num = (short)1863974913;
				if (num != 0)
				{
				}
				num = (short)989790208;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00026854 File Offset: 0x00024A54
		public global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyDataRecord> KeyDataList
		{
			get
			{
				short num = (short)1301151745;
				if (num != 0)
				{
				}
				num = (short)2083061760;
				short num2 = num;
				num = (short)588644352;
				switch (num)
				{
				default:
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyDataRecord> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyDataRecord>();
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyRecord> enumerator = this.d.GetEnumerator();
					try
					{
						num = (short)567345155;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								IL_E3:
								try
								{
									num = (short)1725956099;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)1480720385;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::AcpASKLib.IKeyDataRecord item = enumerator2.Current;
											observableCollection.Add(item);
											num = (short)1382285316;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											num = (short)1074462722;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_224;
										case 3:
											switch (0)
											{
											case 0:
												goto IL_1B0;
											}
											continue;
										}
										IL_1B2:
										num = (short)384761856;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_1B0:
										goto IL_1B2;
									}
									IL_224:
									break;
								}
								finally
								{
									num = (short)262078465;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2;
										switch (num3)
										{
										case 0:
											goto IL_290;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_25B;
											}
											continue;
										case 2:
											enumerator2.Dispose();
											num = (short)1866792960;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_25B:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)1937375234;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_290:;
								}
								goto IL_293;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)499449860;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.IEnumerator<global::AcpASKLib.IKeyDataRecord> enumerator2 = enumerator.Current.KeyDataList.GetEnumerator();
								num = (short)419954688;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_2AB;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_BB;
								}
								continue;
							case 4:
								goto IL_293;
							}
							IL_E8:
							num = (short)2067195704;
							short num4 = num;
							num = (short)420669240;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_E3;
							default:
								num = (short)77856768;
								if (num != 0)
								{
								}
								num = (short)1112473601;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_BB:
							goto IL_E8;
							IL_293:
							num = (short)2108227586;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2AB:;
					}
					finally
					{
						num = (short)743178241;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_314;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2DF;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)1873215488;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2DF:
							if (enumerator == null)
							{
								break;
							}
							num = (short)14548994;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_314:;
					}
					return observableCollection;
				}
				}
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00026BB0 File Offset: 0x00024DB0
		private bool a(global::IBtnWrapperLib.IIBtnWrapper A_0, out global::AcpKeyValidatorLib.AcpiButton A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			short num;
			int num3;
			global::AcpKeyValidatorLib.AcpiButton acpiButton;
			bool flag;
			bool flag2;
			for (;;)
			{
				IL_0A:
				num = (short)1697382400;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (acpiButton.IsDepot(A_0, out flag))
					{
						num = (short)52101123;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)267976712;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_21A;
				case 2:
					goto IL_203;
				case 3:
					flag2 = true;
					num = (short)95420421;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_203;
				case 5:
					goto IL_203;
				case 6:
					flag2 = true;
					num = (short)209256450;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					if (acpiButton.IsFTR(A_0))
					{
						num = (short)642121738;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)411855153;
					short num4 = num;
					num = (short)52521265;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21A;
					default:
						num = (short)688717824;
						if (num != 0)
						{
						}
						num = (short)546766848;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					if (acpiButton.IsLabTool(A_0, out flag))
					{
						num = (short)1267662854;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 9:
					A_1 = acpiButton;
					num = (short)333512715;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)2000683009;
					if (num != 0)
					{
					}
					flag2 = true;
					num = (short)2111438852;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					return flag2;
				}
				goto IL_69;
				IL_203:
				num = (short)1272840193;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_21A:
				if (!flag2)
				{
					break;
				}
				num = (short)1844903945;
				num3 = (int)((global::System.IntPtr)num);
			}
			return flag2;
			IL_69:
			flag2 = false;
			flag = false;
			A_1 = null;
			acpiButton = new global::AcpKeyValidatorLib.AcpiButton();
			num = (short)1137639431;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00026E10 File Offset: 0x00025010
		internal global::System.Collections.ObjectModel.ObservableCollection<global::AcpKeyValidatorLib.AcpiButton> SpecialKeyList
		{
			get
			{
				short num = (short)928497605;
				short num2 = num;
				num = (short)3784645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1178075136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1312292865;
				if (num != 0)
				{
				}
				num = (short)179306496;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00026EC0 File Offset: 0x000250C0
		// Note: this type is marked as 'beforefieldinit'.
		static KeyRecordSet()
		{
			short num = (short)1118171205;
			short num2 = num;
			num = (short)1022750789;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1071579136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)241500161;
			if (num != 0)
			{
			}
			num = (short)916389888;
			if (num != 0)
			{
			}
			global::AcpASKLib.KeyRecordSet.a = new global::System.Collections.ArrayList();
			global::AcpASKLib.KeyRecordSet.b = new global::System.Collections.Generic.Dictionary<string, global::System.DateTime>();
			global::AcpASKLib.KeyRecordSet.c = new global::System.Collections.Generic.Dictionary<string, string>();
		}

		// Token: 0x04000198 RID: 408
		private static global::System.Collections.ArrayList a;

		// Token: 0x04000199 RID: 409
		private static global::System.Collections.Generic.Dictionary<string, global::System.DateTime> b;

		// Token: 0x0400019A RID: 410
		private static global::System.Collections.Generic.Dictionary<string, string> c;

		// Token: 0x0400019B RID: 411
		private global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyRecord> d;

		// Token: 0x0400019C RID: 412
		private global::System.Collections.ObjectModel.ObservableCollection<global::AcpKeyValidatorLib.AcpiButton> e;
	}
}
