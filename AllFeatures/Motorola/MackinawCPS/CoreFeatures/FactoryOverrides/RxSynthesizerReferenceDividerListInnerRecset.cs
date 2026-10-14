using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000460 RID: 1120
	[global::System.Serializable]
	public class RxSynthesizerReferenceDividerListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060094CD RID: 38093 RVA: 0x008C089C File Offset: 0x008BEA9C
		public RxSynthesizerReferenceDividerListInnerRecset() : base(global::CommonResources.AcgResources.ID_RXSYNTHESIZERREFERENCEDIVIDERLIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x060094CE RID: 38094 RVA: 0x008C08C0 File Offset: 0x008BEAC0
		public RxSynthesizerReferenceDividerListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004AD7 RID: 19159
		// (get) Token: 0x060094CF RID: 38095 RVA: 0x008C08EC File Offset: 0x008BEAEC
		public override int MaxPool
		{
			get
			{
				short num = (short)1146258309;
				short num2 = num;
				num = (short)1927906181;
				switch (num2 == num)
				{
				}
				num = (short)120389632;
				short num3 = num;
				num = (short)954269697;
				if (num != 0)
				{
				}
				num = (short)1175781376;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004AD8 RID: 19160
		// (get) Token: 0x060094D0 RID: 38096 RVA: 0x008C099C File Offset: 0x008BEB9C
		// (set) Token: 0x060094D1 RID: 38097 RVA: 0x008C0A58 File Offset: 0x008BEC58
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					num = (short)729717484;
					short num2 = num;
					num = (short)850631404;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)251985921;
						if (num != 0)
						{
						}
						num = (short)1617690624;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset._Max;
					}
				}
				num = (short)1876819968;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)1622871071;
				short num2 = num;
				num = (short)907742239;
				switch (num2 == num)
				{
				}
				num = (short)1216020480;
				short num3 = num;
				num = (short)1939668993;
				if (num != 0)
				{
				}
				num = (short)76414976;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004AD9 RID: 19161
		// (get) Token: 0x060094D2 RID: 38098 RVA: 0x008C0B08 File Offset: 0x008BED08
		public override int Min
		{
			get
			{
				short num = (short)873922561;
				if (num != 0)
				{
				}
				num = (short)1855096108;
				short num2 = num;
				num = (short)2051376428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595197952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)422182912;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset._Min;
			}
		}

		// Token: 0x17004ADA RID: 19162
		// (get) Token: 0x060094D3 RID: 38099 RVA: 0x008C0BB8 File Offset: 0x008BEDB8
		// (set) Token: 0x060094D4 RID: 38100 RVA: 0x008C0C68 File Offset: 0x008BEE68
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1872992871;
				short num2 = num;
				num = (short)853514855;
				switch (num2 == num)
				{
				}
				num = (short)573964288;
				short num3 = num;
				num = (short)1891565568;
				if (num != 0)
				{
				}
				num = (short)1142685697;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)942239063;
				short num2 = num;
				num = (short)2080533847;
				switch (num2 == num)
				{
				}
				num = (short)1148125184;
				short num3 = num;
				num = (short)2043543552;
				if (num != 0)
				{
				}
				num = (short)1013514241;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004ADB RID: 19163
		// (get) Token: 0x060094D5 RID: 38101 RVA: 0x008C0D18 File Offset: 0x008BEF18
		public bool HasDiffs
		{
			get
			{
				short num = (short)699242300;
				short num2 = num;
				num = (short)1898944316;
				switch (num2 == num)
				{
				}
				num = (short)2116681728;
				short num3 = num;
				num = (short)155451392;
				if (num != 0)
				{
				}
				num = (short)1771503617;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060094D6 RID: 38102 RVA: 0x008C0DC8 File Offset: 0x008BEFC8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)793895001;
			short num2 = num;
			num = (short)1433264217;
			switch (num2 == num)
			{
			}
			num = (short)1737293824;
			short num3 = num;
			num = (short)268107776;
			if (num != 0)
			{
			}
			num = (short)1350959105;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInner(this);
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x008C0E78 File Offset: 0x008BF078
		internal void SetValues()
		{
			short num = (short)1996487054;
			short num2 = num;
			num = (short)1370814862;
			switch (num2 == num)
			{
			}
			num = (short)321716224;
			short num3 = num;
			num = (short)75366401;
			if (num != 0)
			{
			}
			num = (short)612958208;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x008C0F40 File Offset: 0x008BF140
		// Note: this type is marked as 'beforefieldinit'.
		static RxSynthesizerReferenceDividerListInnerRecset()
		{
			short num = (short)1586351592;
			short num2 = num;
			num = (short)2143931880;
			switch (num2 == num)
			{
			}
			num = (short)1471152128;
			short num3 = num;
			num = (short)105185281;
			if (num != 0)
			{
			}
			num = (short)2075721728;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset._Min = 1;
		}

		// Token: 0x040049F5 RID: 18933
		public static int _MaxPool;

		// Token: 0x040049F6 RID: 18934
		public static int _Max;

		// Token: 0x040049F7 RID: 18935
		public int _DynMax;

		// Token: 0x040049F8 RID: 18936
		public static int _Min;

		// Token: 0x040049F9 RID: 18937
		public static int _DefaultRecordCount;
	}
}
