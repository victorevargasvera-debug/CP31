using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DVRSProfiles
{
	// Token: 0x020004B7 RID: 1207
	[global::System.Serializable]
	public class DVRSProfiles : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06009E6D RID: 40557 RVA: 0x0093F2D8 File Offset: 0x0093D4D8
		public DVRSProfiles(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 10;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("迊鯌鷎苐藔ꗖ뛘뷚드돞蓠郢", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DVRSPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴돶꿸ꧺ껼\udffe䈀氂欄愆怈氊砌紎瀐朒簔砖眘䜚夜䤞猠瀢Ԥ眦嬨䐪䬬䘮崰嘲䘴欶紸洺漼氾ᅀㅂ⩄ⅆ⁈❊⡌㱎罐⭒㑔㩖㕘", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06009E6E RID: 40558 RVA: 0x0093F344 File Offset: 0x0093D544
		protected DVRSProfiles(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苅黇飉鿋胏ꃑ믓냕뇗뛙맛귝", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DVRSPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蟅꓇ꛉ請ꯍ뇏ꛑꇓꓕ뷗꧙鷝迟迡铣觥蛧迩苫髭곯뛱ꋳꓵ꯷\udaf9뿻釽滿搁洃愅紇砉洋稍礏紑稓䨕尗䰙丛䴝\u001f爡嘣䤥丧䌩䀫䬭䌯渱瀳怵樷椹氻䰽⼿⑁ⵃ⩅ⵇ㥉手㙍ㅏ㽑㡓", a_);
		}

		// Token: 0x17004F85 RID: 20357
		// (get) Token: 0x06009E6F RID: 40559 RVA: 0x0093F398 File Offset: 0x0093D598
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General General
		{
			get
			{
				short num = (short)2107842559;
				short num2 = num;
				num = (short)1900027903;
				switch (num2 == num)
				{
				}
				num = (short)2014183425;
				if (num != 0)
				{
				}
				num = (short)1507852288;
				short num3 = num;
				num = (short)2141192192;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General)base[10759];
			}
		}

		// Token: 0x06009E70 RID: 40560 RVA: 0x0093F450 File Offset: 0x0093D650
		public static global::AcpCommonLib.IAcpFeatureNode GetDVRSProfiles()
		{
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_CB;
					case 1:
					{
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							result = global::AcpCommonLib.FeatureManager.GetFeature(4143)[0];
							num2 = (short)1497300992;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)765186770;
						short num3 = num2;
						num2 = (short)28431058;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1199833088;
							if (num2 != 0)
							{
							}
							num2 = (short)1605566466;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4143)[0];
						num2 = (short)843448321;
						if (num2 != 0)
						{
						}
						num2 = (short)1078067203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return result;
					}
					break;
				}
				IL_20:
				result = null;
				num2 = (short)2000486401;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_CB:
			num2 = (short)280363008;
			short num4 = num2;
			return result;
		}
	}
}
