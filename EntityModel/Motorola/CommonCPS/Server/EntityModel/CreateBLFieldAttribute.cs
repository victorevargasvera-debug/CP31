using System;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000104 RID: 260
	[global::System.AttributeUsage(global::System.AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public class CreateBLFieldAttribute : global::System.Attribute
	{
		// Token: 0x06000F8E RID: 3982 RVA: 0x000A6A00 File Offset: 0x000A4C00
		public CreateBLFieldAttribute()
		{
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000A6A14 File Offset: 0x000A4C14
		public CreateBLFieldAttribute(bool createBLField)
		{
			this.a = createBLField;
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x000A6A30 File Offset: 0x000A4C30
		public bool CreateBLField
		{
			get
			{
				short num = (short)360054249;
				short num2 = num;
				num = (short)65863145;
				switch (num2 == num)
				{
				}
				num = (short)1573126144;
				if (num != 0)
				{
				}
				num = (short)2140995585;
				if (num != 0)
				{
				}
				num = (short)1082458112;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x04000747 RID: 1863
		private bool a;
	}
}
