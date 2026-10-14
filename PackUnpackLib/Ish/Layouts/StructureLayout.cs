using System;
using System.Collections.ObjectModel;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000020 RID: 32
	public abstract class StructureLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.Layout
	{
		// Token: 0x0600013B RID: 315 RVA: 0x0001FCAC File Offset: 0x0001DEAC
		protected StructureLayout(string name, global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayoutType layoutType, params global::Motorola.Acp.PackUnpack.Ish.IshType[] ishTypes)
		{
			int a_ = 0;
			base..ctor(name);
			if (ishTypes == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺖ즜토욢횤", a_));
			}
			if (ishTypes.Length == 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺖ즜토욢횤", a_));
			}
			this.a = layoutType;
			this.b = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Motorola.Acp.PackUnpack.Ish.IshType>(ishTypes);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0001FD10 File Offset: 0x0001DF10
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::Motorola.Acp.PackUnpack.Ish.IshType> IshTypes
		{
			get
			{
				short num = (short)795627201;
				short num2 = num;
				num = (short)547049153;
				switch (num2 == num)
				{
				}
				num = (short)1863778304;
				short num3 = num;
				num = (short)2132738049;
				if (num != 0)
				{
				}
				num = (short)1693777920;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayoutType LayoutType
		{
			get
			{
				short num = (short)735509410;
				short num2 = num;
				num = (short)1583348642;
				switch (num2 == num)
				{
				}
				num = (short)1464729600;
				short num3 = num;
				num = (short)239796224;
				if (num != 0)
				{
				}
				num = (short)1576730625;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600013E RID: 318
		public abstract int Size { get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600013F RID: 319
		public abstract int MaxSize { get; }

		// Token: 0x04000065 RID: 101
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayoutType a;

		// Token: 0x04000066 RID: 102
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Motorola.Acp.PackUnpack.Ish.IshType> b;
	}
}
