using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001C8 RID: 456
	[global::System.Serializable]
	public class QCIICallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x001EB64C File Offset: 0x001E984C
		public global::SpecialFeatures.Ucl.HotList.QCIICallHotListHotListSection HotListQCII
		{
			get
			{
				short num = (short)1157630897;
				short num2 = num;
				num = (short)237374385;
				switch (num2 == num)
				{
				}
				num = (short)589234176;
				short num3 = num;
				num = (short)312934401;
				if (num != 0)
				{
				}
				num = (short)65470464;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.QCIICallHotListHotListSection)base[10426];
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0000397A File Offset: 0x00001B7A
		private QCIICallHotList() : this(null)
		{
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x001EB708 File Offset: 0x001E9908
		internal QCIICallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 19;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude95벛튝즟톡킣", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.QCIICallHotListHotListSection(this));
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x001EB748 File Offset: 0x001E9948
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1168929522;
			short num2 = num;
			num = (short)812282610;
			switch (num2 == num)
			{
			}
			num = (short)581697536;
			short num3 = num;
			num = (short)552402944;
			if (num != 0)
			{
			}
			num = (short)64159745;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000038AD File Offset: 0x00001AAD
		protected QCIICallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
