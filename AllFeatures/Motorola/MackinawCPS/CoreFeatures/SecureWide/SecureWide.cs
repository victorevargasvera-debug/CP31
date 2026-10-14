using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000E6 RID: 230
	[global::System.Serializable]
	public class SecureWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06002044 RID: 8260 RVA: 0x001FFFC8 File Offset: 0x001FE1C8
		public SecureWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 19;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟓돕믗꿙껛믝샟뗡跣若跧", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SECUREWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ叿朁會猅稇漉Ⰻ䴍缏簑爓缕缗漙減缝吟䬡䬣䠥琧礩䤫䴭䔯䀱儳ᘵ漷匹堻嬽᰿ᅁ⅃╅㵇㡉⥋᥍㥏㙑ㅓ硕⁗㭙ㅛ㉝", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Features(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Multikey(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0020007C File Offset: 0x001FE27C
		protected SecureWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铆곈꣊료뷎듐苔뻖뷘뻚", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SECUREWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚鳞軠転闤裦蟨軪菬鯮귰ꃲ郴银賸觺飼\udffe䈀氂欄愆怈氊砌紎瀐朒簔砖眘䜚东稞䈠嘢圤䈦न簪䐬䬮吰漲昴制娸为似娾ᙀ⩂⅄≆杈㍊ⱌ≎㵐", a_);
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x002000D0 File Offset: 0x001FE2D0
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General General
		{
			get
			{
				short num = (short)1748525931;
				short num2 = num;
				num = (short)1442145131;
				switch (num2 == num)
				{
				}
				num = (short)101580800;
				if (num != 0)
				{
				}
				num = (short)1471086593;
				if (num != 0)
				{
				}
				num = (short)657981440;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General)base[10043];
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x00200188 File Offset: 0x001FE388
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR ASTROOTAR
		{
			get
			{
				short num = (short)755119525;
				short num2 = num;
				num = (short)1651324325;
				switch (num2 == num)
				{
				}
				num = (short)613941249;
				if (num != 0)
				{
				}
				num = (short)1316683776;
				if (num != 0)
				{
				}
				num = (short)765657088;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR)base[10042];
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x00200240 File Offset: 0x001FE440
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR MDCOTAR
		{
			get
			{
				short num = (short)1450265482;
				short num2 = num;
				num = (short)1545751434;
				switch (num2 == num)
				{
				}
				num = (short)1517355008;
				if (num != 0)
				{
				}
				num = (short)411631617;
				if (num != 0)
				{
				}
				num = (short)1990328320;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.MDCOTAR)base[10045];
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x002002FC File Offset: 0x001FE4FC
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Features Features
		{
			get
			{
				short num = (short)167903233;
				if (num != 0)
				{
				}
				num = (short)748961859;
				short num2 = num;
				num = (short)663699523;
				switch (num2 == num)
				{
				}
				num = (short)433848320;
				if (num != 0)
				{
				}
				num = (short)1514536960;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Features)base[10046];
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x002003B8 File Offset: 0x001FE5B8
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Multikey Multikey
		{
			get
			{
				short num = (short)1241075884;
				short num2 = num;
				num = (short)1671319724;
				switch (num2 == num)
				{
				}
				num = (short)1278017536;
				if (num != 0)
				{
				}
				num = (short)1917190145;
				if (num != 0)
				{
				}
				num = (short)2118844416;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Multikey)base[10044];
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x00200470 File Offset: 0x001FE670
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyList EncryptionKeyList
		{
			get
			{
				short num = (short)508297217;
				if (num != 0)
				{
				}
				num = (short)301839122;
				short num2 = num;
				num = (short)1420669714;
				switch (num2 == num)
				{
				}
				num = (short)1987837952;
				if (num != 0)
				{
				}
				num = (short)1774125056;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyList)base[10040];
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x0020052C File Offset: 0x001FE72C
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Labtool Labtool
		{
			get
			{
				short num = (short)1955942658;
				short num2 = num;
				num = (short)527061250;
				switch (num2 == num)
				{
				}
				num = (short)27197441;
				if (num != 0)
				{
				}
				num = (short)1748107264;
				if (num != 0)
				{
				}
				num = (short)1241579520;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Labtool)base[10039];
			}
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x002005E4 File Offset: 0x001FE7E4
		public static global::AcpCommonLib.IAcpFeatureNode GetSecureWide()
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
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2021)[0];
					num2 = (short)770483409;
					short num3 = num2;
					num2 = (short)1236116689;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11F;
					default:
					{
						num2 = (short)1061683200;
						short num4 = num2;
						num2 = (short)976617472;
						if (num2 != 0)
						{
						}
						num2 = (short)426704898;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1867186176;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0];
					num2 = (short)221839363;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_11F;
				case 3:
					goto IL_7A;
				}
				goto IL_20;
			}
			IL_7A:
			return result;
			IL_11F:
			num2 = (short)1422983169;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)1922301953;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
