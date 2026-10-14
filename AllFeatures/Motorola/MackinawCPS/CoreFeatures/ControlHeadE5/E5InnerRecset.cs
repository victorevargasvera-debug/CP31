using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003F7 RID: 1015
	[global::System.Serializable]
	public class E5InnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008D25 RID: 36133 RVA: 0x00846390 File Offset: 0x00844590
		public E5InnerRecset() : base(global::CommonResources.AcgResources.ID_E5)
		{
			this.SetValues();
		}

		// Token: 0x06008D26 RID: 36134 RVA: 0x008463B0 File Offset: 0x008445B0
		public E5InnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700475C RID: 18268
		// (get) Token: 0x06008D27 RID: 36135 RVA: 0x008463DC File Offset: 0x008445DC
		public override int MaxPool
		{
			get
			{
				short num = (short)768979571;
				short num2 = num;
				num = (short)2102375027;
				switch (num2 == num)
				{
				}
				num = (short)807796736;
				short num3 = num;
				num = (short)1757085696;
				if (num != 0)
				{
				}
				num = (short)81788929;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset._MaxPool;
			}
		}

		// Token: 0x1700475D RID: 18269
		// (get) Token: 0x06008D28 RID: 36136 RVA: 0x0084648C File Offset: 0x0084468C
		// (set) Token: 0x06008D29 RID: 36137 RVA: 0x0084654C File Offset: 0x0084474C
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					num = (short)89191343;
					short num2 = num;
					num = (short)2057237423;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1077477376;
						if (num != 0)
						{
						}
						num = (short)280428544;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset._Max;
					}
					}
				}
				num = (short)1539833857;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)353096489;
				short num2 = num;
				num = (short)1336922921;
				switch (num2 == num)
				{
				}
				num = (short)1398472704;
				short num3 = num;
				num = (short)1391984641;
				if (num != 0)
				{
				}
				num = (short)1269235712;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700475E RID: 18270
		// (get) Token: 0x06008D2A RID: 36138 RVA: 0x00846600 File Offset: 0x00844800
		public override int Min
		{
			get
			{
				short num = (short)1859085037;
				short num2 = num;
				num = (short)378561261;
				switch (num2 == num)
				{
				}
				num = (short)1928396800;
				short num3 = num;
				num = (short)46202880;
				if (num != 0)
				{
				}
				num = (short)1101398017;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset._Min;
			}
		}

		// Token: 0x1700475F RID: 18271
		// (get) Token: 0x06008D2B RID: 36139 RVA: 0x008466B0 File Offset: 0x008448B0
		// (set) Token: 0x06008D2C RID: 36140 RVA: 0x0084675C File Offset: 0x0084495C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)341810176;
				short num2 = num;
				num = (short)2133826560;
				switch (num2 == num)
				{
				}
				num = (short)208797696;
				short num3 = num;
				num = (short)27525121;
				if (num != 0)
				{
				}
				num = (short)518586368;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1688875953;
				short num2 = num;
				num = (short)383792049;
				switch (num2 == num)
				{
				}
				num = (short)955580416;
				short num3 = num;
				num = (short)501481473;
				if (num != 0)
				{
				}
				num = (short)1084489728;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004760 RID: 18272
		// (get) Token: 0x06008D2D RID: 36141 RVA: 0x0084680C File Offset: 0x00844A0C
		public bool HasDiffs
		{
			get
			{
				short num = (short)2057974691;
				short num2 = num;
				num = (short)1825780643;
				switch (num2 == num)
				{
				}
				num = (short)180617216;
				short num3 = num;
				num = (short)785317888;
				if (num != 0)
				{
				}
				num = (short)1000669185;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008D2E RID: 36142 RVA: 0x008468BC File Offset: 0x00844ABC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)257057267;
			short num2 = num;
			num = (short)1844077043;
			switch (num2 == num)
			{
			}
			num = (short)1379794944;
			short num3 = num;
			num = (short)389349377;
			if (num != 0)
			{
			}
			num = (short)1560084480;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5Inner(this);
		}

		// Token: 0x06008D2F RID: 36143 RVA: 0x00846970 File Offset: 0x00844B70
		internal void SetValues()
		{
			short num = (short)450178901;
			short num2 = num;
			num = (short)257699669;
			switch (num2 == num)
			{
			}
			num = (short)834732032;
			short num3 = num;
			num = (short)961478657;
			if (num != 0)
			{
			}
			num = (short)1524695040;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_E5;
			base.DataTransferOrder = 65;
		}

		// Token: 0x06008D30 RID: 36144 RVA: 0x00846A38 File Offset: 0x00844C38
		// Note: this type is marked as 'beforefieldinit'.
		static E5InnerRecset()
		{
			short num = (short)688000432;
			short num2 = num;
			num = (short)333581744;
			switch (num2 == num)
			{
			}
			num = (short)668729344;
			short num3 = num;
			num = (short)1927806976;
			if (num != 0)
			{
			}
			num = (short)578945025;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset._Min = 1;
		}

		// Token: 0x0400457F RID: 17791
		public static int _MaxPool;

		// Token: 0x04004580 RID: 17792
		public static int _Max;

		// Token: 0x04004581 RID: 17793
		public int _DynMax;

		// Token: 0x04004582 RID: 17794
		public static int _Min;

		// Token: 0x04004583 RID: 17795
		public static int _DefaultRecordCount;
	}
}
