using System;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Fields
{
	// Token: 0x0200007B RID: 123
	public class StringField : global::Motorola.Acp.PackUnpack.Ish.Fields.Field, global::Motorola.Acp.PackUnpack.Ish.Fields.IFieldValue<string>
	{
		// Token: 0x0600038E RID: 910 RVA: 0x000464B8 File Offset: 0x000446B8
		internal StringField(global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout layout) : this(layout, string.Empty)
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000464D4 File Offset: 0x000446D4
		internal StringField(global::Motorola.Acp.PackUnpack.Ish.Layouts.StringFieldLayout layout, string value)
		{
			int a_ = 5;
			base..ctor(layout);
			if (value == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﾝ첟힡솣", a_));
			}
			this.value = value;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00046514 File Offset: 0x00044714
		internal override global::System.TypeCode TypeCode
		{
			get
			{
				short num = (short)1425469926;
				short num2 = num;
				num = (short)2078798310;
				switch (num2 == num)
				{
				}
				num = (short)1443037185;
				if (num != 0)
				{
				}
				num = (short)1807286272;
				short num3 = num;
				num = (short)645660672;
				if (num != 0)
				{
				}
				return global::System.TypeCode.String;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000391 RID: 913 RVA: 0x000465C0 File Offset: 0x000447C0
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00046670 File Offset: 0x00044870
		public string Value
		{
			get
			{
				short num = (short)1713029830;
				short num2 = num;
				num = (short)1010811590;
				switch (num2 == num)
				{
				}
				num = (short)461963264;
				if (num != 0)
				{
				}
				num = (short)1854210048;
				short num3 = num;
				num = (short)312606721;
				if (num != 0)
				{
				}
				return this.value;
			}
			set
			{
				short num = (short)1381394736;
				short num2 = num;
				num = (short)754477360;
				switch (num2 == num)
				{
				}
				num = (short)873857025;
				if (num != 0)
				{
				}
				num = (short)897449984;
				short num3 = num;
				num = (short)852230144;
				if (num != 0)
				{
				}
				this.value = value;
			}
		}

		// Token: 0x0400015E RID: 350
		private string value;
	}
}
