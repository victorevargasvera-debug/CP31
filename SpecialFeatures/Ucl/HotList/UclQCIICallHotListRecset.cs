using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001E5 RID: 485
	[global::System.Serializable]
	public class UclQCIICallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600175B RID: 5979 RVA: 0x00003B29 File Offset: 0x00001D29
		public UclQCIICallHotListRecset() : base(global::CommonResources.AppResources.QCII_Call_Hot_List)
		{
			this.a();
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x001FDCF8 File Offset: 0x001FBEF8
		protected UclQCIICallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾏ", a_));
			}
			this.a();
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x001FDD38 File Offset: 0x001FBF38
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1562116096;
			short num2 = num;
			num = (short)682288518;
			short num3 = num;
			num = (short)1024583046;
			switch (num3 == num)
			{
			}
			num = (short)1437859841;
			if (num != 0)
			{
			}
			num = (short)1444151296;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.UclQCIICallHotList(this);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x001FDDE8 File Offset: 0x001FBFE8
		private void a()
		{
			int a_ = 17;
			short num = (short)2140864512;
			short num2 = num;
			num = (short)1457301377;
			short num3 = num;
			num = (short)1713743745;
			switch (num3 == num)
			{
			}
			num = (short)1194786817;
			if (num != 0)
			{
			}
			num = (short)510001152;
			if (num != 0)
			{
			}
			base.Id = 2218;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잓ﶗ蓮ﾝ첟솣장\udca7\udfa9\udeab쮭쎯覱\ud9b5햷쪹펻킽ꖿ곁냃诇ꯉꃋꋍ黑뷓ꗕ곗龎鿛뇝軟蓡跣臥鷧飩跫髭駯鷱髳\ud9f5냷闹裻닽槿焁瀃⤅崇椉怋弍匏嬑崓唕礗瘙瀛嘝伟嘡栣伥嬧帩簫伭圯圱ᨳ丵夷圹倻", a_);
			base.UIName = global::CommonResources.AppResources.QCII_Call_Hot_List;
			base.DataTransferOrder = 816;
		}
	}
}
