using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000341 RID: 833
	[global::System.Serializable]
	public class DEK : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06007FFD RID: 32765 RVA: 0x0075AE94 File Offset: 0x00759094
		public DEK(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("諍闏駑", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DEK;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ꣹鷻髽槿洁␃䌅稇洉挋怍缏缑紓甕欗㨙弛焝丟䐡䴣䄥崧堩䴫娭夯崱娳樵笷唹刻䨽㈿ⵁ⡃㕅ᑇ้ोՍ౏ᙑᅓᵕ癗≙㵛㍝౟", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DEK.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIP(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessage(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMode(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatus(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x0075AF30 File Offset: 0x00759130
		protected DEK(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诎铐飒", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DEK;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4ꓦ蛨蛪鷬胮鿰雲鯴菶ꗸꧺ鳼鯾栀氂┄䈆笈氊戌愎縐縒簔琖樘㬚帜瀞传䔢䰤䀦尨太䰬嬮堰尲嬴欶稸吺匼䬾㍀ⱂ⥄㑆ᕈཊࡌю൐ᝒၔ᱖睘⍚㱜㉞ൠ", a_);
		}

		// Token: 0x17004173 RID: 16755
		// (get) Token: 0x06007FFF RID: 32767 RVA: 0x0075AF84 File Offset: 0x00759184
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.General General
		{
			get
			{
				short num = (short)574119691;
				short num2 = num;
				num = (short)533946123;
				switch (num2 == num)
				{
				}
				num = (short)84869120;
				short num3 = num;
				num = (short)313262081;
				if (num != 0)
				{
				}
				num = (short)1531510784;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.General)base[10232];
			}
		}

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x06008000 RID: 32768 RVA: 0x0075B040 File Offset: 0x00759240
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIP DEKVIP
		{
			get
			{
				short num = (short)1483066931;
				short num2 = num;
				num = (short)1777651251;
				switch (num2 == num)
				{
				}
				num = (short)2094268416;
				short num3 = num;
				num = (short)694484993;
				if (num != 0)
				{
				}
				num = (short)1479737344;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIP)base[10233];
			}
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x06008001 RID: 32769 RVA: 0x0075B0FC File Offset: 0x007592FC
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessage DirectMessage
		{
			get
			{
				short num = (short)1673393860;
				short num2 = num;
				num = (short)911668932;
				switch (num2 == num)
				{
				}
				num = (short)1618739200;
				short num3 = num;
				num = (short)29360128;
				if (num != 0)
				{
				}
				num = (short)860946433;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessage)base[10229];
			}
		}

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x06008002 RID: 32770 RVA: 0x0075B1B8 File Offset: 0x007593B8
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMode DirectMode
		{
			get
			{
				short num = (short)1436760720;
				short num2 = num;
				num = (short)1892891280;
				switch (num2 == num)
				{
				}
				num = (short)1996095488;
				short num3 = num;
				num = (short)1394343937;
				if (num != 0)
				{
				}
				num = (short)1103298560;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMode)base[10220];
			}
		}

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x06008003 RID: 32771 RVA: 0x0075B270 File Offset: 0x00759470
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatus DirectStatus
		{
			get
			{
				short num = (short)478999578;
				short num2 = num;
				num = (short)224916506;
				switch (num2 == num)
				{
				}
				num = (short)556793856;
				short num3 = num;
				num = (short)526647297;
				if (num != 0)
				{
				}
				num = (short)1014824960;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatus)base[10219];
			}
		}

		// Token: 0x06008004 RID: 32772 RVA: 0x0075B328 File Offset: 0x00759528
		public static global::AcpCommonLib.IAcpFeatureNode GetDEK()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)538771457;
					if (num2 != 0)
					{
					}
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2129)[0];
					num2 = (short)658898947;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						result = global::AcpCommonLib.FeatureManager.GetFeature(2129)[0];
						num2 = (short)164167682;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1078676416;
					short num3 = num2;
					num2 = (short)1100303296;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1249574912;
						if (num2 != 0)
						{
						}
						num2 = (short)718274560;
						short num4 = num2;
						num2 = (short)867565568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					return result;
				case 3:
					return result;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)1506082817;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
