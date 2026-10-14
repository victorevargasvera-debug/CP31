using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004D0 RID: 1232
	[global::System.Serializable]
	public class DataUserListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600A313 RID: 41747 RVA: 0x00980CE0 File Offset: 0x0097EEE0
		public DataUserListInnerRecset() : base(global::CommonResources.AcgResources.ID_DATAUSERLIST, global::CommonResources.AcgResources.ID_USERNAME)
		{
			this.SetValues();
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x00980D04 File Offset: 0x0097EF04
		public DataUserListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170051B7 RID: 20919
		// (get) Token: 0x0600A315 RID: 41749 RVA: 0x00980D30 File Offset: 0x0097EF30
		public override int MaxPool
		{
			get
			{
				short num = (short)1800137563;
				short num2 = num;
				num = (short)101051227;
				switch (num2 == num)
				{
				}
				num = (short)1958608896;
				short num3 = num;
				num = (short)1916928001;
				if (num != 0)
				{
				}
				num = (short)2134179840;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset._MaxPool;
			}
		}

		// Token: 0x170051B8 RID: 20920
		// (get) Token: 0x0600A316 RID: 41750 RVA: 0x00980DDC File Offset: 0x0097EFDC
		// (set) Token: 0x0600A317 RID: 41751 RVA: 0x00980E9C File Offset: 0x0097F09C
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)2089529209;
					short num2 = num;
					num = (short)79867769;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1088552961;
						if (num != 0)
						{
						}
						num = (short)223477760;
						short num3 = num;
						num = (short)1599995904;
						if (num != 0)
						{
						}
						break;
					}
					}
					return global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)2045313025;
				if (num != 0)
				{
				}
				num = (short)2005500127;
				short num2 = num;
				num = (short)1279951071;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366804992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1966997504;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170051B9 RID: 20921
		// (get) Token: 0x0600A318 RID: 41752 RVA: 0x00980F4C File Offset: 0x0097F14C
		public override int Min
		{
			get
			{
				short num = (short)2120899300;
				short num2 = num;
				num = (short)1715296996;
				switch (num2 == num)
				{
				}
				num = (short)114819072;
				short num3 = num;
				num = (short)1161297921;
				if (num != 0)
				{
				}
				num = (short)526974976;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset._Min;
			}
		}

		// Token: 0x170051BA RID: 20922
		// (get) Token: 0x0600A319 RID: 41753 RVA: 0x00980FF8 File Offset: 0x0097F1F8
		// (set) Token: 0x0600A31A RID: 41754 RVA: 0x009810A8 File Offset: 0x0097F2A8
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1167822127;
				short num2 = num;
				num = (short)368676143;
				switch (num2 == num)
				{
				}
				num = (short)1765605376;
				short num3 = num;
				num = (short)44367873;
				if (num != 0)
				{
				}
				num = (short)1114177536;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)999735054;
				short num2 = num;
				num = (short)919715598;
				switch (num2 == num)
				{
				}
				num = (short)1150353408;
				short num3 = num;
				num = (short)520683521;
				if (num != 0)
				{
				}
				num = (short)719978496;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170051BB RID: 20923
		// (get) Token: 0x0600A31B RID: 41755 RVA: 0x0098115C File Offset: 0x0097F35C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1018767914;
				short num2 = num;
				num = (short)425929258;
				switch (num2 == num)
				{
				}
				num = (short)923467776;
				short num3 = num;
				num = (short)265486336;
				if (num != 0)
				{
				}
				num = (short)1119748097;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x0098120C File Offset: 0x0097F40C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2093341878;
			short num2 = num;
			num = (short)735698102;
			switch (num2 == num)
			{
			}
			num = (short)1013645312;
			short num3 = num;
			num = (short)1071513601;
			if (num != 0)
			{
			}
			num = (short)398262272;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInner(this);
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x009812C0 File Offset: 0x0097F4C0
		internal void SetValues()
		{
			short num = (short)291559207;
			short num2 = num;
			num = (short)8050471;
			switch (num2 == num)
			{
			}
			num = (short)1643315200;
			short num3 = num;
			num = (short)1162084353;
			if (num != 0)
			{
			}
			num = (short)490012672;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DATAUSERLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_USERNAME;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x00981394 File Offset: 0x0097F594
		// Note: this type is marked as 'beforefieldinit'.
		static DataUserListInnerRecset()
		{
			short num = (short)1016986406;
			short num2 = num;
			num = (short)15989542;
			switch (num2 == num)
			{
			}
			num = (short)1454047232;
			short num3 = num;
			num = (short)521797633;
			if (num != 0)
			{
			}
			num = (short)1416298496;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerRecset._Min = 1;
		}

		// Token: 0x04004E1D RID: 19997
		public static int _MaxPool;

		// Token: 0x04004E1E RID: 19998
		public static int _Max;

		// Token: 0x04004E1F RID: 19999
		public int _DynMax;

		// Token: 0x04004E20 RID: 20000
		public static int _Min;

		// Token: 0x04004E21 RID: 20001
		public static int _DefaultRecordCount;
	}
}
