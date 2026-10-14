using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000023 RID: 35
	public class CompositeLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00020A24 File Offset: 0x0001EC24
		public CompositeLayout(string name, global::Motorola.Acp.PackUnpack.Ish.CompositeType ishType, int size)
		{
			int a_ = 12;
			base..ctor(name, global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayoutType.Composite, new global::Motorola.Acp.PackUnpack.Ish.IshType[]
			{
				ishType
			});
			this.a = new global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout(this, global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.Composite, name + global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("莢욦\udda8쪪趬쎰횲풴鞶\udaba쒼킾듀럂", a_), size);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00020A70 File Offset: 0x0001EC70
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout DataAreaLayout
		{
			get
			{
				short num = (short)764251253;
				short num2 = num;
				num = (short)1733266549;
				switch (num2 == num)
				{
				}
				num = (short)935788544;
				if (num != 0)
				{
				}
				num = (short)1929183233;
				if (num != 0)
				{
				}
				num = (short)822542336;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00020B20 File Offset: 0x0001ED20
		internal global::Motorola.Acp.PackUnpack.Ish.CompositeType CompositeType
		{
			get
			{
				short num = (short)782551551;
				short num2 = num;
				num = (short)1527761407;
				switch (num2 == num)
				{
				}
				num = (short)1474625537;
				if (num != 0)
				{
				}
				num = (short)1699872768;
				if (num != 0)
				{
				}
				num = (short)1010434048;
				short num3 = num;
				return base.IshTypes[0] as global::Motorola.Acp.PackUnpack.Ish.CompositeType;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00020BDC File Offset: 0x0001EDDC
		public override int Size
		{
			get
			{
				short num = (short)694729918;
				short num2 = num;
				num = (short)1619311806;
				switch (num2 == num)
				{
				}
				num = (short)110362625;
				if (num != 0)
				{
				}
				num = (short)1495334912;
				if (num != 0)
				{
				}
				num = (short)1640431616;
				short num3 = num;
				return this.a.Size;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00020C94 File Offset: 0x0001EE94
		public override int MaxSize
		{
			get
			{
				short num = (short)226426881;
				if (num != 0)
				{
				}
				num = (short)677143637;
				short num2 = num;
				num = (short)1183212629;
				switch (num2 == num)
				{
				}
				num = (short)594149376;
				if (num != 0)
				{
				}
				num = (short)1446838272;
				short num3 = num;
				return this.Size;
			}
		}

		// Token: 0x04000067 RID: 103
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout a;
	}
}
