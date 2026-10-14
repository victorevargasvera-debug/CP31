using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
	// Token: 0x02000035 RID: 53
	[global::System.Serializable]
	public class SiteSelectableAlertList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06000694 RID: 1684 RVA: 0x00061EAC File Offset: 0x000600AC
		public SiteSelectableAlertList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8e랖쪘ﺚ爵슠힢쒤얦얨캪趬\uddb0횲잴쎶馸풼첾뗀", a_);
			base.UIName = global::CommonResources.AppResources.ID_SITESELECTABLEALERTLIST;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾鷀闂꫄껆꫈껊賌ꇎ뿐볒ꃔ맖뫘뻚냜뫞迠韢雤믦뫨苪駬諮퇰ꃲ郴鯶鳸飺觼黾挀漂怄✆䠈朊栌紎攐㌒夔縖樘漚䄜䰞䠠圢䀤琦䰨䜪䠬䰮䔰刲圴嬶尸稺儼娾㍀㝂ॄ⹆㩈㽊捌㝎ぐ㹒㥔", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList41985(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00061F18 File Offset: 0x00060118
		protected SiteSelectableAlertList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힃ﲇ겋\udd8dﺑﮙﺛ얟芡쪥춧\ud8a9\ud8ab躭ﲯ\udbb1잳습", a_);
			base.UIName = global::CommonResources.AppResources.ID_SITESELECTABLEALERTLIST;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힃ﲏ풑ﮝ펟馡즥얧\udaa9쎫삭햯\udcb1삳햹햻\uddbdꖿ菁꫃ꣅꟇ뿉ꋋ귍뗏뿑뇓룕곗꧙胛距觟雡臣웥믧迩胫语鏯蛱闳铵铷鿹\udcfb뿽泿朁瘃爅⠇䘉攋納搏丑䜓缕気缙伛笝䰟䜡䜣別䤧䠩䀫䬭焯帱儳䐵䰷瘹唻䴽㐿汁㱃❅╇♉", a_);
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00061F6C File Offset: 0x0006016C
		public global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList41985 SiteSelectableAlertList41985
		{
			get
			{
				short num = (short)58064896;
				short num2 = num;
				num = (short)1065611672;
				short num3 = num;
				num = (short)61403544;
				switch (num3 == num)
				{
				}
				num = (short)51773440;
				if (num != 0)
				{
				}
				num = (short)1010892801;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList41985)base[10765];
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00062028 File Offset: 0x00060228
		public static global::AcpCommonLib.IAcpFeatureNode GetSiteSelectableAlertList()
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
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)27590658;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(4145)[0];
						num2 = (short)1019109732;
						short num3 = num2;
						num2 = (short)1322148196;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1259536384;
							short num4 = num2;
							num2 = (short)527106048;
							if (num2 != 0)
							{
							}
							num2 = (short)847904769;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return result;
					case 2:
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4145)[0];
						num2 = (short)178913283;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return result;
					}
					break;
				}
				IL_20:
				num2 = (short)536608769;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)1135149056;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}
	}
}
