using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002C2 RID: 706
	[global::System.Serializable]
	public class TrunkingSwitchTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600765F RID: 30303 RVA: 0x006ACBC4 File Offset: 0x006AADC4
		public TrunkingSwitchTableInnerRecset() : base(global::CommonResources.AcgResources.ID_TRUNKINGSWITCHTABLE, global::CommonResources.AcgResources.ID_TRKSWITCH)
		{
			this.SetValues();
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x006ACBE8 File Offset: 0x006AADE8
		public TrunkingSwitchTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x06007661 RID: 30305 RVA: 0x006ACC14 File Offset: 0x006AAE14
		public override int MaxPool
		{
			get
			{
				short num = (short)363681188;
				short num2 = num;
				num = (short)257840548;
				switch (num2 == num)
				{
				}
				num = (short)1883045888;
				short num3 = num;
				num = (short)160169985;
				if (num != 0)
				{
				}
				num = (short)1564082176;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x06007662 RID: 30306 RVA: 0x006ACCC0 File Offset: 0x006AAEC0
		// (set) Token: 0x06007663 RID: 30307 RVA: 0x006ACD88 File Offset: 0x006AAF88
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)1115673297;
					short num2 = num;
					num = (short)777835217;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)989069313;
						if (num != 0)
						{
						}
						num = (short)1795227648;
						if (num != 0)
						{
						}
						num = (short)480182272;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)2017559952;
				short num2 = num;
				num = (short)808158608;
				switch (num2 == num)
				{
				}
				num = (short)888078336;
				short num3 = num;
				num = (short)1172439041;
				if (num != 0)
				{
				}
				num = (short)391315456;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x06007664 RID: 30308 RVA: 0x006ACE38 File Offset: 0x006AB038
		public override int Min
		{
			get
			{
				short num = (short)1632331500;
				short num2 = num;
				num = (short)1616996076;
				switch (num2 == num)
				{
				}
				num = (short)118423552;
				short num3 = num;
				num = (short)1680801793;
				if (num != 0)
				{
				}
				num = (short)1842610176;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset._Min;
			}
		}

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x06007665 RID: 30309 RVA: 0x006ACEE8 File Offset: 0x006AB0E8
		// (set) Token: 0x06007666 RID: 30310 RVA: 0x006ACF98 File Offset: 0x006AB198
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1507766760;
				short num2 = num;
				num = (short)1907208680;
				switch (num2 == num)
				{
				}
				num = (short)2028666880;
				short num3 = num;
				num = (short)616103937;
				if (num != 0)
				{
				}
				num = (short)1416495104;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2132379283;
				short num2 = num;
				num = (short)1933608595;
				switch (num2 == num)
				{
				}
				num = (short)2137260032;
				short num3 = num;
				num = (short)233177089;
				if (num != 0)
				{
				}
				num = (short)961740800;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x06007667 RID: 30311 RVA: 0x006AD048 File Offset: 0x006AB248
		public bool HasDiffs
		{
			get
			{
				short num = (short)2117904795;
				short num2 = num;
				num = (short)1494067611;
				switch (num2 == num)
				{
				}
				num = (short)438173696;
				short num3 = num;
				num = (short)1266745345;
				if (num != 0)
				{
				}
				num = (short)1105920000;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x006AD0F8 File Offset: 0x006AB2F8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1890022815;
			short num2 = num;
			num = (short)154957215;
			switch (num2 == num)
			{
			}
			num = (short)1868234752;
			short num3 = num;
			num = (short)1839398913;
			if (num != 0)
			{
			}
			num = (short)62062592;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner(this);
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x006AD1A8 File Offset: 0x006AB3A8
		internal void SetValues()
		{
			short num = (short)1133741162;
			short num2 = num;
			num = (short)1249477738;
			switch (num2 == num)
			{
			}
			num = (short)1350303744;
			short num3 = num;
			num = (short)1033175041;
			if (num != 0)
			{
			}
			num = (short)580780032;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSWITCHTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_TRKSWITCH;
			base.DataTransferOrder = 24;
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x006AD280 File Offset: 0x006AB480
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingSwitchTableInnerRecset()
		{
			short num = (short)1828867722;
			short num2 = num;
			num = (short)1906724490;
			switch (num2 == num)
			{
			}
			num = (short)1528496128;
			short num3 = num;
			num = (short)62521344;
			if (num != 0)
			{
			}
			num = (short)1255145473;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset._Min = 1;
		}

		// Token: 0x04003086 RID: 12422
		public static int _MaxPool;

		// Token: 0x04003087 RID: 12423
		public static int _Max;

		// Token: 0x04003088 RID: 12424
		public int _DynMax;

		// Token: 0x04003089 RID: 12425
		public static int _Min;

		// Token: 0x0400308A RID: 12426
		public static int _DefaultRecordCount;
	}
}
