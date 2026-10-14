using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MenuItems
{
	// Token: 0x020002F7 RID: 759
	[global::System.Serializable]
	public class MenuItems : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06007A44 RID: 31300 RVA: 0x006F5368 File Offset: 0x006F3568
		public MenuItems(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菍뗏병ꇓ釗껙맛돝鏟", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MENUITEMS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ꣹鷻髽槿洁␃䌅稇洉挋怍缏缑紓甕欗㨙弛焝丟䐡䴣䄥崧堩䴫娭夯崱娳樵笷唹刻䨽㈿ⵁ⡃㕅ᑇ݉⥋⁍╏牑ᵓ≕㵗㝙⽛ɝⵟݡ੣፥Ⅷṩ५ͭͯ山౳᝵ᕷᙹ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x006F53D4 File Offset: 0x006F35D4
		protected MenuItems(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛊꣌ꇎꓐ鳔ꏖ볘뛚껜", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MENUITEMS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴ꗶ飸鿺铼郾℀䘂眄怆昈攊戌戎砐瀒昔㜖娘琚猜礞䠠䐢値唦䠨弪䐬䀮弰漲瘴堶圸伺似倾ⵀあ᥄੆ⱈ╊㡌潎ᡐ❒ご㩖⩘ݚၜ㩞འᙢⱤ፦౨٪Ṭ䅮॰ቲᡴ᭶", a_);
		}

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x06007A46 RID: 31302 RVA: 0x006F5428 File Offset: 0x006F3628
		public global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General General
		{
			get
			{
				short num = (short)631410988;
				short num2 = num;
				num = (short)1619824940;
				switch (num2 == num)
				{
				}
				num = (short)1078525952;
				if (num != 0)
				{
				}
				num = (short)1540358145;
				if (num != 0)
				{
				}
				num = (short)1101791232;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General)base[10024];
			}
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x006F54E0 File Offset: 0x006F36E0
		public static global::AcpCommonLib.IAcpFeatureNode GetMenuItems()
		{
			switch (0)
			{
			case 0:
				goto IL_6C;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				num = (short)1079705119;
				short num2 = num;
				num = (short)1765735967;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1695285248;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_11E;
					case 1:
						return result;
					case 2:
						return result;
					case 3:
					{
						num = (short)286130176;
						short num4 = num;
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)498728961;
							if (num != 0)
							{
							}
							num = (short)690159616;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2088)[0];
						num = (short)688193538;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6C;
				}
				IL_11E:
				result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2088)[0];
				num = (short)739901441;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_6C:
			result = null;
			num = (short)783155203;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
