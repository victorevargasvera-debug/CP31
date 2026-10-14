using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001C9 RID: 457
	[global::System.Serializable]
	public class QCIICallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001601 RID: 5633 RVA: 0x00003983 File Offset: 0x00001B83
		public QCIICallHotListRecset() : base(global::CommonResources.AppResources.QCII_Call_Hot_List)
		{
			base.Id = 2219;
			base.UIName = global::CommonResources.AppResources.QCII_Call_Hot_List;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x001EB7F8 File Offset: 0x001E99F8
		protected QCIICallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.UIName = global::CommonResources.AppResources.QCII_Call_Hot_List;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x001EB83C File Offset: 0x001E9A3C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1085576222;
			short num2 = num;
			num = (short)183800862;
			switch (num2 == num)
			{
			}
			num = (short)1227096064;
			short num3 = num;
			num = (short)1385234433;
			if (num != 0)
			{
			}
			num = (short)465108992;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.QCIICallHotList(this);
		}
	}
}
