using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x0200039E RID: 926
	[global::System.Serializable]
	public class O7InnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008775 RID: 34677 RVA: 0x007E3264 File Offset: 0x007E1464
		public O7InnerRecset() : base(global::CommonResources.AcgResources.ID_O7)
		{
			this.SetValues();
		}

		// Token: 0x06008776 RID: 34678 RVA: 0x007E3284 File Offset: 0x007E1484
		public O7InnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170044E5 RID: 17637
		// (get) Token: 0x06008777 RID: 34679 RVA: 0x007E32B0 File Offset: 0x007E14B0
		public override int MaxPool
		{
			get
			{
				short num = (short)2113109016;
				short num2 = num;
				num = (short)89422872;
				switch (num2 == num)
				{
				}
				num = (short)2037186560;
				if (num != 0)
				{
				}
				num = (short)337903617;
				if (num != 0)
				{
				}
				num = (short)2025259008;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset._MaxPool;
			}
		}

		// Token: 0x170044E6 RID: 17638
		// (get) Token: 0x06008778 RID: 34680 RVA: 0x007E3360 File Offset: 0x007E1560
		// (set) Token: 0x06008779 RID: 34681 RVA: 0x007E3424 File Offset: 0x007E1624
		public override int Max
		{
			get
			{
				short num = (short)206241793;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					num = (short)901240233;
					short num2 = num;
					num = (short)1573770665;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)327090176;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)374603776;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset._Max;
			}
			set
			{
				short num = (short)1903960023;
				short num2 = num;
				num = (short)340205527;
				switch (num2 == num)
				{
				}
				num = (short)2026766336;
				if (num != 0)
				{
				}
				num = (short)764936193;
				if (num != 0)
				{
				}
				num = (short)2069299200;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170044E7 RID: 17639
		// (get) Token: 0x0600877A RID: 34682 RVA: 0x007E34D4 File Offset: 0x007E16D4
		public override int Min
		{
			get
			{
				short num = (short)603686631;
				short num2 = num;
				num = (short)1019643623;
				switch (num2 == num)
				{
				}
				num = (short)1841758208;
				if (num != 0)
				{
				}
				num = (short)16777217;
				if (num != 0)
				{
				}
				num = (short)1569390592;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset._Min;
			}
		}

		// Token: 0x170044E8 RID: 17640
		// (get) Token: 0x0600877B RID: 34683 RVA: 0x007E3584 File Offset: 0x007E1784
		// (set) Token: 0x0600877C RID: 34684 RVA: 0x007E3638 File Offset: 0x007E1838
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)435861854;
				short num2 = num;
				num = (short)1170127198;
				switch (num2 == num)
				{
				}
				num = (short)1048051712;
				if (num != 0)
				{
				}
				num = (short)1180696577;
				if (num != 0)
				{
				}
				num = (short)1833172992;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)605683713;
				if (num != 0)
				{
				}
				num = (short)1964026555;
				short num2 = num;
				num = (short)1818929851;
				switch (num2 == num)
				{
				}
				num = (short)1815937024;
				if (num != 0)
				{
				}
				num = (short)2085879808;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170044E9 RID: 17641
		// (get) Token: 0x0600877D RID: 34685 RVA: 0x007E36E8 File Offset: 0x007E18E8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1956327579;
				short num2 = num;
				num = (short)672477339;
				switch (num2 == num)
				{
				}
				num = (short)1662648321;
				if (num != 0)
				{
				}
				num = (short)1106378752;
				if (num != 0)
				{
				}
				num = (short)1842872320;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x007E3798 File Offset: 0x007E1998
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1465223757;
			short num2 = num;
			num = (short)1377339981;
			switch (num2 == num)
			{
			}
			num = (short)617218049;
			if (num != 0)
			{
			}
			num = (short)1944780800;
			if (num != 0)
			{
			}
			num = (short)910557184;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7Inner(this);
		}

		// Token: 0x0600877F RID: 34687 RVA: 0x007E3848 File Offset: 0x007E1A48
		internal void SetValues()
		{
			short num = (short)732374518;
			short num2 = num;
			num = (short)840115702;
			switch (num2 == num)
			{
			}
			num = (short)812318721;
			if (num != 0)
			{
			}
			num = (short)414253056;
			if (num != 0)
			{
			}
			num = (short)592183296;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_O7;
			base.DataTransferOrder = 65;
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x007E3914 File Offset: 0x007E1B14
		// Note: this type is marked as 'beforefieldinit'.
		static O7InnerRecset()
		{
			short num = (short)1771754141;
			short num2 = num;
			num = (short)623563421;
			switch (num2 == num)
			{
			}
			num = (short)1163329537;
			if (num != 0)
			{
			}
			num = (short)177995776;
			if (num != 0)
			{
			}
			num = (short)2026438656;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset._Min = 1;
		}

		// Token: 0x04003FEF RID: 16367
		public static int _MaxPool;

		// Token: 0x04003FF0 RID: 16368
		public static int _Max;

		// Token: 0x04003FF1 RID: 16369
		public int _DynMax;

		// Token: 0x04003FF2 RID: 16370
		public static int _Min;

		// Token: 0x04003FF3 RID: 16371
		public static int _DefaultRecordCount;
	}
}
