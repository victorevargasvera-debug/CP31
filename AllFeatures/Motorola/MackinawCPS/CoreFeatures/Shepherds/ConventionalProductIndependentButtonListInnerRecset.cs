using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001CA RID: 458
	[global::System.Serializable]
	public class ConventionalProductIndependentButtonListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06005316 RID: 21270 RVA: 0x004B71BC File Offset: 0x004B53BC
		public ConventionalProductIndependentButtonListInnerRecset() : base(global::CommonResources.AcgResources.ID_CONVENTIONALPRODUCTINDEPENDENTBUTTONLIST, global::CommonResources.AcgResources.ID_CNVBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x004B71E0 File Offset: 0x004B53E0
		public ConventionalProductIndependentButtonListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x06005318 RID: 21272 RVA: 0x004B720C File Offset: 0x004B540C
		public override int MaxPool
		{
			get
			{
				short num = (short)1628307456;
				short num2 = num;
				num = (short)61668416;
				short num3 = num;
				num = (short)1916861504;
				switch (num3 == num)
				{
				}
				num = (short)367198209;
				if (num != 0)
				{
				}
				num = (short)1818230784;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x004B72BC File Offset: 0x004B54BC
		// (set) Token: 0x0600531A RID: 21274 RVA: 0x004B737C File Offset: 0x004B557C
		public override int Max
		{
			get
			{
				short num = (short)2096562177;
				if (num != 0)
				{
				}
				num = (short)285998973;
				short num2 = num;
				num = (short)1477967741;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)988413952;
					short num3 = num;
					num = (short)1696792576;
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
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset._Max;
			}
			set
			{
				short num = (short)1648427008;
				short num2 = num;
				num = (short)1003779684;
				short num3 = num;
				num = (short)1076786788;
				switch (num3 == num)
				{
				}
				num = (short)705888257;
				if (num != 0)
				{
				}
				num = (short)816775168;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0600531B RID: 21275 RVA: 0x004B742C File Offset: 0x004B562C
		public override int Min
		{
			get
			{
				short num = (short)602865664;
				short num2 = num;
				num = (short)1904317340;
				short num3 = num;
				num = (short)1846973340;
				switch (num3 == num)
				{
				}
				num = (short)684392449;
				if (num != 0)
				{
				}
				num = (short)2043346944;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset._Min;
			}
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x0600531C RID: 21276 RVA: 0x004B74D8 File Offset: 0x004B56D8
		// (set) Token: 0x0600531D RID: 21277 RVA: 0x004B7588 File Offset: 0x004B5788
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1106051072;
				short num2 = num;
				num = (short)1146945537;
				if (num != 0)
				{
				}
				num = (short)2140793404;
				short num3 = num;
				num = (short)831449660;
				switch (num3 == num)
				{
				}
				num = (short)748421120;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)776339456;
				short num2 = num;
				num = (short)464262777;
				short num3 = num;
				num = (short)1879840377;
				switch (num3 == num)
				{
				}
				num = (short)847052801;
				if (num != 0)
				{
				}
				num = (short)203227136;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x004B7638 File Offset: 0x004B5838
		public bool HasDiffs
		{
			get
			{
				short num = (short)129171456;
				short num2 = num;
				num = (short)313539709;
				short num3 = num;
				num = (short)72825981;
				switch (num3 == num)
				{
				}
				num = (short)1011679233;
				if (num != 0)
				{
				}
				num = (short)1987772416;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x004B76EC File Offset: 0x004B58EC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1217921024;
			short num2 = num;
			num = (short)129454719;
			short num3 = num;
			num = (short)1891848831;
			switch (num3 == num)
			{
			}
			num = (short)356188161;
			if (num != 0)
			{
			}
			num = (short)851705856;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInner(this);
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x004B779C File Offset: 0x004B599C
		internal void SetValues()
		{
			short num = (short)242679808;
			short num2 = num;
			num = (short)1016667529;
			short num3 = num;
			num = (short)1446387081;
			switch (num3 == num)
			{
			}
			num = (short)696713217;
			if (num != 0)
			{
			}
			num = (short)289603584;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALPRODUCTINDEPENDENTBUTTONLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_CNVBUTTON;
			base.DataTransferOrder = 22;
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x004B7870 File Offset: 0x004B5A70
		// Note: this type is marked as 'beforefieldinit'.
		static ConventionalProductIndependentButtonListInnerRecset()
		{
			short num = (short)580517888;
			short num2 = num;
			num = (short)2069483063;
			short num3 = num;
			num = (short)734842423;
			switch (num3 == num)
			{
			}
			num = (short)29425664;
			if (num != 0)
			{
			}
			num = (short)1882914817;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset._Min = 1;
		}

		// Token: 0x04001FA8 RID: 8104
		public static int _MaxPool;

		// Token: 0x04001FA9 RID: 8105
		public static int _Max;

		// Token: 0x04001FAA RID: 8106
		public int _DynMax;

		// Token: 0x04001FAB RID: 8107
		public static int _Min;

		// Token: 0x04001FAC RID: 8108
		public static int _DefaultRecordCount;
	}
}
