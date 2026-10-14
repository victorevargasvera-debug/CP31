using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001BF RID: 447
	[global::System.Serializable]
	public class DTMFCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x001E2E50 File Offset: 0x001E1050
		public global::SpecialFeatures.Ucl.HotList.DTMFCallHotListHotListSection HotListDTMF
		{
			get
			{
				short num = (short)735903745;
				if (num != 0)
				{
				}
				num = (short)85262336;
				short num2 = num;
				num = (short)467536988;
				short num3 = num;
				num = (short)650579036;
				switch (num3 == num)
				{
				}
				num = (short)1471283200;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.DTMFCallHotListHotListSection)base[10424];
			}
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x000038F6 File Offset: 0x00001AF6
		private DTMFCallHotList() : this(null)
		{
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x001E2F08 File Offset: 0x001E1108
		internal DTMFCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆ﾊ권쎎", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.DTMFCallHotListHotListSection(this));
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x001E2F48 File Offset: 0x001E1148
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)2107442439;
			short num2 = num;
			num = (short)853804295;
			switch (num2 == num)
			{
			default:
			{
				num = (short)565182464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1453457408;
			if (num != 0)
			{
			}
			num = (short)887357441;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000038AD File Offset: 0x00001AAD
		protected DTMFCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
