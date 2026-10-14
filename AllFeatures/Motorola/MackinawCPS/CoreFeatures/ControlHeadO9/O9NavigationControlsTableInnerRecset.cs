using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000378 RID: 888
	[global::System.Serializable]
	public class O9NavigationControlsTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008379 RID: 33657 RVA: 0x007A4768 File Offset: 0x007A2968
		public O9NavigationControlsTableInnerRecset() : base(global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS)
		{
			this.SetValues();
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x007A4788 File Offset: 0x007A2988
		public O9NavigationControlsTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170042F6 RID: 17142
		// (get) Token: 0x0600837B RID: 33659 RVA: 0x007A47B4 File Offset: 0x007A29B4
		public override int MaxPool
		{
			get
			{
				short num = (short)334168065;
				if (num != 0)
				{
				}
				num = (short)1742206494;
				short num2 = num;
				num = (short)1362425374;
				switch (num2 == num)
				{
				}
				num = (short)1364131840;
				if (num != 0)
				{
				}
				num = (short)104005632;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x170042F7 RID: 17143
		// (get) Token: 0x0600837C RID: 33660 RVA: 0x007A4860 File Offset: 0x007A2A60
		// (set) Token: 0x0600837D RID: 33661 RVA: 0x007A4924 File Offset: 0x007A2B24
		public override int Max
		{
			get
			{
				short num = (short)1782312257;
				short num2 = num;
				num = (short)143387969;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1322385409;
					if (num != 0)
					{
					}
					num = (short)2108030976;
					if (num != 0)
					{
					}
					if (this._DynMax == -1)
					{
						num = (short)471465984;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset._Max;
					}
					break;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)68761917;
				short num2 = num;
				num = (short)24721725;
				switch (num2 == num)
				{
				}
				num = (short)1862533120;
				if (num != 0)
				{
				}
				num = (short)547487745;
				if (num != 0)
				{
				}
				num = (short)221773824;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170042F8 RID: 17144
		// (get) Token: 0x0600837E RID: 33662 RVA: 0x007A49D4 File Offset: 0x007A2BD4
		public override int Min
		{
			get
			{
				short num = (short)1328898006;
				short num2 = num;
				num = (short)1225809878;
				switch (num2 == num)
				{
				}
				num = (short)1383268353;
				if (num != 0)
				{
				}
				num = (short)1965948928;
				if (num != 0)
				{
				}
				num = (short)1563688960;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset._Min;
			}
		}

		// Token: 0x170042F9 RID: 17145
		// (get) Token: 0x0600837F RID: 33663 RVA: 0x007A4A84 File Offset: 0x007A2C84
		// (set) Token: 0x06008380 RID: 33664 RVA: 0x007A4B34 File Offset: 0x007A2D34
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)767164128;
				short num2 = num;
				num = (short)486473440;
				switch (num2 == num)
				{
				}
				num = (short)1369112577;
				if (num != 0)
				{
				}
				num = (short)1111359488;
				if (num != 0)
				{
				}
				num = (short)1055326208;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1204237653;
				short num2 = num;
				num = (short)2034578773;
				switch (num2 == num)
				{
				}
				num = (short)692977665;
				if (num != 0)
				{
				}
				num = (short)306446336;
				if (num != 0)
				{
				}
				num = (short)161546240;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170042FA RID: 17146
		// (get) Token: 0x06008381 RID: 33665 RVA: 0x007A4BE4 File Offset: 0x007A2DE4
		public bool HasDiffs
		{
			get
			{
				short num = (short)633643299;
				short num2 = num;
				num = (short)1097113891;
				switch (num2 == num)
				{
				}
				num = (short)697237505;
				if (num != 0)
				{
				}
				num = (short)541786112;
				if (num != 0)
				{
				}
				num = (short)202571776;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x007A4C90 File Offset: 0x007A2E90
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1282382720;
			short num2 = num;
			num = (short)1502124928;
			switch (num2 == num)
			{
			}
			num = (short)898433025;
			if (num != 0)
			{
			}
			num = (short)1066008576;
			if (num != 0)
			{
			}
			num = (short)914030592;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner(this);
		}

		// Token: 0x06008383 RID: 33667 RVA: 0x007A4D40 File Offset: 0x007A2F40
		internal void SetValues()
		{
			short num = (short)1101233098;
			short num2 = num;
			num = (short)1230863306;
			switch (num2 == num)
			{
			}
			num = (short)1641545729;
			if (num != 0)
			{
			}
			num = (short)812843008;
			if (num != 0)
			{
			}
			num = (short)688062464;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 50;
		}

		// Token: 0x06008384 RID: 33668 RVA: 0x007A4E08 File Offset: 0x007A3008
		// Note: this type is marked as 'beforefieldinit'.
		static O9NavigationControlsTableInnerRecset()
		{
			short num = (short)1626782396;
			short num2 = num;
			num = (short)1722333884;
			switch (num2 == num)
			{
			}
			num = (short)625541121;
			if (num != 0)
			{
			}
			num = (short)559808512;
			if (num != 0)
			{
			}
			num = (short)903806976;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset._Min = 1;
		}

		// Token: 0x04003E5A RID: 15962
		public static int _MaxPool;

		// Token: 0x04003E5B RID: 15963
		public static int _Max;

		// Token: 0x04003E5C RID: 15964
		public int _DynMax;

		// Token: 0x04003E5D RID: 15965
		public static int _Min;

		// Token: 0x04003E5E RID: 15966
		public static int _DefaultRecordCount;
	}
}
