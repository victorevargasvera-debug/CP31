using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000DF RID: 223
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportTemplateBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00093F7C File Offset: 0x0009217C
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x0009402C File Offset: 0x0009222C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Template Template
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1495742174;
				short num2 = num;
				num = (short)296171230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2110717952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1371144193;
				if (num != 0)
				{
				}
				num = (short)886571008;
				if (num != 0)
				{
				}
				return this.<Template>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1383375223;
				short num2 = num;
				num = (short)791585143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)542572544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1066336257;
				if (num != 0)
				{
				}
				num = (short)1162805248;
				if (num != 0)
				{
				}
				this.<Template>k__BackingField = value;
			}
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000940E0 File Offset: 0x000922E0
		public ImportTemplateBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Template temp) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.Template = temp;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportTemplates;
		}
	}
}
