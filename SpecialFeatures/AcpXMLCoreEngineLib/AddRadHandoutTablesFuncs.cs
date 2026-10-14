using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.Keypad;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.SmartKeyFob;
using Motorola.MackinawCPS.CoreFeatures.Switches;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.AcpXMLCoreEngineLib
{
	// Token: 0x0200022A RID: 554
	public class AddRadHandoutTablesFuncs : global::SpecialFeatures.AcpXMLCoreEngineLib.IAddRadHandouttables
	{
		// Token: 0x06001C33 RID: 7219 RVA: 0x00249460 File Offset: 0x00247660
		public void AddGeneral(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 8;
			short num = (short)1980301312;
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
				global::SpecialFeatures.AcpXMLCoreEngineLib._Value value;
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
				global::System.Globalization.CultureInfo cultureInfo;
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_31:
					global::AcpCommonLib.IAcpField acpField;
					switch (num2)
					{
					case 0:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\udc90\udc92톔튖햘햚좜튞", a_), cultureInfo);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1580859394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (acpField == null)
						{
							goto IL_468;
						}
						num = (short)886354263;
						short num3 = num;
						num = (short)1958719831;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3EC;
						default:
							num = (short)362414080;
							if (num != 0)
							{
							}
							num = (short)1840906240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_468;
					case 3:
						if (acpField != null)
						{
							num = (short)1282211848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_118;
					case 4:
						if (acpField != null)
						{
							num = (short)2141847563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_299;
					case 5:
						goto IL_299;
					case 6:
						if (radioInformation != null)
						{
							num = (short)985989121;
							if (num != 0)
							{
							}
							num = (short)1305214985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						return;
					case 8:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐횒잔\ude96\ud898힚펜쪞", a_), cultureInfo);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1723727882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)846790656;
						short num4 = num;
						table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊ﮖ톘列ﮞ쒠춢", a_);
						string @string = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎횐횒\udb94튖쮘\uda9a톜", a_), cultureInfo);
						table.ColTitle.Add(@string);
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즊", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뮊", a_);
						acpField = null;
						acpField = radioInformation.General.RadInfoGeneralModelNumber_A8539;
						num = (short)837484545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_118;
					case 11:
						goto IL_3EC;
					}
					goto IL_68;
					IL_118:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릊", a_);
					acpField = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132;
					num = (short)73334788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_299:
					RptXMLData.tables.Add(table);
					num = (short)573374471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EC:
					value.FieldValue = acpField.ToString();
					uifields.values.Add(value);
					uifields.UIFieldName = acpField.Name;
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎힐\udf92풔쒖톘\ud89a튜\udb9e", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)770310149;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_468:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좊", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("몊", a_);
					acpField = radioInformation.General.RadInfoGeneralSerialNumber_A9122;
					num = (short)358285315;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_68:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
				uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				cultureInfo = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				bool isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				radioInformation = null;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)505937926;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00249960 File Offset: 0x00247B60
		public void AddButtonsAndControl(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 19;
			short num = (short)1896153088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_634;
				}
				global::System.Globalization.CultureInfo cultureInfo;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				bool isRightToLeft;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset smartKeyFobRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset mfkassignmentControlInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection rotaryControlInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset rotaryControlInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset portableSideUpDownArrowButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection mfkassignmentControlInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection mfkassignmentControlInnerSection2;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset keypadRecset;
				for (;;)
				{
					IL_31:
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					string a_3;
					int num6;
					string a_6;
					string a_7;
					string a_8;
					string text3;
					string text4;
					string a_10;
					string a_11;
					string a_12;
					string a_13;
					string a_14;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
					switch (num2)
					{
					case 0:
					{
						num = (short)353107968;
						short num3 = num;
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), cultureInfo));
						num = (short)439681149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1951334724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)349962499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)1973747721;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string a_2;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								string text;
								switch (num2)
								{
								case 0:
									num = (short)516882462;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4628;
								case 2:
									this.a(ref uifields, a_2);
									num = (short)1614282773;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)1385365504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4331;
								case 4:
									num = (short)785907713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1120796688;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)802684957;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1732706308;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									string btnSideUpDownArrowButtonPrimaryFunction_A41568_UIValue = (acpFeatureNode[10746] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection).BtnSideUpDownArrowButtonPrimaryFunction_A41568_UIValue;
									string btnSideUpDownArrowButtonSecondaryFunction_A41592_UIValue = (acpFeatureNode[10746] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection).BtnSideUpDownArrowButtonSecondaryFunction_A41592_UIValue;
									a_2 = btnSideUpDownArrowButtonPrimaryFunction_A41568_UIValue + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚕몙", a_) + btnSideUpDownArrowButtonSecondaryFunction_A41592_UIValue;
									num = (short)896401433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)960167948;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_3FE8;
									}
									continue;
								case 10:
									goto IL_406C;
								case 11:
									this.a(ref uifields, a_2);
									num = (short)778960915;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (isRightToLeft)
									{
										num = (short)1449394199;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, a_2);
									num = (short)1189675043;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙\ud89b톝盛ﮫ", a_), cultureInfo);
									num = (short)520355857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙\ud89b톝盛ﮫ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1629880333;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num4;
									num4++;
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙첛톝嶺節", a_), cultureInfo) + num4.ToString();
									num = (short)989790242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)930545666;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4331;
								case 16:
									this.a(ref uifields, a_2);
									num = (short)1519910936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_406C;
								case 18:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙즛캝ﾧ", a_), cultureInfo);
									num = (short)847249418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									goto IL_4331;
								case 20:
									this.a(ref uifields, a_2);
									num = (short)263847962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									goto IL_4331;
								case 22:
									goto IL_4331;
								case 23:
									num = (short)2118582277;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									goto IL_45BF;
								case 25:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)1196359687;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1107689475;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									goto IL_4552;
								case 27:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1277624340;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)1209729052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									goto IL_4552;
								case 29:
									goto IL_45BF;
								case 30:
									if (!isRightToLeft)
									{
										num = (short)2040463392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1676673051;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									goto IL_4331;
								case 32:
									this.a(ref uifields, a_2);
									num = (short)440664079;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙즛캝ﾧ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1445855250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1564278798;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									goto IL_406C;
								case 35:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)232128523;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4331;
								}
								goto IL_3FE8;
								IL_406C:
								recSet.UIFields.Add(uifields);
								num = (short)445579272;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4331:
								uifields.UIFieldName = (acpFeatureNode[10746] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection).BtnSideArrowButtonName_A41567.UIName.ToString();
								text = (acpFeatureNode[10746] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection).BtnSideArrowButtonName_A41567_UIValue.ToString();
								num = (short)1860370465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_442A:
								num = (short)1261502470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3FE8:
								goto IL_442A;
								IL_4552:
								this.a(ref uifields, a_2);
								num = (short)2079129622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_45BF:
								this.a(ref uifields, a_2);
								num = (short)240975903;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4628:
							goto IL_6BDD;
						}
						finally
						{
							num = (short)316538880;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_4643;
								case 1:
								{
									num = (short)1284427148;
									short num5 = num;
									num = (short)2034158988;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_4643;
									default:
										num = (short)915079168;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1814757378;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_46EC;
								}
								goto IL_4660;
								IL_4643:
								switch (0)
								{
								case 0:
									IL_4660:
									if (enumerator == null)
									{
										goto IL_46EE;
									}
									num = (short)433979393;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_46EC:
							IL_46EE:;
						}
						goto IL_46EF;
						IL_6BDD:
						table.RecSet.Add(recSet);
						num = (short)674824223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						string text2;
						this.a(ref uifields, text2.ToString());
						num = (short)2067923287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_47A5;
					case 6:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.HiddenStatic)
						{
							num = (short)1968832633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A0;
					case 7:
						goto IL_4A30;
					case 8:
						if (!isRightToLeft)
						{
							num = (short)627179663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1084031294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1659;
					case 10:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.HiddenStatic)
						{
							num = (short)1519124787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E86;
					case 11:
						goto IL_24E5;
					case 12:
						goto IL_5AA1;
					case 13:
						this.a(ref uifields, a_3);
						num = (short)1384710336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_1A4F;
					case 15:
						num = (short)999620816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1088356432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_49F2;
					case 18:
						goto IL_759F;
					case 19:
						if (switches != null)
						{
							num = (short)820052289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C49;
					case 20:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.HiddenStatic)
						{
							num = (short)41681209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1303;
					case 21:
						goto IL_490C;
					case 22:
					{
						string a_4;
						this.a(ref uifields, a_4);
						num = (short)1975779687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (!smartKeyFobRecset.HiddenStatic)
						{
							num = (short)1467351119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_772B;
					case 24:
					{
						uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣", a_);
						uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣殮", a_), cultureInfo);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num6++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슕鍊ﮝﾟ쮣향솧\udea9얫솭\udeaf\ud9b5\udfb7\uddb9킻\udbbd", a_), cultureInfo);
						recSet.RecNo = num6.ToString();
						int value = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.Value;
						int value2 = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.Value;
						string a_4 = (string)switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.Converter.Convert(value, null, null, cultureInfo);
						string a_5 = (string)switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.Converter.Convert(value2, null, null, cultureInfo);
						num = (short)999358748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_2B03;
					case 26:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.HiddenStatic)
						{
							num = (short)881262660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A30;
					case 27:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.HiddenStatic)
						{
							num = (short)442958080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2091122836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)937754791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_772B;
					case 29:
						goto IL_87F;
					case 30:
						num = (short)630128688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_9C6;
					case 32:
						goto IL_3EB2;
					case 33:
						goto IL_90F;
					case 34:
						goto IL_1A4F;
					case 35:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.HiddenStatic)
						{
							num = (short)964689962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E86;
					case 36:
						num = (short)805175428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_3EB2;
					case 38:
						goto IL_6E2C;
					case 39:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1986330910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A30;
					case 40:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)615514265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)1637613772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_E86;
					case 42:
						this.a(ref uifields, a_6);
						num = (short)796197159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
						num = (short)1229651986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.HiddenStatic)
						{
							num = (short)471990327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)424738903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_47A5;
					case 46:
						if (switches != null)
						{
							num = (short)1177092184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10F2;
					case 47:
						this.a(ref uifields, "");
						num = (short)826540077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (!isRightToLeft)
						{
							num = (short)2060124445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1919746088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_67BE;
					case 50:
						goto IL_4716;
					case 51:
						goto IL_6C53;
					case 52:
						if (!isRightToLeft)
						{
							num = (short)1787560019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1203634326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						this.a(ref uifields, "");
						num = (short)418513059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
						num = (short)625082579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						this.a(ref uifields, a_7);
						num = (short)1831469249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
						num = (short)1029374186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_23A0;
					case 58:
					{
						string text2;
						this.a(ref uifields, text2.ToString());
						num = (short)181141515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						num = (short)1372913726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (mfkassignmentControlInnerRecset != null)
						{
							num = (short)1792999605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10F2;
					case 61:
						goto IL_759F;
					case 62:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.HiddenStatic)
						{
							num = (short)498139362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EBD;
					case 63:
						if (isRightToLeft)
						{
							num = (short)385417515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, a_8);
						num = (short)1026031870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						this.a(ref uifields, text3.ToString());
						num = (short)719716623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_2C26;
					case 66:
						num = (short)1492517029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						goto IL_B81;
					case 68:
						this.a(ref uifields, a_3);
						num = (short)322175215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)757530853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1760559397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
					{
						string a_9;
						this.a(ref uifields, a_9);
						num = (short)477626743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.HiddenStatic)
						{
							num = (short)1143275696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EC;
					case 72:
						num = (short)1893597472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)120389981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2108031206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.HiddenStatic)
						{
							num = (short)762446059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AA1;
					case 75:
					{
						string a_5;
						this.a(ref uifields, a_5);
						num = (short)2074804551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
					{
						string a_9;
						this.a(ref uifields, a_9);
						num = (short)1750204465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 77:
						goto IL_1BFC;
					case 78:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.HiddenStatic)
						{
							num = (short)859111544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2761;
					case 79:
						num = (short)1308164267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.HiddenStatic)
						{
							num = (short)1336017002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)12910815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						num = (short)1932329272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						goto IL_1789;
					case 83:
						this.a(ref uifields, text4.ToString());
						num = (short)280822076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1481769032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1789;
					case 85:
						goto IL_1EBD;
					case 86:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
						num = (short)1222312145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.HiddenStatic)
						{
							num = (short)1040253300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6906;
					case 88:
						mfkassignmentControlInnerRecset = (switches[10637].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset);
						num = (short)1283326012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.HiddenStatic)
						{
							num = (short)2054684768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)837681481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)405798968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)437452989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						goto IL_2609;
					case 92:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1430651214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7029;
					case 93:
						goto IL_13C1;
					case 94:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num6++;
						recSet.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛펝", a_), cultureInfo);
						recSet.RecNo = num6.ToString();
						int num7 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)1684078853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 95:
						if (isRightToLeft)
						{
							num = (short)1812856993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), cultureInfo));
						num = (short)1100873993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						this.a(ref uifields, a_6);
						num = (short)959447045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						goto IL_6749;
					case 98:
						this.a(ref uifields, a_10);
						num = (short)113704967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						if (smartKeyFobRecset != null)
						{
							num = (short)404947124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2511;
					case 100:
						if (isRightToLeft)
						{
							num = (short)1809186832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1145831554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						if (rotaryControlInnerSection != null)
						{
							num = (short)971702395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4716;
					case 102:
						if (!isRightToLeft)
						{
							num = (short)1292370001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2121203739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						goto IL_E39;
					case 104:
						this.a(ref uifields, "");
						num = (short)1341325326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.HiddenStatic)
						{
							num = (short)1577517131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1659;
					case 106:
					{
						string a_5;
						this.a(ref uifields, a_5);
						num = (short)1476788471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 107:
						num = (short)56819814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.HiddenStatic)
						{
							num = (short)650969424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13C1;
					case 109:
						num = (short)259326047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						goto IL_4A30;
					case 111:
						goto IL_E86;
					case 112:
						this.a(ref uifields, a_10);
						num = (short)1495269486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)116392051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)149225824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						if (!isRightToLeft)
						{
							num = (short)55902573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)882573401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						num = (short)1076166936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						num = (short)800260097;
						if (num != 0)
						{
						}
						if (isRightToLeft)
						{
							num = (short)1095893134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
						num = (short)329384280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
						goto IL_490C;
					case 118:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)554958878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2609;
					case 119:
						goto IL_1D9F;
					case 120:
						this.a(ref uifields, a_11);
						num = (short)75890929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						this.a(ref uifields, a_12);
						num = (short)1610416185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						goto IL_1659;
					case 123:
						num = (short)867500232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.HiddenStatic)
						{
							num = (short)60162342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_87F;
					case 125:
						goto IL_2609;
					case 126:
						goto IL_2609;
					case 127:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1966538921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1468793163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
						num = (short)1188757821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 129:
						goto IL_1E71;
					case 130:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.HiddenStatic)
						{
							num = (short)612499675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4819;
					case 131:
						goto IL_1789;
					case 132:
						if (!isRightToLeft)
						{
							num = (short)1029767169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1063321735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
						this.a(ref uifields, a_10);
						num = (short)539099165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
						num = (short)1639252303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.HiddenStatic)
						{
							num = (short)1266352469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)613286188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
						rotaryControlInnerRecset = (switches[10081].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset);
						num = (short)839385430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 137:
						goto IL_1B54;
					case 138:
						num = (short)458817808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 139:
						this.a(ref uifields, a_13);
						num = (short)436338872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						if (portableSideUpDownArrowButtonInnerRecset.HasVisibleObjects)
						{
							num = (short)1331626125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C6;
					case 141:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num6++;
						recSet.RecTitle = global::CommonResources.AcgResources.ID_SIDEARROWBUTTONS;
						recSet.RecNo = num6.ToString();
						int num4 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableSideUpDownArrowButtonInnerRecset.GetEnumerator();
						num = (short)2033909763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 142:
						num = (short)1058537562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
						this.a(ref uifields, text3.ToString());
						num = (short)958267636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
						this.a(ref uifields, a_3);
						num = (short)1833828403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						num = (short)1458831461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
						goto IL_90F;
					case 147:
						num = (short)1546649947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.HiddenStatic)
						{
							num = (short)1563557992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4F;
					case 149:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.HiddenStatic)
						{
							num = (short)1212416139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A0;
					case 150:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)152043524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)365887513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 151:
						goto IL_4819;
					case 152:
						this.a(ref uifields, a_14);
						num = (short)827130063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 153:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), cultureInfo));
						num = (short)277020737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 154:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)353632450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1629814823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 155:
						goto IL_4863;
					case 156:
						goto IL_13C1;
					case 157:
						this.a(ref uifields, text3.ToString());
						num = (short)1471021435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 158:
						goto IL_6906;
					case 159:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1807810560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2609;
					case 160:
						if (portableButtonInnerRecset != null)
						{
							num = (short)1953824951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6ABB;
					case 161:
						num = (short)415760659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 162:
						if (portableSideUpDownArrowButtonInnerRecset != null)
						{
							num = (short)741802233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C6;
					case 163:
						goto IL_6749;
					case 164:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.HiddenStatic)
						{
							num = (short)1225523497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1659;
					case 165:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.HiddenStatic)
						{
							num = (short)121503956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1190920412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 166:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.HiddenStatic)
						{
							num = (short)1312751921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A0;
					case 167:
						num = (short)1774911661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 168:
						goto IL_7379;
					case 169:
						num = (short)1467285690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 170:
						this.a(ref uifields, a_13);
						num = (short)727056561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힕좗슙꾛꺝邟銡", a_)))
						{
							num = (short)1124925534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_772B;
					case 172:
						this.a(ref uifields, "");
						num = (short)1743389035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 173:
						if (global::ConstraintHelper.UtilityMack.IsWorldWidePro)
						{
							num = (short)861471028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)440467630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 174:
						if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힕좗슙꾛꺝邟銡", a_)))
						{
							num = (short)1008271606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1072300051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 175:
						num = (short)648347927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 176:
						this.a(ref uifields, a_3);
						num = (short)106692876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						goto IL_23A0;
					case 178:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num6++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슕쎛캝쾟톡춣튥솧얩슫\uddb1\udab3햵\uddb7풹좻첽ꦿꇁ", a_), cultureInfo);
						recSet.RecNo = num6.ToString();
						int value3 = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.Value;
						int value4 = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Value;
						string a_9 = (string)switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.Converter.Convert(value3, null, null, cultureInfo);
						a_7 = (string)switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Converter.Convert(value4, null, null, cultureInfo);
						num = (short)2023686407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 179:
						num = (short)871235592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 180:
						smartKeyFobButtonTableInnerRecset = (smartKeyFobRecset[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
						num = (short)1034092749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 181:
						mfkassignmentControlInnerSection = (mfkassignmentControlInnerRecset[0][10638] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection);
						mfkassignmentControlInnerSection2 = (mfkassignmentControlInnerRecset[1][10638] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection);
						num = (short)738197882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 182:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num6++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd95ﶗﾝ쒟ﶡ펥\udca7\udea9쎫삭쎯", a_), cultureInfo);
						recSet.RecNo = num6.ToString();
						int num8 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = keypadButtonInnerRecset.GetEnumerator();
						num = (short)653000968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 183:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)819003645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 184:
						goto IL_23A0;
					case 185:
						goto IL_4A9E;
					case 186:
						if (isRightToLeft)
						{
							num = (short)1649410176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)176226324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 187:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.HiddenStatic)
						{
							num = (short)20185304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E71;
					case 188:
						goto IL_3EB2;
					case 189:
						goto IL_10B4;
					case 190:
						goto IL_768D;
					case 191:
						this.a(ref uifields, a_12);
						num = (short)10485906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 192:
						goto IL_4A30;
					case 193:
						goto IL_6906;
					case 194:
						num = (short)861667638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 195:
						this.a(ref uifields, a_13);
						num = (short)1004339390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 196:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)187826521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB2;
					case 197:
						this.a(ref uifields, text3.ToString());
						num = (short)318832855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 198:
						goto IL_4716;
					case 199:
						goto IL_E86;
					case 200:
						if (rotaryControlInnerSection.HasVisibleObjects)
						{
							num = (short)385810646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4716;
					case 201:
						goto IL_6B8F;
					case 202:
						if (buttonsRecset != null)
						{
							num = (short)2006974812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E39;
					case 203:
						if (!isRightToLeft)
						{
							num = (short)865272014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1292829029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 204:
						goto IL_2C26;
					case 205:
						goto IL_2511;
					case 206:
						num = (short)1194000755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 207:
						goto IL_1BFC;
					case 208:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1427439844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)81002517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 209:
						goto IL_7379;
					case 210:
						if (isRightToLeft)
						{
							num = (short)1591672834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, text4.ToString());
						num = (short)1467679089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 211:
						goto IL_49F2;
					case 212:
						this.a(ref uifields, a_6);
						num = (short)1736441923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 213:
						goto IL_4716;
					case 214:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num6++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num6.ToString();
						recSet.RecNo = num6.ToString();
						int switchGeneralRotaryControl_A8984Value = rotaryControlInnerSection.SwitchGeneralRotaryControl_A8984Value;
						text3 = (string)rotaryControlInnerSection.SwitchGeneralRotaryControl_A8984.Converter.Convert(switchGeneralRotaryControl_A8984Value, null, null, cultureInfo);
						num = (short)1609957445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 215:
						goto IL_2A39;
					case 216:
						this.a(ref uifields, a_11);
						num = (short)1686700161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 217:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)270467391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B54;
					case 218:
						if (switches.ConventionalSwitches.HasVisibleObjects)
						{
							num = (short)1314848792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C49;
					case 219:
					{
						string a_4;
						this.a(ref uifields, a_4);
						num = (short)2070806679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 220:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.HiddenStatic)
						{
							num = (short)997589164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B81;
					case 221:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)441647147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_759F;
					case 222:
					{
						string text2;
						this.a(ref uifields, text2.ToString());
						num = (short)1281294524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 223:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.HiddenStatic)
						{
							num = (short)1588855035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A9E;
					case 224:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.HiddenStatic)
						{
							num = (short)1115750413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A30;
					case 225:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.HiddenStatic)
						{
							num = (short)1368457474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)599130186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 226:
					{
						string a_9;
						this.a(ref uifields, a_9);
						num = (short)2072445013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 227:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
						num = (short)1462042845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 228:
						this.a(ref uifields, text3.ToString());
						num = (short)1744896117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 229:
						num = (short)961806674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 230:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)2063532354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_759F;
					case 231:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.HiddenStatic)
						{
							num = (short)807534762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A0;
					case 232:
						this.a(ref uifields, a_10);
						num = (short)188874845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 233:
						this.a(ref uifields, a_6);
						num = (short)1331363881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 234:
						goto IL_10B4;
					case 235:
						this.a(ref uifields, "");
						num = (short)900595981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 236:
						goto IL_3C49;
					case 237:
						if (dataButtonInnerRecset.HasVisibleObjects)
						{
							num = (short)906953071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3997;
					case 238:
						goto IL_7029;
					case 239:
						goto IL_4A30;
					case 240:
						goto IL_140B;
					case 241:
						goto IL_2761;
					case 242:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1910112363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1659;
					case 243:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), cultureInfo));
						num = (short)1282605211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 244:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)2053111872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140B;
					case 245:
						num = (short)1349320727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 246:
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num6++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num6.ToString();
						recSet.RecNo = num6.ToString();
						num = (short)110690377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 247:
						goto IL_4A9E;
					case 248:
					{
						string a_5;
						this.a(ref uifields, a_5);
						num = (short)1722941449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 249:
						num = (short)720437388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 250:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.HiddenStatic)
						{
							num = (short)1805844550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1789;
					case 251:
						this.a(ref uifields, "");
						num = (short)372703417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 252:
						rotaryControlInnerSection = (rotaryControlInnerRecset[0][10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection);
						num = (short)1533608055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 253:
						try
						{
							num = (short)1447821378;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text5;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								switch (num2)
								{
								case 0:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝ﲧﺩ", a_), cultureInfo);
									num = (short)1735196701;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.HiddenStatic)
									{
										num = (short)1327038514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)772407353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.HiddenStatic)
									{
										num = (short)1067450389;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_54BF;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnTopButtonShortPressTime.HiddenStatic)
									{
										num = (short)1715666982;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5477;
								}
								case 4:
									num = (short)294060075;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (text5 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝嶺節ﶱ荒", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1706688557;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2005925914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_5065;
								case 7:
									this.a(ref uifields, "");
									num = (short)1738866749;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)647233577;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙좛톝ﲧ", a_), cultureInfo);
									num = (short)284819472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝", a_), cultureInfo);
									num = (short)1459683352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)979632183;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5298;
								case 12:
									num = (short)1305149442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)19660827;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1754595339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_5477;
								case 15:
									if (text5 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝ﲧﺩ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2057830400;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙첛톝ﮭ﮳", a_), cultureInfo);
									num = (short)977928228;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_502F;
								case 17:
									goto IL_5336;
								case 18:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)173867072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
									if (!isRightToLeft)
									{
										num = (short)333643788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)948961312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnTopButtonShortPressTime.HiddenStatic)
									{
										num = (short)156434465;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5298;
								}
								case 21:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)1525088314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									goto IL_594D;
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.HiddenStatic)
									{
										num = (short)485949512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4E67;
								}
								case 24:
									goto IL_502F;
								case 25:
									goto IL_502F;
								case 26:
									if (text5 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1947729930;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1436745743;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									num = (short)157417518;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)889520187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 29:
									goto IL_502F;
								case 30:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.HiddenStatic)
									{
										num = (short)1006501896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_537D;
								}
								case 31:
									this.a(ref uifields, "");
									num = (short)1436680198;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnTopButtonShortPressTime.HiddenStatic)
									{
										num = (short)1028849682;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)679673859;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 33:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)382730309;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 34:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1960575047;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode2 = enumerator.Current;
									recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									num6++;
									recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num6.ToString();
									recSet.RecNo = num6.ToString();
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection = acpFeatureNode2[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection;
									int btnGeneralConventionalFeature_A19544Value = (acpFeatureNode2[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544Value;
									int btnTrunkingPortableButtonFeature_A19546Value = (acpFeatureNode2[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546Value;
									string text8 = (string)(acpFeatureNode2[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Converter.Convert(btnGeneralConventionalFeature_A19544Value, null, null, cultureInfo);
									string text6 = (string)(acpFeatureNode2[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Converter.Convert(btnTrunkingPortableButtonFeature_A19546Value, null, null, cultureInfo);
									int num9 = (acpFeatureNode2[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTopButtonShortPressTime;
									string text7 = (string)(acpFeatureNode2[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTopButtonShortPressTime.Converter.Convert(num9, null, null, cultureInfo);
									num = (short)1479933965;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 35:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)707526703;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 36:
									goto IL_502F;
								case 37:
									if (text5 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙좛톝ﲧ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1231486985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1605632005;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
									this.a(ref uifields, "");
									num = (short)2070085646;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (portableButtonInnerSection.BtnTopButtonShortPressTime.HiddenStatic)
									{
										num = (short)1610678339;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4DAF;
								}
								case 40:
									goto IL_5298;
								case 41:
									goto IL_537D;
								case 42:
									goto IL_5298;
								case 43:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnTopButtonShortPressTime.HiddenStatic)
									{
										num = (short)164757539;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1988100135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 44:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)1227685950;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 45:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙쾛힝嶺節ﶱ荒", a_), cultureInfo);
									num = (short)778305561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									if (isRightToLeft)
									{
										num = (short)1572470788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1804533783;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
									goto IL_4DAF;
								case 49:
									goto IL_4DAF;
								case 50:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)1838546998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 51:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.HiddenStatic)
									{
										num = (short)1644953628;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5298;
								}
								case 52:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.HiddenStatic)
									{
										num = (short)1717501996;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1202651206;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 53:
									goto IL_4E67;
								case 54:
									goto IL_56FF;
								case 55:
									num = (short)323616787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 56:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)2006646801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 57:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.HiddenStatic)
									{
										num = (short)1040711687;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_56FF;
								}
								case 58:
									goto IL_54BF;
								case 59:
									goto IL_5298;
								case 60:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnTopButtonShortPressTime.HiddenStatic)
									{
										num = (short)1370292297;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5298;
								}
								case 61:
									goto IL_56FF;
								case 62:
									goto IL_5065;
								case 63:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)1697120296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 64:
									goto IL_5477;
								case 65:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.HiddenStatic)
									{
										num = (short)1702035512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5336;
								}
								case 66:
									switch (0)
									{
									case 0:
										goto IL_4C39;
									}
									continue;
								case 67:
									this.a(ref uifields, "");
									num = (short)696451121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 68:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (!portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.HiddenStatic)
									{
										num = (short)1654784063;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5298;
								}
								case 69:
									goto IL_5298;
								case 70:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
									if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.HiddenStatic)
									{
										num = (short)305135647;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5065;
								}
								case 71:
									num = (short)1357905942;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 72:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)481624117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 73:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)1509359658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_4C39;
								IL_4DAF:
								num = (short)1854996481;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4E67:
								num = (short)187695134;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_502F:
								recSet.UIFields.Add(uifields);
								table.RecSet.Add(recSet);
								num = (short)1393295408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5065:
								num = (short)1061486643;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_50AD:
								num = (short)1665400866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4C39:
								goto IL_50AD;
								IL_5298:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner)acpFeatureNode2).PortableButtonInnerSection.BtnPortableButtonName_A22558.UIName.ToString();
								text5 = ((global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner)acpFeatureNode2).PortableButtonInnerSection.BtnPortableButtonName_A22558_UIValue.ToString();
								num = (short)1342308389;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5336:
								num = (short)791085116;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_537D:
								num = (short)692781076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5477:
								num = (short)625279028;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_54BF:
								num = (short)1783103553;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_56FF:
								num = (short)289079364;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_594D:
							goto IL_6ABB;
						}
						finally
						{
							num = (short)1898250240;
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
										goto IL_5985;
									}
									continue;
								case 1:
									goto IL_59BC;
								case 2:
									enumerator.Dispose();
									num = (short)1585512449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5985:
								if (enumerator == null)
								{
									break;
								}
								num = (short)990904322;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_59BC:;
						}
						goto IL_59BF;
					case 254:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)497615157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_698D;
					case 255:
						keypadButtonInnerRecset = (keypadRecset[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
						num = (short)417595593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 256:
					{
						string a_5;
						this.a(ref uifields, a_5);
						num = (short)365559842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 257:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.HiddenStatic)
						{
							num = (short)857997692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E86;
					case 258:
						this.a(ref uifields, a_7);
						num = (short)602996748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 259:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1404895290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)813170954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 260:
						if (isRightToLeft)
						{
							num = (short)1352073391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, a_14);
						num = (short)270860505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 261:
						try
						{
							num = (short)1885208587;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								string text9;
								switch (num2)
								{
								case 0:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)2027225109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)1605959708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1013907462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode3 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection smartKeyFobButtonTableInnerSection = acpFeatureNode3[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection;
									string radErgoCfgFobConventionalFeature_A41574_UIValue = (acpFeatureNode3[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574_UIValue;
									string radErgoCfgFobTrunkingFeature_A41575_UIValue = (acpFeatureNode3[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575_UIValue;
									num = (short)1591017495;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)474873871;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_611F;
								case 3:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﶝ쮟ﶡ킣풥\udda7쒩잫", a_), cultureInfo);
									num = (short)83296270;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙\udd9b튝", a_), cultureInfo);
									num = (short)584908830;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_63AC;
								case 6:
									num = (short)291307533;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_63AC;
								case 9:
									goto IL_63AC;
								case 10:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﶝ쮟ﶡ톣횥", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1100873759;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)43974674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_5CEB;
									}
									continue;
								case 12:
									num = (short)57016320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_643D;
								case 14:
									goto IL_63AC;
								case 15:
								{
									string radErgoCfgFobTrunkingFeature_A41575_UIValue;
									this.a(ref uifields, radErgoCfgFobTrunkingFeature_A41575_UIValue);
									num = (short)1668939805;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda95蓮솝쒟춡펣좥", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1517027363;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)773914634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
								{
									if (text9 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙\udd9b튝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1261502468;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num7;
									num7++;
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙\uda9b톝ﲧ", a_), cultureInfo) + num7.ToString();
									num = (short)203554823;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﶝ쮟ﶡ삣즥\udfa7쒩", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)411041816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)466681875;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﶝ쮟ﶡ킣풥\udda7쒩잫", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1355087875;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1652883473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									goto IL_63AC;
								case 21:
								{
									string radErgoCfgFobTrunkingFeature_A41575_UIValue;
									this.a(ref uifields, radErgoCfgFobTrunkingFeature_A41575_UIValue);
									num = (short)756154402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda95蓮솝햟튡", a_), cultureInfo);
									num = (short)1562836997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									if (isRightToLeft)
									{
										num = (short)1878392844;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1198129188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﶝ쮟ﶡ삣즥\udfa7쒩", a_), cultureInfo);
									num = (short)1348075545;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									goto IL_63AC;
								case 26:
									goto IL_5D18;
								case 27:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda95蓮솝햟튡", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)735707158;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1865678864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									goto IL_5F93;
								case 29:
									goto IL_611F;
								case 30:
									goto IL_63AC;
								case 31:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﶝ쮟ﶡ톣횥", a_), cultureInfo);
									num = (short)2051538964;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection smartKeyFobButtonTableInnerSection;
									if (!smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.HiddenStatic)
									{
										num = (short)1602813990;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_611F;
								}
								case 33:
								{
									string radErgoCfgFobConventionalFeature_A41574_UIValue;
									this.a(ref uifields, radErgoCfgFobConventionalFeature_A41574_UIValue);
									num = (short)2021195802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 34:
									goto IL_5F93;
								case 35:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda95蓮솝쒟춡펣좥", a_), cultureInfo);
									num = (short)1579286537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection smartKeyFobButtonTableInnerSection;
									if (!smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.HiddenStatic)
									{
										num = (short)421855265;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5D18;
								}
								case 37:
									goto IL_611F;
								case 38:
								{
									string radErgoCfgFobConventionalFeature_A41574_UIValue;
									this.a(ref uifields, radErgoCfgFobConventionalFeature_A41574_UIValue);
									num = (short)644349989;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_5CEB;
								IL_5D18:
								num = (short)1032126466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5F93:
								num = (short)16318496;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5FDB:
								num = (short)1821966337;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5CEB:
								goto IL_5FDB;
								IL_611F:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner)acpFeatureNode3).SmartKeyFobButtonTableInnerSection.RadErgoCfgFobButtonName_A41573.UIName.ToString();
								text9 = ((global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner)acpFeatureNode3).SmartKeyFobButtonTableInnerSection.RadErgoCfgFobButtonName_A41573_UIValue.ToString();
								num = (short)2032730139;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_63AC:
								recSet.UIFields.Add(uifields);
								num = (short)1213136904;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_643D:
							goto IL_59BF;
						}
						finally
						{
							num = (short)521863168;
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
										goto IL_6474;
									}
									continue;
								case 1:
									goto IL_64AB;
								case 2:
									enumerator.Dispose();
									num = (short)497090561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6474:
								if (enumerator == null)
								{
									break;
								}
								num = (short)316735490;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_64AB:;
						}
						goto IL_64AE;
					case 262:
						if (smartKeyFobButtonTableInnerRecset != null)
						{
							num = (short)492110069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_772B;
					case 263:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)923468052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)244383828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 264:
						try
						{
							num = (short)706347053;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text10;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								switch (num2)
								{
								case 0:
									if (isRightToLeft)
									{
										num = (short)641662988;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)427098113;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)1184235541;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2F1B;
								}
								case 2:
									goto IL_387C;
								case 3:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킕鍊ꮝﾟ삣", a_), cultureInfo);
									num = (short)882049073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									string a_15;
									this.a(ref uifields, a_15);
									num = (short)1511784466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_387C;
								case 6:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud895鍊ꞝﾟ삣", a_), cultureInfo);
									num = (short)655949835;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킕鍊ꮝﾟ삣", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1699414019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1116930103;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ﮙ솝욡", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1563295781;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)982056989;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_387C;
								case 10:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킕ꪝﾟ삣", a_), cultureInfo);
									num = (short)1345323047;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_387C;
								case 12:
									num = (short)1656487967;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슕꺛솝욡", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)154009644;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1687814184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_2D9C;
								case 15:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)23855139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode4 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection = acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection;
									int radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value = (acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value;
									string a_15 = (string)(acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Converter.Convert(radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value, null, null, cultureInfo);
									num = (short)1755578368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕瞧쎡힣캥좫", a_), cultureInfo);
									num = (short)876019742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펕ﶙ颟ﶡ슥", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)935854121;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1599275046;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_2FC2;
								case 19:
									goto IL_38C1;
								case 20:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슕鍊ﮝ鎟ﶡ슥", a_), cultureInfo);
									num = (short)2054946818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									string a_15;
									this.a(ref uifields, a_15);
									num = (short)83886127;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									if (text10 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙욛\udb9d钣", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2129985578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)665780257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									goto IL_387C;
								case 24:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킕ꪝﾟ삣", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)684851210;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1747320839;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									goto IL_2FC2;
								case 26:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud995ﾙ궛솝욡", a_), cultureInfo);
									num = (short)1637351475;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									goto IL_387C;
								case 29:
								{
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕瞧쎡힣캥좫", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)826212368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num8;
									num8++;
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙힛\udb9d烈ﾩ節ﾯﲱ", a_), cultureInfo) + num8.ToString();
									num = (short)869531657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
									goto IL_387C;
								case 31:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)81592324;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)1172242457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									goto IL_387C;
								case 33:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud995ﾙ궛솝욡", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1058209818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1669333005;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)702218290;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D9C;
								}
								case 35:
									num = (short)1736900627;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									goto IL_2D9C;
								case 37:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ﮙ솝욡", a_), cultureInfo);
									num = (short)383778868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud895鍊ꞝﾟ삣", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1756626950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)492568584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									goto IL_387C;
								case 40:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슕鍊ﮝ鎟ﶡ슥", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)310181908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)757334040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 41:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펕ﶙ颟ﶡ슥", a_), cultureInfo);
									num = (short)1685323781;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙욛\udb9d钣", a_), cultureInfo);
									num = (short)1893859371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									goto IL_387C;
								case 44:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슕꺛솝욡", a_), cultureInfo);
									num = (short)2105933847;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									switch (0)
									{
									case 0:
										goto IL_2D97;
									}
									continue;
								case 46:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ꪛ솝욡", a_), cultureInfo);
									num = (short)1949237280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
									goto IL_2F1B;
								case 48:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1859846197;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D9C;
								case 49:
									goto IL_387C;
								case 50:
								{
									string a_15;
									this.a(ref uifields, a_15);
									num = (short)167903268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 51:
									goto IL_387C;
								case 52:
									goto IL_387C;
								case 53:
								{
									string a_15;
									this.a(ref uifields, a_15);
									num = (short)1745879054;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 54:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ﶗ鍊鞟ﶡ슥", a_), cultureInfo);
									num = (short)143982620;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 55:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ꪛ솝욡", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1493827630;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)637206584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 56:
									if (text10 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ﶗ鍊鞟ﶡ슥", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)532414518;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)997326865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2D97;
								IL_2D9C:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode4).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069.UIName.ToString();
								text10 = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode4).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069_UIValue.ToString();
								num = (short)1239613462;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2F1B:
								num = (short)1361838128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2FC2:
								num = (short)996343842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_357E:
								num = (short)1280901135;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D97:
								goto IL_357E;
								IL_387C:
								recSet.UIFields.Add(uifields);
								num = (short)884473883;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_38C1:
							goto IL_75FA;
						}
						finally
						{
							num = (short)1187840002;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2686977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3932;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_38FA;
									}
									continue;
								}
								IL_38FA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)734986240;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3932:;
						}
						goto IL_3935;
						IL_75FA:
						table.RecSet.Add(recSet);
						num = (short)443547686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 265:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)828178786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2609;
					case 266:
						goto IL_24E5;
					case 267:
						if (keypadRecset != null)
						{
							num = (short)331022591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B8F;
					case 268:
						goto IL_6EC;
					case 269:
						goto IL_5AA1;
					case 270:
						if (!isRightToLeft)
						{
							num = (short)58720483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)477167941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 271:
						goto IL_140B;
					case 272:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)196870198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)1238958097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 273:
						goto IL_140B;
					case 274:
						goto IL_3935;
					case 275:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)2041315571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)1706623344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 276:
						num = (short)227475743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 277:
						num = (short)214499372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 278:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.HiddenStatic)
						{
							num = (short)2125004912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A30;
					case 279:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1531379864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)2125332557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 280:
						if (isRightToLeft)
						{
							num = (short)1114177602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2110980283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 281:
						if (isRightToLeft)
						{
							num = (short)1786904714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
						num = (short)202113116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 282:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.HiddenStatic)
						{
							num = (short)763363702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1789;
					case 283:
						if (switches != null)
						{
							num = (short)381354120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9F;
					case 284:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1404109114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1390870770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 285:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), cultureInfo));
						num = (short)1576075423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 286:
						num = (short)1455620299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 287:
						if (isRightToLeft)
						{
							num = (short)1343095061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)199622952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 288:
						if (!isRightToLeft)
						{
							num = (short)612958267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1870332129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 289:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)245432618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1076428996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 290:
					{
						string text2;
						this.a(ref uifields, text2.ToString());
						num = (short)638845278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 291:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.HiddenStatic)
						{
							num = (short)37159145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E86;
					case 292:
						goto IL_3997;
					case 293:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)958267571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140B;
					case 294:
						this.a(ref uifields, "");
						num = (short)943915314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 295:
						goto IL_E86;
					case 296:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.HiddenStatic)
						{
							num = (short)1252655180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67BE;
					case 297:
					{
						string a_4;
						this.a(ref uifields, a_4);
						num = (short)90308910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 298:
						num = (short)2040332498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 299:
						num = (short)767426892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 300:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.HiddenStatic)
						{
							num = (short)493617205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6749;
					case 301:
						if (!keypadRecset.HiddenStatic)
						{
							num = (short)1194197174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E2C;
					case 302:
						goto IL_1659;
					case 303:
					{
						string a_4;
						this.a(ref uifields, a_4);
						num = (short)836173946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 304:
						if (!global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힕좗슙꾛꺝邟銡", a_)))
						{
							num = (short)782303377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4716;
					case 305:
						this.a(ref uifields, a_12);
						num = (short)808059261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 306:
						goto IL_87F;
					case 307:
						this.a(ref uifields, a_11);
						num = (short)662372463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 308:
						goto IL_64AE;
					case 309:
						this.a(ref uifields, a_8);
						num = (short)1597047142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 310:
						if (isRightToLeft)
						{
							num = (short)3932307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)447217735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 311:
						if (keypadButtonInnerRecset != null)
						{
							num = (short)862454130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E2C;
					case 312:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.HiddenStatic)
						{
							num = (short)1031077910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18BB;
					case 313:
						this.a(ref uifields, a_13);
						num = (short)257818997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 314:
						num = (short)1517158500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 315:
						goto IL_759F;
					case 316:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)855114018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB2;
					case 317:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.HiddenStatic)
						{
							num = (short)1333854399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)392692052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 318:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)678035653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)213909880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 319:
						this.a(ref uifields, a_14);
						num = (short)1476591980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 320:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.HiddenStatic)
						{
							num = (short)358154488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1659;
					case 321:
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num6++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num6.ToString();
						recSet.RecNo = num6.ToString();
						num = (short)1615790462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 322:
						num = (short)1900675342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 323:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.HiddenStatic)
						{
							num = (short)1923809378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A30;
					case 324:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.HiddenStatic)
						{
							num = (short)1189675203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_768D;
					case 325:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1508966486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)721748136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 326:
						goto IL_698D;
					case 327:
						goto IL_1659;
					case 328:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.HiddenStatic)
						{
							num = (short)816709985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1789;
					case 329:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.HiddenStatic)
						{
							num = (short)1249902639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47A5;
					case 330:
						goto IL_1789;
					case 331:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)601227300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A0;
					case 332:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1389756772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)634913123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 333:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1240137885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140B;
					case 334:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
						num = (short)1687814382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 335:
						goto IL_759F;
					case 336:
						this.a(ref uifields, "");
						num = (short)1758396572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 337:
						goto IL_59E6;
					case 338:
						if (isRightToLeft)
						{
							num = (short)734724111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, text3.ToString());
						num = (short)722600269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 339:
						goto IL_7029;
					case 340:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.HiddenStatic)
						{
							num = (short)647168377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_90F;
					case 341:
						this.a(ref uifields, a_12);
						num = (short)1787953249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 342:
						if (rotaryControlInnerRecset != null)
						{
							num = (short)1786642684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9F;
					case 343:
						goto IL_2B03;
					case 344:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)39583878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_759F;
					case 345:
						num = (short)1692729396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 346:
						num = (short)1652818034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 347:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.HiddenStatic)
						{
							num = (short)958267525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1810563196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 348:
						portableButtonInnerRecset = (buttonsRecset[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
						dataButtonInnerRecset = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
						portableSideUpDownArrowButtonInnerRecset = (buttonsRecset[0][10745].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset);
						num = (short)1534394471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 349:
						num = (short)803209332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 350:
						goto IL_3EB2;
					case 351:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.HiddenStatic)
						{
							num = (short)680263983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1659;
					case 352:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1788346714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E86;
					case 353:
					{
						string a_9;
						this.a(ref uifields, a_9);
						num = (short)58720586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 354:
						this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), cultureInfo));
						num = (short)1762001022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 355:
						goto IL_46EF;
					case 356:
						this.a(ref uifields, a_8);
						num = (short)1842151786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 357:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.HiddenStatic)
						{
							num = (short)1453129960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1306263660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 358:
						goto IL_698D;
					case 359:
						goto IL_18BB;
					case 360:
						goto IL_2609;
					case 361:
						if (!switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.HiddenStatic)
						{
							num = (short)516751634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1789;
					case 362:
						goto IL_46EF;
					case 363:
						goto IL_B81;
					case 364:
						goto IL_1B54;
					case 365:
						num = (short)1435631694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 366:
						if (switches.ConventionalSwitches.HasVisibleObjects)
						{
							num = (short)1072169138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E86;
					case 367:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num6++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num6.ToString();
						recSet.RecNo = num6.ToString();
						acpFeatureNode5 = dataButtonInnerRecset[0];
						int btnConventionalButtonDatatButtonFeature_A22610Value = (acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610Value;
						int btnTrunkingButtonDatatButtonFeature_A22608Value = (acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608Value;
						text4 = (string)(acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Converter.Convert(btnConventionalButtonDatatButtonFeature_A22610Value, null, null, cultureInfo);
						string text2 = (string)(acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Converter.Convert(btnTrunkingButtonDatatButtonFeature_A22608Value, null, null, cultureInfo);
						num = (short)487260449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 368:
						goto IL_4863;
					case 369:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)150077662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB2;
					case 370:
						num = (short)63177005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 371:
						if (!switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.HiddenStatic)
						{
							num = (short)1288962192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C53;
					case 372:
						this.a(ref uifields, "");
						num = (short)1189740702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 373:
						goto IL_1303;
					case 374:
						this.a(ref uifields, a_7);
						num = (short)1732771971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 375:
						goto IL_1789;
					case 376:
						goto IL_2A39;
					case 377:
						this.a(ref uifields, "");
						num = (short)808386593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 378:
						goto IL_10F2;
					case 379:
						goto IL_140B;
					case 380:
						this.a(ref uifields, a_11);
						num = (short)510722247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 381:
						goto IL_23A0;
					case 382:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)728170605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1317666934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_634;
					IL_6EC:
					num = (short)597426499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_87F:
					num = (short)1742340122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_90F:
					num = (short)1110114453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9C6:
					num = (short)538771718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B81:
					num = (short)1847984138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E39:
					keypadRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset);
					num = (short)687472907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E86:
					num = (short)335282394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10B4:
					this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
					num = (short)1307902267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10F2:
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)1461846218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1303:
					num = (short)941031430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13C1:
					num = (short)1786052832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_140B:
					uifields.UIFieldName = rotaryControlInnerSection.SwitchRotaryControlButtonName_A22903.UIName.ToString();
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙캛톝ﾥ節ﶱ", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)1623458005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1659:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣殮", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int value5 = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.Value;
					int value6 = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.Value;
					a_13 = (string)switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.Converter.Convert(value5, null, null, cultureInfo);
					a_12 = (string)switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.Converter.Convert(value6, null, null, cultureInfo);
					num = (short)342360191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1789:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣殮", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int value7 = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.Value;
					int value8 = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Value;
					a_11 = (string)switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.Converter.Convert(value7, null, null, cultureInfo);
					a_6 = (string)switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Converter.Convert(value8, null, null, cultureInfo);
					num = (short)1987706993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18BB:
					num = (short)772407616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A4F:
					num = (short)1582104740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B54:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ﶗ蓮쒟쎡횣\udfa5\udfa9슫춭쒯\udbb1\udbb3\ud8b5", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얕ﶗ蓮쒟쎡횣\udfa5\ud9ab삭펯욱\uddb3\ud9b5횷", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)2048131270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BFC:
					this.a(ref uifields, a_14);
					num = (short)461766793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D9F:
					num = (short)1667170350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E71:
					num = (short)2030698531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EBD:
					num = (short)16646426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23A0:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣殮", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int value9 = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.Value;
					int value10 = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.Value;
					a_3 = (string)switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.Converter.Convert(value9, null, null, cultureInfo);
					a_10 = (string)switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.Converter.Convert(value10, null, null, cultureInfo);
					num = (short)462553242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24E5:
					this.a(ref uifields, text4.ToString());
					num = (short)347275296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2511:
					table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풕캟톡ﮣ장욧캩\udfaf\udcb1삳쒵ힷ횹쾻", a_), cultureInfo);
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95ﺙ鍊ﾟ삣", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕ﶗﾛ즟튡킣쾥잧쒩풯", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햕ﮝ캟횡춣즥욧쮩삫羚횱", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슕즟첡쎣殮", a_), cultureInfo));
					recSet = null;
					uifields = null;
					num6 = 0;
					num = (short)2014183452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2609:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕쪛첟", a_);
					uifields.UIFieldDes = "";
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)1090126190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2761:
					num = (short)1197211939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A39:
					this.a(ref uifields, text3.ToString());
					num = (short)1246167313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B03:
					this.a(ref uifields, text4.ToString());
					num = (short)75169829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C26:
					this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), cultureInfo));
					num = (short)1784742248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3935:
					this.a(ref uifields, a_7);
					num = (short)1818558546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3997:
					num = (short)1851851063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C49:
					num = (short)1016398128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EB2:
					uifields.UIFieldName = (acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnButtonDataButtonName_A22612.UIName.ToString();
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙\ud89b\udf9dﲧﺩ莱", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)288620836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46EF:
					this.a(ref uifields, a_8);
					num = (short)153092422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4716:
					num = (short)1848574112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47A5:
					num = (short)892862721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4819:
					num = (short)1008926825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4863:
					this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ쮣쪥\udda7잩즫", a_), cultureInfo));
					num = (short)448397403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_490C:
					this.a(ref uifields, text3.ToString());
					num = (short)1572471024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49F2:
					this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
					num = (short)1092485459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A30:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕즟춡쪣殮", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)233373932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A9E:
					num = (short)935330143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59BF:
					table.RecSet.Add(recSet);
					num = (short)628293969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AA1:
					num = (short)1587609928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64AE:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					num6++;
					recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb95ﾟ톣좥쮧\udea9얫솭\udeafﾳ\ud8b5ힷ\ud8b9", a_), cultureInfo);
					recSet.RecNo = num6.ToString();
					num = (short)506134809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6749:
					num = (short)773062887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67BE:
					num = (short)1913913705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6906:
					num = (short)1847722234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_698D:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕ﾝ튟\udba1펥욧즩\ud8ab잭\udfaf\udcb1", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕ﾝ튟\udba1ﮣ\udda7쒩쾫\udaad\ud9af\uddb1\udab3", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int value11 = mfkassignmentControlInnerSection2.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Value;
					a_14 = (string)mfkassignmentControlInnerSection2.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Converter.Convert(value11, null, null, cultureInfo);
					num = (short)1769079044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6ABB:
					num = (short)450035949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B8F:
					smartKeyFobRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset);
					num = (short)1374093411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C53:
					num = (short)1153892630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E2C:
					num = (short)1219428514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7029:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕", a_);
					uifields.UIFieldDes = "";
					recSet.UIFields.Add(uifields);
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int value12 = mfkassignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Value;
					a_8 = (string)mfkassignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Converter.Convert(value12, null, null, cultureInfo);
					num = (short)1623785535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7379:
					this.a(ref uifields, global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕鍊ﾟ삣", a_), cultureInfo));
					num = (short)2079785021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_759F:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕", a_);
					uifields.UIFieldDes = "";
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)1246953522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_768D:
					num = (short)1788870822;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_59E6:
				IL_772B:
				RptXMLData.tables.Add(table);
				return;
				IL_634:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
				cultureInfo = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				switches = null;
				rotaryControlInnerRecset = null;
				rotaryControlInnerSection = null;
				mfkassignmentControlInnerRecset = null;
				mfkassignmentControlInnerSection = null;
				mfkassignmentControlInnerSection2 = null;
				buttonsRecset = null;
				portableButtonInnerRecset = null;
				dataButtonInnerRecset = null;
				portableSideUpDownArrowButtonInnerRecset = null;
				trunkingSystem = null;
				keypadRecset = null;
				keypadButtonInnerRecset = null;
				smartKeyFobRecset = null;
				smartKeyFobButtonTableInnerRecset = null;
				trunkingSystem = (global::AcpCommonLib.FeatureManager.GetFeature(2064)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				switches = (global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
				num = (short)699400475;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0025110C File Offset: 0x0024F30C
		public void AddButtonsAndControlO2(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType)
		{
			int a_ = 8;
			short num = (short)1980366848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1FF;
				}
				global::System.Globalization.CultureInfo cultureInfo;
				bool isRightToLeft;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset keypadRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset o2InnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset o2NavigationControlsTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset kmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
				for (;;)
				{
					IL_30:
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					string a_2;
					string text3;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2 controlHeadO;
					string a_3;
					int num3;
					string a_4;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
					string radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection o2MFKAssignmentControlInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection o2MFKAssignmentControlInnerSection2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)117374993;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection o2NavigationControlsTableInnerSection;
								string text;
								string text2;
								switch (num2)
								{
								case 0:
									num = (short)802422785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3805;
								case 2:
									goto IL_344C;
								case 3:
									goto IL_3478;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1236795392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									o2NavigationControlsTableInnerSection = (acpFeatureNode[10725] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection);
									int radErgoControlO2UpDownButton_A41278Value = o2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278Value;
									text = (string)o2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278.Converter.Convert(radErgoControlO2UpDownButton_A41278Value, null, null, cultureInfo);
									num = (short)512294917;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									if (isRightToLeft)
									{
										num = (short)1144193036;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, text.ToString());
									num = (short)1221001234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									this.a(ref uifields, text.ToString());
									num = (short)190644232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_3478;
								case 9:
									goto IL_34FF;
								case 10:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1335492622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)415760393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (text2 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊ﾐ첒힔", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1261109263;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_344C;
								case 12:
									num = (short)893255690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쒐쎒힔슖춘쾚튜톞", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1976041492;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)993918987;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									this.a(ref uifields, text.ToString());
									num = (short)555810832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊ﾐ첒힔", a_), cultureInfo);
									num = (short)2048983042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_34FF;
								case 17:
									switch (0)
									{
									case 0:
										goto IL_3447;
									}
									continue;
								case 18:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1477705734;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3478;
								case 19:
									goto IL_344C;
								case 20:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쒐쎒힔슖춘쾚튜톞", a_), cultureInfo);
									num = (short)1392771091;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3447;
								IL_344C:
								recSet.UIFields.Add(uifields);
								num = (short)124125191;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3478:
								uifields.UIFieldName = o2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278.UIName.ToString();
								text2 = o2NavigationControlsTableInnerSection.O2UpDownButtonName_A41277_UIValue.ToString();
								num = (short)236781581;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_34FF:
								this.a(ref uifields, text.ToString());
								num = (short)572719107;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3695:
								num = (short)1798438916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3447:
								goto IL_3695;
							}
							IL_3805:
							goto IL_1DF7;
						}
						finally
						{
							num = (short)1813774338;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1875968001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3875;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_383D;
									}
									continue;
								}
								IL_383D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)645005312;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3875:;
						}
						goto IL_3878;
						IL_1DF7:
						table.RecSet.Add(recSet);
						num = (short)782106632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (keypadRecset != null)
						{
							num = (short)1756823569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39F9;
					case 2:
						if (isRightToLeft)
						{
							num = (short)702545966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, a_2);
						num = (short)600571953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						this.a(ref uifields, text3.ToString());
						num = (short)920453229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_39F9;
					case 5:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o2InnerRecset.GetEnumerator();
						num = (short)796065812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						o2InnerRecset = (controlHeadO2Recset[0][10723].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset);
						o2NavigationControlsTableInnerRecset = (controlHeadO2Recset[0][10722].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset);
						num = (short)30867497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						int value = controlHeadO.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.Value;
						a_3 = (string)controlHeadO.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.Converter.Convert(value, null, null, cultureInfo);
						num = (short)1185087547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_30A;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)1756299325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2023817329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						string radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						string text4 = text4 + this.a + radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						num = (short)2060189726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)498663528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!controlHeadO.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.HiddenStatic)
						{
							num = (short)915865607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1565;
					case 13:
						goto IL_1DCF;
					case 14:
						num = (short)664141879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!isRightToLeft)
						{
							num = (short)332005430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1636302857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1803550793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BAE;
					case 17:
						keypadButtonInnerRecset = (keypadRecset[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
						num = (short)51970052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)103088228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CCE;
					}
					case 19:
						num = (short)1280704555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						try
						{
							num = (short)801636381;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text5;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								switch (num2)
								{
								case 0:
									this.a(ref uifields, text5.ToString());
									num = (short)422838296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)934871065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)37617677;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2105;
								case 3:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)2105278481;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2105;
								case 4:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1687617554;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1918435349;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									this.a(ref uifields, "");
									num = (short)1632960528;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (isRightToLeft)
									{
										num = (short)928317460;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, text5.ToString());
									num = (short)944898051;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1348534295;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode2 = enumerator.Current;
									recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									num3++;
									recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num3.ToString();
									recSet.RecNo = num3.ToString();
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection o2InnerSection = acpFeatureNode2[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection;
									int cho2EmergencyButtonFeature_A41272Value = o2InnerSection.CHO2EmergencyButtonFeature_A41272Value;
									text5 = (string)o2InnerSection.CHO2EmergencyButtonFeature_A41272.Converter.Convert(cho2EmergencyButtonFeature_A41272Value, null, null, cultureInfo);
									num = (short)952369161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)1743061007;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2105;
								case 9:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)229965836;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1186725896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_2105;
								case 11:
									goto IL_2105;
								case 12:
									num = (short)2098003974;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)618266655;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F0E;
								case 14:
									goto IL_2456;
								case 15:
									num = (short)1230831646;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_203B;
								case 17:
									this.a(ref uifields, text5.ToString());
									num = (short)657326091;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									this.a(ref uifields, text5.ToString());
									num = (short)1627652122;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									goto IL_2105;
								case 20:
									num = (short)529465348;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									if (trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)452984837;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_203B;
								case 22:
									this.a(ref uifields, text5.ToString());
									num = (short)1135738899;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									num = (short)1936523278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)362545174;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2105;
								case 25:
									this.a(ref uifields, text5.ToString());
									num = (short)452001824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									goto IL_203B;
								case 28:
									goto IL_1F0E;
								case 29:
									switch (0)
									{
									case 0:
										goto IL_1ECD;
									}
									continue;
								case 30:
									if (!isRightToLeft)
									{
										num = (short)1028718592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)889782273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									this.a(ref uifields, "");
									num = (short)1489698844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									goto IL_1F0E;
								}
								goto IL_1ECD;
								IL_1F0E:
								this.a(ref uifields, text5.ToString());
								num = (short)1366228994;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FFA:
								num = (short)1479737351;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1ECD:
								goto IL_1FFA;
								IL_203B:
								this.a(ref uifields, text5.ToString());
								num = (short)681508874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2105:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2Inner)acpFeatureNode2).O2InnerSection.CHO2EmergencyButtonName_A41270.ToString();
								uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\ude90솒풔\ud996\ude98\ude9a\udf9c쪞", a_), cultureInfo);
								recSet.UIFields.Add(uifields);
								table.RecSet.Add(recSet);
								num = (short)1757216795;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2456:
							goto IL_40A;
						}
						finally
						{
							num = (short)603258880;
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
										goto IL_248D;
									}
									continue;
								case 1:
									goto IL_24C7;
								case 2:
									enumerator.Dispose();
									num = (short)1064173569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_248D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)516096002;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_24C7:;
						}
						goto IL_24CA;
					case 21:
						goto IL_1565;
					case 22:
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)495124563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3356;
					case 23:
						this.a(ref uifields, a_2);
						num = (short)591265895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_1D4D;
					case 25:
						goto IL_1BBA;
					case 26:
						this.a(ref uifields, a_2);
						num = (short)1181614118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (isRightToLeft)
						{
							num = (short)319488019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1413;
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic)
						{
							num = (short)868220929;
							if (num != 0)
							{
							}
							num = (short)1348796452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_398;
					}
					case 29:
					{
						string text4;
						if (text4 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎킐킒솔\ude96횘햚\ude9c킞ﮮﲲ﮴", a_), cultureInfo))
						{
							num = (short)466223114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D75;
					}
					case 30:
						goto IL_1D75;
					case 31:
						goto IL_15A2;
					case 32:
						goto IL_38FC;
					case 33:
						goto IL_3BAC;
					case 34:
						this.a(ref uifields, a_3);
						num = (short)1832386584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)680394840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_615;
					case 36:
					{
						string text4;
						this.a(ref uifields, text4.ToString());
						num = (short)591462440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						try
						{
							num = (short)1761017875;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								string text8;
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)968884252;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CB1;
								}
								case 1:
									goto IL_2EB7;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)1694826546;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)485228553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)326238224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖\udb98풚즜쮞ﶨﾪ", a_), cultureInfo);
									num = (short)603521034;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)1082261533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1542651924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)663355439;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CB1;
								}
								case 7:
									goto IL_272C;
								case 8:
									goto IL_272C;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)889585681;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2EB7;
								}
								case 10:
									goto IL_2A11;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)208928812;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CB1;
								}
								case 12:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)216924163;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CB1;
								case 13:
									goto IL_2A11;
								case 14:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)1399848998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									goto IL_2A11;
								case 16:
									if (!isRightToLeft)
									{
										num = (short)472711217;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)375783426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									this.a(ref uifields, "");
									num = (short)2040594462;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									if (isRightToLeft)
									{
										num = (short)1686503466;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1242300461;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									switch (0)
									{
									case 0:
										goto IL_26ED;
									}
									continue;
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)468451374;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_272C;
								}
								case 21:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)486342699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode3 = enumerator.Current;
									recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									num3++;
									recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num3.ToString();
									recSet.RecNo = num3.ToString();
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection = acpFeatureNode3[10239] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection;
									int radErgoCfgKMConventionalKMButtonFeature_A19646Value = kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646Value;
									int radErgoCfgKMTrunkingKMButtonFeature_A19746Value = kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746Value;
									string text6 = (string)kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Converter.Convert(radErgoCfgKMConventionalKMButtonFeature_A19646Value, null, null, cultureInfo);
									string text7 = (string)kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Converter.Convert(radErgoCfgKMTrunkingKMButtonFeature_A19746Value, null, null, cultureInfo);
									num = (short)2114584617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									goto IL_2CB1;
								case 23:
									goto IL_2BE4;
								case 24:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)1364262935;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									goto IL_2CB1;
								case 26:
									goto IL_2A11;
								case 27:
									if (text8 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖\udb98풚즜쮞ﶨﾪ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1398341636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\ude90Ꚓ힔슖춘쾚튜톞", a_), cultureInfo);
									num = (short)891944986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)888930329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 29:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)2143879176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
									goto IL_2EB7;
								case 31:
									goto IL_300F;
								case 33:
									if (text8 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖풘튚\ud99c\udb9eﶨﾪ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)540409908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1005453339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									goto IL_2CB1;
								case 35:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖춘풚출\udd9e", a_), cultureInfo);
									num = (short)1231945741;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									num = (short)1050607634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)2143879207;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 38:
									goto IL_2B9E;
								case 39:
									goto IL_2CB1;
								case 40:
									if (text8 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖춘풚출\udd9e", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1146486819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1807417377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 41:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)2051473444;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1039138828;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									num = (short)1313210373;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									num = (short)1480589343;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)1698234390;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 45:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)2046296088;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BE4;
								}
								case 46:
									this.a(ref uifields, "");
									num = (short)1382481927;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)612827170;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 48:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)315686949;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CB1;
								}
								case 49:
									num = (short)1985478707;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)523173889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 51:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)1089798158;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B9E;
								}
								case 52:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖풘튚\ud99c\udb9eﶨﾪ", a_), cultureInfo);
									num = (short)1848049679;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_26ED;
								IL_272C:
								num = (short)663617584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A11:
								recSet.UIFields.Add(uifields);
								table.RecSet.Add(recSet);
								num = (short)861470752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B9E:
								num = (short)382009355;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2BE4:
								num = (short)360841222;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2CB1:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode3).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561.UIName.ToString();
								text8 = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode3).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561_UIValue.ToString();
								num = (short)840106024;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2E48:
								num = (short)1582891029;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_26ED:
								goto IL_2E48;
								IL_2EB7:
								num = (short)799997952;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_300F:
							goto IL_3166;
						}
						finally
						{
							num = (short)1995177984;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3046;
									}
									continue;
								case 1:
									goto IL_30AE;
								case 2:
									goto IL_30CF;
								}
								IL_3046:
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (enumerator == null)
								{
									break;
								}
								num = (short)2082783922;
								short num4 = num;
								num = (short)1446757042;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1776615424;
									if (num != 0)
									{
									}
									num = (short)1844576257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_30AE:
								enumerator.Dispose();
								num = (short)1414922242;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_30CF:;
						}
						goto IL_30D2;
					case 38:
						goto IL_38FC;
					case 39:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1347747874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)770637923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_398;
					case 41:
						goto IL_1A06;
					case 42:
						if (controlHeadO != null)
						{
							num = (short)989265990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1565;
					case 43:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)558366828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)408289359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						goto IL_15A2;
					case 45:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic)
						{
							num = (short)434372685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CCE;
					}
					case 46:
						num = (short)2051539011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_2C3;
					case 48:
						if (controlHeadO2Recset != null)
						{
							num = (short)366084102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A06;
					case 49:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1415249946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38FC;
					case 50:
						goto IL_30D2;
					case 51:
						goto IL_1CCE;
					case 52:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)1294598234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C3;
					}
					case 53:
						if (kmbuttonInnerRecset != null)
						{
							num = (short)1733754975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3166;
					case 54:
						num = (short)170721308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (isRightToLeft)
						{
							num = (short)1951858699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24CA;
					case 56:
						goto IL_1A92;
					case 57:
						goto IL_3356;
					case 58:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic)
						{
							num = (short)272760914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18FE;
					}
					case 59:
						if (isRightToLeft)
						{
							num = (short)2062155888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, a_3);
						num = (short)396886051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_1CCE;
					case 61:
						this.a(ref uifields, text3.ToString());
						num = (short)1602551852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1337786382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1186136174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (o2NavigationControlsTableInnerRecset != null)
						{
							num = (short)1899233365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30A;
					case 64:
						goto IL_3878;
					case 65:
						goto IL_18FE;
					case 66:
						goto IL_2567;
					case 67:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1971650583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)458621030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						this.a(ref uifields, text3.ToString());
						num = (short)325320785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						this.a(ref uifields, a_4);
						num = (short)882769996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						num = (short)932446220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						num = (short)601817195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						goto IL_615;
					case 73:
						num = (short)1329528918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						goto IL_1A54;
					case 75:
						num = (short)1791361039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						goto IL_2567;
					case 77:
					{
						string text4;
						this.a(ref uifields, text4.ToString());
						num = (short)1015742515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 78:
						if (controlHeadO != null)
						{
							num = (short)479723607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A92;
					case 79:
						goto IL_1DCF;
					case 80:
						if (text3 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎킐킒솔\ude96횘햚\ude9c킞ﮮﲲ﮴", a_), cultureInfo))
						{
							num = (short)1770192946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BBA;
					case 81:
						goto IL_2C3;
					case 82:
					{
						string text4;
						this.a(ref uifields, text4.ToString());
						num = (short)2039087169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 83:
						kmbuttonInnerRecset = (keypadMicAndAccessoriesRecset[0][10231].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset);
						dataButtonInnerRecset = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)576782393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						goto IL_615;
					case 85:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\udf90튒쎔\ude96\ude98\uda9a즜횞ﾪﾬﶰ", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o2NavigationControlsTableInnerRecset.GetEnumerator();
						num = (short)1278214144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 86:
						if (o2InnerRecset != null)
						{
							num = (short)1515847685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40A;
					case 87:
						o2MFKAssignmentControlInnerRecset = (controlHeadO[10721].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset);
						num = (short)1162674267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						this.a(ref uifields, a_3);
						num = (short)256376916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						try
						{
							num = (short)1023410221;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text9;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								switch (num2)
								{
								case 0:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒊ꂐ첒\udc94", a_), cultureInfo);
									num = (short)1271791645;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊搜Ꞓ쪔\ude96ﶘ", a_), cultureInfo);
									num = (short)1798373379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8a戴ꎐ첒\udc94", a_), cultureInfo);
									num = (short)846921771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_FDC;
								case 4:
									goto IL_7D6;
								case 5:
									if (text9 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쮐횒잔\ud896ꦘ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1675952146;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1278869535;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1577189423;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a歷첒\udc94", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)703594547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)726204431;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊搜Ꞓ쪔\ude96ﶘ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)950009857;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)200540200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aꞐ첒\udc94", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1359675414;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)901644304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a年ﶒꊔ좖킘ﾚ", a_), cultureInfo);
									num = (short)508362791;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)1972633653;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_FDC;
								case 13:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8aﶎꚔ좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1627652146;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)103284744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									string text10;
									this.a(ref uifields, text10);
									num = (short)878903319;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8a搜ﾐ\udd94슜횞얠", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1057357866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num5;
									num5++;
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\uda90횒첔잖\ud898\udf9a\udf9c쪞", a_), cultureInfo) + num5.ToString();
									num = (short)1862336556;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a年ﶒꊔ좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1897922570;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)716570665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8a戴ꎐ첒\udc94", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)37814274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1217200141;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쮐횒잔\ud896ꦘ", a_), cultureInfo);
									num = (short)516882460;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									goto IL_9DF;
								case 20:
									goto IL_FDC;
								case 21:
								{
									string text10;
									this.a(ref uifields, text10);
									num = (short)906166291;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aꞐ첒\udc94", a_), cultureInfo);
									num = (short)1634402324;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									goto IL_F30;
								case 24:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)634126347;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode4 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection = acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection;
									int radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value = (acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value;
									string text10 = (string)(acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Converter.Convert(radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value, null, null, cultureInfo);
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue = (acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)1956249654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
									goto IL_FDC;
								case 27:
									goto IL_11F4;
								case 28:
									goto IL_FDC;
								case 29:
									goto IL_FDC;
								case 30:
								{
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									string text10 = text10 + this.a + radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)717357083;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 31:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒊ꂐ첒\udc94", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)227344384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1095172113;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									goto IL_FDC;
								case 33:
									goto IL_FDC;
								case 34:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)1482031125;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9DF;
								}
								case 35:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얊ꪒ쪔\ude96ﶘ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1659633702;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)552796167;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
								{
									string text10;
									this.a(ref uifields, text10);
									num = (short)672923706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 37:
									goto IL_FDC;
								case 38:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얊ꪒ쪔\ude96ﶘ", a_), cultureInfo);
									num = (short)914227237;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									goto IL_FDC;
								case 40:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊年Ꚓ쪔\ude96ﶘ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1910439988;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2116091913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 41:
									if (text9 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캊戀궔좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)386007086;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)141426723;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8a搜ﾐ\udd94슜횞얠", a_), cultureInfo);
									num = (short)103153696;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									goto IL_FDC;
								case 44:
									goto IL_FDC;
								case 45:
									switch (0)
									{
									case 0:
										goto IL_7D1;
									}
									continue;
								case 46:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캊戀궔좖킘ﾚ", a_), cultureInfo);
									num = (short)1959657484;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)993263630;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)587399223;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
								{
									string text10;
									this.a(ref uifields, text10);
									num = (short)902234116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 49:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)451346468;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7D6;
								case 50:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8aﶎꚔ좖킘ﾚ", a_), cultureInfo);
									num = (short)207552571;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 51:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a歷첒\udc94", a_), cultureInfo);
									num = (short)1717370913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 52:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊年Ꚓ쪔\ude96ﶘ", a_), cultureInfo);
									num = (short)1284177946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
									goto IL_13A1;
								case 54:
								{
									string text10;
									if (text10 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쎐횒\ud994횖삘쮚\udc9c쮞", a_), cultureInfo))
									{
										num = (short)165609502;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11F4;
								}
								case 55:
									goto IL_F30;
								case 56:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)769851440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7D6;
								}
								case 57:
									if (isRightToLeft)
									{
										num = (short)866451462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1758789666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 58:
									goto IL_7D6;
								case 59:
									goto IL_FDC;
								}
								goto IL_7D1;
								IL_7D6:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode4).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069.UIName.ToString();
								text9 = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode4).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069_UIValue.ToString();
								num = (short)2026373125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9DF:
								num = (short)1611857969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F30:
								num = (short)511705144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FDC:
								recSet.UIFields.Add(uifields);
								num = (short)1441071129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1175:
								num = (short)1414856728;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7D1:
								goto IL_1175;
								IL_11F4:
								num = (short)74121273;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_13A1:
							goto IL_3B85;
						}
						finally
						{
							num = (short)256835585;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_1410;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_13D8;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1071448064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_13D8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1240924162;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1410:;
						}
						goto IL_1413;
						IL_3B85:
						table.RecSet.Add(recSet);
						num = (short)1073479713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						this.a(ref uifields, "");
						num = (short)900464687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						if (o2MFKAssignmentControlInnerRecset != null)
						{
							num = (short)705036394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A92;
					case 92:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)1198260227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CCE;
					}
					case 93:
						if (dataButtonInnerRecset != null)
						{
							num = (short)566886498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A54;
					case 94:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic)
						{
							num = (short)1096548448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CCE;
					}
					case 95:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = kmbuttonInnerRecset.GetEnumerator();
						num = (short)942276645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 96:
					{
						string text4;
						this.a(ref uifields, text4.ToString());
						num = (short)1774780476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 97:
						if (keypadButtonInnerRecset != null)
						{
							num = (short)517013575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BAE;
					case 98:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num3.ToString();
						recSet.RecNo = num3.ToString();
						acpFeatureNode5 = dataButtonInnerRecset[0];
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = acpFeatureNode5[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						int radErgoCfgKMConventionalKMDatatButtonFeature_A22603Value = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603Value;
						int radErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value;
						string text4 = (string)dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Converter.Convert(radErgoCfgKMConventionalKMDatatButtonFeature_A22603Value, null, null, cultureInfo);
						text3 = (string)dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Converter.Convert(radErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value, null, null, cultureInfo);
						string radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
						num = (short)517865501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 99:
						goto IL_1D4D;
					case 100:
						this.a(ref uifields, text3.ToString());
						num = (short)1744371813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						goto IL_1CCE;
					case 102:
						goto IL_1C08;
					case 103:
						goto IL_1C08;
					case 104:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)1628569668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1884291124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 105:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삊좖\udb98캠춢횤", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						int num5 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = keypadButtonInnerRecset.GetEnumerator();
						num = (short)1151008857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 106:
						o2MFKAssignmentControlInnerSection = (o2MFKAssignmentControlInnerRecset[0][10726] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection);
						o2MFKAssignmentControlInnerSection2 = (o2MFKAssignmentControlInnerRecset[1][10726] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection);
						num = (short)1381367864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						if (!keypadRecset.HiddenStatic)
						{
							num = (short)951517289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BAE;
					case 108:
						this.a(ref uifields, a_4);
						num = (short)1603403789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						goto IL_1CCE;
					case 110:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1963524171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CCE;
					case 111:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)415563845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2567;
					case 112:
						num = (short)1762328615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)693960768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A2;
					}
					}
					goto IL_1FF;
					IL_2C3:
					num = (short)931201069;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30A:
					num = (short)1602224221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_398:
					num = (short)37552128;
					short num6 = num;
					num = (short)1661993052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40A:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					num3++;
					recSet.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\udc90욒\ud994쎖킘\udd9a좜톞", a_), cultureInfo);
					recSet.RecNo = num3.ToString();
					o2MFKAssignmentControlInnerRecset = null;
					o2MFKAssignmentControlInnerSection = null;
					o2MFKAssignmentControlInnerSection2 = null;
					controlHeadO = null;
					controlHeadO = (global::AcpCommonLib.FeatureManager.GetFeature(4115)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2);
					num = (short)820772906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_615:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욊쮌쒎손\ud99a삠햢첤좦\udba8", a_);
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\udc90햒\ude94잖쮘\ude9a캜첞ﾨﶮ", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					num = (short)1699282965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1413:
					this.a(ref uifields, a_4);
					num = (short)467861615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1565:
					num = (short)598474830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15A2:
					num = (short)1540030558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18FE:
					num = (short)277348370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A06:
					keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
					num = (short)436469782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A54:
					num = (short)1896743009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A92:
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int value2 = o2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.Value;
					a_2 = (string)o2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.Converter.Convert(value2, null, null, cultureInfo);
					num = (short)1720385538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BBA:
					num = (short)1241317438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C08:
					this.a(ref uifields, a_2);
					num = (short)164626464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CCE:
					uifields.UIFieldName = (acpFeatureNode5[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMDataButtonName_A22601.UIName.ToString();
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎햐튒솔횖\udb98캚즜쮞瘝隦", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)449904714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D4D:
					this.a(ref uifields, a_3);
					num = (short)803012680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D75:
					num = (short)209846352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DCF:
					this.a(ref uifields, a_4);
					num = (short)1189740610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24CA:
					num = (short)1976434746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2567:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aﺐﶒ\udb9c쾠삢톤캦욨얪", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aﺐﶒ슜\ud99e풠춢욤펦삨쒪쎬", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)1895235637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30D2:
					text3 = text3 + this.a + radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
					num = (short)1211432985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3166:
					num = (short)908263487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3356:
					keypadRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset);
					num = (short)1477509121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3878:
					this.a(ref uifields, "");
					num = (short)873791519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38FC:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8aﾌﲐ\udf98ﲞ햠쪢쪤즦", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8aﾌﲐ욘\udd9a슠힢첤좦잨", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int value3 = o2MFKAssignmentControlInnerSection2.RadErgoControlO2MFKFeatureAssignment_A41275.Value;
					a_4 = (string)o2MFKAssignmentControlInnerSection2.RadErgoControlO2MFKFeatureAssignment_A41275.Converter.Convert(value3, null, null, cultureInfo);
					num = (short)1263927323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39F9:
					table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즊ﮎﲒﮔ욘漢ﮞﺠ쪤즦\udda8\ud9aa슬쎮슰", a_), cultureInfo);
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊쪔\ude96ﶘ", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊ﲎﲔﺠ솤", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좊ﮔﺞ춠ﲢ쎦", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8aﾌ搜ﾐﲔ練ﺘ쒚풜\udb9e", a_), cultureInfo));
					recSet = null;
					uifields = null;
					num3 = 0;
					num = (short)235470864;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3BAC:
				IL_3BAE:
				RptXMLData.tables.Add(table);
				return;
				IL_1FF:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
				cultureInfo = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				o2InnerRecset = null;
				kmbuttonInnerRecset = null;
				dataButtonInnerRecset = null;
				controlHeadO2Recset = null;
				o2NavigationControlsTableInnerRecset = null;
				keypadMicAndAccessoriesRecset = null;
				trunkingSystem = null;
				keypadRecset = null;
				keypadButtonInnerRecset = null;
				trunkingSystem = (global::AcpCommonLib.FeatureManager.GetFeature(2064)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = global::AcpCommonLib.FeatureManager.GetFeature(4115)[0];
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = global::AcpCommonLib.FeatureManager.GetFeature(2128)[0];
				controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
				num = (short)111738928;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00254D38 File Offset: 0x00252F38
		public void AddButtonsAndControlO3(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType)
		{
			int a_ = 8;
			short num = (short)1964703744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_149;
				}
				bool isRightToLeft;
				global::System.Globalization.CultureInfo cultureInfo;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset keypadRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset o3NavigationControlsTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset o3HHCHButtonInnerRecset;
				for (;;)
				{
					IL_32:
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					string text3;
					string text4;
					int num4;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
					string cho3DataButtonTrkIndex_A41420_UIValue;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenStatic)
						{
							num = (short)399835140;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)697958410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.HiddenStatic)
						{
							num = (short)1569521669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143B;
					}
					case 2:
						if (!isRightToLeft)
						{
							num = (short)218890275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)323289088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)1945894930;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text;
								string text2;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection o3NavigationControlsTableInnerSection;
								switch (num2)
								{
								case 0:
									this.a(ref uifields, text.ToString());
									num = (short)1341456403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (text2 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊ﾐ첒힔", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)437125122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_55C;
								case 2:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊ﾐ첒힔", a_), cultureInfo);
									num = (short)788332556;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_6C9;
								case 4:
									if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쒐쎒힔슖춘쾚튜톞", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1347026953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2022244353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_30E;
								case 6:
									num = (short)671744003;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_55C;
								case 8:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1864499200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)608567310;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쒐쎒힔슖춘쾚튜톞", a_), cultureInfo);
									num = (short)941228039;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									this.a(ref uifields, text.ToString());
									num = (short)1534394379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_30E;
								case 12:
									goto IL_55C;
								case 13:
									num = (short)1199636488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_4AD;
								case 15:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1081475082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30E;
								case 17:
									if (isRightToLeft)
									{
										num = (short)962592781;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, text.ToString());
									num = (short)1590755343;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									switch (0)
									{
									case 0:
										goto IL_309;
									}
									continue;
								case 19:
									goto IL_4AD;
								case 20:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)907149318;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									o3NavigationControlsTableInnerSection = (acpFeatureNode[10733] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection);
									int radErgoControlO3NaviControlFeature_A41375Value = o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlFeature_A41375Value;
									text = (string)o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlFeature_A41375.Converter.Convert(radErgoControlO3NaviControlFeature_A41375Value, null, null, cultureInfo);
									num = (short)1300299793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_309;
								IL_30E:
								uifields.UIFieldName = o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlName_A41374.UIName.ToString();
								text2 = o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlName_A41374_UIValue.ToString();
								num = (short)373489668;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4AD:
								this.a(ref uifields, text.ToString());
								num = (short)2143813637;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_55C:
								recSet.UIFields.Add(uifields);
								num = (short)243531792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_584:
								num = (short)1449132052;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_309:
								goto IL_584;
							}
							IL_6C9:
							goto IL_19D7;
						}
						finally
						{
							num = (short)1877213184;
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
										goto IL_700;
									}
									continue;
								case 1:
								{
									num = (short)1833096880;
									short num3 = num;
									num = (short)2084034224;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1484193792;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										break;
									}
									num = (short)240517122;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_78A;
								}
								IL_700:
								if (enumerator == null)
								{
									break;
								}
								num = (short)878903297;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_78A:;
						}
						goto IL_78D;
						IL_19D7:
						table.RecSet.Add(recSet);
						num = (short)1692008513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						this.a(ref uifields, text3);
						num = (short)1326776377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						this.a(ref uifields, text4);
						num = (short)275316783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (keypadRecset != null)
						{
							num = (short)1297350694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A43;
					case 7:
						this.a(ref uifields, text4);
						num = (short)985071674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.HiddenStatic)
						{
							num = (short)1788870663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1482;
					}
					case 9:
						try
						{
							num = (short)809631747;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text5;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								switch (num2)
								{
								case 0:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖춘풚출\udd9e", a_), cultureInfo);
									num = (short)1820065848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!isRightToLeft)
									{
										num = (short)562561028;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)293077040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_E37;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_8E8;
									}
									continue;
								case 4:
									num = (short)1791623220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1259;
								case 6:
									num = (short)24051729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (text5 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎얐\udc92얔\uda96킘\udf9a\ud99c펞ﶨ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2039545903;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1489305658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_11CA;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (!o3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.HiddenStatic)
									{
										num = (short)1849622579;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C33;
								}
								case 10:
									goto IL_C33;
								case 11:
									num = (short)448331795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_1259;
								case 13:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)1750990859;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1282408489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_C33;
								case 15:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖\udb98풚즜쮞ﶨﾪ", a_), cultureInfo);
									num = (short)730726405;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_E7D;
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (!o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenStatic)
									{
										num = (short)110755864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)172163108;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenStatic)
									{
										num = (short)1035534369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E37;
								}
								case 19:
									if (isRightToLeft)
									{
										num = (short)746127366;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)805044247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									if (text5 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖풘튚\ud99c\udb9eﶨﾪ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)123076637;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1342570527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									goto IL_C33;
								case 22:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)1213267982;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (!o3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.HiddenStatic)
									{
										num = (short)1801388062;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1212;
								}
								case 24:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)1015414792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									goto IL_1259;
								case 26:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)264765479;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode2 = enumerator.Current;
									recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									num4++;
									recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num4.ToString();
									recSet.RecNo = num4.ToString();
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection = acpFeatureNode2[10210] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection;
									int cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650Value = o3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650Value;
									int cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750Value = o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750Value;
									string text7 = (string)o3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Converter.Convert(cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650Value, null, null, cultureInfo);
									string text6 = (string)o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Converter.Convert(cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750Value, null, null, cultureInfo);
									num = (short)1245118477;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
									goto IL_1212;
								case 28:
									goto IL_135B;
								case 29:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖풘튚\ud99c\udb9eﶨﾪ", a_), cultureInfo);
									num = (short)619773964;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)1786052635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 31:
									if (text5 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖\udb98풚즜쮞ﶨﾪ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2024341519;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\ude90ꂒ힔슖춘쾚튜톞", a_), cultureInfo);
									num = (short)2025979941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)1660747814;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 33:
									this.a(ref uifields, "");
									num = (short)1031274498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									goto IL_11CA;
								case 35:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)875888694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 36:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenStatic)
									{
										num = (short)678559797;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11CA;
								}
								case 37:
									goto IL_1259;
								case 38:
									goto IL_E37;
								case 39:
									num = (short)126484508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 40:
									goto IL_1259;
								case 41:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)69795897;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C33;
								case 42:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)952827920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 43:
									if (text5 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎얐\udc92얔얖킘\udc9a햜쮞", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)174325809;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1392443399;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
								{
									string text6;
									this.a(ref uifields, text6.ToString());
									num = (short)1629945877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 45:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (!o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenStatic)
									{
										num = (short)443547670;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C33;
								}
								case 46:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (!o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenStatic)
									{
										num = (short)1840447532;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C33;
								}
								case 47:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎얐\udc92얔\uda96킘\udf9a\ud99c펞ﶨ", a_), cultureInfo);
									num = (short)2107965480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (!o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenStatic)
									{
										num = (short)1542914080;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2124480530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 49:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎얐\udc92얔얖킘\udc9a햜쮞", a_), cultureInfo);
									num = (short)892993561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (!o3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.HiddenStatic)
									{
										num = (short)777781283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C33;
								}
								case 51:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)780009482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 52:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
									if (!o3HHCHButtonInnerSection.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.HiddenStatic)
									{
										num = (short)1467744298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E7D;
								}
								case 53:
									this.a(ref uifields, "");
									num = (short)2113601570;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 54:
									goto IL_C33;
								case 56:
									goto IL_1259;
								case 57:
									num = (short)735117313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 58:
									if (text5 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎슐\uda92톔튖춘풚출\udd9e", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1532952576;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1360789524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_8E8;
								IL_C33:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner)acpFeatureNode2).O3HHCHButtonInnerSection.CntrlHeadO3HHCHButtonName_A22523.UIName.ToString();
								text5 = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner)acpFeatureNode2).O3HHCHButtonInnerSection.CntrlHeadO3HHCHButtonName_A22523_UIValue.ToString();
								num = (short)358154283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E37:
								num = (short)1901461554;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E7D:
								num = (short)244449326;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11CA:
								num = (short)2124087305;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1212:
								num = (short)1351352365;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1259:
								recSet.UIFields.Add(uifields);
								table.RecSet.Add(recSet);
								num = (short)1431175223;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12BD:
								num = (short)1484455962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8E8:
								goto IL_12BD;
							}
							IL_135B:
							goto IL_17C8;
						}
						finally
						{
							num = (short)1216217090;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1666908161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_13CB;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1392;
									}
									continue;
								}
								IL_1392:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1532231680;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_13CB:;
						}
						goto IL_13CE;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenStatic)
						{
							num = (short)1664090144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_78D;
					}
					case 11:
						goto IL_2B3A;
					case 12:
						goto IL_2BF5;
					case 13:
						if (keypadButtonInnerRecset != null)
						{
							num = (short)386072601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CCE;
					case 14:
						goto IL_1A49;
					case 15:
						if (isRightToLeft)
						{
							num = (short)1846476848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)918355969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						this.a(ref uifields, text3);
						num = (short)237043731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						this.a(ref uifields, text3);
						num = (short)1949106235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1187840055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165E;
					case 19:
						goto IL_1482;
					case 20:
						goto IL_1830;
					case 21:
						goto IL_13CE;
					case 22:
						if (o3NavigationControlsTableInnerRecset != null)
						{
							num = (short)1087897661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1621;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.HiddenStatic)
						{
							num = (short)1042219032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1482;
					}
					case 24:
						this.a(ref uifields, text4);
						num = (short)1742471205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)101056551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_165E;
					case 27:
						goto IL_1482;
					case 28:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num4++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삊좖\udb98캠춢횤", a_), cultureInfo);
						recSet.RecNo = num4.ToString();
						int num5 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = keypadButtonInnerRecset.GetEnumerator();
						num = (short)1447362624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (text4 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎킐킒솔\ude96횘햚\ude9c킞ﮮﲲ﮴", a_), cultureInfo))
						{
							num = (short)1917452334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1830;
					case 30:
						o3HHCHButtonInnerRecset = (controlHeadO3Recset[0][10235].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset);
						dataButtonInnerRecset = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						o3NavigationControlsTableInnerRecset = (controlHeadO3Recset[0][10732].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset);
						num = (short)1145831438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenStatic)
						{
							num = (short)725614645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1482;
					}
					case 32:
						this.a(ref uifields, "");
						num = (short)303104043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						this.a(ref uifields, "");
						num = (short)42598411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_21F;
					case 35:
						num = (short)1350369336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (o3HHCHButtonInnerRecset != null)
						{
							num = (short)1272643626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17C8;
					case 37:
						goto IL_1482;
					case 38:
						keypadButtonInnerRecset = (keypadRecset[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
						num = (short)1524629548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (!keypadRecset.HiddenStatic)
						{
							num = (short)1966276636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CCE;
					case 40:
						num = (short)1355612162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)1456340993;
						if (num != 0)
						{
						}
						if (text3 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎킐킒솔\ude96횘햚\ude9c킞ﮮﲲ﮴", a_), cultureInfo))
						{
							num = (short)8716350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16FF;
					case 42:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o3HHCHButtonInnerRecset.GetEnumerator();
						num = (short)1326448649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_78D;
					case 44:
						goto IL_2A43;
					case 45:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)665321522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2118189116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
					{
						string cho3DataButtonConvIndex_A41419_UIValue;
						text4 = text4 + this.a + cho3DataButtonConvIndex_A41419_UIValue;
						num = (short)1055916052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_143B;
					case 48:
						num = (short)1131544642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)2101805123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CCE;
					case 50:
						num = (short)751435791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_16FF;
					case 52:
						if (controlHeadO3Recset != null)
						{
							num = (short)1154088990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A49;
					case 53:
						this.a(ref uifields, text3);
						num = (short)298647579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenStatic)
						{
							num = (short)1201143841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B3A;
					}
					case 55:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num4++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num4.ToString();
						recSet.RecNo = num4.ToString();
						acpFeatureNode3 = dataButtonInnerRecset[0];
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection = acpFeatureNode3[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
						int value = dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value;
						int value2 = dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value;
						text4 = (string)dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Converter.Convert(value, null, null, cultureInfo);
						text3 = (string)dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Converter.Convert(value2, null, null, cultureInfo);
						string cho3DataButtonConvIndex_A41419_UIValue = dataButtonInnerSection.CHO3DataButtonConvIndex_A41419_UIValue;
						cho3DataButtonTrkIndex_A41420_UIValue = dataButtonInnerSection.CHO3DataButtonTrkIndex_A41420_UIValue;
						num = (short)1943863325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.HiddenStatic)
						{
							num = (short)781844501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21F;
					}
					case 57:
						goto IL_78D;
					case 58:
						goto IL_1482;
					case 59:
						goto IL_2B3A;
					case 60:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1088749608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1482;
					case 61:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num4++;
						recSet.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\udf90튒쎔\ude96\ude98\uda9a즜횞ﾪﾬﶰ", a_), cultureInfo);
						recSet.RecNo = num4.ToString();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o3NavigationControlsTableInnerRecset.GetEnumerator();
						num = (short)178782211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						goto IL_29A7;
					case 63:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenStatic)
						{
							num = (short)1077674000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1482;
					}
					case 64:
						try
						{
							num = (short)411107371;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text8;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								switch (num2)
								{
								case 0:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얊ꪒ쪔\ude96ﶘ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)539557922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)953810950;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캊戀궔좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1997799437;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)178126848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1087111186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_25A4;
								case 4:
									goto IL_25A4;
								case 5:
									goto IL_25A4;
								case 6:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a歷첒\udc94", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)154664985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2104098848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_2295;
								case 8:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a年ﶒꊔ좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1725104148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)679084033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8a戴ꎐ첒\udc94", a_), cultureInfo);
									num = (short)1012596762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_25A4;
								case 11:
									goto IL_2115;
								case 12:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쮐횒잔\ud896ꦘ", a_), cultureInfo);
									num = (short)245301283;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캊戀궔좖킘ﾚ", a_), cultureInfo);
									num = (short)2088894504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									string text9 = text9 + this.a + radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)2023817223;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									num = (short)1050017836;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aꞐ첒\udc94", a_), cultureInfo);
									num = (short)1940717572;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
								{
									string text9;
									this.a(ref uifields, text9);
									num = (short)1004797991;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									goto IL_2935;
								case 19:
									goto IL_25A4;
								case 20:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a年ﶒꊔ좖킘ﾚ", a_), cultureInfo);
									num = (short)1672216598;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊搜Ꞓ쪔\ude96ﶘ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)287571992;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)965279803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									goto IL_25A4;
								case 23:
									goto IL_25A4;
								case 24:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊搜Ꞓ쪔\ude96ﶘ", a_), cultureInfo);
									num = (short)1678639107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88a歷첒\udc94", a_), cultureInfo);
									num = (short)1161953303;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									goto IL_25A4;
								case 27:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒊ꂐ첒\udc94", a_), cultureInfo);
									num = (short)1830486035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒊ꂐ첒\udc94", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1189019675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1059389485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)1546715166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1EDE;
								}
								case 30:
								{
									string text9;
									this.a(ref uifields, text9);
									num = (short)1652424756;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 31:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1748172802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode4 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection = acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection;
									int radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value = (acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value;
									string text9 = (string)(acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Converter.Convert(radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value, null, null, cultureInfo);
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue = (acpFeatureNode4[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)1289289778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 32:
								{
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8a搜ﾐ\udd94슜횞얠", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)986447920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num5;
									num5++;
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎\uda90횒첔잖\ud898\udf9a\udf9c쪞", a_), cultureInfo) + num5.ToString();
									num = (short)164102149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 33:
									goto IL_25A4;
								case 34:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얊ꪒ쪔\ude96ﶘ", a_), cultureInfo);
									num = (short)1228668982;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
									goto IL_25A4;
								case 36:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8aﶎꚔ좖킘ﾚ", a_), cultureInfo);
									num = (short)846594081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
									goto IL_22F5;
								case 38:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8aﶎꚔ좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1558315044;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2117599253;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									goto IL_2115;
								case 40:
									goto IL_25A4;
								case 41:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1977745425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2115;
								case 42:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)1650851887;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2115;
								}
								case 43:
									switch (0)
									{
									case 0:
										goto IL_1D64;
									}
									continue;
								case 44:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1815085114;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)1484062773;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8a戴ꎐ첒\udc94", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1862336521;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)947978278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
								{
									string text9;
									this.a(ref uifields, text9);
									num = (short)1690697739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 48:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8a搜ﾐ\udd94슜횞얠", a_), cultureInfo);
									num = (short)588447801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 49:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aꞐ첒\udc94", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1968242704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1197015048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
								{
									string text9;
									if (text9 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쎐횒\ud994횖삘쮚\udc9c쮞", a_), cultureInfo))
									{
										num = (short)1236926478;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2295;
								}
								case 51:
									if (isRightToLeft)
									{
										num = (short)436928527;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1673068573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 52:
									goto IL_1EDE;
								case 53:
									goto IL_22F5;
								case 54:
									goto IL_25A4;
								case 55:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊年Ꚓ쪔\ude96ﶘ", a_), cultureInfo);
									num = (short)536739850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 56:
									if (text8 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎쮐횒잔\ud896ꦘ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)426573836;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)982908956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 57:
									goto IL_25A4;
								case 58:
								{
									string text9;
									this.a(ref uifields, text9);
									num = (short)895680549;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 59:
									if (text8 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춊年Ꚓ쪔\ude96ﶘ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1224212535;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1894907953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D64;
								IL_1EDE:
								num = (short)335282217;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2115:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode4).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069.UIName.ToString();
								text8 = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode4).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069_UIValue.ToString();
								num = (short)558104632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2214:
								num = (short)175505439;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D64:
								goto IL_2214;
								IL_2295:
								num = (short)990445619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_22F5:
								num = (short)1913520170;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_25A4:
								recSet.UIFields.Add(uifields);
								num = (short)1451032622;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2935:
							goto IL_2BD0;
						}
						finally
						{
							num = (short)1245970433;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_29A4;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_296C;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)970784768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_296C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1256587266;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_29A4:;
						}
						goto IL_29A7;
						IL_2BD0:
						table.RecSet.Add(recSet);
						num = (short)992215052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_1621;
					case 66:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.HiddenStatic)
						{
							num = (short)133169169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)32440374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						num = (short)209453092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
					IL_21F:
					num = (short)2061697087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_78D:
					num = (short)1365508104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13CE:
					this.a(ref uifields, text4);
					num = (short)925827106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_143B:
					num = (short)1365508127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1482:
					uifields.UIFieldName = (acpFeatureNode3[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3DataButtonName_A22591.UIName.ToString();
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊즌킎햐튒솔횖\udb98캚즜쮞瘝隦", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)183500826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1621:
					num = (short)71630866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165E:
					num = (short)1695219725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16FF:
					num = (short)460062765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17C8:
					num = (short)1988689942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1830:
					num = (short)1680539689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A49:
					keypadRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset);
					num = (short)2029060102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29A7:
					text3 = text3 + this.a + cho3DataButtonTrkIndex_A41420_UIValue;
					num = (short)1728380979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A43:
					table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즊ﮎﲒﮔ욘漢ﮞﺠ쪤즦\udda8\ud9aa슬쎮슰", a_), cultureInfo);
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슊쪔\ude96ﶘ", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾊ﲎﲔﺠ솤", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좊ﮔﺞ춠ﲢ쎦", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8aﾌ搜ﾐﲔ練ﺘ쒚풜\udb9e", a_), cultureInfo));
					recSet = null;
					uifields = null;
					num4 = 0;
					num = (short)1537278001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B3A:
					num = (short)1226178583;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2BF5:
				IL_2CCE:
				RptXMLData.tables.Add(table);
				return;
				IL_149:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
				cultureInfo = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				o3HHCHButtonInnerRecset = null;
				dataButtonInnerRecset = null;
				controlHeadO3Recset = null;
				keypadRecset = null;
				o3NavigationControlsTableInnerRecset = null;
				keypadButtonInnerRecset = null;
				trunkingSystem = null;
				trunkingSystem = (global::AcpCommonLib.FeatureManager.GetFeature(2064)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = global::AcpCommonLib.FeatureManager.GetFeature(2127)[0];
				controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
				num = (short)1835794432;
				short num6 = num;
				num = (short)802619444;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00257A6C File Offset: 0x00255C6C
		public void AddButtonsAndControlO7(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType)
		{
			int a_ = 13;
			short num = (short)369557504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_200;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::System.Globalization.CultureInfo cultureInfo;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
				bool isRightToLeft;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset keypadRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset o7NavigationControlsTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset o7InnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset kmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
				for (;;)
				{
					IL_31:
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection o7MFKAssignmentControlInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection o7MFKAssignmentControlInnerSection2;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7 controlHeadO;
					string a_2;
					string text6;
					string a_3;
					string a_4;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
					string cho7DataButtonTrkIndex_A41418_UIValue;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenStatic)
						{
							num = (short)1713832012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C6;
					}
					case 1:
					{
						string cho7DataButtonConvIndex_A41417_UIValue;
						string text = text + this.a + cho7DataButtonConvIndex_A41417_UIValue;
						num = (short)1625161812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_30D;
					case 3:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)329777168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)1245970523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_38E5;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenStatic)
						{
							num = (short)218365974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)401014784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_25A9;
					case 7:
						o7MFKAssignmentControlInnerSection = (o7MFKAssignmentControlInnerRecset[0][10724] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection);
						o7MFKAssignmentControlInnerSection2 = (o7MFKAssignmentControlInnerRecset[1][10724] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection);
						num = (short)891289709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8f聯ﺙ쎛\udc9d햟횡킣즥욧\ud9a9", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						int num4 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = keypadButtonInnerRecset.GetEnumerator();
						num = (short)1628176399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (controlHeadO != null)
						{
							num = (short)420544538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15BC;
					case 10:
						goto IL_2C6;
					case 11:
						goto IL_2C6;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.HiddenStatic)
						{
							num = (short)1802043424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1959;
					}
					case 13:
						num = (short)740950035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)221118469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						try
						{
							num = (short)390660150;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text2;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								switch (num2)
								{
								case 0:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏잗펙", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1956053043;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)635895816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏ﮑꂕ잗펙", a_), cultureInfo);
									num = (short)1837957126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_F12;
								case 4:
								{
									string text3;
									if (text3 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓쒕\udd97횙\udd9b잝", a_), cultureInfo))
									{
										num = (short)251789370;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11D5;
								}
								case 5:
									goto IL_FBD;
								case 6:
									goto IL_FBD;
								case 7:
									goto IL_FBD;
								case 8:
								{
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏﶑ﲗ튙ﶛ좟ﶡ슥", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1961885720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num4;
									num4++;
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓\udd95\udd97쎙첛\udf9dﲧ", a_), cultureInfo) + num4.ToString();
									num = (short)1717436421;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓첕\udd97좙펛꺝", a_), cultureInfo);
									num = (short)434896951;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_FBD;
								case 11:
									goto IL_FBD;
								case 12:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏ﮓ꒕잗펙", a_), cultureInfo);
									num = (short)170524703;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햏ﮑﺕꊙ쎛힝쒟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)940245049;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1263403057;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓첕\udd97좙펛꺝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)728956937;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2091188270;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									string text3;
									this.a(ref uifields, text3);
									num = (short)560594983;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1009254419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)1750532098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8fﲑꞕ잗펙", a_), cultureInfo);
									num = (short)1918500923;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_FBD;
								case 19:
								{
									string text3;
									this.a(ref uifields, text3);
									num = (short)499515418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
									if (isRightToLeft)
									{
										num = (short)225968184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1103298597;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									goto IL_11D5;
								case 22:
								{
									string text3;
									this.a(ref uifields, text3);
									num = (short)614006812;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
									goto IL_FBD;
								case 24:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏﶑ﲗ튙ﶛ좟ﶡ슥", a_), cultureInfo);
									num = (short)1934098467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횏﶑겗얙햛瞧", a_), cultureInfo);
									num = (short)603914258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									goto IL_F12;
								case 27:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏궙쎛힝쒟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1734869025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)696320013;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									goto IL_9C2;
								case 29:
									goto IL_FBD;
								case 30:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏晴ﶗꦙ쎛힝쒟", a_), cultureInfo);
									num = (short)561709066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									goto IL_FBD;
								case 32:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1496580111;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7B6;
								case 33:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏궙쎛힝쒟", a_), cultureInfo);
									num = (short)1733885981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									goto IL_1384;
								case 35:
									goto IL_FBD;
								case 36:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8fﮑ望ꆗ얙햛瞧", a_), cultureInfo);
									num = (short)1855586344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)725155862;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9C2;
								}
								case 38:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏ﮑꂕ잗펙", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)272433153;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)966590491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									goto IL_7B6;
								case 40:
									goto IL_FBD;
								case 41:
									num = (short)1228341282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횏﶑겗얙햛瞧", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1212416025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1704525868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏ﮓ꒕잗펙", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)44236812;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1203634228;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횏ﮑ궗얙햛瞧", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1458241589;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)236781606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)1942945840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7B6;
								}
								case 46:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8fﲑꞕ잗펙", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1797783569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)345833515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)724238377;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection = acpFeatureNode[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection;
									int radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value = (acpFeatureNode[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value;
									string text3 = (string)(acpFeatureNode[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Converter.Convert(radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value, null, null, cultureInfo);
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue = (acpFeatureNode[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)880803844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 48:
								{
									string text3;
									this.a(ref uifields, text3);
									num = (short)912261170;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 49:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8fﮑ望ꆗ얙햛瞧", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1969225764;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1124990976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
									goto IL_7B6;
								case 51:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏잗펙", a_), cultureInfo);
									num = (short)354418699;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 52:
									if (text2 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏晴ﶗꦙ쎛힝쒟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)842989598;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2017853482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횏ﮑ궗얙햛瞧", a_), cultureInfo);
									num = (short)211288071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 54:
									switch (0)
									{
									case 0:
										goto IL_7B1;
									}
									continue;
								case 55:
									goto IL_FBD;
								case 56:
									num = (short)1048592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 57:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햏ﮑﺕꊙ쎛힝쒟", a_), cultureInfo);
									num = (short)983236631;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 58:
								{
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									string text3 = text3 + this.a + radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)1421344789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 59:
									goto IL_FBD;
								}
								goto IL_7B1;
								IL_7B6:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069.UIName.ToString();
								text2 = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069_UIValue.ToString();
								num = (short)325058574;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9C2:
								num = (short)1596063776;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F12:
								num = (short)1512505389;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FBD:
								recSet.UIFields.Add(uifields);
								num = (short)1518600195;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1155:
								num = (short)1748631599;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7B1:
								goto IL_1155;
								IL_11D5:
								num = (short)110624788;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1384:
							goto IL_3B6F;
						}
						finally
						{
							num = (short)504102912;
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
										goto IL_13BB;
									}
									continue;
								case 1:
									goto IL_1446;
								case 2:
									enumerator.Dispose();
									goto IL_142D;
								}
								IL_13BB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)88396630;
								short num5 = num;
								num = (short)2130432854;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1481900032;
									if (num != 0)
									{
									}
									num = (short)624033794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_142D:
								num = (short)1577975809;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1446:;
						}
						goto IL_1449;
						IL_3B6F:
						table.RecSet.Add(recSet);
						num = (short)91160687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						this.a(ref uifields, a_2);
						num = (short)459276333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_1959;
					case 18:
						goto IL_3348;
					case 19:
						if (isRightToLeft)
						{
							num = (short)201392142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_250B;
					case 20:
						try
						{
							num = (short)1673920516;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection o7NavigationControlsTableInnerSection;
								string text4;
								string text5;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)952172556;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									o7NavigationControlsTableInnerSection = (acpFeatureNode2[10728] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection);
									int radErgoControlO7UpDownButton_A41293Value = o7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293Value;
									text4 = (string)o7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293.Converter.Convert(radErgoControlO7UpDownButton_A41293Value, null, null, cultureInfo);
									num = (short)1520893965;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_343F;
								case 2:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)305266708;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)769523720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓쎕좗\ud899즛쪝", a_), cultureInfo);
									num = (short)1233518597;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_343A;
									}
									continue;
								case 5:
									goto IL_343F;
								case 6:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)380174347;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_346B;
								case 7:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풏﶑잗\ud899풟춡쪣", a_), cultureInfo);
									num = (short)1532690433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_34F1;
								case 9:
									goto IL_346B;
								case 10:
									goto IL_346B;
								case 11:
									this.a(ref uifields, text4.ToString());
									num = (short)115343370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)257884179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (isRightToLeft)
									{
										num = (short)771424273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, text4.ToString());
									num = (short)2006253574;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_34F1;
								case 16:
									if (text5 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풏﶑잗\ud899풟춡쪣", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)496566279;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_343F;
								case 17:
									num = (short)671219714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									if (text5 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓쎕좗\ud899즛쪝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1807810563;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)780337168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									goto IL_37F8;
								case 20:
									this.a(ref uifields, text4.ToString());
									num = (short)1728708622;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_343A;
								IL_343F:
								recSet.UIFields.Add(uifields);
								num = (short)1044512783;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_346B:
								uifields.UIFieldName = o7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293.UIName.ToString();
								text5 = o7NavigationControlsTableInnerSection.O7UpDownButtonName_A41292_UIValue.ToString();
								num = (short)809173010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_34F1:
								this.a(ref uifields, text4.ToString());
								num = (short)683212809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3688:
								num = (short)774832128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_343A:
								goto IL_3688;
							}
							IL_37F8:
							goto IL_1E41;
						}
						finally
						{
							num = (short)992477186;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_386A;
								case 1:
									enumerator.Dispose();
									num = (short)1482620928;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3831;
									}
									continue;
								}
								IL_3831:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1338966017;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_386A:;
						}
						goto IL_386D;
						IL_1E41:
						table.RecSet.Add(recSet);
						num = (short)1910571010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_1C5C;
					case 22:
						this.a(ref uifields, text6);
						num = (short)713883659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)65011713;
						if (num != 0)
						{
						}
						if (!isRightToLeft)
						{
							num = (short)1748893761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)892928071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_1C0D;
					case 25:
						if (isRightToLeft)
						{
							num = (short)393609285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, a_2);
						num = (short)1022296102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)560529454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)2118844483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38E5;
					case 28:
					{
						string text;
						this.a(ref uifields, text);
						num = (short)29360234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						this.a(ref uifields, a_3);
						num = (short)1029505114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (!keypadRecset.HiddenStatic)
						{
							num = (short)96731144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B96;
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenStatic)
						{
							num = (short)1407451240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D16;
					}
					case 32:
					{
						string text;
						this.a(ref uifields, text);
						num = (short)252379153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						num = (short)790954007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)2002321471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_1C5C;
					case 36:
						if (text6 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓힕\udb97캙햛톝ﮧﾵ", a_), cultureInfo))
						{
							num = (short)569966632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0D;
					case 37:
						num = (short)406061141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1651114046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F2;
					case 39:
					{
						string text;
						this.a(ref uifields, text);
						num = (short)183107657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_30C8;
					case 41:
						o7MFKAssignmentControlInnerRecset = (controlHeadO[10718].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset);
						num = (short)1396637762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)1343094880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenStatic)
						{
							num = (short)1237450796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15FB;
					}
					case 44:
						goto IL_386D;
					case 45:
						goto IL_1D95;
					case 46:
						if (!controlHeadO.O7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218.HiddenStatic)
						{
							num = (short)2015559752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15BC;
					case 47:
						if (keypadButtonInnerRecset != null)
						{
							num = (short)551485508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B96;
					case 48:
					{
						string text;
						if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓힕\udb97캙햛톝ﮧﾵ", a_), cultureInfo))
						{
							num = (short)1539768321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DBE;
					}
					case 49:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓\ud895\ud997척햛\ud99d﮳蝹", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7NavigationControlsTableInnerRecset.GetEnumerator();
						num = (short)1063059476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)955449443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AA9;
					case 51:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1300955169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D16;
					case 52:
						goto IL_39E3;
					case 53:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenStatic)
						{
							num = (short)1310982230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D16;
					}
					case 54:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7InnerRecset.GetEnumerator();
						num = (short)762642490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						if (controlHeadO != null)
						{
							num = (short)2137587753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AE5;
					case 56:
						goto IL_15BC;
					case 57:
						goto IL_1D16;
					case 58:
						try
						{
							num = (short)1889140761;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text7;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								switch (num2)
								{
								case 0:
									goto IL_249A;
								case 1:
									num = (short)87031819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_214B;
								case 3:
									this.a(ref uifields, "");
									num = (short)258736152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									this.a(ref uifields, text7.ToString());
									num = (short)1610678300;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1F56;
								case 6:
									this.a(ref uifields, "");
									num = (short)1290403845;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_1F56;
								case 8:
									if (trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)300941318;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F56;
								case 9:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1599012868;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_214B;
								case 10:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)324993055;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)532348936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1225392158;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)997195794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (!isRightToLeft)
									{
										num = (short)805371919;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)376897546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									this.a(ref uifields, text7.ToString());
									num = (short)373293075;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									this.a(ref uifields, text7.ToString());
									num = (short)656343072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_2084;
								case 17:
									if (isRightToLeft)
									{
										num = (short)927072257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, text7.ToString());
									num = (short)996212745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									if (trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)60424195;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2084;
								case 19:
									goto IL_214B;
								case 20:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)1247543322;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_214B;
								case 21:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)214433815;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode3 = enumerator.Current;
									recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									num3++;
									recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num3.ToString();
									recSet.RecNo = num3.ToString();
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection o7InnerSection = acpFeatureNode3[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection;
									int cho7EmergencyButtonFeature_A41291Value = o7InnerSection.CHO7EmergencyButtonFeature_A41291Value;
									text7 = (string)o7InnerSection.CHO7EmergencyButtonFeature_A41291.Converter.Convert(cho7EmergencyButtonFeature_A41291Value, null, null, cultureInfo);
									num = (short)708968470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)899285019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1066467348;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									num = (short)1365377024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									goto IL_2084;
								case 25:
									switch (0)
									{
									case 0:
										goto IL_1F16;
									}
									continue;
								case 26:
									num = (short)113049613;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									num = (short)1476001809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									goto IL_214B;
								case 29:
									goto IL_214B;
								case 30:
									this.a(ref uifields, text7.ToString());
									num = (short)314114064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									this.a(ref uifields, text7.ToString());
									num = (short)1825177607;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)637927438;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_214B;
								}
								goto IL_1F16;
								IL_1F56:
								this.a(ref uifields, text7.ToString());
								num = (short)1684930589;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2041:
								num = (short)542638101;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F16:
								goto IL_2041;
								IL_2084:
								this.a(ref uifields, text7.ToString());
								num = (short)1636171778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_214B:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7Inner)acpFeatureNode3).O7InnerSection.CHO7EmergencyButtonName_A41289Value.ToString();
								uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓\ud995쪗\udb99튛\ud99dﲧ", a_), cultureInfo);
								recSet.UIFields.Add(uifields);
								table.RecSet.Add(recSet);
								num = (short)1942421516;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_249A:
							goto IL_3E1;
						}
						finally
						{
							num = (short)859373568;
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
										goto IL_24D1;
									}
									continue;
								case 1:
									goto IL_2508;
								case 2:
									enumerator.Dispose();
									num = (short)1587412993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_24D1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1064239106;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2508:;
						}
						goto IL_250B;
					case 59:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = kmbuttonInnerRecset.GetEnumerator();
						num = (short)443351122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						if (keypadRecset != null)
						{
							num = (short)1037172800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39E3;
					case 61:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1498087437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)933494835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						this.a(ref uifields, a_2);
						num = (short)982122593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)1353252934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)56164387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						keypadButtonInnerRecset = (keypadRecset[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
						num = (short)1652359220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						num = (short)253362251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (o7MFKAssignmentControlInnerRecset != null)
						{
							num = (short)1391788039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AE5;
					case 67:
						this.a(ref uifields, a_4);
						num = (short)1000865796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)1096876062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						num = (short)1421344771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						this.a(ref uifields, a_4);
						num = (short)997261333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.HiddenStatic)
						{
							num = (short)1596522573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2100887595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 72:
					{
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						int value = controlHeadO.O7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218.Value;
						a_2 = (string)controlHeadO.O7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218.Converter.Convert(value, null, null, cultureInfo);
						num = (short)1831075865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						goto IL_39A;
					case 74:
						if (o7NavigationControlsTableInnerRecset != null)
						{
							num = (short)76283904;
							short num6 = num;
							num = (short)215023665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30D;
					case 75:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.HiddenStatic)
						{
							num = (short)49348647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A;
					}
					case 76:
						this.a(ref uifields, "");
						num = (short)937754634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						this.a(ref uifields, text6);
						num = (short)244908110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						goto IL_15FB;
					case 79:
						goto IL_1D16;
					case 80:
						this.a(ref uifields, a_3);
						num = (short)1861353478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (controlHeadO7Recset != null)
						{
							num = (short)1906507871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5C;
					case 82:
						try
						{
							num = (short)1870266397;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text9;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								switch (num2)
								{
								case 0:
									num = (short)734330906;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									this.a(ref uifields, "");
									num = (short)995426317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2C2C;
								case 4:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)276955147;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)2024013825;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2770;
								}
								case 6:
									goto IL_2CF9;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)2074673196;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CF9;
								}
								case 8:
									goto IL_2CF9;
								case 9:
									goto IL_2CF9;
								case 10:
									if (text9 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓얕톗\ude99\ud99b펝嶺節ﶱ荒", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1180500002;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1426128921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_2EFF;
								case 12:
									goto IL_2BE6;
								case 13:
									goto IL_2770;
								case 14:
									if (!isRightToLeft)
									{
										num = (short)1188560929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)968294449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)1671823396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CF9;
								case 16:
								{
									string text10;
									this.a(ref uifields, text10.ToString());
									num = (short)1368588308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									string text10;
									this.a(ref uifields, text10.ToString());
									num = (short)1057882124;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)607649801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)814743582;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
									goto IL_2CF9;
								case 21:
								{
									string text10;
									this.a(ref uifields, text10.ToString());
									num = (short)1475018754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)1764098066;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CF9;
								}
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)1039204369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2BE6;
								}
								case 24:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓얕톗\ude99\ud99b쪝ﲧﺩ", a_), cultureInfo);
									num = (short)789315624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									if (text9 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓얕톗\ude99\ud99b\udc9d嶺節ﶱ荒", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1471152171;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓\ud995궗\ud899즛쪝", a_), cultureInfo);
									num = (short)193265710;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									goto IL_3055;
								case 27:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)131923987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1236271109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 28:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)1856176163;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CF9;
								}
								case 29:
									switch (0)
									{
									case 0:
										goto IL_2731;
									}
									continue;
								case 30:
									goto IL_2770;
								case 31:
									this.a(ref uifields, "");
									num = (short)775946288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)378863632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CF9;
								}
								case 33:
									num = (short)465895447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓얕톗\ude99\ud99b펝嶺節ﶱ荒", a_), cultureInfo);
									num = (short)394526771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
								{
									string text10;
									this.a(ref uifields, text10.ToString());
									num = (short)495714312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 36:
									num = (short)1252196366;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
									if (text9 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓얕톗\ude99\ud99b쪝ﲧﺩ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2053111832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)310312970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
									goto IL_2A56;
								case 39:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1795686400;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode4 = enumerator.Current;
									recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									num3++;
									recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num3.ToString();
									recSet.RecNo = num3.ToString();
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection = acpFeatureNode4[10239] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection;
									int radErgoCfgKMConventionalKMButtonFeature_A19646Value = kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646Value;
									int radErgoCfgKMTrunkingKMButtonFeature_A19746Value = kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746Value;
									string text10 = (string)kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Converter.Convert(radErgoCfgKMConventionalKMButtonFeature_A19646Value, null, null, cultureInfo);
									string text8 = (string)kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Converter.Convert(radErgoCfgKMTrunkingKMButtonFeature_A19746Value, null, null, cultureInfo);
									num = (short)1568538665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 40:
									goto IL_2A56;
								case 41:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)1490354218;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)395902991;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									num = (short)1292173364;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓얕톗\ude99\ud99b\udc9d嶺節ﶱ荒", a_), cultureInfo);
									num = (short)1473380390;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)806944774;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 45:
									num = (short)165675035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									goto IL_2A56;
								case 47:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)1337458709;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2C2C;
								}
								case 48:
									goto IL_2EFF;
								case 49:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)2116943876;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1609236530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 50:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)140050463;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2EFF;
								}
								case 51:
									goto IL_2A56;
								case 52:
									if (isRightToLeft)
									{
										num = (short)1335754797;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1136721967;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2731;
								IL_2770:
								num = (short)986644512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A56:
								recSet.UIFields.Add(uifields);
								table.RecSet.Add(recSet);
								num = (short)1634467843;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2BE6:
								num = (short)448987143;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2C2C:
								num = (short)1585512470;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2CF9:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode4).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561.UIName.ToString();
								text9 = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode4).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561_UIValue.ToString();
								num = (short)446103589;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2E90:
								num = (short)757989415;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2731:
								goto IL_2E90;
								IL_2EFF:
								num = (short)324206620;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3055:
							goto IL_315B;
						}
						finally
						{
							num = (short)2120876033;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_30C5;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_308D;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)642252800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_308D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)729743362;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_30C5:;
						}
						goto IL_30C8;
					case 83:
						goto IL_1A5C;
					case 84:
						goto IL_1DBE;
					case 85:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)327614493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)841220206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						this.a(ref uifields, text6);
						num = (short)2103967851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						goto IL_38E5;
					case 88:
						if (!trunkingSystem.Parent.HiddenStatic)
						{
							num = (short)325386320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25A9;
					case 89:
						goto IL_25A9;
					case 90:
						goto IL_1E18;
					case 91:
						goto IL_1D95;
					case 92:
						if (isRightToLeft)
						{
							num = (short)2047410210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, a_4);
						num = (short)1869348891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						if (kmbuttonInnerRecset != null)
						{
							num = (short)465829947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_315B;
					case 94:
					{
						string text;
						this.a(ref uifields, text);
						num = (short)417857593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 95:
						o7InnerRecset = (controlHeadO7Recset[0][10719].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset);
						o7NavigationControlsTableInnerRecset = (controlHeadO7Recset[0][10727].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset);
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)188940371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						if (o7InnerRecset != null)
						{
							num = (short)556269622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E1;
					case 97:
						goto IL_5F2;
					case 98:
						if (isRightToLeft)
						{
							num = (short)324599845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1449;
					case 99:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num3.ToString();
						recSet.RecNo = num3.ToString();
						acpFeatureNode5 = o7DataButtonInnerRecset[0];
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = acpFeatureNode5[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						int value2 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value;
						int value3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value;
						string text = (string)o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Converter.Convert(value2, null, null, cultureInfo);
						text6 = (string)o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Converter.Convert(value3, null, null, cultureInfo);
						string cho7DataButtonConvIndex_A41417_UIValue = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417_UIValue;
						cho7DataButtonTrkIndex_A41418_UIValue = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418_UIValue;
						num = (short)534249520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 100:
						goto IL_5F2;
					case 101:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)82575402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B96;
					case 102:
						kmbuttonInnerRecset = (keypadMicAndAccessoriesRecset[0][10231].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset);
						num = (short)753270802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.HiddenStatic)
						{
							num = (short)1693057118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D16;
					}
					case 104:
						this.a(ref uifields, text6);
						num = (short)646971471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection;
						if (!o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.HiddenStatic)
						{
							num = (short)1124466716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D16;
					}
					case 106:
						goto IL_1D16;
					case 107:
						goto IL_1D16;
					case 108:
						goto IL_15FB;
					case 109:
						goto IL_1AE5;
					case 110:
						goto IL_1E18;
					case 111:
						goto IL_3B94;
					case 112:
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)921108582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3348;
					case 113:
						goto IL_1AA9;
					}
					goto IL_200;
					IL_2C6:
					num = (short)914686057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30D:
					num = (short)803143730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39A:
					num = (short)546111541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E1:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					num3++;
					recSet.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓\udb95춗횙좛힝ﲧﮯﲱ﮳", a_), cultureInfo);
					recSet.RecNo = num3.ToString();
					o7MFKAssignmentControlInnerRecset = null;
					o7MFKAssignmentControlInnerSection = null;
					o7MFKAssignmentControlInnerSection2 = null;
					controlHeadO = null;
					controlHeadO = (global::AcpCommonLib.FeatureManager.GetFeature(4114)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7);
					num = (short)580386825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F2:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8f풑\udf93욕ﾙ잡첣장\udea7쎩쎫\udcad", a_);
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓\udb95\ude97톙첛첝羚ﶱ", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					num = (short)1462566968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1449:
					this.a(ref uifields, a_3);
					num = (short)215679064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15BC:
					num = (short)631898167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15FB:
					num = (short)729284711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1959:
					num = (short)1094058015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A5C:
					keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
					num = (short)1425473648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AA9:
					num = (short)1952120879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AE5:
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int value4 = o7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.Value;
					a_4 = (string)o7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.Converter.Convert(value4, null, null, cultureInfo);
					num = (short)660537436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C0D:
					num = (short)1584595005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C5C:
					this.a(ref uifields, a_4);
					num = (short)228458583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D16:
					uifields.UIFieldName = (acpFeatureNode5[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonName_A41296.UIName.ToString();
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98f횑쮓튕\ud997캙\udd9b\udc9d鶫", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)710410353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D95:
					this.a(ref uifields, a_2);
					num = (short)1734082660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DBE:
					num = (short)1766981668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E18:
					this.a(ref uifields, a_3);
					num = (short)1114767449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_250B:
					num = (short)1895104524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25A9:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏秊ﺙﶛ\ud99f톣좥쮧\udea9얫솭\udeaf", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎏秊ﺙﶛ\ud99fﶡ펥욧즩\ud8ab잭\udfaf\udcb1", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)165019741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30C8:
					text6 = text6 + this.a + cho7DataButtonTrkIndex_A41418_UIValue;
					num = (short)1912733720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_315B:
					num = (short)1212285002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3348:
					keypadRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset);
					num = (short)646119484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_386D:
					this.a(ref uifields, "");
					num = (short)205783148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38E5:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ﶓﮕ聯\ud89d햟첡잣튥솧얩슫", a_);
					uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삏ﶓﮕ聯솝힡쪣얥\udca7쎩쎫삭", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					int value5 = o7MFKAssignmentControlInnerSection2.RadErgoControlO7MFKFeatureAssignment_A41295.Value;
					a_3 = (string)o7MFKAssignmentControlInnerSection2.RadErgoControlO7MFKFeatureAssignment_A41295.Converter.Convert(value5, null, null, cultureInfo);
					num = (short)459866210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39E3:
					table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튏솝솟첡삣殮얩슫\udaad슯\uddb1\ud8b3억", a_), cultureInfo);
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98fﲑ얙햛瞧", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풏즟춡쪣殮캩", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펏﶑望ﶗ쾟첡얣쪥좫", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏劣ﾟ", a_), cultureInfo));
					recSet = null;
					uifields = null;
					num3 = 0;
					num = (short)1138491493;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3B94:
				IL_3B96:
				RptXMLData.tables.Add(table);
				return;
				IL_200:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
				cultureInfo = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				o7InnerRecset = null;
				kmbuttonInnerRecset = null;
				o7DataButtonInnerRecset = null;
				controlHeadO7Recset = null;
				o7NavigationControlsTableInnerRecset = null;
				keypadMicAndAccessoriesRecset = null;
				trunkingSystem = null;
				keypadRecset = null;
				keypadButtonInnerRecset = null;
				trunkingSystem = (global::AcpCommonLib.FeatureManager.GetFeature(2064)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = global::AcpCommonLib.FeatureManager.GetFeature(4114)[0];
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = global::AcpCommonLib.FeatureManager.GetFeature(2128)[0];
				controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
				num = (short)852885585;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0025B680 File Offset: 0x00259880
		public void AddButtonsAndControlO5(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType)
		{
			int a_ = 12;
			short num = (short)1525547008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_15F;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset o5InnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset controlHeadO5Recset;
				bool isRightToLeft;
				global::System.Globalization.CultureInfo cultureInfo;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset kmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset keypadRecset;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset o5NavigationControlsTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					int num4;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					switch (num2)
					{
					case 0:
						enumerator = o5InnerRecset.GetEnumerator();
						num = (short)738590761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						string text;
						this.a(ref uifields, text.ToString());
						num = (short)1293746184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (controlHeadO5Recset != null)
						{
							num = (short)378667039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D8F;
					case 3:
						if (isRightToLeft)
						{
							num = (short)725876774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)619774021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						string text;
						if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒풔풖춘튚튜톞ﲴ", a_), cultureInfo))
						{
							num = (short)573112392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB3;
					}
					case 5:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1171980361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 6:
						goto IL_3E7;
					case 7:
					{
						string text;
						this.a(ref uifields, text.ToString());
						num = (short)1265565732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_D10;
					case 9:
						if (dataButtonInnerRecset != null)
						{
							num = (short)501678107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C03;
					case 10:
						enumerator = kmbuttonInnerRecset.GetEnumerator();
						num = (short)996737088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_4EA;
					case 12:
						goto IL_320B;
					case 13:
						goto IL_1FD0;
					case 14:
						goto IL_1F53;
					case 15:
						if (!isRightToLeft)
						{
							num = (short)1064697901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)887423032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						string text;
						this.a(ref uifields, text.ToString());
						num = (short)1564934183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (!keypadRecset.HiddenStatic)
						{
							num = (short)880279622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_333D;
					case 18:
						goto IL_C03;
					case 19:
						if (o5InnerRecset != null)
						{
							num = (short)282787840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EF;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic)
						{
							num = (short)1253310523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30AA;
					}
					case 21:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)1362165790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)587464709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)162660396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					}
					case 23:
					{
						kmbuttonInnerRecset = (keypadMicAndAccessoriesRecset[0][10231].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset);
						dataButtonInnerRecset = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)2062483456;
						short num3 = num;
						num = (short)1106051084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)1488650257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_39F;
					case 26:
						goto IL_1CD9;
					case 27:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num4++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num4.ToString();
						recSet.RecNo = num4.ToString();
						acpFeatureNode = dataButtonInnerRecset[0];
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						int radErgoCfgKMConventionalKMDatatButtonFeature_A22603Value = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603Value;
						int radErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value;
						string text = (string)dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Converter.Convert(radErgoCfgKMConventionalKMDatatButtonFeature_A22603Value, null, null, cultureInfo);
						string text2 = (string)dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Converter.Convert(radErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value, null, null, cultureInfo);
						string radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						string radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
						num = (short)1486094340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						try
						{
							num = (short)871563300;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text4;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								switch (num2)
								{
								case 0:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒쾔튖쮘풚궜", a_), cultureInfo);
									num = (short)546439182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									string text3;
									this.a(ref uifields, text3);
									num = (short)1612709921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_23D8;
								case 3:
								{
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8eﺐﮔ톘漢ﺠ솤", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1205927960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num5;
									num5++;
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒\ude94튖삘쮚\udc9c\udb9e", a_), cultureInfo) + num5.ToString();
									num = (short)1713504262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_23D8;
								case 5:
								{
									string text3;
									this.a(ref uifields, text3);
									num = (short)855441464;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_23D8;
								case 7:
								{
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									string text3 = text3 + this.a + radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)900530210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)104267829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D82;
								}
								case 9:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪎ﶔꆘ쒚풜ﮞ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1429274651;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)941096992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_23D8;
								case 11:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎ﺐꎖ욘튚列", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)267976732;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1361379365;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8e戀ꪘ쒚풜ﮞ", a_), cultureInfo);
									num = (short)1058275338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e練꺘쒚풜ﮞ", a_), cultureInfo);
									num = (short)705560618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_23D8;
								case 15:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)967507973;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)655687698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삎ﾐ꒔좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1485897783;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)443023395;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솎ﶒ꺖욘튚列", a_), cultureInfo);
									num = (short)2119303172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_26CE;
								case 19:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e좖킘ﾚ", a_), cultureInfo);
									num = (short)1087045678;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									goto IL_2D82;
								case 21:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2035941395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)602406915;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1305608215;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode2 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection = acpFeatureNode2[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection;
									int radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value = (acpFeatureNode2[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value;
									string text3 = (string)(acpFeatureNode2[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Converter.Convert(radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value, null, null, cultureInfo);
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue = (acpFeatureNode2[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)1519779890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
									num = (short)70516775;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8eﺐﮔ톘漢ﺠ솤", a_), cultureInfo);
									num = (short)1708589058;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									goto IL_23D8;
								case 26:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)147521537;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D82;
								case 27:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪎ﶔꆘ쒚풜ﮞ", a_), cultureInfo);
									num = (short)287375418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎ﺐꎖ욘튚列", a_), cultureInfo);
									num = (short)1716125727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									goto IL_23D8;
								case 30:
									goto IL_23D8;
								case 31:
									goto IL_23D8;
								case 32:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솎ﶒ꺖욘튚列", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1911357457;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)859176981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									goto IL_2D82;
								case 34:
									goto IL_2929;
								case 35:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8eﲒꞔ좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2020671533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1742209081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									switch (0)
									{
									case 0:
										goto IL_2264;
									}
									continue;
								case 37:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎ꊖ욘튚列", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)481820715;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)772669499;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eꎔ좖킘ﾚ", a_), cultureInfo);
									num = (short)1830027289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									goto IL_2E39;
								case 40:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e練꺘쒚풜ﮞ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1641414669;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)914882569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 41:
									num = (short)2032795663;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									goto IL_23D8;
								case 43:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즎ꊖ욘튚列", a_), cultureInfo);
									num = (short)836239414;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8eﲒꞔ좖킘ﾚ", a_), cultureInfo);
									num = (short)652017694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									goto IL_23D8;
								case 47:
									if (text4 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒쾔튖쮘풚궜", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1685716992;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)997195792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
									if (isRightToLeft)
									{
										num = (short)1519190057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1089536052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 49:
								{
									string text3;
									this.a(ref uifields, text3);
									num = (short)204341299;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 50:
								{
									string text3;
									if (text3 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒잔튖햘\uda9a쒜쾞ﮨ", a_), cultureInfo))
									{
										num = (short)1431240711;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2929;
								}
								case 51:
									goto IL_2B97;
								case 52:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)2125791281;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B97;
								}
								case 53:
								{
									string text3;
									this.a(ref uifields, text3);
									num = (short)663486484;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 54:
									goto IL_23D8;
								case 55:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삎ﾐ꒔좖킘ﾚ", a_), cultureInfo);
									num = (short)1064501277;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 56:
									goto IL_26CE;
								case 57:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8e戀ꪘ쒚풜ﮞ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1214840844;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1391656971;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 58:
									goto IL_23D8;
								case 59:
									if (text4 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eꎔ좖킘ﾚ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1180500006;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)240582696;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2264;
								IL_23D8:
								recSet.UIFields.Add(uifields);
								num = (short)497877036;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_26CE:
								num = (short)1838481416;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2929:
								num = (short)1855520816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B97:
								num = (short)755433498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2BE1:
								num = (short)1073741846;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2264:
								goto IL_2BE1;
								IL_2D82:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode2).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069.UIName.ToString();
								text4 = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode2).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069_UIValue.ToString();
								num = (short)2057437231;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E39:
							goto IL_3282;
						}
						finally
						{
							num = (short)35389442;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)401932289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2EA9;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2E70;
									}
									continue;
								}
								IL_2E70:
								if (enumerator == null)
								{
									break;
								}
								num = (short)646643712;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2EA9:;
						}
						goto IL_2EAC;
						IL_3282:
						table.RecSet.Add(recSet);
						num = (short)235274269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_32A7;
					case 30:
						num = (short)985661443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						o5InnerRecset = (controlHeadO5Recset[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset);
						o5NavigationControlsTableInnerRecset = (controlHeadO5Recset[0][10735].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset);
						num = (short)1518600203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (o5NavigationControlsTableInnerRecset != null)
						{
							num = (short)416874522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EAC;
					case 33:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)1943339056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					}
					case 34:
						goto IL_30AA;
					case 35:
						goto IL_2EAC;
					case 36:
						goto IL_3E7;
					case 37:
						this.a(ref uifields, "");
						num = (short)1956708399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)961151037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_3E7;
					case 40:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)339738661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30F3;
					}
					case 41:
						try
						{
							num = (short)1789460496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text5;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								switch (num2)
								{
								case 0:
									if (!isRightToLeft)
									{
										num = (short)157089820;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)489422855;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									this.a(ref uifields, text5.ToString());
									num = (short)877658144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_6FD;
								case 3:
									goto IL_B55;
								case 4:
									goto IL_6FD;
								case 5:
									num = (short)156041219;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1609367570;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_631;
								case 7:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1689976833;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1292828689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (isRightToLeft)
									{
										num = (short)331350035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, text5.ToString());
									num = (short)807731209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1016201227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6FD;
								case 10:
									goto IL_6FD;
								case 11:
									this.a(ref uifields, text5.ToString());
									num = (short)781123594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)323747848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									this.a(ref uifields, text5.ToString());
									num = (short)775880706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									this.a(ref uifields, "");
									num = (short)1027604510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									num = (short)1214971904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									switch (0)
									{
									case 0:
										goto IL_5D6;
									}
									continue;
								case 17:
									if (trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)50855950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A51;
								case 18:
									this.a(ref uifields, "");
									num = (short)1775566869;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									num = (short)132055066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									goto IL_6FD;
								case 21:
									goto IL_631;
								case 23:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)14876687;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6FD;
								case 24:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1932460045;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6FD;
								case 25:
									this.a(ref uifields, text5.ToString());
									num = (short)699334687;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)969670681;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1162936326;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)941490188;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)143261719;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									this.a(ref uifields, text5.ToString());
									num = (short)5963800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)454098949;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode3 = enumerator.Current;
									recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									num4++;
									recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num4.ToString();
									recSet.RecNo = num4.ToString();
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection o5InnerSection = acpFeatureNode3[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection;
									int cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754Value = o5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754Value;
									text5 = (string)o5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Converter.Convert(cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754Value, null, null, cultureInfo);
									num = (short)1060044827;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
									goto IL_A51;
								case 31:
									goto IL_631;
								case 32:
									goto IL_A51;
								}
								goto IL_5D6;
								IL_631:
								this.a(ref uifields, text5.ToString());
								num = (short)564723716;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6FD:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner)acpFeatureNode3).O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.UIName.ToString();
								uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒\uda94얖\ud898햚\uda9c\uda9e", a_), cultureInfo);
								recSet.UIFields.Add(uifields);
								table.RecSet.Add(recSet);
								num = (short)227016726;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A51:
								this.a(ref uifields, text5.ToString());
								num = (short)612565012;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AC1:
								num = (short)1121845277;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5D6:
								goto IL_AC1;
							}
							IL_B55:
							goto IL_4EF;
						}
						finally
						{
							num = (short)595460096;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_B8C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)366608386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_BC4;
								}
								IL_B8C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)41353217;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_BC4:;
						}
						goto IL_BC7;
					case 42:
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)1284177943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_320B;
					case 43:
					{
						string text2;
						this.a(ref uifields, text2.ToString());
						num = (short)630390809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
					{
						string text2;
						this.a(ref uifields, text2.ToString());
						num = (short)1511849990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						num = (short)830472212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (keypadRecset != null)
						{
							num = (short)71892993;
							if (num != 0)
							{
							}
							num = (short)708575298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD0;
					case 47:
						goto IL_30F3;
					case 48:
					{
						string text2;
						this.a(ref uifields, text2.ToString());
						num = (short)707788858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
					{
						string radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
						string text2 = text2 + this.a + radErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue;
						num = (short)920387598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)963182645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39F;
					}
					case 51:
						num = (short)1803026451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic)
						{
							num = (short)2025521168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					}
					case 53:
						this.a(ref uifields, "");
						num = (short)383123527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
					{
						string text2;
						if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒풔풖춘튚튜톞ﲴ", a_), cultureInfo))
						{
							num = (short)2034106417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F53;
					}
					case 55:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)647233587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_333D;
					case 56:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)521142339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17EC;
					}
					case 57:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic)
						{
							num = (short)1444806663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					}
					case 58:
						goto IL_3E7;
					case 59:
					{
						string text;
						this.a(ref uifields, text.ToString());
						num = (short)1936785442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						try
						{
							num = (short)1477378067;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text6;
								string text7;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection o5NavigationControlsTableInnerSection;
								switch (num2)
								{
								case 0:
									if (isRightToLeft)
									{
										num = (short)93716494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, text6.ToString());
									num = (short)1316028428;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (text7 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒삔잖\udb98캚즜쮞", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2003828756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1973747719;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)956301317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1083834370;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									o5NavigationControlsTableInnerSection = (acpFeatureNode4[10736] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection);
									int radErgoControlO5NaviControlFeature_A41379Value = o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlFeature_A41379Value;
									text6 = (string)o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlFeature_A41379.Converter.Convert(radErgoControlO5NaviControlFeature_A41379Value, null, null, cultureInfo);
									num = (short)643891200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮎ﺐﮔ좖\udb98캠춢", a_), cultureInfo);
									num = (short)252444690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1C66;
								case 6:
									goto IL_19F4;
								case 7:
									if (text7 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮎ﺐﮔ좖\udb98캠춢", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)583860228;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1BE7;
								case 8:
									goto IL_1BE7;
								case 9:
									goto IL_19F4;
								case 10:
									this.a(ref uifields, text6.ToString());
									num = (short)1377959945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_1A8B;
								case 12:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1681588241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A8B;
								case 14:
									num = (short)111214607;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)113770506;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)1226964998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_1A8B;
								case 17:
									this.a(ref uifields, text6.ToString());
									num = (short)1443233803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_1BE7;
								case 19:
									switch (0)
									{
									case 0:
										goto IL_18AE;
									}
									continue;
								case 20:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒삔잖\udb98캚즜쮞", a_), cultureInfo);
									num = (short)1300430856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18AE;
								IL_19F4:
								this.a(ref uifields, text6.ToString());
								num = (short)1519321104;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A47:
								num = (short)870449155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18AE:
								goto IL_1A47;
								IL_1A8B:
								uifields.UIFieldName = o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlName_A41378.UIName.ToString();
								text7 = o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlName_A41378_UIValue.ToString();
								num = (short)49020929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BE7:
								recSet.UIFields.Add(uifields);
								num = (short)1756823565;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C66:
							goto IL_1D3B;
						}
						finally
						{
							num = (short)553254912;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1C9E;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1399848962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1CD6;
								}
								IL_1C9E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1600454657;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1CD6:;
						}
						goto IL_1CD9;
						IL_1D3B:
						table.RecSet.Add(recSet);
						num = (short)1551695907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
						if (!dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic)
						{
							num = (short)708182059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1312620594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						goto IL_30F3;
					case 63:
						goto IL_CB3;
					case 64:
						try
						{
							num = (short)632684578;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								string text10;
								switch (num2)
								{
								case 0:
									goto IL_15EE;
								case 1:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)1113653296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)1061158923;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_12CC;
								}
								case 3:
								{
									string text9;
									this.a(ref uifields, text9.ToString());
									num = (short)1919549477;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1313931287;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode5 = enumerator.Current;
									recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									num4++;
									recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num4.ToString();
									recSet.RecNo = num4.ToString();
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection = acpFeatureNode5[10239] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection;
									int radErgoCfgKMConventionalKMButtonFeature_A19646Value = kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646Value;
									int radErgoCfgKMTrunkingKMButtonFeature_A19746Value = kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746Value;
									string text8 = (string)kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Converter.Convert(radErgoCfgKMConventionalKMButtonFeature_A19646Value, null, null, cultureInfo);
									string text9 = (string)kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Converter.Convert(radErgoCfgKMTrunkingKMButtonFeature_A19746Value, null, null, cultureInfo);
									num = (short)733872145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_12CC;
								case 6:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a즜킞ﶨ", a_), cultureInfo);
									num = (short)669515801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (!isRightToLeft)
									{
										num = (short)1449459756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)373489683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (text10 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a\udf9c킞ﺪ怜ﮮﺰﶲ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2079850520;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒\uda94ꊖ\udb98캚즜쮞", a_), cultureInfo);
									num = (short)684326912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_12CC;
								case 11:
								{
									string text9;
									this.a(ref uifields, text9.ToString());
									num = (short)433979397;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num = (short)890765319;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									string text9;
									this.a(ref uifields, text9.ToString());
									num = (short)40108042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)44105770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									if (isRightToLeft)
									{
										num = (short)126746667;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)373948442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a킜횞ﺪ怜ﮮﺰﶲ", a_), cultureInfo);
									num = (short)1274019868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)389480477;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2072641571;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									this.a(ref uifields, "");
									num = (short)503054357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)847773734;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)909967407;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)1895956512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_16AF;
								}
								case 21:
									goto IL_11D5;
								case 22:
									goto IL_12CC;
								case 23:
									num = (short)1484193819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a\udf9c킞ﺪ怜ﮮﺰﶲ", a_), cultureInfo);
									num = (short)1076690974;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									goto IL_15EE;
								case 26:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)1638793217;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_10CD;
								}
								case 27:
									goto IL_177A;
								case 28:
									goto IL_15EE;
								case 29:
									num = (short)1757872143;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									goto IL_15EE;
								case 31:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)83492867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1327104020;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 32:
									this.a(ref uifields, "");
									num = (short)1327169569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									goto IL_16AF;
								case 34:
									switch (0)
									{
									case 0:
										goto IL_E51;
									}
									continue;
								case 35:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)250216460;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_12CC;
								case 36:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)1450573837;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_12CC;
								}
								case 37:
									goto IL_16AF;
								case 38:
								{
									string text9;
									this.a(ref uifields, text9.ToString());
									num = (short)64290855;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 39:
									goto IL_11D5;
								case 40:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)819920947;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 41:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)996802610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_12CC;
								}
								case 42:
									goto IL_E56;
								case 43:
									num = (short)1478885407;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
									num = (short)1439170612;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									if (text10 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a킜횞ﺪ怜ﮮﺰﶲ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)938672144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1358626825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									if (text10 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒요\ude96\udd98\ude9a즜킞ﶨ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)72286214;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)479264813;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
									{
										num = (short)1694171154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11D5;
								}
								case 48:
									goto IL_10CD;
								case 49:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)1122697256;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_12CC;
								}
								case 50:
								{
									string text8;
									this.a(ref uifields, text8.ToString());
									num = (short)109903894;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 51:
									goto IL_12CC;
								case 52:
								{
									global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
									if (!kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic)
									{
										num = (short)1965096974;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E56;
								}
								}
								goto IL_E51;
								IL_E56:
								num = (short)319946788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10CD:
								num = (short)1129775106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11D5:
								num = (short)1759969321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12CC:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode5).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561.UIName.ToString();
								text10 = ((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)acpFeatureNode5).KMButtonInnerSection.RadErgoCfgKMButtonName_A22561_UIValue.ToString();
								num = (short)1428160558;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_15EE:
								recSet.UIFields.Add(uifields);
								table.RecSet.Add(recSet);
								num = (short)1148911624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16AF:
								num = (short)1554055217;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16F6:
								num = (short)265224196;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E51:
								goto IL_16F6;
							}
							IL_177A:
							goto IL_BC7;
						}
						finally
						{
							num = (short)396558337;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_17E9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_17B1;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1667104768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17B1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)382861314;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17E9:;
						}
						goto IL_17EC;
					case 65:
						if (keypadButtonInnerRecset != null)
						{
							num = (short)1862139928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_333D;
					case 66:
						keypadButtonInnerRecset = (keypadRecset[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
						num = (short)1505099789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
					{
						string text2;
						this.a(ref uifields, text2.ToString());
						num = (short)1244790846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
						if (kmbuttonInnerRecset != null)
						{
							num = (short)1443102730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC7;
					case 69:
					{
						num = (short)1158189164;
						short num6 = num;
						num = (short)942313580;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4EA;
						default:
						{
							num = (short)2093875200;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection;
							if (!dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic)
							{
								num = (short)1589772289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D10;
						}
						}
						break;
					}
					case 70:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num4++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒎ﶘ쒚\udf9c햠힢쪤즦\udaa8", a_), cultureInfo);
						recSet.RecNo = num4.ToString();
						int num5 = 0;
						enumerator = keypadButtonInnerRecset.GetEnumerator();
						num = (short)661979164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						goto IL_39F;
					case 72:
					{
						string radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						string text = text + this.a + radErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue;
						num = (short)1105002559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						num = (short)1524367375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15F;
					IL_39F:
					num = (short)1246953529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E7:
					uifields.UIFieldName = (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMDataButtonName_A22601.UIName.ToString();
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒톔횖춘\uda9a\udf9c쪞骪", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)173539346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EF:
					num = (short)997785668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BC7:
					num = (short)1576796192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C03:
					num = (short)1862467649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB3:
					num = (short)1378353206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D10:
					num = (short)510066710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17EC:
					num = (short)178192424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CD9:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					num4++;
					recSet.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎햐첒\udb94횖쾘튚\uda9c\ude9eﮮﲲ領", a_), cultureInfo);
					recSet.RecNo = num4.ToString();
					enumerator = o5NavigationControlsTableInnerRecset.GetEnumerator();
					num = (short)580583484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D8F:
					keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
					num = (short)619773994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EA:
					goto IL_1D8F;
					IL_1F53:
					num = (short)1749418005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FD0:
					table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춎슜ﺞ쾠잢瘝욨얪\ud9ac\uddae\udeb0\udfb2운", a_), cultureInfo);
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욎ﾐ욘튚列", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮎캠춢瘝춨", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첎ﺐﶒ쾠슢즤쾪", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8eﮔﲖ煮삞", a_), cultureInfo));
					recSet = null;
					uifields = null;
					num4 = 0;
					num = (short)1362624567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EAC:
					num = (short)1093599241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30AA:
					num = (short)1695219745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30F3:
					num = (short)1868628020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_320B:
					keypadRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset);
					num = (short)1026752558;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_32A7:
				IL_333D:
				RptXMLData.tables.Add(table);
				return;
				IL_15F:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
				cultureInfo = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				o5InnerRecset = null;
				kmbuttonInnerRecset = null;
				dataButtonInnerRecset = null;
				controlHeadO5Recset = null;
				o5NavigationControlsTableInnerRecset = null;
				keypadMicAndAccessoriesRecset = null;
				trunkingSystem = null;
				keypadRecset = null;
				keypadButtonInnerRecset = null;
				trunkingSystem = (global::AcpCommonLib.FeatureManager.GetFeature(2064)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = global::AcpCommonLib.FeatureManager.GetFeature(2130)[0];
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = global::AcpCommonLib.FeatureManager.GetFeature(2128)[0];
				controlHeadO5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
				num = (short)582811650;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0025EA3C File Offset: 0x0025CC3C
		public void AddButtonsAndControlO9(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType)
		{
			int a_ = 15;
			short num = (short)161218560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_190;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset keypadRecset;
				global::System.Globalization.CultureInfo cultureInfo;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset responseSelectorListInnerRecset;
				bool isRightToLeft;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset o9InnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset o9NavigationControlsTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset pasirenButtonsListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				for (;;)
				{
					IL_31:
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					int num3;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					string text;
					string text2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection;
					switch (num2)
					{
					case 0:
						if (keypadRecset != null)
						{
							num = (short)1543569449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44D1;
					case 1:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삑얟ﶡ쎥쒧쾩쾫\udaad\udfaf삱", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = responseSelectorListInnerRecset.GetEnumerator();
						num = (short)2089877579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						this.a(ref uifields, text.ToString());
						this.a(ref uifields, text2.ToString());
						num = (short)57999431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2093;
					case 4:
						goto IL_4494;
					case 5:
						goto IL_154D;
					case 6:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)492634168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3858;
					case 7:
						goto IL_154D;
					case 8:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)1785266230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45C8;
					case 9:
						num = (short)1177223194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_44D1;
					case 11:
						if (!isRightToLeft)
						{
							num = (short)1802567689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1623588872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1405091851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						this.a(ref uifields, "");
						this.a(ref uifields, text.ToString());
						num = (short)184811573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenStatic)
						{
							num = (short)1145372674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36B4;
					case 15:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenStatic)
						{
							num = (short)887226431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45C8;
					case 16:
						if (bottomFunctionProgrammableButtonInnerRecset != null)
						{
							num = (short)673513501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14D3;
					case 17:
						goto IL_3853;
					case 18:
						this.a(ref uifields, text.ToString());
						this.a(ref uifields, "");
						num = (short)1706426419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (!keypadRecset.HiddenStatic)
						{
							num = (short)1105264670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2093;
					case 20:
						this.a(ref uifields, text.ToString());
						this.a(ref uifields, "");
						num = (short)936640519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num3.ToString();
						recSet.RecNo = num3.ToString();
						o9DataButtonInnerSection = (o9DataButtonInnerRecset[0][10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection);
						int radErgCtrlHeadO9DataButtonCnvFeature_A36528Value = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528Value;
						int radErgCtrlHeadO9DataButtonTrkFeature_A36526Value = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526Value;
						text = (string)o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Converter.Convert(radErgCtrlHeadO9DataButtonCnvFeature_A36528Value, null, null, cultureInfo);
						text2 = (string)o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Converter.Convert(radErgCtrlHeadO9DataButtonTrkFeature_A36526Value, null, null, cultureInfo);
						string cho9DataButtonConvIndex_A41414_UIValue = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414_UIValue;
						string cho9DataButtonTrkIndex_A41416_UIValue = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416_UIValue;
						num = (short)1115815984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_2130;
					case 23:
						if (directionalButtonsListInnerRecset != null)
						{
							num = (short)1047789602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1510;
					case 24:
						goto IL_154D;
					case 25:
						this.a(ref uifields, "");
						this.a(ref uifields, text.ToString());
						num = (short)393019434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)1093075025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36B4;
					case 27:
						goto IL_1510;
					case 28:
						try
						{
							num = (short)1042612228;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text3;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection;
								switch (num2)
								{
								case 0:
									if (text3 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쮗펙캛\udb9dﺫ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)251658245;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)242352153;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91궓즕쮗ﮝ캟ﶡ", a_), cultureInfo);
									num = (short)508952584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3E77;
								case 3:
								{
									this.a(ref uifields, "");
									string text4;
									this.a(ref uifields, text4.ToString());
									num = (short)658243603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_3E38;
									}
									continue;
								case 5:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쮗펙캛\udb9dﺫ", a_), cultureInfo);
									num = (short)574160920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									string text4;
									this.a(ref uifields, text4.ToString());
									this.a(ref uifields, "");
									num = (short)422510619;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									if (text3 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91궓즕쮗ﮝ캟ﶡ쾥쒧얩", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)452460561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1490812949;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_3E77;
								case 9:
									num = (short)68419602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (text3 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쮗펙캛\udb9dﮡ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1983447053;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)215089159;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_3E77;
								case 12:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쮗펙캛\udb9dﶧ", a_), cultureInfo);
									num = (short)1234108427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쮗펙캛\udb9dﮡ", a_), cultureInfo);
									num = (short)2143944706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (!isRightToLeft)
									{
										num = (short)1341784094;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)466223130;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									if (text3 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쮗펙캛\udb9d", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1781727254;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1573191690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91궓즕쮗ﮝ캟ﶡ쾥쒧얩", a_), cultureInfo);
									num = (short)365887511;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_4422;
								case 19:
									goto IL_4058;
								case 20:
									goto IL_3E77;
								case 21:
									if (text3 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91궓즕쮗ﮝ캟ﶡ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)570228737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3E77;
								case 22:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쮗펙캛\udb9d", a_), cultureInfo);
									num = (short)1220411412;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									goto IL_3E77;
								case 24:
									goto IL_3E77;
								case 25:
									if (text3 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쮗펙캛\udb9dﶧ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1472528396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1447100431;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									if (!pasirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.HiddenStatic)
									{
										num = (short)2128281603;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4058;
								case 27:
									goto IL_4058;
								case 28:
									if (!pasirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.HiddenStatic)
									{
										num = (short)53870598;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4058;
								case 29:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1571553289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									pasirenButtonsListInnerSection = (acpFeatureNode[10744] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection);
									int cho9PASirenButtonsFeature_A41540Value = pasirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540Value;
									string text4 = (string)pasirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Converter.Convert(cho9PASirenButtonsFeature_A41540Value, null, null, cultureInfo);
									num = (short)773193742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
									num = (short)570097692;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3E38;
								IL_3E77:
								recSet.UIFields.Add(uifields);
								num = (short)510459920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3E9F:
								num = (short)935788573;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3E38:
								goto IL_3E9F;
								IL_4058:
								uifields.UIFieldName = pasirenButtonsListInnerSection.CHO9PASirenButtonsName_A41537.UIName;
								text3 = pasirenButtonsListInnerSection.CHO9PASirenButtonsName_A41537_UIValue.ToString();
								num = (short)1873149952;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4422:
							goto IL_382D;
						}
						finally
						{
							num = (short)205914113;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_4491;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4459;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)657260544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4459:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1987313666;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4491:;
						}
						goto IL_4494;
						IL_382D:
						table.RecSet.Add(recSet);
						num = (short)1932591121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킑ﮓ솝힡킣튥잧쒩\udfab", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = bottomFunctionProgrammableButtonInnerRecset.GetEnumerator();
						num = (short)1572864064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud991ﮙ솝힡킣튥잧쒩\udfab", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						int num4 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = keypadButtonInnerRecset.GetEnumerator();
						num = (short)1936982047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						try
						{
							num = (short)622985222;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text6;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								switch (num2)
								{
								case 0:
								{
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									string text5 = text5 + this.a + radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)1136132117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)718733325;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﶗ꾙쎛힝쒟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1171390509;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)338624548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1123;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)1077477428;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D73;
								}
								case 5:
									goto IL_1123;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_7C8;
									}
									continue;
								case 7:
									goto IL_1123;
								case 8:
									goto IL_1123;
								case 9:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﶓ꺗얙햛瞧", a_), cultureInfo);
									num = (short)1975582759;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑ﶓ꒛솝욡", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1217986575;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)557776945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_1123;
								case 13:
									goto IL_129C;
								case 14:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﮓ꺙쎛힝쒟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)614793234;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1494941698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑ﶓ꒛솝욡", a_), cultureInfo);
									num = (short)1941110791;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﶗꮛ솝욡", a_), cultureInfo);
									num = (short)1501429763;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (isRightToLeft)
									{
										num = (short)1740505130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1477312516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﮓ꺙쎛힝쒟", a_), cultureInfo);
									num = (short)2126053387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									goto IL_1123;
								case 20:
									goto IL_1123;
								case 21:
									goto IL_BB7;
								case 22:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욑ﲓﶗﾙ꾛솝욡", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1205207066;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1042481166;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									goto IL_1123;
								case 24:
									goto IL_D73;
								case 25:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ﮓﺙ풛ﾝ펟쪡ﮣ첧", a_), cultureInfo);
									num = (short)760872995;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욑ﲓﶗﾙ꾛솝욡", a_), cultureInfo);
									num = (short)514195485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91望ꦗ얙햛瞧", a_), cultureInfo);
									num = (short)1626472468;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
									if (!keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.HiddenStatic)
									{
										num = (short)1566965792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D73;
								}
								case 29:
									goto IL_1123;
								case 30:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑얙햛瞧", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)279642149;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1262682162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									goto IL_1123;
								case 32:
								{
									string text5;
									this.a(ref uifields, text5);
									num = (short)267845656;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 33:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91望ꦗ얙햛瞧", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)47120411;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)425000994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욑秊ꪗ얙햛瞧", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)163119155;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)546570262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
									goto IL_1123;
								case 36:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﶓ꺗얙햛瞧", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2089811977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)203489323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑얙햛瞧", a_), cultureInfo);
									num = (short)1379270687;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
									if (text6 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕슗\udf99캛톝邟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)811925544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)985137185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									goto IL_1123;
								case 40:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕슗\udf99캛톝邟", a_), cultureInfo);
									num = (short)1083441171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 41:
								{
									string text5;
									if (text5 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쪗\udf99킛\udf9d烈ﲧﺫ", a_), cultureInfo))
									{
										num = (short)1430585344;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BB7;
								}
								case 42:
									this.a(ref uifields, "");
									num = (short)312737820;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﶗꮛ솝욡", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1925447696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1630470154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91ﶓﶗꎙ쎛힝쒟", a_), cultureInfo);
									num = (short)846921736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﶓﶗ꾙쎛힝쒟", a_), cultureInfo);
									num = (short)256442373;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									goto IL_1123;
								case 47:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)467861505;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode2 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection = acpFeatureNode2[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection;
									int radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value = (acpFeatureNode2[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value;
									string text5 = (string)(acpFeatureNode2[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Converter.Convert(radErgCtrlKeypadGeneralKeypadButtonFeature_A41071Value, null, null, cultureInfo);
									string radErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue = (acpFeatureNode2[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonIndex_41415_UIValue;
									num = (short)2136801321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 48:
									goto IL_D73;
								case 49:
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc91ﶓﶗꎙ쎛힝쒟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1460797484;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1445396510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
								{
									if (text6 == global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ﮓﺙ풛ﾝ펟쪡ﮣ첧", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)58982425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num4;
									num4++;
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕펗\udf99얛캝ﲧﺩ", a_), cultureInfo) + num4.ToString();
									num = (short)422051863;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 51:
									uifields.UIFieldDes = global::CommonResources.MTFResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욑秊ꪗ얙햛瞧", a_), cultureInfo);
									num = (short)1881014318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 52:
								{
									string text5;
									this.a(ref uifields, text5);
									num = (short)141623344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_7C8;
								IL_BB7:
								num = (short)1116798993;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D73:
								uifields.UIFieldName = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode2).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069.UIName.ToString();
								text6 = ((global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)acpFeatureNode2).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069_UIValue.ToString();
								num = (short)1887240230;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1123:
								recSet.UIFields.Add(uifields);
								num = (short)1425145868;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_118A:
								num = (short)1218183215;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7C8:
								goto IL_118A;
							}
							IL_129C:
							goto IL_3B6;
						}
						finally
						{
							num = (short)1443758080;
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
										goto IL_12D3;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1882521602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_130C;
								}
								IL_12D3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1633878017;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_130C:;
						}
						goto IL_130F;
						IL_3B6:
						table.RecSet.Add(recSet);
						num = (short)557580291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)542441484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_154D;
					case 33:
						if (o9InnerRecset != null)
						{
							num = (short)1375010860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_426;
					case 34:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑ﶓﶗ蓮쾟첡얣쪥\ud9ab\udaad쒯\uddb1\udab3억", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = directionalButtonsListInnerRecset.GetEnumerator();
						num = (short)606863398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (o9NavigationControlsTableInnerRecset != null)
						{
							num = (short)1196818478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134A;
					case 36:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)856096781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_154D;
					case 37:
						num = (short)1108148302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						try
						{
							num = (short)614727697;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text10;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection;
								switch (num2)
								{
								case 0:
								{
									string text7 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗풙\udd9b춝", a_), cultureInfo);
									num = (short)1359216643;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_2921;
								case 3:
									goto IL_285E;
								case 4:
								{
									string text7;
									string text8;
									if (text7 == text8)
									{
										num = (short)114425856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_285E;
								}
								case 5:
									goto IL_2921;
								case 6:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕첗햙첛\udd9d盛", a_), cultureInfo);
									num = (short)1841561601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_2A70;
								case 8:
									num = (short)964296727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1838284816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_2921;
								case 11:
								{
									string text7;
									this.a(ref uifields, text7.ToString());
									string text9;
									this.a(ref uifields, text9.ToString());
									num = (short)1745223698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)1676673033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)162398222;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_2921;
								case 14:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)824639496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A70;
								case 15:
									goto IL_2B51;
								case 16:
								{
									if (isRightToLeft)
									{
										num = (short)667484171;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text9;
									this.a(ref uifields, text9.ToString());
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)1407057948;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
									switch (0)
									{
									case 0:
										goto IL_2553;
									}
									continue;
								case 18:
									goto IL_2A70;
								case 19:
									if (text10 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕첗햙첛\udd9d盛", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)633012230;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)124321818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쪗펙\udb9b횝", a_), cultureInfo);
									num = (short)581828618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									string text9;
									this.a(ref uifields, text9.ToString());
									string text7;
									this.a(ref uifields, text7.ToString());
									num = (short)588775446;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									goto IL_2A70;
								case 23:
								{
									if (!isRightToLeft)
									{
										num = (short)1104805909;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text7;
									this.a(ref uifields, text7.ToString());
									string text9;
									this.a(ref uifields, text9.ToString());
									num = (short)375980039;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1281425433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									directionalButtonsListInnerSection = (acpFeatureNode3[10610] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection);
									int radErgCtrlHeadO9DirLightBarFeature_A36597Value = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597Value;
									int radErgCtrlHeadO9DirLightBarIndex_A36601Value = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarIndex_A36601Value;
									string text9 = (string)directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597.Converter.Convert(radErgCtrlHeadO9DirLightBarFeature_A36597Value, null, null, cultureInfo);
									string text7 = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarIndex_A36601_UIValue;
									string text8 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗풙\udd9b춝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture);
									text8 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺑", a_) + text8 + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겑", a_);
									num = (short)1979711492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									num = (short)92012559;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									if (text10 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕풗\udf99\uda9b쪝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)272302109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1693122587;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									if (text10 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕쪗펙\udb9b횝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)30670868;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕\udc97펙캛\udb9d例", a_), cultureInfo);
									num = (short)1197277197;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									goto IL_2A70;
								case 29:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕풗\udf99\uda9b쪝", a_), cultureInfo);
									num = (short)951582725;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2558:
								num = (short)1220280344;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2553:
								goto IL_2558;
								IL_285E:
								num = (short)1488191500;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2921:
								recSet.UIFields.Add(uifields);
								num = (short)390266882;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A70:
								uifields.UIFieldName = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarName_A36558.UIName.ToString();
								text10 = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarName_A36558_UIValue.ToString();
								num = (short)1232404499;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B51:
							goto IL_2E0;
						}
						finally
						{
							num = (short)745930753;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1283981314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2B88;
									}
									continue;
								case 2:
									goto IL_2BC0;
								}
								IL_2B88:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1058144256;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2BC0:;
						}
						goto IL_2BC3;
						IL_2E0:
						table.RecSet.Add(recSet);
						num = (short)77266971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						string cho9DataButtonConvIndex_A41414_UIValue;
						text = text + this.a + cho9DataButtonConvIndex_A41414_UIValue;
						num = (short)2022309972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕좗\udb99쾛힝ﶧﺩﺯ", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = pasirenButtonsListInnerRecset.GetEnumerator();
						num = (short)558170140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						keypadButtonInnerRecset = (keypadRecset[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
						num = (short)1521352714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_154D;
					case 43:
						if (controlHeadO9Recset != null)
						{
							num = (short)1007157330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2046;
					case 44:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						num3++;
						recSet.RecTitle = global::CommonResources.AppResources.NOPRINT_Id + num3.ToString();
						recSet.RecNo = num3.ToString();
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection o9InnerSection = o9InnerRecset[0][10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection;
						int cho9EmergencyButtonFeature_A36682Value = o9InnerSection.CHO9EmergencyButtonFeature_A36682Value;
						string text11 = (string)o9InnerSection.CHO9EmergencyButtonFeature_A36682.Converter.Convert(cho9EmergencyButtonFeature_A36682Value, null, null, cultureInfo);
						this.a(ref uifields, text11.ToString());
						this.a(ref uifields, text11.ToString());
						uifields.UIFieldName = o9InnerSection.CHO9EmergencyButtonName_A36680.UIName.ToString();
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕힗좙\udd9b킝ﲧﺩ", a_), cultureInfo);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)230359100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						goto IL_2046;
					case 46:
					{
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						num3++;
						recSet.RecTitle = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕횗\udb99쪛힝ﺯ例", a_), cultureInfo);
						recSet.RecNo = num3.ToString();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9NavigationControlsTableInnerRecset.GetEnumerator();
						num = (short)399769668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_239C;
					case 48:
						if (text == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕\ud997\ud999좛힝囹羚", a_), cultureInfo))
						{
							num = (short)1227685927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FEC;
					case 49:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenStatic)
						{
							num = (short)865402965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3858;
					case 50:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)2144469017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_154D;
					case 51:
						goto IL_154D;
					case 52:
						if (pasirenButtonsListInnerRecset != null)
						{
							num = (short)2112159784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_460E;
					case 53:
						goto IL_154D;
					case 54:
						num = (short)1242628111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_2BC3;
					case 56:
						num = (short)1980629041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_154D;
					case 58:
						if (keypadButtonInnerRecset != null)
						{
							num = (short)1978859599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2093;
					case 59:
						num = (short)103022598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_426;
					case 61:
						goto IL_134A;
					case 62:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1584463876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_460E;
					case 63:
						goto IL_130F;
					case 64:
						try
						{
							num = (short)1108213785;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text12;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
								string text14;
								switch (num2)
								{
								case 0:
									goto IL_1D52;
								case 1:
									goto IL_1E71;
								case 2:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ꂓ즕톗ﺙ", a_), cultureInfo);
									num = (short)1297678342;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (text12 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕좗ꮙ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1829765128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)794099724;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (text12 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ꂓ즕톗ﺙ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1173291010;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)422772756;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1D52;
								case 6:
									goto IL_1D52;
								case 7:
									if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_Applicable)
									{
										num = (short)23592988;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)1802174500;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕좗ꮙ", a_), cultureInfo);
									num = (short)1661468672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)299630593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_1B4A;
								case 11:
									goto IL_190E;
								case 12:
									if (text12 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ꚓ즕톗ﺙ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)692977698;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2066874382;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ꆓ즕톗ﺙ", a_), cultureInfo);
									num = (short)832372766;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (text12 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ꞓ즕톗ﺙ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)928907296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)534183940;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									string a_2 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗풙\udd9b춝", a_), cultureInfo);
									this.a(ref uifields, a_2);
									num = (short)639238173;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									string a_2;
									string text13;
									if (a_2 == text13)
									{
										num = (short)1870069775;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_UIValue.ToString());
									num = (short)1911422994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									goto IL_1B4A;
								case 19:
								{
									string a_3 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗풙\udd9b춝", a_), cultureInfo);
									this.a(ref uifields, a_3);
									num = (short)1453785109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
									if (text12 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ꆓ즕톗ﺙ", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)643235853;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킑ﮓ솝힡킣튥잧쒩", a_), cultureInfo);
									num = (short)626458659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									goto IL_190E;
								case 22:
									this.a(ref uifields, text14.ToString());
									num = (short)1758789639;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									if (!isRightToLeft)
									{
										num = (short)669515798;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)470548517;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)625082377;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									bottomFunctionProgrammableButtonInnerSection = (acpFeatureNode4[10619] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection);
									int cho9BottomFunctionButtonFeature_A36664Value = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664Value;
									text14 = (string)bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664.Converter.Convert(cho9BottomFunctionButtonFeature_A36664Value, null, null, cultureInfo);
									num = (short)877789207;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									switch (0)
									{
									case 0:
										goto IL_16A7;
									}
									continue;
								case 26:
									goto IL_190E;
								case 27:
								{
									string a_3;
									string text15;
									if (a_3 == text15)
									{
										num = (short)376045587;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_UIValue.ToString());
									num = (short)1743061003;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 28:
								{
									string text15 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗풙\udd9b춝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture);
									text15 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺑", a_) + text15 + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겑", a_);
									string a_3 = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_UIValue.ToString();
									num = (short)1699872795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 29:
									goto IL_1B4A;
								case 30:
									goto IL_1D52;
								case 31:
									goto IL_1D52;
								case 32:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ꞓ즕톗ﺙ", a_), cultureInfo);
									num = (short)1114046469;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
								{
									string text13 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗풙\udd9b춝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture);
									text13 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺑", a_) + text13 + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겑", a_);
									string a_2 = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_UIValue.ToString();
									num = (short)843513873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 34:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑ꚓ즕톗ﺙ", a_), cultureInfo);
									num = (short)1457127455;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
									goto IL_1D52;
								case 36:
									goto IL_190E;
								case 37:
									if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665_Applicable)
									{
										num = (short)342032417;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)187760650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_16A7;
								IL_190E:
								uifields.UIFieldName = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonName_A36657.UIName.ToString();
								text12 = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonName_A36657_UIValue.ToString();
								num = (short)1063780355;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B07:
								num = (short)147062808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16A7:
								goto IL_1B07;
								IL_1B4A:
								this.a(ref uifields, text14.ToString());
								num = (short)73728026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D52:
								recSet.UIFields.Add(uifields);
								num = (short)1639972880;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E71:
							goto IL_15BE;
						}
						finally
						{
							num = (short)457965570;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1076625409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1EE1;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1EA9;
									}
									continue;
								}
								IL_1EA9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1803223040;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1EE1:;
						}
						goto IL_1EE4;
						IL_15BE:
						table.RecSet.Add(recSet);
						num = (short)666697801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)820838421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_239C;
					case 66:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)273285192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1779040288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (text2 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕\ud997\ud999좛힝囹羚", a_), cultureInfo))
						{
							num = (short)702349382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BFE;
					case 68:
						try
						{
							num = (short)1794244621;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text16;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection o9NavigationControlsTableInnerSection;
								string text17;
								switch (num2)
								{
								case 0:
									goto IL_3CDD;
								case 1:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗쪙\ude9b쮝", a_), cultureInfo);
									num = (short)1048772613;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									this.a(ref uifields, text16.ToString());
									num = (short)1671561233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									this.a(ref uifields, text16.ToString());
									num = (short)1901985800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑ﮓ얙\ude9b풟횡쮣좥", a_), cultureInfo);
									num = (short)1500577808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_3BE1;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2126970898;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									o9NavigationControlsTableInnerSection = (acpFeatureNode5[10734] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection);
									int radErgoControlO9NaviControlFeature_A41371Value = o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlFeature_A41371Value;
									text16 = (string)o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlFeature_A41371.Converter.Convert(radErgoControlO9NaviControlFeature_A41371Value, null, null, cultureInfo);
									num = (short)842989583;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_3A64;
								case 8:
									goto IL_3A64;
								case 9:
									num = (short)1617559572;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)1953955843;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3A64;
								case 11:
									if (text17 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑ﮓ얙\ude9b풟횡쮣좥", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1872953348;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3BE1;
								case 13:
									switch (0)
									{
									case 0:
										goto IL_3919;
									}
									continue;
								case 14:
									goto IL_391E;
								case 15:
									if (isRightToLeft)
									{
										num = (short)1486815241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, text16.ToString());
									num = (short)1568931850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_3BE1;
								case 17:
									goto IL_391E;
								case 18:
									num = (short)873791488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									if (text17 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗쪙\ude9b쮝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)766967809;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)310247435;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									if (!trunkingSystem.Parent.HiddenStatic)
									{
										num = (short)200278018;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)1687289870;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3919;
								IL_391E:
								this.a(ref uifields, text16.ToString());
								num = (short)808058887;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3A64:
								uifields.UIFieldName = o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlName_A41370.UIName.ToString();
								text17 = o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlName_A41370_UIValue.ToString();
								num = (short)55640083;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AEE:
								num = (short)1380843526;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3919:
								goto IL_3AEE;
								IL_3BE1:
								recSet.UIFields.Add(uifields);
								num = (short)989462540;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3CDD:
							goto IL_2370;
						}
						finally
						{
							num = (short)1662976002;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1279787009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3D4D;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3D14;
									}
									continue;
								}
								IL_3D14:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1540096000;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3D4D:;
						}
						goto IL_3D50;
						IL_2370:
						table.RecSet.Add(recSet);
						num = (short)640155709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (responseSelectorListInnerRecset != null)
						{
							num = (short)216334337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2130;
					case 70:
					{
						string cho9DataButtonTrkIndex_A41416_UIValue;
						text2 = text2 + this.a + cho9DataButtonTrkIndex_A41416_UIValue;
						num = (short)1516830800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						goto IL_154D;
					case 72:
						num = (short)210174029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						goto IL_14D3;
					case 74:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)1577648146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_154D;
					case 75:
						try
						{
							num = (short)2040004615;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection responseSelectorListInnerSection;
								string text20;
								string text21;
								switch (num2)
								{
								case 0:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗햙\ud89b\udb9d醟", a_), cultureInfo);
									num = (short)1191706636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!isRightToLeft)
									{
										num = (short)1957756948;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1846214695;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_35A4;
								case 3:
									goto IL_35A4;
								case 4:
								{
									string text18;
									this.a(ref uifields, text18.ToString());
									num = (short)1376976905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_300D;
								case 6:
								{
									string text18;
									string text19;
									if (text18 == text19)
									{
										num = (short)2097676315;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_300D;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_2D78;
									}
									continue;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1742274586;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									responseSelectorListInnerSection = (acpFeatureNode6[10625] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection);
									int cho9PursuitKnobAction_A36684Value = responseSelectorListInnerSection.CHO9PursuitKnobAction_A36684Value;
									int cho9PursuitKnobIndex_A36685Value = responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685Value;
									text20 = (string)responseSelectorListInnerSection.CHO9PursuitKnobAction_A36684.Converter.Convert(cho9PursuitKnobAction_A36684Value, null, null, cultureInfo);
									string text18 = responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685_UIValue;
									string text19 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗풙\udd9b춝", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture);
									text19 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꺑", a_) + text19 + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겑", a_);
									num = (short)192086022;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_3462;
								case 10:
									if (text21 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗햙\ud89b\udb9d銟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)1146093610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1709506596;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_3462;
								case 12:
									goto IL_2FE2;
								case 14:
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗햙\ud89b\udb9d邟", a_), cultureInfo);
									num = (short)1994588185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)1688469523;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3462;
								case 16:
									goto IL_2FE2;
								case 17:
									goto IL_3462;
								case 18:
									goto IL_3640;
								case 19:
									num = (short)1526202369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									this.a(ref uifields, text20.ToString());
									num = (short)1368326184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									string text18;
									this.a(ref uifields, text18.ToString());
									num = (short)854917149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									goto IL_3462;
								case 23:
									if (text21 == global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗햙\ud89b\udb9d邟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)738459662;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1089470502;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									goto IL_3577;
								case 25:
									goto IL_2FE2;
								case 26:
									num = (short)392626194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
								{
									string text18 = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕춗풙\udd9b춝", a_), cultureInfo);
									goto IL_3445;
								}
								case 28:
									num = (short)367067169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									goto IL_3462;
								case 30:
									goto IL_2FE2;
								case 31:
									num = (short)1494482987;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									if (responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685_Applicable)
									{
										num = (short)803209220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)301465622;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
								{
									if (!isRightToLeft)
									{
										this.a(ref uifields, text20.ToString());
										num = (short)1622999072;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1229882025;
									short num5 = num;
									num = (short)1318290089;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3445;
									default:
										num = (short)1559953408;
										if (num != 0)
										{
										}
										num = (short)762052639;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 34:
									goto IL_3577;
								case 35:
								{
									string text18;
									this.a(ref uifields, text18.ToString());
									num = (short)1270743042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 36:
									if (text21 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗햙\ud89b\udb9d鎟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)2101542953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗햙\ud89b\udb9d", a_), cultureInfo);
									num = (short)460652560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									string text18;
									this.a(ref uifields, text18.ToString());
									num = (short)1310064674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 38:
									if (text21 == global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗햙\ud89b\udb9d醟", a_), global::System.Threading.Thread.CurrentThread.CurrentCulture))
									{
										num = (short)676593664;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2002059274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									if (responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685_Applicable)
									{
										num = (short)2058682405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)1233977368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 40:
									if (responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685_Applicable)
									{
										num = (short)1495007253;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)172359726;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 41:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗햙\ud89b\udb9d鎟", a_), cultureInfo);
									num = (short)802357292;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									uifields.UIFieldDes = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕햗햙\ud89b\udb9d銟", a_), cultureInfo);
									num = (short)1980104734;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
									if (responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685_Applicable)
									{
										num = (short)1762525219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(ref uifields, "");
									num = (short)138870787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
									goto IL_2FE2;
								case 45:
									if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
									{
										num = (short)932511772;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)364445711;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									goto IL_3462;
								}
								goto IL_2D78;
								IL_2FE2:
								recSet.UIFields.Add(uifields);
								num = (short)1952776205;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_300D:
								num = (short)1278148653;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_33E7:
								num = (short)2105475080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D78:
								goto IL_33E7;
								IL_3445:
								num = (short)963379205;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3462:
								uifields.UIFieldName = responseSelectorListInnerSection.CHO9PursuitKnobMode_A36683.UIName.ToString();
								text21 = responseSelectorListInnerSection.CHO9PursuitKnobMode_A36683_UIValue.ToString();
								num = (short)1514012695;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3577:
								this.a(ref uifields, text20.ToString());
								num = (short)338100235;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_35A4:
								this.a(ref uifields, text20.ToString());
								num = (short)667418641;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3640:
							goto IL_344;
						}
						finally
						{
							num = (short)1058209794;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)437714945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_36B1;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3677;
									}
									continue;
								}
								IL_3677:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1936523264;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_36B1:;
						}
						goto IL_36B4;
						IL_344:
						table.RecSet.Add(recSet);
						num = (short)1354432534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)742981652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_154D;
					case 77:
						if (isRightToLeft)
						{
							num = (short)2010185787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1430126675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.HiddenStatic)
						{
							num = (short)1500971063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36FC;
					case 79:
						num = (short)680656915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						goto IL_2BFE;
					case 81:
						goto IL_3D50;
					case 82:
						responseSelectorListInnerRecset = (controlHeadO9Recset[0][10624].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset);
						directionalButtonsListInnerRecset = (controlHeadO9Recset[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset);
						o9InnerRecset = (controlHeadO9Recset[0][10626].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset);
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						o9NavigationControlsTableInnerRecset = (controlHeadO9Recset[0][10731].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset);
						bottomFunctionProgrammableButtonInnerRecset = (controlHeadO9Recset[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset);
						pasirenButtonsListInnerRecset = (controlHeadO9Recset[0][10743].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset);
						num = (short)1492582445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						if (!o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.HiddenStatic)
						{
							num = (short)167116837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36FC;
					case 84:
						goto IL_1FEC;
					case 85:
						goto IL_1EE4;
					}
					goto IL_190;
					IL_426:
					num = (short)1495465984;
					short num6 = num;
					num = (short)1996947472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_130F:
					this.a(ref uifields, text2.ToString());
					this.a(ref uifields, text.ToString());
					num = (short)768606232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_134A:
					num = (short)1269104705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14D3:
					num = (short)1335558179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1510:
					num = (short)1632698401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_154D:
					uifields.UIFieldName = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonName_A36523.UIName.ToString();
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91킓즕\udc97\udb99좛\udf9d龭", a_), cultureInfo);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)1554186287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EE4:
					this.a(ref uifields, text2.ToString());
					this.a(ref uifields, text.ToString());
					num = (short)736624645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FEC:
					num = (short)1094385731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2046:
					keypadRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset);
					num = (short)1683554304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2093:
					num = (short)1227685940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2130:
					num = (short)627638295;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_239C:
					num = (short)1753219130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BC3:
					this.a(ref uifields, text.ToString());
					this.a(ref uifields, text2.ToString());
					num = (short)1458438201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BFE:
					num = (short)1313669186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36B4:
					num = (short)294256716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36FC:
					num = (short)1205272650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3858:
					num = (short)1013579812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D50:
					num = (short)1746403342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4494:
					num = (short)629997637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44D1:
					table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킑ﾟ쎡쪣슥쎫삭쒯삱\udbb3\udab5쮷", a_), cultureInfo);
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb91望ﶗ쎛힝쒟", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑ﮗ풟쮡쮣좥좫", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﮓﾙ즟춡쪣장쒧쪭", a_), cultureInfo));
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욑잟ﶡ", a_), cultureInfo));
					recSet = null;
					uifields = null;
					num3 = 0;
					num = (short)802029630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45C8:
					num = (short)671481906;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3853:
				IL_460E:
				RptXMLData.tables.Add(table);
				return;
				IL_190:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				new global::SpecialFeatures.AcpXMLCoreEngineLib.AcpReports();
				cultureInfo = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = global::AcpCommonLib.FeatureManager.GetFeature(4003)[0];
				controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
				responseSelectorListInnerRecset = null;
				directionalButtonsListInnerRecset = null;
				o9InnerRecset = null;
				o9DataButtonInnerRecset = null;
				o9NavigationControlsTableInnerRecset = null;
				bottomFunctionProgrammableButtonInnerRecset = null;
				pasirenButtonsListInnerRecset = null;
				trunkingSystem = (global::AcpCommonLib.FeatureManager.GetFeature(2064)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				keypadRecset = null;
				keypadButtonInnerRecset = null;
				num = (short)613416961;
				if (num != 0)
				{
				}
				num = (short)1872691243;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x002630F8 File Offset: 0x002612F8
		private void a(ref global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields A_0, string A_1)
		{
			short num = (short)1749352449;
			if (num != 0)
			{
			}
			num = (short)70338952;
			short num2 = num;
			num = (short)1637435784;
			switch (num2 == num)
			{
			}
			num = (short)1177616384;
			if (num != 0)
			{
			}
			num = (short)617480192;
			short num3 = num;
			global::SpecialFeatures.AcpXMLCoreEngineLib._Value value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
			value.FieldValue = A_1;
			A_0.values.Add(value);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x002631BC File Offset: 0x002613BC
		public void AddZonesAndChannels(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 10;
			short num = (short)1767309312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5DB;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				global::System.Globalization.CultureInfo cultureInfo;
				bool isRightToLeft;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.Dictionary<int, string> dictionary;
					int num3;
					string a_2;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::System.Collections.Generic.Dictionary<int, string> dictionary2;
					int num4;
					string a_3;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields2;
					global::System.Collections.Generic.Dictionary<int, string> dictionary3;
					int num5;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields3;
					global::System.Collections.Generic.Dictionary<int, string> dictionary4;
					int num6;
					string a_4;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields4;
					global::System.Collections.Generic.Dictionary<int, string> dictionary5;
					int num7;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields5;
					global::System.Collections.Generic.Dictionary<int, string> dictionary6;
					global::System.Collections.Generic.Dictionary<int, string> dictionary7;
					global::System.Collections.Generic.Dictionary<int, string> dictionary8;
					global::System.Collections.Generic.Dictionary<int, string> dictionary9;
					global::System.Collections.Generic.Dictionary<int, string> dictionary10;
					global::System.Collections.Generic.Dictionary<int, string> dictionary11;
					global::System.Collections.Generic.Dictionary<int, string> dictionary12;
					int num8;
					int num9;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields6;
					int num10;
					global::System.Collections.Generic.Dictionary<int, string> dictionary13;
					global::System.Collections.Generic.Dictionary<int, string> dictionary14;
					int num11;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields7;
					global::System.Collections.Generic.Dictionary<int, string> dictionary15;
					string a_5;
					global::System.Collections.Generic.Dictionary<int, string> dictionary16;
					int num12;
					string a_6;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields8;
					int num14;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet2;
					int num15;
					global::System.Collections.Generic.Dictionary<int, string> dictionary17;
					global::System.Collections.Generic.Dictionary<int, string> dictionary18;
					global::System.Collections.Generic.Dictionary<int, string> dictionary19;
					global::System.Collections.Generic.Dictionary<int, string> dictionary20;
					global::System.Collections.Generic.Dictionary<int, string> dictionary21;
					global::System.Collections.Generic.Dictionary<int, string> dictionary22;
					global::System.Collections.Generic.Dictionary<int, string> dictionary23;
					global::System.Collections.Generic.Dictionary<int, string> dictionary24;
					global::System.Collections.Generic.Dictionary<int, string> dictionary25;
					global::System.Collections.Generic.Dictionary<int, string> dictionary26;
					global::System.Collections.Generic.Dictionary<int, string> dictionary27;
					global::System.Collections.Generic.Dictionary<int, string> dictionary28;
					global::System.Collections.Generic.Dictionary<int, string> dictionary29;
					string a_7;
					int num17;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet3;
					int num18;
					string a_8;
					global::System.Collections.Generic.Dictionary<int, string> dictionary30;
					global::System.Collections.Generic.Dictionary<int, string> dictionary31;
					global::System.Collections.Generic.Dictionary<int, string> dictionary32;
					int num19;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet4;
					int num20;
					int num21;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet5;
					int num22;
					int num23;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet6;
					int num24;
					global::System.Collections.Generic.Dictionary<int, string> dictionary33;
					global::System.Collections.Generic.Dictionary<int, string> dictionary34;
					global::System.Collections.Generic.Dictionary<int, string> dictionary35;
					global::System.Collections.Generic.Dictionary<int, string> dictionary36;
					string a_9;
					int num25;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet7;
					int num26;
					int num28;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet9;
					int num29;
					switch (num2)
					{
					case 0:
						dictionary.TryGetValue(num3, out a_2);
						this.a(ref uifields, a_2);
						num = (short)815923374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2528;
					case 2:
						goto IL_4AAC;
					case 3:
						num = (short)320733403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_737;
					case 5:
						dictionary2.TryGetValue(num4, out a_3);
						this.a(ref uifields2, a_3);
						num = (short)1184694506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_3160;
					case 7:
						goto IL_4CA8;
					case 8:
						goto IL_2174;
					case 9:
						if (dictionary3.Count > num5)
						{
							num = (short)358547511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields3, "");
						num = (short)1087701167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (zoneChannelAssignment.Parent.Count >= 6)
						{
							num = (short)1650917491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1088422222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						dictionary4.TryGetValue(num6, out a_4);
						this.a(ref uifields4, a_4);
						num = (short)959840489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (zoneChannelAssignment.Parent.Count >= 6)
						{
							num = (short)426967122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1067515919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_3597;
					case 14:
						goto IL_3E4D;
					case 15:
						if (zoneChannelAssignment.Parent.Count == 5)
						{
							num = (short)78184579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1185022251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (dictionary5.Count > num7)
						{
							num = (short)1874395384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields5, "");
						num = (short)2075853121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_AF8;
					case 18:
						goto IL_657;
					case 19:
						num = (short)1911226533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_21FF;
					case 21:
						if (dictionary6.Count <= 0)
						{
							num = (short)2047410489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6B;
					case 22:
						goto IL_3AC8;
					case 23:
						if (dictionary7.Count > num7)
						{
							num = (short)263061806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields5, "");
						num = (short)1026752721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (dictionary8.Count <= 0)
						{
							num = (short)1472397536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E0;
					case 25:
						dictionary9.TryGetValue(num6, out a_4);
						this.a(ref uifields4, a_4);
						num = (short)59899995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_1A99;
					case 27:
						num = (short)553058663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_1576;
					case 29:
						if (dictionary10.Count > num4)
						{
							num = (short)1782972511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields2, "");
						num = (short)1985937674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (dictionary9.Count > num6)
						{
							num = (short)995754009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields4, "");
						num = (short)1744306451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_413B;
					case 32:
						goto IL_2131;
					case 33:
						goto IL_732;
					case 34:
						goto IL_4510;
					case 35:
						if (dictionary11.Count <= 0)
						{
							num = (short)717815873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F7C;
					case 36:
						dictionary12.TryGetValue(num6, out a_4);
						this.a(ref uifields4, a_4);
						num = (short)427098113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)907346156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_3808;
					case 39:
						num = (short)703725882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (num8 >= num9)
						{
							num = (short)608043030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields6 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num10.ToString();
						recSet.RecNo = num10++.ToString();
						num = (short)1263337524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_106F;
					case 42:
						if (dictionary13.Count <= 0)
						{
							num = (short)1813053527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F7C;
					case 43:
						goto IL_4CA8;
					case 44:
						if (dictionary14.Count > num11)
						{
							num = (short)27459677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields7, "");
						num = (short)1092812867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_657;
					case 46:
						goto IL_4F7C;
					case 47:
						num = (short)1878261992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						dictionary8.TryGetValue(num6, out a_4);
						this.a(ref uifields4, a_4);
						num = (short)342425698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)71631136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						goto IL_1CA1;
					case 51:
						goto IL_22F9;
					case 52:
						if (dictionary15.Count > num8)
						{
							num = (short)1226703037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields6, "");
						num = (short)1123614726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (dictionary4.Count > num6)
						{
							num = (short)763625483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields4, "");
						num = (short)1106313330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (zoneChannelAssignment.Parent.Count == 3)
						{
							num = (short)1692074186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)359203125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						dictionary3.TryGetValue(num5, out a_5);
						this.a(ref uifields3, a_5);
						num = (short)772604126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_3E4D;
					case 57:
						goto IL_1742;
					case 58:
						goto IL_2FE3;
					case 59:
						dictionary16.TryGetValue(num12, out a_6);
						this.a(ref uifields8, a_6);
						num = (short)462225527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_15E5;
					case 61:
					{
						if (dictionary.Count > 0)
						{
							goto IL_77E;
						}
						num = (short)1032764388;
						short num13 = num;
						num = (short)1254931428;
						switch ((num13 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3A63;
						default:
							num = (short)152109056;
							if (num != 0)
							{
							}
							num = (short)1858797615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 62:
						if (num7 >= num14)
						{
							num = (short)964886688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						recSet2 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields5 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet2.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num15.ToString();
						recSet2.RecNo = num15++.ToString();
						num = (short)1107755031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (zoneChannelAssignment.Parent.Count == 2)
						{
							num = (short)902299940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref dictionary8, 1);
						num = (short)2032599341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (dictionary17.Count > num6)
						{
							num = (short)397410437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields4, "");
						num = (short)57606491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						num = (short)569901098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (dictionary18.Count > num7)
						{
							num = (short)392888421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields5, "");
						num = (short)1584136478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						goto IL_3339;
					case 68:
						num = (short)506659020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
					{
						num = (short)1688600576;
						short num16 = num;
						this.a(ref dictionary19, 1);
						this.a(ref dictionary16, 2);
						num = (short)657195189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						goto IL_3808;
					case 71:
						if (dictionary6.Count > num4)
						{
							num = (short)15401230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields2, "");
						num = (short)310247703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						goto IL_1B1C;
					case 73:
						this.a(ref dictionary20, 1);
						this.a(ref dictionary3, 2);
						num = (short)1807876314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						this.a(ref dictionary7, 1);
						this.a(ref dictionary18, 2);
						this.a(ref dictionary21, 3);
						this.a(ref dictionary22, 4);
						this.a(ref dictionary23, 5);
						this.a(ref dictionary5, 6);
						num = (short)1653407964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						goto IL_3160;
					case 76:
						if (zoneChannelAssignment.Parent.Count == 4)
						{
							num = (short)836304998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)751173686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						this.a(ref dictionary19, 1);
						this.a(ref dictionary16, 2);
						this.a(ref dictionary24, 3);
						num = (short)1212350719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						goto IL_4993;
					case 79:
						this.a(ref dictionary25, 2);
						this.a(ref dictionary10, 1);
						num = (short)139722833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						goto IL_1D42;
					case 81:
						goto IL_22F9;
					case 82:
						this.a(ref dictionary19, 1);
						this.a(ref dictionary16, 2);
						this.a(ref dictionary24, 3);
						this.a(ref dictionary26, 4);
						this.a(ref dictionary27, 5);
						this.a(ref dictionary28, 6);
						num = (short)697565269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						goto IL_5030;
					case 84:
						num = (short)687079564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						goto IL_15E5;
					case 86:
						goto IL_1B6B;
					case 87:
						num = (short)2005598459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						dictionary27.TryGetValue(num12, out a_6);
						this.a(ref uifields8, a_6);
						num = (short)871498084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						dictionary29.TryGetValue(num3, out a_2);
						this.a(ref uifields, a_2);
						num = (short)1620639960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						goto IL_32EF;
					case 91:
						goto IL_40F6;
					case 92:
						goto IL_BD6;
					case 93:
						dictionary14.TryGetValue(num11, out a_7);
						this.a(ref uifields7, a_7);
						num = (short)582484145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						goto IL_4CA8;
					case 95:
						dictionary10.TryGetValue(num4, out a_3);
						this.a(ref uifields2, a_3);
						num = (short)1109327952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						if (num11 >= num17)
						{
							num = (short)1791688737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						recSet3 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields7 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet3.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num18.ToString();
						recSet3.RecNo = num18++.ToString();
						num = (short)381288591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						goto IL_461C;
					case 98:
						goto IL_9E4;
					case 99:
						num = (short)1243349101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						goto IL_6F7;
					case 101:
						dictionary18.TryGetValue(num7, out a_8);
						this.a(ref uifields5, a_8);
						num = (short)193658990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						this.a(ref dictionary7, 1);
						this.a(ref dictionary18, 2);
						this.a(ref dictionary21, 3);
						this.a(ref dictionary22, 4);
						num = (short)1626210541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						goto IL_77E;
					case 104:
						this.a(ref dictionary15, 3);
						this.a(ref dictionary13, 2);
						this.a(ref dictionary11, 1);
						num = (short)1670643841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						if (zoneChannelAssignment.Parent.Count == 3)
						{
							num = (short)1305346125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)141099133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						this.a(ref dictionary7, 1);
						this.a(ref dictionary18, 2);
						this.a(ref dictionary21, 3);
						this.a(ref dictionary22, 4);
						this.a(ref dictionary23, 5);
						num = (short)1162805539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						if (dictionary30.Count > num11)
						{
							num = (short)2120483160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields7, "");
						num = (short)786956480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						if (dictionary11.Count > num8)
						{
							num = (short)547291382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields6, "");
						num = (short)860684605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						if (dictionary14.Count > 0)
						{
							num = (short)1634992162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7D;
					case 110:
						goto IL_4878;
					case 111:
						num = (short)51708016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						if (dictionary12.Count <= 0)
						{
							num = (short)723845169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E0;
					case 113:
						if (dictionary29.Count <= 0)
						{
							num = (short)1875050800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_77E;
					case 114:
						goto IL_185C;
					case 115:
						this.a(ref dictionary4, 6);
						this.a(ref dictionary9, 5);
						this.a(ref dictionary12, 4);
						this.a(ref dictionary31, 3);
						this.a(ref dictionary17, 2);
						this.a(ref dictionary8, 1);
						num = (short)1438777573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						if (dictionary17.Count <= 0)
						{
							num = (short)854917248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E0;
					case 117:
						if (zoneChannelAssignment.Parent.Count >= 6)
						{
							num = (short)2001207466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1502740695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						dictionary20.TryGetValue(num5, out a_5);
						this.a(ref uifields3, a_5);
						num = (short)1101660463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
						goto IL_1742;
					case 120:
						if (dictionary32.Count <= 0)
						{
							num = (short)608239964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4510;
					case 121:
						goto IL_169D;
					case 122:
						if (dictionary20.Count > num5)
						{
							num = (short)564985974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields3, "");
						num = (short)392757256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						if (dictionary22.Count > num7)
						{
							num = (short)1772814485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields5, "");
						num = (short)1743388936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						goto IL_8D2;
					case 125:
						if (zoneChannelAssignment.Parent.Count == 2)
						{
							num = (short)419299397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref dictionary19, 1);
						num = (short)306184252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						if (num3 >= num19)
						{
							num = (short)2008940815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						recSet4 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet4.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num20.ToString();
						recSet4.RecNo = num20++.ToString();
						num = (short)762773828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						goto IL_3954;
					case 128:
						num = (short)748486856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 129:
						goto IL_3808;
					case 130:
						goto IL_9E4;
					case 131:
						this.a(ref dictionary19, 1);
						this.a(ref dictionary16, 2);
						this.a(ref dictionary24, 3);
						this.a(ref dictionary26, 4);
						this.a(ref dictionary27, 5);
						num = (short)37159076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						goto IL_3B73;
					case 133:
						dictionary17.TryGetValue(num6, out a_4);
						this.a(ref uifields4, a_4);
						num = (short)1541865522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						if (zoneChannelAssignment.Parent.Count == 2)
						{
							num = (short)86179913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref dictionary20, 1);
						num = (short)1430454479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						if (dictionary19.Count > num12)
						{
							num = (short)1168965989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields8, "");
						num = (short)916193475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
						goto IL_106F;
					case 137:
						if (num5 >= num21)
						{
							num = (short)1087963475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						recSet5 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields3 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet5.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num22.ToString();
						recSet5.RecNo = num22++.ToString();
						num = (short)1659306106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 138:
						if (dictionary10.Count <= 0)
						{
							num = (short)277545166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6B;
					case 139:
						goto IL_16FE;
					case 140:
						if (isRightToLeft)
						{
							num = (short)1033044227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ좖列삞쮢쒤즦잨캪솬\udcae", a_), cultureInfo);
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ슜횞얠", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ꒔좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꞔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꚔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꆔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꂔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꎔ좖킘\udf9a", a_), cultureInfo));
						dictionary7 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary18 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary21 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary22 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary23 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary5 = new global::System.Collections.Generic.Dictionary<int, string>();
						num = (short)1071579462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						if (num6 >= num23)
						{
							num = (short)1198981417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						recSet6 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields4 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet6.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num24.ToString();
						recSet6.RecNo = num24++.ToString();
						num = (short)905379893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 142:
						dictionary26.TryGetValue(num12, out a_6);
						this.a(ref uifields8, a_6);
						num = (short)1755447565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
						if (dictionary32.Count > num11)
						{
							num = (short)1395458251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields7, "");
						num = (short)893190200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
						if (dictionary33.Count > num5)
						{
							num = (short)1394540800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields3, "");
						num = (short)92143737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						goto IL_3B2F;
					case 146:
						this.a(ref dictionary34, 3);
						this.a(ref dictionary, 2);
						this.a(ref dictionary29, 1);
						num = (short)781123930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 147:
						goto IL_233C;
					case 148:
						goto IL_22F9;
					case 149:
						dictionary22.TryGetValue(num7, out a_8);
						this.a(ref uifields5, a_8);
						num = (short)2040135960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 150:
						goto IL_2760;
					case 151:
						goto IL_3BAE;
					case 152:
						dictionary28.TryGetValue(num12, out a_6);
						this.a(ref uifields8, a_6);
						num = (short)2121007162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 153:
						if (dictionary2.Count > num4)
						{
							num = (short)1141178373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields2, "");
						num = (short)946929909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 154:
						goto IL_24E0;
					case 155:
						goto IL_461C;
					case 156:
						if (dictionary4.Count > 0)
						{
							num = (short)1574043802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_509A;
					case 157:
						dictionary21.TryGetValue(num7, out a_8);
						this.a(ref uifields5, a_8);
						num = (short)1815150612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 158:
						if (dictionary31.Count > num6)
						{
							num = (short)934740322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields4, "");
						num = (short)1448345604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 159:
						goto IL_37D8;
					case 160:
						goto IL_4AE7;
					case 161:
						goto IL_1BDD;
					case 162:
						this.a(ref dictionary12, 4);
						this.a(ref dictionary31, 3);
						this.a(ref dictionary17, 2);
						this.a(ref dictionary8, 1);
						num = (short)1209073758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 163:
						goto IL_1A99;
					case 164:
						goto IL_15E5;
					case 165:
						if (dictionary24.Count <= 0)
						{
							num = (short)121962681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF8;
					case 166:
						if (dictionary35.Count > 0)
						{
							num = (short)1764556886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B78;
					case 167:
						dictionary25.TryGetValue(num4, out a_3);
						this.a(ref uifields2, a_3);
						num = (short)1484914856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 168:
						goto IL_413B;
					case 169:
						goto IL_4AAC;
					case 170:
						this.a(ref dictionary35, 6);
						this.a(ref dictionary6, 5);
						this.a(ref dictionary36, 4);
						this.a(ref dictionary2, 3);
						this.a(ref dictionary25, 2);
						this.a(ref dictionary10, 1);
						num = (short)1729233204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ좖列삞쮢쒤즦잨캪솬\udcae", a_), cultureInfo);
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ슜횞얠", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ꒔좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꞔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꚔ좖킘\udf9a", a_), cultureInfo));
						dictionary20 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary3 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary33 = new global::System.Collections.Generic.Dictionary<int, string>();
						num = (short)1543373127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 172:
						goto IL_8D2;
					case 173:
						if (dictionary23.Count > num7)
						{
							num = (short)2079457533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields5, "");
						num = (short)1469841598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 174:
						goto IL_2131;
					case 175:
						goto IL_4925;
					case 176:
						if (!isRightToLeft)
						{
							num = (short)1974403313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ좖列삞쮢쒤즦잨캪솬\udcae", a_), cultureInfo);
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ슜횞얠", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꎔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꂔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꆔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꚔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꞔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ꒔좖킘\udf9a", a_), cultureInfo));
						dictionary10 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary25 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary2 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary36 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary6 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary35 = new global::System.Collections.Generic.Dictionary<int, string>();
						num = (short)1237450869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						goto IL_3339;
					case 178:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)629866580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)966983856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 179:
						goto IL_3B2F;
					case 180:
						dictionary34.TryGetValue(num3, out a_2);
						this.a(ref uifields, a_2);
						num = (short)1938423853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 181:
						goto IL_15E5;
					case 182:
						dictionary13.TryGetValue(num8, out a_9);
						this.a(ref uifields6, a_9);
						num = (short)627310716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 183:
						if (dictionary36.Count <= 0)
						{
							num = (short)482279617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6B;
					case 184:
						if (zoneChannelAssignment.Parent.Count == 3)
						{
							num = (short)2021785839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)813826366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 185:
						num = (short)1882259653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 186:
						if (dictionary18.Count <= 0)
						{
							num = (short)1889533955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32EF;
					case 187:
						this.a(ref dictionary36, 4);
						this.a(ref dictionary2, 3);
						this.a(ref dictionary25, 2);
						this.a(ref dictionary10, 1);
						num = (short)1593245747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 188:
						num = (short)374341818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 189:
						dictionary15.TryGetValue(num8, out a_9);
						this.a(ref uifields6, a_9);
						num = (short)35979339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 190:
						goto IL_1DA3;
					case 191:
						if (dictionary30.Count <= 0)
						{
							num = (short)1587019875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4510;
					case 192:
						goto IL_AB3;
					case 193:
						num = (short)233177109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 194:
						if (zoneChannelAssignment.Parent.Count == 2)
						{
							num = (short)1751974118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref dictionary32, 1);
						num = (short)1620115723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 195:
						goto IL_1BDD;
					case 196:
						if (dictionary24.Count > num12)
						{
							num = (short)103219414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields8, "");
						num = (short)1713504403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 197:
						if (dictionary26.Count <= 0)
						{
							num = (short)1187119436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF8;
					case 198:
						goto IL_737;
					case 199:
						goto IL_5030;
					case 200:
						if (dictionary31.Count <= 0)
						{
							num = (short)1861877871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E0;
					case 201:
						if (zoneChannelAssignment.Parent.Count == 2)
						{
							num = (short)396689695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref dictionary11, 1);
						num = (short)7471174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 202:
						this.a(ref dictionary7, 1);
						this.a(ref dictionary18, 2);
						this.a(ref dictionary21, 3);
						num = (short)1707999497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 203:
						dictionary32.TryGetValue(num11, out a_7);
						this.a(ref uifields7, a_7);
						num = (short)665976846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 204:
						if (dictionary16.Count <= 0)
						{
							num = (short)986513427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF8;
					case 205:
						this.a(ref dictionary6, 5);
						this.a(ref dictionary36, 4);
						this.a(ref dictionary2, 3);
						this.a(ref dictionary25, 2);
						this.a(ref dictionary10, 1);
						num = (short)1018101908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 206:
						num = (short)1178599740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 207:
						goto IL_2049;
					case 208:
						goto IL_1102;
					case 209:
						goto IL_2760;
					case 210:
						num = (short)101777665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 211:
						goto IL_AB3;
					case 212:
						if (dictionary33.Count > 0)
						{
							num = (short)500105516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3099;
					case 213:
						this.a(ref dictionary32, 1);
						this.a(ref dictionary30, 2);
						this.a(ref dictionary14, 3);
						num = (short)1787429009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 214:
						dictionary24.TryGetValue(num12, out a_6);
						this.a(ref uifields8, a_6);
						num = (short)1351745843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 215:
						if (zoneChannelAssignment.Parent.Count == 5)
						{
							num = (short)515375309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1601896729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 216:
						goto IL_3954;
					case 217:
						this.a(ref dictionary7, 1);
						this.a(ref dictionary18, 2);
						num = (short)708313185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 218:
						goto IL_2049;
					case 219:
						if (dictionary21.Count <= 0)
						{
							num = (short)88342804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32EF;
					case 220:
						goto IL_461C;
					case 221:
						goto IL_3A8E;
					case 222:
						goto IL_4925;
					case 223:
						if (zoneChannelAssignment.Parent.Count == 4)
						{
							num = (short)803995810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1730805998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 224:
						num = (short)447807604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 225:
						if (num12 >= num25)
						{
							num = (short)1264582807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						recSet7 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields8 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet7.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num26.ToString();
						recSet7.RecNo = num26++.ToString();
						num = (short)1940652167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 226:
						goto IL_22F9;
					case 227:
						goto IL_2049;
					case 228:
						if (dictionary.Count > num3)
						{
							num = (short)1747517440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)486998048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 229:
						goto IL_4CA8;
					case 230:
						this.a(ref dictionary32, 1);
						this.a(ref dictionary30, 2);
						num = (short)1069875379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 231:
						goto IL_15E5;
					case 232:
						if (dictionary34.Count > 0)
						{
							num = (short)50921575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E73;
					case 233:
						goto IL_185C;
					case 234:
						goto IL_122B;
					case 235:
						goto IL_1576;
					case 236:
						if (dictionary2.Count <= 0)
						{
							num = (short)1054343508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6B;
					case 237:
						goto IL_461C;
					case 238:
						if (zoneChannelAssignment.Parent.Count == 3)
						{
							num = (short)405471568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2117009471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 239:
						this.a(ref dictionary2, 3);
						this.a(ref dictionary25, 2);
						this.a(ref dictionary10, 1);
						num = (short)1048641778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 240:
						if (dictionary8.Count > num6)
						{
							num = (short)1312423984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields4, "");
						num = (short)1213333634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 241:
						table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ좖列삞쮢쒤즦잨캪솬\udcae", a_), cultureInfo);
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ슜횞얠", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ꒔좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꞔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꚔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꆔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꂔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꎔ좖킘\udf9a", a_), cultureInfo));
						dictionary19 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary16 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary24 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary26 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary27 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary28 = new global::System.Collections.Generic.Dictionary<int, string>();
						num = (short)1017118732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 242:
						goto IL_22F9;
					case 243:
						goto IL_198D;
					case 244:
						goto IL_169D;
					case 245:
						goto IL_122B;
					case 246:
						dictionary11.TryGetValue(num8, out a_9);
						this.a(ref uifields6, a_9);
						num = (short)1278672909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 247:
						if (zoneChannelAssignment.Parent.Count >= 3)
						{
							num = (short)1995899093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)359268546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 248:
						dictionary5.TryGetValue(num7, out a_8);
						this.a(ref uifields5, a_8);
						num = (short)1510146140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 249:
						if (dictionary28.Count > num12)
						{
							num = (short)85852312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields8, "");
						num = (short)842924365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 250:
						if (dictionary27.Count <= 0)
						{
							num = (short)1955987483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF8;
					case 251:
					{
						if (dictionary15.Count > 0)
						{
							num = (short)949878830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet8 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields9 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						int num27 = 0;
						recSet8.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num27.ToString();
						recSet8.RecNo = num27++.ToString();
						this.a(ref uifields9, "");
						this.a(ref uifields9, "");
						this.a(ref uifields9, "");
						uifields9.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
						uifields9.UIFieldDes = recSet8.RecNo;
						recSet8.UIFields.Add(uifields9);
						table.RecSet.Add(recSet8);
						RptXMLData.tables.Add(table);
						num = (short)661979295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 252:
						num = (short)59637916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 253:
						dictionary23.TryGetValue(num7, out a_8);
						this.a(ref uifields5, a_8);
						num = (short)1189675333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 254:
						if (dictionary20.Count <= 0)
						{
							num = (short)197722464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E77;
					case 255:
						goto IL_15E5;
					case 256:
						dictionary33.TryGetValue(num5, out a_5);
						this.a(ref uifields3, a_5);
						num = (short)282788084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 257:
						if (zoneChannelAssignment.Parent.Count != 5)
						{
							num = (short)244711761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B1C;
					case 258:
						goto IL_21FF;
					case 259:
						table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ좖列삞쮢쒤즦잨캪솬\udcae", a_), cultureInfo);
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ슜횞얠", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꎔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꂔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꆔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꚔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꞔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ꒔좖킘\udf9a", a_), cultureInfo));
						dictionary8 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary17 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary31 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary12 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary9 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary4 = new global::System.Collections.Generic.Dictionary<int, string>();
						num = (short)1624702986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 260:
						if (dictionary16.Count > num12)
						{
							num = (short)1456275515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields8, "");
						num = (short)1757020217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 261:
						num = (short)2068578581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 262:
						goto IL_3A63;
					case 263:
						this.a(ref dictionary20, 1);
						this.a(ref dictionary3, 2);
						this.a(ref dictionary33, 3);
						num = (short)123994339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 264:
						goto IL_D44;
					case 265:
						goto IL_461C;
					case 266:
						goto IL_1D42;
					case 267:
						goto IL_3B2F;
					case 268:
						goto IL_198D;
					case 269:
						goto IL_916;
					case 270:
						dictionary6.TryGetValue(num4, out a_3);
						this.a(ref uifields2, a_3);
						num = (short)1774846030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 271:
						goto IL_1AD2;
					case 272:
						if (dictionary3.Count <= 0)
						{
							num = (short)1607336255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E77;
					case 273:
						goto IL_3B73;
					case 274:
						goto IL_916;
					case 275:
						goto IL_40F6;
					case 276:
						num = (short)1665401183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 277:
						if (!global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
						{
							num = (short)946339879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1904345400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 278:
						if (dictionary23.Count <= 0)
						{
							num = (short)1779106112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32EF;
					case 279:
						goto IL_4993;
					case 280:
						goto IL_D44;
					case 281:
						if (zoneChannelAssignment.Parent.Count == 4)
						{
							num = (short)116326587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)131727544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 282:
						if (zoneChannelAssignment.Parent.Count == 4)
						{
							num = (short)269811784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)235012406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 283:
						if (dictionary12.Count > num6)
						{
							num = (short)625672228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields4, "");
						num = (short)1185939794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 284:
						this.a(ref dictionary, 2);
						this.a(ref dictionary29, 1);
						num = (short)1604124940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 285:
						if (dictionary25.Count > num4)
						{
							num = (short)1192755367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields2, "");
						num = (short)1914634271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 286:
						goto IL_4878;
					case 287:
						this.a(ref dictionary13, 2);
						this.a(ref dictionary11, 1);
						num = (short)1395195942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 288:
						if (dictionary9.Count <= 0)
						{
							num = (short)786497788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E0;
					case 289:
						if (dictionary5.Count > 0)
						{
							num = (short)470548570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B20;
					case 290:
						if (zoneChannelAssignment.Parent.Count >= 3)
						{
							num = (short)427294866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1888026965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 291:
						goto IL_461C;
					case 292:
						this.a(ref dictionary17, 2);
						this.a(ref dictionary8, 1);
						num = (short)703005025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 293:
						dictionary35.TryGetValue(num4, out a_3);
						this.a(ref uifields2, a_3);
						num = (short)2131820572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 294:
						goto IL_506A;
					case 295:
						if (dictionary36.Count > num4)
						{
							num = (short)1143996731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields2, "");
						num = (short)1971519837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 296:
						if (dictionary13.Count > num8)
						{
							num = (short)1484914870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields6, "");
						num = (short)1877737644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 297:
						goto IL_10A9;
					case 298:
						table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ좖列삞쮢쒤즦잨캪솬\udcae", a_), cultureInfo);
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ슜횞얠", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꚔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꞔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ꒔좖킘\udf9a", a_), cultureInfo));
						dictionary29 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary34 = new global::System.Collections.Generic.Dictionary<int, string>();
						num = (short)1262092578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 299:
						if (zoneChannelAssignment.Parent.Count == 4)
						{
							num = (short)1696006474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1420951657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 300:
						goto IL_4E77;
					case 301:
						goto IL_4CA8;
					case 302:
						dictionary7.TryGetValue(num7, out a_8);
						this.a(ref uifields5, a_8);
						num = (short)1999437974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 303:
						goto IL_2174;
					case 304:
						num = (short)2138177597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 305:
						if (dictionary19.Count <= 0)
						{
							num = (short)882180164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF8;
					case 306:
						if (dictionary7.Count <= 0)
						{
							num = (short)2100822204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32EF;
					case 307:
						goto IL_233C;
					case 308:
						goto IL_22F9;
					case 309:
						if (zoneChannelAssignment.Parent.Count == 2)
						{
							num = (short)537985241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref dictionary7, 1);
						num = (short)459538587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 310:
						if (zoneChannelAssignment.Parent.Count <= 3)
						{
							num = (short)3145989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 311:
						if (dictionary21.Count > num7)
						{
							num = (short)304611485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields5, "");
						num = (short)781451522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 312:
						if (!isRightToLeft)
						{
							num = (short)1810497707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ좖列삞쮢쒤즦잨캪솬\udcae", a_), cultureInfo);
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ슜횞얠", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꚔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꞔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ꒔좖킘\udf9a", a_), cultureInfo));
						dictionary11 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary13 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary15 = new global::System.Collections.Generic.Dictionary<int, string>();
						num = (short)1812070745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 313:
						num = (short)1305673894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 314:
						if (isRightToLeft)
						{
							num = (short)647627050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						table.TableTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ좖列삞쮢쒤즦잨캪솬\udcae", a_), cultureInfo);
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ슜횞얠", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐ꒔좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꞔ좖킘\udf9a", a_), cultureInfo));
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힌ﾐꚔ좖킘\udf9a", a_), cultureInfo));
						dictionary32 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary30 = new global::System.Collections.Generic.Dictionary<int, string>();
						dictionary14 = new global::System.Collections.Generic.Dictionary<int, string>();
						num = (short)1736966391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 315:
						dictionary36.TryGetValue(num4, out a_3);
						this.a(ref uifields2, a_3);
						num = (short)1189806415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 316:
						if (dictionary25.Count <= 0)
						{
							num = (short)689700901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6B;
					case 317:
						goto IL_3597;
					case 318:
						if (zoneChannelAssignment.Parent.Count == 2)
						{
							num = (short)1410662479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref dictionary10, 1);
						num = (short)1492451554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 319:
						num = (short)660472020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 320:
						num = (short)1890910497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 321:
						goto IL_BD6;
					case 322:
						this.a(ref dictionary9, 5);
						this.a(ref dictionary12, 4);
						this.a(ref dictionary31, 3);
						this.a(ref dictionary17, 2);
						this.a(ref dictionary8, 1);
						num = (short)1708982315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 323:
						if (dictionary29.Count > num3)
						{
							num = (short)341835865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)389873791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 324:
						if (dictionary34.Count > num3)
						{
							num = (short)1004863668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields, "");
						num = (short)2005008402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 325:
						goto IL_1DA3;
					case 326:
						if (zoneChannelAssignment.Parent.Count >= 6)
						{
							num = (short)1312751690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2083586379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 327:
						if (zoneChannelAssignment.Parent.Count >= 3)
						{
							num = (short)1769799943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)973144198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 328:
						if (dictionary27.Count > num12)
						{
							num = (short)1659371608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields8, "");
						num = (short)176291979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 329:
						goto IL_6F7;
					case 330:
						this.a(ref dictionary19, 1);
						this.a(ref dictionary16, 2);
						this.a(ref dictionary24, 3);
						this.a(ref dictionary26, 4);
						num = (short)2068644071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 331:
						if (zoneChannelAssignment.Parent.Count == 5)
						{
							num = (short)1977221226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1410924620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 332:
						num = (short)802160890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 333:
						goto IL_2FE3;
					case 334:
						if (zoneChannelAssignment.Parent.Count == 5)
						{
							num = (short)515244354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)347930847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 335:
						goto IL_7CE;
					case 336:
						this.a(ref dictionary31, 3);
						this.a(ref dictionary17, 2);
						this.a(ref dictionary8, 1);
						num = (short)192544775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 337:
						num = (short)1623654682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 338:
						goto IL_2528;
					case 339:
						goto IL_113C;
					case 340:
						num = (short)1281491127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 341:
						if (zoneChannelAssignment.Parent.Count == 2)
						{
							num = (short)673841436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref dictionary29, 1);
						num = (short)484376819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 342:
						if (num4 >= num28)
						{
							num = (short)341311782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						recSet9 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						uifields2 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet9.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num29.ToString();
						recSet9.RecNo = num29++.ToString();
						num = (short)1934819590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 343:
						num = (short)171770134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 344:
						dictionary30.TryGetValue(num11, out a_7);
						this.a(ref uifields7, a_7);
						num = (short)139460819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 345:
						if (zoneChannelAssignment.Parent.Count >= 3)
						{
							num = (short)813760616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)442499273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 346:
						goto IL_198D;
					case 347:
						goto IL_1CA1;
					case 348:
						num = (short)2135621823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 349:
						goto IL_7CE;
					case 350:
						goto IL_3A8E;
					case 351:
						if (dictionary22.Count <= 0)
						{
							num = (short)743440727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32EF;
					case 352:
						num = (short)1897070864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 353:
						goto IL_4CA8;
					case 354:
						dictionary31.TryGetValue(num6, out a_4);
						this.a(ref uifields4, a_4);
						num = (short)589955270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 355:
						if (zoneChannelAssignment.Parent.Count < 6)
						{
							num = (short)1488191698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B1C;
					case 356:
						goto IL_16FE;
					case 357:
						dictionary19.TryGetValue(num12, out a_6);
						this.a(ref uifields8, a_6);
						num = (short)929497249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 358:
						goto IL_1102;
					case 359:
						if (dictionary28.Count > 0)
						{
							num = (short)1303314449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BB3;
					case 360:
						if (dictionary26.Count > num12)
						{
							num = (short)1995440270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(ref uifields8, "");
						num = (short)1529610514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DB;
					IL_657:
					num = (short)1861877988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F7:
					num = (short)717160544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_737:
					num = (short)2070675520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77E:
					recSet4 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					num19 = this.a(dictionary29, dictionary, dictionary34);
					num20 = 1;
					a_2 = null;
					num3 = 0;
					num = (short)1316225050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7CE:
					num = (short)223740057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D2:
					num = (short)780468332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_916:
					num = (short)1804009800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E4:
					uifields4.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
					uifields4.UIFieldDes = recSet6.RecNo;
					recSet6.UIFields.Add(uifields4);
					table.RecSet.Add(recSet6);
					num6++;
					num = (short)88342569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB3:
					num = (short)1329463340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AF8:
					recSet7 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					uifields8 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					num25 = this.a(dictionary19, dictionary16, dictionary24, dictionary26, dictionary27, dictionary28);
					num26 = 1;
					a_6 = null;
					num12 = 0;
					num = (short)365232401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BD6:
					uifields5.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
					uifields5.UIFieldDes = recSet2.RecNo;
					recSet2.UIFields.Add(uifields5);
					table.RecSet.Add(recSet2);
					num7++;
					num = (short)2042495145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D44:
					num = (short)795213997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_106F:
					num = (short)119472269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1102:
					num = (short)465043593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_122B:
					num = (short)815857949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1576:
					num = (short)1762394183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E5:
					num = (short)504299825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_169D:
					uifields3.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
					uifields3.UIFieldDes = recSet5.RecNo;
					recSet5.UIFields.Add(uifields3);
					table.RecSet.Add(recSet5);
					num5++;
					num = (short)462815440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16FE:
					num = (short)1071513849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1742:
					num = (short)1890451652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_185C:
					num = (short)1274609694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_198D:
					num = (short)1217986673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A99:
					num = (short)856621182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B1C:
					num = (short)1903296690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B6B:
					recSet9 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					uifields2 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					num28 = this.a(dictionary10, dictionary25, dictionary2, dictionary36, dictionary6, dictionary35);
					num29 = 1;
					a_3 = null;
					num4 = 0;
					num = (short)108986451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BDD:
					num = (short)544211204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CA1:
					num = (short)660930800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D42:
					uifields2.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
					uifields2.UIFieldDes = recSet9.RecNo;
					recSet9.UIFields.Add(uifields2);
					table.RecSet.Add(recSet9);
					num4++;
					num = (short)950403271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DA3:
					num = (short)555089936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2049:
					num = (short)1759903998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2131:
					num = (short)1488847171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2174:
					num = (short)1712979977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21FF:
					num = (short)1537212539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22F9:
					num = (short)428933258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_233C:
					num = (short)884604929;
					if (num != 0)
					{
					}
					num = (short)15925608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24E0:
					recSet6 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					uifields4 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					num23 = this.a(dictionary8, dictionary17, dictionary31, dictionary12, dictionary9, dictionary4);
					num24 = 1;
					a_4 = null;
					num6 = 0;
					num = (short)499253384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2528:
					num = (short)1614807198;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2760:
					num = (short)920715330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE3:
					uifields8.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
					uifields8.UIFieldDes = recSet7.RecNo;
					recSet7.UIFields.Add(uifields8);
					table.RecSet.Add(recSet7);
					num12++;
					num = (short)1395916932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3160:
					num = (short)630456616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A63:
					if (dictionary35.Count > num4)
					{
						num = (short)467271973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a(ref uifields2, "");
					num = (short)376307947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32EF:
					recSet2 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					uifields5 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					num14 = this.a(dictionary7, dictionary18, dictionary21, dictionary22, dictionary23, dictionary5);
					num15 = 1;
					a_8 = null;
					num7 = 0;
					num = (short)2141388802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3339:
					uifields7.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
					uifields7.UIFieldDes = recSet3.RecNo;
					recSet3.UIFields.Add(uifields7);
					table.RecSet.Add(recSet3);
					num11++;
					num = (short)157614409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3597:
					uifields6.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
					uifields6.UIFieldDes = recSet.RecNo;
					recSet.UIFields.Add(uifields6);
					table.RecSet.Add(recSet);
					num8++;
					num = (short)1003487582;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3808:
					num = (short)2048720931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3954:
					uifields.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
					uifields.UIFieldDes = recSet4.RecNo;
					recSet4.UIFields.Add(uifields);
					table.RecSet.Add(recSet4);
					num3++;
					num = (short)552206499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A8E:
					num = (short)1901723688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B2F:
					num = (short)830341240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B73:
					num = (short)178979041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E4D:
					num = (short)1510670443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40F6:
					num = (short)2108948763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_413B:
					num = (short)941096989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4510:
					recSet3 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					uifields7 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					num17 = this.a(dictionary32, dictionary30, dictionary14);
					num18 = 1;
					a_7 = null;
					num11 = 0;
					num = (short)1542652004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_461C:
					num = (short)1681195314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4878:
					num = (short)1620967735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4925:
					num = (short)2100691088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4993:
					num = (short)1163854119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AAC:
					num = (short)967508030;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CA8:
					num = (short)1807876120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E77:
					recSet5 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					uifields3 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					num21 = this.a(dictionary20, dictionary3, dictionary33);
					num22 = 1;
					a_5 = null;
					num5 = 0;
					num = (short)2053898598;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F7C:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					uifields6 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					num9 = this.a(dictionary11, dictionary13, dictionary15);
					num10 = 1;
					a_9 = null;
					num8 = 0;
					num = (short)1714749661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5030:
					num = (short)764215638;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_732:
				RptXMLData.tables.Add(table);
				return;
				IL_C7D:
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet10 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields10 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int num30 = 0;
				recSet10.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num30.ToString();
				recSet10.RecNo = num30++.ToString();
				this.a(ref uifields10, "");
				this.a(ref uifields10, "");
				this.a(ref uifields10, "");
				uifields10.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
				uifields10.UIFieldDes = recSet10.RecNo;
				recSet10.UIFields.Add(uifields10);
				table.RecSet.Add(recSet10);
				RptXMLData.tables.Add(table);
				return;
				IL_10A9:
				RptXMLData.tables.Add(table);
				return;
				IL_113C:
				RptXMLData.tables.Add(table);
				return;
				IL_1AD2:
				RptXMLData.tables.Add(table);
				return;
				IL_1E73:
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet11 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields11 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int num31 = 0;
				recSet11.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num31.ToString();
				recSet11.RecNo = num31++.ToString();
				this.a(ref uifields11, "");
				this.a(ref uifields11, "");
				this.a(ref uifields11, "");
				uifields11.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
				uifields11.UIFieldDes = recSet11.RecNo;
				recSet11.UIFields.Add(uifields11);
				table.RecSet.Add(recSet11);
				RptXMLData.tables.Add(table);
				return;
				IL_2B20:
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet12 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields12 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int num32 = 0;
				recSet12.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num32.ToString();
				recSet12.RecNo = num32++.ToString();
				this.a(ref uifields12, "");
				this.a(ref uifields12, "");
				this.a(ref uifields12, "");
				this.a(ref uifields12, "");
				this.a(ref uifields12, "");
				this.a(ref uifields12, "");
				uifields12.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
				uifields12.UIFieldDes = recSet12.RecNo;
				recSet12.UIFields.Add(uifields12);
				table.RecSet.Add(recSet12);
				RptXMLData.tables.Add(table);
				return;
				IL_3099:
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet13 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields13 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int num33 = 0;
				recSet13.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num33.ToString();
				recSet13.RecNo = num33++.ToString();
				this.a(ref uifields13, "");
				this.a(ref uifields13, "");
				this.a(ref uifields13, "");
				uifields13.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
				uifields13.UIFieldDes = recSet13.RecNo;
				recSet13.UIFields.Add(uifields13);
				table.RecSet.Add(recSet13);
				RptXMLData.tables.Add(table);
				return;
				IL_37D8:
				return;
				IL_3AC8:
				RptXMLData.tables.Add(table);
				return;
				IL_3BAE:
				RptXMLData.tables.Add(table);
				return;
				IL_3BB3:
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet14 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields14 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int num34 = 0;
				recSet14.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num34.ToString();
				recSet14.RecNo = num34++.ToString();
				this.a(ref uifields14, "");
				this.a(ref uifields14, "");
				this.a(ref uifields14, "");
				this.a(ref uifields14, "");
				this.a(ref uifields14, "");
				this.a(ref uifields14, "");
				uifields14.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
				uifields14.UIFieldDes = recSet14.RecNo;
				recSet14.UIFields.Add(uifields14);
				table.RecSet.Add(recSet14);
				RptXMLData.tables.Add(table);
				return;
				IL_4AE7:
				RptXMLData.tables.Add(table);
				return;
				IL_4B78:
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet15 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields15 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int num35 = 0;
				recSet15.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num35.ToString();
				recSet15.RecNo = num35++.ToString();
				this.a(ref uifields15, "");
				this.a(ref uifields15, "");
				this.a(ref uifields15, "");
				this.a(ref uifields15, "");
				this.a(ref uifields15, "");
				this.a(ref uifields15, "");
				uifields15.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
				uifields15.UIFieldDes = recSet15.RecNo;
				recSet15.UIFields.Add(uifields15);
				table.RecSet.Add(recSet15);
				RptXMLData.tables.Add(table);
				return;
				IL_506A:
				RptXMLData.tables.Add(table);
				return;
				IL_509A:
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet16 = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields16 = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				int num36 = 0;
				recSet16.RecTitle = global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎌ﾐ쪔\ude96ﶘ", a_), cultureInfo) + num36.ToString();
				recSet16.RecNo = num36++.ToString();
				this.a(ref uifields16, "");
				this.a(ref uifields16, "");
				this.a(ref uifields16, "");
				this.a(ref uifields16, "");
				this.a(ref uifields16, "");
				this.a(ref uifields16, "");
				uifields16.UIFieldName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﶒﮔ햚ﲜ쒠", a_);
				uifields16.UIFieldDes = recSet16.RecNo;
				recSet16.UIFields.Add(uifields16);
				table.RecSet.Add(recSet16);
				RptXMLData.tables.Add(table);
				return;
				IL_5DB:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				cultureInfo = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				isRightToLeft = cultureInfo.TextInfo.IsRightToLeft;
				zoneChannelAssignment = null;
				zoneChannelAssignment = (global::AcpCommonLib.FeatureManager.GetFeature(2051)[0] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				num = (short)808911203;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0026845C File Offset: 0x0026665C
		private void a(ref global::System.Collections.Generic.Dictionary<int, string> A_0, short A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			short num3;
			for (;;)
			{
				IL_0A:
				int num2;
				switch (num)
				{
				case 0:
				{
					if (num2 >= zoneChannelAssignment.Channels.EmbeddedRecset.Count)
					{
						num3 = (short)490012676;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)zoneChannelAssignment.Channels.EmbeddedRecset[num2];
					num3 = (short)191430658;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
					goto IL_1FC;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					if (channelAssignmentListInner != null)
					{
						num3 = (short)512098316;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1FC;
				}
				case 3:
					goto IL_142;
				case 4:
					goto IL_185;
				case 5:
					if (zoneChannelAssignment != null)
					{
						num3 = (short)1993474057;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 6:
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num3 = (short)878575627;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)841220104;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = null;
					num2 = 0;
					num3 = (short)1727264819;
					short num4 = num3;
					num3 = (short)1229912115;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num3 = (short)1221001216;
						if (num3 != 0)
						{
						}
						num3 = (short)1818165251;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 8:
					if (zoneChannelAssignment.Channels.HasEmbeddedRecset)
					{
						num3 = (short)347668487;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 9:
					num3 = (short)1794310150;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					goto IL_142;
				case 11:
					return;
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					A_0.Add(num2, channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelName_A7659Value);
					channelAssignmentListInner = null;
					num3 = (short)1963851777;
					if (num3 != 0)
					{
					}
					num3 = (short)2085617665;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				}
				goto IL_44;
				IL_142:
				num3 = (short)832438272;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1FC:
				num2++;
				num3 = (short)189792266;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_185:
			num3 = (short)1647575040;
			short num5 = num3;
			return;
			IL_44:
			zoneChannelAssignment = null;
			zoneChannelAssignment = (global::AcpCommonLib.FeatureManager.GetFeature(2051)[(int)(A_1 - 1)] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num3 = (short)294584325;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00268730 File Offset: 0x00266930
		private int a(global::System.Collections.Generic.Dictionary<int, string> A_0, global::System.Collections.Generic.Dictionary<int, string> A_1, global::System.Collections.Generic.Dictionary<int, string> A_2)
		{
			short num = (short)440664065;
			if (num != 0)
			{
			}
			num = (short)1103544273;
			short num2 = num;
			num = (short)1853931473;
			switch (num2 == num)
			{
			}
			num = (short)884670464;
			if (num != 0)
			{
			}
			num = (short)1061683200;
			short num3 = num;
			return global::System.Math.Max(global::System.Math.Max(A_0.Count, A_1.Count), A_2.Count);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x002687F8 File Offset: 0x002669F8
		private int a(global::System.Collections.Generic.Dictionary<int, string> A_0, global::System.Collections.Generic.Dictionary<int, string> A_1, global::System.Collections.Generic.Dictionary<int, string> A_2, global::System.Collections.Generic.Dictionary<int, string> A_3, global::System.Collections.Generic.Dictionary<int, string> A_4, global::System.Collections.Generic.Dictionary<int, string> A_5)
		{
			short num = (short)1818099713;
			if (num != 0)
			{
			}
			num = (short)1170926662;
			short num2 = num;
			num = (short)639298630;
			switch (num2 == num)
			{
			}
			num = (short)1779040256;
			if (num != 0)
			{
			}
			num = (short)1187971072;
			short num3 = num;
			return global::System.Math.Max(global::System.Math.Max(global::System.Math.Max(global::System.Math.Max(global::System.Math.Max(A_0.Count, A_1.Count), A_2.Count), A_3.Count), A_4.Count), A_5.Count);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x002688E0 File Offset: 0x00266AE0
		public AddRadHandoutTablesFuncs()
		{
			int a_ = 7;
			this.a = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚉ", a_);
			base..ctor();
		}

		// Token: 0x04000DF0 RID: 3568
		private string a;
	}
}
