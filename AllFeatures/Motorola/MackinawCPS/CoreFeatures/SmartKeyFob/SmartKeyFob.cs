using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SmartKeyFob
{
	// Token: 0x020002CA RID: 714
	[global::System.Serializable]
	public class SmartKeyFob : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06007702 RID: 30466 RVA: 0x006BA1E8 File Offset: 0x006B83E8
		public SmartKeyFob(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鷍뷏돑ꛓꋕ釙맛꟝샟ꓡ诣蓥죧꣩駫髭蓯鷱髳藵", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SMARTKEYFOBBUTTONS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ꣹鷻髽槿洁␃䌅稇洉挋怍缏缑紓甕欗㨙弛焝丟䐡䴣䄥崧堩䴫娭夯崱娳樵笷唹刻䨽㈿ⵁ⡃㕅ᑇ᥉⅋⽍≏♑瑓ᵕ㵗⍙籛ᡝཟa㡣㕥է୩ṫᩭ㭯᝱൳ふ᝷᡹剻ٽ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x006BA254 File Offset: 0x006B8454
		protected SmartKeyFob(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黌ꋎ냐ꇒꇔ鋘뻚ꓜ￞꟠賢蟤쟦ꯨ黪駬鯮黰鷲蛴", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SMARTKEYFOBBUTTONS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶꯸髺駼雾渀⌂䀄甆済搊挌怎簐稒瘔搖㤘堚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲椴琶嘸唺䤼䴾⹀⽂㙄ᭆᩈ♊ⱌ㵎═獒Ṕ㉖⁘筚᭜ぞ͠㽢㙤੦ࡨᥪᥬ⑮ᑰੲ㍴ᡶ᭸啺ռṾ", a_);
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x06007704 RID: 30468 RVA: 0x006BA2A8 File Offset: 0x006B84A8
		public global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.General General
		{
			get
			{
				short num = (short)636083874;
				short num2 = num;
				num = (short)157277858;
				switch (num2 == num)
				{
				}
				num = (short)1844641793;
				if (num != 0)
				{
				}
				num = (short)1766195200;
				short num3 = num;
				num = (short)1601765376;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.General)base[10747];
			}
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x006BA364 File Offset: 0x006B8564
		public static global::AcpCommonLib.IAcpFeatureNode GetSmartKeyFob()
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
					return result;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)1123024896;
					short num3 = num2;
					num2 = (short)760029091;
					short num4 = num2;
					num2 = (short)472653731;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1514733568;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4130)[0];
						num2 = (short)1997864961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1505886210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(4130)[0];
					num2 = (short)52101121;
					if (num2 != 0)
					{
					}
					num2 = (short)152109056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)1812856835;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
