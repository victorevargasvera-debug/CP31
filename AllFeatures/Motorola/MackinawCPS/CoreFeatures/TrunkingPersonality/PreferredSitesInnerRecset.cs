using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000CB RID: 203
	[global::System.Serializable]
	public class PreferredSitesInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001C0C RID: 7180 RVA: 0x001C229C File Offset: 0x001C049C
		public PreferredSitesInnerRecset() : base(global::CommonResources.AcgResources.ID_PREFERREDSITES)
		{
			this.SetValues();
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x001C22BC File Offset: 0x001C04BC
		public PreferredSitesInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x001C22E8 File Offset: 0x001C04E8
		public override int MaxPool
		{
			get
			{
				short num = (short)1422917633;
				if (num != 0)
				{
				}
				num = (short)1392337479;
				short num2 = num;
				num = (short)134898247;
				switch (num2 == num)
				{
				}
				num = (short)1376714752;
				if (num != 0)
				{
				}
				num = (short)2042626048;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset._MaxPool;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x001C2394 File Offset: 0x001C0594
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x001C2454 File Offset: 0x001C0654
		public override int Max
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)933036032;
					short num2 = num;
					if (this._DynMax != -1)
					{
						goto IL_AA;
					}
					num = (short)1199898625;
					if (num != 0)
					{
					}
					num = (short)1581210682;
					short num3 = num;
					num = (short)1284332602;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_8E;
					}
				}
				IL_8E:
				num = (short)1347485696;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset._Max;
				IL_AA:
				return this._DynMax;
			}
			set
			{
				short num = (short)2074854286;
				short num2 = num;
				num = (short)333431694;
				switch (num2 == num)
				{
				}
				num = (short)1067057153;
				if (num != 0)
				{
				}
				num = (short)1311375360;
				if (num != 0)
				{
				}
				num = (short)2129264640;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x001C2504 File Offset: 0x001C0704
		public override int Min
		{
			get
			{
				short num = (short)132961193;
				short num2 = num;
				num = (short)266982313;
				switch (num2 == num)
				{
				}
				num = (short)1751777281;
				if (num != 0)
				{
				}
				num = (short)182648832;
				if (num != 0)
				{
				}
				num = (short)548667392;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset._Min;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x001C25B0 File Offset: 0x001C07B0
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x001C2660 File Offset: 0x001C0860
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)403526002;
				short num2 = num;
				num = (short)831213938;
				switch (num2 == num)
				{
				}
				num = (short)1857093633;
				if (num != 0)
				{
				}
				num = (short)1187840000;
				if (num != 0)
				{
				}
				num = (short)1236598784;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)946493933;
				short num2 = num;
				num = (short)2078366189;
				switch (num2 == num)
				{
				}
				num = (short)529334273;
				if (num != 0)
				{
				}
				num = (short)1916403712;
				if (num != 0)
				{
				}
				num = (short)1363935232;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x001C2710 File Offset: 0x001C0910
		public bool HasDiffs
		{
			get
			{
				short num = (short)1543838498;
				short num2 = num;
				num = (short)1210391330;
				switch (num2 == num)
				{
				}
				num = (short)1286209536;
				if (num != 0)
				{
				}
				num = (short)1854537729;
				if (num != 0)
				{
				}
				num = (short)1303314432;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x001C27BC File Offset: 0x001C09BC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1008228163;
			short num2 = num;
			num = (short)2071091011;
			switch (num2 == num)
			{
			}
			num = (short)1221591040;
			if (num != 0)
			{
			}
			num = (short)1103626241;
			if (num != 0)
			{
			}
			num = (short)2035482624;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInner(this);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x001C2868 File Offset: 0x001C0A68
		internal void SetValues()
		{
			short num = (short)576970873;
			short num2 = num;
			num = (short)90628217;
			switch (num2 == num)
			{
			}
			num = (short)1330905088;
			if (num != 0)
			{
			}
			num = (short)1165033473;
			if (num != 0)
			{
			}
			num = (short)1431044096;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_PREFERREDSITES;
			base.DataTransferOrder = 45;
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x001C2938 File Offset: 0x001C0B38
		// Note: this type is marked as 'beforefieldinit'.
		static PreferredSitesInnerRecset()
		{
			short num = (short)1087242241;
			if (num != 0)
			{
			}
			num = (short)1312184935;
			short num2 = num;
			num = (short)847862375;
			switch (num2 == num)
			{
			}
			num = (short)771883008;
			if (num != 0)
			{
			}
			num = (short)1121976320;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset._Min = 1;
		}

		// Token: 0x040008FA RID: 2298
		public static int _MaxPool;

		// Token: 0x040008FB RID: 2299
		public static int _Max;

		// Token: 0x040008FC RID: 2300
		public int _DynMax;

		// Token: 0x040008FD RID: 2301
		public static int _Min;

		// Token: 0x040008FE RID: 2302
		public static int _DefaultRecordCount;
	}
}
