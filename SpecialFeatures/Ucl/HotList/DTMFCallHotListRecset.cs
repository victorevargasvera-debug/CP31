using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001C0 RID: 448
	[global::System.Serializable]
	public class DTMFCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001563 RID: 5475 RVA: 0x000038FF File Offset: 0x00001AFF
		public DTMFCallHotListRecset() : base(global::CommonResources.AppResources.DTMF_Call_Hot_List)
		{
			base.Id = 2217;
			base.UIName = global::CommonResources.AppResources.DTMF_Call_Hot_List;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x001E2FFC File Offset: 0x001E11FC
		protected DTMFCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾐ杖", a_));
			}
			base.UIName = global::CommonResources.AppResources.DTMF_Call_Hot_List;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x001E3040 File Offset: 0x001E1240
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1113980929;
			if (num != 0)
			{
			}
			num = (short)1874067456;
			short num2 = num;
			num = (short)301706769;
			short num3 = num;
			num = (short)622571025;
			switch (num3 == num)
			{
			}
			num = (short)1027866624;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.DTMFCallHotList(this);
		}
	}
}
