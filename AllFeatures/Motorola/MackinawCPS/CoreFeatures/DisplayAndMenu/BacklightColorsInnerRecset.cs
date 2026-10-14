using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000273 RID: 627
	[global::System.Serializable]
	public class BacklightColorsInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600702E RID: 28718 RVA: 0x0063D464 File Offset: 0x0063B664
		public BacklightColorsInnerRecset() : base(global::CommonResources.AcgResources.ID_BACKLIGHTCOLOR, global::CommonResources.AcgResources.ID_COLOR)
		{
			this.SetValues();
		}

		// Token: 0x0600702F RID: 28719 RVA: 0x0063D488 File Offset: 0x0063B688
		public BacklightColorsInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x06007030 RID: 28720 RVA: 0x0063D4B4 File Offset: 0x0063B6B4
		public override int MaxPool
		{
			get
			{
				short num = (short)1159628724;
				short num2 = num;
				num = (short)1364494260;
				switch (num2 == num)
				{
				}
				num = (short)1871183872;
				short num3 = num;
				num = (short)905052161;
				if (num != 0)
				{
				}
				num = (short)831455232;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset._MaxPool;
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x06007031 RID: 28721 RVA: 0x0063D564 File Offset: 0x0063B764
		// (set) Token: 0x06007032 RID: 28722 RVA: 0x0063D624 File Offset: 0x0063B824
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					for (;;)
					{
						num = (short)630777507;
						short num2 = num;
						num = (short)1173939875;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_41;
						}
					}
					IL_41:
					num = (short)583663617;
					if (num != 0)
					{
					}
					num = (short)1685127168;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset._Max;
				}
				num = (short)328073216;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)1096773230;
				short num2 = num;
				num = (short)533622382;
				switch (num2 == num)
				{
				}
				num = (short)1596981248;
				short num3 = num;
				num = (short)398327808;
				if (num != 0)
				{
				}
				num = (short)1756758017;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x0063D6D8 File Offset: 0x0063B8D8
		public override int Min
		{
			get
			{
				short num = (short)638473382;
				short num2 = num;
				num = (short)248272038;
				switch (num2 == num)
				{
				}
				num = (short)1685716992;
				short num3 = num;
				num = (short)1837170689;
				if (num != 0)
				{
				}
				num = (short)972619776;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset._Min;
			}
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x06007034 RID: 28724 RVA: 0x0063D788 File Offset: 0x0063B988
		// (set) Token: 0x06007035 RID: 28725 RVA: 0x0063D838 File Offset: 0x0063BA38
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1230700532;
				short num2 = num;
				num = (short)1110769652;
				switch (num2 == num)
				{
				}
				num = (short)1683881984;
				short num3 = num;
				num = (short)1956052993;
				if (num != 0)
				{
				}
				num = (short)740425728;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)649123950;
				short num2 = num;
				num = (short)298768494;
				switch (num2 == num)
				{
				}
				num = (short)2091843584;
				short num3 = num;
				num = (short)846725121;
				if (num != 0)
				{
				}
				num = (short)1375010816;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x06007036 RID: 28726 RVA: 0x0063D8EC File Offset: 0x0063BAEC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1775264644;
				short num2 = num;
				num = (short)1068196740;
				switch (num2 == num)
				{
				}
				num = (short)1663172608;
				short num3 = num;
				num = (short)1307770881;
				if (num != 0)
				{
				}
				num = (short)661061632;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x0063D9A0 File Offset: 0x0063BBA0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1814968722;
			short num2 = num;
			num = (short)1195194770;
			switch (num2 == num)
			{
			}
			num = (short)1740636160;
			short num3 = num;
			num = (short)1225392129;
			if (num != 0)
			{
			}
			num = (short)1637613568;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner(this);
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x0063DA50 File Offset: 0x0063BC50
		internal void SetValues()
		{
			short num = (short)1888801628;
			short num2 = num;
			num = (short)606851932;
			switch (num2 == num)
			{
			}
			num = (short)1282998272;
			short num3 = num;
			num = (short)1954742273;
			if (num != 0)
			{
			}
			num = (short)111214592;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_BACKLIGHTCOLOR;
			base.KeySeed = global::CommonResources.AcgResources.ID_COLOR;
			base.DataTransferOrder = 25;
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x0063DB28 File Offset: 0x0063BD28
		// Note: this type is marked as 'beforefieldinit'.
		static BacklightColorsInnerRecset()
		{
			short num = (short)533705729;
			short num2 = num;
			num = (short)1714861057;
			switch (num2 == num)
			{
			}
			num = (short)741670912;
			short num3 = num;
			num = (short)1805582336;
			if (num != 0)
			{
			}
			num = (short)268566529;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerRecset._Min = 1;
		}

		// Token: 0x04002B45 RID: 11077
		public static int _MaxPool;

		// Token: 0x04002B46 RID: 11078
		public static int _Max;

		// Token: 0x04002B47 RID: 11079
		public int _DynMax;

		// Token: 0x04002B48 RID: 11080
		public static int _Min;

		// Token: 0x04002B49 RID: 11081
		public static int _DefaultRecordCount;
	}
}
