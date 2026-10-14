using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000B7 RID: 183
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ApplyConfiguationBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0008C338 File Offset: 0x0008A538
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x0008C3E8 File Offset: 0x0008A5E8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid ConfigurationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1913920628;
				short num2 = num;
				num = (short)887757940;
				switch (num2 == num)
				{
				}
				num = (short)975437825;
				if (num != 0)
				{
				}
				num = (short)1207894016;
				short num3 = num;
				num = (short)633077760;
				if (num != 0)
				{
				}
				return this.<ConfigurationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1132724225;
				if (num != 0)
				{
				}
				num = (short)886101347;
				short num2 = num;
				num = (short)1733154147;
				switch (num2 == num)
				{
				}
				num = (short)2018508800;
				short num3 = num;
				num = (short)621215744;
				if (num != 0)
				{
				}
				this.<ConfigurationUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0008C494 File Offset: 0x0008A694
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x0008C540 File Offset: 0x0008A740
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyConfiguration RadioInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)70618732;
				short num2 = num;
				num = (short)156470892;
				switch (num2 == num)
				{
				}
				num = (short)1588396033;
				if (num != 0)
				{
				}
				num = (short)1187250176;
				short num3 = num;
				num = (short)1003552768;
				if (num != 0)
				{
				}
				return this.<RadioInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)575607944;
				short num2 = num;
				num = (short)847451272;
				switch (num2 == num)
				{
				}
				num = (short)1376780289;
				if (num != 0)
				{
				}
				num = (short)1168441344;
				short num3 = num;
				num = (short)360644608;
				if (num != 0)
				{
				}
				this.<RadioInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0008C5F4 File Offset: 0x0008A7F4
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x0008C6A4 File Offset: 0x0008A8A4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1845304734;
				short num2 = num;
				num = (short)2055019934;
				switch (num2 == num)
				{
				}
				num = (short)1318387713;
				if (num != 0)
				{
				}
				num = (short)2130313216;
				short num3 = num;
				num = (short)1291255808;
				if (num != 0)
				{
				}
				return this.<ValidateSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1693712385;
				if (num != 0)
				{
				}
				num = (short)844880244;
				short num2 = num;
				num = (short)2142624116;
				switch (num2 == num)
				{
				}
				num = (short)1720320000;
				short num3 = num;
				num = (short)43843584;
				if (num != 0)
				{
				}
				this.<ValidateSet>k__BackingField = value;
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0008C758 File Offset: 0x0008A958
		public ApplyConfiguationBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid configurationUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyConfiguration radioInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.ConfigurationUuid = configurationUuid;
			this.RadioInfo = radioInfo;
			this.ValidateSet = validateSet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyConfiguration;
		}
	}
}
