using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x020004A5 RID: 1189
	[global::System.Serializable]
	public class ConventionalEmergencyProfiles : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06009B8A RID: 39818 RVA: 0x0091A624 File Offset: 0x00918824
		public ConventionalEmergencyProfiles(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軌ꃎ뿐ꗒ냔맖귘닚닜뇞胠迢엤ꋦ蓨軪鿬裮铰鷲雴軶\ud9f8꯺迼郾最樂椄戆稈", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALEMERGENCYPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶본雺飼跾昀昂欄搆瀈⬊丌怎缐甒簔瀖氘椚簜欞䠠䰢䬤符樨䐪䌬央吰崲䄴帶嘸唺尼匾慀ق⡄≆㭈ⱊ⡌ⅎ㉐⩒畔ݖ⭘㑚㭜㙞ൠ٢ᙤ㭦⩨Ѫͬ᥮ᑰᵲŴṶᙸᕺᱼ፾쒀쎒ﾘ爵튠趢\udda4욦쒨잪", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.MDC(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyCompatibilityOptionsConventional(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x0091A6C0 File Offset: 0x009188C0
		protected ConventionalEmergencyProfiles(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诇ꗉꋋ룍뗏병ꃓ뿕럗듙뷛닝샟꟡解菥髧跩觫胭鏯诱퓳꛵諷闹髻韽泿朁眃", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALEMERGENCYPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛ꏟ跡解雥蟧蓩觫胭蓯껱뇳鯵鷷裹鯻鯽滿愁紃★䬇攉戋栍礏甑愓搕礗渙甛焝丟縡朣䤥䘧尩䤫䀭䐯嬱嬳堵夷嘹᰻笽ⴿ❁㙃ⅅⵇ⑉⽋㝍灏ɑ♓㥕㹗㍙せ㭝፟㹡❣॥٧ᱩ५mѯ᭱᭳ᡵ᥷ᙹ㥻፽\ude8d﶑ﾕﾙ낝\ud89f쎡즣쪥", a_);
		}

		// Token: 0x17004E0A RID: 19978
		// (get) Token: 0x06009B8C RID: 39820 RVA: 0x0091A714 File Offset: 0x00918914
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General General
		{
			get
			{
				short num = (short)2123228988;
				short num2 = num;
				num = (short)1179510588;
				switch (num2 == num)
				{
				}
				num = (short)1100939264;
				short num3 = num;
				num = (short)1967063041;
				if (num != 0)
				{
				}
				num = (short)1146486784;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General)base[10184];
			}
		}

		// Token: 0x17004E0B RID: 19979
		// (get) Token: 0x06009B8D RID: 39821 RVA: 0x0091A7CC File Offset: 0x009189CC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.MDC MDC
		{
			get
			{
				short num = (short)2039330340;
				short num2 = num;
				num = (short)2132915748;
				switch (num2 == num)
				{
				}
				num = (short)177078272;
				short num3 = num;
				num = (short)550371329;
				if (num != 0)
				{
				}
				num = (short)1598357504;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.MDC)base[10185];
			}
		}

		// Token: 0x17004E0C RID: 19980
		// (get) Token: 0x06009B8E RID: 39822 RVA: 0x0091A884 File Offset: 0x00918A84
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneList EmergencyToneList
		{
			get
			{
				short num = (short)1782317057;
				if (num != 0)
				{
				}
				num = (short)419090597;
				short num2 = num;
				num = (short)2000474277;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2042429440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1946681344;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneList)base[10771];
			}
		}

		// Token: 0x17004E0D RID: 19981
		// (get) Token: 0x06009B8F RID: 39823 RVA: 0x0091A93C File Offset: 0x00918B3C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyCompatibilityOptionsConventional EmergencyCompatibilityOptionsConventional
		{
			get
			{
				short num = (short)512130821;
				short num2 = num;
				num = (short)1601076997;
				switch (num2 == num)
				{
				}
				num = (short)1394671616;
				short num3 = num;
				num = (short)1012662273;
				if (num != 0)
				{
				}
				num = (short)1464074240;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyCompatibilityOptionsConventional)base[10846];
			}
		}

		// Token: 0x17004E0E RID: 19982
		// (get) Token: 0x06009B90 RID: 39824 RVA: 0x0091A9F4 File Offset: 0x00918BF4
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.Labtool Labtool
		{
			get
			{
				short num = (short)2094042476;
				short num2 = num;
				num = (short)547786092;
				switch (num2 == num)
				{
				}
				num = (short)254541824;
				short num3 = num;
				num = (short)1858404353;
				if (num != 0)
				{
				}
				num = (short)1038155776;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.Labtool)base[10777];
			}
		}

		// Token: 0x06009B91 RID: 39825 RVA: 0x0091AAB0 File Offset: 0x00918CB0
		public static global::AcpCommonLib.IAcpFeatureNode GetConventionalEmergencyProfiles()
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			short num;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				num = (short)1922301952;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2075)[0];
					num = (short)1539309569;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_121;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)585433088;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2075)[0];
					num = (short)2134704131;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_A6;
				}
				goto IL_48;
			}
			IL_A6:
			num = (short)1575917924;
			short num4 = num;
			num = (short)2107873636;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_48:
				result = null;
				num = (short)976355330;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
				num = (short)296026112;
				if (num != 0)
				{
				}
				break;
			}
			IL_121:
			num = (short)1949564929;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
