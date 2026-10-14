using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x0200031B RID: 795
	[global::System.Serializable]
	public class KMANavigationControlsTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007C38 RID: 31800 RVA: 0x0071F3D0 File Offset: 0x0071D5D0
		public KMANavigationControlsTableInnerRecset() : base(global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS)
		{
			this.SetValues();
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x0071F3F0 File Offset: 0x0071D5F0
		public KMANavigationControlsTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x06007C3A RID: 31802 RVA: 0x0071F41C File Offset: 0x0071D61C
		public override int MaxPool
		{
			get
			{
				short num = (short)1498080260;
				short num2 = num;
				num = (short)1696261124;
				switch (num2 == num)
				{
				}
				num = (short)449183744;
				if (num != 0)
				{
				}
				num = (short)197459968;
				short num3 = num;
				num = (short)2013200385;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x06007C3B RID: 31803 RVA: 0x0071F4CC File Offset: 0x0071D6CC
		// (set) Token: 0x06007C3C RID: 31804 RVA: 0x0071F590 File Offset: 0x0071D790
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1051197440;
					short num2 = num;
					num = (short)1833893889;
					if (num != 0)
					{
					}
					num = (short)544127420;
					short num3 = num;
					num = (short)121878972;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1613824000;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset._Max;
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1184563201;
				if (num != 0)
				{
				}
				num = (short)309501437;
				short num2 = num;
				num = (short)565419517;
				switch (num2 == num)
				{
				}
				num = (short)602013696;
				short num3 = num;
				num = (short)1414004736;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x06007C3D RID: 31805 RVA: 0x0071F644 File Offset: 0x0071D844
		public override int Min
		{
			get
			{
				short num = (short)1165393344;
				short num2 = num;
				num = (short)740982208;
				switch (num2 == num)
				{
				}
				num = (short)518193152;
				if (num != 0)
				{
				}
				num = (short)895090688;
				short num3 = num;
				num = (short)161677313;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset._Min;
			}
		}

		// Token: 0x17003FA6 RID: 16294
		// (get) Token: 0x06007C3E RID: 31806 RVA: 0x0071F6F4 File Offset: 0x0071D8F4
		// (set) Token: 0x06007C3F RID: 31807 RVA: 0x0071F7A4 File Offset: 0x0071D9A4
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1046044646;
				short num2 = num;
				num = (short)722886630;
				switch (num2 == num)
				{
				}
				num = (short)278790145;
				if (num != 0)
				{
				}
				num = (short)1054081024;
				short num3 = num;
				num = (short)1545076736;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1520887330;
				short num2 = num;
				num = (short)690546210;
				switch (num2 == num)
				{
				}
				num = (short)547225600;
				if (num != 0)
				{
				}
				num = (short)555483136;
				short num3 = num;
				num = (short)1325596673;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x06007C40 RID: 31808 RVA: 0x0071F854 File Offset: 0x0071DA54
		public bool HasDiffs
		{
			get
			{
				short num = (short)584026787;
				short num2 = num;
				num = (short)1175292579;
				switch (num2 == num)
				{
				}
				num = (short)2004746241;
				if (num != 0)
				{
				}
				num = (short)1292828672;
				short num3 = num;
				num = (short)1669464064;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007C41 RID: 31809 RVA: 0x0071F904 File Offset: 0x0071DB04
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)964601548;
			short num2 = num;
			num = (short)1728816844;
			switch (num2 == num)
			{
			}
			num = (short)301072384;
			if (num != 0)
			{
			}
			num = (short)990380032;
			short num3 = num;
			num = (short)400752641;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInner(this);
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x0071F9B4 File Offset: 0x0071DBB4
		internal void SetValues()
		{
			short num = (short)1218209291;
			short num2 = num;
			num = (short)887711243;
			switch (num2 == num)
			{
			}
			num = (short)1182924801;
			if (num != 0)
			{
			}
			num = (short)2138570752;
			short num3 = num;
			num = (short)2145910784;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 18;
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x0071FA80 File Offset: 0x0071DC80
		// Note: this type is marked as 'beforefieldinit'.
		static KMANavigationControlsTableInnerRecset()
		{
			short num = (short)1662458869;
			short num2 = num;
			num = (short)514202613;
			switch (num2 == num)
			{
			}
			num = (short)1249247232;
			if (num != 0)
			{
			}
			num = (short)743505920;
			short num3 = num;
			num = (short)625999873;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset._Min = 1;
		}

		// Token: 0x040037C3 RID: 14275
		public static int _MaxPool;

		// Token: 0x040037C4 RID: 14276
		public static int _Max;

		// Token: 0x040037C5 RID: 14277
		public int _DynMax;

		// Token: 0x040037C6 RID: 14278
		public static int _Min;

		// Token: 0x040037C7 RID: 14279
		public static int _DefaultRecordCount;
	}
}
