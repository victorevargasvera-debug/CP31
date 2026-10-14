using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000005 RID: 5
	[global::System.Serializable]
	public sealed class DBMigrationErrorAttribute : global::System.Attribute
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002B70 File Offset: 0x00000D70
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002C1C File Offset: 0x00000E1C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFatal
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)539033601;
				if (num != 0)
				{
				}
				num = (short)2064098319;
				short num2 = num;
				num = (short)632071183;
				switch (num2 == num)
				{
				}
				num = (short)286916608;
				if (num != 0)
				{
				}
				num = (short)1795424256;
				short num3 = num;
				return this.<IsFatal>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1108905680;
				short num2 = num;
				num = (short)1113689808;
				switch (num2 == num)
				{
				}
				num = (short)496304129;
				if (num != 0)
				{
				}
				num = (short)1068498944;
				if (num != 0)
				{
				}
				num = (short)1372389376;
				short num3 = num;
				this.<IsFatal>k__BackingField = value;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002CCC File Offset: 0x00000ECC
		public DBMigrationErrorAttribute(bool isFatal)
		{
			this.IsFatal = isFatal;
		}
	}
}
