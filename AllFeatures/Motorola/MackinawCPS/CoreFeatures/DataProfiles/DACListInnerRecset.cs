using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x020004F3 RID: 1267
	[global::System.Serializable]
	public class DACListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600AA2F RID: 43567 RVA: 0x009E7AB0 File Offset: 0x009E5CB0
		public DACListInnerRecset() : base(global::CommonResources.AcgResources.ID_CCAPDACLIST)
		{
			this.SetValues();
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x009E7AD0 File Offset: 0x009E5CD0
		public DACListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005544 RID: 21828
		// (get) Token: 0x0600AA31 RID: 43569 RVA: 0x009E7AFC File Offset: 0x009E5CFC
		public override int MaxPool
		{
			get
			{
				short num = (short)1902870309;
				short num2 = num;
				num = (short)77561637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)436404224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)622854145;
				if (num != 0)
				{
				}
				num = (short)820248576;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005545 RID: 21829
		// (get) Token: 0x0600AA32 RID: 43570 RVA: 0x009E7BB0 File Offset: 0x009E5DB0
		// (set) Token: 0x0600AA33 RID: 43571 RVA: 0x009E7C70 File Offset: 0x009E5E70
		public override int Max
		{
			get
			{
				short num = (short)1414070273;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					num = (short)1784842135;
					short num2 = num;
					num = (short)1394968471;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1970733056;
						short num3 = num;
						num = (short)1275658240;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset._Max;
			}
			set
			{
				short num = (short)2119499777;
				if (num != 0)
				{
				}
				num = (short)1485832192;
				short num2 = num;
				num = (short)730432467;
				short num3 = num;
				num = (short)444302291;
				switch (num3 == num)
				{
				}
				num = (short)1034813440;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005546 RID: 21830
		// (get) Token: 0x0600AA34 RID: 43572 RVA: 0x009E7D20 File Offset: 0x009E5F20
		public override int Min
		{
			get
			{
				short num = (short)304887643;
				short num2 = num;
				num = (short)758069083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1723203584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1863122945;
				if (num != 0)
				{
				}
				num = (short)1812135936;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset._Min;
			}
		}

		// Token: 0x17005547 RID: 21831
		// (get) Token: 0x0600AA35 RID: 43573 RVA: 0x009E7DD0 File Offset: 0x009E5FD0
		// (set) Token: 0x0600AA36 RID: 43574 RVA: 0x009E7E80 File Offset: 0x009E6080
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)783524286;
				short num2 = num;
				num = (short)1480892862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)71761920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1276575744;
				if (num != 0)
				{
				}
				num = (short)694484993;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1806646769;
				short num2 = num;
				num = (short)196099569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)907673600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1090322433;
				if (num != 0)
				{
				}
				num = (short)187432960;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17005548 RID: 21832
		// (get) Token: 0x0600AA37 RID: 43575 RVA: 0x009E7F30 File Offset: 0x009E6130
		public bool HasDiffs
		{
			get
			{
				short num = (short)424068553;
				short num2 = num;
				num = (short)487572937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)630456320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)996081665;
				if (num != 0)
				{
				}
				num = (short)1614938112;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600AA38 RID: 43576 RVA: 0x009E7FE4 File Offset: 0x009E61E4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)380891916;
			short num2 = num;
			num = (short)886698764;
			switch (num2 == num)
			{
			default:
			{
				num = (short)678297600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)735838209;
			if (num != 0)
			{
			}
			num = (short)769851392;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInner(this);
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x009E8090 File Offset: 0x009E6290
		internal void SetValues()
		{
			short num = (short)2146914458;
			short num2 = num;
			num = (short)1713262746;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1996947456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)828243969;
			if (num != 0)
			{
			}
			num = (short)1837694976;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CCAPDACLIST;
			base.DataTransferOrder = 28;
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x009E815C File Offset: 0x009E635C
		// Note: this type is marked as 'beforefieldinit'.
		static DACListInnerRecset()
		{
			short num = (short)740316748;
			short num2 = num;
			num = (short)224286284;
			switch (num2 == num)
			{
			default:
			{
				num = (short)145752064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1812398081;
			if (num != 0)
			{
			}
			num = (short)351666176;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset._Min = 1;
		}

		// Token: 0x0400514F RID: 20815
		public static int _MaxPool;

		// Token: 0x04005150 RID: 20816
		public static int _Max;

		// Token: 0x04005151 RID: 20817
		public int _DynMax;

		// Token: 0x04005152 RID: 20818
		public static int _Min;

		// Token: 0x04005153 RID: 20819
		public static int _DefaultRecordCount;
	}
}
