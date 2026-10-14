using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.DVRSProfiles;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList;
using Motorola.MackinawCPS.CoreFeatures.FactoryOverrides;
using Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList;
using Motorola.MackinawCPS.CoreFeatures.Keypad;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence;
using Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioVIPs;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SmartKeyFob;
using Motorola.MackinawCPS.CoreFeatures.Switches;
using Motorola.MackinawCPS.CoreFeatures.ToneSignalingList;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.DVRSFiles.List;
using SpecialFeatures.SystemCertificates.List;
using SpecialFeatures.VoiceAnnouncements.List;
using SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList;
using SpecialFeatures.VoiceAnnouncements.Wide;

namespace MackinawCPS
{
	// Token: 0x02000035 RID: 53
	public class MackCPSDocument : global::AcpBusinessLayer.AcpDocument
	{
		// Token: 0x06000139 RID: 313 RVA: 0x0003BD2C File Offset: 0x00039F2C
		internal MackCPSDocument()
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0003BD40 File Offset: 0x00039F40
		internal void resetDirty()
		{
			short num = (short)832035176;
			short num2 = num;
			num = (short)1135401320;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1712259072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)461963265;
			if (num != 0)
			{
			}
			num = (short)817168384;
			if (num != 0)
			{
			}
			base.IsDirty = false;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0003BDF0 File Offset: 0x00039FF0
		protected override void AddNewFeatures(string codeplugVersion)
		{
			short num = (short)1261961216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_2B7;
				}
				global::AcpCommonLib.IAcpRecordset acpRecordset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMic remoteSpeakerMic;
					switch (num2)
					{
					case 0:
						global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementWideRecSet());
						num = (short)799539241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_156C;
					case 2:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1965097096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)1460535307;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)246939653;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1938882567;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode[10640] == null)
									{
										num = (short)2073493514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									featureNode.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Stealth(featureNode));
									num = (short)604962824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide)
									{
										num = (short)1469579265;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_137E;
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode[10603] == null)
									{
										num = (short)1465122819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1229;
								}
								case 8:
									goto IL_1229;
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1721696256;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)945815556;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									featureNode.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannel(featureNode));
									num = (short)196804614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									switch (0)
									{
									case 0:
										goto IL_1200;
									}
									continue;
								}
								goto IL_1200;
								IL_1229:
								num = (short)2028011522;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1266:
								num = (short)881328137;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1200:
								goto IL_1266;
							}
							IL_137E:
							goto IL_2F3F;
						}
						finally
						{
							num = (short)847904768;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_13B5;
									}
									continue;
								case 1:
									goto IL_13EA;
								case 2:
									enumerator.Dispose();
									num = (short)1031143425;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_13B5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1416560642;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_13EA:;
						}
						goto IL_13ED;
					case 4:
						if (acpRecordset == null)
						{
							num = (short)1292435530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B03;
					case 5:
						goto IL_3E0D;
					case 6:
						goto IL_4EF1;
					case 7:
						if (acpRecordset == null)
						{
							num = (short)809959556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)188088464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1268318341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)636158065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)248447044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							num = (short)1999241218;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2[10793] == null)
									{
										num = (short)1459683346;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1FA3;
								}
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									featureNode2.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.LTE(featureNode2));
									num = (short)836501517;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1E9C;
									}
									continue;
								case 3:
									goto IL_20F0;
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2[10632] == null)
									{
										num = (short)1501167622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1FE6;
								}
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									featureNode2.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataProtocolConfiguration(featureNode2));
									num = (short)402128899;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									featureNode2.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration(featureNode2));
									num = (short)1396768778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1758265358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2[10782] == null)
									{
										num = (short)1613758465;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1EE6;
								}
								case 10:
									goto IL_1FE6;
								case 11:
									num = (short)2105868304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									featureNode2.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem(featureNode2));
									num = (short)1664548872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									goto IL_1EE6;
								case 14:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2[10503] == null)
									{
										num = (short)850132997;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_20F0;
								}
								case 15:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2[10849] == null)
									{
										num = (short)1832845324;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 16:
									goto IL_217C;
								case 17:
									goto IL_1FA3;
								case 18:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									featureNode2.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.WIFI(featureNode2));
									num = (short)1597505553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2 is global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide)
									{
										num = (short)1785593863;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 20:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1797521419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									num = (short)1816657939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_1E9C;
								IL_1EE6:
								num = (short)1021313024;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FA3:
								num = (short)3014671;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FE6:
								num = (short)732692489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2058:
								num = (short)1468006420;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E9C:
								goto IL_2058;
								IL_20F0:
								num = (short)2013069316;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_217C:
							goto IL_2ECE;
						}
						finally
						{
							num = (short)1070989312;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_21B3;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)198574082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_21EB;
								}
								IL_21B3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1234173953;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_21EB:;
						}
						goto IL_21EE;
					case 12:
						goto IL_17B9;
					case 13:
						goto IL_71A;
					case 14:
						goto IL_3D7B;
					case 15:
						try
						{
							num = (short)285081611;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1247870988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)636682247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode3;
									if (featureNode3[10801] == null)
									{
										num = (short)1937440781;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4A35;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode3;
									if (featureNode3[10905] == null)
									{
										num = (short)1753219082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)317784064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode3 = enumerator.Current;
									num = (short)1339949062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode3;
									if (featureNode3 is global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides)
									{
										num = (short)49545217;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode3;
									if (featureNode3[10791] == null)
									{
										num = (short)1721761806;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4981;
								}
								case 8:
									goto IL_4981;
								case 9:
									goto IL_4A35;
								case 10:
								{
									global::AcpBusinessLayer.FeatureNode featureNode3;
									featureNode3.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequency(featureNode3));
									num = (short)822870019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									switch (0)
									{
									case 0:
										goto IL_48A8;
									}
									continue;
								case 12:
									goto IL_4A91;
								case 13:
								{
									global::AcpBusinessLayer.FeatureNode featureNode3;
									featureNode3.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIRateTXMode(featureNode3));
									num = (short)160694281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::AcpBusinessLayer.FeatureNode featureNode3;
									featureNode3.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateList(featureNode3));
									num = (short)1170866184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_4942:
								num = (short)1301676037;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_48A8:
								goto IL_4942;
								IL_4981:
								num = (short)1904541698;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4A35:
								num = (short)942145540;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4A91:
							goto IL_3E0D;
						}
						finally
						{
							num = (short)2063073282;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)588185601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4B00;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4ACA;
									}
									continue;
								}
								IL_4ACA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)206569472;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4B00:;
						}
						goto IL_4B03;
					case 16:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)772669502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (acpRecordset == null)
						{
							num = (short)137363515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)1650130974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1051328663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1185808476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_13ED;
					case 21:
						if (acpRecordset == null)
						{
							num = (short)1937899538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)557449252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_3008;
					case 23:
						if (acpRecordset == null)
						{
							num = (short)1536098380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D7B;
					case 24:
						goto IL_3DC3;
					case 25:
						if (acpRecordset == null)
						{
							num = (short)1826750560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)942604299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWideRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)371916955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_14B3;
					case 28:
						try
						{
							num = (short)1935671311;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode4;
									featureNode4.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DAC(featureNode4));
									num = (short)747438089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_4E81;
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode4;
									if (featureNode4 is global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)
									{
										num = (short)989397004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1008402442;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode4 = enumerator.Current;
									num = (short)1358757890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode4;
									featureNode4.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupID(featureNode4));
									num = (short)1293025286;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode4;
									if (featureNode4[10770] == null)
									{
										num = (short)811139085;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4DB0;
								}
								case 6:
									goto IL_4DF7;
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode4;
									featureNode4.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LTE(featureNode4));
									num = (short)1933312017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpBusinessLayer.FeatureNode featureNode4;
									if (featureNode4[10505] == null)
									{
										num = (short)853082116;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4DF7;
								}
								case 9:
									goto IL_4CFE;
								case 10:
									num = (short)1961164801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::AcpBusinessLayer.FeatureNode featureNode4;
									if (featureNode4[10773] == null)
									{
										num = (short)431292423;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)993787920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									global::AcpBusinessLayer.FeatureNode featureNode4;
									featureNode4.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EnhancedData(featureNode4));
									num = (short)62062606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									goto IL_4DB0;
								case 15:
									switch (0)
									{
									case 0:
										goto IL_4C18;
									}
									continue;
								case 16:
								{
									global::AcpBusinessLayer.FeatureNode featureNode4;
									if (featureNode4[10504] == null)
									{
										num = (short)1269563392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4CFE;
								}
								}
								goto IL_4C18;
								IL_4CFE:
								num = (short)1611857928;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4D6F:
								num = (short)1916665859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4C18:
								goto IL_4D6F;
								IL_4DB0:
								num = (short)1160511499;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4DF7:
								num = (short)1958739973;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4E81:
							goto IL_1ADC;
						}
						finally
						{
							num = (short)466747392;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4EB9;
									}
									continue;
								case 1:
									goto IL_4EEE;
								case 2:
									enumerator.Dispose();
									num = (short)1865023489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4EB9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1926037506;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4EEE:;
						}
						goto IL_4EF1;
					case 29:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1921777803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						try
						{
							num = (short)1896939524;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1539375112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode5 = enumerator.Current;
									num = (short)1100939270;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode5;
									if (featureNode5[10637] == null)
									{
										num = (short)1161625607;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1896742914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_18BA;
									}
									continue;
								case 5:
									goto IL_19C4;
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode5;
									if (featureNode5 is global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches)
									{
										num = (short)1924399107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode5;
									featureNode5.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Switches.MultiFunctionKnob(featureNode5));
									num = (short)635305984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1261961221;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_18E1:
								num = (short)1579548673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18BA:
								goto IL_18E1;
							}
							IL_19C4:
							goto IL_6D2;
						}
						finally
						{
							num = (short)1147863040;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_19FC;
									}
									continue;
								case 1:
									goto IL_1A33;
								case 2:
									enumerator.Dispose();
									num = (short)566886401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_19FC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)758054914;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A33:;
						}
						goto IL_1A36;
					case 31:
						goto IL_FA7;
					case 32:
						goto IL_6D2;
					case 33:
						if (acpRecordset == null)
						{
							num = (short)1022623874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_156C;
					case 34:
						goto IL_10D3;
					case 35:
						if (acpRecordset == null)
						{
							num = (short)88866882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_108A;
					case 36:
						goto IL_3789;
					case 37:
						if (acpRecordset == null)
						{
							num = (short)1118961683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)963575928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (acpRecordset == null)
						{
							num = (short)236781703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71A;
					case 39:
						if (acpRecordset == null)
						{
							num = (short)850591863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA7;
					case 40:
						if (acpRecordset == null)
						{
							num = (short)1160708242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4766;
					case 41:
						goto IL_3AC6;
					case 42:
						goto IL_5117;
					case 43:
						goto IL_3521;
					case 44:
						goto IL_1417;
					case 45:
						goto IL_1ADC;
					case 46:
						try
						{
							num = (short)1371799557;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_507D;
								case 2:
									num = (short)1879048199;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)761724936;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode6 = enumerator.Current;
									num = (short)1251016708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode6;
									if (featureNode6 is global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide)
									{
										num = (short)885391362;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_4F73;
									}
									continue;
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode6;
									featureNode6.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LogicalProfileConfiguration(featureNode6));
									num = (short)2028601345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode6;
									if (featureNode6[10818] == null)
									{
										num = (short)699203590;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)2065235968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4F75:
								num = (short)859308035;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F73:
								goto IL_4F75;
							}
							IL_507D:
							return;
						}
						finally
						{
							num = (short)717684738;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1424687105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_50EB;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_50B4;
									}
									continue;
								}
								IL_50B4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1444347904;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_50EB:;
						}
						goto IL_50EE;
					case 47:
						try
						{
							num = (short)1523843080;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)918290433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode7;
									if (featureNode7[10889] == null)
									{
										num = (short)1238040583;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)56557573;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode7 = enumerator.Current;
									num = (short)1242038276;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode7;
									if (featureNode7 is global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)
									{
										num = (short)1804664832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1952710662;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_31A4;
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode7;
									featureNode7.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Broadband(featureNode7));
									num = (short)1944584195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_309B;
									}
									continue;
								}
								IL_309D:
								num = (short)1152516098;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_309B:
								goto IL_309D;
							}
							IL_31A4:
							goto IL_2E7B;
						}
						finally
						{
							num = (short)1910833152;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_31DC;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1080950786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3211;
								}
								IL_31DC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1659371521;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3211:;
						}
						goto Block_48;
					case 48:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1786642557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_4766;
					case 50:
						goto IL_165A;
					case 51:
						goto IL_2ECE;
					case 52:
						if (acpRecordset == null)
						{
							num = (short)70909952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AC6;
					case 53:
						goto IL_68B;
					case 54:
						global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet());
						num = (short)815530028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_28BB;
					case 56:
						try
						{
							num = (short)1301610499;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)151060481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_441B;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)450691072;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode8 = enumerator.Current;
									num = (short)657522696;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_431B;
									}
									continue;
								case 4:
									num = (short)210698247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode8;
									featureNode8.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAI(featureNode8));
									num = (short)1867644933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode8;
									if (featureNode8[10797] == null)
									{
										num = (short)168493062;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::AcpBusinessLayer.FeatureNode featureNode8;
									if (featureNode8 is global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPs)
									{
										num = (short)1576468484;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_435C:
								num = (short)1917779970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_431B:
								goto IL_435C;
							}
							IL_441B:
							goto IL_68B;
						}
						finally
						{
							num = (short)1995505665;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_448A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4453;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1072234496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4453:
								if (enumerator == null)
								{
									break;
								}
								num = (short)85131266;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_448A:;
						}
						goto IL_448D;
					case 57:
						try
						{
							num = (short)1610678282;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode9;
									if (featureNode9[10775] == null)
									{
										num = (short)39190533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5246;
								}
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode9;
									if (featureNode9[10845] == null)
									{
										num = (short)836632584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_5387;
								case 4:
									goto IL_5246;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode9;
									featureNode9.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneList(featureNode9));
									num = (short)850657284;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1584070659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)630980614;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode9 = enumerator.Current;
									num = (short)1021378571;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpBusinessLayer.FeatureNode featureNode9;
									featureNode9.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.EmergencyCompatibilityOptionsTrunking(featureNode9));
									num = (short)338493442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)1650655232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_520A;
									}
									continue;
								case 11:
								{
									global::AcpBusinessLayer.FeatureNode featureNode9;
									if (featureNode9 is global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)
									{
										num = (short)1314455561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_520C:
								num = (short)35717127;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_520A:
								goto IL_520C;
								IL_5246:
								num = (short)1071513601;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5387:
							goto IL_165A;
						}
						finally
						{
							num = (short)955973633;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_53F4;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_53BE;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)778567680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_53BE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1336082434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_53F4:;
						}
						goto IL_53F7;
					case 58:
						if (acpRecordset == null)
						{
							num = (short)223346704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1827;
					case 59:
						goto IL_23F9;
					case 60:
						if (acpRecordset == null)
						{
							num = (short)1319370815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399A;
					case 61:
						if (acpRecordset == null)
						{
							num = (short)1797324929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)109248612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_1827;
					case 63:
						goto IL_53F7;
					case 64:
						if (acpRecordset == null)
						{
							num = (short)2050883686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_586;
					case 65:
						try
						{
							num = (short)1860829188;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode10;
									if (featureNode10[10753] == null)
									{
										num = (short)93257733;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)405078024;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode10 = enumerator.Current;
									num = (short)27066375;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_4678;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_4573;
									}
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode10;
									featureNode10.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsExpander(featureNode10));
									num = (short)1376714755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)734658560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode10;
									if (featureNode10 is global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories)
									{
										num = (short)667353094;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)1757806594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4622:
								num = (short)2018902017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4573:
								goto IL_4622;
							}
							IL_4678:
							goto IL_47AE;
						}
						finally
						{
							num = (short)1029046273;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2143748098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_46B0;
									}
									continue;
								case 2:
									goto IL_46E6;
								}
								IL_46B0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)827392000;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46E6:;
						}
						goto IL_46E9;
					case 66:
						global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet());
						num = (short)1073938542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (acpRecordset == null)
						{
							num = (short)1746731080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)1190330506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_1019;
					case 69:
						if (acpRecordset == null)
						{
							num = (short)693174377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)27459679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						goto IL_111A;
					case 71:
						if (acpRecordset == null)
						{
							num = (short)1973682224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)1400766467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)516161578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						goto IL_3A7E;
					case 74:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1209860151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						goto IL_4236;
					case 76:
						goto IL_3973;
					case 77:
						if (acpRecordset == null)
						{
							num = (short)103022695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)174588030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						goto IL_2C10;
					case 79:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1429536802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						if (acpRecordset == null)
						{
							num = (short)1119289468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)74252334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						try
						{
							num = (short)634257416;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
								global::AcpBusinessLayer.FeatureNode featureNode11;
								switch (num2)
								{
								case 0:
									goto IL_2B43;
								case 1:
									if (acpFeatureSection == null)
									{
										num = (short)1406795788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B43;
								case 2:
									if (acpFeatureSection == null)
									{
										num = (short)397475854;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (acpFeatureSection.EmbeddedRecset == null)
									{
										num = (short)535298052;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A12;
								case 4:
									acpFeatureSection.EmbeddedRecset = new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset();
									num = (short)1625161735;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_2B9E;
								case 6:
									num = (short)1968308229;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_2A12;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_29AE;
									}
									continue;
								case 9:
									acpFeatureSection = featureNode11[10881];
									num = (short)1798373377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (featureNode11 is global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)
									{
										num = (short)1665794057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 12:
									acpFeatureSection = new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyList(featureNode11);
									featureNode11.AddFeatureSection(acpFeatureSection);
									num = (short)2020933632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (!enumerator.MoveNext())
									{
										num = (short)1816002566;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									featureNode11 = enumerator.Current;
									num = (short)2107572234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									featureNode11.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General(featureNode11));
									num = (short)1798438923;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_29B0:
								num = (short)566099981;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_29AE:
								goto IL_29B0;
								IL_2A12:
								acpFeatureSection = featureNode11[10883];
								num = (short)268763138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B43:
								num = (short)1427046403;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B9E:
							goto IL_2903;
						}
						finally
						{
							num = (short)1633484800;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2BD7;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)305659906;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2C0D;
								}
								IL_2BD7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1770586113;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2C0D:;
						}
						goto Block_41;
					case 82:
						if (acpRecordset == null)
						{
							num = (short)1456668682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1019;
					case 83:
						if (acpRecordset == null)
						{
							num = (short)8585301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A7E;
					case 84:
						if (acpRecordset == null)
						{
							num = (short)777846813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_352;
					case 85:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)634454089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						if (remoteSpeakerMic != null)
						{
							num = (short)754843791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1163;
					case 87:
					{
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)412155904;
						short num3 = num;
						num = (short)938934322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 88:
						if (acpRecordset == null)
						{
							num = (short)1090781324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)300220494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)354811957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						goto IL_2E7B;
					case 91:
						goto IL_C1E;
					case 92:
						goto IL_617;
					case 93:
						if (acpRecordset == null)
						{
							num = (short)346161275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111A;
					case 94:
						if (acpRecordset == null)
						{
							num = (short)108593243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C44;
					case 95:
						try
						{
							num = (short)744423443;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									if (featureNode12[10819] == null)
									{
										num = (short)1900085268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_275A;
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									featureNode12.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LTE(featureNode12));
									num = (short)146276361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1653866507;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode12 = enumerator.Current;
									num = (short)1587740686;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									featureNode12.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern(featureNode12));
									num = (short)826408981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)2118385676;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_2820;
								case 7:
									goto IL_2713;
								case 9:
									goto IL_254B;
								case 10:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									featureNode12.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit(featureNode12));
									num = (short)1252327442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)2073100294;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									if (featureNode12[10604] == null)
									{
										num = (short)581173252;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_24D8;
								}
								case 13:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									featureNode12.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio(featureNode12));
									num = (short)1474560001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									if (featureNode12 is global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)
									{
										num = (short)1321861125;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 15:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									if (featureNode12[10772] == null)
									{
										num = (short)1883045890;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_254B;
								}
								case 16:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									if (featureNode12[10636] == null)
									{
										num = (short)404946954;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_25DB;
								}
								case 17:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									featureNode12.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GunLock(featureNode12));
									num = (short)1891958791;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									goto IL_25DB;
								case 19:
									switch (0)
									{
									case 0:
										goto IL_24D3;
									}
									continue;
								case 20:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									featureNode12.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Sensor(featureNode12));
									num = (short)882114568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 21:
									goto IL_24D8;
								case 22:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									if (featureNode12[10606] == null)
									{
										num = (short)592183313;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2713;
								}
								case 23:
								{
									global::AcpBusinessLayer.FeatureNode featureNode12;
									if (featureNode12[10784] == null)
									{
										num = (short)742785037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_275A;
								}
								}
								goto IL_24D3;
								IL_24D8:
								num = (short)1580793878;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_254B:
								num = (short)872742935;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_25DB:
								num = (short)423821327;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2713:
								num = (short)200081424;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_275A:
								num = (short)958070784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_279E:
								num = (short)1548877827;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_24D3:
								goto IL_279E;
							}
							IL_2820:
							goto IL_3A36;
						}
						finally
						{
							num = (short)1024000000;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2858;
									}
									continue;
								case 1:
									goto IL_288E;
								case 2:
									enumerator.Dispose();
									num = (short)2083717121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2858:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1109655554;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_288E:;
						}
						goto IL_2891;
					case 96:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1763639347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						if (acpRecordset == null)
						{
							num = (short)687734921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)1065812102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						if (acpRecordset == null)
						{
							num = (short)394002544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DDA;
					case 99:
						if (acpRecordset == null)
						{
							num = (short)1248854143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17B9;
					case 100:
						try
						{
							num = (short)33226758;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1182007298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode13;
									if (featureNode13[10642] == null)
									{
										num = (short)1657864200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1D6A;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)542703616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode13 = enumerator.Current;
									num = (short)936509447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1710424065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1C5D;
									}
									continue;
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode13;
									if (featureNode13 is global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)
									{
										num = (short)145162245;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::AcpBusinessLayer.FeatureNode featureNode13;
									featureNode13.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.DVRS(featureNode13));
									num = (short)640811012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1D12:
								num = (short)1465974787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C5D:
								goto IL_1D12;
							}
							IL_1D6A:
							goto IL_1BC9;
						}
						finally
						{
							num = (short)440664065;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1DD7;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1DA1;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1316618240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1DA1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1315307522;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1DD7:;
						}
						goto IL_1DDA;
					case 101:
						if (acpRecordset == null)
						{
							num = (short)486146074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CF;
					case 102:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1560543386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)2141126683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						goto IL_3A36;
					case 105:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1614479464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						goto IL_1A36;
					case 107:
						if (acpRecordset == null)
						{
							num = (short)295436367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)829489310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						if (acpRecordset != null)
						{
							num = (short)391053468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2903;
					case 109:
						if (acpRecordset == null)
						{
							num = (short)146210905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)1320878136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						goto IL_108A;
					case 111:
						try
						{
							num = (short)965476352;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_D43;
									}
									continue;
								case 1:
									goto IL_D8A;
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode14;
									if (featureNode14[10771] == null)
									{
										num = (short)544210950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_EAB;
								}
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode14;
									featureNode14.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.Labtool(featureNode14));
									num = (short)1729167361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode14;
									featureNode14.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyCompatibilityOptionsConventional(featureNode14));
									num = (short)1311113226;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_EAB;
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode14;
									featureNode14.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneList(featureNode14));
									num = (short)660733957;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)387317773;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode14 = enumerator.Current;
									num = (short)2111897611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_F37;
								case 9:
								{
									global::AcpBusinessLayer.FeatureNode featureNode14;
									if (featureNode14[10777] == null)
									{
										num = (short)367919107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D8A;
								}
								case 11:
								{
									global::AcpBusinessLayer.FeatureNode featureNode14;
									if (featureNode14 is global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles)
									{
										num = (short)102957070;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									global::AcpBusinessLayer.FeatureNode featureNode14;
									if (featureNode14[10846] == null)
									{
										num = (short)482934788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									num = (short)918945800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)510722050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_D43;
								IL_D8A:
								num = (short)1571422220;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E25:
								num = (short)2110717959;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D43:
								goto IL_E25;
								IL_EAB:
								num = (short)2121400329;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F37:
							goto IL_28BB;
						}
						finally
						{
							num = (short)1639120898;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)19202049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_FA4;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F6F;
									}
									continue;
								}
								IL_F6F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1468661760;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FA4:;
						}
						goto IL_FA7;
					case 112:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)594608280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
						goto IL_419B;
					case 114:
						if (acpRecordset == null)
						{
							num = (short)1741684842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)959971356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						if (acpRecordset == null)
						{
							num = (short)1923547144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16CB;
					case 116:
						goto IL_399A;
					case 117:
						if (acpRecordset == null)
						{
							num = (short)1890779145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_419B;
					case 118:
						if (acpRecordset == null)
						{
							num = (short)273023063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E51;
					case 119:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1982595103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						try
						{
							num = (short)704118786;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_8F7;
								case 1:
									num = (short)161480704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7F4;
									}
									continue;
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode15;
									if (featureNode15[10735] == null)
									{
										num = (short)654245896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1896546307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode15;
									if (featureNode15 is global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5)
									{
										num = (short)1467154436;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)445120513;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode15 = enumerator.Current;
									num = (short)1322057733;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpBusinessLayer.FeatureNode featureNode15;
									featureNode15.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsExpander(featureNode15));
									num = (short)1284964358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_7F6:
								num = (short)392167431;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7F4:
								goto IL_7F6;
							}
							IL_8F7:
							goto IL_617;
						}
						finally
						{
							num = (short)164036609;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1210515458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_92E;
									}
									continue;
								case 2:
									goto IL_963;
								}
								IL_92E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1133445120;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_963:;
						}
						goto Block_12;
					case 121:
						goto IL_14FA;
					case 122:
						goto IL_3214;
					case 123:
						goto IL_3CFF;
					case 124:
						goto IL_6CD;
					case 125:
						goto IL_2F3F;
					case 126:
						try
						{
							num = (short)780402693;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)705691649;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode16 = enumerator.Current;
									num = (short)1113194500;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1821507591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode16;
									if (featureNode16[10732] == null)
									{
										num = (short)580452358;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode16;
									if (featureNode16 is global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3)
									{
										num = (short)555745288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_40D;
									}
									continue;
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode16;
									featureNode16.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsExpander(featureNode16));
									num = (short)1984888834;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_516;
								case 8:
									num = (short)1515323395;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_40F:
								num = (short)755826688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_40D:
								goto IL_40F;
							}
							IL_516:
							goto IL_14B3;
						}
						finally
						{
							num = (short)310181889;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1853227010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_54D;
									}
									continue;
								case 2:
									goto IL_583;
								}
								IL_54D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)932511744;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_583:;
						}
						goto IL_586;
					case 127:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)920256524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
						if (acpRecordset == null)
						{
							num = (short)1153171609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46E9;
					case 129:
						goto IL_411F;
					case 130:
						goto IL_2891;
					case 131:
						goto IL_C44;
					case 132:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1814691862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
						goto IL_16CB;
					case 134:
						try
						{
							num = (short)1800798212;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode17;
									featureNode17.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Labtool(featureNode17));
									num = (short)1680736267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)441122821;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode17;
									if (featureNode17[10760] == null)
									{
										num = (short)496173062;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_35A2;
									}
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode17;
									if (featureNode17[10711] == null)
									{
										num = (short)682754048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_360C;
								}
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode17;
									featureNode17.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI(featureNode17));
									num = (short)468910081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_3718;
								case 8:
								{
									global::AcpBusinessLayer.FeatureNode featureNode17;
									if (featureNode17 is global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)
									{
										num = (short)567345154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)395837447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)765067273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode17 = enumerator.Current;
									num = (short)1462042632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_360C;
								}
								goto IL_35A2;
								IL_360C:
								num = (short)1570373635;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3650:
								num = (short)120913930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_35A2:
								goto IL_3650;
							}
							IL_3718:
							goto IL_14FA;
						}
						finally
						{
							num = (short)1382350850;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1278803969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3786;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3750;
									}
									continue;
								}
								IL_3750:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2018246656;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3786:;
						}
						goto Block_50;
					case 135:
						goto IL_21EE;
					case 136:
						goto IL_2FC1;
					case 137:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)862978169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 138:
						goto IL_966;
					case 139:
						goto IL_352;
					case 140:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)1635582027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						if (acpRecordset == null)
						{
							num = (short)857800706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)541589626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 142:
						goto IL_1BC9;
					case 143:
					{
						acpRecordset = remoteSpeakerMic.General.EmbeddedRecset;
						int num4 = 0;
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)2127822997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 144:
						try
						{
							num = (short)421396491;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode18;
									if (featureNode18 is global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)
									{
										num = (short)725024769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1099628556;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode18;
									featureNode18.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsNewBandPlan(featureNode18));
									num = (short)67371014;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode18;
									featureNode18.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Fireground(featureNode18));
									num = (short)1638531082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode18;
									if (featureNode18[10749] == null)
									{
										num = (short)111869960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_400F;
								}
								case 5:
									goto IL_40AC;
								case 7:
									num = (short)354811909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpBusinessLayer.FeatureNode featureNode18;
									featureNode18.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPS(featureNode18));
									num = (short)1593049101;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::AcpBusinessLayer.FeatureNode featureNode18;
									if (featureNode18[10761] == null)
									{
										num = (short)927924226;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_3EBD;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_3EB8;
									}
									continue;
								case 12:
								{
									global::AcpBusinessLayer.FeatureNode featureNode18;
									if (featureNode18[10750] == null)
									{
										num = (short)627900419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3EBD;
								}
								case 13:
									goto IL_400F;
								case 14:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)43778055;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode18 = enumerator.Current;
									num = (short)885719040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_3EB8;
								IL_3EBD:
								num = (short)519241732;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_400F:
								num = (short)524156937;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4056:
								num = (short)693698574;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3EB8:
								goto IL_4056;
							}
							IL_40AC:
							goto IL_3008;
						}
						finally
						{
							num = (short)189136898;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_411C;
								case 1:
									enumerator.Dispose();
									num = (short)2106720256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_40E4;
									}
									continue;
								}
								IL_40E4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1212350465;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_411C:;
						}
						goto IL_411F;
					case 145:
						if (acpRecordset == null)
						{
							num = (short)1741029419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)490405935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
						goto IL_50EE;
					case 147:
						if (acpRecordset == null)
						{
							num = (short)434176157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DC3;
					case 148:
						goto IL_47AE;
					case 149:
						try
						{
							num = (short)1497563138;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3C8E;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3B59;
									}
									continue;
								case 3:
									num = (short)1581449216;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMButtonKey_A22526.Value.Length > 14)
									{
										num = (short)1305214982;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1983315971;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode19 = enumerator.Current;
									int num4;
									num4++;
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner = featureNode19 as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner;
									num = (short)760348680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									int num4;
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMButtonKey_A22526.Value = global::CommonResources.AppResources.Accessory_Id + num4.ToString();
									num = (short)1846083585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)963772420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
									if (rsmbuttonInner != null)
									{
										num = (short)257359879;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_3C39:
								num = (short)247005189;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3B59:
								goto IL_3C39;
							}
							IL_3C8E:
							goto IL_1163;
						}
						finally
						{
							num = (short)424673280;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3CC5;
									}
									continue;
								case 1:
									goto IL_3CFC;
								case 2:
									enumerator.Dispose();
									num = (short)2005467137;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3CC5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)619446274;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3CFC:;
						}
						goto IL_3CFF;
					case 150:
						if (acpRecordset == null)
						{
							num = (short)1071251476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_763;
					case 151:
						goto IL_448D;
					case 152:
						goto IL_1DDA;
					case 153:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)291438597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 154:
						goto IL_586;
					case 155:
						goto IL_5CF;
					case 156:
						enumerator = (acpRecordset as global::AcpBusinessLayer.Recordset).GetEnumerator();
						num = (short)604569681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 157:
						acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset();
						global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
						num = (short)494731288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 158:
						try
						{
							num = (short)823132160;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2288;
									}
									continue;
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode20;
									if (featureNode20[10803] == null)
									{
										num = (short)1236598791;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)392167427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_2389;
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode20;
									if (featureNode20 is global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation)
									{
										num = (short)1298792454;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)317325314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode20 = enumerator.Current;
									num = (short)1846345732;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)197394433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode20;
									featureNode20.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DepotKeyInfo(featureNode20));
									num = (short)955645960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_22C7:
								num = (short)1031995397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2288:
								goto IL_22C7;
							}
							IL_2389:
							goto IL_10D3;
						}
						finally
						{
							num = (short)88539138;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)187891713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_23F6;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_23C0;
									}
									continue;
								}
								IL_23C0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1673986048;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_23F6:;
						}
						goto IL_23F9;
					case 159:
						goto IL_763;
					case 160:
						if (acpRecordset == null)
						{
							num = (short)290455558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)309919809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 161:
						if (acpRecordset == null)
						{
							num = (short)515637302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1417;
					}
					goto IL_2B7;
					IL_352:
					acpRecordset = base.GetFeature(2130);
					num = (short)592052261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_586:
					acpRecordset = base.GetFeature(2042);
					num = (short)2113929237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CF:
					acpRecordset = base.GetFeature(4143);
					num = (short)183042163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_617:
					acpRecordset = base.GetFeature(2131);
					num = (short)490143826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_68B:
					acpRecordset = base.GetFeature(2033);
					num = (short)294256720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D2:
					acpRecordset = base.GetFeature(2049);
					num = (short)1046806635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_71A:
					acpRecordset = base.GetFeature(4234);
					num = (short)164561057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_763:
					acpRecordset = base.GetFeature(4109);
					num = (short)1678442529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C1E:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)1071120515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_12:
					try
					{
						IL_966:
						num = (short)996278275;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpBusinessLayer.FeatureNode featureNode21;
								featureNode21.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown(featureNode21));
								num = (short)825753612;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)93126670;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_A73;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_9C8;
								}
								continue;
							case 4:
							{
								global::AcpBusinessLayer.FeatureNode featureNode21;
								if (featureNode21 is global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide)
								{
									num = (short)857669633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::AcpBusinessLayer.FeatureNode featureNode21;
								featureNode21.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyToneTrigger(featureNode21));
								num = (short)1341718530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::AcpBusinessLayer.FeatureNode featureNode21;
								featureNode21.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideImpactDetection(featureNode21));
								num = (short)550961160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								num = (short)1878917130;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
							{
								global::AcpBusinessLayer.FeatureNode featureNode21;
								if (featureNode21[10778] == null)
								{
									num = (short)366018565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_A73;
							}
							case 10:
								goto IL_BAE;
							case 11:
							{
								global::AcpBusinessLayer.FeatureNode featureNode21;
								if (featureNode21[10854] == null)
								{
									num = (short)1331691526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 12:
								goto IL_ABB;
							case 13:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1834876935;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.FeatureNode featureNode21 = enumerator.Current;
								num = (short)1604648964;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 14:
							{
								global::AcpBusinessLayer.FeatureNode featureNode21;
								if (featureNode21[10639] == null)
								{
									num = (short)830668800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_ABB;
							}
							}
							IL_9EF:
							num = (short)1453195277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9C8:
							goto IL_9EF;
							IL_A73:
							num = (short)1497759755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_ABB:
							num = (short)1310457865;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_BAE:
						goto IL_5117;
					}
					finally
					{
						num = (short)1089208320;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_BE5;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)2142765058;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_C1B;
							}
							IL_BE5:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1540358145;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_C1B:;
					}
					goto IL_C1E;
					IL_C44:
					acpRecordset = base.GetFeature(4156);
					num = (short)692846675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA7:
					acpRecordset = base.GetFeature(4003);
					num = (short)1159528536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1019:
					acpRecordset = base.GetFeature(4176);
					num = (short)27394165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_108A:
					acpRecordset = base.GetFeature(2302);
					num = (short)84082728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D3:
					acpRecordset = base.GetFeature(2045);
					num = (short)1929314373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_111A:
					acpRecordset = base.GetFeature(4114);
					num = (short)330629218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1163:
					acpRecordset = base.GetFeature(2051);
					num = (short)1502740577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13ED:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)1174339743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1417:
					acpRecordset = base.GetFeature(2300);
					num = (short)380043299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14B3:
					acpRecordset = base.GetFeature(4236);
					num = (short)822214806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14FA:
					acpRecordset = base.GetFeature(2032);
					num = (short)1778909251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_156C:
					acpRecordset = base.GetFeature(2128);
					num = (short)1845952672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165A:
					acpRecordset = base.GetFeature(2045);
					num = (short)1231749127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16CB:
					acpRecordset = base.GetFeature(2053);
					num = (short)932315277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17B9:
					acpRecordset = base.GetFeature(4142);
					num = (short)943456357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1827:
					acpRecordset = base.GetFeature(4231);
					num = (short)1088356446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A36:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)1222705197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ADC:
					acpRecordset = base.GetFeature(4148);
					num = (short)503054435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BC9:
					acpRecordset = base.GetFeature(2064);
					num = (short)436732049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DDA:
					acpRecordset = base.GetFeature(2033);
					num = (short)1289617479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21EE:
					global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet());
					num = (short)1681391629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23F9:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)1956380704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2891:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)2119434241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28BB:
					acpRecordset = base.GetFeature(2076);
					num = (short)1449132150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2903:
					acpRecordset = base.GetFeature(2059);
					num = (short)107479101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E51:
					enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
					num = (short)341704761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_41:
					try
					{
						IL_2C10:
						num = (short)1486356481;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1918631942;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.FeatureNode featureNode22 = enumerator.Current;
								num = (short)1549205515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2C67;
								}
								continue;
							case 2:
							{
								global::AcpBusinessLayer.FeatureNode featureNode22;
								featureNode22.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtons(featureNode22));
								num = (short)1688993801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								global::AcpBusinessLayer.FeatureNode featureNode22;
								if (featureNode22[10743] == null)
								{
									num = (short)1637089282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
							{
								global::AcpBusinessLayer.FeatureNode featureNode22;
								featureNode22.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsExpander(featureNode22));
								num = (short)464846853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_2CE8;
							case 6:
								num = (short)406257672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								global::AcpBusinessLayer.FeatureNode featureNode22;
								if (featureNode22[10731] == null)
								{
									num = (short)1840381956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2CE8;
							}
							case 8:
								goto IL_2DDF;
							case 10:
								num = (short)889651207;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
							{
								global::AcpBusinessLayer.FeatureNode featureNode22;
								if (featureNode22 is global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9)
								{
									num = (short)750714890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_2CA7:
							num = (short)1675165696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2C67:
							goto IL_2CA7;
							IL_2CE8:
							num = (short)631046147;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2DDF:
						goto IL_4236;
					}
					finally
					{
						num = (short)420741122;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2E4E;
							case 1:
								enumerator.Dispose();
								num = (short)984154112;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2E16;
								}
								continue;
							}
							IL_2E16:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1438842881;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2E4E:;
					}
					goto IL_2E51;
					IL_2E7B:
					remoteSpeakerMic = (base.GetFeature(2036)[0] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMic);
					num = (short)366018646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2ECE:
					acpRecordset = base.GetFeature(2054);
					num = (short)1647575154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F3F:
					acpRecordset = base.GetFeature(4174);
					num = (short)1688469562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FC1:
					acpRecordset = base.GetFeature(2055);
					num = (short)882311276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_48:
					try
					{
						IL_3214:
						num = (short)1116405768;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::AcpBusinessLayer.FeatureNode featureNode23;
							switch (num2)
							{
							case 0:
								if (featureNode23 is global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)
								{
									num = (short)1394999298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								featureNode23.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure(featureNode23));
								num = (short)1607925774;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1903099916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_332A;
							case 4:
								if (featureNode23[10785] == null)
								{
									num = (short)900399107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)1698234377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								featureNode23 = enumerator.Current;
								num = (short)73990144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_32A1;
							case 7:
								featureNode23.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS(featureNode23));
								num = (short)164429830;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								switch (0)
								{
								case 0:
									goto IL_3276;
								}
								continue;
							case 9:
								num = (short)1636827149;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								if (featureNode23[10644] == null)
								{
									num = (short)955842561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_32E5;
							case 11:
							{
								num = (short)1797930792;
								short num5 = num;
								num = (short)1849114408;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_332A;
								default:
									num = (short)631111680;
									if (num != 0)
									{
									}
									break;
								}
								break;
							}
							case 12:
								if (featureNode23[10643] == null)
								{
									num = (short)1013841927;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_32A1;
							case 13:
								goto IL_34B1;
							case 14:
								goto IL_32E5;
							}
							goto IL_3276;
							IL_32A1:
							num = (short)1999765514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_32E5:
							num = (short)2064646148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_332A:
							featureNode23.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.QuikCallII(featureNode23));
							num = (short)1609695243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_342F:
							num = (short)1829634053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3276:
							goto IL_342F;
						}
						IL_34B1:
						goto IL_2FC1;
					}
					finally
					{
						num = (short)1544617986;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_351E;
							case 1:
								enumerator.Dispose();
								num = (short)1500971008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_34E8;
								}
								continue;
							}
							IL_34E8:
							if (enumerator == null)
							{
								break;
							}
							num = (short)877723649;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_351E:;
					}
					goto IL_3521;
					IL_3008:
					acpRecordset = base.GetFeature(4130);
					num = (short)1676214336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3521:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)412876890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3973:
					global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertListRecset());
					num = (short)1289748494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_50:
					try
					{
						IL_3789:
						num = (short)2032926727;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)736296961;
								if (num != 0)
								{
								}
								num = (short)540934152;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)247398404;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.FeatureNode featureNode24 = enumerator.Current;
								num = (short)541392901;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::AcpBusinessLayer.FeatureNode featureNode24;
								featureNode24.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Buttons.SideArrowButtons(featureNode24));
								num = (short)1800536067;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1866989574;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::AcpBusinessLayer.FeatureNode featureNode24;
								if (featureNode24 is global::Motorola.MackinawCPS.CoreFeatures.Buttons.Buttons)
								{
									num = (short)2085617664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_3900;
							case 7:
								switch (0)
								{
								case 0:
									goto IL_37D5;
								}
								continue;
							case 8:
							{
								global::AcpBusinessLayer.FeatureNode featureNode24;
								if (featureNode24[10745] == null)
								{
									num = (short)1270153218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_3867:
							num = (short)443809793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_37D5:
							goto IL_3867;
						}
						IL_3900:
						goto IL_448D;
					}
					finally
					{
						num = (short)1585577984;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3939;
								}
								continue;
							case 1:
								goto IL_3970;
							case 2:
								enumerator.Dispose();
								num = (short)1122500609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3939:
							if (enumerator == null)
							{
								break;
							}
							num = (short)277872642;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3970:;
					}
					goto IL_3973;
					IL_399A:
					acpRecordset = base.GetFeature(2042);
					num = (short)1576992807;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A36:
					acpRecordset = base.GetFeature(2028);
					num = (short)991887385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A7E:
					acpRecordset = base.GetFeature(2038);
					num = (short)52756497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AC6:
					acpRecordset = base.GetFeature(2125);
					num = (short)2005139603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CFF:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)715587654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D7B:
					acpRecordset = base.GetFeature(2301);
					num = (short)1719337012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DC3:
					acpRecordset = base.GetFeature(2003);
					num = (short)466026624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E0D:
					acpRecordset = base.GetFeature(2127);
					num = (short)1639448653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_411F:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)291831950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_419B:
					acpRecordset = base.GetFeature(4008);
					num = (short)1308295228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4236:
					acpRecordset = base.GetFeature(4115);
					num = (short)63897693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_448D:
					acpRecordset = base.GetFeature(2125);
					num = (short)861208685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46E9:
					enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
					num = (short)1986723855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4766:
					acpRecordset = base.GetFeature(4145);
					num = (short)818085911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47AE:
					acpRecordset = base.GetFeature(2129);
					num = (short)1943994452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B03:
					enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
					num = (short)1757937775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EF1:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)1129775252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50EE:
					global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet());
					num = (short)630521905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5117:
					acpRecordset = base.GetFeature(2075);
					num = (short)1222049796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53F7:
					acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset();
					global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
					num = (short)1593704564;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_6CD:
				acpRecordset = new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset();
				global::AcpCommonLib.FeatureManager.AddFeature(acpRecordset);
				return;
				IL_2B7:
				acpRecordset = null;
				acpRecordset = base.GetFeature(4228);
				num = (short)643301414;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x040000E1 RID: 225
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
