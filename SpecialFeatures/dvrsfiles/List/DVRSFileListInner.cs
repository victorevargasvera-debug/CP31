using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x0200012E RID: 302
	[global::System.Serializable]
	public class DVRSFileListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x001647A4 File Offset: 0x001629A4
		public global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerSection DVRSFileListInnerSection
		{
			get
			{
				short num = (short)1591827007;
				short num2 = num;
				num = (short)1995594303;
				switch (num2 == num)
				{
				}
				num = (short)393609217;
				if (num != 0)
				{
				}
				num = (short)1054408704;
				short num3 = num;
				num = (short)1458962432;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerSection)base[10894];
			}
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x000034F2 File Offset: 0x000016F2
		private DVRSFileListInner() : this(null)
		{
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00164860 File Offset: 0x00162A60
		public DVRSFileListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆\udf88\ud98a\ude8c꾎힐朗璉릘힚햠", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DVRSFILELIST;
			base.AddFeatureSection(new global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerSection(this));
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x001648A8 File Offset: 0x00162AA8
		protected DVRSFileListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍욏삑잓뚕\ude97ﮝ肟춣향\udca7", a_);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x001648DC File Offset: 0x00162ADC
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1220513114;
			short num2 = num;
			num = (short)734694746;
			switch (num2 == num)
			{
			}
			num = (short)1120075777;
			if (num != 0)
			{
			}
			num = (short)1916731392;
			short num3 = num;
			num = (short)694616064;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}
	}
}
