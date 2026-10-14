using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000211 RID: 529
	[global::System.Serializable]
	public class UclContact : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06001B08 RID: 6920 RVA: 0x0022ED40 File Offset: 0x0022CF40
		internal UclContact(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 16;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킒杖練漢ﺜ튠", a_);
			base.UIName = global::CommonResources.AppResources.Contacts_Id;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰\udab4\udab6즸풺펼\udabe꿀럂蓆꣈ꟊꇌ鷐뫒ꛔꏖ律飚닜뇞蟠諢苤鋦鯨諪駬蛮黰鷲\udaf4듶雸闺觼黾戀眂⨄分樈朊丌怎缐朒琔琖洘䬚簜砞䐠ഢ崤䘦䐨䜪", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.UclContactGeneralSection(this));
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.UclContactTrunkingCallListSection(this));
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.UclContactTrunkingT2CallListSection(this));
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.UclContactAstroCallListSection(this));
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.UclContactMDCCallListSection(this));
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.UclContactPhoneCallListSection(this));
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0022EDD8 File Offset: 0x0022CFD8
		public global::SpecialFeatures.Ucl.Contact.UclContactGeneralSection General
		{
			get
			{
				short num = (short)746097686;
				short num2 = num;
				num = (short)1395690518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1445658624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1461387264;
				if (num != 0)
				{
				}
				num = (short)2112946177;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContactGeneralSection)base[10400];
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0022EE94 File Offset: 0x0022D094
		public global::SpecialFeatures.Ucl.Contact.UclContactTrunkingCallListSection TrunkingCallList
		{
			get
			{
				short num = (short)1995709483;
				short num2 = num;
				num = (short)194059307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2086862848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)153747457;
				if (num != 0)
				{
				}
				num = (short)1103888384;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContactTrunkingCallListSection)base[10401];
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0022EF4C File Offset: 0x0022D14C
		public global::SpecialFeatures.Ucl.Contact.UclContactTrunkingT2CallListSection TrunkingT2CallList
		{
			get
			{
				short num = (short)1781813583;
				short num2 = num;
				num = (short)1536119119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)57933824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)78381056;
				if (num != 0)
				{
				}
				num = (short)625475585;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContactTrunkingT2CallListSection)base[10411];
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0022F008 File Offset: 0x0022D208
		public global::SpecialFeatures.Ucl.Contact.UclContactAstroCallListSection AstroCallList
		{
			get
			{
				short num = (short)2074804225;
				if (num != 0)
				{
				}
				num = (short)2096496640;
				short num2 = num;
				num = (short)1994932745;
				short num3 = num;
				num = (short)1517634057;
				switch (num3 == num)
				{
				}
				num = (short)1280704512;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContactAstroCallListSection)base[10403];
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x0022F0C0 File Offset: 0x0022D2C0
		public global::SpecialFeatures.Ucl.Contact.UclContactMDCCallListSection MDCCallList
		{
			get
			{
				short num = (short)1657460604;
				short num2 = num;
				num = (short)1461835644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)740818944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)781451265;
				if (num != 0)
				{
				}
				num = (short)1068892160;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContactMDCCallListSection)base[10405];
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0022F178 File Offset: 0x0022D378
		internal global::SpecialFeatures.Ucl.Contact.UclContactDTMFCallListSection DTMFCallList
		{
			get
			{
				short num = (short)390135809;
				if (num != 0)
				{
				}
				num = (short)1362493440;
				short num2 = num;
				num = (short)1125434383;
				short num3 = num;
				num = (short)203932687;
				switch (num3 == num)
				{
				}
				num = (short)1550581760;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContactDTMFCallListSection)base[10407];
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0022F234 File Offset: 0x0022D434
		internal global::SpecialFeatures.Ucl.Contact.UclContactQCIICallListSection QCIICallList
		{
			get
			{
				short num = (short)851378177;
				if (num != 0)
				{
				}
				num = (short)1640497152;
				short num2 = num;
				num = (short)351460310;
				short num3 = num;
				num = (short)1925438422;
				switch (num3 == num)
				{
				}
				num = (short)1056833536;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContactQCIICallListSection)base[10409];
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0022F2EC File Offset: 0x0022D4EC
		public global::SpecialFeatures.Ucl.Contact.UclContactPhoneCallListSection PhoneCallList
		{
			get
			{
				short num = (short)1891217127;
				short num2 = num;
				num = (short)1711058663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)615710720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1080688640;
				if (num != 0)
				{
				}
				num = (short)326041601;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContactPhoneCallListSection)base[10413];
			}
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0022F3A4 File Offset: 0x0022D5A4
		protected UclContact(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾐ杖", a_));
			}
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첎ﺐﶒ滛", a_);
			base.UIName = global::CommonResources.AppResources.Contacts_Id;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾胂꓄ꯆꗈ臌ꛎꋐ꟒铖뛘뗚믜뛞蛠離韤蛦鷨苪苬臮\udef0냲髴駶跸髺黼课⸀嘂昄欆䨈搊挌笎瀐瀒愔䜖砘簚砜ㄞ夠䈢䠤䬦", a_);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0022F410 File Offset: 0x0022D610
		internal static global::AcpBusinessLayer.Recordset GetContactRecset()
		{
			short num;
			if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
			{
				num = (short)196409307;
				short num2 = num;
				num = (short)530118619;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)396230657;
					if (num != 0)
					{
					}
					num = (short)987365376;
					if (num != 0)
					{
					}
					return (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2200);
				}
			}
			num = (short)371195904;
			short num3 = num;
			return (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2200);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0022F4E8 File Offset: 0x0022D6E8
		protected override void Dispose(bool disposing)
		{
			short num = (short)395942518;
			short num2 = num;
			num = (short)2106694262;
			switch (num2 == num)
			{
			default:
			{
				num = (short)503971840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)970260481;
			if (num != 0)
			{
			}
			num = (short)1100742656;
			if (num != 0)
			{
			}
			base.Dispose(disposing);
		}
	}
}
