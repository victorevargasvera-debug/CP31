using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200034C RID: 844
	[global::System.Serializable]
	public class ConsolidatedActionBCOListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008114 RID: 33044 RVA: 0x00767CC0 File Offset: 0x00765EC0
		public ConsolidatedActionBCOListInnerRecset() : base(global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONBCOLIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x00767CE4 File Offset: 0x00765EE4
		public ConsolidatedActionBCOListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170041F6 RID: 16886
		// (get) Token: 0x06008116 RID: 33046 RVA: 0x00767D10 File Offset: 0x00765F10
		public override int MaxPool
		{
			get
			{
				short num = (short)1918304257;
				if (num != 0)
				{
				}
				num = (short)539401430;
				short num2 = num;
				num = (short)83336406;
				switch (num2 == num)
				{
				}
				num = (short)1747124224;
				short num3 = num;
				num = (short)958201856;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset._MaxPool;
			}
		}

		// Token: 0x170041F7 RID: 16887
		// (get) Token: 0x06008117 RID: 33047 RVA: 0x00767DBC File Offset: 0x00765FBC
		// (set) Token: 0x06008118 RID: 33048 RVA: 0x00767E80 File Offset: 0x00766080
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1218193739;
					short num2 = num;
					num = (short)713828683;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)924385280;
						if (num != 0)
						{
						}
						num = (short)793051136;
						short num3 = num;
						num = (short)1800732673;
						if (num != 0)
						{
						}
						break;
					}
					}
					return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1103727381;
				short num2 = num;
				num = (short)1620085525;
				switch (num2 == num)
				{
				}
				num = (short)1556152321;
				if (num != 0)
				{
				}
				num = (short)1043988480;
				short num3 = num;
				num = (short)979697664;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170041F8 RID: 16888
		// (get) Token: 0x06008119 RID: 33049 RVA: 0x00767F30 File Offset: 0x00766130
		public override int Min
		{
			get
			{
				short num = (short)539713234;
				short num2 = num;
				num = (short)2056085202;
				switch (num2 == num)
				{
				}
				num = (short)691011585;
				if (num != 0)
				{
				}
				num = (short)345505792;
				short num3 = num;
				num = (short)983040;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset._Min;
			}
		}

		// Token: 0x170041F9 RID: 16889
		// (get) Token: 0x0600811A RID: 33050 RVA: 0x00767FE0 File Offset: 0x007661E0
		// (set) Token: 0x0600811B RID: 33051 RVA: 0x00768090 File Offset: 0x00766290
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1969984185;
				short num2 = num;
				num = (short)1544327865;
				switch (num2 == num)
				{
				}
				num = (short)1823408128;
				if (num != 0)
				{
				}
				num = (short)1729495040;
				short num3 = num;
				num = (short)1939865601;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)577474680;
				short num2 = num;
				num = (short)1555075192;
				switch (num2 == num)
				{
				}
				num = (short)752615425;
				if (num != 0)
				{
				}
				num = (short)419823616;
				short num3 = num;
				num = (short)1298923520;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x0600811C RID: 33052 RVA: 0x00768140 File Offset: 0x00766340
		public bool HasDiffs
		{
			get
			{
				short num = (short)1555374598;
				short num2 = num;
				num = (short)1576804870;
				switch (num2 == num)
				{
				}
				num = (short)708902913;
				if (num != 0)
				{
				}
				num = (short)1062993920;
				short num3 = num;
				num = (short)1643511808;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600811D RID: 33053 RVA: 0x007681F0 File Offset: 0x007663F0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1069593660;
			short num2 = num;
			num = (short)888321084;
			switch (num2 == num)
			{
			}
			num = (short)265224193;
			if (num != 0)
			{
			}
			num = (short)1908277248;
			short num3 = num;
			num = (short)1320812544;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner(this);
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x007682A0 File Offset: 0x007664A0
		internal void SetValues()
		{
			short num = (short)2144997583;
			short num2 = num;
			num = (short)173543631;
			switch (num2 == num)
			{
			}
			num = (short)557121537;
			if (num != 0)
			{
			}
			num = (short)1210515456;
			short num3 = num;
			num = (short)284884992;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONBCOLIST;
			base.DataTransferOrder = 50;
			this.b();
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x00768374 File Offset: 0x00766574
		private void b()
		{
			short num = (short)1892510161;
			short num2 = num;
			num = (short)1692690897;
			switch (num2 == num)
			{
			}
			num = (short)104136704;
			if (num != 0)
			{
			}
			num = (short)2036465664;
			short num3 = num;
			num = (short)889913345;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06008120 RID: 33056 RVA: 0x00768424 File Offset: 0x00766624
		private void a()
		{
			if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
			{
				short num = (short)40348353;
				short num2 = num;
				num = (short)492415681;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)551485441;
					if (num != 0)
					{
					}
					num = (short)1643184128;
					short num3 = num;
					num = (short)546963456;
					if (num != 0)
					{
					}
					break;
				}
				}
				base.HiddenStatic = false;
				return;
			}
			base.HiddenStatic = true;
		}

		// Token: 0x06008121 RID: 33057 RVA: 0x007684E8 File Offset: 0x007666E8
		// Note: this type is marked as 'beforefieldinit'.
		static ConsolidatedActionBCOListInnerRecset()
		{
			short num = (short)1907785634;
			short num2 = num;
			num = (short)1235910562;
			switch (num2 == num)
			{
			}
			num = (short)293011457;
			if (num != 0)
			{
			}
			num = (short)1063256064;
			short num3 = num;
			num = (short)390594560;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset._Min = 1;
		}

		// Token: 0x040039CF RID: 14799
		public static int _MaxPool;

		// Token: 0x040039D0 RID: 14800
		public static int _Max;

		// Token: 0x040039D1 RID: 14801
		public int _DynMax;

		// Token: 0x040039D2 RID: 14802
		public static int _Min;

		// Token: 0x040039D3 RID: 14803
		public static int _DefaultRecordCount;
	}
}
