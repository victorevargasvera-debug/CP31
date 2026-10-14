using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002B4 RID: 692
	[global::System.Serializable]
	public class Switches : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060074E0 RID: 29920 RVA: 0x00697B80 File Offset: 0x00695D80
		public Switches(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 11;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿋맍맏ꛑ럓뻕뷗꧙", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SWITCHES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("跋ꋍ볏铑뇓럕곗꿙껛믝鏟\ud9e1꟣觥藧髩菫胭闯鳱胳ꫵ꫷鯹飻韽濿∁䄃琅漇攉戋愍紏笑眓攕㠗夙猛瀝䘟䬡䌣匥娧䬩堫䜭弯就栳电圷吹䠻䰽⼿⹁㝃ᩅᭇ㵉╋㩍㍏㩑ㅓ╕їख़⭛㝝ᑟšౣͥ᭧䑩ᑫ཭ᵯṱ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Switches.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTable(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTable(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Switches.MultiFunctionKnob(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x00697C28 File Offset: 0x00695E28
		protected Switches(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 16;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苐ꓒ볔ꏖ뫘돚룜곞", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SWITCHES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6ꫨ蓪胬鿮黰鷲郴駶跸ꟺ꿼黾攀樂樄✆䰈礊樌怎缐簒研縖稘栚㴜尞丠䴢䌤並丨帪弬丮䔰娲娴夶攸砺刼儾㕀ㅂ⩄⭆㩈ᝊṌ㡎㡐❒㙔㽖㱘⡚Ŝ౞ᙠ੢ᅤѦŨ๪Ṭ䅮॰ቲᡴ᭶", a_);
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x060074E2 RID: 29922 RVA: 0x00697C7C File Offset: 0x00695E7C
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.General General
		{
			get
			{
				short num = (short)826352349;
				short num2 = num;
				num = (short)1760699101;
				switch (num2 == num)
				{
				}
				num = (short)1087111169;
				if (num != 0)
				{
				}
				num = (short)550109184;
				if (num != 0)
				{
				}
				num = (short)1768882176;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.General)base[10081];
			}
		}

		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x060074E3 RID: 29923 RVA: 0x00697D34 File Offset: 0x00695F34
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches ConventionalSwitches
		{
			get
			{
				short num = (short)451565509;
				short num2 = num;
				num = (short)565073861;
				switch (num2 == num)
				{
				}
				num = (short)576847873;
				if (num != 0)
				{
				}
				num = (short)2127167488;
				if (num != 0)
				{
				}
				num = (short)1601372160;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches)base[10087];
			}
		}

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x060074E4 RID: 29924 RVA: 0x00697DF0 File Offset: 0x00695FF0
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches TrunkingSwitches
		{
			get
			{
				short num = (short)806306907;
				short num2 = num;
				num = (short)616318043;
				switch (num2 == num)
				{
				}
				num = (short)2100494337;
				if (num != 0)
				{
				}
				num = (short)977207296;
				if (num != 0)
				{
				}
				num = (short)131923968;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches)base[10088];
			}
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x060074E5 RID: 29925 RVA: 0x00697EB0 File Offset: 0x006960B0
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTable ConventionalSwitchTable
		{
			get
			{
				short num = (short)976127507;
				short num2 = num;
				num = (short)332760595;
				switch (num2 == num)
				{
				}
				num = (short)1375797249;
				if (num != 0)
				{
				}
				num = (short)1973551104;
				if (num != 0)
				{
				}
				num = (short)1889796096;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTable)base[10085];
			}
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x060074E6 RID: 29926 RVA: 0x00697F68 File Offset: 0x00696168
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTable TrunkingSwitchTable
		{
			get
			{
				short num = (short)1002828229;
				short num2 = num;
				num = (short)1866461637;
				switch (num2 == num)
				{
				}
				num = (short)459538433;
				if (num != 0)
				{
				}
				num = (short)293273600;
				if (num != 0)
				{
				}
				num = (short)2024996864;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTable)base[10083];
			}
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x060074E7 RID: 29927 RVA: 0x00698020 File Offset: 0x00696220
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.MultiFunctionKnob MultiFunctionKnob
		{
			get
			{
				short num = (short)303594358;
				short num2 = num;
				num = (short)1282767734;
				switch (num2 == num)
				{
				}
				num = (short)166133761;
				if (num != 0)
				{
				}
				num = (short)870383616;
				if (num != 0)
				{
				}
				num = (short)1365508096;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.MultiFunctionKnob)base[10637];
			}
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x006980D8 File Offset: 0x006962D8
		public static global::AcpCommonLib.IAcpFeatureNode GetSwitches()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FE;
				case 1:
					goto IL_CF;
				case 2:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2038)[0];
					num2 = (short)751566848;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)994115585;
					if (num2 != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1572143106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2038)[0];
					num2 = (short)1760034817;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_CF:
			return result;
			IL_FE:
			num2 = (short)975949413;
			short num3 = num2;
			num2 = (short)519818853;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)340525056;
				if (num2 != 0)
				{
				}
				break;
			}
			return result;
			IL_20:
			num2 = (short)2090074112;
			short num4 = num2;
			result = null;
			num2 = (short)1517223939;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
