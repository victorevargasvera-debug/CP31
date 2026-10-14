using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003E1 RID: 993
	[global::System.Serializable]
	public class O2MFKAssignmentControlInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008BE2 RID: 35810 RVA: 0x0082EF6C File Offset: 0x0082D16C
		public O2MFKAssignmentControlInnerRecset() : base(global::CommonResources.AcgResources.ID_MFKROTARYCONTROL, global::CommonResources.AcgResources.ID_MFKCONTROL)
		{
			this.SetValues();
		}

		// Token: 0x06008BE3 RID: 35811 RVA: 0x0082EF90 File Offset: 0x0082D190
		public O2MFKAssignmentControlInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170046DA RID: 18138
		// (get) Token: 0x06008BE4 RID: 35812 RVA: 0x0082EFBC File Offset: 0x0082D1BC
		public override int MaxPool
		{
			get
			{
				short num = (short)705888256;
				short num2 = num;
				num = (short)45507588;
				short num3 = num;
				num = (short)1135895556;
				switch (num3 == num)
				{
				}
				num = (short)260505601;
				if (num != 0)
				{
				}
				num = (short)320929792;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset._MaxPool;
			}
		}

		// Token: 0x170046DB RID: 18139
		// (get) Token: 0x06008BE5 RID: 35813 RVA: 0x0082F06C File Offset: 0x0082D26C
		// (set) Token: 0x06008BE6 RID: 35814 RVA: 0x0082F12C File Offset: 0x0082D32C
		public override int Max
		{
			get
			{
				short num = (short)1537802240;
				short num2 = num;
				num = (short)1982466771;
				short num3 = num;
				num = (short)1836387027;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1740111873;
					if (num != 0)
					{
					}
					num = (short)1444872192;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset._Max;
			}
			set
			{
				short num = (short)797638656;
				short num2 = num;
				num = (short)1075432757;
				short num3 = num;
				num = (short)1818479925;
				switch (num3 == num)
				{
				}
				num = (short)1691746305;
				if (num != 0)
				{
				}
				num = (short)1216937984;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170046DC RID: 18140
		// (get) Token: 0x06008BE7 RID: 35815 RVA: 0x0082F1DC File Offset: 0x0082D3DC
		public override int Min
		{
			get
			{
				short num = (short)714145792;
				short num2 = num;
				num = (short)2080072263;
				short num3 = num;
				num = (short)552100423;
				switch (num3 == num)
				{
				}
				num = (short)1249050625;
				if (num != 0)
				{
				}
				num = (short)127991808;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset._Min;
			}
		}

		// Token: 0x170046DD RID: 18141
		// (get) Token: 0x06008BE8 RID: 35816 RVA: 0x0082F288 File Offset: 0x0082D488
		// (set) Token: 0x06008BE9 RID: 35817 RVA: 0x0082F334 File Offset: 0x0082D534
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2140798976;
				short num2 = num;
				num = (short)1249509377;
				if (num != 0)
				{
				}
				num = (short)971273594;
				short num3 = num;
				num = (short)90076538;
				switch (num3 == num)
				{
				}
				num = (short)682754048;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1704329216;
				short num2 = num;
				num = (short)753517639;
				short num3 = num;
				num = (short)352699463;
				switch (num3 == num)
				{
				}
				num = (short)170852353;
				if (num != 0)
				{
				}
				num = (short)1091698688;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170046DE RID: 18142
		// (get) Token: 0x06008BEA RID: 35818 RVA: 0x0082F3E4 File Offset: 0x0082D5E4
		public bool HasDiffs
		{
			get
			{
				short num = (short)2143420416;
				short num2 = num;
				num = (short)1632130281;
				short num3 = num;
				num = (short)762795241;
				switch (num3 == num)
				{
				}
				num = (short)547094529;
				if (num != 0)
				{
				}
				num = (short)408223744;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x0082F494 File Offset: 0x0082D694
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)85065728;
			short num2 = num;
			num = (short)30186088;
			short num3 = num;
			num = (short)1764596328;
			switch (num3 == num)
			{
			}
			num = (short)352976897;
			if (num != 0)
			{
			}
			num = (short)763691008;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner(this);
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x0082F540 File Offset: 0x0082D740
		internal void SetValues()
		{
			short num = (short)1551302656;
			short num2 = num;
			num = (short)1783089953;
			short num3 = num;
			num = (short)216976161;
			switch (num3 == num)
			{
			}
			num = (short)211877888;
			if (num != 0)
			{
			}
			num = (short)946077697;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			base.KeySeed = global::CommonResources.AcgResources.ID_MFKCONTROL;
			base.DataTransferOrder = 60;
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x0082F618 File Offset: 0x0082D818
		// Note: this type is marked as 'beforefieldinit'.
		static O2MFKAssignmentControlInnerRecset()
		{
			short num = (short)1907570740;
			short num2 = num;
			num = (short)306067508;
			switch (num2 == num)
			{
			}
			num = (short)443744257;
			if (num != 0)
			{
			}
			num = (short)122355712;
			if (num != 0)
			{
			}
			num = (short)1407975424;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset._Min = 1;
		}

		// Token: 0x040043E4 RID: 17380
		public static int _MaxPool;

		// Token: 0x040043E5 RID: 17381
		public static int _Max;

		// Token: 0x040043E6 RID: 17382
		public int _DynMax;

		// Token: 0x040043E7 RID: 17383
		public static int _Min;

		// Token: 0x040043E8 RID: 17384
		public static int _DefaultRecordCount;
	}
}
