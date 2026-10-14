using System;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000051 RID: 81
	public class ByteArrayFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout
	{
		// Token: 0x06000308 RID: 776 RVA: 0x00042088 File Offset: 0x00040288
		public ByteArrayFieldLayout(string name, int byteOffset) : base(name, global::System.TypeCode.Object, byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Right)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000420A0 File Offset: 0x000402A0
		public override int Size
		{
			get
			{
				short num = (short)1902967289;
				short num2 = num;
				num = (short)2129263097;
				switch (num2 == num)
				{
				}
				num = (short)61210624;
				if (num != 0)
				{
				}
				num = (short)569049089;
				if (num != 0)
				{
				}
				num = (short)399310848;
				short num3 = num;
				return 1;
			}
		}
	}
}
