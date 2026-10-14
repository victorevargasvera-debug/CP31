using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000454 RID: 1108
	[global::System.Serializable]
	public class RxFrequencyListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060093F1 RID: 37873 RVA: 0x008B6BEC File Offset: 0x008B4DEC
		public RxFrequencyListInnerRecset() : base(global::CommonResources.AcgResources.ID_RXFREQUENCYLIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x060093F2 RID: 37874 RVA: 0x008B6C10 File Offset: 0x008B4E10
		public RxFrequencyListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004A7D RID: 19069
		// (get) Token: 0x060093F3 RID: 37875 RVA: 0x008B6C3C File Offset: 0x008B4E3C
		public override int MaxPool
		{
			get
			{
				short num = (short)357159818;
				short num2 = num;
				num = (short)691065738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1047003136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1842872321;
				if (num != 0)
				{
				}
				num = (short)1767112704;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004A7E RID: 19070
		// (get) Token: 0x060093F4 RID: 37876 RVA: 0x008B6CEC File Offset: 0x008B4EEC
		// (set) Token: 0x060093F5 RID: 37877 RVA: 0x008B6DB0 File Offset: 0x008B4FB0
		public override int Max
		{
			get
			{
				short num = (short)164364289;
				if (num != 0)
				{
				}
				if (this._DynMax == -1)
				{
					num = (short)1075723498;
					short num2 = num;
					num = (short)1833843946;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)758120448;
						short num3 = num;
						num = (short)1703215104;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)18313334;
				short num2 = num;
				num = (short)1175548022;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282525696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2122973184;
				if (num != 0)
				{
				}
				num = (short)742981633;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004A7F RID: 19071
		// (get) Token: 0x060093F6 RID: 37878 RVA: 0x008B6E60 File Offset: 0x008B5060
		public override int Min
		{
			get
			{
				short num = (short)478273768;
				short num2 = num;
				num = (short)1062265064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2062024704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858076673;
				if (num != 0)
				{
				}
				num = (short)1936064512;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset._Min;
			}
		}

		// Token: 0x17004A80 RID: 19072
		// (get) Token: 0x060093F7 RID: 37879 RVA: 0x008B6F10 File Offset: 0x008B5110
		// (set) Token: 0x060093F8 RID: 37880 RVA: 0x008B6FC0 File Offset: 0x008B51C0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)712110045;
				short num2 = num;
				num = (short)996601821;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26738688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)147783681;
				if (num != 0)
				{
				}
				num = (short)1787625472;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)500134341;
				short num2 = num;
				num = (short)1742827973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)126287872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007484929;
				if (num != 0)
				{
				}
				num = (short)915603456;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004A81 RID: 19073
		// (get) Token: 0x060093F9 RID: 37881 RVA: 0x008B7070 File Offset: 0x008B5270
		public bool HasDiffs
		{
			get
			{
				short num = (short)559024716;
				short num2 = num;
				num = (short)171444812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2016477184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)192872449;
				if (num != 0)
				{
				}
				num = (short)19333120;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060093FA RID: 37882 RVA: 0x008B7120 File Offset: 0x008B5320
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1874140866;
			short num2 = num;
			num = (short)872029890;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1963655168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1380057089;
			if (num != 0)
			{
			}
			num = (short)955842560;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInner(this);
		}

		// Token: 0x060093FB RID: 37883 RVA: 0x008B71CC File Offset: 0x008B53CC
		internal void SetValues()
		{
			short num = (short)1494548481;
			if (num != 0)
			{
			}
			num = (short)1638006784;
			short num2 = num;
			num = (short)1281222729;
			short num3 = num;
			num = (short)247588937;
			switch (num3 == num)
			{
			}
			num = (short)282984448;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYLIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060093FC RID: 37884 RVA: 0x008B7294 File Offset: 0x008B5494
		// Note: this type is marked as 'beforefieldinit'.
		static RxFrequencyListInnerRecset()
		{
			short num = (short)92113168;
			short num2 = num;
			num = (short)1127385360;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1559298048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)62914560;
			if (num != 0)
			{
			}
			num = (short)484966401;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset._Min = 1;
		}

		// Token: 0x040049DE RID: 18910
		public static int _MaxPool;

		// Token: 0x040049DF RID: 18911
		public static int _Max;

		// Token: 0x040049E0 RID: 18912
		public int _DynMax;

		// Token: 0x040049E1 RID: 18913
		public static int _Min;

		// Token: 0x040049E2 RID: 18914
		public static int _DefaultRecordCount;
	}
}
