using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000F7 RID: 247
	[global::System.Serializable]
	public class SecureKMFProfile : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060024A4 RID: 9380 RVA: 0x0023EF78 File Offset: 0x0023D178
		public SecureKMFProfile(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("量臑胓蓕韗龎鏛諝ꇟ냡쓣뛥髧藩諫蟭鳯韱", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ASTROOTARPROFILE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹꿻鯽揿省瘃挅⠇䤉挋怍瘏笑猓挕樗笙栛眝伟䰡砣甥䴧䤩夫尭唯ሱ缳笵縷ᨹ氻䰽⼿⑁ⵃ⩅ⵇᙉὋ⭍㍏❑♓㍕ፗ᝙ᩛ๝቟ൡɣཥѧཀྵ䉫᙭ᅯάᡳ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.DataTransport(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0023F020 File Offset: 0x0023D220
		protected SecureKMFProfile(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("觇駉飋鳍鿏鯓苕駗裙ﳛ軝鋟跡苣迥蓧迩", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ASTROOTARPROFILE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛ꏟ跡解雥蟧蓩觫胭蓯껱ꟳ鏵鯷迹軻鯽⃿䄁欃栅渇按欋笍戏猑怓缕眗琙䀛䴝䔟䄡儣吥䴧਩末挭瘯ሱ搳䐵圷尹唻刽┿ṁᝃ⍅⭇㽉㹋⭍᭏ὑቓٕ⩗㕙㩛㝝౟ݡ䩣ṥ१ݩk", a_);
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x0023F074 File Offset: 0x0023D274
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General General
		{
			get
			{
				short num = (short)1617500636;
				short num2 = num;
				num = (short)120920540;
				switch (num2 == num)
				{
				}
				num = (short)915931137;
				if (num != 0)
				{
				}
				num = (short)906493952;
				short num3 = num;
				num = (short)1903624192;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General)base[10883];
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x0023F12C File Offset: 0x0023D32C
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation ASTROOTARInformation
		{
			get
			{
				short num = (short)1201744438;
				short num2 = num;
				num = (short)709306934;
				switch (num2 == num)
				{
				}
				num = (short)1917911041;
				if (num != 0)
				{
				}
				num = (short)1199505408;
				short num3 = num;
				num = (short)1869086720;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.ASTROOTARInformation)base[10124];
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x0023F1E8 File Offset: 0x0023D3E8
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.DataTransport DataTransport
		{
			get
			{
				short num = (short)1278917949;
				short num2 = num;
				num = (short)1077460285;
				switch (num2 == num)
				{
				}
				num = (short)374800385;
				if (num != 0)
				{
				}
				num = (short)2023620608;
				short num3 = num;
				num = (short)1727070208;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.DataTransport)base[10125];
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x0023F2A4 File Offset: 0x0023D4A4
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesList SecureHardwareEncryptionKeyReferencesList
		{
			get
			{
				short num = (short)473343400;
				short num2 = num;
				num = (short)429237672;
				switch (num2 == num)
				{
				}
				num = (short)169607169;
				if (num != 0)
				{
				}
				num = (short)617414656;
				short num3 = num;
				num = (short)1385889792;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesList)base[10126];
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x0023F360 File Offset: 0x0023D560
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyList SecureHardwareEncryptionIndependentKeyList
		{
			get
			{
				short num = (short)1954676737;
				if (num != 0)
				{
				}
				num = (short)1426095491;
				short num2 = num;
				num = (short)1514765699;
				switch (num2 == num)
				{
				}
				num = (short)1188888576;
				short num3 = num;
				num = (short)1349255168;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyList)base[10881];
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x0023F418 File Offset: 0x0023D618
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.Labtool Labtool
		{
			get
			{
				short num = (short)2102711367;
				short num2 = num;
				num = (short)1534252103;
				switch (num2 == num)
				{
				}
				num = (short)142147585;
				if (num != 0)
				{
				}
				num = (short)1237319680;
				short num3 = num;
				num = (short)566231040;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.Labtool)base[10128];
			}
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0023F4D4 File Offset: 0x0023D6D4
		public static global::AcpCommonLib.IAcpFeatureNode GetSecureKMFProfile()
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
					return result;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)212402179;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2055)[0];
					num2 = (short)913965056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					for (;;)
					{
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2055)[0];
						num2 = (short)616890368;
						short num3 = num2;
						num2 = (short)1425420184;
						short num4 = num2;
						num2 = (short)594096024;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_F3;
						}
					}
					IL_F3:
					num2 = (short)1575092225;
					if (num2 != 0)
					{
					}
					num2 = (short)1719730176;
					if (num2 != 0)
					{
					}
					num2 = (short)371261441;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)881852418;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
