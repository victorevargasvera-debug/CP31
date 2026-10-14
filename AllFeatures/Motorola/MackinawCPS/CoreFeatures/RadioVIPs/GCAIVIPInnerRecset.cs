using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002E9 RID: 745
	[global::System.Serializable]
	public class GCAIVIPInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060078D9 RID: 30937 RVA: 0x006DF338 File Offset: 0x006DD538
		public GCAIVIPInnerRecset() : base(global::CommonResources.AcgResources.ID_GCAIVIPTABLE, global::CommonResources.AcgResources.ID_GCAIVIP)
		{
			this.SetValues();
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x006DF35C File Offset: 0x006DD55C
		public GCAIVIPInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x060078DB RID: 30939 RVA: 0x006DF388 File Offset: 0x006DD588
		public override int MaxPool
		{
			get
			{
				short num = (short)1498107254;
				short num2 = num;
				num = (short)114904438;
				switch (num2 == num)
				{
				}
				num = (short)1993146369;
				if (num != 0)
				{
				}
				num = (short)1661272064;
				if (num != 0)
				{
				}
				num = (short)1681391616;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x060078DC RID: 30940 RVA: 0x006DF434 File Offset: 0x006DD634
		// (set) Token: 0x060078DD RID: 30941 RVA: 0x006DF4F8 File Offset: 0x006DD6F8
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1067702540;
					short num2 = num;
					num = (short)535419148;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1618083841;
						if (num != 0)
						{
						}
						num = (short)1592066048;
						short num3 = num;
						num = (short)479068160;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1112443893;
				short num2 = num;
				num = (short)10587125;
				switch (num2 == num)
				{
				}
				num = (short)1187119105;
				if (num != 0)
				{
				}
				num = (short)1315897344;
				if (num != 0)
				{
				}
				num = (short)1336147968;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x060078DE RID: 30942 RVA: 0x006DF5A8 File Offset: 0x006DD7A8
		public override int Min
		{
			get
			{
				short num = (short)1106216183;
				short num2 = num;
				num = (short)1356956919;
				switch (num2 == num)
				{
				}
				num = (short)262340608;
				if (num != 0)
				{
				}
				num = (short)1054277633;
				if (num != 0)
				{
				}
				num = (short)1045561344;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset._Min;
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x060078DF RID: 30943 RVA: 0x006DF658 File Offset: 0x006DD858
		// (set) Token: 0x060078E0 RID: 30944 RVA: 0x006DF708 File Offset: 0x006DD908
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1343207443;
				short num2 = num;
				num = (short)2020849683;
				switch (num2 == num)
				{
				}
				num = (short)481886208;
				if (num != 0)
				{
				}
				num = (short)214368257;
				if (num != 0)
				{
				}
				num = (short)906166272;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1523974145;
				if (num != 0)
				{
				}
				num = (short)720631367;
				short num2 = num;
				num = (short)250869319;
				switch (num2 == num)
				{
				}
				num = (short)1718419456;
				if (num != 0)
				{
				}
				num = (short)625803264;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x060078E1 RID: 30945 RVA: 0x006DF7BC File Offset: 0x006DD9BC
		public bool HasDiffs
		{
			get
			{
				short num = (short)999555073;
				if (num != 0)
				{
				}
				num = (short)902528170;
				short num2 = num;
				num = (short)1234402474;
				switch (num2 == num)
				{
				}
				num = (short)1011417088;
				if (num != 0)
				{
				}
				num = (short)2132475904;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x006DF86C File Offset: 0x006DDA6C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2113142785;
			if (num != 0)
			{
			}
			num = (short)651676999;
			short num2 = num;
			num = (short)1747307847;
			switch (num2 == num)
			{
			}
			num = (short)42926080;
			if (num != 0)
			{
			}
			num = (short)1055457280;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInner(this);
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x006DF91C File Offset: 0x006DDB1C
		internal void SetValues()
		{
			short num = (short)1605707056;
			short num2 = num;
			num = (short)1052190000;
			switch (num2 == num)
			{
			}
			num = (short)28835841;
			if (num != 0)
			{
			}
			num = (short)1057161216;
			if (num != 0)
			{
			}
			num = (short)749404160;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_GCAIVIPTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_GCAIVIP;
			base.DataTransferOrder = 15;
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x006DF9F0 File Offset: 0x006DDBF0
		// Note: this type is marked as 'beforefieldinit'.
		static GCAIVIPInnerRecset()
		{
			short num = (short)1350777791;
			short num2 = num;
			num = (short)50084799;
			switch (num2 == num)
			{
			}
			num = (short)375914497;
			if (num != 0)
			{
			}
			num = (short)1880096768;
			if (num != 0)
			{
			}
			num = (short)297205760;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset._Min = 1;
		}

		// Token: 0x0400334A RID: 13130
		public static int _MaxPool;

		// Token: 0x0400334B RID: 13131
		public static int _Max;

		// Token: 0x0400334C RID: 13132
		public int _DynMax;

		// Token: 0x0400334D RID: 13133
		public static int _Min;

		// Token: 0x0400334E RID: 13134
		public static int _DefaultRecordCount;
	}
}
