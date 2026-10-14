using System;
using System.Globalization;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.AcpXMLCoreEngineLib
{
	// Token: 0x0200022C RID: 556
	public class AddRadInfotablesFuncs : global::SpecialFeatures.AcpXMLCoreEngineLib.IAddRadInfotables
	{
		// Token: 0x06001C45 RID: 7237 RVA: 0x00268910 File Offset: 0x00266B10
		public void AddGeneral(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 4;
			short num = (short)878706688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::SpecialFeatures.AcpXMLCoreEngineLib._Value value;
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
				global::System.Globalization.CultureInfo culture;
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				for (;;)
				{
					IL_31:
					global::AcpCommonLib.IAcpField acpField;
					switch (num2)
					{
					case 0:
						goto IL_55D;
					case 1:
						if (radioInformation != null)
						{
							num = (short)1568735243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캆춈풊캌삎햐횒얔\udb96처\udc9a\udc9c펞", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1347354629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (acpField != null)
						{
							num = (short)788725761;
							if (num != 0)
							{
							}
							num = (short)1305608206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF;
					case 4:
						if (acpField != null)
						{
							num = (short)777322498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B8;
					case 5:
						goto IL_4B8;
					case 6:
					{
						if (acpField == null)
						{
							goto IL_55D;
						}
						num = (short)2086730898;
						short num3 = num;
						num = (short)1932000402;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)44892160;
							if (num != 0)
							{
							}
							num = (short)841089034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_176;
					case 8:
						if (acpField != null)
						{
							num = (short)2055405577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					case 9:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캆춈풊\ude8c쪎쎐\uda92풔\udb96힘캚킜\udd9e", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1177026567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욆", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("랆", a_);
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캆춈풊삌삎햐횒\ud994\ud996처횚\udf9c\uda9e", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)586743808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆ﶎﾒ\udd94ﺖﶘﾚ", a_);
						table.ColTitle.Add(global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캆춈풊쪌쪎\udf90횒잔횖햘", a_), culture));
						acpField = null;
						acpField = radioInformation.General.RadInfoGeneralModelNumber_A8539;
						num = (short)209190918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return;
					case 13:
					{
						num = (short)1628700672;
						short num4 = num;
						goto IL_EF;
					}
					case 14:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캆춈풊쮌쎎킐삒\udd94풖횘\udf9a\ud89c", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)161808397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_74;
					IL_EF:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뒆", a_);
					acpField = radioInformation.General.RadInfoGeneralCodeplugAlias_A7684;
					num = (short)502333444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_176:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒆", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("떆", a_);
					acpField = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132;
					num = (short)154075139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B8:
					RptXMLData.tables.Add(table);
					num = (short)155385868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55D:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얆", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚆", a_);
					acpField = radioInformation.General.RadInfoGeneralSerialNumber_A9122;
					num = (short)1257504776;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_74:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
				uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				culture = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				radioInformation = null;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)2003238913;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00268F04 File Offset: 0x00267104
		public void AddTracking(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 5;
			short num = (short)2068971520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8D;
				}
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				string text2;
				for (;;)
				{
					IL_32:
					global::SpecialFeatures.AcpXMLCoreEngineLib._Value value;
					string text;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					global::System.Globalization.CultureInfo culture;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					global::AcpCommonLib.IAcpField acpField;
					switch (num2)
					{
					case 0:
						value.FieldValue = text;
						uifields.values.Add(value);
						uifields.UIFieldName = radioInformation.Tracking.RadInfoLabtoolBornOnDateDBValue_A7568.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솇캉펋속슏\udb91펓\udf95횗\udb99킛캝ﮱ荒ﾽ钿证诃装談藉黋胍鿏鳑胓鿕闗鿙鷛郝ꓟꛡꗣ닥귧", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)351666194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (text2 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_))
						{
							num = (short)1131347974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BB;
					case 2:
						if (acpField != null)
						{
							num = (short)528613380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_168;
					case 3:
					{
						string text3;
						value.FieldValue = text3;
						uifields.values.Add(value);
						uifields.UIFieldName = radioInformation.Tracking.RadInfoLabtoolLastProgrammedDateDBValue_A8411.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솇캉펋슍톏솑삓욕쪗햙\udb9b첝ﾯ靈貿菁韃鋅飇飉菋觍苏鏑駓鯕鷗黙裛韝귟꟡ꗣ꣥곧껩귫뫭뗯", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1239111160;
						short num3 = num;
						num = (short)1871271416;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_31B;
						default:
							num = (short)1245577216;
							if (num != 0)
							{
							}
							num = (short)281935891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솇캉펋슍톏솑삓욕쪗햙\udb9b첝ﾯ靈鎿跁釃铅诇迉", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)89194503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솇캉펋속슏\udb91펓\udf95횗\udb99킛캝ﮱ荒ﾽ钿证诃装诇藉裋词胏黑臓釕軗鿙軛距꧟귡ꫣ", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)2114781201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆋ얍잏", a_);
						num = (short)1821442061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_168;
					case 8:
						if (radioInformation != null)
						{
							num = (short)2037317647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						return;
					case 10:
					{
						string text3;
						if (text3 != null)
						{
							goto IL_31B;
						}
						goto IL_78C;
					}
					case 11:
						num = (short)2094006273;
						if (num != 0)
						{
						}
						if (text != null)
						{
							num = (short)1342898176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					case 12:
						if (acpField != null)
						{
							num = (short)746389509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					case 13:
						goto IL_3BB;
					case 14:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솇캉펋속슏\udb91펓\udf95횗\udb99킛캝ﮱ荒ﾽ钿证诃装鯇藉駋鳍鏏韑", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1820983316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc87ﮏﮑ望킗瞧얟첡", a_);
						table.ColTitle.Add(global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솇캉펋\uda8d슏펑힓\udd95톗풙\udb9b", a_), culture));
						acpField = null;
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						acpField = null;
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("즇", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릇", a_);
						long value2 = radioInformation.Tracking.RadInfoLabtoolLastProgrammedDateDBValue_A8411.Value;
						string text3 = (string)radioInformation.Tracking.RadInfoLabtoolLastProgrammedDateDBValue_A8411.Converter.Convert(value2, null, null, culture);
						num = (short)690028554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (acpField != null)
						{
							num = (short)896466958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A1;
					case 17:
						goto IL_620;
					case 18:
						goto IL_416;
					case 19:
						goto IL_78C;
					case 20:
						goto IL_4A1;
					}
					goto IL_8D;
					IL_168:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮇", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뮇", a_);
					long value3 = radioInformation.Tracking.RadInfoLabtoolBornOnDateDBValue_A7568.Value;
					text = (string)radioInformation.Tracking.RadInfoLabtoolBornOnDateDBValue_A7568.Converter.Convert(value3, null, null, culture);
					num = (short)233439243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31B:
					num = (short)1702559747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BB:
					culture = new global::System.Globalization.CultureInfo(text2);
					radioInformation = null;
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)351469576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_416:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첇", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("벇", a_);
					acpField = radioInformation.Tracking.RadInfoTrackingCodeplugVersion_A7688;
					num = (short)1006698508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A1:
					RptXMLData.tables.Add(table);
					num = (short)1150025737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_620:
					num = (short)1132789760;
					short num4 = num;
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춇", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붇", a_);
					acpField = radioInformation.Tracking.RadInfoTrackingSource2_A8625;
					num = (short)1434648592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_78C:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪇", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("몇", a_);
					acpField = radioInformation.Tracking.RadInfoTrackingSource1_A9171;
					num = (short)261160962;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8D:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				text2 = global::AcpCommonLib.AppInfoManager.ReportsLangSelection;
				num = (short)1833631745;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0026972C File Offset: 0x0026792C
		public void AddFlashPort(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 14;
			short num = (short)1471676416;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::System.Globalization.CultureInfo culture;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				for (;;)
				{
					IL_31:
					global::AcpCommonLib.IAcpField acpField;
					global::SpecialFeatures.AcpXMLCoreEngineLib._Value value;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					switch (num2)
					{
					case 0:
						if (acpField != null)
						{
							num = (short)1098645510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CD;
					case 1:
						if (acpField != null)
						{
							num = (short)1888550913;
							if (num != 0)
							{
							}
							num = (short)28835845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A9;
					case 2:
						return;
					case 3:
						goto IL_461;
					case 4:
						if (radioInformation != null)
						{
							num = (short)246939656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
					{
						num = (short)2108162048;
						short num3 = num;
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔\udb96\ud898좚즜쪞ﺬ", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)626393097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔\ude96\udb98캚즜쮞", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						goto IL_209;
					case 7:
						if (acpField != null)
						{
							num = (short)393216010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_461;
					case 8:
					{
						table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힐ﾒ쮚햠첤쎦춨캪쎬", a_);
						table.ColTitle.Add(global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔톖햘\uda9a캜힞", a_), culture));
						acpField = null;
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						acpField = null;
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킐", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂐ", a_);
						acpField = radioInformation.FLASHport.RadInfoFLASHportNumberofTimesFlashed_A8581;
						num = (short)152313530;
						short num4 = num;
						num = (short)741088954;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_209;
						default:
							num = (short)495976448;
							if (num != 0)
							{
							}
							num = (short)1875574791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_2A9;
					case 10:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud890힒쪔\ud996처횚\udf9c\uda9eﲮﾲﺺ寮", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1671364611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_CD;
					}
					goto IL_68;
					IL_CD:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튐", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊐ", a_);
					acpField = radioInformation.FLASHport.RadInfoFLASHportLastUpgradeSource_A8387;
					num = (short)76873729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_209:
					num = (short)1754136587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A9:
					RptXMLData.tables.Add(table);
					num = (short)324993026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_461:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펐", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎐ", a_);
					acpField = radioInformation.FLASHport.RadInfoFLASHportIButton_A8217;
					num = (short)1839202304;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_68:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				culture = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				radioInformation = null;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)1928855556;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00269C24 File Offset: 0x00267E24
		public void AddVersion(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 3;
			short num = (short)1983709184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_30:
					global::SpecialFeatures.AcpXMLCoreEngineLib._Value value;
					global::AcpCommonLib.IAcpField acpField;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					switch (num2)
					{
					case 0:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)894828561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_3FC;
					case 2:
						goto IL_427;
					case 3:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1519190032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (radioInformation != null)
						{
							num = (short)1546190854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						if (acpField != null)
						{
							num = (short)127598603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_427;
					case 6:
					{
						table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킅ﾋﾏﲑ뒓\udf95ﲙ춟쎡킣쾥잧쒩貫\ud9af횱킳펵횷", a_);
						acpField = null;
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("입", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("랅", a_);
						acpField = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683;
						num = (short)445841408;
						short num3 = num;
						num = (short)1685913615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (acpField != null)
						{
							num = (short)246415360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_536;
					case 8:
						return;
					case 9:
					{
						num = (short)2040891643;
						short num4 = num;
						num = (short)2132904187;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_294;
						default:
							num = (short)473300992;
							if (num != 0)
							{
							}
							if (acpField != null)
							{
								num = (short)730464259;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_377;
						}
						break;
					}
					case 10:
						num = (short)1024655361;
						if (num != 0)
						{
						}
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)368115726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1319501826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (acpField != null)
						{
							num = (short)1374945293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FC;
					case 13:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						goto IL_294;
					case 14:
						goto IL_4AE;
					case 15:
						if (acpField != null)
						{
							num = (short)1991114762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AE;
					case 16:
						goto IL_377;
					case 17:
						goto IL_536;
					}
					goto IL_7F;
					IL_294:
					num = (short)1029308417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_377:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎅", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뎅", a_);
					acpField = radioInformation.General.RadInfoGeneralTuningVersion_A9509;
					num = (short)44826636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FC:
					RptXMLData.tables.Add(table);
					num = (short)64421896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_427:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얅", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("떅", a_);
					acpField = radioInformation.General.RadInfoGeneralFirmwareVersion_A8124;
					num = (short)539164679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AE:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒅", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뒅", a_);
					acpField = radioInformation.General.RadInfoGeneralDSPVersion_A7892;
					num = (short)1042087941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_536:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늅", a_);
					acpField = radioInformation.General.RadInfoGeneralUCMVersion_A9591;
					num = (short)591396873;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7F:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				radioInformation = null;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)1287258116;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0026A2A4 File Offset: 0x002684A4
		public void AddFeatures(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			short num = (short)2106640022;
			short num2 = num;
			num = (short)1029686934;
			switch (num2 == num)
			{
			}
			num = (short)1101135872;
			short num3 = num;
			num = (short)1308753920;
			if (num != 0)
			{
			}
			num = (short)855769089;
			if (num != 0)
			{
			}
		}
	}
}
