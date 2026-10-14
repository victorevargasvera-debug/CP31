using System;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Fields
{
	// Token: 0x02000073 RID: 115
	public abstract class Field
	{
		// Token: 0x06000366 RID: 870 RVA: 0x00045380 File Offset: 0x00043580
		internal Field(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout layout)
		{
			int a_ = 19;
			base..ctor();
			if (layout == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("용춫힭\udfaf잱삳", a_));
			}
			this.layout = layout;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000367 RID: 871
		internal abstract global::System.TypeCode TypeCode { get; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000453BC File Offset: 0x000435BC
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout Layout
		{
			get
			{
				short num = (short)1862551591;
				short num2 = num;
				num = (short)1530218535;
				switch (num2 == num)
				{
				}
				num = (short)1886715904;
				short num3 = num;
				num = (short)1555431424;
				if (num != 0)
				{
				}
				num = (short)20381697;
				if (num != 0)
				{
				}
				return this.layout;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0004546C File Offset: 0x0004366C
		internal int Id
		{
			get
			{
				short num = (short)562586203;
				short num2 = num;
				num = (short)716399195;
				switch (num2 == num)
				{
				}
				num = (short)961806336;
				short num3 = num;
				num = (short)1043070977;
				if (num != 0)
				{
				}
				num = (short)971833344;
				if (num != 0)
				{
				}
				return this.layout.Id;
			}
		}

		// Token: 0x04000156 RID: 342
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout layout;
	}
}
