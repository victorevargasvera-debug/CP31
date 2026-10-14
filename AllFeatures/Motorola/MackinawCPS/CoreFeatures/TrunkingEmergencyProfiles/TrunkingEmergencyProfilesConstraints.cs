using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x0200046E RID: 1134
	public static class TrunkingEmergencyProfilesConstraints
	{
		// Token: 0x060095ED RID: 38381 RVA: 0x008CD724 File Offset: 0x008CB924
		internal static bool ConEmerAlarmIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1835393491;
			short num2 = num;
			num = (short)93184467;
			global::AcpBusinessLayer.AcpListField trkEmerProfGeneralEmergencyOperation_A;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1954676737;
				if (num != 0)
				{
				}
				num = (short)390594560;
				if (num != 0)
				{
				}
				trkEmerProfGeneralEmergencyOperation_A = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General).TrkEmerProfGeneralEmergencyOperation_A7926;
				if (trkEmerProfGeneralEmergencyOperation_A.Value == 1)
				{
					return true;
				}
				num = (short)262995968;
				short num3 = num;
				break;
			}
			}
			return trkEmerProfGeneralEmergencyOperation_A.Value == 3;
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x008CD7F0 File Offset: 0x008CB9F0
		internal static bool conAutoTransmitModeIsHotMicEmergency(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General general;
			short num2;
			global::AcpBusinessLayer.AcpListField trkEmerProfGeneralEmergencyOperation_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!general.TrkEmerProfGeneralConsoleAckRequired_A7712.Value)
					{
						num2 = (short)1357643786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					num2 = (short)402128899;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (trkEmerProfGeneralEmergencyOperation_A.Value == 2)
					{
						num2 = (short)1121648649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					if (trkEmerProfGeneralEmergencyOperation_A.Value != 3)
					{
						num2 = (short)1163722760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_236;
				case 4:
					if (general.RefRadioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Value)
					{
						num2 = (short)2039021574;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					if (general.TrkEmerProEmergencyAutoTransmitMode_A22567.Value == 2)
					{
						num2 = (short)774897664;
						short num3 = num2;
						num2 = (short)1436090369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					num2 = (short)1638989826;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (general.TrkEmerProfGeneralRevertPTTID_A12642.Value)
					{
						goto IL_25A;
					}
					return false;
				case 8:
					num2 = (short)757006340;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1101594625;
					if (num2 != 0)
					{
					}
					goto IL_236;
				case 10:
					return true;
				case 11:
				{
					num2 = (short)1127091883;
					short num4 = num2;
					num2 = (short)481365675;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25A;
					default:
						num2 = (short)1590099968;
						if (num2 != 0)
						{
						}
						num2 = (short)2020409344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_40;
				IL_236:
				num2 = (short)1662124039;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_25A:
				num2 = (short)514129931;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_40:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General);
			trkEmerProfGeneralEmergencyOperation_A = general.TrkEmerProfGeneralEmergencyOperation_A7926;
			num2 = (short)1278672901;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x008CDA74 File Offset: 0x008CBC74
		internal static bool conAutoTransmitModeIsEmerViaSilentAudio(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General general;
			short num2;
			global::AcpBusinessLayer.AcpListField trkEmerProfGeneralEmergencyOperation_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!general.TrkEmerProfGeneralConsoleAckRequired_A7712.Value)
					{
						num2 = (short)317194250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 1:
					num2 = (short)571801603;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (trkEmerProfGeneralEmergencyOperation_A.Value == 2)
					{
						num2 = (short)1059979273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 3:
					if (trkEmerProfGeneralEmergencyOperation_A.Value != 3)
					{
						num2 = (short)1523187720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_209;
				case 4:
					if (general.RefRadioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Value)
					{
						num2 = (short)909770758;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 5:
					if (general.TrkEmerProEmergencyAutoTransmitMode_A22567.Value == 1)
					{
						num2 = (short)1911488512;
						short num3 = num2;
						num2 = (short)574095361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 6:
					num2 = (short)1534001154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (general.TrkEmerProfGeneralRevertPTTID_A12642.Value)
					{
						goto IL_22D;
					}
					goto IL_249;
				case 8:
					num2 = (short)1777270788;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_209;
				case 10:
					return true;
				case 11:
				{
					num2 = (short)1328085937;
					short num4 = num2;
					num2 = (short)1901657009;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_22D;
					default:
						num2 = (short)441843712;
						if (num2 != 0)
						{
						}
						num2 = (short)862519296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_40;
				IL_209:
				num2 = (short)1785397255;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22D:
				num2 = (short)1868693515;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_249:
			num2 = (short)197722113;
			if (num2 != 0)
			{
			}
			return false;
			IL_40:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General);
			trkEmerProfGeneralEmergencyOperation_A = general.TrkEmerProfGeneralEmergencyOperation_A7926;
			num2 = (short)1452933125;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060095F0 RID: 38384 RVA: 0x008CDCF4 File Offset: 0x008CBEF4
		internal static bool conAutoTransmitModeIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1465909248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1311047681;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_C8;
				}
				global::AcpBusinessLayer.AcpListField trkEmerProfGeneralEmergencyOperation_A;
				bool result;
				global::AcpBusinessLayer.AcpField<bool> trkEmerProfGeneralConsoleAckRequired_A;
				global::AcpBusinessLayer.AcpField<bool> trkEmerProfGeneralRevertPTTID_A;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolEmergencyCallOnlywithHotMicCapable_A;
				for (;;)
				{
					IL_51:
					switch (num2)
					{
					case 0:
						num = (short)1487667224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (trkEmerProfGeneralEmergencyOperation_A.Value == 2)
						{
							num = (short)881066002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					case 2:
						if (trkEmerProfGeneralEmergencyOperation_A.Value != 3)
						{
							num = (short)696844313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DA;
					case 3:
						result = true;
						num = (short)1422655510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_3DA;
					case 5:
						num = (short)425721868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!trkEmerProfGeneralConsoleAckRequired_A.Value)
						{
							num = (short)640090115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					case 7:
						return result;
					case 8:
						num = (short)798949382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						result = true;
						num = (short)89391124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (trkEmerProfGeneralRevertPTTID_A.Value)
						{
							num = (short)649527301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 11:
						if (radWideLabtoolEmergencyCallOnlywithHotMicCapable_A.Value)
						{
							num = (short)1266024462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					case 12:
						if (!trkEmerProfGeneralConsoleAckRequired_A.Value)
						{
							num = (short)59965449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 13:
						return result;
					case 14:
						num = (short)82968577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						if (!trkEmerProfGeneralRevertPTTID_A.Value)
						{
							goto IL_27E;
						}
						num = (short)519111326;
						short num3 = num;
						num = (short)60031646;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_122;
						default:
						{
							num = (short)907673600;
							if (num != 0)
							{
							}
							num = (short)1250361344;
							short num4 = num;
							num = (short)824180744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 16:
						if (radWideLabtoolEmergencyCallOnlywithHotMicCapable_A.Value)
						{
							num = (short)1007681536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 17:
						return result;
					case 18:
						goto IL_323;
					case 19:
						num = (short)792461319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						return result;
					case 21:
						switch (index)
						{
						case 0:
							result = true;
							num = (short)1575223322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1988886555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)1219493890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_122;
					case 22:
						return result;
					case 23:
						num = (short)869335051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (trkEmerProfGeneralEmergencyOperation_A.Value == 2)
						{
							num = (short)220135428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 25:
						num = (short)412090384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						return result;
					case 27:
						if (trkEmerProfGeneralEmergencyOperation_A.Value != 3)
						{
							num = (short)621936663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					}
					goto IL_C8;
					IL_122:
					num = (short)459538451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_183:
					result = false;
					num = (short)470482957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27E:
					result = false;
					num = (short)1199112209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_323:
					num = (short)1801388047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DA:
					num = (short)540409866;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_C8:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General;
				trkEmerProfGeneralEmergencyOperation_A = general.TrkEmerProfGeneralEmergencyOperation_A7926;
				trkEmerProfGeneralRevertPTTID_A = general.TrkEmerProfGeneralRevertPTTID_A12642;
				trkEmerProfGeneralConsoleAckRequired_A = general.TrkEmerProfGeneralConsoleAckRequired_A7712;
				radWideLabtoolEmergencyCallOnlywithHotMicCapable_A = general.RefRadioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162;
				result = true;
				num = (short)1767964693;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x060095F1 RID: 38385 RVA: 0x008CE1FC File Offset: 0x008CC3FC
		public static bool conEmergencyOpCallOnly(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
			short num2;
			global::AcpBusinessLayer.AcpField<bool> emerWideGeneralSilentAlarm_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (emergencyWide != null)
					{
						num2 = (short)2119106562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					goto IL_146;
				case 2:
				{
					num2 = (short)1341541279;
					short num3 = num2;
					num2 = (short)1037585311;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_146;
					default:
						num2 = (short)430833664;
						if (num2 != 0)
						{
						}
						num2 = (short)1705836545;
						if (num2 != 0)
						{
						}
						emerWideGeneralSilentAlarm_A = emergencyWide.General.EmerWideGeneralSilentAlarm_A9130;
						num2 = (short)1928331265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_161;
				}
				goto IL_20;
				IL_146:
				if (index != 2)
				{
					break;
				}
				num2 = (short)207290371;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_161:
			return !emerWideGeneralSilentAlarm_A.Value;
			IL_20:
			emergencyWide = (self.Parent.Parent.ContainerDoc.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide);
			num2 = (short)915472384;
			short num4 = num2;
			num2 = (short)826015744;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060095F2 RID: 38386 RVA: 0x008CE370 File Offset: 0x008CC570
		public static bool ConTriggerTrkPerApplicableConstraint(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)954925056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2085945344;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles2;
				for (;;)
				{
					IL_53:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_343;
					case 1:
						if (trunkingPersonalityRecset != null)
						{
							num = (short)188219392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						try
						{
							num = (short)7077892;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)864681990;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									num = (short)44564489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1145503747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles;
									if (trunkingEmergencyProfiles != null)
									{
										num = (short)914030593;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles;
									if (trunkingEmergencyProfiles == trunkingEmergencyProfiles2)
									{
										num = (short)503382023;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_10D;
									}
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles = trunkingPersonality.General.TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles;
									num = (short)1418461186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)830144522;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									num = (short)52701031;
									short num4 = num;
									num = (short)998844263;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2D1;
									default:
									{
										num = (short)1099956224;
										if (num != 0)
										{
										}
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
										trunkingPersonality.General.TrkPerGeneralEmergencyRevertType_A41914.CallConstraints();
										trunkingPersonality.General.TrkPerGeneralRevertZone_A41916.CallConstraints();
										trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.CallConstraints();
										num = (short)1978990600;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality != null)
									{
										num = (short)1639579653;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_2D1;
								}
								IL_10F:
								num = (short)253427712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10D:
								goto IL_10F;
							}
							IL_2D1:
							return true;
						}
						finally
						{
							num = (short)937689089;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)622657538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_30A;
									}
									continue;
								case 2:
									goto IL_340;
								}
								IL_30A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1497694208;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_340:;
						}
						goto IL_343;
					}
					goto IL_66;
					IL_343:
					enumerator = trunkingPersonalityRecset.GetEnumerator();
					num = (short)9699329;
					if (num != 0)
					{
					}
					num = (short)840433666;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_66:
				trunkingEmergencyProfiles2 = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles);
				trunkingPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
				num = (short)174587905;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_53;
			}
			}
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x008CE72C File Offset: 0x008CC92C
		internal static bool ConPerEmerProfIsSelected(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General;
			if (general.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0)
			{
				short num = (short)1202461178;
				short num2 = num;
				num = (short)1131878906;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)33095681;
					if (num != 0)
					{
					}
					num = (short)230031360;
					short num3 = num;
					num = (short)237961216;
					if (num != 0)
					{
					}
					return general.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1;
				}
				}
			}
			return false;
		}

		// Token: 0x060095F4 RID: 38388 RVA: 0x008CE814 File Offset: 0x008CCA14
		internal static bool ConTrkLegacyToneNotSelected(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection trunkingEmergencyToneTableInnerSection;
			global::AcpBusinessLayer.AcpListField trkEmerTone_;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)946601985;
					if (num2 != 0)
					{
					}
					num2 = (short)357040130;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (trunkingEmergencyToneTableInnerSection.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1)
					{
						num2 = (short)99549184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FB;
				case 2:
					if (trunkingEmergencyToneTableInnerSection.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135)
					{
						num2 = (short)1886781440;
						short num3 = num2;
						num2 = (short)1134690313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FB;
				case 3:
					if (trkEmerTone_ == 0)
					{
						num2 = (short)1870135300;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					goto IL_FB;
				case 5:
					num2 = (short)813563905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (trunkingEmergencyProfiles.General.TrkEmerProfImpactDetectionEn_A43392)
					{
						num2 = (short)208601095;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BB;
				case 7:
					num2 = (short)916389896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (trunkingEmergencyToneTableInnerSection.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value == 2)
					{
						num2 = (short)473628683;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BB;
				case 9:
					num2 = (short)405078019;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (trunkingEmergencyToneTableInnerSection.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0)
					{
						num2 = (short)1767243781;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FB;
				case 11:
					goto IL_F6;
				}
				goto IL_40;
				IL_FB:
				num2 = (short)98435078;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1BB:
				num2 = (short)682402549;
				short num4 = num2;
				num2 = (short)851550965;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FB;
				default:
					goto IL_1F1;
				}
			}
			IL_F6:
			return trkEmerTone_ != 0;
			IL_1F1:
			num2 = (short)771162112;
			if (num2 != 0)
			{
			}
			return false;
			IL_40:
			trunkingEmergencyToneTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection);
			trunkingEmergencyProfiles = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles);
			trkEmerTone_ = trunkingEmergencyToneTableInnerSection.TrkEmerTone_42108;
			num2 = (short)1817509898;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x008CEAEC File Offset: 0x008CCCEC
		internal static bool conTrkEmerPrfTonePeriodInvalid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpSimpleRangeField trkEmerTonePeriodSec_ = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection).TrkEmerTonePeriodSec_42110;
			if (trkEmerTonePeriodSec_.Value >= 1)
			{
				short num = (short)2008830634;
				short num2 = num;
				num = (short)2077905578;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)991625217;
					if (num != 0)
					{
					}
					num = (short)430768128;
					short num3 = num;
					num = (short)1804075008;
					if (num != 0)
					{
					}
					return trkEmerTonePeriodSec_.Value > 4;
				}
				}
			}
			return true;
		}

		// Token: 0x060095F6 RID: 38390 RVA: 0x008CEBBC File Offset: 0x008CCDBC
		internal static bool conTrkAudioRoutingIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection trunkingEmergencyToneTableInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1251344391;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (trunkingEmergencyToneTableInnerSection.TrkEmerTone_42108 != 0)
					{
						num2 = (short)1993998337;
						if (num2 != 0)
						{
						}
						num2 = (short)1167785984;
						short num3 = num2;
						num2 = (short)1757151235;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					goto IL_116;
				case 3:
					num2 = (short)1874788357;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_161;
				case 5:
					if (trunkingEmergencyToneTableInnerSection.TrkEmerTonePeriodSec_42110 >= 5)
					{
						num2 = (short)1265369088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
				{
					num2 = (short)486567820;
					short num4 = num2;
					num2 = (short)2084204428;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_161;
					default:
						num2 = (short)1945108480;
						if (num2 != 0)
						{
						}
						if (trunkingEmergencyToneTableInnerSection.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135)
						{
							num2 = (short)1444347908;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 7:
					if (trunkingEmergencyToneTableInnerSection.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0)
					{
						num2 = (short)1479540738;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_30;
				IL_161:
				num2 = (short)974520321;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_116:
			return trunkingEmergencyToneTableInnerSection.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1;
			IL_30:
			trunkingEmergencyToneTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection);
			num2 = (short)1103888390;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060095F7 RID: 38391 RVA: 0x008CEDD8 File Offset: 0x008CCFD8
		internal static bool conAutoModeIsHotMicEmergencyForTRK(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)770179073;
			if (num != 0)
			{
			}
			num = (short)605257223;
			short num2 = num;
			num = (short)550010375;
			switch (num2 == num)
			{
			}
			num = (short)1661468672;
			if (num != 0)
			{
			}
			num = (short)81133568;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General).TrkEmerProEmergencyAutoTransmitMode_A22567.Value == 2;
		}

		// Token: 0x060095F8 RID: 38392 RVA: 0x008CEE94 File Offset: 0x008CD094
		internal static bool conImpDetectApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1451244565;
			short num2 = num;
			num = (short)1134115861;
			switch (num2 == num)
			{
			}
			num = (short)241565697;
			if (num != 0)
			{
			}
			num = (short)1677918208;
			if (num != 0)
			{
			}
			num = (short)1035272192;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General).RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value == 2;
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x008CEF5C File Offset: 0x008CD15C
		internal static bool conTriggedByManDownEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection trunkingEmergencyToneTableInnerSection;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)97910784;
					short num3 = num2;
					num2 = (short)684130305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (!trunkingEmergencyToneTableInnerSection.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135)
					{
						num2 = (short)176095235;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AE;
				case 2:
					goto IL_EF;
				case 3:
					goto IL_AB;
				case 4:
					num2 = (short)1049034757;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (trunkingEmergencyToneTableInnerSection.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1)
					{
						num2 = (short)1344995328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB;
				case 6:
					if (trunkingEmergencyToneTableInnerSection.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0)
					{
						num2 = (short)1986985988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB;
				case 7:
					if (trunkingEmergencyProfiles.General.TrkEmerProfImpactDetectionEn_A43392)
					{
						num2 = (short)1243348994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_30;
				IL_AB:
				num2 = (short)2030567431;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EF:
			return trunkingEmergencyToneTableInnerSection.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value == 2;
			IL_1AE:
			num2 = (short)1528768813;
			short num4 = num2;
			num2 = (short)376711469;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
				num2 = (short)111411200;
				if (num2 != 0)
				{
				}
				num2 = (short)155320321;
				if (num2 != 0)
				{
				}
				return true;
			}
			IL_30:
			trunkingEmergencyToneTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection);
			trunkingEmergencyProfiles = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles);
			num2 = (short)1088684038;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x008CF18C File Offset: 0x008CD38C
		internal static bool ConTrunkEmerHotMicRestartIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)355467265;
			if (num != 0)
			{
			}
			if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles).General.TrkEmerProEmergencyAutoTransmitMode_A22567.Value == 2)
			{
				num = (short)118795227;
				short num2 = num;
				num = (short)454798299;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)556990464;
					short num3 = num;
					num = (short)1377107968;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.CheckTrkEmergencyCompatibilityOptions(self);
				}
				}
			}
			return false;
		}

		// Token: 0x060095FB RID: 38395 RVA: 0x008CF260 File Offset: 0x008CD460
		internal static bool ConValidateTrunSysConsoleEmergExitContr(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1636958208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset o3HHCHButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset kmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag;
					switch (num2)
					{
					case 0:
						if (index != 2)
						{
							num = (short)1177157643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_976;
					case 1:
						return result;
					case 2:
						goto IL_54E;
					case 3:
						if (index == 3)
						{
							num = (short)394526735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						if (index == 1)
						{
							num = (short)1921712145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54E;
					case 5:
						enumerator = o3HHCHButtonInnerRecset.GetEnumerator();
						num = (short)1814036489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (kmbuttonInnerRecset != null)
						{
							num = (short)117374989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BE;
					case 7:
					{
						num = (short)1752891392;
						short num3 = num;
						goto IL_710;
					}
					case 8:
						num = (short)1830682625;
						if (num != 0)
						{
						}
						if (o3HHCHButtonInnerRecset != null)
						{
							num = (short)95289349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_513;
					case 9:
						try
						{
							num = (short)87097347;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3B6;
								case 2:
									num = (short)1794179072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_330;
									}
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)209780738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner)enumerator.Current).O3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.CalculateValidity();
									num = (short)1416560641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_332:
								num = (short)1038352388;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_330:
								goto IL_332;
							}
							IL_3B6:
							goto IL_513;
						}
						finally
						{
							num = (short)2078408706;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)194379777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_426;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3EE;
									}
									continue;
								}
								IL_3EE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)662831104;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_426:;
						}
						goto IL_429;
					case 10:
						try
						{
							num = (short)103153667;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_64D;
								case 1:
									num = (short)1893072896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)388562945;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)enumerator.Current).KMButtonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.CalculateValidity();
									num = (short)455344132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_5C6;
									}
									continue;
								}
								IL_5FC:
								num = (short)746323970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5C6:
								goto IL_5FC;
							}
							IL_64D:
							goto IL_2BE;
						}
						finally
						{
							num = (short)1367212034;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1656160257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_70D;
								case 2:
								{
									num = (short)1340418091;
									short num4 = num;
									num = (short)1556752427;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_6D8;
									default:
										num = (short)63963136;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_6D4;
										}
										continue;
									}
									break;
								}
								}
								goto IL_6D4;
								IL_6D8:
								num = (short)1865220096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6D4:
								if (enumerator != null)
								{
									goto IL_6D8;
								}
								break;
							}
							IL_70D:;
						}
						goto Block_11;
					case 11:
						num = (short)243269636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						flag = false;
						goto IL_449;
					case 13:
						enumerator = kmbuttonInnerRecset.GetEnumerator();
						num = (short)2064515082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)91226133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)2098200596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (rsmbuttonInnerRecset != null)
						{
							num = (short)1560412179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25E;
					case 17:
						goto IL_976;
					case 18:
						flag = global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.CheckDVRSAndRadioSelection(self);
						goto IL_449;
					case 19:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)2028470279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.CheckTrkEmergencyCompatibilityOptions(self))
						{
							num = (short)2108751895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)63176716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_844;
					case 22:
						if (portableButtonInnerRecset != null)
						{
							num = (short)585629710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B3;
					case 23:
						goto IL_429;
					}
					goto IL_8E;
					IL_25E:
					result = true;
					num = (short)1154744320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_11:
					try
					{
						IL_710:
						num = (short)1339883523;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_7D0;
							case 2:
								num = (short)648413184;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_74A;
								}
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)1615003650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								((global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner)enumerator.Current).RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.CalculateValidity();
								num = (short)559939585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_74C:
							num = (short)1485766660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_74A:
							goto IL_74C;
						}
						IL_7D0:
						goto IL_25E;
					}
					finally
					{
						num = (short)2102788098;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)174063617;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_841;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_807;
								}
								continue;
							}
							IL_807:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1815150592;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_841:;
					}
					goto Block_12;
					IL_2BE:
					num = (short)1843265552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_429:
					num = (short)484966418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_449:
					result = flag;
					num = (short)2029518849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B3:
					num = (short)268501000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_12:
					try
					{
						IL_844:
						num = (short)495583235;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_905;
							case 1:
								num = (short)1289617408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)1229520897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								((global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner)enumerator.Current).PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.CalculateValidity();
								num = (short)1422524420;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_87E;
								}
								continue;
							}
							IL_8B2:
							num = (short)115802114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_87E:
							goto IL_8B2;
						}
						IL_905:
						goto IL_4B3;
					}
					finally
					{
						num = (short)281608194;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)249430017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_973;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_93C;
								}
								continue;
							}
							IL_93C:
							if (enumerator == null)
							{
								break;
							}
							num = (short)909574144;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_973:;
					}
					goto IL_976;
					IL_513:
					num = (short)331546630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54E:
					num = (short)494731267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_976:
					result = global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.CheckTrkEmergencyCompatibilityOptions(self);
					num = (short)369819650;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_8E:
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				o3HHCHButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset)[0][10235].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset);
				kmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset)[0][10231].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				num = (short)1176436758;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x008CFC40 File Offset: 0x008CDE40
		internal static bool CheckTrkEmergencyCompatibilityOptions(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1591300101;
			short num2 = num;
			num = (short)842158085;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_8F;
			case 1:
				break;
			default:
			{
				num = (short)715980800;
				short num3 = num;
				break;
			}
			}
			num = (short)1019609088;
			if (num != 0)
			{
			}
			num = (short)1834221568;
			switch (num)
			{
			default:
			{
				IL_8F:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles;
				global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset;
				bool result = false;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = collection.GetEnumerator();
				bool result2;
				try
				{
					num = (short)1372782601;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = trunkingPersonality.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
							num = (short)34734095;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1154744328;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1263009802;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current;
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles2 = trunkingPersonality.General.TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles;
							num = (short)2146566158;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							result = true;
							num = (short)952369168;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1330249739;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_3A0;
						case 6:
							goto IL_142;
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles2;
							if (trunkingEmergencyProfiles2.NodeId == trunkingEmergencyProfiles.NodeId)
							{
								num = (short)1671757824;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
							{
								num = (short)1379401732;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12A;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_125;
							}
							continue;
						case 10:
							num = (short)1773076485;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (!trunkingSystem.ASTRO26.TrkSysASTRO25MotorolaProprietaryFeatures_A8547.Value)
							{
								num = (short)182321155;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12A;
						}
						case 12:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles2;
							if (trunkingEmergencyProfiles2.General.TrkEmerProfGeneralEmergencyOperation_A7926.Value != 1)
							{
								num = (short)2061434881;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12A;
						}
						case 13:
							num = (short)305201164;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles2;
							if (trunkingEmergencyProfiles2 != null)
							{
								num = (short)632029201;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 15:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (trunkingSystem != null)
							{
								num = (short)1258094605;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 17:
							num = (short)64159751;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
						IL_12A:
						result2 = false;
						num = (short)920518662;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D7:
						num = (short)965410818;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_125:
						goto IL_1D7;
					}
					IL_142:
					goto IL_410;
					IL_3A0:
					return result;
				}
				finally
				{
					num = (short)76414976;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_3D8;
							}
							continue;
						case 1:
							goto IL_40D;
						case 2:
							enumerator.Dispose();
							num = (short)1918173185;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3D8:
						if (enumerator == null)
						{
							break;
						}
						num = (short)47841282;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_40D:;
				}
				IL_410:
				num = (short)1283063809;
				if (num != 0)
				{
				}
				return result2;
			}
			}
		}

		// Token: 0x060095FD RID: 38397 RVA: 0x008D00A4 File Offset: 0x008CE2A4
		internal static bool CheckDVRSAndRadioSelection(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1490354176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1740743691;
				short num3 = num;
				num = (short)1507566603;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1308950528;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles2;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					for (;;)
					{
						IL_73:
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)838664194;
								num2 = (int)((global::System.IntPtr)num);
								bool result;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1440677897;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										result = false;
										num = (short)146341892;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_16F;
										}
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)262275072;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current;
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles = trunkingPersonality.General.TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles;
										num = (short)777060353;
										if (num != 0)
										{
										}
										num = (short)530120710;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_18A;
									case 5:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles;
										if (trunkingEmergencyProfiles.NodeId == trunkingEmergencyProfiles2.NodeId)
										{
											num = (short)1969750023;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles;
										if (trunkingEmergencyProfiles != null)
										{
											num = (short)372244490;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
										num = (short)770572296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
										if (trunkingPersonality.General.TrkPerFeaturesDVRSProf_A41796.Value != 0)
										{
											num = (short)831127553;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
										goto IL_2FD;
									case 10:
										num = (short)431357957;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_18F:
									num = (short)1155268611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_16F:
									goto IL_18F;
								}
								IL_18A:
								return result;
								IL_2FD:
								goto IL_D6;
							}
							finally
							{
								num = (short)220725248;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_336;
										}
										continue;
									case 1:
										goto IL_36E;
									case 2:
										enumerator.Dispose();
										num = (short)351141889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_336:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1302265858;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_36E:;
							}
							goto IL_371;
							IL_D6:
							num = (short)693633026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_11A;
						case 2:
							if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
							{
								num = (short)120389633;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_371;
						}
						goto IL_86;
					}
					IL_11A:
					break;
					IL_371:
					num = (short)1775042560;
					short num4 = num;
					return true;
					IL_86:
					trunkingEmergencyProfiles2 = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles);
					global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset;
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					enumerator = collection.GetEnumerator();
					num = (short)1135607808;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_73;
				}
				}
				return false;
			}
			}
		}

		// Token: 0x060095FE RID: 38398 RVA: 0x008D046C File Offset: 0x008CE66C
		internal static void conSetValueTrkHotMicTxPeriod(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1096876032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				global::AcpBusinessLayer.AcpSimpleRangeField trkEmerProfGeneralTxPeriodsec2_A;
				int num5;
				int num6;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_185;
					case 1:
					{
						num = (short)942327273;
						short num3 = num;
						num = (short)1869858281;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11D;
						case 1:
							break;
						default:
						{
							num = (short)351928320;
							short num4 = num;
							break;
						}
						}
						num = (short)1056702465;
						if (num != 0)
						{
						}
						num = (short)1189347328;
						if (num != 0)
						{
						}
						goto IL_185;
					}
					case 2:
						if (trkEmerProfGeneralTxPeriodsec2_A > num5 * 10)
						{
							num = (short)2121203716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119;
					case 3:
						if (num5 >= num6)
						{
							num = (short)270794759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2070806530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1766916101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (trkEmerProfGeneralTxPeriodsec2_A <= (num5 + 1) * 10)
						{
							num = (short)69599238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119;
					case 6:
						goto IL_1FE;
					case 7:
						return;
					}
					goto IL_50;
					IL_11D:
					num = (short)114688000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_185:
					num = (short)769523715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_119:
					num5++;
					goto IL_11D;
				}
				return;
				IL_1FE:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General general;
				general.TrkEmerProfGeneralTxPeriodsec1_A7939.Value = num5 + 1;
				return;
				IL_50:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General);
				trkEmerProfGeneralTxPeriodsec2_A = general.TrkEmerProfGeneralTxPeriodsec2_A43601;
				int num7 = 1;
				num6 = 12;
				num5 = num7 - 1;
				num = (short)1814691841;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}
	}
}
