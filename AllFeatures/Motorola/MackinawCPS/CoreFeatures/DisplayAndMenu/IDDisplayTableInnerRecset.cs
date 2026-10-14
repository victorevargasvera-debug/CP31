using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x0200028F RID: 655
	[global::System.Serializable]
	public class IDDisplayTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007319 RID: 29465 RVA: 0x006641CC File Offset: 0x006623CC
		public IDDisplayTableInnerRecset() : base(global::CommonResources.AcgResources.ID_IDDISPLAYTABLE)
		{
			this.SetValues();
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x006641EC File Offset: 0x006623EC
		public IDDisplayTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0600731B RID: 29467 RVA: 0x00664218 File Offset: 0x00662418
		public override int MaxPool
		{
			get
			{
				short num = (short)1315569664;
				short num2 = num;
				num = (short)1096088089;
				short num3 = num;
				num = (short)900135449;
				switch (num3 == num)
				{
				}
				num = (short)1664876545;
				if (num != 0)
				{
				}
				num = (short)1081933824;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x0600731C RID: 29468 RVA: 0x006642C4 File Offset: 0x006624C4
		// (set) Token: 0x0600731D RID: 29469 RVA: 0x00664388 File Offset: 0x00662588
		public override int Max
		{
			get
			{
				short num = (short)233963520;
				short num2 = num;
				num = (short)1767062667;
				short num3 = num;
				num = (short)824851595;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1496055809;
					if (num != 0)
					{
					}
					num = (short)1619197952;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._Max;
			}
			set
			{
				short num = (short)1124073472;
				short num2 = num;
				num = (short)1026182998;
				short num3 = num;
				num = (short)1133006678;
				switch (num3 == num)
				{
				}
				num = (short)979632129;
				if (num != 0)
				{
				}
				num = (short)349569024;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x0600731E RID: 29470 RVA: 0x00664438 File Offset: 0x00662638
		public override int Min
		{
			get
			{
				short num = (short)1451556864;
				short num2 = num;
				num = (short)669201090;
				short num3 = num;
				num = (short)1250964162;
				switch (num3 == num)
				{
				}
				num = (short)1536229377;
				if (num != 0)
				{
				}
				num = (short)1362231296;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._Min;
			}
		}

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x0600731F RID: 29471 RVA: 0x006644E8 File Offset: 0x006626E8
		// (set) Token: 0x06007320 RID: 29472 RVA: 0x00664598 File Offset: 0x00662798
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2044854272;
				short num2 = num;
				num = (short)1180002154;
				short num3 = num;
				num = (short)3368810;
				switch (num3 == num)
				{
				}
				num = (short)1195180033;
				if (num != 0)
				{
				}
				num = (short)288489472;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2024079360;
				short num2 = num;
				num = (short)245775624;
				short num3 = num;
				num = (short)582958344;
				switch (num3 == num)
				{
				}
				num = (short)765722625;
				if (num != 0)
				{
				}
				num = (short)1709375488;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x06007321 RID: 29473 RVA: 0x00664648 File Offset: 0x00662848
		public bool HasDiffs
		{
			get
			{
				short num = (short)2114060288;
				short num2 = num;
				num = (short)417313843;
				short num3 = num;
				num = (short)385594419;
				switch (num3 == num)
				{
				}
				num = (short)1150091265;
				if (num != 0)
				{
				}
				num = (short)619380736;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x006646F8 File Offset: 0x006628F8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)868548608;
			short num2 = num;
			num = (short)996127102;
			short num3 = num;
			num = (short)1034137982;
			switch (num3 == num)
			{
			}
			num = (short)1732050945;
			if (num != 0)
			{
			}
			num = (short)726859776;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInner(this);
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x006647A8 File Offset: 0x006629A8
		internal void SetValues()
		{
			short num = (short)1682440192;
			short num2 = num;
			num = (short)405954075;
			short num3 = num;
			num = (short)848649755;
			switch (num3 == num)
			{
			}
			num = (short)1320353792;
			if (num != 0)
			{
			}
			num = (short)859045889;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_IDDISPLAYTABLE;
			base.DataTransferOrder = 25;
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00664874 File Offset: 0x00662A74
		// Note: this type is marked as 'beforefieldinit'.
		static IDDisplayTableInnerRecset()
		{
			short num = (short)1065418752;
			short num2 = num;
			num = (short)1913749387;
			short num3 = num;
			num = (short)697139083;
			switch (num3 == num)
			{
			}
			num = (short)1363476481;
			if (num != 0)
			{
			}
			num = (short)220594176;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._Min = 1;
		}

		// Token: 0x04002D01 RID: 11521
		public static int _MaxPool;

		// Token: 0x04002D02 RID: 11522
		public static int _Max;

		// Token: 0x04002D03 RID: 11523
		public int _DynMax;

		// Token: 0x04002D04 RID: 11524
		public static int _Min;

		// Token: 0x04002D05 RID: 11525
		public static int _DefaultRecordCount;
	}
}
