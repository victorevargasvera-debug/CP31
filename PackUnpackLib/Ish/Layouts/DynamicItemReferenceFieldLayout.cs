using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x0200005A RID: 90
	public sealed class DynamicItemReferenceFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout
	{
		// Token: 0x0600031C RID: 796 RVA: 0x00042C70 File Offset: 0x00040E70
		public DynamicItemReferenceFieldLayout(string name, int byteOffset, global::Motorola.Acp.PackUnpack.Ish.IshType[] ishTypes, global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship relationship, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout layout) : this(name, byteOffset, ishTypes, relationship)
		{
			this.c = layout;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00042C90 File Offset: 0x00040E90
		public DynamicItemReferenceFieldLayout(string name, int byteOffset, global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.IshType> ishTypes, global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship relationship)
		{
			int a_ = 9;
			base..ctor(name, global::System.TypeCode.Int32, byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Left);
			if (!global::System.Enum.IsDefined(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship), relationship))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("튟잡좣장\udca7쎩쎫삭쎯\udab1\uddb3욵", a_));
			}
			if (ishTypes == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즟톡첣톧\udaa9즫\uddad", a_));
			}
			this.a = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Motorola.Acp.PackUnpack.Ish.IshType>(ishTypes);
			this.b = relationship;
			this.c = null;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00042D14 File Offset: 0x00040F14
		public DynamicItemReferenceFieldLayout(string name, int byteOffset, global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.IshType> ishTypes, global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship relationship, bool setFieldLayout)
		{
			int a_ = 17;
			base..ctor(name, global::System.TypeCode.Int32, byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Left);
			if (!global::System.Enum.IsDefined(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship), relationship))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udaa7쾩삫쾭쒯\udbb1\udbb3\ud8b5쮷특햻캽", a_));
			}
			if (ishTypes == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솧\ud9a9쒫節즯슱톳억", a_));
			}
			this.a = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Motorola.Acp.PackUnpack.Ish.IshType>(ishTypes);
			this.b = relationship;
			this.c = this;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00042D98 File Offset: 0x00040F98
		internal global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.IshType> ReferencedIshTypes
		{
			get
			{
				short num = (short)1060151239;
				short num2 = num;
				num = (short)61054919;
				switch (num2 == num)
				{
				}
				num = (short)1216741376;
				if (num != 0)
				{
				}
				num = (short)1519255553;
				if (num != 0)
				{
				}
				num = (short)170131456;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00042E4C File Offset: 0x0004104C
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship Relationship
		{
			get
			{
				short num = (short)151763007;
				short num2 = num;
				num = (short)1249359935;
				switch (num2 == num)
				{
				}
				num = (short)1019281409;
				if (num != 0)
				{
				}
				num = (short)1376190464;
				if (num != 0)
				{
				}
				num = (short)393412608;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00042EFC File Offset: 0x000410FC
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout SelectorLayout
		{
			get
			{
				short num = (short)245555894;
				short num2 = num;
				num = (short)1548083894;
				switch (num2 == num)
				{
				}
				num = (short)553189377;
				if (num != 0)
				{
				}
				num = (short)2103574528;
				if (num != 0)
				{
				}
				num = (short)1454047232;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00042FAC File Offset: 0x000411AC
		public override int Size
		{
			get
			{
				short num = (short)295370753;
				if (num != 0)
				{
				}
				num = (short)1064141430;
				short num2 = num;
				num = (short)2075624054;
				switch (num2 == num)
				{
				}
				num = (short)1486749696;
				if (num != 0)
				{
				}
				num = (short)1096876032;
				short num3 = num;
				return 4;
			}
		}

		// Token: 0x0400011D RID: 285
		private global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.IshType> a;

		// Token: 0x0400011E RID: 286
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship b;

		// Token: 0x0400011F RID: 287
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout c;
	}
}
