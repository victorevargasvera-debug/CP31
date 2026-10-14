using System;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Fields
{
	// Token: 0x02000078 RID: 120
	public class IntField<T> : global::Motorola.Acp.PackUnpack.Ish.Fields.Field, global::Motorola.Acp.PackUnpack.Ish.Fields.IFieldValue<T> where T : struct, global::System.IComparable<T>
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00045CC0 File Offset: 0x00043EC0
		internal IntField(global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout) : this(layout, default(T))
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00045CE0 File Offset: 0x00043EE0
		internal IntField(global::Motorola.Acp.PackUnpack.Ish.Layouts.IntFieldLayout layout, T value)
		{
			int a_ = 1;
			base..ctor(layout);
			if (layout.Type != global::System.Type.GetTypeCode(typeof(T)))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮙ햟횡", a_));
			}
			this.value = value;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00045D34 File Offset: 0x00043F34
		internal override global::System.TypeCode TypeCode
		{
			get
			{
				short num = (short)1922796291;
				short num2 = num;
				num = (short)479103747;
				switch (num2 == num)
				{
				}
				num = (short)749731841;
				if (num != 0)
				{
				}
				num = (short)1916141568;
				short num3 = num;
				num = (short)2021392384;
				if (num != 0)
				{
				}
				return base.Layout.Type;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00045DE8 File Offset: 0x00043FE8
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00045E98 File Offset: 0x00044098
		public T Value
		{
			get
			{
				short num = (short)1373386730;
				short num2 = num;
				num = (short)236009450;
				switch (num2 == num)
				{
				}
				num = (short)1543897089;
				if (num != 0)
				{
				}
				num = (short)412352512;
				short num3 = num;
				num = (short)2003238912;
				if (num != 0)
				{
				}
				return this.value;
			}
			set
			{
				short num = (short)1228006474;
				short num2 = num;
				num = (short)644080714;
				switch (num2 == num)
				{
				}
				num = (short)1876033537;
				if (num != 0)
				{
				}
				num = (short)867958784;
				short num3 = num;
				num = (short)964689920;
				if (num != 0)
				{
				}
				this.value = value;
			}
		}

		// Token: 0x0400015B RID: 347
		private T value;
	}
}
