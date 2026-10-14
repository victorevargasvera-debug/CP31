using System;
using System.IO;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Fields
{
	// Token: 0x02000075 RID: 117
	public class ByteArrayField : global::Motorola.Acp.PackUnpack.Ish.Fields.Field, global::Motorola.Acp.PackUnpack.Ish.Fields.IFieldValue<global::System.IO.MemoryStream>
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00045520 File Offset: 0x00043720
		internal ByteArrayField(global::Motorola.Acp.PackUnpack.Ish.Layouts.ByteArrayFieldLayout layout) : this(layout, new global::System.IO.MemoryStream())
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0004553C File Offset: 0x0004373C
		internal ByteArrayField(global::Motorola.Acp.PackUnpack.Ish.Layouts.ByteArrayFieldLayout layout, global::System.IO.MemoryStream value) : base(layout)
		{
			this.Value = value;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00045558 File Offset: 0x00043758
		internal override global::System.TypeCode TypeCode
		{
			get
			{
				short num = (short)730923009;
				if (num != 0)
				{
				}
				num = (short)2073951275;
				short num2 = num;
				num = (short)843054123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1441333248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)179896320;
				if (num != 0)
				{
				}
				return global::System.TypeCode.Object;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00045600 File Offset: 0x00043800
		// (set) Token: 0x06000370 RID: 880 RVA: 0x000456AC File Offset: 0x000438AC
		public global::System.IO.MemoryStream Value
		{
			get
			{
				short num = (short)1241166151;
				short num2 = num;
				num = (short)1246212423;
				switch (num2 == num)
				{
				}
				num = (short)1444544512;
				short num3 = num;
				num = (short)1128923137;
				if (num != 0)
				{
				}
				num = (short)592052224;
				if (num != 0)
				{
				}
				return this.value;
			}
			set
			{
				short num = (short)307859617;
				short num2 = num;
				num = (short)1348047009;
				switch (num2 == num)
				{
				}
				num = (short)2076049408;
				short num3 = num;
				num = (short)369819648;
				if (num != 0)
				{
				}
				num = (short)1534590977;
				if (num != 0)
				{
				}
				this.value = value;
			}
		}

		// Token: 0x04000157 RID: 343
		private global::System.IO.MemoryStream value;
	}
}
