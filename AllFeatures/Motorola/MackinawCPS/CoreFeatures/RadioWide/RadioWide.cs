using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000170 RID: 368
	[global::System.Serializable]
	public class RadioWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06003015 RID: 12309 RVA: 0x002F0790 File Offset: 0x002EE990
		public RadioWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐苔뻖뷘뻚", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜ꋠ賢裤韦蛨藪裬臮藰꿲ꟴ零鷸鋺鋼\udffe嘀樂愄戆唈夊氌欎砐簒䈔縖紘縚㌜朞䀠丢䤤", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TransmitPowerLevels(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsNewBandPlan(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPSFireground(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPS(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Fireground(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplit(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplit(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GunLock(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LTE(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Depot(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Sensor(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x002F08F8 File Offset: 0x002EEAF8
		protected RadioWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黋꿍듏믑믓迗동룛믝", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("跋ꋍ볏铑뇓럕곗꿙껛믝鏟\ud9e1꟣觥藧髩菫胭闯鳱胳ꫵ꫷鯹飻韽濿∁匃漅氇漉個對焏瘑紓礕众猙砛笝ฟ娡䔣䬥䐧", a_);
			this.a(info, context);
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06003017 RID: 12311 RVA: 0x002F0954 File Offset: 0x002EEB54
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.General General
		{
			get
			{
				short num = (short)54012148;
				short num2 = num;
				num = (short)1019095284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1352531968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1981284353;
				if (num != 0)
				{
				}
				num = (short)1618214912;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.General)base[10099];
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x002F0A0C File Offset: 0x002EEC0C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones AlertTones
		{
			get
			{
				short num = (short)728474244;
				short num2 = num;
				num = (short)2032968324;
				switch (num2 == num)
				{
				}
				num = (short)676397056;
				short num3 = num;
				num = (short)1017839616;
				if (num != 0)
				{
				}
				num = (short)1897201665;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones)base[10098];
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x002F0AC4 File Offset: 0x002EECC4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords UserInformationAndPasswords
		{
			get
			{
				short num = (short)663062076;
				short num2 = num;
				num = (short)1598522940;
				switch (num2 == num)
				{
				}
				num = (short)254476288;
				short num3 = num;
				num = (short)266207233;
				if (num != 0)
				{
				}
				num = (short)1956446208;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords)base[10102];
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x002F0B80 File Offset: 0x002EED80
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features Features
		{
			get
			{
				short num = (short)639015161;
				short num2 = num;
				num = (short)166041849;
				switch (num2 == num)
				{
				}
				num = (short)174981120;
				short num3 = num;
				num = (short)757989376;
				if (num != 0)
				{
				}
				num = (short)24903681;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features)base[10105];
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x002F0C38 File Offset: 0x002EEE38
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio DualRadio
		{
			get
			{
				short num = (short)1161739778;
				short num2 = num;
				num = (short)889896450;
				switch (num2 == num)
				{
				}
				num = (short)1328807936;
				short num3 = num;
				num = (short)97648641;
				if (num != 0)
				{
				}
				num = (short)1688666112;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio)base[10784];
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x002F0CF0 File Offset: 0x002EEEF0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location Location
		{
			get
			{
				short num = (short)26559373;
				short num2 = num;
				num = (short)865813389;
				switch (num2 == num)
				{
				}
				num = (short)1341718528;
				short num3 = num;
				num = (short)992673793;
				if (num != 0)
				{
				}
				num = (short)1397948416;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location)base[10100];
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x002F0DAC File Offset: 0x002EEFAC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions DigitalAudioOptions
		{
			get
			{
				short num = (short)572990089;
				short num2 = num;
				num = (short)1725571721;
				switch (num2 == num)
				{
				}
				num = (short)937164800;
				short num3 = num;
				num = (short)432996353;
				if (num != 0)
				{
				}
				num = (short)1030029312;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions)base[10101];
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x002F0E64 File Offset: 0x002EF064
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TransmitPowerLevels TransmitPowerLevels
		{
			get
			{
				short num = (short)994427515;
				short num2 = num;
				num = (short)113164923;
				switch (num2 == num)
				{
				}
				num = (short)1780613120;
				short num3 = num;
				num = (short)555745281;
				if (num != 0)
				{
				}
				num = (short)632422400;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TransmitPowerLevels)base[10103];
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x002F0F1C File Offset: 0x002EF11C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsNewBandPlan TxPowerLevelsNewBandPlan
		{
			get
			{
				short num = (short)1901158944;
				short num2 = num;
				num = (short)1278108192;
				switch (num2 == num)
				{
				}
				num = (short)186122240;
				short num3 = num;
				num = (short)673251329;
				if (num != 0)
				{
				}
				num = (short)1828192256;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsNewBandPlan)base[10761];
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x002F0FD4 File Offset: 0x002EF1D4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPSFireground TPSFireground
		{
			get
			{
				short num = (short)1066517887;
				short num2 = num;
				num = (short)955762047;
				switch (num2 == num)
				{
				}
				num = (short)850067456;
				short num3 = num;
				num = (short)2037776385;
				if (num != 0)
				{
				}
				num = (short)114294784;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPSFireground)base[10230];
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x002F108C File Offset: 0x002EF28C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPS TPS
		{
			get
			{
				short num = (short)429914278;
				short num2 = num;
				num = (short)1549531302;
				switch (num2 == num)
				{
				}
				num = (short)1906507776;
				short num3 = num;
				num = (short)394526721;
				if (num != 0)
				{
				}
				num = (short)1518796800;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPS)base[10749];
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x002F1144 File Offset: 0x002EF344
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Fireground Fireground
		{
			get
			{
				short num = (short)1346680162;
				short num2 = num;
				num = (short)1165014370;
				switch (num2 == num)
				{
				}
				num = (short)285212672;
				short num3 = num;
				num = (short)1651441664;
				if (num != 0)
				{
				}
				num = (short)1265631233;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Fireground)base[10750];
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x002F11FC File Offset: 0x002EF3FC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplit RxFrequencySplit
		{
			get
			{
				short num = (short)1761195586;
				short num2 = num;
				num = (short)399685186;
				switch (num2 == num)
				{
				}
				num = (short)1014693888;
				short num3 = num;
				num = (short)661848065;
				if (num != 0)
				{
				}
				num = (short)789250048;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplit)base[10096];
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x002F12B8 File Offset: 0x002EF4B8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplit TxFrequencySplit
		{
			get
			{
				short num = (short)1503236779;
				short num2 = num;
				num = (short)1723503275;
				switch (num2 == num)
				{
				}
				num = (short)1021575168;
				short num3 = num;
				num = (short)866582529;
				if (num != 0)
				{
				}
				num = (short)1167589376;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplit)base[10094];
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x002F1374 File Offset: 0x002EF574
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit FCCNarrowBandingFrequencySplit
		{
			get
			{
				short num = (short)1010171905;
				if (num != 0)
				{
				}
				num = (short)1749799963;
				short num2 = num;
				num = (short)1677906971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1687945216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584791552;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit)base[10636];
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x002F1430 File Offset: 0x002EF630
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern LightbarPattern
		{
			get
			{
				short num = (short)1635270695;
				short num2 = num;
				num = (short)1842364455;
				switch (num2 == num)
				{
				}
				num = (short)2097414144;
				short num3 = num;
				num = (short)286982145;
				if (num != 0)
				{
				}
				num = (short)287178752;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern)base[10604];
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x002F14EC File Offset: 0x002EF6EC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GunLock GunLock
		{
			get
			{
				short num = (short)1742901642;
				short num2 = num;
				num = (short)677024138;
				switch (num2 == num)
				{
				}
				num = (short)2005663744;
				short num3 = num;
				num = (short)168034305;
				if (num != 0)
				{
				}
				num = (short)1085472768;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GunLock)base[10606];
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x002F15A8 File Offset: 0x002EF7A8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth Bluetooth
		{
			get
			{
				short num = (short)548470495;
				short num2 = num;
				num = (short)299302623;
				switch (num2 == num)
				{
				}
				num = (short)1340669952;
				short num3 = num;
				num = (short)1005387776;
				if (num != 0)
				{
				}
				num = (short)317915137;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth)base[10630];
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x002F1660 File Offset: 0x002EF860
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LTE LTE
		{
			get
			{
				short num = (short)1580858957;
				short num2 = num;
				num = (short)1257832013;
				switch (num2 == num)
				{
				}
				num = (short)1042874368;
				short num3 = num;
				num = (short)1123352576;
				if (num != 0)
				{
				}
				num = (short)1927610369;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LTE)base[10772];
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x002F171C File Offset: 0x002EF91C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Depot Depot
		{
			get
			{
				short num = (short)1424889739;
				short num2 = num;
				num = (short)899094411;
				switch (num2 == num)
				{
				}
				num = (short)1902706688;
				short num3 = num;
				num = (short)1849819136;
				if (num != 0)
				{
				}
				num = (short)1495597057;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Depot)base[10106];
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x002F17D8 File Offset: 0x002EF9D8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool Labtool
		{
			get
			{
				short num = (short)1342239053;
				short num2 = num;
				num = (short)1103098189;
				switch (num2 == num)
				{
				}
				num = (short)513146880;
				short num3 = num;
				num = (short)194772993;
				if (num != 0)
				{
				}
				num = (short)2129068032;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool)base[10093];
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x002F1894 File Offset: 0x002EFA94
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Sensor Sensor
		{
			get
			{
				short num = (short)892826761;
				short num2 = num;
				num = (short)851211401;
				switch (num2 == num)
				{
				}
				num = (short)1413677056;
				short num3 = num;
				num = (short)76087296;
				if (num != 0)
				{
				}
				num = (short)1197211649;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Sensor)base[10819];
			}
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x002F1950 File Offset: 0x002EFB50
		public static global::AcpCommonLib.IAcpFeatureNode GetRadioWide()
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_A9;
					case 1:
					{
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)1152843778;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1449263104;
						short num3 = num2;
						result = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0];
						num2 = (short)660209664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						num2 = (short)1928134657;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2045)[0];
						num2 = (short)903413763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return result;
					}
					goto IL_20;
				}
				IL_A9:
				num2 = (short)1372981031;
				short num4 = num2;
				num2 = (short)563873575;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_22;
				default:
					num2 = (short)1191313408;
					if (num2 != 0)
					{
					}
					break;
				}
				return result;
			}
			}
			IL_20:
			result = null;
			IL_22:
			num2 = (short)1510080513;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x002F1AA8 File Offset: 0x002EFCA8
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)23315245;
			short num2 = num;
			num = (short)1913832237;
			switch (num2 == num)
			{
			}
			num = (short)1870790656;
			short num3 = num;
			num = (short)208470017;
			if (num != 0)
			{
			}
			num = (short)115015680;
			if (num != 0)
			{
			}
			this.b();
			this.a();
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x002F1B60 File Offset: 0x002EFD60
		private void b()
		{
			short num = (short)684261377;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					if (this.LightbarPattern == null)
					{
						num = (short)1077280772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)240741248;
					short num3 = num;
					num = (short)1050045312;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1892024321;
						if (num != 0)
						{
						}
						num = (short)1104871424;
						if (num != 0)
						{
						}
						num = (short)1205796866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
				{
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern(this));
					num = (short)1303838720;
					short num4 = num;
					num = (short)464846848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_39:
				if (global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					break;
				}
				num = (short)773586947;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x002F1CC8 File Offset: 0x002EFEC8
		private void a()
		{
			short num = (short)1929379841;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
					if (this.Bluetooth == null)
					{
						num = (short)1037828100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)1106333727;
					short num3 = num;
					num = (short)1571901471;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)288686081;
						if (num != 0)
						{
						}
						num = (short)1258225664;
						if (num != 0)
						{
						}
						num = (short)1102643202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
				{
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth(this));
					num = (short)1405943808;
					short num4 = num;
					num = (short)1850540032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_38:
				if (global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					break;
				}
				num = (short)1263599619;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
