using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000E0 RID: 224
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportTGSAFromCSVBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00094110 File Offset: 0x00092310
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x000941BC File Offset: 0x000923BC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1461779161;
				short num2 = num;
				num = (short)586480345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)222953472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1075970049;
				if (num != 0)
				{
				}
				num = (short)1463615488;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1170201447;
				short num2 = num;
				num = (short)1175706471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1861615616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)649854977;
				if (num != 0)
				{
				}
				num = (short)1462763520;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0009426C File Offset: 0x0009246C
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x0009431C File Offset: 0x0009251C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ImportTGSAFromCSVRequest CSVRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1771180911;
				short num2 = num;
				num = (short)1372197743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)391053312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)928317440;
				if (num != 0)
				{
				}
				num = (short)204603393;
				if (num != 0)
				{
				}
				return this.<CSVRequest>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)210367564;
				short num2 = num;
				num = (short)514585676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)669777920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1187577857;
				if (num != 0)
				{
				}
				num = (short)1190002688;
				if (num != 0)
				{
				}
				this.<CSVRequest>k__BackingField = value;
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000943CC File Offset: 0x000925CC
		public ImportTGSAFromCSVBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportTGSAFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.CSVRequest = csvRequest;
			this.ValidateEntitySet = validateEntitySet;
			base.WarningMessage = csvRequest.WarningMsg;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportCSV;
		}
	}
}
