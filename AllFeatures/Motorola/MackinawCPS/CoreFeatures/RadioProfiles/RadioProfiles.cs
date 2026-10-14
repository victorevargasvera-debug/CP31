using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioProfiles
{
	// Token: 0x02000212 RID: 530
	[global::System.Serializable]
	public class RadioProfiles : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06005E0C RID: 24076 RVA: 0x005486E4 File Offset: 0x005468E4
		public RadioProfiles(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 6;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闆꣈꿊꓌ꃎ菒꟔룖뿘닚뇜뫞鋠", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚鳞軠転闤裦蟨軪菬鯮귰ꇲ铴鏶郸铺\uddfc뫾猀搂樄椆昈昊搌氎成㌒嘔砖眘級琜砞吠儢䐤匦䀨䐪䌬献挰刲儴帶嘸ᬺ洼䴾⹀╂ⱄ⭆ⱈ㡊ᅌᵎぐ㝒㱔㡖क़⥚㉜㥞ࡠརdᑦ䝨፪౬ɮᵰ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AlertTones(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x00548774 File Offset: 0x00546974
		protected RadioProfiles(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("郁ꗃꋅꇇꗉ黍ꋏ뷑닓뿕듗뿙꿛", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫볭釯雱鷳駵\ud8f7뿹軻駽濿氁欃欅愇椉缋⸍匏紑稓瀕焗紙椛氝䄟嘡䴣䤥䘧瘩縫伭启嬱嬳ᘵ样䠹医堽⤿⹁⅃㕅ᑇᡉⵋ⩍㥏㵑ѓ⑕㝗㱙㕛㉝՟ᅡ䩣ṥ१ݩk", a_);
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x06005E0E RID: 24078 RVA: 0x005487C8 File Offset: 0x005469C8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General General
		{
			get
			{
				short num = (short)1549991937;
				if (num != 0)
				{
				}
				num = (short)2038407450;
				short num2 = num;
				num = (short)2118164762;
				switch (num2 == num)
				{
				}
				num = (short)2007760896;
				if (num != 0)
				{
				}
				num = (short)120061952;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General)base[10189];
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x06005E0F RID: 24079 RVA: 0x00548884 File Offset: 0x00546A84
		public global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings AudioSettings
		{
			get
			{
				short num = (short)1716477928;
				short num2 = num;
				num = (short)1387945960;
				switch (num2 == num)
				{
				}
				num = (short)1708392449;
				if (num != 0)
				{
				}
				num = (short)1222443008;
				if (num != 0)
				{
				}
				num = (short)296288256;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings)base[10188];
			}
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x06005E10 RID: 24080 RVA: 0x0054893C File Offset: 0x00546B3C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA LabtoolRAD_PROF_CDA
		{
			get
			{
				short num = (short)1610468712;
				short num2 = num;
				num = (short)174116200;
				switch (num2 == num)
				{
				}
				num = (short)2096562177;
				if (num != 0)
				{
				}
				num = (short)144769024;
				if (num != 0)
				{
				}
				num = (short)2032140288;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA)base[10190];
			}
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x005489F4 File Offset: 0x00546BF4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AlertTones AlertTones
		{
			get
			{
				short num = (short)1356381046;
				short num2 = num;
				num = (short)2042674038;
				switch (num2 == num)
				{
				}
				num = (short)1828782081;
				if (num != 0)
				{
				}
				num = (short)306315264;
				short num3 = num;
				num = (short)472776704;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AlertTones)base[10191];
			}
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x00548AAC File Offset: 0x00546CAC
		public static global::AcpCommonLib.IAcpFeatureNode GetRadioProfiles()
		{
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)2050818048;
						short num3 = num2;
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2077)[0];
						num2 = (short)1775042563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						return result;
					case 2:
					{
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)2060451840;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2077)[0];
						num2 = (short)80057160;
						short num4 = num2;
						num2 = (short)1180209992;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)899022849;
							if (num2 != 0)
							{
							}
							num2 = (short)2012938240;
							if (num2 != 0)
							{
							}
							num2 = (short)1478885377;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						return result;
					}
					break;
				}
				IL_20:
				result = null;
				num2 = (short)1403191298;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}
	}
}
