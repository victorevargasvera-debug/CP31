using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000049 RID: 73
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DiscardCPRFChangesBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x000442B0 File Offset: 0x000424B0
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00044360 File Offset: 0x00042560
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)570102484;
				short num2 = num;
				num = (short)1892618964;
				switch (num2 == num)
				{
				}
				num = (short)792330240;
				short num3 = num;
				num = (short)937689089;
				if (num != 0)
				{
				}
				num = (short)1562968064;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)732224363;
				short num2 = num;
				num = (short)732879723;
				switch (num2 == num)
				{
				}
				num = (short)1375731712;
				short num3 = num;
				num = (short)262733824;
				if (num != 0)
				{
				}
				num = (short)1676345345;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00044414 File Offset: 0x00042614
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x000444C4 File Offset: 0x000426C4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)831117451;
				short num2 = num;
				num = (short)1171249291;
				switch (num2 == num)
				{
				}
				num = (short)1375469568;
				short num3 = num;
				num = (short)1258553345;
				if (num != 0)
				{
				}
				num = (short)1057882112;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)404684801;
				if (num != 0)
				{
				}
				num = (short)1604975597;
				short num2 = num;
				num = (short)1732705261;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1386086400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1506672640;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00044574 File Offset: 0x00042774
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00044624 File Offset: 0x00042824
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> OriginalRadioFeature
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1337953573;
				short num2 = num;
				num = (short)992054565;
				switch (num2 == num)
				{
				}
				num = (short)1372782592;
				short num3 = num;
				num = (short)2070609920;
				if (num != 0)
				{
				}
				num = (short)727908353;
				if (num != 0)
				{
				}
				return this.<OriginalRadioFeature>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1076844670;
				short num2 = num;
				num = (short)567629950;
				switch (num2 == num)
				{
				}
				num = (short)1617297408;
				short num3 = num;
				num = (short)887160832;
				if (num != 0)
				{
				}
				num = (short)1264975873;
				if (num != 0)
				{
				}
				this.<OriginalRadioFeature>k__BackingField = value;
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000446D8 File Offset: 0x000428D8
		public DiscardCPRFChangesBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> originalRadioFeature) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.RadioUuid = radioUuid;
			this.ValidateEntitySet = validateEntitySet;
			this.OriginalRadioFeature = originalRadioFeature;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DiscardCodeplugChanges;
		}
	}
}
