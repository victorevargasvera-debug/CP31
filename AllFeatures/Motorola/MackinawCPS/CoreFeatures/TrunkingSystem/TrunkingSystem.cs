using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000094 RID: 148
	[global::System.Serializable]
	public class TrunkingSystem : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06000ED6 RID: 3798 RVA: 0x000ECCA0 File Offset: 0x000EAEA0
		public TrunkingSystem(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("髍ꋏꟑ뫓뷕뇗듙믛ﻝ돟鯡韣鋥跧蟩", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSYSTEM;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ껹軻诽滿椁洃栅漇⨉伋愍縏琑紓焕洗栙紛樝䤟䴡䨣稥簧堩夫䀭嬯嬱娳儵ᠷ椹䔻䴽㐿❁⥃ᩅ᱇㡉㥋⁍㭏㭑㩓ㅕୗ⍙⽛⩝՟ཡ䩣ṥ१ݩk", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OBTChannelAssignment(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannels(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelID(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAlias(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TypeIIChannelSetup(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAlias(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAlias(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouch(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Digital(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Labtool(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Broadband(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x000ECDB4 File Offset: 0x000EAFB4
		protected TrunkingSystem(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鳇룉맋ꃍ믏믑뫓뇕觙ꗛ귝铟蟡解", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSYSTEM;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛ꏟ跡解雥蟧蓩觫胭蓯껱ꃳ蓵跷铹韻韽滿攁␃䔅朇搉樋服眏朑易眕気猙猛瀝簟瘡嘣匥䘧䄩䔫䀭圯ሱ朳伵䬷丹夻匽᰿ᙁ㙃㍅♇ⅉ╋⁍㝏őⵓ╕ⱗ㽙ㅛ灝ᡟ͡ॣ੥", a_);
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x000ECE08 File Offset: 0x000EB008
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General General
		{
			get
			{
				short num = (short)2113878817;
				short num2 = num;
				num = (short)1249458977;
				switch (num2 == num)
				{
				}
				num = (short)639827968;
				if (num != 0)
				{
				}
				num = (short)1814102017;
				if (num != 0)
				{
				}
				num = (short)1988689920;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General)base[10157];
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x000ECEC4 File Offset: 0x000EB0C4
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OBTChannelAssignment OBTChannelAssignment
		{
			get
			{
				short num = (short)838385651;
				short num2 = num;
				num = (short)1979170803;
				switch (num2 == num)
				{
				}
				num = (short)981204993;
				if (num != 0)
				{
				}
				num = (short)48496640;
				if (num != 0)
				{
				}
				num = (short)44564480;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OBTChannelAssignment)base[10167];
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x000ECF7C File Offset: 0x000EB17C
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannels ControlChannels
		{
			get
			{
				short num = (short)210020268;
				short num2 = num;
				num = (short)1366665132;
				switch (num2 == num)
				{
				}
				num = (short)345178113;
				if (num != 0)
				{
				}
				num = (short)2081095680;
				if (num != 0)
				{
				}
				num = (short)1604780032;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannels)base[10169];
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x000ED038 File Offset: 0x000EB238
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelID ASTRO25ChannelID
		{
			get
			{
				short num = (short)139923278;
				short num2 = num;
				num = (short)2038435662;
				switch (num2 == num)
				{
				}
				num = (short)1391853569;
				if (num != 0)
				{
				}
				num = (short)1083113472;
				if (num != 0)
				{
				}
				num = (short)27721728;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelID)base[10160];
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x000ED0F0 File Offset: 0x000EB2F0
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features Features
		{
			get
			{
				short num = (short)1561027890;
				short num2 = num;
				num = (short)148071730;
				switch (num2 == num)
				{
				}
				num = (short)199294976;
				if (num != 0)
				{
				}
				num = (short)2086862849;
				if (num != 0)
				{
				}
				num = (short)931725312;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features)base[10154];
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000ED1AC File Offset: 0x000EB3AC
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAlias MessageAlias
		{
			get
			{
				short num = (short)1080363517;
				short num2 = num;
				num = (short)558828029;
				switch (num2 == num)
				{
				}
				num = (short)1782382593;
				if (num != 0)
				{
				}
				num = (short)200671232;
				if (num != 0)
				{
				}
				num = (short)397017088;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAlias)base[10163];
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x000ED268 File Offset: 0x000EB468
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TypeIIChannelSetup TypeIIChannelSetup
		{
			get
			{
				short num = (short)77361337;
				short num2 = num;
				num = (short)1488220345;
				switch (num2 == num)
				{
				}
				num = (short)913768448;
				if (num != 0)
				{
				}
				num = (short)1733820417;
				if (num != 0)
				{
				}
				num = (short)1385627648;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TypeIIChannelSetup)base[10155];
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x000ED320 File Offset: 0x000EB520
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAlias StatusAlias
		{
			get
			{
				short num = (short)1626043855;
				short num2 = num;
				num = (short)154170831;
				switch (num2 == num)
				{
				}
				num = (short)1700659201;
				if (num != 0)
				{
				}
				num = (short)661979136;
				if (num != 0)
				{
				}
				num = (short)1809645568;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAlias)base[10173];
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x000ED3D8 File Offset: 0x000EB5D8
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAlias SiteAlias
		{
			get
			{
				short num = (short)748590090;
				short num2 = num;
				num = (short)1091081226;
				switch (num2 == num)
				{
				}
				num = (short)1652293632;
				if (num != 0)
				{
				}
				num = (short)2127495169;
				if (num != 0)
				{
				}
				num = (short)509018112;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAlias)base[10171];
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x000ED494 File Offset: 0x000EB694
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouch OneTouch
		{
			get
			{
				short num = (short)117645790;
				short num2 = num;
				num = (short)1182671326;
				switch (num2 == num)
				{
				}
				num = (short)516685825;
				if (num != 0)
				{
				}
				num = (short)1073152000;
				if (num != 0)
				{
				}
				num = (short)1749417984;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouch)base[10165];
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x000ED54C File Offset: 0x000EB74C
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26 ASTRO26
		{
			get
			{
				short num = (short)149359670;
				short num2 = num;
				num = (short)196873270;
				switch (num2 == num)
				{
				}
				num = (short)2094137344;
				if (num != 0)
				{
				}
				num = (short)1504837633;
				if (num != 0)
				{
				}
				num = (short)128909312;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26)base[10162];
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x000ED604 File Offset: 0x000EB804
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Digital Digital
		{
			get
			{
				short num = (short)502071582;
				short num2 = num;
				num = (short)1117913374;
				switch (num2 == num)
				{
				}
				num = (short)1165492224;
				if (num != 0)
				{
				}
				num = (short)1929248769;
				if (num != 0)
				{
				}
				num = (short)845217792;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Digital)base[10159];
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x000ED6BC File Offset: 0x000EB8BC
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey SecureMultikey
		{
			get
			{
				short num = (short)781533370;
				short num2 = num;
				num = (short)986792122;
				switch (num2 == num)
				{
				}
				num = (short)331546625;
				if (num != 0)
				{
				}
				num = (short)1120993280;
				if (num != 0)
				{
				}
				num = (short)212729856;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey)base[10158];
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x000ED774 File Offset: 0x000EB974
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Labtool Labtool
		{
			get
			{
				short num = (short)1431178414;
				short num2 = num;
				num = (short)667290798;
				switch (num2 == num)
				{
				}
				num = (short)1898250241;
				if (num != 0)
				{
				}
				num = (short)1990459392;
				if (num != 0)
				{
				}
				num = (short)1302200320;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Labtool)base[10156];
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x000ED82C File Offset: 0x000EBA2C
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Broadband Broadband
		{
			get
			{
				short num = (short)1996643273;
				short num2 = num;
				num = (short)914119625;
				switch (num2 == num)
				{
				}
				num = (short)324272128;
				if (num != 0)
				{
				}
				num = (short)1893728257;
				if (num != 0)
				{
				}
				num = (short)1264386048;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Broadband)base[10889];
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000ED8E4 File Offset: 0x000EBAE4
		public static global::AcpCommonLib.IAcpFeatureNode GetTrunkingSystem()
		{
			switch (0)
			{
			case 0:
				goto IL_47;
			}
			short num;
			int num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				num = (short)629604353;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return result;
				case 1:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1981022210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2064)[0];
					num = (short)1593178673;
					short num3 = num;
					num = (short)141752881;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)384827392;
						short num4 = num;
						break;
					}
					}
					num = (short)258277376;
					if (num != 0)
					{
					}
					num = (short)8585219;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2064)[0];
					num = (short)1516175360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				}
				goto IL_47;
			}
			return result;
			IL_47:
			result = null;
			num = (short)907018241;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
