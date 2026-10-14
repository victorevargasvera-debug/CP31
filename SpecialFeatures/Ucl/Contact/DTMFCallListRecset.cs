using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x020001FC RID: 508
	[global::System.Serializable]
	public class DTMFCallListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600188B RID: 6283 RVA: 0x00003C62 File Offset: 0x00001E62
		public DTMFCallListRecset() : base(global::CommonResources.AppResources.DTMF_Call_List)
		{
			base.Id = 2204;
			base.UIName = global::CommonResources.AppResources.DTMF_Call_List;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0020E914 File Offset: 0x0020CB14
		protected DTMFCallListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("﶑", a_));
			}
			base.UIName = global::CommonResources.AppResources.DTMF_Call_List;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0020E958 File Offset: 0x0020CB58
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1636691871;
			short num2 = num;
			num = (short)605220767;
			switch (num2 == num)
			{
			}
			num = (short)1341521920;
			if (num != 0)
			{
			}
			num = (short)1089011712;
			short num3 = num;
			num = (short)453181441;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.Contact.DTMFCallList(this);
		}
	}
}
