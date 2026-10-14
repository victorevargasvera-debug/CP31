using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200045B RID: 1115
	[global::System.Serializable]
	public class RxSSIClockRateTXModeInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06009474 RID: 38004 RVA: 0x008BC910 File Offset: 0x008BAB10
		public RxSSIClockRateTXModeInnerRecset() : base(global::CommonResources.AcgResources.ID_RXSSICLOCKRATELISTTXMODE, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x008BC934 File Offset: 0x008BAB34
		public RxSSIClockRateTXModeInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004AB5 RID: 19125
		// (get) Token: 0x06009476 RID: 38006 RVA: 0x008BC960 File Offset: 0x008BAB60
		public override int MaxPool
		{
			get
			{
				short num = (short)2055630366;
				short num2 = num;
				num = (short)987590174;
				switch (num2 == num)
				{
				}
				num = (short)287244289;
				if (num != 0)
				{
				}
				num = (short)1387528192;
				short num3 = num;
				num = (short)1101266944;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004AB6 RID: 19126
		// (get) Token: 0x06009477 RID: 38007 RVA: 0x008BCA10 File Offset: 0x008BAC10
		// (set) Token: 0x06009478 RID: 38008 RVA: 0x008BCAD4 File Offset: 0x008BACD4
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num;
					for (;;)
					{
						num = (short)1117126656;
						short num2 = num;
						num = (short)283907619;
						short num3 = num;
						num = (short)1687754275;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6D;
						}
					}
					IL_6D:
					num = (short)1526398976;
					if (num != 0)
					{
					}
					num = (short)306184193;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)2118203056;
				short num2 = num;
				num = (short)1145321136;
				switch (num2 == num)
				{
				}
				num = (short)1038614528;
				if (num != 0)
				{
				}
				num = (short)180748288;
				short num3 = num;
				num = (short)1480392705;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004AB7 RID: 19127
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x008BCB84 File Offset: 0x008BAD84
		public override int Min
		{
			get
			{
				short num = (short)1112086206;
				short num2 = num;
				num = (short)1480988350;
				switch (num2 == num)
				{
				}
				num = (short)1395720192;
				if (num != 0)
				{
				}
				num = (short)176816128;
				short num3 = num;
				num = (short)1666252801;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset._Min;
			}
		}

		// Token: 0x17004AB8 RID: 19128
		// (get) Token: 0x0600947A RID: 38010 RVA: 0x008BCC30 File Offset: 0x008BAE30
		// (set) Token: 0x0600947B RID: 38011 RVA: 0x008BCCDC File Offset: 0x008BAEDC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)664430090;
				short num2 = num;
				num = (short)462120458;
				switch (num2 == num)
				{
				}
				num = (short)1432616960;
				if (num != 0)
				{
				}
				num = (short)464125952;
				short num3 = num;
				num = (short)3604481;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1427323596;
				short num2 = num;
				num = (short)785398476;
				switch (num2 == num)
				{
				}
				num = (short)1262026753;
				if (num != 0)
				{
				}
				num = (short)1528496128;
				short num3 = num;
				num = (short)638386176;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004AB9 RID: 19129
		// (get) Token: 0x0600947C RID: 38012 RVA: 0x008BCD8C File Offset: 0x008BAF8C
		public bool HasDiffs
		{
			get
			{
				short num = (short)2023274550;
				short num2 = num;
				num = (short)416593974;
				switch (num2 == num)
				{
				}
				num = (short)318767105;
				if (num != 0)
				{
				}
				num = (short)1725628416;
				short num3 = num;
				num = (short)793247744;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x008BCE38 File Offset: 0x008BB038
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1084080000;
			short num2 = num;
			num = (short)573554560;
			switch (num2 == num)
			{
			}
			num = (short)1191051265;
			if (num != 0)
			{
			}
			num = (short)497352704;
			short num3 = num;
			num = (short)902037504;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInner(this);
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x008BCEE8 File Offset: 0x008BB0E8
		internal void SetValues()
		{
			short num = (short)481220770;
			short num2 = num;
			num = (short)1663228066;
			switch (num2 == num)
			{
			}
			num = (short)798425089;
			if (num != 0)
			{
			}
			num = (short)819986432;
			short num3 = num;
			num = (short)48955392;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELISTTXMODE;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x008BCFB0 File Offset: 0x008BB1B0
		// Note: this type is marked as 'beforefieldinit'.
		static RxSSIClockRateTXModeInnerRecset()
		{
			short num = (short)1918049229;
			short num2 = num;
			num = (short)1561402317;
			switch (num2 == num)
			{
			}
			num = (short)1905328128;
			if (num != 0)
			{
			}
			num = (short)1550647296;
			short num3 = num;
			num = (short)1109262337;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset._Min = 1;
		}

		// Token: 0x040049EC RID: 18924
		public static int _MaxPool;

		// Token: 0x040049ED RID: 18925
		public static int _Max;

		// Token: 0x040049EE RID: 18926
		public int _DynMax;

		// Token: 0x040049EF RID: 18927
		public static int _Min;

		// Token: 0x040049F0 RID: 18928
		public static int _DefaultRecordCount;
	}
}
