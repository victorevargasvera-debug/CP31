using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D5 RID: 213
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteSACRecordBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00091D3C File Offset: 0x0008FF3C
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00091DEC File Offset: 0x0008FFEC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary SACRecord
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1637909735;
				short num2 = num;
				num = (short)1575191783;
				switch (num2 == num)
				{
				}
				num = (short)103874560;
				short num3 = num;
				num = (short)1393426432;
				if (num != 0)
				{
				}
				num = (short)800653313;
				if (num != 0)
				{
				}
				return this.<SACRecord>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2005346159;
				short num2 = num;
				num = (short)270804847;
				switch (num2 == num)
				{
				}
				num = (short)1603665920;
				short num3 = num;
				num = (short)1391919105;
				if (num != 0)
				{
				}
				num = (short)1400045568;
				if (num != 0)
				{
				}
				this.<SACRecord>k__BackingField = value;
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00091E9C File Offset: 0x0009009C
		public DeleteSACRecordBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary sac) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.SACRecord = sac;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteSystems;
		}
	}
}
