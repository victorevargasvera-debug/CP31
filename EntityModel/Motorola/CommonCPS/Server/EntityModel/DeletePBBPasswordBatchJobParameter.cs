using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000D3 RID: 211
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeletePBBPasswordBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x000918B0 File Offset: 0x0008FAB0
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x00091960 File Offset: 0x0008FB60
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid PBBPasswordUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)641126817;
				short num2 = num;
				num = (short)36557217;
				switch (num2 == num)
				{
				}
				num = (short)1160445952;
				short num3 = num;
				num = (short)1150746625;
				if (num != 0)
				{
				}
				num = (short)198443008;
				if (num != 0)
				{
				}
				return this.<PBBPasswordUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)805765121;
				if (num != 0)
				{
				}
				num = (short)1039838110;
				short num2 = num;
				num = (short)918858654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2116747264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)807862272;
				if (num != 0)
				{
				}
				this.<PBBPasswordUuid>k__BackingField = value;
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00091A10 File Offset: 0x0008FC10
		public DeletePBBPasswordBatchJobParameter(global::System.Guid batchJobContainerUuid, global::System.Guid passwordUuid, string passwordID) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.PBBPasswordUuid = passwordUuid;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeletePBBPassword;
			base.JobDescription = passwordID;
		}
	}
}
