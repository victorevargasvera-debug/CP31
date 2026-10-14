using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001A9 RID: 425
	[global::System.Serializable]
	public class SystemCertificateList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06001402 RID: 5122 RVA: 0x001CFEC8 File Offset: 0x001CE0C8
		internal SystemCertificateList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aﲎ랖\uda98ﺚ좠얢첤쒦좨\udfaa좬辮ﶰ\udab2운쎶", a_);
			base.UIName = global::CommonResources.AppResources.System_Cerfiticate_List_ID;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aﶌ朗ﮖ\udf98ﺚﲜ풠톢삤풦銨슬슮솰\udcb2\udbb4튶ힸ쾺ﲾ꓀뇂뇄껆꿈ꋊ껌껎ꗐ뛒飔뛖럘뫚뫜뫞賠蛢诤鏦뗨룪铬鳮藰雲飴듶鳸觺觼雾最樂昄昆紈渊䄌明成朒䤔䐖怘栚検稞䰠怢䀤唦崨䈪䬬䘮到刲䄴制甸刺丼䬾潀㭂⑄⩆╈", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x001CFF34 File Offset: 0x001CE134
		protected SystemCertificateList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐ﲘ붜\udc9e쒠톢톤캦쾨슪캬캮얰횲閴﮶킸좺즼", a_);
			base.UIName = global::CommonResources.AppResources.System_Cerfiticate_List_ID;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐漢\ud99e쒠슢톤튦\udba8캪\udeac钮\udcb2\ud8b4잶횸햺\ud8bc톾뗀鿂蛄ꋆ믈뿊꓌꧎룐냒듔ꏖ볘雚볜뇞胠蓢胤諦賨藪駬돮ꋰ諲蛴菶鳸雺뻼髾猀眂氄愆怈栊氌笎琐弒簔搖洘䜚东昞删圢䀤䨦樨个弬嬮堰唲尴吶堸伺堼猾⡀あㅄ楆ㅈ⩊⁌⍎", a_);
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x001CFF88 File Offset: 0x001CE188
		public global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection General
		{
			get
			{
				short num = (short)2104958987;
				short num2 = num;
				num = (short)960569355;
				switch (num2 == num)
				{
				}
				num = (short)262930432;
				short num3 = num;
				num = (short)1776943105;
				if (num != 0)
				{
				}
				num = (short)126812160;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.SystemCertificates.List.SystemCertificateGeneralSection)base[10885];
			}
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x001D0044 File Offset: 0x001CE244
		internal static global::AcpCommonLib.IAcpFeatureNode GetSystemCertificate()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
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
					goto IL_AF;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)535165854;
					short num3 = num2;
					num2 = (short)1108802462;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AF;
					default:
						num2 = (short)1809121281;
						if (num2 != 0)
						{
						}
						num2 = (short)1862729728;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4228)[0];
						num2 = (short)1284112384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
				{
					num2 = (short)1280507904;
					short num4 = num2;
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4228)[0];
					num2 = (short)2095513602;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)312737796;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1364262913;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				}
				goto IL_2C;
				IL_AF:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
				{
					num2 = (short)341311491;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					result = global::AcpCommonLib.FeatureManager.GetFeature(4228)[0];
					num2 = (short)1940783110;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)1788411909;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
