using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200016E RID: 366
	[global::System.Serializable]
	public class FCCNarrowBandingFrequencySplitInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06002FCD RID: 12237 RVA: 0x002ED38C File Offset: 0x002EB58C
		public FCCNarrowBandingFrequencySplitInnerRecset() : base(global::CommonResources.AcgResources.ID_FCCNARROWBANDINGFREQUENCYSPLIT)
		{
			this.SetValues();
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x002ED3AC File Offset: 0x002EB5AC
		public FCCNarrowBandingFrequencySplitInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x002ED3D8 File Offset: 0x002EB5D8
		public override int MaxPool
		{
			get
			{
				short num = (short)1512177664;
				short num2 = num;
				num = (short)155169436;
				short num3 = num;
				num = (short)41988764;
				switch (num3 == num)
				{
				}
				num = (short)1820786689;
				if (num != 0)
				{
				}
				num = (short)767688704;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset._MaxPool;
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x002ED488 File Offset: 0x002EB688
		// (set) Token: 0x06002FD1 RID: 12241 RVA: 0x002ED548 File Offset: 0x002EB748
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)1770596420;
					short num2 = num;
					num = (short)1597057092;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)129761281;
						if (num != 0)
						{
						}
						num = (short)315424768;
						if (num != 0)
						{
						}
						num = (short)359989248;
						short num3 = num;
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset._Max;
			}
			set
			{
				short num = (short)687734784;
				short num2 = num;
				num = (short)342780102;
				short num3 = num;
				num = (short)2022074566;
				switch (num3 == num)
				{
				}
				num = (short)1617559553;
				if (num != 0)
				{
				}
				num = (short)1000669184;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x002ED5FC File Offset: 0x002EB7FC
		public override int Min
		{
			get
			{
				short num = (short)864354304;
				short num2 = num;
				num = (short)1711169115;
				short num3 = num;
				num = (short)324165211;
				switch (num3 == num)
				{
				}
				num = (short)1771700225;
				if (num != 0)
				{
				}
				num = (short)841875456;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset._Min;
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06002FD3 RID: 12243 RVA: 0x002ED6AC File Offset: 0x002EB8AC
		// (set) Token: 0x06002FD4 RID: 12244 RVA: 0x002ED758 File Offset: 0x002EB958
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2138505216;
				short num2 = num;
				num = (short)1843732106;
				short num3 = num;
				num = (short)412884618;
				switch (num3 == num)
				{
				}
				num = (short)1878392833;
				if (num != 0)
				{
				}
				num = (short)2018967552;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2119892992;
				short num2 = num;
				num = (short)13172737;
				if (num != 0)
				{
				}
				num = (short)2031824871;
				short num3 = num;
				num = (short)1770794983;
				switch (num3 == num)
				{
				}
				num = (short)1901985792;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x002ED808 File Offset: 0x002EBA08
		public bool HasDiffs
		{
			get
			{
				short num = (short)1366425600;
				short num2 = num;
				num = (short)1307700260;
				short num3 = num;
				num = (short)1928326180;
				switch (num3 == num)
				{
				}
				num = (short)141754369;
				if (num != 0)
				{
				}
				num = (short)1248985088;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x002ED8B8 File Offset: 0x002EBAB8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1336082432;
			short num2 = num;
			num = (short)1558324728;
			short num3 = num;
			num = (short)150414840;
			switch (num3 == num)
			{
			}
			num = (short)138412033;
			if (num != 0)
			{
			}
			num = (short)1193934848;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner(this);
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x002ED968 File Offset: 0x002EBB68
		internal void SetValues()
		{
			short num = (short)1757151232;
			short num2 = num;
			num = (short)1562211219;
			short num3 = num;
			num = (short)900756371;
			switch (num3 == num)
			{
			}
			num = (short)907149313;
			if (num != 0)
			{
			}
			num = (short)844890112;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_FCCNARROWBANDINGFREQUENCYSPLIT;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x002EDA34 File Offset: 0x002EBC34
		// Note: this type is marked as 'beforefieldinit'.
		static FCCNarrowBandingFrequencySplitInnerRecset()
		{
			short num = (short)792461312;
			short num2 = num;
			num = (short)1533922572;
			short num3 = num;
			num = (short)2036845836;
			switch (num3 == num)
			{
			}
			num = (short)1480130560;
			if (num != 0)
			{
			}
			num = (short)1783824385;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset._Min = 1;
		}

		// Token: 0x04001164 RID: 4452
		public static int _MaxPool;

		// Token: 0x04001165 RID: 4453
		public static int _Max;

		// Token: 0x04001166 RID: 4454
		public int _DynMax;

		// Token: 0x04001167 RID: 4455
		public static int _Min;

		// Token: 0x04001168 RID: 4456
		public static int _DefaultRecordCount;
	}
}
