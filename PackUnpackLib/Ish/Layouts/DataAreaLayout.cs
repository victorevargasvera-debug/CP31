using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000056 RID: 86
	public class DataAreaLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.Layout, global::Motorola.Acp.PackUnpack.Ish.Layouts.IChildLayout<global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout>, global::Motorola.Acp.PackUnpack.Ish.Layouts.ILayout
	{
		// Token: 0x06000311 RID: 785 RVA: 0x00042638 File Offset: 0x00040838
		internal DataAreaLayout(global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout A_0, global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType A_1, string A_2, int A_3)
		{
			int a_ = 17;
			base..ctor(A_2);
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ud8a7쮩\udeab쮭\udeaf욱", a_));
			}
			if (!global::System.Enum.IsDefined(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType), A_1))
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즧\ud8a9즫쾭", a_));
			}
			if (A_3 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udba7쎩횫쮭", a_));
			}
			this.a = A_0;
			this.b = A_1;
			this.d = A_3;
			this.c = new global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection(this);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000426D8 File Offset: 0x000408D8
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout Parent
		{
			get
			{
				short num = (short)938349468;
				short num2 = num;
				num = (short)1820005276;
				switch (num2 == num)
				{
				}
				num = (short)56885249;
				if (num != 0)
				{
				}
				num = (short)1236205568;
				if (num != 0)
				{
				}
				num = (short)2013593600;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00042788 File Offset: 0x00040988
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType AreaType
		{
			get
			{
				short num = (short)1263534081;
				if (num != 0)
				{
				}
				num = (short)606690548;
				short num2 = num;
				num = (short)2135186676;
				switch (num2 == num)
				{
				}
				num = (short)1477050368;
				if (num != 0)
				{
				}
				num = (short)2117468160;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00042838 File Offset: 0x00040A38
		public global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection FieldLayouts
		{
			get
			{
				short num = (short)1009463991;
				short num2 = num;
				num = (short)1234383543;
				switch (num2 == num)
				{
				}
				num = (short)359858177;
				if (num != 0)
				{
				}
				num = (short)1805516800;
				if (num != 0)
				{
				}
				num = (short)1457979392;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000428E4 File Offset: 0x00040AE4
		internal bool IsPaddingRequired
		{
			get
			{
				short num = (short)1942529281;
				short num2 = num;
				num = (short)1415554305;
				int count;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1421803520;
					if (num != 0)
					{
					}
					num = (short)1860763649;
					if (num != 0)
					{
					}
					count = this.c.Count;
					if (count == 0)
					{
						num = (short)1160511488;
						short num3 = num;
						return this.d > 0;
					}
					break;
				}
				global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout = this.c[count - 1];
				return fieldLayout.Offset + fieldLayout.Size < this.d;
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000429CC File Offset: 0x00040BCC
		internal int c()
		{
			short num = (short)1688403969;
			if (num != 0)
			{
			}
			num = (short)1546673683;
			short num2 = num;
			num = (short)1217748499;
			int count;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1204879360;
				if (num != 0)
				{
				}
				count = this.c.Count;
				if (count == 0)
				{
					num = (short)2424832;
					short num3 = num;
					return this.d;
				}
				break;
			}
			global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout fieldLayout = this.c[count - 1];
			return this.d - (fieldLayout.Offset + fieldLayout.Size);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00042AB0 File Offset: 0x00040CB0
		internal int Size
		{
			get
			{
				short num = (short)1838215951;
				short num2 = num;
				num = (short)558887695;
				switch (num2 == num)
				{
				}
				num = (short)1348337664;
				if (num != 0)
				{
				}
				num = (short)1326514177;
				if (num != 0)
				{
				}
				num = (short)1563754496;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x04000118 RID: 280
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout a;

		// Token: 0x04000119 RID: 281
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType b;

		// Token: 0x0400011A RID: 282
		private global::Motorola.Acp.PackUnpack.Ish.Collections.FieldLayoutCollection c;

		// Token: 0x0400011B RID: 283
		private int d;
	}
}
