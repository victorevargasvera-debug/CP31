using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000062 RID: 98
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MatrixPreSharedKey : global::Motorola.CommonCPS.Server.EntityModel.MatrixKey
	{
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x000545A0 File Offset: 0x000527A0
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00054654 File Offset: 0x00052854
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[global::System.Runtime.Serialization.DataMember]
		public string Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)478479290;
				short num2 = num;
				num = (short)1996751802;
				switch (num2 == num)
				{
				}
				num = (short)1642004481;
				if (num != 0)
				{
				}
				num = (short)1127350272;
				short num3 = num;
				num = (short)1359020032;
				if (num != 0)
				{
				}
				return this.<Value>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)906362881;
				if (num != 0)
				{
				}
				num = (short)1570459200;
				short num2 = num;
				num = (short)1885883968;
				switch (num2 == num)
				{
				}
				num = (short)597229568;
				short num3 = num;
				num = (short)57606144;
				if (num != 0)
				{
				}
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00054704 File Offset: 0x00052904
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x000547B4 File Offset: 0x000529B4
		[global::System.Runtime.Serialization.DataMember]
		public string ValueEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)262366052;
				short num2 = num;
				num = (short)177824612;
				switch (num2 == num)
				{
				}
				num = (short)937689089;
				if (num != 0)
				{
				}
				num = (short)1246429184;
				short num3 = num;
				num = (short)898564096;
				if (num != 0)
				{
				}
				return this.<ValueEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1842932188;
				short num2 = num;
				num = (short)939190748;
				switch (num2 == num)
				{
				}
				num = (short)2119172097;
				if (num != 0)
				{
				}
				num = (short)131465216;
				short num3 = num;
				num = (short)940834816;
				if (num != 0)
				{
				}
				this.<ValueEncrypt>k__BackingField = value;
			}
		}
	}
}
