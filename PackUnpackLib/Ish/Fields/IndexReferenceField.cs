using System;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Fields
{
	// Token: 0x02000077 RID: 119
	public class IndexReferenceField : global::Motorola.Acp.PackUnpack.Ish.Fields.Field, global::Motorola.Acp.PackUnpack.Ish.Fields.IFieldValue<ushort>
	{
		// Token: 0x06000376 RID: 886 RVA: 0x000459A0 File Offset: 0x00043BA0
		internal IndexReferenceField(global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout layout) : this(layout, global::Motorola.Acp.PackUnpack.Ish.IshItemName.Null, 0)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000459BC File Offset: 0x00043BBC
		internal IndexReferenceField(global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout layout, int type, int id, ushort index) : this(layout, new global::Motorola.Acp.PackUnpack.Ish.IshItemName(type, id), index)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000459DC File Offset: 0x00043BDC
		internal IndexReferenceField(global::Motorola.Acp.PackUnpack.Ish.Layouts.IndexReferenceFieldLayout layout, global::Motorola.Acp.PackUnpack.Ish.IshItemName name, ushort index) : base(layout)
		{
			this.name = name;
			this.index = index;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00045A00 File Offset: 0x00043C00
		internal override global::System.TypeCode TypeCode
		{
			get
			{
				short num = (short)600296931;
				short num2 = num;
				num = (short)1895747043;
				switch (num2 == num)
				{
				}
				num = (short)1835663360;
				short num3 = num;
				num = (short)2115436545;
				if (num != 0)
				{
				}
				num = (short)1109721088;
				if (num != 0)
				{
				}
				return global::System.TypeCode.UInt16;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00045AAC File Offset: 0x00043CAC
		internal global::Motorola.Acp.PackUnpack.Ish.IshItemName Name
		{
			get
			{
				short num = (short)1444544513;
				if (num != 0)
				{
				}
				num = (short)1234203219;
				short num2 = num;
				num = (short)1213624915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)614465536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)563675136;
				if (num != 0)
				{
				}
				return this.name;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00045B5C File Offset: 0x00043D5C
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00045C10 File Offset: 0x00043E10
		public ushort Value
		{
			get
			{
				short num = (short)177097690;
				short num2 = num;
				num = (short)684346330;
				switch (num2 == num)
				{
				}
				num = (short)2067595264;
				short num3 = num;
				num = (short)1908211712;
				if (num != 0)
				{
				}
				num = (short)1433665537;
				if (num != 0)
				{
				}
				return this.index;
			}
			set
			{
				short num = (short)1789838303;
				short num2 = num;
				num = (short)1804780511;
				switch (num2 == num)
				{
				}
				num = (short)1300692993;
				if (num != 0)
				{
				}
				num = (short)400490496;
				short num3 = num;
				num = (short)160366592;
				if (num != 0)
				{
				}
				this.index = value;
			}
		}

		// Token: 0x04000159 RID: 345
		private global::Motorola.Acp.PackUnpack.Ish.IshItemName name;

		// Token: 0x0400015A RID: 346
		private ushort index;
	}
}
