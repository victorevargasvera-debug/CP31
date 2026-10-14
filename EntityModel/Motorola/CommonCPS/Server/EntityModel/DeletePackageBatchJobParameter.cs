using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D2 RID: 210
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeletePackageBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x000915B4 File Offset: 0x0008F7B4
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00091660 File Offset: 0x0008F860
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.EntitySummary EntitySummary
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)84567637;
				short num2 = num;
				num = (short)689858133;
				switch (num2 == num)
				{
				}
				num = (short)756613120;
				short num3 = num;
				num = (short)207093761;
				if (num != 0)
				{
				}
				num = (short)1079771136;
				if (num != 0)
				{
				}
				return this.<EntitySummary>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)15882263;
				short num2 = num;
				num = (short)1240881175;
				switch (num2 == num)
				{
				}
				num = (short)677576704;
				short num3 = num;
				num = (short)1428684801;
				if (num != 0)
				{
				}
				num = (short)617414656;
				if (num != 0)
				{
				}
				this.<EntitySummary>k__BackingField = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00091714 File Offset: 0x0008F914
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x000917C0 File Offset: 0x0008F9C0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1599174037;
				short num2 = num;
				num = (short)604730773;
				switch (num2 == num)
				{
				}
				num = (short)929497088;
				short num3 = num;
				num = (short)296943617;
				if (num != 0)
				{
				}
				num = (short)1743388672;
				if (num != 0)
				{
				}
				return this.<ValidateSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1509791541;
				short num2 = num;
				num = (short)1320916789;
				switch (num2 == num)
				{
				}
				num = (short)559611904;
				short num3 = num;
				num = (short)1768161280;
				if (num != 0)
				{
				}
				num = (short)823787521;
				if (num != 0)
				{
				}
				this.<ValidateSet>k__BackingField = value;
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0009186C File Offset: 0x0008FA6C
		public DeletePackageBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.EntitySummary = entitySummary;
			this.ValidateSet = validateSet;
			base.JobDescription = entitySummary.Name;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeletePackage;
		}
	}
}
