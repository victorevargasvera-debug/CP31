using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000458 RID: 1112
	[global::System.Serializable]
	public class RxSSIClockRateListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600942E RID: 37934 RVA: 0x008B9698 File Offset: 0x008B7898
		public RxSSIClockRateListInnerRecset() : base(global::CommonResources.AcgResources.ID_RXSSICLOCKRATELIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x0600942F RID: 37935 RVA: 0x008B96BC File Offset: 0x008B78BC
		public RxSSIClockRateListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004A94 RID: 19092
		// (get) Token: 0x06009430 RID: 37936 RVA: 0x008B96E8 File Offset: 0x008B78E8
		public override int MaxPool
		{
			get
			{
				short num = (short)1886060544;
				short num2 = num;
				num = (short)1066238176;
				short num3 = num;
				num = (short)1040613600;
				switch (num3 == num)
				{
				}
				num = (short)989069313;
				if (num != 0)
				{
				}
				num = (short)423428096;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004A95 RID: 19093
		// (get) Token: 0x06009431 RID: 37937 RVA: 0x008B9794 File Offset: 0x008B7994
		// (set) Token: 0x06009432 RID: 37938 RVA: 0x008B9854 File Offset: 0x008B7A54
		public override int Max
		{
			get
			{
				short num;
				while (this._DynMax != -1)
				{
					num = (short)963969025;
					if (num != 0)
					{
					}
					num = (short)1837752550;
					short num2 = num;
					num = (short)1808195814;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)435486720;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)128647168;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset._Max;
			}
			set
			{
				short num = (short)996671488;
				short num2 = num;
				num = (short)819299796;
				short num3 = num;
				num = (short)1843824084;
				switch (num3 == num)
				{
				}
				num = (short)2069364737;
				if (num != 0)
				{
				}
				num = (short)1069809664;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004A96 RID: 19094
		// (get) Token: 0x06009433 RID: 37939 RVA: 0x008B9904 File Offset: 0x008B7B04
		public override int Min
		{
			get
			{
				short num = (short)1002373120;
				short num2 = num;
				num = (short)669344802;
				short num3 = num;
				num = (short)21062690;
				switch (num3 == num)
				{
				}
				num = (short)305397760;
				if (num != 0)
				{
				}
				num = (short)233504769;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset._Min;
			}
		}

		// Token: 0x17004A97 RID: 19095
		// (get) Token: 0x06009434 RID: 37940 RVA: 0x008B99B0 File Offset: 0x008B7BB0
		// (set) Token: 0x06009435 RID: 37941 RVA: 0x008B9A5C File Offset: 0x008B7C5C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1953628160;
				short num2 = num;
				num = (short)865642154;
				short num3 = num;
				num = (short)752068266;
				switch (num3 == num)
				{
				}
				num = (short)1988034561;
				if (num != 0)
				{
				}
				num = (short)1943994368;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)951255040;
				short num2 = num;
				num = (short)1254096897;
				if (num != 0)
				{
				}
				num = (short)1491038041;
				short num3 = num;
				num = (short)1046376281;
				switch (num3 == num)
				{
				}
				num = (short)1096220672;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004A98 RID: 19096
		// (get) Token: 0x06009436 RID: 37942 RVA: 0x008B9B0C File Offset: 0x008B7D0C
		public bool HasDiffs
		{
			get
			{
				short num = (short)585105408;
				short num2 = num;
				num = (short)185925633;
				if (num != 0)
				{
				}
				num = (short)1174537372;
				short num3 = num;
				num = (short)620561564;
				switch (num3 == num)
				{
				}
				num = (short)36110336;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x008B9BBC File Offset: 0x008B7DBC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1926168576;
			short num2 = num;
			num = (short)2090005000;
			short num3 = num;
			num = (short)422769160;
			switch (num3 == num)
			{
			}
			num = (short)2028077056;
			if (num != 0)
			{
			}
			num = (short)1173618689;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInner(this);
		}

		// Token: 0x06009438 RID: 37944 RVA: 0x008B9C6C File Offset: 0x008B7E6C
		internal void SetValues()
		{
			short num = (short)1743650816;
			short num2 = num;
			num = (short)1923312761;
			short num3 = num;
			num = (short)598895737;
			switch (num3 == num)
			{
			}
			num = (short)1021181953;
			if (num != 0)
			{
			}
			num = (short)426377216;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06009439 RID: 37945 RVA: 0x008B9D34 File Offset: 0x008B7F34
		// Note: this type is marked as 'beforefieldinit'.
		static RxSSIClockRateListInnerRecset()
		{
			short num = (short)1364459520;
			short num2 = num;
			num = (short)714302139;
			short num3 = num;
			num = (short)1334862523;
			switch (num3 == num)
			{
			}
			num = (short)1061683201;
			if (num != 0)
			{
			}
			num = (short)1432551424;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset._Min = 1;
		}

		// Token: 0x040049E5 RID: 18917
		public static int _MaxPool;

		// Token: 0x040049E6 RID: 18918
		public static int _Max;

		// Token: 0x040049E7 RID: 18919
		public int _DynMax;

		// Token: 0x040049E8 RID: 18920
		public static int _Min;

		// Token: 0x040049E9 RID: 18921
		public static int _DefaultRecordCount;
	}
}
