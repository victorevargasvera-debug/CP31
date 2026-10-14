using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001EA RID: 490
	[global::System.Serializable]
	public class TrunkingProductIndependentButtonListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600553D RID: 21821 RVA: 0x004D5620 File Offset: 0x004D3820
		public TrunkingProductIndependentButtonListInnerRecset() : base(global::CommonResources.AcgResources.ID_TRUNKINGPRODUCTINDEPENDENTBUTTONLIST, global::CommonResources.AcgResources.ID_TRKBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x004D5644 File Offset: 0x004D3844
		public TrunkingProductIndependentButtonListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x0600553F RID: 21823 RVA: 0x004D5670 File Offset: 0x004D3870
		public override int MaxPool
		{
			get
			{
				short num = (short)1697012583;
				short num2 = num;
				num = (short)1033329511;
				switch (num2 == num)
				{
				}
				num = (short)1228734464;
				short num3 = num;
				num = (short)1620705281;
				if (num != 0)
				{
				}
				num = (short)1717895168;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x06005540 RID: 21824 RVA: 0x004D5720 File Offset: 0x004D3920
		// (set) Token: 0x06005541 RID: 21825 RVA: 0x004D57E0 File Offset: 0x004D39E0
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)1954148247;
					short num2 = num;
					num = (short)1719267223;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1422983168;
						short num3 = num;
						num = (short)674299904;
						if (num != 0)
						{
						}
						num = (short)482738177;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset._Max;
			}
			set
			{
				short num = (short)1476756442;
				short num2 = num;
				num = (short)1471972314;
				switch (num2 == num)
				{
				}
				num = (short)1952972800;
				short num3 = num;
				num = (short)463732737;
				if (num != 0)
				{
				}
				num = (short)567017472;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x06005542 RID: 21826 RVA: 0x004D5894 File Offset: 0x004D3A94
		public override int Min
		{
			get
			{
				short num = (short)996829134;
				short num2 = num;
				num = (short)409888718;
				switch (num2 == num)
				{
				}
				num = (short)472449024;
				short num3 = num;
				num = (short)2109341696;
				if (num != 0)
				{
				}
				num = (short)32112641;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset._Min;
			}
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x06005543 RID: 21827 RVA: 0x004D5940 File Offset: 0x004D3B40
		// (set) Token: 0x06005544 RID: 21828 RVA: 0x004D59F0 File Offset: 0x004D3BF0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)852009750;
				short num2 = num;
				num = (short)1833411350;
				switch (num2 == num)
				{
				}
				num = (short)930086912;
				short num3 = num;
				num = (short)217317377;
				if (num != 0)
				{
				}
				num = (short)1459159040;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)455251123;
				short num2 = num;
				num = (short)169383091;
				switch (num2 == num)
				{
				}
				num = (short)1466368000;
				short num3 = num;
				num = (short)1104412672;
				if (num != 0)
				{
				}
				num = (short)1986592769;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x06005545 RID: 21829 RVA: 0x004D5A9C File Offset: 0x004D3C9C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1166871446;
				short num2 = num;
				num = (short)2097744790;
				switch (num2 == num)
				{
				}
				num = (short)1220739072;
				short num3 = num;
				num = (short)1546059776;
				if (num != 0)
				{
				}
				num = (short)828702721;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x004D5B50 File Offset: 0x004D3D50
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1474999285;
			short num2 = num;
			num = (short)130266101;
			switch (num2 == num)
			{
			}
			num = (short)1211301888;
			short num3 = num;
			num = (short)680853505;
			if (num != 0)
			{
			}
			num = (short)467140608;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInner(this);
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x004D5C00 File Offset: 0x004D3E00
		internal void SetValues()
		{
			short num = (short)1220126545;
			short num2 = num;
			num = (short)1387898705;
			switch (num2 == num)
			{
			}
			num = (short)1399128064;
			short num3 = num;
			num = (short)58392577;
			if (num != 0)
			{
			}
			num = (short)734461952;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGPRODUCTINDEPENDENTBUTTONLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_TRKBUTTON;
			base.DataTransferOrder = 22;
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x004D5CD4 File Offset: 0x004D3ED4
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingProductIndependentButtonListInnerRecset()
		{
			short num = (short)1186216266;
			short num2 = num;
			num = (short)402995530;
			switch (num2 == num)
			{
			}
			num = (short)1105264640;
			short num3 = num;
			num = (short)519176193;
			if (num != 0)
			{
			}
			num = (short)1815347200;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset._Min = 1;
		}

		// Token: 0x04002174 RID: 8564
		public static int _MaxPool;

		// Token: 0x04002175 RID: 8565
		public static int _Max;

		// Token: 0x04002176 RID: 8566
		public int _DynMax;

		// Token: 0x04002177 RID: 8567
		public static int _Min;

		// Token: 0x04002178 RID: 8568
		public static int _DefaultRecordCount;
	}
}
