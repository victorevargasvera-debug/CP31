using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D7 RID: 215
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteTGSARecordBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x000921C0 File Offset: 0x000903C0
		// (set) Token: 0x06000DAF RID: 3503 RVA: 0x0009226C File Offset: 0x0009046C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> TGSARecords
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1855803776;
				short num2 = num;
				num = (short)1397120;
				switch (num2 == num)
				{
				}
				num = (short)1549926400;
				short num3 = num;
				num = (short)392364032;
				if (num != 0)
				{
				}
				num = (short)201785345;
				if (num != 0)
				{
				}
				return this.<TGSARecords>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1648227368;
				short num2 = num;
				num = (short)147518504;
				switch (num2 == num)
				{
				}
				num = (short)2115305472;
				short num3 = num;
				num = (short)1622736897;
				if (num != 0)
				{
				}
				num = (short)1550188544;
				if (num != 0)
				{
				}
				this.<TGSARecords>k__BackingField = value;
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0009231C File Offset: 0x0009051C
		public DeleteTGSARecordBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> tgsas) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.TGSARecords = tgsas;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteTGSARecords;
		}
	}
}
