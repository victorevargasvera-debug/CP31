using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000BB RID: 187
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class CompleteJobBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x0008D4C4 File Offset: 0x0008B6C4
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x0008D574 File Offset: 0x0008B774
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.EntitySummary EntitySummary
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1114263954;
				short num2 = num;
				num = (short)1662538130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2113142784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584005120;
				if (num != 0)
				{
				}
				num = (short)1615265793;
				if (num != 0)
				{
				}
				return this.<EntitySummary>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1421103327;
				short num2 = num;
				num = (short)29249759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)582352896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1667891201;
				if (num != 0)
				{
				}
				num = (short)936247296;
				if (num != 0)
				{
				}
				this.<EntitySummary>k__BackingField = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0008D620 File Offset: 0x0008B820
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x0008D6D0 File Offset: 0x0008B8D0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ClientInfo ClientInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)307993308;
				short num2 = num;
				num = (short)906992348;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2065891328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2021588992;
				if (num != 0)
				{
				}
				num = (short)1261830145;
				if (num != 0)
				{
				}
				return this.<ClientInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1675534916;
				short num2 = num;
				num = (short)278897220;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1061814272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1964638209;
				if (num != 0)
				{
				}
				num = (short)444661760;
				if (num != 0)
				{
				}
				this.<ClientInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0008D780 File Offset: 0x0008B980
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x0008D82C File Offset: 0x0008BA2C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1825968196;
				short num2 = num;
				num = (short)1722683460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)410714112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)840171521;
				if (num != 0)
				{
				}
				num = (short)1343553536;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1453986607;
				short num2 = num;
				num = (short)636621615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1476591616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)489226241;
				if (num != 0)
				{
				}
				num = (short)1907294208;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0008D8DC File Offset: 0x0008BADC
		public CompleteJobBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.EntitySummary = entitySummary;
			this.ValidateEntitySet = validateEntitySet;
			base.JobDescription = entitySummary.Name;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CompleteRadio;
		}
	}
}
