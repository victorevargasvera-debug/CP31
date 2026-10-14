using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003C9 RID: 969
	[global::System.Serializable]
	public class ControlHeadO3 : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06008A4D RID: 35405 RVA: 0x008168BC File Offset: 0x00814ABC
		public ControlHeadO3(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軌ꃎ뿐꟒꟔룖뗘ﯚ關뫞胠蟢엤쫦짨ꓪ\udeec", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO3;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶꯸髺駼雾渀⌂䀄甆済搊挌怎簐稒瘔搖㤘堚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲椴琶嘸唺䤼䴾⹀⽂㙄ᭆੈ⑊⍌㭎⍐㱒㥔睖ᅘ㹚㱜㭞䅠乢䕤⡦婨㝪⹬nὰݲݴᡶᕸ㍺᡼Ṿ첂뚄ꦆ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.Data(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsExpander(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x00816940 File Offset: 0x00814B40
		protected ControlHeadO3(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏏뷑뫓ꋕ꫗뗙냛ﻝ꣟蟡藣若죧쟩쳫ꇭ쏯", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO3;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹껻鿽擿欁欃★䴇砉欋愍縏紑礓缕笗椙㰛崝伟䰡䈣伥伧弩師伭䐯嬱嬳堵搷礹医倽㐿ぁ⭃⩅㭇ᙉཋ⅍㹏♑♓㥕㑗穙ᑛ㭝ş١䑣䭥䡧╩彫㉭㍯ᵱᩳɵ੷ᕹၻ㙽즅뮇ꒉﶏﺑ", a_);
		}

		// Token: 0x17004627 RID: 17959
		// (get) Token: 0x06008A4F RID: 35407 RVA: 0x00816994 File Offset: 0x00814B94
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.General General
		{
			get
			{
				short num = (short)1099421972;
				short num2 = num;
				num = (short)237820180;
				switch (num2 == num)
				{
				}
				num = (short)1630601216;
				short num3 = num;
				num = (short)1535901697;
				if (num != 0)
				{
				}
				num = (short)1784152064;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.General)base[10235];
			}
		}

		// Token: 0x17004628 RID: 17960
		// (get) Token: 0x06008A50 RID: 35408 RVA: 0x00816A4C File Offset: 0x00814C4C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.Data Data
		{
			get
			{
				short num = (short)45110083;
				short num2 = num;
				num = (short)1345278787;
				switch (num2 == num)
				{
				}
				num = (short)879296512;
				short num3 = num;
				num = (short)736362496;
				if (num != 0)
				{
				}
				num = (short)1016922113;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.Data)base[10234];
			}
		}

		// Token: 0x17004629 RID: 17961
		// (get) Token: 0x06008A51 RID: 35409 RVA: 0x00816B08 File Offset: 0x00814D08
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsExpander O3NavigationControlsExpander
		{
			get
			{
				short num = (short)490169210;
				short num2 = num;
				num = (short)1986290554;
				switch (num2 == num)
				{
				}
				num = (short)229376000;
				short num3 = num;
				num = (short)1659699201;
				if (num != 0)
				{
				}
				num = (short)1629028352;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsExpander)base[10732];
			}
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x00816BC0 File Offset: 0x00814DC0
		public static global::AcpCommonLib.IAcpFeatureNode GetControlHeadO3()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)850591744;
					short num3 = num2;
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2127)[0];
					num2 = (short)111607810;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1100152832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2127)[0];
					num2 = (short)1224867843;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					return result;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			num2 = (short)1043601265;
			short num4 = num2;
			num2 = (short)1144067953;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)596770817;
				if (num2 != 0)
				{
				}
				num2 = (short)1350565888;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)1729429505;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
