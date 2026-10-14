using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001EE RID: 494
	[global::System.Serializable]
	public class TrunkingShepherdListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06005573 RID: 21875 RVA: 0x004D7BD8 File Offset: 0x004D5DD8
		public TrunkingShepherdListInnerRecset() : base(global::CommonResources.AcgResources.ID_TRUNKINGSHEPHERDLIST, global::CommonResources.AcgResources.ID_TRKSHEPH)
		{
			this.SetValues();
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x004D7BFC File Offset: 0x004D5DFC
		public TrunkingShepherdListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x004D7C28 File Offset: 0x004D5E28
		public override int MaxPool
		{
			get
			{
				short num = (short)1783728479;
				short num2 = num;
				num = (short)761563487;
				switch (num2 == num)
				{
				}
				num = (short)612106240;
				short num3 = num;
				num = (short)1626079233;
				if (num != 0)
				{
				}
				num = (short)105381888;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x06005576 RID: 21878 RVA: 0x004D7CD8 File Offset: 0x004D5ED8
		// (set) Token: 0x06005577 RID: 21879 RVA: 0x004D7DA0 File Offset: 0x004D5FA0
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)1144455168;
					short num2 = num;
					num = (short)692158606;
					short num3 = num;
					num = (short)1508409486;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1358364672;
						if (num != 0)
						{
						}
						num = (short)655360001;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset._Max;
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)78279090;
				short num2 = num;
				num = (short)987918770;
				switch (num2 == num)
				{
				}
				num = (short)214695936;
				short num3 = num;
				num = (short)558301184;
				if (num != 0)
				{
				}
				num = (short)263716865;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x06005578 RID: 21880 RVA: 0x004D7E50 File Offset: 0x004D6050
		public override int Min
		{
			get
			{
				short num = (short)775018155;
				short num2 = num;
				num = (short)1247270571;
				switch (num2 == num)
				{
				}
				num = (short)20119552;
				short num3 = num;
				num = (short)414842881;
				if (num != 0)
				{
				}
				num = (short)944963584;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset._Min;
			}
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x06005579 RID: 21881 RVA: 0x004D7F00 File Offset: 0x004D6100
		// (set) Token: 0x0600557A RID: 21882 RVA: 0x004D7FB0 File Offset: 0x004D61B0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1934213419;
				short num2 = num;
				num = (short)331530539;
				switch (num2 == num)
				{
				}
				num = (short)2117664768;
				short num3 = num;
				num = (short)111738880;
				if (num != 0)
				{
				}
				num = (short)430702593;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1192995306;
				short num2 = num;
				num = (short)585542122;
				switch (num2 == num)
				{
				}
				num = (short)583991296;
				short num3 = num;
				num = (short)1738801152;
				if (num != 0)
				{
				}
				num = (short)838402049;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x0600557B RID: 21883 RVA: 0x004D8060 File Offset: 0x004D6260
		public bool HasDiffs
		{
			get
			{
				short num = (short)1405026305;
				if (num != 0)
				{
				}
				num = (short)13150421;
				short num2 = num;
				num = (short)382970069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)471334912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)13565952;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x004D8110 File Offset: 0x004D6310
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1450090555;
			short num2 = num;
			num = (short)1150853179;
			switch (num2 == num)
			{
			}
			num = (short)1094254592;
			short num3 = num;
			num = (short)1114177536;
			if (num != 0)
			{
			}
			num = (short)1569456129;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInner(this);
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x004D81C0 File Offset: 0x004D63C0
		internal void SetValues()
		{
			short num = (short)2033663243;
			short num2 = num;
			num = (short)2108767499;
			switch (num2 == num)
			{
			}
			num = (short)289341440;
			short num3 = num;
			num = (short)1998979073;
			if (num != 0)
			{
			}
			num = (short)1684799488;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSHEPHERDLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_TRKSHEPH;
			base.DataTransferOrder = 22;
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x004D8294 File Offset: 0x004D6494
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingShepherdListInnerRecset()
		{
			short num = (short)1618877150;
			short num2 = num;
			num = (short)578427614;
			switch (num2 == num)
			{
			}
			num = (short)347668480;
			short num3 = num;
			num = (short)689635329;
			if (num != 0)
			{
			}
			num = (short)1988427776;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset._Min = 1;
		}

		// Token: 0x0400217B RID: 8571
		public static int _MaxPool;

		// Token: 0x0400217C RID: 8572
		public static int _Max;

		// Token: 0x0400217D RID: 8573
		public int _DynMax;

		// Token: 0x0400217E RID: 8574
		public static int _Min;

		// Token: 0x0400217F RID: 8575
		public static int _DefaultRecordCount;
	}
}
