using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003B6 RID: 950
	[global::System.Serializable]
	public class O5NavigationControlsTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008932 RID: 35122 RVA: 0x007FBC5C File Offset: 0x007F9E5C
		public O5NavigationControlsTableInnerRecset() : base(global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS)
		{
			this.SetValues();
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x007FBC7C File Offset: 0x007F9E7C
		public O5NavigationControlsTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170045A7 RID: 17831
		// (get) Token: 0x06008934 RID: 35124 RVA: 0x007FBCA8 File Offset: 0x007F9EA8
		public override int MaxPool
		{
			get
			{
				short num = (short)1835439585;
				short num2 = num;
				num = (short)100767201;
				switch (num2 == num)
				{
				}
				num = (short)10158081;
				if (num != 0)
				{
				}
				num = (short)57671680;
				short num3 = num;
				num = (short)768540672;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x170045A8 RID: 17832
		// (get) Token: 0x06008935 RID: 35125 RVA: 0x007FBD58 File Offset: 0x007F9F58
		// (set) Token: 0x06008936 RID: 35126 RVA: 0x007FBE14 File Offset: 0x007FA014
		public override int Max
		{
			get
			{
				short num = (short)267024851;
				short num2 = num;
				num = (short)1249540563;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1454505984;
					short num3 = num;
					num = (short)368508929;
					if (num != 0)
					{
					}
					num = (short)892403712;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset._Max;
			}
			set
			{
				short num = (short)733676281;
				short num2 = num;
				num = (short)142869241;
				switch (num2 == num)
				{
				}
				num = (short)1415184384;
				if (num != 0)
				{
				}
				num = (short)1465843712;
				short num3 = num;
				num = (short)392036353;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170045A9 RID: 17833
		// (get) Token: 0x06008937 RID: 35127 RVA: 0x007FBEC4 File Offset: 0x007FA0C4
		public override int Min
		{
			get
			{
				short num = (short)1197547448;
				short num2 = num;
				num = (short)812982200;
				switch (num2 == num)
				{
				}
				num = (short)128581633;
				if (num != 0)
				{
				}
				num = (short)1815150592;
				short num3 = num;
				num = (short)1580072960;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset._Min;
			}
		}

		// Token: 0x170045AA RID: 17834
		// (get) Token: 0x06008938 RID: 35128 RVA: 0x007FBF70 File Offset: 0x007FA170
		// (set) Token: 0x06008939 RID: 35129 RVA: 0x007FC020 File Offset: 0x007FA220
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)477233153;
				if (num != 0)
				{
				}
				num = (short)1428590397;
				short num2 = num;
				num = (short)871206717;
				switch (num2 == num)
				{
				}
				num = (short)1562443776;
				short num3 = num;
				num = (short)1447624704;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1619518480;
				short num2 = num;
				num = (short)638379024;
				switch (num2 == num)
				{
				}
				num = (short)71237633;
				if (num != 0)
				{
				}
				num = (short)1265041408;
				short num3 = num;
				num = (short)805175296;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170045AB RID: 17835
		// (get) Token: 0x0600893A RID: 35130 RVA: 0x007FC0D4 File Offset: 0x007FA2D4
		public bool HasDiffs
		{
			get
			{
				short num = (short)165034038;
				short num2 = num;
				num = (short)908605494;
				switch (num2 == num)
				{
				}
				num = (short)1969291265;
				if (num != 0)
				{
				}
				num = (short)1268449280;
				short num3 = num;
				num = (short)377749504;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600893B RID: 35131 RVA: 0x007FC188 File Offset: 0x007FA388
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1908138560;
			short num2 = num;
			num = (short)1579934272;
			switch (num2 == num)
			{
			}
			num = (short)867631105;
			if (num != 0)
			{
			}
			num = (short)99549184;
			short num3 = num;
			num = (short)1654521856;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInner(this);
		}

		// Token: 0x0600893C RID: 35132 RVA: 0x007FC23C File Offset: 0x007FA43C
		internal void SetValues()
		{
			short num = (short)814476487;
			short num2 = num;
			num = (short)1311501511;
			switch (num2 == num)
			{
			}
			num = (short)1037959169;
			if (num != 0)
			{
			}
			num = (short)1120534528;
			short num3 = num;
			num = (short)1306984448;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 16;
		}

		// Token: 0x0600893D RID: 35133 RVA: 0x007FC308 File Offset: 0x007FA508
		// Note: this type is marked as 'beforefieldinit'.
		static O5NavigationControlsTableInnerRecset()
		{
			short num = (short)1244183686;
			short num2 = num;
			num = (short)1383971974;
			switch (num2 == num)
			{
			}
			num = (short)1090584576;
			if (num != 0)
			{
			}
			num = (short)381091840;
			short num3 = num;
			num = (short)25493505;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset._Min = 1;
		}

		// Token: 0x040040E8 RID: 16616
		public static int _MaxPool;

		// Token: 0x040040E9 RID: 16617
		public static int _Max;

		// Token: 0x040040EA RID: 16618
		public int _DynMax;

		// Token: 0x040040EB RID: 16619
		public static int _Min;

		// Token: 0x040040EC RID: 16620
		public static int _DefaultRecordCount;
	}
}
