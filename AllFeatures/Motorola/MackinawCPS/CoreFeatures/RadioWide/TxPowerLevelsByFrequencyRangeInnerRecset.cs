using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200018E RID: 398
	[global::System.Serializable]
	public class TxPowerLevelsByFrequencyRangeInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06004030 RID: 16432 RVA: 0x003C344C File Offset: 0x003C164C
		public TxPowerLevelsByFrequencyRangeInnerRecset() : base(global::CommonResources.AcgResources.ID_TXPOWERLEVELSBYFREQUENCYRANGE)
		{
			this.SetValues();
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x003C346C File Offset: 0x003C166C
		public TxPowerLevelsByFrequencyRangeInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x003C3498 File Offset: 0x003C1698
		public override int MaxPool
		{
			get
			{
				short num = (short)1161756672;
				short num2 = num;
				num = (short)1017727739;
				short num3 = num;
				num = (short)344148731;
				switch (num3 == num)
				{
				}
				num = (short)2146107393;
				if (num != 0)
				{
				}
				num = (short)1992753152;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset._MaxPool;
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x003C3548 File Offset: 0x003C1748
		// (set) Token: 0x06004034 RID: 16436 RVA: 0x003C3604 File Offset: 0x003C1804
		public override int Max
		{
			get
			{
				short num = (short)546409860;
				short num2 = num;
				num = (short)1734118788;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2121859072;
					if (num != 0)
					{
					}
					num = (short)965410816;
					short num3 = num;
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				}
				num = (short)565903361;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset._Max;
			}
			set
			{
				short num = (short)1548746752;
				short num2 = num;
				num = (short)868486997;
				short num3 = num;
				num = (short)651759445;
				switch (num3 == num)
				{
				}
				num = (short)307560449;
				if (num != 0)
				{
				}
				num = (short)48037888;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x06004035 RID: 16437 RVA: 0x003C36B4 File Offset: 0x003C18B4
		public override int Min
		{
			get
			{
				short num = (short)1407647745;
				if (num != 0)
				{
				}
				num = (short)517683579;
				short num2 = num;
				num = (short)618543483;
				switch (num2 == num)
				{
				}
				num = (short)718209024;
				short num3 = num;
				num = (short)1514536960;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset._Min;
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x06004036 RID: 16438 RVA: 0x003C3768 File Offset: 0x003C1968
		// (set) Token: 0x06004037 RID: 16439 RVA: 0x003C3814 File Offset: 0x003C1A14
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)474349569;
				if (num != 0)
				{
				}
				num = (short)704511441;
				short num2 = num;
				num = (short)472776145;
				switch (num2 == num)
				{
				}
				num = (short)1334181888;
				short num3 = num;
				num = (short)1768226816;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)709251528;
				short num2 = num;
				num = (short)2010403272;
				switch (num2 == num)
				{
				}
				num = (short)1860501505;
				if (num != 0)
				{
				}
				num = (short)770441216;
				short num3 = num;
				num = (short)396951552;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x003C38C4 File Offset: 0x003C1AC4
		public bool HasDiffs
		{
			get
			{
				short num = (short)682380294;
				short num2 = num;
				num = (short)713116678;
				switch (num2 == num)
				{
				}
				num = (short)1490288640;
				if (num != 0)
				{
				}
				num = (short)2144075776;
				short num3 = num;
				num = (short)1200422913;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x003C3974 File Offset: 0x003C1B74
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1507640498;
			short num2 = num;
			num = (short)2039465138;
			switch (num2 == num)
			{
			}
			num = (short)261554177;
			if (num != 0)
			{
			}
			num = (short)2044264448;
			short num3 = num;
			num = (short)1647443968;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInner(this);
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x003C3A28 File Offset: 0x003C1C28
		internal void SetValues()
		{
			short num = (short)2079402593;
			short num2 = num;
			num = (short)417016417;
			switch (num2 == num)
			{
			}
			num = (short)1952579584;
			if (num != 0)
			{
			}
			num = (short)2126970880;
			short num3 = num;
			num = (short)786366465;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELSBYFREQUENCYRANGE;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x003C3AF4 File Offset: 0x003C1CF4
		// Note: this type is marked as 'beforefieldinit'.
		static TxPowerLevelsByFrequencyRangeInnerRecset()
		{
			short num = (short)1233256889;
			short num2 = num;
			num = (short)1445790137;
			switch (num2 == num)
			{
			}
			num = (short)341180416;
			if (num != 0)
			{
			}
			num = (short)36044800;
			short num3 = num;
			num = (short)62193665;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset._Min = 1;
		}

		// Token: 0x04001A01 RID: 6657
		public static int _MaxPool;

		// Token: 0x04001A02 RID: 6658
		public static int _Max;

		// Token: 0x04001A03 RID: 6659
		public int _DynMax;

		// Token: 0x04001A04 RID: 6660
		public static int _Min;

		// Token: 0x04001A05 RID: 6661
		public static int _DefaultRecordCount;
	}
}
