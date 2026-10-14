using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000557 RID: 1367
	public static class ConventionalSystemConstraints
	{
		// Token: 0x0600B6F4 RID: 46836 RVA: 0x00A94410 File Offset: 0x00A92610
		internal static bool conConventionalRemMonRadTraceIsEnabledAndDvrsIsDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1873739778;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			for (;;)
			{
				global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
				switch (num2)
				{
				case 0:
					goto IL_145;
				case 1:
					num = (short)375521283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					if (cnvSysGeneralSystemType_A.Value != 2)
					{
						num = (short)1251147781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18A;
				case 4:
				{
					if (cnvSysGeneralSystemType_A.Value != 0)
					{
						return true;
					}
					num = (short)1882060584;
					short num3 = num;
					num = (short)1626732328;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18A;
					default:
						num = (short)1051262976;
						if (num != 0)
						{
						}
						num = (short)1179713536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					num = (short)45547521;
					if (num != 0)
					{
					}
					num = (short)441057284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features;
				conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				cnvSysGeneralSystemType_A = conventionalSystem.General.CnvSysGeneralSystemType_A13262;
				if (features.CnvSysFeaturesRemoteRadioMode_A8935.Value == 0)
				{
					goto IL_18A;
				}
				num = (short)271843329;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_145:
			return !conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value;
			IL_18A:
			num = (short)1102315520;
			short num4 = num;
			return false;
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x00A945D4 File Offset: 0x00A927D4
		internal static bool conConventionalStatusIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)486604800;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)113418626;
					short num3 = num;
					num = (short)1358012802;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A3;
					default:
						num = (short)1079443456;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					}
					break;
				}
				case 1:
					if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
					{
						num = (short)1810497539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
				{
					num = (short)642514945;
					if (num != 0)
					{
					}
					num = (short)826867712;
					short num4 = num;
					num = (short)2012938241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_161;
				}
				goto IL_82;
				IL_A3:
				num = (short)1456472066;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_82:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features;
				conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				if (features.CnvSysFeaturesStatus_A9186.Value)
				{
					goto IL_A3;
				}
				return false;
			}
			return true;
			IL_161:
			return !conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value;
		}

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x00A94748 File Offset: 0x00A92948
		internal static bool ConBoolMdcSysLdngPttIdEnIsEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1772945408;
			short num2 = num;
			num = (short)572522497;
			if (num != 0)
			{
			}
			num = (short)843622834;
			short num3 = num;
			num = (short)1735567794;
			global::AcpBusinessLayer.AcpListField cnvSysGeneralPTTID_A;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)684261376;
				if (num != 0)
				{
				}
				cnvSysGeneralPTTID_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General).CnvSysGeneralPTTID_A8427;
				if (cnvSysGeneralPTTID_A.Value == 1)
				{
					return true;
				}
				break;
			}
			return cnvSysGeneralPTTID_A.Value == 3;
		}

		// Token: 0x0600B6F7 RID: 46839 RVA: 0x00A94810 File Offset: 0x00A92A10
		internal static bool ConMdcSysDosEnIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)83168321;
			short num2 = num;
			num = (short)1648430145;
			switch (num2 == num)
			{
			}
			num = (short)1241579521;
			if (num != 0)
			{
			}
			num = (short)1822556160;
			short num3 = num;
			num = (short)1557463040;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features).CnvSysFeaturesDataOperatedSquelchDOS_A7796.Value;
		}

		// Token: 0x0600B6F8 RID: 46840 RVA: 0x00A948C8 File Offset: 0x00A92AC8
		internal static void conSetNumberOfPreamblesRac(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)580138040;
			short num2 = num;
			num = (short)1567306808;
			switch (num2 == num)
			{
			}
			num = (short)338296832;
			if (num != 0)
			{
			}
			num = (short)708247552;
			short num3 = num;
			num = (short)898564097;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			global::AcpBusinessLayer.AcpField<bool> cnvSysLabtoolPreambleEnable_A = general.CnvSysLabtoolPreambleEnable_A19576;
			global::AcpBusinessLayer.AcpSimpleRangeField cnvSysGeneralSystemPretimems2_A = general.CnvSysGeneralSystemPretimems2_A9246;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(general.CnvSysGeneralPreambles_A8731, global::ConstraintHelper.UtilityMack.SetPreambles(cnvSysLabtoolPreambleEnable_A.Value, global::System.Convert.ToInt32(general.CnvSysGeneralRepeaterAccessPretimems_A8741.UIValue))));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(conventionalSystem.Labtool.CnvSysLabtoolInterPacketPreambles_A8311, global::ConstraintHelper.UtilityMack.SetPreambles(cnvSysLabtoolPreambleEnable_A.Value, global::System.Convert.ToInt32(general.CnvSysGeneralInterPacketTimems_A8312.UIValue))));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(conventionalSystem.Labtool.CnvSysLabtoolAckPreambles_A7392, global::ConstraintHelper.UtilityMack.SetPreambles(cnvSysLabtoolPreambleEnable_A.Value, global::System.Convert.ToInt32(general.CnvSysGeneralAckPretimems_A7393.UIValue))));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(conventionalSystem.Labtool.CnvSysLabtoolCPTotalPretimeMDC_A7789, global::ConstraintHelper.UtilityMack.SetPretime(true, global::System.Convert.ToInt32(cnvSysGeneralSystemPretimems2_A.UIValue), true)));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(conventionalSystem.Labtool.CnvSysLabtoolPreambles_A8730, global::ConstraintHelper.UtilityMack.SetPreambles(cnvSysLabtoolPreambleEnable_A.Value, global::System.Convert.ToInt32(cnvSysGeneralSystemPretimems2_A.UIValue))));
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x00A94A74 File Offset: 0x00A92C74
		internal static bool conSelCallResetIsNotManual(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)251330560;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)639686497;
					short num3 = num;
					num = (short)1936906081;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C8;
					default:
						num = (short)498925568;
						if (num != 0)
						{
						}
						num = (short)412942337;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					}
					break;
				}
				case 1:
					if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
					{
						num = (short)1980628995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
				{
					num = (short)1019871232;
					short num4 = num;
					num = (short)2073362433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_15F;
				}
				goto IL_A7;
				IL_C8:
				num = (short)2041577474;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A7:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features;
				conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				if (features.CnvSysFeaturesSelectCallInCallReset_A9102.Value != 0)
				{
					goto IL_C8;
				}
				return false;
			}
			return true;
			IL_15F:
			return !conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value;
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x00A94BE4 File Offset: 0x00A92DE4
		internal static bool ConValidateSelCallInCallReset(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)631767040;
			switch (num)
			{
			default:
			{
				num = (short)950861830;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					num = (short)689569793;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)720904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (index == 0)
						{
							num = (short)938475531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					case 2:
					{
						global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262;
						num = (short)447545357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)829947905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
						num = (short)78577669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_F9;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 7:
						return true;
					case 8:
						if (index == 0)
						{
							num = (short)998703108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 9:
						goto IL_55A;
					case 10:
					{
						num = (short)2103443456;
						short num3 = num;
						global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
						if (cnvSysGeneralSystemType_A.Value == 3)
						{
							num = (short)1846018048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 11:
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
						num = (short)1866924041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
						if (cnvSysGeneralSystemType_A.Value == 1)
						{
							num = (short)293076995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					}
					case 13:
					{
						global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
						if (cnvSysGeneralSystemType_A.Value == 0)
						{
							num = (short)1845886983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)91488268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A4:
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						num = (short)1073217538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
					IL_FE:
					num = (short)1517420554;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F9:
				bool result;
				try
				{
					num = (short)858587143;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if ((conventionalPersonality[10143] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.NonASTROCall).CnvPerNonASTROCallSelectiveCallRxTx_A9116.Value == 3)
							{
								num = (short)1669005326;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1259798541;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
							num = (short)1323171849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)1933508619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if ((conventionalPersonality[10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingSignalingType_A9129.Value == 10)
							{
								num = (short)1222639618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_318;
						case 5:
							num = (short)474480652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)487260163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_20F;
							}
							continue;
						case 8:
							goto IL_441;
						case 9:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if ((conventionalPersonality[10136] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions).CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 2)
							{
								num = (short)1303379974;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
							num = (short)1919614976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if ((conventionalPersonality[10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingSystemNumber_A9243.ReferencedNode == self.Parent)
							{
								num = (short)2063400965;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if ((conventionalPersonality[10143] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.NonASTROCall).CnvPerNonASTROCallSelectiveCallRxTx_A9116.Value != 1)
							{
								num = (short)520814602;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2FC;
						}
						case 13:
							num = (short)1222180872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_2FC;
						}
						IL_2BA:
						num = (short)977797121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_20F:
						goto IL_2BA;
						IL_2FC:
						result = false;
						num = (short)80478212;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_318:
					return result;
					IL_441:
					return true;
				}
				finally
				{
					num = (short)1407254529;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1538392066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_478;
							}
							continue;
						case 2:
							goto IL_4AF;
						}
						IL_478:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1045495808;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4AF:;
				}
				return true;
				IL_55A:
				try
				{
					num = (short)892141578;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_5D4:
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
							if ((conventionalPersonality2[10143] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.NonASTROCall).CnvPerNonASTROCallSelectiveCallRxTx_A9116.Value != 1)
							{
								num = (short)996409355;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_85D;
						}
						case 1:
							num = (short)118620174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)453836800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1721303045;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2 = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
							num = (short)746520584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)1299972109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)140115974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_895;
						case 7:
							goto IL_877;
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
							if ((conventionalPersonality2[10136] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions).CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 2)
							{
								num = (short)1295843329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_85D;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_617;
							}
							continue;
						case 11:
							num = (short)1250492428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
							if ((conventionalPersonality2[10143] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.NonASTROCall).CnvPerNonASTROCallSelectiveCallRxTx_A9116.Value == 3)
							{
								num = (short)255328265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
							if ((conventionalPersonality2[10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingSystemNumber_A9243.ReferencedNode == self.Parent)
							{
								num = (short)397869058;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 14:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
							while ((conventionalPersonality2[10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingSignalingType_A9129.Value == 4)
							{
								num = (short)1105003826;
								short num4 = num;
								num = (short)1618740530;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)968556544;
									if (num != 0)
									{
									}
									num = (short)1786904580;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_5D4;
								}
							}
							break;
						}
						}
						IL_713:
						num = (short)170852355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_617:
						goto IL_713;
						IL_85D:
						result = false;
						num = (short)1531641863;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_877:
					return result;
					IL_895:
					return true;
				}
				finally
				{
					num = (short)76546050;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1430781953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_902;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_8CC;
							}
							continue;
						}
						IL_8CC:
						if (enumerator == null)
						{
							break;
						}
						num = (short)593625088;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_902:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x00A9552C File Offset: 0x00A9372C
		internal static bool ConCnvSysRemRadioModeIsRadioTrace(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 1)
					{
						num2 = (short)1660944386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					num2 = (short)805896193;
					if (num2 != 0)
					{
					}
					num2 = (short)1836515328;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return false;
				case 3:
				{
					if (index != 1)
					{
						return true;
					}
					num2 = (short)878751469;
					short num3 = num2;
					num2 = (short)595439341;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
					{
						num2 = (short)1413152768;
						if (num2 != 0)
						{
						}
						num2 = (short)444268544;
						short num4 = num2;
						num2 = (short)1998979073;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_20;
			}
			return false;
			IL_20:
			conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
			num2 = (short)900268035;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x00A9567C File Offset: 0x00A9387C
		internal static void ConSetTotalPretimeAndNumberOfPreamblesSys(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1950181012;
			short num2 = num;
			num = (short)1683842708;
			switch (num2 == num)
			{
			}
			num = (short)701366273;
			if (num != 0)
			{
			}
			num = (short)741801984;
			short num3 = num;
			num = (short)196935680;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			global::AcpBusinessLayer.AcpSimpleRangeField cnvSysGeneralSystemPretimems2_A = general.CnvSysGeneralSystemPretimems2_A9246;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(conventionalSystem.Labtool.CnvSysLabtoolCPTotalPretimeMDC_A7789, global::ConstraintHelper.UtilityMack.SetPretime(true, global::System.Convert.ToInt32(cnvSysGeneralSystemPretimems2_A.UIValue), true)));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(conventionalSystem.Labtool.CnvSysLabtoolPreambles_A8730, global::ConstraintHelper.UtilityMack.SetPreambles(general.CnvSysLabtoolPreambleEnable_A19576.Value, global::System.Convert.ToInt32(cnvSysGeneralSystemPretimems2_A.UIValue))));
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x00A95798 File Offset: 0x00A93998
		internal static bool ConSystemTypeIsAstro(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)978262687;
			short num2 = num;
			num = (short)378739359;
			switch (num2 == num)
			{
			}
			num = (short)451870720;
			if (num != 0)
			{
			}
			num = (short)966262784;
			short num3 = num;
			num = (short)1287454721;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value == 0;
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x00A95860 File Offset: 0x00A93A60
		internal static bool ConSystemTypeIsMDC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2119440073;
			short num2 = num;
			num = (short)1828263625;
			switch (num2 == num)
			{
			}
			num = (short)1292697601;
			if (num != 0)
			{
			}
			num = (short)617676800;
			short num3 = num;
			num = (short)884473856;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value == 1;
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x00A95928 File Offset: 0x00A93B28
		internal static bool ConSystemTypeIsAstroOrIsMDC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262;
			if (cnvSysGeneralSystemType_A.Value != 0)
			{
				short num;
				for (;;)
				{
					num = (short)273416193;
					if (num != 0)
					{
					}
					num = (short)1027888438;
					short num2 = num;
					num = (short)1048466742;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_A7;
					}
					break;
				}
				num = (short)1749942272;
				short num3 = num;
				IL_A7:
				num = (short)801898496;
				if (num != 0)
				{
				}
				return cnvSysGeneralSystemType_A.Value == 1;
			}
			return true;
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x00A959FC File Offset: 0x00A93BFC
		internal static bool ConSystemTypeisMDCorDTMForQCII(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1292495687;
			short num2 = num;
			num = (short)1819601735;
			switch (num2 == num)
			{
			}
			num = (short)582680577;
			if (num != 0)
			{
			}
			num = (short)675020800;
			short num3 = num;
			num = (short)2142699520;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General).CnvSysGeneralSystemType_A13262.Value == 1;
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x00A95AB8 File Offset: 0x00A93CB8
		internal static bool ConSystemTypeisMDCorDTMF(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2070895831;
			short num2 = num;
			num = (short)1011047639;
			switch (num2 == num)
			{
			}
			num = (short)1276575745;
			if (num != 0)
			{
			}
			num = (short)645529600;
			short num3 = num;
			num = (short)1345781760;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General).CnvSysGeneralSystemType_A13262.Value == 1;
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x00A95B74 File Offset: 0x00A93D74
		internal static bool conCnvDataEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266;
			bool flag = false;
			if (cnvSysGeneralDataProfileSelection_A.Value != 0)
			{
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = cnvSysGeneralDataProfileSelection_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
				if (dataProfiles != null && dataProfiles.Features.DataProfFeaturesAtakField)
				{
					flag = true;
				}
			}
			if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
			{
				short num;
				for (;;)
				{
					num = (short)2300369;
					short num2 = num;
					num = (short)425990609;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_97;
					}
				}
				IL_97:
				num = (short)1306132480;
				short num3 = num;
				num = (short)386334720;
				if (num != 0)
				{
				}
				num = (short)477888513;
				if (num != 0)
				{
				}
				return !flag;
			}
			return false;
		}

		// Token: 0x0600B703 RID: 46851 RVA: 0x00A95C88 File Offset: 0x00A93E88
		internal static bool ConIsCnvSysDataProSelValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)114556928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_110;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
				for (;;)
				{
					IL_29:
					global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					switch (num2)
					{
					case 0:
						num = (short)766312475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						try
						{
							num = (short)1934753794;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_699;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5ED;
									}
									continue;
								case 3:
									num = (short)119406593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)576389123;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator.Current;
									(scanList[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralDesignatedDataMember_A7829.CalculateApplicability();
									(scanList[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralDesignatedDataMember_A7829.CalculateValidity();
									num = (short)1369374720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_644:
								num = (short)1498742788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5ED:
								goto IL_644;
							}
							IL_699:
							goto IL_BCC;
						}
						finally
						{
							num = (short)1715863552;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_6D0;
									}
									continue;
								case 1:
									goto IL_706;
								case 2:
									enumerator.Dispose();
									num = (short)740163585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6D0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)436273154;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_706:;
						}
						goto IL_709;
						IL_BCC:
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						cnvSysGeneralDataProfileSelection_A = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266;
						num = (short)1714749481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)1932591109;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1993277444;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)829816838;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_450;
								case 2:
									goto IL_432;
								case 3:
									result = false;
									num = (short)762314754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_414;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_338;
									}
									continue;
								case 6:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10506] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection).DataProfilesDACOperationalMode_A36199.Value != 0)
									{
										num = (short)520589151;
										short num3 = num;
										num = (short)378244959;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_414;
										default:
											num = (short)360054784;
											if (num != 0)
											{
											}
											num = (short)1443889155;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								IL_3D9:
								num = (short)406061056;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_338:
								goto IL_3D9;
								IL_414:
								num = (short)1823670273;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_432:
							return result;
							IL_450:
							return true;
						}
						finally
						{
							num = (short)773980160;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_487;
									}
									continue;
								case 1:
									goto IL_4BC;
								case 2:
									enumerator.Dispose();
									num = (short)962723841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_487:
								if (enumerator == null)
								{
									break;
								}
								num = (short)130482178;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4BC:;
						}
						goto IL_4BF;
					case 3:
						goto IL_4BF;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)1981153298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55F;
					}
					case 5:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 1)
						{
							num = (short)1753677830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 6:
						num = (short)510787620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!dataProfiles.General.DataProfGeneralLimitedBroadcast_A8431.Value)
						{
							num = (short)866713612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 8:
						num = (short)951255066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1364656177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)2110980127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (dataProfiles.EnhancedData.DatProFeaturesPortListSelection_A42011.ReferencedNode == null)
						{
							num = (short)1327759407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 12:
						num = (short)1140064270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
						{
							num = (short)537722888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55F;
					}
					case 14:
						if (!dataProfiles.General.DataConfigDataProfIPHeaderCompressionEnable_A36190.Value)
						{
							num = (short)68878376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 15:
						num = (short)1321402385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 1)
						{
							num = (short)1646985262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)608108578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (index >= 0)
						{
							num = (short)1508769822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 18:
						num = (short)1708654605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2 = radioWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset daclistInnerRecset = dataProfiles[10504].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset;
						num = (short)197197829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)850067488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)48824321;
						if (num != 0)
						{
						}
						num = (short)1642332167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (dataProfiles.NetworkLayerSecurity.DataProfNLSSecClrStrp_A36415.Value == 1)
						{
							num = (short)1301348395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 23:
						num = (short)239140886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (index != 0)
						{
							num = (short)500957212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 25:
						num = (short)673120301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (!radioWide.DualRadio.RadWideDualRadioSecRadioTransmissionCapability_A42238.Value)
						{
							num = (short)1817968692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55F;
					}
					case 27:
						if (dataProfiles.Features.DatProFeaturesPADMode_A20536.Value == 0)
						{
							num = (short)1825177625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 28:
						num = (short)194576422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_27C;
					case 30:
						num = (short)1173553206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 0)
						{
							num = (short)191234098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 32:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
						{
							num = (short)1819869193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A99;
					}
					case 33:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = radioWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)526450692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						if (radioWideRecset != null)
						{
							num = (short)1275527201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55F;
					case 35:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 2)
						{
							num = (short)828244023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A99;
					case 36:
						if (dataProfiles.General.TrkSysLabtoolRxVoiceInterruptsData_A9043.Value)
						{
							num = (short)1317339157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2;
						if (radioWide2.Labtool.AllowPSUSecure_43809.Value)
						{
							num = (short)1235550247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					}
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value != 3)
						{
							num = (short)1043660851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 39:
						goto IL_794;
					case 40:
						num = (short)1764491312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (cnvSysGeneralDataProfileSelection_A.RefRecset != null)
						{
							num = (short)369098767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 42:
						if (dataProfiles != null)
						{
							num = (short)1358299156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 43:
						num = (short)280297509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 2)
						{
							num = (short)1609236499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					}
					case 45:
						if (dataProfiles.NetworkLayerSecurity.DataProfNLSSecClrStrp_A36415.Value != 0)
						{
							num = (short)1626734615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_794;
					case 46:
						goto IL_981;
					case 47:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset daclistInnerRecset;
						enumerator = daclistInnerRecset.GetEnumerator();
						num = (short)2139881474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						if (!dataProfiles.Features.DataProfFeaturesTerminalData_A9288.Value)
						{
							num = (short)1751318528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_534;
					case 49:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (!conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value)
						{
							num = (short)829816842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A99;
					}
					case 50:
						num = (short)2036531253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						num = (short)333316112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						return false;
					case 53:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 3)
						{
							num = (short)1474363395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 54:
						if (index > cnvSysGeneralDataProfileSelection_A.RefRecset.Count)
						{
							num = (short)2139881501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_709;
					case 55:
						goto IL_507;
					}
					goto IL_110;
					IL_4BF:
					num = (short)1244790819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55F:
					dataProfiles = (cnvSysGeneralDataProfileSelection_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
					num = (short)1403715626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_709:
					num = (short)1037500440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_794:
					num = (short)1230307339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A99:
					num = (short)1975648300;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_27C:
				return false;
				IL_507:
				return true;
				IL_534:
				num = (short)1003814912;
				short num4 = num;
				return false;
				IL_981:
				return true;
				IL_110:
				global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset;
				radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
				enumerator = collection.GetEnumerator();
				num = (short)1459814401;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x00A969D8 File Offset: 0x00A94BD8
		public static bool ConValidateDataProfileSelectionWhenSignalingRevertChannelInvalid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)889454592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3;
					switch (num2)
					{
					case 0:
						num = (short)556531718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_47C;
					case 2:
						return false;
					case 3:
						if (conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value)
						{
							num = (short)1571618818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B2;
					case 4:
						enumerator = trunkingPersonalityRecset.GetEnumerator();
						num = (short)1703739399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_644;
					case 6:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
						{
							num = (short)1931280389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B2;
					case 7:
						try
						{
							num = (short)379256848;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2 = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)1464860677;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_409;
								case 3:
									goto IL_35A;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.CallConstraints();
									num = (short)1048051712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_35A;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2071986184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									num = (short)1596063759;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality != null)
									{
										num = (short)1072562190;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)2020278274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value == 1)
									{
										num = (short)1580466177;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1369571346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)256835591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)1436286988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner != null)
									{
										num = (short)1577582602;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2 = conventionalPersonality.Signaling.CnvPerSignalingSystemNumber_A9243.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)1174405123;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2 = null;
									num = (short)284098569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality != null)
									{
										num = (short)2010710027;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 16:
									switch (0)
									{
									case 0:
										goto IL_152;
									}
									continue;
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
									if (conventionalSystem2 == conventionalSystem3)
									{
										num = (short)1277820932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.Value == 4)
									{
										num = (short)904396813;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_35A;
								}
								}
								IL_272:
								num = (short)2001338374;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_152:
								goto IL_272;
								IL_35A:
								num = (short)210305041;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_409:
							goto IL_A4;
						}
						finally
						{
							num = (short)728432640;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_442;
									}
									continue;
								case 1:
									goto IL_479;
								case 2:
									enumerator.Dispose();
									num = (short)1032585217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_442:
								if (enumerator == null)
								{
									break;
								}
								num = (short)13500418;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_479:;
						}
						goto Block_4;
					case 8:
						if (index != 0)
						{
							num = (short)1264386048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B2;
					case 9:
						feature.CalculateValidity();
						num = (short)802160651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (feature != null)
						{
							num = (short)2045313033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_68D;
					case 11:
						goto IL_68D;
					case 12:
						if (trunkingPersonalityRecset != null)
						{
							num = (short)680787972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A4;
					}
					goto IL_62;
					IL_A4:
					num = (short)1311637512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_644:
					num = (short)1023279107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_47C:
						num = (short)1313275906;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_563;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_4B7;
								}
								continue;
							case 3:
								num = (short)294977537;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1601961987;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2 = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
								(conventionalPersonality2[10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingRevertChannel_A13267.CalculateApplicability();
								(conventionalPersonality2[10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingRevertChannel_A13267.CalculateValidity();
								num = (short)1032847360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_50F:
							num = (short)207880196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4B7:
							goto IL_50F;
						}
						IL_563:
						goto IL_6CE;
					}
					finally
					{
						num = (short)2142306304;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1826786466;
								short num3 = num;
								num = (short)1391103138;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_622;
								default:
									num = (short)573243393;
									if (num != 0)
									{
									}
									num = (short)2099642368;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_609;
									}
									continue;
								}
								break;
							}
							case 1:
								goto IL_641;
							case 2:
								goto IL_622;
							}
							IL_609:
							if (enumerator != null)
							{
								num = (short)2058551298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
							IL_622:
							enumerator.Dispose();
							num = (short)822149121;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_641:;
					}
					goto IL_644;
					IL_6CE:
					conventionalSystem3 = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
					trunkingPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
					num = (short)1207894028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_68D:
					conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
					num = (short)858652673;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_7B2:
				num = (short)1371209728;
				short num4 = num;
				return true;
				IL_62:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2075);
				num = (short)1082327050;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x00A971F8 File Offset: 0x00A953F8
		internal static bool conCnvSysIsMDCorASTRO(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262;
			if (cnvSysGeneralSystemType_A.Value != 1)
			{
				short num = (short)1808924673;
				if (num != 0)
				{
				}
				num = (short)1453877526;
				short num2 = num;
				num = (short)1311074582;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)285409280;
					short num3 = num;
					num = (short)185008128;
					if (num != 0)
					{
					}
					return cnvSysGeneralSystemType_A.Value == 0;
				}
				}
			}
			return true;
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x00A972D0 File Offset: 0x00A954D0
		internal static bool conCnvTxtMsgValueValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1667851348;
			short num2 = num;
			num = (short)1345938516;
			switch (num2 == num)
			{
			}
			num = (short)1687093249;
			if (num != 0)
			{
			}
			num = (short)1205010432;
			if (num != 0)
			{
			}
			num = (short)891879424;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features tmpFeatures = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features;
			return global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ValidateTMSField(self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem, tmpFeatures, index);
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x00A97398 File Offset: 0x00A95598
		public static bool ValidateTMSField(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem tmpConventionalSystem, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features tmpFeatures, int index)
		{
			short num = (short)1143406592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_80;
				}
				global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
				bool result;
				global::AcpBusinessLayer.AcpListField radWideLabtoolKeypadType_A;
				int radWideFeaturesSmartMessagingSmartMessageModeValue;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (cnvSysGeneralDataProfileSelection_A.Value != 0)
						{
							num = (short)161939463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						if (radWideLabtoolKeypadType_A.Value != 3)
						{
							num = (short)1332936717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 2:
						goto IL_29A;
					case 3:
						if (radWideLabtoolKeypadType_A.Value == 2)
						{
							num = (short)53542931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						if (radWideLabtoolKeypadType_A.Value != 4)
						{
							num = (short)578093067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 5:
						if (cnvSysGeneralDataProfileSelection_A.Value != 0)
						{
							num = (short)663355404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
					{
						num = (short)1241716476;
						short num3 = num;
						num = (short)957880060;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32A;
						default:
							goto IL_2EF;
						}
						break;
					}
					case 7:
						result = true;
						num = (short)1495072774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)1523384320;
						short num4 = num;
						switch (index)
						{
						case 0:
							result = true;
							num = (short)464191497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)2048393230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)1814822930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)154075151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_1E0;
					case 10:
						num = (short)480509952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)911605761;
						if (num != 0)
						{
						}
						num = (short)1214644225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1186660356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1028325379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (radWideFeaturesSmartMessagingSmartMessageModeValue != 1)
						{
							goto IL_32A;
						}
						return result;
					case 15:
						num = (short)1082064913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)2041249797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_23C;
					case 18:
						if (radWideFeaturesSmartMessagingSmartMessageModeValue != 1)
						{
							num = (short)845152272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 19:
						goto IL_280;
					}
					goto IL_80;
					IL_280:
					result = true;
					num = (short)1734017026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32A:
					num = (short)1938685962;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E0:
				IL_23C:
				IL_29A:
				return result;
				IL_2EF:
				num = (short)1264254976;
				if (num != 0)
				{
				}
				return result;
				IL_80:
				cnvSysGeneralDataProfileSelection_A = tmpConventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266;
				radWideLabtoolKeypadType_A = tmpFeatures.RefRadioWide.Labtool.RadWideLabtoolKeypadType_A8372;
				radWideFeaturesSmartMessagingSmartMessageModeValue = tmpFeatures.RefRadioWide.Features.RadWideFeaturesSmartMessagingSmartMessageModeValue;
				result = false;
				num = (short)224591880;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x00A97768 File Offset: 0x00A95968
		internal static bool ConSystemTypeIsDVRS(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)270426725;
			short num2 = num;
			num = (short)100295269;
			switch (num2 == num)
			{
			}
			num = (short)826671105;
			if (num != 0)
			{
			}
			num = (short)2032271360;
			if (num != 0)
			{
			}
			num = (short)145293312;
			short num3 = num;
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value == 2;
		}

		// Token: 0x0600B709 RID: 46857 RVA: 0x00A97830 File Offset: 0x00A95A30
		internal static bool ConSystemTypeIsAstroOrMdcOrDVRS(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_B5;
				case 1:
				{
					num2 = (short)2120664726;
					short num3 = num2;
					num2 = (short)1952827030;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B5;
					default:
						goto IL_10E;
					}
					break;
				}
				case 2:
					num2 = (short)851771393;
					if (num2 != 0)
					{
					}
					if (cnvSysGeneralSystemType_A.Value != 0)
					{
						num2 = (short)1945239555;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					num2 = (short)238551040;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_B5:
				if (cnvSysGeneralSystemType_A.Value == 1)
				{
					return true;
				}
				num2 = (short)697892865;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10E:
			num2 = (short)1392115712;
			if (num2 != 0)
			{
			}
			num2 = (short)1086324736;
			short num4 = num2;
			return cnvSysGeneralSystemType_A.Value == 2;
			IL_20:
			cnvSysGeneralSystemType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262;
			num2 = (short)1267924994;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B70A RID: 46858 RVA: 0x00A97990 File Offset: 0x00A95B90
		internal static bool ConSystemTypeIsAstroOrDVRS(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262;
			if (cnvSysGeneralSystemType_A.Value != 0)
			{
				short num = (short)334993968;
				short num2 = num;
				num = (short)704551472;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)445513729;
					if (num != 0)
					{
					}
					num = (short)996016128;
					short num3 = num;
					num = (short)766771200;
					if (num != 0)
					{
					}
					return cnvSysGeneralSystemType_A.Value == 2;
				}
				}
			}
			return true;
		}

		// Token: 0x0600B70B RID: 46859 RVA: 0x00A97A68 File Offset: 0x00A95C68
		internal static bool ConSystemTypeIsAstroOrMdcOrDTMFOrQCIIOrDVRS(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_82;
				case 1:
				{
					num2 = (short)1555976950;
					short num3 = num2;
					num2 = (short)1216828150;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_82;
					default:
						goto IL_DA;
					}
					break;
				}
				case 2:
					if (cnvSysGeneralSystemType_A.Value != 0)
					{
						num2 = (short)2071855107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					num2 = (short)2555904;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_82:
				if (cnvSysGeneralSystemType_A.Value == 1)
				{
					return true;
				}
				num2 = (short)1467088897;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DA:
			num2 = (short)95092737;
			if (num2 != 0)
			{
			}
			num2 = (short)1402535936;
			if (num2 != 0)
			{
			}
			num2 = (short)1143078912;
			short num4 = num2;
			return cnvSysGeneralSystemType_A.Value == 2;
			IL_20:
			cnvSysGeneralSystemType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General).CnvSysGeneralSystemType_A13262;
			num2 = (short)767688706;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B70C RID: 46860 RVA: 0x00A97BBC File Offset: 0x00A95DBC
		internal static bool ConDVRSDynRegrIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1928265729;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS dvrs = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS;
			if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value == 2)
			{
				num = (short)906608237;
				short num2 = num;
				num = (short)96845421;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1027473408;
					short num3 = num;
					num = (short)710606848;
					if (num != 0)
					{
					}
					return dvrs.CnvSysFeatureDynRegroupEn_A40146.Value;
				}
				}
			}
			return false;
		}

		// Token: 0x0600B70D RID: 46861 RVA: 0x00A97C9C File Offset: 0x00A95E9C
		public static bool ConDVRSDynRegroupZoneIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS dvrs;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)1825832965;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.Value != 0)
					{
						num2 = (short)913506306;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10D;
				}
				case 2:
					goto IL_20F;
				case 3:
					num2 = (short)1557069824;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1294991366;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)873791496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (index <= dvrs.CnvSysFeatureDynRegroupZone_A40145.RefRecset.Count)
					{
						num2 = (short)811270154;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10D;
				case 7:
					if (dvrs.ChannelAssignmentListInnerSectionForCnvSysFeatureDynRegroupChannel_A40144 != null)
					{
						num2 = (short)575209484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D5;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.RSI != null)
					{
						num2 = (short)1691353103;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10D;
				}
				case 9:
					if (!dvrs.CnvSysFeatureDynRegroupEn_A40146.Value)
					{
						num2 = (short)114456023;
						short num3 = num2;
						num2 = (short)1570338263;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_334;
						}
					}
					num2 = (short)6619152;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = dvrs.CnvSysFeatureDynRegroupZone_A40145.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
					num2 = (short)1757544459;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 11:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment != null)
					{
						num2 = (short)2021326851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10D;
				}
				case 12:
				{
					num2 = (short)1895497728;
					short num4 = num2;
					dvrs.ChannelAssignmentListInnerSectionForCnvSysFeatureDynRegroupChannel_A40144.CalculateValidity();
					num2 = (short)152633358;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					if (index > 0)
					{
						num2 = (short)144310276;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10D;
				case 14:
					goto IL_D5;
				case 15:
					num2 = (short)27852801;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_175;
				}
				goto IL_54;
				IL_D5:
				num2 = (short)1672806413;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10D:
				num2 = (short)113836033;
				if (num2 != 0)
				{
				}
				num2 = (short)1044774921;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_175:
			return index != 0;
			IL_20F:
			return false;
			IL_334:
			num2 = (short)567410688;
			if (num2 != 0)
			{
			}
			return true;
			IL_54:
			dvrs = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS);
			num2 = (short)199884807;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B70E RID: 46862 RVA: 0x00A97FF4 File Offset: 0x00A961F4
		public static bool ConDynTlkGrpAndMultiKeyAndHWOrADP(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure secure;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (conventionalSystem.DVRS.CnvSysFeatureDynRegroupEn_A40146.Value)
					{
						num2 = (short)2121138179;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_F4;
				case 2:
					if (conventionalSystem.DVRS != null)
					{
						num2 = (short)864157700;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
				{
					num2 = (short)1364726672;
					short num3 = num2;
					num2 = (short)1297486736;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C3;
					default:
					{
						num2 = (short)1431240704;
						short num4 = num2;
						num2 = (short)293470208;
						if (num2 != 0)
						{
						}
						num2 = (short)46858245;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 4:
					num2 = (short)1214840833;
					if (num2 != 0)
					{
					}
					num2 = (short)2077622272;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_C3;
				}
				goto IL_28;
				IL_C3:
				if (secure.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 0)
				{
					return false;
				}
				num2 = (short)1855193089;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F4:
			return conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 2;
			IL_28:
			secure = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure);
			conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
			num2 = (short)1665204226;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x00A981B8 File Offset: 0x00A963B8
		public static bool ConDVRSDynRegroupChannelIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)616103936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_DF;
				}
				global::AcpBusinessLayer.AcpRecRefField cnvSysFeatureDynRegroupChannel_A;
				global::AcpBusinessLayer.FeatureNode featureNode;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS dvrs;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner3;
					switch (num2)
					{
					case 0:
					{
						if (index > cnvSysFeatureDynRegroupChannel_A.RefRecset.Count)
						{
							num = (short)1464139776;
							short num3 = num;
							num = (short)864944160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)1020919813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return false;
					case 2:
						num = (short)483000351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value == 65535)
						{
							num = (short)1399128102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
						num = (short)136052756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (index <= 0)
						{
							num = (short)932249633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1611792394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (channelAssignmentListInner != null)
						{
							num = (short)1828978690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						goto IL_4E6;
					case 8:
						if (cnvSysFeatureDynRegroupChannel_A.RefRecset == null)
						{
							num = (short)1100152833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1466040354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						acpFeatureNode = cnvSysFeatureDynRegroupChannel_A.RefRecset[index - 1];
						goto IL_783;
					case 10:
						channelAssignmentListInner2 = (cnvSysFeatureDynRegroupChannel_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
						goto IL_424;
					case 11:
						channelAssignmentListInner2 = null;
						goto IL_424;
					case 12:
						num = (short)1922039831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (index <= 0)
						{
							num = (short)1594359835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1472266249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
						{
							num = (short)1729101850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						num = (short)208404494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						acpFeatureNode = cnvSysFeatureDynRegroupChannel_A.RefRecset[0];
						goto IL_783;
					case 17:
						if (conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value)
						{
							num = (short)355401732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 18:
						return false;
					case 19:
						num = (short)705822721;
						if (num != 0)
						{
						}
						num = (short)1338441750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner != null)
						{
							num = (short)1798832168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 21:
						if (conventionalPersonality != null)
						{
							num = (short)30736391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
						if (index != 0)
						{
							num = (short)1363935262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (radioInformation != null)
						{
							num = (short)692584484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_578;
					}
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178Value == 13)
						{
							num = (short)1503789081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_578;
					}
					case 25:
						num = (short)1570635819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)1564147729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)127533072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)244842496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (featureNode == conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)
						{
							num = (short)279642127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 30:
						goto IL_184;
					case 31:
						if (dvrs.CnvSysFeatureDynRegroupZone_A40145.ParentNode != null)
						{
							num = (short)1367867431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 32:
						goto IL_681;
					case 33:
						num = (short)1047986187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (index >= 0)
						{
							num = (short)1422196764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 35:
						num = (short)183566357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						num = (short)175757819;
						short num4 = num;
						num = (short)1984223739;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4E6;
						default:
							num = (short)354549760;
							if (num != 0)
							{
							}
							num = (short)404029464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 37:
						if (dvrs.CnvSysFeatureDynRegroupEn_A40146.Value)
						{
							num = (short)965410835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					case 38:
						return true;
					case 39:
						num = (short)926941226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)1843068931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (channelAssignmentListInner3 != null)
						{
							num = (short)890961932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_578;
					case 42:
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
						{
							num = (short)1422655523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 43:
						if (channelAssignmentListInner3.Position > 48)
						{
							num = (short)845611026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_578;
					}
					goto IL_DF;
					IL_184:
					num = (short)375652365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_424:
					channelAssignmentListInner3 = channelAssignmentListInner2;
					num = (short)736428073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E6:
					num = (short)2081751069;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_578:
					num = (short)1037959205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_783:
					channelAssignmentListInner = (acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
					conventionalPersonality = (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality);
					num = (short)741212166;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_681:
				return false;
				IL_DF:
				dvrs = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS);
				featureNode = (self.Parent as global::AcpBusinessLayer.FeatureNode);
				cnvSysFeatureDynRegroupChannel_A = dvrs.CnvSysFeatureDynRegroupChannel_A40144;
				num = (short)1193345032;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x00A989A4 File Offset: 0x00A96BA4
		public static bool ConCnvDVRSKeyValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)126156800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				global::AcpBusinessLayer.AcpField<bool> secWideGeneralOTAREnable_A;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure secure;
				for (;;)
				{
					IL_27:
					global::AcpBusinessLayer.AcpRecRefField cnvSysSecureKMFProfIndex_A;
					global::AcpBusinessLayer.Recordset recordset;
					switch (num2)
					{
					case 0:
						return true;
					case 1:
						goto IL_1E4;
					case 2:
						if (secWideGeneralOTAREnable_A.Value)
						{
							num = (short)1606811655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
					{
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_;
						if (secKmfProfGenIndependentKeyList_.Applicable)
						{
							num = (short)1921908736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					}
					case 4:
					{
						global::AcpBusinessLayer.AcpField<bool> secWideASTROOTARASTROOTAREnable_A = secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496;
						cnvSysSecureKMFProfIndex_A = secure.CnvSysSecureKMFProfIndex_A40132;
						bool flag = secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1 || (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3 && (secureWide.General.SecureWideAESAlgorithmEnable_43201.Value || secureWide.General.SecureWideDESAlgorithmEnable_43744.Value));
						if (secWideASTROOTARASTROOTAREnable_A.Value)
						{
							num = (short)1246887936;
							short num3 = num;
							num = (short)1570832396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
						goto IL_4E7;
					case 6:
					{
						bool flag;
						if (flag)
						{
							num = (short)806092809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 7:
						num = (short)1852768262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_;
						if (secKmfProfGenIndependentKeyList_.Value)
						{
							num = (short)622657541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					}
					case 9:
						num = (short)1966080019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1257635862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (cnvSysSecureKMFProfIndex_A.ReferencedNode == null)
						{
							num = (short)1832452116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)420085775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)788267009;
						if (num != 0)
						{
						}
						num = (short)2136145922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)1654521883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					}
					case 14:
						return false;
					case 15:
						if (cnvSysSecureKMFProfIndex_A.RefRecset != null)
						{
							num = (short)633339914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					case 16:
					{
						if (recordset == null)
						{
							num = (short)1512112142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = recordset.GetEnumerator();
						num = (short)1928331287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)1357840410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.General != null)
						{
							num = (short)1379598357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					}
					case 19:
						if (cnvSysSecureKMFProfIndex_A.Value == 0)
						{
							num = (short)2035154945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_329;
					case 20:
						return false;
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_ = secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597;
						num = (short)816840712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						num = (short)151538419;
						short num4 = num;
						num = (short)1671056115;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_329;
						default:
							num = (short)735903744;
							if (num != 0)
							{
							}
							if (cnvSysSecureKMFProfIndex_A.ReferencedNode != null)
							{
								num = (short)1047986193;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_278;
						}
						break;
					}
					case 23:
						try
						{
							num = (short)705298434;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)165085190;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1783037955;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_3C8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3AE;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10127] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection).SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Value == index)
									{
										num = (short)1049231364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									result = true;
									num = (short)1665531905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_475;
								case 6:
									num = (short)265551877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_420:
								num = (short)1197211648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AE:
								goto IL_420;
							}
							IL_3C8:
							return result;
							IL_475:
							goto IL_52A;
						}
						finally
						{
							num = (short)1443889152;
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
										goto IL_4AC;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)139919362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4E4;
								}
								IL_4AC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1482752001;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4E4:;
						}
						goto IL_4E7;
						IL_52A:
						num = (short)603062297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = cnvSysSecureKMFProfIndex_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)655753229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						return false;
					case 26:
						if (cnvSysSecureKMFProfIndex_A.Value > 0)
						{
							num = (short)1717239832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					case 27:
						num = (short)2087976978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
					IL_278:
					recordset = (cnvSysSecureKMFProfIndex_A.ReferencedNode[10126].EmbeddedRecset as global::AcpBusinessLayer.Recordset);
					num = (short)525598736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_329:
					num = (short)997326859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E7:
					num = (short)1145241603;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E4:
				return true;
				IL_9E:
				secure = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure);
				global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
				secureWide = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				secWideGeneralOTAREnable_A = secureWide.General.SecWideGeneralOTAREnable_A7966;
				num = (short)1953234948;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600B711 RID: 46865 RVA: 0x00A990F8 File Offset: 0x00A972F8
		internal static bool ConDVRSPop25App(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
				switch (num)
				{
				case 0:
					if (dataProfiles.Features.DataProfFeaturesAtakField)
					{
						num2 = (short)1519779849;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D7;
				case 1:
					if (dataProfiles != null)
					{
						num2 = (short)455147525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D7;
				case 2:
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1)
					{
						num2 = (short)1039532035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					goto IL_D2;
				case 4:
					goto IL_104;
				case 5:
				{
					num2 = (short)192869064;
					short num3 = num2;
					num2 = (short)178909896;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_104;
					default:
					{
						num2 = (short)163971072;
						if (num2 != 0)
						{
						}
						num2 = (short)1766850560;
						short num4 = num2;
						num2 = (short)797507584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 6:
					num2 = (short)1655635969;
					if (num2 != 0)
					{
					}
					num2 = (short)241106946;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)149094408;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266Value != 0)
					{
						num2 = (short)2089877510;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					return false;
				}
				goto IL_38;
				IL_D7:
				secureWide = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				num2 = (short)753860612;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_104:
				if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value != 0)
				{
					return false;
				}
				num2 = (short)151453703;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D2:
			return !conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value;
			IL_38:
			conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
			dataProfiles = (conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
			num2 = (short)1676410881;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B712 RID: 46866 RVA: 0x00A99378 File Offset: 0x00A97578
		internal static bool ConSystemTypeIsDVRSWithSecure(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1038155776;
			short num2 = num;
			num = (short)570318814;
			short num3 = num;
			num = (short)812212190;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure secure;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1259798528;
				if (num != 0)
				{
				}
				secure = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure);
				if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value != 2)
				{
					return false;
				}
				break;
			}
			num = (short)1353318401;
			if (num != 0)
			{
			}
			return secure.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value != 0;
		}

		// Token: 0x0600B713 RID: 46867 RVA: 0x00A99460 File Offset: 0x00A97660
		public static bool ConDVRSDynChlRegrIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)60096512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 2)
						{
							num = (short)1513029638;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						num = (short)1762525187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (zoneChannelAssignment != null)
						{
							num = (short)1350369281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E6;
					case 3:
						if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)1821507584;
							short num3 = num;
							num = (short)148111364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E6;
					case 4:
						goto IL_3A9;
					case 5:
						IL_50A:
						try
						{
							num = (short)1995767810;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
								switch (num2)
								{
								case 0:
									num = (short)742916101;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (conventionalPersonality != null)
									{
										num = (short)366936067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E9;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonality.ReferencingNodes.GetEnumerator();
									num = (short)453312518;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (!enumerator2.MoveNext())
									{
										num = (short)717357056;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_276;
								case 5:
									goto IL_339;
								case 6:
									try
									{
										num = (short)901316610;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)2032205830;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
												num = (short)1236992001;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												if (channelAssignmentListInner != null)
												{
													num = (short)531103747;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_130;
												}
												continue;
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.CalculateApplicability();
												channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.CalculateValidity();
												num = (short)899940356;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												goto IL_204;
											case 6:
												num = (short)542310405;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_1AD:
											num = (short)2046230528;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_130:
											goto IL_1AD;
										}
										IL_204:
										break;
									}
									finally
									{
										num = (short)1963065344;
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
													goto IL_23B;
												}
												continue;
											case 1:
												enumerator.Dispose();
												num = (short)780926978;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_273;
											}
											IL_23B:
											if (enumerator == null)
											{
												break;
											}
											num = (short)841220097;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_273:;
									}
									goto IL_276;
								}
								goto IL_E9;
								IL_276:
								conventionalPersonality = (enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality);
								num = (short)1223557121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B9:
								num = (short)612958212;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E9:
								goto IL_2B9;
							}
							IL_339:
							goto IL_478;
						}
						finally
						{
							num = (short)1087963136;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_371;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)1444413442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3A6;
								}
								IL_371:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1567621121;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A6:;
						}
						goto IL_3A9;
						IL_478:
						num = (short)2022375425;
						if (num != 0)
						{
						}
						num = (short)727056384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_4E1;
					}
					goto IL_4B;
					IL_3A9:
					num = (short)1364350031;
					short num4 = num;
					num = (short)236934223;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_50A;
					default:
						goto IL_3DE;
					}
					IL_4E6:
					enumerator2 = conventionalSystem.ReferencingNodes.GetEnumerator();
					num = (short)818413573;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3DE:
				num = (short)1846345728;
				if (num != 0)
				{
				}
				return false;
				IL_4E1:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS dvrs;
				return dvrs.CnvSysFeatureDynRegroupEn_A40146.Value;
				IL_4B:
				dvrs = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.DVRS);
				conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				zoneChannelAssignment = (dvrs.CnvSysFeatureDynRegroupZone_A40145.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				num = (short)177668098;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600B714 RID: 46868 RVA: 0x00A999B4 File Offset: 0x00A97BB4
		public static bool conNonEditableWhenOpenFromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)525074432;
			short num2 = num;
			num = (short)1345457873;
			short num3 = num;
			num = (short)601296593;
			switch (num3 == num)
			{
			}
			num = (short)1071185921;
			if (num != 0)
			{
			}
			num = (short)1137573888;
			if (num != 0)
			{
			}
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x0600B715 RID: 46869 RVA: 0x00A99A64 File Offset: 0x00A97C64
		internal static bool conExtendedDispatchNotEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1744568320;
			short num2 = num;
			num = (short)417136641;
			if (num != 0)
			{
			}
			num = (short)333112887;
			short num3 = num;
			num = (short)334947895;
			switch (num3 == num)
			{
			}
			num = (short)809369600;
			if (num != 0)
			{
			}
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features).CnvSysFeaturesExtendedDispatchEn_A37220.Value;
		}

		// Token: 0x0600B716 RID: 46870 RVA: 0x00A99B20 File Offset: 0x00A97D20
		internal static void conSetEmergencyACKPerExtendedDispatch(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			short num;
			global::AcpBusinessLayer.AcpField<bool> cnvSysFeaturesExtendedDispatchEn_A;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features;
			for (;;)
			{
				IL_0A:
				num = (short)884342785;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
					if (cnvSysFeaturesExtendedDispatchEn_A.Value)
					{
						num = (short)820641793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)507248640;
					short num3 = num;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(features.CnvSysFeaturesEmergencyAckEn_A41546, cnvSysFeaturesExtendedDispatchEn_A.Value));
					num = (short)1664483330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				}
				goto IL_44;
			}
			return;
			IL_44:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features);
			cnvSysFeaturesExtendedDispatchEn_A = features.CnvSysFeaturesExtendedDispatchEn_A37220;
			num = (short)308814012;
			short num4 = num;
			num = (short)34611388;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num = (short)1975975936;
				if (num != 0)
				{
				}
				num = (short)827850752;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600B717 RID: 46871 RVA: 0x00A99C5C File Offset: 0x00A97E5C
		public static bool ConAddtionalMDCIDChecked(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 15;
			short num = (short)2134376449;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				int value;
				switch (num2)
				{
				case 0:
					goto IL_171;
				case 1:
				{
					num = (short)481099776;
					short num3 = num;
					num = (short)885826795;
					short num4 = num;
					num = (short)1939645675;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_171;
					default:
						num = (short)123142145;
						if (num != 0)
						{
						}
						num = (short)1781858304;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_E3;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_16F;
				case 3:
					if (text.Contains(global::AllFeatures.CodeplugGuid.b("雏", a_)))
					{
						num = (short)1095827458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)851836931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (value <= 57070)
					{
						num = (short)2013134852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_E3:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General;
				value = general.CnvSysGeneralMDCPrimaryID_A8744.Value;
				text = general.CnvSysGeneralMDCPrimaryID_A8744.UIValue.ToUpper();
				if (!general.CnvSysGeneralAdditionalMDCPID_A41761.Value)
				{
					num = (short)417726464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_171:
				num = (short)1947860997;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_16F:
			return false;
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x00A99E18 File Offset: 0x00A98018
		internal static bool ConAddtionalMDCIDIsUnchecked(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)830668800;
			short num2 = num;
			num = (short)970671509;
			short num3 = num;
			num = (short)1651983765;
			switch (num3 == num)
			{
			}
			num = (short)901054465;
			if (num != 0)
			{
			}
			num = (short)1601175552;
			if (num != 0)
			{
			}
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General).CnvSysGeneralAdditionalMDCPID_A41761.Value;
		}

		// Token: 0x0600B719 RID: 46873 RVA: 0x00A99ED4 File Offset: 0x00A980D4
		public static bool ConTriggerRSIModeValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1034551296;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					goto IL_1FF;
				case 2:
					try
					{
						num = (short)167772160;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_267;
								}
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2017918978;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current;
								zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.CalculateValidity();
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (zoneChannelAssignment[10114].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset).GetEnumerator();
								num = (short)1677131780;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_410;
							case 3:
								goto IL_428;
							case 4:
								try
								{
									num = (short)1509163008;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_325;
											}
											continue;
										case 2:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)1790443524;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)enumerator2.Current).ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.CalculateValidity();
											num = (short)2008678401;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											goto IL_3A3;
										case 4:
											num = (short)196083715;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_357:
										num = (short)556990466;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_325:
										goto IL_357;
									}
									IL_3A3:
									break;
								}
								finally
								{
									num = (short)1531183104;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_3D8;
											}
											continue;
										case 1:
											enumerator2.Dispose();
											num = (short)1822621698;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_40D;
										}
										IL_3D8:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)336658433;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_40D:;
								}
								goto IL_410;
							}
							IL_269:
							num = (short)1590951937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_267:
							goto IL_269;
							IL_410:
							num = (short)1794572291;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_428:;
					}
					finally
					{
						num = (short)286851072;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_45D;
								}
								continue;
							case 1:
							{
								enumerator.Dispose();
								num = (short)123014511;
								short num3 = num;
								num = (short)548932975;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)830537728;
									if (num != 0)
									{
									}
									num = (short)1648099330;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_4E5;
							}
							IL_45D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1695023105;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4E5:;
					}
					num = (short)310116353;
					if (num != 0)
					{
					}
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
					num = (short)1847787523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					try
					{
						num = (short)1411579906;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
								if (self.Parent == conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode)
								{
									num = (short)592510982;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)837615619;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
								num = (short)640745472;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_C1;
								}
								continue;
							case 3:
								num = (short)1000865797;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_192;
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
								conventionalPersonality.TxOptions.CnvPerTxOptionsAdaptivePower_A7405.CalculateValidity();
								num = (short)1005060100;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_C3:
							num = (short)296550401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C1:
							goto IL_C3;
						}
						IL_192:
						return true;
					}
					finally
					{
						num = (short)1407647744;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1C7;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1754333186;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1FC;
							}
							IL_1C7:
							if (enumerator == null)
							{
								break;
							}
							num = (short)327483393;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1FC:;
					}
					goto IL_1FF;
				}
				IL_34:
				num = (short)2044461056;
				short num4 = num;
				if (global::ConstraintHelper.UtilityMack.IsMobile())
				{
					num = (short)1722875905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1FF:
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset).GetEnumerator();
				num = (short)1117323266;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x0600B71A RID: 46874 RVA: 0x00A9A470 File Offset: 0x00A98670
		internal static bool ConCnvSystemTypeIsDigitalAstroAndEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General;
			short num;
			if (general.CnvSysGeneralSystemType_A13262.Value != 0)
			{
				num = (short)668596253;
				short num2 = num;
				num = (short)1150613533;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1159790592;
					if (num != 0)
					{
					}
					return !general.ConvConfigConvSystemFeatRSISys_A41838.Value;
				}
			}
			num = (short)1075511296;
			short num3 = num;
			num = (short)1554251777;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600B71B RID: 46875 RVA: 0x00A9A53C File Offset: 0x00A9873C
		internal static bool ConRSISysEnAndEmerProSelDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_86;
				case 1:
				{
					num2 = (short)590550298;
					short num3 = num2;
					num2 = (short)1146885402;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
						goto IL_135;
					}
					break;
				}
				case 2:
					if (general.CnvSysGeneralSystemType_A13262.Value == 0)
					{
						num2 = (short)1090519041;
						if (num2 != 0)
						{
						}
						num2 = (short)378929152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					if (general.ConvConfigConvSystemFeatRSISys_A41838)
					{
						num2 = (short)2040397824;
						short num4 = num2;
						num2 = (short)1329659905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_20;
				IL_86:
				num2 = (short)1931870211;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_135:
			num2 = (short)1679687680;
			if (num2 != 0)
			{
			}
			return general.CnvSysGeneralEmergencyProfileSelection_A19421.Value != 0;
			IL_20:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General);
			num2 = (short)459669506;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B71C RID: 46876 RVA: 0x00A9A69C File Offset: 0x00A9889C
		internal static bool ConRSISysEnAndDataProSelDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_60;
				case 1:
				{
					num2 = (short)1074528256;
					short num3 = num2;
					num2 = (short)97124031;
					short num4 = num2;
					num2 = (short)942341823;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
						goto IL_10C;
					}
					break;
				}
				case 2:
					if (general.CnvSysGeneralSystemType_A13262.Value == 0)
					{
						num2 = (short)1036910592;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_126;
				case 3:
					if (general.ConvConfigConvSystemFeatRSISys_A41838)
					{
						num2 = (short)106496001;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_126;
				}
				goto IL_20;
				IL_60:
				num2 = (short)1233584131;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10C:
			num2 = (short)535822336;
			if (num2 != 0)
			{
			}
			return general.CnvSysGeneralDataProfileSelection_A13266.Value != 0;
			IL_126:
			num2 = (short)953745409;
			if (num2 != 0)
			{
			}
			return true;
			IL_20:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General);
			num2 = (short)207290370;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x00A9A7F8 File Offset: 0x00A989F8
		internal static bool ConCnvSysTypeIsAstroAndRSISysEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
			{
				short num = (short)231267147;
				short num2 = num;
				num = (short)1180949323;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1807679488;
					if (num != 0)
					{
					}
					num = (short)647102465;
					if (num != 0)
					{
					}
					num = (short)982122496;
					short num3 = num;
					return !conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value;
				}
				}
			}
			return true;
		}

		// Token: 0x0600B71E RID: 46878 RVA: 0x00A9A8D8 File Offset: 0x00A98AD8
		internal static bool ConCnvFeatureMsgApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			for (;;)
			{
				IL_00:
				short num = (short)207486976;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				int num3;
				global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
				for (;;)
				{
					IL_32:
					switch (num3)
					{
					case 0:
						if (cnvSysGeneralSystemType_A.Value != 2)
						{
							num = (short)61669377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						num = (short)6619137;
						if (num != 0)
						{
						}
						num = (short)59637762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)2101692860;
						short num4 = num;
						num = (short)913852860;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1231880192;
							if (num != 0)
							{
							}
							if (cnvSysGeneralSystemType_A.Value == 0)
							{
								num = (short)1457586181;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						break;
					}
					case 3:
						if (cnvSysGeneralSystemType_A.Value != 1)
						{
							num = (short)1897267204;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						num = (short)203096064;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_13D;
					}
					break;
				}
				IL_50:
				conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				cnvSysGeneralSystemType_A = conventionalSystem.General.CnvSysGeneralSystemType_A13262;
				num = (short)720175107;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			IL_13D:
			return !conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value;
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x00A9AA90 File Offset: 0x00A98C90
		internal static bool ConEmerAlrmRxIndicTypeNotNoIndicAndNotAstroRSI(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1246167042;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
				switch (num2)
				{
				case 0:
					num = (short)986054659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_11B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
					if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
					{
						num = (short)1404436480;
						short num3 = num;
						num = (short)1493106689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_35:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features;
				conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				if (features.RefEmergencyWide.General.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Value == 0)
				{
					return false;
				}
				num = (short)1664614401;
				if (num != 0)
				{
				}
				num = (short)269549568;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_11B:
			num = (short)1601655864;
			short num4 = num;
			num = (short)2107593784;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
			{
				num = (short)1275789312;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
				return !conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value;
			}
			}
			return false;
		}

		// Token: 0x0600B720 RID: 46880 RVA: 0x00A9AC08 File Offset: 0x00A98E08
		internal static bool ConCAIDataRegApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features;
			for (;;)
			{
				IL_00:
				short num = (short)1572274176;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_51;
				}
				int num3;
				global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						if (cnvSysGeneralSystemType_A.Value == 0)
						{
							num = (short)1762983937;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						num = (short)654835714;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)53380613;
						short num4 = num;
						num = (short)720471557;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1796276224;
							if (num != 0)
							{
							}
							num = (short)173604865;
							if (num != 0)
							{
							}
							if (conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value)
							{
								num = (short)1761542149;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						break;
					}
					case 3:
						if (cnvSysGeneralSystemType_A.Value == 0)
						{
							num = (short)1358626820;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						num = (short)811859968;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_16A;
					}
					break;
				}
				IL_51:
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features);
				conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				cnvSysGeneralSystemType_A = conventionalSystem.General.CnvSysGeneralSystemType_A13262;
				num = (short)113704963;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			IL_16A:
			return features.CnvSysFeaturesCAIDataRegistration_A7585;
		}

		// Token: 0x0600B721 RID: 46881 RVA: 0x00A9ADC4 File Offset: 0x00A98FC4
		internal static bool ConDVRSIsEnAndDynamicIDValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features;
			if (features.CnvSysFeaturesDynamicIDEnable_A40100.Value)
			{
				short num = (short)1251722843;
				short num2 = num;
				num = (short)420660827;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)793903105;
					if (num != 0)
					{
					}
					num = (short)811532288;
					if (num != 0)
					{
					}
					num = (short)330891264;
					short num3 = num;
					return !features.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
				}
				}
			}
			return true;
		}

		// Token: 0x0600B722 RID: 46882 RVA: 0x00A9AEA0 File Offset: 0x00A990A0
		internal static bool ConDVRSIsEnAndDynamicIDApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features;
			for (;;)
			{
				IL_00:
				num = (short)70844416;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
				for (;;)
				{
					IL_34:
					switch (num3)
					{
					case 0:
						if (!conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value)
						{
							num = (short)1851457537;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						goto IL_B1;
					case 2:
					{
						num = (short)1638690695;
						short num4 = num;
						num = (short)61763463;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1763704832;
							if (num != 0)
							{
							}
							if (features.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
							{
								num = (short)301596677;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18E;
						}
						break;
					}
					case 3:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
						{
							num = (short)1496383492;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1;
					case 4:
						num = (short)823001088;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_142;
					}
					break;
					IL_B1:
					num = (short)228261890;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_52:
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features);
				conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				num = (short)1039663107;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
			IL_142:
			return features.CnvSysFeaturesDynamicIDEnable_A40100.Value;
			IL_18E:
			num = (short)1691746305;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600B723 RID: 46883 RVA: 0x00A9B068 File Offset: 0x00A99268
		public static void ConSetValueFalseOnRSISystem(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)673906688;
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
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
					{
						num = (short)1465581568;
						short num3 = num;
						try
						{
							num = (short)1730215943;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value == 2)
									{
										num = (short)1619329025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = frequencyOptionsInnerRecset.GetEnumerator();
									num = (short)892796930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									try
									{
										num = (short)1635057666;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1541931012;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
												task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>((acpFeatureNode[10149] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection).CnvPerConventionalChannelOptionsDirectTalkaround_A9255, false));
												num = (short)414908419;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												goto IL_36C;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_28C;
												}
												continue;
											case 4:
											{
												num = (short)157409219;
												short num4 = num;
												num = (short)1294262211;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													break;
												default:
													num = (short)1383333888;
													if (num != 0)
													{
													}
													num = (short)2047541249;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_2D0:
											num = (short)221773824;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_28C:
											goto IL_2D0;
										}
										IL_36C:
										goto IL_222;
									}
									finally
									{
										num = (short)1481375745;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												goto IL_3DC;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_3A4;
												}
												continue;
											case 2:
												enumerator.Dispose();
												num = (short)1061683200;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_3A4:
											if (enumerator == null)
											{
												break;
											}
											num = (short)437125122;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3DC:;
									}
									goto IL_3DF;
									IL_222:
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									conventionalPersonality.ASTROCall.CnvPerASTROCallASTROUnlimitedCalling_A7501.Value = false;
									num = (short)1792213000;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem != null)
									{
										num = (short)725483531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem == conventionalSystem2)
									{
										num = (short)1901395977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)944373766;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_443;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_110;
									}
									continue;
								case 9:
									goto IL_3DF;
								case 10:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)429195269;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator2.Current;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset = conventionalPersonality.FrequencyOptions.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset;
									num = (short)1393491971;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)708706308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_14B:
								num = (short)1503526922;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_110:
								goto IL_14B;
								IL_3DF:
								num = (short)638713856;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_443:
							return;
						}
						finally
						{
							num = (short)463077377;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4B1;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_47A;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)491126784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_47A:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1437859842;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4B1:;
						}
						goto IL_4B4;
					}
					case 1:
						goto IL_4B4;
					case 2:
						if (conventionalSystem2.General.CnvSysGeneralSystemType_A13262.Value == 0)
						{
							num = (short)364380163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						num = (short)229310465;
						if (num != 0)
						{
						}
						num = (short)876740612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (conventionalSystem2.General.ConvConfigConvSystemFeatRSISys_A41838.Value)
						{
							num = (short)1450311681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_42;
					IL_4B4:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(conventionalSystem2.Features.CnvSysFeaturesCAIDataRegistration_A7585, false));
					enumerator2 = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
					num = (short)1785004032;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_42:
				conventionalSystem2 = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				num = (short)1355153410;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600B724 RID: 46884 RVA: 0x00A9B61C File Offset: 0x00A9981C
		internal static bool ConCAIDataReadOnly(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_70;
				case 1:
				{
					num2 = (short)1255616105;
					short num3 = num2;
					num2 = (short)2052206185;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70;
					default:
						goto IL_14C;
					}
					break;
				}
				case 2:
					if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
					{
						num2 = (short)1637810176;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					num2 = (short)645070849;
					if (num2 != 0)
					{
					}
					if (conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value)
					{
						num2 = (short)511574016;
						short num4 = num2;
						num2 = (short)1917911041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_20;
				IL_70:
				num2 = (short)1445986307;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14C:
			num2 = (short)376700928;
			if (num2 != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features;
			return features.CnvSysFeaturesCAIDataRegistration_A7585;
			IL_20:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features);
			conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
			num2 = (short)1875247106;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x00A9B790 File Offset: 0x00A99990
		public static bool ConSystemTypeIsAstroOrDVRSWithRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1743847425;
			if (num != 0)
			{
			}
			num = (short)437714946;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					goto IL_13C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 3:
				{
					if (cnvSysGeneralSystemType_A.Value == 0)
					{
						return true;
					}
					num = (short)1681249789;
					short num3 = num;
					num = (short)2109265405;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1911881728;
						if (num != 0)
						{
						}
						num = (short)2025193473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_5C:
				if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
				{
					num = (short)1615200256;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					cnvSysGeneralSystemType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General).CnvSysGeneralSystemType_A13262;
					num = (short)511901696;
					short num4 = num;
					num = (short)573702147;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_13C:
			return cnvSysGeneralSystemType_A.Value == 2;
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x00A9B8E4 File Offset: 0x00A99AE4
		public static bool ConSystemTypeIsMDCWithRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
			{
				short num = (short)1932337333;
				short num2 = num;
				num = (short)1655709877;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1008074753;
					if (num != 0)
					{
					}
					num = (short)1864630272;
					if (num != 0)
					{
					}
					num = (short)2096562176;
					short num3 = num;
					break;
				}
				}
				return false;
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value == 1;
		}

		// Token: 0x0600B727 RID: 46887 RVA: 0x00A9B9B8 File Offset: 0x00A99BB8
		public static bool ConTiggerRevertChannelApplicableForCon(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1833304064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					switch (num2)
					{
					case 0:
						goto IL_B8;
					case 1:
						enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)319160320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)708050945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						goto IL_546;
					case 4:
						if (trunkingPersonalityRecset != null)
						{
							num = (short)50987011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7;
					case 5:
						try
						{
							num = (short)213450769;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality != null)
									{
										num = (short)1633746956;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)151977995;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)404750354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)296550409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner != null)
									{
										num = (short)1733296129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_428;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value == 1)
									{
										num = (short)344522755;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)18612234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem == conventionalSystem2)
									{
										num = (short)504430605;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingSystemNumber_A9243.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)1601503237;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_428;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.Value == 4)
									{
										num = (short)1151270920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_428;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality != null)
									{
										num = (short)111411214;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)738197508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.CallConstraints();
									num = (short)1345257487;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = null;
									num = (short)231800838;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)466354178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									num = (short)727711744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
									switch (0)
									{
									case 0:
										goto IL_1CE;
									}
									continue;
								case 18:
									goto IL_482;
								}
								IL_296:
								num = (short)1985806352;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CE:
								goto IL_296;
								IL_428:
								num = (short)595001351;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_482:
							goto IL_E7;
						}
						finally
						{
							num = (short)1265238017;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)305870357;
									short num3 = num;
									num = (short)911357461;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1893072896;
										if (num != 0)
										{
										}
										break;
									}
									enumerator.Dispose();
									num = (short)1420558338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4B9;
									}
									continue;
								case 2:
									goto IL_543;
								}
								IL_4B9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)244252672;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_543:;
						}
						goto IL_546;
					}
					goto IL_47;
					IL_E7:
					num = (short)1948909569;
					if (num != 0)
					{
					}
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)1289682946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_546:
					enumerator = trunkingPersonalityRecset.GetEnumerator();
					num = (short)1975713797;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B8:
				num = (short)250609664;
				short num4 = num;
				try
				{
					num = (short)1517813777;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)130351116;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2 = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
							num = (short)429916164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2 = conventionalPersonality2.Signaling.CnvPerSignalingRevertChannel_A13267.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
							num = (short)1981218832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
							num = (short)318046214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3 = null;
							num = (short)1101594632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
							if (conventionalPersonality2 != null)
							{
								num = (short)905183233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3 = conventionalPersonality3.Signaling.CnvPerSignalingSystemNumber_A9243.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
							num = (short)1459355663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
							if (conventionalPersonality3 != null)
							{
								num = (short)1313275907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3;
							if (conventionalSystem3 == conventionalSystem2)
							{
								num = (short)1444347917;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
							if (conventionalPersonality3.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value == 1)
							{
								num = (short)82116619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1101987849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
							if (conventionalPersonality3.Signaling.CnvPerSignalingSignalingType_A9129.Value == 4)
							{
								num = (short)1222508549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_83C;
						}
						case 11:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3 = conventionalPersonality3.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
							num = (short)1367736334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)246677522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
							conventionalPersonality2.Signaling.CnvPerSignalingRevertChannel_A13267.CallConstraints();
							num = (short)595001354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							goto IL_83C;
						case 15:
							goto IL_83C;
						case 16:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
							if (channelAssignmentListInner2 != null)
							{
								num = (short)1256980482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 17:
							switch (0)
							{
							case 0:
								goto IL_5DC;
							}
							continue;
						case 18:
							goto IL_891;
						}
						IL_768:
						num = (short)1374748672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5DC:
						goto IL_768;
						IL_83C:
						num = (short)1370947591;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_891:;
				}
				finally
				{
					num = (short)332922881;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1986330626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_8C5;
							}
							continue;
						case 2:
							goto IL_8FB;
						}
						IL_8C5:
						if (enumerator == null)
						{
							break;
						}
						num = (short)319619072;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_8FB:;
				}
				return true;
				IL_47:
				conventionalSystem2 = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				trunkingPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
				num = (short)1109327876;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600B728 RID: 46888 RVA: 0x00A9C2F8 File Offset: 0x00A9A4F8
		internal static bool ConSystemTypeIsMDCAndRSIDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (cnvSysGeneralSystemType_A.Value == 2)
					{
						num2 = (short)2009923586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					if (cnvSysGeneralSystemType_A.Value != 3)
					{
						goto IL_176;
					}
					goto IL_6D;
				case 2:
					goto IL_127;
				case 3:
					num2 = (short)1717633025;
					if (num2 != 0)
					{
					}
					num2 = (short)599195649;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (cnvSysGeneralSystemType_A.Value != 1)
					{
						num2 = (short)145162243;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6D;
				case 5:
				{
					num2 = (short)670014720;
					short num3 = num2;
					num2 = (short)764714240;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_176;
					default:
					{
						num2 = (short)1708785664;
						short num4 = num2;
						num2 = (short)116326400;
						if (num2 != 0)
						{
						}
						num2 = (short)1033895936;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_28;
				IL_176:
				num2 = (short)814415877;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_6D:
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general;
			return general.ConvConfigConvSystemFeatRSISys_A41838.Value;
			IL_127:
			goto IL_6D;
			IL_28:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General);
			cnvSysGeneralSystemType_A = general.CnvSysGeneralSystemType_A13262;
			num2 = (short)480706564;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x00A9C49C File Offset: 0x00A9A69C
		internal static bool ConCAIDataRegValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)406388740;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1175453697;
					if (num2 != 0)
					{
					}
					num2 = (short)509076141;
					short num3 = num2;
					num2 = (short)1630266029;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_123;
					default:
						num2 = (short)489816064;
						if (num2 != 0)
						{
						}
						if (dataProfiles != null)
						{
							num2 = (short)642580483;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					break;
				}
				case 2:
					if (features.CnvSysFeaturesCAIDataRegistration_A7585.Value)
					{
						goto IL_123;
					}
					goto IL_BC;
				case 3:
					num2 = (short)467599362;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 2)
					{
						num2 = (short)143523849;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
				{
					num2 = (short)730857472;
					short num4 = num2;
					num2 = (short)32309249;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (!features.CnvSysFeaturesCAIDataRegistration_A7585.Value)
					{
						num2 = (short)1641086983;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					goto IL_FB;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
					dataProfiles = (conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
					if (conventionalSystem.General.CnvSysGeneralSystemType_A13262 == 0)
					{
						num2 = (short)654442501;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 9:
					goto IL_BC;
				}
				goto IL_38;
				IL_BC:
				num2 = (short)916324358;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_123:
				num2 = (short)1625423872;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FB:
			return dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 3;
			IL_38:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features);
			num2 = (short)453181448;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B72A RID: 46890 RVA: 0x00A9C70C File Offset: 0x00A9A90C
		internal static bool conCallFormatIncludeCorD(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)551354368;
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
				global::AcpBusinessLayer.AcpListField cnvSysGeneralQc2CallFormat_A;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.QuikCallII quikCallII;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (cnvSysGeneralQc2CallFormat_A.Value != 0)
						{
							num = (short)364380162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						goto IL_1C9;
					case 2:
						goto IL_2C7;
					case 3:
					{
						num = (short)1949148904;
						short num3 = num;
						num = (short)768780008;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return false;
						default:
							num = (short)376897536;
							if (num != 0)
							{
							}
							num = (short)1219362827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_285;
					case 5:
						if (cnvSysGeneralQc2CallFormat_A.Value != 8)
						{
							num = (short)675151876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						num = (short)870449159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 1)
						{
							num = (short)962330627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					case 8:
						if (self.ParentRecset.IndexOf(parent) == 2)
						{
							num = (short)2115633165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)259653641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (self.ParentRecset.IndexOf(parent) == 3)
						{
							num = (short)2031943690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31F;
					case 10:
						num = (short)302252037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (conventionalSystem.QuikCallII.CnvSysQCIIDecodeValue)
						{
							num = (short)1106509825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					case 12:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value != 3)
						{
							num = (short)63832070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 13:
						num = (short)1026293760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68;
					IL_2D0:
					cnvSysGeneralQc2CallFormat_A = quikCallII.CnvSysGeneralQc2CallFormat_A42230;
					num = (short)272302088;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C9:
				return true;
				IL_285:
				num = (short)1022492672;
				short num4 = num;
				return cnvSysGeneralQc2CallFormat_A.Value == 9;
				IL_2C7:
				return cnvSysGeneralQc2CallFormat_A.Value != 3;
				IL_31F:
				num = (short)2093678593;
				if (num != 0)
				{
				}
				return false;
				IL_68:
				quikCallII = (self.Parent.Parent.ParentSection as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.QuikCallII);
				conventionalSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				parent = self.Parent;
				num = (short)1848311820;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x00A9CA60 File Offset: 0x00A9AC60
		internal static void conSyncCodetoFreq(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 13;
			short num = (short)1190789120;
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
				global::AcpBusinessLayer.AcpListField cnvSysGeneralQc2Code_A;
				string[] array;
				int num5;
				for (;;)
				{
					IL_31:
					int num3;
					switch (num2)
					{
					case 0:
						if (cnvSysGeneralQc2Code_A.UIValue == array[num3].TrimStart(global::System.Array.Empty<char>()).TrimEnd(global::System.Array.Empty<char>()))
						{
							num = (short)379322374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)2027356162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num3 >= array.GetLength(0))
						{
							num = (short)582418442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1967980544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_AA5;
					case 3:
					{
						num = (short)1782263954;
						short num4 = num;
						num = (short)1473458322;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C81;
						default:
							goto IL_B8E;
						}
						break;
					}
					case 4:
						goto IL_BCE;
					case 5:
						if (cnvSysGeneralQc2Code_A.Value == 0)
						{
							num = (short)1754923011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = -1;
						num3 = 0;
						num = (short)1643839496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_C81;
					case 7:
						if (num5 == -1)
						{
							num = (short)2027683849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C83;
					case 8:
						goto IL_AA5;
					case 9:
						return;
					case 10:
						num = (short)264699905;
						if (num != 0)
						{
						}
						goto IL_BCE;
					}
					goto IL_64;
					IL_AA5:
					num = (short)321519617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BCE:
					num = (short)1651113991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C81:
					num5 = num3;
					num = (short)852688900;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B8E:
				num = (short)911474688;
				if (num != 0)
				{
				}
				num = (short)493420544;
				short num6 = num;
				return;
				IL_C83:
				global::AcpBusinessLayer.AcpCustomRangeField cnvSysGeneralQc2Freq_A;
				double[] array2;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(cnvSysGeneralQc2Freq_A, (int)(array2[num5] * 10.0)));
				return;
				IL_64:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection;
				cnvSysGeneralQc2Freq_A = individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232;
				cnvSysGeneralQc2Code_A = individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234;
				array = new string[]
				{
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍諏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍量", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍鋏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("諍諏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("諍量", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("諍鋏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("词諏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("词量", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("词鋏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("裍諏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("裍量", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("裍鋏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("賍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("觍諏", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("觍量", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("觍鋏", a_),
					global::AllFeatures.CodeplugGuid.b("賍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("蛍諏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("蛍量", a_),
					global::AllFeatures.CodeplugGuid.b("賍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("蛍鋏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("蓍諏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("賍", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("蓍量", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("蓍鋏", a_),
					global::AllFeatures.CodeplugGuid.b("賍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("藍諏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("藍量", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("賍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("苍諏", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("苍量", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("苍鋏", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("賍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("菍諏", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("菍量", a_),
					global::AllFeatures.CodeplugGuid.b("賍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("迍", a_),
					global::AllFeatures.CodeplugGuid.b("菍鋏", a_),
					global::AllFeatures.CodeplugGuid.b("跍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("賍", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ￍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_),
					global::AllFeatures.CodeplugGuid.b("ﳍ", a_)
				};
				array2 = new double[]
				{
					288.5,
					296.5,
					304.7,
					313.0,
					321.7,
					330.5,
					339.6,
					346.7,
					349.0,
					358.6,
					358.9,
					368.5,
					371.5,
					378.6,
					384.6,
					389.0,
					398.1,
					399.8,
					410.8,
					412.1,
					422.1,
					426.6,
					433.7,
					441.6,
					445.7,
					457.1,
					457.9,
					470.5,
					473.2,
					483.5,
					489.8,
					496.8,
					507.0,
					510.5,
					517.5,
					524.6,
					524.8,
					532.5,
					539.0,
					543.3,
					547.5,
					553.9,
					562.3,
					562.5,
					569.1,
					577.5,
					582.1,
					584.8,
					592.5,
					600.9,
					602.6,
					607.5,
					617.4,
					622.5,
					623.7,
					634.5,
					637.5,
					645.7,
					651.9,
					652.5,
					667.5,
					668.3,
					669.9,
					682.5,
					688.3,
					691.8,
					697.5,
					707.3,
					712.5,
					716.7,
					726.8,
					727.5,
					741.3,
					746.8,
					757.5,
					767.4,
					772.5,
					787.5,
					788.5,
					794.3,
					802.5,
					810.2,
					817.5,
					822.2,
					832.5,
					847.5,
					851.1,
					855.5,
					862.5,
					877.5,
					879.0,
					881.0,
					892.5,
					903.2,
					907.5,
					912.0,
					922.5,
					928.1,
					937.5,
					944.1,
					952.5,
					953.7,
					967.5,
					979.9,
					1006.9,
					1034.7,
					1063.2,
					1092.4,
					1122.5,
					1153.4,
					1185.2,
					1217.8,
					1251.4,
					1285.8,
					1321.2,
					1357.6,
					1395.0,
					1433.4,
					1472.9,
					1513.5,
					1555.2,
					1598.0,
					1642.0,
					1687.2,
					1733.7,
					1781.5,
					1830.5,
					1881.0,
					1930.2,
					1989.1,
					2043.8,
					2094.5,
					2155.6,
					2212.2,
					2271.7,
					2334.6,
					2401.0,
					2468.2
				};
				num = (short)1604583429;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600B72C RID: 46892 RVA: 0x00A9D70C File Offset: 0x00A9B90C
		internal static void conSyncFreqtoCode(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 4;
			short num = (short)2044395520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A4;
				}
				int num4;
				int num5;
				double[] array;
				global::AcpBusinessLayer.AcpCustomRangeField cnvSysGeneralQc2Freq_A;
				for (;;)
				{
					IL_30:
					num = (short)861079378;
					short num3 = num;
					num = (short)2005796690;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)728563712;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							if (num4 == -1)
							{
								num = (short)141688836;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C32;
						case 1:
							if (num5 >= array.GetLength(0))
							{
								num = (short)765788162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)732889094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_AC3;
						case 3:
							goto IL_BED;
						case 4:
							goto IL_AFA;
						case 5:
							goto IL_AC3;
						case 6:
							if (cnvSysGeneralQc2Freq_A.UIValue == array[num5].ToString())
							{
								num = (short)914620423;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B4B;
						case 7:
							num4 = num5;
							num = (short)221642757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_BED;
						}
						goto IL_A4;
						IL_AC3:
						num = (short)470220800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BED:
						num = (short)1240989697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B4B:
					num5++;
					num = (short)972816392;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AFA:
				num = (short)1234436096;
				short num6 = num;
				num = (short)576782337;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpListField cnvSysGeneralQc2Code_A;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(cnvSysGeneralQc2Code_A, 0));
				return;
				IL_C32:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(cnvSysGeneralQc2Code_A, num4 + 1));
				return;
				IL_A4:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection;
				cnvSysGeneralQc2Freq_A = individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232;
				cnvSysGeneralQc2Code_A = individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234;
				string[] array2 = new string[]
				{
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("杻", a_),
					global::AllFeatures.CodeplugGuid.b("杻", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("蛄鷆", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("﯈", a_),
					global::AllFeatures.CodeplugGuid.b("蛄蛆", a_),
					global::AllFeatures.CodeplugGuid.b("﯈", a_),
					global::AllFeatures.CodeplugGuid.b("蛄藆", a_),
					global::AllFeatures.CodeplugGuid.b("靖", a_),
					global::AllFeatures.CodeplugGuid.b("臄鷆", a_),
					global::AllFeatures.CodeplugGuid.b("靖", a_),
					global::AllFeatures.CodeplugGuid.b("臄蛆", a_),
					global::AllFeatures.CodeplugGuid.b("﷈", a_),
					global::AllFeatures.CodeplugGuid.b("﷈", a_),
					global::AllFeatures.CodeplugGuid.b("臄藆", a_),
					global::AllFeatures.CodeplugGuid.b("ﳈ", a_),
					global::AllFeatures.CodeplugGuid.b("胄鷆", a_),
					global::AllFeatures.CodeplugGuid.b("ﳈ", a_),
					global::AllFeatures.CodeplugGuid.b("胄蛆", a_),
					global::AllFeatures.CodeplugGuid.b("￈", a_),
					global::AllFeatures.CodeplugGuid.b("胄藆", a_),
					global::AllFeatures.CodeplugGuid.b("￈", a_),
					global::AllFeatures.CodeplugGuid.b("ﻈ", a_),
					global::AllFeatures.CodeplugGuid.b("菄鷆", a_),
					global::AllFeatures.CodeplugGuid.b("ﻈ", a_),
					global::AllFeatures.CodeplugGuid.b("菄蛆", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("菄藆", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("蟄", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("苄鷆", a_),
					global::AllFeatures.CodeplugGuid.b("蛄", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("苄蛆", a_),
					global::AllFeatures.CodeplugGuid.b("蓄", a_),
					global::AllFeatures.CodeplugGuid.b("杻", a_),
					global::AllFeatures.CodeplugGuid.b("苄藆", a_),
					global::AllFeatures.CodeplugGuid.b("蟄ￆ", a_),
					global::AllFeatures.CodeplugGuid.b("杻", a_),
					global::AllFeatures.CodeplugGuid.b("蛄ￆ", a_),
					global::AllFeatures.CodeplugGuid.b("跄鷆", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("蓄", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("跄蛆", a_),
					global::AllFeatures.CodeplugGuid.b("蟄", a_),
					global::AllFeatures.CodeplugGuid.b("﯈", a_),
					global::AllFeatures.CodeplugGuid.b("蛄ﻆ", a_),
					global::AllFeatures.CodeplugGuid.b("跄藆", a_),
					global::AllFeatures.CodeplugGuid.b("﯈", a_),
					global::AllFeatures.CodeplugGuid.b("蓄ﻆ", a_),
					global::AllFeatures.CodeplugGuid.b("迄鷆", a_),
					global::AllFeatures.CodeplugGuid.b("靖", a_),
					global::AllFeatures.CodeplugGuid.b("蟄", a_),
					global::AllFeatures.CodeplugGuid.b("蛄", a_),
					global::AllFeatures.CodeplugGuid.b("迄蛆", a_),
					global::AllFeatures.CodeplugGuid.b("靖", a_),
					global::AllFeatures.CodeplugGuid.b("蓄", a_),
					global::AllFeatures.CodeplugGuid.b("﷈", a_),
					global::AllFeatures.CodeplugGuid.b("迄藆", a_),
					global::AllFeatures.CodeplugGuid.b("蟄ﻆ", a_),
					global::AllFeatures.CodeplugGuid.b("﷈", a_),
					global::AllFeatures.CodeplugGuid.b("蛄", a_),
					global::AllFeatures.CodeplugGuid.b("軄鷆", a_),
					global::AllFeatures.CodeplugGuid.b("ﳈ", a_),
					global::AllFeatures.CodeplugGuid.b("蓄ￆ", a_),
					global::AllFeatures.CodeplugGuid.b("軄蛆", a_),
					global::AllFeatures.CodeplugGuid.b("ﳈ", a_),
					global::AllFeatures.CodeplugGuid.b("蓄", a_),
					global::AllFeatures.CodeplugGuid.b("￈", a_),
					global::AllFeatures.CodeplugGuid.b("蛄", a_),
					global::AllFeatures.CodeplugGuid.b("蟄", a_),
					global::AllFeatures.CodeplugGuid.b("￈", a_),
					global::AllFeatures.CodeplugGuid.b("规鷆", a_),
					global::AllFeatures.CodeplugGuid.b("蓄", a_),
					global::AllFeatures.CodeplugGuid.b("ﻈ", a_),
					global::AllFeatures.CodeplugGuid.b("蛄", a_),
					global::AllFeatures.CodeplugGuid.b("规蛆", a_),
					global::AllFeatures.CodeplugGuid.b("ﻈ", a_),
					global::AllFeatures.CodeplugGuid.b("蓄", a_),
					global::AllFeatures.CodeplugGuid.b("规藆", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("蛄", a_),
					global::AllFeatures.CodeplugGuid.b("蟄", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("裄鷆", a_),
					global::AllFeatures.CodeplugGuid.b("蓄", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("蛄", a_),
					global::AllFeatures.CodeplugGuid.b("裄蛆", a_),
					global::AllFeatures.CodeplugGuid.b("蟄", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("蓄", a_),
					global::AllFeatures.CodeplugGuid.b("裄藆", a_),
					global::AllFeatures.CodeplugGuid.b("蛄", a_),
					global::AllFeatures.CodeplugGuid.b("杻", a_),
					global::AllFeatures.CodeplugGuid.b("蟄", a_),
					global::AllFeatures.CodeplugGuid.b("杻", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("﯈", a_),
					global::AllFeatures.CodeplugGuid.b("ￆ", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆ杻", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆ", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆ﯈", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆ靖", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆ﷈", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆﳈ", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆ￈", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆﻈ", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆ", a_),
					global::AllFeatures.CodeplugGuid.b("ﻆ", a_),
					global::AllFeatures.CodeplugGuid.b("杻", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("﯈", a_),
					global::AllFeatures.CodeplugGuid.b("靖", a_),
					global::AllFeatures.CodeplugGuid.b("﷈", a_),
					global::AllFeatures.CodeplugGuid.b("ﳈ", a_),
					global::AllFeatures.CodeplugGuid.b("￈", a_),
					global::AllFeatures.CodeplugGuid.b("ﻈ", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("杻", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("﯈", a_),
					global::AllFeatures.CodeplugGuid.b("靖", a_),
					global::AllFeatures.CodeplugGuid.b("﷈", a_),
					global::AllFeatures.CodeplugGuid.b("ﳈ", a_),
					global::AllFeatures.CodeplugGuid.b("￈", a_),
					global::AllFeatures.CodeplugGuid.b("ﻈ", a_),
					global::AllFeatures.CodeplugGuid.b("", a_),
					global::AllFeatures.CodeplugGuid.b("", a_)
				};
				array = new double[]
				{
					288.5,
					296.5,
					304.7,
					313.0,
					321.7,
					330.5,
					339.6,
					346.7,
					349.0,
					358.6,
					358.9,
					368.5,
					371.5,
					378.6,
					384.6,
					389.0,
					398.1,
					399.8,
					410.8,
					412.1,
					422.1,
					426.6,
					433.7,
					441.6,
					445.7,
					457.1,
					457.9,
					470.5,
					473.2,
					483.5,
					489.8,
					496.8,
					507.0,
					510.5,
					517.5,
					524.6,
					524.8,
					532.5,
					539.0,
					543.3,
					547.5,
					553.9,
					562.3,
					562.5,
					569.1,
					577.5,
					582.1,
					584.8,
					592.5,
					600.9,
					602.6,
					607.5,
					617.4,
					622.5,
					623.7,
					634.5,
					637.5,
					645.7,
					651.9,
					652.5,
					667.5,
					668.3,
					669.9,
					682.5,
					688.3,
					691.8,
					697.5,
					707.3,
					712.5,
					716.7,
					726.8,
					727.5,
					741.3,
					746.8,
					757.5,
					767.4,
					772.5,
					787.5,
					788.5,
					794.3,
					802.5,
					810.2,
					817.5,
					822.2,
					832.5,
					847.5,
					851.1,
					855.5,
					862.5,
					877.5,
					879.0,
					881.0,
					892.5,
					903.2,
					907.5,
					912.0,
					922.5,
					928.1,
					937.5,
					944.1,
					952.5,
					953.7,
					967.5,
					979.9,
					1006.9,
					1034.7,
					1063.2,
					1092.4,
					1122.5,
					1153.4,
					1185.2,
					1217.8,
					1251.4,
					1285.8,
					1321.2,
					1357.6,
					1395.0,
					1433.4,
					1472.9,
					1513.5,
					1555.2,
					1598.0,
					1642.0,
					1687.2,
					1733.7,
					1781.5,
					1830.5,
					1881.0,
					1930.2,
					1989.1,
					2043.8,
					2094.5,
					2155.6,
					2212.2,
					2271.7,
					2334.6,
					2401.0,
					2468.2
				};
				num4 = -1;
				num5 = 0;
				num = (short)1004208131;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600B72D RID: 46893 RVA: 0x00A9E35C File Offset: 0x00A9C55C
		internal static bool conCodeIsNotNoneFreqPair(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)473759744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				double[] array;
				global::AcpBusinessLayer.AcpCustomRangeField cnvSysGeneralQc2Freq_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return false;
					case 1:
					{
						int num3;
						if (num3 >= array.GetLength(0))
						{
							num = (short)1873281034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)301989896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_137;
					case 3:
					{
						int num4 = -1;
						int num3 = 0;
						num = (short)930283529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int num4;
						if (num4 != -1)
						{
							num = (short)593035264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
					{
						if (index != 0)
						{
							return true;
						}
						num = (short)1808160444;
						short num5 = num;
						num = (short)58545852;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17D;
						default:
							num = (short)1037238272;
							if (num != 0)
							{
							}
							num = (short)2037579779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_22D;
					case 7:
					{
						num = (short)163119105;
						if (num != 0)
						{
						}
						int num3;
						int num4 = num3;
						num = (short)711720966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int num3;
						if (cnvSysGeneralQc2Freq_A.Value == (int)(array[num3] * 10.0))
						{
							num = (short)1671036935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						goto IL_17D;
					}
					case 9:
						goto IL_137;
					case 10:
						goto IL_22D;
					}
					goto IL_5A;
					IL_137:
					num = (short)116064257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17D:
					num = (short)1461387266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22D:
					num = (short)1658454020;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_5A:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection;
				cnvSysGeneralQc2Freq_A = individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232;
				global::AcpBusinessLayer.AcpListField cnvSysGeneralQc2Code_A = individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234;
				array = new double[]
				{
					288.5,
					296.5,
					304.7,
					313.0,
					321.7,
					330.5,
					339.6,
					346.7,
					349.0,
					358.6,
					358.9,
					368.5,
					371.5,
					378.6,
					384.6,
					389.0,
					398.1,
					399.8,
					410.8,
					412.1,
					422.1,
					426.6,
					433.7,
					441.6,
					445.7,
					457.1,
					457.9,
					470.5,
					473.2,
					483.5,
					489.8,
					496.8,
					507.0,
					510.5,
					517.5,
					524.6,
					524.8,
					532.5,
					539.0,
					543.3,
					547.5,
					553.9,
					562.3,
					562.5,
					569.1,
					577.5,
					582.1,
					584.8,
					592.5,
					600.9,
					602.6,
					607.5,
					617.4,
					622.5,
					623.7,
					634.5,
					637.5,
					645.7,
					651.9,
					652.5,
					667.5,
					668.3,
					669.9,
					682.5,
					688.3,
					691.8,
					697.5,
					707.3,
					712.5,
					716.7,
					726.8,
					727.5,
					741.3,
					746.8,
					757.5,
					767.4,
					772.5,
					787.5,
					788.5,
					794.3,
					802.5,
					810.2,
					817.5,
					822.2,
					832.5,
					847.5,
					851.1,
					855.5,
					862.5,
					877.5,
					879.0,
					881.0,
					892.5,
					903.2,
					907.5,
					912.0,
					922.5,
					928.1,
					937.5,
					944.1,
					952.5,
					953.7,
					967.5,
					979.9,
					1006.9,
					1034.7,
					1063.2,
					1092.4,
					1122.5,
					1153.4,
					1185.2,
					1217.8,
					1251.4,
					1285.8,
					1321.2,
					1357.6,
					1395.0,
					1433.4,
					1472.9,
					1513.5,
					1555.2,
					1598.0,
					1642.0,
					1687.2,
					1733.7,
					1781.5,
					1830.5,
					1881.0,
					1930.2,
					1989.1,
					2043.8,
					2094.5,
					2155.6,
					2212.2,
					2271.7,
					2334.6,
					2401.0,
					2468.2
				};
				num = (short)187301888;
				short num6 = num;
				num = (short)1235746821;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x00A9E5EC File Offset: 0x00A9C7EC
		internal static bool ConSystemTypeIsQC2ORMDCWithQCIIDecodeEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					conventionalSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
					num2 = (short)1373634566;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1297416193;
					if (num2 != 0)
					{
					}
					if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 1)
					{
						num2 = (short)1190789120;
						short num3 = num2;
						num2 = (short)2135425027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F2;
				case 2:
					if (self.ParentRecset.IsEmbeddedRecset)
					{
						num2 = (short)96534528;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
					num2 = (short)976224260;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_1FA;
				case 4:
					goto IL_79;
				case 5:
					num2 = (short)575864833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_79;
				case 7:
					if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value != 3)
					{
						num2 = (short)998047749;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_30;
				IL_79:
				num2 = (short)2103508999;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F2:
			num2 = (short)638012883;
			short num4 = num2;
			num2 = (short)1381322195;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				num2 = (short)25755648;
				if (num2 != 0)
				{
				}
				return false;
			}
			IL_1FA:
			return conventionalSystem.QuikCallII.CnvSysQCIIDecodeValue;
			IL_30:
			conventionalSystem = null;
			num2 = (short)2139291650;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x00A9E7FC File Offset: 0x00A9C9FC
		internal static bool ConSystemTypeIsNotQC2(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1814757376;
			short num2 = num;
			num = (short)34389600;
			short num3 = num;
			num = (short)1153154656;
			switch (num3 == num)
			{
			}
			num = (short)471007232;
			if (num != 0)
			{
			}
			num = (short)1290731521;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value != 3;
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x00A9E8CC File Offset: 0x00A9CACC
		internal static bool ConIsVisibleSystemTypeIsQC2ORMDC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (!self.ParentRecset.IsEmbeddedRecset)
					{
						num2 = (short)1664745472;
						short num3 = num2;
						conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
						num2 = (short)1108934658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)538297297;
					short num4 = num2;
					num2 = (short)1516225489;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CC;
					default:
						num2 = (short)1648623616;
						if (num2 != 0)
						{
						}
						num2 = (short)1887502337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)2023620609;
					if (num2 != 0)
					{
					}
					conventionalSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
					num2 = (short)1074987011;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_B4;
				case 3:
					goto IL_B4;
				case 4:
					goto IL_F9;
				case 5:
					goto IL_CC;
				}
				goto IL_28;
				IL_B4:
				num2 = (short)312541189;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CC:
				if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 3)
				{
					return true;
				}
				num2 = (short)1629749252;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F9:
			return conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 1;
			IL_28:
			conventionalSystem = null;
			num2 = (short)680853504;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x00A9EA98 File Offset: 0x00A9CC98
		internal static bool ConLocationEnableIsEnabledAndConSysIsASTRO(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)524615680;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)496631817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						result = true;
						num = (short)708640780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)301727748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2A8;
					case 4:
					{
						global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
						if (cnvSysGeneralDataProfileSelection_A.RefRecset != null)
						{
							num = (short)343408640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 5:
						num = (short)736559120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return result;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles != null)
						{
							num = (short)340197387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 8:
						result = true;
						num = (short)1217069074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
						if (cnvSysGeneralDataProfileSelection_A.Value != 0)
						{
							num = (short)310575121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 10:
					{
						if (features.CnvSysFeaturesSendLocationToPeer_42427.Value)
						{
							num = (short)1999634435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266;
						num = (short)1786118159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1677197326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return result;
					case 13:
						if (features.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.Value)
						{
							num = (short)154861573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value == 5)
						{
							num = (short)1146617857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 15:
					{
						num = (short)417409846;
						short num3 = num;
						num = (short)963455798;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2A8;
						default:
						{
							num = (short)1608450049;
							if (num != 0)
							{
							}
							num = (short)1891958784;
							if (num != 0)
							{
							}
							global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
							if (cnvSysGeneralDataProfileSelection_A != null)
							{
								num = (short)813039618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						}
						break;
					}
					case 16:
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value != 2)
						{
							num = (short)1577320456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1626472458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						num = (short)2048983040;
						short num4 = num;
						global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = cnvSysGeneralDataProfileSelection_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
						num = (short)1024000007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						return result;
					}
					goto IL_7A;
					IL_2A8:
					result = true;
					num = (short)1652752390;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_7A:
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features);
				conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
				result = false;
				num = (short)1846476813;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x00A9EE6C File Offset: 0x00A9D06C
		internal static bool ConIndividualIDRangeCheck(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1022558209;
					if (num2 != 0)
					{
					}
					global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
					if (cnvSysGeneralSystemType_A.Value != 2)
					{
						num2 = (short)1161822208;
						short num3 = num2;
						num2 = (short)2072182787;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 1:
					return false;
				case 2:
				{
					int value;
					if (value > 9999999)
					{
						num2 = (short)699203585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 3:
					num2 = (short)1143996418;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return false;
			for (;;)
			{
				IL_20:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General;
				global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A = general.CnvSysGeneralSystemType_A13262;
				int value = general.CnvSysGeneralIndividualID_A8287.Value;
				num2 = (short)411853818;
				short num4 = num2;
				num2 = (short)1976001530;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6D;
				}
			}
			IL_6D:
			num2 = (short)656670720;
			if (num2 != 0)
			{
			}
			num2 = (short)446496768;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x00A9EFC4 File Offset: 0x00A9D1C4
		internal static bool ConCnvSysGroupTMSIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1854210049;
			if (num != 0)
			{
			}
			num = (short)508362752;
			short num2 = num;
			num = (short)1810985931;
			short num3 = num;
			num = (short)1464955851;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)777715712;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262;
				if (cnvSysGeneralSystemType_A.Value != 2)
				{
					return cnvSysGeneralSystemType_A.Value == 0;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x00A9F098 File Offset: 0x00A9D298
		internal static bool ConCnvPerAccSelectionIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2134310913;
					if (num2 != 0)
					{
					}
					if (index != 0)
					{
						num2 = (short)903282688;
						short num3 = num2;
						num2 = (short)1145044995;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					goto IL_14D;
				case 2:
					if (cnvSysGeneralSystemType_A.Value != 0)
					{
						num2 = (short)997982209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					num2 = (short)1249574914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_14D:
			return cnvSysGeneralSystemType_A.Value == 2;
			for (;;)
			{
				IL_20:
				cnvSysGeneralSystemType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262;
				num2 = (short)590854849;
				short num4 = num2;
				num2 = (short)1958525633;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6C;
				}
			}
			IL_6C:
			num2 = (short)908394496;
			if (num2 != 0)
			{
			}
			num2 = (short)146669568;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x00A9F1F8 File Offset: 0x00A9D3F8
		internal static bool ConCnvPerAccSelectionIsVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)643170305;
					if (num2 != 0)
					{
					}
					global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
					if (cnvSysGeneralSystemType_A.Value != 0)
					{
						num2 = (short)1994129408;
						short num3 = num2;
						num2 = (short)1031012355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 1:
					goto IL_15B;
				case 2:
				{
					global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
					if (cnvSysGeneralSystemType_A.Value != 2)
					{
						num2 = (short)1201078273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 3:
					num2 = (short)1593573378;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_15B:
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features;
			return features.CnvSysFeaturesPASelection_A42880.Value != 0;
			for (;;)
			{
				IL_20:
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features);
				global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262;
				num2 = (short)1820312186;
				short num4 = num2;
				num2 = (short)1284424314;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_73;
				}
			}
			IL_73:
			num2 = (short)1011941376;
			if (num2 != 0)
			{
			}
			num2 = (short)514916352;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x00A9F364 File Offset: 0x00A9D564
		internal static bool conSendLocationToPeeronPTTValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)760545280;
			switch (num)
			{
			default:
			{
				num = (short)185204744;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
					global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
					switch (num2)
					{
					case 0:
						num = (short)1347551239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)636747789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return true;
					case 3:
					{
						global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
						if (cnvSysGeneralDataProfileSelection_A != null)
						{
							num = (short)174194688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B0;
					}
					case 4:
						return true;
					case 5:
					{
						global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266;
						num = (short)873267203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value == 5)
						{
							num = (short)66781186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B0;
					}
					case 7:
					{
						global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
						if (cnvSysGeneralDataProfileSelection_A.RefRecset != null)
						{
							num = (short)1179058177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B0;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 9:
					{
						global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = cnvSysGeneralDataProfileSelection_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
						num = (short)1017839626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						IL_20B:
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles != null)
						{
							num = (short)1442512908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B0;
					}
					case 11:
						if (cnvSysGeneralSystemType_A.Value == 2)
						{
							num = (short)244252677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 12:
						num = (short)429588486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)9961472;
						short num3 = num;
						global::AcpBusinessLayer.AcpRecRefField cnvSysGeneralDataProfileSelection_A;
						if (cnvSysGeneralDataProfileSelection_A.Value != 0)
						{
							num = (short)510459913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B0;
					}
					}
					IL_7C:
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features;
					conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
					cnvSysGeneralSystemType_A = conventionalSystem.General.CnvSysGeneralSystemType_A13262;
					if (!features.CnvSysFeaturesSendLocationToPeer_42427.Value)
					{
						num = (short)1149173764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1158348801;
					if (num != 0)
					{
					}
					num = (short)1757937675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B0:
					num = (short)1756382820;
					short num4 = num;
					num = (short)1245595236;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20B;
					default:
						goto IL_2E7;
					}
				}
				return true;
				IL_2E7:
				num = (short)1395785728;
				if (num != 0)
				{
				}
				return false;
			}
			}
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x00A9F670 File Offset: 0x00A9D870
		public static bool ConSysTypeEditabilityByZoneClone(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)432930816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::AcpBusinessLayer.AcpField<bool> radWideFeaturesZoneCloneEnable_;
				for (;;)
				{
					IL_28:
					bool flag;
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						num = (short)1695023115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_33B;
					case 3:
						goto IL_24F;
					case 4:
						num = (short)1748303877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (conventionalSystemRecset.Count > 0)
						{
							num = (short)739442697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						flag = true;
						goto IL_18E;
					case 7:
						num = (short)1613430785;
						if (num != 0)
						{
						}
						goto IL_24F;
					case 8:
						if (!radioInformation.Labtool.RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798.Value)
						{
							num = (short)646840337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1032454150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)562036752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_33B;
					case 11:
						if (conventionalSystemRecset != null)
						{
							num = (short)1291190276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 12:
						if (num3 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)372310026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1796669458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						flag = radioInformation.Labtool.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799.Value;
						goto IL_18E;
					case 14:
						flag2 = true;
						num = (short)43646978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if ((radWideFeaturesZoneCloneEnable_.Value || flag2) && flag3)
						{
							num = (short)196935681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 16:
						if (self.Parent == conventionalSystemRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)
						{
							num = (short)664141824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 17:
						num = (short)852754445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if ((zoneChannelAssignmentRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)861470734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)740818951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
					IL_18E:
					flag3 = flag;
					zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
					flag2 = false;
					num3 = 0;
					num = (short)1063190528;
					short num4 = num;
					num = (short)26214403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24F:
					num = (short)1458307084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33B:
					num = (short)1146225936;
					short num5 = num;
					num = (short)1879704848;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)105316352;
						if (num != 0)
						{
						}
						num = (short)575406095;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return false;
				IL_7B:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
				conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				radWideFeaturesZoneCloneEnable_ = features.RadWideFeaturesZoneCloneEnable_43130;
				num = (short)1338769416;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x00A9FA94 File Offset: 0x00A9DC94
		internal static bool ConBoolMdcSysLdngTrngPttIdEnIsEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpListField cnvSysGeneralPTTID_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_BA;
				case 1:
					if (cnvSysGeneralPTTID_A.Value != 2)
					{
						num2 = (short)1580662786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11E;
				case 2:
				{
					num2 = (short)196819994;
					short num3 = num2;
					num2 = (short)1092959258;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BA;
					default:
						goto IL_99;
					}
					break;
				}
				case 3:
					if (cnvSysGeneralPTTID_A.Value != 1)
					{
						num2 = (short)2020343808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11E;
				}
				goto IL_20;
				IL_BA:
				num2 = (short)1397161985;
				if (num2 != 0)
				{
				}
				num2 = (short)114032641;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_99:
			num2 = (short)328073216;
			if (num2 != 0)
			{
			}
			return cnvSysGeneralPTTID_A.Value == 3;
			IL_11E:
			num2 = (short)480116736;
			short num4 = num2;
			return true;
			IL_20:
			cnvSysGeneralPTTID_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General).CnvSysGeneralPTTID_A8427;
			num2 = (short)133496835;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x00A9FBEC File Offset: 0x00A9DDEC
		internal static bool ConSecKmfProfileEnAstroOtarOtarEmcEqpdExtIsEnableAndCfgSecTypeIsHW(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1105592321;
			if (num != 0)
			{
			}
			num = (short)1146748928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)61997056;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_DE;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure secure;
				bool flag;
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
				for (;;)
				{
					IL_77:
					bool flag2;
					global::AcpBusinessLayer.AcpRecRefField cnvSysSecureKMFProfIndex_A;
					switch (num2)
					{
					case 0:
						num = (short)2127953937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1967289574;
						short num4 = num;
						num = (short)1970959590;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16A;
						default:
						{
							num = (short)1942814720;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile a_ = secure.CnvSysSecureKMFProfIndex_A40132.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.a(secure, a_, flag);
							num = (short)1312686087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						if (secure.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
						{
							num = (short)390266880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E;
					case 3:
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.a(secure, null, flag);
						num = (short)1897594890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)2110652439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS(self))
						{
							num = (short)934412289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44B;
					case 6:
						flag2 = false;
						goto IL_37C;
					case 7:
						return flag;
					case 8:
						num = (short)811991060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)550240275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return flag;
					case 11:
						flag2 = true;
						goto IL_37C;
					case 12:
						if (secure.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num = (short)957022229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E;
					case 13:
						num = (short)1588920325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						flag2 = false;
						goto IL_37C;
					case 15:
						if (cnvSysSecureKMFProfIndex_A != null)
						{
							num = (short)850526216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44B;
					case 16:
						num = (short)733806614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (secWideGeneralSecureOperation_A.Value != 1)
						{
							num = (short)1226702864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1592459275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (cnvSysSecureKMFProfIndex_A != null)
						{
							num = (short)1984299017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 19:
						if (cnvSysSecureKMFProfIndex_A.Value == 0)
						{
							num = (short)457900035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 20:
						if (cnvSysSecureKMFProfIndex_A.ReferencedNode != null)
						{
							num = (short)1004142605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44B;
					case 21:
						num = (short)524615682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (secWideGeneralSecureOperation_A.Value == 3)
						{
							goto IL_16A;
						}
						num = (short)1968111630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						flag2 = secure.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value;
						goto IL_37C;
					}
					goto IL_DE;
					IL_16A:
					num = (short)6029316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24E:
					num = (short)71237638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37C:
					flag = flag2;
					cnvSysSecureKMFProfIndex_A = secure.CnvSysSecureKMFProfIndex_A40132;
					num = (short)1065287695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44B:
					num = (short)1670316050;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_DE:
				secure = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure);
				secWideGeneralSecureOperation_A = secure.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
				num = (short)191365132;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_77;
			}
			}
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x00AA0080 File Offset: 0x00A9E280
		private static void a(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Secure A_0, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile A_1, bool A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset recset;
			for (;;)
			{
				IL_0A:
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				bool flag;
				switch (num)
				{
				case 0:
					goto IL_142;
				case 1:
					embeddedRecset = A_1.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
					goto IL_12A;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general;
					flag = general.SecKmfProfGenIndependentKeyList_43597.Value;
					goto IL_224;
				}
				case 3:
				{
					num2 = (short)1882062848;
					short num3 = num2;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide refSecureWide;
					embeddedRecset = refSecureWide.EncryptionKeyList.EmbeddedRecset;
					goto IL_12A;
				}
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general;
					if (!general.SecKmfProfGenIndependentKeyList_43597.Applicable)
					{
						num2 = (short)1688993798;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)986139082;
					short num4 = num2;
					num2 = (short)2064796106;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					default:
						num2 = (short)606208000;
						if (num2 != 0)
						{
						}
						num2 = (short)299761671;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					num2 = (short)135069699;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					flag = false;
					goto IL_224;
				case 7:
					goto IL_103;
				case 8:
					num2 = (short)1385168897;
					if (num2 != 0)
					{
					}
					if (A_1 != null)
					{
						num2 = (short)775880713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_247;
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = A_1.General;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide refSecureWide = general.RefSecureWide;
					num2 = (short)1594949636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_38;
				IL_103:
				num2 = (short)1915355138;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_12A:
				recset = embeddedRecset;
				num2 = (short)226033664;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_224:
				if (!flag || !A_2)
				{
					num2 = (short)721944581;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)1726283777;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_142:
			IL_247:
			A_0.CnvSysSecurePatchKeySel_A40136.SetRecset(recset);
			A_0.CnvSysSecureFSKeySel_A40134.SetRecset(recset);
			A_0.CnvSysSecurePrivateCallKeySel_A40137.SetRecset(recset);
			A_0.CnvSysSecureInterConnectKeySel_A40135.SetRecset(recset);
			A_0.CnvSysSecureDynTGKeySel_A40133.SetRecset(recset);
			return;
			IL_38:
			recset = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10040].EmbeddedRecset;
			num2 = (short)1444413448;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B73B RID: 46907 RVA: 0x00AA0310 File Offset: 0x00A9E510
		internal static bool ConSystemTypeIsDVRSAndTAAttempsNotDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			short num2;
			global::AcpBusinessLayer.AcpListField cnvSysDVRSTAAfterDVRSNoCommAttempts_A;
			for (;;)
			{
				IL_0A:
				global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
				switch (num)
				{
				case 0:
					return false;
				case 1:
					goto IL_10C;
				case 2:
					goto IL_12C;
				case 3:
				{
					if (conventionalSystem == null)
					{
						num2 = (short)757923840;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					cnvSysGeneralSystemType_A = conventionalSystem.General.CnvSysGeneralSystemType_A13262;
					cnvSysDVRSTAAfterDVRSNoCommAttempts_A = conventionalSystem.DVRS.CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125;
					num2 = (short)1756135218;
					short num3 = num2;
					num2 = (short)872906546;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10C;
					default:
						num2 = (short)1846804481;
						if (num2 != 0)
						{
						}
						num2 = (short)610271232;
						if (num2 != 0)
						{
						}
						num2 = (short)1123680257;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
				IL_10C:
				if (cnvSysGeneralSystemType_A.Value != 2)
				{
					goto IL_133;
				}
				num2 = (short)986120194;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_12C:
			return cnvSysDVRSTAAfterDVRSNoCommAttempts_A != 0;
			IL_133:
			num2 = (short)157941760;
			short num4 = num2;
			return false;
			IL_20:
			conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
			num2 = (short)1410990083;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B73C RID: 46908 RVA: 0x00AA047C File Offset: 0x00A9E67C
		internal static bool ConPhase2SystemCompatibilityIsEnabled(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return false;
				case 1:
				{
					num2 = (short)125595896;
					short num3 = num2;
					num2 = (short)550007032;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
					{
						num2 = (short)1763311616;
						short num4 = num2;
						num2 = (short)1629552640;
						if (num2 != 0)
						{
						}
						if (index == 1)
						{
							num2 = (short)1535770626;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					}
					break;
				}
				case 2:
					goto IL_13E;
				case 3:
					if (conventionalSystem == null)
					{
						num2 = (short)1307836416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_96;
				}
				goto IL_20;
				IL_96:
				num2 = (short)61341697;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_13E:
			return conventionalSystem.DVRS.CnvSysDVRSPhase2SysCompatibility_43000.Value;
			IL_20:
			conventionalSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
			num2 = (short)464322561;
			if (num2 != 0)
			{
			}
			num2 = (short)32899075;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B73D RID: 46909 RVA: 0x00AA05D0 File Offset: 0x00A9E7D0
		internal static bool ConQualifyEmergencyAlarmRxIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features features;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_F1;
				case 1:
					if (features.CnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Value)
					{
						num2 = (short)28704770;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_134;
				case 2:
				{
					num2 = (short)1134186298;
					short num3 = num2;
					num2 = (short)951340858;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F1;
					default:
						goto IL_CF;
					}
					break;
				}
				case 3:
					num2 = (short)1977352193;
					if (num2 != 0)
					{
					}
					if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value == 1)
					{
						num2 = (short)1710161920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_134;
				}
				goto IL_20;
				IL_F1:
				num2 = (short)1721892865;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_CF:
			num2 = (short)328531968;
			if (num2 != 0)
			{
			}
			return features.CnvSysFeaturesEmergencyAlarmRxIndicator_A7930.Applicable;
			IL_134:
			num2 = (short)1148125184;
			short num4 = num2;
			return false;
			IL_20:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features);
			num2 = (short)183762947;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x00AA073C File Offset: 0x00A9E93C
		internal static bool ConQualifyEmergencyAlarmRxIsVisiblity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)834082877;
			short num2 = num;
			num = (short)202813;
			switch (num2 == num)
			{
			}
			num = (short)777060352;
			short num3 = num;
			num = (short)1977614337;
			if (num != 0)
			{
			}
			num = (short)1591934976;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value == 1;
		}
	}
}
