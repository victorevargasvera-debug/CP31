using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200033F RID: 831
	[global::System.Serializable]
	public class DirectStatusBCOListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007FC1 RID: 32705 RVA: 0x00758280 File Offset: 0x00756480
		public DirectStatusBCOListInnerRecset() : base(global::CommonResources.AcgResources.ID_DIRECTSTATUSBCOLIST)
		{
			this.SetValues();
		}

		// Token: 0x06007FC2 RID: 32706 RVA: 0x007582A0 File Offset: 0x007564A0
		public DirectStatusBCOListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004157 RID: 16727
		// (get) Token: 0x06007FC3 RID: 32707 RVA: 0x007582CC File Offset: 0x007564CC
		public override int MaxPool
		{
			get
			{
				short num = (short)2021628399;
				short num2 = num;
				num = (short)1190959599;
				switch (num2 == num)
				{
				}
				num = (short)1839005697;
				if (num != 0)
				{
				}
				num = (short)288358400;
				if (num != 0)
				{
				}
				num = (short)1229127680;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004158 RID: 16728
		// (get) Token: 0x06007FC4 RID: 32708 RVA: 0x00758378 File Offset: 0x00756578
		// (set) Token: 0x06007FC5 RID: 32709 RVA: 0x00758438 File Offset: 0x00756638
		public override int Max
		{
			get
			{
				short num;
				while (this._DynMax == -1)
				{
					num = (short)6328540;
					short num2 = num;
					num = (short)1930596572;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1675362305;
						if (num != 0)
						{
						}
						num = (short)1977679872;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset._Max;
					}
				}
				num = (short)1286209536;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)781442323;
				short num2 = num;
				num = (short)1525800211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2077753344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010434049;
				if (num != 0)
				{
				}
				num = (short)1609826304;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004159 RID: 16729
		// (get) Token: 0x06007FC6 RID: 32710 RVA: 0x007584EC File Offset: 0x007566EC
		public override int Min
		{
			get
			{
				short num = (short)811144048;
				short num2 = num;
				num = (short)1971131248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1324285952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)107741185;
				if (num != 0)
				{
				}
				num = (short)1877868544;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset._Min;
			}
		}

		// Token: 0x1700415A RID: 16730
		// (get) Token: 0x06007FC7 RID: 32711 RVA: 0x0075859C File Offset: 0x0075679C
		// (set) Token: 0x06007FC8 RID: 32712 RVA: 0x0075864C File Offset: 0x0075684C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)243007489;
				if (num != 0)
				{
				}
				num = (short)768212992;
				short num2 = num;
				num = (short)559680697;
				short num3 = num;
				num = (short)282266809;
				switch (num3 == num)
				{
				}
				num = (short)33947648;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)472317953;
				if (num != 0)
				{
				}
				num = (short)488308736;
				short num2 = num;
				num = (short)94444823;
				short num3 = num;
				num = (short)2121735447;
				switch (num3 == num)
				{
				}
				num = (short)628621312;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700415B RID: 16731
		// (get) Token: 0x06007FC9 RID: 32713 RVA: 0x007586FC File Offset: 0x007568FC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1512774544;
				short num2 = num;
				num = (short)422452112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966342144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1052180480;
				if (num != 0)
				{
				}
				num = (short)684654593;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007FCA RID: 32714 RVA: 0x007587A8 File Offset: 0x007569A8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)733879861;
			short num2 = num;
			num = (short)1539186229;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1613365248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1637744640;
			if (num != 0)
			{
			}
			num = (short)675676161;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner(this);
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x00758858 File Offset: 0x00756A58
		internal void SetValues()
		{
			short num = (short)1957763624;
			short num2 = num;
			num = (short)981735976;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1067515904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1866203137;
			if (num != 0)
			{
			}
			num = (short)1265631232;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTSTATUSBCOLIST;
			base.DataTransferOrder = 14;
		}

		// Token: 0x06007FCC RID: 32716 RVA: 0x00758924 File Offset: 0x00756B24
		// Note: this type is marked as 'beforefieldinit'.
		static DirectStatusBCOListInnerRecset()
		{
			short num = (short)1368588932;
			short num2 = num;
			num = (short)1133380228;
			switch (num2 == num)
			{
			default:
			{
				num = (short)898039808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1132068865;
			if (num != 0)
			{
			}
			num = (short)2088435712;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset._Min = 1;
		}

		// Token: 0x040039B2 RID: 14770
		public static int _MaxPool;

		// Token: 0x040039B3 RID: 14771
		public static int _Max;

		// Token: 0x040039B4 RID: 14772
		public int _DynMax;

		// Token: 0x040039B5 RID: 14773
		public static int _Min;

		// Token: 0x040039B6 RID: 14774
		public static int _DefaultRecordCount;
	}
}
