using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000183 RID: 387
	[global::System.Serializable]
	public class RxFrequencySplitFPPInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06003E5E RID: 15966 RVA: 0x003ADBE4 File Offset: 0x003ABDE4
		public RxFrequencySplitFPPInnerRecset() : base(global::CommonResources.AcgResources.ID_RXFREQUENCYSPLITFPP)
		{
			this.SetValues();
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x003ADC04 File Offset: 0x003ABE04
		public RxFrequencySplitFPPInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06003E60 RID: 15968 RVA: 0x003ADC30 File Offset: 0x003ABE30
		public override int MaxPool
		{
			get
			{
				short num = (short)2065847499;
				short num2 = num;
				num = (short)2006668491;
				switch (num2 == num)
				{
				}
				num = (short)702021632;
				short num3 = num;
				num = (short)158597120;
				if (num != 0)
				{
				}
				num = (short)1029373953;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset._MaxPool;
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06003E61 RID: 15969 RVA: 0x003ADCE0 File Offset: 0x003ABEE0
		// (set) Token: 0x06003E62 RID: 15970 RVA: 0x003ADDA0 File Offset: 0x003ABFA0
		public override int Max
		{
			get
			{
				short num = (short)801439745;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					num = (short)1624899584;
					short num2 = num;
					num = (short)932456180;
					short num3 = num;
					num = (short)1985881844;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)561381376;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset._Max;
			}
			set
			{
				short num = (short)1867155394;
				short num2 = num;
				num = (short)1763805122;
				switch (num2 == num)
				{
				}
				num = (short)568262656;
				short num3 = num;
				num = (short)473956353;
				if (num != 0)
				{
				}
				num = (short)1197146112;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x003ADE50 File Offset: 0x003AC050
		public override int Min
		{
			get
			{
				short num = (short)856870817;
				short num2 = num;
				num = (short)170971041;
				switch (num2 == num)
				{
				}
				num = (short)383123456;
				short num3 = num;
				num = (short)876347392;
				if (num != 0)
				{
				}
				num = (short)1388838913;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset._Min;
			}
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06003E64 RID: 15972 RVA: 0x003ADEFC File Offset: 0x003AC0FC
		// (set) Token: 0x06003E65 RID: 15973 RVA: 0x003ADFAC File Offset: 0x003AC1AC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)864056514;
				short num2 = num;
				num = (short)2091545794;
				switch (num2 == num)
				{
				}
				num = (short)1049886720;
				short num3 = num;
				num = (short)912523265;
				if (num != 0)
				{
				}
				num = (short)809631744;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)845865175;
				short num2 = num;
				num = (short)1682038999;
				switch (num2 == num)
				{
				}
				num = (short)1059651584;
				short num3 = num;
				num = (short)91947009;
				if (num != 0)
				{
				}
				num = (short)2037972992;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06003E66 RID: 15974 RVA: 0x003AE05C File Offset: 0x003AC25C
		public bool HasDiffs
		{
			get
			{
				short num = (short)397410305;
				if (num != 0)
				{
				}
				num = (short)2004544679;
				short num2 = num;
				num = (short)1787096231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601423872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422131200;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x003AE10C File Offset: 0x003AC30C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)75796461;
			short num2 = num;
			num = (short)1596100589;
			switch (num2 == num)
			{
			}
			num = (short)102629376;
			short num3 = num;
			num = (short)733413377;
			if (num != 0)
			{
			}
			num = (short)129105920;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInner(this);
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x003AE1BC File Offset: 0x003AC3BC
		internal void SetValues()
		{
			short num = (short)641778046;
			short num2 = num;
			num = (short)1237565822;
			switch (num2 == num)
			{
			}
			num = (short)1071972352;
			short num3 = num;
			num = (short)2093285377;
			if (num != 0)
			{
			}
			num = (short)1075838976;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYSPLITFPP;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x003AE288 File Offset: 0x003AC488
		// Note: this type is marked as 'beforefieldinit'.
		static RxFrequencySplitFPPInnerRecset()
		{
			short num = (short)2003810365;
			short num2 = num;
			num = (short)1549645885;
			switch (num2 == num)
			{
			}
			num = (short)1759969280;
			short num3 = num;
			num = (short)1130496001;
			if (num != 0)
			{
			}
			num = (short)1315110912;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset._Min = 1;
		}

		// Token: 0x040019E4 RID: 6628
		public static int _MaxPool;

		// Token: 0x040019E5 RID: 6629
		public static int _Max;

		// Token: 0x040019E6 RID: 6630
		public int _DynMax;

		// Token: 0x040019E7 RID: 6631
		public static int _Min;

		// Token: 0x040019E8 RID: 6632
		public static int _DefaultRecordCount;
	}
}
