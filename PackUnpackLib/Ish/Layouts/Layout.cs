using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000057 RID: 87
	public abstract class Layout : global::Motorola.Acp.PackUnpack.Ish.Layouts.ILayout
	{
		// Token: 0x06000318 RID: 792 RVA: 0x00042B60 File Offset: 0x00040D60
		protected Layout(string name)
		{
			int a_ = 5;
			base..ctor();
			if (name == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾝ춟잡", a_));
			}
			if (name == string.Empty)
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾝ춟잡", a_));
			}
			this.a = name;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00042BC0 File Offset: 0x00040DC0
		public string Name
		{
			get
			{
				short num = (short)2024603649;
				if (num != 0)
				{
				}
				num = (short)1241424208;
				short num2 = num;
				num = (short)1812898128;
				switch (num2 == num)
				{
				}
				num = (short)1666121728;
				if (num != 0)
				{
				}
				num = (short)1512177664;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x0400011C RID: 284
		private string a;
	}
}
