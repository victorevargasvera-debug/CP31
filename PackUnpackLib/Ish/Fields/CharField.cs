using System;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Fields
{
	// Token: 0x02000076 RID: 118
	public class CharField : global::Motorola.Acp.PackUnpack.Ish.Fields.Field, global::Motorola.Acp.PackUnpack.Ish.Fields.IFieldValue<char>
	{
		// Token: 0x06000371 RID: 881 RVA: 0x0004575C File Offset: 0x0004395C
		internal CharField(global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout layout) : this(layout, '\0')
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00045774 File Offset: 0x00043974
		internal CharField(global::Motorola.Acp.PackUnpack.Ish.Layouts.CharFieldLayout layout, char value) : base(layout)
		{
			this.value = value;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00045790 File Offset: 0x00043990
		internal override global::System.TypeCode TypeCode
		{
			get
			{
				short num = (short)1161208973;
				short num2 = num;
				num = (short)417703053;
				switch (num2 == num)
				{
				}
				num = (short)1126891520;
				short num3 = num;
				num = (short)482803713;
				if (num != 0)
				{
				}
				num = (short)1885863936;
				if (num != 0)
				{
				}
				return global::System.TypeCode.Char;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00045838 File Offset: 0x00043A38
		// (set) Token: 0x06000375 RID: 885 RVA: 0x000458EC File Offset: 0x00043AEC
		public char Value
		{
			get
			{
				short num = (short)1639534070;
				short num2 = num;
				num = (short)2056801782;
				switch (num2 == num)
				{
				}
				num = (short)470679552;
				short num3 = num;
				num = (short)406388737;
				if (num != 0)
				{
				}
				num = (short)1045430272;
				if (num != 0)
				{
				}
				return this.value;
			}
			set
			{
				short num = (short)1973775689;
				short num2 = num;
				num = (short)1717005641;
				switch (num2 == num)
				{
				}
				num = (short)1266352128;
				short num3 = num;
				num = (short)1124335617;
				if (num != 0)
				{
				}
				num = (short)1542258688;
				if (num != 0)
				{
				}
				this.value = value;
			}
		}

		// Token: 0x04000158 RID: 344
		private char value;
	}
}
