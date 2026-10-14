using System;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x0200006F RID: 111
	public class UclContactListLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout, global::Motorola.Acp.PackUnpack.Ish.Layouts.IUclListLayout
	{
		// Token: 0x0600035B RID: 859 RVA: 0x00044E78 File Offset: 0x00043078
		public UclContactListLayout(string name, global::Motorola.Acp.PackUnpack.Ish.UclContactListHeaderType headerType, global::Motorola.Acp.PackUnpack.Ish.UclContactListListletType listletType, bool hasReferencedTypes, global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType> signallingIshTypes, int listCapacity, int headerCapacity, int listletCapacity, int headerDataAreaSize, int listEntrySize)
		{
			int a_ = 18;
			base..ctor(name, headerType, listletType, listCapacity, headerCapacity, listletCapacity, headerDataAreaSize, listEntrySize);
			if (signallingIshTypes == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udaa8슪쪬솮킰\udfb2\ud9b4\udeb6ힸ\udcba첾꧀韂별럆곈룊", a_));
			}
			this.a = signallingIshTypes;
			this.b = hasReferencedTypes;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00044ECC File Offset: 0x000430CC
		internal global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType> SignallingIshTypes
		{
			get
			{
				short num = (short)1405518844;
				short num2 = num;
				num = (short)325288956;
				switch (num2 == num)
				{
				}
				num = (short)1981808640;
				short num3 = num;
				num = (short)41943040;
				if (num != 0)
				{
				}
				num = (short)426770433;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00044F7C File Offset: 0x0004317C
		public bool HasReferencedTypes
		{
			get
			{
				short num = (short)825050044;
				short num2 = num;
				num = (short)538657724;
				switch (num2 == num)
				{
				}
				num = (short)856489984;
				short num3 = num;
				num = (short)1188560897;
				if (num != 0)
				{
				}
				num = (short)1965752320;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x04000152 RID: 338
		private global::System.Collections.Generic.IList<global::Motorola.Acp.PackUnpack.Ish.UclCallIdListHeaderType> a;

		// Token: 0x04000153 RID: 339
		private bool b;
	}
}
