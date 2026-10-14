using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000468 RID: 1128
	[global::System.Serializable]
	public class TxSSIClockRateListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600955A RID: 38234 RVA: 0x008C6C88 File Offset: 0x008C4E88
		public TxSSIClockRateListInnerRecset() : base(global::CommonResources.AcgResources.ID_TXSSICLOCKRATELIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x008C6CAC File Offset: 0x008C4EAC
		public TxSSIClockRateListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004B10 RID: 19216
		// (get) Token: 0x0600955C RID: 38236 RVA: 0x008C6CD8 File Offset: 0x008C4ED8
		public override int MaxPool
		{
			get
			{
				short num = (short)1553268736;
				short num2 = num;
				num = (short)1677555170;
				short num3 = num;
				num = (short)1505719778;
				switch (num3 == num)
				{
				}
				num = (short)855179265;
				if (num != 0)
				{
				}
				num = (short)1318780928;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004B11 RID: 19217
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x008C6D88 File Offset: 0x008C4F88
		// (set) Token: 0x0600955E RID: 38238 RVA: 0x008C6E48 File Offset: 0x008C5048
		public override int Max
		{
			get
			{
				short num = (short)1456583970;
				short num2 = num;
				num = (short)968144162;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1717043200;
					if (num != 0)
					{
					}
					num = (short)1854144513;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				num = (short)1418854400;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset._Max;
			}
			set
			{
				short num = (short)1086193664;
				short num2 = num;
				num = (short)359906904;
				short num3 = num;
				num = (short)1263648344;
				switch (num3 == num)
				{
				}
				num = (short)1550057473;
				if (num != 0)
				{
				}
				num = (short)1797128192;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004B12 RID: 19218
		// (get) Token: 0x0600955F RID: 38239 RVA: 0x008C6EF8 File Offset: 0x008C50F8
		public override int Min
		{
			get
			{
				short num = (short)637272064;
				short num2 = num;
				num = (short)1594037869;
				short num3 = num;
				num = (short)1422726765;
				switch (num3 == num)
				{
				}
				num = (short)2143944704;
				if (num != 0)
				{
				}
				num = (short)379912193;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset._Min;
			}
		}

		// Token: 0x17004B13 RID: 19219
		// (get) Token: 0x06009560 RID: 38240 RVA: 0x008C6FA8 File Offset: 0x008C51A8
		// (set) Token: 0x06009561 RID: 38241 RVA: 0x008C7054 File Offset: 0x008C5254
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)642056192;
				short num2 = num;
				num = (short)770572289;
				if (num != 0)
				{
				}
				num = (short)451713748;
				short num3 = num;
				num = (short)1443666644;
				switch (num3 == num)
				{
				}
				num = (short)243597312;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2090205184;
				short num2 = num;
				num = (short)422691470;
				short num3 = num;
				num = (short)1545650830;
				switch (num3 == num)
				{
				}
				num = (short)765526017;
				if (num != 0)
				{
				}
				num = (short)2031812608;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004B14 RID: 19220
		// (get) Token: 0x06009562 RID: 38242 RVA: 0x008C7104 File Offset: 0x008C5304
		public bool HasDiffs
		{
			get
			{
				short num = (short)1059192832;
				short num2 = num;
				num = (short)298123820;
				short num3 = num;
				num = (short)417006124;
				switch (num3 == num)
				{
				}
				num = (short)635830273;
				if (num != 0)
				{
				}
				num = (short)132579328;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06009563 RID: 38243 RVA: 0x008C71B4 File Offset: 0x008C53B4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2045902848;
			short num2 = num;
			num = (short)590885745;
			short num3 = num;
			num = (short)790115185;
			switch (num3 == num)
			{
			}
			num = (short)1502871553;
			if (num != 0)
			{
			}
			num = (short)307691520;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInner(this);
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x008C7264 File Offset: 0x008C5464
		internal void SetValues()
		{
			short num = (short)1889992704;
			short num2 = num;
			num = (short)1779105793;
			if (num != 0)
			{
			}
			num = (short)1887241779;
			short num3 = num;
			num = (short)839321139;
			switch (num3 == num)
			{
			}
			num = (short)1112080384;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TXSSICLOCKRATELIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06009565 RID: 38245 RVA: 0x008C7330 File Offset: 0x008C5530
		// Note: this type is marked as 'beforefieldinit'.
		static TxSSIClockRateListInnerRecset()
		{
			short num = (short)2041511936;
			short num2 = num;
			num = (short)1935736833;
			if (num != 0)
			{
			}
			num = (short)366349637;
			short num3 = num;
			num = (short)1998458181;
			switch (num3 == num)
			{
			}
			num = (short)1722089472;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset._Min = 1;
		}

		// Token: 0x04004A04 RID: 18948
		public static int _MaxPool;

		// Token: 0x04004A05 RID: 18949
		public static int _Max;

		// Token: 0x04004A06 RID: 18950
		public int _DynMax;

		// Token: 0x04004A07 RID: 18951
		public static int _Min;

		// Token: 0x04004A08 RID: 18952
		public static int _DefaultRecordCount;
	}
}
