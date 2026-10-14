using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003CC RID: 972
	[global::System.Serializable]
	public class O3HHCHButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008A60 RID: 35424 RVA: 0x0081753C File Offset: 0x0081573C
		public O3HHCHButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_O3HHCHBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x0081755C File Offset: 0x0081575C
		public O3HHCHButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700462C RID: 17964
		// (get) Token: 0x06008A62 RID: 35426 RVA: 0x00817588 File Offset: 0x00815788
		public override int MaxPool
		{
			get
			{
				short num = (short)1687801668;
				short num2 = num;
				num = (short)619368260;
				switch (num2 == num)
				{
				}
				num = (short)102432768;
				if (num != 0)
				{
				}
				num = (short)55443456;
				short num3 = num;
				num = (short)562429953;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700462D RID: 17965
		// (get) Token: 0x06008A63 RID: 35427 RVA: 0x00817638 File Offset: 0x00815838
		// (set) Token: 0x06008A64 RID: 35428 RVA: 0x008176F8 File Offset: 0x008158F8
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)900960759;
					short num2 = num;
					num = (short)1779667447;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)933167104;
						short num3 = num;
						num = (short)1242562561;
						if (num != 0)
						{
						}
						num = (short)2012282880;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset._Max;
			}
			set
			{
				short num = (short)108932057;
				short num2 = num;
				num = (short)488516569;
				switch (num2 == num)
				{
				}
				num = (short)1786183681;
				if (num != 0)
				{
				}
				num = (short)752877568;
				short num3 = num;
				num = (short)2137194496;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700462E RID: 17966
		// (get) Token: 0x06008A65 RID: 35429 RVA: 0x008177A8 File Offset: 0x008159A8
		public override int Min
		{
			get
			{
				short num = (short)1953512963;
				short num2 = num;
				num = (short)596196867;
				switch (num2 == num)
				{
				}
				num = (short)297730049;
				if (num != 0)
				{
				}
				num = (short)1392443392;
				short num3 = num;
				num = (short)1551171584;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset._Min;
			}
		}

		// Token: 0x1700462F RID: 17967
		// (get) Token: 0x06008A66 RID: 35430 RVA: 0x00817858 File Offset: 0x00815A58
		// (set) Token: 0x06008A67 RID: 35431 RVA: 0x00817908 File Offset: 0x00815B08
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)731034000;
				short num2 = num;
				num = (short)636465552;
				switch (num2 == num)
				{
				}
				num = (short)16842753;
				if (num != 0)
				{
				}
				num = (short)2086862848;
				short num3 = num;
				num = (short)2109538304;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)431025673;
				short num2 = num;
				num = (short)1047129609;
				switch (num2 == num)
				{
				}
				num = (short)210632705;
				if (num != 0)
				{
				}
				num = (short)894500864;
				short num3 = num;
				num = (short)516882432;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004630 RID: 17968
		// (get) Token: 0x06008A68 RID: 35432 RVA: 0x008179B8 File Offset: 0x00815BB8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1453572625;
				short num2 = num;
				num = (short)1413726737;
				switch (num2 == num)
				{
				}
				num = (short)980549633;
				if (num != 0)
				{
				}
				num = (short)1977679872;
				short num3 = num;
				num = (short)926613504;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x00817A64 File Offset: 0x00815C64
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1904490357;
			short num2 = num;
			num = (short)2077767541;
			switch (num2 == num)
			{
			}
			num = (short)1094713344;
			if (num != 0)
			{
			}
			num = (short)1588199424;
			short num3 = num;
			num = (short)1366884353;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner(this);
		}

		// Token: 0x06008A6A RID: 35434 RVA: 0x00817B14 File Offset: 0x00815D14
		internal void SetValues()
		{
			short num = (short)1258851569;
			short num2 = num;
			num = (short)1371966705;
			switch (num2 == num)
			{
			}
			num = (short)298123265;
			if (num != 0)
			{
			}
			num = (short)1661206528;
			short num3 = num;
			num = (short)1816330240;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_O3HHCHBUTTON;
			base.DataTransferOrder = 17;
		}

		// Token: 0x06008A6B RID: 35435 RVA: 0x00817BE0 File Offset: 0x00815DE0
		// Note: this type is marked as 'beforefieldinit'.
		static O3HHCHButtonInnerRecset()
		{
			short num = (short)1434942243;
			short num2 = num;
			num = (short)2096855843;
			switch (num2 == num)
			{
			}
			num = (short)2118320129;
			if (num != 0)
			{
			}
			num = (short)489160704;
			short num3 = num;
			num = (short)487718912;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset._Min = 1;
		}

		// Token: 0x040042CF RID: 17103
		public static int _MaxPool;

		// Token: 0x040042D0 RID: 17104
		public static int _Max;

		// Token: 0x040042D1 RID: 17105
		public int _DynMax;

		// Token: 0x040042D2 RID: 17106
		public static int _Min;

		// Token: 0x040042D3 RID: 17107
		public static int _DefaultRecordCount;
	}
}
