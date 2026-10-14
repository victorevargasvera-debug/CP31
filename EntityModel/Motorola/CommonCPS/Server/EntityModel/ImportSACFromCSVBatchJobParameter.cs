using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000DE RID: 222
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportSACFromCSVBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00093C70 File Offset: 0x00091E70
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x00093D20 File Offset: 0x00091F20
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)127786979;
				short num2 = num;
				num = (short)1664868323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1832779776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1324810240;
				if (num != 0)
				{
				}
				num = (short)156958721;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1701902059;
				short num2 = num;
				num = (short)1530459883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196883968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1152647169;
				if (num != 0)
				{
				}
				num = (short)163577856;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00093DD4 File Offset: 0x00091FD4
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00093E84 File Offset: 0x00092084
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ImportSACFromCSVRequest CSVRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1195585672;
				short num2 = num;
				num = (short)1225011336;
				switch (num2 == num)
				{
				default:
				{
					num = (short)84934656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1058734081;
				if (num != 0)
				{
				}
				num = (short)1766850560;
				if (num != 0)
				{
				}
				return this.<CSVRequest>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1888401375;
				short num2 = num;
				num = (short)2061219807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2059141120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400307712;
				if (num != 0)
				{
				}
				num = (short)658440193;
				if (num != 0)
				{
				}
				this.<CSVRequest>k__BackingField = value;
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00093F38 File Offset: 0x00092138
		public ImportSACFromCSVBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportSACFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.CSVRequest = csvRequest;
			this.ValidateEntitySet = validateEntitySet;
			base.WarningMessage = csvRequest.WarningMsg;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportCSV;
		}
	}
}
