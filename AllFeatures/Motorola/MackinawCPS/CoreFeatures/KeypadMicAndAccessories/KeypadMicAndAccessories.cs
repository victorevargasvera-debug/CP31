using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x02000315 RID: 789
	[global::System.Serializable]
	public class KeypadMicAndAccessories : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06007C0A RID: 31754 RVA: 0x0071B42C File Offset: 0x0071962C
		public KeypadMicAndAccessories(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓎듐꫒ꗔ뛖뷘ﯚ郜뛞苠쏢ꓤ触跨쯪곬賮鋰雲蛴蓶雸觺铼髾爀", a_);
			base.UIName = global::CommonResources.AcgResources.ID_KEYPADMICANDACCESSORIES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4ꓦ蛨蛪鷬胮鿰雲鯴菶ꗸꧺ鳼鯾栀氂┄䈆笈氊戌愎縐縒簔琖樘㬚帜瀞传䔢䰤䀦尨太䰬嬮堰尲嬴欶稸吺匼䬾㍀ⱂ⥄㑆ᕈJ⡌㙎⅐㉒ㅔ睖ᑘ㉚㹜罞⁠ൢŤ䝦⡨ࡪ๬੮ɰrᩴնၸṺ๼⍾쪀ﲄ삌튒ﮔ\ud898ﺜ爵튠킢쪤햦삨캪\udeac膮즰튲\ud8b4\udbb6", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.Data(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsExpander(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x0071B4B0 File Offset: 0x007196B0
		protected KeypadMicAndAccessories(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賆곈닊뷌껎뗐飔뻖뫘ﯚ鳜뇞藠쏢ꓤ蓦諨軪黬鳮黰臲鳴鋶諸", a_);
			base.UIName = global::CommonResources.AcgResources.ID_KEYPADMICANDACCESSORIES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚鳞軠転闤裦蟨軪菬鯮귰ꇲ铴鏶郸铺\uddfc뫾猀搂樄椆昈昊搌氎成㌒嘔砖眘級琜砞吠儢䐤匦䀨䐪䌬献爰尲嬴䌶䬸吺儼䰾ᵀࡂ⁄㹆㥈⩊⥌潎᱐㩒㙔睖ᡘ㕚㥜罞⁠b٤ɦᩨᡪɬᵮᡰᙲٴ⭶㉸ṺѼཾ좄쪊킐좠욢횤覦톨쪪사쎮", a_);
		}

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x06007C0C RID: 31756 RVA: 0x0071B504 File Offset: 0x00719704
		public global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.General General
		{
			get
			{
				short num = (short)1100351408;
				short num2 = num;
				num = (short)1961428912;
				switch (num2 == num)
				{
				}
				num = (short)1537671168;
				short num3 = num;
				num = (short)662110209;
				if (num != 0)
				{
				}
				num = (short)1259077632;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.General)base[10231];
			}
		}

		// Token: 0x17003F9E RID: 16286
		// (get) Token: 0x06007C0D RID: 31757 RVA: 0x0071B5BC File Offset: 0x007197BC
		public global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.Data Data
		{
			get
			{
				short num = (short)725155841;
				if (num != 0)
				{
				}
				num = (short)584432640;
				short num2 = num;
				num = (short)742308864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2120744960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)960495616;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.Data)base[10228];
			}
		}

		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x06007C0E RID: 31758 RVA: 0x0071B674 File Offset: 0x00719874
		public global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsExpander KMANavigationControlsExpander
		{
			get
			{
				short num = (short)1405869107;
				short num2 = num;
				num = (short)1792728115;
				switch (num2 == num)
				{
				}
				num = (short)828768256;
				short num3 = num;
				num = (short)1838743553;
				if (num != 0)
				{
				}
				num = (short)689897472;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsExpander)base[10753];
			}
		}

		// Token: 0x06007C0F RID: 31759 RVA: 0x0071B730 File Offset: 0x00719930
		public static global::AcpCommonLib.IAcpFeatureNode GetKeypadMicAndAccessories()
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)1842610177;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2128)[0];
						num2 = (short)1616510979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							result = global::AcpCommonLib.FeatureManager.GetFeature(2128)[0];
							num2 = (short)140967938;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1102227114;
						short num3 = num2;
						num2 = (short)74884778;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22;
						default:
						{
							num2 = (short)1552220160;
							if (num2 != 0)
							{
							}
							num2 = (short)1009123328;
							short num4 = num2;
							num2 = (short)1712848896;
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
			}
			IL_20:
			result = null;
			IL_22:
			num2 = (short)1364852737;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
