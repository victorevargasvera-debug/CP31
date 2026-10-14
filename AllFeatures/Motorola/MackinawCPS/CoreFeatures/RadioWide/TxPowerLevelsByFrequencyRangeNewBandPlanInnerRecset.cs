using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000191 RID: 401
	[global::System.Serializable]
	public class TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06004157 RID: 16727 RVA: 0x003D1C0C File Offset: 0x003CFE0C
		public TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset() : base(global::CommonResources.AcgResources.ID_TXPOWERLEVELS)
		{
			this.SetValues();
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x003D1C2C File Offset: 0x003CFE2C
		public TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x003D1C58 File Offset: 0x003CFE58
		public override int MaxPool
		{
			get
			{
				short num = (short)907476992;
				short num2 = num;
				num = (short)1967109977;
				short num3 = num;
				num = (short)1208268633;
				switch (num3 == num)
				{
				}
				num = (short)1069088769;
				if (num != 0)
				{
				}
				num = (short)847314944;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x003D1D08 File Offset: 0x003CFF08
		// (set) Token: 0x0600415B RID: 16731 RVA: 0x003D1DC8 File Offset: 0x003CFFC8
		public override int Max
		{
			get
			{
				short num = (short)1477836800;
				short num2 = num;
				num = (short)1748434945;
				if (num != 0)
				{
				}
				num = (short)235655105;
				short num3 = num;
				num = (short)1800261569;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)766181376;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset._Max;
			}
			set
			{
				short num = (short)978649088;
				short num2 = num;
				num = (short)234037629;
				short num3 = num;
				num = (short)1325146493;
				switch (num3 == num)
				{
				}
				num = (short)870645761;
				if (num != 0)
				{
				}
				num = (short)648347648;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x0600415C RID: 16732 RVA: 0x003D1E78 File Offset: 0x003D0078
		public override int Min
		{
			get
			{
				short num = (short)775553024;
				short num2 = num;
				num = (short)1455599749;
				short num3 = num;
				num = (short)132231301;
				switch (num3 == num)
				{
				}
				num = (short)2119892992;
				if (num != 0)
				{
				}
				num = (short)1625554945;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset._Min;
			}
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x003D1F24 File Offset: 0x003D0124
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x003D1FD0 File Offset: 0x003D01D0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)518914048;
				short num2 = num;
				num = (short)883599486;
				short num3 = num;
				num = (short)831498366;
				switch (num3 == num)
				{
				}
				num = (short)1173225472;
				if (num != 0)
				{
				}
				num = (short)341966849;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1997340672;
				short num2 = num;
				num = (short)675851301;
				short num3 = num;
				num = (short)695118885;
				switch (num3 == num)
				{
				}
				num = (short)232194048;
				if (num != 0)
				{
				}
				num = (short)656932865;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x003D2080 File Offset: 0x003D0280
		public bool HasDiffs
		{
			get
			{
				short num = (short)1284177920;
				short num2 = num;
				num = (short)1318700216;
				short num3 = num;
				num = (short)729466040;
				switch (num3 == num)
				{
				}
				num = (short)721682433;
				if (num != 0)
				{
				}
				num = (short)963117056;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x003D2134 File Offset: 0x003D0334
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1233977344;
			short num2 = num;
			num = (short)1233977345;
			if (num != 0)
			{
			}
			num = (short)1873436357;
			short num3 = num;
			num = (short)632970949;
			switch (num3 == num)
			{
			}
			num = (short)1513095168;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInner(this);
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x003D21E4 File Offset: 0x003D03E4
		internal void SetValues()
		{
			short num = (short)2059665408;
			short num2 = num;
			num = (short)1620558056;
			short num3 = num;
			num = (short)353812712;
			switch (num3 == num)
			{
			}
			num = (short)106233857;
			if (num != 0)
			{
			}
			num = (short)761724928;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELS;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x003D22AC File Offset: 0x003D04AC
		// Note: this type is marked as 'beforefieldinit'.
		static TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset()
		{
			short num = (short)1519976448;
			short num2 = num;
			num = (short)1125729025;
			short num3 = num;
			num = (short)867189505;
			switch (num3 == num)
			{
			}
			num = (short)1371602945;
			if (num != 0)
			{
			}
			num = (short)648478720;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset._Min = 1;
		}

		// Token: 0x04001A11 RID: 6673
		public static int _MaxPool;

		// Token: 0x04001A12 RID: 6674
		public static int _Max;

		// Token: 0x04001A13 RID: 6675
		public int _DynMax;

		// Token: 0x04001A14 RID: 6676
		public static int _Min;

		// Token: 0x04001A15 RID: 6677
		public static int _DefaultRecordCount;
	}
}
