using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AcpBusinessLayer;
using AcpCommonLib;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Tts;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.Wide
{
	// Token: 0x0200001D RID: 29
	public static class VoiceAnnouncementsConstraints
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
		internal static bool ConIsVARecRefSelectionValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)741736454;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.FeatureNode featureNode;
			for (;;)
			{
				global::AcpCommonLib.IAcpField acpField;
				global::AcpBusinessLayer.Recordset recordset;
				global::AcpBusinessLayer.Recordset recordset2;
				switch (num2)
				{
				case 0:
				{
					global::SpecialFeatures.VoiceAnnouncements.Wide.General general = self as global::SpecialFeatures.VoiceAnnouncements.Wide.General;
					if (general == null)
					{
						num = (short)539099147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					acpField = general.CurrentField;
					goto IL_191;
				}
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					if (index > recordset.Count)
					{
						num = (short)1852768265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					featureNode = (recordset[index - 1] as global::AcpBusinessLayer.FeatureNode);
					num = (short)1410727946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					recordset2 = null;
					goto IL_1BD;
				case 5:
					goto IL_1D6;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 7:
					return true;
				case 8:
					return false;
				case 9:
					return true;
				case 10:
					if (featureNode == null)
					{
						num = (short)1817772039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_275;
				case 11:
					acpField = null;
					goto IL_191;
				case 12:
					if (!global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.VerifyTtsValueSupport(index))
					{
						num = (short)2064842753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1571291136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_59:
				num = (short)2070937601;
				if (num != 0)
				{
				}
				num = (short)1874067456;
				short num3 = num;
				if (index != 0)
				{
					num = (short)1721827340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1199337532;
				short num4 = num;
				num = (short)104755260;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1D6;
				default:
					num = (short)1036058624;
					if (num != 0)
					{
					}
					num = (short)1142620162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_191:
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField = acpField as global::AcpBusinessLayer.AcpRecRefField;
				if (acpRecRefField == null)
				{
					num = (short)1889665028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				recordset2 = acpRecRefField.RefRecset;
				IL_1BD:
				recordset = recordset2;
				num = (short)1442381829;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D6:
				if (recordset == null)
				{
					num = (short)167510024;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1693384707;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_275:
			return featureNode.KeyField.Valid;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0004C568 File Offset: 0x0004A768
		public static bool VerifyTtsValueSupport(int index)
		{
			switch (0)
			{
			case 0:
				goto IL_9A;
			}
			short num;
			int num4;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			for (;;)
			{
				IL_0A:
				num = (short)1292726120;
				short num2 = num;
				num = (short)1581870952;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)805371904;
					short num3 = num;
					num = (short)2092630016;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (!radioInformation.Labtool.RadInfoLabtoolQA09028ViQi_VoiceControlValue)
						{
							num = (short)2004484101;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (!radioInformation.Labtool.radInfoLabtoolQA08715VoiceControlBasicValue)
						{
							goto IL_157;
						}
						return true;
					case 2:
						return false;
					case 3:
						num = (short)1961361412;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (index == 65535)
						{
							num = (short)1188691970;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						num = (short)1534328833;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A;
				}
				}
				IL_157:
				num = (short)1544028161;
				if (num != 0)
				{
				}
				num = (short)412745731;
				num4 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_9A:
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num = (short)2060124160;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0004C710 File Offset: 0x0004A910
		public static bool ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			if (global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.a(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide))
			{
				num = (short)790705285;
				short num2 = num;
				num = (short)1005401221;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)791543808;
					if (num != 0)
					{
					}
					num = (short)1310588929;
					if (num != 0)
					{
					}
					return true;
				}
			}
			num = (short)2077556736;
			short num3 = num;
			global::SpecialFeatures.VoiceAnnouncements.Wide.General general = global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.a(self);
			return global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldsByName[general.CurrentField.Name].VoiceAnnouncementId(general).Value == 65535;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0004C80C File Offset: 0x0004AA0C
		public static bool ConSetVAPriorityFieldInapplicableAndLowForNFPAModelsAndNFPACompliantEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			int num3;
			bool flag;
			global::AcpBusinessLayer.AcpSparseLOVField voiceAnnouncementPriority_A;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1080098816;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (flag)
						{
							num = (short)1407123457;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						goto IL_166;
					case 2:
						num = (short)748224512;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)880381081;
						short num4 = num;
						num = (short)961252505;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7B;
						default:
							num = (short)1545666560;
							if (num != 0)
							{
							}
							if (global::ConstraintHelper.UtilityMack.IsAPXNextOrAloha)
							{
								num = (short)1732313089;
								if (num != 0)
								{
								}
								num = (short)846921730;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						break;
					}
					}
					goto IL_4A;
				}
				IL_166:
				voiceAnnouncementPriority_A.Value = 0;
				return false;
			}
			IL_4A:
			voiceAnnouncementPriority_A = (self as global::SpecialFeatures.VoiceAnnouncements.Wide.General).VoiceAnnouncementPriority_A7651;
			flag = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Features.RadWideFeaturesNFPACompliant;
			IL_7B:
			num = (short)338427907;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0004C984 File Offset: 0x0004AB84
		public static bool ConValidateTTSFieldAndDuration(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			short num;
			int num3;
			string value;
			global::SpecialFeatures.VoiceAnnouncements.Wide.General general;
			for (;;)
			{
				IL_0A:
				num = (short)1492385792;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (string.IsNullOrWhiteSpace(value))
					{
						num = (short)429195265;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 1:
					return false;
				case 2:
					goto IL_119;
				case 3:
				{
					num = (short)606986291;
					short num4 = num;
					num = (short)1085399091;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
					{
						num = (short)383778816;
						if (num != 0)
						{
						}
						int value2 = global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldsByName[general.CurrentField.Name].VoiceAnnouncementId(general).Value;
						value = global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldsByName[general.CurrentField.Name].TtsText(general).Value;
						if (value2 != 65535)
						{
							num = (short)401408002;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2050228224;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_49;
			}
			IL_119:
			num = (short)2086338561;
			if (num != 0)
			{
			}
			return true;
			IL_182:
			return global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.CheckTTSVoiceDuration(value);
			IL_49:
			general = global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.a(self);
			num = (short)1699479555;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0004CB1C File Offset: 0x0004AD1C
		private static global::SpecialFeatures.VoiceAnnouncements.Wide.General a(global::AcpCommonLib.IAcpFeatureSection A_0)
		{
			short num = (short)771669751;
			short num2 = num;
			num = (short)1829486327;
			switch (num2 == num)
			{
			}
			num = (short)322568193;
			if (num != 0)
			{
			}
			num = (short)894107648;
			if (num != 0)
			{
			}
			num = (short)1072627712;
			short num3 = num;
			return A_0 as global::SpecialFeatures.VoiceAnnouncements.Wide.General;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
		public static bool ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			bool result;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = false;
					num2 = (short)510459905;
					if (num2 != 0)
					{
					}
					num2 = (short)801374209;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					if (index == 0)
					{
						num2 = (short)596049920;
						short num3 = num2;
						num2 = (short)1303642112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)1751318530;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					if (!global::ConstraintHelper.UtilityMack.IsAPXNextOrAloha || !flag)
					{
						return result;
					}
					num2 = (short)792563360;
					short num4 = num2;
					num2 = (short)810127008;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1845166080;
						if (num2 != 0)
						{
						}
						num2 = (short)894828547;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			flag = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Features.RadWideFeaturesNFPACompliant;
			result = true;
			num2 = (short)904855556;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0004CD4C File Offset: 0x0004AF4C
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide A_0)
		{
			if (A_0 != null)
			{
				short num = (short)1798151829;
				short num2 = num;
				num = (short)870620821;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2424833;
					if (num != 0)
					{
					}
					num = (short)248119296;
					short num3 = num;
					num = (short)215089152;
					if (num != 0)
					{
					}
					return A_0.Features.RadWideFeaturesVoiceControlPriority.Value != 0;
				}
				}
			}
			return true;
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0004CE14 File Offset: 0x0004B014
		private static global::System.Collections.Generic.Dictionary<string, global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors> FieldsByName
		{
			get
			{
				int a_ = 12;
				short num = (short)83820545;
				if (num != 0)
				{
				}
				num = (short)876986148;
				short num2 = num;
				num = (short)582401828;
				switch (num2 == num)
				{
				}
				num = (short)1771896832;
				short num3 = num;
				num = (short)1160118272;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<string, global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors> dictionary = new global::System.Collections.Generic.Dictionary<string, global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors>();
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ캜ﲞ삠춢즦얪쎬삮쒰\uddb2횴튶풸\udeba펼쮾韀곂계꓆곈裊ꋌꋎ볐닒믔돖", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1084060197;
					short num5 = num4;
					num4 = (short)480473637;
					switch (num5 == num4)
					{
					}
					num4 = (short)1452736512;
					if (num4 != 0)
					{
					}
					num4 = (short)192086016;
					short num6 = num4;
					num4 = (short)137494529;
					if (num4 != 0)
					{
					}
					return general.ScanOnAnnouncementID_A22250;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)2021456630;
					short num5 = num4;
					num4 = (short)1345714934;
					switch (num5 == num4)
					{
					}
					num4 = (short)357892097;
					if (num4 != 0)
					{
					}
					num4 = (short)2002780160;
					short num6 = num4;
					num4 = (short)1518927872;
					if (num4 != 0)
					{
					}
					return general.RadErgoScanOnAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ캜ﲞ삠춢솦쾨쎬솮\udeb0욲\udbb4풶\udcb8횺\ud8bc톾뗀闂꫄껆꫈껊軌ꃎ볐뻒듔맖뷘", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)953898279;
					short num5 = num4;
					num4 = (short)1131173159;
					switch (num5 == num4)
					{
					}
					num4 = (short)1440677889;
					if (num4 != 0)
					{
					}
					num4 = (short)659095552;
					short num6 = num4;
					num4 = (short)1324613632;
					if (num4 != 0)
					{
					}
					return general.ScanOffAnnouncementID_A22252;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)42920325;
					short num5 = num4;
					num4 = (short)1659758981;
					switch (num5 == num4)
					{
					}
					num4 = (short)1448542209;
					if (num4 != 0)
					{
					}
					num4 = (short)1266024448;
					short num6 = num4;
					num4 = (short)1672740864;
					if (num4 != 0)
					{
					}
					return general.RadErgoScanOffAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ킜쾠쪢톤좦\udba8쎬瑩\udeb0\udab2횴튶視풺킼튾ꃀ귂ꇄ", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1822031873;
					if (num4 != 0)
					{
					}
					num4 = (short)811825803;
					short num5 = num4;
					num4 = (short)1614772875;
					switch (num5 == num4)
					{
					}
					num4 = (short)64421888;
					short num6 = num4;
					num4 = (short)1490747392;
					if (num4 != 0)
					{
					}
					return general.MonitorOnAnnouncementID_A22254;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1236595693;
					short num5 = num4;
					num4 = (short)286061549;
					switch (num5 == num4)
					{
					}
					num4 = (short)700645377;
					if (num4 != 0)
					{
					}
					num4 = (short)1144324096;
					short num6 = num4;
					num4 = (short)1360134144;
					if (num4 != 0)
					{
					}
					return general.RadErgoMonitorOnVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ킜쾠쪢톤좦\udba8쮬즮\udcb2\udcb4풶\udcb8튼튾곀ꋂꯄꏆ", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1778996827;
					short num5 = num4;
					num4 = (short)1259427419;
					switch (num5 == num4)
					{
					}
					num4 = (short)245301249;
					if (num4 != 0)
					{
					}
					num4 = (short)1406730240;
					short num6 = num4;
					num4 = (short)1248919552;
					if (num4 != 0)
					{
					}
					return general.MonitorOffAnnouncementID_A22256;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)379060225;
					if (num4 != 0)
					{
					}
					num4 = (short)1635428035;
					short num5 = num4;
					num4 = (short)1032234691;
					switch (num5 == num4)
					{
					}
					num4 = (short)246218752;
					short num6 = num4;
					num4 = (short)821362688;
					if (num4 != 0)
					{
					}
					return general.RadErgoMonitorOffVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ\ud99c펠욢욤펦쒪즬쪮ﺰ\uddb2\ud8b6킸\ud8ba\ud8bcﲾ껀껂꣄ꛆꟈ꿊", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)351770862;
					short num5 = num4;
					num4 = (short)1801033966;
					switch (num5 == num4)
					{
					}
					num4 = (short)1547239425;
					if (num4 != 0)
					{
					}
					num4 = (short)2125332480;
					short num6 = num4;
					num4 = (short)780730368;
					if (num4 != 0)
					{
					}
					return general.DirectModeOnAnnouncementID_A22258;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)55246849;
					if (num4 != 0)
					{
					}
					num4 = (short)1509217170;
					short num5 = num4;
					num4 = (short)1436865426;
					switch (num5 == num4)
					{
					}
					num4 = (short)623312896;
					short num6 = num4;
					num4 = (short)1332543488;
					if (num4 != 0)
					{
					}
					return general.RadErgoDirectModeOnVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ\ud99c펠욢욤펦쒪즬쪮ﺰ햲펴횸튺\udebc\udabe苀곂꣄꫆꣈ꗊ꧌", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1760317301;
					short num5 = num4;
					num4 = (short)911363957;
					switch (num5 == num4)
					{
					}
					num4 = (short)546177025;
					if (num4 != 0)
					{
					}
					num4 = (short)1267531776;
					short num6 = num4;
					num4 = (short)88080384;
					if (num4 != 0)
					{
					}
					return general.DirectModeOffAnnouncementID_A22121;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)119868832;
					short num5 = num4;
					num4 = (short)607980960;
					switch (num5 == num4)
					{
					}
					num4 = (short)1023934465;
					if (num4 != 0)
					{
					}
					num4 = (short)711983104;
					short num6 = num4;
					num4 = (short)416088064;
					if (num4 != 0)
					{
					}
					return general.RadErgoDirectModeOffVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ즜춢춤캦쮨슪\ud9ac\udfb0\udab4\udeb6\udab8\udebaﺼ킾곀껂꓄꧆귈", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)3467725;
					short num5 = num4;
					num4 = (short)1362029005;
					switch (num5 == num4)
					{
					}
					num4 = (short)981598209;
					if (num4 != 0)
					{
					}
					num4 = (short)707788800;
					if (num4 != 0)
					{
					}
					num4 = (short)927203328;
					short num6 = num4;
					return general.TxInhibitOnAnnouncementID_A22260;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)151656893;
					short num5 = num4;
					num4 = (short)1832982973;
					switch (num5 == num4)
					{
					}
					num4 = (short)1346961409;
					if (num4 != 0)
					{
					}
					num4 = (short)926416896;
					if (num4 != 0)
					{
					}
					num4 = (short)601817088;
					short num6 = num4;
					return general.RadErgoTxInhibitOnVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ즜춢춤캦쮨슪\ud9acힰ햲\ud8b6킸\ud8ba\ud8bcﲾ껀껂꣄ꛆꟈ꿊", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)974690158;
					short num5 = num4;
					num4 = (short)1621792622;
					switch (num5 == num4)
					{
					}
					num4 = (short)942342145;
					if (num4 != 0)
					{
					}
					num4 = (short)161218560;
					if (num4 != 0)
					{
					}
					num4 = (short)253689856;
					short num6 = num4;
					return general.TxInhibitOffAnnouncementID_A22262;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1936004908;
					short num5 = num4;
					num4 = (short)1873942316;
					switch (num5 == num4)
					{
					}
					num4 = (short)189399040;
					if (num4 != 0)
					{
					}
					num4 = (short)1358888961;
					if (num4 != 0)
					{
					}
					num4 = (short)1898840064;
					short num6 = num4;
					return general.RadErgoTxInhibitOffVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ풜슢즤쮦ﲨ\ud8aa좬\uddae\udfb2킴얶춸펼껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)396369082;
					short num5 = num4;
					num4 = (short)1726160058;
					switch (num5 == num4)
					{
					}
					num4 = (short)1442250752;
					if (num4 != 0)
					{
					}
					num4 = (short)1901592577;
					if (num4 != 0)
					{
					}
					num4 = (short)789708800;
					short num6 = num4;
					return general.RadErgoCfgVAWide_A41497;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1801579411;
					short num5 = num4;
					num4 = (short)1995631507;
					switch (num5 == num4)
					{
					}
					num4 = (short)575012864;
					if (num4 != 0)
					{
					}
					num4 = (short)1410465793;
					if (num4 != 0)
					{
					}
					num4 = (short)847183872;
					short num6 = num4;
					return general.RadErgoInCallUserAlertOnVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ풜슢즤쮦ﲨ\ud8aa좬\uddae\udfb2킴얶춸\udbbc\ud9be韀곂계꓆곈裊ꋌꋎ볐닒믔돖", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1564516164;
					short num5 = num4;
					num4 = (short)348954436;
					switch (num5 == num4)
					{
					}
					num4 = (short)1644429313;
					if (num4 != 0)
					{
					}
					num4 = (short)2106982400;
					if (num4 != 0)
					{
					}
					num4 = (short)1413480448;
					short num6 = num4;
					return general.RadErgoCfgVAWide_A41499;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)874024424;
					short num5 = num4;
					num4 = (short)2013695464;
					switch (num5 == num4)
					{
					}
					num4 = (short)129171457;
					if (num4 != 0)
					{
					}
					num4 = (short)1615790080;
					if (num4 != 0)
					{
					}
					num4 = (short)266010624;
					short num6 = num4;
					return general.RadErgoInCallUserAlertOffVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ\ud89c쒠톢스슦잨좪풬\udfb0\udab4\udeb6\udab8\udebaﺼ킾곀껂꓄꧆귈", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1463746156;
					short num5 = num4;
					num4 = (short)1459093100;
					switch (num5 == num4)
					{
					}
					num4 = (short)354353153;
					if (num4 != 0)
					{
					}
					num4 = (short)263520256;
					if (num4 != 0)
					{
					}
					num4 = (short)1603469312;
					short num6 = num4;
					return general.RadErgoCfgVAWide_A41500;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)197203157;
					short num5 = num4;
					num4 = (short)789189845;
					switch (num5 == num4)
					{
					}
					num4 = (short)1809973248;
					if (num4 != 0)
					{
					}
					num4 = (short)1336541185;
					if (num4 != 0)
					{
					}
					num4 = (short)1000079360;
					short num6 = num4;
					return general.RadErgoEmergencyOnVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ캜爵슠횢힤슦ﶨ펪ﺬ쪮\uddb0횲횴쎶햺킾ꣀꃂꃄ蓆ꛈꛊꃌ껎뿐럒", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1121483537;
					short num5 = num4;
					num4 = (short)918715153;
					switch (num5 == num4)
					{
					}
					num4 = (short)345702401;
					if (num4 != 0)
					{
					}
					num4 = (short)670957568;
					if (num4 != 0)
					{
					}
					num4 = (short)889847808;
					short num6 = num4;
					return general.RadErgoCfgVAWide_A41501;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1490906203;
					short num5 = num4;
					num4 = (short)1444506715;
					switch (num5 == num4)
					{
					}
					num4 = (short)1525284864;
					if (num4 != 0)
					{
					}
					num4 = (short)884539393;
					if (num4 != 0)
					{
					}
					num4 = (short)708706304;
					short num6 = num4;
					return general.RadErgoSecureTxSelectOnVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ캜爵슠횢힤슦ﶨ펪ﺬ쪮\uddb0횲횴쎶\uddba\udbbc껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)2042429441;
					if (num4 != 0)
					{
					}
					num4 = (short)263119179;
					short num5 = num4;
					num4 = (short)268230987;
					switch (num5 == num4)
					{
					}
					num4 = (short)12451840;
					if (num4 != 0)
					{
					}
					num4 = (short)1130430464;
					short num6 = num4;
					return general.RadErgoCfgVAWide_A41502;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1757130435;
					short num5 = num4;
					num4 = (short)1688514243;
					switch (num5 == num4)
					{
					}
					num4 = (short)671612929;
					if (num4 != 0)
					{
					}
					num4 = (short)1294073856;
					if (num4 != 0)
					{
					}
					num4 = (short)1075118080;
					short num6 = num4;
					return general.RadErgoSecureTxSelectOffVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ횜爵\ud8a0쒤쎦쒪쎬\udbae쎰\udcb2\ud9b4쒶풺\udebc풾軀귂鏄꣆ꃈ꣊꣌賎뻐뻒룔뛖럘뿚", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1376976708;
					short num5 = num4;
					num4 = (short)597622596;
					switch (num5 == num4)
					{
					}
					num4 = (short)715849728;
					if (num4 != 0)
					{
					}
					num4 = (short)468844545;
					if (num4 != 0)
					{
					}
					num4 = (short)256114688;
					short num6 = num4;
					return general.RadErgoCfgVAWide_A41503;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1149553818;
					short num5 = num4;
					num4 = (short)900254874;
					switch (num5 == num4)
					{
					}
					num4 = (short)2015166465;
					if (num4 != 0)
					{
					}
					num4 = (short)517013504;
					if (num4 != 0)
					{
					}
					num4 = (short)1883897856;
					short num6 = num4;
					return general.RadErgoKeyPadControlsLockOnVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ횜爵\ud8a0쒤쎦쒪쎬\udbae쎰\udcb2\ud9b4쒶풺\udebc풾軀ꗂꏄ釆ꛈꋊ껌꫎鋐볒룔뫖룘뗚맜", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)610234685;
					short num5 = num4;
					num4 = (short)1123119421;
					switch (num5 == num4)
					{
					}
					num4 = (short)656932865;
					if (num4 != 0)
					{
					}
					num4 = (short)136970240;
					if (num4 != 0)
					{
					}
					num4 = (short)840171520;
					short num6 = num4;
					return general.RadErgoCfgVAWide_A41504;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)2051205913;
					short num5 = num4;
					num4 = (short)423947033;
					switch (num5 == num4)
					{
					}
					num4 = (short)1176829953;
					if (num4 != 0)
					{
					}
					num4 = (short)880607232;
					if (num4 != 0)
					{
					}
					num4 = (short)954204160;
					short num6 = num4;
					return general.RadErgoKeyPadControlsLockOffVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ킜춠힢첤\udca8얪\ud9ac욮\udeb0\uddb2풴\udbb6﮸캺즼쮾껀귂闄뗆ꃈꛊ곌뷎꣐黒뫔돖볘飚닜닞賠苢诤菦", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)3641903;
					short num5 = num4;
					num4 = (short)22647343;
					switch (num5 == num4)
					{
					}
					num4 = (short)982450176;
					if (num4 != 0)
					{
					}
					num4 = (short)477298689;
					if (num4 != 0)
					{
					}
					num4 = (short)1910112256;
					short num6 = num4;
					return general.RadErgoCfgVAWide_A41505;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)391270586;
					short num5 = num4;
					num4 = (short)1387942074;
					switch (num5 == num4)
					{
					}
					num4 = (short)1852768256;
					if (num4 != 0)
					{
					}
					num4 = (short)1024458753;
					if (num4 != 0)
					{
					}
					num4 = (short)2109210624;
					short num6 = num4;
					return general.RadErgoMultiFuntionalButtonPrimaryModeCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ킜춠힢첤\udca8얪\ud9ac욮\udeb0\uddb2풴\udbb6﮸캺즼쮾껀귂雄ꋆ꫈꓊ꏌꯎ냐ꇒ곔髖뛘뿚룜鳞軠転裤蛦蟨迪", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)133444961;
					short num5 = num4;
					num4 = (short)1958294881;
					switch (num5 == num4)
					{
					}
					num4 = (short)481951744;
					if (num4 != 0)
					{
					}
					num4 = (short)1613758465;
					if (num4 != 0)
					{
					}
					num4 = (short)1784414208;
					short num6 = num4;
					return general.RadErgoCfgVAWide_A41506;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1769557505;
					short num5 = num4;
					num4 = (short)1599884801;
					switch (num5 == num4)
					{
					}
					num4 = (short)389480449;
					if (num4 != 0)
					{
					}
					num4 = (short)1489895424;
					if (num4 != 0)
					{
					}
					num4 = (short)2085814272;
					short num6 = num4;
					return general.RadErgoMultiFuntionalButtonSecondaryModeCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ쪜캠춢스좨\udfaa\ud9ac쪮쎰쪲\ud8b6킸\ud8ba\ud8bcﲾ껀껂꣄ꛆꟈ꿊", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)463219089;
					short num5 = num4;
					num4 = (short)70855057;
					switch (num5 == num4)
					{
					}
					num4 = (short)1252982785;
					if (num4 != 0)
					{
					}
					num4 = (short)1814560768;
					if (num4 != 0)
					{
					}
					num4 = (short)987693056;
					short num6 = num4;
					return general.WrongBatteryOnAnnouncementID_43251;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1418304870;
					short num5 = num4;
					num4 = (short)87072102;
					switch (num5 == num4)
					{
					}
					num4 = (short)34537473;
					if (num4 != 0)
					{
					}
					num4 = (short)721092608;
					if (num4 != 0)
					{
					}
					num4 = (short)1672740864;
					short num6 = num4;
					return general.RadErgoWrongBatteryVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ튜쒠톢슦쒨\udbaa좬\uddae킰잲살얶\udcb8諸펼톾껀뛂ꯄ꓆곈ꛊ꣌ꇎꗐ藒뫔뻖뫘뻚黜냞賠転蓤触跨", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1094761630;
					short num5 = num4;
					num4 = (short)2104212638;
					switch (num5 == num4)
					{
					}
					num4 = (short)399638528;
					if (num4 != 0)
					{
					}
					num4 = (short)54853633;
					if (num4 != 0)
					{
					}
					num4 = (short)426967040;
					short num6 = num4;
					return general.RadErgoCfgVAWideOverTemperature;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)391626203;
					short num5 = num4;
					num4 = (short)1826143707;
					switch (num5 == num4)
					{
					}
					num4 = (short)698613761;
					if (num4 != 0)
					{
					}
					num4 = (short)147456000;
					if (num4 != 0)
					{
					}
					num4 = (short)1463222272;
					short num6 = num4;
					return general.RadErgoOverTemperatureAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ쾜咽욢펤캦쪨캪\udaae\udcb0욲\ud9b4횶춸튺쮼\udabe軀뗂ꃄ뗆鷈껊ꃌ뿎듐ꇒ듔ꏖ곘꧚룜點迠跢諤鋦蟨裪裬苮铰鷲致ꇶ雸鋺黼髾䈀氂栄樆栈攊椌", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)804080537;
					short num5 = num4;
					num4 = (short)2015316889;
					switch (num5 == num4)
					{
					}
					num4 = (short)1468334081;
					if (num4 != 0)
					{
					}
					num4 = (short)1328611328;
					if (num4 != 0)
					{
					}
					num4 = (short)4718592;
					short num6 = num4;
					return general.RadErgoCfgVAWideRFDeviceCumulativeOverTemperature;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)2034232315;
					short num5 = num4;
					num4 = (short)1188621307;
					switch (num5 == num4)
					{
					}
					num4 = (short)905707521;
					if (num4 != 0)
					{
					}
					num4 = (short)341835776;
					if (num4 != 0)
					{
					}
					num4 = (short)484507648;
					short num6 = num4;
					return general.RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ튜햠쪢쪤즦좨잪삮\udcb0쎲\udab4\ud9b6\udcb8햺즼ﲾ듀껂냄ꯆ꣈뿊꓌많듐鳒ꏔ닖ꯘ迚룜닞釠蛢韤蛦鷨黪鿬諮냰鷲鯴飶賸闺黼髾氀昂欄猆弈搊搌氎琐倒稔稖琘稚猜笞", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)442439356;
					short num5 = num4;
					num4 = (short)1501959868;
					switch (num5 == num4)
					{
					}
					num4 = (short)437780481;
					if (num4 != 0)
					{
					}
					num4 = (short)2009726976;
					if (num4 != 0)
					{
					}
					num4 = (short)1588658176;
					short num6 = num4;
					return general.RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)2046271541;
					short num5 = num4;
					num4 = (short)610770997;
					switch (num5 == num4)
					{
					}
					num4 = (short)292225025;
					if (num4 != 0)
					{
					}
					num4 = (short)516816896;
					if (num4 != 0)
					{
					}
					num4 = (short)171114496;
					short num6 = num4;
					return general.RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ\udf9cﺞ햠힢삤햦킨\ud8ac슮쒰\udfb2풴쎶킸춺\ud8bc럀ꛂ럄鏆곈ꛊ뷌꫎ꏐ닒ꇔꋖꯘ뻚鳜뇞迠賢郤触諨軪胬諮鿰蟲ꏴ飶郸飺飼볾渀渂栄昆月漊", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)994246657;
					if (num4 != 0)
					{
					}
					num4 = (short)296964447;
					short num5 = num4;
					num4 = (short)135483743;
					switch (num5 == num4)
					{
					}
					num4 = (short)660865024;
					if (num4 != 0)
					{
					}
					num4 = (short)1692532736;
					short num6 = num4;
					return general.RadErgoCfgVAWideBatteryCumulativeOverTemperature;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1064173569;
					if (num4 != 0)
					{
					}
					num4 = (short)1707187370;
					short num5 = num4;
					num4 = (short)143760554;
					switch (num5 == num4)
					{
					}
					num4 = (short)124321792;
					if (num4 != 0)
					{
					}
					num4 = (short)434831360;
					short num6 = num4;
					return general.RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ펜쾠ﾤ좪캬쪮슰삲\udab4얶삸諸펼톾껀뛂ꯄ꓆곈ꛊ꣌ꇎꗐ藒뫔뻖뫘뻚黜냞賠転蓤触跨", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1151475698;
					short num5 = num4;
					num4 = (short)1165107186;
					switch (num5 == num4)
					{
					}
					num4 = (short)802816001;
					if (num4 != 0)
					{
					}
					num4 = (short)1178927104;
					if (num4 != 0)
					{
					}
					num4 = (short)1867776000;
					short num6 = num4;
					return general.RadErgoCfgVAWideNonHZMAccessory;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1941317348;
					short num5 = num4;
					num4 = (short)1957242596;
					switch (num5 == num4)
					{
					}
					num4 = (short)1555693569;
					if (num4 != 0)
					{
					}
					num4 = (short)1932918784;
					if (num4 != 0)
					{
					}
					num4 = (short)1540423680;
					short num6 = num4;
					return general.RadErgoNonHZMAccessoryAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ\ud89c좠힢욦펨쪪\udfac쮮\udcb2\udbb4튶풺\ud9bc\udabe胀귂ꯄ꣆볈ꗊ껌꫎볐뛒믔ꏖ还듚드볞蓠ꃢ諤諦蓨諪菬诮", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1507786753;
					if (num4 != 0)
					{
					}
					num4 = (short)36741835;
					short num5 = num4;
					num4 = (short)1864016587;
					switch (num5 == num4)
					{
					}
					num4 = (short)1749942272;
					if (num4 != 0)
					{
					}
					num4 = (short)2033582080;
					short num6 = num4;
					return general.RadErgoCfgVAWideExitHazardZoneMode;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)267845633;
					if (num4 != 0)
					{
					}
					num4 = (short)927778422;
					short num5 = num4;
					num4 = (short)1012582006;
					switch (num5 == num4)
					{
					}
					num4 = (short)957874176;
					if (num4 != 0)
					{
					}
					num4 = (short)1404960768;
					short num6 = num4;
					return general.RadErgoExitHazardZoneModeAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ튜햠쎤좨얪쪬쪮\uddb2\udbb4\ud8b6첸햺\udebc\udabe곀ꛂꯄ돆鿈꓊꓌곎듐郒뫔뫖듘뫚돜믞", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1549739913;
					short num5 = num4;
					num4 = (short)297478025;
					switch (num5 == num4)
					{
					}
					num4 = (short)1879179264;
					if (num4 != 0)
					{
					}
					num4 = (short)1826816001;
					if (num4 != 0)
					{
					}
					num4 = (short)467140608;
					short num6 = num4;
					return general.RadErgoCfgVAWideOutOfRange;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1126528884;
					short num5 = num4;
					num4 = (short)242382708;
					switch (num5 == num4)
					{
					}
					num4 = (short)1043529728;
					if (num4 != 0)
					{
					}
					num4 = (short)208863233;
					if (num4 != 0)
					{
					}
					num4 = (short)294453248;
					short num6 = num4;
					return general.RadErgoOutOfRangeAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ출횠욢힤욨\udcaa쎬\udfb0\uddb2\udab4슶ힸ\ud8ba\ud8bc튾꓀귂뇄釆ꛈꋊ껌꫎鋐볒룔뫖룘뗚맜", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)59343322;
					short num5 = num4;
					num4 = (short)1384088026;
					switch (num5 == num4)
					{
					}
					num4 = (short)106692609;
					if (num4 != 0)
					{
					}
					num4 = (short)861732864;
					if (num4 != 0)
					{
					}
					num4 = (short)1284243456;
					short num6 = num4;
					return general.RadErgoCfgVAWidePowerDown;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)331218945;
					if (num4 != 0)
					{
					}
					num4 = (short)822924176;
					short num5 = num4;
					num4 = (short)470930320;
					switch (num5 == num4)
					{
					}
					num4 = (short)1623982080;
					if (num4 != 0)
					{
					}
					num4 = (short)357498880;
					short num6 = num4;
					return general.RadErgoPowerDownAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ캜爵춠얢쾦첨좪욬킰\udab2\ud9b4ힸ햺튼쪾꿀ꃂꃄ꫆곈ꗊ만駎뻐뫒뛔닖高듚냜닞胠跢臤", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)665312672;
					short num5 = num4;
					num4 = (short)1153621408;
					switch (num5 == num4)
					{
					}
					num4 = (short)1553858561;
					if (num4 != 0)
					{
					}
					num4 = (short)1368195072;
					if (num4 != 0)
					{
					}
					num4 = (short)1236074496;
					short num6 = num4;
					return general.RadErgoCfgVAWideSelfCheckFailure;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)164251702;
					short num5 = num4;
					num4 = (short)1744390198;
					switch (num5 == num4)
					{
					}
					num4 = (short)1847066625;
					if (num4 != 0)
					{
					}
					num4 = (short)1107427328;
					if (num4 != 0)
					{
					}
					num4 = (short)1527447552;
					short num6 = num4;
					return general.RadErgoSelfCheckFailAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ\udc9cﲞ슠욢횤풦욨\ud9aa풬킰\udab2\ud9b4슶쮸\udebaﲼ톾꿀곂냄꧆꫈껊ꃌ꫎뿐꟒菔룖냘룚룜鳞軠転裤蛦蟨迪", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)976524125;
					short num5 = num4;
					num4 = (short)675058525;
					switch (num5 == num4)
					{
					}
					num4 = (short)1044512768;
					if (num4 != 0)
					{
					}
					num4 = (short)985268225;
					if (num4 != 0)
					{
					}
					num4 = (short)1130692608;
					short num6 = num4;
					return general.RadErgoCfgVAWideAccessoryFailure;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1642987521;
					if (num4 != 0)
					{
					}
					num4 = (short)384392528;
					short num5 = num4;
					num4 = (short)1179737424;
					switch (num5 == num4)
					{
					}
					num4 = (short)1391591424;
					if (num4 != 0)
					{
					}
					num4 = (short)1525743616;
					short num6 = num4;
					return general.RadErgoAccessoryFailureAnnouncementVoiceCommand;
				}));
				dictionary.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e킔ﺘ\udc9c햠욢쮤즦좨첬욮\uddb0욲잴튶햺펼킾듀귂ꛄꋆ꓈껊ꏌ믎蟐볒볔듖볘飚닜닞賠苢诤菦", a_), new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.FieldAccessors(delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)2134999013;
					short num5 = num4;
					num4 = (short)849706981;
					switch (num5 == num4)
					{
					}
					num4 = (short)519176192;
					if (num4 != 0)
					{
					}
					num4 = (short)271515649;
					if (num4 != 0)
					{
					}
					num4 = (short)2071920640;
					short num6 = num4;
					return general.RadErgoCfgVAWideAntennaFailure;
				}, delegate(global::SpecialFeatures.VoiceAnnouncements.Wide.General general)
				{
					short num4 = (short)1468459211;
					short num5 = num4;
					num4 = (short)1439688907;
					switch (num5 == num4)
					{
					}
					num4 = (short)1873674241;
					if (num4 != 0)
					{
					}
					num4 = (short)596639744;
					if (num4 != 0)
					{
					}
					num4 = (short)538574848;
					short num6 = num4;
					return general.RadErgoAntennaFailureAnnouncementVoiceCommand;
				}));
				return dictionary;
			}
		}

		// Token: 0x04000214 RID: 532
		private const int a = 65535;

		// Token: 0x0200001E RID: 30
		private class FieldAccessors
		{
			// Token: 0x0600053A RID: 1338 RVA: 0x0000267C File Offset: 0x0000087C
			public FieldAccessors(global::System.Func<global::SpecialFeatures.VoiceAnnouncements.Wide.General, global::AcpBusinessLayer.AcpRecRefField> voiceAnnouncementId, global::System.Func<global::SpecialFeatures.VoiceAnnouncements.Wide.General, global::AcpBusinessLayer.AcpField<string>> ttsText)
			{
				this.a = voiceAnnouncementId;
				this.b = ttsText;
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x0600053B RID: 1339 RVA: 0x0004D990 File Offset: 0x0004BB90
			public global::System.Func<global::SpecialFeatures.VoiceAnnouncements.Wide.General, global::AcpBusinessLayer.AcpRecRefField> VoiceAnnouncementId
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)2097315044;
					short num2 = num;
					num = (short)1026587876;
					switch (num2 == num)
					{
					}
					num = (short)2101149697;
					if (num != 0)
					{
					}
					num = (short)480444416;
					short num3 = num;
					num = (short)682033152;
					if (num != 0)
					{
					}
					return this.a;
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x0600053C RID: 1340 RVA: 0x0004DA40 File Offset: 0x0004BC40
			public global::System.Func<global::SpecialFeatures.VoiceAnnouncements.Wide.General, global::AcpBusinessLayer.AcpField<string>> TtsText
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)65263135;
					short num2 = num;
					num = (short)1785058847;
					switch (num2 == num)
					{
					}
					num = (short)339804160;
					if (num != 0)
					{
					}
					num = (short)491782144;
					short num3 = num;
					num = (short)162988033;
					if (num != 0)
					{
					}
					return this.b;
				}
			}

			// Token: 0x04000215 RID: 533
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private readonly global::System.Func<global::SpecialFeatures.VoiceAnnouncements.Wide.General, global::AcpBusinessLayer.AcpRecRefField> a;

			// Token: 0x04000216 RID: 534
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private readonly global::System.Func<global::SpecialFeatures.VoiceAnnouncements.Wide.General, global::AcpBusinessLayer.AcpField<string>> b;
		}
	}
}
