using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x02000535 RID: 1333
	[global::System.Serializable]
	public class MPLConfiguration : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600B1BC RID: 45500 RVA: 0x00A50DEC File Offset: 0x00A4EFEC
		public MPLConfiguration(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黒藔鯖律飚닜뇞蟠諢苤鋦鯨諪駬蛮黰鷲", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MPLCONFIGURATION;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鋒맔믖鿘뻚볜ꯞ铠釢胤铦틨꣪苬苮臰鳲鯴鋶韸迺ꇼ볾渀洂猄戆月缊搌怎缐爒礔㜖娘琚猜礞䠠䐢値唦䠨弪䐬䀮弰漲破朶甸ᬺ縼倾⽀╂ⱄ⁆㱈㥊ⱌ㭎㡐㱒㭔ୖᑘ୚ᅜᱞ๠ൢͤ๦๨ṪὬ๮հᩲᩴ᥶坸ͺᱼቾ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x00A50E70 File Offset: 0x00A4F070
		protected MPLConfiguration(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 17;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿑蓓髕駙돛냝蛟诡菣鏥髧诩飫蟭鿯鳱", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MPLCONFIGURATION;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鏑룓뫕黗뿙뷛ꫝ闟郡臣闥폧ꧩ菫菭胯鷱髳鏵雷軹ꃻ뷽濿氁爃挅昇縉攋愍縏猑砓㘕嬗甙爛砝䤟䔡儣吥䤧帩䔫䄭帯渱礳昵琷ᨹ缻儽⸿⑁ⵃⅅ㵇㡉ⵋ㩍㥏㵑㩓੕ᕗਖ਼ၛᵝཟౡɣཥཧὩṫ཭ѯ᭱᭳ᡵ噷ɹᵻ፽", a_);
		}

		// Token: 0x1700591E RID: 22814
		// (get) Token: 0x0600B1BE RID: 45502 RVA: 0x00A50EC4 File Offset: 0x00A4F0C4
		public global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.General General
		{
			get
			{
				short num = (short)1066532865;
				if (num != 0)
				{
				}
				num = (short)199919878;
				short num2 = num;
				num = (short)1031571718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)570949632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1375600640;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.General)base[10194];
			}
		}

		// Token: 0x1700591F RID: 22815
		// (get) Token: 0x0600B1BF RID: 45503 RVA: 0x00A50F7C File Offset: 0x00A4F17C
		public global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLList MPLList
		{
			get
			{
				short num = (short)1563559587;
				short num2 = num;
				num = (short)1186924195;
				switch (num2 == num)
				{
				}
				num = (short)1379926016;
				short num3 = num;
				num = (short)931594241;
				if (num != 0)
				{
				}
				num = (short)314441728;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLList)base[10192];
			}
		}

		// Token: 0x17005920 RID: 22816
		// (get) Token: 0x0600B1C0 RID: 45504 RVA: 0x00A51034 File Offset: 0x00A4F234
		public global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.Labtool Labtool
		{
			get
			{
				short num = (short)329408405;
				short num2 = num;
				num = (short)2010603413;
				switch (num2 == num)
				{
				}
				num = (short)1658388480;
				short num3 = num;
				num = (short)816513025;
				if (num != 0)
				{
				}
				num = (short)790822912;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.Labtool)base[10195];
			}
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x00A510F0 File Offset: 0x00A4F2F0
		public static global::AcpCommonLib.IAcpFeatureNode GetMPLConfiguration()
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
					goto IL_7A;
				case 1:
				{
					num2 = (short)1536069448;
					short num3 = num2;
					num2 = (short)987991880;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BD;
					default:
						goto IL_131;
					}
					break;
				}
				case 2:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2078)[0];
					goto IL_BD;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)822345730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2078)[0];
					num2 = (short)390922240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_BD:
				num2 = (short)1086128128;
				short num4 = num2;
				num2 = (short)1744306177;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_7A:
			num2 = (short)1968308225;
			if (num2 != 0)
			{
			}
			return result;
			IL_131:
			num2 = (short)1165950976;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)739180547;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
