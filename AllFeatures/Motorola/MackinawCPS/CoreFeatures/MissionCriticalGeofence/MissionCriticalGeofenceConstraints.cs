using System;
using System.Collections.Generic;
using System.Device.Location;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x02000265 RID: 613
	public static class MissionCriticalGeofenceConstraints
	{
		// Token: 0x06006E06 RID: 28166 RVA: 0x006207B4 File Offset: 0x0061E9B4
		internal static bool ConLocationEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_F1;
					case 1:
						goto IL_149;
					case 2:
						num2 = (short)677249025;
						if (num2 != 0)
						{
						}
						missionCriticalGeofence = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence);
						num2 = (short)1675296769;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)501547008;
						short num3 = num2;
						if (self.ParentRecset.IsEmbeddedRecset)
						{
							num2 = (short)1107361794;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						missionCriticalGeofence = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence);
						num2 = (short)601018355;
						short num4 = num2;
						num2 = (short)1865601011;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22;
						default:
							num2 = (short)907608064;
							if (num2 != 0)
							{
							}
							num2 = (short)896008192;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_20;
				}
				IL_F1:
				IL_149:
				return missionCriticalGeofence.General.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.Value;
			}
			IL_20:
			missionCriticalGeofence = null;
			IL_22:
			num2 = (short)68026371;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x00620928 File Offset: 0x0061EB28
		internal static bool conGeofencePriorityValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)981204992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				int value;
				global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence2;
				global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset missionCriticalGeofenceRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1639710720;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_EB;
									}
									continue;
								case 1:
									result = false;
									num = (short)1143209992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									if (missionCriticalGeofence.General.McGeofencePriority_42879.Value == value)
									{
										num = (short)2029584385;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)398000137;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence = (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence)enumerator.Current;
									num = (short)1445658634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)253820934;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_232;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									if (missionCriticalGeofence2 != missionCriticalGeofence)
									{
										num = (short)1968504839;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)1458765826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_14B;
								case 9:
									num = (short)538247173;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									if (missionCriticalGeofence != null)
									{
										num = (short)133890052;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_150:
								num = (short)1246101507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EB:
								goto IL_150;
							}
							IL_14B:
							return result;
							IL_232:
							return true;
						}
						finally
						{
							num = (short)517182234;
							short num3 = num;
							num = (short)1001624346;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_2B8:
								num = (short)682885121;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1180631040;
								if (num != 0)
								{
								}
								num = (short)1236467714;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2EB;
								case 1:
									enumerator.Dispose();
									num = (short)1615396864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2B5;
									}
									continue;
								}
								break;
							}
							IL_2B5:
							if (enumerator != null)
							{
								goto IL_2B8;
							}
							IL_2EB:;
						}
						goto IL_2EE;
					case 1:
						goto IL_2EE;
					case 2:
						if (missionCriticalGeofence2 != null)
						{
							num = (short)1636892673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_3A;
					IL_2EE:
					num = (short)153878528;
					short num4 = num;
					enumerator = missionCriticalGeofenceRecset.GetEnumerator();
					num = (short)1286602753;
					if (num != 0)
					{
					}
					num = (short)1164771328;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_3A:
				global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General general = self as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General;
				missionCriticalGeofence2 = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence);
				missionCriticalGeofenceRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset);
				value = general.McGeofencePriority_42879.Value;
				num = (short)1882390530;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x00620CB8 File Offset: 0x0061EEB8
		internal static bool conGeofenceRadiusApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)21168129;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_5F;
			}
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General general;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					if (general != null)
					{
						num = (short)1406074880;
						short num3 = num;
						num = (short)444661769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
					if (coordinatesInnerRecset.Count != 0)
					{
						num = (short)211484680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
					if (coordinatesInnerRecset != null)
					{
						num = (short)2062811141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DE;
				}
				case 3:
					if (!radioWide.Location.RadWideLocationLocationEnable_A8448.Value)
					{
						num = (short)1611923463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)1924988929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)240910342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
					if (coordinatesInnerRecset.Count <= 2)
					{
						num = (short)479920132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 7:
					goto IL_124;
				case 8:
					goto IL_DE;
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset = general.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset;
					num = (short)1760624642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_5F;
				IL_DE:
				num = (short)1428422659;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_124:
			num = (short)1598391258;
			short num4 = num;
			num = (short)446727130;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1999503360;
				if (num != 0)
				{
				}
				break;
			}
			return false;
			IL_5F:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General);
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num = (short)34275328;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00620EF8 File Offset: 0x0061F0F8
		internal static bool conGeofenceRadiusEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General general;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)237371396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return false;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
						if (coordinatesInnerRecset != null)
						{
							num2 = (short)1192099840;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset = general.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset;
						num2 = (short)295698434;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
						if (coordinatesInnerRecset.Count == 2)
						{
							num2 = (short)526712833;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					case 5:
					{
						num2 = (short)22762260;
						short num3 = num2;
						num2 = (short)771379988;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2F;
						default:
						{
							num2 = (short)1250951168;
							short num4 = num2;
							num2 = (short)1245185;
							if (num2 != 0)
							{
							}
							num2 = (short)74645504;
							if (num2 != 0)
							{
							}
							if (general != null)
							{
								num2 = (short)226099203;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return true;
						}
						}
						break;
					}
					}
					goto IL_28;
				}
				return false;
			}
			IL_28:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General);
			IL_2F:
			num2 = (short)322502661;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x00621080 File Offset: 0x0061F280
		internal static bool conExitActionValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_AC;
			}
			short num;
			int num4;
			global::AcpBusinessLayer.AcpRecRefField mcGeofenceExitAction_;
			for (;;)
			{
				IL_0A:
				num = (short)2000823745;
				short num2 = num;
				num = (short)1412441537;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
				{
					num = (short)1787232256;
					short num3 = num;
					num = (short)1519648768;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (index == 0)
						{
							num = (short)1711931401;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)739115010;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (mcGeofenceExitAction_.RefRecset != null)
						{
							num = (short)2080047112;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						if (mcGeofenceExitAction_ != null)
						{
							num = (short)2119041029;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
						if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value == 2)
						{
							num = (short)47251463;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
						num = (short)1799028739;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1208680449;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)997982209;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
						if (actionConsolidation != null)
						{
							num = (short)2065629188;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 7:
						return true;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation = mcGeofenceExitAction_.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
						num = (short)2087059462;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return true;
					}
					goto IL_AC;
				}
				}
			}
			return true;
			IL_AC:
			mcGeofenceExitAction_ = (self as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General).McGeofenceExitAction_42888;
			num = (short)208601088;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x006212B4 File Offset: 0x0061F4B4
		internal static void ConSetGeofenceRadius(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)231735296;
			switch (num)
			{
			default:
			{
				num = (short)1932853253;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Device.Location.GeoCoordinate geoCoordinate;
				global::System.Device.Location.GeoCoordinate geoCoordinate2;
				global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General general;
				for (;;)
				{
					double num3;
					double num5;
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerSection coordinatesInnerSection;
					switch (num2)
					{
					case 0:
						goto IL_F8;
					case 1:
						if (num3 <= 180.0)
						{
							num = (short)2061041694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					case 2:
						num = (short)426835994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						double num4;
						if (num4 >= -90.0)
						{
							num = (short)1983184898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					}
					case 4:
						if (geoCoordinate != null)
						{
							num = (short)692060179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BC;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_D1;
						}
						continue;
					case 6:
						num = (short)971964429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_555;
					case 8:
						num = (short)1249640471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						geoCoordinate2 = new global::System.Device.Location.GeoCoordinate(num5, num3);
						num = (short)1737621504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_2FD;
					case 11:
						if (coordinatesInnerRecset.Count > 2)
						{
							num = (short)768081942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)740425746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						geoCoordinate = null;
						geoCoordinate2 = null;
						global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner = coordinatesInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner;
						double num6 = global::System.Convert.ToDouble(coordinatesInner.CoordinatesInnerSection.McGeofenceLongitude_42893.UIValue);
						double num4 = global::System.Convert.ToDouble(coordinatesInner.CoordinatesInnerSection.McGeofenceLatitude_42894.UIValue);
						num = (short)1716322333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						double num6;
						if (num6 <= 180.0)
						{
							num = (short)431620129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					}
					case 14:
						return;
					case 15:
						goto IL_627;
					case 16:
						if (coordinatesInnerRecset != null)
						{
							num = (short)155582485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BC;
					case 17:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(general.McGeofenceRadiusInMeters_42890, 10));
						num = (short)1702166555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (coordinatesInnerRecset.Count == 0)
						{
							num = (short)1866203153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BC;
					case 19:
						num = (short)1504575520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						double num4;
						double num6;
						geoCoordinate = new global::System.Device.Location.GeoCoordinate(num4, num6);
						num = (short)62783495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						num = (short)2028273695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_245;
					case 23:
					{
						num = (short)2038034238;
						short num7 = num;
						num = (short)530247486;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_627;
						default:
							num = (short)745799680;
							if (num != 0)
							{
							}
							if (num5 <= 90.0)
							{
								num = (short)1974337545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F8;
						}
						break;
					}
					case 24:
						if (num3 >= -180.0)
						{
							num = (short)644218908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					case 25:
						if (coordinatesInnerSection != null)
						{
							num = (short)1515716623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BC;
					case 26:
					{
						double num4;
						if (num4 <= 90.0)
						{
							num = (short)1761411092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					}
					case 27:
						goto IL_40E;
					case 28:
						num = (short)1603534849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						double num6;
						if (num6 >= -180.0)
						{
							num = (short)225181702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					}
					case 30:
						num = (short)181796898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (coordinatesInnerRecset.Count == 2)
						{
							num = (short)1206124556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)44236811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (geoCoordinate2 != null)
						{
							num = (short)495190026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BC;
					case 33:
						num = (short)2124087299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (num5 >= -90.0)
						{
							num = (short)626786312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					}
					IL_D1:
					if (global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
					{
						num = (short)1467613198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					coordinatesInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerSection);
					general = (coordinatesInnerSection.Parent.Parent.ParentSection as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General);
					num = (short)607125529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F8:
					num = (short)430833668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_555:
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner2 = coordinatesInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner;
					num3 = global::System.Convert.ToDouble(coordinatesInner2.CoordinatesInnerSection.McGeofenceLongitude_42893.UIValue);
					num5 = global::System.Convert.ToDouble(coordinatesInner2.CoordinatesInnerSection.McGeofenceLatitude_42894.UIValue);
					num = (short)1597767704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_627:
					num = (short)1752170496;
					short num8 = num;
					coordinatesInnerRecset = (coordinatesInnerSection.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset);
					num = (short)437649424;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_245:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(general.McGeofenceRadiusInMeters_42890, 0));
				return;
				IL_2FD:
				double distanceTo = geoCoordinate.GetDistanceTo(geoCoordinate2);
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(general.McGeofenceRadiusInMeters_42890, global::System.Convert.ToInt32(distanceTo)));
				return;
				IL_40E:
				IL_6BC:
				num = (short)905117697;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x006219A8 File Offset: 0x0061FBA8
		internal static bool conGeofenceRadiusValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2022115405;
			short num2 = num;
			num = (short)1412892749;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)667549696;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General general;
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
						if (general.McGeofenceRadiusInMeters_42890.Value > 0)
						{
							num = (short)543358976;
							short num4 = num;
							num = (short)341442561;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7;
					case 1:
						num = (short)1165230086;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (general != null)
						{
							num = (short)369491975;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						goto IL_B7;
					case 4:
						goto IL_11F;
					case 5:
						num = (short)271908865;
						if (num != 0)
						{
						}
						if (general.McGeofenceRadiusInMeters_42890.Value > 5000000)
						{
							num = (short)390004740;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						if (general.McGeofenceRadiusInMeters_42890.Value >= 10)
						{
							num = (short)178257923;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						num = (short)747110400;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
					IL_B7:
					num = (short)1912668165;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_11F:
				break;
				IL_7B:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General);
				num = (short)1983774722;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			}
			return false;
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x00621B90 File Offset: 0x0061FD90
		internal static bool conEntryActionValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_AC;
			}
			short num;
			int num4;
			global::AcpBusinessLayer.AcpRecRefField mcGeofenceExitAction_;
			for (;;)
			{
				IL_0A:
				num = (short)963582667;
				short num2 = num;
				num = (short)187636427;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
				{
					num = (short)1800470528;
					short num3 = num;
					num = (short)85524480;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (index == 0)
						{
							num = (short)1989869577;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)903806978;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (mcGeofenceExitAction_.RefRecset != null)
						{
							num = (short)1215692808;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						if (mcGeofenceExitAction_ != null)
						{
							num = (short)1047855109;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
						if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value != 0)
						{
							num = (short)1869086727;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
						num = (short)1072103427;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)476708865;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
						if (actionConsolidation != null)
						{
							num = (short)1678704644;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 7:
						return true;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation = mcGeofenceExitAction_.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
						num = (short)263913478;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return true;
					}
					goto IL_AC;
				}
				}
			}
			return true;
			IL_AC:
			mcGeofenceExitAction_ = (self as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General).McGeofenceExitAction_42888;
			num = (short)1671823361;
			if (num != 0)
			{
			}
			num = (short)443940864;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
