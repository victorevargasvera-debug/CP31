using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.UclWide
{
	// Token: 0x020001B6 RID: 438
	[global::System.Serializable]
	public class UclWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001487 RID: 5255 RVA: 0x000038B7 File Offset: 0x00001AB7
		public UclWideRecset() : base(global::CommonResources.AppResources.Call_List_Wide)
		{
			this.a();
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x001D8278 File Offset: 0x001D6478
		protected UclWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 16;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("朗ﮔ", a_));
			}
			this.a();
			base.UIName = global::CommonResources.AppResources.Call_List_Wide;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x001D82C0 File Offset: 0x001D64C0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)843882192;
			short num2 = num;
			num = (short)735682256;
			switch (num2 == num)
			{
			}
			num = (short)2045837312;
			if (num != 0)
			{
			}
			num = (short)1561198592;
			short num3 = num;
			num = (short)347930625;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.UclWide.UclWide(this);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x001D8370 File Offset: 0x001D6570
		private void a()
		{
			int a_ = 0;
			short num = (short)525352896;
			short num2 = num;
			num = (short)2068463552;
			switch (num2 == num)
			{
			}
			num = (short)796196865;
			if (num != 0)
			{
			}
			num = (short)1822818304;
			short num3 = num;
			num = (short)503382016;
			if (num != 0)
			{
			}
			base.Id = 2222;
			base.SingleInstance = true;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킂힐骠쪤쪦\ud9a8쒪쎬쪮\udfb0잲骴\ud8b8ힺ톼龾跀ꫂ뛄돆裊ꋌꇎ럐뫒닔ꋖꯘ뫚꧜뛞軠跢쫤닦諨蟪뫬蛮闰雲\udaf4ꟶ飸鳺飼꫾戀漂刄渆洈渊⌌眎瀐縒礔", a_);
			base.UIName = global::CommonResources.AppResources.Call_List_Wide;
			base.DataTransferOrder = 34;
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x001D845C File Offset: 0x001D665C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1025486608;
				short num2 = num;
				num = (short)1853599504;
				switch (num2 == num)
				{
				}
				num = (short)1631387648;
				if (num != 0)
				{
				}
				num = (short)1605107712;
				short num3 = num;
				num = (short)244514817;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}
	}
}
