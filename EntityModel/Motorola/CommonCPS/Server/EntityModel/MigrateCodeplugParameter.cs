using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000C0 RID: 192
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateCodeplugParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0008E69C File Offset: 0x0008C89C
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x0008E74C File Offset: 0x0008C94C
		public global::Motorola.CommonCPS.Server.EntityModel.Codeplug Codeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)762283517;
				short num2 = num;
				num = (short)1531872765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2081030144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284688385;
				if (num != 0)
				{
				}
				num = (short)561643520;
				if (num != 0)
				{
				}
				return this.<Codeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2123019837;
				short num2 = num;
				num = (short)1684518461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)324993024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1247477761;
				if (num != 0)
				{
				}
				num = (short)1119748096;
				if (num != 0)
				{
				}
				this.<Codeplug>k__BackingField = value;
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0008E7FC File Offset: 0x0008C9FC
		public MigrateCodeplugParameter(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.Codeplug = codeplug;
			base.JobDescription = jobDescription;
		}
	}
}
