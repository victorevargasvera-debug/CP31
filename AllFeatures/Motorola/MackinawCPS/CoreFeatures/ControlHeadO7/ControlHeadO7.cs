using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x02000397 RID: 919
	[global::System.Serializable]
	public class ControlHeadO7 : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060086B6 RID: 34486 RVA: 0x007DA4B0 File Offset: 0x007D86B0
		public ControlHeadO7(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 6;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓆ꛈꗊ만뷎뻐뿒鿖볘뫚맜￞쳠쏢ꫤ탦", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO7;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚鳞軠転闤裦蟨軪菬鯮귰ꇲ铴鏶郸铺\uddfc뫾猀搂樄椆昈昊搌氎成㌒嘔砖眘級琜砞吠儢䐤匦䀨䐪䌬献爰尲嬴䌶䬸吺儼䰾ᵀB⩄⥆㵈㥊≌⍎煐᭒ご㙖㵘筚灜罞⹠呢㥤⑦٨ժᥬᵮṰὲ㵴ቶᡸὺ㉼䡾꾀ﮂ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7GeneralExpander(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButton(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsExpander(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060086B7 RID: 34487 RVA: 0x007DA540 File Offset: 0x007D8740
		protected ControlHeadO7(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 16;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鋐볒믔ꏖꯘ듚뇜￞ꧠ蛢蓤菦짨웪췬ꃮ웰", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO7;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6ꫨ蓪胬鿮黰鷲郴駶跸ꟺ꿼黾攀樂樄✆䰈礊樌怎缐簒研縖稘栚㴜尞丠䴢䌤並丨帪弬丮䔰娲娴夶攸砺刼儾㕀ㅂ⩄⭆㩈ᝊ์⁎㽐❒❔㡖㕘筚ᕜ㩞`ݢ䕤䩦䥨⑪婬㍮㉰ᱲ᭴Ͷ୸ᑺᅼ㝾좆뺈ꖊﲐﾒ", a_);
		}

		// Token: 0x17004487 RID: 17543
		// (get) Token: 0x060086B8 RID: 34488 RVA: 0x007DA594 File Offset: 0x007D8794
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7GeneralExpander O7GeneralExpander
		{
			get
			{
				short num = (short)758652372;
				short num2 = num;
				num = (short)302325204;
				switch (num2 == num)
				{
				}
				num = (short)1321336833;
				if (num != 0)
				{
				}
				num = (short)1285554176;
				if (num != 0)
				{
				}
				num = (short)1622605824;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7GeneralExpander)base[10719];
			}
		}

		// Token: 0x17004488 RID: 17544
		// (get) Token: 0x060086B9 RID: 34489 RVA: 0x007DA64C File Offset: 0x007D884C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButton O7DataButton
		{
			get
			{
				short num = (short)541941784;
				short num2 = num;
				num = (short)1444241432;
				switch (num2 == num)
				{
				}
				num = (short)850460672;
				if (num != 0)
				{
				}
				num = (short)1209794561;
				if (num != 0)
				{
				}
				num = (short)378404864;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButton)base[10717];
			}
		}

		// Token: 0x17004489 RID: 17545
		// (get) Token: 0x060086BA RID: 34490 RVA: 0x007DA708 File Offset: 0x007D8908
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob O7MultiFunctionKnob
		{
			get
			{
				short num = (short)1610905503;
				short num2 = num;
				num = (short)761296799;
				switch (num2 == num)
				{
				}
				num = (short)737411073;
				if (num != 0)
				{
				}
				num = (short)738066432;
				if (num != 0)
				{
				}
				num = (short)365559808;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob)base[10718];
			}
		}

		// Token: 0x1700448A RID: 17546
		// (get) Token: 0x060086BB RID: 34491 RVA: 0x007DA7C0 File Offset: 0x007D89C0
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsExpander O7NavigationControlsExpander
		{
			get
			{
				short num = (short)952370502;
				short num2 = num;
				num = (short)391775558;
				switch (num2 == num)
				{
				}
				num = (short)1733820416;
				if (num != 0)
				{
				}
				num = (short)559874049;
				if (num != 0)
				{
				}
				num = (short)35782656;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsExpander)base[10727];
			}
		}

		// Token: 0x060086BC RID: 34492 RVA: 0x007DA87C File Offset: 0x007D8A7C
		public static global::AcpCommonLib.IAcpFeatureNode GetControlHeadO7()
		{
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)2116757646;
					short num2 = num;
					num = (short)909518990;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)633143296;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							return result;
						case 1:
							if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
							{
								num = (short)939982851;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = global::AcpCommonLib.FeatureManager.GetFeature(4114)[0];
							num = (short)1118830594;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return result;
						case 3:
						{
							result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4114)[0];
							num = (short)424214528;
							short num4 = num;
							num = (short)278200320;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_6B;
					}
				}
				IL_6B:
				num = (short)1258029057;
				if (num != 0)
				{
				}
				result = null;
				num = (short)1626079233;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			return result;
		}
	}
}
