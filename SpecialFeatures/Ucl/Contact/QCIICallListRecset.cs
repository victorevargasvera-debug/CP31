using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000207 RID: 519
	[global::System.Serializable]
	public class QCIICallListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600199C RID: 6556 RVA: 0x00003D0C File Offset: 0x00001F0C
		internal QCIICallListRecset() : base(global::CommonResources.AppResources.QCII_Call_List)
		{
			base.Id = 2205;
			base.UIName = global::CommonResources.AppResources.QCII_Call_List;
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0021C368 File Offset: 0x0021A568
		protected QCIICallListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.UIName = global::CommonResources.AppResources.QCII_Call_List;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0021C3AC File Offset: 0x0021A5AC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1099588189;
			short num2 = num;
			num = (short)692281949;
			switch (num2 == num)
			{
			}
			num = (short)976683008;
			short num3 = num;
			num = (short)186515457;
			if (num != 0)
			{
			}
			num = (short)288030720;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.Contact.QCIICallList(this);
		}
	}
}
