using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x0200031E RID: 798
	[global::System.Serializable]
	public class KMButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007C77 RID: 31863 RVA: 0x007220F4 File Offset: 0x007202F4
		public KMButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_KMBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x06007C78 RID: 31864 RVA: 0x00722114 File Offset: 0x00720314
		public KMButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x00722140 File Offset: 0x00720340
		public override int MaxPool
		{
			get
			{
				short num = (short)1029436138;
				short num2 = num;
				num = (short)158855914;
				switch (num2 == num)
				{
				}
				num = (short)1440350208;
				short num3 = num;
				num = (short)773259264;
				if (num != 0)
				{
				}
				num = (short)2103050241;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x06007C7A RID: 31866 RVA: 0x007221F0 File Offset: 0x007203F0
		// (set) Token: 0x06007C7B RID: 31867 RVA: 0x007222B0 File Offset: 0x007204B0
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)852478593;
					short num2 = num;
					num = (short)986958465;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1512112128;
						short num3 = num;
						num = (short)1540685825;
						if (num != 0)
						{
						}
						num = (short)819462144;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1566846885;
				short num2 = num;
				num = (short)996159397;
				switch (num2 == num)
				{
				}
				num = (short)241500160;
				short num3 = num;
				num = (short)500039680;
				if (num != 0)
				{
				}
				num = (short)496041985;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x06007C7C RID: 31868 RVA: 0x00722360 File Offset: 0x00720560
		public override int Min
		{
			get
			{
				short num = (short)1862642224;
				short num2 = num;
				num = (short)467380784;
				switch (num2 == num)
				{
				}
				num = (short)1453064192;
				short num3 = num;
				num = (short)60489728;
				if (num != 0)
				{
				}
				num = (short)496762881;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset._Min;
			}
		}

		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x06007C7D RID: 31869 RVA: 0x00722410 File Offset: 0x00720610
		// (set) Token: 0x06007C7E RID: 31870 RVA: 0x007224C0 File Offset: 0x007206C0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)122481645;
				short num2 = num;
				num = (short)738978797;
				switch (num2 == num)
				{
				}
				num = (short)1311768576;
				short num3 = num;
				num = (short)309264385;
				if (num != 0)
				{
				}
				num = (short)109576192;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)588465926;
				short num2 = num;
				num = (short)660096774;
				switch (num2 == num)
				{
				}
				num = (short)1085603840;
				short num3 = num;
				num = (short)286130177;
				if (num != 0)
				{
				}
				num = (short)771227648;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x06007C7F RID: 31871 RVA: 0x00722570 File Offset: 0x00720770
		public bool HasDiffs
		{
			get
			{
				short num = (short)1750258476;
				short num2 = num;
				num = (short)480957228;
				switch (num2 == num)
				{
				}
				num = (short)1965096960;
				short num3 = num;
				num = (short)503513089;
				if (num != 0)
				{
				}
				num = (short)1986265088;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007C80 RID: 31872 RVA: 0x0072261C File Offset: 0x0072081C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)548208641;
			if (num != 0)
			{
			}
			num = (short)104418958;
			short num2 = num;
			num = (short)236998286;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2424832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)899022848;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner(this);
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x007226CC File Offset: 0x007208CC
		internal void SetValues()
		{
			short num = (short)869906045;
			short num2 = num;
			num = (short)295024253;
			switch (num2 == num)
			{
			}
			num = (short)1691025408;
			short num3 = num;
			num = (short)1907884032;
			if (num != 0)
			{
			}
			num = (short)1495662593;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_KMBUTTON;
			base.DataTransferOrder = 18;
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x00722798 File Offset: 0x00720998
		// Note: this type is marked as 'beforefieldinit'.
		static KMButtonInnerRecset()
		{
			short num = (short)1393923925;
			short num2 = num;
			num = (short)522819413;
			switch (num2 == num)
			{
			}
			num = (short)58130432;
			if (num != 0)
			{
			}
			num = (short)2046820353;
			if (num != 0)
			{
			}
			num = (short)1993277440;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset._Min = 1;
		}

		// Token: 0x040037CA RID: 14282
		public static int _MaxPool;

		// Token: 0x040037CB RID: 14283
		public static int _Max;

		// Token: 0x040037CC RID: 14284
		public int _DynMax;

		// Token: 0x040037CD RID: 14285
		public static int _Min;

		// Token: 0x040037CE RID: 14286
		public static int _DefaultRecordCount;
	}
}
