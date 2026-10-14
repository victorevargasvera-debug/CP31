using System;
using System.Collections.Generic;
using System.Globalization;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.AcpXMLCoreEngineLib;
using SpecialFeatures.Flashport;
using SpecialFeatures.RadioFeatureSet;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x0200023D RID: 573
	public class BaseRadioInfoXMLCoreEngine : global::SpecialFeatures.ACPXMLCoreEngineLib.AcpBaseXMLCoreEngine
	{
		// Token: 0x06001CC0 RID: 7360 RVA: 0x0027D294 File Offset: 0x0027B494
		protected virtual void AddGeneral(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 1;
			short num = (short)2082734080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::SpecialFeatures.AcpXMLCoreEngineLib._Value value;
				global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
				global::System.Globalization.CultureInfo culture;
				global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_30:
						global::AcpCommonLib.IAcpField acpField;
						switch (num2)
						{
						case 0:
							goto IL_53A;
						case 1:
							value.FieldValue = acpField.ToString();
							uifields.values.Add(value);
							uifields.UIFieldName = acpField.Name;
							uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇\ud989즋\udc8d\ud98f펑\ud893\ud895춗힙\ude9b\udb9d", a_), culture);
							recSet.UIFields.Add(uifields);
							table.RecSet.Add(recSet);
							num = (short)1523253258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_495;
						case 3:
						{
							num = (short)819296309;
							short num3 = num;
							num = (short)983595061;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_B1;
							default:
								num = (short)952172544;
								if (num != 0)
								{
								}
								recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얃", a_);
								recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뒃", a_);
								value.FieldValue = acpField.ToString();
								uifields.values.Add(value);
								uifields.UIFieldName = acpField.Name;
								uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇잉쎋쪍햏\ude91\uda93쎕햗\ud899\ud99b첝", a_), culture);
								recSet.UIFields.Add(uifields);
								table.RecSet.Add(recSet);
								num = (short)696123392;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							value.FieldValue = acpField.ToString();
							uifields.values.Add(value);
							uifields.UIFieldName = acpField.Name;
							uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇첉삋쾍쎏\uda91힓\ud995\udc97\udf99", a_), culture);
							recSet.UIFields.Add(uifields);
							table.RecSet.Add(recSet);
							num = (short)187695116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							return;
						case 6:
							table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎃ﺋﲏ\uda91ﶓﲗﾙ", a_);
							table.ColTitle.Add(global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇춉즋삍햏삑햓\uda95", a_), culture));
							acpField = null;
							acpField = radioInformation.General.RadInfoGeneralModelNumber_A8539;
							num = (short)1670840331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (acpField != null)
							{
								num = (short)246480905;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_495;
						case 8:
							if (acpField != null)
							{
								num = (short)623771652;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EE;
						case 9:
							num = (short)1383464961;
							if (num != 0)
							{
							}
							value.FieldValue = acpField.ToString();
							uifields.values.Add(value);
							uifields.UIFieldName = acpField.Name;
							uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춃슅힇즉쎋쪍햏슑\ud893쎕\udf97\udb99킛힝", a_), culture);
							recSet.UIFields.Add(uifields);
							table.RecSet.Add(recSet);
							num = (short)700907522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_19C;
						case 11:
							if (acpField != null)
							{
								num = (short)1449132035;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_53A;
						case 12:
							goto IL_EE;
						case 13:
							if (radioInformation != null)
							{
								num = (short)1873674246;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 14:
							if (acpField != null)
							{
								num = (short)785186817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19C;
						}
						goto IL_73;
						IL_EE:
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						acpField = null;
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삃", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("랃", a_);
						acpField = radioInformation.General.RadInfoGeneralCodeplugAlias_A7684;
						num = (short)300613639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19C:
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						acpField = null;
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잃", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚃", a_);
						acpField = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132;
						num = (short)1187184648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_495:
						RptXMLData.tables.Add(table);
						num = (short)1792606213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_53A:
						num = (short)242417664;
						short num4 = num;
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						acpField = null;
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욃", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("떃", a_);
						acpField = radioInformation.General.RadInfoGeneralSerialNumber_A9122;
						num = (short)1220083726;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
				}
				IL_73:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
				value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
				uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
				culture = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				radioInformation = null;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				IL_B1:
				num = (short)1388904461;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0027D88C File Offset: 0x0027BA8C
		protected virtual void AddTracking(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 19;
			short num = (short)233242624;
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
					global::AcpCommonLib.IAcpField acpField;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::System.Globalization.CultureInfo culture;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					string text3;
					switch (num2)
					{
					case 0:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙킛\udf9dﺫﶯﾱ請銿迁藃鋅臇藉苋鷍鿏蟑蛓闕鷗", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)135331857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						string text;
						if (text != null)
						{
							num = (short)1841496072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_763;
					}
					case 2:
						goto IL_763;
					case 3:
					{
						table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슕ﮙﾛ즟첡쎣솧캩좫쮭\udeaf", a_);
						table.ColTitle.Add(global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙좛첝", a_), culture));
						acpField = null;
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						acpField = null;
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힕", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꞕ", a_);
						long value2 = radioInformation.Tracking.RadInfoLabtoolLastProgrammedDateDBValue_A8411.Value;
						string text = (string)radioInformation.Tracking.RadInfoLabtoolLastProgrammedDateDBValue_A8411.Converter.Convert(value2, null, null, culture);
						num = (short)929890305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_5AE;
					case 5:
						if (acpField != null)
						{
							num = (short)1126957074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47B;
					case 6:
						return;
					case 7:
						if (text2 == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_))
						{
							num = (short)1302790163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_395;
					case 8:
					{
						string text;
						value.FieldValue = text;
						uifields.values.Add(value);
						uifields.UIFieldName = radioInformation.Tracking.RadInfoLabtoolLastProgrammedDateDBValue_A8411.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙킛\udf9dﺫﶯﾱ請銿迁藃鋅臇藉苋苍量臑胓蛕諗闙鯛賝ꇟ꿡ꧣꏥ곧뻩ꗫꏭ뗯돱뫳답볷믹ꣻ믽", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1560543234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙펛첝ﲫﲭﾯ僚諾覿賁苃觅髇蟉跋髍駏鷑髓闕韗黙駛軝곟럡ꏣ냥귧룩뿫꟭뿯볱", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)34209796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (acpField != null)
						{
							num = (short)1088815113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AE;
					case 11:
						if (radioInformation != null)
						{
							num = (short)961937411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						goto IL_3F0;
					case 13:
						if (text3 != null)
						{
							num = (short)788660239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					case 14:
						goto IL_47B;
					case 15:
					{
						num = (short)240606690;
						short num3 = num;
						num = (short)1998413282;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_312;
						case 1:
							break;
						default:
						{
							num = (short)171966464;
							short num4 = num;
							break;
						}
						}
						num = (short)1164967936;
						if (num != 0)
						{
						}
						value.FieldValue = text3;
						uifields.values.Add(value);
						uifields.UIFieldName = radioInformation.Tracking.RadInfoLabtoolBornOnDateDBValue_A7568.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙펛첝ﲫﲭﾯ僚諾覿賁苃觅髇蟉跋髍駏鷑髓铕韗裙鋛針껟뛡귣ꯥ귧ꯩꋫꫭ듯돱ꃳ돵", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1160183820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_395;
					case 17:
						goto IL_167;
					case 18:
						goto IL_312;
					case 19:
						text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("랙힛증", a_);
						num = (short)1564737552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1380122625;
						if (num != 0)
						{
						}
						if (acpField != null)
						{
							num = (short)1205534720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					}
					goto IL_8D;
					IL_167:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햕", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖕ", a_);
					long value3 = radioInformation.Tracking.RadInfoLabtoolBornOnDateDBValue_A7568.Value;
					text3 = (string)radioInformation.Tracking.RadInfoLabtoolBornOnDateDBValue_A7568.Converter.Convert(value3, null, null, culture);
					num = (short)231473165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_312:
					value.FieldValue = acpField.ToString();
					uifields.values.Add(value);
					uifields.UIFieldName = acpField.Name;
					uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf95\udc97얙펛첝ﲫﲭﾯ僚諾覿賁苃觅髇蟉跋髍駏鷑髓藕韗这軛鷝ꗟ", a_), culture);
					recSet.UIFields.Add(uifields);
					table.RecSet.Add(recSet);
					num = (short)1879703566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_395:
					culture = new global::System.Globalization.CultureInfo(text2);
					radioInformation = null;
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)1781334027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F0:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊕ", a_);
					acpField = radioInformation.Tracking.RadInfoTrackingCodeplugVersion_A7688;
					num = (short)1627848714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47B:
					RptXMLData.tables.Add(table);
					num = (short)385679366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AE:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펕", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎕ", a_);
					acpField = radioInformation.Tracking.RadInfoTrackingSource2_A8625;
					num = (short)879820805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_763:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풕", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("꒕", a_);
					acpField = radioInformation.Tracking.RadInfoTrackingSource1_A9171;
					num = (short)901185556;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8D:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				text2 = global::AcpCommonLib.AppInfoManager.ReportsLangSelection;
				num = (short)466878471;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0027E0B0 File Offset: 0x0027C2B0
		protected virtual void AddFlashPort(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 9;
			short num = (short)737476608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				global::System.Globalization.CultureInfo culture;
				global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_30:
					num = (short)2038431745;
					if (num != 0)
					{
					}
					global::SpecialFeatures.AcpXMLCoreEngineLib._Value value;
					global::AcpCommonLib.IAcpField acpField;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					switch (num2)
					{
					case 0:
					{
						num = (short)1952317440;
						short num3 = num;
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋쪍쾏\udb91횓쎕첗캙펛킝", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)155254789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (acpField != null)
						{
							num = (short)366477323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AD;
					case 2:
						goto IL_41C;
					case 3:
						goto IL_2AD;
					case 4:
						return;
					case 5:
						goto IL_F7;
					case 6:
						if (acpField != null)
						{
							num = (short)349044746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41C;
					case 7:
					{
						num = (short)899153755;
						short num4 = num;
						num = (short)1084358491;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F2;
						default:
							num = (short)423165952;
							if (num != 0)
							{
							}
							if (acpField != null)
							{
								num = (short)643366912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F7;
						}
						break;
					}
					case 8:
						goto IL_F2;
					case 9:
						if (radioInformation != null)
						{
							num = (short)1060700168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋쪍쾏\udc91솓\udb95\uda97\udf99캛톝囹ﲳﲷ", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1679360002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋쪍쾏\ude91햓얕첗쾙첛\ud99dﮧ嶺ﲭ", a_), culture);
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1668415491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_90;
					IL_F2:
					table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪋ﲓ욕횝즟욡삣쎥욧", a_);
					table.ColTitle.Add(global::CommonResources.AcgResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얋쪍쾏풑\ud893힕쮗튙첛톝", a_), culture));
					acpField = null;
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춋", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붋", a_);
					acpField = radioInformation.FLASHport.RadInfoFLASHportNumberofTimesFlashed_A8581;
					num = (short)1803419654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F7:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾋", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾋", a_);
					acpField = radioInformation.FLASHport.RadInfoFLASHportLastUpgradeSource_A8387;
					num = (short)1596850177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AD:
					RptXMLData.tables.Add(table);
					num = (short)518258692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41C:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캋", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺋", a_);
					acpField = radioInformation.FLASHport.RadInfoFLASHportIButton_A8217;
					num = (short)1141440519;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_90:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				culture = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				radioInformation = null;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)358678537;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0027E5B4 File Offset: 0x0027C7B4
		protected void AddFeatureSet(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 15;
			short num = (short)2112421888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				global::System.Globalization.CultureInfo culture;
				global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet pageRadioFeatureSet;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FeatureNode> enumerator;
					int num3;
					global::SpecialFeatures.AcpXMLCoreEngineLib._table table;
					global::SpecialFeatures.RadioFeatureSet.RadioFeatureSet radioFeatureSet;
					int num4;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1779236866;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_493;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)325976067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Flashport.FeatureNode featureNode = enumerator.Current;
									string extendedFeatureSetFeatureNameValue = (featureNode as global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInner).ExtendedFeatureSetInnerSection.ExtendedFeatureSetFeatureNameValue;
									string extendedFeatureSetEnabledValue = (featureNode as global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInner).ExtendedFeatureSetInnerSection.ExtendedFeatureSetEnabledValue;
									base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
									base.rptRec.RecTitle = num3++.ToString();
									base.rptRec.RecNo = num3.ToString();
									base.rptValue = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
									this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
									this.rptFields.UIFieldDes = extendedFeatureSetFeatureNameValue;
									base.rptValue.FieldValue = extendedFeatureSetEnabledValue;
									this.rptFields.values.Add(base.rptValue);
									this.rptFields.UIFieldName = extendedFeatureSetFeatureNameValue;
									base.rptRec.UIFields.Add(this.rptFields);
									table.RecSet.Add(base.rptRec);
									num = (short)1085407236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_33F;
									}
									continue;
								case 3:
									num = (short)424607744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_43D:
								num = (short)1833697281;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_33F:
								goto IL_43D;
							}
							IL_493:
							goto IL_1EE;
						}
						finally
						{
							num = (short)1208745986;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_503;
								case 1:
									enumerator.Dispose();
									num = (short)1279328256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4CB;
									}
									continue;
								}
								IL_4CB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1084424193;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_503:;
						}
						goto Block_5;
						IL_1EE:
						RptXMLData.tables.Add(table);
						num = (short)309329929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::SpecialFeatures.Flashport.FeatureNode featureNode2;
						radioFeatureSet = (featureNode2 as global::SpecialFeatures.RadioFeatureSet.RadioFeatureSet);
						table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
						table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풑ﮝ잡킣솧캩좫쮭\udeaf", a_);
						table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﮓﶗ잟ﶡ쎥즧\udea9\ud9ab\udcad햯펵첷", a_), culture));
						num3 = 0;
						enumerator = radioFeatureSet.FeatureSet.EmbeddedRecset.GetEnumerator();
						num = (short)1951989764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						if (num4 >= pageRadioFeatureSet.FeatSetRecSet.Count)
						{
							num = (short)773193734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Flashport.FeatureNode featureNode2 = pageRadioFeatureSet.FeatSetRecSet[num4];
						num = (short)1048444938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_217;
					case 4:
					{
						num = (short)1614413824;
						short num5 = num;
						goto IL_506;
					}
					case 5:
						goto IL_217;
					case 6:
						return;
					case 7:
						num4 = 0;
						num = (short)1249640453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1209204737;
						if (num != 0)
						{
						}
						if (pageRadioFeatureSet.FeatSetRecSet != null)
						{
							num = (short)2077294599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						goto IL_1B0;
					case 10:
					{
						global::SpecialFeatures.Flashport.FeatureNode featureNode2;
						if (featureNode2 is global::SpecialFeatures.RadioFeatureSet.RadioFeatureSet)
						{
							num = (short)1494810625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B0;
					}
					}
					goto IL_64;
					Block_5:
					try
					{
						IL_506:
						num = (short)782499842;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_694;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)84279299;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.Flashport.FeatureNode featureNode3 = enumerator.Current;
								string featureSetPurchasedFeatureNameValue = (featureNode3 as global::SpecialFeatures.RadioFeatureSet.FeatureSetInner).FeatureSetInnerSection.FeatureSetPurchasedFeatureNameValue;
								string featureSetEnabledInUsedFlashcodeValue = (featureNode3 as global::SpecialFeatures.RadioFeatureSet.FeatureSetInner).FeatureSetInnerSection.FeatureSetEnabledInUsedFlashcodeValue;
								base.rptRec = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
								base.rptRec.RecTitle = num3++.ToString();
								base.rptRec.RecNo = num3.ToString();
								base.rptValue = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
								this.rptFields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
								this.rptFields.UIFieldDes = featureSetPurchasedFeatureNameValue;
								base.rptValue.FieldValue = featureSetEnabledInUsedFlashcodeValue;
								this.rptFields.values.Add(base.rptValue);
								this.rptFields.UIFieldName = featureSetPurchasedFeatureNameValue;
								base.rptRec.UIFields.Add(this.rptFields);
								table.RecSet.Add(base.rptRec);
								num = (short)1051983876;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_540;
								}
								continue;
							case 3:
								num = (short)947322880;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_63D:
							num = (short)1685323777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_540:
							goto IL_63D;
						}
						IL_694:
						goto IL_DD;
					}
					finally
					{
						num = (short)1533542402;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							IL_6B9:
							switch (num2)
							{
							case 0:
								goto IL_758;
							case 1:
								enumerator.Dispose();
								num = (short)689504256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_6CC;
								}
								continue;
							}
							IL_6CC:
							while (enumerator != null)
							{
								num = (short)1350382570;
								short num6 = num;
								num = (short)1645884394;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)494993408;
									if (num != 0)
									{
									}
									num = (short)373030913;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_6B9;
								}
							}
							break;
						}
						IL_758:;
					}
					break;
					IL_DD:
					RptXMLData.tables.Add(table);
					table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
					table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑ﶗﮝ쒟솣장\udca7\udfa9\udeab쮭ힱ삳ﺵ톷\udeb9\ud8bb\udbbd꺿", a_);
					table.ColTitle.Add(global::CommonResources.AppResources.ResourceManager.GetString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑ﶗﮝ쒟ﶡ쎥즧\udea9\ud9ab\udcad햯펵첷", a_), culture));
					num3 = 0;
					enumerator = radioFeatureSet.ExtendedFeatureSet.EmbeddedRecset.GetEnumerator();
					num = (short)458358784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B0:
					num4++;
					num = (short)767361027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_217:
					num = (short)551354370;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_64:
				culture = new global::System.Globalization.CultureInfo(global::AcpCommonLib.AppInfoManager.ReportsLangSelection);
				pageRadioFeatureSet = new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet();
				num = (short)1509425160;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0027ED50 File Offset: 0x0027CF50
		protected virtual void AddVersion(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			int a_ = 15;
			short num = (short)1289748480;
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
					global::AcpCommonLib.IAcpField acpField;
					global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet recSet;
					global::SpecialFeatures.AcpXMLCoreEngineLib._Value value;
					global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields uifields;
					switch (num2)
					{
					case 0:
						table.TableTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒑肟쪣삥잧\ud8a9솫쾭쒯\udbb1\udbb3\ud8b5颷햻\udabd꒿ꟁ꫃", a_);
						acpField = null;
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펑", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎑ", a_);
						acpField = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683;
						num = (short)1580007431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (acpField != null)
						{
							num = (short)1387724810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_349;
					case 2:
						return;
					case 3:
						if (acpField != null)
						{
							num = (short)1988493328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_505;
					case 4:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						goto IL_1FF;
					case 5:
						goto IL_47E;
					case 6:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)1791754257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (acpField != null)
						{
							num = (short)662568964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47E;
					case 8:
						goto IL_3F7;
					case 9:
						if (acpField != null)
						{
							num = (short)2098987021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F7;
					case 10:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)331218958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (acpField != null)
						{
							num = (short)401408006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CD;
					case 12:
						goto IL_505;
					case 13:
					{
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)860618752;
						short num3 = num;
						num = (short)1951334408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_349;
					case 15:
						if (radioInformation != null)
						{
							num = (short)199098368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						value.FieldValue = acpField.ToString();
						uifields.values.Add(value);
						uifields.UIFieldName = acpField.Name;
						uifields.UIFieldDes = acpField.UIName;
						recSet.UIFields.Add(uifields);
						table.RecSet.Add(recSet);
						num = (short)397017100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)904527873;
						if (num != 0)
						{
						}
						goto IL_3CD;
					}
					goto IL_7F;
					IL_1FF:
					num = (short)120258565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_505:
					num = (short)628424679;
					short num4 = num;
					num = (short)480444391;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1FF;
					default:
						num = (short)289079296;
						if (num != 0)
						{
						}
						recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
						value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
						uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
						acpField = null;
						recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑", a_);
						recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚑ", a_);
						acpField = radioInformation.General.RadInfoGeneralUCMVersion_A9591;
						num = (short)1106575361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_349:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꞑ", a_);
					acpField = radioInformation.General.RadInfoGeneralTuningVersion_A9509;
					num = (short)1925513227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CD:
					RptXMLData.tables.Add(table);
					num = (short)450887682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F7:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꆑ", a_);
					acpField = radioInformation.General.RadInfoGeneralFirmwareVersion_A8124;
					num = (short)1223294979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47E:
					recSet = new global::SpecialFeatures.AcpXMLCoreEngineLib._RecSet();
					value = new global::SpecialFeatures.AcpXMLCoreEngineLib._Value();
					uifields = new global::SpecialFeatures.AcpXMLCoreEngineLib._UIFields();
					acpField = null;
					recSet.RecTitle = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킑", a_);
					recSet.RecNo = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂑ", a_);
					acpField = radioInformation.General.RadInfoGeneralDSPVersion_A7892;
					num = (short)1791950857;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7F:
				table = new global::SpecialFeatures.AcpXMLCoreEngineLib._table();
				radioInformation = null;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)209059855;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0027F3CC File Offset: 0x0027D5CC
		protected virtual void AddFeatures(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData)
		{
			short num = (short)752478720;
			short num2 = num;
			num = (short)1662970368;
			switch (num2 == num)
			{
			}
			num = (short)1707081728;
			if (num != 0)
			{
			}
			num = (short)1649082369;
			if (num != 0)
			{
			}
			num = (short)1598750720;
			short num3 = num;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0027F478 File Offset: 0x0027D678
		public override void BuildDataTables(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData XMLRptDataObj)
		{
			short num = (short)2127550261;
			short num2 = num;
			num = (short)1119082293;
			switch (num2 == num)
			{
			}
			num = (short)1288765441;
			if (num != 0)
			{
			}
			num = (short)395378688;
			if (num != 0)
			{
			}
			num = (short)2037579776;
			short num3 = num;
			this.AddGeneral(ref XMLRptDataObj);
			this.AddTracking(ref XMLRptDataObj);
			this.AddFlashPort(ref XMLRptDataObj);
			this.AddFeatureSet(ref XMLRptDataObj);
		}
	}
}
