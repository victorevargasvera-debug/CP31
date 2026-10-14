using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000071 RID: 113
	public class UclHotListLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout
	{
		// Token: 0x0600035F RID: 863 RVA: 0x00045048 File Offset: 0x00043248
		public UclHotListLayout(string name, global::Motorola.Acp.PackUnpack.Ish.UclHotListHeaderType headerType, global::Motorola.Acp.PackUnpack.Ish.UclHotListListletType listletType, global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType signallingIshType, int listCapacity, int headerCapacity, int listletCapacity, int headerDataAreaSize, int listEntrySize)
		{
			int a_ = 9;
			base..ctor(name, headerType, listletType, listCapacity, headerCapacity, listletCapacity, headerDataAreaSize, listEntrySize);
			if (signallingIshType == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟쮡쎣좥즧용삫잭\udeaf햱ﶳ억킷얻캽ꖿ", a_));
			}
			this.a = signallingIshType;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00045094 File Offset: 0x00043294
		internal global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType SignallingIshType
		{
			get
			{
				short num = (short)1392942076;
				short num2 = num;
				num = (short)1862704124;
				switch (num2 == num)
				{
				}
				num = (short)374472704;
				short num3 = num;
				num = (short)206372864;
				if (num != 0)
				{
				}
				num = (short)479592449;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x04000154 RID: 340
		private global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType a;
	}
}
