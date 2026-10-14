using System;
using System.Collections.Generic;
using System.Reflection;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.Acp.PackUnpack.Ish.Layouts;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.RadioFeatureSet;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000D8 RID: 216
	public class FlashcodeTable : global::System.IDisposable
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x00002FFF File Offset: 0x000011FF
		public FlashcodeTable()
		{
			this.d = false;
			this.a = new global::SpecialFeatures.Flashport.FlashRadio.Flashcode();
			this.b = false;
			this.c = false;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00003032 File Offset: 0x00001232
		public FlashcodeTable(bool isPortable, bool ordered) : this(ordered)
		{
			this.e = isPortable;
			this.f = true;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00003049 File Offset: 0x00001249
		internal FlashcodeTable(bool ordered)
		{
			this.d = ordered;
			this.a = new global::SpecialFeatures.Flashport.FlashRadio.Flashcode(this.d);
			this.b = false;
			this.c = false;
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0010F828 File Offset: 0x0010DA28
		public global::SpecialFeatures.Flashport.FlashRadio.Flashcode FLASHcode
		{
			get
			{
				short num = (short)1846783220;
				short num2 = num;
				num = (short)376286452;
				switch (num2 == num)
				{
				}
				num = (short)568918017;
				if (num != 0)
				{
				}
				num = (short)235667456;
				short num3 = num;
				num = (short)593559552;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0010F8D4 File Offset: 0x0010DAD4
		public void InitTable(bool codeplugOpen, string modelNumber, bool forComparedCodeplug = false)
		{
			int a_ = 8;
			short num = (short)739180544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7C7;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::AcpCommonLib.IAcpField field;
				global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fldLayout;
				for (;;)
				{
					IL_30:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation2;
					string text;
					global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint optionGatingConstraint;
					string text2;
					global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint optionGatingConstraint2;
					switch (num2)
					{
					case 0:
						if (codeplugOpen)
						{
							num = (short)447807662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33F2;
					case 1:
						field = radioInformation.Labtool.RadioInfoLabToolGermanFedGovEnabled_43792;
						num = (short)66519058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_12E3;
					case 3:
						field = radioInformation.Labtool.RadInfoLabtoolFrontDisplayFullKeypad_A23985;
						num = (short)876675258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.d())
						{
							num = (short)1244004394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊뺌랎", a_), 1, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsSmartzoneUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.SMARTZONE_Systems_Operation));
						num = (short)2130116991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.d())
						{
							num = (short)1055654070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B5;
					case 6:
						if (codeplugOpen)
						{
							num = (short)439812120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DDA;
					case 7:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊뺌릎ꂐ", a_), 5, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.Is9600UsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.ASTRO_25_9600_Baud_Trunking_Systems_Operation));
						num = (short)588972151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_4BA4;
					case 9:
						goto IL_1CC3;
					case 10:
						goto IL_B9A;
					case 11:
						field = radioInformation.Labtool.RadInfoLabtoolAtakHOption_HA00680;
						num = (short)1693974640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊벌뢎ꆐ", a_), 18, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsTrunkedRadioTraceRemoteMonitorUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Trunked_Radio_Trace_Remote_Monitor));
						num = (short)1012990089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						field = radioInformation.Labtool.RadInfoLabtoolG857FDNYEmRxTxToneSet_A41509;
						num = (short)467665119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						field = radioInformation.Labtool.RadInfoLabtoolP25CommonAirInterface_A42122;
						num = (short)2028077508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_4F28;
					case 16:
						goto IL_2235;
					case 17:
						goto IL_20F0;
					case 18:
						goto IL_4DFB;
					case 19:
						if (codeplugOpen)
						{
							num = (short)389480920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6690;
					case 20:
						goto IL_56B7;
					case 21:
						field = radioInformation.Labtool.RadInfoLabtoolSWAES_A43013;
						num = (short)1218773312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊벌뚎ꊐ", a_), 12, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsADPSwUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Advanced_Digital_Privacy_Software));
						num = (short)1683554306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_5E52;
					case 24:
						field = radioInformation.Labtool.RadInfoLabtoolEncryptedVPNGateway_42279;
						num = (short)386072777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (codeplugOpen)
						{
							num = (short)1409679423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_491E;
					case 26:
						goto IL_2038;
					case 27:
						radioInformation2 = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						goto IL_1C69;
					case 28:
						goto IL_531B;
					case 29:
						if (codeplugOpen)
						{
							num = (short)77856876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64A2;
					case 30:
						goto IL_3014;
					case 31:
						field = radioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986;
						num = (short)1392312676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (this.d())
						{
							num = (short)1824588176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊릌릎", a_), 30, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsOneTouchUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.One_Touch_Status_Message));
						num = (short)1334640692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_24E9;
					case 34:
						if (codeplugOpen)
						{
							num = (short)91488521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C32;
					case 35:
						if (this.c())
						{
							num = (short)24183033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A6E;
					case 36:
						if (codeplugOpen)
						{
							num = (short)483786912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_122A;
					case 37:
						if (!this.b())
						{
							num = (short)1469448563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꖖ", a_), 81, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_1_Primary_Band));
						num = (short)1968701460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (codeplugOpen)
						{
							num = (short)1230045628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_248E;
					case 39:
						if (codeplugOpen)
						{
							num = (short)1528693007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1398;
					case 40:
						if (codeplugOpen)
						{
							num = (short)2127495553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6349;
					case 41:
						if (codeplugOpen)
						{
							num = (short)1303183752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_524B;
					case 42:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊뢌뺎", a_), 1, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsSmartzoneUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.SMARTZONE_Systems_Operation));
						num = (short)916849030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (codeplugOpen)
						{
							num = (short)256376888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D00;
					case 44:
						field = radioInformation.Labtool.RadInfoLabtoolGA04892_8900MHZ_A44827;
						num = (short)748683715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						field = radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185;
						num = (short)1384448459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						goto IL_4A86;
					case 47:
						goto IL_213D;
					case 48:
						if (codeplugOpen)
						{
							num = (short)1529151573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C0A;
					case 49:
						goto IL_2A44;
					case 50:
						goto IL_361E;
					case 51:
						num = (short)901447751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_5501;
					case 53:
						if (codeplugOpen)
						{
							num = (short)664338443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131E;
					case 54:
						if (codeplugOpen)
						{
							num = (short)205389855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_364C;
					case 55:
						if (this.c())
						{
							num = (short)812384408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21F6;
					case 56:
						field = radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988;
						num = (short)632750197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (codeplugOpen)
						{
							num = (short)1089667398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4023;
					case 58:
						goto IL_3DF7;
					case 59:
						goto IL_1472;
					case 60:
						goto IL_3357;
					case 61:
						goto IL_40C8;
					case 62:
						goto IL_4023;
					case 63:
						field = radioInformation.Labtool.RadInfoLabtoolQA08676_AdaptiveSpeakerVolume;
						num = (short)1566638352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (this.d())
						{
							num = (short)1942749206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a뮌릎Ꚑ", a_), 12, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsADPSwUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Advanced_Digital_Privacy_Software));
						num = (short)1023803534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						field = radioInformation.Labtool.RadInfoLabtoolSmartConnect_43719;
						num = (short)1887961348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (codeplugOpen)
						{
							num = (short)343539871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3078;
					case 67:
						goto IL_9C8;
					case 68:
						goto IL_22FB;
					case 69:
						if (codeplugOpen)
						{
							num = (short)68157829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52CE;
					case 70:
						goto IL_14B3;
					case 71:
						if (codeplugOpen)
						{
							num = (short)1688535435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FCC;
					case 72:
						if (codeplugOpen)
						{
							num = (short)558170522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2077;
					case 73:
						goto IL_2F33;
					case 74:
						goto IL_1E81;
					case 75:
						field = radioInformation.Labtool.RadInfoLabtoolQ173G173Omnilink_A8788;
						num = (short)788725840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (codeplugOpen)
						{
							num = (short)598802645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5945;
					case 77:
						num = (short)2065826085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						goto IL_558D;
					case 79:
						goto IL_5C87;
					case 80:
						goto IL_5E8D;
					case 81:
						field = radioInformation.Labtool.RadInfoLabtoolH46G683OneTouchStatusMsg_37658;
						num = (short)762053091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔꆖ", a_), 80, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_Primary_Band));
						num = (short)1343029321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						field = radioInformation.Labtool.RadInfoLabtoolWiFiCapability_42549;
						num = (short)172294458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐ꒒ꚔꚖ", a_);
						goto IL_3AFD;
					case 85:
						field = radioInformation.Labtool.RadInfoLabtoolThirdPartyModemTethering_A43043;
						num = (short)495321461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꪒ궔ꖖ", a_), 72, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsSiteSelAlertInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Site_Selectable_Alert_For_P25_Trunking));
						num = (short)1459355885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						goto IL_4EEF;
					case 88:
						goto IL_E63;
					case 89:
						field = radioInformation.Labtool.RadInfoLabtoolH43G170TrunkedRadioTraceRemoteMonitor_37551;
						num = (short)298451272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (this.d())
						{
							num = (short)100991076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔ꺖", a_), 31, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Enable_Dual_Band_Operation));
						num = (short)1035665790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						goto IL_176C;
					case 92:
						field = radioInformation.Labtool.RadInfoLabtoolQA07680AAGA01620AAMultiSystemOTARHOption_43695;
						num = (short)2004156863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						if (codeplugOpen)
						{
							num = (short)627769702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37B0;
					case 94:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊뢌뾎Ꚑ", a_), 19, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsFCCNarrowBandMandateUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._125_kHz_FCC_Mandate));
						num = (short)1425866985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_4C32;
					case 96:
						goto IL_12A7;
					case 97:
						if (codeplugOpen)
						{
							num = (short)88867207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EFA;
					case 98:
						if (codeplugOpen)
						{
							num = (short)681247176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_651D;
					case 99:
						goto IL_3078;
					case 100:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꚒꊔ꺖", a_), 31, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Enable_Dual_Band_Operation));
						num = (short)1737163028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						num = (short)1780613482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						if (!this.b())
						{
							num = (short)1102446674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔꂖ", a_), 80, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_Primary_Band));
						num = (short)698876284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						if (codeplugOpen)
						{
							num = (short)1836450232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C8;
					case 104:
						goto IL_5501;
					case 105:
						if (codeplugOpen)
						{
							num = (short)1564541094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213D;
					case 106:
						if (this.d())
						{
							num = (short)4718741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꢐꎒ꒔ꖖ", a_), 85, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsMissionCriticalGeofenceUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Mission_Critical_Geofence));
						num = (short)1221591279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						goto IL_34C8;
					case 108:
						field = radioInformation.Labtool.RadInfoLabtoolH04ConvTacticalRekey_35710;
						num = (short)425918683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊벌뢎ꊐ", a_), 4, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsOmnilinkUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.SMARTZONE_OMNILINK_Multizone_Operation));
						num = (short)1463418903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						goto IL_5FCC;
					case 111:
						goto IL_2415;
					case 112:
						goto IL_131E;
					case 113:
						goto IL_19C9;
					case 114:
						num = (short)1002176769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						if (codeplugOpen)
						{
							num = (short)282722709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_448F;
					case 116:
						num = (short)1136656849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
						goto IL_2D00;
					case 118:
						goto IL_480F;
					case 119:
						goto IL_19C9;
					case 120:
						if (this.c())
						{
							num = (short)1686569174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B4;
					case 121:
						field = radioInformation.Labtool.RadInfoLabtoolQA02751APXLiRadioTrigger_A41197;
						num = (short)1655504970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						num = (short)2126643531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						if (codeplugOpen)
						{
							num = (short)154927282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2235;
					case 124:
						field = radioInformation.Labtool.RadInfoLabtoolDINCPlusAudio_42670;
						num = (short)614203616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						if (codeplugOpen)
						{
							num = (short)487325831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_346D;
					case 126:
						goto IL_38FA;
					case 127:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꢐꎒꖔꚖ", a_), 77, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsWifiCapabilityUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.WiFi_Capability));
						num = (short)1528365465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
						if (this.c())
						{
							num = (short)433651994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C88;
					case 129:
						if (this.d())
						{
							num = (short)1420951989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3357;
					case 130:
						if (codeplugOpen)
						{
							num = (short)1919287501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A63;
					case 131:
						optionGatingConstraint = (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable.<>c.<>9__12_1 = delegate()
						{
							short num5 = (short)342124778;
							short num6 = num5;
							num5 = (short)1599170794;
							switch ((num6 == num5) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num5 = (short)1978531840;
								short num7 = num5;
								num5 = (short)926089216;
								if (num5 != 0)
								{
								}
								num5 = (short)2028339201;
								if (num5 != 0)
								{
								}
								if (global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDataModemUsedInCP(2))
								{
									return true;
								}
								break;
							}
							}
							return global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDataModemUsedInCP(3);
						});
						goto IL_4D46;
					case 132:
						if (codeplugOpen)
						{
							num = (short)1528430870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B4A;
					case 133:
						if ((optionGatingConstraint = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable.<>c.<>9__12_1) == null)
						{
							num = (short)1142423683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D46;
					case 134:
						goto IL_B04;
					case 135:
						field = radioInformation.Labtool.RadInfoLabtoolSmartConnectOverBroadband_43720;
						num = (short)1389560206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
						field = radioInformation.Labtool.RadInfoLabtoolMotoVMLDataModemTethering_A42852;
						num = (short)683606484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 137:
						goto IL_3593;
					case 138:
						if (this.d())
						{
							num = (short)373358678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꪒ궔ꖖ", a_), 72, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsSiteSelAlertInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Site_Selectable_Alert_For_P25_Trunking));
						num = (short)885588206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 139:
						if (this.d())
						{
							num = (short)293863774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎Ꚑꖒ궔ꖖ", a_), 101, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsSmartConnectUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.SmartConnect));
						num = (short)1286209720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						field = radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796;
						num = (short)203423929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						if (this.d())
						{
							num = (short)706609422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a릌뮎꒐", a_), 69, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsFiregroundAccountabilitySoftwareInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Fireground_Accountability_Software));
						num = (short)1615987058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 142:
						goto IL_12E3;
					case 143:
						goto IL_3014;
					case 144:
						if (codeplugOpen)
						{
							num = (short)368050177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DFB;
					case 145:
						if (this.d())
						{
							num = (short)777060599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a뺌랎Ꚑ", a_), 57, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsVotingScanUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Conventional_Voting_Scan));
						num = (short)1387004188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
						goto IL_2939;
					case 147:
						if (codeplugOpen)
						{
							num = (short)1480851901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3C;
					case 148:
						goto IL_3E70;
					case 149:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꢐꎒ꒔ꖖ", a_), 85, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsMissionCriticalGeofenceUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Mission_Critical_Geofence));
						num = (short)50331681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 150:
						field = radioInformation.Labtool.RadInfoLabtoolQA00570VHF_A37151;
						num = (short)536281199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 151:
						if (this.d())
						{
							num = (short)290914700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources._7_800_MHz_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔ꒖", a_), 25, 1, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._7_800_MHz_Secondary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.VHF_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꎖ", a_), 25, 2, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_Secondary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_Range_1_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꊖ", a_), 25, 4, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_1_Secondary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_Range_2_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꆖ", a_), 25, 8, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_2_Secondary_Band));
						num = (short)1703018922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 152:
						num = (short)1689845801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 153:
						goto IL_1B5B;
					case 154:
						field = radioInformation.Labtool.RadInfoLabtoolQA08157ETSIRegulatoryRegionEnabled_43771;
						num = (short)435683484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 155:
						goto IL_52CE;
					case 156:
						goto IL_C97;
					case 157:
						if (codeplugOpen)
						{
							num = (short)654311873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34C8;
					case 158:
						if (this.d())
						{
							num = (short)334889436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65D5;
					case 159:
						field = radioInformation.Labtool.RadInfoLabtoolQA01648ASKEnable_A37150;
						num = (short)202702947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 160:
						field = radioInformation.Labtool.RadInfoLabtoolG966OTAP_A22740;
						num = (short)1562575094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 161:
						goto IL_2C5B;
					case 162:
						if (codeplugOpen)
						{
							num = (short)1394409904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_262D;
					case 163:
						goto IL_651D;
					case 164:
						if (codeplugOpen)
						{
							num = (short)894894125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AE0;
					case 165:
						if (this.d())
						{
							num = (short)234422591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꂐ꒒ꊔꚖ", a_), 35, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsEnhLevel2UsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Enhancement_Level_2));
						num = (short)1959133427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 166:
						field = radioInformation.Labtool.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799;
						num = (short)651690031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 167:
						field = radioInformation.Labtool.RadInfoLabtoolV24Software_A41828;
						num = (short)1724514643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 168:
						field = radioInformation.Labtool.RadInfoLabtoolQ361G361APCOTrunking_A8794;
						num = (short)2030895174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 169:
						goto IL_39A0;
					case 170:
						goto IL_1DE5;
					case 171:
						goto IL_21B5;
					case 172:
						if (codeplugOpen)
						{
							num = (short)1851851052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A44;
					case 173:
						if (!this.d())
						{
							num = (short)312803519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1757216852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 174:
						field = radioInformation.Labtool.RadInfoLabtoolManDown_A40006;
						num = (short)186319195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 175:
						goto IL_10EB;
					case 176:
						num = (short)1690763600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						goto IL_25B4;
					case 178:
						field = radioInformation.Labtool.RadInfoLabtoolQA00572UHFRange2_A42595;
						num = (short)1071710224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 179:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꢐꎒꖔ꾖", a_), 83, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsGroupServicesUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Group_Services));
						num = (short)887423297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 180:
						if (codeplugOpen)
						{
							num = (short)803799320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1694;
					case 181:
						if (codeplugOpen)
						{
							num = (short)1076298132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47C2;
					case 182:
						num = (short)544866519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 183:
						field = radioInformation.Labtool.RadioInfoLabtoolExtremeNoiseReduction_A37723;
						num = (short)70582351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
						goto IL_1472;
					case 185:
						goto IL_3EE8;
					case 186:
						goto IL_1503;
					case 187:
					{
						num = (short)1075838976;
						short num3 = num;
						if (this.d())
						{
							num = (short)189399149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a벌뢎ꊐ", a_), 4, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsOmnilinkUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.SMARTZONE_OMNILINK_Multizone_Operation));
						num = (short)1402995108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 188:
						if (codeplugOpen)
						{
							num = (short)325255622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28C1;
					case 189:
						goto IL_4303;
					case 190:
						goto IL_1435;
					case 191:
						num = (short)709886430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 192:
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources._7_800_MHz_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꆒꆔꎖ", a_), 23, 1, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._7_800_MHz_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.VHF_MP_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔꆖ", a_), 23, 2, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_MP_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.VHF_HP_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔꂖ", a_), 23, 3, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_HP_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_R1_MP_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꚖ", a_), 23, 4, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R1_MP_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_R1_HP_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꖖ", a_), 23, 5, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R1_HP_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_R2_MP_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꊖ", a_), 23, 8, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R2_MP_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources._900MHZ_ID, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꪒꎔ꺖", a_), 23, 6, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._900MHZ_ID));
						num = (short)1870725581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 193:
						field = radioInformation.Labtool.RadInfoLabtoolQ667G193ADPSW_38631;
						num = (short)858456428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 194:
						num = (short)521601156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 195:
						if (codeplugOpen)
						{
							num = (short)100794504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3392;
					case 196:
						if (this.d())
						{
							num = (short)1502216613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒ궔Ꞗ", a_), 63, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsTDMAUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.TDMA_Operation));
						num = (short)1912930565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 197:
						goto IL_1C88;
					case 198:
						goto IL_4378;
					case 199:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꢐꎒꖔꆖ", a_), 25, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDINCPlusUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.DINC_PLUS_AUDIO));
						num = (short)2053963929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 200:
						if (this.c())
						{
							num = (short)97583155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2855;
					case 201:
						goto IL_DDA;
					case 202:
						if (this.d())
						{
							num = (short)1014170067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a떌뾎Ꞑ", a_), 3, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDigitalIMBEUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.ASTRO_Digital_Operation));
						num = (short)1703412023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 203:
						goto IL_643B;
					case 204:
						goto IL_2D8E;
					case 205:
						field = radioInformation.Labtool.RadInfoLabtoolQA01749LegacySWEnable_A37151;
						num = (short)937296306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 206:
						num = (short)432603395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 207:
						goto IL_4B4A;
					case 208:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꢐꎒꖔꞖ", a_), 60, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDigitalToneSignalingOperationUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Alstro_Alert_Operation));
						num = (short)2076704911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 209:
						goto IL_5472;
					case 210:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊뢌뾎", a_), 2, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsSmartnetUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.SMARTNET_Systems_Operation));
						num = (short)885064122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 211:
						if (codeplugOpen)
						{
							num = (short)6357369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A86;
					case 212:
						field = radioInformation.Labtool.RadInfoLabtoolExtendedDispatch_A38638;
						num = (short)1367343422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 213:
						field = radioInformation.Labtool.RadInfoLabtoolQA01768EnhancedZoneBank_A37209;
						num = (short)2008875304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 214:
						num = (short)1554120979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 215:
						if (codeplugOpen)
						{
							num = (short)898957618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B04;
					case 216:
						field = radioInformation.Labtool.RadInfoLabtoolQA09028ViQi_VoiceControl;
						num = (short)1783103546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 217:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐꆒꖔꖖ", a_), 70, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsGeofenceActivationUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Geo_Fence_Option));
						num = (short)77594853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 218:
						if (codeplugOpen)
						{
							num = (short)630849798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_507F;
					case 219:
						goto IL_64A2;
					case 220:
						field = radioInformation.Labtool.RadInfoLabtoolCollaborativePhase1_A41683;
						num = (short)477823285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 221:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊뾌뚎ꦐ", a_), 13, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsOtarMkeyUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.OTAR_with_Multikey));
						num = (short)412418388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 222:
						if (codeplugOpen)
						{
							num = (short)70975716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A31;
					case 223:
						goto IL_6611;
					case 224:
						goto IL_1862;
					case 225:
						if (!forComparedCodeplug)
						{
							num = (short)79822925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1976303643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 226:
						field = radioInformation.Labtool.RadInfoLabtoolH868W968OtarAndMultikey_A8192;
						num = (short)764870673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 227:
						goto IL_88A;
					case 228:
						field = radioInformation.Labtool.RadInfoLabtoolQA00569_7800MHZ_A42596;
						num = (short)2128085334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 229:
						goto IL_4559;
					case 230:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꆒꆔ꒖", a_), 15, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsFedFPPUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Federal_Government_Front_Panel_Programming_Enhancement));
						num = (short)1023082872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 231:
						if (codeplugOpen)
						{
							num = (short)1331036626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C5B;
					case 232:
						if (codeplugOpen)
						{
							num = (short)1492779234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20F0;
					case 233:
						goto IL_1CC3;
					case 234:
						field = radioInformation.Labtool.RadInfoLabtoolQA01770GA01770EnhancementLev1_38632;
						num = (short)583729585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 235:
						if (codeplugOpen)
						{
							num = (short)686948473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E81;
					case 236:
						text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎Ꚑꖒ궔Ꞗ", a_);
						goto IL_1CFF;
					case 237:
						goto IL_26AD;
					case 238:
						goto IL_26AD;
					case 239:
						goto IL_24E9;
					case 240:
						if (global::ConstraintHelper.UtilityMack.IsFreonCodeplug(modelNumber))
						{
							num = (short)1778909306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1233911851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 241:
						goto IL_28C1;
					case 242:
						goto IL_480F;
					case 243:
						goto IL_816;
					case 244:
						if (this.d())
						{
							num = (short)655622323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꢐꎒꖔ꾖", a_), 83, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsGroupServicesUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Group_Services));
						num = (short)1441333603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 245:
						goto IL_4610;
					case 246:
						goto IL_122A;
					case 247:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊뺌랎Ꚑ", a_), 57, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsVotingScanUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Conventional_Voting_Scan));
						num = (short)797376608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 248:
						goto IL_2855;
					case 249:
						num = (short)1927675997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 250:
						field = radioInformation.Labtool.RadInfoLabtoolQA01771GA01771EnhancementLev2_37660;
						num = (short)1319305502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 251:
						goto IL_4378;
					case 252:
						goto IL_2F33;
					case 253:
						if (codeplugOpen)
						{
							num = (short)327221698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176C;
					case 254:
						goto IL_65D5;
					case 255:
						num = (short)241107020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 256:
						if (codeplugOpen)
						{
							num = (short)1031078167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40C8;
					case 257:
						if (codeplugOpen)
						{
							num = (short)1995964583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_579C;
					case 258:
						if (this.d())
						{
							num = (short)2093875504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a뢌벎", a_), 58, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsNonFedFPPUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.FCC_Conventional_Front_Panel_Programming));
						num = (short)321519985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 259:
						if (this.a())
						{
							num = (short)803799156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)23789790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 260:
						goto IL_2BE1;
					case 261:
						goto IL_54C2;
					case 262:
						field = radioInformation.Labtool.RadInfoLabtoolTDMAOperation_A23984;
						num = (short)1592197563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 263:
						field = radioInformation.Labtool.RadInfoLabtoolQA00569_7800MHZ_A42596;
						num = (short)1761804303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 264:
						goto IL_816;
					case 265:
						field = radioInformation.Labtool.RadInfoLabtoolAstroAlertingOperHOption;
						num = (short)1520828511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 266:
						goto IL_47C2;
					case 267:
						if (this.d())
						{
							num = (short)1581776903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a뺌릎ꂐ", a_), 5, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.Is9600UsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.ASTRO_25_9600_Baud_Trunking_Systems_Operation));
						num = (short)840564849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 268:
						text2 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐꖒꞔꞖ", a_);
						goto IL_1CFF;
					case 269:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐꚒꊔꎖ", a_), 88, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsAESUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Advanced_Encryption_Standard));
						num = (short)1073283456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 270:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊릌뮎꒐", a_), 69, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsFiregroundAccountabilitySoftwareInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Fireground_Accountability_Software));
						num = (short)984940748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 271:
						field = radioInformation.Labtool.RadInfoLabtoolGeoFence_42325;
						num = (short)566952417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 272:
						goto IL_491E;
					case 273:
						goto IL_448F;
					case 274:
						if (codeplugOpen)
						{
							num = (short)1556742481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_237A;
					case 275:
						if (codeplugOpen)
						{
							num = (short)508624910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BAF;
					case 276:
						goto IL_3965;
					case 277:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8a뒌뮎Ꚑ", a_), 53, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDataUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Packet_Data_Interface));
						num = (short)1158742219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 278:
						field = radioInformation.Labtool.RadInfoLabtoolW12Preamp_A9671;
						num = (short)1330184399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 279:
						field = radioInformation.Labtool.RadInfoLabtoolRSIData_42491;
						num = (short)360972349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 280:
						num = (short)1595604993;
						if (num != 0)
						{
						}
						field = radioInformation.Labtool.RadInfoLabtoolGA01731AAQA07949AAApxDesSoftwareCrypto_43745;
						num = (short)1342308674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 281:
						field = radioInformation.Labtool.RadioInfoLabToolQA00631DvrsPsuActivation_A40166;
						num = (short)671416388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 282:
						num = (short)436142205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 283:
						goto IL_62C0;
					case 284:
						goto IL_12A7;
					case 285:
						goto IL_D9E;
					case 286:
						goto IL_5133;
					case 287:
						if (codeplugOpen)
						{
							num = (short)1007943979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E70;
					case 288:
						num = (short)897122540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 289:
						if (this.d())
						{
							num = (short)22347984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꢐꎒꖔꞖ", a_), 60, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDigitalToneSignalingOperationUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Alstro_Alert_Operation));
						num = (short)1381761054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 290:
						if (this.c())
						{
							num = (short)1406468509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D6;
					case 291:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐ꒒ꊔꞖ", a_), 48, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsEnhLevel1UsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Enhancement_Level_1));
						num = (short)1966473414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 292:
						goto IL_237A;
					case 293:
						radioInformation2 = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						goto IL_1C69;
					case 294:
						if (codeplugOpen)
						{
							num = (short)110428249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4997;
					case 295:
						if (this.d())
						{
							num = (short)800915686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a뢌붎", a_), 15, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsFedFPPUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Federal_Government_Front_Panel_Programming_Enhancement));
						num = (short)650576205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 296:
						goto IL_5945;
					case 297:
						num = (short)1101135878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 298:
						if (codeplugOpen)
						{
							num = (short)353763420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_582D;
					case 299:
						field = radioInformation.Labtool.RadInfoLabtoolQA00572UHFRange2_A42595;
						num = (short)1476329620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 300:
						field = radioInformation.Labtool.RadInfoLabtoolQ806IMBE_A8191;
						num = (short)811270193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 301:
						if (codeplugOpen)
						{
							num = (short)230818042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5133;
					case 302:
						if (this.d())
						{
							num = (short)1533411605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a뒌뮎Ꚑ", a_), 53, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDataUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Packet_Data_Interface));
						num = (short)597426624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 303:
						if (codeplugOpen)
						{
							num = (short)1882849363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E6;
					case 304:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊뢌벎", a_), 58, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsNonFedFPPUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.FCC_Conventional_Front_Panel_Programming));
						num = (short)2050883710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 305:
						if (codeplugOpen)
						{
							num = (short)1201668246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2415;
					case 306:
						field = radioInformation.Labtool.RadioInfoLabToolGA00631DvrsMsuOperation_A41827;
						num = (short)672596102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 307:
						goto IL_4DAC;
					case 308:
						goto IL_43B3;
					case 309:
						goto IL_1638;
					case 310:
						if (codeplugOpen)
						{
							num = (short)2019492121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22FB;
					case 311:
						goto IL_558D;
					case 312:
						goto IL_524B;
					case 313:
						field = radioInformation.Labtool.RadInfoLabtool900MHzEnable_A42570;
						num = (short)567869898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 314:
						goto IL_13E6;
					case 315:
						field = radioInformation.Labtool.RadInfoLabtoolGroupServices_42787;
						num = (short)239337661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 316:
						if (codeplugOpen)
						{
							num = (short)479658204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1638;
					case 317:
						if (this.c())
						{
							num = (short)1909784677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9E;
					case 318:
						goto IL_1D8A;
					case 319:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐ꒒ꊔꚖ", a_), 35, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsEnhLevel2UsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Enhancement_Level_2));
						num = (short)626327816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 320:
						goto IL_38AB;
					case 321:
						goto IL_32E0;
					case 322:
						goto IL_1694;
					case 323:
						optionGatingConstraint2 = (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable.<>c.<>9__12_0 = delegate()
						{
							short num5 = (short)916780115;
							short num6 = num5;
							num5 = (short)1704195155;
							switch (num6 == num5)
							{
							default:
							{
								num5 = (short)2007498752;
								short num7 = num5;
								break;
							}
							case true:
								break;
							}
							num5 = (short)1968766976;
							if (num5 != 0)
							{
							}
							num5 = (short)1877082113;
							if (num5 != 0)
							{
							}
							return global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDataModemUsedInCP(1);
						});
						goto IL_46D7;
					case 324:
						goto IL_248E;
					case 325:
						if (codeplugOpen)
						{
							num = (short)1155268801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_97B;
					case 326:
						field = radioInformation.Labtool.RadInfoLabtoolLTEHWEnablement_QA08887;
						num = (short)1657012286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 327:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐ꒒ꎔꂖ", a_), 17, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsAuthenticationUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.P25_Radio_Authentication));
						num = (short)544800855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 328:
						goto IL_4997;
					case 329:
						if (this.d())
						{
							num = (short)255131762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17E7;
					case 330:
						goto IL_6349;
					case 331:
						if (codeplugOpen)
						{
							num = (short)820379772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1862;
					case 332:
						if (codeplugOpen)
						{
							num = (short)1630732662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DAC;
					case 333:
						goto IL_656A;
					case 334:
						if (codeplugOpen)
						{
							num = (short)1026883818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4509;
					case 335:
						if (this.c())
						{
							num = (short)457769398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A0;
					case 336:
						if (this.d())
						{
							num = (short)945029326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)812646870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 337:
						field = radioInformation.Labtool.RadInfoLabtoolG138MotorcycleRadio_A24684;
						num = (short)1491403044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 338:
						if (this.d())
						{
							num = (short)1384775872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources._7_800_MHz_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꎔ꺖", a_), 23, 1, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._7_800_MHz_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.VHF_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꞖ", a_), 23, 2, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_Range_1_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꚖ", a_), 23, 4, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_1_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_Range_2_Primary_Band, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꖖ", a_), 23, 8, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_2_Primary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.Primary_Band_800_900MHz, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꖐꮒꚔꖖ", a_), 23, 7, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Primary_Band_800_900MHz));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources._900MHZ_ID, global::System.TypeCode.Byte, 3, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꊐꎒꂔꆖ", a_), 23, 6, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._900MHZ_ID));
						num = (short)526123424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 339:
						goto IL_579C;
					case 340:
						goto IL_155E;
					case 341:
						if (codeplugOpen)
						{
							num = (short)1983250513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CE7;
					case 342:
						goto IL_1A31;
					case 343:
						if (codeplugOpen)
						{
							num = (short)1540882445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6611;
					case 344:
						if (codeplugOpen)
						{
							num = (short)2061434901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38AB;
					case 345:
						if (codeplugOpen)
						{
							num = (short)1738932647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5472;
					case 346:
						goto IL_37B0;
					case 347:
						goto IL_33F2;
					case 348:
						if (codeplugOpen)
						{
							num = (short)677183801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56F4;
					case 349:
						if (codeplugOpen)
						{
							num = (short)806551974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DE5;
					case 350:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐꖒꚔꞖ", a_), 101, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsSmartConnectUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.SmartConnect));
						num = (short)130678843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 351:
						goto IL_C3C;
					case 352:
						goto IL_54C2;
					case 353:
						goto IL_56B7;
					case 354:
						if (this.c())
						{
							num = (short)107413801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10EB;
					case 355:
						goto IL_32E0;
					case 356:
						goto IL_364C;
					case 357:
						if (codeplugOpen)
						{
							num = (short)128581772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EE8;
					case 358:
						field = radioInformation.Labtool.RadInfoLabtoolNightVisionGoggle_43542;
						num = (short)1960378714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 359:
						if (this.d())
						{
							num = (short)187891929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꖐꞒꆔꂖ", a_), 70, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsGeofenceActivationUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Geo_Fence_Option));
						num = (short)553976235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 360:
						if (codeplugOpen)
						{
							num = (short)1612316747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E8D;
					case 361:
						goto IL_D14;
					case 362:
						if (codeplugOpen)
						{
							num = (short)172097539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1503;
					case 363:
						goto IL_3A2D;
					case 364:
						goto IL_97B;
					case 365:
						if (this.d())
						{
							num = (short)1090191581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a릌뚎ꦐ", a_), 13, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsOtarMkeyUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.OTAR_with_Multikey));
						num = (short)1066533326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 366:
						if (this.d())
						{
							num = (short)216465535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꢐꎒꖔꚖ", a_), 77, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsWifiCapabilityUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.WiFi_Capability));
						num = (short)785186904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 367:
						num = (short)886702336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 368:
						if (this.d())
						{
							num = (short)2132869132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊릌벎", a_), 18, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsTrunkedRadioTraceRemoteMonitorUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Trunked_Radio_Trace_Remote_Monitor));
						num = (short)1994391960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 369:
						goto IL_38FA;
					case 370:
						goto IL_2D8E;
					case 371:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꚖ", a_), 81, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_1_Primary_Band));
						num = (short)914096481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 372:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐꮒꚔ꒖", a_), 37, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsExtremeNoiseReductionUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Extreme_Noise_Reduction));
						num = (short)1428619547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 373:
						goto IL_3C0A;
					case 374:
						field = radioInformation.Labtool.RadInfoLabtoolH869W969Multikey_A8193;
						num = (short)1785200947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 375:
						goto IL_17E7;
					case 376:
						goto IL_656A;
					case 377:
						field = radioInformation.Labtool.RadInfoLabtoolQ507G507FCCMANDATE_A38198;
						num = (short)164823086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 378:
						if (this.c())
						{
							num = (short)1852768511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D14;
					case 379:
						if (codeplugOpen)
						{
							num = (short)1440350523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4303;
					case 380:
						goto IL_2F33;
					case 381:
						if (codeplugOpen)
						{
							num = (short)1869938753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BE1;
					case 382:
						goto IL_3965;
					case 383:
						goto IL_1F3A;
					case 384:
						goto IL_531B;
					case 385:
						field = radioInformation.Labtool.RadInfoLabtoolAuthentication_A37609;
						num = (short)945553738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 386:
						num = (short)1127874904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 387:
						if (codeplugOpen)
						{
							num = (short)480051675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2939;
					case 388:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꆒꞔ꺖", a_), 47, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsGPSActivationUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.GPS_Activation));
						num = (short)651952355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 389:
						field = radioInformation.Labtool.RadInfoLabtoolQA00570VHF_A37151;
						num = (short)838008987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 390:
						goto IL_1F3A;
					case 391:
						field = radioInformation.Labtool.RadInfoLabtoolQ387G387ConvVoteScan_A8795;
						num = (short)948437417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 392:
						field = radioInformation.Labtool.RadInfoLabtoolLTEOperation_A41923;
						num = (short)1038418232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 393:
						if (this.d())
						{
							num = (short)1521615058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊뺌뢎", a_), 2, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsSmartnetUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.SMARTNET_Systems_Operation));
						num = (short)1835401242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 394:
						field = radioInformation.Labtool.RadInfoLabtoolH02EncryTacticalInhibit_A41560;
						num = (short)1723138058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 395:
						field = radioInformation.Labtool.RadInfoLabtoolQA02006APX6000XE_A38951;
						num = (short)652345454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 396:
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources._7_800_MHz_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꆒꞔꊖ", a_), 25, 1, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._7_800_MHz_Secondary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.VHF_MPZ_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔ꾖", a_), 25, 2, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_MPZ_Secondary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.VHF_HP_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꖔ꺖", a_), 25, 3, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_HP_Secondary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_R1_MP_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔ꒖", a_), 25, 4, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R1_MP_Secondary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_R1_HP_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꎖ", a_), 25, 5, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R1_HP_Secondary_Band));
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.UHF_R2_MP_Secondary_Band, global::System.TypeCode.Byte, 4, 4, 5);
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꆖ", a_), 25, 8, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R2_MP_Secondary_Band));
						num = (short)529334441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 397:
						if (codeplugOpen)
						{
							num = (short)422511003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4595;
					case 398:
						goto IL_346D;
					case 399:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8a뒌릎ꢐ", a_), 14, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsMultikeyUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Multikey_Id));
						num = (short)171376882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 400:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊뮌랎ꊐ", a_), 30, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsOneTouchUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.One_Touch_Status_Message));
						num = (short)1479016552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 401:
						if (codeplugOpen)
						{
							num = (short)689373625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1435;
					case 402:
						num = (short)486867218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 403:
						goto IL_3A6E;
					case 404:
						field = radioInformation.Labtool.RadInfoLabtoolQA00571UHFRange1_A42594;
						num = (short)97714442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 405:
						field = radioInformation.Labtool.RadInfoLabtool_HA00677_DVRS_PSU_CONVENTIONAL_SCAN_ENABLED;
						num = (short)698417425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 406:
						if (this.d())
						{
							num = (short)1795096975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊떌릎ꢐ", a_), 14, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsMultikeyUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Multikey_Id));
						num = (short)1209598070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 407:
						if (this.d())
						{
							num = (short)2050949492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꂐꮒꚔ꒖", a_), 37, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsExtremeNoiseReductionUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Extreme_Noise_Reduction));
						num = (short)1348403636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 408:
						goto IL_3593;
					case 409:
						goto IL_E63;
					case 410:
						field = radioInformation.Labtool.RadInfoLabtool00982SiteSelAlertForP25_42052;
						num = (short)1311637964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 411:
						field = radioInformation.Labtool.RadInfoLabtoolQ947W947APCOPacketData_8804;
						num = (short)984875463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 412:
						if (!this.d())
						{
							num = (short)263913760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2121531660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 413:
						num = (short)279970108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 414:
						if (this.d())
						{
							num = (short)206307655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꂐ꒒ꎔꂖ", a_), 17, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsAuthenticationUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.P25_Radio_Authentication));
						num = (short)1227489757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 415:
						if (codeplugOpen)
						{
							num = (short)883228888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DF7;
					case 416:
						goto IL_2F33;
					case 417:
						if (codeplugOpen)
						{
							num = (short)1445200055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C87;
					case 418:
						if (global::ConstraintHelper.UtilityMack.IsFreonCodeplug(modelNumber))
						{
							num = (short)1983119536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1626210461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 419:
						goto IL_23D6;
					case 420:
						goto IL_5E52;
					case 421:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꚒ궔Ꞗ", a_), 63, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsTDMAUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.TDMA_Operation));
						num = (short)1196032352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 422:
						field = radioInformation.Labtool.RadInfoLabtoolGPSActivation_A23983;
						num = (short)249888938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 423:
						field = radioInformation.Labtool.RadInfoLabtoolMissionCriticalGeofencing_A43013;
						num = (short)156958929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 424:
						if (this.d())
						{
							num = (short)1149370562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4610;
					case 425:
						goto IL_EFA;
					case 426:
						goto IL_39A0;
					case 427:
						goto IL_4559;
					case 428:
						if ((optionGatingConstraint2 = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable.<>c.<>9__12_0) == null)
						{
							num = (short)156696899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46D7;
					case 429:
						goto IL_262D;
					case 430:
						if (codeplugOpen)
						{
							num = (short)93454730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B9A;
					case 431:
						if (codeplugOpen)
						{
							num = (short)1044578472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14B3;
					case 432:
						field = radioInformation.Labtool.EnhancedDataOperation_42024;
						num = (short)1427833261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 433:
						goto IL_4509;
					case 434:
						goto IL_A63;
					case 435:
						if (this.d())
						{
							num = (short)1372193156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐ꒒궔ꖖ", a_), 47, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsGPSActivationUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.GPS_Activation));
						num = (short)2142110159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 436:
						goto IL_62C0;
					case 437:
						num = (short)838664671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 438:
						IL_1B99:
						num = (short)892469395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 439:
						if (this.d())
						{
							num = (short)2144338189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎Ꞑꖒꂔ꒖", a_), 88, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsAESUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Advanced_Encryption_Standard));
						num = (short)815071260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 440:
						field = radioInformation.Labtool.RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798;
						num = (short)731709507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 441:
						num = (short)1171718369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 442:
						goto IL_2038;
					case 443:
						goto IL_507F;
					case 444:
						field = radioInformation.Labtool.RadInfoLabtoolDualRadioOperation_A42245;
						num = (short)388301124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 445:
						field = radioInformation.Labtool.RadInfoLabtoolQA07516NYPDTrigger_43587;
						num = (short)1400176991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 446:
						if (!this.d())
						{
							num = (short)1866137799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B5B;
					case 447:
						goto IL_582D;
					case 448:
						goto IL_643B;
					case 449:
						field = radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987;
						num = (short)118358123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 450:
						field = radioInformation.Labtool.RadInfoLabtoolQA02811TrkSingleSysTrigger_A41198;
						num = (short)1308622939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 451:
						goto IL_4898;
					case 452:
						goto IL_3BAF;
					case 453:
						if (this.d())
						{
							num = (short)900071826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2D;
					case 454:
						field = radioInformation.Labtool.RadInfoLabtoolBluetooth_A37042;
						num = (short)1687355633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 455:
						goto IL_4595;
					case 456:
						field = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184;
						num = (short)2131296419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 457:
						goto IL_39A0;
					case 458:
						goto IL_56F4;
					case 459:
						goto IL_2AE0;
					case 460:
						goto IL_2077;
					case 461:
						goto IL_2F33;
					case 462:
						goto IL_155E;
					case 463:
						goto IL_88A;
					case 464:
						if (this.d())
						{
							num = (short)1058537839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BA4;
					case 465:
						if (codeplugOpen)
						{
							num = (short)1211695148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4898;
					case 466:
						field = radioInformation.Labtool.RadInfoLabtoolQA08715VoiceControlBasic;
						num = (short)497811617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 467:
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊떌뾎Ꞑ", a_), 3, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDigitalIMBEUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.ASTRO_Digital_Operation));
						num = (short)292356174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 468:
						goto IL_3392;
					case 469:
						if (global::ConstraintHelper.UtilityMack.IsFreonCodeplug(modelNumber))
						{
							num = (short)398131586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_531B;
					case 470:
						if (codeplugOpen)
						{
							num = (short)461832455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F28;
					case 471:
						goto IL_21F6;
					case 472:
						field = radioInformation.Labtool.RadInfoLabtoolTacticalServicesHOption;
						num = (short)1882849330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 473:
						if (this.d())
						{
							num = (short)2047213859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꂐ꒒ꊔꞖ", a_), 48, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsEnhLevel1UsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Enhancement_Level_1));
						num = (short)2016084219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 474:
						goto IL_43B3;
					case 475:
						field = radioInformation.Labtool.RadInfoLabtoolQA00571UHFRange1_A42594;
						num = (short)1513029778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 476:
						num = (short)1212678182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 477:
						goto IL_4EEF;
					case 478:
						text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎Ꚑꪒꆔ꺖", a_);
						goto IL_3AFD;
					case 479:
						if (codeplugOpen)
						{
							num = (short)1408762068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D8A;
					case 480:
						if (this.d())
						{
							num = (short)1257111646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a뢌뾎Ꚑ", a_), 19, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsFCCNarrowBandMandateUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._125_kHz_FCC_Mandate));
						num = (short)1233649673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 481:
						goto IL_1398;
					case 482:
						if (codeplugOpen)
						{
							num = (short)1965621402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C97;
					case 483:
						goto IL_3CE7;
					}
					goto IL_7C7;
					IL_816:
					num = (short)713949379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_88A:
					num = (short)1252589913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_97B:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Advanced_Digital_Privacy_Software, 7, 4);
					num = (short)42270784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9C8:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Federal_Government_Front_Panel_Programming_Enhancement, 2, 1);
					num = (short)2109276455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A63:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Legacy_SW_System_Key_Enable, 5, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꂐ꒒ꆔ꺖", a_), 71, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsLegacySWEnableUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Legacy_SW_System_Key_Enable));
					num = (short)156434620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B04:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.DVRS_MSU_Operation, 8, 3);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꖒꚔꚖ", a_), 41, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDVRSMSUUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.DVRS_MSU_Operation));
					num = (short)1772683435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B9A:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Encrypted_Tactical_Inhibit, 11, 1);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊붌붎", a_), 62, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsEncryptedTacticalInhibitUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Encrypted_Tactical_Inhibit));
					num = (short)1689256154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C3C:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.NYPD_Trigger, 4, 4);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꚐꚒ꒔ꆖ", a_), 98, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.NYPD_Trigger));
					num = (short)1120010697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C97:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.ETSI_REGULATORY_REGION_ENABLED, 15, 0);
					string name = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꦐꊒꂔꂖ", a_);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(name, 70, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsRegRegionEnabledETSIOption_43771), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.ETSI_Regulatory_Region_Enabled));
					num = (short)1726939280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D14:
					num = (short)95551554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D9E:
					num = (short)1245315429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DDA:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Encrypted_VPN_Gateway, 12, 4);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꊐꪒ궔ꆖ", a_), 75, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsEnVPNGatewayUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Encrypted_VPN_Gateway));
					num = (short)88539311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E63:
					num = (short)1680670755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EFA:
					num = (short)973771085;
					short num4 = num;
					num = (short)1717080397;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B99;
					default:
						num = (short)739442688;
						if (num != 0)
						{
						}
						fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Conventional_Voting_Scan, 10, 1);
						num = (short)59375761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_10EB:
					num = (short)1866662008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_122A:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Over_the_Air_Provisioning, 1, 3);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊뒌뚎Ꞑ", a_), 8, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsOtapUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Over_the_Air_Provisioning));
					num = (short)728170696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12A7:
					num = (short)1662910569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E3:
					num = (short)2013200595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_131E:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AcgResources.ID_ATAK_H, 15, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊첌뾎ꆐꖒ궔Ꞗ", a_), 80, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.isAtakHOption), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.ATAK_HOption));
					num = (short)833617945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1398:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.ID_GEOFENCEHOPTION, 1, 5);
					num = (short)883032423;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13E6:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.WiFi_Capability, 4, 5);
					num = (short)254476654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1435:
					num = (short)1631911975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1472:
					num = (short)1727922530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14B3:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.ASTRO_25_9600_Baud_Trunking_Systems_Operation, 11, 3);
					num = (short)1956839691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1503:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Front_Display_and_Full_Keypad, 12, 1);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꂖ", a_), 68, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsFrontDisplayFullKeypadUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Front_Display_and_Full_Keypad));
					num = (short)783810845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_155E:
					num = (short)2119893324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1638:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Collaborative_Phase_1, 11, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꊐꊒꊔꆖ", a_), 61, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsCollaborativePhase1UsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Collaborative_Phase_1));
					num = (short)600113571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1694:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.APX_DES_SOFTWARE_CRYPTO, 14, 4);
					num = (short)585498797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_176C:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.P_9600_or_3600_Single_System_Trigger, 9, 1);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꎐꮒ꒔Ꚗ", a_), 52, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsTrkSingleSystemTriggerUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.P_9600_or_3600_Single_System_Trigger));
					num = (short)365232525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17E7:
					num = (short)395247851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1862:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.DINC_PLUS_AUDIO, 4, 2);
					num = (short)822084030;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19C9:
					num = (short)2123235618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A31:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources._7_800_MHz, global::System.TypeCode.Byte, 3, 4, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꆒꆔꎖ", a_), 78, 3, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._7_800_MHz_Primary_Band));
					num = (short)1319829978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B5B:
					num = (short)1787953487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C69:
					radioInformation = radioInformation2;
					num = (short)1949630654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C88:
					num = (short)700776746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC3:
					num = (short)815464477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CFF:
					string name2 = text2;
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(name2, 73, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsMultiSystemOTARUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Multi_System_OTAR));
					num = (short)1088750050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D8A:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Extended_Dispatch_Enable, 8, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꞒꎔ꺖", a_), 36, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsExtendedDispatchEnabledInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Extended_Dispatch_Enable));
					num = (short)1991508028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DE5:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.GPS_Activation, 8, 0);
					num = (short)1441989043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E81:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.APX_Lite_Option, 9, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꎐ꒒ꂔꚖ", a_), 7, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsAPXLiUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.APX_Lite_Option));
					num = (short)435749117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F3A:
					num = (short)677445730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2038:
					num = (short)822870016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2077:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Site_Selectable_Alert_For_P25_Trunking, 10, 3);
					num = (short)1889927306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20F0:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.OTAR_with_Multikey, 2, 3);
					num = (short)1037238637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_213D:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.FCC_Conventional_Front_Panel_Programming, 10, 0);
					num = (short)1676673282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B5:
					num = (short)106496129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21F6:
					num = (short)971046917;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2235:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.UHF_Range_2, 3, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꂒꆔꊖ", a_), 82, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_2_Primary_Band));
					num = (short)1249378485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22FB:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.DVRS_PSU_Activation, 7, 0);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꖒꚔꚖ", a_), 40, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDVRSUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.DVRS_PSU_Activation));
					num = (short)1512702007;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_237A:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Motorcycle_Radio, 2, 0);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊벌벎ꦐ", a_), 16, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsMotorcycleRadioUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Motorcycle_Radio));
					num = (short)91685227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23D6:
					num = (short)825098670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2415:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.VHF, 3, 0);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꞖ", a_), 80, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_Primary_Band));
					num = (short)984547715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_248E:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Dual_Radio_Operation, 11, 4);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐꎒꂔ꾖", a_), 74, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDualRadioUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Dual_Radio_Operation));
					num = (short)1842938110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24E9:
					num = (short)879558818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25B4:
					num = (short)1266680151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_262D:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Enhanced_Data_Operation, 9, 4);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꊐꂒ겔꺖", a_), 56, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsEnhancedDataEnabledInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Enhanced_Data_Operation));
					num = (short)780534089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26AD:
					num = (short)1279983976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2855:
					num = (short)113115560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28C1:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Bluetooth_Id, 5, 1);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒ궔꒖", a_), 33, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsBluetoothUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Bluetooth_Id));
					num = (short)24117302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2939:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.UHF_Range_1, 3, 1);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꚖ", a_), 81, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_1_Primary_Band));
					num = (short)262734111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A44:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.ASTRO_Digital_Operation, 1, 0);
					num = (short)438763722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AE0:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.SMARTZONE_Systems_Operation, 6, 3);
					num = (short)35192836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BE1:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.SmartConnect, 12, 5);
					num = (short)1738408075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C5B:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AcgResources.ID_QA08715VOICECONTROLBASIC, 15, 5);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꦐ꒒꒔ꊖ", a_), 81, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.isVoiceControlBasic), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Voice_Control_Basic));
					num = (short)2056519737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D00:
					num = (short)1481638039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D8E:
					num = (short)1080754291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F33:
					num = (short)1849884975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3014:
					num = (short)1819934760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3078:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.ASK_Enable, 5, 3);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꂐꖒꆔ꾖", a_), 70, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsASKEnableUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.ASK_Enable));
					num = (short)1762328706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32E0:
					num = (short)1194131797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3357:
					num = (short)1064108366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3392:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Motorola_VML_Data_Modem_Tethering, 7, 5);
					num = (short)328925612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33F2:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Man_Down_Operation, 6, 1);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꂐꮒꆔ꒖", a_), 38, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsManDownUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Man_Down_Operation));
					num = (short)2013528365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_346D:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.SmartConnectOverBroadband, 14, 3);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꢐꎒꞔꖖ", a_), 100, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsSmartConnectUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.SmartConnectOverBroadband));
					num = (short)194183365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34C8:
					num = (short)1781006674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3593:
					num = (short)1810104356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_364C:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Enable_Dual_Band_Operation, 5, 0);
					num = (short)1866268762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37B0:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Night_Vision_Goggle, 11, 5);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎Ꞑꪒ궔ꊖ", a_), 97, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsNightVisionGoggleUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Night_Vision_Goggle));
					num = (short)381092243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38AB:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Advanced_Encryption_Standard, 4, 3);
					num = (short)879165879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38FA:
					num = (short)209780894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3965:
					num = (short)1924923771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39A0:
					num = (short)1248330192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A2D:
					num = (short)1263993250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A6E:
					num = (short)779813333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AFD:
					string name3 = text;
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(name3, 72, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDesSwCryptoUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Des_Sw_Software_Crypto));
					num = (short)1890910336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BAF:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.P25_Common_Air_Interface, 12, 3);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꊐ꒒ꎔ꾖", a_), 56, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsP25CommonAirInterfaceOptionUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.P25_Common_Air_Interface));
					num = (short)366936241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C0A:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Third_Party_Data_Modem_Tethering, 10, 5);
					num = (short)1826357381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CE7:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.One_Touch_Status_Message, 6, 4);
					num = (short)959119392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DF7:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.ID_VIQIVOICECONTROL, 14, 0);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꢐꎒꞔ꾖", a_), 79, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsViQi_VoiceControl), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Voice_Control));
					num = (short)1938227253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E70:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.UHF_Range_2, 3, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꊔꖖ", a_), 82, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_2_Primary_Band));
					num = (short)1993146716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EE8:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Personnel_Accountability_Software, 12, 0);
					num = (short)1686241421;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4023:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.LTE_ENABLEMENT, 15, 3);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꦐꮒ궔ꂖ", a_), 83, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.isLTEHwEnablement), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.LTE_ENABLEMENT));
					num = (short)2065956883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40C8:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.RSI_Data, 5, 5);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐꆒꎔꂖ", a_), 76, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsRSIDataUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.RSI_Data));
					num = (short)1211236360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4303:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Group_Services, 6, 5);
					num = (short)2079654132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4378:
					num = (short)79233373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43B3:
					num = (short)686686331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_448F:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.DVRS_PSU_CONVENTIONAL_SCAN_ENABLED, 14, 5);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊첌뾎ꆐꖒꊔꂖ", a_), 71, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsDVRSConScanUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.DVRS_PSU_CONVENTIONAL_SCAN_ENABLED));
					num = (short)572784820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4509:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Enhancement_Level_1, 8, 1);
					num = (short)358416857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4559:
					num = (short)2135884070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4595:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Packet_Data_Interface, 9, 0);
					num = (short)1979515182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4610:
					num = (short)15466668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46D7:
					global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint optionGate = optionGatingConstraint2;
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꂐꚒꆔꊖ", a_), 84, field, fldLayout, optionGate, global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Motorola_VML_Data_Modem_Tethering));
					num = (short)545325381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47C2:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.UHF_Range_1, 3, 1);
					num = (short)2085355557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_480F:
					num = (short)478412903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4898:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources.Primary_Band_800_900MHz, global::System.TypeCode.Byte, 3, 5, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꖐꮒ겔ꖖ", a_), 83, 3, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Primary_Band_800_900MHz));
					num = (short)2071527732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_491E:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AcgResources.ID_QA08676ADAPTIVESPEAKERVOLUME, 15, 4);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꦐꖒꊔꆖ", a_), 82, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.isAdaptiveSpeakerVolumeHOption), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.AdaptiveSpeakerVolume_HOption));
					num = (short)158793959;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4997:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Trunked_Radio_Trace_Remote_Monitor, 1, 4);
					num = (short)375783792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A86:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources._125_kHz_FCC_Mandate, 7, 3);
					num = (short)1637679584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B4A:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.RF_Preamp, 1, 1);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8a벌붎", a_), 10, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsPreAMPInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.RF_Preamp));
					num = (short)1597767925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BA4:
					num = (short)640352634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C32:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.ID_DIGITALTONESIGNALING, 2, 5);
					num = (short)564265249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D46:
					global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint optionGate2 = optionGatingConstraint;
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꢐꎒ꒔Ꚗ", a_), 86, field, fldLayout, optionGate2, global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Third_Part_Modem_Tethering));
					num = (short)1779236936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DAC:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Multikey_Id, 2, 2);
					num = (short)1611006358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DFB:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.GERMANFEDGOVENABLED_ID, 15, 1);
					string name4 = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊첌뾎ꆐꖒꊔ꺖", a_);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(name4, 74, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsGermanFedGovEnabledOptionUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.German_Fed_Gov_Enabled));
					num = (short)896926111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EEF:
					num = (short)907477224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F28:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout(global::CommonResources.AppResources._7_800_MHz, global::System.TypeCode.Byte, 3, 4, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꆐꚒꎔ꺖", a_), 78, 3, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._7_800_MHz_Primary_Band));
					num = (short)1389691185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_507F:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.TDMA_Operation, 11, 0);
					num = (short)182517956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5133:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Enhancement_Level_2, 6, 0);
					num = (short)2036400293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_524B:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.LTE_Operation, 8, 4);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꊐꂒꆔꎖ", a_), 73, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsLTEUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.LTE_Operation));
					num = (short)429982167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_52CE:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.VHF, 3, 0);
					num = (short)508756070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_531B:
					num = (short)548536560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5472:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Mission_Critical_Geofencing, 9, 5);
					num = (short)1152581738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54C2:
					num = (short)1904476541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5501:
					num = (short)1237975204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_558D:
					num = (short)1522991138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56B7:
					num = (short)1295843397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56F4:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources._900MHZ_ID, 3, 5);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꊐꎒꂔꆖ", a_), 87, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.BandsIgnoredOnClone), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._900MHZ_ID));
					num = (short)57213180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_579C:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.V24_Software_Enable, 9, 3);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊첌뾎ꆐꮒ겔꾖", a_), 55, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsV24SoftwareEnabledInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.V24_Software_Enable));
					num = (short)824377719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_582D:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Multi_System_OTAR, 14, 2);
					num = (short)2037121436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5945:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Enhanced_Zone_Bank, 5, 4);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꂐ꒒ꎔ꾖", a_), 32, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsEnhancedZoneBankUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Enhanced_Zone_Bank));
					num = (short)767230313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C87:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Extreme_Noise_Reduction, 7, 1);
					num = (short)951255447;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E52:
					num = (short)2115108961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E8D:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.SMARTZONE_OMNILINK_Multizone_Operation, 10, 2);
					num = (short)1630601403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FCC:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪊\udd8c힎놐쮒킔", a_), 1, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꎐꎒꖔꆖ", a_), 9, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.Is6000XEUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.APX6000XE));
					num = (short)593363192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62C0:
					num = (short)152371510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6349:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.P25_Radio_Authentication, 2, 4);
					num = (short)500629918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_643B:
					num = (short)1807089712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64A2:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.Conventional_Tactical_Rekey, 7, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎊붌뮎", a_), 39, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsCnvTactRekeyUsedInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Conventional_Tactical_Rekey));
					num = (short)2123891105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_651D:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.SMARTNET_Systems_Operation, 6, 2);
					num = (short)110297481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_656A:
					num = (short)1432945093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65D5:
					num = (short)1347092911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6611:
					fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AppResources.FDNY_Emergency_Rx_Tx_Tone_Set, 12, 2);
					this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첊떌몎Ꚑ", a_), 67, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.IsFDNYEmergencyRxTxToneSetInCpg), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.FDNY_Emergency_Rx_Tx_Tone_Set));
					num = (short)1270284605;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_361E:
				IL_6690:
				fldLayout = new global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout(global::CommonResources.AcgResources.ID_TACTICALSERVICES, 16, 0);
				this.a.Add(new global::SpecialFeatures.Flashport.FlashRadio.Option(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a첌뾎ꢐꎒ겔ꖖ", a_), 84, field, fldLayout, new global::SpecialFeatures.Flashport.FlashRadio.OptionGatingConstraint(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.isTacticalServicesHOption), global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Tactical_Services_HOption));
				return;
				IL_7C7:
				this.b = codeplugOpen;
				this.g = modelNumber;
				radioInformation = null;
				field = null;
				fldLayout = null;
				num = (short)1046741393;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00115FB0 File Offset: 0x001141B0
		public string GetOptionsInOffset(int bytePos, int bitPos)
		{
			int a_ = 15;
			short num = (short)1342570496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)302383105;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				string text;
				global::System.Collections.Generic.IList<global::SpecialFeatures.Flashport.FlashRadio.Option> optionsByOffset;
				for (;;)
				{
					IL_58:
					global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_237;
					case 1:
					{
						num = (short)928579584;
						short num3 = num;
						try
						{
							num = (short)1506410499;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									num = (short)733371907;
									short num4 = num;
									num = (short)2116509187;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_CC;
									default:
										num = (short)2139029504;
										if (num != 0)
										{
										}
										num = (short)977666050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1C8;
								case 3:
									goto IL_CC;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)348323841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
									text = text + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늑", a_) + option.ToString();
									num = (short)142475264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_F1;
								IL_CC:
								switch (0)
								{
								case 0:
									IL_F1:
									goto IL_F3;
								}
								continue;
								IL_F3:
								num = (short)144637956;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C8:
							return text;
						}
						finally
						{
							num = (short)91488258;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1034551297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_234;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1FF;
									}
									continue;
								}
								IL_1FF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)975437824;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_234:;
						}
						goto IL_237;
					}
					case 2:
						if (optionsByOffset != null)
						{
							num = (short)1235419136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					}
					goto IL_6B;
					IL_237:
					enumerator = optionsByOffset.GetEnumerator();
					num = (short)1705246721;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_6B:
				text = string.Empty;
				optionsByOffset = this.a.GetOptionsByOffset(bytePos, bitPos);
				num = (short)1898381314;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00116260 File Offset: 0x00114460
		internal bool IsOptionEnabledInFlashcode(string name, string flashcode, ref bool optionFound)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			bool result;
			global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					optionFound = true;
					result = this.IsOptionEnabledInFlashcode(optionByName, flashcode);
					num2 = (short)1958084610;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)402792602;
					short num3 = num2;
					num2 = (short)962601114;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)310444032;
						short num4 = num2;
						num2 = (short)2134835200;
						if (num2 != 0)
						{
						}
						if (optionByName != null)
						{
							num2 = (short)1502806017;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						optionFound = false;
						num2 = (short)1330380800;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_20;
			}
			return result;
			IL_20:
			num2 = (short)1264254977;
			if (num2 != 0)
			{
			}
			result = false;
			optionByName = this.a.GetOptionByName(name);
			num2 = (short)1009975299;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x001163AC File Offset: 0x001145AC
		public bool IsOptionEnabledInFlashcode(global::SpecialFeatures.Flashport.FlashRadio.Option opt, string flashcode)
		{
			int a_ = 15;
			short num = (short)807206912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				bool result;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (opt != null)
						{
							num = (short)1656684551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14E;
					case 1:
						if (opt.PositionArray == null)
						{
							num = (short)1826226179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A9;
					case 2:
					{
						byte[] array;
						if (array == null)
						{
							num = (short)532676613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1280694379;
						short num3 = num;
						num = (short)727046251;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_94;
						default:
							num = (short)254541824;
							if (num != 0)
							{
							}
							num = (short)405471233;
							if (num != 0)
							{
							}
							num = (short)562167809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						int num4 = (opt.Position - 1) / 8;
						byte[] array;
						int value = (int)array[num4];
						num = (short)253689860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int value;
						if (opt.Mask.Apply(value, global::Motorola.Acp.PackUnpack.Ish.Layouts.MaskApplication.Unpack) == opt.BitsValue)
						{
							num = (short)473694214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 5:
						goto IL_1A7;
					case 6:
						goto IL_94;
					case 7:
					{
						byte[] array = new byte[24];
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(flashcode, ref array);
						num = (short)1267924994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_D8;
					}
					goto IL_5B;
					IL_94:
					result = true;
					num = (short)283639808;
					short num5 = num;
					num = (short)748945416;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D8:
				return result;
				IL_14E:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("﶑", a_));
				IL_1A7:
				throw new global::System.ArgumentException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮑ望聯瞧肟쒡좣장\udba7슩쾫솭풯ힱ", a_));
				IL_1A9:
				throw new global::System.NotImplementedException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd91肟쮡쪣蚥욧얩슫莭펯\uddb1\udab3습톷\uddb9즻톽떿뇁ꃅ꓇ꯉ뿋ꛍ돏뷑냓돕꫙돛귝觟雡跣觥蛧駩쳫胭鿯蛱퓳闵跷裹軻鯽滿瘁栃缅⠇礉礋縍怏紑易戕紗縙", a_));
				IL_5B:
				result = false;
				num = (short)1077739520;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00116630 File Offset: 0x00114830
		internal bool AddOrDeleteHoptToCpg(string name, bool add)
		{
			short num2;
			bool result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::SpecialFeatures.Flashport.FlashRadio.Option optionByName;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)558759937;
						if (num2 != 0)
						{
						}
						result = true;
						num2 = (short)1320353793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_A5;
					case 2:
						if (this.AddOrDeleteHoptToCpg(optionByName, add))
						{
							num2 = (short)1850015744;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_1C;
				}
				IL_A5:
				num2 = (short)593231872;
				short num3 = num2;
				num2 = (short)1571119467;
				short num4 = num2;
				num2 = (short)11166059;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_103;
				}
				IL_1C:
				result = false;
				optionByName = this.a.GetOptionByName(name);
				num2 = (short)1926889474;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_103:
			num2 = (short)898301952;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00116758 File Offset: 0x00114958
		internal bool AddOrDeleteHoptToCpg(global::SpecialFeatures.Flashport.FlashRadio.Option opt, bool add)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (opt != null)
					{
						num2 = (short)928120840;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				case 1:
				{
					if (opt.PositionArray != null)
					{
						num2 = (short)1406074882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::AcpCommonLib.IAcpField dbField = opt.DbField;
					num2 = (short)1764884489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_23C;
				case 3:
				{
					num2 = (short)1123287040;
					short num3 = num2;
					int fldValue = 0;
					num2 = (short)623378439;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					global::AcpCommonLib.IAcpField dbField;
					int fldValue;
					this.SetFieldValue(dbField, fldValue);
					result = true;
					num2 = (short)2078670849;
					if (num2 != 0)
					{
					}
					num2 = (short)926089221;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_1B3;
				case 6:
					if (!add)
					{
						num2 = (short)968687619;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B8;
				case 7:
					goto IL_1B8;
				case 8:
				{
					int fldValue = opt.BitsValue;
					goto IL_131;
				}
				case 9:
				{
					global::AcpCommonLib.IAcpField dbField;
					if (dbField != null)
					{
						num2 = (short)1963261956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_41;
				IL_131:
				num2 = (short)858783750;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B8:
				num2 = (short)1947882551;
				short num4 = num2;
				num2 = (short)1108169783;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_131;
				default:
					num2 = (short)392626176;
					if (num2 != 0)
					{
					}
					num2 = (short)888799233;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_116:
			throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("麗ﾊ", a_));
			IL_1B3:
			return result;
			IL_23C:
			throw new global::System.NotImplementedException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좆麗ﾊﾐ떔ﺖ뮚쾠躢욤좦잨\udfaa쒬좮쒰\udcb2살쒶馸\uddba톼\udebe닀ꯂꛄ꣆귈껊뿎뻐ꃒ볔ꏖ냘듚돜곞쇠跢諤鏦짨裪飬鷮菰雲鯴菶闸苺\uddfc賾琀猂甄栆笈缊栌欎", a_));
			IL_41:
			result = false;
			num2 = (short)519503872;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x001169A8 File Offset: 0x00114BA8
		internal int GetFieldValue(global::AcpCommonLib.IAcpField acpField)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			short num2;
			global::System.Type type;
			object value;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpField is global::AcpBusinessLayer.AcpField<int>)
					{
						num2 = (short)1495072774;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1781006339;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_1B2;
				case 2:
				{
					global::System.Type[] genericArguments = type.GetGenericArguments();
					value = type.GetProperty(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("자璉ﲘ", a_), genericArguments[0]).GetValue(acpField, null);
					num2 = (short)1182072836;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (type.IsGenericType)
					{
						num2 = (short)1540292610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					value = type.GetProperty(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("자璉ﲘ", a_)).GetValue(acpField, null);
					num2 = (short)847118341;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_B1;
				case 5:
					goto IL_1E7;
				case 6:
				{
					num2 = (short)1425563541;
					short num3 = num2;
					num2 = (short)1105092501;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E9;
					default:
					{
						num2 = (short)1648361473;
						if (num2 != 0)
						{
						}
						num2 = (short)1940324352;
						if (num2 != 0)
						{
						}
						value = ((global::AcpBusinessLayer.AcpField<int>)acpField).Value;
						num2 = (short)527106048;
						short num4 = num2;
						num2 = (short)1471938561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_35;
			}
			IL_B1:
			IL_1B2:
			IL_1E7:
			IL_1E9:
			return global::System.Convert.ToInt32(value);
			IL_35:
			value = null;
			type = acpField.GetType();
			num2 = (short)240189440;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00116BA4 File Offset: 0x00114DA4
		public void SetFieldValue(global::AcpCommonLib.IAcpField field, int fldValue)
		{
			int a_ = 13;
			short num = (short)1992556544;
			switch (num)
			{
			default:
			{
				num = (short)324796416;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Reflection.PropertyInfo property;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 1:
					{
						global::System.Type type;
						global::System.Type[] genericArguments = type.GetGenericArguments();
						property = type.GetProperty(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욏ﶗ", a_), genericArguments[0]);
						num = (short)1439956995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Type type;
						if (type.IsGenericType)
						{
							num = (short)183762945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						property = type.GetProperty(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욏ﶗ", a_));
						num = (short)1338638340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_EB;
					case 4:
						goto IL_172;
					case 5:
						goto IL_84;
					}
					IL_64:
					if (field is global::AcpBusinessLayer.AcpField<int>)
					{
						num = (short)345374725;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::System.Type type = field.GetType();
						num = (short)1203044354;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_84:
				num = (short)67305472;
				short num3 = num;
				goto IL_132;
				IL_EB:
				goto IL_1E8;
				IL_132:
				((global::AcpBusinessLayer.AcpField<int>)field).Value = global::System.Convert.ToInt32(fldValue);
				return;
				IL_172:
				num = (short)351901249;
				short num4 = num;
				num = (short)1915196993;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_132;
				default:
					num = (short)1076035585;
					if (num != 0)
					{
					}
					num = (short)975110144;
					if (num != 0)
					{
					}
					break;
				}
				IL_1E8:
				global::System.TypeCode typeCode = global::System.Type.GetTypeCode(property.PropertyType);
				object value = global::System.Convert.ChangeType(fldValue, typeCode);
				property.SetValue(field, value, null);
				return;
			}
			}
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00116DBC File Offset: 0x00114FBC
		internal void Clear()
		{
			short num = (short)1091841207;
			short num2 = num;
			num = (short)770452663;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1800667136;
				if (num != 0)
				{
				}
				num = (short)764542978;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1518403585;
						if (num != 0)
						{
						}
						this.a.Clear();
						this.a = null;
						num = (short)792330241;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)1204420608;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					}
					}
					IL_A8:
					if (this.a == null)
					{
						break;
					}
					num = (short)2012086272;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			}
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00116EE0 File Offset: 0x001150E0
		internal void Close()
		{
			short num = (short)322329675;
			short num2 = num;
			num = (short)1042897995;
			switch (num2 == num)
			{
			}
			num = (short)1427701760;
			if (num != 0)
			{
			}
			num = (short)1366884352;
			short num3 = num;
			num = (short)454164481;
			if (num != 0)
			{
			}
			((global::System.IDisposable)this).Dispose();
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00116F8C File Offset: 0x0011518C
		private bool d()
		{
			short num = (short)792788992;
			short num2 = num;
			if (!this.f)
			{
				for (;;)
				{
					num = (short)1310822457;
					short num3 = num;
					num = (short)1754632249;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_66;
					}
				}
				IL_66:
				num = (short)1138884608;
				if (num != 0)
				{
				}
				num = (short)1378680833;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.IsMobile();
			}
			return !this.e;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0011704C File Offset: 0x0011524C
		private bool c()
		{
			short num = (short)394592256;
			short num2 = num;
			if (!this.f)
			{
				for (;;)
				{
					num = (short)207344027;
					short num3 = num;
					num = (short)391434651;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6A;
					}
				}
				IL_6A:
				num = (short)479592448;
				if (num != 0)
				{
				}
				num = (short)1298792449;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.IsPortable();
			}
			return this.e;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0011710C File Offset: 0x0011530C
		private bool b()
		{
			int a_ = 13;
			short num = (short)1996320917;
			short num2 = num;
			num = (short)192901269;
			switch (num2 == num)
			{
			}
			num = (short)16252929;
			if (num != 0)
			{
			}
			num = (short)144375808;
			short num3 = num;
			num = (short)2111045632;
			if (num != 0)
			{
			}
			return this.g == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑꎓ슕삗즙ꖛ캝鎡", a_);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x001171D4 File Offset: 0x001153D4
		private bool a()
		{
			short num = (short)1049700325;
			short num2 = num;
			num = (short)1716987877;
			switch (num2 == num)
			{
			}
			num = (short)1807351808;
			if (num != 0)
			{
			}
			num = (short)1224867840;
			short num3 = num;
			num = (short)1947467777;
			if (num != 0)
			{
			}
			return this.g[3] == 'V';
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0011728C File Offset: 0x0011548C
		public void Dispose()
		{
			short num = (short)1151270912;
			short num2 = num;
			if (this.c)
			{
				for (;;)
				{
					num = (short)1476326;
					short num3 = num;
					num = (short)1654097638;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6C;
					}
				}
				IL_6C:
				num = (short)303235072;
				if (num != 0)
				{
				}
				return;
			}
			num = (short)1656815617;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
			this.c = true;
			this.Clear();
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0011735C File Offset: 0x0011555C
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)2006514970;
			short num2 = num;
			num = (short)1574829338;
			switch (num2 == num)
			{
			default:
			{
				num = (short)960364544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)548143104;
			if (num != 0)
			{
			}
			num = (short)1346568193;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400064E RID: 1614
		private global::SpecialFeatures.Flashport.FlashRadio.Flashcode a;

		// Token: 0x0400064F RID: 1615
		private bool b;

		// Token: 0x04000650 RID: 1616
		private bool c;

		// Token: 0x04000651 RID: 1617
		private bool d;

		// Token: 0x04000652 RID: 1618
		private bool e;

		// Token: 0x04000653 RID: 1619
		private bool f;

		// Token: 0x04000654 RID: 1620
		private string g = "";
	}
}
