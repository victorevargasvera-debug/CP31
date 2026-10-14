using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000BC RID: 188
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteConfigurationBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0008D91C File Offset: 0x0008BB1C
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x0008D9CC File Offset: 0x0008BBCC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid ConfigUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1672901203;
				short num2 = num;
				num = (short)965243475;
				switch (num2 == num)
				{
				default:
				{
					num = (short)454426624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348782593;
				if (num != 0)
				{
				}
				num = (short)1172897792;
				if (num != 0)
				{
				}
				return this.<ConfigUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)942332675;
				short num2 = num;
				num = (short)1275845379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1070268416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2082275328;
				if (num != 0)
				{
				}
				num = (short)851640321;
				if (num != 0)
				{
				}
				this.<ConfigUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0008DA7C File Offset: 0x0008BC7C
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x0008DB2C File Offset: 0x0008BD2C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1422652685;
				short num2 = num;
				num = (short)1953428749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1528299520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1487994880;
				if (num != 0)
				{
				}
				num = (short)554303489;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)176587421;
				short num2 = num;
				num = (short)547914397;
				switch (num2 == num)
				{
				default:
				{
					num = (short)474415104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1721958401;
				if (num != 0)
				{
				}
				num = (short)1287979008;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0008DBE0 File Offset: 0x0008BDE0
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x0008DC90 File Offset: 0x0008BE90
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> SharedSets
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)948713741;
				short num2 = num;
				num = (short)1071986957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1110376448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)366608384;
				if (num != 0)
				{
				}
				num = (short)180879361;
				if (num != 0)
				{
				}
				return this.<SharedSets>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)528809985;
				if (num != 0)
				{
				}
				num = (short)693305344;
				short num2 = num;
				num = (short)1174679196;
				short num3 = num;
				num = (short)389361308;
				switch (num3 == num)
				{
				}
				num = (short)811466752;
				if (num != 0)
				{
				}
				this.<SharedSets>k__BackingField = value;
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0008DD44 File Offset: 0x0008BF44
		public DeleteConfigurationBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid cfgUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.ConfigUuid = cfgUuid;
			this.ValidateEntitySet = validateSet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteConfiguration;
		}
	}
}
