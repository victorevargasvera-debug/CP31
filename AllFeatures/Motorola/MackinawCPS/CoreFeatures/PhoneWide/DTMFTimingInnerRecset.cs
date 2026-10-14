using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x0200043D RID: 1085
	[global::System.Serializable]
	public class DTMFTimingInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060092AA RID: 37546 RVA: 0x008A271C File Offset: 0x008A091C
		public DTMFTimingInnerRecset() : base(global::CommonResources.AcgResources.ID_DTMFTIMING, global::CommonResources.AcgResources.ID_TIMING)
		{
			this.SetValues();
		}

		// Token: 0x060092AB RID: 37547 RVA: 0x008A2740 File Offset: 0x008A0940
		public DTMFTimingInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170049FA RID: 18938
		// (get) Token: 0x060092AC RID: 37548 RVA: 0x008A276C File Offset: 0x008A096C
		public override int MaxPool
		{
			get
			{
				short num = (short)1576665088;
				short num2 = num;
				num = (short)2045195838;
				short num3 = num;
				num = (short)2144351806;
				switch (num3 == num)
				{
				}
				num = (short)157876224;
				if (num != 0)
				{
				}
				num = (short)1320615937;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset._MaxPool;
			}
		}

		// Token: 0x170049FB RID: 18939
		// (get) Token: 0x060092AD RID: 37549 RVA: 0x008A281C File Offset: 0x008A0A1C
		// (set) Token: 0x060092AE RID: 37550 RVA: 0x008A28E0 File Offset: 0x008A0AE0
		public override int Max
		{
			get
			{
				short num = (short)1109482539;
				short num2 = num;
				num = (short)345463851;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_81;
				case 1:
					break;
				default:
				{
					num = (short)531365888;
					short num3 = num;
					break;
				}
				}
				num = (short)538050560;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					return this._DynMax;
				}
				IL_81:
				num = (short)343867393;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset._Max;
			}
			set
			{
				short num = (short)1883439104;
				short num2 = num;
				num = (short)1576524155;
				short num3 = num;
				num = (short)1279121787;
				switch (num3 == num)
				{
				}
				num = (short)819068929;
				if (num != 0)
				{
				}
				num = (short)1855651840;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170049FC RID: 18940
		// (get) Token: 0x060092AF RID: 37551 RVA: 0x008A2990 File Offset: 0x008A0B90
		public override int Min
		{
			get
			{
				short num = (short)1185611776;
				short num2 = num;
				num = (short)1384733014;
				short num3 = num;
				num = (short)1829722454;
				switch (num3 == num)
				{
				}
				num = (short)1158807553;
				if (num != 0)
				{
				}
				num = (short)998178816;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset._Min;
			}
		}

		// Token: 0x170049FD RID: 18941
		// (get) Token: 0x060092B0 RID: 37552 RVA: 0x008A2A3C File Offset: 0x008A0C3C
		// (set) Token: 0x060092B1 RID: 37553 RVA: 0x008A2AF0 File Offset: 0x008A0CF0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)259915776;
				short num2 = num;
				num = (short)1245074318;
				short num3 = num;
				num = (short)2054443918;
				switch (num3 == num)
				{
				}
				num = (short)1196359681;
				if (num != 0)
				{
				}
				num = (short)482213888;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1814167552;
				short num2 = num;
				num = (short)1466587696;
				short num3 = num;
				num = (short)1649236528;
				switch (num3 == num)
				{
				}
				num = (short)766115840;
				if (num != 0)
				{
				}
				num = (short)42532865;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170049FE RID: 18942
		// (get) Token: 0x060092B2 RID: 37554 RVA: 0x008A2BA0 File Offset: 0x008A0DA0
		public bool HasDiffs
		{
			get
			{
				short num = (short)44957696;
				short num2 = num;
				num = (short)1380832949;
				short num3 = num;
				num = (short)1707005621;
				switch (num3 == num)
				{
				}
				num = (short)333578241;
				if (num != 0)
				{
				}
				num = (short)822280192;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x008A2C50 File Offset: 0x008A0E50
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1802305536;
			short num2 = num;
			num = (short)1096078266;
			short num3 = num;
			num = (short)1660474298;
			switch (num3 == num)
			{
			}
			num = (short)16580609;
			if (num != 0)
			{
			}
			num = (short)1772027904;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInner(this);
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x008A2D00 File Offset: 0x008A0F00
		internal void SetValues()
		{
			short num = (short)1799028736;
			short num2 = num;
			num = (short)750292236;
			short num3 = num;
			num = (short)1332186380;
			switch (num3 == num)
			{
			}
			num = (short)766115840;
			if (num != 0)
			{
			}
			num = (short)1504051201;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFTIMING;
			base.KeySeed = global::CommonResources.AcgResources.ID_TIMING;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x008A2DD0 File Offset: 0x008A0FD0
		// Note: this type is marked as 'beforefieldinit'.
		static DTMFTimingInnerRecset()
		{
			short num = (short)1711669248;
			short num2 = num;
			num = (short)612794876;
			short num3 = num;
			num = (short)7766524;
			switch (num3 == num)
			{
			}
			num = (short)810024961;
			if (num != 0)
			{
			}
			num = (short)1756758016;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerRecset._Min = 1;
		}

		// Token: 0x040048A5 RID: 18597
		public static int _MaxPool;

		// Token: 0x040048A6 RID: 18598
		public static int _Max;

		// Token: 0x040048A7 RID: 18599
		public int _DynMax;

		// Token: 0x040048A8 RID: 18600
		public static int _Min;

		// Token: 0x040048A9 RID: 18601
		public static int _DefaultRecordCount;
	}
}
