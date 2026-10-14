using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x020003A6 RID: 934
	[global::System.Serializable]
	public class O7NavigationControlsTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008831 RID: 34865 RVA: 0x007EBC68 File Offset: 0x007E9E68
		public O7NavigationControlsTableInnerRecset() : base(global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS, global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS)
		{
			this.SetValues();
		}

		// Token: 0x06008832 RID: 34866 RVA: 0x007EBC8C File Offset: 0x007E9E8C
		public O7NavigationControlsTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700453B RID: 17723
		// (get) Token: 0x06008833 RID: 34867 RVA: 0x007EBCB8 File Offset: 0x007E9EB8
		public override int MaxPool
		{
			get
			{
				short num = (short)1706622977;
				if (num != 0)
				{
				}
				num = (short)122617856;
				short num2 = num;
				num = (short)394315992;
				short num3 = num;
				num = (short)1941358808;
				switch (num3 == num)
				{
				}
				num = (short)607649792;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700453C RID: 17724
		// (get) Token: 0x06008834 RID: 34868 RVA: 0x007EBD64 File Offset: 0x007E9F64
		// (set) Token: 0x06008835 RID: 34869 RVA: 0x007EBE28 File Offset: 0x007EA028
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num;
					for (;;)
					{
						num = (short)205843008;
						short num2 = num;
						num = (short)1509222976;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_44;
						}
					}
					IL_44:
					num = (short)41943041;
					if (num != 0)
					{
					}
					num = (short)1364197376;
					if (num != 0)
					{
					}
					num = (short)2086797312;
					short num3 = num;
					return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1973176138;
				short num2 = num;
				num = (short)1149060938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1746206720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)434110464;
				if (num != 0)
				{
				}
				num = (short)118751233;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700453D RID: 17725
		// (get) Token: 0x06008836 RID: 34870 RVA: 0x007EBED8 File Offset: 0x007EA0D8
		public override int Min
		{
			get
			{
				short num = (short)882323423;
				short num2 = num;
				num = (short)1709912031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1348075520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)942669825;
				if (num != 0)
				{
				}
				num = (short)883490816;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset._Min;
			}
		}

		// Token: 0x1700453E RID: 17726
		// (get) Token: 0x06008837 RID: 34871 RVA: 0x007EBF88 File Offset: 0x007EA188
		// (set) Token: 0x06008838 RID: 34872 RVA: 0x007EC03C File Offset: 0x007EA23C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)491907199;
				short num2 = num;
				num = (short)1364781183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499318784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)464388096;
				if (num != 0)
				{
				}
				num = (short)1035272193;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)647897524;
				short num2 = num;
				num = (short)402792884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1646460928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1220149249;
				if (num != 0)
				{
				}
				num = (short)1613627392;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700453F RID: 17727
		// (get) Token: 0x06008839 RID: 34873 RVA: 0x007EC0F0 File Offset: 0x007EA2F0
		public bool HasDiffs
		{
			get
			{
				short num = (short)135767463;
				short num2 = num;
				num = (short)2077861287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)781451264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1220214784;
				if (num != 0)
				{
				}
				num = (short)1909260289;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x007EC1A4 File Offset: 0x007EA3A4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1149136312;
			short num2 = num;
			num = (short)881946040;
			switch (num2 == num)
			{
			default:
			{
				num = (short)660930560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)852230145;
			if (num != 0)
			{
			}
			num = (short)126222336;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInner(this);
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x007EC258 File Offset: 0x007EA458
		internal void SetValues()
		{
			short num = (short)487784660;
			short num2 = num;
			num = (short)2118910164;
			switch (num2 == num)
			{
			default:
			{
				num = (short)406061056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1281490945;
			if (num != 0)
			{
			}
			num = (short)1512112128;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.KeySeed = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 65;
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x007EC32C File Offset: 0x007EA52C
		// Note: this type is marked as 'beforefieldinit'.
		static O7NavigationControlsTableInnerRecset()
		{
			short num = (short)1189207015;
			short num2 = num;
			num = (short)2000346087;
			switch (num2 == num)
			{
			default:
			{
				num = (short)514326528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2107899905;
			if (num != 0)
			{
			}
			num = (short)1552547840;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset._Min = 1;
		}

		// Token: 0x04004001 RID: 16385
		public static int _MaxPool;

		// Token: 0x04004002 RID: 16386
		public static int _Max;

		// Token: 0x04004003 RID: 16387
		public int _DynMax;

		// Token: 0x04004004 RID: 16388
		public static int _Min;

		// Token: 0x04004005 RID: 16389
		public static int _DefaultRecordCount;
	}
}
