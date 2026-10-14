using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000C3 RID: 195
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateGroupParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0008EB34 File Offset: 0x0008CD34
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0008EBE0 File Offset: 0x0008CDE0
		public global::Motorola.CommonCPS.Server.EntityModel.Group Group
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1750532097;
				if (num != 0)
				{
				}
				num = (short)1546059776;
				short num2 = num;
				num = (short)522451437;
				short num3 = num;
				num = (short)1125120493;
				switch (num3 == num)
				{
				}
				num = (short)1154547712;
				if (num != 0)
				{
				}
				return this.<Group>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1454319379;
				short num2 = num;
				num = (short)1769023251;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1758134272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)940441600;
				if (num != 0)
				{
				}
				num = (short)1700069377;
				if (num != 0)
				{
				}
				this.<Group>k__BackingField = value;
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0008EC90 File Offset: 0x0008CE90
		public MigrateGroupParameter(global::Motorola.CommonCPS.Server.EntityModel.Group group, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.Group = group;
			base.JobDescription = jobDescription;
		}
	}
}
