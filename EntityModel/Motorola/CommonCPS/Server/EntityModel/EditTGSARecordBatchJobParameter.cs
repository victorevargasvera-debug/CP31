using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000DA RID: 218
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class EditTGSARecordBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x00092AB0 File Offset: 0x00090CB0
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x00092B60 File Offset: 0x00090D60
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid TGSARecordUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1175051556;
				short num2 = num;
				num = (short)1980226852;
				switch (num2 == num)
				{
				}
				num = (short)619053056;
				short num3 = num;
				num = (short)1825046529;
				if (num != 0)
				{
				}
				num = (short)2141913088;
				if (num != 0)
				{
				}
				return this.<TGSARecordUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1312303786;
				short num2 = num;
				num = (short)1303390890;
				switch (num2 == num)
				{
				}
				num = (short)826605568;
				short num3 = num;
				num = (short)1665400833;
				if (num != 0)
				{
				}
				num = (short)1383989248;
				if (num != 0)
				{
				}
				this.<TGSARecordUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00092C10 File Offset: 0x00090E10
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x00092CC0 File Offset: 0x00090EC0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TGSARecordFieldType, object>> ChangedFieldValePair
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1043006785;
				short num2 = num;
				num = (short)1580860737;
				switch (num2 == num)
				{
				}
				num = (short)291700736;
				short num3 = num;
				num = (short)1182531585;
				if (num != 0)
				{
				}
				num = (short)2067988480;
				if (num != 0)
				{
				}
				return this.<ChangedFieldValePair>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)466747393;
				if (num != 0)
				{
				}
				num = (short)1991750239;
				short num2 = num;
				num = (short)980267615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1134821376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)523173888;
				if (num != 0)
				{
				}
				this.<ChangedFieldValePair>k__BackingField = value;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00092D70 File Offset: 0x00090F70
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00092E20 File Offset: 0x00091020
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet ValidateEntitySet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)463142913;
				if (num != 0)
				{
				}
				num = (short)92133716;
				short num2 = num;
				num = (short)648403284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)938278912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1658781696;
				if (num != 0)
				{
				}
				return this.<ValidateEntitySet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)38469633;
				if (num != 0)
				{
				}
				num = (short)517392927;
				short num2 = num;
				num = (short)254790175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2138308608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)599588864;
				if (num != 0)
				{
				}
				this.<ValidateEntitySet>k__BackingField = value;
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00092ED0 File Offset: 0x000910D0
		public EditTGSARecordBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid tgsaUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TGSARecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.TGSARecordUuid = tgsaUuid;
			this.ChangedFieldValePair = changedFieldValePair;
			this.ValidateEntitySet = validateEntitySet;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteSystems;
		}
	}
}
