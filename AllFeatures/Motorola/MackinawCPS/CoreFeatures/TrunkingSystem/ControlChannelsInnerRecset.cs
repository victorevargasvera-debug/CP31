using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200006F RID: 111
	[global::System.Serializable]
	public class ControlChannelsInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06000C27 RID: 3111 RVA: 0x000CAFDC File Offset: 0x000C91DC
		public ControlChannelsInnerRecset() : base(global::CommonResources.AcgResources.ID_CONTROLCHANNELS)
		{
			this.SetValues();
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000CAFFC File Offset: 0x000C91FC
		public ControlChannelsInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x000CB028 File Offset: 0x000C9228
		public override int MaxPool
		{
			get
			{
				short num = (short)44517201;
				short num2 = num;
				num = (short)776423249;
				switch (num2 == num)
				{
				}
				num = (short)1571749888;
				if (num != 0)
				{
				}
				num = (short)1111818241;
				if (num != 0)
				{
				}
				num = (short)80150528;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset._MaxPool;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000CB0D8 File Offset: 0x000C92D8
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x000CB198 File Offset: 0x000C9398
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)1954254673;
					short num2 = num;
					num = (short)425430865;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1940455424;
						short num3 = num;
						num = (short)502988801;
						if (num != 0)
						{
						}
						num = (short)1825832960;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset._Max;
			}
			set
			{
				short num = (short)1185835646;
				short num2 = num;
				num = (short)518875774;
				switch (num2 == num)
				{
				}
				num = (short)878247937;
				if (num != 0)
				{
				}
				num = (short)2105933824;
				if (num != 0)
				{
				}
				num = (short)1615069184;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x000CB248 File Offset: 0x000C9448
		public override int Min
		{
			get
			{
				short num = (short)1192269242;
				short num2 = num;
				num = (short)1760794042;
				switch (num2 == num)
				{
				}
				num = (short)1663565825;
				if (num != 0)
				{
				}
				num = (short)1327890432;
				if (num != 0)
				{
				}
				num = (short)173867008;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset._Min;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x000CB2F8 File Offset: 0x000C94F8
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x000CB3A4 File Offset: 0x000C95A4
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1650179311;
				short num2 = num;
				num = (short)1240972527;
				switch (num2 == num)
				{
				}
				num = (short)741277697;
				if (num != 0)
				{
				}
				num = (short)190775296;
				if (num != 0)
				{
				}
				num = (short)2000027648;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2021130241;
				if (num != 0)
				{
				}
				num = (short)211857582;
				short num2 = num;
				num = (short)812822702;
				switch (num2 == num)
				{
				}
				num = (short)106299392;
				if (num != 0)
				{
				}
				num = (short)1561526272;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x000CB454 File Offset: 0x000C9654
		public bool HasDiffs
		{
			get
			{
				short num = (short)1294441269;
				short num2 = num;
				num = (short)581212981;
				switch (num2 == num)
				{
				}
				num = (short)1720713217;
				if (num != 0)
				{
				}
				num = (short)1985085440;
				if (num != 0)
				{
				}
				num = (short)1534590976;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000CB500 File Offset: 0x000C9700
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1889162023;
			short num2 = num;
			num = (short)1923633959;
			switch (num2 == num)
			{
			}
			num = (short)499646464;
			if (num != 0)
			{
			}
			num = (short)714539009;
			if (num != 0)
			{
			}
			num = (short)1129119744;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInner(this);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x000CB5B0 File Offset: 0x000C97B0
		internal void SetValues()
		{
			short num = (short)848805017;
			short num2 = num;
			num = (short)1788132505;
			switch (num2 == num)
			{
			}
			num = (short)1970012160;
			if (num != 0)
			{
			}
			num = (short)606208000;
			short num3 = num;
			num = (short)900071425;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLCHANNELS;
			base.DataTransferOrder = 43;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000CB678 File Offset: 0x000C9878
		// Note: this type is marked as 'beforefieldinit'.
		static ControlChannelsInnerRecset()
		{
			short num = (short)1804254901;
			short num2 = num;
			num = (short)1823260341;
			switch (num2 == num)
			{
			}
			num = (short)704905217;
			if (num != 0)
			{
			}
			num = (short)692518912;
			short num3 = num;
			num = (short)14286848;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset._Min = 1;
		}

		// Token: 0x04000353 RID: 851
		public static int _MaxPool;

		// Token: 0x04000354 RID: 852
		public static int _Max;

		// Token: 0x04000355 RID: 853
		public int _DynMax;

		// Token: 0x04000356 RID: 854
		public static int _Min;

		// Token: 0x04000357 RID: 855
		public static int _DefaultRecordCount;
	}
}
