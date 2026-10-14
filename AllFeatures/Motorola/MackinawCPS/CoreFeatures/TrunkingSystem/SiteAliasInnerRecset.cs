using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A3 RID: 163
	[global::System.Serializable]
	public class SiteAliasInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060013E9 RID: 5097 RVA: 0x0012B7DC File Offset: 0x001299DC
		public SiteAliasInnerRecset() : base(global::CommonResources.AcgResources.ID_SITEALIAS)
		{
			this.SetValues();
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0012B7FC File Offset: 0x001299FC
		public SiteAliasInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0012B828 File Offset: 0x00129A28
		public override int MaxPool
		{
			get
			{
				short num = (short)536976685;
				short num2 = num;
				num = (short)1025547565;
				switch (num2 == num)
				{
				}
				num = (short)1329463297;
				if (num != 0)
				{
				}
				num = (short)1340669952;
				short num3 = num;
				num = (short)948043776;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset._MaxPool;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0012B8D4 File Offset: 0x00129AD4
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x0012B998 File Offset: 0x00129B98
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1122238464;
					short num2 = num;
					num = (short)624193929;
					short num3 = num;
					num = (short)390885769;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1322254337;
						if (num != 0)
						{
						}
						num = (short)1874919424;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset._Max;
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)2120763409;
				short num2 = num;
				num = (short)372459537;
				switch (num2 == num)
				{
				}
				num = (short)610861057;
				if (num != 0)
				{
				}
				num = (short)908656640;
				short num3 = num;
				num = (short)146800640;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0012BA48 File Offset: 0x00129C48
		public override int Min
		{
			get
			{
				short num = (short)1974807897;
				short num2 = num;
				num = (short)900410713;
				switch (num2 == num)
				{
				}
				num = (short)1926627329;
				if (num != 0)
				{
				}
				num = (short)1649082368;
				short num3 = num;
				num = (short)1214185472;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset._Min;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0012BAF8 File Offset: 0x00129CF8
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x0012BBA8 File Offset: 0x00129DA8
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1518075905;
				if (num != 0)
				{
				}
				num = (short)1682307641;
				short num2 = num;
				num = (short)1227225657;
				switch (num2 == num)
				{
				}
				num = (short)1122893824;
				short num3 = num;
				num = (short)843317248;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1748500481;
				if (num != 0)
				{
				}
				num = (short)2118484856;
				short num2 = num;
				num = (short)1331921784;
				switch (num2 == num)
				{
				}
				num = (short)660930560;
				short num3 = num;
				num = (short)1576009728;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0012BC58 File Offset: 0x00129E58
		public bool HasDiffs
		{
			get
			{
				short num = (short)1718681601;
				if (num != 0)
				{
				}
				num = (short)849066958;
				short num2 = num;
				num = (short)614448078;
				switch (num2 == num)
				{
				}
				num = (short)1923350528;
				short num3 = num;
				num = (short)932773888;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0012BD04 File Offset: 0x00129F04
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)646017973;
			short num2 = num;
			num = (short)1805284277;
			switch (num2 == num)
			{
			}
			num = (short)822870017;
			if (num != 0)
			{
			}
			num = (short)471793664;
			short num3 = num;
			num = (short)388759552;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInner(this);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0012BDB8 File Offset: 0x00129FB8
		internal void SetValues()
		{
			short num = (short)1022884322;
			short num2 = num;
			num = (short)512358882;
			switch (num2 == num)
			{
			}
			num = (short)718929921;
			if (num != 0)
			{
			}
			num = (short)232062976;
			short num3 = num;
			num = (short)1417740288;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_SITEALIAS;
			base.DataTransferOrder = 43;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0012BE84 File Offset: 0x0012A084
		// Note: this type is marked as 'beforefieldinit'.
		static SiteAliasInnerRecset()
		{
			short num = (short)1024298963;
			short num2 = num;
			num = (short)337678291;
			switch (num2 == num)
			{
			}
			num = (short)889126912;
			if (num != 0)
			{
			}
			num = (short)1781071872;
			short num3 = num;
			num = (short)1040973825;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset._Min = 1;
		}

		// Token: 0x04000468 RID: 1128
		public static int _MaxPool;

		// Token: 0x04000469 RID: 1129
		public static int _Max;

		// Token: 0x0400046A RID: 1130
		public int _DynMax;

		// Token: 0x0400046B RID: 1131
		public static int _Min;

		// Token: 0x0400046C RID: 1132
		public static int _DefaultRecordCount;
	}
}
