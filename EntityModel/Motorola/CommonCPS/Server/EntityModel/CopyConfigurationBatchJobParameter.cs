using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000BD RID: 189
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class CopyConfigurationBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0008DD7C File Offset: 0x0008BF7C
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x0008DE2C File Offset: 0x0008C02C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.CopyConfigurationArg Arg
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)338588411;
				short num2 = num;
				num = (short)830239483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1877344256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)128647168;
				if (num != 0)
				{
				}
				num = (short)1413808129;
				if (num != 0)
				{
				}
				return this.<Arg>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)122157392;
				short num2 = num;
				num = (short)858913104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1967325184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784203776;
				if (num != 0)
				{
				}
				num = (short)2033451009;
				if (num != 0)
				{
				}
				this.<Arg>k__BackingField = value;
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0008DEDC File Offset: 0x0008C0DC
		public CopyConfigurationBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.CopyConfigurationArg arg) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CopyConfiguration;
			this.Arg = arg;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0008DF0C File Offset: 0x0008C10C
		public CopyConfigurationBatchJobParameter(global::System.Guid batchJobContainerUuid, string JobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			base.JobDescription = JobDescription;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CopyConfiguration;
		}
	}
}
