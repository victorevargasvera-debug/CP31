using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200001F RID: 31
	internal class r : global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.RUDP.r>
	{
		// Token: 0x06000165 RID: 357 RVA: 0x0001830C File Offset: 0x0001650C
		public ushort b()
		{
			short num = (short)1370040998;
			short num2 = num;
			num = (short)781658790;
			switch (num2 == num)
			{
			}
			num = (short)337379329;
			if (num != 0)
			{
			}
			num = (short)796917760;
			short num3 = num;
			num = (short)1924792320;
			if (num != 0)
			{
			}
			return (ushort)(this.c.Next() % 65535);
		}

		// Token: 0x040000BE RID: 190
		private const ushort a = 0;

		// Token: 0x040000BF RID: 191
		private const ushort b = 65535;

		// Token: 0x040000C0 RID: 192
		private global::System.Random c = new global::System.Random();
	}
}
