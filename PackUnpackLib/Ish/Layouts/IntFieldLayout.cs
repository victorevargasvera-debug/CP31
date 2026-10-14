using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000060 RID: 96
	public class IntFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout
	{
		// Token: 0x0600032E RID: 814 RVA: 0x000432E4 File Offset: 0x000414E4
		public IntFieldLayout(string name, global::System.TypeCode typeCode, int byteOffset)
		{
			int a_ = 11;
			base..ctor(name, typeCode, byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Right);
			if (!global::Motorola.Acp.PackUnpack.Ish.TypeCodeInfo.d(typeCode))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("횡\udda3횥춧", a_));
			}
			this.a = global::Motorola.Acp.PackUnpack.Ish.TypeCodeInfo.e(typeCode);
			this.b = null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00043338 File Offset: 0x00041538
		public IntFieldLayout(string name, global::System.TypeCode typeCode, int byteOffset, int bitOffset, int bitSize)
		{
			int a_ = 19;
			this..ctor(name, typeCode, byteOffset);
			if (!global::Motorola.Acp.PackUnpack.Ish.TypeCodeInfo.d(typeCode))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udea9햫\udead햯\udbb3튵\uddb7", a_));
			}
			if (global::Motorola.Acp.PackUnpack.Ish.TypeCodeInfo.b(typeCode))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udea9햫\udead햯\udbb3튵\uddb7", a_));
			}
			if (bitOffset > global::Motorola.Acp.PackUnpack.Ish.TypeCodeInfo.g(typeCode))
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좩얫\udaadﾯ풱튳억\uddb7캹", a_));
			}
			if (bitSize >= 1)
			{
				if (bitSize <= global::Motorola.Acp.PackUnpack.Ish.TypeCodeInfo.f(typeCode))
				{
					if (typeCode != global::System.TypeCode.Int32)
					{
						if (typeCode != global::System.TypeCode.UInt32)
						{
							goto IL_C2;
						}
					}
					this.a = ((bitSize <= 24) ? 3 : 4);
					IL_C2:
					this.b = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask(bitOffset, bitSize);
					return;
				}
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좩얫\udaad\udbb1캳펵", a_));
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00043418 File Offset: 0x00041618
		public override int Size
		{
			get
			{
				short num = (short)1006307370;
				short num2 = num;
				num = (short)2121730090;
				switch (num2 == num)
				{
				}
				num = (short)1720254465;
				if (num != 0)
				{
				}
				num = (short)98631680;
				if (num != 0)
				{
				}
				num = (short)899284992;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000331 RID: 817 RVA: 0x000434C4 File Offset: 0x000416C4
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask Mask
		{
			get
			{
				short num = (short)138938423;
				short num2 = num;
				num = (short)1034815543;
				switch (num2 == num)
				{
				}
				num = (short)1028980737;
				if (num != 0)
				{
				}
				num = (short)937623552;
				if (num != 0)
				{
				}
				num = (short)1909325824;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00043574 File Offset: 0x00041774
		protected override int GetId()
		{
			short num = (short)1282015233;
			if (num != 0)
			{
			}
			num = (short)1155871266;
			short num2 = num;
			num = (short)1330328098;
			switch (num2 == num)
			{
			}
			num = (short)1606287360;
			if (num != 0)
			{
			}
			num = (short)1236008960;
			short num3 = num;
			int id = base.GetId();
			int num4;
			if (this.b != null)
			{
				num4 = this.b.BitOffset;
			}
			else
			{
				num4 = 7;
			}
			return (id & 536870911) | num4 << 29;
		}

		// Token: 0x0400012D RID: 301
		private int a;

		// Token: 0x0400012E RID: 302
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask b;
	}
}
