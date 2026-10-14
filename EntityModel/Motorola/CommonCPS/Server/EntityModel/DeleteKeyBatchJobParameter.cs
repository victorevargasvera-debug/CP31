using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D1 RID: 209
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteKeyBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00091424 File Offset: 0x0008F624
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x000914D4 File Offset: 0x0008F6D4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.MatrixKey MatrixKey
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1310668965;
				short num2 = num;
				num = (short)161298597;
				switch (num2 == num)
				{
				}
				num = (short)1943863296;
				if (num != 0)
				{
				}
				num = (short)193789952;
				short num3 = num;
				num = (short)1534132225;
				if (num != 0)
				{
				}
				return this.<MatrixKey>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1533621058;
				short num2 = num;
				num = (short)592393026;
				switch (num2 == num)
				{
				}
				num = (short)1470431232;
				if (num != 0)
				{
				}
				num = (short)1307901952;
				short num3 = num;
				num = (short)617545729;
				if (num != 0)
				{
				}
				this.<MatrixKey>k__BackingField = value;
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00091584 File Offset: 0x0008F784
		public DeleteKeyBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey key) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.MatrixKey = key;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteKeys;
		}
	}
}
