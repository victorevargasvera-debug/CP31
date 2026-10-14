using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000CF RID: 207
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DeleteIPProgramSystemBatchJobParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00090FA4 File Offset: 0x0008F1A4
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00091054 File Offset: 0x0008F254
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem System
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)367656961;
				if (num != 0)
				{
				}
				num = (short)1008583127;
				short num2 = num;
				num = (short)1866908119;
				switch (num2 == num)
				{
				}
				num = (short)1837301760;
				short num3 = num;
				num = (short)503316480;
				if (num != 0)
				{
				}
				return this.<System>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1324971442;
				short num2 = num;
				num = (short)1419146674;
				switch (num2 == num)
				{
				}
				num = (short)150208513;
				if (num != 0)
				{
				}
				num = (short)1283653632;
				short num3 = num;
				num = (short)823853056;
				if (num != 0)
				{
				}
				this.<System>k__BackingField = value;
			}
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00091104 File Offset: 0x0008F304
		public DeleteIPProgramSystemBatchJobParameter(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			base.BatchJobContainerUuid = batchJobContainerUuid;
			this.System = sys;
			base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteSystems;
		}
	}
}
