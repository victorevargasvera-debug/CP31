using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000DD RID: 221
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportRadioFromCSVBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00093970 File Offset: 0x00091B70
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00093A20 File Offset: 0x00091C20
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)440763062;
				short num2 = num;
				num = (short)1254261430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1331494912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2098135041;
				if (num != 0)
				{
				}
				num = (short)2041249792;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1367277569;
				if (num != 0)
				{
				}
				num = (short)619970560;
				short num2 = num;
				num = (short)2137211606;
				short num3 = num;
				num = (short)2115584726;
				switch (num3 == num)
				{
				}
				num = (short)1225195520;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00093AD0 File Offset: 0x00091CD0
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x00093B80 File Offset: 0x00091D80
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest CSVRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)325255169;
				if (num != 0)
				{
				}
				num = (short)1002504192;
				short num2 = num;
				num = (short)1250712739;
				short num3 = num;
				num = (short)1975737507;
				switch (num3 == num)
				{
				}
				num = (short)1205796864;
				if (num != 0)
				{
				}
				return this.<CSVRequest>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1611379822;
				short num2 = num;
				num = (short)638104686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)327876608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2135490560;
				if (num != 0)
				{
				}
				num = (short)1052639233;
				if (num != 0)
				{
				}
				this.<CSVRequest>k__BackingField = value;
			}
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00093C2C File Offset: 0x00091E2C
		public ImportRadioFromCSVBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.CSVRequest = csvRequest;
			this.ValidateEntitySet = validateEntitySet;
			base.WarningMessage = csvRequest.WarningMsg;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportCSV;
		}
	}
}
