using System;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000027 RID: 39
	public class ListListletItem : global::Motorola.Acp.PackUnpack.Ish.IshItem, global::Motorola.Acp.PackUnpack.Ish.IListNode
	{
		// Token: 0x06000172 RID: 370 RVA: 0x00022790 File Offset: 0x00020990
		internal ListListletItem(global::Motorola.Acp.PackUnpack.Ish.ListListletType A_0, int A_1, int A_2, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_3, global::Motorola.Acp.PackUnpack.Ish.IshItemName A_4, global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout A_5)
		{
			int a_ = 13;
			base..ctor(A_0, A_1, A_5);
			if (A_2 <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("잣장\ud8a7쮩쾫잭쒯쮱", a_));
			}
			if (A_3 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("삣장\udca7쮩\udcad햯펱", a_));
			}
			this.a = A_2;
			this.b = new global::Motorola.Acp.PackUnpack.Ish.DataArea(A_3);
			this.c = A_4;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00022800 File Offset: 0x00020A00
		internal new global::Motorola.Acp.PackUnpack.Ish.ListListletType Type
		{
			get
			{
				short num = (short)1675775531;
				short num2 = num;
				num = (short)1167150635;
				switch (num2 == num)
				{
				}
				num = (short)1722613761;
				if (num != 0)
				{
				}
				num = (short)1069154304;
				short num3 = num;
				num = (short)1545994240;
				if (num != 0)
				{
				}
				return base.Type as global::Motorola.Acp.PackUnpack.Ish.ListListletType;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000228B4 File Offset: 0x00020AB4
		internal new global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout Layout
		{
			get
			{
				short num = (short)1192361985;
				if (num != 0)
				{
				}
				num = (short)429422138;
				short num2 = num;
				num = (short)938374714;
				switch (num2 == num)
				{
				}
				num = (short)406192128;
				short num3 = num;
				num = (short)1440546816;
				if (num != 0)
				{
				}
				return base.Layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00022968 File Offset: 0x00020B68
		public int Count
		{
			get
			{
				short num = (short)1386872833;
				if (num != 0)
				{
				}
				num = (short)1825572271;
				short num2 = num;
				num = (short)601359791;
				switch (num2 == num)
				{
				}
				num = (short)1548091392;
				short num3 = num;
				num = (short)1554251776;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00022A1C File Offset: 0x00020C1C
		internal global::Motorola.Acp.PackUnpack.Ish.DataArea DataArea
		{
			get
			{
				short num = (short)1326508705;
				short num2 = num;
				num = (short)1268116129;
				switch (num2 == num)
				{
				}
				num = (short)544669697;
				if (num != 0)
				{
				}
				num = (short)1236402176;
				short num3 = num;
				num = (short)1983381504;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00022ACC File Offset: 0x00020CCC
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00022B7C File Offset: 0x00020D7C
		public global::Motorola.Acp.PackUnpack.Ish.IshItemName Next
		{
			get
			{
				short num = (short)841433310;
				short num2 = num;
				num = (short)532103390;
				switch (num2 == num)
				{
				}
				num = (short)976486401;
				if (num != 0)
				{
				}
				num = (short)1477509120;
				short num3 = num;
				num = (short)326631424;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1235172070;
				short num2 = num;
				num = (short)143473382;
				switch (num2 == num)
				{
				}
				num = (short)764870657;
				if (num != 0)
				{
				}
				num = (short)944504832;
				short num3 = num;
				num = (short)412090368;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00022C30 File Offset: 0x00020E30
		public override int Length
		{
			get
			{
				short num = (short)1139746882;
				short num2 = num;
				num = (short)1079650370;
				switch (num2 == num)
				{
				}
				num = (short)1768816640;
				if (num != 0)
				{
				}
				num = (short)1825177600;
				short num3 = num;
				num = (short)1348075521;
				if (num != 0)
				{
				}
				return 4 + (int)this.b.PackedData.Length;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00022CEC File Offset: 0x00020EEC
		public global::Motorola.Acp.PackUnpack.Ish.DataArea Entries
		{
			get
			{
				short num = (short)1690459104;
				short num2 = num;
				num = (short)1401183200;
				switch (num2 == num)
				{
				}
				num = (short)687407105;
				if (num != 0)
				{
				}
				num = (short)374013952;
				short num3 = num;
				num = (short)181862400;
				if (num != 0)
				{
				}
				return this.DataArea;
			}
		}

		// Token: 0x0400007A RID: 122
		private int a;

		// Token: 0x0400007B RID: 123
		private global::Motorola.Acp.PackUnpack.Ish.DataArea b;

		// Token: 0x0400007C RID: 124
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName c;

		// Token: 0x0400007D RID: 125
		private const int d = 4;
	}
}
