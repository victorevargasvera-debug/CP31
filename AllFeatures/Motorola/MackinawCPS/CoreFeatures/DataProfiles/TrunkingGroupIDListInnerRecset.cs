using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x02000515 RID: 1301
	[global::System.Serializable]
	public class TrunkingGroupIDListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B0F1 RID: 45297 RVA: 0x00A413F0 File Offset: 0x00A3F5F0
		public TrunkingGroupIDListInnerRecset() : base(global::CommonResources.AcgResources.ID_TRUNKINGGROUPIDLIST)
		{
			this.SetValues();
		}

		// Token: 0x0600B0F2 RID: 45298 RVA: 0x00A41410 File Offset: 0x00A3F610
		public TrunkingGroupIDListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170058DE RID: 22750
		// (get) Token: 0x0600B0F3 RID: 45299 RVA: 0x00A4143C File Offset: 0x00A3F63C
		public override int MaxPool
		{
			get
			{
				short num = (short)1450133758;
				short num2 = num;
				num = (short)193022206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289210368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1673854977;
				if (num != 0)
				{
				}
				num = (short)240189440;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset._MaxPool;
			}
		}

		// Token: 0x170058DF RID: 22751
		// (get) Token: 0x0600B0F4 RID: 45300 RVA: 0x00A414E8 File Offset: 0x00A3F6E8
		// (set) Token: 0x0600B0F5 RID: 45301 RVA: 0x00A415A8 File Offset: 0x00A3F7A8
		public override int Max
		{
			get
			{
				short num = (short)1872166913;
				if (num != 0)
				{
				}
				num = (short)376656419;
				short num2 = num;
				num = (short)1443844643;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A4;
				case 1:
					break;
				default:
				{
					num = (short)853999616;
					short num3 = num;
					break;
				}
				}
				num = (short)803471360;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					return this._DynMax;
				}
				IL_A4:
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset._Max;
			}
			set
			{
				short num = (short)673438925;
				short num2 = num;
				num = (short)1066654925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270270464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)156565505;
				if (num != 0)
				{
				}
				num = (short)924844032;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170058E0 RID: 22752
		// (get) Token: 0x0600B0F6 RID: 45302 RVA: 0x00A41658 File Offset: 0x00A3F858
		public override int Min
		{
			get
			{
				short num = (short)1046740992;
				short num2 = num;
				num = (short)1516568577;
				if (num != 0)
				{
				}
				num = (short)222729256;
				short num3 = num;
				num = (short)183866408;
				switch (num3 == num)
				{
				}
				num = (short)183042048;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset._Min;
			}
		}

		// Token: 0x170058E1 RID: 22753
		// (get) Token: 0x0600B0F7 RID: 45303 RVA: 0x00A41708 File Offset: 0x00A3F908
		// (set) Token: 0x0600B0F8 RID: 45304 RVA: 0x00A417B8 File Offset: 0x00A3F9B8
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)697630720;
				short num2 = num;
				num = (short)221675042;
				short num3 = num;
				num = (short)1932426786;
				switch (num3 == num)
				{
				}
				num = (short)401670145;
				if (num != 0)
				{
				}
				num = (short)1150877696;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)473300992;
				short num2 = num;
				num = (short)536777786;
				short num3 = num;
				num = (short)655922234;
				switch (num3 == num)
				{
				}
				num = (short)1215889408;
				if (num != 0)
				{
				}
				num = (short)1803419649;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170058E2 RID: 22754
		// (get) Token: 0x0600B0F9 RID: 45305 RVA: 0x00A41868 File Offset: 0x00A3FA68
		public bool HasDiffs
		{
			get
			{
				short num = (short)1899626496;
				short num2 = num;
				num = (short)1270022145;
				if (num != 0)
				{
				}
				num = (short)222125235;
				short num3 = num;
				num = (short)198663347;
				switch (num3 == num)
				{
				}
				num = (short)830734336;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B0FA RID: 45306 RVA: 0x00A41918 File Offset: 0x00A3FB18
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)544997376;
			short num2 = num;
			num = (short)1302515335;
			short num3 = num;
			num = (short)412077703;
			switch (num3 == num)
			{
			}
			num = (short)1381105665;
			if (num != 0)
			{
			}
			num = (short)2009137152;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner(this);
		}

		// Token: 0x0600B0FB RID: 45307 RVA: 0x00A419C8 File Offset: 0x00A3FBC8
		internal void SetValues()
		{
			short num = (short)590217216;
			short num2 = num;
			num = (short)1871348509;
			short num3 = num;
			num = (short)664699677;
			switch (num3 == num)
			{
			}
			num = (short)1735852033;
			if (num != 0)
			{
			}
			num = (short)368181248;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGGROUPIDLIST;
			base.DataTransferOrder = 28;
		}

		// Token: 0x0600B0FC RID: 45308 RVA: 0x00A41A94 File Offset: 0x00A3FC94
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingGroupIDListInnerRecset()
		{
			short num = (short)1922891776;
			short num2 = num;
			num = (short)687269422;
			short num3 = num;
			num = (short)1947133486;
			switch (num3 == num)
			{
			}
			num = (short)1834745856;
			if (num != 0)
			{
			}
			num = (short)1861353473;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset._Min = 1;
		}

		// Token: 0x040053F2 RID: 21490
		public static int _MaxPool;

		// Token: 0x040053F3 RID: 21491
		public static int _Max;

		// Token: 0x040053F4 RID: 21492
		public int _DynMax;

		// Token: 0x040053F5 RID: 21493
		public static int _Min;

		// Token: 0x040053F6 RID: 21494
		public static int _DefaultRecordCount;
	}
}
