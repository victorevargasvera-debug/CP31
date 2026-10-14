using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000CD RID: 205
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrationPasswordParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00090C94 File Offset: 0x0008EE94
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x00090D44 File Offset: 0x0008EF44
		public global::Motorola.CommonCPS.Server.EntityModel.PBBPassword Password
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)943046083;
				short num2 = num;
				num = (short)1745731011;
				switch (num2 == num)
				{
				}
				num = (short)2062745601;
				if (num != 0)
				{
				}
				num = (short)1282277376;
				short num3 = num;
				num = (short)524812288;
				if (num != 0)
				{
				}
				return this.<Password>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1574582164;
				short num2 = num;
				num = (short)1131296660;
				switch (num2 == num)
				{
				}
				num = (short)2076114945;
				if (num != 0)
				{
				}
				num = (short)274137088;
				short num3 = num;
				num = (short)1873805312;
				if (num != 0)
				{
				}
				this.<Password>k__BackingField = value;
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00090DF4 File Offset: 0x0008EFF4
		public MigrationPasswordParameter(global::Motorola.CommonCPS.Server.EntityModel.PBBPassword password, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.Password = password;
			base.JobDescription = jobDescription;
		}
	}
}
