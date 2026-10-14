using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000066 RID: 102
	public class ItemReferenceFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceFieldLayout
	{
		// Token: 0x06000347 RID: 839 RVA: 0x00043F48 File Offset: 0x00042148
		public ItemReferenceFieldLayout(string name, int byteOffset, global::Motorola.Acp.PackUnpack.Ish.IshType ishType, global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship relationship)
		{
			int a_ = 8;
			base..ctor(name, global::System.TypeCode.Int32, byteOffset);
			if (!global::System.Enum.IsDefined(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship), relationship))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쒠쾢쒤펦삨쒪쎬\udcae\ud9b0\udab2어", a_));
			}
			if (ishType == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("튠쮢\udea6\ud9a8캪", a_));
			}
			this.a = ishType;
			this.b = relationship;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00043FC0 File Offset: 0x000421C0
		public override global::Motorola.Acp.PackUnpack.Ish.IshType ReferencedIshType
		{
			get
			{
				short num = (short)1075995376;
				short num2 = num;
				num = (short)845767408;
				switch (num2 == num)
				{
				}
				num = (short)1275592705;
				if (num != 0)
				{
				}
				num = (short)199491584;
				if (num != 0)
				{
				}
				num = (short)267190272;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00044070 File Offset: 0x00042270
		public override global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship Relationship
		{
			get
			{
				short num = (short)1395523585;
				if (num != 0)
				{
				}
				num = (short)1644133859;
				short num2 = num;
				num = (short)305036771;
				switch (num2 == num)
				{
				}
				num = (short)1800011776;
				if (num != 0)
				{
				}
				num = (short)1952645120;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00044120 File Offset: 0x00042320
		public override int Size
		{
			get
			{
				short num = (short)379675409;
				short num2 = num;
				num = (short)1052467985;
				switch (num2 == num)
				{
				}
				num = (short)601227264;
				if (num != 0)
				{
				}
				num = (short)64815105;
				if (num != 0)
				{
				}
				num = (short)394788864;
				short num3 = num;
				return 4;
			}
		}

		// Token: 0x0400013C RID: 316
		private global::Motorola.Acp.PackUnpack.Ish.IshType a;

		// Token: 0x0400013D RID: 317
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship b;
	}
}
