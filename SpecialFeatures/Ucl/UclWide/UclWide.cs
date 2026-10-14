using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.UclWide
{
	// Token: 0x020001B5 RID: 437
	[global::System.Serializable]
	public class UclWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x001D7FE4 File Offset: 0x001D61E4
		public global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral General
		{
			get
			{
				short num = (short)1204420609;
				if (num != 0)
				{
				}
				num = (short)531597746;
				short num2 = num;
				num = (short)1539344818;
				switch (num2 == num)
				{
				}
				num = (short)691601408;
				short num3 = num;
				num = (short)1567293440;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral)base[10429];
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x001D80A0 File Offset: 0x001D62A0
		public global::SpecialFeatures.Ucl.UclWide.UclWideSectionLabtool Labtool
		{
			get
			{
				short num = (short)1663369217;
				if (num != 0)
				{
				}
				num = (short)1539568402;
				short num2 = num;
				num = (short)267645714;
				switch (num2 == num)
				{
				}
				num = (short)1256980480;
				short num3 = num;
				num = (short)1606811648;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.UclWide.UclWideSectionLabtool)base[10430];
			}
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000038A4 File Offset: 0x00001AA4
		private UclWide() : this(null)
		{
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x001D815C File Offset: 0x001D635C
		internal UclWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튐璉ﮖ릘힚햠莢캦춨캪", a_);
			base.UIName = global::CommonResources.AppResources.Call_List_Wide;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐漢\ud99e쒠슢톤튦\udba8캪\udeac钮\udcb2\ud8b4잶횸햺\ud8bc톾뗀蛄ꛆꗈꟊ菎룐ꃒꇔ高듚돜맞裠蓢郤闦裨鿪蓬胮鿰\udcf2ꃴ银闸곺铼鯾搀Ⰲ唄昆済渊堌氎紐䐒簔猖簘㔚攜縞䰠伢", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral(this));
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.UclWide.UclWideSectionLabtool(this));
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x001D81C4 File Offset: 0x001D63C4
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1568145409;
			if (num != 0)
			{
			}
			num = (short)1348426424;
			short num2 = num;
			num = (short)1243830968;
			switch (num2 == num)
			{
			}
			num = (short)1106771968;
			short num3 = num;
			num = (short)972292096;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000038AD File Offset: 0x00001AAD
		protected UclWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
