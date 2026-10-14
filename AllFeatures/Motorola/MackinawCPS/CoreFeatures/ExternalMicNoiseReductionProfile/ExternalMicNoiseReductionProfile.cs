using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile
{
	// Token: 0x02000263 RID: 611
	[global::System.Serializable]
	public class ExternalMicNoiseReductionProfile : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06006C31 RID: 27697 RVA: 0x0060A6FC File Offset: 0x006088FC
		public ExternalMicNoiseReductionProfile(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 7;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("觇꧉꿋ꯍꏏꇑ믓ꓕꇗ龎鋛뇝觟釡臣웥뫧迩裫鯭鏯蛱鷳駵雷\udaf9곻賽濿搁洃樅洇", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYNOISEREDUCTIONPROFILE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛ꏟ跡解雥蟧蓩觫胭蓯껱꛳韵鳷鏹鏻\udefd䗿瀁挃椅昇攉愋服猏愑㐓唕眗琙稛眝䜟圡嘣䜥尧䌩䌫䀭氯簱嬳張䬷弹᰻氽┿♁ㅃ╅㱇⍉⍋⁍灏ᅑ㭓㡕㹗㍙㭛⭝቟͡ၣཥݧѩに⭭࡯ٱᅳѵᙷ᭹ၻ幽쵿ꚅ욇ﶍ늑욓ﲗﾛ즟춡쪣蚥\ud8a9쎫좭\ud9af\udeb1톳ﶷ승좻\udbbd늿곁ꗃ꫅藇ꏉ꿋胍뿏믑ꟓ돕諗뿙룛ꯝ菟雡跣觥蛧뫩黫臭雯鯱飳鏵훷苹鷻鏽泿", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x0060A768 File Offset: 0x00608968
		protected ExternalMicNoiseReductionProfile(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诉꿋귍뗏ꇑꟓ맕꫗ꏙﳛ郝迟诡韣菥죧룩觫諭藯釱胳鿵韷铹\udcfb껽狿洁戃漅搇漉", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYNOISEREDUCTIONPROFILE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ雏럑뗓ꋕ귗꣙맛귝\udbdfꇡ诣该飧藩苫语黯蛱ꣳꓵ駷黹闻釽⃿䜁瘃愅朇搉挋挍礏焑朓㘕嬗甙爛砝䤟䔡儣吥䤧帩䔫䄭帯渱稳夵儷䤹夻ḽሿ❁⁃㍅⭇㹉╋⅍㹏牑ᝓ㥕㙗㱙㕛㥝ᕟၡգብŧթɫ㉭㕯ੱs፵੷ᑹᵻችꁿ쾁ꢇ쒉뒓쒕ﶗﺙﶝ풟쮡쮣좥袧睊\udeab솭횯\udbb1\ud8b3펵ﾹ쒻쪽ꖿ냁꫃Ʂ꓇蟉ꗋ귍黏뷑뷓ꗕ뷗裙맛뫝闟臡郣迥蟧蓩볫鳭鿯铱鷳髵鷷퓹蓻鿽淿渁", a_);
		}

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x06006C33 RID: 27699 RVA: 0x0060A7BC File Offset: 0x006089BC
		public global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.General General
		{
			get
			{
				short num = (short)1515842537;
				short num2 = num;
				num = (short)1891494889;
				switch (num2 == num)
				{
				}
				num = (short)1797849088;
				short num3 = num;
				num = (short)1543569408;
				if (num != 0)
				{
				}
				num = (short)37945345;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.General)base[10203];
			}
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x0060A878 File Offset: 0x00608A78
		public static global::AcpCommonLib.IAcpFeatureNode GetExternalMicNoiseReductionProfile()
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
				{
					num2 = (short)2072309179;
					short num3 = num2;
					num2 = (short)1854795195;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)704905217;
						if (num2 != 0)
						{
						}
						num2 = (short)1265238016;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2087)[0];
						num2 = (short)1404108802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)441384960;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2087)[0];
					num2 = (short)829292544;
					short num4 = num2;
					num2 = (short)1880686595;
					num = (int)((global::System.IntPtr)num2);
					continue;
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
			num2 = (short)632225793;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
