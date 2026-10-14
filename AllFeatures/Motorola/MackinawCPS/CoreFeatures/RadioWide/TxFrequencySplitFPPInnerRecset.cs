using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200018B RID: 395
	[global::System.Serializable]
	public class TxFrequencySplitFPPInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06003FD2 RID: 16338 RVA: 0x003BF0A0 File Offset: 0x003BD2A0
		public TxFrequencySplitFPPInnerRecset() : base(global::CommonResources.AcgResources.ID_TXFREQUENCYSPLITFPP)
		{
			this.SetValues();
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x003BF0C0 File Offset: 0x003BD2C0
		public TxFrequencySplitFPPInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06003FD4 RID: 16340 RVA: 0x003BF0EC File Offset: 0x003BD2EC
		public override int MaxPool
		{
			get
			{
				short num = (short)980374542;
				short num2 = num;
				num = (short)356668430;
				switch (num2 == num)
				{
				}
				num = (short)619577345;
				if (num != 0)
				{
				}
				num = (short)1350369280;
				if (num != 0)
				{
				}
				num = (short)1196490752;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset._MaxPool;
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x003BF198 File Offset: 0x003BD398
		// (set) Token: 0x06003FD6 RID: 16342 RVA: 0x003BF258 File Offset: 0x003BD458
		public override int Max
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)295174144;
					short num2 = num;
					if (this._DynMax == -1)
					{
						break;
					}
					num = (short)949650610;
					short num3 = num;
					num = (short)65504434;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6F;
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset._Max;
				IL_6F:
				num = (short)749404161;
				if (num != 0)
				{
				}
				num = (short)1891106816;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)385955382;
				short num2 = num;
				num = (short)1633498678;
				switch (num2 == num)
				{
				}
				num = (short)1212022785;
				if (num != 0)
				{
				}
				num = (short)1771175936;
				if (num != 0)
				{
				}
				num = (short)510328832;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x003BF30C File Offset: 0x003BD50C
		public override int Min
		{
			get
			{
				short num = (short)356561387;
				short num2 = num;
				num = (short)792965611;
				switch (num2 == num)
				{
				}
				num = (short)479789056;
				if (num != 0)
				{
				}
				num = (short)1812922369;
				if (num != 0)
				{
				}
				num = (short)1302986752;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset._Min;
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06003FD8 RID: 16344 RVA: 0x003BF3BC File Offset: 0x003BD5BC
		// (set) Token: 0x06003FD9 RID: 16345 RVA: 0x003BF46C File Offset: 0x003BD66C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2026045441;
				if (num != 0)
				{
				}
				num = (short)1310690525;
				short num2 = num;
				num = (short)1989840093;
				switch (num2 == num)
				{
				}
				num = (short)382074880;
				if (num != 0)
				{
				}
				num = (short)2076508160;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)321583982;
				short num2 = num;
				num = (short)82508654;
				switch (num2 == num)
				{
				}
				num = (short)619577344;
				if (num != 0)
				{
				}
				num = (short)485490689;
				if (num != 0)
				{
				}
				num = (short)584908800;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06003FDA RID: 16346 RVA: 0x003BF51C File Offset: 0x003BD71C
		public bool HasDiffs
		{
			get
			{
				short num = (short)173018710;
				short num2 = num;
				num = (short)370413142;
				switch (num2 == num)
				{
				}
				num = (short)1848639489;
				if (num != 0)
				{
				}
				num = (short)793247744;
				if (num != 0)
				{
				}
				num = (short)147193856;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x003BF5CC File Offset: 0x003BD7CC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)804931957;
			short num2 = num;
			num = (short)1293175157;
			switch (num2 == num)
			{
			}
			num = (short)2127036416;
			if (num != 0)
			{
			}
			num = (short)64290817;
			if (num != 0)
			{
			}
			num = (short)1227751424;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInner(this);
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x003BF67C File Offset: 0x003BD87C
		internal void SetValues()
		{
			short num = (short)1956660031;
			short num2 = num;
			num = (short)1637761855;
			switch (num2 == num)
			{
			}
			num = (short)1099300864;
			if (num != 0)
			{
			}
			num = (short)192741377;
			if (num != 0)
			{
			}
			num = (short)862978048;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TXFREQUENCYSPLITFPP;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x003BF744 File Offset: 0x003BD944
		// Note: this type is marked as 'beforefieldinit'.
		static TxFrequencySplitFPPInnerRecset()
		{
			short num = (short)64646528;
			short num2 = num;
			num = (short)1305243008;
			switch (num2 == num)
			{
			}
			num = (short)389414913;
			if (num != 0)
			{
			}
			num = (short)1795227648;
			if (num != 0)
			{
			}
			num = (short)643301376;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset._Min = 1;
		}

		// Token: 0x040019F9 RID: 6649
		public static int _MaxPool;

		// Token: 0x040019FA RID: 6650
		public static int _Max;

		// Token: 0x040019FB RID: 6651
		public int _DynMax;

		// Token: 0x040019FC RID: 6652
		public static int _Min;

		// Token: 0x040019FD RID: 6653
		public static int _DefaultRecordCount;
	}
}
