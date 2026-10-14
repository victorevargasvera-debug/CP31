using System;
using AcpASKLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000DC RID: 220
	public class OwnerSystemData
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x00003082 File Offset: 0x00001282
		public OwnerSystemData(int ownerID, global::AcpASKLib.KeyType ownerType)
		{
			this.a = ownerID;
			this.b = ownerType;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00117624 File Offset: 0x00115824
		internal int OwnerSystemID
		{
			get
			{
				short num = (short)224264193;
				if (num != 0)
				{
				}
				num = (short)1485701120;
				short num2 = num;
				num = (short)793478249;
				short num3 = num;
				num = (short)235963497;
				switch (num3 == num)
				{
				}
				num = (short)101974016;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x001176D4 File Offset: 0x001158D4
		internal global::AcpASKLib.KeyType OwnerSystemType
		{
			get
			{
				short num = (short)1624446530;
				short num2 = num;
				num = (short)1954485826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)866123776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)889716736;
				if (num != 0)
				{
				}
				num = (short)849543169;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x040006B8 RID: 1720
		private int a;

		// Token: 0x040006B9 RID: 1721
		private global::AcpASKLib.KeyType b;
	}
}
