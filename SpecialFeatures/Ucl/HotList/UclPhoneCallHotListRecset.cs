using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001E1 RID: 481
	[global::System.Serializable]
	public class UclPhoneCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600173D RID: 5949 RVA: 0x00003ADF File Offset: 0x00001CDF
		public UclPhoneCallHotListRecset() : base(global::CommonResources.AppResources.Phone_Hot_List, global::CommonResources.AppResources.List)
		{
			this.a();
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x001FBECC File Offset: 0x001FA0CC
		protected UclPhoneCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 13;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("憐ﲑ秊", a_));
			}
			this.a();
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x001FBF0C File Offset: 0x001FA10C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2120274639;
			short num2 = num;
			num = (short)415421135;
			switch (num2 == num)
			{
			}
			num = (short)1216086016;
			short num3 = num;
			num = (short)236322817;
			if (num != 0)
			{
			}
			num = (short)1822556160;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.UclPhoneCallHotList(this);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x001FBFBC File Offset: 0x001FA1BC
		private void a()
		{
			int a_ = 5;
			short num = (short)521510524;
			short num2 = num;
			num = (short)2092408444;
			switch (num2 == num)
			{
			}
			num = (short)565575680;
			short num3 = num;
			num = (short)890109953;
			if (num != 0)
			{
			}
			num = (short)915341312;
			if (num != 0)
			{
			}
			base.Id = 2220;
			base.SingleInstance = true;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb87憎憐킕ﶗﮙ튟잡힣鶥얩솫\udead\udfaf\udcb1톳\ud8b5첷閹ﾻ\udfbd겿껁諅ꇇ막룋鏏뷑뫓냕뇗뷙꧛곝臟雡跣觥蛧엩ꓫ臭蓯뻱鷳藵賷헹ꧻ鷽泿刁氃椅昇漉伋漍簏縑尓礕気嘙甛洝吟爡䔣䄥䴧Щ含伭崯帱", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
			base.DataTransferOrder = 105;
			base.KeySeed = global::CommonResources.AppResources.List;
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x001FC0B0 File Offset: 0x001FA2B0
		public bool HasDiffs
		{
			get
			{
				short num = (short)544494021;
				short num2 = num;
				num = (short)1761497541;
				switch (num2 == num)
				{
				}
				num = (short)1922957312;
				short num3 = num;
				num = (short)1599406080;
				if (num != 0)
				{
				}
				num = (short)1265827841;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}
	}
}
