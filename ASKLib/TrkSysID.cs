using System;
using ASK.Interface;

namespace ASKLib
{
	// Token: 0x02000008 RID: 8
	public class TrkSysID
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000034F8 File Offset: 0x000016F8
		internal TrkSysID(global::ASK.Interface.KeyType A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000351C File Offset: 0x0000171C
		internal global::ASK.Interface.KeyType SystemKeyType
		{
			get
			{
				short num = (short)1670807857;
				short num2 = num;
				num = (short)1106084145;
				switch (num2 == num)
				{
				}
				num = (short)1373437952;
				short num3 = num;
				num = (short)1018232832;
				if (num != 0)
				{
				}
				num = (short)1782841345;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000035C8 File Offset: 0x000017C8
		internal int ID
		{
			get
			{
				short num = (short)733972629;
				short num2 = num;
				num = (short)530745493;
				switch (num2 == num)
				{
				}
				num = (short)1254948864;
				short num3 = num;
				num = (short)236584960;
				if (num != 0)
				{
				}
				num = (short)1839988737;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0400000C RID: 12
		private global::ASK.Interface.KeyType a;

		// Token: 0x0400000D RID: 13
		private int b;
	}
}
