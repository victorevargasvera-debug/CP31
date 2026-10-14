using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability
{
	// Token: 0x02000249 RID: 585
	[global::System.Serializable]
	public class PerAccListTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06006872 RID: 26738 RVA: 0x005D7ABC File Offset: 0x005D5CBC
		public PerAccListTableInnerRecset() : base(global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLIST, true, false, global::CommonResources.AcgResources.ID_ALERT)
		{
			this.SetValues();
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x005D7AE4 File Offset: 0x005D5CE4
		public PerAccListTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x06006874 RID: 26740 RVA: 0x005D7B10 File Offset: 0x005D5D10
		public override int MaxPool
		{
			get
			{
				short num = (short)1957670447;
				short num2 = num;
				num = (short)140029487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1874329600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1203437569;
				if (num != 0)
				{
				}
				num = (short)1526923264;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x06006875 RID: 26741 RVA: 0x005D7BC0 File Offset: 0x005D5DC0
		// (set) Token: 0x06006876 RID: 26742 RVA: 0x005D7C80 File Offset: 0x005D5E80
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1642508767;
					short num2 = num;
					num = (short)1662169567;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A7;
					case 1:
						break;
					default:
					{
						num = (short)1169358848;
						short num3 = num;
						break;
					}
					}
					num = (short)1336344577;
					if (num != 0)
					{
					}
					num = (short)1533542400;
					if (num != 0)
					{
					}
					IL_A7:
					return global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)416808961;
				if (num != 0)
				{
				}
				num = (short)1544617984;
				short num2 = num;
				num = (short)849287066;
				short num3 = num;
				num = (short)1799427994;
				switch (num3 == num)
				{
				}
				num = (short)635240448;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x06006877 RID: 26743 RVA: 0x005D7D30 File Offset: 0x005D5F30
		public override int Min
		{
			get
			{
				short num = (short)1330577409;
				if (num != 0)
				{
				}
				num = (short)1358036992;
				short num2 = num;
				num = (short)2033629157;
				short num3 = num;
				num = (short)1894823909;
				switch (num3 == num)
				{
				}
				num = (short)1615527936;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset._Min;
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x06006878 RID: 26744 RVA: 0x005D7DE0 File Offset: 0x005D5FE0
		// (set) Token: 0x06006879 RID: 26745 RVA: 0x005D7E8C File Offset: 0x005D608C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1822928897;
				short num2 = num;
				num = (short)1046261761;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1549205504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)65667073;
				if (num != 0)
				{
				}
				num = (short)763756544;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1343594421;
				short num2 = num;
				num = (short)1566941109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1530920960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)141164544;
				if (num != 0)
				{
				}
				num = (short)1701511169;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600687A RID: 26746 RVA: 0x005D7F3C File Offset: 0x005D613C
		public bool HasDiffs
		{
			get
			{
				short num = (short)651510661;
				short num2 = num;
				num = (short)877151109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1694892032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1767374849;
				if (num != 0)
				{
				}
				num = (short)1009123328;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x005D7FEC File Offset: 0x005D61EC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)368469894;
			short num2 = num;
			num = (short)280323974;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1708392448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1677524993;
			if (num != 0)
			{
			}
			num = (short)320208896;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner(this);
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x005D809C File Offset: 0x005D629C
		internal void SetValues()
		{
			short num = (short)382533633;
			if (num != 0)
			{
			}
			num = (short)1399586816;
			short num2 = num;
			num = (short)1657019916;
			short num3 = num;
			num = (short)450698764;
			switch (num3 == num)
			{
			}
			num = (short)1797521408;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_ALERT;
			base.DataTransferOrder = 77;
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x005D8170 File Offset: 0x005D6370
		// Note: this type is marked as 'beforefieldinit'.
		static PerAccListTableInnerRecset()
		{
			short num = (short)464241669;
			short num2 = num;
			num = (short)365216773;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1760231424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1138425857;
			if (num != 0)
			{
			}
			num = (short)475267072;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerRecset._Min = 1;
		}

		// Token: 0x04002912 RID: 10514
		public static int _MaxPool;

		// Token: 0x04002913 RID: 10515
		public static int _Max;

		// Token: 0x04002914 RID: 10516
		public int _DynMax;

		// Token: 0x04002915 RID: 10517
		public static int _Min;

		// Token: 0x04002916 RID: 10518
		public static int _DefaultRecordCount;
	}
}
