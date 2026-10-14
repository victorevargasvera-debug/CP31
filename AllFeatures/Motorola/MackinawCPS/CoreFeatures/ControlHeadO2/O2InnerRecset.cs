using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003DE RID: 990
	[global::System.Serializable]
	public class O2InnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008B8E RID: 35726 RVA: 0x0082B174 File Offset: 0x00829374
		public O2InnerRecset() : base(global::CommonResources.AcgResources.ID_O2)
		{
			this.SetValues();
		}

		// Token: 0x06008B8F RID: 35727 RVA: 0x0082B194 File Offset: 0x00829394
		public O2InnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170046B0 RID: 18096
		// (get) Token: 0x06008B90 RID: 35728 RVA: 0x0082B1C0 File Offset: 0x008293C0
		public override int MaxPool
		{
			get
			{
				short num = (short)26034536;
				short num2 = num;
				num = (short)1173504360;
				switch (num2 == num)
				{
				}
				num = (short)309526529;
				if (num != 0)
				{
				}
				num = (short)1839202304;
				if (num != 0)
				{
				}
				num = (short)1621164032;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset._MaxPool;
			}
		}

		// Token: 0x170046B1 RID: 18097
		// (get) Token: 0x06008B91 RID: 35729 RVA: 0x0082B270 File Offset: 0x00829470
		// (set) Token: 0x06008B92 RID: 35730 RVA: 0x0082B330 File Offset: 0x00829530
		public override int Max
		{
			get
			{
				short num = (short)1656986316;
				short num2 = num;
				num = (short)1379244748;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1020264448;
					if (num != 0)
					{
					}
					if (this._DynMax == -1)
					{
						num = (short)196609;
						if (num != 0)
						{
						}
						num = (short)701628416;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset._Max;
					}
					break;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1234173953;
				if (num != 0)
				{
				}
				num = (short)553001061;
				short num2 = num;
				num = (short)1140727909;
				switch (num2 == num)
				{
				}
				num = (short)986185728;
				if (num != 0)
				{
				}
				num = (short)1866072064;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170046B2 RID: 18098
		// (get) Token: 0x06008B93 RID: 35731 RVA: 0x0082B3E0 File Offset: 0x008295E0
		public override int Min
		{
			get
			{
				short num = (short)1156900658;
				short num2 = num;
				num = (short)810608434;
				switch (num2 == num)
				{
				}
				num = (short)774504448;
				if (num != 0)
				{
				}
				num = (short)912850945;
				if (num != 0)
				{
				}
				num = (short)64159744;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset._Min;
			}
		}

		// Token: 0x170046B3 RID: 18099
		// (get) Token: 0x06008B94 RID: 35732 RVA: 0x0082B48C File Offset: 0x0082968C
		// (set) Token: 0x06008B95 RID: 35733 RVA: 0x0082B538 File Offset: 0x00829738
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)169321313;
				short num2 = num;
				num = (short)843293537;
				switch (num2 == num)
				{
				}
				num = (short)1375272961;
				if (num != 0)
				{
				}
				num = (short)871956480;
				if (num != 0)
				{
				}
				num = (short)2114322432;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1816330241;
				if (num != 0)
				{
				}
				num = (short)388992033;
				short num2 = num;
				num = (short)1336708129;
				switch (num2 == num)
				{
				}
				num = (short)662700032;
				if (num != 0)
				{
				}
				num = (short)485163008;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170046B4 RID: 18100
		// (get) Token: 0x06008B96 RID: 35734 RVA: 0x0082B5EC File Offset: 0x008297EC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1596391425;
				if (num != 0)
				{
				}
				num = (short)1982294227;
				short num2 = num;
				num = (short)705456339;
				switch (num2 == num)
				{
				}
				num = (short)1599537152;
				if (num != 0)
				{
				}
				num = (short)1148059648;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x0082B69C File Offset: 0x0082989C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)350069431;
			short num2 = num;
			num = (short)1915527863;
			switch (num2 == num)
			{
			}
			num = (short)1156382721;
			if (num != 0)
			{
			}
			num = (short)1052246016;
			if (num != 0)
			{
			}
			num = (short)1641152512;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2Inner(this);
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x0082B74C File Offset: 0x0082994C
		internal void SetValues()
		{
			short num = (short)1004734735;
			short num2 = num;
			num = (short)142805263;
			switch (num2 == num)
			{
			}
			num = (short)1792081921;
			if (num != 0)
			{
			}
			num = (short)1419247616;
			if (num != 0)
			{
			}
			num = (short)1732378624;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_O2;
			base.DataTransferOrder = 60;
		}

		// Token: 0x06008B99 RID: 35737 RVA: 0x0082B818 File Offset: 0x00829A18
		// Note: this type is marked as 'beforefieldinit'.
		static O2InnerRecset()
		{
			short num = (short)487552291;
			short num2 = num;
			num = (short)2145154339;
			switch (num2 == num)
			{
			}
			num = (short)1566441473;
			if (num != 0)
			{
			}
			num = (short)1842610176;
			if (num != 0)
			{
			}
			num = (short)1181155328;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset._Min = 1;
		}

		// Token: 0x040043DC RID: 17372
		public static int _MaxPool;

		// Token: 0x040043DD RID: 17373
		public static int _Max;

		// Token: 0x040043DE RID: 17374
		public int _DynMax;

		// Token: 0x040043DF RID: 17375
		public static int _Min;

		// Token: 0x040043E0 RID: 17376
		public static int _DefaultRecordCount;
	}
}
