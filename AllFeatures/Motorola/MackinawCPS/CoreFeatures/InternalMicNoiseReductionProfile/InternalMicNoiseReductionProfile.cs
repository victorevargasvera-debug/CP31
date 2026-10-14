using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile
{
	// Token: 0x02000251 RID: 593
	[global::System.Serializable]
	public class InternalMicNoiseReductionProfile : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060068C4 RID: 26820 RVA: 0x005DCD3C File Offset: 0x005DAF3C
		public InternalMicNoiseReductionProfile(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韄ꛆ귈ꋊꋌ鿐볒볔ꓖ볘ﯚ远뫞藠離蛤鏦胨蓪菬쿮ꇰ臲髴釶郸韺飼", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIONOISEREDUCTIONPROFILE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蓄ꯆꗈ跊꣌껎ꗐꛒ꟔닖꫘黜냞賠鏢諤触賨藪駬돮ꏰ鋲釴黶雸\udbfa룼跾昀氂欄栆搈戊渌簎ㄐ倒稔礖缘爚稜樞匠䈢儤並䘨䔪焬愮帰娲䘴制ᤸ椺堼嬾㑀⁂ㅄ⹆♈╊浌౎㹐㵒㍔㹖㹘⹚⽜㹞ᕠ੢੤०㕨≪ͬ᭮ᑰŲ᭴ᙶᕸ孺ぼᙾꎂ쮄꾎쎐滛쾠莢햦욨춪쒬쎮풰ﲴ\ud9b6춸\udeba쾼톾ꃀ꿂裄껆꫈藊ꋌꛎꋐ뛒蟔닖뷘껚뻜ꯞ裠賢诤럦鯨蓪诬蛮鷰雲\udbf4迶飸雺釼", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060068C5 RID: 26821 RVA: 0x005DCDA8 File Offset: 0x005DAFA8
		protected InternalMicNoiseReductionProfile(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗龎鋛뇝觟釡臣웥뫧迩裫鯭鏯蛱鷳駵雷\udaf9곻賽濿搁洃樅洇", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIONOISEREDUCTIONPROFILE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹껻鿽擿欁欃★䴇砉欋愍縏紑礓缕笗椙㰛崝伟䰡䈣伥伧弩師伭䐯嬱嬳堵搷琹医圽㌿❁摃ᑅⵇ⹉㥋ⵍ⑏㭑㭓㡕硗ᥙ㍛そٟୡͣ፥ᩧ୩ᡫݭὯᱱ⡳㽵ᙷ๹᥻౽ꚅ얇꺍\ude8f﶑ﶓﶗ몙캛ﮝ쒟힡잣튥솧얩슫躭삱\udbb3킵톷횹\ud9bb覿곁냃ꏅ뫇꓉귋ꋍ鷏믑럓飕럗동꿛믝닟蟡胣鏥诧黩藫臭黯ꋱ蛳駵黷鏹郻鯽⻿稁攃欅搇", a_);
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x060068C6 RID: 26822 RVA: 0x005DCDFC File Offset: 0x005DAFFC
		public global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.General General
		{
			get
			{
				short num = (short)514981888;
				short num2 = num;
				num = (short)969636898;
				short num3 = num;
				num = (short)203848738;
				switch (num3 == num)
				{
				}
				num = (short)117309441;
				if (num != 0)
				{
				}
				num = (short)1204027392;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.General)base[10202];
			}
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x005DCEB8 File Offset: 0x005DB0B8
		public static global::AcpCommonLib.IAcpFeatureNode GetInternalMicNoiseReductionProfile()
		{
			short num = (short)1199570945;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_47;
			}
			int num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2086)[0];
					num = (short)1385431043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)800072432;
						short num3 = num;
						num = (short)716186352;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)2001141760;
							if (num != 0)
							{
							}
							num = (short)558759936;
							short num4 = num;
							result = global::AcpCommonLib.FeatureManager.GetFeature(2086)[0];
							num = (short)401408000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
					}
					num = (short)1541537793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				}
				goto IL_47;
			}
			return result;
			IL_47:
			result = null;
			num = (short)1529479170;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}
	}
}
