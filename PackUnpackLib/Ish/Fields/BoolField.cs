using System;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Fields
{
	// Token: 0x02000072 RID: 114
	public class BoolField : global::Motorola.Acp.PackUnpack.Ish.Fields.Field, global::Motorola.Acp.PackUnpack.Ish.Fields.IFieldValue<bool>
	{
		// Token: 0x06000361 RID: 865 RVA: 0x00045144 File Offset: 0x00043344
		internal BoolField(global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout layout) : this(layout, false)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0004515C File Offset: 0x0004335C
		internal BoolField(global::Motorola.Acp.PackUnpack.Ish.Layouts.BoolFieldLayout layout, bool value) : base(layout)
		{
			this.value = value;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00045178 File Offset: 0x00043378
		internal override global::System.TypeCode TypeCode
		{
			get
			{
				short num = (short)171468465;
				short num2 = num;
				num = (short)1920886449;
				switch (num2 == num)
				{
				}
				num = (short)1944059904;
				short num3 = num;
				num = (short)1493368833;
				if (num != 0)
				{
				}
				num = (short)1577058304;
				if (num != 0)
				{
				}
				return global::System.TypeCode.Boolean;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00045220 File Offset: 0x00043420
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000452D0 File Offset: 0x000434D0
		public bool Value
		{
			get
			{
				short num = (short)31199989;
				short num2 = num;
				num = (short)803017461;
				switch (num2 == num)
				{
				}
				num = (short)1586888704;
				short num3 = num;
				num = (short)1120665601;
				if (num != 0)
				{
				}
				num = (short)1741422592;
				if (num != 0)
				{
				}
				return this.value;
			}
			set
			{
				short num = (short)1038083985;
				short num2 = num;
				num = (short)988800913;
				switch (num2 == num)
				{
				}
				num = (short)1338900480;
				short num3 = num;
				num = (short)515309569;
				if (num != 0)
				{
				}
				num = (short)1341259776;
				if (num != 0)
				{
				}
				this.value = value;
			}
		}

		// Token: 0x04000155 RID: 341
		private bool value;
	}
}
