using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x02000028 RID: 40
	[global::System.Serializable]
	public class VoiceAnnouncementList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060005A6 RID: 1446 RVA: 0x00053350 File Offset: 0x00051550
		internal VoiceAnnouncementList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud98eﺐ朗릘\uda9a캠횢쮤쒦첨욪좬솮얰鎲領\udeb6쪸쾺", a_);
			base.UIName = global::CommonResources.AppResources.Voice_Announcement_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾鷀闂꫄껆꫈껊賌ꇎ뿐볒ꃔ맖뫘뻚냜뫞迠韢雤믦뿨蓪蓬賮铰닲鯴駶雸軺鏼鳾搀渂怄椆紈䜊搌簎攐伒䌔砖瀘砚砜帞传䴢䨤刦䜨䠪䠬䈮吰崲䄴笶倸䠺䤼ᄾ㥀≂⡄⭆", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000533BC File Offset: 0x000515BC
		protected VoiceAnnouncementList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("자ﲒﲔﲘ뮚\udc9c쾠첢키즦쪨캪사쪮\udfb0잲閴﮶킸좺즼", a_);
			base.UIName = global::CommonResources.AppResources.Voice_Announcement_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐漢\ud99e쒠슢톤튦\udba8캪\udeac钮\udcb2\ud8b4잶횸햺\ud8bc톾뗀鿂鏄꣆ꃈ꣊꣌軎뿐뷒뫔ꋖ럘룚룜닞蓠跢釤铦뗨뷪苬蛮鋰雲듴駶韸铺裼釾戀昂栄戆月缊䄌明成朒䤔䄖瘘爚縜稞怠䴢䬤䠦尨䔪丬䨮尰嘲嬴䌶甸刺丼䬾潀㭂⑄⩆╈", a_);
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00053410 File Offset: 0x00051610
		public global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection General
		{
			get
			{
				short num = (short)535232512;
				short num2 = num;
				num = (short)425894795;
				short num3 = num;
				num = (short)1122214795;
				switch (num3 == num)
				{
				}
				num = (short)208076801;
				if (num != 0)
				{
				}
				num = (short)1395458048;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementGeneralSection)base[10500];
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000534CC File Offset: 0x000516CC
		internal static global::AcpCommonLib.IAcpFeatureNode GetVoiceAnnouncement()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
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
					num2 = (short)701628416;
					short num3 = num2;
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2300)[0];
					num2 = (short)1312030724;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)170459137;
					if (num2 != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)202178560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BC;
				case 2:
					return result;
				case 3:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1990524934;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2300)[0];
					num2 = (short)2046974791;
					short num4 = num2;
					num2 = (short)379083591;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BC;
					default:
						num2 = (short)1791557632;
						if (num2 != 0)
						{
						}
						num2 = (short)784990213;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2300)[0];
					num2 = (short)705363970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_BC:
				num2 = (short)1567227907;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)515964929;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
