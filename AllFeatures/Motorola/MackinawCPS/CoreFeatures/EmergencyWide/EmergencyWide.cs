using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.EmergencyWide
{
	// Token: 0x02000490 RID: 1168
	[global::System.Serializable]
	public class EmergencyWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600994E RID: 39246 RVA: 0x008FC114 File Offset: 0x008FA314
		public EmergencyWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 10;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("車ꃌ꫎ꏐ듒냔맖뫘ꋚ﷜裞裠蟢胤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴닶铸黺迼飾搀洂昄縆⤈䠊戌愎眐稒爔或欘稚検瘞丠䴢礤戦䐨个弬䠮吰崲嘴丶ᤸ氺吼嬾⑀ὂD⩆ⱈ㥊⩌⩎㽐げⱔVじ㽚㡜煞ᥠɢࡤ୦", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyToneTrigger(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideImpactDetection(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600994F RID: 39247 RVA: 0x008FC1A4 File Offset: 0x008FA3A4
		protected EmergencyWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌꣎듐뷒뛔껖律賚드믞蓠", a_);
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚鳞軠転闤裦蟨軪菬鯮귰뛲飴鋶诸鳺飼釾戀稂┄䐆昈攊欌明瘐昒朔瘖洘爚爜焞素昢䠤䈦嬨䰪䠬䄮到䨲ᔴ怶倸强堼挾р⹂⁄㕆⹈⹊⍌ⱎ⡐ђ㱔㍖㱘畚╜㹞ౠར", a_);
		}

		// Token: 0x17004CF4 RID: 19700
		// (get) Token: 0x06009950 RID: 39248 RVA: 0x008FC1F8 File Offset: 0x008FA3F8
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General General
		{
			get
			{
				short num = (short)385664384;
				short num2 = num;
				num = (short)1774503296;
				switch (num2 == num)
				{
				}
				num = (short)2000355328;
				if (num != 0)
				{
				}
				num = (short)676659200;
				short num3 = num;
				num = (short)114556929;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General)base[10074];
			}
		}

		// Token: 0x17004CF5 RID: 19701
		// (get) Token: 0x06009951 RID: 39249 RVA: 0x008FC2B4 File Offset: 0x008FA4B4
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown ManDown
		{
			get
			{
				short num = (short)1376413197;
				short num2 = num;
				num = (short)1165846029;
				switch (num2 == num)
				{
				}
				num = (short)1333329920;
				if (num != 0)
				{
				}
				num = (short)99614720;
				short num3 = num;
				num = (short)1767374849;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown)base[10639];
			}
		}

		// Token: 0x17004CF6 RID: 19702
		// (get) Token: 0x06009952 RID: 39250 RVA: 0x008FC370 File Offset: 0x008FA570
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyToneTrigger EmergencyToneTrigger
		{
			get
			{
				short num = (short)815212065;
				short num2 = num;
				num = (short)459351585;
				switch (num2 == num)
				{
				}
				num = (short)19136512;
				if (num != 0)
				{
				}
				num = (short)1982726144;
				short num3 = num;
				num = (short)199098369;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyToneTrigger)base[10778];
			}
		}

		// Token: 0x17004CF7 RID: 19703
		// (get) Token: 0x06009953 RID: 39251 RVA: 0x008FC428 File Offset: 0x008FA628
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideImpactDetection EmergencyWideImpactDetection
		{
			get
			{
				short num = (short)684770174;
				short num2 = num;
				num = (short)699515774;
				switch (num2 == num)
				{
				}
				num = (short)760283136;
				if (num != 0)
				{
				}
				num = (short)43319296;
				short num3 = num;
				num = (short)446824449;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideImpactDetection)base[10854];
			}
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x008FC4E4 File Offset: 0x008FA6E4
		public static global::AcpCommonLib.IAcpFeatureNode GetEmergencyWide()
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
				{
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2032)[0];
					num2 = (short)1140237532;
					short num3 = num2;
					num2 = (short)1202627804;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)327417856;
						if (num2 != 0)
						{
						}
						num2 = (short)1036648451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_A8;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1542782976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2000617473;
					if (num2 != 0)
					{
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2032)[0];
					num2 = (short)1043267585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_125;
				}
				goto IL_20;
			}
			IL_A8:
			return result;
			IL_125:
			num2 = (short)238944256;
			short num4 = num2;
			return result;
			IL_20:
			result = null;
			num2 = (short)1243021314;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
