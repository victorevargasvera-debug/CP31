using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x0200026B RID: 619
	[global::System.Serializable]
	public class MissionCriticalGeofence : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06006E62 RID: 28258 RVA: 0x0062623C File Offset: 0x0062443C
		public MissionCriticalGeofence(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓈ꋊ뻌볎룐볒믔高꧚드ꯞ裠胢蓤详짨곪裬胮韰雲鯴银鳸", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MISSIONCRITICALGEOFENCE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜ꋠ賢裤韦蛨藪裬臮藰꿲ꟴ零鷸鋺鋼\udffe䐀焂戄栆月搊怌明爐怒㔔吖瘘甚笜瘞䘠嘢圤䘦崨䈪䈬䄮洰縲尴䐶䨸刺刼儾慀B㝄⹆㵈≊⹌⹎㵐獒ቔ㉖㙘㵚㡜ㅞɠ٢㥤⩦hᡪṬٮṰᵲ㙴նၸེᑼ᱾슄뮔", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06006E63 RID: 28259 RVA: 0x006262A8 File Offset: 0x006244A8
		protected MissionCriticalGeofence(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟉ꗋ뷍ꏏ믑믓룕駙껛럝铟诡蟣蟥蓧쫩꯫语鿯铱釳飵鯷鿹", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MISSIONCRITICALGEOFENCE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ雏럑뗓ꋕ귗꣙맛귝\udbdfꇡ诣该飧藩苫语黯蛱ꣳꓵ駷黹闻釽⃿䜁瘃愅朇搉挋挍礏焑朓㘕嬗甙爛砝䤟䔡儣吥䤧帩䔫䄭帯渱礳張䬷䤹唻儽⸿扁݃㑅ⅇ㹉╋ⵍㅏ㹑瑓ᅕ㵗㕙㩛㭝๟šţ㩥╧ͩὫᵭ᥯ᵱᩳ㕵੷፹ࡻ᝽솅ﺏ뢕ﮙ", a_);
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x06006E64 RID: 28260 RVA: 0x006262FC File Offset: 0x006244FC
		public global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General General
		{
			get
			{
				short num = (short)1521429598;
				short num2 = num;
				num = (short)586361950;
				switch (num2 == num)
				{
				}
				num = (short)876216320;
				short num3 = num;
				num = (short)1210384385;
				if (num != 0)
				{
				}
				num = (short)1699938304;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.General)base[10810];
			}
		}

		// Token: 0x06006E65 RID: 28261 RVA: 0x006263B4 File Offset: 0x006245B4
		public static global::AcpCommonLib.IAcpFeatureNode GetMissionCriticalGeofence()
		{
			short num = (short)1260650496;
			short num2 = num;
			num = (short)346262397;
			short num3 = num;
			num = (short)1043368829;
			global::AcpCommonLib.IAcpFeatureNode result;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C6:
				result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4174)[0];
				num = (short)992542720;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)714014720;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				break;
			}
			for (;;)
			{
				IL_7D:
				switch (num4)
				{
				case 0:
					return result;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)2072641538;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)73072641;
					if (num != 0)
					{
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(4174)[0];
					num = (short)380567555;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_C6;
				case 3:
					return result;
				}
				goto IL_93;
			}
			return result;
			IL_93:
			result = null;
			num = (short)1654325249;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}
	}
}
