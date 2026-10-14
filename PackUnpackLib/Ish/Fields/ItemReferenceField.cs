using System;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Fields
{
	// Token: 0x0200007A RID: 122
	public class ItemReferenceField : global::Motorola.Acp.PackUnpack.Ish.Fields.Field, global::Motorola.Acp.PackUnpack.Ish.Fields.IFieldValue<global::Motorola.Acp.PackUnpack.Ish.IshItemName>
	{
		// Token: 0x06000387 RID: 903 RVA: 0x00046234 File Offset: 0x00044434
		internal ItemReferenceField(global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout layout) : this(layout, default(global::Motorola.Acp.PackUnpack.Ish.IshItemName))
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00046254 File Offset: 0x00044454
		internal ItemReferenceField(global::Motorola.Acp.PackUnpack.Ish.Layouts.ItemReferenceFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.IshItemName value) : base(layout)
		{
			this.value = value;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00046270 File Offset: 0x00044470
		internal ItemReferenceField(global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout layout) : this(layout, default(global::Motorola.Acp.PackUnpack.Ish.IshItemName))
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00046290 File Offset: 0x00044490
		internal ItemReferenceField(global::Motorola.Acp.PackUnpack.Ish.Layouts.DynamicItemReferenceFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.IshItemName value) : base(layout)
		{
			this.value = value;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600038B RID: 907 RVA: 0x000462AC File Offset: 0x000444AC
		internal override global::System.TypeCode TypeCode
		{
			get
			{
				short num = (short)523637614;
				short num2 = num;
				num = (short)522982254;
				switch (num2 == num)
				{
				}
				num = (short)311754753;
				if (num != 0)
				{
				}
				num = (short)1016070144;
				short num3 = num;
				num = (short)2071724032;
				if (num != 0)
				{
				}
				return global::System.TypeCode.Int32;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00046358 File Offset: 0x00044558
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00046408 File Offset: 0x00044608
		public global::Motorola.Acp.PackUnpack.Ish.IshItemName Value
		{
			get
			{
				short num = (short)1641240459;
				short num2 = num;
				num = (short)112875403;
				switch (num2 == num)
				{
				}
				num = (short)1928986625;
				if (num != 0)
				{
				}
				num = (short)81068032;
				short num3 = num;
				num = (short)1612840960;
				if (num != 0)
				{
				}
				return this.value;
			}
			set
			{
				short num = (short)1966691089;
				short num2 = num;
				num = (short)377967377;
				switch (num2 == num)
				{
				}
				num = (short)657653760;
				if (num != 0)
				{
				}
				num = (short)1245577216;
				short num3 = num;
				num = (short)516685825;
				if (num != 0)
				{
				}
				this.value = value;
			}
		}

		// Token: 0x0400015D RID: 349
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName value;
	}
}
