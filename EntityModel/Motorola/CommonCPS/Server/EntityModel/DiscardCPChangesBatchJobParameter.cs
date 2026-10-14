using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D8 RID: 216
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DiscardCPChangesBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0009234C File Offset: 0x0009054C
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x000923FC File Offset: 0x000905FC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)238286444;
				short num2 = num;
				num = (short)733869676;
				switch (num2 == num)
				{
				}
				num = (short)2120286208;
				short num3 = num;
				num = (short)175439873;
				if (num != 0)
				{
				}
				num = (short)144113664;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1515078074;
				short num2 = num;
				num = (short)122634682;
				switch (num2 == num)
				{
				}
				num = (short)673579008;
				short num3 = num;
				num = (short)1608187905;
				if (num != 0)
				{
				}
				num = (short)2028208128;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x000924AC File Offset: 0x000906AC
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x0009255C File Offset: 0x0009075C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2069299898;
				short num2 = num;
				num = (short)2027356858;
				switch (num2 == num)
				{
				}
				num = (short)208797696;
				short num3 = num;
				num = (short)683343873;
				if (num != 0)
				{
				}
				num = (short)1605173248;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1699851894;
				short num2 = num;
				num = (short)1265282678;
				switch (num2 == num)
				{
				}
				num = (short)1634271232;
				short num3 = num;
				num = (short)1308033025;
				if (num != 0)
				{
				}
				num = (short)518127616;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00092610 File Offset: 0x00090810
		public DiscardCPChangesBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.RadioUuid = radioUuid;
			this.ValidateEntitySet = validateEntitySet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DiscardCodeplugChanges;
		}
	}
}
