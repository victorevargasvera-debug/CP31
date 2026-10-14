using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200037C RID: 892
	[global::System.Serializable]
	public class PASirenButtonsListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060083C3 RID: 33731 RVA: 0x007A7C60 File Offset: 0x007A5E60
		public PASirenButtonsListInnerRecset() : base(global::CommonResources.AcgResources.ID_PASIRENBUTTONS, global::CommonResources.AcgResources.ID_PASIREN_1)
		{
			this.SetValues();
		}

		// Token: 0x060083C4 RID: 33732 RVA: 0x007A7C84 File Offset: 0x007A5E84
		public PASirenButtonsListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004315 RID: 17173
		// (get) Token: 0x060083C5 RID: 33733 RVA: 0x007A7CB0 File Offset: 0x007A5EB0
		public override int MaxPool
		{
			get
			{
				short num = (short)903610368;
				short num2 = num;
				num = (short)217765437;
				short num3 = num;
				num = (short)1601361469;
				switch (num3 == num)
				{
				}
				num = (short)1177223168;
				if (num != 0)
				{
				}
				num = (short)2055012353;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004316 RID: 17174
		// (get) Token: 0x060083C6 RID: 33734 RVA: 0x007A7D60 File Offset: 0x007A5F60
		// (set) Token: 0x060083C7 RID: 33735 RVA: 0x007A7E20 File Offset: 0x007A6020
		public override int Max
		{
			get
			{
				short num = (short)1928929708;
				short num2 = num;
				num = (short)150806956;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7D;
				case 1:
					break;
				default:
				{
					num = (short)925827072;
					short num3 = num;
					break;
				}
				}
				num = (short)759562240;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					return this._DynMax;
				}
				IL_7D:
				num = (short)14286849;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset._Max;
			}
			set
			{
				short num = (short)1585840128;
				short num2 = num;
				num = (short)755964403;
				short num3 = num;
				num = (short)1772493299;
				switch (num3 == num)
				{
				}
				num = (short)394788864;
				if (num != 0)
				{
				}
				num = (short)1091567617;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004317 RID: 17175
		// (get) Token: 0x060083C8 RID: 33736 RVA: 0x007A7ED4 File Offset: 0x007A60D4
		public override int Min
		{
			get
			{
				short num = (short)95092736;
				short num2 = num;
				num = (short)394637750;
				short num3 = num;
				num = (short)604221878;
				switch (num3 == num)
				{
				}
				num = (short)1518600192;
				if (num != 0)
				{
				}
				num = (short)1970077697;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset._Min;
			}
		}

		// Token: 0x17004318 RID: 17176
		// (get) Token: 0x060083C9 RID: 33737 RVA: 0x007A7F80 File Offset: 0x007A6180
		// (set) Token: 0x060083CA RID: 33738 RVA: 0x007A8030 File Offset: 0x007A6230
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)642252800;
				short num2 = num;
				num = (short)1152878072;
				short num3 = num;
				num = (short)1216972280;
				switch (num3 == num)
				{
				}
				num = (short)1876951041;
				if (num != 0)
				{
				}
				num = (short)1634205696;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)352714752;
				short num2 = num;
				num = (short)143634813;
				short num3 = num;
				num = (short)1276490109;
				switch (num3 == num)
				{
				}
				num = (short)1106313217;
				if (num != 0)
				{
				}
				num = (short)1942814720;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004319 RID: 17177
		// (get) Token: 0x060083CB RID: 33739 RVA: 0x007A80E0 File Offset: 0x007A62E0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1478754304;
				short num2 = num;
				num = (short)555669633;
				short num3 = num;
				num = (short)478992513;
				switch (num3 == num)
				{
				}
				num = (short)320995329;
				if (num != 0)
				{
				}
				num = (short)1153761280;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x007A8190 File Offset: 0x007A6390
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)348061696;
			short num2 = num;
			num = (short)1136590849;
			if (num != 0)
			{
			}
			num = (short)326044946;
			short num3 = num;
			num = (short)1060244754;
			switch (num3 == num)
			{
			}
			num = (short)174784512;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner(this);
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x007A8240 File Offset: 0x007A6440
		internal void SetValues()
		{
			short num = (short)860487680;
			short num2 = num;
			num = (short)91271114;
			short num3 = num;
			num = (short)251768778;
			switch (num3 == num)
			{
			}
			num = (short)520683520;
			if (num != 0)
			{
			}
			num = (short)831913985;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_PASIRENBUTTONS;
			base.KeySeed = global::CommonResources.AcgResources.ID_PASIREN_1;
			base.DataTransferOrder = 50;
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x007A8314 File Offset: 0x007A6514
		// Note: this type is marked as 'beforefieldinit'.
		static PASirenButtonsListInnerRecset()
		{
			short num = (short)851116032;
			short num2 = num;
			num = (short)1677245949;
			short num3 = num;
			num = (short)1760214525;
			switch (num3 == num)
			{
			}
			num = (short)236257281;
			if (num != 0)
			{
			}
			num = (short)521469952;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset._Min = 1;
		}

		// Token: 0x04003E62 RID: 15970
		public static int _MaxPool;

		// Token: 0x04003E63 RID: 15971
		public static int _Max;

		// Token: 0x04003E64 RID: 15972
		public int _DynMax;

		// Token: 0x04003E65 RID: 15973
		public static int _Min;

		// Token: 0x04003E66 RID: 15974
		public static int _DefaultRecordCount;
	}
}
