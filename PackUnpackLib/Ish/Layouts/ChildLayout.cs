using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000068 RID: 104
	public abstract class ChildLayout<T> : global::Motorola.Acp.PackUnpack.Ish.Layouts.Layout, global::Motorola.Acp.PackUnpack.Ish.Layouts.IChildLayout<T>, global::Motorola.Acp.PackUnpack.Ish.Layouts.ILayout where T : global::Motorola.Acp.PackUnpack.Ish.Layouts.Layout
	{
		// Token: 0x0600034C RID: 844 RVA: 0x000441CC File Offset: 0x000423CC
		protected ChildLayout(string name, T parent)
		{
			int a_ = 1;
			base..ctor(name);
			if (parent == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮙﮝ캟횡", a_));
			}
			this.a = parent;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00044210 File Offset: 0x00042410
		public T Parent
		{
			get
			{
				short num = (short)1037828097;
				if (num != 0)
				{
				}
				num = (short)1033484273;
				short num2 = num;
				num = (short)639809521;
				switch (num2 == num)
				{
				}
				num = (short)302317568;
				if (num != 0)
				{
				}
				num = (short)1840578560;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x0400013E RID: 318
		private T a;
	}
}
