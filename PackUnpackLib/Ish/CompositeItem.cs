using System;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200000F RID: 15
	public class CompositeItem : global::Motorola.Acp.PackUnpack.Ish.IshItem
	{
		// Token: 0x06000098 RID: 152 RVA: 0x0000E784 File Offset: 0x0000C984
		internal CompositeItem(global::Motorola.Acp.PackUnpack.Ish.CompositeType A_0, int A_1, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout A_2) : base(A_0, A_1, A_2)
		{
			this.a = new global::Motorola.Acp.PackUnpack.Ish.DataArea();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		internal CompositeItem(global::Motorola.Acp.PackUnpack.Ish.CompositeType A_0, int A_1, int A_2, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout A_3)
		{
			int a_ = 3;
			base..ctor(A_0, A_1, A_3);
			if (A_2 <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("蓮ﶛ솟송춣튥톧", a_));
			}
			global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream a_2 = new global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream(new byte[A_2], true);
			this.a = new global::Motorola.Acp.PackUnpack.Ish.DataArea(a_2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000E7FC File Offset: 0x0000C9FC
		internal CompositeItem(global::Motorola.Acp.PackUnpack.Ish.CompositeType A_0, int A_1, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStream A_2, global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout A_3)
		{
			int a_ = 7;
			base..ctor(A_0, A_1, A_3);
			if (A_2 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풟킡솣장얧", a_));
			}
			if (A_2.Length == 0L)
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("욟쒡힣쎥\udca7", a_));
			}
			this.a = new global::Motorola.Acp.PackUnpack.Ish.DataArea(A_2);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000E860 File Offset: 0x0000CA60
		internal new global::Motorola.Acp.PackUnpack.Ish.CompositeType Type
		{
			get
			{
				short num = (short)562892105;
				short num2 = num;
				num = (short)1703415113;
				switch (num2 == num)
				{
				}
				num = (short)849936385;
				if (num != 0)
				{
				}
				num = (short)1441923072;
				if (num != 0)
				{
				}
				num = (short)1190395904;
				short num3 = num;
				return base.Type as global::Motorola.Acp.PackUnpack.Ish.CompositeType;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000E914 File Offset: 0x0000CB14
		internal new global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout Layout
		{
			get
			{
				short num = (short)1162343908;
				short num2 = num;
				num = (short)613021156;
				switch (num2 == num)
				{
				}
				num = (short)1906900993;
				if (num != 0)
				{
				}
				num = (short)1909063680;
				if (num != 0)
				{
				}
				num = (short)1805516800;
				short num3 = num;
				return base.Layout as global::Motorola.Acp.PackUnpack.Ish.Layouts.CompositeLayout;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000E9CC File Offset: 0x0000CBCC
		public override int Length
		{
			get
			{
				short num = (short)611222766;
				short num2 = num;
				num = (short)927499502;
				switch (num2 == num)
				{
				}
				num = (short)1312948225;
				if (num != 0)
				{
				}
				num = (short)650248192;
				if (num != 0)
				{
				}
				num = (short)2085355520;
				short num3 = num;
				return (int)this.a.PackedData.Length;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000EA84 File Offset: 0x0000CC84
		public global::Motorola.Acp.PackUnpack.Ish.DataArea DataArea
		{
			get
			{
				short num = (short)616131466;
				short num2 = num;
				num = (short)1495362442;
				switch (num2 == num)
				{
				}
				num = (short)1738670081;
				if (num != 0)
				{
				}
				num = (short)1091371008;
				if (num != 0)
				{
				}
				num = (short)172425216;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x0400002F RID: 47
		private global::Motorola.Acp.PackUnpack.Ish.DataArea a;
	}
}
