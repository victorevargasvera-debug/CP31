using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200001D RID: 29
	public class IshId
	{
		// Token: 0x06000137 RID: 311 RVA: 0x0001FBBC File Offset: 0x0001DDBC
		internal IshId(int A_0)
		{
			int a_ = 2;
			base..ctor();
			if (A_0 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾚ", a_));
			}
			this.a = A_0;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0001FBFC File Offset: 0x0001DDFC
		internal int Value
		{
			get
			{
				short num = (short)1100819240;
				short num2 = num;
				num = (short)1956588328;
				switch (num2 == num)
				{
				}
				num = (short)1482227712;
				if (num != 0)
				{
				}
				num = (short)1441857536;
				short num3 = num;
				num = (short)1611071489;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x04000060 RID: 96
		private int a;
	}
}
