using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001DC RID: 476
	[global::System.Serializable]
	public class GlobalShepherdListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060053BC RID: 21436 RVA: 0x004C0224 File Offset: 0x004BE424
		public GlobalShepherdListInnerRecset() : base(global::CommonResources.AcgResources.ID_GLOBALSHEPHERDLIST, global::CommonResources.AcgResources.ID_GLOBALSHEP)
		{
			this.SetValues();
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x004C0248 File Offset: 0x004BE448
		public GlobalShepherdListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x060053BE RID: 21438 RVA: 0x004C0274 File Offset: 0x004BE474
		public override int MaxPool
		{
			get
			{
				short num = (short)1759772672;
				short num2 = num;
				num = (short)1249622764;
				short num3 = num;
				num = (short)452836076;
				switch (num3 == num)
				{
				}
				num = (short)775028737;
				if (num != 0)
				{
				}
				num = (short)1063911424;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x060053BF RID: 21439 RVA: 0x004C0324 File Offset: 0x004BE524
		// (set) Token: 0x060053C0 RID: 21440 RVA: 0x004C03E0 File Offset: 0x004BE5E0
		public override int Max
		{
			get
			{
				short num = (short)2043743108;
				short num2 = num;
				num = (short)525536132;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7A;
				case 1:
					break;
				default:
				{
					num = (short)394723328;
					short num3 = num;
					break;
				}
				}
				num = (short)1257701376;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					return this._DynMax;
				}
				IL_7A:
				num = (short)1919352833;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset._Max;
			}
			set
			{
				short num = (short)107109135;
				short num2 = num;
				num = (short)178543375;
				switch (num2 == num)
				{
				}
				num = (short)1642070016;
				if (num != 0)
				{
				}
				num = (short)1548353536;
				short num3 = num;
				num = (short)1831469057;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x004C048C File Offset: 0x004BE68C
		public override int Min
		{
			get
			{
				short num = (short)1796493931;
				short num2 = num;
				num = (short)1518621291;
				switch (num2 == num)
				{
				}
				num = (short)645136385;
				if (num != 0)
				{
				}
				num = (short)624164864;
				short num3 = num;
				num = (short)1948712960;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset._Min;
			}
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x004C053C File Offset: 0x004BE73C
		// (set) Token: 0x060053C3 RID: 21443 RVA: 0x004C05EC File Offset: 0x004BE7EC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1745421151;
				short num2 = num;
				num = (short)1902248799;
				switch (num2 == num)
				{
				}
				num = (short)1239220225;
				if (num != 0)
				{
				}
				num = (short)893452288;
				short num3 = num;
				num = (short)1961885696;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1715924833;
				short num2 = num;
				num = (short)43708257;
				switch (num2 == num)
				{
				}
				num = (short)735117312;
				if (num != 0)
				{
				}
				num = (short)443547648;
				short num3 = num;
				num = (short)663027713;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x060053C4 RID: 21444 RVA: 0x004C069C File Offset: 0x004BE89C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1756584808;
				short num2 = num;
				num = (short)1485003624;
				switch (num2 == num)
				{
				}
				num = (short)1018888193;
				if (num != 0)
				{
				}
				num = (short)1648754688;
				short num3 = num;
				num = (short)39321600;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x004C0750 File Offset: 0x004BE950
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)690487297;
			if (num != 0)
			{
			}
			num = (short)1155256746;
			short num2 = num;
			num = (short)788320682;
			switch (num2 == num)
			{
			}
			num = (short)361365504;
			short num3 = num;
			num = (short)1223491584;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInner(this);
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x004C07FC File Offset: 0x004BE9FC
		internal void SetValues()
		{
			short num = (short)1131484079;
			short num2 = num;
			num = (short)1533875119;
			switch (num2 == num)
			{
			}
			num = (short)827260929;
			if (num != 0)
			{
			}
			num = (short)1639383040;
			short num3 = num;
			num = (short)1384710144;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_GLOBALSHEPHERDLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_GLOBALSHEP;
			base.DataTransferOrder = 22;
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x004C08D0 File Offset: 0x004BEAD0
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalShepherdListInnerRecset()
		{
			short num = (short)1268546853;
			short num2 = num;
			num = (short)1332313381;
			switch (num2 == num)
			{
			}
			num = (short)1008861185;
			if (num != 0)
			{
			}
			num = (short)1881276416;
			short num3 = num;
			num = (short)663552000;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset._Min = 1;
		}

		// Token: 0x040020A2 RID: 8354
		public static int _MaxPool;

		// Token: 0x040020A3 RID: 8355
		public static int _Max;

		// Token: 0x040020A4 RID: 8356
		public int _DynMax;

		// Token: 0x040020A5 RID: 8357
		public static int _Min;

		// Token: 0x040020A6 RID: 8358
		public static int _DefaultRecordCount;
	}
}
