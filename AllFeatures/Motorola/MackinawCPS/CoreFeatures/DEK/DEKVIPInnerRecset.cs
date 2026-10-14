using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000333 RID: 819
	[global::System.Serializable]
	public class DEKVIPInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007E40 RID: 32320 RVA: 0x00746394 File Offset: 0x00744594
		public DEKVIPInnerRecset() : base(global::CommonResources.AcgResources.ID_DEKVIP)
		{
			this.SetValues();
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x007463B4 File Offset: 0x007445B4
		public DEKVIPInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x06007E42 RID: 32322 RVA: 0x007463E0 File Offset: 0x007445E0
		public override int MaxPool
		{
			get
			{
				short num = (short)497090560;
				short num2 = num;
				num = (short)1419051009;
				if (num != 0)
				{
				}
				num = (short)2022966329;
				short num3 = num;
				num = (short)266208313;
				switch (num3 == num)
				{
				}
				num = (short)1964507136;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700409D RID: 16541
		// (get) Token: 0x06007E43 RID: 32323 RVA: 0x00746490 File Offset: 0x00744690
		// (set) Token: 0x06007E44 RID: 32324 RVA: 0x00746554 File Offset: 0x00744754
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)229244928;
					short num2 = num;
					num = (short)2057306113;
					if (num != 0)
					{
					}
					num = (short)895393337;
					short num3 = num;
					num = (short)74096185;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2029715456;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset._Max;
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1981022208;
				short num2 = num;
				num = (short)123714244;
				short num3 = num;
				num = (short)989444804;
				switch (num3 == num)
				{
				}
				num = (short)1126957056;
				if (num != 0)
				{
				}
				num = (short)240582657;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x06007E45 RID: 32325 RVA: 0x00746608 File Offset: 0x00744808
		public override int Min
		{
			get
			{
				short num = (short)1833500672;
				short num2 = num;
				num = (short)1763207003;
				short num3 = num;
				num = (short)676947803;
				switch (num3 == num)
				{
				}
				num = (short)115277825;
				if (num != 0)
				{
				}
				num = (short)879820800;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset._Min;
			}
		}

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x06007E46 RID: 32326 RVA: 0x007466B8 File Offset: 0x007448B8
		// (set) Token: 0x06007E47 RID: 32327 RVA: 0x0074676C File Offset: 0x0074496C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2138112000;
				short num2 = num;
				num = (short)2100166657;
				if (num != 0)
				{
				}
				num = (short)233227478;
				short num3 = num;
				num = (short)1920124118;
				switch (num3 == num)
				{
				}
				num = (short)1516503040;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1932460032;
				short num2 = num;
				num = (short)1732082181;
				short num3 = num;
				num = (short)719878661;
				switch (num3 == num)
				{
				}
				num = (short)1445527553;
				if (num != 0)
				{
				}
				num = (short)1550909440;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x06007E48 RID: 32328 RVA: 0x00746820 File Offset: 0x00744A20
		public bool HasDiffs
		{
			get
			{
				short num = (short)2072510464;
				short num2 = num;
				num = (short)137127598;
				short num3 = num;
				num = (short)65889966;
				switch (num3 == num)
				{
				}
				num = (short)1737031681;
				if (num != 0)
				{
				}
				num = (short)1157955584;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x007468D0 File Offset: 0x00744AD0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)337313792;
			short num2 = num;
			num = (short)976481416;
			short num3 = num;
			num = (short)1852173448;
			switch (num3 == num)
			{
			}
			num = (short)2122252288;
			if (num != 0)
			{
			}
			num = (short)956891137;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner(this);
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x0074697C File Offset: 0x00744B7C
		internal void SetValues()
		{
			short num = (short)1459421184;
			short num2 = num;
			num = (short)283319202;
			short num3 = num;
			num = (short)1607932834;
			switch (num3 == num)
			{
			}
			num = (short)559546369;
			if (num != 0)
			{
			}
			num = (short)313589760;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DEKVIP;
			base.DataTransferOrder = 14;
		}

		// Token: 0x06007E4B RID: 32331 RVA: 0x00746A44 File Offset: 0x00744C44
		// Note: this type is marked as 'beforefieldinit'.
		static DEKVIPInnerRecset()
		{
			short num = (short)40304640;
			short num2 = num;
			num = (short)2091712513;
			if (num != 0)
			{
			}
			num = (short)275924560;
			short num3 = num;
			num = (short)453461584;
			switch (num3 == num)
			{
			}
			num = (short)716374016;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset._Min = 1;
		}

		// Token: 0x04003992 RID: 14738
		public static int _MaxPool;

		// Token: 0x04003993 RID: 14739
		public static int _Max;

		// Token: 0x04003994 RID: 14740
		public int _DynMax;

		// Token: 0x04003995 RID: 14741
		public static int _Min;

		// Token: 0x04003996 RID: 14742
		public static int _DefaultRecordCount;
	}
}
