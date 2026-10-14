using System;
using System.Runtime.CompilerServices;

namespace SpecialFeatures.FileOperations
{
	// Token: 0x02000115 RID: 277
	public class FileOperationReturnEventArgs
	{
		// Token: 0x06000F2F RID: 3887 RVA: 0x000033CA File Offset: 0x000015CA
		internal FileOperationReturnEventArgs(global::SpecialFeatures.FileOperations.DialogResult result, object data)
		{
			this.a = result;
			this.b = data;
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00150D04 File Offset: 0x0014EF04
		internal global::SpecialFeatures.FileOperations.DialogResult Result
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)241627077;
				short num2 = num;
				num = (short)1855451077;
				switch (num2 == num)
				{
				}
				num = (short)372178944;
				if (num != 0)
				{
				}
				num = (short)1712652289;
				if (num != 0)
				{
				}
				num = (short)263258112;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00150DB4 File Offset: 0x0014EFB4
		internal object Data
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1970803766;
				short num2 = num;
				num = (short)1459229750;
				switch (num2 == num)
				{
				}
				num = (short)1682767873;
				if (num != 0)
				{
				}
				num = (short)1582301184;
				if (num != 0)
				{
				}
				num = (short)312672256;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x040007F3 RID: 2035
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::SpecialFeatures.FileOperations.DialogResult a;

		// Token: 0x040007F4 RID: 2036
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly object b;
	}
}
