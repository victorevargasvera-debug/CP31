using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AcpASKLib;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUtility;
using CommonResources;
using ConstraintHelper;
using Motorola.Acp.PackUnpack.Ish.Layouts;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Model_Configuration;
using SpecialFeatures.Ucl.Contact;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000D6 RID: 214
	public class FlashCodeplug
	{
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0010C778 File Offset: 0x0010A978
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x0010C82C File Offset: 0x0010AA2C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.HOptionAdvancedKeyIDS keyIDS
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)143458304;
				short num2 = num;
				num = (short)102432769;
				if (num != 0)
				{
				}
				num = (short)25684661;
				short num3 = num;
				num = (short)2027023029;
				switch (num3 == num)
				{
				}
				num = (short)1346764800;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1742340096;
				short num2 = num;
				num = (short)2038431745;
				if (num != 0)
				{
				}
				num = (short)208676936;
				short num3 = num;
				num = (short)1689790536;
				switch (num3 == num)
				{
				}
				num = (short)418381824;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0010C8DC File Offset: 0x0010AADC
		public bool UpgradeCodeplug(string modelNumber, string flashcode, bool IsModelNumberUpgrade, bool updateASK = true, global::SpecialFeatures.Flashport.FlashRadio.OwnerSystemData ownerSystemData = null)
		{
			int a_ = 9;
			short num = (short)834535424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				for (;;)
				{
					IL_31:
					bool flag4;
					string text;
					byte[] array3;
					switch (num2)
					{
					case 0:
						if (IsModelNumberUpgrade)
						{
							num = (short)1356005385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)322371589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_DD;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_459;
							}
							int[] array;
							global::System.Collections.Generic.IDictionary<global::SpecialFeatures.Flashport.FlashRadio.Option, int> dictionary;
							global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
							int[] array2;
							int num11;
							for (;;)
							{
								IL_252:
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
								global::SpecialFeatures.Flashport.FlashRadio.OwnerSystemData ownerSystemData2;
								bool flag;
								bool flag2;
								int num3;
								bool flag3;
								bool flag5;
								bool flag6;
								global::AcpASKLib.KeyType ownerSystemType;
								bool flag7;
								bool flag14;
								global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
								bool flag16;
								bool flag17;
								int num12;
								switch (num2)
								{
								case 0:
									radioWide.General.RadWideGeneralOwnerSystemID_A37153Value = ownerSystemData2.OwnerSystemID;
									radioWide.General.RadWideGeneralOwnerWACNID_A38656.SetValue(0);
									num = (short)159514625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
									{
										num = (short)1018232864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_DAA;
								case 2:
									if (flag || flag2)
									{
										num = (short)47775783;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DF6;
								case 3:
									this.keyIDS.ASKRequired = new bool?(true);
									this.keyIDS.WriteProtect = new bool?(radioWide.Depot.AdvancedExternalMicOnly.Value);
									num = (short)2042429548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!global::ConstraintHelper.UtilityMack.bOpenFromRMC)
									{
										num = (short)281346136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									ownerSystemData2 = ownerSystemData;
									num = (short)1898315903;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_61F;
								case 6:
									num = (short)664797218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_AE6;
								case 8:
									num = (short)247201911;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1438187536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									if (num3 >= array.Length)
									{
										num = (short)720568339;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num4 = array[num3];
									num = (short)487718965;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									if (flag3)
									{
										num = (short)937164877;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_14C0;
								case 12:
									if (flag4)
									{
										num = (short)1838940285;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num3 = 0;
									num = (short)734330936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_4A4;
								case 14:
									num = (short)419561569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_10AE;
								case 16:
								{
									int num5;
									int num6;
									if (num5 > num6)
									{
										num = (short)743702634;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DF6;
								}
								case 17:
									if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
									{
										num = (short)500039751;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_16AB;
								case 18:
								{
									int num6;
									if (num6 < 13)
									{
										num = (short)551747591;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DF6;
								}
								case 19:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::SpecialFeatures.Flashport.FlashRadio.Option, int>> enumerator = dictionary.GetEnumerator();
									num = (short)2037055535;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
									radioWide.General.RadWideGeneralOwnerWACNID_A38656Value = ownerSystemData2.OwnerSystemID;
									radioWide.General.RadWideGeneralOwnerSystemID_A37153.SetValue(0);
									num = (short)435552283;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									if (!flag5)
									{
										num = (short)813105211;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A95;
								case 22:
									flag6 = (radioWide.General.RadWideGeneralOwnerWACNID_A38656Value > radioWide.General.RadWideGeneralOwnerWACNID_A38656.Max);
									goto IL_1424;
								case 23:
									if (ownerSystemType != global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
									{
										num = (short)1612382286;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1820196954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									goto IL_16A6;
								case 25:
									flag7 = true;
									goto IL_132F;
								case 26:
								{
									int radWideGeneralOwnerAdvancedKeyType_A38663Value;
									if (radWideGeneralOwnerAdvancedKeyType_A38663Value != 0)
									{
										num = (short)1754333249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)670236777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
									if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
									{
										num = (short)1532100646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4A4;
								case 28:
									num = (short)1837957172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
								{
									bool flag8;
									bool flag9;
									if (flag8 && flag9)
									{
										num = (short)1709637734;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									bool flag10 = false;
									bool flag11 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꎑꎓꊕꆗ", a_), flashcode, ref flag10);
									num = (short)1946288158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
								{
									bool flag10;
									bool flag11;
									if (flag10 && flag11)
									{
										num = (short)1384775743;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_14C0;
								}
								case 31:
								{
									bool flag12;
									bool flag13;
									if ((flag12 || flag13) && flag5)
									{
										num = (short)271646832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1896284232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 32:
									this.keyIDS.OwnerSystemID = radioWide.General.RadWideGeneralOwnerSystemID_A37153Value;
									this.keyIDS.OwnerWACNID = 0;
									num = (short)2068512803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									num = (short)1721761893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
								{
									bool flag13;
									flag14 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋뮍ꎏ", a_), flashcode, ref flag13);
									goto IL_1B17;
								}
								case 35:
									goto IL_DAA;
								case 36:
									goto IL_1A95;
								case 37:
									goto IL_1DF6;
								case 38:
									this.keyIDS.OwnerWACNID = radioWide.General.RadWideGeneralOwnerWACNID_A38656Value;
									this.keyIDS.OwnerSystemID = 0;
									num = (short)379322381;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
								{
									string value = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683.Value;
									string appVersion = global::AcpCommonLib.AppInfoManager.AppVersion;
									int num6 = int.Parse(value.Substring(1, 2));
									int num5 = int.Parse(appVersion.Substring(1, 2));
									num = (short)2089943149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 40:
								{
									radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132.SetValue(flashcode);
									bool value2 = radioInformation.Labtool.RadInfoLabtoolFPPNonFEDVersion_A8143.Value;
									bool flag12 = false;
									bool flag13 = false;
									num = (short)2039545959;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 41:
									goto IL_D5E;
								case 42:
								{
									bool flag15 = false;
									global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator2 = optionsByPosition.GetEnumerator();
									num = (short)810025006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 43:
									num = (short)1003421717;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
									if (ownerSystemData2.OwnerSystemID <= radioWide.General.RadWideGeneralOwnerSystemID_A37153.Max)
									{
										num = (short)1932001280;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D9F;
								case 45:
									num = (short)941555803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									try
									{
										num = (short)1135673363;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::SpecialFeatures.Flashport.FlashRadio.Option option;
											int num8;
											int bitSize;
											switch (num2)
											{
											case 0:
											{
												int num7;
												if (num7 == option.BitsValue)
												{
													num = (short)1266548737;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_7D4;
											}
											case 1:
												text = option.ToString();
												flag4 = true;
												num = (short)94502921;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_9BB;
											case 3:
											{
												int num7;
												dictionary.Add(option, num7);
												num = (short)322371597;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
											{
												if (num8 >= bitSize)
												{
													num = (short)763297798;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												int num9;
												array2[num9 - 1 + num8] = num9 + num8;
												num8++;
												num = (short)1051918346;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												int num7;
												if (num7 != 0)
												{
													num = (short)1928331272;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_9BB;
											}
											case 6:
												num = (short)383975429;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												num = (short)918355968;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												num = (short)928186388;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												goto IL_9B6;
											case 10:
												goto IL_A1B;
											case 11:
												num = (short)604897298;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 12:
											{
												int num7;
												int fieldValue;
												if (fieldValue != num7)
												{
													num = (short)1055981571;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_80F;
											}
											case 13:
												goto IL_80F;
											case 14:
											{
												global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1611989003;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												option = enumerator2.Current;
												global::AcpCommonLib.IAcpField dbField = option.DbField;
												int fieldValue = flashcodeTable.GetFieldValue(dbField);
												int num10;
												int num7 = option.Mask.Apply(num10, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack);
												num = (short)1471414289;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 15:
												goto IL_A1B;
											case 17:
											{
												global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
												if (!modelTiering.IsOptionAvailableForModel(modelNumber, option.Name))
												{
													num = (short)642842631;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_7D4;
											}
											case 18:
												goto IL_A74;
											case 19:
												switch (0)
												{
												case 0:
													goto IL_78E;
												}
												continue;
											case 20:
											{
												int num7;
												if (num7 == option.BitsValue)
												{
													num = (short)987824130;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											goto IL_78E;
											IL_7D4:
											num = (short)1973878796;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_80F:
											bitSize = option.Mask.BitSize;
											num8 = 0;
											num = (short)503644175;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_929:
											num = (short)14352398;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_78E:
											goto IL_929;
											IL_9BB:
											bool flag15 = true;
											num = (short)668139536;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_A1B:
											num = (short)1450377220;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_9B6:
										IL_A74:
										goto IL_1C00;
									}
									finally
									{
										num = (short)684851201;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)520159234;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_AAC;
												}
												continue;
											case 2:
												goto IL_AE3;
											}
											IL_AAC:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)999751680;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_AE3:;
									}
									goto IL_AE6;
									IL_1C00:
									num = (short)766247038;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
									try
									{
										num = (short)402259971;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_100A;
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::SpecialFeatures.Flashport.FlashRadio.Option, int>> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)135528452;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.KeyValuePair<global::SpecialFeatures.Flashport.FlashRadio.Option, int> keyValuePair = enumerator.Current;
												flashcodeTable.SetFieldValue(keyValuePair.Key.DbField, keyValuePair.Value);
												num = (short)1303707649;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												switch (0)
												{
												case 0:
													goto IL_F7C;
												}
												continue;
											case 4:
												num = (short)783810560;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_FB8:
											num = (short)195952642;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_F7C:
											goto IL_FB8;
										}
										IL_100A:
										goto IL_5C1;
									}
									finally
									{
										num = (short)1601044481;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::SpecialFeatures.Flashport.FlashRadio.Option, int>> enumerator;
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)2013659138;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_1042;
												}
												continue;
											case 2:
												goto IL_107A;
											}
											IL_1042:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1286275072;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_107A:;
									}
									goto IL_107D;
									IL_5C1:
									dictionary.Clear();
									dictionary = null;
									radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
									num = (short)303693908;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
									this.keyIDS.OwnerAdvancedKeyType = 0;
									num = (short)1933836339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 49:
								{
									int num9;
									array[num9 - 1] = num9;
									num = (short)2062549065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 50:
									flag6 = true;
									goto IL_1424;
								case 51:
									goto IL_16AB;
								case 52:
									flag7 = (radioWide.General.RadWideGeneralOwnerSystemID_A37153Value > radioWide.General.RadWideGeneralOwnerSystemID_A37153.Max);
									goto IL_132F;
								case 53:
								{
									int num4;
									if (num4 != 0)
									{
										num = (short)1381695603;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1752;
								}
								case 54:
									if (ownerSystemData2 != null)
									{
										num = (short)1637679137;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_10EB;
								case 55:
									goto IL_EAE;
								case 56:
									goto IL_D5E;
								case 57:
									if (flag16 || flag17)
									{
										num = (short)1332936778;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DF6;
								case 58:
								{
									int num5;
									if (num5 >= 13)
									{
										num = (short)1283981321;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DF6;
								}
								case 59:
									goto IL_107D;
								case 60:
									num = (short)747044908;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 61:
									goto IL_EAE;
								case 62:
									goto IL_1C62;
								case 63:
									num = (short)1395916889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 64:
									num = (short)1869873232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 65:
									num = (short)2009596025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 66:
								{
									global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition;
									if (optionsByPosition != null)
									{
										num = (short)1400635434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1551302731;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 67:
									if (ownerSystemData2.OwnerSystemID > 0)
									{
										num = (short)899350542;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_532;
								case 68:
									if (num11 < 24)
									{
										num = (short)1571291181;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B95;
								case 69:
									goto IL_16AB;
								case 70:
									if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
									{
										num = (short)618725379;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1153;
								case 71:
									this.keyIDS.OwnerAdvancedKeyType = 1;
									num = (short)250806341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 72:
								{
									bool flag12;
									bool flag13;
									if (flag12 || flag13)
									{
										num = (short)284360747;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A95;
								}
								case 73:
									goto IL_17FC;
								case 74:
									num = (short)143851522;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 75:
								{
									int num10;
									if (new global::System.Collections.BitArray(new byte[]
									{
										(byte)num10
									})[8 - num12 - 1])
									{
										num = (short)1647706161;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_17FC;
								}
								case 76:
									goto IL_1CE0;
								case 77:
									ownerSystemData2 = null;
									num = (short)317652996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 78:
									num = (short)1353842775;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 79:
									goto IL_114E;
								case 80:
									if (this.keyIDS == null)
									{
										num = (short)927596636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CE0;
								case 81:
									goto IL_1995;
								case 82:
									num = (short)682360854;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 83:
									goto IL_1C38;
								case 84:
									if (radioInformation == null)
									{
										num = (short)1149108264;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DF6;
								case 85:
									if (radioWide.General.RadWideGeneralOwnerWACNID_A38656Value >= 1)
									{
										num = (short)1634402386;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1610874930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 86:
								{
									bool flag8 = false;
									bool flag9 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꎑꊓꊕꂗ", a_), flashcode, ref flag8);
									num = (short)2099380253;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 87:
									if (ownerSystemType != global::AcpASKLib.KeyType.ADVANCED_WACN_KEY)
									{
										num = (short)733544564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1267925059;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 88:
									ownerSystemData2 = (global::SpecialFeatures.Flashport.FlashRadio.OwnerSystemData)global::SpecialFeatures.Flashport.FlashRadio.MainUIDispatcher.MainDispatcher.Invoke(new global::SpecialFeatures.Flashport.FlashRadio.FlashCodeplug.MainUIDisplayOwnerSysID(this.a), global::System.Array.Empty<object>());
									num = (short)1888354319;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 89:
									if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
									{
										num = (short)25493568;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CE0;
								case 90:
									if (ownerSystemData2.OwnerSystemID > 0)
									{
										num = (short)1151795260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D9F;
								case 91:
								{
									if (flag4)
									{
										num = (short)1296892004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num10 = (int)array3[num11];
									num12 = 0;
									num = (short)136315004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 92:
									this.keyIDS = new global::Motorola.CommonCPS.RadioManagement.SharedServices.HOptionAdvancedKeyIDS();
									this.keyIDS.OwnerSystemID = 0;
									this.keyIDS.OwnerWACNID = 0;
									this.keyIDS.OwnerAdvancedKeyType = 0;
									this.keyIDS.ASKRequired = new bool?(false);
									this.keyIDS.WriteProtect = new bool?(false);
									num = (short)927268940;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 93:
									this.keyIDS = new global::Motorola.CommonCPS.RadioManagement.SharedServices.HOptionAdvancedKeyIDS();
									num = (short)1888878673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 94:
									goto IL_14C0;
								case 95:
									goto IL_1A95;
								case 96:
									goto IL_1E10;
								case 97:
									if (ownerSystemData2.OwnerSystemID <= radioWide.General.RadWideGeneralOwnerWACNID_A38656.Max)
									{
										num = (short)783286292;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_532;
								case 98:
									num = (short)134479990;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 99:
									goto IL_61F;
								case 100:
									goto IL_B95;
								case 101:
									if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
									{
										num = (short)1459027976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1995;
								case 102:
								{
									flag3 = true;
									int radWideGeneralOwnerAdvancedKeyType_A38663Value = radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663Value;
									num = (short)1570504730;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 103:
								{
									bool flag12;
									if (!flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b뮍ꎏ", a_), flashcode, ref flag12))
									{
										num = (short)1169948678;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)267911279;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 104:
									goto IL_EAE;
								case 105:
									if (radioWide.General.RadWideGeneralOwnerSystemID_A37153Value >= 1)
									{
										num = (short)309723164;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)751239193;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 106:
									radioWide.Location.GPSFailToneInterval_42329.Value = radioWide.Location.GPSFailToneInterval_42329.DefaultValue;
									num = (short)1999372325;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 107:
									if (num12 < 8)
									{
										num = (short)594673762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C62;
								case 108:
									goto IL_1153;
								case 109:
									if (radioWide != null)
									{
										num = (short)773587066;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DF6;
								case 110:
									num = (short)1370882109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 111:
									flag14 = true;
									goto IL_1B17;
								case 112:
									radioInformation.Labtool.RadInfoLabtoolFPPNonFEDVersion_A8143.SetValue(true);
									num = (short)1897791583;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 113:
									if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
									{
										num = (short)1217003568;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_16AB;
								case 114:
								{
									int num4;
									if (global::System.Array.IndexOf<int>(array2, num4) == -1)
									{
										num = (short)1829109784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1752;
								}
								case 115:
									num = (short)1922367602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 116:
									num = (short)1915027535;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 117:
									goto IL_134E;
								case 118:
								{
									if (flag4)
									{
										num = (short)1397293118;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num9 = num11 * 8 + num12 + 1;
									global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByPosition = flashcodeTable.FLASHcode.GetOptionsByPosition(num9);
									num = (short)1256194114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 119:
									if (this.keyIDS == null)
									{
										num = (short)1825374301;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1995;
								case 120:
									goto IL_14C0;
								case 121:
								{
									int radWideGeneralOwnerAdvancedKeyType_A38663Value;
									if (radWideGeneralOwnerAdvancedKeyType_A38663Value != 1)
									{
										num = (short)649461870;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1029636181;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 122:
									num = (short)49676306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 123:
									if (radioWide != null && updateASK)
									{
										num = (short)1998913622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DF6;
								case 124:
									goto IL_134E;
								case 125:
									goto IL_BCC;
								case 126:
								{
									bool flag15;
									if (!flag15)
									{
										num = (short)1615659091;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_17FC;
								}
								case 127:
									goto IL_10AE;
								}
								goto IL_459;
								IL_4A4:
								radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.SetValue(1);
								num = (short)2088108049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_61F:
								num = (short)1656619076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AE6:
								num = (short)1237057594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B95:
								num = (short)146145292;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D5E:
								num = (short)317587466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DAA:
								radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.SetValue(0);
								num = (short)695861361;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EAE:
								num = (short)322043915;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_107D:
								radioInformation.Labtool.RadInfoLabtoolFPPNonFEDVersion_A8143.SetValue(false);
								num = (short)220069924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10AE:
								num = (short)1446641718;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1153:
								radioWide.General.RadWideGeneralASKRequired_A37152.SetValue(true);
								num = (short)472318072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_132F:
								flag3 = flag7;
								num = (short)2039152744;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_134E:
								num = (short)1415577707;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1424:
								flag3 = flag6;
								num = (short)1110376503;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14C0:
								flag17 = false;
								flag16 = false;
								flag = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮋쾍ꂏꊑꚓ꒕ꆗ", a_), flashcode, ref flag17);
								flag2 = flashcodeTable.IsOptionEnabledInFlashcode(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8b쾍ꂏꊑꎓ꺕ꪗ", a_), flashcode, ref flag16);
								num = (short)1797587001;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16AB:
								num = (short)2131951686;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1752:
								num3++;
								num = (short)1514799145;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17FC:
								num12++;
								num = (short)1261961333;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1995:
								ownerSystemType = ownerSystemData2.OwnerSystemType;
								num = (short)925499415;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A95:
								radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
								num = (short)627507323;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B17:
								flag5 = flag14;
								num = (short)1189281823;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C62:
								num11++;
								num = (short)880476165;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CE0:
								radioWide.General.RadWideGeneralASKRequired_A37152.SetValue(false);
								radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.SetValue(0);
								radioWide.General.RadWideGeneralOwnerSystemID_A37153.SetValue(0);
								radioWide.General.RadWideGeneralOwnerWACNID_A38656.SetValue(0);
								radioWide.Depot.AdvancedExternalMicOnly.SetValue(false);
								num = (short)116850782;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DF6:
								num = (short)1487601760;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_532:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_Owner_WACN_ID_Please_Load_Advanced_WACN_Key);
							IL_BCC:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Not_a_Valid_Option_for_Model.AcpStringFormat(new object[]
							{
								text,
								modelNumber
							}));
							IL_D9F:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_Owner_System_ID);
							IL_10EB:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_Owner_System_Info_Please_Load_ASK_Or_WACN_Key);
							IL_114E:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_Owner_System_Type_Please_Load_ASK_Or_WACN_Key);
							IL_16A6:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
							{
								flashcode
							}));
							IL_1C38:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
							{
								flashcode
							}));
							IL_1E10:
							return true;
							IL_459:
							flashcodeTable.InitTable(true, modelNumber, false);
							array = new int[192];
							array2 = new int[192];
							dictionary = new global::System.Collections.Generic.Dictionary<global::SpecialFeatures.Flashport.FlashRadio.Option, int>();
							num11 = 0;
							num = (short)1017249891;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_252;
						}
						finally
						{
							num = (short)374996994;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
								switch (num2)
								{
								case 0:
									goto IL_1ED0;
								case 1:
									((global::System.IDisposable)flashcodeTable).Dispose();
									num = (short)365887488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1E47;
									}
									continue;
								}
								IL_1E47:
								if (flashcodeTable == null)
								{
									break;
								}
								num = (short)1847419614;
								short num13 = num;
								num = (short)678519518;
								switch ((num13 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1160511488;
									if (num != 0)
									{
									}
									num = (short)1415446529;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_1ED0:;
						}
						goto IL_1ED3;
					case 3:
						goto IL_19F;
					case 4:
					{
						if (array3.Length != 24)
						{
							num = (short)1734737921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
						num = (short)1154875392;
						short num14 = num;
						num = (short)2115239938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						if (!global::SpecialFeatures.Flashport.FlashRadio.FlashcodeValidator.Validate(flashcode))
						{
							num = (short)175112195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering = null;
						num = (short)869466118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						try
						{
							global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering = new global::SpecialFeatures.Model_Configuration.ModelTiering(modelNumber, global::SpecialFeatures.Model_Configuration.ModelTiering.ActionTypes.FLASHPORT, global::SpecialFeatures.Model_Configuration.ModelTiering.TargetTypes.NONE, false);
							goto IL_1BE;
						}
						catch (global::System.Exception)
						{
							global::System.Windows.Forms.MessageBox.Show(global::CommonResources.AppResources.Internal_Error_Critical_File_Mis_Crpt_0xFCF01);
							global::System.Environment.Exit(1036033);
							goto IL_1BE;
						}
						goto IL_1F4F;
						IL_1BE:
						num = (short)577372171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1959526404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_1FC;
					case 9:
						goto IL_A0;
					case 10:
						if (array3 != null)
						{
							num = (short)1223753735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					case 11:
					{
						global::SpecialFeatures.Model_Configuration.ModelTiering modelTiering;
						if (!modelTiering.FindModel(modelNumber))
						{
							num = (short)1656160264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1ED3;
					}
					}
					goto IL_68;
					IL_1ED3:
					flag4 = false;
					text = "";
					array3 = new byte[0];
					global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(flashcode, ref array3);
					num = (short)530907146;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A0:
				goto IL_1F4F;
				IL_DD:
				goto IL_1A4;
				IL_19F:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
				{
					flashcode
				}));
				IL_1A4:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
				{
					flashcode
				}));
				IL_1FC:
				num = (short)1328283649;
				if (num != 0)
				{
				}
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Not_Found_In_Model_Tiering_Database.AcpStringFormat(new object[]
				{
					modelNumber
				}));
				IL_1F4F:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Model_Num_Upg_Not_Spt_This_Release);
				IL_68:
				string empty = string.Empty;
				num = (short)634388480;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0010E8A8 File Offset: 0x0010CAA8
		public void SetPostFlashCodeplugFields(string ibtnSerialNumber)
		{
			short num = (short)274333696;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(ibtnSerialNumber))
						{
							goto IL_1EF;
						}
						goto IL_8D;
					case 1:
					{
						num = (short)1991704576;
						short num3 = num;
						radioInformation.FLASHport.RadInfoFLASHportIButton_A8217.SetValue(ibtnSerialNumber);
						num = (short)1198587908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (radioInformation != null)
						{
							num = (short)932970499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_236;
					case 3:
					{
						num = (short)1859512733;
						short num4 = num;
						num = (short)585296285;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1EF;
						default:
						{
							num = (short)1695154176;
							if (num != 0)
							{
							}
							num = (short)230490113;
							if (num != 0)
							{
							}
							int num5 = radioInformation.FLASHport.RadInfoFLASHportNumberofTimesFlashed_A8581.Value;
							num5++;
							radioInformation.FLASHport.RadInfoFLASHportNumberofTimesFlashed_A8581.SetValue(num5);
							global::System.DateTime now = global::System.DateTime.Now;
							global::System.DateTime dateTime = new global::System.DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
							long ticks = dateTime.ToUniversalTime().Ticks;
							radioInformation.FLASHport.RadInfoLabtoolLastFLASHKeyDateStampData_A8388Value = ticks;
							num = (short)606994432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						goto IL_E2;
					}
					goto IL_42;
					IL_1EF:
					num = (short)1890779137;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8D:
				radioInformation.General.RadInfoGeneralCodeplugVersion_A7683.SetValue(global::AcpCommonLib.AppInfoManager.AppVersion);
				radioInformation.Labtool.RadInfoLabtoolSecurePartitionVersionNumber_A9076.SetValue(global::AcpCommonLib.AppInfoManager.AppVersion);
				return;
				IL_E2:
				goto IL_8D;
				IL_236:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_codeplug_Unable_find_Radio_Infor);
				IL_42:
				radioInformation = null;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)562823170;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0010EAF8 File Offset: 0x0010CCF8
		internal void UpdateFlashcode(string currFlashcode, ref string newFlashcode, string strOpt, bool bAdd)
		{
			short num = (short)1055719424;
			switch (num)
			{
			default:
			{
				num = (short)1843200001;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] array;
					switch (num2)
					{
					case 0:
					{
						if (array.Length != 25)
						{
							num = (short)154796034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable();
						num = (short)1075118085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 2:
						goto IL_448;
					case 3:
						goto IL_40E;
					case 4:
						goto IL_82;
					case 5:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_1AE;
							}
							global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
							for (;;)
							{
								IL_183:
								switch (num2)
								{
								case 0:
								{
									int num3 = optionByName.Mask.Apply(optionByName.BitsValue, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Pack);
									int num4;
									num4 |= num3;
									num = (short)761135112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_2A1;
								case 2:
									if (optionByName != null)
									{
										num = (short)421199878;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_337;
								case 3:
									goto IL_1FB;
								case 4:
								{
									if (bAdd)
									{
										num = (short)898957312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num5 = ~(optionByName.Mask.Mask << optionByName.Mask.Shift);
									int num4;
									num4 &= num5;
									num = (short)708378627;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									int num4;
									if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeCharValue(num4) != '\0')
									{
										num = (short)625147911;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_26D;
								}
								case 6:
								{
									int num6 = (optionByName.Position - 1) / 8;
									int num4 = (int)array[num6];
									num = (short)116654084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									int num4;
									int num6;
									array[num6] = (byte)num4;
									newFlashcode = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(array, array.Length);
									num = (short)348520449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_1FB;
								}
								goto IL_1AE;
								IL_1FB:
								num = (short)1873936389;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_26D:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Invalid_value_for_flashcode);
							IL_2A1:
							return;
							IL_337:
							throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.Not_Valid_Option.AcpStringFormat(new object[]
							{
								strOpt
							}));
							IL_1AE:
							global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
							flashcodeTable.InitTable(true, null, false);
							optionByName = flashcodeTable.FLASHcode.GetOptionByName(strOpt);
							num = (short)884080642;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_183;
						}
						finally
						{
							num = (short)2055602177;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
								switch (num2)
								{
								case 0:
									goto IL_40B;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_384;
									}
									continue;
								case 2:
									((global::System.IDisposable)flashcodeTable).Dispose();
									num = (short)1199505408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_384:
								if (flashcodeTable == null)
								{
									break;
								}
								num = (short)584022578;
								short num7 = num;
								num = (short)2103867954;
								switch ((num7 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_40D;
								default:
									num = (short)454754304;
									if (num != 0)
									{
									}
									num = (short)713818114;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_40B:
							IL_40D:;
						}
						goto IL_40E;
					case 6:
						if (array != null)
						{
							num = (short)375717891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D3;
					}
					IL_60:
					if (!global::SpecialFeatures.Flashport.FlashRadio.FlashcodeValidator.Validate(currFlashcode))
					{
						num = (short)414121988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					array = new byte[0];
					global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(currFlashcode, ref array);
					num = (short)849084422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40E:
					num = (short)1672871936;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_82:
				num = (short)1638465537;
				if (num != 0)
				{
				}
				num = (short)311492608;
				short num8 = num;
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
				{
					currFlashcode
				}));
				IL_D3:
				throw new global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadioException(global::CommonResources.AppResources.is_an_invalid_flashcode.AcpStringFormat(new object[]
				{
					currFlashcode
				}));
				IL_448:
				goto IL_D3;
			}
			}
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0010EF70 File Offset: 0x0010D170
		public void postCodeplugInitialization()
		{
			short num = (short)1340491261;
			short num2 = num;
			num = (short)1984251389;
			switch (num2 == num)
			{
			}
			num = (short)284164097;
			if (num != 0)
			{
			}
			num = (short)286392320;
			short num3 = num;
			num = (short)510459904;
			if (num != 0)
			{
			}
			this.ResolveUCLReferenceAfterUnpack();
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0010F020 File Offset: 0x0010D220
		internal void ResolveUCLReferenceAfterUnpack()
		{
			short num = (short)235929600;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::SpecialFeatures.Ucl.Contact.UclContactRecset)global::AcpCommonLib.FeatureManager.GetFeature(2200)).GetEnumerator();
				try
				{
					num = (short)238354434;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_57B;
						case 1:
							goto IL_593;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_6F;
							}
							continue;
						case 3:
							try
							{
								num = (short)198311938;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator3;
									switch (num2)
									{
									case 0:
										try
										{
											num = (short)1843003401;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													num = (short)715259910;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
												{
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
													((global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection)acpFeatureNode[10404]).ResolveReferenceAfterUnpack();
													num = (short)1248460801;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 4:
												{
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
													((global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection)acpFeatureNode[10402]).ResolveReferenceAfterUnpack();
													num = (short)1387069455;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 5:
												{
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
													((global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection)acpFeatureNode[10412]).ResolveReferenceAfterUnpack();
													num = (short)707854349;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
													goto IL_404;
												case 7:
												{
													if (!enumerator2.MoveNext())
													{
														num = (short)1141243904;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator2.Current;
													num = (short)1089863692;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 8:
													if (acpRecordset.ParentSection.FeatureSectionId == 10403)
													{
														num = (short)2102067203;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)56360971;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 9:
													switch (0)
													{
													case 0:
														goto IL_1BA;
													}
													continue;
												case 10:
												{
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
													((global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection)acpFeatureNode[10406]).ResolveReferenceAfterUnpack();
													num = (short)1806893058;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 11:
													if (acpRecordset.ParentSection.FeatureSectionId == 10405)
													{
														num = (short)596508682;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 12:
													if (acpRecordset.ParentSection.FeatureSectionId == 10401)
													{
														num = (short)1414594564;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)52887566;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 14:
													if (acpRecordset.ParentSection.FeatureSectionId == 10411)
													{
														num = (short)208338949;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)331743240;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_1BF:
												num = (short)268566535;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_1BA:
												goto IL_1BF;
											}
											IL_404:
											break;
										}
										finally
										{
											num = (short)1282277377;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_470;
												case 1:
													switch (0)
													{
													case 0:
														goto IL_43B;
													}
													continue;
												case 2:
													enumerator2.Dispose();
													num = (short)1229651968;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												IL_43B:
												if (enumerator2 == null)
												{
													break;
												}
												num = (short)165609474;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_470:;
										}
										goto IL_473;
									case 1:
										goto IL_4BB;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_112;
										}
										continue;
									case 3:
										if (!enumerator3.MoveNext())
										{
											num = (short)181141508;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_473;
									case 4:
										num = (short)2082340865;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_117:
									num = (short)337444867;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_112:
									goto IL_117;
									IL_473:
									acpRecordset = enumerator3.Current;
									enumerator2 = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
									num = (short)2092433408;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4BB:
								break;
							}
							finally
							{
								num = (short)1161756673;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator3;
									switch (num2)
									{
									case 0:
										goto IL_578;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_4F2;
										}
										continue;
									case 2:
										enumerator3.Dispose();
										num = (short)237305856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_4F2:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)374218662;
									short num3 = num;
									num = (short)1742020518;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_57A;
									default:
										num = (short)1007222784;
										if (num != 0)
										{
										}
										num = (short)1952382978;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
								IL_578:
								IL_57A:;
							}
							goto IL_57B;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1495465984;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator3 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current).EmbeddedRecordsets.GetEnumerator();
							num = (short)1022033923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_9D:
						num = (short)207683588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6F:
						goto IL_9D;
						IL_57B:
						num = (short)2054488065;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_593:;
				}
				finally
				{
					num = (short)550371329;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_627;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_5CB;
							}
							continue;
						case 2:
							num = (short)1007550465;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)1583349760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_5CB:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1767112706;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_627:;
				}
				num = (short)506068992;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0010F6D0 File Offset: 0x0010D8D0
		private global::SpecialFeatures.Flashport.FlashRadio.OwnerSystemData a()
		{
			short num = (short)135200768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1981328553;
				short num3 = num;
				num = (short)897756329;
				global::SpecialFeatures.Flashport.FlashRadio.OwnerSystemData result;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				case 1:
					break;
				default:
				{
					num = (short)2086666240;
					short num4 = num;
					break;
				}
				}
				num = (short)829095936;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				bool? flag;
				bool flag2;
				global::SpecialFeatures.Flashport.FlashRadio.OwnerSystemIDWnd ownerSystemIDWnd;
				for (;;)
				{
					IL_9C:
					switch (num2)
					{
					case 0:
						goto IL_148;
					case 1:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1553334274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						result = ownerSystemIDWnd.OwnerSystemInfo;
						num = (short)1939668992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AF;
				}
				IL_148:
				return result;
				IL_AF:
				num = (short)1679687681;
				if (num != 0)
				{
				}
				result = null;
				ownerSystemIDWnd = new global::SpecialFeatures.Flashport.FlashRadio.OwnerSystemIDWnd();
				flag = ownerSystemIDWnd.ShowDialog();
				flag2 = true;
				num = (short)1711931393;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_9C;
			}
			}
		}

		// Token: 0x0400064D RID: 1613
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.HOptionAdvancedKeyIDS a;

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x06000D22 RID: 3362
		public delegate global::SpecialFeatures.Flashport.FlashRadio.OwnerSystemData MainUIDisplayOwnerSysID();
	}
}
