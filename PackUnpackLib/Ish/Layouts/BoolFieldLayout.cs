using System;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x0200004F RID: 79
	public class BoolFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout
	{
		// Token: 0x060002FA RID: 762 RVA: 0x000417A4 File Offset: 0x0003F9A4
		public BoolFieldLayout(string name, int byteOffset, int bitOffset) : base(name, global::System.TypeCode.Boolean, byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Right)
		{
			this.a = bitOffset;
			this.b = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask(bitOffset, 1);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000417D0 File Offset: 0x0003F9D0
		protected override int GetId()
		{
			short num = (short)503075616;
			short num2 = num;
			num = (short)1388008224;
			switch (num2 == num)
			{
			}
			num = (short)413728769;
			if (num != 0)
			{
			}
			num = (short)1814036480;
			if (num != 0)
			{
			}
			num = (short)1038352384;
			short num3 = num;
			return (base.GetId() & 536870911) | this.b.BitOffset << 29;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00041894 File Offset: 0x0003FA94
		public override int Size
		{
			get
			{
				short num = (short)1732444161;
				if (num != 0)
				{
				}
				num = (short)1105437382;
				short num2 = num;
				num = (short)1099211462;
				switch (num2 == num)
				{
				}
				num = (short)2008481792;
				if (num != 0)
				{
				}
				num = (short)1550778368;
				short num3 = num;
				return 1;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00041940 File Offset: 0x0003FB40
		public int BitOffset
		{
			get
			{
				short num = (short)650007102;
				short num2 = num;
				num = (short)1292718654;
				switch (num2 == num)
				{
				}
				num = (short)327876609;
				if (num != 0)
				{
				}
				num = (short)1796669440;
				if (num != 0)
				{
				}
				num = (short)5242880;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000419EC File Offset: 0x0003FBEC
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask Mask
		{
			get
			{
				short num = (short)1681653761;
				if (num != 0)
				{
				}
				num = (short)1808678363;
				short num2 = num;
				num = (short)1786854875;
				switch (num2 == num)
				{
				}
				num = (short)1535639552;
				if (num != 0)
				{
				}
				num = (short)1849425920;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x04000100 RID: 256
		private int a;

		// Token: 0x04000101 RID: 257
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask b;
	}
}
