using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003DB RID: 987
	[global::System.Serializable]
	public class ControlHeadO2 : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06008B7B RID: 35707 RVA: 0x0082A4E8 File Offset: 0x008286E8
		public ControlHeadO2(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 7;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诇ꗉꋋ뫍ꋏ뷑룓郗뿙뷛뫝샟쿡쓣ꧥ\udae7", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO2;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛ꏟ跡解雥蟧蓩觫胭蓯껱꛳韵鳷鏹鏻\udefd䗿瀁挃椅昇攉愋服猏愑㐓唕眗琙稛眝䜟圡嘣䜥尧䌩䌫䀭氯焱嬳堵䰷䠹医刽㌿ṁ݃⥅♇㹉㹋⅍㱏牑᱓㍕㥗㹙籛獝䁟ⵡ噣㩥⭧թɫᩭɯᵱᡳ㹵ᵷ᭹᡻ㅽ뉿겁ﲃ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2GeneralExpander(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsExpander(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x0082A56C File Offset: 0x0082876C
		protected ControlHeadO2(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裊ꋌꇎꗐꇒ뫔믖律鏚룜뻞藠쏢죤쟦ꛨ\ud9ea", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO2;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴ꗶ飸鿺铼郾℀䘂眄怆昈攊戌戎砐瀒昔㜖娘琚猜礞䠠䐢値唦䠨弪䐬䀮弰漲瘴堶圸伺似倾ⵀあ᥄ц♈╊㥌㵎㹐㽒畔ὖ㱘㩚㥜罞䱠䍢⩤啦㕨⡪ɬŮհŲᩴ᭶ㅸṺᱼ᭾캀놂ꮄﾆ", a_);
		}

		// Token: 0x170046AB RID: 18091
		// (get) Token: 0x06008B7D RID: 35709 RVA: 0x0082A5C0 File Offset: 0x008287C0
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2GeneralExpander O2GeneralExpander
		{
			get
			{
				short num = (short)182869920;
				short num2 = num;
				num = (short)101998496;
				switch (num2 == num)
				{
				}
				num = (short)2132213760;
				short num3 = num;
				num = (short)1288503296;
				if (num != 0)
				{
				}
				num = (short)1018363905;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2GeneralExpander)base[10723];
			}
		}

		// Token: 0x170046AC RID: 18092
		// (get) Token: 0x06008B7E RID: 35710 RVA: 0x0082A67C File Offset: 0x0082887C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob O2MultiFunctionKnob
		{
			get
			{
				short num = (short)2074237261;
				short num2 = num;
				num = (short)582375757;
				switch (num2 == num)
				{
				}
				num = (short)692453376;
				short num3 = num;
				num = (short)1258487809;
				if (num != 0)
				{
				}
				num = (short)415105024;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob)base[10721];
			}
		}

		// Token: 0x170046AD RID: 18093
		// (get) Token: 0x06008B7F RID: 35711 RVA: 0x0082A738 File Offset: 0x00828938
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsExpander O2NavigationControlsExpander
		{
			get
			{
				short num = (short)2078156035;
				short num2 = num;
				num = (short)797058307;
				switch (num2 == num)
				{
				}
				num = (short)1285685248;
				short num3 = num;
				num = (short)90243073;
				if (num != 0)
				{
				}
				num = (short)2028732416;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsExpander)base[10722];
			}
		}

		// Token: 0x06008B80 RID: 35712 RVA: 0x0082A7F4 File Offset: 0x008289F4
		public static global::AcpCommonLib.IAcpFeatureNode GetControlHeadO2()
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
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1869283330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(4115)[0];
					num2 = (short)2013069315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1414332417;
					if (num2 != 0)
					{
					}
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4115)[0];
					num2 = (short)2024174205;
					short num3 = num2;
					num2 = (short)407990909;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)2025193472;
						if (num2 != 0)
						{
						}
						num2 = (short)183304192;
						short num4 = num2;
						num2 = (short)277676032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					return result;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)1199177729;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
