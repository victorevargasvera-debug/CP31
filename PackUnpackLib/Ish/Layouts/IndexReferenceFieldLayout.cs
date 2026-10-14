using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x0200005D RID: 93
	public class IndexReferenceFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceFieldLayout
	{
		// Token: 0x06000327 RID: 807 RVA: 0x00043058 File Offset: 0x00041258
		public IndexReferenceFieldLayout(string name, int byteOffset, global::Motorola.Acp.PackUnpack.Ish.IshType referencedIshType, global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship relationship)
		{
			int a_ = 15;
			base..ctor(name, global::System.TypeCode.Object, byteOffset);
			if (referencedIshType == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풥춧첩즫\udcad햯\udcb1ힳ펵\udcb7쾻횽钿믁듃ꏅ", a_));
			}
			if (!(referencedIshType is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풥춧첩즫\udcad햯\udcb1ힳ펵\udcb7쾻횽钿믁듃ꏅ", a_));
			}
			this.a = referencedIshType;
			this.b = relationship;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000430C0 File Offset: 0x000412C0
		public override global::Motorola.Acp.PackUnpack.Ish.IshType ReferencedIshType
		{
			get
			{
				short num = (short)696273043;
				short num2 = num;
				num = (short)1574389907;
				switch (num2 == num)
				{
				}
				num = (short)1408892928;
				if (num != 0)
				{
				}
				num = (short)1659699201;
				if (num != 0)
				{
				}
				num = (short)984612864;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00043170 File Offset: 0x00041370
		public override global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship Relationship
		{
			get
			{
				short num = (short)1258794598;
				short num2 = num;
				num = (short)592555622;
				switch (num2 == num)
				{
				}
				num = (short)1791557633;
				if (num != 0)
				{
				}
				num = (short)1397227520;
				if (num != 0)
				{
				}
				num = (short)2145386496;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00043220 File Offset: 0x00041420
		public override int Size
		{
			get
			{
				short num = (short)2008872613;
				short num2 = num;
				num = (short)638908069;
				switch (num2 == num)
				{
				}
				num = (short)1105985536;
				if (num != 0)
				{
				}
				num = (short)1365311489;
				if (num != 0)
				{
				}
				num = (short)806551552;
				short num3 = num;
				return 6;
			}
		}

		// Token: 0x04000123 RID: 291
		private global::Motorola.Acp.PackUnpack.Ish.IshType a;

		// Token: 0x04000124 RID: 292
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship b;
	}
}
