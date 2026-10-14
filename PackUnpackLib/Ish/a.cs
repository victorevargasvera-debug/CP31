using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200003E RID: 62
	internal class a : global::Motorola.Acp.PackUnpack.Ish.IshId
	{
		// Token: 0x06000274 RID: 628 RVA: 0x00038638 File Offset: 0x00036838
		internal a(int A_0, global::Motorola.Acp.PackUnpack.Ish.IshType A_1)
		{
			int a_ = 2;
			base..ctor(A_0);
			if (A_1 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쮞\ud8a0펢삤", a_));
			}
			this.a = A_1;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00038678 File Offset: 0x00036878
		private global::Motorola.Acp.PackUnpack.Ish.IshType a()
		{
			short num = (short)1253933517;
			short num2 = num;
			num = (short)1653244365;
			switch (num2 == num)
			{
			}
			num = (short)230096896;
			if (num != 0)
			{
			}
			num = (short)692256769;
			if (num != 0)
			{
			}
			num = (short)1326514176;
			short num3 = num;
			return this.a;
		}

		// Token: 0x040000E7 RID: 231
		private global::Motorola.Acp.PackUnpack.Ish.IshType a;
	}
}
