using System;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.DataExchange
{
	// Token: 0x02000086 RID: 134
	public class FieldExchange
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x00048364 File Offset: 0x00046564
		internal FieldExchange(global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout A_0, string A_1)
		{
			int a_ = 18;
			base..ctor();
			if (A_0 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얨쪪풬삮쒰잲", a_));
			}
			if (A_1 == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ud9a8\ud9aa슬\udfae풰솲솴캶\udaba킼\udabe", a_));
			}
			this.b = A_0;
			this.a = A_1;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x000483C0 File Offset: 0x000465C0
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout Layout
		{
			get
			{
				short num = (short)253872246;
				short num2 = num;
				num = (short)1619118198;
				switch (num2 == num)
				{
				}
				num = (short)598016001;
				if (num != 0)
				{
				}
				num = (short)218955776;
				short num3 = num;
				num = (short)929038336;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0004846C File Offset: 0x0004666C
		internal string PropertyName
		{
			get
			{
				short num = (short)1165688833;
				if (num != 0)
				{
				}
				num = (short)1472701255;
				short num2 = num;
				num = (short)1085186887;
				switch (num2 == num)
				{
				}
				num = (short)2048917504;
				short num3 = num;
				num = (short)2035286016;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0004851C File Offset: 0x0004671C
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x000485CC File Offset: 0x000467CC
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange Parent
		{
			get
			{
				short num = (short)313748534;
				short num2 = num;
				num = (short)178285622;
				switch (num2 == num)
				{
				}
				num = (short)1427898368;
				if (num != 0)
				{
				}
				num = (short)1456996352;
				short num3 = num;
				num = (short)1084227585;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)185271015;
				short num2 = num;
				num = (short)1019544295;
				switch (num2 == num)
				{
				}
				num = (short)1052704769;
				if (num != 0)
				{
				}
				num = (short)938606592;
				short num3 = num;
				num = (short)1049886720;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x04000168 RID: 360
		private string a;

		// Token: 0x04000169 RID: 361
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout b;

		// Token: 0x0400016A RID: 362
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange c;
	}
}
